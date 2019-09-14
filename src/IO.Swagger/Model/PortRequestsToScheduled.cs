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
    /// Schema for a port request to be transitioned to the &#39;scheduled&#39; state
    /// </summary>
    [DataContract]
    public partial class PortRequestsToScheduled :  IEquatable<PortRequestsToScheduled>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PortRequestsToScheduled" /> class.
        /// </summary>
        /// <param name="scheduleOn">scheduleOn.</param>
        /// <param name="scheduledDate">Gregorian timestamp at which to perform the porting.</param>
        public PortRequestsToScheduled(PortRequestsToScheduledScheduleOn scheduleOn = default(PortRequestsToScheduledScheduleOn), int? scheduledDate = default(int?))
        {
            this.ScheduleOn = scheduleOn;
            this.ScheduledDate = scheduledDate;
        }
        
        /// <summary>
        /// Gets or Sets ScheduleOn
        /// </summary>
        [DataMember(Name="schedule_on", EmitDefaultValue=false)]
        public PortRequestsToScheduledScheduleOn ScheduleOn { get; set; }

        /// <summary>
        /// Gregorian timestamp at which to perform the porting
        /// </summary>
        /// <value>Gregorian timestamp at which to perform the porting</value>
        [DataMember(Name="scheduled_date", EmitDefaultValue=false)]
        public int? ScheduledDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PortRequestsToScheduled {\n");
            sb.Append("  ScheduleOn: ").Append(ScheduleOn).Append("\n");
            sb.Append("  ScheduledDate: ").Append(ScheduledDate).Append("\n");
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
            return this.Equals(input as PortRequestsToScheduled);
        }

        /// <summary>
        /// Returns true if PortRequestsToScheduled instances are equal
        /// </summary>
        /// <param name="input">Instance of PortRequestsToScheduled to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PortRequestsToScheduled input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ScheduleOn == input.ScheduleOn ||
                    (this.ScheduleOn != null &&
                    this.ScheduleOn.Equals(input.ScheduleOn))
                ) && 
                (
                    this.ScheduledDate == input.ScheduledDate ||
                    (this.ScheduledDate != null &&
                    this.ScheduledDate.Equals(input.ScheduledDate))
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
                if (this.ScheduleOn != null)
                    hashCode = hashCode * 59 + this.ScheduleOn.GetHashCode();
                if (this.ScheduledDate != null)
                    hashCode = hashCode * 59 + this.ScheduledDate.GetHashCode();
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
