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
    /// AMQP API for conference.config_resp
    /// </summary>
    [DataContract]
    public partial class KapiConferenceConfigResp :  IEquatable<KapiConferenceConfigResp>, IValidatableObject
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
            /// Enum Configresp for value: config_resp
            /// </summary>
            [EnumMember(Value = "config_resp")]
            Configresp = 1
        }

        /// <summary>
        /// Gets or Sets EventName
        /// </summary>
        [DataMember(Name="Event-Name", EmitDefaultValue=false)]
        public EventNameEnum? EventName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiConferenceConfigResp" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KapiConferenceConfigResp() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiConferenceConfigResp" /> class.
        /// </summary>
        /// <param name="advertise">advertise.</param>
        /// <param name="callerControls">callerControls.</param>
        /// <param name="chatPermissions">chatPermissions.</param>
        /// <param name="eventCategory">eventCategory.</param>
        /// <param name="eventName">eventName.</param>
        /// <param name="profiles">profiles (required).</param>
        public KapiConferenceConfigResp(string advertise = default(string), string callerControls = default(string), string chatPermissions = default(string), EventCategoryEnum? eventCategory = default(EventCategoryEnum?), EventNameEnum? eventName = default(EventNameEnum?), string profiles = default(string))
        {
            // to ensure "profiles" is required (not null)
            if (profiles == null)
            {
                throw new InvalidDataException("profiles is a required property for KapiConferenceConfigResp and cannot be null");
            }
            else
            {
                this.Profiles = profiles;
            }
            this.Advertise = advertise;
            this.CallerControls = callerControls;
            this.ChatPermissions = chatPermissions;
            this.EventCategory = eventCategory;
            this.EventName = eventName;
        }
        
        /// <summary>
        /// Gets or Sets Advertise
        /// </summary>
        [DataMember(Name="Advertise", EmitDefaultValue=false)]
        public string Advertise { get; set; }

        /// <summary>
        /// Gets or Sets CallerControls
        /// </summary>
        [DataMember(Name="Caller-Controls", EmitDefaultValue=false)]
        public string CallerControls { get; set; }

        /// <summary>
        /// Gets or Sets ChatPermissions
        /// </summary>
        [DataMember(Name="Chat-Permissions", EmitDefaultValue=false)]
        public string ChatPermissions { get; set; }



        /// <summary>
        /// Gets or Sets Profiles
        /// </summary>
        [DataMember(Name="Profiles", EmitDefaultValue=false)]
        public string Profiles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KapiConferenceConfigResp {\n");
            sb.Append("  Advertise: ").Append(Advertise).Append("\n");
            sb.Append("  CallerControls: ").Append(CallerControls).Append("\n");
            sb.Append("  ChatPermissions: ").Append(ChatPermissions).Append("\n");
            sb.Append("  EventCategory: ").Append(EventCategory).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  Profiles: ").Append(Profiles).Append("\n");
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
            return this.Equals(input as KapiConferenceConfigResp);
        }

        /// <summary>
        /// Returns true if KapiConferenceConfigResp instances are equal
        /// </summary>
        /// <param name="input">Instance of KapiConferenceConfigResp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KapiConferenceConfigResp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Advertise == input.Advertise ||
                    (this.Advertise != null &&
                    this.Advertise.Equals(input.Advertise))
                ) && 
                (
                    this.CallerControls == input.CallerControls ||
                    (this.CallerControls != null &&
                    this.CallerControls.Equals(input.CallerControls))
                ) && 
                (
                    this.ChatPermissions == input.ChatPermissions ||
                    (this.ChatPermissions != null &&
                    this.ChatPermissions.Equals(input.ChatPermissions))
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
                    this.Profiles == input.Profiles ||
                    (this.Profiles != null &&
                    this.Profiles.Equals(input.Profiles))
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
                if (this.Advertise != null)
                    hashCode = hashCode * 59 + this.Advertise.GetHashCode();
                if (this.CallerControls != null)
                    hashCode = hashCode * 59 + this.CallerControls.GetHashCode();
                if (this.ChatPermissions != null)
                    hashCode = hashCode * 59 + this.ChatPermissions.GetHashCode();
                if (this.EventCategory != null)
                    hashCode = hashCode * 59 + this.EventCategory.GetHashCode();
                if (this.EventName != null)
                    hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.Profiles != null)
                    hashCode = hashCode * 59 + this.Profiles.GetHashCode();
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
