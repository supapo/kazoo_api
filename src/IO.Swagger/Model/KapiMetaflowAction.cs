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
    /// AMQP API for metaflow.action
    /// </summary>
    [DataContract]
    public partial class KapiMetaflowAction :  IEquatable<KapiMetaflowAction>, IValidatableObject
    {
        /// <summary>
        /// Defines Action
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionEnum
        {
            
            /// <summary>
            /// Enum Transfer for value: transfer
            /// </summary>
            [EnumMember(Value = "transfer")]
            Transfer = 1,
            
            /// <summary>
            /// Enum Hangup for value: hangup
            /// </summary>
            [EnumMember(Value = "hangup")]
            Hangup = 2,
            
            /// <summary>
            /// Enum Callflow for value: callflow
            /// </summary>
            [EnumMember(Value = "callflow")]
            Callflow = 3,
            
            /// <summary>
            /// Enum Break for value: break
            /// </summary>
            [EnumMember(Value = "break")]
            Break = 4,
            
            /// <summary>
            /// Enum Intercept for value: intercept
            /// </summary>
            [EnumMember(Value = "intercept")]
            Intercept = 5,
            
            /// <summary>
            /// Enum Move for value: move
            /// </summary>
            [EnumMember(Value = "move")]
            Move = 6,
            
            /// <summary>
            /// Enum Park for value: park
            /// </summary>
            [EnumMember(Value = "park")]
            Park = 7,
            
            /// <summary>
            /// Enum Unpark for value: unpark
            /// </summary>
            [EnumMember(Value = "unpark")]
            Unpark = 8,
            
            /// <summary>
            /// Enum Play for value: play
            /// </summary>
            [EnumMember(Value = "play")]
            Play = 9,
            
            /// <summary>
            /// Enum Say for value: say
            /// </summary>
            [EnumMember(Value = "say")]
            Say = 10,
            
            /// <summary>
            /// Enum Audiolevel for value: audio_level
            /// </summary>
            [EnumMember(Value = "audio_level")]
            Audiolevel = 11,
            
            /// <summary>
            /// Enum Hold for value: hold
            /// </summary>
            [EnumMember(Value = "hold")]
            Hold = 12,
            
            /// <summary>
            /// Enum Recordcall for value: record_call
            /// </summary>
            [EnumMember(Value = "record_call")]
            Recordcall = 13,
            
            /// <summary>
            /// Enum Resume for value: resume
            /// </summary>
            [EnumMember(Value = "resume")]
            Resume = 14,
            
            /// <summary>
            /// Enum Tts for value: tts
            /// </summary>
            [EnumMember(Value = "tts")]
            Tts = 15
        }

        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name="Action", EmitDefaultValue=false)]
        public ActionEnum Action { get; set; }
        /// <summary>
        /// Defines EventCategory
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventCategoryEnum
        {
            
            /// <summary>
            /// Enum Metaflow for value: metaflow
            /// </summary>
            [EnumMember(Value = "metaflow")]
            Metaflow = 1
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
            /// Enum Action for value: action
            /// </summary>
            [EnumMember(Value = "action")]
            Action = 1
        }

        /// <summary>
        /// Gets or Sets EventName
        /// </summary>
        [DataMember(Name="Event-Name", EmitDefaultValue=false)]
        public EventNameEnum? EventName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiMetaflowAction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KapiMetaflowAction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiMetaflowAction" /> class.
        /// </summary>
        /// <param name="action">action (required).</param>
        /// <param name="callID">callID (required).</param>
        /// <param name="data">data.</param>
        /// <param name="eventCategory">eventCategory.</param>
        /// <param name="eventName">eventName.</param>
        public KapiMetaflowAction(ActionEnum action = default(ActionEnum), string callID = default(string), string data = default(string), EventCategoryEnum? eventCategory = default(EventCategoryEnum?), EventNameEnum? eventName = default(EventNameEnum?))
        {
            // to ensure "action" is required (not null)
            if (action == null)
            {
                throw new InvalidDataException("action is a required property for KapiMetaflowAction and cannot be null");
            }
            else
            {
                this.Action = action;
            }
            // to ensure "callID" is required (not null)
            if (callID == null)
            {
                throw new InvalidDataException("callID is a required property for KapiMetaflowAction and cannot be null");
            }
            else
            {
                this.CallID = callID;
            }
            this.Data = data;
            this.EventCategory = eventCategory;
            this.EventName = eventName;
        }
        

        /// <summary>
        /// Gets or Sets CallID
        /// </summary>
        [DataMember(Name="Call-ID", EmitDefaultValue=false)]
        public string CallID { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="Data", EmitDefaultValue=false)]
        public string Data { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KapiMetaflowAction {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  CallID: ").Append(CallID).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  EventCategory: ").Append(EventCategory).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
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
            return this.Equals(input as KapiMetaflowAction);
        }

        /// <summary>
        /// Returns true if KapiMetaflowAction instances are equal
        /// </summary>
        /// <param name="input">Instance of KapiMetaflowAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KapiMetaflowAction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.CallID == input.CallID ||
                    (this.CallID != null &&
                    this.CallID.Equals(input.CallID))
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
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
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.CallID != null)
                    hashCode = hashCode * 59 + this.CallID.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.EventCategory != null)
                    hashCode = hashCode * 59 + this.EventCategory.GetHashCode();
                if (this.EventName != null)
                    hashCode = hashCode * 59 + this.EventName.GetHashCode();
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
