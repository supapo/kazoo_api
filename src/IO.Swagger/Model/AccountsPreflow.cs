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
    /// Each property provides functionality that can be applied to calls using the callflow application
    /// </summary>
    [DataContract]
    public partial class AccountsPreflow :  IEquatable<AccountsPreflow>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountsPreflow" /> class.
        /// </summary>
        /// <param name="always">The ID of a callflow to always execute prior to processing the callflow with numbers/patterns matching the request.</param>
        public AccountsPreflow(string always = default(string))
        {
            this.Always = always;
        }
        
        /// <summary>
        /// The ID of a callflow to always execute prior to processing the callflow with numbers/patterns matching the request
        /// </summary>
        /// <value>The ID of a callflow to always execute prior to processing the callflow with numbers/patterns matching the request</value>
        [DataMember(Name="always", EmitDefaultValue=false)]
        public string Always { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountsPreflow {\n");
            sb.Append("  Always: ").Append(Always).Append("\n");
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
            return this.Equals(input as AccountsPreflow);
        }

        /// <summary>
        /// Returns true if AccountsPreflow instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountsPreflow to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountsPreflow input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Always == input.Always ||
                    (this.Always != null &&
                    this.Always.Equals(input.Always))
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
                if (this.Always != null)
                    hashCode = hashCode * 59 + this.Always.GetHashCode();
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