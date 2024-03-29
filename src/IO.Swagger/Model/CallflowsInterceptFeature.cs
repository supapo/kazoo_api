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
    /// Validator for the intercept_feature callflow data object
    /// </summary>
    [DataContract]
    public partial class CallflowsInterceptFeature :  IEquatable<CallflowsInterceptFeature>, IValidatableObject
    {
        /// <summary>
        /// The scope of devices to intercept
        /// </summary>
        /// <value>The scope of devices to intercept</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum User for value: user
            /// </summary>
            [EnumMember(Value = "user")]
            User = 1,
            
            /// <summary>
            /// Enum Device for value: device
            /// </summary>
            [EnumMember(Value = "device")]
            Device = 2,
            
            /// <summary>
            /// Enum Extension for value: extension
            /// </summary>
            [EnumMember(Value = "extension")]
            Extension = 3
        }

        /// <summary>
        /// The scope of devices to intercept
        /// </summary>
        /// <value>The scope of devices to intercept</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CallflowsInterceptFeature" /> class.
        /// </summary>
        /// <param name="approvedDeviceId">Restricts the calling device to this Device.</param>
        /// <param name="approvedGroupId">Requires the calling device to be part of the Group.</param>
        /// <param name="approvedUserId">Requires the calling device to be part of the User.</param>
        /// <param name="skipModule">When set to true this callflow action is skipped, advancing to the wildcard branch (if any).</param>
        /// <param name="type">The scope of devices to intercept.</param>
        public CallflowsInterceptFeature(string approvedDeviceId = default(string), string approvedGroupId = default(string), string approvedUserId = default(string), bool? skipModule = default(bool?), TypeEnum? type = default(TypeEnum?))
        {
            this.ApprovedDeviceId = approvedDeviceId;
            this.ApprovedGroupId = approvedGroupId;
            this.ApprovedUserId = approvedUserId;
            this.SkipModule = skipModule;
            this.Type = type;
        }
        
        /// <summary>
        /// Restricts the calling device to this Device
        /// </summary>
        /// <value>Restricts the calling device to this Device</value>
        [DataMember(Name="approved_device_id", EmitDefaultValue=false)]
        public string ApprovedDeviceId { get; set; }

        /// <summary>
        /// Requires the calling device to be part of the Group
        /// </summary>
        /// <value>Requires the calling device to be part of the Group</value>
        [DataMember(Name="approved_group_id", EmitDefaultValue=false)]
        public string ApprovedGroupId { get; set; }

        /// <summary>
        /// Requires the calling device to be part of the User
        /// </summary>
        /// <value>Requires the calling device to be part of the User</value>
        [DataMember(Name="approved_user_id", EmitDefaultValue=false)]
        public string ApprovedUserId { get; set; }

        /// <summary>
        /// When set to true this callflow action is skipped, advancing to the wildcard branch (if any)
        /// </summary>
        /// <value>When set to true this callflow action is skipped, advancing to the wildcard branch (if any)</value>
        [DataMember(Name="skip_module", EmitDefaultValue=false)]
        public bool? SkipModule { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CallflowsInterceptFeature {\n");
            sb.Append("  ApprovedDeviceId: ").Append(ApprovedDeviceId).Append("\n");
            sb.Append("  ApprovedGroupId: ").Append(ApprovedGroupId).Append("\n");
            sb.Append("  ApprovedUserId: ").Append(ApprovedUserId).Append("\n");
            sb.Append("  SkipModule: ").Append(SkipModule).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as CallflowsInterceptFeature);
        }

        /// <summary>
        /// Returns true if CallflowsInterceptFeature instances are equal
        /// </summary>
        /// <param name="input">Instance of CallflowsInterceptFeature to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallflowsInterceptFeature input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApprovedDeviceId == input.ApprovedDeviceId ||
                    (this.ApprovedDeviceId != null &&
                    this.ApprovedDeviceId.Equals(input.ApprovedDeviceId))
                ) && 
                (
                    this.ApprovedGroupId == input.ApprovedGroupId ||
                    (this.ApprovedGroupId != null &&
                    this.ApprovedGroupId.Equals(input.ApprovedGroupId))
                ) && 
                (
                    this.ApprovedUserId == input.ApprovedUserId ||
                    (this.ApprovedUserId != null &&
                    this.ApprovedUserId.Equals(input.ApprovedUserId))
                ) && 
                (
                    this.SkipModule == input.SkipModule ||
                    (this.SkipModule != null &&
                    this.SkipModule.Equals(input.SkipModule))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.ApprovedDeviceId != null)
                    hashCode = hashCode * 59 + this.ApprovedDeviceId.GetHashCode();
                if (this.ApprovedGroupId != null)
                    hashCode = hashCode * 59 + this.ApprovedGroupId.GetHashCode();
                if (this.ApprovedUserId != null)
                    hashCode = hashCode * 59 + this.ApprovedUserId.GetHashCode();
                if (this.SkipModule != null)
                    hashCode = hashCode * 59 + this.SkipModule.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
