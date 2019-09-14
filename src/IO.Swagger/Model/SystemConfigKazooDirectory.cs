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
    /// Schema for kazoo_directory system_config
    /// </summary>
    [DataContract]
    public partial class SystemConfigKazooDirectory :  IEquatable<SystemConfigKazooDirectory>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemConfigKazooDirectory" /> class.
        /// </summary>
        /// <param name="restrictToKnownTypes">kazoo_directory restrict_to_known_types (default to false).</param>
        public SystemConfigKazooDirectory(bool? restrictToKnownTypes = false)
        {
            // use default value if no "restrictToKnownTypes" provided
            if (restrictToKnownTypes == null)
            {
                this.RestrictToKnownTypes = false;
            }
            else
            {
                this.RestrictToKnownTypes = restrictToKnownTypes;
            }
        }
        
        /// <summary>
        /// kazoo_directory restrict_to_known_types
        /// </summary>
        /// <value>kazoo_directory restrict_to_known_types</value>
        [DataMember(Name="restrict_to_known_types", EmitDefaultValue=false)]
        public bool? RestrictToKnownTypes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SystemConfigKazooDirectory {\n");
            sb.Append("  RestrictToKnownTypes: ").Append(RestrictToKnownTypes).Append("\n");
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
            return this.Equals(input as SystemConfigKazooDirectory);
        }

        /// <summary>
        /// Returns true if SystemConfigKazooDirectory instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemConfigKazooDirectory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemConfigKazooDirectory input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RestrictToKnownTypes == input.RestrictToKnownTypes ||
                    (this.RestrictToKnownTypes != null &&
                    this.RestrictToKnownTypes.Equals(input.RestrictToKnownTypes))
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
                if (this.RestrictToKnownTypes != null)
                    hashCode = hashCode * 59 + this.RestrictToKnownTypes.GetHashCode();
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
