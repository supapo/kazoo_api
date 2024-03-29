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
    /// AMQP API for presence.search_partial_resp
    /// </summary>
    [DataContract]
    public partial class KapiPresenceSearchPartialResp :  IEquatable<KapiPresenceSearchPartialResp>, IValidatableObject
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
            /// Enum Searchpartialresp for value: search_partial_resp
            /// </summary>
            [EnumMember(Value = "search_partial_resp")]
            Searchpartialresp = 1
        }

        /// <summary>
        /// Gets or Sets EventName
        /// </summary>
        [DataMember(Name="Event-Name", EmitDefaultValue=false)]
        public EventNameEnum? EventName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiPresenceSearchPartialResp" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KapiPresenceSearchPartialResp() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiPresenceSearchPartialResp" /> class.
        /// </summary>
        /// <param name="eventCategory">eventCategory.</param>
        /// <param name="eventName">eventName.</param>
        /// <param name="subscriptions">subscriptions (required).</param>
        public KapiPresenceSearchPartialResp(EventCategoryEnum? eventCategory = default(EventCategoryEnum?), EventNameEnum? eventName = default(EventNameEnum?), string subscriptions = default(string))
        {
            // to ensure "subscriptions" is required (not null)
            if (subscriptions == null)
            {
                throw new InvalidDataException("subscriptions is a required property for KapiPresenceSearchPartialResp and cannot be null");
            }
            else
            {
                this.Subscriptions = subscriptions;
            }
            this.EventCategory = eventCategory;
            this.EventName = eventName;
        }
        


        /// <summary>
        /// Gets or Sets Subscriptions
        /// </summary>
        [DataMember(Name="Subscriptions", EmitDefaultValue=false)]
        public string Subscriptions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KapiPresenceSearchPartialResp {\n");
            sb.Append("  EventCategory: ").Append(EventCategory).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  Subscriptions: ").Append(Subscriptions).Append("\n");
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
            return this.Equals(input as KapiPresenceSearchPartialResp);
        }

        /// <summary>
        /// Returns true if KapiPresenceSearchPartialResp instances are equal
        /// </summary>
        /// <param name="input">Instance of KapiPresenceSearchPartialResp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KapiPresenceSearchPartialResp input)
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
                    this.Subscriptions == input.Subscriptions ||
                    (this.Subscriptions != null &&
                    this.Subscriptions.Equals(input.Subscriptions))
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
                if (this.Subscriptions != null)
                    hashCode = hashCode * 59 + this.Subscriptions.GetHashCode();
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
