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
    /// schema for attachment ref type storage plan
    /// </summary>
    [DataContract]
    public partial class StoragePlanDatabaseAttachment :  IEquatable<StoragePlanDatabaseAttachment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoragePlanDatabaseAttachment" /> class.
        /// </summary>
        /// <param name="handler">handler.</param>
        /// <param name="_params">_params.</param>
        /// <param name="stub">stub.</param>
        public StoragePlanDatabaseAttachment(string handler = default(string), StoragePlanDatabaseAttachmentParams _params = default(StoragePlanDatabaseAttachmentParams), bool? stub = default(bool?))
        {
            this.Handler = handler;
            this.Params = _params;
            this.Stub = stub;
        }
        
        /// <summary>
        /// Gets or Sets Handler
        /// </summary>
        [DataMember(Name="handler", EmitDefaultValue=false)]
        public string Handler { get; set; }

        /// <summary>
        /// Gets or Sets Params
        /// </summary>
        [DataMember(Name="params", EmitDefaultValue=false)]
        public StoragePlanDatabaseAttachmentParams Params { get; set; }

        /// <summary>
        /// Gets or Sets Stub
        /// </summary>
        [DataMember(Name="stub", EmitDefaultValue=false)]
        public bool? Stub { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StoragePlanDatabaseAttachment {\n");
            sb.Append("  Handler: ").Append(Handler).Append("\n");
            sb.Append("  Params: ").Append(Params).Append("\n");
            sb.Append("  Stub: ").Append(Stub).Append("\n");
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
            return this.Equals(input as StoragePlanDatabaseAttachment);
        }

        /// <summary>
        /// Returns true if StoragePlanDatabaseAttachment instances are equal
        /// </summary>
        /// <param name="input">Instance of StoragePlanDatabaseAttachment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StoragePlanDatabaseAttachment input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Handler == input.Handler ||
                    (this.Handler != null &&
                    this.Handler.Equals(input.Handler))
                ) && 
                (
                    this.Params == input.Params ||
                    (this.Params != null &&
                    this.Params.Equals(input.Params))
                ) && 
                (
                    this.Stub == input.Stub ||
                    (this.Stub != null &&
                    this.Stub.Equals(input.Stub))
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
                if (this.Handler != null)
                    hashCode = hashCode * 59 + this.Handler.GetHashCode();
                if (this.Params != null)
                    hashCode = hashCode * 59 + this.Params.GetHashCode();
                if (this.Stub != null)
                    hashCode = hashCode * 59 + this.Stub.GetHashCode();
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
