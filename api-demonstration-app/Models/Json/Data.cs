using Newtonsoft.Json;

namespace api_demonstration_app.Models.Json
{
    public class Data
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("legal_form")]
        public string LegalForm { get; set; }

        [JsonProperty("target")]
        public string Target { get; set; }

        [JsonProperty("verification_center_id")]
        public int VerificationCenterId { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }

        [JsonProperty("embeded_cp")]
        public int EmbededCp { get; set; }

        [JsonProperty("is_gkfh")]
        public int IsGkfh { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("is_foreigner")]
        public int IsForeigner { get; set; }

        [JsonProperty("is_minor")]
        public int IsMinor { get; set; }

        [JsonProperty("is_foreign_company")]
        public int IsForeignCompany { get; set; }

        [JsonProperty("no_color_scan")]
        public int NoColorScan { get; set; }

        [JsonProperty("crypto_provider")]
        public string CryptoProvider { get; set; }

        [JsonProperty("issue_date")]
        public object IssueDate { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("refill_reason")]
        public string RefillReason { get; set; }

        [JsonProperty("period")]
        public int Period { get; set; }

        [JsonProperty("exportable_key")]
        public int ExportableKey { get; set; }

        [JsonProperty("container_name")]
        public object ContainerName { get; set; }

        [JsonProperty("valid_to")]
        public object ValidTo { get; set; }

        [JsonProperty("serial_number")]
        public object SerialNumber { get; set; }

        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        [JsonProperty("work_mode_id")]
        public string WorkModeId { get; set; }

        [JsonProperty("prolongation_id")]
        public object ProlongationId { get; set; }

        [JsonProperty("container_info")]
        public object ContainerInfo { get; set; }

        [JsonProperty("identification_kind")]
        public int IdentificationKind { get; set; }

        [JsonProperty("platforms")]
        public List<string> Platforms { get; set; }

        [JsonProperty("platform_ids")]
        public string PlatformIds { get; set; }

        [JsonProperty("platform_names")]
        public string PlatformNames { get; set; }

        [JsonProperty("certificate_form")]
        public string CertificateForm { get; set; }

        [JsonProperty("mdss_username")]
        public string MdssUsername { get; set; }
    }
}
