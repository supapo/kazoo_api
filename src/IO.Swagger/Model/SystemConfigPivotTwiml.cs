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
    /// Schema for pivot.twiml system_config
    /// </summary>
    [DataContract]
    public partial class SystemConfigPivotTwiml :  IEquatable<SystemConfigPivotTwiml>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemConfigPivotTwiml" /> class.
        /// </summary>
        /// <param name="conferenceMoh">Default MOH for conferences dialed via TwiML (default to &quot;$${hold_music}&quot;).</param>
        public SystemConfigPivotTwiml(string conferenceMoh = "$${hold_music}")
        {
            // use default value if no "conferenceMoh" provided
            if (conferenceMoh == null)
            {
                this.ConferenceMoh = "$${hold_music}";
            }
            else
            {
                this.ConferenceMoh = conferenceMoh;
            }
        }
        
        /// <summary>
        /// Default MOH for conferences dialed via TwiML
        /// </summary>
        /// <value>Default MOH for conferences dialed via TwiML</value>
        [DataMember(Name="conference_moh", EmitDefaultValue=false)]
        public string ConferenceMoh { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SystemConfigPivotTwiml {\n");
            sb.Append("  ConferenceMoh: ").Append(ConferenceMoh).Append("\n");
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
            return this.Equals(input as SystemConfigPivotTwiml);
        }

        /// <summary>
        /// Returns true if SystemConfigPivotTwiml instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemConfigPivotTwiml to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemConfigPivotTwiml input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConferenceMoh == input.ConferenceMoh ||
                    (this.ConferenceMoh != null &&
                    this.ConferenceMoh.Equals(input.ConferenceMoh))
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
                if (this.ConferenceMoh != null)
                    hashCode = hashCode * 59 + this.ConferenceMoh.GetHashCode();
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
