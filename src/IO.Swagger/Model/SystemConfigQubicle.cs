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
    /// Schema for qubicle system_config
    /// </summary>
    [DataContract]
    public partial class SystemConfigQubicle :  IEquatable<SystemConfigQubicle>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemConfigQubicle" /> class.
        /// </summary>
        /// <param name="enableEventCallProps">qubicle enable_event_call_props (default to false).</param>
        public SystemConfigQubicle(bool? enableEventCallProps = false)
        {
            // use default value if no "enableEventCallProps" provided
            if (enableEventCallProps == null)
            {
                this.EnableEventCallProps = false;
            }
            else
            {
                this.EnableEventCallProps = enableEventCallProps;
            }
        }
        
        /// <summary>
        /// qubicle enable_event_call_props
        /// </summary>
        /// <value>qubicle enable_event_call_props</value>
        [DataMember(Name="enable_event_call_props", EmitDefaultValue=false)]
        public bool? EnableEventCallProps { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SystemConfigQubicle {\n");
            sb.Append("  EnableEventCallProps: ").Append(EnableEventCallProps).Append("\n");
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
            return this.Equals(input as SystemConfigQubicle);
        }

        /// <summary>
        /// Returns true if SystemConfigQubicle instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemConfigQubicle to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemConfigQubicle input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EnableEventCallProps == input.EnableEventCallProps ||
                    (this.EnableEventCallProps != null &&
                    this.EnableEventCallProps.Equals(input.EnableEventCallProps))
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
                if (this.EnableEventCallProps != null)
                    hashCode = hashCode * 59 + this.EnableEventCallProps.GetHashCode();
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
