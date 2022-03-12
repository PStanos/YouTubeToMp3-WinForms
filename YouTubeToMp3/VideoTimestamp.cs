namespace YouTubeToMp3
{
   public class VideoTimestamp
   {
      public VideoTimestamp( decimal hours, decimal minutes, decimal seconds )
      {
         Hours = hours;
         Minutes = minutes;
         Seconds = seconds;
      }

      public decimal Hours
      {
         get;
      }

      public decimal Minutes
      {
         get;
      }

      public decimal Seconds
      {
         get;
      }

      public override string ToString()
      {
         return $"{Hours}:{Minutes}:{Seconds:F4}";
      }
   }
}
