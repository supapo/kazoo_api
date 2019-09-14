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
    /// Skeleton JSON schema
    /// </summary>
    [DataContract]
    public partial class MetaflowsIntercept :  IEquatable<MetaflowsIntercept>, IValidatableObject
    {
        /// <summary>
        /// Type of entity of the target
        /// </summary>
        /// <value>Type of entity of the target</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TargetTypeEnum
        {
            
            /// <summary>
            /// Enum Device for value: device
            /// </summary>
            [EnumMember(Value = "device")]
            Device = 1,
            
            /// <summary>
            /// Enum User for value: user
            /// </summary>
            [EnumMember(Value = "user")]
            User = 2,
            
            /// <summary>
            /// Enum Number for value: number
            /// </summary>
            [EnumMember(Value = "number")]
            Number = 3
        }

        /// <summary>
        /// Type of entity of the target
        /// </summary>
        /// <value>Type of entity of the target</value>
        [DataMember(Name="target_type", EmitDefaultValue=false)]
        public TargetTypeEnum? TargetType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MetaflowsIntercept" /> class.
        /// </summary>
        /// <param name="autoAnswer">Auto-answer the leg (default to false).</param>
        /// <param name="canCallSelf">Can intercept devices of the same targeted user (default to true).</param>
        /// <param name="targetId">ID of the target (device or user).</param>
        /// <param name="targetType">Type of entity of the target.</param>
        /// <param name="unbridgedOnly">Only intercept if the a-leg is unbridged (default to true).</param>
        public MetaflowsIntercept(bool? autoAnswer = false, bool? canCallSelf = true, string targetId = default(string), TargetTypeEnum? targetType = default(TargetTypeEnum?), bool? unbridgedOnly = true)
        {
            // use default value if no "autoAnswer" provided
            if (autoAnswer == null)
            {
                this.AutoAnswer = false;
            }
            else
            {
                this.AutoAnswer = autoAnswer;
            }
            // use default value if no "canCallSelf" provided
            if (canCallSelf == null)
            {
                this.CanCallSelf = true;
            }
            else
            {
                this.CanCallSelf = canCallSelf;
            }
            this.TargetId = targetId;
            this.TargetType = targetType;
            // use default value if no "unbridgedOnly" provided
            if (unbridgedOnly == null)
            {
                this.UnbridgedOnly = true;
            }
            else
            {
                this.UnbridgedOnly = unbridgedOnly;
            }
        }
        
        /// <summary>
        /// Auto-answer the leg
        /// </summary>
        /// <value>Auto-answer the leg</value>
        [DataMember(Name="auto_answer", EmitDefaultValue=false)]
        public bool? AutoAnswer { get; set; }

        /// <summary>
        /// Can intercept devices of the same targeted user
        /// </summary>
        /// <value>Can intercept devices of the same targeted user</value>
        [DataMember(Name="can_call_self", EmitDefaultValue=false)]
        public bool? CanCallSelf { get; set; }

        /// <summary>
        /// ID of the target (device or user)
        /// </summary>
        /// <value>ID of the target (device or user)</value>
        [DataMember(Name="target_id", EmitDefaultValue=false)]
        public string TargetId { get; set; }


        /// <summary>
        /// Only intercept if the a-leg is unbridged
        /// </summary>
        /// <value>Only intercept if the a-leg is unbridged</value>
        [DataMember(Name="unbridged_only", EmitDefaultValue=false)]
        public bool? UnbridgedOnly { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetaflowsIntercept {\n");
            sb.Append("  AutoAnswer: ").Append(AutoAnswer).Append("\n");
            sb.Append("  CanCallSelf: ").Append(CanCallSelf).Append("\n");
            sb.Append("  TargetId: ").Append(TargetId).Append("\n");
            sb.Append("  TargetType: ").Append(TargetType).Append("\n");
            sb.Append("  UnbridgedOnly: ").Append(UnbridgedOnly).Append("\n");
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
            return this.Equals(input as MetaflowsIntercept);
        }

        /// <summary>
        /// Returns true if MetaflowsIntercept instances are equal
        /// </summary>
        /// <param name="input">Instance of MetaflowsIntercept to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MetaflowsIntercept input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AutoAnswer == input.AutoAnswer ||
                    (this.AutoAnswer != null &&
                    this.AutoAnswer.Equals(input.AutoAnswer))
                ) && 
                (
                    this.CanCallSelf == input.CanCallSelf ||
                    (this.CanCallSelf != null &&
                    this.CanCallSelf.Equals(input.CanCallSelf))
                ) && 
                (
                    this.TargetId == input.TargetId ||
                    (this.TargetId != null &&
                    this.TargetId.Equals(input.TargetId))
                ) && 
                (
                    this.TargetType == input.TargetType ||
                    (this.TargetType != null &&
                    this.TargetType.Equals(input.TargetType))
                ) && 
                (
                    this.UnbridgedOnly == input.UnbridgedOnly ||
                    (this.UnbridgedOnly != null &&
                    this.UnbridgedOnly.Equals(input.UnbridgedOnly))
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
                if (this.AutoAnswer != null)
                    hashCode = hashCode * 59 + this.AutoAnswer.GetHashCode();
                if (this.CanCallSelf != null)
                    hashCode = hashCode * 59 + this.CanCallSelf.GetHashCode();
                if (this.TargetId != null)
                    hashCode = hashCode * 59 + this.TargetId.GetHashCode();
                if (this.TargetType != null)
                    hashCode = hashCode * 59 + this.TargetType.GetHashCode();
                if (this.UnbridgedOnly != null)
                    hashCode = hashCode * 59 + this.UnbridgedOnly.GetHashCode();
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
