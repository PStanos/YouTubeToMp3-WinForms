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

      private void btnConvert_Click( object sender, EventArgs e )
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

         youtubeDlProcess = Process.Start( youtubeDlProcessInfo );
         youtubeDlProcess.WaitForExit();
         string youtubeDlOutput = youtubeDlProcess.StandardOutput.ReadToEnd();

         string audioStreamUrl = youtubeDlOutput.Split( '\n' )[1];

         Process ffmpegProcess;
         ProcessStartInfo ffmpegProcessInfo;
         ffmpegProcessInfo = new ProcessStartInfo( "ffmpeg.exe", $"-ss {startTimestamp} -to {endTimestamp} -i {audioStreamUrl} \"{destinationPath}\"" );
         ffmpegProcessInfo.RedirectStandardOutput = true;
         ffmpegProcessInfo.RedirectStandardError = true;
         ffmpegProcess = Process.Start( ffmpegProcessInfo );
         ffmpegProcess.WaitForExit();
         // FFmpeg outputs to standard error for regular shit? Cool.
         string ffmpegError = ffmpegProcess.StandardError.ReadToEnd();

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
