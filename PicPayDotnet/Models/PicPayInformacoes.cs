using System.Text.Json.Serialization;

namespace PicPayDotnet.Models
{
    public class PicPayInformacoes // PicPay deixou em aberto essa struct, pode colocar qualquer coisa
    {
        [JsonPropertyName("observacao"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? Observacao { get; set; }
    }
}