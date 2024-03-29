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
    /// Validator for the transfer callflow data object
    /// </summary>
    [DataContract]
    public partial class CallflowsTransfer :  IEquatable<CallflowsTransfer>, IValidatableObject
    {
        /// <summary>
        /// Which leg to transfer (transferee)
        /// </summary>
        /// <value>Which leg to transfer (transferee)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LegEnum
        {
            
            /// <summary>
            /// Enum Self for value: self
            /// </summary>
            [EnumMember(Value = "self")]
            Self = 1,
            
            /// <summary>
            /// Enum Bleg for value: bleg
            /// </summary>
            [EnumMember(Value = "bleg")]
            Bleg = 2
        }

        /// <summary>
        /// Which leg to transfer (transferee)
        /// </summary>
        /// <value>Which leg to transfer (transferee)</value>
        [DataMember(Name="leg", EmitDefaultValue=false)]
        public LegEnum? Leg { get; set; }
        /// <summary>
        /// The type of transfer to perform
        /// </summary>
        /// <value>The type of transfer to perform</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TransferTypeEnum
        {
            
            /// <summary>
            /// Enum Attended for value: attended
            /// </summary>
            [EnumMember(Value = "attended")]
            Attended = 1,
            
            /// <summary>
            /// Enum Blind for value: blind
            /// </summary>
            [EnumMember(Value = "blind")]
            Blind = 2
        }

        /// <summary>
        /// The type of transfer to perform
        /// </summary>
        /// <value>The type of transfer to perform</value>
        [DataMember(Name="transfer_type", EmitDefaultValue=false)]
        public TransferTypeEnum? TransferType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CallflowsTransfer" /> class.
        /// </summary>
        /// <param name="captures">What to default to using if no capture group is present.</param>
        /// <param name="leg">Which leg to transfer (transferee).</param>
        /// <param name="skipModule">When set to true this callflow action is skipped, advancing to the wildcard branch (if any).</param>
        /// <param name="target">The target destination (extension or DID).</param>
        /// <param name="transferType">The type of transfer to perform (default to TransferTypeEnum.Blind).</param>
        public CallflowsTransfer(List<string> captures = default(List<string>), LegEnum? leg = default(LegEnum?), bool? skipModule = default(bool?), string target = default(string), TransferTypeEnum? transferType = TransferTypeEnum.Blind)
        {
            this.Captures = captures;
            this.Leg = leg;
            this.SkipModule = skipModule;
            this.Target = target;
            // use default value if no "transferType" provided
            if (transferType == null)
            {
                this.TransferType = TransferTypeEnum.Blind;
            }
            else
            {
                this.TransferType = transferType;
            }
        }
        
        /// <summary>
        /// What to default to using if no capture group is present
        /// </summary>
        /// <value>What to default to using if no capture group is present</value>
        [DataMember(Name="captures", EmitDefaultValue=false)]
        public List<string> Captures { get; set; }


        /// <summary>
        /// When set to true this callflow action is skipped, advancing to the wildcard branch (if any)
        /// </summary>
        /// <value>When set to true this callflow action is skipped, advancing to the wildcard branch (if any)</value>
        [DataMember(Name="skip_module", EmitDefaultValue=false)]
        public bool? SkipModule { get; set; }

        /// <summary>
        /// The target destination (extension or DID)
        /// </summary>
        /// <value>The target destination (extension or DID)</value>
        [DataMember(Name="target", EmitDefaultValue=false)]
        public string Target { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CallflowsTransfer {\n");
            sb.Append("  Captures: ").Append(Captures).Append("\n");
            sb.Append("  Leg: ").Append(Leg).Append("\n");
            sb.Append("  SkipModule: ").Append(SkipModule).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
            sb.Append("  TransferType: ").Append(TransferType).Append("\n");
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
            return this.Equals(input as CallflowsTransfer);
        }

        /// <summary>
        /// Returns true if CallflowsTransfer instances are equal
        /// </summary>
        /// <param name="input">Instance of CallflowsTransfer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallflowsTransfer input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Captures == input.Captures ||
                    this.Captures != null &&
                    this.Captures.SequenceEqual(input.Captures)
                ) && 
                (
                    this.Leg == input.Leg ||
                    (this.Leg != null &&
                    this.Leg.Equals(input.Leg))
                ) && 
                (
                    this.SkipModule == input.SkipModule ||
                    (this.SkipModule != null &&
                    this.SkipModule.Equals(input.SkipModule))
                ) && 
                (
                    this.Target == input.Target ||
                    (this.Target != null &&
                    this.Target.Equals(input.Target))
                ) && 
                (
                    this.TransferType == input.TransferType ||
                    (this.TransferType != null &&
                    this.TransferType.Equals(input.TransferType))
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
                if (this.Captures != null)
                    hashCode = hashCode * 59 + this.Captures.GetHashCode();
                if (this.Leg != null)
                    hashCode = hashCode * 59 + this.Leg.GetHashCode();
                if (this.SkipModule != null)
                    hashCode = hashCode * 59 + this.SkipModule.GetHashCode();
                if (this.Target != null)
                    hashCode = hashCode * 59 + this.Target.GetHashCode();
                if (this.TransferType != null)
                    hashCode = hashCode * 59 + this.TransferType.GetHashCode();
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
