using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace YouTubeToMp3
{
   public partial class SoundBiteGeneratorForm : Form
   {
      public SoundBiteGeneratorForm()
      {
         InitializeComponent();
      }

      private async void btnConvert_Click( object sender, EventArgs e )
      {
         Enabled = false;

         try
         {
            string startTimestamp = GetStartTimestamp();
            string endTimestamp = GetEndTimestamp();
            string fileNameNoExtension = string.IsNullOrWhiteSpace( txtFileName.Text ) ? Guid.NewGuid().ToString() : txtFileName.Text;
            string fileName = $"{fileNameNoExtension}.mp3";
            string destinationPath = Directory.Exists( txtDestinationDirectory.Text ) ? Path.Combine( txtDestinationDirectory.Text, fileName ) : fileName;

            Process youtubeDlProcess;
            ProcessStartInfo youtubeDlProcessInfo;
            youtubeDlProcessInfo = new ProcessStartInfo( "youtube-dl.exe", $"-g {txtYouTubeUrl.Text}" );
            youtubeDlProcessInfo.RedirectStandardOutput = true;
            youtubeDlProcessInfo.CreateNoWindow = true;

            youtubeDlProcess = Process.Start( youtubeDlProcessInfo );
            await youtubeDlProcess.WaitForExitAsync();
            string youtubeDlOutput = youtubeDlProcess.StandardOutput.ReadToEnd();

            string audioStreamUrl = youtubeDlOutput.Split( '\n' )[1];

            Process ffmpegProcess;
            ProcessStartInfo ffmpegProcessInfo;
            ffmpegProcessInfo = new ProcessStartInfo( "ffmpeg.exe", $"-ss {startTimestamp} -to {endTimestamp} -i {audioStreamUrl} \"{destinationPath}\"" );
            ffmpegProcessInfo.CreateNoWindow = true;
            ffmpegProcess = Process.Start( ffmpegProcessInfo );
            await ffmpegProcess.WaitForExitAsync();
         }
         finally
         {
            Enabled = true;
         }
      }

      private string GetStartTimestamp()
      {
         return BuildTimestampString( numSTHours.Value, numSTMinutes.Value, numSTSeconds.Value );
      }

      private string GetEndTimestamp()
      {
         return BuildTimestampString( numETHours.Value, numETMinutes.Value, numETSeconds.Value );
      }

      private string BuildTimestampString( decimal hours, decimal minutes, decimal seconds )
      {
         return $"{hours}:{minutes}:{seconds:F4}";
      }

      private void btnSelectDirectory_Click( object sender, EventArgs e )
      {
         var folderBrowser = new FolderBrowserDialog();
         DialogResult result = folderBrowser.ShowDialog();

         if ( result == DialogResult.OK )
         {
            txtDestinationDirectory.Text = folderBrowser.SelectedPath;
         }
      }
   }
}
