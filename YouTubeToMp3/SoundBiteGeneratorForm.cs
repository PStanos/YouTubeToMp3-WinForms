using System;
using System.IO;
using System.Windows.Forms;

namespace YouTubeToMp3
{
   public partial class SoundBiteGeneratorForm : Form
   {
      private YouTubeToMp3Converter _converter;

      public SoundBiteGeneratorForm()
      {
         InitializeComponent();

         _converter = new YouTubeToMp3Converter();
      }

      private async void btnConvert_Click( object sender, EventArgs e )
      {
         Enabled = false;

         try
         {
            if ( !Uri.TryCreate( txtYouTubeUrl.Text, UriKind.Absolute, out Uri youTubeUrl ) )
            {
               return;
            }

            VideoTimestamp startTimestamp = GetStartTimestamp();
            VideoTimestamp endTimestamp = GetEndTimestamp();
            string fileNameNoExtension = string.IsNullOrWhiteSpace( txtFileName.Text ) ? Guid.NewGuid().ToString() : txtFileName.Text;
            string fileName = $"{fileNameNoExtension}.mp3";
            string destinationPath = Directory.Exists( txtDestinationDirectory.Text ) ? Path.Combine( txtDestinationDirectory.Text, fileName ) : fileName;

            await _converter.ConvertAsync( youTubeUrl, startTimestamp, endTimestamp, destinationPath );
         }
         finally
         {
            Enabled = true;
         }
      }

      private VideoTimestamp GetStartTimestamp()
      {
         return BuildTimestampString( numSTHours.Value, numSTMinutes.Value, numSTSeconds.Value );
      }

      private VideoTimestamp GetEndTimestamp()
      {
         return BuildTimestampString( numETHours.Value, numETMinutes.Value, numETSeconds.Value );
      }

      private VideoTimestamp BuildTimestampString( decimal hours, decimal minutes, decimal seconds )
      {
         return new VideoTimestamp( hours, minutes, seconds );
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
