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
    /// AMQP API for dialplan.privacy
    /// </summary>
    [DataContract]
    public partial class KapiDialplanPrivacy :  IEquatable<KapiDialplanPrivacy>, IValidatableObject
    {
        /// <summary>
        /// Defines ApplicationName
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ApplicationNameEnum
        {
            
            /// <summary>
            /// Enum Privacy for value: privacy
            /// </summary>
            [EnumMember(Value = "privacy")]
            Privacy = 1
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
            /// Enum Call for value: call
            /// </summary>
            [EnumMember(Value = "call")]
            Call = 1
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
        /// Defines InsertAt
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum InsertAtEnum
        {
            
            /// <summary>
            /// Enum Head for value: head
            /// </summary>
            [EnumMember(Value = "head")]
            Head = 1,
            
            /// <summary>
            /// Enum Tail for value: tail
            /// </summary>
            [EnumMember(Value = "tail")]
            Tail = 2,
            
            /// <summary>
            /// Enum Flush for value: flush
            /// </summary>
            [EnumMember(Value = "flush")]
            Flush = 3,
            
            /// <summary>
            /// Enum Now for value: now
            /// </summary>
            [EnumMember(Value = "now")]
            Now = 4
        }

        /// <summary>
        /// Gets or Sets InsertAt
        /// </summary>
        [DataMember(Name="Insert-At", EmitDefaultValue=false)]
        public InsertAtEnum? InsertAt { get; set; }
        /// <summary>
        /// Defines PrivacyMode
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PrivacyModeEnum
        {
            
            /// <summary>
            /// Enum Full for value: full
            /// </summary>
            [EnumMember(Value = "full")]
            Full = 1,
            
            /// <summary>
            /// Enum Name for value: name
            /// </summary>
            [EnumMember(Value = "name")]
            Name = 2,
            
            /// <summary>
            /// Enum Number for value: number
            /// </summary>
            [EnumMember(Value = "number")]
            Number = 3
        }

        /// <summary>
        /// Gets or Sets PrivacyMode
        /// </summary>
        [DataMember(Name="Privacy-Mode", EmitDefaultValue=false)]
        public PrivacyModeEnum? PrivacyMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiDialplanPrivacy" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KapiDialplanPrivacy() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiDialplanPrivacy" /> class.
        /// </summary>
        /// <param name="applicationName">applicationName (required).</param>
        /// <param name="callID">callID (required).</param>
        /// <param name="eventCategory">eventCategory.</param>
        /// <param name="eventName">eventName.</param>
        /// <param name="insertAt">insertAt.</param>
        /// <param name="privacyMode">privacyMode.</param>
        public KapiDialplanPrivacy(ApplicationNameEnum applicationName = default(ApplicationNameEnum), string callID = default(string), EventCategoryEnum? eventCategory = default(EventCategoryEnum?), EventNameEnum? eventName = default(EventNameEnum?), InsertAtEnum? insertAt = default(InsertAtEnum?), PrivacyModeEnum? privacyMode = default(PrivacyModeEnum?))
        {
            // to ensure "applicationName" is required (not null)
            if (applicationName == null)
            {
                throw new InvalidDataException("applicationName is a required property for KapiDialplanPrivacy and cannot be null");
            }
            else
            {
                this.ApplicationName = applicationName;
            }
            // to ensure "callID" is required (not null)
            if (callID == null)
            {
                throw new InvalidDataException("callID is a required property for KapiDialplanPrivacy and cannot be null");
            }
            else
            {
                this.CallID = callID;
            }
            this.EventCategory = eventCategory;
            this.EventName = eventName;
            this.InsertAt = insertAt;
            this.PrivacyMode = privacyMode;
        }
        

        /// <summary>
        /// Gets or Sets CallID
        /// </summary>
        [DataMember(Name="Call-ID", EmitDefaultValue=false)]
        public string CallID { get; set; }





        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KapiDialplanPrivacy {\n");
            sb.Append("  ApplicationName: ").Append(ApplicationName).Append("\n");
            sb.Append("  CallID: ").Append(CallID).Append("\n");
            sb.Append("  EventCategory: ").Append(EventCategory).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  InsertAt: ").Append(InsertAt).Append("\n");
            sb.Append("  PrivacyMode: ").Append(PrivacyMode).Append("\n");
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
            return this.Equals(input as KapiDialplanPrivacy);
        }

        /// <summary>
        /// Returns true if KapiDialplanPrivacy instances are equal
        /// </summary>
        /// <param name="input">Instance of KapiDialplanPrivacy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KapiDialplanPrivacy input)
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
                    this.InsertAt == input.InsertAt ||
                    (this.InsertAt != null &&
                    this.InsertAt.Equals(input.InsertAt))
                ) && 
                (
                    this.PrivacyMode == input.PrivacyMode ||
                    (this.PrivacyMode != null &&
                    this.PrivacyMode.Equals(input.PrivacyMode))
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
                if (this.EventCategory != null)
                    hashCode = hashCode * 59 + this.EventCategory.GetHashCode();
                if (this.EventName != null)
                    hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.InsertAt != null)
                    hashCode = hashCode * 59 + this.InsertAt.GetHashCode();
                if (this.PrivacyMode != null)
                    hashCode = hashCode * 59 + this.PrivacyMode.GetHashCode();
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
