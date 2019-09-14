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
    /// Schema for notify.topup system_config
    /// </summary>
    [DataContract]
    public partial class SystemConfigNotifyTopup :  IEquatable<SystemConfigNotifyTopup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemConfigNotifyTopup" /> class.
        /// </summary>
        /// <param name="defaultTo">notify.topup default to.</param>
        /// <param name="htmlContentTransferEncoding">notify.topup html content transfer encoding (default to &quot;7BIT&quot;).</param>
        /// <param name="textContentTransferEncoding">notify.topup text content transfer encoding (default to &quot;7BIT&quot;).</param>
        public SystemConfigNotifyTopup(Object defaultTo = default(Object), string htmlContentTransferEncoding = "7BIT", string textContentTransferEncoding = "7BIT")
        {
            this.DefaultTo = defaultTo;
            // use default value if no "htmlContentTransferEncoding" provided
            if (htmlContentTransferEncoding == null)
            {
                this.HtmlContentTransferEncoding = "7BIT";
            }
            else
            {
                this.HtmlContentTransferEncoding = htmlContentTransferEncoding;
            }
            // use default value if no "textContentTransferEncoding" provided
            if (textContentTransferEncoding == null)
            {
                this.TextContentTransferEncoding = "7BIT";
            }
            else
            {
                this.TextContentTransferEncoding = textContentTransferEncoding;
            }
        }
        
        /// <summary>
        /// notify.topup default to
        /// </summary>
        /// <value>notify.topup default to</value>
        [DataMember(Name="default_to", EmitDefaultValue=false)]
        public Object DefaultTo { get; set; }

        /// <summary>
        /// notify.topup html content transfer encoding
        /// </summary>
        /// <value>notify.topup html content transfer encoding</value>
        [DataMember(Name="html_content_transfer_encoding", EmitDefaultValue=false)]
        public string HtmlContentTransferEncoding { get; set; }

        /// <summary>
        /// notify.topup text content transfer encoding
        /// </summary>
        /// <value>notify.topup text content transfer encoding</value>
        [DataMember(Name="text_content_transfer_encoding", EmitDefaultValue=false)]
        public string TextContentTransferEncoding { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SystemConfigNotifyTopup {\n");
            sb.Append("  DefaultTo: ").Append(DefaultTo).Append("\n");
            sb.Append("  HtmlContentTransferEncoding: ").Append(HtmlContentTransferEncoding).Append("\n");
            sb.Append("  TextContentTransferEncoding: ").Append(TextContentTransferEncoding).Append("\n");
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
            return this.Equals(input as SystemConfigNotifyTopup);
        }

        /// <summary>
        /// Returns true if SystemConfigNotifyTopup instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemConfigNotifyTopup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemConfigNotifyTopup input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DefaultTo == input.DefaultTo ||
                    (this.DefaultTo != null &&
                    this.DefaultTo.Equals(input.DefaultTo))
                ) && 
                (
                    this.HtmlContentTransferEncoding == input.HtmlContentTransferEncoding ||
                    (this.HtmlContentTransferEncoding != null &&
                    this.HtmlContentTransferEncoding.Equals(input.HtmlContentTransferEncoding))
                ) && 
                (
                    this.TextContentTransferEncoding == input.TextContentTransferEncoding ||
                    (this.TextContentTransferEncoding != null &&
                    this.TextContentTransferEncoding.Equals(input.TextContentTransferEncoding))
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
                if (this.DefaultTo != null)
                    hashCode = hashCode * 59 + this.DefaultTo.GetHashCode();
                if (this.HtmlContentTransferEncoding != null)
                    hashCode = hashCode * 59 + this.HtmlContentTransferEncoding.GetHashCode();
                if (this.TextContentTransferEncoding != null)
                    hashCode = hashCode * 59 + this.TextContentTransferEncoding.GetHashCode();
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