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
    /// AMQP API for conference.participants_resp
    /// </summary>
    [DataContract]
    public partial class KapiConferenceParticipantsResp :  IEquatable<KapiConferenceParticipantsResp>, IValidatableObject
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
            /// Enum Participantsresp for value: participants_resp
            /// </summary>
            [EnumMember(Value = "participants_resp")]
            Participantsresp = 1
        }

        /// <summary>
        /// Gets or Sets EventName
        /// </summary>
        [DataMember(Name="Event-Name", EmitDefaultValue=false)]
        public EventNameEnum? EventName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiConferenceParticipantsResp" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KapiConferenceParticipantsResp() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiConferenceParticipantsResp" /> class.
        /// </summary>
        /// <param name="conferenceID">conferenceID.</param>
        /// <param name="eventCategory">eventCategory.</param>
        /// <param name="eventName">eventName.</param>
        /// <param name="participants">participants (required).</param>
        public KapiConferenceParticipantsResp(string conferenceID = default(string), EventCategoryEnum? eventCategory = default(EventCategoryEnum?), EventNameEnum? eventName = default(EventNameEnum?), string participants = default(string))
        {
            // to ensure "participants" is required (not null)
            if (participants == null)
            {
                throw new InvalidDataException("participants is a required property for KapiConferenceParticipantsResp and cannot be null");
            }
            else
            {
                this.Participants = participants;
            }
            this.ConferenceID = conferenceID;
            this.EventCategory = eventCategory;
            this.EventName = eventName;
        }
        
        /// <summary>
        /// Gets or Sets ConferenceID
        /// </summary>
        [DataMember(Name="Conference-ID", EmitDefaultValue=false)]
        public string ConferenceID { get; set; }



        /// <summary>
        /// Gets or Sets Participants
        /// </summary>
        [DataMember(Name="Participants", EmitDefaultValue=false)]
        public string Participants { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KapiConferenceParticipantsResp {\n");
            sb.Append("  ConferenceID: ").Append(ConferenceID).Append("\n");
            sb.Append("  EventCategory: ").Append(EventCategory).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  Participants: ").Append(Participants).Append("\n");
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
            return this.Equals(input as KapiConferenceParticipantsResp);
        }

        /// <summary>
        /// Returns true if KapiConferenceParticipantsResp instances are equal
        /// </summary>
        /// <param name="input">Instance of KapiConferenceParticipantsResp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KapiConferenceParticipantsResp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConferenceID == input.ConferenceID ||
                    (this.ConferenceID != null &&
                    this.ConferenceID.Equals(input.ConferenceID))
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
                    this.Participants == input.Participants ||
                    (this.Participants != null &&
                    this.Participants.Equals(input.Participants))
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
                if (this.ConferenceID != null)
                    hashCode = hashCode * 59 + this.ConferenceID.GetHashCode();
                if (this.EventCategory != null)
                    hashCode = hashCode * 59 + this.EventCategory.GetHashCode();
                if (this.EventName != null)
                    hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.Participants != null)
                    hashCode = hashCode * 59 + this.Participants.GetHashCode();
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