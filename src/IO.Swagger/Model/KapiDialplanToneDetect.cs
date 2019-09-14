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
    /// AMQP API for dialplan.tone_detect
    /// </summary>
    [DataContract]
    public partial class KapiDialplanToneDetect :  IEquatable<KapiDialplanToneDetect>, IValidatableObject
    {
        /// <summary>
        /// Defines ApplicationName
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ApplicationNameEnum
        {
            
            /// <summary>
            /// Enum Tonedetect for value: tone_detect
            /// </summary>
            [EnumMember(Value = "tone_detect")]
            Tonedetect = 1
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
        /// Defines SniffDirection
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SniffDirectionEnum
        {
            
            /// <summary>
            /// Enum Read for value: read
            /// </summary>
            [EnumMember(Value = "read")]
            Read = 1,
            
            /// <summary>
            /// Enum Write for value: write
            /// </summary>
            [EnumMember(Value = "write")]
            Write = 2
        }

        /// <summary>
        /// Gets or Sets SniffDirection
        /// </summary>
        [DataMember(Name="Sniff-Direction", EmitDefaultValue=false)]
        public SniffDirectionEnum? SniffDirection { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiDialplanToneDetect" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KapiDialplanToneDetect() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiDialplanToneDetect" /> class.
        /// </summary>
        /// <param name="applicationName">applicationName (required).</param>
        /// <param name="callID">callID (required).</param>
        /// <param name="eventCategory">eventCategory.</param>
        /// <param name="eventName">eventName.</param>
        /// <param name="frequencies">frequencies (required).</param>
        /// <param name="hitsNeeded">hitsNeeded.</param>
        /// <param name="insertAt">insertAt.</param>
        /// <param name="onSuccess">onSuccess.</param>
        /// <param name="sniffDirection">sniffDirection.</param>
        /// <param name="timeout">timeout.</param>
        /// <param name="toneDetectName">toneDetectName (required).</param>
        public KapiDialplanToneDetect(ApplicationNameEnum applicationName = default(ApplicationNameEnum), string callID = default(string), EventCategoryEnum? eventCategory = default(EventCategoryEnum?), EventNameEnum? eventName = default(EventNameEnum?), string frequencies = default(string), string hitsNeeded = default(string), InsertAtEnum? insertAt = default(InsertAtEnum?), List<string> onSuccess = default(List<string>), SniffDirectionEnum? sniffDirection = default(SniffDirectionEnum?), int? timeout = default(int?), string toneDetectName = default(string))
        {
            // to ensure "applicationName" is required (not null)
            if (applicationName == null)
            {
                throw new InvalidDataException("applicationName is a required property for KapiDialplanToneDetect and cannot be null");
            }
            else
            {
                this.ApplicationName = applicationName;
            }
            // to ensure "callID" is required (not null)
            if (callID == null)
            {
                throw new InvalidDataException("callID is a required property for KapiDialplanToneDetect and cannot be null");
            }
            else
            {
                this.CallID = callID;
            }
            // to ensure "frequencies" is required (not null)
            if (frequencies == null)
            {
                throw new InvalidDataException("frequencies is a required property for KapiDialplanToneDetect and cannot be null");
            }
            else
            {
                this.Frequencies = frequencies;
            }
            // to ensure "toneDetectName" is required (not null)
            if (toneDetectName == null)
            {
                throw new InvalidDataException("toneDetectName is a required property for KapiDialplanToneDetect and cannot be null");
            }
            else
            {
                this.ToneDetectName = toneDetectName;
            }
            this.EventCategory = eventCategory;
            this.EventName = eventName;
            this.HitsNeeded = hitsNeeded;
            this.InsertAt = insertAt;
            this.OnSuccess = onSuccess;
            this.SniffDirection = sniffDirection;
            this.Timeout = timeout;
        }
        

        /// <summary>
        /// Gets or Sets CallID
        /// </summary>
        [DataMember(Name="Call-ID", EmitDefaultValue=false)]
        public string CallID { get; set; }



        /// <summary>
        /// Gets or Sets Frequencies
        /// </summary>
        [DataMember(Name="Frequencies", EmitDefaultValue=false)]
        public string Frequencies { get; set; }

        /// <summary>
        /// Gets or Sets HitsNeeded
        /// </summary>
        [DataMember(Name="Hits-Needed", EmitDefaultValue=false)]
        public string HitsNeeded { get; set; }


        /// <summary>
        /// Gets or Sets OnSuccess
        /// </summary>
        [DataMember(Name="On-Success", EmitDefaultValue=false)]
        public List<string> OnSuccess { get; set; }


        /// <summary>
        /// Gets or Sets Timeout
        /// </summary>
        [DataMember(Name="Timeout", EmitDefaultValue=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// Gets or Sets ToneDetectName
        /// </summary>
        [DataMember(Name="Tone-Detect-Name", EmitDefaultValue=false)]
        public string ToneDetectName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KapiDialplanToneDetect {\n");
            sb.Append("  ApplicationName: ").Append(ApplicationName).Append("\n");
            sb.Append("  CallID: ").Append(CallID).Append("\n");
            sb.Append("  EventCategory: ").Append(EventCategory).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  Frequencies: ").Append(Frequencies).Append("\n");
            sb.Append("  HitsNeeded: ").Append(HitsNeeded).Append("\n");
            sb.Append("  InsertAt: ").Append(InsertAt).Append("\n");
            sb.Append("  OnSuccess: ").Append(OnSuccess).Append("\n");
            sb.Append("  SniffDirection: ").Append(SniffDirection).Append("\n");
            sb.Append("  Timeout: ").Append(Timeout).Append("\n");
            sb.Append("  ToneDetectName: ").Append(ToneDetectName).Append("\n");
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
            return this.Equals(input as KapiDialplanToneDetect);
        }

        /// <summary>
        /// Returns true if KapiDialplanToneDetect instances are equal
        /// </summary>
        /// <param name="input">Instance of KapiDialplanToneDetect to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KapiDialplanToneDetect input)
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
                    this.Frequencies == input.Frequencies ||
                    (this.Frequencies != null &&
                    this.Frequencies.Equals(input.Frequencies))
                ) && 
                (
                    this.HitsNeeded == input.HitsNeeded ||
                    (this.HitsNeeded != null &&
                    this.HitsNeeded.Equals(input.HitsNeeded))
                ) && 
                (
                    this.InsertAt == input.InsertAt ||
                    (this.InsertAt != null &&
                    this.InsertAt.Equals(input.InsertAt))
                ) && 
                (
                    this.OnSuccess == input.OnSuccess ||
                    this.OnSuccess != null &&
                    this.OnSuccess.SequenceEqual(input.OnSuccess)
                ) && 
                (
                    this.SniffDirection == input.SniffDirection ||
                    (this.SniffDirection != null &&
                    this.SniffDirection.Equals(input.SniffDirection))
                ) && 
                (
                    this.Timeout == input.Timeout ||
                    (this.Timeout != null &&
                    this.Timeout.Equals(input.Timeout))
                ) && 
                (
                    this.ToneDetectName == input.ToneDetectName ||
                    (this.ToneDetectName != null &&
                    this.ToneDetectName.Equals(input.ToneDetectName))
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
                if (this.Frequencies != null)
                    hashCode = hashCode * 59 + this.Frequencies.GetHashCode();
                if (this.HitsNeeded != null)
                    hashCode = hashCode * 59 + this.HitsNeeded.GetHashCode();
                if (this.InsertAt != null)
                    hashCode = hashCode * 59 + this.InsertAt.GetHashCode();
                if (this.OnSuccess != null)
                    hashCode = hashCode * 59 + this.OnSuccess.GetHashCode();
                if (this.SniffDirection != null)
                    hashCode = hashCode * 59 + this.SniffDirection.GetHashCode();
                if (this.Timeout != null)
                    hashCode = hashCode * 59 + this.Timeout.GetHashCode();
                if (this.ToneDetectName != null)
                    hashCode = hashCode * 59 + this.ToneDetectName.GetHashCode();
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
            // Timeout (int?) minimum
            if(this.Timeout < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Timeout, must be a value greater than or equal to 0.", new [] { "Timeout" });
            }

            yield break;
        }
    }

}
