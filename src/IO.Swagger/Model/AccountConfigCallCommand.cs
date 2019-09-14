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
    /// Schema for call_command account_config
    /// </summary>
    [DataContract]
    public partial class AccountConfigCallCommand :  IEquatable<AccountConfigCallCommand>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountConfigCallCommand" /> class.
        /// </summary>
        /// <param name="unknownCidName">the value to use when a caller ID name is required but unknown (default to &quot;unknown&quot;).</param>
        public AccountConfigCallCommand(string unknownCidName = "unknown")
        {
            // use default value if no "unknownCidName" provided
            if (unknownCidName == null)
            {
                this.UnknownCidName = "unknown";
            }
            else
            {
                this.UnknownCidName = unknownCidName;
            }
        }
        
        /// <summary>
        /// the value to use when a caller ID name is required but unknown
        /// </summary>
        /// <value>the value to use when a caller ID name is required but unknown</value>
        [DataMember(Name="unknown_cid_name", EmitDefaultValue=false)]
        public string UnknownCidName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountConfigCallCommand {\n");
            sb.Append("  UnknownCidName: ").Append(UnknownCidName).Append("\n");
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
            return this.Equals(input as AccountConfigCallCommand);
        }

        /// <summary>
        /// Returns true if AccountConfigCallCommand instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountConfigCallCommand to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountConfigCallCommand input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UnknownCidName == input.UnknownCidName ||
                    (this.UnknownCidName != null &&
                    this.UnknownCidName.Equals(input.UnknownCidName))
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
                if (this.UnknownCidName != null)
                    hashCode = hashCode * 59 + this.UnknownCidName.GetHashCode();
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