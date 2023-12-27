using PicPayDotnet.Interfaces;

namespace PicPayDotnet.Config
{
    public class PicPayConfiguration : IPicPayConfiguration
    {
        public required string URL { get; set; }
        public required string PicPayToken { get; set; }
    }
}