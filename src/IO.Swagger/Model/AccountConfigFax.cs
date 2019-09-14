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
    /// Schema for fax account_config
    /// </summary>
    [DataContract]
    public partial class AccountConfigFax :  IEquatable<AccountConfigFax>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountConfigFax" /> class.
        /// </summary>
        /// <param name="defaultSmtpDomain">fax defaultsmtp domain (default to &quot;fax.kazoo.io&quot;).</param>
        /// <param name="logFaxboxErrors">fax log faxbox errors (default to true).</param>
        /// <param name="maxOutbound">fax max outbound.</param>
        public AccountConfigFax(string defaultSmtpDomain = "fax.kazoo.io", bool? logFaxboxErrors = true, int? maxOutbound = default(int?))
        {
            // use default value if no "defaultSmtpDomain" provided
            if (defaultSmtpDomain == null)
            {
                this.DefaultSmtpDomain = "fax.kazoo.io";
            }
            else
            {
                this.DefaultSmtpDomain = defaultSmtpDomain;
            }
            // use default value if no "logFaxboxErrors" provided
            if (logFaxboxErrors == null)
            {
                this.LogFaxboxErrors = true;
            }
            else
            {
                this.LogFaxboxErrors = logFaxboxErrors;
            }
            this.MaxOutbound = maxOutbound;
        }
        
        /// <summary>
        /// fax defaultsmtp domain
        /// </summary>
        /// <value>fax defaultsmtp domain</value>
        [DataMember(Name="default_smtp_domain", EmitDefaultValue=false)]
        public string DefaultSmtpDomain { get; set; }

        /// <summary>
        /// fax log faxbox errors
        /// </summary>
        /// <value>fax log faxbox errors</value>
        [DataMember(Name="log_faxbox_errors", EmitDefaultValue=false)]
        public bool? LogFaxboxErrors { get; set; }

        /// <summary>
        /// fax max outbound
        /// </summary>
        /// <value>fax max outbound</value>
        [DataMember(Name="max_outbound", EmitDefaultValue=false)]
        public int? MaxOutbound { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountConfigFax {\n");
            sb.Append("  DefaultSmtpDomain: ").Append(DefaultSmtpDomain).Append("\n");
            sb.Append("  LogFaxboxErrors: ").Append(LogFaxboxErrors).Append("\n");
            sb.Append("  MaxOutbound: ").Append(MaxOutbound).Append("\n");
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
            return this.Equals(input as AccountConfigFax);
        }

        /// <summary>
        /// Returns true if AccountConfigFax instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountConfigFax to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountConfigFax input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DefaultSmtpDomain == input.DefaultSmtpDomain ||
                    (this.DefaultSmtpDomain != null &&
                    this.DefaultSmtpDomain.Equals(input.DefaultSmtpDomain))
                ) && 
                (
                    this.LogFaxboxErrors == input.LogFaxboxErrors ||
                    (this.LogFaxboxErrors != null &&
                    this.LogFaxboxErrors.Equals(input.LogFaxboxErrors))
                ) && 
                (
                    this.MaxOutbound == input.MaxOutbound ||
                    (this.MaxOutbound != null &&
                    this.MaxOutbound.Equals(input.MaxOutbound))
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
                if (this.DefaultSmtpDomain != null)
                    hashCode = hashCode * 59 + this.DefaultSmtpDomain.GetHashCode();
                if (this.LogFaxboxErrors != null)
                    hashCode = hashCode * 59 + this.LogFaxboxErrors.GetHashCode();
                if (this.MaxOutbound != null)
                    hashCode = hashCode * 59 + this.MaxOutbound.GetHashCode();
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
