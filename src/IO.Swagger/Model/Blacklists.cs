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
    /// Schema for a blacklists
    /// </summary>
    [DataContract]
    public partial class Blacklists :  IEquatable<Blacklists>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Blacklists" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Blacklists() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Blacklists" /> class.
        /// </summary>
        /// <param name="flags">Flags set by external applications.</param>
        /// <param name="name">A friendly name for the temporal rule set (required).</param>
        /// <param name="numbers">Map of caller id number to block.</param>
        /// <param name="shouldBlockAnonymous">Should block Anonymous call.</param>
        public Blacklists(List<string> flags = default(List<string>), string name = default(string), Object numbers = default(Object), bool? shouldBlockAnonymous = default(bool?))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Blacklists and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            this.Flags = flags;
            this.Numbers = numbers;
            this.ShouldBlockAnonymous = shouldBlockAnonymous;
        }
        
        /// <summary>
        /// Flags set by external applications
        /// </summary>
        /// <value>Flags set by external applications</value>
        [DataMember(Name="flags", EmitDefaultValue=false)]
        public List<string> Flags { get; set; }

        /// <summary>
        /// A friendly name for the temporal rule set
        /// </summary>
        /// <value>A friendly name for the temporal rule set</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Map of caller id number to block
        /// </summary>
        /// <value>Map of caller id number to block</value>
        [DataMember(Name="numbers", EmitDefaultValue=false)]
        public Object Numbers { get; set; }

        /// <summary>
        /// Should block Anonymous call
        /// </summary>
        /// <value>Should block Anonymous call</value>
        [DataMember(Name="should_block_anonymous", EmitDefaultValue=false)]
        public bool? ShouldBlockAnonymous { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Blacklists {\n");
            sb.Append("  Flags: ").Append(Flags).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Numbers: ").Append(Numbers).Append("\n");
            sb.Append("  ShouldBlockAnonymous: ").Append(ShouldBlockAnonymous).Append("\n");
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
            return this.Equals(input as Blacklists);
        }

        /// <summary>
        /// Returns true if Blacklists instances are equal
        /// </summary>
        /// <param name="input">Instance of Blacklists to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Blacklists input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Flags == input.Flags ||
                    this.Flags != null &&
                    this.Flags.SequenceEqual(input.Flags)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Numbers == input.Numbers ||
                    (this.Numbers != null &&
                    this.Numbers.Equals(input.Numbers))
                ) && 
                (
                    this.ShouldBlockAnonymous == input.ShouldBlockAnonymous ||
                    (this.ShouldBlockAnonymous != null &&
                    this.ShouldBlockAnonymous.Equals(input.ShouldBlockAnonymous))
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
                if (this.Flags != null)
                    hashCode = hashCode * 59 + this.Flags.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Numbers != null)
                    hashCode = hashCode * 59 + this.Numbers.GetHashCode();
                if (this.ShouldBlockAnonymous != null)
                    hashCode = hashCode * 59 + this.ShouldBlockAnonymous.GetHashCode();
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
