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
    /// AMQP API for acdc_stats.status_connecting
    /// </summary>
    [DataContract]
    public partial class KapiAcdcStatsStatusConnecting :  IEquatable<KapiAcdcStatsStatusConnecting>, IValidatableObject
    {
        /// <summary>
        /// Defines EventCategory
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventCategoryEnum
        {
            
            /// <summary>
            /// Enum Acdcstatusstat for value: acdc_status_stat
            /// </summary>
            [EnumMember(Value = "acdc_status_stat")]
            Acdcstatusstat = 1
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
            /// Enum Connecting for value: connecting
            /// </summary>
            [EnumMember(Value = "connecting")]
            Connecting = 1
        }

        /// <summary>
        /// Gets or Sets EventName
        /// </summary>
        [DataMember(Name="Event-Name", EmitDefaultValue=false)]
        public EventNameEnum? EventName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiAcdcStatsStatusConnecting" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KapiAcdcStatsStatusConnecting() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiAcdcStatsStatusConnecting" /> class.
        /// </summary>
        /// <param name="accountID">accountID (required).</param>
        /// <param name="agentID">agentID (required).</param>
        /// <param name="callID">callID.</param>
        /// <param name="callerIDName">callerIDName.</param>
        /// <param name="callerIDNumber">callerIDNumber.</param>
        /// <param name="eventCategory">eventCategory.</param>
        /// <param name="eventName">eventName.</param>
        /// <param name="pauseTime">pauseTime.</param>
        /// <param name="queueID">queueID.</param>
        /// <param name="timestamp">timestamp (required).</param>
        /// <param name="waitTime">waitTime.</param>
        public KapiAcdcStatsStatusConnecting(string accountID = default(string), string agentID = default(string), string callID = default(string), string callerIDName = default(string), string callerIDNumber = default(string), EventCategoryEnum? eventCategory = default(EventCategoryEnum?), EventNameEnum? eventName = default(EventNameEnum?), int? pauseTime = default(int?), string queueID = default(string), string timestamp = default(string), int? waitTime = default(int?))
        {
            // to ensure "accountID" is required (not null)
            if (accountID == null)
            {
                throw new InvalidDataException("accountID is a required property for KapiAcdcStatsStatusConnecting and cannot be null");
            }
            else
            {
                this.AccountID = accountID;
            }
            // to ensure "agentID" is required (not null)
            if (agentID == null)
            {
                throw new InvalidDataException("agentID is a required property for KapiAcdcStatsStatusConnecting and cannot be null");
            }
            else
            {
                this.AgentID = agentID;
            }
            // to ensure "timestamp" is required (not null)
            if (timestamp == null)
            {
                throw new InvalidDataException("timestamp is a required property for KapiAcdcStatsStatusConnecting and cannot be null");
            }
            else
            {
                this.Timestamp = timestamp;
            }
            this.CallID = callID;
            this.CallerIDName = callerIDName;
            this.CallerIDNumber = callerIDNumber;
            this.EventCategory = eventCategory;
            this.EventName = eventName;
            this.PauseTime = pauseTime;
            this.QueueID = queueID;
            this.WaitTime = waitTime;
        }
        
        /// <summary>
        /// Gets or Sets AccountID
        /// </summary>
        [DataMember(Name="Account-ID", EmitDefaultValue=false)]
        public string AccountID { get; set; }

        /// <summary>
        /// Gets or Sets AgentID
        /// </summary>
        [DataMember(Name="Agent-ID", EmitDefaultValue=false)]
        public string AgentID { get; set; }

        /// <summary>
        /// Gets or Sets CallID
        /// </summary>
        [DataMember(Name="Call-ID", EmitDefaultValue=false)]
        public string CallID { get; set; }

        /// <summary>
        /// Gets or Sets CallerIDName
        /// </summary>
        [DataMember(Name="Caller-ID-Name", EmitDefaultValue=false)]
        public string CallerIDName { get; set; }

        /// <summary>
        /// Gets or Sets CallerIDNumber
        /// </summary>
        [DataMember(Name="Caller-ID-Number", EmitDefaultValue=false)]
        public string CallerIDNumber { get; set; }



        /// <summary>
        /// Gets or Sets PauseTime
        /// </summary>
        [DataMember(Name="Pause-Time", EmitDefaultValue=false)]
        public int? PauseTime { get; set; }

        /// <summary>
        /// Gets or Sets QueueID
        /// </summary>
        [DataMember(Name="Queue-ID", EmitDefaultValue=false)]
        public string QueueID { get; set; }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name="Timestamp", EmitDefaultValue=false)]
        public string Timestamp { get; set; }

        /// <summary>
        /// Gets or Sets WaitTime
        /// </summary>
        [DataMember(Name="Wait-Time", EmitDefaultValue=false)]
        public int? WaitTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KapiAcdcStatsStatusConnecting {\n");
            sb.Append("  AccountID: ").Append(AccountID).Append("\n");
            sb.Append("  AgentID: ").Append(AgentID).Append("\n");
            sb.Append("  CallID: ").Append(CallID).Append("\n");
            sb.Append("  CallerIDName: ").Append(CallerIDName).Append("\n");
            sb.Append("  CallerIDNumber: ").Append(CallerIDNumber).Append("\n");
            sb.Append("  EventCategory: ").Append(EventCategory).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  PauseTime: ").Append(PauseTime).Append("\n");
            sb.Append("  QueueID: ").Append(QueueID).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  WaitTime: ").Append(WaitTime).Append("\n");
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
            return this.Equals(input as KapiAcdcStatsStatusConnecting);
        }

        /// <summary>
        /// Returns true if KapiAcdcStatsStatusConnecting instances are equal
        /// </summary>
        /// <param name="input">Instance of KapiAcdcStatsStatusConnecting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KapiAcdcStatsStatusConnecting input)
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
                    this.AgentID == input.AgentID ||
                    (this.AgentID != null &&
                    this.AgentID.Equals(input.AgentID))
                ) && 
                (
                    this.CallID == input.CallID ||
                    (this.CallID != null &&
                    this.CallID.Equals(input.CallID))
                ) && 
                (
                    this.CallerIDName == input.CallerIDName ||
                    (this.CallerIDName != null &&
                    this.CallerIDName.Equals(input.CallerIDName))
                ) && 
                (
                    this.CallerIDNumber == input.CallerIDNumber ||
                    (this.CallerIDNumber != null &&
                    this.CallerIDNumber.Equals(input.CallerIDNumber))
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
                    this.PauseTime == input.PauseTime ||
                    (this.PauseTime != null &&
                    this.PauseTime.Equals(input.PauseTime))
                ) && 
                (
                    this.QueueID == input.QueueID ||
                    (this.QueueID != null &&
                    this.QueueID.Equals(input.QueueID))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.WaitTime == input.WaitTime ||
                    (this.WaitTime != null &&
                    this.WaitTime.Equals(input.WaitTime))
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
                if (this.AgentID != null)
                    hashCode = hashCode * 59 + this.AgentID.GetHashCode();
                if (this.CallID != null)
                    hashCode = hashCode * 59 + this.CallID.GetHashCode();
                if (this.CallerIDName != null)
                    hashCode = hashCode * 59 + this.CallerIDName.GetHashCode();
                if (this.CallerIDNumber != null)
                    hashCode = hashCode * 59 + this.CallerIDNumber.GetHashCode();
                if (this.EventCategory != null)
                    hashCode = hashCode * 59 + this.EventCategory.GetHashCode();
                if (this.EventName != null)
                    hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.PauseTime != null)
                    hashCode = hashCode * 59 + this.PauseTime.GetHashCode();
                if (this.QueueID != null)
                    hashCode = hashCode * 59 + this.QueueID.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.WaitTime != null)
                    hashCode = hashCode * 59 + this.WaitTime.GetHashCode();
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
