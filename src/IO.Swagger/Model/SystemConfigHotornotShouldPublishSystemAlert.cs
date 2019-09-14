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
    /// SystemConfigHotornotShouldPublishSystemAlert
    /// </summary>
    [DataContract]
    public partial class SystemConfigHotornotShouldPublishSystemAlert :  IEquatable<SystemConfigHotornotShouldPublishSystemAlert>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemConfigHotornotShouldPublishSystemAlert" /> class.
        /// </summary>
        /// <param name="both">hotornot should_publish_system_alert if a rate is missing (default to true).</param>
        /// <param name="inbound">hotornot should_publish_system_alert if inbound rate is missing (default to true).</param>
        /// <param name="outbound">hotornot should_publish_system_alert if outbound rate is missing (default to true).</param>
        public SystemConfigHotornotShouldPublishSystemAlert(bool? both = true, bool? inbound = true, bool? outbound = true)
        {
            // use default value if no "both" provided
            if (both == null)
            {
                this.Both = true;
            }
            else
            {
                this.Both = both;
            }
            // use default value if no "inbound" provided
            if (inbound == null)
            {
                this.Inbound = true;
            }
            else
            {
                this.Inbound = inbound;
            }
            // use default value if no "outbound" provided
            if (outbound == null)
            {
                this.Outbound = true;
            }
            else
            {
                this.Outbound = outbound;
            }
        }
        
        /// <summary>
        /// hotornot should_publish_system_alert if a rate is missing
        /// </summary>
        /// <value>hotornot should_publish_system_alert if a rate is missing</value>
        [DataMember(Name="both", EmitDefaultValue=false)]
        public bool? Both { get; set; }

        /// <summary>
        /// hotornot should_publish_system_alert if inbound rate is missing
        /// </summary>
        /// <value>hotornot should_publish_system_alert if inbound rate is missing</value>
        [DataMember(Name="inbound", EmitDefaultValue=false)]
        public bool? Inbound { get; set; }

        /// <summary>
        /// hotornot should_publish_system_alert if outbound rate is missing
        /// </summary>
        /// <value>hotornot should_publish_system_alert if outbound rate is missing</value>
        [DataMember(Name="outbound", EmitDefaultValue=false)]
        public bool? Outbound { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SystemConfigHotornotShouldPublishSystemAlert {\n");
            sb.Append("  Both: ").Append(Both).Append("\n");
            sb.Append("  Inbound: ").Append(Inbound).Append("\n");
            sb.Append("  Outbound: ").Append(Outbound).Append("\n");
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
            return this.Equals(input as SystemConfigHotornotShouldPublishSystemAlert);
        }

        /// <summary>
        /// Returns true if SystemConfigHotornotShouldPublishSystemAlert instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemConfigHotornotShouldPublishSystemAlert to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemConfigHotornotShouldPublishSystemAlert input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Both == input.Both ||
                    (this.Both != null &&
                    this.Both.Equals(input.Both))
                ) && 
                (
                    this.Inbound == input.Inbound ||
                    (this.Inbound != null &&
                    this.Inbound.Equals(input.Inbound))
                ) && 
                (
                    this.Outbound == input.Outbound ||
                    (this.Outbound != null &&
                    this.Outbound.Equals(input.Outbound))
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
                if (this.Both != null)
                    hashCode = hashCode * 59 + this.Both.GetHashCode();
                if (this.Inbound != null)
                    hashCode = hashCode * 59 + this.Inbound.GetHashCode();
                if (this.Outbound != null)
                    hashCode = hashCode * 59 + this.Outbound.GetHashCode();
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
