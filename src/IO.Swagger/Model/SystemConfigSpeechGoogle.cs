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
    /// Schema for speech.google system_config
    /// </summary>
    [DataContract]
    public partial class SystemConfigSpeechGoogle :  IEquatable<SystemConfigSpeechGoogle>, IValidatableObject
    {
        /// <summary>
        /// model to select for the given request
        /// </summary>
        /// <value>model to select for the given request</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AsrModelEnum
        {
            
            /// <summary>
            /// Enum Commandandsearch for value: command_and_search
            /// </summary>
            [EnumMember(Value = "command_and_search")]
            Commandandsearch = 1,
            
            /// <summary>
            /// Enum Phonecall for value: phone_call
            /// </summary>
            [EnumMember(Value = "phone_call")]
            Phonecall = 2,
            
            /// <summary>
            /// Enum Video for value: video
            /// </summary>
            [EnumMember(Value = "video")]
            Video = 3,
            
            /// <summary>
            /// Enum Default for value: default
            /// </summary>
            [EnumMember(Value = "default")]
            Default = 4
        }

        /// <summary>
        /// model to select for the given request
        /// </summary>
        /// <value>model to select for the given request</value>
        [DataMember(Name="asr_model", EmitDefaultValue=false)]
        public AsrModelEnum? AsrModel { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemConfigSpeechGoogle" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SystemConfigSpeechGoogle() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemConfigSpeechGoogle" /> class.
        /// </summary>
        /// <param name="asrApiKey">API key for Google Cloud Speech (required) (default to &quot;&quot;).</param>
        /// <param name="asrEnableAutomaticPunctuation">detect and insert punctuation in transcription results (default to true).</param>
        /// <param name="asrEnableWordTimeOffsets">top result includes a list of words and the start and end time offsets.</param>
        /// <param name="asrModel">model to select for the given request (default to AsrModelEnum.Phonecall).</param>
        /// <param name="asrProfanityFilter">server will attempt to filter out profanities, replacing all but the initial character in each filtered word with asterisk.</param>
        /// <param name="asrUrl">Google Cloud Speech API url (default to &quot;https://speech.googleapis.com/v1/speech:recognize&quot;).</param>
        /// <param name="asrUseEnhanced">use an enhanced model for speech recognition (default to true).</param>
        /// <param name="ttsApiKey">speech google tts_api_key (default to &quot;&quot;).</param>
        /// <param name="ttsUrl">speech google tts_url (default to &quot;https://texttospeech.googleapis.com/v1/text:synthesize&quot;).</param>
        public SystemConfigSpeechGoogle(string asrApiKey = "", bool? asrEnableAutomaticPunctuation = true, bool? asrEnableWordTimeOffsets = default(bool?), AsrModelEnum? asrModel = AsrModelEnum.Phonecall, bool? asrProfanityFilter = default(bool?), string asrUrl = "https://speech.googleapis.com/v1/speech:recognize", bool? asrUseEnhanced = true, string ttsApiKey = "", string ttsUrl = "https://texttospeech.googleapis.com/v1/text:synthesize")
        {
            // to ensure "asrApiKey" is required (not null)
            if (asrApiKey == null)
            {
                throw new InvalidDataException("asrApiKey is a required property for SystemConfigSpeechGoogle and cannot be null");
            }
            else
            {
                this.AsrApiKey = asrApiKey;
            }
            // use default value if no "asrEnableAutomaticPunctuation" provided
            if (asrEnableAutomaticPunctuation == null)
            {
                this.AsrEnableAutomaticPunctuation = true;
            }
            else
            {
                this.AsrEnableAutomaticPunctuation = asrEnableAutomaticPunctuation;
            }
            this.AsrEnableWordTimeOffsets = asrEnableWordTimeOffsets;
            // use default value if no "asrModel" provided
            if (asrModel == null)
            {
                this.AsrModel = AsrModelEnum.Phonecall;
            }
            else
            {
                this.AsrModel = asrModel;
            }
            this.AsrProfanityFilter = asrProfanityFilter;
            // use default value if no "asrUrl" provided
            if (asrUrl == null)
            {
                this.AsrUrl = "https://speech.googleapis.com/v1/speech:recognize";
            }
            else
            {
                this.AsrUrl = asrUrl;
            }
            // use default value if no "asrUseEnhanced" provided
            if (asrUseEnhanced == null)
            {
                this.AsrUseEnhanced = true;
            }
            else
            {
                this.AsrUseEnhanced = asrUseEnhanced;
            }
            // use default value if no "ttsApiKey" provided
            if (ttsApiKey == null)
            {
                this.TtsApiKey = "";
            }
            else
            {
                this.TtsApiKey = ttsApiKey;
            }
            // use default value if no "ttsUrl" provided
            if (ttsUrl == null)
            {
                this.TtsUrl = "https://texttospeech.googleapis.com/v1/text:synthesize";
            }
            else
            {
                this.TtsUrl = ttsUrl;
            }
        }
        
        /// <summary>
        /// API key for Google Cloud Speech
        /// </summary>
        /// <value>API key for Google Cloud Speech</value>
        [DataMember(Name="asr_api_key", EmitDefaultValue=false)]
        public string AsrApiKey { get; set; }

        /// <summary>
        /// detect and insert punctuation in transcription results
        /// </summary>
        /// <value>detect and insert punctuation in transcription results</value>
        [DataMember(Name="asr_enable_automatic_punctuation", EmitDefaultValue=false)]
        public bool? AsrEnableAutomaticPunctuation { get; set; }

        /// <summary>
        /// top result includes a list of words and the start and end time offsets
        /// </summary>
        /// <value>top result includes a list of words and the start and end time offsets</value>
        [DataMember(Name="asr_enable_word_time_offsets", EmitDefaultValue=false)]
        public bool? AsrEnableWordTimeOffsets { get; set; }


        /// <summary>
        /// server will attempt to filter out profanities, replacing all but the initial character in each filtered word with asterisk
        /// </summary>
        /// <value>server will attempt to filter out profanities, replacing all but the initial character in each filtered word with asterisk</value>
        [DataMember(Name="asr_profanity_filter", EmitDefaultValue=false)]
        public bool? AsrProfanityFilter { get; set; }

        /// <summary>
        /// Google Cloud Speech API url
        /// </summary>
        /// <value>Google Cloud Speech API url</value>
        [DataMember(Name="asr_url", EmitDefaultValue=false)]
        public string AsrUrl { get; set; }

        /// <summary>
        /// use an enhanced model for speech recognition
        /// </summary>
        /// <value>use an enhanced model for speech recognition</value>
        [DataMember(Name="asr_use_enhanced", EmitDefaultValue=false)]
        public bool? AsrUseEnhanced { get; set; }

        /// <summary>
        /// speech google tts_api_key
        /// </summary>
        /// <value>speech google tts_api_key</value>
        [DataMember(Name="tts_api_key", EmitDefaultValue=false)]
        public string TtsApiKey { get; set; }

        /// <summary>
        /// speech google tts_url
        /// </summary>
        /// <value>speech google tts_url</value>
        [DataMember(Name="tts_url", EmitDefaultValue=false)]
        public string TtsUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SystemConfigSpeechGoogle {\n");
            sb.Append("  AsrApiKey: ").Append(AsrApiKey).Append("\n");
            sb.Append("  AsrEnableAutomaticPunctuation: ").Append(AsrEnableAutomaticPunctuation).Append("\n");
            sb.Append("  AsrEnableWordTimeOffsets: ").Append(AsrEnableWordTimeOffsets).Append("\n");
            sb.Append("  AsrModel: ").Append(AsrModel).Append("\n");
            sb.Append("  AsrProfanityFilter: ").Append(AsrProfanityFilter).Append("\n");
            sb.Append("  AsrUrl: ").Append(AsrUrl).Append("\n");
            sb.Append("  AsrUseEnhanced: ").Append(AsrUseEnhanced).Append("\n");
            sb.Append("  TtsApiKey: ").Append(TtsApiKey).Append("\n");
            sb.Append("  TtsUrl: ").Append(TtsUrl).Append("\n");
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
            return this.Equals(input as SystemConfigSpeechGoogle);
        }

        /// <summary>
        /// Returns true if SystemConfigSpeechGoogle instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemConfigSpeechGoogle to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemConfigSpeechGoogle input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AsrApiKey == input.AsrApiKey ||
                    (this.AsrApiKey != null &&
                    this.AsrApiKey.Equals(input.AsrApiKey))
                ) && 
                (
                    this.AsrEnableAutomaticPunctuation == input.AsrEnableAutomaticPunctuation ||
                    (this.AsrEnableAutomaticPunctuation != null &&
                    this.AsrEnableAutomaticPunctuation.Equals(input.AsrEnableAutomaticPunctuation))
                ) && 
                (
                    this.AsrEnableWordTimeOffsets == input.AsrEnableWordTimeOffsets ||
                    (this.AsrEnableWordTimeOffsets != null &&
                    this.AsrEnableWordTimeOffsets.Equals(input.AsrEnableWordTimeOffsets))
                ) && 
                (
                    this.AsrModel == input.AsrModel ||
                    (this.AsrModel != null &&
                    this.AsrModel.Equals(input.AsrModel))
                ) && 
                (
                    this.AsrProfanityFilter == input.AsrProfanityFilter ||
                    (this.AsrProfanityFilter != null &&
                    this.AsrProfanityFilter.Equals(input.AsrProfanityFilter))
                ) && 
                (
                    this.AsrUrl == input.AsrUrl ||
                    (this.AsrUrl != null &&
                    this.AsrUrl.Equals(input.AsrUrl))
                ) && 
                (
                    this.AsrUseEnhanced == input.AsrUseEnhanced ||
                    (this.AsrUseEnhanced != null &&
                    this.AsrUseEnhanced.Equals(input.AsrUseEnhanced))
                ) && 
                (
                    this.TtsApiKey == input.TtsApiKey ||
                    (this.TtsApiKey != null &&
                    this.TtsApiKey.Equals(input.TtsApiKey))
                ) && 
                (
                    this.TtsUrl == input.TtsUrl ||
                    (this.TtsUrl != null &&
                    this.TtsUrl.Equals(input.TtsUrl))
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
                if (this.AsrApiKey != null)
                    hashCode = hashCode * 59 + this.AsrApiKey.GetHashCode();
                if (this.AsrEnableAutomaticPunctuation != null)
                    hashCode = hashCode * 59 + this.AsrEnableAutomaticPunctuation.GetHashCode();
                if (this.AsrEnableWordTimeOffsets != null)
                    hashCode = hashCode * 59 + this.AsrEnableWordTimeOffsets.GetHashCode();
                if (this.AsrModel != null)
                    hashCode = hashCode * 59 + this.AsrModel.GetHashCode();
                if (this.AsrProfanityFilter != null)
                    hashCode = hashCode * 59 + this.AsrProfanityFilter.GetHashCode();
                if (this.AsrUrl != null)
                    hashCode = hashCode * 59 + this.AsrUrl.GetHashCode();
                if (this.AsrUseEnhanced != null)
                    hashCode = hashCode * 59 + this.AsrUseEnhanced.GetHashCode();
                if (this.TtsApiKey != null)
                    hashCode = hashCode * 59 + this.TtsApiKey.GetHashCode();
                if (this.TtsUrl != null)
                    hashCode = hashCode * 59 + this.TtsUrl.GetHashCode();
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
