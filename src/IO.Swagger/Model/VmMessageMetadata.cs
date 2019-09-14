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
    /// Schema for a voicemail message metadata
    /// </summary>
    [DataContract]
    public partial class VmMessageMetadata :  IEquatable<VmMessageMetadata>, IValidatableObject
    {
        /// <summary>
        /// The folder the message belongs to
        /// </summary>
        /// <value>The folder the message belongs to</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FolderEnum
        {
            
            /// <summary>
            /// Enum Deleted for value: deleted
            /// </summary>
            [EnumMember(Value = "deleted")]
            Deleted = 1,
            
            /// <summary>
            /// Enum Saved for value: saved
            /// </summary>
            [EnumMember(Value = "saved")]
            Saved = 2,
            
            /// <summary>
            /// Enum New for value: new
            /// </summary>
            [EnumMember(Value = "new")]
            New = 3
        }

        /// <summary>
        /// The folder the message belongs to
        /// </summary>
        /// <value>The folder the message belongs to</value>
        [DataMember(Name="folder", EmitDefaultValue=false)]
        public FolderEnum? Folder { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="VmMessageMetadata" /> class.
        /// </summary>
        /// <param name="callId">The SIP call-id.</param>
        /// <param name="callerIdName">The caller id name.</param>
        /// <param name="callerIdNumber">The caller id number.</param>
        /// <param name="folder">The folder the message belongs to.</param>
        /// <param name="from">The SIP from header.</param>
        /// <param name="length">length.</param>
        /// <param name="timestamp">The UTC timestamp, in Gregorian seconds, that the voicemail was left on.</param>
        /// <param name="to">The SIP to header.</param>
        public VmMessageMetadata(string callId = default(string), string callerIdName = default(string), string callerIdNumber = default(string), FolderEnum? folder = default(FolderEnum?), string from = default(string), int? length = default(int?), int? timestamp = default(int?), string to = default(string))
        {
            this.CallId = callId;
            this.CallerIdName = callerIdName;
            this.CallerIdNumber = callerIdNumber;
            this.Folder = folder;
            this.From = from;
            this.Length = length;
            this.Timestamp = timestamp;
            this.To = to;
        }
        
        /// <summary>
        /// The SIP call-id
        /// </summary>
        /// <value>The SIP call-id</value>
        [DataMember(Name="call_id", EmitDefaultValue=false)]
        public string CallId { get; set; }

        /// <summary>
        /// The caller id name
        /// </summary>
        /// <value>The caller id name</value>
        [DataMember(Name="caller_id_name", EmitDefaultValue=false)]
        public string CallerIdName { get; set; }

        /// <summary>
        /// The caller id number
        /// </summary>
        /// <value>The caller id number</value>
        [DataMember(Name="caller_id_number", EmitDefaultValue=false)]
        public string CallerIdNumber { get; set; }


        /// <summary>
        /// The SIP from header
        /// </summary>
        /// <value>The SIP from header</value>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public string From { get; set; }

        /// <summary>
        /// Gets or Sets Length
        /// </summary>
        [DataMember(Name="length", EmitDefaultValue=false)]
        public int? Length { get; set; }

        /// <summary>
        /// The UTC timestamp, in Gregorian seconds, that the voicemail was left on
        /// </summary>
        /// <value>The UTC timestamp, in Gregorian seconds, that the voicemail was left on</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public int? Timestamp { get; set; }

        /// <summary>
        /// The SIP to header
        /// </summary>
        /// <value>The SIP to header</value>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public string To { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VmMessageMetadata {\n");
            sb.Append("  CallId: ").Append(CallId).Append("\n");
            sb.Append("  CallerIdName: ").Append(CallerIdName).Append("\n");
            sb.Append("  CallerIdNumber: ").Append(CallerIdNumber).Append("\n");
            sb.Append("  Folder: ").Append(Folder).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Length: ").Append(Length).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
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
            return this.Equals(input as VmMessageMetadata);
        }

        /// <summary>
        /// Returns true if VmMessageMetadata instances are equal
        /// </summary>
        /// <param name="input">Instance of VmMessageMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VmMessageMetadata input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CallId == input.CallId ||
                    (this.CallId != null &&
                    this.CallId.Equals(input.CallId))
                ) && 
                (
                    this.CallerIdName == input.CallerIdName ||
                    (this.CallerIdName != null &&
                    this.CallerIdName.Equals(input.CallerIdName))
                ) && 
                (
                    this.CallerIdNumber == input.CallerIdNumber ||
                    (this.CallerIdNumber != null &&
                    this.CallerIdNumber.Equals(input.CallerIdNumber))
                ) && 
                (
                    this.Folder == input.Folder ||
                    (this.Folder != null &&
                    this.Folder.Equals(input.Folder))
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.Length == input.Length ||
                    (this.Length != null &&
                    this.Length.Equals(input.Length))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
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
                if (this.CallId != null)
                    hashCode = hashCode * 59 + this.CallId.GetHashCode();
                if (this.CallerIdName != null)
                    hashCode = hashCode * 59 + this.CallerIdName.GetHashCode();
                if (this.CallerIdNumber != null)
                    hashCode = hashCode * 59 + this.CallerIdNumber.GetHashCode();
                if (this.Folder != null)
                    hashCode = hashCode * 59 + this.Folder.GetHashCode();
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.Length != null)
                    hashCode = hashCode * 59 + this.Length.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
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
            // CallerIdName (string) maxLength
            if(this.CallerIdName != null && this.CallerIdName.Length > 35)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CallerIdName, length must be less than 35.", new [] { "CallerIdName" });
            }

            // CallerIdNumber (string) maxLength
            if(this.CallerIdNumber != null && this.CallerIdNumber.Length > 35)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CallerIdNumber, length must be less than 35.", new [] { "CallerIdNumber" });
            }

            yield break;
        }
    }

}