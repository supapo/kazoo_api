/* 
 * Crossbar
 *
 * The Crossbar APIs
 *
 * OpenAPI spec version: v2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Schema for kazoo_convert.convertapi system_config
    /// </summary>
    [DataContract]
    public partial class SystemConfigKazooConvertConvertapi :  IEquatable<SystemConfigKazooConvertConvertapi>, IValidatableObject
    {
        /// <summary>
        /// Which pdf version files will be produced by convertapi service
        /// </summary>
        /// <value>Which pdf version files will be produced by convertapi service</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PdfVersionEnum
        {
            
            /// <summary>
            /// Enum _2 for value: 1.2
            /// </summary>
            [EnumMember(Value = "1.2")]
            _2 = 1,
            
            /// <summary>
            /// Enum _3 for value: 1.3
            /// </summary>
            [EnumMember(Value = "1.3")]
            _3 = 2,
            
            /// <summary>
            /// Enum _4 for value: 1.4
            /// </summary>
            [EnumMember(Value = "1.4")]
            _4 = 3,
            
            /// <summary>
            /// Enum _5 for value: 1.5
            /// </summary>
            [EnumMember(Value = "1.5")]
            _5 = 4,
            
            /// <summary>
            /// Enum _6 for value: 1.6
            /// </summary>
            [EnumMember(Value = "1.6")]
            _6 = 5,
            
            /// <summary>
            /// Enum _7 for value: 1.7
            /// </summary>
            [EnumMember(Value = "1.7")]
            _7 = 6
        }

        /// <summary>
        /// Which pdf version files will be produced by convertapi service
        /// </summary>
        /// <value>Which pdf version files will be produced by convertapi service</value>
        [DataMember(Name="pdf_version", EmitDefaultValue=false)]
        public PdfVersionEnum? PdfVersion { get; set; }
        /// <summary>
        /// For which files types may be called openoffice
        /// </summary>
        /// <value>For which files types may be called openoffice</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TryOpenofficeEnum
        {
            
            /// <summary>
            /// Enum Formsofficefilesalso for value: for_msoffice_files_also
            /// </summary>
            [EnumMember(Value = "for_msoffice_files_also")]
            Formsofficefilesalso = 1,
            
            /// <summary>
            /// Enum Foropenofficefilesonly for value: for_openoffice_files_only
            /// </summary>
            [EnumMember(Value = "for_openoffice_files_only")]
            Foropenofficefilesonly = 2,
            
            /// <summary>
            /// Enum Never for value: never
            /// </summary>
            [EnumMember(Value = "never")]
            Never = 3
        }

        /// <summary>
        /// For which files types may be called openoffice
        /// </summary>
        /// <value>For which files types may be called openoffice</value>
        [DataMember(Name="try_openoffice", EmitDefaultValue=false)]
        public TryOpenofficeEnum? TryOpenoffice { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemConfigKazooConvertConvertapi" /> class.
        /// </summary>
        /// <param name="apiUrl">convertapi api_url (default to &quot;https://v2.convertapi.com&quot;).</param>
        /// <param name="pdfVersion">Which pdf version files will be produced by convertapi service (default to PdfVersionEnum._7).</param>
        /// <param name="resolution">Which document resolution is used for converted files.</param>
        /// <param name="secret">convertapi secret.</param>
        /// <param name="timeout">Document conversion timeout.</param>
        /// <param name="tryOpenoffice">For which files types may be called openoffice (default to TryOpenofficeEnum.Formsofficefilesalso).</param>
        public SystemConfigKazooConvertConvertapi(string apiUrl = "https://v2.convertapi.com", PdfVersionEnum? pdfVersion = PdfVersionEnum._7, int? resolution = default(int?), string secret = default(string), int? timeout = default(int?), TryOpenofficeEnum? tryOpenoffice = TryOpenofficeEnum.Formsofficefilesalso)
        {
            // use default value if no "apiUrl" provided
            if (apiUrl == null)
            {
                this.ApiUrl = "https://v2.convertapi.com";
            }
            else
            {
                this.ApiUrl = apiUrl;
            }
            // use default value if no "pdfVersion" provided
            if (pdfVersion == null)
            {
                this.PdfVersion = PdfVersionEnum._7;
            }
            else
            {
                this.PdfVersion = pdfVersion;
            }
            this.Resolution = resolution;
            this.Secret = secret;
            this.Timeout = timeout;
            // use default value if no "tryOpenoffice" provided
            if (tryOpenoffice == null)
            {
                this.TryOpenoffice = TryOpenofficeEnum.Formsofficefilesalso;
            }
            else
            {
                this.TryOpenoffice = tryOpenoffice;
            }
        }
        
        /// <summary>
        /// convertapi api_url
        /// </summary>
        /// <value>convertapi api_url</value>
        [DataMember(Name="api_url", EmitDefaultValue=false)]
        public string ApiUrl { get; set; }


        /// <summary>
        /// Which document resolution is used for converted files
        /// </summary>
        /// <value>Which document resolution is used for converted files</value>
        [DataMember(Name="resolution", EmitDefaultValue=false)]
        public int? Resolution { get; set; }

        /// <summary>
        /// convertapi secret
        /// </summary>
        /// <value>convertapi secret</value>
        [DataMember(Name="secret", EmitDefaultValue=false)]
        public string Secret { get; set; }

        /// <summary>
        /// Document conversion timeout
        /// </summary>
        /// <value>Document conversion timeout</value>
        [DataMember(Name="timeout", EmitDefaultValue=false)]
        public int? Timeout { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SystemConfigKazooConvertConvertapi {\n");
            sb.Append("  ApiUrl: ").Append(ApiUrl).Append("\n");
            sb.Append("  PdfVersion: ").Append(PdfVersion).Append("\n");
            sb.Append("  Resolution: ").Append(Resolution).Append("\n");
            sb.Append("  Secret: ").Append(Secret).Append("\n");
            sb.Append("  Timeout: ").Append(Timeout).Append("\n");
            sb.Append("  TryOpenoffice: ").Append(TryOpenoffice).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SystemConfigKazooConvertConvertapi);
        }

        /// <summary>
        /// Returns true if SystemConfigKazooConvertConvertapi instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemConfigKazooConvertConvertapi to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemConfigKazooConvertConvertapi input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApiUrl == input.ApiUrl ||
                    (this.ApiUrl != null &&
                    this.ApiUrl.Equals(input.ApiUrl))
                ) && 
                (
                    this.PdfVersion == input.PdfVersion ||
                    (this.PdfVersion != null &&
                    this.PdfVersion.Equals(input.PdfVersion))
                ) && 
                (
                    this.Resolution == input.Resolution ||
                    (this.Resolution != null &&
                    this.Resolution.Equals(input.Resolution))
                ) && 
                (
                    this.Secret == input.Secret ||
                    (this.Secret != null &&
                    this.Secret.Equals(input.Secret))
                ) && 
                (
                    this.Timeout == input.Timeout ||
                    (this.Timeout != null &&
                    this.Timeout.Equals(input.Timeout))
                ) && 
                (
                    this.TryOpenoffice == input.TryOpenoffice ||
                    (this.TryOpenoffice != null &&
                    this.TryOpenoffice.Equals(input.TryOpenoffice))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ApiUrl != null)
                    hashCode = hashCode * 59 + this.ApiUrl.GetHashCode();
                if (this.PdfVersion != null)
                    hashCode = hashCode * 59 + this.PdfVersion.GetHashCode();
                if (this.Resolution != null)
                    hashCode = hashCode * 59 + this.Resolution.GetHashCode();
                if (this.Secret != null)
                    hashCode = hashCode * 59 + this.Secret.GetHashCode();
                if (this.Timeout != null)
                    hashCode = hashCode * 59 + this.Timeout.GetHashCode();
                if (this.TryOpenoffice != null)
                    hashCode = hashCode * 59 + this.TryOpenoffice.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Resolution (int?) maximum
            if(this.Resolution > (int?)2400)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Resolution, must be a value less than or equal to 2400.", new [] { "Resolution" });
            }

            // Resolution (int?) minimum
            if(this.Resolution < (int?)10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Resolution, must be a value greater than or equal to 10.", new [] { "Resolution" });
            }

            // Timeout (int?) maximum
            if(this.Timeout > (int?)1200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Timeout, must be a value less than or equal to 1200.", new [] { "Timeout" });
            }

            // Timeout (int?) minimum
            if(this.Timeout < (int?)10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Timeout, must be a value greater than or equal to 10.", new [] { "Timeout" });
            }

            yield break;
        }
    }

}
