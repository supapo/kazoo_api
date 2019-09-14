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
    /// Validator for the prepend_cid callflow data object
    /// </summary>
    [DataContract]
    public partial class CallflowsPrependCid :  IEquatable<CallflowsPrependCid>, IValidatableObject
    {
        /// <summary>
        /// Action to perform
        /// </summary>
        /// <value>Action to perform</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionEnum
        {
            
            /// <summary>
            /// Enum Reset for value: reset
            /// </summary>
            [EnumMember(Value = "reset")]
            Reset = 1,
            
            /// <summary>
            /// Enum Prepend for value: prepend
            /// </summary>
            [EnumMember(Value = "prepend")]
            Prepend = 2
        }

        /// <summary>
        /// Action to perform
        /// </summary>
        /// <value>Action to perform</value>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public ActionEnum? Action { get; set; }
        /// <summary>
        /// Apply the prepend to which caller ID
        /// </summary>
        /// <value>Apply the prepend to which caller ID</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ApplyToEnum
        {
            
            /// <summary>
            /// Enum Original for value: original
            /// </summary>
            [EnumMember(Value = "original")]
            Original = 1,
            
            /// <summary>
            /// Enum Current for value: current
            /// </summary>
            [EnumMember(Value = "current")]
            Current = 2
        }

        /// <summary>
        /// Apply the prepend to which caller ID
        /// </summary>
        /// <value>Apply the prepend to which caller ID</value>
        [DataMember(Name="apply_to", EmitDefaultValue=false)]
        public ApplyToEnum? ApplyTo { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CallflowsPrependCid" /> class.
        /// </summary>
        /// <param name="action">Action to perform (default to ActionEnum.Prepend).</param>
        /// <param name="applyTo">Apply the prepend to which caller ID (default to ApplyToEnum.Current).</param>
        /// <param name="callerIdNamePrefix">Prefix caller ID name (default to &quot;&quot;).</param>
        /// <param name="callerIdNumberPrefix">Prefix caller ID number (default to &quot;&quot;).</param>
        /// <param name="skipModule">When set to true this callflow action is skipped, advancing to the wildcard branch (if any).</param>
        public CallflowsPrependCid(ActionEnum? action = ActionEnum.Prepend, ApplyToEnum? applyTo = ApplyToEnum.Current, string callerIdNamePrefix = "", string callerIdNumberPrefix = "", bool? skipModule = default(bool?))
        {
            // use default value if no "action" provided
            if (action == null)
            {
                this.Action = ActionEnum.Prepend;
            }
            else
            {
                this.Action = action;
            }
            // use default value if no "applyTo" provided
            if (applyTo == null)
            {
                this.ApplyTo = ApplyToEnum.Current;
            }
            else
            {
                this.ApplyTo = applyTo;
            }
            // use default value if no "callerIdNamePrefix" provided
            if (callerIdNamePrefix == null)
            {
                this.CallerIdNamePrefix = "";
            }
            else
            {
                this.CallerIdNamePrefix = callerIdNamePrefix;
            }
            // use default value if no "callerIdNumberPrefix" provided
            if (callerIdNumberPrefix == null)
            {
                this.CallerIdNumberPrefix = "";
            }
            else
            {
                this.CallerIdNumberPrefix = callerIdNumberPrefix;
            }
            this.SkipModule = skipModule;
        }
        


        /// <summary>
        /// Prefix caller ID name
        /// </summary>
        /// <value>Prefix caller ID name</value>
        [DataMember(Name="caller_id_name_prefix", EmitDefaultValue=false)]
        public string CallerIdNamePrefix { get; set; }

        /// <summary>
        /// Prefix caller ID number
        /// </summary>
        /// <value>Prefix caller ID number</value>
        [DataMember(Name="caller_id_number_prefix", EmitDefaultValue=false)]
        public string CallerIdNumberPrefix { get; set; }

        /// <summary>
        /// When set to true this callflow action is skipped, advancing to the wildcard branch (if any)
        /// </summary>
        /// <value>When set to true this callflow action is skipped, advancing to the wildcard branch (if any)</value>
        [DataMember(Name="skip_module", EmitDefaultValue=false)]
        public bool? SkipModule { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CallflowsPrependCid {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  ApplyTo: ").Append(ApplyTo).Append("\n");
            sb.Append("  CallerIdNamePrefix: ").Append(CallerIdNamePrefix).Append("\n");
            sb.Append("  CallerIdNumberPrefix: ").Append(CallerIdNumberPrefix).Append("\n");
            sb.Append("  SkipModule: ").Append(SkipModule).Append("\n");
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
            return this.Equals(input as CallflowsPrependCid);
        }

        /// <summary>
        /// Returns true if CallflowsPrependCid instances are equal
        /// </summary>
        /// <param name="input">Instance of CallflowsPrependCid to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallflowsPrependCid input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.ApplyTo == input.ApplyTo ||
                    (this.ApplyTo != null &&
                    this.ApplyTo.Equals(input.ApplyTo))
                ) && 
                (
                    this.CallerIdNamePrefix == input.CallerIdNamePrefix ||
                    (this.CallerIdNamePrefix != null &&
                    this.CallerIdNamePrefix.Equals(input.CallerIdNamePrefix))
                ) && 
                (
                    this.CallerIdNumberPrefix == input.CallerIdNumberPrefix ||
                    (this.CallerIdNumberPrefix != null &&
                    this.CallerIdNumberPrefix.Equals(input.CallerIdNumberPrefix))
                ) && 
                (
                    this.SkipModule == input.SkipModule ||
                    (this.SkipModule != null &&
                    this.SkipModule.Equals(input.SkipModule))
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
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.ApplyTo != null)
                    hashCode = hashCode * 59 + this.ApplyTo.GetHashCode();
                if (this.CallerIdNamePrefix != null)
                    hashCode = hashCode * 59 + this.CallerIdNamePrefix.GetHashCode();
                if (this.CallerIdNumberPrefix != null)
                    hashCode = hashCode * 59 + this.CallerIdNumberPrefix.GetHashCode();
                if (this.SkipModule != null)
                    hashCode = hashCode * 59 + this.SkipModule.GetHashCode();
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
