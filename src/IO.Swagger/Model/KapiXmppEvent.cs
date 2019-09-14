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
    /// AMQP API for xmpp.event
    /// </summary>
    [DataContract]
    public partial class KapiXmppEvent :  IEquatable<KapiXmppEvent>, IValidatableObject
    {
        /// <summary>
        /// Defines EventCategory
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventCategoryEnum
        {
            
            /// <summary>
            /// Enum Xmppevent for value: xmpp_event
            /// </summary>
            [EnumMember(Value = "xmpp_event")]
            Xmppevent = 1
        }

        /// <summary>
        /// Gets or Sets EventCategory
        /// </summary>
        [DataMember(Name="Event-Category", EmitDefaultValue=false)]
        public EventCategoryEnum? EventCategory { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiXmppEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KapiXmppEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiXmppEvent" /> class.
        /// </summary>
        /// <param name="applicationData">applicationData.</param>
        /// <param name="applicationEvent">applicationEvent.</param>
        /// <param name="applicationName">applicationName.</param>
        /// <param name="eventCategory">eventCategory.</param>
        /// <param name="jID">jID (required).</param>
        public KapiXmppEvent(string applicationData = default(string), string applicationEvent = default(string), string applicationName = default(string), EventCategoryEnum? eventCategory = default(EventCategoryEnum?), string jID = default(string))
        {
            // to ensure "jID" is required (not null)
            if (jID == null)
            {
                throw new InvalidDataException("jID is a required property for KapiXmppEvent and cannot be null");
            }
            else
            {
                this.JID = jID;
            }
            this.ApplicationData = applicationData;
            this.ApplicationEvent = applicationEvent;
            this.ApplicationName = applicationName;
            this.EventCategory = eventCategory;
        }
        
        /// <summary>
        /// Gets or Sets ApplicationData
        /// </summary>
        [DataMember(Name="Application-Data", EmitDefaultValue=false)]
        public string ApplicationData { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationEvent
        /// </summary>
        [DataMember(Name="Application-Event", EmitDefaultValue=false)]
        public string ApplicationEvent { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationName
        /// </summary>
        [DataMember(Name="Application-Name", EmitDefaultValue=false)]
        public string ApplicationName { get; set; }


        /// <summary>
        /// Gets or Sets JID
        /// </summary>
        [DataMember(Name="JID", EmitDefaultValue=false)]
        public string JID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KapiXmppEvent {\n");
            sb.Append("  ApplicationData: ").Append(ApplicationData).Append("\n");
            sb.Append("  ApplicationEvent: ").Append(ApplicationEvent).Append("\n");
            sb.Append("  ApplicationName: ").Append(ApplicationName).Append("\n");
            sb.Append("  EventCategory: ").Append(EventCategory).Append("\n");
            sb.Append("  JID: ").Append(JID).Append("\n");
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
            return this.Equals(input as KapiXmppEvent);
        }

        /// <summary>
        /// Returns true if KapiXmppEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of KapiXmppEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KapiXmppEvent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApplicationData == input.ApplicationData ||
                    (this.ApplicationData != null &&
                    this.ApplicationData.Equals(input.ApplicationData))
                ) && 
                (
                    this.ApplicationEvent == input.ApplicationEvent ||
                    (this.ApplicationEvent != null &&
                    this.ApplicationEvent.Equals(input.ApplicationEvent))
                ) && 
                (
                    this.ApplicationName == input.ApplicationName ||
                    (this.ApplicationName != null &&
                    this.ApplicationName.Equals(input.ApplicationName))
                ) && 
                (
                    this.EventCategory == input.EventCategory ||
                    (this.EventCategory != null &&
                    this.EventCategory.Equals(input.EventCategory))
                ) && 
                (
                    this.JID == input.JID ||
                    (this.JID != null &&
                    this.JID.Equals(input.JID))
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
                if (this.ApplicationData != null)
                    hashCode = hashCode * 59 + this.ApplicationData.GetHashCode();
                if (this.ApplicationEvent != null)
                    hashCode = hashCode * 59 + this.ApplicationEvent.GetHashCode();
                if (this.ApplicationName != null)
                    hashCode = hashCode * 59 + this.ApplicationName.GetHashCode();
                if (this.EventCategory != null)
                    hashCode = hashCode * 59 + this.EventCategory.GetHashCode();
                if (this.JID != null)
                    hashCode = hashCode * 59 + this.JID.GetHashCode();
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
