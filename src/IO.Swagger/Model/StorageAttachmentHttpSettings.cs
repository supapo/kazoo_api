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
    /// HTTP server settings
    /// </summary>
    [DataContract]
    public partial class StorageAttachmentHttpSettings :  IEquatable<StorageAttachmentHttpSettings>, IValidatableObject
    {
        /// <summary>
        /// The HTTP verb to use when sending the data
        /// </summary>
        /// <value>The HTTP verb to use when sending the data</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VerbEnum
        {
            
            /// <summary>
            /// Enum Post for value: post
            /// </summary>
            [EnumMember(Value = "post")]
            Post = 1,
            
            /// <summary>
            /// Enum Put for value: put
            /// </summary>
            [EnumMember(Value = "put")]
            Put = 2
        }

        /// <summary>
        /// The HTTP verb to use when sending the data
        /// </summary>
        /// <value>The HTTP verb to use when sending the data</value>
        [DataMember(Name="verb", EmitDefaultValue=false)]
        public VerbEnum? Verb { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageAttachmentHttpSettings" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StorageAttachmentHttpSettings() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageAttachmentHttpSettings" /> class.
        /// </summary>
        /// <param name="base64EncodeData">Toggles whether to base64-encode the attachment data (default to false).</param>
        /// <param name="sendMultipart">Toggle whether to send multipart payload when storing attachment - will include metadata JSON if true.</param>
        /// <param name="url">The base HTTP(s) URL to use when creating the request (required).</param>
        /// <param name="verb">The HTTP verb to use when sending the data (default to VerbEnum.Put).</param>
        public StorageAttachmentHttpSettings(bool? base64EncodeData = false, bool? sendMultipart = default(bool?), string url = default(string), VerbEnum? verb = VerbEnum.Put)
        {
            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new InvalidDataException("url is a required property for StorageAttachmentHttpSettings and cannot be null");
            }
            else
            {
                this.Url = url;
            }
            // use default value if no "base64EncodeData" provided
            if (base64EncodeData == null)
            {
                this.Base64EncodeData = false;
            }
            else
            {
                this.Base64EncodeData = base64EncodeData;
            }
            this.SendMultipart = sendMultipart;
            // use default value if no "verb" provided
            if (verb == null)
            {
                this.Verb = VerbEnum.Put;
            }
            else
            {
                this.Verb = verb;
            }
        }
        
        /// <summary>
        /// Toggles whether to base64-encode the attachment data
        /// </summary>
        /// <value>Toggles whether to base64-encode the attachment data</value>
        [DataMember(Name="base64_encode_data", EmitDefaultValue=false)]
        public bool? Base64EncodeData { get; set; }

        /// <summary>
        /// Toggle whether to send multipart payload when storing attachment - will include metadata JSON if true
        /// </summary>
        /// <value>Toggle whether to send multipart payload when storing attachment - will include metadata JSON if true</value>
        [DataMember(Name="send_multipart", EmitDefaultValue=false)]
        public bool? SendMultipart { get; set; }

        /// <summary>
        /// The base HTTP(s) URL to use when creating the request
        /// </summary>
        /// <value>The base HTTP(s) URL to use when creating the request</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StorageAttachmentHttpSettings {\n");
            sb.Append("  Base64EncodeData: ").Append(Base64EncodeData).Append("\n");
            sb.Append("  SendMultipart: ").Append(SendMultipart).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Verb: ").Append(Verb).Append("\n");
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
            return this.Equals(input as StorageAttachmentHttpSettings);
        }

        /// <summary>
        /// Returns true if StorageAttachmentHttpSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of StorageAttachmentHttpSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StorageAttachmentHttpSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Base64EncodeData == input.Base64EncodeData ||
                    (this.Base64EncodeData != null &&
                    this.Base64EncodeData.Equals(input.Base64EncodeData))
                ) && 
                (
                    this.SendMultipart == input.SendMultipart ||
                    (this.SendMultipart != null &&
                    this.SendMultipart.Equals(input.SendMultipart))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Verb == input.Verb ||
                    (this.Verb != null &&
                    this.Verb.Equals(input.Verb))
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
                if (this.Base64EncodeData != null)
                    hashCode = hashCode * 59 + this.Base64EncodeData.GetHashCode();
                if (this.SendMultipart != null)
                    hashCode = hashCode * 59 + this.SendMultipart.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Verb != null)
                    hashCode = hashCode * 59 + this.Verb.GetHashCode();
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
