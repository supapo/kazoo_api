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
    /// Provides an auth-token via an Account API key
    /// </summary>
    [DataContract]
    public partial class ApiAuth :  IEquatable<ApiAuth>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiAuth" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApiAuth() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiAuth" /> class.
        /// </summary>
        /// <param name="apiKey">The Accounts API key (required).</param>
        public ApiAuth(string apiKey = default(string))
        {
            // to ensure "apiKey" is required (not null)
            if (apiKey == null)
            {
                throw new InvalidDataException("apiKey is a required property for ApiAuth and cannot be null");
            }
            else
            {
                this.ApiKey = apiKey;
            }
        }
        
        /// <summary>
        /// The Accounts API key
        /// </summary>
        /// <value>The Accounts API key</value>
        [DataMember(Name="api_key", EmitDefaultValue=false)]
        public string ApiKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiAuth {\n");
            sb.Append("  ApiKey: ").Append(ApiKey).Append("\n");
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
            return this.Equals(input as ApiAuth);
        }

        /// <summary>
        /// Returns true if ApiAuth instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiAuth to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiAuth input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApiKey == input.ApiKey ||
                    (this.ApiKey != null &&
                    this.ApiKey.Equals(input.ApiKey))
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
                if (this.ApiKey != null)
                    hashCode = hashCode * 59 + this.ApiKey.GetHashCode();
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
            // ApiKey (string) maxLength
            if(this.ApiKey != null && this.ApiKey.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ApiKey, length must be less than 64.", new [] { "ApiKey" });
            }

            // ApiKey (string) minLength
            if(this.ApiKey != null && this.ApiKey.Length < 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ApiKey, length must be greater than 64.", new [] { "ApiKey" });
            }

            yield break;
        }
    }

}