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
    /// Validator for the Voicemail callflow element
    /// </summary>
    [DataContract]
    public partial class CallflowsVoicemail :  IEquatable<CallflowsVoicemail>, IValidatableObject
    {
        /// <summary>
        /// Whether to check voicemail box or compose a new voicemail message
        /// </summary>
        /// <value>Whether to check voicemail box or compose a new voicemail message</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionEnum
        {
            
            /// <summary>
            /// Enum Check for value: check
            /// </summary>
            [EnumMember(Value = "check")]
            Check = 1,
            
            /// <summary>
            /// Enum Compose for value: compose
            /// </summary>
            [EnumMember(Value = "compose")]
            Compose = 2
        }

        /// <summary>
        /// Whether to check voicemail box or compose a new voicemail message
        /// </summary>
        /// <value>Whether to check voicemail box or compose a new voicemail message</value>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public ActionEnum? Action { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CallflowsVoicemail" /> class.
        /// </summary>
        /// <param name="action">Whether to check voicemail box or compose a new voicemail message (default to ActionEnum.Compose).</param>
        /// <param name="calleridMatchLogin">Whether to match the caller ID to a voicemail box (default to false).</param>
        /// <param name="id">The ID of the voicemail box.</param>
        /// <param name="interdigitTimeout">The amount of time (in milliseconds) to wait for the caller to press the next digit after pressing a digit.</param>
        /// <param name="maxMessageLength">Max length of the message that caller can leave in voicemail box.</param>
        /// <param name="singleMailboxLogin">Allow login if caller has a single mailbox (default to false).</param>
        /// <param name="skipModule">When set to true this callflow action is skipped, advancing to the wildcard branch (if any).</param>
        public CallflowsVoicemail(ActionEnum? action = ActionEnum.Compose, bool? calleridMatchLogin = false, string id = default(string), int? interdigitTimeout = default(int?), int? maxMessageLength = default(int?), bool? singleMailboxLogin = false, bool? skipModule = default(bool?))
        {
            // use default value if no "action" provided
            if (action == null)
            {
                this.Action = ActionEnum.Compose;
            }
            else
            {
                this.Action = action;
            }
            // use default value if no "calleridMatchLogin" provided
            if (calleridMatchLogin == null)
            {
                this.CalleridMatchLogin = false;
            }
            else
            {
                this.CalleridMatchLogin = calleridMatchLogin;
            }
            this.Id = id;
            this.InterdigitTimeout = interdigitTimeout;
            this.MaxMessageLength = maxMessageLength;
            // use default value if no "singleMailboxLogin" provided
            if (singleMailboxLogin == null)
            {
                this.SingleMailboxLogin = false;
            }
            else
            {
                this.SingleMailboxLogin = singleMailboxLogin;
            }
            this.SkipModule = skipModule;
        }
        

        /// <summary>
        /// Whether to match the caller ID to a voicemail box
        /// </summary>
        /// <value>Whether to match the caller ID to a voicemail box</value>
        [DataMember(Name="callerid_match_login", EmitDefaultValue=false)]
        public bool? CalleridMatchLogin { get; set; }

        /// <summary>
        /// The ID of the voicemail box
        /// </summary>
        /// <value>The ID of the voicemail box</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The amount of time (in milliseconds) to wait for the caller to press the next digit after pressing a digit
        /// </summary>
        /// <value>The amount of time (in milliseconds) to wait for the caller to press the next digit after pressing a digit</value>
        [DataMember(Name="interdigit_timeout", EmitDefaultValue=false)]
        public int? InterdigitTimeout { get; set; }

        /// <summary>
        /// Max length of the message that caller can leave in voicemail box
        /// </summary>
        /// <value>Max length of the message that caller can leave in voicemail box</value>
        [DataMember(Name="max_message_length", EmitDefaultValue=false)]
        public int? MaxMessageLength { get; set; }

        /// <summary>
        /// Allow login if caller has a single mailbox
        /// </summary>
        /// <value>Allow login if caller has a single mailbox</value>
        [DataMember(Name="single_mailbox_login", EmitDefaultValue=false)]
        public bool? SingleMailboxLogin { get; set; }

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
            sb.Append("class CallflowsVoicemail {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  CalleridMatchLogin: ").Append(CalleridMatchLogin).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InterdigitTimeout: ").Append(InterdigitTimeout).Append("\n");
            sb.Append("  MaxMessageLength: ").Append(MaxMessageLength).Append("\n");
            sb.Append("  SingleMailboxLogin: ").Append(SingleMailboxLogin).Append("\n");
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
            return this.Equals(input as CallflowsVoicemail);
        }

        /// <summary>
        /// Returns true if CallflowsVoicemail instances are equal
        /// </summary>
        /// <param name="input">Instance of CallflowsVoicemail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallflowsVoicemail input)
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
                    this.CalleridMatchLogin == input.CalleridMatchLogin ||
                    (this.CalleridMatchLogin != null &&
                    this.CalleridMatchLogin.Equals(input.CalleridMatchLogin))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.InterdigitTimeout == input.InterdigitTimeout ||
                    (this.InterdigitTimeout != null &&
                    this.InterdigitTimeout.Equals(input.InterdigitTimeout))
                ) && 
                (
                    this.MaxMessageLength == input.MaxMessageLength ||
                    (this.MaxMessageLength != null &&
                    this.MaxMessageLength.Equals(input.MaxMessageLength))
                ) && 
                (
                    this.SingleMailboxLogin == input.SingleMailboxLogin ||
                    (this.SingleMailboxLogin != null &&
                    this.SingleMailboxLogin.Equals(input.SingleMailboxLogin))
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
                if (this.CalleridMatchLogin != null)
                    hashCode = hashCode * 59 + this.CalleridMatchLogin.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.InterdigitTimeout != null)
                    hashCode = hashCode * 59 + this.InterdigitTimeout.GetHashCode();
                if (this.MaxMessageLength != null)
                    hashCode = hashCode * 59 + this.MaxMessageLength.GetHashCode();
                if (this.SingleMailboxLogin != null)
                    hashCode = hashCode * 59 + this.SingleMailboxLogin.GetHashCode();
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
            // Id (string) maxLength
            if(this.Id != null && this.Id.Length > 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, length must be less than 32.", new [] { "Id" });
            }

            // Id (string) minLength
            if(this.Id != null && this.Id.Length < 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, length must be greater than 32.", new [] { "Id" });
            }

            yield break;
        }
    }

}
