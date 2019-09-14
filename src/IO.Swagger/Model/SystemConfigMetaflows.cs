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
    /// Schema for metaflows system_config
    /// </summary>
    [DataContract]
    public partial class SystemConfigMetaflows :  IEquatable<SystemConfigMetaflows>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemConfigMetaflows" /> class.
        /// </summary>
        /// <param name="bindingDigit">metaflows binding digit (default to &quot;*&quot;).</param>
        /// <param name="defaultMetaflow">metaflows default metaflow.</param>
        /// <param name="digitTimeoutMs">metaflows digit timeout in milliseconds.</param>
        /// <param name="listenOn">metaflows listen on (default to &quot;a&quot;).</param>
        /// <param name="numbers">metaflows numbers.</param>
        /// <param name="patterns">metaflows patterns.</param>
        public SystemConfigMetaflows(string bindingDigit = "*", Object defaultMetaflow = default(Object), int? digitTimeoutMs = default(int?), string listenOn = "a", Object numbers = default(Object), Object patterns = default(Object))
        {
            // use default value if no "bindingDigit" provided
            if (bindingDigit == null)
            {
                this.BindingDigit = "*";
            }
            else
            {
                this.BindingDigit = bindingDigit;
            }
            this.DefaultMetaflow = defaultMetaflow;
            this.DigitTimeoutMs = digitTimeoutMs;
            // use default value if no "listenOn" provided
            if (listenOn == null)
            {
                this.ListenOn = "a";
            }
            else
            {
                this.ListenOn = listenOn;
            }
            this.Numbers = numbers;
            this.Patterns = patterns;
        }
        
        /// <summary>
        /// metaflows binding digit
        /// </summary>
        /// <value>metaflows binding digit</value>
        [DataMember(Name="binding_digit", EmitDefaultValue=false)]
        public string BindingDigit { get; set; }

        /// <summary>
        /// metaflows default metaflow
        /// </summary>
        /// <value>metaflows default metaflow</value>
        [DataMember(Name="default_metaflow", EmitDefaultValue=false)]
        public Object DefaultMetaflow { get; set; }

        /// <summary>
        /// metaflows digit timeout in milliseconds
        /// </summary>
        /// <value>metaflows digit timeout in milliseconds</value>
        [DataMember(Name="digit_timeout_ms", EmitDefaultValue=false)]
        public int? DigitTimeoutMs { get; set; }

        /// <summary>
        /// metaflows listen on
        /// </summary>
        /// <value>metaflows listen on</value>
        [DataMember(Name="listen_on", EmitDefaultValue=false)]
        public string ListenOn { get; set; }

        /// <summary>
        /// metaflows numbers
        /// </summary>
        /// <value>metaflows numbers</value>
        [DataMember(Name="numbers", EmitDefaultValue=false)]
        public Object Numbers { get; set; }

        /// <summary>
        /// metaflows patterns
        /// </summary>
        /// <value>metaflows patterns</value>
        [DataMember(Name="patterns", EmitDefaultValue=false)]
        public Object Patterns { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SystemConfigMetaflows {\n");
            sb.Append("  BindingDigit: ").Append(BindingDigit).Append("\n");
            sb.Append("  DefaultMetaflow: ").Append(DefaultMetaflow).Append("\n");
            sb.Append("  DigitTimeoutMs: ").Append(DigitTimeoutMs).Append("\n");
            sb.Append("  ListenOn: ").Append(ListenOn).Append("\n");
            sb.Append("  Numbers: ").Append(Numbers).Append("\n");
            sb.Append("  Patterns: ").Append(Patterns).Append("\n");
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
            return this.Equals(input as SystemConfigMetaflows);
        }

        /// <summary>
        /// Returns true if SystemConfigMetaflows instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemConfigMetaflows to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemConfigMetaflows input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BindingDigit == input.BindingDigit ||
                    (this.BindingDigit != null &&
                    this.BindingDigit.Equals(input.BindingDigit))
                ) && 
                (
                    this.DefaultMetaflow == input.DefaultMetaflow ||
                    (this.DefaultMetaflow != null &&
                    this.DefaultMetaflow.Equals(input.DefaultMetaflow))
                ) && 
                (
                    this.DigitTimeoutMs == input.DigitTimeoutMs ||
                    (this.DigitTimeoutMs != null &&
                    this.DigitTimeoutMs.Equals(input.DigitTimeoutMs))
                ) && 
                (
                    this.ListenOn == input.ListenOn ||
                    (this.ListenOn != null &&
                    this.ListenOn.Equals(input.ListenOn))
                ) && 
                (
                    this.Numbers == input.Numbers ||
                    (this.Numbers != null &&
                    this.Numbers.Equals(input.Numbers))
                ) && 
                (
                    this.Patterns == input.Patterns ||
                    (this.Patterns != null &&
                    this.Patterns.Equals(input.Patterns))
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
                if (this.BindingDigit != null)
                    hashCode = hashCode * 59 + this.BindingDigit.GetHashCode();
                if (this.DefaultMetaflow != null)
                    hashCode = hashCode * 59 + this.DefaultMetaflow.GetHashCode();
                if (this.DigitTimeoutMs != null)
                    hashCode = hashCode * 59 + this.DigitTimeoutMs.GetHashCode();
                if (this.ListenOn != null)
                    hashCode = hashCode * 59 + this.ListenOn.GetHashCode();
                if (this.Numbers != null)
                    hashCode = hashCode * 59 + this.Numbers.GetHashCode();
                if (this.Patterns != null)
                    hashCode = hashCode * 59 + this.Patterns.GetHashCode();
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
