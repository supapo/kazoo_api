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
    /// AMQP API for presence.subscribe
    /// </summary>
    [DataContract]
    public partial class KapiPresenceSubscribe :  IEquatable<KapiPresenceSubscribe>, IValidatableObject
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
            /// Enum Subscription for value: subscription
            /// </summary>
            [EnumMember(Value = "subscription")]
            Subscription = 1
        }

        /// <summary>
        /// Gets or Sets EventName
        /// </summary>
        [DataMember(Name="Event-Name", EmitDefaultValue=false)]
        public EventNameEnum? EventName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiPresenceSubscribe" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KapiPresenceSubscribe() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiPresenceSubscribe" /> class.
        /// </summary>
        /// <param name="callID">callID.</param>
        /// <param name="contact">contact.</param>
        /// <param name="eventCategory">eventCategory.</param>
        /// <param name="eventName">eventName.</param>
        /// <param name="eventPackage">eventPackage.</param>
        /// <param name="expires">expires (required).</param>
        /// <param name="from">from.</param>
        /// <param name="fromTag">fromTag.</param>
        /// <param name="queue">queue.</param>
        /// <param name="toTag">toTag.</param>
        /// <param name="user">user (required).</param>
        public KapiPresenceSubscribe(string callID = default(string), string contact = default(string), EventCategoryEnum? eventCategory = default(EventCategoryEnum?), EventNameEnum? eventName = default(EventNameEnum?), string eventPackage = default(string), string expires = default(string), string from = default(string), string fromTag = default(string), string queue = default(string), string toTag = default(string), string user = default(string))
        {
            // to ensure "expires" is required (not null)
            if (expires == null)
            {
                throw new InvalidDataException("expires is a required property for KapiPresenceSubscribe and cannot be null");
            }
            else
            {
                this.Expires = expires;
            }
            // to ensure "user" is required (not null)
            if (user == null)
            {
                throw new InvalidDataException("user is a required property for KapiPresenceSubscribe and cannot be null");
            }
            else
            {
                this.User = user;
            }
            this.CallID = callID;
            this.Contact = contact;
            this.EventCategory = eventCategory;
            this.EventName = eventName;
            this.EventPackage = eventPackage;
            this.From = from;
            this.FromTag = fromTag;
            this.Queue = queue;
            this.ToTag = toTag;
        }
        
        /// <summary>
        /// Gets or Sets CallID
        /// </summary>
        [DataMember(Name="Call-ID", EmitDefaultValue=false)]
        public string CallID { get; set; }

        /// <summary>
        /// Gets or Sets Contact
        /// </summary>
        [DataMember(Name="Contact", EmitDefaultValue=false)]
        public string Contact { get; set; }



        /// <summary>
        /// Gets or Sets EventPackage
        /// </summary>
        [DataMember(Name="Event-Package", EmitDefaultValue=false)]
        public string EventPackage { get; set; }

        /// <summary>
        /// Gets or Sets Expires
        /// </summary>
        [DataMember(Name="Expires", EmitDefaultValue=false)]
        public string Expires { get; set; }

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
        /// Gets or Sets Queue
        /// </summary>
        [DataMember(Name="Queue", EmitDefaultValue=false)]
        public string Queue { get; set; }

        /// <summary>
        /// Gets or Sets ToTag
        /// </summary>
        [DataMember(Name="To-Tag", EmitDefaultValue=false)]
        public string ToTag { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="User", EmitDefaultValue=false)]
        public string User { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KapiPresenceSubscribe {\n");
            sb.Append("  CallID: ").Append(CallID).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  EventCategory: ").Append(EventCategory).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  EventPackage: ").Append(EventPackage).Append("\n");
            sb.Append("  Expires: ").Append(Expires).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  FromTag: ").Append(FromTag).Append("\n");
            sb.Append("  Queue: ").Append(Queue).Append("\n");
            sb.Append("  ToTag: ").Append(ToTag).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
            return this.Equals(input as KapiPresenceSubscribe);
        }

        /// <summary>
        /// Returns true if KapiPresenceSubscribe instances are equal
        /// </summary>
        /// <param name="input">Instance of KapiPresenceSubscribe to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KapiPresenceSubscribe input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CallID == input.CallID ||
                    (this.CallID != null &&
                    this.CallID.Equals(input.CallID))
                ) && 
                (
                    this.Contact == input.Contact ||
                    (this.Contact != null &&
                    this.Contact.Equals(input.Contact))
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
                    this.Expires == input.Expires ||
                    (this.Expires != null &&
                    this.Expires.Equals(input.Expires))
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
                    this.Queue == input.Queue ||
                    (this.Queue != null &&
                    this.Queue.Equals(input.Queue))
                ) && 
                (
                    this.ToTag == input.ToTag ||
                    (this.ToTag != null &&
                    this.ToTag.Equals(input.ToTag))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
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
                if (this.CallID != null)
                    hashCode = hashCode * 59 + this.CallID.GetHashCode();
                if (this.Contact != null)
                    hashCode = hashCode * 59 + this.Contact.GetHashCode();
                if (this.EventCategory != null)
                    hashCode = hashCode * 59 + this.EventCategory.GetHashCode();
                if (this.EventName != null)
                    hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.EventPackage != null)
                    hashCode = hashCode * 59 + this.EventPackage.GetHashCode();
                if (this.Expires != null)
                    hashCode = hashCode * 59 + this.Expires.GetHashCode();
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.FromTag != null)
                    hashCode = hashCode * 59 + this.FromTag.GetHashCode();
                if (this.Queue != null)
                    hashCode = hashCode * 59 + this.Queue.GetHashCode();
                if (this.ToTag != null)
                    hashCode = hashCode * 59 + this.ToTag.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
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
