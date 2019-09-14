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
    /// Origin of ledger
    /// </summary>
    [DataContract]
    public partial class LedgersSource :  IEquatable<LedgersSource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LedgersSource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LedgersSource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LedgersSource" /> class.
        /// </summary>
        /// <param name="id">Source ID (required).</param>
        /// <param name="service">Source service (required).</param>
        public LedgersSource(string id = default(string), string service = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for LedgersSource and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "service" is required (not null)
            if (service == null)
            {
                throw new InvalidDataException("service is a required property for LedgersSource and cannot be null");
            }
            else
            {
                this.Service = service;
            }
        }
        
        /// <summary>
        /// Source ID
        /// </summary>
        /// <value>Source ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Source service
        /// </summary>
        /// <value>Source service</value>
        [DataMember(Name="service", EmitDefaultValue=false)]
        public string Service { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LedgersSource {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Service: ").Append(Service).Append("\n");
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
            return this.Equals(input as LedgersSource);
        }

        /// <summary>
        /// Returns true if LedgersSource instances are equal
        /// </summary>
        /// <param name="input">Instance of LedgersSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LedgersSource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Service == input.Service ||
                    (this.Service != null &&
                    this.Service.Equals(input.Service))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Service != null)
                    hashCode = hashCode * 59 + this.Service.GetHashCode();
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
