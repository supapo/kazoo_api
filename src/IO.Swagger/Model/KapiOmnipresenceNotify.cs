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
    /// AMQP API for omnipresence.notify
    /// </summary>
    [DataContract]
    public partial class KapiOmnipresenceNotify :  IEquatable<KapiOmnipresenceNotify>, IValidatableObject
    {
        /// <summary>
        /// Defines EventCategory
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventCategoryEnum
        {
            
            /// <summary>
            /// Enum Presence for value: presence
            /// </summary>
            [EnumMember(Value = "presence")]
            Presence = 1
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
            /// Enum Notify for value: notify
            /// </summary>
            [EnumMember(Value = "notify")]
            Notify = 1
        }

        /// <summary>
        /// Gets or Sets EventName
        /// </summary>
        [DataMember(Name="Event-Name", EmitDefaultValue=false)]
        public EventNameEnum? EventName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiOmnipresenceNotify" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KapiOmnipresenceNotify() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiOmnipresenceNotify" /> class.
        /// </summary>
        /// <param name="body">body.</param>
        /// <param name="callID">callID.</param>
        /// <param name="eventCategory">eventCategory.</param>
        /// <param name="eventName">eventName.</param>
        /// <param name="eventPackage">eventPackage.</param>
        /// <param name="from">from (required).</param>
        /// <param name="fromTag">fromTag.</param>
        /// <param name="to">to (required).</param>
        /// <param name="toTag">toTag.</param>
        public KapiOmnipresenceNotify(string body = default(string), string callID = default(string), EventCategoryEnum? eventCategory = default(EventCategoryEnum?), EventNameEnum? eventName = default(EventNameEnum?), string eventPackage = default(string), string from = default(string), string fromTag = default(string), string to = default(string), string toTag = default(string))
        {
            // to ensure "from" is required (not null)
            if (from == null)
            {
                throw new InvalidDataException("from is a required property for KapiOmnipresenceNotify and cannot be null");
            }
            else
            {
                this.From = from;
            }
            // to ensure "to" is required (not null)
            if (to == null)
            {
                throw new InvalidDataException("to is a required property for KapiOmnipresenceNotify and cannot be null");
            }
            else
            {
                this.To = to;
            }
            this.Body = body;
            this.CallID = callID;
            this.EventCategory = eventCategory;
            this.EventName = eventName;
            this.EventPackage = eventPackage;
            this.FromTag = fromTag;
            this.ToTag = toTag;
        }
        
        /// <summary>
        /// Gets or Sets Body
        /// </summary>
        [DataMember(Name="Body", EmitDefaultValue=false)]
        public string Body { get; set; }

        /// <summary>
        /// Gets or Sets CallID
        /// </summary>
        [DataMember(Name="Call-ID", EmitDefaultValue=false)]
        public string CallID { get; set; }



        /// <summary>
        /// Gets or Sets EventPackage
        /// </summary>
        [DataMember(Name="Event-Package", EmitDefaultValue=false)]
        public string EventPackage { get; set; }

        /// <summary>
        /// Gets or Sets From
        /// </summary>
        [DataMember(Name="From", EmitDefaultValue=false)]
        public string From { get; set; }

        /// <summary>
        /// Gets or Sets FromTag
        /// </summary>
        [DataMember(Name="From-Tag", EmitDefaultValue=false)]
        public string FromTag { get; set; }

        /// <summary>
        /// Gets or Sets To
        /// </summary>
        [DataMember(Name="To", EmitDefaultValue=false)]
        public string To { get; set; }

        /// <summary>
        /// Gets or Sets ToTag
        /// </summary>
        [DataMember(Name="To-Tag", EmitDefaultValue=false)]
        public string ToTag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KapiOmnipresenceNotify {\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  CallID: ").Append(CallID).Append("\n");
            sb.Append("  EventCategory: ").Append(EventCategory).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  EventPackage: ").Append(EventPackage).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  FromTag: ").Append(FromTag).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  ToTag: ").Append(ToTag).Append("\n");
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
            return this.Equals(input as KapiOmnipresenceNotify);
        }

        /// <summary>
        /// Returns true if KapiOmnipresenceNotify instances are equal
        /// </summary>
        /// <param name="input">Instance of KapiOmnipresenceNotify to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KapiOmnipresenceNotify input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
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
                    this.EventPackage == input.EventPackage ||
                    (this.EventPackage != null &&
                    this.EventPackage.Equals(input.EventPackage))
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.FromTag == input.FromTag ||
                    (this.FromTag != null &&
                    this.FromTag.Equals(input.FromTag))
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.ToTag == input.ToTag ||
                    (this.ToTag != null &&
                    this.ToTag.Equals(input.ToTag))
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
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                if (this.CallID != null)
                    hashCode = hashCode * 59 + this.CallID.GetHashCode();
                if (this.EventCategory != null)
                    hashCode = hashCode * 59 + this.EventCategory.GetHashCode();
                if (this.EventName != null)
                    hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.EventPackage != null)
                    hashCode = hashCode * 59 + this.EventPackage.GetHashCode();
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.FromTag != null)
                    hashCode = hashCode * 59 + this.FromTag.GetHashCode();
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.ToTag != null)
                    hashCode = hashCode * 59 + this.ToTag.GetHashCode();
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