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
    /// Schema for crossbar.users system_config
    /// </summary>
    [DataContract]
    public partial class SystemConfigCrossbarUsers :  IEquatable<SystemConfigCrossbarUsers>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemConfigCrossbarUsers" /> class.
        /// </summary>
        /// <param name="generatePasswordIfEmpty">crossbar users generate_password_if_empty (default to false).</param>
        /// <param name="generateUsernameIfEmpty">crossbar users generate_username_if_empty (default to true).</param>
        /// <param name="resetIdentitySecretOnRehash">crossbar users reset_identity_secret_on_rehash (default to true).</param>
        public SystemConfigCrossbarUsers(bool? generatePasswordIfEmpty = false, bool? generateUsernameIfEmpty = true, bool? resetIdentitySecretOnRehash = true)
        {
            // use default value if no "generatePasswordIfEmpty" provided
            if (generatePasswordIfEmpty == null)
            {
                this.GeneratePasswordIfEmpty = false;
            }
            else
            {
                this.GeneratePasswordIfEmpty = generatePasswordIfEmpty;
            }
            // use default value if no "generateUsernameIfEmpty" provided
            if (generateUsernameIfEmpty == null)
            {
                this.GenerateUsernameIfEmpty = true;
            }
            else
            {
                this.GenerateUsernameIfEmpty = generateUsernameIfEmpty;
            }
            // use default value if no "resetIdentitySecretOnRehash" provided
            if (resetIdentitySecretOnRehash == null)
            {
                this.ResetIdentitySecretOnRehash = true;
            }
            else
            {
                this.ResetIdentitySecretOnRehash = resetIdentitySecretOnRehash;
            }
        }
        
        /// <summary>
        /// crossbar users generate_password_if_empty
        /// </summary>
        /// <value>crossbar users generate_password_if_empty</value>
        [DataMember(Name="generate_password_if_empty", EmitDefaultValue=false)]
        public bool? GeneratePasswordIfEmpty { get; set; }

        /// <summary>
        /// crossbar users generate_username_if_empty
        /// </summary>
        /// <value>crossbar users generate_username_if_empty</value>
        [DataMember(Name="generate_username_if_empty", EmitDefaultValue=false)]
        public bool? GenerateUsernameIfEmpty { get; set; }

        /// <summary>
        /// crossbar users reset_identity_secret_on_rehash
        /// </summary>
        /// <value>crossbar users reset_identity_secret_on_rehash</value>
        [DataMember(Name="reset_identity_secret_on_rehash", EmitDefaultValue=false)]
        public bool? ResetIdentitySecretOnRehash { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SystemConfigCrossbarUsers {\n");
            sb.Append("  GeneratePasswordIfEmpty: ").Append(GeneratePasswordIfEmpty).Append("\n");
            sb.Append("  GenerateUsernameIfEmpty: ").Append(GenerateUsernameIfEmpty).Append("\n");
            sb.Append("  ResetIdentitySecretOnRehash: ").Append(ResetIdentitySecretOnRehash).Append("\n");
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
            return this.Equals(input as SystemConfigCrossbarUsers);
        }

        /// <summary>
        /// Returns true if SystemConfigCrossbarUsers instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemConfigCrossbarUsers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemConfigCrossbarUsers input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GeneratePasswordIfEmpty == input.GeneratePasswordIfEmpty ||
                    (this.GeneratePasswordIfEmpty != null &&
                    this.GeneratePasswordIfEmpty.Equals(input.GeneratePasswordIfEmpty))
                ) && 
                (
                    this.GenerateUsernameIfEmpty == input.GenerateUsernameIfEmpty ||
                    (this.GenerateUsernameIfEmpty != null &&
                    this.GenerateUsernameIfEmpty.Equals(input.GenerateUsernameIfEmpty))
                ) && 
                (
                    this.ResetIdentitySecretOnRehash == input.ResetIdentitySecretOnRehash ||
                    (this.ResetIdentitySecretOnRehash != null &&
                    this.ResetIdentitySecretOnRehash.Equals(input.ResetIdentitySecretOnRehash))
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
                if (this.GeneratePasswordIfEmpty != null)
                    hashCode = hashCode * 59 + this.GeneratePasswordIfEmpty.GetHashCode();
                if (this.GenerateUsernameIfEmpty != null)
                    hashCode = hashCode * 59 + this.GenerateUsernameIfEmpty.GetHashCode();
                if (this.ResetIdentitySecretOnRehash != null)
                    hashCode = hashCode * 59 + this.ResetIdentitySecretOnRehash.GetHashCode();
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
