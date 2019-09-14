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
    /// The individual media to play
    /// </summary>
    [DataContract]
    public partial class CallflowsAudioMacroMacros :  IEquatable<CallflowsAudioMacroMacros>, IValidatableObject
    {
        /// <summary>
        /// the macro type to process
        /// </summary>
        /// <value>the macro type to process</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MacroEnum
        {
            
            /// <summary>
            /// Enum Play for value: play
            /// </summary>
            [EnumMember(Value = "play")]
            Play = 1,
            
            /// <summary>
            /// Enum Prompt for value: prompt
            /// </summary>
            [EnumMember(Value = "prompt")]
            Prompt = 2,
            
            /// <summary>
            /// Enum Say for value: say
            /// </summary>
            [EnumMember(Value = "say")]
            Say = 3,
            
            /// <summary>
            /// Enum Tts for value: tts
            /// </summary>
            [EnumMember(Value = "tts")]
            Tts = 4,
            
            /// <summary>
            /// Enum Tone for value: tone
            /// </summary>
            [EnumMember(Value = "tone")]
            Tone = 5
        }

        /// <summary>
        /// the macro type to process
        /// </summary>
        /// <value>the macro type to process</value>
        [DataMember(Name="macro", EmitDefaultValue=false)]
        public MacroEnum Macro { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CallflowsAudioMacroMacros" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CallflowsAudioMacroMacros() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CallflowsAudioMacroMacros" /> class.
        /// </summary>
        /// <param name="macro">the macro type to process (required).</param>
        public CallflowsAudioMacroMacros(MacroEnum macro = default(MacroEnum))
        {
            // to ensure "macro" is required (not null)
            if (macro == null)
            {
                throw new InvalidDataException("macro is a required property for CallflowsAudioMacroMacros and cannot be null");
            }
            else
            {
                this.Macro = macro;
            }
        }
        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CallflowsAudioMacroMacros {\n");
            sb.Append("  Macro: ").Append(Macro).Append("\n");
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
            return this.Equals(input as CallflowsAudioMacroMacros);
        }

        /// <summary>
        /// Returns true if CallflowsAudioMacroMacros instances are equal
        /// </summary>
        /// <param name="input">Instance of CallflowsAudioMacroMacros to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallflowsAudioMacroMacros input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Macro == input.Macro ||
                    (this.Macro != null &&
                    this.Macro.Equals(input.Macro))
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
                if (this.Macro != null)
                    hashCode = hashCode * 59 + this.Macro.GetHashCode();
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