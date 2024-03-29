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
    /// AMQP API for acdc_queue.member_call
    /// </summary>
    [DataContract]
    public partial class KapiAcdcQueueMemberCall :  IEquatable<KapiAcdcQueueMemberCall>, IValidatableObject
    {
        /// <summary>
        /// Defines EventCategory
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventCategoryEnum
        {
            
            /// <summary>
            /// Enum Member for value: member
            /// </summary>
            [EnumMember(Value = "member")]
            Member = 1
        }

        /// <summary>
        /// Gets or Sets EventCategory
        /// </summary>
        [DataMember(Name="Event-Category", EmitDefaultValue=false)]
        public EventCategoryEnum? EventCategory { get; set; }
        /// <summary>
        /// Defines EventName
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventNameEnum
        {
            
            /// <summary>
            /// Enum Call for value: call
            /// </summary>
            [EnumMember(Value = "call")]
            Call = 1
        }

        /// <summary>
        /// Gets or Sets EventName
        /// </summary>
        [DataMember(Name="Event-Name", EmitDefaultValue=false)]
        public EventNameEnum? EventName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiAcdcQueueMemberCall" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KapiAcdcQueueMemberCall() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiAcdcQueueMemberCall" /> class.
        /// </summary>
        /// <param name="accountID">accountID (required).</param>
        /// <param name="call">call (required).</param>
        /// <param name="eventCategory">eventCategory.</param>
        /// <param name="eventName">eventName.</param>
        /// <param name="memberPriority">memberPriority.</param>
        /// <param name="queueID">queueID (required).</param>
        public KapiAcdcQueueMemberCall(string accountID = default(string), Object call = default(Object), EventCategoryEnum? eventCategory = default(EventCategoryEnum?), EventNameEnum? eventName = default(EventNameEnum?), int? memberPriority = default(int?), string queueID = default(string))
        {
            // to ensure "accountID" is required (not null)
            if (accountID == null)
            {
                throw new InvalidDataException("accountID is a required property for KapiAcdcQueueMemberCall and cannot be null");
            }
            else
            {
                this.AccountID = accountID;
            }
            // to ensure "call" is required (not null)
            if (call == null)
            {
                throw new InvalidDataException("call is a required property for KapiAcdcQueueMemberCall and cannot be null");
            }
            else
            {
                this.Call = call;
            }
            // to ensure "queueID" is required (not null)
            if (queueID == null)
            {
                throw new InvalidDataException("queueID is a required property for KapiAcdcQueueMemberCall and cannot be null");
            }
            else
            {
                this.QueueID = queueID;
            }
            this.EventCategory = eventCategory;
            this.EventName = eventName;
            this.MemberPriority = memberPriority;
        }
        
        /// <summary>
        /// Gets or Sets AccountID
        /// </summary>
        [DataMember(Name="Account-ID", EmitDefaultValue=false)]
        public string AccountID { get; set; }

        /// <summary>
        /// Gets or Sets Call
        /// </summary>
        [DataMember(Name="Call", EmitDefaultValue=false)]
        public Object Call { get; set; }



        /// <summary>
        /// Gets or Sets MemberPriority
        /// </summary>
        [DataMember(Name="Member-Priority", EmitDefaultValue=false)]
        public int? MemberPriority { get; set; }

        /// <summary>
        /// Gets or Sets QueueID
        /// </summary>
        [DataMember(Name="Queue-ID", EmitDefaultValue=false)]
        public string QueueID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KapiAcdcQueueMemberCall {\n");
            sb.Append("  AccountID: ").Append(AccountID).Append("\n");
            sb.Append("  Call: ").Append(Call).Append("\n");
            sb.Append("  EventCategory: ").Append(EventCategory).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  MemberPriority: ").Append(MemberPriority).Append("\n");
            sb.Append("  QueueID: ").Append(QueueID).Append("\n");
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
            return this.Equals(input as KapiAcdcQueueMemberCall);
        }

        /// <summary>
        /// Returns true if KapiAcdcQueueMemberCall instances are equal
        /// </summary>
        /// <param name="input">Instance of KapiAcdcQueueMemberCall to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KapiAcdcQueueMemberCall input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountID == input.AccountID ||
                    (this.AccountID != null &&
                    this.AccountID.Equals(input.AccountID))
                ) && 
                (
                    this.Call == input.Call ||
                    (this.Call != null &&
                    this.Call.Equals(input.Call))
                ) && 
                (
                    this.EventCategory == input.EventCategory ||
                    (this.EventCategory != null &&
                    this.EventCategory.Equals(input.EventCategory))
                ) && 
                (
                    this.EventName == input.EventName ||
                    (this.EventName != null &&
                    this.EventName.Equals(input.EventName))
                ) && 
                (
                    this.MemberPriority == input.MemberPriority ||
                    (this.MemberPriority != null &&
                    this.MemberPriority.Equals(input.MemberPriority))
                ) && 
                (
                    this.QueueID == input.QueueID ||
                    (this.QueueID != null &&
                    this.QueueID.Equals(input.QueueID))
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
                if (this.AccountID != null)
                    hashCode = hashCode * 59 + this.AccountID.GetHashCode();
                if (this.Call != null)
                    hashCode = hashCode * 59 + this.Call.GetHashCode();
                if (this.EventCategory != null)
                    hashCode = hashCode * 59 + this.EventCategory.GetHashCode();
                if (this.EventName != null)
                    hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.MemberPriority != null)
                    hashCode = hashCode * 59 + this.MemberPriority.GetHashCode();
                if (this.QueueID != null)
                    hashCode = hashCode * 59 + this.QueueID.GetHashCode();
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
