using System;
using System.IO;
using System.Linq;
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
               MessageBox.Show( "Bad YouTube URL", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
               return;
            }

            VideoTimestamp startTimestamp = GetStartTimestamp();
            VideoTimestamp endTimestamp = GetEndTimestamp();

            if ( !( startTimestamp < endTimestamp ) )
            {
               MessageBox.Show( "Start timestamp is after end timestamp", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
               return;
            }

            string fileNameNoExtension = string.IsNullOrWhiteSpace( txtFileName.Text ) ? Guid.NewGuid().ToString() : txtFileName.Text;

            if ( string.IsNullOrWhiteSpace( fileNameNoExtension ) || fileNameNoExtension.ToCharArray().Any( c => Path.GetInvalidFileNameChars().Contains( c ) ) )
            {
               MessageBox.Show( "Invalid file name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
               return;
            }

            string fileName = $"{fileNameNoExtension}.mp3";
            bool outputDirExists = Directory.Exists( txtDestinationDirectory.Text );
            string destinationPath = outputDirExists ? Path.Combine( txtDestinationDirectory.Text, fileName ) : fileName;

            if ( !outputDirExists )
            {
               MessageBox.Show( "Output directory does not exist or was left empty. Using current working directory...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }

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
