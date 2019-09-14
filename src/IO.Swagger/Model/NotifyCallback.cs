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
    /// Schema for a callback options
    /// </summary>
    [DataContract]
    public partial class NotifyCallback :  IEquatable<NotifyCallback>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotifyCallback" /> class.
        /// </summary>
        /// <param name="attempts">How many attempts without answer will system do.</param>
        /// <param name="disabled">Determines if the system will call to callback number.</param>
        /// <param name="intervalS">How long will system wait between call back notification attempts.</param>
        /// <param name="number">Number for callback notifications about new messages.</param>
        /// <param name="schedule">Schedules interval between callbacks.</param>
        /// <param name="timeoutS">How long will system wait for answer to callback.</param>
        public NotifyCallback(int? attempts = default(int?), bool? disabled = default(bool?), int? intervalS = default(int?), string number = default(string), List<int?> schedule = default(List<int?>), int? timeoutS = default(int?))
        {
            this.Attempts = attempts;
            this.Disabled = disabled;
            this.IntervalS = intervalS;
            this.Number = number;
            this.Schedule = schedule;
            this.TimeoutS = timeoutS;
        }
        
        /// <summary>
        /// How many attempts without answer will system do
        /// </summary>
        /// <value>How many attempts without answer will system do</value>
        [DataMember(Name="attempts", EmitDefaultValue=false)]
        public int? Attempts { get; set; }

        /// <summary>
        /// Determines if the system will call to callback number
        /// </summary>
        /// <value>Determines if the system will call to callback number</value>
        [DataMember(Name="disabled", EmitDefaultValue=false)]
        public bool? Disabled { get; set; }

        /// <summary>
        /// How long will system wait between call back notification attempts
        /// </summary>
        /// <value>How long will system wait between call back notification attempts</value>
        [DataMember(Name="interval_s", EmitDefaultValue=false)]
        public int? IntervalS { get; set; }

        /// <summary>
        /// Number for callback notifications about new messages
        /// </summary>
        /// <value>Number for callback notifications about new messages</value>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public string Number { get; set; }

        /// <summary>
        /// Schedules interval between callbacks
        /// </summary>
        /// <value>Schedules interval between callbacks</value>
        [DataMember(Name="schedule", EmitDefaultValue=false)]
        public List<int?> Schedule { get; set; }

        /// <summary>
        /// How long will system wait for answer to callback
        /// </summary>
        /// <value>How long will system wait for answer to callback</value>
        [DataMember(Name="timeout_s", EmitDefaultValue=false)]
        public int? TimeoutS { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotifyCallback {\n");
            sb.Append("  Attempts: ").Append(Attempts).Append("\n");
            sb.Append("  Disabled: ").Append(Disabled).Append("\n");
            sb.Append("  IntervalS: ").Append(IntervalS).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
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
            return this.Equals(input as NotifyCallback);
        }

        /// <summary>
        /// Returns true if NotifyCallback instances are equal
        /// </summary>
        /// <param name="input">Instance of NotifyCallback to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotifyCallback input)
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
                    this.Disabled == input.Disabled ||
                    (this.Disabled != null &&
                    this.Disabled.Equals(input.Disabled))
                ) && 
                (
                    this.IntervalS == input.IntervalS ||
                    (this.IntervalS != null &&
                    this.IntervalS.Equals(input.IntervalS))
                ) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.Schedule == input.Schedule ||
                    this.Schedule != null &&
                    this.Schedule.SequenceEqual(input.Schedule)
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
                if (this.Disabled != null)
                    hashCode = hashCode * 59 + this.Disabled.GetHashCode();
                if (this.IntervalS != null)
                    hashCode = hashCode * 59 + this.IntervalS.GetHashCode();
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.Schedule != null)
                    hashCode = hashCode * 59 + this.Schedule.GetHashCode();
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
