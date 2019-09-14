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
    /// Schema for servers system_config
    /// </summary>
    [DataContract]
    public partial class SystemConfigServers :  IEquatable<SystemConfigServers>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemConfigServers" /> class.
        /// </summary>
        /// <param name="clockTimezone">servers clock timezone (default to &quot;UTC&quot;).</param>
        public SystemConfigServers(string clockTimezone = "UTC")
        {
            // use default value if no "clockTimezone" provided
            if (clockTimezone == null)
            {
                this.ClockTimezone = "UTC";
            }
            else
            {
                this.ClockTimezone = clockTimezone;
            }
        }
        
        /// <summary>
        /// servers clock timezone
        /// </summary>
        /// <value>servers clock timezone</value>
        [DataMember(Name="clock_timezone", EmitDefaultValue=false)]
        public string ClockTimezone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SystemConfigServers {\n");
            sb.Append("  ClockTimezone: ").Append(ClockTimezone).Append("\n");
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
            return this.Equals(input as SystemConfigServers);
        }

        /// <summary>
        /// Returns true if SystemConfigServers instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemConfigServers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemConfigServers input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClockTimezone == input.ClockTimezone ||
                    (this.ClockTimezone != null &&
                    this.ClockTimezone.Equals(input.ClockTimezone))
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
                if (this.ClockTimezone != null)
                    hashCode = hashCode * 59 + this.ClockTimezone.GetHashCode();
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