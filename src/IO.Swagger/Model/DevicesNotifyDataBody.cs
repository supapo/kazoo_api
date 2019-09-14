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
    /// Parameters of content body of SIP NOTIFY
    /// </summary>
    [DataContract]
    public partial class DevicesNotifyDataBody :  IEquatable<DevicesNotifyDataBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DevicesNotifyDataBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DevicesNotifyDataBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DevicesNotifyDataBody" /> class.
        /// </summary>
        /// <param name="contentType">The Content-Type of the data in the content body (required).</param>
        /// <param name="data">The data in the content body (required).</param>
        public DevicesNotifyDataBody(string contentType = default(string), string data = default(string))
        {
            // to ensure "contentType" is required (not null)
            if (contentType == null)
            {
                throw new InvalidDataException("contentType is a required property for DevicesNotifyDataBody and cannot be null");
            }
            else
            {
                this.ContentType = contentType;
            }
            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new InvalidDataException("data is a required property for DevicesNotifyDataBody and cannot be null");
            }
            else
            {
                this.Data = data;
            }
        }
        
        /// <summary>
        /// The Content-Type of the data in the content body
        /// </summary>
        /// <value>The Content-Type of the data in the content body</value>
        [DataMember(Name="content_type", EmitDefaultValue=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// The data in the content body
        /// </summary>
        /// <value>The data in the content body</value>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public string Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DevicesNotifyDataBody {\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(input as DevicesNotifyDataBody);
        }

        /// <summary>
        /// Returns true if DevicesNotifyDataBody instances are equal
        /// </summary>
        /// <param name="input">Instance of DevicesNotifyDataBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DevicesNotifyDataBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ContentType == input.ContentType ||
                    (this.ContentType != null &&
                    this.ContentType.Equals(input.ContentType))
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
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
                if (this.ContentType != null)
                    hashCode = hashCode * 59 + this.ContentType.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
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
