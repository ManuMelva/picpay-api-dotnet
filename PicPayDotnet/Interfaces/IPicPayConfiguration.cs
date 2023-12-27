namespace PicPayDotnet.Interfaces
{
    public interface IPicPayConfiguration
    {
        string URL { get; set; }
        string PicPayToken { get; set; }
    }
}