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
    /// Schema for resource jobs (bulk number uploads)
    /// </summary>
    [DataContract]
    public partial class ResourceJobs :  IEquatable<ResourceJobs>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceJobs" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ResourceJobs() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceJobs" /> class.
        /// </summary>
        /// <param name="name">A friendly name for the job, if you like.</param>
        /// <param name="numbers">The listing of numbers to import to the account (required).</param>
        /// <param name="resourceId">The Resource ID the numbers are coming from (required).</param>
        public ResourceJobs(string name = default(string), List<string> numbers = default(List<string>), string resourceId = default(string))
        {
            // to ensure "numbers" is required (not null)
            if (numbers == null)
            {
                throw new InvalidDataException("numbers is a required property for ResourceJobs and cannot be null");
            }
            else
            {
                this.Numbers = numbers;
            }
            // to ensure "resourceId" is required (not null)
            if (resourceId == null)
            {
                throw new InvalidDataException("resourceId is a required property for ResourceJobs and cannot be null");
            }
            else
            {
                this.ResourceId = resourceId;
            }
            this.Name = name;
        }
        
        /// <summary>
        /// A friendly name for the job, if you like
        /// </summary>
        /// <value>A friendly name for the job, if you like</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The listing of numbers to import to the account
        /// </summary>
        /// <value>The listing of numbers to import to the account</value>
        [DataMember(Name="numbers", EmitDefaultValue=false)]
        public List<string> Numbers { get; set; }

        /// <summary>
        /// The Resource ID the numbers are coming from
        /// </summary>
        /// <value>The Resource ID the numbers are coming from</value>
        [DataMember(Name="resource_id", EmitDefaultValue=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceJobs {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Numbers: ").Append(Numbers).Append("\n");
            sb.Append("  ResourceId: ").Append(ResourceId).Append("\n");
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
            return this.Equals(input as ResourceJobs);
        }

        /// <summary>
        /// Returns true if ResourceJobs instances are equal
        /// </summary>
        /// <param name="input">Instance of ResourceJobs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResourceJobs input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Numbers == input.Numbers ||
                    this.Numbers != null &&
                    this.Numbers.SequenceEqual(input.Numbers)
                ) && 
                (
                    this.ResourceId == input.ResourceId ||
                    (this.ResourceId != null &&
                    this.ResourceId.Equals(input.ResourceId))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Numbers != null)
                    hashCode = hashCode * 59 + this.Numbers.GetHashCode();
                if (this.ResourceId != null)
                    hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
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
            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 128)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 128.", new [] { "Name" });
            }

            // Name (string) minLength
            if(this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            yield break;
        }
    }

}
