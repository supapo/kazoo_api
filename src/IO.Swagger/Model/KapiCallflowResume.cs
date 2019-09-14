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
    /// AMQP API for callflow.resume
    /// </summary>
    [DataContract]
    public partial class KapiCallflowResume :  IEquatable<KapiCallflowResume>, IValidatableObject
    {
        /// <summary>
        /// Defines EventCategory
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventCategoryEnum
        {
            
            /// <summary>
            /// Enum Callflow for value: callflow
            /// </summary>
            [EnumMember(Value = "callflow")]
            Callflow = 1
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
            /// Enum Resume for value: resume
            /// </summary>
            [EnumMember(Value = "resume")]
            Resume = 1
        }

        /// <summary>
        /// Gets or Sets EventName
        /// </summary>
        [DataMember(Name="Event-Name", EmitDefaultValue=false)]
        public EventNameEnum? EventName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiCallflowResume" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KapiCallflowResume() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiCallflowResume" /> class.
        /// </summary>
        /// <param name="call">call (required).</param>
        /// <param name="eventCategory">eventCategory.</param>
        /// <param name="eventName">eventName.</param>
        /// <param name="flow">flow (required).</param>
        public KapiCallflowResume(Object call = default(Object), EventCategoryEnum? eventCategory = default(EventCategoryEnum?), EventNameEnum? eventName = default(EventNameEnum?), string flow = default(string))
        {
            // to ensure "call" is required (not null)
            if (call == null)
            {
                throw new InvalidDataException("call is a required property for KapiCallflowResume and cannot be null");
            }
            else
            {
                this.Call = call;
            }
            // to ensure "flow" is required (not null)
            if (flow == null)
            {
                throw new InvalidDataException("flow is a required property for KapiCallflowResume and cannot be null");
            }
            else
            {
                this.Flow = flow;
            }
            this.EventCategory = eventCategory;
            this.EventName = eventName;
        }
        
        /// <summary>
        /// Gets or Sets Call
        /// </summary>
        [DataMember(Name="Call", EmitDefaultValue=false)]
        public Object Call { get; set; }



        /// <summary>
        /// Gets or Sets Flow
        /// </summary>
        [DataMember(Name="Flow", EmitDefaultValue=false)]
        public string Flow { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KapiCallflowResume {\n");
            sb.Append("  Call: ").Append(Call).Append("\n");
            sb.Append("  EventCategory: ").Append(EventCategory).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  Flow: ").Append(Flow).Append("\n");
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
            return this.Equals(input as KapiCallflowResume);
        }

        /// <summary>
        /// Returns true if KapiCallflowResume instances are equal
        /// </summary>
        /// <param name="input">Instance of KapiCallflowResume to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KapiCallflowResume input)
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
                    this.Flow == input.Flow ||
                    (this.Flow != null &&
                    this.Flow.Equals(input.Flow))
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
                if (this.EventCategory != null)
                    hashCode = hashCode * 59 + this.EventCategory.GetHashCode();
                if (this.EventName != null)
                    hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.Flow != null)
                    hashCode = hashCode * 59 + this.Flow.GetHashCode();
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
