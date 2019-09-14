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
    /// The default music on hold parameters
    /// </summary>
    [DataContract]
    public partial class AccountsMusicOnHold :  IEquatable<AccountsMusicOnHold>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountsMusicOnHold" /> class.
        /// </summary>
        /// <param name="mediaId">The ID of a media object that should be used as the default music on hold.</param>
        public AccountsMusicOnHold(string mediaId = default(string))
        {
            this.MediaId = mediaId;
        }
        
        /// <summary>
        /// The ID of a media object that should be used as the default music on hold
        /// </summary>
        /// <value>The ID of a media object that should be used as the default music on hold</value>
        [DataMember(Name="media_id", EmitDefaultValue=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountsMusicOnHold {\n");
            sb.Append("  MediaId: ").Append(MediaId).Append("\n");
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
            return this.Equals(input as AccountsMusicOnHold);
        }

        /// <summary>
        /// Returns true if AccountsMusicOnHold instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountsMusicOnHold to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountsMusicOnHold input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MediaId == input.MediaId ||
                    (this.MediaId != null &&
                    this.MediaId.Equals(input.MediaId))
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
                if (this.MediaId != null)
                    hashCode = hashCode * 59 + this.MediaId.GetHashCode();
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
            // MediaId (string) maxLength
            if(this.MediaId != null && this.MediaId.Length > 2048)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MediaId, length must be less than 2048.", new [] { "MediaId" });
            }

            yield break;
        }
    }

}
