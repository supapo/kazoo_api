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
    /// Provides an auth-token via Ubiquiti&#39;s SSO
    /// </summary>
    [DataContract]
    public partial class UbiquitiAuth :  IEquatable<UbiquitiAuth>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UbiquitiAuth" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UbiquitiAuth() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UbiquitiAuth" /> class.
        /// </summary>
        /// <param name="password">Ubiquiti SSO Password (required).</param>
        /// <param name="username">Ubiquiti SSO Username (required).</param>
        public UbiquitiAuth(string password = default(string), string username = default(string))
        {
            // to ensure "password" is required (not null)
            if (password == null)
            {
                throw new InvalidDataException("password is a required property for UbiquitiAuth and cannot be null");
            }
            else
            {
                this.Password = password;
            }
            // to ensure "username" is required (not null)
            if (username == null)
            {
                throw new InvalidDataException("username is a required property for UbiquitiAuth and cannot be null");
            }
            else
            {
                this.Username = username;
            }
        }
        
        /// <summary>
        /// Ubiquiti SSO Password
        /// </summary>
        /// <value>Ubiquiti SSO Password</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Ubiquiti SSO Username
        /// </summary>
        /// <value>Ubiquiti SSO Username</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UbiquitiAuth {\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
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
            return this.Equals(input as UbiquitiAuth);
        }

        /// <summary>
        /// Returns true if UbiquitiAuth instances are equal
        /// </summary>
        /// <param name="input">Instance of UbiquitiAuth to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UbiquitiAuth input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
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
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
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
            // Password (string) maxLength
            if(this.Password != null && this.Password.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Password, length must be less than 64.", new [] { "Password" });
            }

            // Password (string) minLength
            if(this.Password != null && this.Password.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Password, length must be greater than 1.", new [] { "Password" });
            }

            // Username (string) maxLength
            if(this.Username != null && this.Username.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Username, length must be less than 64.", new [] { "Username" });
            }

            // Username (string) minLength
            if(this.Username != null && this.Username.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Username, length must be greater than 1.", new [] { "Username" });
            }

            yield break;
        }
    }

}
