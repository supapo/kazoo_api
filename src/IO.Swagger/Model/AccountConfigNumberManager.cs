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
    /// Schema for number_manager account_config
    /// </summary>
    [DataContract]
    public partial class AccountConfigNumberManager :  IEquatable<AccountConfigNumberManager>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountConfigNumberManager" /> class.
        /// </summary>
        /// <param name="unauthorizedNumbersLookup">number_manager unauthorized numbers lookup (default to false).</param>
        public AccountConfigNumberManager(bool? unauthorizedNumbersLookup = false)
        {
            // use default value if no "unauthorizedNumbersLookup" provided
            if (unauthorizedNumbersLookup == null)
            {
                this.UnauthorizedNumbersLookup = false;
            }
            else
            {
                this.UnauthorizedNumbersLookup = unauthorizedNumbersLookup;
            }
        }
        
        /// <summary>
        /// number_manager unauthorized numbers lookup
        /// </summary>
        /// <value>number_manager unauthorized numbers lookup</value>
        [DataMember(Name="unauthorized_numbers_lookup", EmitDefaultValue=false)]
        public bool? UnauthorizedNumbersLookup { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountConfigNumberManager {\n");
            sb.Append("  UnauthorizedNumbersLookup: ").Append(UnauthorizedNumbersLookup).Append("\n");
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
            return this.Equals(input as AccountConfigNumberManager);
        }

        /// <summary>
        /// Returns true if AccountConfigNumberManager instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountConfigNumberManager to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountConfigNumberManager input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UnauthorizedNumbersLookup == input.UnauthorizedNumbersLookup ||
                    (this.UnauthorizedNumbersLookup != null &&
                    this.UnauthorizedNumbersLookup.Equals(input.UnauthorizedNumbersLookup))
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
                if (this.UnauthorizedNumbersLookup != null)
                    hashCode = hashCode * 59 + this.UnauthorizedNumbersLookup.GetHashCode();
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