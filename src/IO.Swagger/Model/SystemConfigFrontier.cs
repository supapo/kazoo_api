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
    /// Schema for frontier system_config
    /// </summary>
    [DataContract]
    public partial class SystemConfigFrontier :  IEquatable<SystemConfigFrontier>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemConfigFrontier" /> class.
        /// </summary>
        /// <param name="rateLimits">frontier rate limits.</param>
        public SystemConfigFrontier(Object rateLimits = default(Object))
        {
            this.RateLimits = rateLimits;
        }
        
        /// <summary>
        /// frontier rate limits
        /// </summary>
        /// <value>frontier rate limits</value>
        [DataMember(Name="rate_limits", EmitDefaultValue=false)]
        public Object RateLimits { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SystemConfigFrontier {\n");
            sb.Append("  RateLimits: ").Append(RateLimits).Append("\n");
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
            return this.Equals(input as SystemConfigFrontier);
        }

        /// <summary>
        /// Returns true if SystemConfigFrontier instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemConfigFrontier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemConfigFrontier input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RateLimits == input.RateLimits ||
                    (this.RateLimits != null &&
                    this.RateLimits.Equals(input.RateLimits))
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
                if (this.RateLimits != null)
                    hashCode = hashCode * 59 + this.RateLimits.GetHashCode();
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