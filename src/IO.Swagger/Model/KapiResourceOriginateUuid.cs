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
    /// AMQP API for resource.originate_uuid
    /// </summary>
    [DataContract]
    public partial class KapiResourceOriginateUuid :  IEquatable<KapiResourceOriginateUuid>, IValidatableObject
    {
        /// <summary>
        /// Defines EventCategory
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventCategoryEnum
        {
            
            /// <summary>
            /// Enum Resource for value: resource
            /// </summary>
            [EnumMember(Value = "resource")]
            Resource = 1
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
            /// Enum Originateuuid for value: originate_uuid
            /// </summary>
            [EnumMember(Value = "originate_uuid")]
            Originateuuid = 1
        }

        /// <summary>
        /// Gets or Sets EventName
        /// </summary>
        [DataMember(Name="Event-Name", EmitDefaultValue=false)]
        public EventNameEnum? EventName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiResourceOriginateUuid" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KapiResourceOriginateUuid() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiResourceOriginateUuid" /> class.
        /// </summary>
        /// <param name="eventCategory">eventCategory.</param>
        /// <param name="eventName">eventName.</param>
        /// <param name="outboundCallControlQueue">outboundCallControlQueue.</param>
        /// <param name="outboundCallID">outboundCallID (required).</param>
        public KapiResourceOriginateUuid(EventCategoryEnum? eventCategory = default(EventCategoryEnum?), EventNameEnum? eventName = default(EventNameEnum?), string outboundCallControlQueue = default(string), string outboundCallID = default(string))
        {
            // to ensure "outboundCallID" is required (not null)
            if (outboundCallID == null)
            {
                throw new InvalidDataException("outboundCallID is a required property for KapiResourceOriginateUuid and cannot be null");
            }
            else
            {
                this.OutboundCallID = outboundCallID;
            }
            this.EventCategory = eventCategory;
            this.EventName = eventName;
            this.OutboundCallControlQueue = outboundCallControlQueue;
        }
        


        /// <summary>
        /// Gets or Sets OutboundCallControlQueue
        /// </summary>
        [DataMember(Name="Outbound-Call-Control-Queue", EmitDefaultValue=false)]
        public string OutboundCallControlQueue { get; set; }

        /// <summary>
        /// Gets or Sets OutboundCallID
        /// </summary>
        [DataMember(Name="Outbound-Call-ID", EmitDefaultValue=false)]
        public string OutboundCallID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KapiResourceOriginateUuid {\n");
            sb.Append("  EventCategory: ").Append(EventCategory).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  OutboundCallControlQueue: ").Append(OutboundCallControlQueue).Append("\n");
            sb.Append("  OutboundCallID: ").Append(OutboundCallID).Append("\n");
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
            return this.Equals(input as KapiResourceOriginateUuid);
        }

        /// <summary>
        /// Returns true if KapiResourceOriginateUuid instances are equal
        /// </summary>
        /// <param name="input">Instance of KapiResourceOriginateUuid to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KapiResourceOriginateUuid input)
        {
            if (input == null)
                return false;

            return 
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
                    this.OutboundCallControlQueue == input.OutboundCallControlQueue ||
                    (this.OutboundCallControlQueue != null &&
                    this.OutboundCallControlQueue.Equals(input.OutboundCallControlQueue))
                ) && 
                (
                    this.OutboundCallID == input.OutboundCallID ||
                    (this.OutboundCallID != null &&
                    this.OutboundCallID.Equals(input.OutboundCallID))
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
                if (this.EventCategory != null)
                    hashCode = hashCode * 59 + this.EventCategory.GetHashCode();
                if (this.EventName != null)
                    hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.OutboundCallControlQueue != null)
                    hashCode = hashCode * 59 + this.OutboundCallControlQueue.GetHashCode();
                if (this.OutboundCallID != null)
                    hashCode = hashCode * 59 + this.OutboundCallID.GetHashCode();
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