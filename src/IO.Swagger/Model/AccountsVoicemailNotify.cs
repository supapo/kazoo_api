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
    /// AccountsVoicemailNotify
    /// </summary>
    [DataContract]
    public partial class AccountsVoicemailNotify :  IEquatable<AccountsVoicemailNotify>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountsVoicemailNotify" /> class.
        /// </summary>
        /// <param name="callback">callback.</param>
        public AccountsVoicemailNotify(NotifyCallback callback = default(NotifyCallback))
        {
            this.Callback = callback;
        }
        
        /// <summary>
        /// Gets or Sets Callback
        /// </summary>
        [DataMember(Name="callback", EmitDefaultValue=false)]
        public NotifyCallback Callback { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountsVoicemailNotify {\n");
            sb.Append("  Callback: ").Append(Callback).Append("\n");
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
            return this.Equals(input as AccountsVoicemailNotify);
        }

        /// <summary>
        /// Returns true if AccountsVoicemailNotify instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountsVoicemailNotify to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountsVoicemailNotify input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Callback == input.Callback ||
                    (this.Callback != null &&
                    this.Callback.Equals(input.Callback))
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
                if (this.Callback != null)
                    hashCode = hashCode * 59 + this.Callback.GetHashCode();
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
