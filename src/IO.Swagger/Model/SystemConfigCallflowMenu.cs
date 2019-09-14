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
    /// Schema for callflow.menu system_config
    /// </summary>
    [DataContract]
    public partial class SystemConfigCallflowMenu :  IEquatable<SystemConfigCallflowMenu>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemConfigCallflowMenu" /> class.
        /// </summary>
        /// <param name="minGreetingLength">callflow.menu minimum greeting length.</param>
        public SystemConfigCallflowMenu(int? minGreetingLength = default(int?))
        {
            this.MinGreetingLength = minGreetingLength;
        }
        
        /// <summary>
        /// callflow.menu minimum greeting length
        /// </summary>
        /// <value>callflow.menu minimum greeting length</value>
        [DataMember(Name="min_greeting_length", EmitDefaultValue=false)]
        public int? MinGreetingLength { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SystemConfigCallflowMenu {\n");
            sb.Append("  MinGreetingLength: ").Append(MinGreetingLength).Append("\n");
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
            return this.Equals(input as SystemConfigCallflowMenu);
        }

        /// <summary>
        /// Returns true if SystemConfigCallflowMenu instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemConfigCallflowMenu to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemConfigCallflowMenu input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MinGreetingLength == input.MinGreetingLength ||
                    (this.MinGreetingLength != null &&
                    this.MinGreetingLength.Equals(input.MinGreetingLength))
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
                if (this.MinGreetingLength != null)
                    hashCode = hashCode * 59 + this.MinGreetingLength.GetHashCode();
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
