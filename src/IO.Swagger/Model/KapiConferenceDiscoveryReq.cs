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
    /// AMQP API for conference.discovery_req
    /// </summary>
    [DataContract]
    public partial class KapiConferenceDiscoveryReq :  IEquatable<KapiConferenceDiscoveryReq>, IValidatableObject
    {
        /// <summary>
        /// Defines EventCategory
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventCategoryEnum
        {
            
            /// <summary>
            /// Enum Conference for value: conference
            /// </summary>
            [EnumMember(Value = "conference")]
            Conference = 1
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
            /// Enum Discoveryreq for value: discovery_req
            /// </summary>
            [EnumMember(Value = "discovery_req")]
            Discoveryreq = 1
        }

        /// <summary>
        /// Gets or Sets EventName
        /// </summary>
        [DataMember(Name="Event-Name", EmitDefaultValue=false)]
        public EventNameEnum? EventName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiConferenceDiscoveryReq" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KapiConferenceDiscoveryReq() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiConferenceDiscoveryReq" /> class.
        /// </summary>
        /// <param name="call">call (required).</param>
        /// <param name="conferenceDoc">conferenceDoc.</param>
        /// <param name="conferenceID">conferenceID.</param>
        /// <param name="conferenceName">conferenceName.</param>
        /// <param name="eventCategory">eventCategory.</param>
        /// <param name="eventName">eventName.</param>
        /// <param name="moderator">moderator.</param>
        /// <param name="playEntryTone">playEntryTone.</param>
        /// <param name="playExitTone">playExitTone.</param>
        /// <param name="playWelcome">playWelcome.</param>
        /// <param name="playWelcomeMedia">playWelcomeMedia.</param>
        public KapiConferenceDiscoveryReq(Object call = default(Object), string conferenceDoc = default(string), string conferenceID = default(string), string conferenceName = default(string), EventCategoryEnum? eventCategory = default(EventCategoryEnum?), EventNameEnum? eventName = default(EventNameEnum?), bool? moderator = default(bool?), string playEntryTone = default(string), string playExitTone = default(string), bool? playWelcome = default(bool?), string playWelcomeMedia = default(string))
        {
            // to ensure "call" is required (not null)
            if (call == null)
            {
                throw new InvalidDataException("call is a required property for KapiConferenceDiscoveryReq and cannot be null");
            }
            else
            {
                this.Call = call;
            }
            this.ConferenceDoc = conferenceDoc;
            this.ConferenceID = conferenceID;
            this.ConferenceName = conferenceName;
            this.EventCategory = eventCategory;
            this.EventName = eventName;
            this.Moderator = moderator;
            this.PlayEntryTone = playEntryTone;
            this.PlayExitTone = playExitTone;
            this.PlayWelcome = playWelcome;
            this.PlayWelcomeMedia = playWelcomeMedia;
        }
        
        /// <summary>
        /// Gets or Sets Call
        /// </summary>
        [DataMember(Name="Call", EmitDefaultValue=false)]
        public Object Call { get; set; }

        /// <summary>
        /// Gets or Sets ConferenceDoc
        /// </summary>
        [DataMember(Name="Conference-Doc", EmitDefaultValue=false)]
        public string ConferenceDoc { get; set; }

        /// <summary>
        /// Gets or Sets ConferenceID
        /// </summary>
        [DataMember(Name="Conference-ID", EmitDefaultValue=false)]
        public string ConferenceID { get; set; }

        /// <summary>
        /// Gets or Sets ConferenceName
        /// </summary>
        [DataMember(Name="Conference-Name", EmitDefaultValue=false)]
        public string ConferenceName { get; set; }



        /// <summary>
        /// Gets or Sets Moderator
        /// </summary>
        [DataMember(Name="Moderator", EmitDefaultValue=false)]
        public bool? Moderator { get; set; }

        /// <summary>
        /// Gets or Sets PlayEntryTone
        /// </summary>
        [DataMember(Name="Play-Entry-Tone", EmitDefaultValue=false)]
        public string PlayEntryTone { get; set; }

        /// <summary>
        /// Gets or Sets PlayExitTone
        /// </summary>
        [DataMember(Name="Play-Exit-Tone", EmitDefaultValue=false)]
        public string PlayExitTone { get; set; }

        /// <summary>
        /// Gets or Sets PlayWelcome
        /// </summary>
        [DataMember(Name="Play-Welcome", EmitDefaultValue=false)]
        public bool? PlayWelcome { get; set; }

        /// <summary>
        /// Gets or Sets PlayWelcomeMedia
        /// </summary>
        [DataMember(Name="Play-Welcome-Media", EmitDefaultValue=false)]
        public string PlayWelcomeMedia { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KapiConferenceDiscoveryReq {\n");
            sb.Append("  Call: ").Append(Call).Append("\n");
            sb.Append("  ConferenceDoc: ").Append(ConferenceDoc).Append("\n");
            sb.Append("  ConferenceID: ").Append(ConferenceID).Append("\n");
            sb.Append("  ConferenceName: ").Append(ConferenceName).Append("\n");
            sb.Append("  EventCategory: ").Append(EventCategory).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  Moderator: ").Append(Moderator).Append("\n");
            sb.Append("  PlayEntryTone: ").Append(PlayEntryTone).Append("\n");
            sb.Append("  PlayExitTone: ").Append(PlayExitTone).Append("\n");
            sb.Append("  PlayWelcome: ").Append(PlayWelcome).Append("\n");
            sb.Append("  PlayWelcomeMedia: ").Append(PlayWelcomeMedia).Append("\n");
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
            return this.Equals(input as KapiConferenceDiscoveryReq);
        }

        /// <summary>
        /// Returns true if KapiConferenceDiscoveryReq instances are equal
        /// </summary>
        /// <param name="input">Instance of KapiConferenceDiscoveryReq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KapiConferenceDiscoveryReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Call == input.Call ||
                    (this.Call != null &&
                    this.Call.Equals(input.Call))
                ) && 
                (
                    this.ConferenceDoc == input.ConferenceDoc ||
                    (this.ConferenceDoc != null &&
                    this.ConferenceDoc.Equals(input.ConferenceDoc))
                ) && 
                (
                    this.ConferenceID == input.ConferenceID ||
                    (this.ConferenceID != null &&
                    this.ConferenceID.Equals(input.ConferenceID))
                ) && 
                (
                    this.ConferenceName == input.ConferenceName ||
                    (this.ConferenceName != null &&
                    this.ConferenceName.Equals(input.ConferenceName))
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
                    this.Moderator == input.Moderator ||
                    (this.Moderator != null &&
                    this.Moderator.Equals(input.Moderator))
                ) && 
                (
                    this.PlayEntryTone == input.PlayEntryTone ||
                    (this.PlayEntryTone != null &&
                    this.PlayEntryTone.Equals(input.PlayEntryTone))
                ) && 
                (
                    this.PlayExitTone == input.PlayExitTone ||
                    (this.PlayExitTone != null &&
                    this.PlayExitTone.Equals(input.PlayExitTone))
                ) && 
                (
                    this.PlayWelcome == input.PlayWelcome ||
                    (this.PlayWelcome != null &&
                    this.PlayWelcome.Equals(input.PlayWelcome))
                ) && 
                (
                    this.PlayWelcomeMedia == input.PlayWelcomeMedia ||
                    (this.PlayWelcomeMedia != null &&
                    this.PlayWelcomeMedia.Equals(input.PlayWelcomeMedia))
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
                if (this.Call != null)
                    hashCode = hashCode * 59 + this.Call.GetHashCode();
                if (this.ConferenceDoc != null)
                    hashCode = hashCode * 59 + this.ConferenceDoc.GetHashCode();
                if (this.ConferenceID != null)
                    hashCode = hashCode * 59 + this.ConferenceID.GetHashCode();
                if (this.ConferenceName != null)
                    hashCode = hashCode * 59 + this.ConferenceName.GetHashCode();
                if (this.EventCategory != null)
                    hashCode = hashCode * 59 + this.EventCategory.GetHashCode();
                if (this.EventName != null)
                    hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.Moderator != null)
                    hashCode = hashCode * 59 + this.Moderator.GetHashCode();
                if (this.PlayEntryTone != null)
                    hashCode = hashCode * 59 + this.PlayEntryTone.GetHashCode();
                if (this.PlayExitTone != null)
                    hashCode = hashCode * 59 + this.PlayExitTone.GetHashCode();
                if (this.PlayWelcome != null)
                    hashCode = hashCode * 59 + this.PlayWelcome.GetHashCode();
                if (this.PlayWelcomeMedia != null)
                    hashCode = hashCode * 59 + this.PlayWelcomeMedia.GetHashCode();
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