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
    /// AMQP API for dialplan.originate_ready
    /// </summary>
    [DataContract]
    public partial class KapiDialplanOriginateReady :  IEquatable<KapiDialplanOriginateReady>, IValidatableObject
    {
        /// <summary>
        /// Defines EventCategory
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventCategoryEnum
        {
            
            /// <summary>
            /// Enum Dialplan for value: dialplan
            /// </summary>
            [EnumMember(Value = "dialplan")]
            Dialplan = 1
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
            /// Enum Originateready for value: originate_ready
            /// </summary>
            [EnumMember(Value = "originate_ready")]
            Originateready = 1
        }

        /// <summary>
        /// Gets or Sets EventName
        /// </summary>
        [DataMember(Name="Event-Name", EmitDefaultValue=false)]
        public EventNameEnum? EventName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiDialplanOriginateReady" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KapiDialplanOriginateReady() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiDialplanOriginateReady" /> class.
        /// </summary>
        /// <param name="callID">callID (required).</param>
        /// <param name="controlQueue">controlQueue (required).</param>
        /// <param name="eventCategory">eventCategory.</param>
        /// <param name="eventName">eventName.</param>
        public KapiDialplanOriginateReady(string callID = default(string), string controlQueue = default(string), EventCategoryEnum? eventCategory = default(EventCategoryEnum?), EventNameEnum? eventName = default(EventNameEnum?))
        {
            // to ensure "callID" is required (not null)
            if (callID == null)
            {
                throw new InvalidDataException("callID is a required property for KapiDialplanOriginateReady and cannot be null");
            }
            else
            {
                this.CallID = callID;
            }
            // to ensure "controlQueue" is required (not null)
            if (controlQueue == null)
            {
                throw new InvalidDataException("controlQueue is a required property for KapiDialplanOriginateReady and cannot be null");
            }
            else
            {
                this.ControlQueue = controlQueue;
            }
            this.EventCategory = eventCategory;
            this.EventName = eventName;
        }
        
        /// <summary>
        /// Gets or Sets CallID
        /// </summary>
        [DataMember(Name="Call-ID", EmitDefaultValue=false)]
        public string CallID { get; set; }

        /// <summary>
        /// Gets or Sets ControlQueue
        /// </summary>
        [DataMember(Name="Control-Queue", EmitDefaultValue=false)]
        public string ControlQueue { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KapiDialplanOriginateReady {\n");
            sb.Append("  CallID: ").Append(CallID).Append("\n");
            sb.Append("  ControlQueue: ").Append(ControlQueue).Append("\n");
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
            return this.Equals(input as KapiDialplanOriginateReady);
        }

        /// <summary>
        /// Returns true if KapiDialplanOriginateReady instances are equal
        /// </summary>
        /// <param name="input">Instance of KapiDialplanOriginateReady to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KapiDialplanOriginateReady input)
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
                    this.ControlQueue == input.ControlQueue ||
                    (this.ControlQueue != null &&
                    this.ControlQueue.Equals(input.ControlQueue))
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
                if (this.CallID != null)
                    hashCode = hashCode * 59 + this.CallID.GetHashCode();
                if (this.ControlQueue != null)
                    hashCode = hashCode * 59 + this.ControlQueue.GetHashCode();
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