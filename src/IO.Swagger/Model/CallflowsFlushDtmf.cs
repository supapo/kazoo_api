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
    /// Validator for the flush_dtmf callflow data object
    /// </summary>
    [DataContract]
    public partial class CallflowsFlushDtmf :  IEquatable<CallflowsFlushDtmf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CallflowsFlushDtmf" /> class.
        /// </summary>
        /// <param name="collectionName">Flush collected DTMF in a named key (default to &quot;default&quot;).</param>
        /// <param name="skipModule">When set to true this callflow action is skipped, advancing to the wildcard branch (if any).</param>
        public CallflowsFlushDtmf(string collectionName = "default", bool? skipModule = default(bool?))
        {
            // use default value if no "collectionName" provided
            if (collectionName == null)
            {
                this.CollectionName = "default";
            }
            else
            {
                this.CollectionName = collectionName;
            }
            this.SkipModule = skipModule;
        }
        
        /// <summary>
        /// Flush collected DTMF in a named key
        /// </summary>
        /// <value>Flush collected DTMF in a named key</value>
        [DataMember(Name="collection_name", EmitDefaultValue=false)]
        public string CollectionName { get; set; }

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
            sb.Append("class CallflowsFlushDtmf {\n");
            sb.Append("  CollectionName: ").Append(CollectionName).Append("\n");
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
            return this.Equals(input as CallflowsFlushDtmf);
        }

        /// <summary>
        /// Returns true if CallflowsFlushDtmf instances are equal
        /// </summary>
        /// <param name="input">Instance of CallflowsFlushDtmf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallflowsFlushDtmf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CollectionName == input.CollectionName ||
                    (this.CollectionName != null &&
                    this.CollectionName.Equals(input.CollectionName))
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
                if (this.CollectionName != null)
                    hashCode = hashCode * 59 + this.CollectionName.GetHashCode();
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
