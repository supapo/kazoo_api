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
    /// AMQP API for conference.record
    /// </summary>
    [DataContract]
    public partial class KapiConferenceRecord :  IEquatable<KapiConferenceRecord>, IValidatableObject
    {
        /// <summary>
        /// Defines ApplicationName
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ApplicationNameEnum
        {
            
            /// <summary>
            /// Enum Record for value: record
            /// </summary>
            [EnumMember(Value = "record")]
            Record = 1
        }

        /// <summary>
        /// Gets or Sets ApplicationName
        /// </summary>
        [DataMember(Name="Application-Name", EmitDefaultValue=false)]
        public ApplicationNameEnum ApplicationName { get; set; }
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
            /// Enum Command for value: command
            /// </summary>
            [EnumMember(Value = "command")]
            Command = 1
        }

        /// <summary>
        /// Gets or Sets EventName
        /// </summary>
        [DataMember(Name="Event-Name", EmitDefaultValue=false)]
        public EventNameEnum? EventName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiConferenceRecord" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KapiConferenceRecord() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiConferenceRecord" /> class.
        /// </summary>
        /// <param name="applicationName">applicationName (required).</param>
        /// <param name="callID">callID.</param>
        /// <param name="conferenceID">conferenceID (required).</param>
        /// <param name="eventCategory">eventCategory.</param>
        /// <param name="eventName">eventName.</param>
        /// <param name="mediaName">mediaName (required).</param>
        public KapiConferenceRecord(ApplicationNameEnum applicationName = default(ApplicationNameEnum), string callID = default(string), string conferenceID = default(string), EventCategoryEnum? eventCategory = default(EventCategoryEnum?), EventNameEnum? eventName = default(EventNameEnum?), string mediaName = default(string))
        {
            // to ensure "applicationName" is required (not null)
            if (applicationName == null)
            {
                throw new InvalidDataException("applicationName is a required property for KapiConferenceRecord and cannot be null");
            }
            else
            {
                this.ApplicationName = applicationName;
            }
            // to ensure "conferenceID" is required (not null)
            if (conferenceID == null)
            {
                throw new InvalidDataException("conferenceID is a required property for KapiConferenceRecord and cannot be null");
            }
            else
            {
                this.ConferenceID = conferenceID;
            }
            // to ensure "mediaName" is required (not null)
            if (mediaName == null)
            {
                throw new InvalidDataException("mediaName is a required property for KapiConferenceRecord and cannot be null");
            }
            else
            {
                this.MediaName = mediaName;
            }
            this.CallID = callID;
            this.EventCategory = eventCategory;
            this.EventName = eventName;
        }
        

        /// <summary>
        /// Gets or Sets CallID
        /// </summary>
        [DataMember(Name="Call-ID", EmitDefaultValue=false)]
        public string CallID { get; set; }

        /// <summary>
        /// Gets or Sets ConferenceID
        /// </summary>
        [DataMember(Name="Conference-ID", EmitDefaultValue=false)]
        public string ConferenceID { get; set; }



        /// <summary>
        /// Gets or Sets MediaName
        /// </summary>
        [DataMember(Name="Media-Name", EmitDefaultValue=false)]
        public string MediaName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KapiConferenceRecord {\n");
            sb.Append("  ApplicationName: ").Append(ApplicationName).Append("\n");
            sb.Append("  CallID: ").Append(CallID).Append("\n");
            sb.Append("  ConferenceID: ").Append(ConferenceID).Append("\n");
            sb.Append("  EventCategory: ").Append(EventCategory).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  MediaName: ").Append(MediaName).Append("\n");
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
            return this.Equals(input as KapiConferenceRecord);
        }

        /// <summary>
        /// Returns true if KapiConferenceRecord instances are equal
        /// </summary>
        /// <param name="input">Instance of KapiConferenceRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KapiConferenceRecord input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApplicationName == input.ApplicationName ||
                    (this.ApplicationName != null &&
                    this.ApplicationName.Equals(input.ApplicationName))
                ) && 
                (
                    this.CallID == input.CallID ||
                    (this.CallID != null &&
                    this.CallID.Equals(input.CallID))
                ) && 
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
                    this.MediaName == input.MediaName ||
                    (this.MediaName != null &&
                    this.MediaName.Equals(input.MediaName))
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
                if (this.ApplicationName != null)
                    hashCode = hashCode * 59 + this.ApplicationName.GetHashCode();
                if (this.CallID != null)
                    hashCode = hashCode * 59 + this.CallID.GetHashCode();
                if (this.ConferenceID != null)
                    hashCode = hashCode * 59 + this.ConferenceID.GetHashCode();
                if (this.EventCategory != null)
                    hashCode = hashCode * 59 + this.EventCategory.GetHashCode();
                if (this.EventName != null)
                    hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.MediaName != null)
                    hashCode = hashCode * 59 + this.MediaName.GetHashCode();
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
