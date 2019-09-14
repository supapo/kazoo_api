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
    /// Schema for crossbar.notifications system_config
    /// </summary>
    [DataContract]
    public partial class SystemConfigCrossbarNotifications :  IEquatable<SystemConfigCrossbarNotifications>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemConfigCrossbarNotifications" /> class.
        /// </summary>
        /// <param name="inheritDefaultValues">crossbar.notifications use parent notifications doc as default values, to be overridden by request data (prior to validation) (default to false).</param>
        /// <param name="notificationTimeoutMs">crossbar.notifications notification timeout in milliseconds.</param>
        public SystemConfigCrossbarNotifications(bool? inheritDefaultValues = false, int? notificationTimeoutMs = default(int?))
        {
            // use default value if no "inheritDefaultValues" provided
            if (inheritDefaultValues == null)
            {
                this.InheritDefaultValues = false;
            }
            else
            {
                this.InheritDefaultValues = inheritDefaultValues;
            }
            this.NotificationTimeoutMs = notificationTimeoutMs;
        }
        
        /// <summary>
        /// crossbar.notifications use parent notifications doc as default values, to be overridden by request data (prior to validation)
        /// </summary>
        /// <value>crossbar.notifications use parent notifications doc as default values, to be overridden by request data (prior to validation)</value>
        [DataMember(Name="inherit_default_values", EmitDefaultValue=false)]
        public bool? InheritDefaultValues { get; set; }

        /// <summary>
        /// crossbar.notifications notification timeout in milliseconds
        /// </summary>
        /// <value>crossbar.notifications notification timeout in milliseconds</value>
        [DataMember(Name="notification_timeout_ms", EmitDefaultValue=false)]
        public int? NotificationTimeoutMs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SystemConfigCrossbarNotifications {\n");
            sb.Append("  InheritDefaultValues: ").Append(InheritDefaultValues).Append("\n");
            sb.Append("  NotificationTimeoutMs: ").Append(NotificationTimeoutMs).Append("\n");
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
            return this.Equals(input as SystemConfigCrossbarNotifications);
        }

        /// <summary>
        /// Returns true if SystemConfigCrossbarNotifications instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemConfigCrossbarNotifications to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemConfigCrossbarNotifications input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InheritDefaultValues == input.InheritDefaultValues ||
                    (this.InheritDefaultValues != null &&
                    this.InheritDefaultValues.Equals(input.InheritDefaultValues))
                ) && 
                (
                    this.NotificationTimeoutMs == input.NotificationTimeoutMs ||
                    (this.NotificationTimeoutMs != null &&
                    this.NotificationTimeoutMs.Equals(input.NotificationTimeoutMs))
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
                if (this.InheritDefaultValues != null)
                    hashCode = hashCode * 59 + this.InheritDefaultValues.GetHashCode();
                if (this.NotificationTimeoutMs != null)
                    hashCode = hashCode * 59 + this.NotificationTimeoutMs.GetHashCode();
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