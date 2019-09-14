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
    /// Settings for the OneDrive account
    /// </summary>
    [DataContract]
    public partial class StorageAttachmentOnedriveSettings :  IEquatable<StorageAttachmentOnedriveSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageAttachmentOnedriveSettings" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StorageAttachmentOnedriveSettings() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageAttachmentOnedriveSettings" /> class.
        /// </summary>
        /// <param name="oauthDocId">Doc ID in the system &#39;auth&#39; database (required).</param>
        public StorageAttachmentOnedriveSettings(string oauthDocId = default(string))
        {
            // to ensure "oauthDocId" is required (not null)
            if (oauthDocId == null)
            {
                throw new InvalidDataException("oauthDocId is a required property for StorageAttachmentOnedriveSettings and cannot be null");
            }
            else
            {
                this.OauthDocId = oauthDocId;
            }
        }
        
        /// <summary>
        /// Doc ID in the system &#39;auth&#39; database
        /// </summary>
        /// <value>Doc ID in the system &#39;auth&#39; database</value>
        [DataMember(Name="oauth_doc_id", EmitDefaultValue=false)]
        public string OauthDocId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StorageAttachmentOnedriveSettings {\n");
            sb.Append("  OauthDocId: ").Append(OauthDocId).Append("\n");
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
            return this.Equals(input as StorageAttachmentOnedriveSettings);
        }

        /// <summary>
        /// Returns true if StorageAttachmentOnedriveSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of StorageAttachmentOnedriveSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StorageAttachmentOnedriveSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OauthDocId == input.OauthDocId ||
                    (this.OauthDocId != null &&
                    this.OauthDocId.Equals(input.OauthDocId))
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
                if (this.OauthDocId != null)
                    hashCode = hashCode * 59 + this.OauthDocId.GetHashCode();
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
            // OauthDocId (string) minLength
            if(this.OauthDocId != null && this.OauthDocId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OauthDocId, length must be greater than 1.", new [] { "OauthDocId" });
            }

            yield break;
        }
    }

}
