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
    /// Schema for crossbar.voicemail system_config
    /// </summary>
    [DataContract]
    public partial class SystemConfigCrossbarVoicemail :  IEquatable<SystemConfigCrossbarVoicemail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemConfigCrossbarVoicemail" /> class.
        /// </summary>
        /// <param name="normalizationFormat">Voicemail default audio format (default to &quot;mp3&quot;).</param>
        /// <param name="normalizeMedia">Whether or not normalize voicemail audio file (default to false).</param>
        /// <param name="transcribeFormat">crossbar voicemail transcribe_format.</param>
        public SystemConfigCrossbarVoicemail(string normalizationFormat = "mp3", bool? normalizeMedia = false, string transcribeFormat = default(string))
        {
            // use default value if no "normalizationFormat" provided
            if (normalizationFormat == null)
            {
                this.NormalizationFormat = "mp3";
            }
            else
            {
                this.NormalizationFormat = normalizationFormat;
            }
            // use default value if no "normalizeMedia" provided
            if (normalizeMedia == null)
            {
                this.NormalizeMedia = false;
            }
            else
            {
                this.NormalizeMedia = normalizeMedia;
            }
            this.TranscribeFormat = transcribeFormat;
        }
        
        /// <summary>
        /// Voicemail default audio format
        /// </summary>
        /// <value>Voicemail default audio format</value>
        [DataMember(Name="normalization_format", EmitDefaultValue=false)]
        public string NormalizationFormat { get; set; }

        /// <summary>
        /// Whether or not normalize voicemail audio file
        /// </summary>
        /// <value>Whether or not normalize voicemail audio file</value>
        [DataMember(Name="normalize_media", EmitDefaultValue=false)]
        public bool? NormalizeMedia { get; set; }

        /// <summary>
        /// crossbar voicemail transcribe_format
        /// </summary>
        /// <value>crossbar voicemail transcribe_format</value>
        [DataMember(Name="transcribe_format", EmitDefaultValue=false)]
        public string TranscribeFormat { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SystemConfigCrossbarVoicemail {\n");
            sb.Append("  NormalizationFormat: ").Append(NormalizationFormat).Append("\n");
            sb.Append("  NormalizeMedia: ").Append(NormalizeMedia).Append("\n");
            sb.Append("  TranscribeFormat: ").Append(TranscribeFormat).Append("\n");
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
            return this.Equals(input as SystemConfigCrossbarVoicemail);
        }

        /// <summary>
        /// Returns true if SystemConfigCrossbarVoicemail instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemConfigCrossbarVoicemail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemConfigCrossbarVoicemail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NormalizationFormat == input.NormalizationFormat ||
                    (this.NormalizationFormat != null &&
                    this.NormalizationFormat.Equals(input.NormalizationFormat))
                ) && 
                (
                    this.NormalizeMedia == input.NormalizeMedia ||
                    (this.NormalizeMedia != null &&
                    this.NormalizeMedia.Equals(input.NormalizeMedia))
                ) && 
                (
                    this.TranscribeFormat == input.TranscribeFormat ||
                    (this.TranscribeFormat != null &&
                    this.TranscribeFormat.Equals(input.TranscribeFormat))
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
                if (this.NormalizationFormat != null)
                    hashCode = hashCode * 59 + this.NormalizationFormat.GetHashCode();
                if (this.NormalizeMedia != null)
                    hashCode = hashCode * 59 + this.NormalizeMedia.GetHashCode();
                if (this.TranscribeFormat != null)
                    hashCode = hashCode * 59 + this.TranscribeFormat.GetHashCode();
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