using System.Text.Json.Serialization;

namespace PicPayDotnet.Models
{
    public class PicPayBuyer
    {
        [JsonPropertyName("firstName"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? Nome { get; set; }
        [JsonPropertyName("lastName"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? Sobrenome { get; set; }
        [JsonPropertyName("document"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? Documento { get; set; }
        [JsonPropertyName("email"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? Email { get; set; }
        [JsonPropertyName("phone"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? Telefone { get; set; }
    }
}