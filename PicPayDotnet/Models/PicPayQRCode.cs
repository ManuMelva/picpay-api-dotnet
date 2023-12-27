using System.Text.Json.Serialization;

namespace PicPayDotnet.Models
{
    public class PicPayQRCode
    {
        [JsonPropertyName("content"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? Content { get; set; }
        [JsonPropertyName("base64"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? Base64 { get; set; }
    }
}