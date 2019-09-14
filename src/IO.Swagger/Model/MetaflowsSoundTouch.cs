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
    /// Pitch-shift and other audio effects
    /// </summary>
    [DataContract]
    public partial class MetaflowsSoundTouch :  IEquatable<MetaflowsSoundTouch>, IValidatableObject
    {
        /// <summary>
        /// Whether to start or stop touching the sound
        /// </summary>
        /// <value>Whether to start or stop touching the sound</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionEnum
        {
            
            /// <summary>
            /// Enum Start for value: start
            /// </summary>
            [EnumMember(Value = "start")]
            Start = 1,
            
            /// <summary>
            /// Enum Stop for value: stop
            /// </summary>
            [EnumMember(Value = "stop")]
            Stop = 2
        }

        /// <summary>
        /// Whether to start or stop touching the sound
        /// </summary>
        /// <value>Whether to start or stop touching the sound</value>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public ActionEnum? Action { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MetaflowsSoundTouch" /> class.
        /// </summary>
        /// <param name="action">Whether to start or stop touching the sound.</param>
        /// <param name="adjustInOctaves">Adjust the pitch in octaves.</param>
        /// <param name="adjustInSemitones">Adjust the pitch in semitones.</param>
        /// <param name="hookDtmf">Enable DTMF control of audio modifications (default to false).</param>
        /// <param name="pitch">Set the pitch directly (lower number &#x3D; lower tone).</param>
        /// <param name="rate">Set the rate directly.</param>
        /// <param name="sendingLeg">Apply the filter to the sending leg (default to false).</param>
        /// <param name="tempo">Set the tempo directly.</param>
        public MetaflowsSoundTouch(ActionEnum? action = default(ActionEnum?), decimal? adjustInOctaves = default(decimal?), decimal? adjustInSemitones = default(decimal?), bool? hookDtmf = false, decimal? pitch = default(decimal?), decimal? rate = default(decimal?), bool? sendingLeg = false, decimal? tempo = default(decimal?))
        {
            this.Action = action;
            this.AdjustInOctaves = adjustInOctaves;
            this.AdjustInSemitones = adjustInSemitones;
            // use default value if no "hookDtmf" provided
            if (hookDtmf == null)
            {
                this.HookDtmf = false;
            }
            else
            {
                this.HookDtmf = hookDtmf;
            }
            this.Pitch = pitch;
            this.Rate = rate;
            // use default value if no "sendingLeg" provided
            if (sendingLeg == null)
            {
                this.SendingLeg = false;
            }
            else
            {
                this.SendingLeg = sendingLeg;
            }
            this.Tempo = tempo;
        }
        

        /// <summary>
        /// Adjust the pitch in octaves
        /// </summary>
        /// <value>Adjust the pitch in octaves</value>
        [DataMember(Name="adjust_in_octaves", EmitDefaultValue=false)]
        public decimal? AdjustInOctaves { get; set; }

        /// <summary>
        /// Adjust the pitch in semitones
        /// </summary>
        /// <value>Adjust the pitch in semitones</value>
        [DataMember(Name="adjust_in_semitones", EmitDefaultValue=false)]
        public decimal? AdjustInSemitones { get; set; }

        /// <summary>
        /// Enable DTMF control of audio modifications
        /// </summary>
        /// <value>Enable DTMF control of audio modifications</value>
        [DataMember(Name="hook_dtmf", EmitDefaultValue=false)]
        public bool? HookDtmf { get; set; }

        /// <summary>
        /// Set the pitch directly (lower number &#x3D; lower tone)
        /// </summary>
        /// <value>Set the pitch directly (lower number &#x3D; lower tone)</value>
        [DataMember(Name="pitch", EmitDefaultValue=false)]
        public decimal? Pitch { get; set; }

        /// <summary>
        /// Set the rate directly
        /// </summary>
        /// <value>Set the rate directly</value>
        [DataMember(Name="rate", EmitDefaultValue=false)]
        public decimal? Rate { get; set; }

        /// <summary>
        /// Apply the filter to the sending leg
        /// </summary>
        /// <value>Apply the filter to the sending leg</value>
        [DataMember(Name="sending_leg", EmitDefaultValue=false)]
        public bool? SendingLeg { get; set; }

        /// <summary>
        /// Set the tempo directly
        /// </summary>
        /// <value>Set the tempo directly</value>
        [DataMember(Name="tempo", EmitDefaultValue=false)]
        public decimal? Tempo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetaflowsSoundTouch {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  AdjustInOctaves: ").Append(AdjustInOctaves).Append("\n");
            sb.Append("  AdjustInSemitones: ").Append(AdjustInSemitones).Append("\n");
            sb.Append("  HookDtmf: ").Append(HookDtmf).Append("\n");
            sb.Append("  Pitch: ").Append(Pitch).Append("\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
            sb.Append("  SendingLeg: ").Append(SendingLeg).Append("\n");
            sb.Append("  Tempo: ").Append(Tempo).Append("\n");
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
            return this.Equals(input as MetaflowsSoundTouch);
        }

        /// <summary>
        /// Returns true if MetaflowsSoundTouch instances are equal
        /// </summary>
        /// <param name="input">Instance of MetaflowsSoundTouch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MetaflowsSoundTouch input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.AdjustInOctaves == input.AdjustInOctaves ||
                    (this.AdjustInOctaves != null &&
                    this.AdjustInOctaves.Equals(input.AdjustInOctaves))
                ) && 
                (
                    this.AdjustInSemitones == input.AdjustInSemitones ||
                    (this.AdjustInSemitones != null &&
                    this.AdjustInSemitones.Equals(input.AdjustInSemitones))
                ) && 
                (
                    this.HookDtmf == input.HookDtmf ||
                    (this.HookDtmf != null &&
                    this.HookDtmf.Equals(input.HookDtmf))
                ) && 
                (
                    this.Pitch == input.Pitch ||
                    (this.Pitch != null &&
                    this.Pitch.Equals(input.Pitch))
                ) && 
                (
                    this.Rate == input.Rate ||
                    (this.Rate != null &&
                    this.Rate.Equals(input.Rate))
                ) && 
                (
                    this.SendingLeg == input.SendingLeg ||
                    (this.SendingLeg != null &&
                    this.SendingLeg.Equals(input.SendingLeg))
                ) && 
                (
                    this.Tempo == input.Tempo ||
                    (this.Tempo != null &&
                    this.Tempo.Equals(input.Tempo))
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
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.AdjustInOctaves != null)
                    hashCode = hashCode * 59 + this.AdjustInOctaves.GetHashCode();
                if (this.AdjustInSemitones != null)
                    hashCode = hashCode * 59 + this.AdjustInSemitones.GetHashCode();
                if (this.HookDtmf != null)
                    hashCode = hashCode * 59 + this.HookDtmf.GetHashCode();
                if (this.Pitch != null)
                    hashCode = hashCode * 59 + this.Pitch.GetHashCode();
                if (this.Rate != null)
                    hashCode = hashCode * 59 + this.Rate.GetHashCode();
                if (this.SendingLeg != null)
                    hashCode = hashCode * 59 + this.SendingLeg.GetHashCode();
                if (this.Tempo != null)
                    hashCode = hashCode * 59 + this.Tempo.GetHashCode();
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
            // AdjustInOctaves (decimal?) maximum
            if(this.AdjustInOctaves > (decimal?)1.0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AdjustInOctaves, must be a value less than or equal to 1.0.", new [] { "AdjustInOctaves" });
            }

            // AdjustInOctaves (decimal?) minimum
            if(this.AdjustInOctaves < (decimal?)-1.0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AdjustInOctaves, must be a value greater than or equal to -1.0.", new [] { "AdjustInOctaves" });
            }

            // AdjustInSemitones (decimal?) maximum
            if(this.AdjustInSemitones > (decimal?)14.0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AdjustInSemitones, must be a value less than or equal to 14.0.", new [] { "AdjustInSemitones" });
            }

            // AdjustInSemitones (decimal?) minimum
            if(this.AdjustInSemitones < (decimal?)-14.0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AdjustInSemitones, must be a value greater than or equal to -14.0.", new [] { "AdjustInSemitones" });
            }

            // Pitch (decimal?) minimum
            if(this.Pitch < (decimal?)1.0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Pitch, must be a value greater than or equal to 1.0.", new [] { "Pitch" });
            }

            // Rate (decimal?) minimum
            if(this.Rate < (decimal?)1.0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Rate, must be a value greater than or equal to 1.0.", new [] { "Rate" });
            }

            // Tempo (decimal?) minimum
            if(this.Tempo < (decimal?)1.0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Tempo, must be a value greater than or equal to 1.0.", new [] { "Tempo" });
            }

            yield break;
        }
    }

}