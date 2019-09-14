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
    /// Schema for camper system_config
    /// </summary>
    [DataContract]
    public partial class SystemConfigCamper :  IEquatable<SystemConfigCamper>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemConfigCamper" /> class.
        /// </summary>
        /// <param name="stopAfter">camper stop after.</param>
        /// <param name="timeout">camper timeout.</param>
        /// <param name="tries">camper tries.</param>
        /// <param name="tryInterval">camper try interval.</param>
        public SystemConfigCamper(int? stopAfter = default(int?), int? timeout = default(int?), int? tries = default(int?), int? tryInterval = default(int?))
        {
            this.StopAfter = stopAfter;
            this.Timeout = timeout;
            this.Tries = tries;
            this.TryInterval = tryInterval;
        }
        
        /// <summary>
        /// camper stop after
        /// </summary>
        /// <value>camper stop after</value>
        [DataMember(Name="stop_after", EmitDefaultValue=false)]
        public int? StopAfter { get; set; }

        /// <summary>
        /// camper timeout
        /// </summary>
        /// <value>camper timeout</value>
        [DataMember(Name="timeout", EmitDefaultValue=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// camper tries
        /// </summary>
        /// <value>camper tries</value>
        [DataMember(Name="tries", EmitDefaultValue=false)]
        public int? Tries { get; set; }

        /// <summary>
        /// camper try interval
        /// </summary>
        /// <value>camper try interval</value>
        [DataMember(Name="try_interval", EmitDefaultValue=false)]
        public int? TryInterval { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SystemConfigCamper {\n");
            sb.Append("  StopAfter: ").Append(StopAfter).Append("\n");
            sb.Append("  Timeout: ").Append(Timeout).Append("\n");
            sb.Append("  Tries: ").Append(Tries).Append("\n");
            sb.Append("  TryInterval: ").Append(TryInterval).Append("\n");
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
            return this.Equals(input as SystemConfigCamper);
        }

        /// <summary>
        /// Returns true if SystemConfigCamper instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemConfigCamper to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemConfigCamper input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StopAfter == input.StopAfter ||
                    (this.StopAfter != null &&
                    this.StopAfter.Equals(input.StopAfter))
                ) && 
                (
                    this.Timeout == input.Timeout ||
                    (this.Timeout != null &&
                    this.Timeout.Equals(input.Timeout))
                ) && 
                (
                    this.Tries == input.Tries ||
                    (this.Tries != null &&
                    this.Tries.Equals(input.Tries))
                ) && 
                (
                    this.TryInterval == input.TryInterval ||
                    (this.TryInterval != null &&
                    this.TryInterval.Equals(input.TryInterval))
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
                if (this.StopAfter != null)
                    hashCode = hashCode * 59 + this.StopAfter.GetHashCode();
                if (this.Timeout != null)
                    hashCode = hashCode * 59 + this.Timeout.GetHashCode();
                if (this.Tries != null)
                    hashCode = hashCode * 59 + this.Tries.GetHashCode();
                if (this.TryInterval != null)
                    hashCode = hashCode * 59 + this.TryInterval.GetHashCode();
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
