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
    /// SystemConfigAnankeVoicemailNotifyCallback
    /// </summary>
    [DataContract]
    public partial class SystemConfigAnankeVoicemailNotifyCallback :  IEquatable<SystemConfigAnankeVoicemailNotifyCallback>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemConfigAnankeVoicemailNotifyCallback" /> class.
        /// </summary>
        /// <param name="attempts">ananke attempts.</param>
        /// <param name="intervalS">ananke interval in seconds.</param>
        /// <param name="timeoutS">ananke timeout in seconds.</param>
        public SystemConfigAnankeVoicemailNotifyCallback(int? attempts = default(int?), int? intervalS = default(int?), int? timeoutS = default(int?))
        {
            this.Attempts = attempts;
            this.IntervalS = intervalS;
            this.TimeoutS = timeoutS;
        }
        
        /// <summary>
        /// ananke attempts
        /// </summary>
        /// <value>ananke attempts</value>
        [DataMember(Name="attempts", EmitDefaultValue=false)]
        public int? Attempts { get; set; }

        /// <summary>
        /// ananke interval in seconds
        /// </summary>
        /// <value>ananke interval in seconds</value>
        [DataMember(Name="interval_s", EmitDefaultValue=false)]
        public int? IntervalS { get; set; }

        /// <summary>
        /// ananke timeout in seconds
        /// </summary>
        /// <value>ananke timeout in seconds</value>
        [DataMember(Name="timeout_s", EmitDefaultValue=false)]
        public int? TimeoutS { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SystemConfigAnankeVoicemailNotifyCallback {\n");
            sb.Append("  Attempts: ").Append(Attempts).Append("\n");
            sb.Append("  IntervalS: ").Append(IntervalS).Append("\n");
            sb.Append("  TimeoutS: ").Append(TimeoutS).Append("\n");
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
            return this.Equals(input as SystemConfigAnankeVoicemailNotifyCallback);
        }

        /// <summary>
        /// Returns true if SystemConfigAnankeVoicemailNotifyCallback instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemConfigAnankeVoicemailNotifyCallback to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemConfigAnankeVoicemailNotifyCallback input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Attempts == input.Attempts ||
                    (this.Attempts != null &&
                    this.Attempts.Equals(input.Attempts))
                ) && 
                (
                    this.IntervalS == input.IntervalS ||
                    (this.IntervalS != null &&
                    this.IntervalS.Equals(input.IntervalS))
                ) && 
                (
                    this.TimeoutS == input.TimeoutS ||
                    (this.TimeoutS != null &&
                    this.TimeoutS.Equals(input.TimeoutS))
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
                if (this.Attempts != null)
                    hashCode = hashCode * 59 + this.Attempts.GetHashCode();
                if (this.IntervalS != null)
                    hashCode = hashCode * 59 + this.IntervalS.GetHashCode();
                if (this.TimeoutS != null)
                    hashCode = hashCode * 59 + this.TimeoutS.GetHashCode();
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
