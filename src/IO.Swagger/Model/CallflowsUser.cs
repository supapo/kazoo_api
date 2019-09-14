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
    /// Validator for the user callflow data object
    /// </summary>
    [DataContract]
    public partial class CallflowsUser :  IEquatable<CallflowsUser>, IValidatableObject
    {
        /// <summary>
        /// Ringing strategy for the endpoint(s)
        /// </summary>
        /// <value>Ringing strategy for the endpoint(s)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StrategyEnum
        {
            
            /// <summary>
            /// Enum Simultaneous for value: simultaneous
            /// </summary>
            [EnumMember(Value = "simultaneous")]
            Simultaneous = 1,
            
            /// <summary>
            /// Enum Single for value: single
            /// </summary>
            [EnumMember(Value = "single")]
            Single = 2
        }

        /// <summary>
        /// Ringing strategy for the endpoint(s)
        /// </summary>
        /// <value>Ringing strategy for the endpoint(s)</value>
        [DataMember(Name="strategy", EmitDefaultValue=false)]
        public StrategyEnum? Strategy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CallflowsUser" /> class.
        /// </summary>
        /// <param name="canCallSelf">Toggle whether devices of this use can call each other.</param>
        /// <param name="canTextSelf">Toggle whether devices of this use can text each other.</param>
        /// <param name="customSipHeaders">KV Object where the name is the SIP header and the value is the SIP field.</param>
        /// <param name="delay">How long to delay the endpoint(s) before bridging.</param>
        /// <param name="failOnSingleReject">If any leg rejects the call, cancel all other legs.</param>
        /// <param name="id">User ID.</param>
        /// <param name="skipModule">When set to true this callflow action is skipped, advancing to the wildcard branch (if any).</param>
        /// <param name="staticInvite">Override the SIP Username.</param>
        /// <param name="strategy">Ringing strategy for the endpoint(s) (default to StrategyEnum.Simultaneous).</param>
        /// <param name="suppressClid">Toggle whether to suppress caller ID.</param>
        /// <param name="timeout">Timeout, in seconds, to wait for answer.</param>
        public CallflowsUser(bool? canCallSelf = default(bool?), bool? canTextSelf = default(bool?), Object customSipHeaders = default(Object), int? delay = default(int?), bool? failOnSingleReject = default(bool?), string id = default(string), bool? skipModule = default(bool?), string staticInvite = default(string), StrategyEnum? strategy = StrategyEnum.Simultaneous, bool? suppressClid = default(bool?), int? timeout = default(int?))
        {
            this.CanCallSelf = canCallSelf;
            this.CanTextSelf = canTextSelf;
            this.CustomSipHeaders = customSipHeaders;
            this.Delay = delay;
            this.FailOnSingleReject = failOnSingleReject;
            this.Id = id;
            this.SkipModule = skipModule;
            this.StaticInvite = staticInvite;
            // use default value if no "strategy" provided
            if (strategy == null)
            {
                this.Strategy = StrategyEnum.Simultaneous;
            }
            else
            {
                this.Strategy = strategy;
            }
            this.SuppressClid = suppressClid;
            this.Timeout = timeout;
        }
        
        /// <summary>
        /// Toggle whether devices of this use can call each other
        /// </summary>
        /// <value>Toggle whether devices of this use can call each other</value>
        [DataMember(Name="can_call_self", EmitDefaultValue=false)]
        public bool? CanCallSelf { get; set; }

        /// <summary>
        /// Toggle whether devices of this use can text each other
        /// </summary>
        /// <value>Toggle whether devices of this use can text each other</value>
        [DataMember(Name="can_text_self", EmitDefaultValue=false)]
        public bool? CanTextSelf { get; set; }

        /// <summary>
        /// KV Object where the name is the SIP header and the value is the SIP field
        /// </summary>
        /// <value>KV Object where the name is the SIP header and the value is the SIP field</value>
        [DataMember(Name="custom_sip_headers", EmitDefaultValue=false)]
        public Object CustomSipHeaders { get; set; }

        /// <summary>
        /// How long to delay the endpoint(s) before bridging
        /// </summary>
        /// <value>How long to delay the endpoint(s) before bridging</value>
        [DataMember(Name="delay", EmitDefaultValue=false)]
        public int? Delay { get; set; }

        /// <summary>
        /// If any leg rejects the call, cancel all other legs
        /// </summary>
        /// <value>If any leg rejects the call, cancel all other legs</value>
        [DataMember(Name="fail_on_single_reject", EmitDefaultValue=false)]
        public bool? FailOnSingleReject { get; set; }

        /// <summary>
        /// User ID
        /// </summary>
        /// <value>User ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// When set to true this callflow action is skipped, advancing to the wildcard branch (if any)
        /// </summary>
        /// <value>When set to true this callflow action is skipped, advancing to the wildcard branch (if any)</value>
        [DataMember(Name="skip_module", EmitDefaultValue=false)]
        public bool? SkipModule { get; set; }

        /// <summary>
        /// Override the SIP Username
        /// </summary>
        /// <value>Override the SIP Username</value>
        [DataMember(Name="static_invite", EmitDefaultValue=false)]
        public string StaticInvite { get; set; }


        /// <summary>
        /// Toggle whether to suppress caller ID
        /// </summary>
        /// <value>Toggle whether to suppress caller ID</value>
        [DataMember(Name="suppress_clid", EmitDefaultValue=false)]
        public bool? SuppressClid { get; set; }

        /// <summary>
        /// Timeout, in seconds, to wait for answer
        /// </summary>
        /// <value>Timeout, in seconds, to wait for answer</value>
        [DataMember(Name="timeout", EmitDefaultValue=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CallflowsUser {\n");
            sb.Append("  CanCallSelf: ").Append(CanCallSelf).Append("\n");
            sb.Append("  CanTextSelf: ").Append(CanTextSelf).Append("\n");
            sb.Append("  CustomSipHeaders: ").Append(CustomSipHeaders).Append("\n");
            sb.Append("  Delay: ").Append(Delay).Append("\n");
            sb.Append("  FailOnSingleReject: ").Append(FailOnSingleReject).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SkipModule: ").Append(SkipModule).Append("\n");
            sb.Append("  StaticInvite: ").Append(StaticInvite).Append("\n");
            sb.Append("  Strategy: ").Append(Strategy).Append("\n");
            sb.Append("  SuppressClid: ").Append(SuppressClid).Append("\n");
            sb.Append("  Timeout: ").Append(Timeout).Append("\n");
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
            return this.Equals(input as CallflowsUser);
        }

        /// <summary>
        /// Returns true if CallflowsUser instances are equal
        /// </summary>
        /// <param name="input">Instance of CallflowsUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallflowsUser input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CanCallSelf == input.CanCallSelf ||
                    (this.CanCallSelf != null &&
                    this.CanCallSelf.Equals(input.CanCallSelf))
                ) && 
                (
                    this.CanTextSelf == input.CanTextSelf ||
                    (this.CanTextSelf != null &&
                    this.CanTextSelf.Equals(input.CanTextSelf))
                ) && 
                (
                    this.CustomSipHeaders == input.CustomSipHeaders ||
                    (this.CustomSipHeaders != null &&
                    this.CustomSipHeaders.Equals(input.CustomSipHeaders))
                ) && 
                (
                    this.Delay == input.Delay ||
                    (this.Delay != null &&
                    this.Delay.Equals(input.Delay))
                ) && 
                (
                    this.FailOnSingleReject == input.FailOnSingleReject ||
                    (this.FailOnSingleReject != null &&
                    this.FailOnSingleReject.Equals(input.FailOnSingleReject))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.SkipModule == input.SkipModule ||
                    (this.SkipModule != null &&
                    this.SkipModule.Equals(input.SkipModule))
                ) && 
                (
                    this.StaticInvite == input.StaticInvite ||
                    (this.StaticInvite != null &&
                    this.StaticInvite.Equals(input.StaticInvite))
                ) && 
                (
                    this.Strategy == input.Strategy ||
                    (this.Strategy != null &&
                    this.Strategy.Equals(input.Strategy))
                ) && 
                (
                    this.SuppressClid == input.SuppressClid ||
                    (this.SuppressClid != null &&
                    this.SuppressClid.Equals(input.SuppressClid))
                ) && 
                (
                    this.Timeout == input.Timeout ||
                    (this.Timeout != null &&
                    this.Timeout.Equals(input.Timeout))
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
                if (this.CanCallSelf != null)
                    hashCode = hashCode * 59 + this.CanCallSelf.GetHashCode();
                if (this.CanTextSelf != null)
                    hashCode = hashCode * 59 + this.CanTextSelf.GetHashCode();
                if (this.CustomSipHeaders != null)
                    hashCode = hashCode * 59 + this.CustomSipHeaders.GetHashCode();
                if (this.Delay != null)
                    hashCode = hashCode * 59 + this.Delay.GetHashCode();
                if (this.FailOnSingleReject != null)
                    hashCode = hashCode * 59 + this.FailOnSingleReject.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.SkipModule != null)
                    hashCode = hashCode * 59 + this.SkipModule.GetHashCode();
                if (this.StaticInvite != null)
                    hashCode = hashCode * 59 + this.StaticInvite.GetHashCode();
                if (this.Strategy != null)
                    hashCode = hashCode * 59 + this.Strategy.GetHashCode();
                if (this.SuppressClid != null)
                    hashCode = hashCode * 59 + this.SuppressClid.GetHashCode();
                if (this.Timeout != null)
                    hashCode = hashCode * 59 + this.Timeout.GetHashCode();
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
