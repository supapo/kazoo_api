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
    /// Schema for notify.ported system_config
    /// </summary>
    [DataContract]
    public partial class SystemConfigNotifyPorted :  IEquatable<SystemConfigNotifyPorted>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemConfigNotifyPorted" /> class.
        /// </summary>
        /// <param name="defaultTo">notify.ported default to.</param>
        /// <param name="sendFromAdminEmail">notify.ported send from admin email (default to true).</param>
        public SystemConfigNotifyPorted(Object defaultTo = default(Object), bool? sendFromAdminEmail = true)
        {
            this.DefaultTo = defaultTo;
            // use default value if no "sendFromAdminEmail" provided
            if (sendFromAdminEmail == null)
            {
                this.SendFromAdminEmail = true;
            }
            else
            {
                this.SendFromAdminEmail = sendFromAdminEmail;
            }
        }
        
        /// <summary>
        /// notify.ported default to
        /// </summary>
        /// <value>notify.ported default to</value>
        [DataMember(Name="default_to", EmitDefaultValue=false)]
        public Object DefaultTo { get; set; }

        /// <summary>
        /// notify.ported send from admin email
        /// </summary>
        /// <value>notify.ported send from admin email</value>
        [DataMember(Name="send_from_admin_email", EmitDefaultValue=false)]
        public bool? SendFromAdminEmail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SystemConfigNotifyPorted {\n");
            sb.Append("  DefaultTo: ").Append(DefaultTo).Append("\n");
            sb.Append("  SendFromAdminEmail: ").Append(SendFromAdminEmail).Append("\n");
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
            return this.Equals(input as SystemConfigNotifyPorted);
        }

        /// <summary>
        /// Returns true if SystemConfigNotifyPorted instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemConfigNotifyPorted to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemConfigNotifyPorted input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DefaultTo == input.DefaultTo ||
                    (this.DefaultTo != null &&
                    this.DefaultTo.Equals(input.DefaultTo))
                ) && 
                (
                    this.SendFromAdminEmail == input.SendFromAdminEmail ||
                    (this.SendFromAdminEmail != null &&
                    this.SendFromAdminEmail.Equals(input.SendFromAdminEmail))
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
                if (this.DefaultTo != null)
                    hashCode = hashCode * 59 + this.DefaultTo.GetHashCode();
                if (this.SendFromAdminEmail != null)
                    hashCode = hashCode * 59 + this.SendFromAdminEmail.GetHashCode();
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
