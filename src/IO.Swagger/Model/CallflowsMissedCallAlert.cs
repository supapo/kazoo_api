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
    /// Validator for the missed_call_alert callflow data object
    /// </summary>
    [DataContract]
    public partial class CallflowsMissedCallAlert :  IEquatable<CallflowsMissedCallAlert>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CallflowsMissedCallAlert" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CallflowsMissedCallAlert() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CallflowsMissedCallAlert" /> class.
        /// </summary>
        /// <param name="recipients">One or more specific email addresses, Kazoo user ids or a combination of both (required).</param>
        /// <param name="skipModule">When set to true this callflow action is skipped, advancing to the wildcard branch (if any).</param>
        public CallflowsMissedCallAlert(List<CallflowsMissedCallAlertRecipients> recipients = default(List<CallflowsMissedCallAlertRecipients>), bool? skipModule = default(bool?))
        {
            // to ensure "recipients" is required (not null)
            if (recipients == null)
            {
                throw new InvalidDataException("recipients is a required property for CallflowsMissedCallAlert and cannot be null");
            }
            else
            {
                this.Recipients = recipients;
            }
            this.SkipModule = skipModule;
        }
        
        /// <summary>
        /// One or more specific email addresses, Kazoo user ids or a combination of both
        /// </summary>
        /// <value>One or more specific email addresses, Kazoo user ids or a combination of both</value>
        [DataMember(Name="recipients", EmitDefaultValue=false)]
        public List<CallflowsMissedCallAlertRecipients> Recipients { get; set; }

        /// <summary>
        /// When set to true this callflow action is skipped, advancing to the wildcard branch (if any)
        /// </summary>
        /// <value>When set to true this callflow action is skipped, advancing to the wildcard branch (if any)</value>
        [DataMember(Name="skip_module", EmitDefaultValue=false)]
        public bool? SkipModule { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CallflowsMissedCallAlert {\n");
            sb.Append("  Recipients: ").Append(Recipients).Append("\n");
            sb.Append("  SkipModule: ").Append(SkipModule).Append("\n");
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
            return this.Equals(input as CallflowsMissedCallAlert);
        }

        /// <summary>
        /// Returns true if CallflowsMissedCallAlert instances are equal
        /// </summary>
        /// <param name="input">Instance of CallflowsMissedCallAlert to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallflowsMissedCallAlert input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Recipients == input.Recipients ||
                    this.Recipients != null &&
                    this.Recipients.SequenceEqual(input.Recipients)
                ) && 
                (
                    this.SkipModule == input.SkipModule ||
                    (this.SkipModule != null &&
                    this.SkipModule.Equals(input.SkipModule))
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
                if (this.Recipients != null)
                    hashCode = hashCode * 59 + this.Recipients.GetHashCode();
                if (this.SkipModule != null)
                    hashCode = hashCode * 59 + this.SkipModule.GetHashCode();
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
