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
    /// AMQP API for hangups.query_req
    /// </summary>
    [DataContract]
    public partial class KapiHangupsQueryReq :  IEquatable<KapiHangupsQueryReq>, IValidatableObject
    {
        /// <summary>
        /// Defines EventCategory
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventCategoryEnum
        {
            
            /// <summary>
            /// Enum Hangups for value: hangups
            /// </summary>
            [EnumMember(Value = "hangups")]
            Hangups = 1
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
            /// Enum Queryreq for value: query_req
            /// </summary>
            [EnumMember(Value = "query_req")]
            Queryreq = 1
        }

        /// <summary>
        /// Gets or Sets EventName
        /// </summary>
        [DataMember(Name="Event-Name", EmitDefaultValue=false)]
        public EventNameEnum? EventName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiHangupsQueryReq" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KapiHangupsQueryReq() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiHangupsQueryReq" /> class.
        /// </summary>
        /// <param name="accountID">accountID.</param>
        /// <param name="eventCategory">eventCategory.</param>
        /// <param name="eventName">eventName.</param>
        /// <param name="hangupCause">hangupCause (required).</param>
        /// <param name="rawData">rawData.</param>
        public KapiHangupsQueryReq(string accountID = default(string), EventCategoryEnum? eventCategory = default(EventCategoryEnum?), EventNameEnum? eventName = default(EventNameEnum?), string hangupCause = default(string), bool? rawData = default(bool?))
        {
            // to ensure "hangupCause" is required (not null)
            if (hangupCause == null)
            {
                throw new InvalidDataException("hangupCause is a required property for KapiHangupsQueryReq and cannot be null");
            }
            else
            {
                this.HangupCause = hangupCause;
            }
            this.AccountID = accountID;
            this.EventCategory = eventCategory;
            this.EventName = eventName;
            this.RawData = rawData;
        }
        
        /// <summary>
        /// Gets or Sets AccountID
        /// </summary>
        [DataMember(Name="Account-ID", EmitDefaultValue=false)]
        public string AccountID { get; set; }



        /// <summary>
        /// Gets or Sets HangupCause
        /// </summary>
        [DataMember(Name="Hangup-Cause", EmitDefaultValue=false)]
        public string HangupCause { get; set; }

        /// <summary>
        /// Gets or Sets RawData
        /// </summary>
        [DataMember(Name="Raw-Data", EmitDefaultValue=false)]
        public bool? RawData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KapiHangupsQueryReq {\n");
            sb.Append("  AccountID: ").Append(AccountID).Append("\n");
            sb.Append("  EventCategory: ").Append(EventCategory).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  HangupCause: ").Append(HangupCause).Append("\n");
            sb.Append("  RawData: ").Append(RawData).Append("\n");
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
            return this.Equals(input as KapiHangupsQueryReq);
        }

        /// <summary>
        /// Returns true if KapiHangupsQueryReq instances are equal
        /// </summary>
        /// <param name="input">Instance of KapiHangupsQueryReq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KapiHangupsQueryReq input)
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
                    this.HangupCause == input.HangupCause ||
                    (this.HangupCause != null &&
                    this.HangupCause.Equals(input.HangupCause))
                ) && 
                (
                    this.RawData == input.RawData ||
                    (this.RawData != null &&
                    this.RawData.Equals(input.RawData))
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
                if (this.EventCategory != null)
                    hashCode = hashCode * 59 + this.EventCategory.GetHashCode();
                if (this.EventName != null)
                    hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.HangupCause != null)
                    hashCode = hashCode * 59 + this.HangupCause.GetHashCode();
                if (this.RawData != null)
                    hashCode = hashCode * 59 + this.RawData.GetHashCode();
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