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
    /// Provides a local auth-token via a shared auth-token
    /// </summary>
    [DataContract]
    public partial class SharedAuth :  IEquatable<SharedAuth>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SharedAuth" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SharedAuth() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SharedAuth" /> class.
        /// </summary>
        /// <param name="sharedAuth">The shared token (required).</param>
        public SharedAuth(string sharedAuth = default(string))
        {
            // to ensure "sharedAuth" is required (not null)
            if (sharedAuth == null)
            {
                throw new InvalidDataException("sharedAuth is a required property for SharedAuth and cannot be null");
            }
            else
            {
                this.SharedAuth = sharedAuth;
            }
        }
        
        /// <summary>
        /// The shared token
        /// </summary>
        /// <value>The shared token</value>
        [DataMember(Name="shared_auth", EmitDefaultValue=false)]
        public string SharedAuth { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SharedAuth {\n");
            sb.Append("  SharedAuth: ").Append(SharedAuth).Append("\n");
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
            return this.Equals(input as SharedAuth);
        }

        /// <summary>
        /// Returns true if SharedAuth instances are equal
        /// </summary>
        /// <param name="input">Instance of SharedAuth to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SharedAuth input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SharedAuth == input.SharedAuth ||
                    (this.SharedAuth != null &&
                    this.SharedAuth.Equals(input.SharedAuth))
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
                if (this.SharedAuth != null)
                    hashCode = hashCode * 59 + this.SharedAuth.GetHashCode();
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
            // SharedAuth (string) maxLength
            if(this.SharedAuth != null && this.SharedAuth.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SharedAuth, length must be less than 64.", new [] { "SharedAuth" });
            }

            // SharedAuth (string) minLength
            if(this.SharedAuth != null && this.SharedAuth.Length < 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SharedAuth, length must be greater than 64.", new [] { "SharedAuth" });
            }

            yield break;
        }
    }

}