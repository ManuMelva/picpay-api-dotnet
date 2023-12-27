using System.Text.Json.Serialization;

namespace PicPayDotnet.Models
{
    public class PicPayErros
    {
        [JsonPropertyName("field"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Campo { get; set; }
        [JsonPropertyName("message"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Mensagem { get; set; }
    }
}