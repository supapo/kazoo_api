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
    /// Validator for the faxbox callflow data object
    /// </summary>
    [DataContract]
    public partial class CallflowsFaxbox :  IEquatable<CallflowsFaxbox>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CallflowsFaxbox" /> class.
        /// </summary>
        /// <param name="faxboxId">ID of the faxbox.</param>
        /// <param name="id">ID of the faxbox.</param>
        /// <param name="media">media.</param>
        /// <param name="skipModule">When set to true this callflow action is skipped, advancing to the wildcard branch (if any).</param>
        public CallflowsFaxbox(string faxboxId = default(string), string id = default(string), CallflowsFaxboxMedia media = default(CallflowsFaxboxMedia), bool? skipModule = default(bool?))
        {
            this.FaxboxId = faxboxId;
            this.Id = id;
            this.Media = media;
            this.SkipModule = skipModule;
        }
        
        /// <summary>
        /// ID of the faxbox
        /// </summary>
        /// <value>ID of the faxbox</value>
        [DataMember(Name="faxbox_id", EmitDefaultValue=false)]
        public string FaxboxId { get; set; }

        /// <summary>
        /// ID of the faxbox
        /// </summary>
        /// <value>ID of the faxbox</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Media
        /// </summary>
        [DataMember(Name="media", EmitDefaultValue=false)]
        public CallflowsFaxboxMedia Media { get; set; }

        /// <summary>
        /// When set to true this callflow action is skipped, advancing to the wildcard branch (if any)
        /// </summary>
        /// <value>When set to true this callflow action is skipped, advancing to the wildcard branch (if any)</value>
        [DataMember(Name="skip_module", EmitDefaultValue=false)]
        public bool? SkipModule { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CallflowsFaxbox {\n");
            sb.Append("  FaxboxId: ").Append(FaxboxId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Media: ").Append(Media).Append("\n");
            sb.Append("  SkipModule: ").Append(SkipModule).Append("\n");
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
            return this.Equals(input as CallflowsFaxbox);
        }

        /// <summary>
        /// Returns true if CallflowsFaxbox instances are equal
        /// </summary>
        /// <param name="input">Instance of CallflowsFaxbox to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallflowsFaxbox input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FaxboxId == input.FaxboxId ||
                    (this.FaxboxId != null &&
                    this.FaxboxId.Equals(input.FaxboxId))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Media == input.Media ||
                    (this.Media != null &&
                    this.Media.Equals(input.Media))
                ) && 
                (
                    this.SkipModule == input.SkipModule ||
                    (this.SkipModule != null &&
                    this.SkipModule.Equals(input.SkipModule))
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
                if (this.FaxboxId != null)
                    hashCode = hashCode * 59 + this.FaxboxId.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Media != null)
                    hashCode = hashCode * 59 + this.Media.GetHashCode();
                if (this.SkipModule != null)
                    hashCode = hashCode * 59 + this.SkipModule.GetHashCode();
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
