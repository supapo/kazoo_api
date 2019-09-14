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
    /// Options passed on to the backend module. These vary by module
    /// </summary>
    [DataContract]
    public partial class SystemConfigEdrOptions :  IEquatable<SystemConfigEdrOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemConfigEdrOptions" /> class.
        /// </summary>
        /// <param name="formatter">formatter.</param>
        public SystemConfigEdrOptions(SystemConfigEdrOptionsFormatter formatter = default(SystemConfigEdrOptionsFormatter))
        {
            this.Formatter = formatter;
        }
        
        /// <summary>
        /// Gets or Sets Formatter
        /// </summary>
        [DataMember(Name="formatter", EmitDefaultValue=false)]
        public SystemConfigEdrOptionsFormatter Formatter { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SystemConfigEdrOptions {\n");
            sb.Append("  Formatter: ").Append(Formatter).Append("\n");
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
            return this.Equals(input as SystemConfigEdrOptions);
        }

        /// <summary>
        /// Returns true if SystemConfigEdrOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemConfigEdrOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemConfigEdrOptions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Formatter == input.Formatter ||
                    (this.Formatter != null &&
                    this.Formatter.Equals(input.Formatter))
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
                if (this.Formatter != null)
                    hashCode = hashCode * 59 + this.Formatter.GetHashCode();
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