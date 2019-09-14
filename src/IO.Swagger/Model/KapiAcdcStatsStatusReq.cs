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
    /// AMQP API for acdc_stats.status_req
    /// </summary>
    [DataContract]
    public partial class KapiAcdcStatsStatusReq :  IEquatable<KapiAcdcStatsStatusReq>, IValidatableObject
    {
        /// <summary>
        /// Defines EventCategory
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventCategoryEnum
        {
            
            /// <summary>
            /// Enum Acdcstat for value: acdc_stat
            /// </summary>
            [EnumMember(Value = "acdc_stat")]
            Acdcstat = 1
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
            /// Enum Statusreq for value: status_req
            /// </summary>
            [EnumMember(Value = "status_req")]
            Statusreq = 1
        }

        /// <summary>
        /// Gets or Sets EventName
        /// </summary>
        [DataMember(Name="Event-Name", EmitDefaultValue=false)]
        public EventNameEnum? EventName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiAcdcStatsStatusReq" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KapiAcdcStatsStatusReq() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiAcdcStatsStatusReq" /> class.
        /// </summary>
        /// <param name="accountID">accountID (required).</param>
        /// <param name="agentID">agentID.</param>
        /// <param name="endRange">endRange.</param>
        /// <param name="eventCategory">eventCategory.</param>
        /// <param name="eventName">eventName.</param>
        /// <param name="limit">limit.</param>
        /// <param name="startRange">startRange.</param>
        /// <param name="status">status.</param>
        public KapiAcdcStatsStatusReq(string accountID = default(string), string agentID = default(string), string endRange = default(string), EventCategoryEnum? eventCategory = default(EventCategoryEnum?), EventNameEnum? eventName = default(EventNameEnum?), string limit = default(string), string startRange = default(string), string status = default(string))
        {
            // to ensure "accountID" is required (not null)
            if (accountID == null)
            {
                throw new InvalidDataException("accountID is a required property for KapiAcdcStatsStatusReq and cannot be null");
            }
            else
            {
                this.AccountID = accountID;
            }
            this.AgentID = agentID;
            this.EndRange = endRange;
            this.EventCategory = eventCategory;
            this.EventName = eventName;
            this.Limit = limit;
            this.StartRange = startRange;
            this.Status = status;
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
        /// Gets or Sets EndRange
        /// </summary>
        [DataMember(Name="End-Range", EmitDefaultValue=false)]
        public string EndRange { get; set; }



        /// <summary>
        /// Gets or Sets Limit
        /// </summary>
        [DataMember(Name="Limit", EmitDefaultValue=false)]
        public string Limit { get; set; }

        /// <summary>
        /// Gets or Sets StartRange
        /// </summary>
        [DataMember(Name="Start-Range", EmitDefaultValue=false)]
        public string StartRange { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KapiAcdcStatsStatusReq {\n");
            sb.Append("  AccountID: ").Append(AccountID).Append("\n");
            sb.Append("  AgentID: ").Append(AgentID).Append("\n");
            sb.Append("  EndRange: ").Append(EndRange).Append("\n");
            sb.Append("  EventCategory: ").Append(EventCategory).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  StartRange: ").Append(StartRange).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as KapiAcdcStatsStatusReq);
        }

        /// <summary>
        /// Returns true if KapiAcdcStatsStatusReq instances are equal
        /// </summary>
        /// <param name="input">Instance of KapiAcdcStatsStatusReq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KapiAcdcStatsStatusReq input)
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
                    this.EndRange == input.EndRange ||
                    (this.EndRange != null &&
                    this.EndRange.Equals(input.EndRange))
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
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.StartRange == input.StartRange ||
                    (this.StartRange != null &&
                    this.StartRange.Equals(input.StartRange))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.EndRange != null)
                    hashCode = hashCode * 59 + this.EndRange.GetHashCode();
                if (this.EventCategory != null)
                    hashCode = hashCode * 59 + this.EventCategory.GetHashCode();
                if (this.EventName != null)
                    hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.StartRange != null)
                    hashCode = hashCode * 59 + this.StartRange.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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