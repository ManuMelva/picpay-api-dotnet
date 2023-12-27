using System.Text.Json.Serialization;

namespace PicPayDotnet.Models
{
    public class PicPayStatus
    {
        [JsonPropertyName("created"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public short Criado { get; set; }
        [JsonPropertyName("paid"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public short Pago { get; set; }
        [JsonPropertyName("refunded"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public short Reembolsado { get; set; }
        [JsonPropertyName("expired"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public short Expirado { get; set; }
        [JsonPropertyName("analysis"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public short EmAnalise { get; set; }
        [JsonPropertyName("completed"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public short Finalizado { get; set; }
    }
}