using System.Text.Json.Serialization;

namespace PicPayDotnet.Models
{
    public class PicPayPaymentRequest
    {
        [JsonPropertyName("referenceId"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? ReferenceId { get; set; }
        [JsonPropertyName("callbackUrl"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? CallbackUrl { get; set; }
        [JsonPropertyName("returnUrl"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? ReturnUrl { get; set; }
        [JsonPropertyName("value"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public decimal Valor { get; set; }
        [JsonPropertyName("expiresAt"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public DateTime ExpiraEm { get; set; }
        [JsonPropertyName("channel"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? Channel { get; set; }
        [JsonPropertyName("purchaseMode"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? PurchaseMode { get; set; }
        [JsonPropertyName("buyer"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public PicPayBuyer? Buyer { get; set; }
        [JsonPropertyName("notification"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public PicPayNotifications? Notification { get; set; }
        [JsonPropertyName("softDescriptor"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? SoftDescriptor { get; set; }
        [JsonPropertyName("autoCapture"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public bool AutoCapture { get; set; }
        [JsonPropertyName("amount"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public decimal Amount { get; set; }
        [JsonPropertyName("authorizationId"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? AuthorizationId { get; set; }
        [JsonPropertyName("additionalInfo"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public PicPayInformacoes? InfoAdicional { get; set; }
    }
}