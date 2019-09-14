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
    /// Validator for the ring_group_toggle callflow data object
    /// </summary>
    [DataContract]
    public partial class CallflowsRingGroupToggle :  IEquatable<CallflowsRingGroupToggle>, IValidatableObject
    {
        /// <summary>
        /// What the module should do. Options are &#39;login&#39; and &#39;logout&#39;
        /// </summary>
        /// <value>What the module should do. Options are &#39;login&#39; and &#39;logout&#39;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionEnum
        {
            
            /// <summary>
            /// Enum Login for value: login
            /// </summary>
            [EnumMember(Value = "login")]
            Login = 1,
            
            /// <summary>
            /// Enum Logout for value: logout
            /// </summary>
            [EnumMember(Value = "logout")]
            Logout = 2
        }

        /// <summary>
        /// What the module should do. Options are &#39;login&#39; and &#39;logout&#39;
        /// </summary>
        /// <value>What the module should do. Options are &#39;login&#39; and &#39;logout&#39;</value>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public ActionEnum Action { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CallflowsRingGroupToggle" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CallflowsRingGroupToggle() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CallflowsRingGroupToggle" /> class.
        /// </summary>
        /// <param name="action">What the module should do. Options are &#39;login&#39; and &#39;logout&#39; (required).</param>
        /// <param name="callflowId">The callflow containing the ring group to log in and out of (required).</param>
        /// <param name="skipModule">When set to true this callflow action is skipped, advancing to the wildcard branch (if any).</param>
        public CallflowsRingGroupToggle(ActionEnum action = default(ActionEnum), string callflowId = default(string), bool? skipModule = default(bool?))
        {
            // to ensure "action" is required (not null)
            if (action == null)
            {
                throw new InvalidDataException("action is a required property for CallflowsRingGroupToggle and cannot be null");
            }
            else
            {
                this.Action = action;
            }
            // to ensure "callflowId" is required (not null)
            if (callflowId == null)
            {
                throw new InvalidDataException("callflowId is a required property for CallflowsRingGroupToggle and cannot be null");
            }
            else
            {
                this.CallflowId = callflowId;
            }
            this.SkipModule = skipModule;
        }
        

        /// <summary>
        /// The callflow containing the ring group to log in and out of
        /// </summary>
        /// <value>The callflow containing the ring group to log in and out of</value>
        [DataMember(Name="callflow_id", EmitDefaultValue=false)]
        public string CallflowId { get; set; }

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
            sb.Append("class CallflowsRingGroupToggle {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  CallflowId: ").Append(CallflowId).Append("\n");
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
            return this.Equals(input as CallflowsRingGroupToggle);
        }

        /// <summary>
        /// Returns true if CallflowsRingGroupToggle instances are equal
        /// </summary>
        /// <param name="input">Instance of CallflowsRingGroupToggle to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallflowsRingGroupToggle input)
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
                    this.CallflowId == input.CallflowId ||
                    (this.CallflowId != null &&
                    this.CallflowId.Equals(input.CallflowId))
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
                if (this.CallflowId != null)
                    hashCode = hashCode * 59 + this.CallflowId.GetHashCode();
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