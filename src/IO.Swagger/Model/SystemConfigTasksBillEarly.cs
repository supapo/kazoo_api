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
    /// Schema for tasks.bill_early system_config
    /// </summary>
    [DataContract]
    public partial class SystemConfigTasksBillEarly :  IEquatable<SystemConfigTasksBillEarly>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemConfigTasksBillEarly" /> class.
        /// </summary>
        /// <param name="billEarlyEnabled">Controls whether we should bill early the accounts (default to false).</param>
        /// <param name="howManyEarlyDays">How many days before first of the next month this task should start processing accounts.</param>
        /// <param name="reminderEnabled">Controls whether we should send bill reminder for the accounts a few days before due date (default to false).</param>
        public SystemConfigTasksBillEarly(bool? billEarlyEnabled = false, int? howManyEarlyDays = default(int?), bool? reminderEnabled = false)
        {
            // use default value if no "billEarlyEnabled" provided
            if (billEarlyEnabled == null)
            {
                this.BillEarlyEnabled = false;
            }
            else
            {
                this.BillEarlyEnabled = billEarlyEnabled;
            }
            this.HowManyEarlyDays = howManyEarlyDays;
            // use default value if no "reminderEnabled" provided
            if (reminderEnabled == null)
            {
                this.ReminderEnabled = false;
            }
            else
            {
                this.ReminderEnabled = reminderEnabled;
            }
        }
        
        /// <summary>
        /// Controls whether we should bill early the accounts
        /// </summary>
        /// <value>Controls whether we should bill early the accounts</value>
        [DataMember(Name="bill_early_enabled", EmitDefaultValue=false)]
        public bool? BillEarlyEnabled { get; set; }

        /// <summary>
        /// How many days before first of the next month this task should start processing accounts
        /// </summary>
        /// <value>How many days before first of the next month this task should start processing accounts</value>
        [DataMember(Name="how_many_early_days", EmitDefaultValue=false)]
        public int? HowManyEarlyDays { get; set; }

        /// <summary>
        /// Controls whether we should send bill reminder for the accounts a few days before due date
        /// </summary>
        /// <value>Controls whether we should send bill reminder for the accounts a few days before due date</value>
        [DataMember(Name="reminder_enabled", EmitDefaultValue=false)]
        public bool? ReminderEnabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SystemConfigTasksBillEarly {\n");
            sb.Append("  BillEarlyEnabled: ").Append(BillEarlyEnabled).Append("\n");
            sb.Append("  HowManyEarlyDays: ").Append(HowManyEarlyDays).Append("\n");
            sb.Append("  ReminderEnabled: ").Append(ReminderEnabled).Append("\n");
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
            return this.Equals(input as SystemConfigTasksBillEarly);
        }

        /// <summary>
        /// Returns true if SystemConfigTasksBillEarly instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemConfigTasksBillEarly to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemConfigTasksBillEarly input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BillEarlyEnabled == input.BillEarlyEnabled ||
                    (this.BillEarlyEnabled != null &&
                    this.BillEarlyEnabled.Equals(input.BillEarlyEnabled))
                ) && 
                (
                    this.HowManyEarlyDays == input.HowManyEarlyDays ||
                    (this.HowManyEarlyDays != null &&
                    this.HowManyEarlyDays.Equals(input.HowManyEarlyDays))
                ) && 
                (
                    this.ReminderEnabled == input.ReminderEnabled ||
                    (this.ReminderEnabled != null &&
                    this.ReminderEnabled.Equals(input.ReminderEnabled))
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
                if (this.BillEarlyEnabled != null)
                    hashCode = hashCode * 59 + this.BillEarlyEnabled.GetHashCode();
                if (this.HowManyEarlyDays != null)
                    hashCode = hashCode * 59 + this.HowManyEarlyDays.GetHashCode();
                if (this.ReminderEnabled != null)
                    hashCode = hashCode * 59 + this.ReminderEnabled.GetHashCode();
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
