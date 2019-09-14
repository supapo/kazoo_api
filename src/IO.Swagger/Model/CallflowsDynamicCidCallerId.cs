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
    /// Static Caller ID settings
    /// </summary>
    [DataContract]
    public partial class CallflowsDynamicCidCallerId :  IEquatable<CallflowsDynamicCidCallerId>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CallflowsDynamicCidCallerId" /> class.
        /// </summary>
        /// <param name="name">Caller ID Name.</param>
        /// <param name="number">Caller ID Number.</param>
        public CallflowsDynamicCidCallerId(string name = default(string), string number = default(string))
        {
            this.Name = name;
            this.Number = number;
        }
        
        /// <summary>
        /// Caller ID Name
        /// </summary>
        /// <value>Caller ID Name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Caller ID Number
        /// </summary>
        /// <value>Caller ID Number</value>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public string Number { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CallflowsDynamicCidCallerId {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
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
            return this.Equals(input as CallflowsDynamicCidCallerId);
        }

        /// <summary>
        /// Returns true if CallflowsDynamicCidCallerId instances are equal
        /// </summary>
        /// <param name="input">Instance of CallflowsDynamicCidCallerId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallflowsDynamicCidCallerId input)
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
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
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
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
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
