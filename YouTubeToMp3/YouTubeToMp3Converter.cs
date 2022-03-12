using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace YouTubeToMp3
{
   public class YouTubeToMp3Converter
   {
      public async Task ConvertAsync( Uri youTubeUrl, VideoTimestamp startTimestamp, VideoTimestamp endTimestamp, string absoluteFilePath )
      {
         Process youtubeDlProcess;
         ProcessStartInfo youtubeDlProcessInfo;
         youtubeDlProcessInfo = new ProcessStartInfo( "youtube-dl.exe", $"-g {youTubeUrl.AbsoluteUri}" );
         youtubeDlProcessInfo.RedirectStandardOutput = true;
         youtubeDlProcessInfo.CreateNoWindow = true;

         youtubeDlProcess = Process.Start( youtubeDlProcessInfo );
         await youtubeDlProcess.WaitForExitAsync();
         string youtubeDlOutput = youtubeDlProcess.StandardOutput.ReadToEnd();

         string audioStreamUrl = youtubeDlOutput.Split( '\n' )[1];

         Process ffmpegProcess;
         ProcessStartInfo ffmpegProcessInfo;
         ffmpegProcessInfo = new ProcessStartInfo( "ffmpeg.exe", $"-ss {startTimestamp} -to {endTimestamp} -i {audioStreamUrl} \"{absoluteFilePath}\"" );
         ffmpegProcessInfo.CreateNoWindow = true;
         ffmpegProcess = Process.Start( ffmpegProcessInfo );
         await ffmpegProcess.WaitForExitAsync();
      }
   }
}
