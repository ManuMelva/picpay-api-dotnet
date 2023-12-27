using System.Text.Json.Serialization;

namespace PicPayDotnet.Models
{
    public class PicPayNotifications
    {
        [JsonPropertyName("disablePush"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public bool DesativarPush { get; set; }
        [JsonPropertyName("disableEmail"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public bool DesativarEmail { get; set; }
    }
}