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
    /// Schema for notify.voicemail_full system_config
    /// </summary>
    [DataContract]
    public partial class SystemConfigNotifyVoicemailFull :  IEquatable<SystemConfigNotifyVoicemailFull>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemConfigNotifyVoicemailFull" /> class.
        /// </summary>
        /// <param name="defaultEnabled">notify.voicemail_full default enabled (default to false).</param>
        /// <param name="defaultTo">notify.voicemail_full default to.</param>
        public SystemConfigNotifyVoicemailFull(bool? defaultEnabled = false, Object defaultTo = default(Object))
        {
            // use default value if no "defaultEnabled" provided
            if (defaultEnabled == null)
            {
                this.DefaultEnabled = false;
            }
            else
            {
                this.DefaultEnabled = defaultEnabled;
            }
            this.DefaultTo = defaultTo;
        }
        
        /// <summary>
        /// notify.voicemail_full default enabled
        /// </summary>
        /// <value>notify.voicemail_full default enabled</value>
        [DataMember(Name="default_enabled", EmitDefaultValue=false)]
        public bool? DefaultEnabled { get; set; }

        /// <summary>
        /// notify.voicemail_full default to
        /// </summary>
        /// <value>notify.voicemail_full default to</value>
        [DataMember(Name="default_to", EmitDefaultValue=false)]
        public Object DefaultTo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SystemConfigNotifyVoicemailFull {\n");
            sb.Append("  DefaultEnabled: ").Append(DefaultEnabled).Append("\n");
            sb.Append("  DefaultTo: ").Append(DefaultTo).Append("\n");
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
            return this.Equals(input as SystemConfigNotifyVoicemailFull);
        }

        /// <summary>
        /// Returns true if SystemConfigNotifyVoicemailFull instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemConfigNotifyVoicemailFull to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemConfigNotifyVoicemailFull input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DefaultEnabled == input.DefaultEnabled ||
                    (this.DefaultEnabled != null &&
                    this.DefaultEnabled.Equals(input.DefaultEnabled))
                ) && 
                (
                    this.DefaultTo == input.DefaultTo ||
                    (this.DefaultTo != null &&
                    this.DefaultTo.Equals(input.DefaultTo))
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
                if (this.DefaultEnabled != null)
                    hashCode = hashCode * 59 + this.DefaultEnabled.GetHashCode();
                if (this.DefaultTo != null)
                    hashCode = hashCode * 59 + this.DefaultTo.GetHashCode();
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
