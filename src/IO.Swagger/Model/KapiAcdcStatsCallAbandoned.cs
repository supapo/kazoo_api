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
    /// AMQP API for acdc_stats.call_abandoned
    /// </summary>
    [DataContract]
    public partial class KapiAcdcStatsCallAbandoned :  IEquatable<KapiAcdcStatsCallAbandoned>, IValidatableObject
    {
        /// <summary>
        /// Defines EventCategory
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventCategoryEnum
        {
            
            /// <summary>
            /// Enum Acdccallstat for value: acdc_call_stat
            /// </summary>
            [EnumMember(Value = "acdc_call_stat")]
            Acdccallstat = 1
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
            /// Enum Abandoned for value: abandoned
            /// </summary>
            [EnumMember(Value = "abandoned")]
            Abandoned = 1
        }

        /// <summary>
        /// Gets or Sets EventName
        /// </summary>
        [DataMember(Name="Event-Name", EmitDefaultValue=false)]
        public EventNameEnum? EventName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiAcdcStatsCallAbandoned" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KapiAcdcStatsCallAbandoned() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiAcdcStatsCallAbandoned" /> class.
        /// </summary>
        /// <param name="abandonReason">abandonReason.</param>
        /// <param name="abandonTimestamp">abandonTimestamp.</param>
        /// <param name="accountID">accountID (required).</param>
        /// <param name="callID">callID (required).</param>
        /// <param name="eventCategory">eventCategory.</param>
        /// <param name="eventName">eventName.</param>
        /// <param name="queueID">queueID (required).</param>
        public KapiAcdcStatsCallAbandoned(string abandonReason = default(string), string abandonTimestamp = default(string), string accountID = default(string), string callID = default(string), EventCategoryEnum? eventCategory = default(EventCategoryEnum?), EventNameEnum? eventName = default(EventNameEnum?), string queueID = default(string))
        {
            // to ensure "accountID" is required (not null)
            if (accountID == null)
            {
                throw new InvalidDataException("accountID is a required property for KapiAcdcStatsCallAbandoned and cannot be null");
            }
            else
            {
                this.AccountID = accountID;
            }
            // to ensure "callID" is required (not null)
            if (callID == null)
            {
                throw new InvalidDataException("callID is a required property for KapiAcdcStatsCallAbandoned and cannot be null");
            }
            else
            {
                this.CallID = callID;
            }
            // to ensure "queueID" is required (not null)
            if (queueID == null)
            {
                throw new InvalidDataException("queueID is a required property for KapiAcdcStatsCallAbandoned and cannot be null");
            }
            else
            {
                this.QueueID = queueID;
            }
            this.AbandonReason = abandonReason;
            this.AbandonTimestamp = abandonTimestamp;
            this.EventCategory = eventCategory;
            this.EventName = eventName;
        }
        
        /// <summary>
        /// Gets or Sets AbandonReason
        /// </summary>
        [DataMember(Name="Abandon-Reason", EmitDefaultValue=false)]
        public string AbandonReason { get; set; }

        /// <summary>
        /// Gets or Sets AbandonTimestamp
        /// </summary>
        [DataMember(Name="Abandon-Timestamp", EmitDefaultValue=false)]
        public string AbandonTimestamp { get; set; }

        /// <summary>
        /// Gets or Sets AccountID
        /// </summary>
        [DataMember(Name="Account-ID", EmitDefaultValue=false)]
        public string AccountID { get; set; }

        /// <summary>
        /// Gets or Sets CallID
        /// </summary>
        [DataMember(Name="Call-ID", EmitDefaultValue=false)]
        public string CallID { get; set; }



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
            sb.Append("class KapiAcdcStatsCallAbandoned {\n");
            sb.Append("  AbandonReason: ").Append(AbandonReason).Append("\n");
            sb.Append("  AbandonTimestamp: ").Append(AbandonTimestamp).Append("\n");
            sb.Append("  AccountID: ").Append(AccountID).Append("\n");
            sb.Append("  CallID: ").Append(CallID).Append("\n");
            sb.Append("  EventCategory: ").Append(EventCategory).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
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
            return this.Equals(input as KapiAcdcStatsCallAbandoned);
        }

        /// <summary>
        /// Returns true if KapiAcdcStatsCallAbandoned instances are equal
        /// </summary>
        /// <param name="input">Instance of KapiAcdcStatsCallAbandoned to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KapiAcdcStatsCallAbandoned input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AbandonReason == input.AbandonReason ||
                    (this.AbandonReason != null &&
                    this.AbandonReason.Equals(input.AbandonReason))
                ) && 
                (
                    this.AbandonTimestamp == input.AbandonTimestamp ||
                    (this.AbandonTimestamp != null &&
                    this.AbandonTimestamp.Equals(input.AbandonTimestamp))
                ) && 
                (
                    this.AccountID == input.AccountID ||
                    (this.AccountID != null &&
                    this.AccountID.Equals(input.AccountID))
                ) && 
                (
                    this.CallID == input.CallID ||
                    (this.CallID != null &&
                    this.CallID.Equals(input.CallID))
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
                if (this.AbandonReason != null)
                    hashCode = hashCode * 59 + this.AbandonReason.GetHashCode();
                if (this.AbandonTimestamp != null)
                    hashCode = hashCode * 59 + this.AbandonTimestamp.GetHashCode();
                if (this.AccountID != null)
                    hashCode = hashCode * 59 + this.AccountID.GetHashCode();
                if (this.CallID != null)
                    hashCode = hashCode * 59 + this.CallID.GetHashCode();
                if (this.EventCategory != null)
                    hashCode = hashCode * 59 + this.EventCategory.GetHashCode();
                if (this.EventName != null)
                    hashCode = hashCode * 59 + this.EventName.GetHashCode();
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
