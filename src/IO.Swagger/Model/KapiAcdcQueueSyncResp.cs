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
    /// AMQP API for acdc_queue.sync_resp
    /// </summary>
    [DataContract]
    public partial class KapiAcdcQueueSyncResp :  IEquatable<KapiAcdcQueueSyncResp>, IValidatableObject
    {
        /// <summary>
        /// Defines EventCategory
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventCategoryEnum
        {
            
            /// <summary>
            /// Enum Queue for value: queue
            /// </summary>
            [EnumMember(Value = "queue")]
            Queue = 1
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
            /// Enum Syncresp for value: sync_resp
            /// </summary>
            [EnumMember(Value = "sync_resp")]
            Syncresp = 1
        }

        /// <summary>
        /// Gets or Sets EventName
        /// </summary>
        [DataMember(Name="Event-Name", EmitDefaultValue=false)]
        public EventNameEnum? EventName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiAcdcQueueSyncResp" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KapiAcdcQueueSyncResp() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiAcdcQueueSyncResp" /> class.
        /// </summary>
        /// <param name="accountID">accountID (required).</param>
        /// <param name="currentStrategy">currentStrategy (required).</param>
        /// <param name="eventCategory">eventCategory.</param>
        /// <param name="eventName">eventName.</param>
        /// <param name="processID">processID.</param>
        /// <param name="queueID">queueID (required).</param>
        /// <param name="strategyState">strategyState.</param>
        public KapiAcdcQueueSyncResp(string accountID = default(string), string currentStrategy = default(string), EventCategoryEnum? eventCategory = default(EventCategoryEnum?), EventNameEnum? eventName = default(EventNameEnum?), string processID = default(string), string queueID = default(string), string strategyState = default(string))
        {
            // to ensure "accountID" is required (not null)
            if (accountID == null)
            {
                throw new InvalidDataException("accountID is a required property for KapiAcdcQueueSyncResp and cannot be null");
            }
            else
            {
                this.AccountID = accountID;
            }
            // to ensure "currentStrategy" is required (not null)
            if (currentStrategy == null)
            {
                throw new InvalidDataException("currentStrategy is a required property for KapiAcdcQueueSyncResp and cannot be null");
            }
            else
            {
                this.CurrentStrategy = currentStrategy;
            }
            // to ensure "queueID" is required (not null)
            if (queueID == null)
            {
                throw new InvalidDataException("queueID is a required property for KapiAcdcQueueSyncResp and cannot be null");
            }
            else
            {
                this.QueueID = queueID;
            }
            this.EventCategory = eventCategory;
            this.EventName = eventName;
            this.ProcessID = processID;
            this.StrategyState = strategyState;
        }
        
        /// <summary>
        /// Gets or Sets AccountID
        /// </summary>
        [DataMember(Name="Account-ID", EmitDefaultValue=false)]
        public string AccountID { get; set; }

        /// <summary>
        /// Gets or Sets CurrentStrategy
        /// </summary>
        [DataMember(Name="Current-Strategy", EmitDefaultValue=false)]
        public string CurrentStrategy { get; set; }



        /// <summary>
        /// Gets or Sets ProcessID
        /// </summary>
        [DataMember(Name="Process-ID", EmitDefaultValue=false)]
        public string ProcessID { get; set; }

        /// <summary>
        /// Gets or Sets QueueID
        /// </summary>
        [DataMember(Name="Queue-ID", EmitDefaultValue=false)]
        public string QueueID { get; set; }

        /// <summary>
        /// Gets or Sets StrategyState
        /// </summary>
        [DataMember(Name="Strategy-State", EmitDefaultValue=false)]
        public string StrategyState { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KapiAcdcQueueSyncResp {\n");
            sb.Append("  AccountID: ").Append(AccountID).Append("\n");
            sb.Append("  CurrentStrategy: ").Append(CurrentStrategy).Append("\n");
            sb.Append("  EventCategory: ").Append(EventCategory).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  ProcessID: ").Append(ProcessID).Append("\n");
            sb.Append("  QueueID: ").Append(QueueID).Append("\n");
            sb.Append("  StrategyState: ").Append(StrategyState).Append("\n");
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
            return this.Equals(input as KapiAcdcQueueSyncResp);
        }

        /// <summary>
        /// Returns true if KapiAcdcQueueSyncResp instances are equal
        /// </summary>
        /// <param name="input">Instance of KapiAcdcQueueSyncResp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KapiAcdcQueueSyncResp input)
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
                    this.CurrentStrategy == input.CurrentStrategy ||
                    (this.CurrentStrategy != null &&
                    this.CurrentStrategy.Equals(input.CurrentStrategy))
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
                    this.ProcessID == input.ProcessID ||
                    (this.ProcessID != null &&
                    this.ProcessID.Equals(input.ProcessID))
                ) && 
                (
                    this.QueueID == input.QueueID ||
                    (this.QueueID != null &&
                    this.QueueID.Equals(input.QueueID))
                ) && 
                (
                    this.StrategyState == input.StrategyState ||
                    (this.StrategyState != null &&
                    this.StrategyState.Equals(input.StrategyState))
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
                if (this.CurrentStrategy != null)
                    hashCode = hashCode * 59 + this.CurrentStrategy.GetHashCode();
                if (this.EventCategory != null)
                    hashCode = hashCode * 59 + this.EventCategory.GetHashCode();
                if (this.EventName != null)
                    hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.ProcessID != null)
                    hashCode = hashCode * 59 + this.ProcessID.GetHashCode();
                if (this.QueueID != null)
                    hashCode = hashCode * 59 + this.QueueID.GetHashCode();
                if (this.StrategyState != null)
                    hashCode = hashCode * 59 + this.StrategyState.GetHashCode();
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
