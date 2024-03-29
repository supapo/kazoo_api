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
    /// Schema for konami system_config
    /// </summary>
    [DataContract]
    public partial class SystemConfigKonami :  IEquatable<SystemConfigKonami>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemConfigKonami" /> class.
        /// </summary>
        /// <param name="eventCleanupTimeoutMs">konami event cleanup timeout in milliseconds.</param>
        /// <param name="transfer">transfer.</param>
        /// <param name="useFastRearm">konami use fast rearm (default to false).</param>
        /// <param name="webseqEnabled">konami webseq enabled (default to false).</param>
        public SystemConfigKonami(int? eventCleanupTimeoutMs = default(int?), SystemConfigKonamiTransfer transfer = default(SystemConfigKonamiTransfer), bool? useFastRearm = false, bool? webseqEnabled = false)
        {
            this.EventCleanupTimeoutMs = eventCleanupTimeoutMs;
            this.Transfer = transfer;
            // use default value if no "useFastRearm" provided
            if (useFastRearm == null)
            {
                this.UseFastRearm = false;
            }
            else
            {
                this.UseFastRearm = useFastRearm;
            }
            // use default value if no "webseqEnabled" provided
            if (webseqEnabled == null)
            {
                this.WebseqEnabled = false;
            }
            else
            {
                this.WebseqEnabled = webseqEnabled;
            }
        }
        
        /// <summary>
        /// konami event cleanup timeout in milliseconds
        /// </summary>
        /// <value>konami event cleanup timeout in milliseconds</value>
        [DataMember(Name="event_cleanup_timeout_ms", EmitDefaultValue=false)]
        public int? EventCleanupTimeoutMs { get; set; }

        /// <summary>
        /// Gets or Sets Transfer
        /// </summary>
        [DataMember(Name="transfer", EmitDefaultValue=false)]
        public SystemConfigKonamiTransfer Transfer { get; set; }

        /// <summary>
        /// konami use fast rearm
        /// </summary>
        /// <value>konami use fast rearm</value>
        [DataMember(Name="use_fast_rearm", EmitDefaultValue=false)]
        public bool? UseFastRearm { get; set; }

        /// <summary>
        /// konami webseq enabled
        /// </summary>
        /// <value>konami webseq enabled</value>
        [DataMember(Name="webseq_enabled", EmitDefaultValue=false)]
        public bool? WebseqEnabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SystemConfigKonami {\n");
            sb.Append("  EventCleanupTimeoutMs: ").Append(EventCleanupTimeoutMs).Append("\n");
            sb.Append("  Transfer: ").Append(Transfer).Append("\n");
            sb.Append("  UseFastRearm: ").Append(UseFastRearm).Append("\n");
            sb.Append("  WebseqEnabled: ").Append(WebseqEnabled).Append("\n");
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
            return this.Equals(input as SystemConfigKonami);
        }

        /// <summary>
        /// Returns true if SystemConfigKonami instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemConfigKonami to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemConfigKonami input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EventCleanupTimeoutMs == input.EventCleanupTimeoutMs ||
                    (this.EventCleanupTimeoutMs != null &&
                    this.EventCleanupTimeoutMs.Equals(input.EventCleanupTimeoutMs))
                ) && 
                (
                    this.Transfer == input.Transfer ||
                    (this.Transfer != null &&
                    this.Transfer.Equals(input.Transfer))
                ) && 
                (
                    this.UseFastRearm == input.UseFastRearm ||
                    (this.UseFastRearm != null &&
                    this.UseFastRearm.Equals(input.UseFastRearm))
                ) && 
                (
                    this.WebseqEnabled == input.WebseqEnabled ||
                    (this.WebseqEnabled != null &&
                    this.WebseqEnabled.Equals(input.WebseqEnabled))
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
                if (this.EventCleanupTimeoutMs != null)
                    hashCode = hashCode * 59 + this.EventCleanupTimeoutMs.GetHashCode();
                if (this.Transfer != null)
                    hashCode = hashCode * 59 + this.Transfer.GetHashCode();
                if (this.UseFastRearm != null)
                    hashCode = hashCode * 59 + this.UseFastRearm.GetHashCode();
                if (this.WebseqEnabled != null)
                    hashCode = hashCode * 59 + this.WebseqEnabled.GetHashCode();
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
            yield break;
        }
    }

}
