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
    /// AMQP API for media.error
    /// </summary>
    [DataContract]
    public partial class KapiMediaError :  IEquatable<KapiMediaError>, IValidatableObject
    {
        /// <summary>
        /// Defines ErrorCode
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ErrorCodeEnum
        {
            
            /// <summary>
            /// Enum Notfound for value: not_found
            /// </summary>
            [EnumMember(Value = "not_found")]
            Notfound = 1,
            
            /// <summary>
            /// Enum Nodata for value: no_data
            /// </summary>
            [EnumMember(Value = "no_data")]
            Nodata = 2,
            
            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 3
        }

        /// <summary>
        /// Gets or Sets ErrorCode
        /// </summary>
        [DataMember(Name="Error-Code", EmitDefaultValue=false)]
        public ErrorCodeEnum ErrorCode { get; set; }
        /// <summary>
        /// Defines EventCategory
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventCategoryEnum
        {
            
            /// <summary>
            /// Enum Media for value: media
            /// </summary>
            [EnumMember(Value = "media")]
            Media = 1
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
            /// Enum Mediaerror for value: media_error
            /// </summary>
            [EnumMember(Value = "media_error")]
            Mediaerror = 1
        }

        /// <summary>
        /// Gets or Sets EventName
        /// </summary>
        [DataMember(Name="Event-Name", EmitDefaultValue=false)]
        public EventNameEnum? EventName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiMediaError" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KapiMediaError() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiMediaError" /> class.
        /// </summary>
        /// <param name="errorCode">errorCode (required).</param>
        /// <param name="errorMsg">errorMsg.</param>
        /// <param name="eventCategory">eventCategory.</param>
        /// <param name="eventName">eventName.</param>
        /// <param name="mediaName">mediaName (required).</param>
        public KapiMediaError(ErrorCodeEnum errorCode = default(ErrorCodeEnum), string errorMsg = default(string), EventCategoryEnum? eventCategory = default(EventCategoryEnum?), EventNameEnum? eventName = default(EventNameEnum?), string mediaName = default(string))
        {
            // to ensure "errorCode" is required (not null)
            if (errorCode == null)
            {
                throw new InvalidDataException("errorCode is a required property for KapiMediaError and cannot be null");
            }
            else
            {
                this.ErrorCode = errorCode;
            }
            // to ensure "mediaName" is required (not null)
            if (mediaName == null)
            {
                throw new InvalidDataException("mediaName is a required property for KapiMediaError and cannot be null");
            }
            else
            {
                this.MediaName = mediaName;
            }
            this.ErrorMsg = errorMsg;
            this.EventCategory = eventCategory;
            this.EventName = eventName;
        }
        

        /// <summary>
        /// Gets or Sets ErrorMsg
        /// </summary>
        [DataMember(Name="Error-Msg", EmitDefaultValue=false)]
        public string ErrorMsg { get; set; }



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
            sb.Append("class KapiMediaError {\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  ErrorMsg: ").Append(ErrorMsg).Append("\n");
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
            return this.Equals(input as KapiMediaError);
        }

        /// <summary>
        /// Returns true if KapiMediaError instances are equal
        /// </summary>
        /// <param name="input">Instance of KapiMediaError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KapiMediaError input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
                ) && 
                (
                    this.ErrorMsg == input.ErrorMsg ||
                    (this.ErrorMsg != null &&
                    this.ErrorMsg.Equals(input.ErrorMsg))
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
                if (this.ErrorCode != null)
                    hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.ErrorMsg != null)
                    hashCode = hashCode * 59 + this.ErrorMsg.GetHashCode();
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
