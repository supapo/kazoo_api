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
    /// AMQP API for conference.conference_error
    /// </summary>
    [DataContract]
    public partial class KapiConferenceConferenceError :  IEquatable<KapiConferenceConferenceError>, IValidatableObject
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
            /// Enum Error for value: error
            /// </summary>
            [EnumMember(Value = "error")]
            Error = 1
        }

        /// <summary>
        /// Gets or Sets EventName
        /// </summary>
        [DataMember(Name="Event-Name", EmitDefaultValue=false)]
        public EventNameEnum? EventName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiConferenceConferenceError" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KapiConferenceConferenceError() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiConferenceConferenceError" /> class.
        /// </summary>
        /// <param name="conferenceID">conferenceID (required).</param>
        /// <param name="errorMessage">errorMessage (required).</param>
        /// <param name="eventCategory">eventCategory.</param>
        /// <param name="eventName">eventName.</param>
        /// <param name="request">request (required).</param>
        public KapiConferenceConferenceError(string conferenceID = default(string), string errorMessage = default(string), EventCategoryEnum? eventCategory = default(EventCategoryEnum?), EventNameEnum? eventName = default(EventNameEnum?), string request = default(string))
        {
            // to ensure "conferenceID" is required (not null)
            if (conferenceID == null)
            {
                throw new InvalidDataException("conferenceID is a required property for KapiConferenceConferenceError and cannot be null");
            }
            else
            {
                this.ConferenceID = conferenceID;
            }
            // to ensure "errorMessage" is required (not null)
            if (errorMessage == null)
            {
                throw new InvalidDataException("errorMessage is a required property for KapiConferenceConferenceError and cannot be null");
            }
            else
            {
                this.ErrorMessage = errorMessage;
            }
            // to ensure "request" is required (not null)
            if (request == null)
            {
                throw new InvalidDataException("request is a required property for KapiConferenceConferenceError and cannot be null");
            }
            else
            {
                this.Request = request;
            }
            this.EventCategory = eventCategory;
            this.EventName = eventName;
        }
        
        /// <summary>
        /// Gets or Sets ConferenceID
        /// </summary>
        [DataMember(Name="Conference-ID", EmitDefaultValue=false)]
        public string ConferenceID { get; set; }

        /// <summary>
        /// Gets or Sets ErrorMessage
        /// </summary>
        [DataMember(Name="Error-Message", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }



        /// <summary>
        /// Gets or Sets Request
        /// </summary>
        [DataMember(Name="Request", EmitDefaultValue=false)]
        public string Request { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KapiConferenceConferenceError {\n");
            sb.Append("  ConferenceID: ").Append(ConferenceID).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  EventCategory: ").Append(EventCategory).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  Request: ").Append(Request).Append("\n");
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
            return this.Equals(input as KapiConferenceConferenceError);
        }

        /// <summary>
        /// Returns true if KapiConferenceConferenceError instances are equal
        /// </summary>
        /// <param name="input">Instance of KapiConferenceConferenceError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KapiConferenceConferenceError input)
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
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
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
                    this.Request == input.Request ||
                    (this.Request != null &&
                    this.Request.Equals(input.Request))
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
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                if (this.EventCategory != null)
                    hashCode = hashCode * 59 + this.EventCategory.GetHashCode();
                if (this.EventName != null)
                    hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.Request != null)
                    hashCode = hashCode * 59 + this.Request.GetHashCode();
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