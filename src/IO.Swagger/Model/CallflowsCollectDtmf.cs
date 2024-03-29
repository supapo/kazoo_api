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
    /// Validator for the Collect DTMF callflow element
    /// </summary>
    [DataContract]
    public partial class CallflowsCollectDtmf :  IEquatable<CallflowsCollectDtmf>, IValidatableObject
    {
        /// <summary>
        /// What DTMF will terminate collection before the timeout occurs
        /// </summary>
        /// <value>What DTMF will terminate collection before the timeout occurs</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TerminatorEnum
        {
            
            /// <summary>
            /// Enum _1 for value: 1
            /// </summary>
            [EnumMember(Value = "1")]
            _1 = 1,
            
            /// <summary>
            /// Enum _2 for value: 2
            /// </summary>
            [EnumMember(Value = "2")]
            _2 = 2,
            
            /// <summary>
            /// Enum _3 for value: 3
            /// </summary>
            [EnumMember(Value = "3")]
            _3 = 3,
            
            /// <summary>
            /// Enum _4 for value: 4
            /// </summary>
            [EnumMember(Value = "4")]
            _4 = 4,
            
            /// <summary>
            /// Enum _5 for value: 5
            /// </summary>
            [EnumMember(Value = "5")]
            _5 = 5,
            
            /// <summary>
            /// Enum _6 for value: 6
            /// </summary>
            [EnumMember(Value = "6")]
            _6 = 6,
            
            /// <summary>
            /// Enum _7 for value: 7
            /// </summary>
            [EnumMember(Value = "7")]
            _7 = 7,
            
            /// <summary>
            /// Enum _8 for value: 8
            /// </summary>
            [EnumMember(Value = "8")]
            _8 = 8,
            
            /// <summary>
            /// Enum _9 for value: 9
            /// </summary>
            [EnumMember(Value = "9")]
            _9 = 9,
            
            /// <summary>
            /// Enum _0 for value: 0
            /// </summary>
            [EnumMember(Value = "0")]
            _0 = 10,
            
            /// <summary>
            /// Enum Hash for value: #
            /// </summary>
            [EnumMember(Value = "#")]
            Hash = 11,
            
            /// <summary>
            /// Enum Star for value: *
            /// </summary>
            [EnumMember(Value = "*")]
            Star = 12
        }

        /// <summary>
        /// What DTMF will terminate collection before the timeout occurs
        /// </summary>
        /// <value>What DTMF will terminate collection before the timeout occurs</value>
        [DataMember(Name="terminator", EmitDefaultValue=false)]
        public TerminatorEnum? Terminator { get; set; }
        /// <summary>
        /// Defines Terminators
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TerminatorsEnum
        {
            
            /// <summary>
            /// Enum _1 for value: 1
            /// </summary>
            [EnumMember(Value = "1")]
            _1 = 1,
            
            /// <summary>
            /// Enum _2 for value: 2
            /// </summary>
            [EnumMember(Value = "2")]
            _2 = 2,
            
            /// <summary>
            /// Enum _3 for value: 3
            /// </summary>
            [EnumMember(Value = "3")]
            _3 = 3,
            
            /// <summary>
            /// Enum _4 for value: 4
            /// </summary>
            [EnumMember(Value = "4")]
            _4 = 4,
            
            /// <summary>
            /// Enum _5 for value: 5
            /// </summary>
            [EnumMember(Value = "5")]
            _5 = 5,
            
            /// <summary>
            /// Enum _6 for value: 6
            /// </summary>
            [EnumMember(Value = "6")]
            _6 = 6,
            
            /// <summary>
            /// Enum _7 for value: 7
            /// </summary>
            [EnumMember(Value = "7")]
            _7 = 7,
            
            /// <summary>
            /// Enum _8 for value: 8
            /// </summary>
            [EnumMember(Value = "8")]
            _8 = 8,
            
            /// <summary>
            /// Enum _9 for value: 9
            /// </summary>
            [EnumMember(Value = "9")]
            _9 = 9,
            
            /// <summary>
            /// Enum _0 for value: 0
            /// </summary>
            [EnumMember(Value = "0")]
            _0 = 10,
            
            /// <summary>
            /// Enum Hash for value: #
            /// </summary>
            [EnumMember(Value = "#")]
            Hash = 11,
            
            /// <summary>
            /// Enum Star for value: *
            /// </summary>
            [EnumMember(Value = "*")]
            Star = 12
        }


        /// <summary>
        /// What DTMFs will terminate collection before the timeout occurs
        /// </summary>
        /// <value>What DTMFs will terminate collection before the timeout occurs</value>
        [DataMember(Name="terminators", EmitDefaultValue=false)]
        public List<TerminatorsEnum> Terminators { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CallflowsCollectDtmf" /> class.
        /// </summary>
        /// <param name="collectionName">Store collected DTMF in a named key.</param>
        /// <param name="interdigitTimeout">How long, in milliseconds, to wait for the next DTMF.</param>
        /// <param name="maxDigits">How many DTMFs to collect from the caller.</param>
        /// <param name="skipModule">When set to true this callflow action is skipped, advancing to the wildcard branch (if any).</param>
        /// <param name="terminator">What DTMF will terminate collection before the timeout occurs (default to TerminatorEnum.Hash).</param>
        /// <param name="terminators">What DTMFs will terminate collection before the timeout occurs.</param>
        /// <param name="timeout">How long, in milliseconds, to wait for the first DTMF.</param>
        public CallflowsCollectDtmf(string collectionName = default(string), int? interdigitTimeout = default(int?), int? maxDigits = default(int?), bool? skipModule = default(bool?), TerminatorEnum? terminator = TerminatorEnum.Hash, List<TerminatorsEnum> terminators = default(List<TerminatorsEnum>), int? timeout = default(int?))
        {
            this.CollectionName = collectionName;
            this.InterdigitTimeout = interdigitTimeout;
            this.MaxDigits = maxDigits;
            this.SkipModule = skipModule;
            // use default value if no "terminator" provided
            if (terminator == null)
            {
                this.Terminator = TerminatorEnum.Hash;
            }
            else
            {
                this.Terminator = terminator;
            }
            this.Terminators = terminators;
            this.Timeout = timeout;
        }
        
        /// <summary>
        /// Store collected DTMF in a named key
        /// </summary>
        /// <value>Store collected DTMF in a named key</value>
        [DataMember(Name="collection_name", EmitDefaultValue=false)]
        public string CollectionName { get; set; }

        /// <summary>
        /// How long, in milliseconds, to wait for the next DTMF
        /// </summary>
        /// <value>How long, in milliseconds, to wait for the next DTMF</value>
        [DataMember(Name="interdigit_timeout", EmitDefaultValue=false)]
        public int? InterdigitTimeout { get; set; }

        /// <summary>
        /// How many DTMFs to collect from the caller
        /// </summary>
        /// <value>How many DTMFs to collect from the caller</value>
        [DataMember(Name="max_digits", EmitDefaultValue=false)]
        public int? MaxDigits { get; set; }

        /// <summary>
        /// When set to true this callflow action is skipped, advancing to the wildcard branch (if any)
        /// </summary>
        /// <value>When set to true this callflow action is skipped, advancing to the wildcard branch (if any)</value>
        [DataMember(Name="skip_module", EmitDefaultValue=false)]
        public bool? SkipModule { get; set; }



        /// <summary>
        /// How long, in milliseconds, to wait for the first DTMF
        /// </summary>
        /// <value>How long, in milliseconds, to wait for the first DTMF</value>
        [DataMember(Name="timeout", EmitDefaultValue=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CallflowsCollectDtmf {\n");
            sb.Append("  CollectionName: ").Append(CollectionName).Append("\n");
            sb.Append("  InterdigitTimeout: ").Append(InterdigitTimeout).Append("\n");
            sb.Append("  MaxDigits: ").Append(MaxDigits).Append("\n");
            sb.Append("  SkipModule: ").Append(SkipModule).Append("\n");
            sb.Append("  Terminator: ").Append(Terminator).Append("\n");
            sb.Append("  Terminators: ").Append(Terminators).Append("\n");
            sb.Append("  Timeout: ").Append(Timeout).Append("\n");
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
            return this.Equals(input as CallflowsCollectDtmf);
        }

        /// <summary>
        /// Returns true if CallflowsCollectDtmf instances are equal
        /// </summary>
        /// <param name="input">Instance of CallflowsCollectDtmf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallflowsCollectDtmf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CollectionName == input.CollectionName ||
                    (this.CollectionName != null &&
                    this.CollectionName.Equals(input.CollectionName))
                ) && 
                (
                    this.InterdigitTimeout == input.InterdigitTimeout ||
                    (this.InterdigitTimeout != null &&
                    this.InterdigitTimeout.Equals(input.InterdigitTimeout))
                ) && 
                (
                    this.MaxDigits == input.MaxDigits ||
                    (this.MaxDigits != null &&
                    this.MaxDigits.Equals(input.MaxDigits))
                ) && 
                (
                    this.SkipModule == input.SkipModule ||
                    (this.SkipModule != null &&
                    this.SkipModule.Equals(input.SkipModule))
                ) && 
                (
                    this.Terminator == input.Terminator ||
                    (this.Terminator != null &&
                    this.Terminator.Equals(input.Terminator))
                ) && 
                (
                    this.Terminators == input.Terminators ||
                    this.Terminators != null &&
                    this.Terminators.SequenceEqual(input.Terminators)
                ) && 
                (
                    this.Timeout == input.Timeout ||
                    (this.Timeout != null &&
                    this.Timeout.Equals(input.Timeout))
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
                if (this.CollectionName != null)
                    hashCode = hashCode * 59 + this.CollectionName.GetHashCode();
                if (this.InterdigitTimeout != null)
                    hashCode = hashCode * 59 + this.InterdigitTimeout.GetHashCode();
                if (this.MaxDigits != null)
                    hashCode = hashCode * 59 + this.MaxDigits.GetHashCode();
                if (this.SkipModule != null)
                    hashCode = hashCode * 59 + this.SkipModule.GetHashCode();
                if (this.Terminator != null)
                    hashCode = hashCode * 59 + this.Terminator.GetHashCode();
                if (this.Terminators != null)
                    hashCode = hashCode * 59 + this.Terminators.GetHashCode();
                if (this.Timeout != null)
                    hashCode = hashCode * 59 + this.Timeout.GetHashCode();
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
            // InterdigitTimeout (int?) minimum
            if(this.InterdigitTimeout < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InterdigitTimeout, must be a value greater than or equal to 1.", new [] { "InterdigitTimeout" });
            }

            // MaxDigits (int?) minimum
            if(this.MaxDigits < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaxDigits, must be a value greater than or equal to 1.", new [] { "MaxDigits" });
            }

            // Timeout (int?) minimum
            if(this.Timeout < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Timeout, must be a value greater than or equal to 1.", new [] { "Timeout" });
            }

            yield break;
        }
    }

}
