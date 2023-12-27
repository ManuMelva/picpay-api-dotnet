using System.Text.Json.Serialization;

namespace PicPayDotnet.Models
{
    public class PicPayPaymentResponse
    {
        [JsonPropertyName("authorizationId"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? AuthorizationId { get; set; }
        [JsonPropertyName("referenceId"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? ReferenceId { get; set; }
        [JsonPropertyName("paymentUrl"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? PaymentUrl { get; set; }
        [JsonPropertyName("expiresAt"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public DateTime ExpiraEm { get; set; }
        [JsonPropertyName("qrcode"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public PicPayQRCode? Qrcode { get; set; }
        [JsonPropertyName("id"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? Id { get; set; }
        [JsonPropertyName("status"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? Status { get; set; }
        [JsonPropertyName("summary"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public PicPayStatus? StatusPagamento { get; set; }
        [JsonPropertyName("message"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? Message { get; set; }
        [JsonPropertyName("errors"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public List<PicPayErros>? Errors { get; set; }
        [JsonPropertyName("cancellationId"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? CancellationId { get; set; }
    }
}