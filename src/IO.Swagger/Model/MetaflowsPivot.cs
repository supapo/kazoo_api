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
    /// Validator for the Pivot metaflow element
    /// </summary>
    [DataContract]
    public partial class MetaflowsPivot :  IEquatable<MetaflowsPivot>, IValidatableObject
    {
        /// <summary>
        /// What HTTP verb to send the request(s) with
        /// </summary>
        /// <value>What HTTP verb to send the request(s) with</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MethodEnum
        {
            
            /// <summary>
            /// Enum Get for value: get
            /// </summary>
            [EnumMember(Value = "get")]
            Get = 1,
            
            /// <summary>
            /// Enum Post for value: post
            /// </summary>
            [EnumMember(Value = "post")]
            Post = 2,
            
            /// <summary>
            /// Enum GET for value: GET
            /// </summary>
            [EnumMember(Value = "GET")]
            GET = 3,
            
            /// <summary>
            /// Enum POST for value: POST
            /// </summary>
            [EnumMember(Value = "POST")]
            POST = 4
        }

        /// <summary>
        /// What HTTP verb to send the request(s) with
        /// </summary>
        /// <value>What HTTP verb to send the request(s) with</value>
        [DataMember(Name="method", EmitDefaultValue=false)]
        public MethodEnum? Method { get; set; }
        /// <summary>
        /// What format of Pivot will the your server respond with
        /// </summary>
        /// <value>What format of Pivot will the your server respond with</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReqFormatEnum
        {
            
            /// <summary>
            /// Enum Kazoo for value: kazoo
            /// </summary>
            [EnumMember(Value = "kazoo")]
            Kazoo = 1,
            
            /// <summary>
            /// Enum Twiml for value: twiml
            /// </summary>
            [EnumMember(Value = "twiml")]
            Twiml = 2
        }

        /// <summary>
        /// What format of Pivot will the your server respond with
        /// </summary>
        /// <value>What format of Pivot will the your server respond with</value>
        [DataMember(Name="req_format", EmitDefaultValue=false)]
        public ReqFormatEnum? ReqFormat { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MetaflowsPivot" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MetaflowsPivot() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MetaflowsPivot" /> class.
        /// </summary>
        /// <param name="cdrUrl">Optional URL to send the CDR to at the end of the call.</param>
        /// <param name="debug">Store debug logs related to processing this Pivot call (default to false).</param>
        /// <param name="method">What HTTP verb to send the request(s) with (default to MethodEnum.Get).</param>
        /// <param name="reqFormat">What format of Pivot will the your server respond with (default to ReqFormatEnum.Kazoo).</param>
        /// <param name="voiceUrl">What URL to request the initial Pivot callflow (required).</param>
        public MetaflowsPivot(string cdrUrl = default(string), bool? debug = false, MethodEnum? method = MethodEnum.Get, ReqFormatEnum? reqFormat = ReqFormatEnum.Kazoo, string voiceUrl = default(string))
        {
            // to ensure "voiceUrl" is required (not null)
            if (voiceUrl == null)
            {
                throw new InvalidDataException("voiceUrl is a required property for MetaflowsPivot and cannot be null");
            }
            else
            {
                this.VoiceUrl = voiceUrl;
            }
            this.CdrUrl = cdrUrl;
            // use default value if no "debug" provided
            if (debug == null)
            {
                this.Debug = false;
            }
            else
            {
                this.Debug = debug;
            }
            // use default value if no "method" provided
            if (method == null)
            {
                this.Method = MethodEnum.Get;
            }
            else
            {
                this.Method = method;
            }
            // use default value if no "reqFormat" provided
            if (reqFormat == null)
            {
                this.ReqFormat = ReqFormatEnum.Kazoo;
            }
            else
            {
                this.ReqFormat = reqFormat;
            }
        }
        
        /// <summary>
        /// Optional URL to send the CDR to at the end of the call
        /// </summary>
        /// <value>Optional URL to send the CDR to at the end of the call</value>
        [DataMember(Name="cdr_url", EmitDefaultValue=false)]
        public string CdrUrl { get; set; }

        /// <summary>
        /// Store debug logs related to processing this Pivot call
        /// </summary>
        /// <value>Store debug logs related to processing this Pivot call</value>
        [DataMember(Name="debug", EmitDefaultValue=false)]
        public bool? Debug { get; set; }



        /// <summary>
        /// What URL to request the initial Pivot callflow
        /// </summary>
        /// <value>What URL to request the initial Pivot callflow</value>
        [DataMember(Name="voice_url", EmitDefaultValue=false)]
        public string VoiceUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetaflowsPivot {\n");
            sb.Append("  CdrUrl: ").Append(CdrUrl).Append("\n");
            sb.Append("  Debug: ").Append(Debug).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  ReqFormat: ").Append(ReqFormat).Append("\n");
            sb.Append("  VoiceUrl: ").Append(VoiceUrl).Append("\n");
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
            return this.Equals(input as MetaflowsPivot);
        }

        /// <summary>
        /// Returns true if MetaflowsPivot instances are equal
        /// </summary>
        /// <param name="input">Instance of MetaflowsPivot to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MetaflowsPivot input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CdrUrl == input.CdrUrl ||
                    (this.CdrUrl != null &&
                    this.CdrUrl.Equals(input.CdrUrl))
                ) && 
                (
                    this.Debug == input.Debug ||
                    (this.Debug != null &&
                    this.Debug.Equals(input.Debug))
                ) && 
                (
                    this.Method == input.Method ||
                    (this.Method != null &&
                    this.Method.Equals(input.Method))
                ) && 
                (
                    this.ReqFormat == input.ReqFormat ||
                    (this.ReqFormat != null &&
                    this.ReqFormat.Equals(input.ReqFormat))
                ) && 
                (
                    this.VoiceUrl == input.VoiceUrl ||
                    (this.VoiceUrl != null &&
                    this.VoiceUrl.Equals(input.VoiceUrl))
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
                if (this.CdrUrl != null)
                    hashCode = hashCode * 59 + this.CdrUrl.GetHashCode();
                if (this.Debug != null)
                    hashCode = hashCode * 59 + this.Debug.GetHashCode();
                if (this.Method != null)
                    hashCode = hashCode * 59 + this.Method.GetHashCode();
                if (this.ReqFormat != null)
                    hashCode = hashCode * 59 + this.ReqFormat.GetHashCode();
                if (this.VoiceUrl != null)
                    hashCode = hashCode * 59 + this.VoiceUrl.GetHashCode();
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
            // CdrUrl (string) pattern
            Regex regexCdrUrl = new Regex(@"^https?:\/\/", RegexOptions.CultureInvariant);
            if (false == regexCdrUrl.Match(this.CdrUrl).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CdrUrl, must match a pattern of " + regexCdrUrl, new [] { "CdrUrl" });
            }

            // VoiceUrl (string) pattern
            Regex regexVoiceUrl = new Regex(@"^https?:\/\/", RegexOptions.CultureInvariant);
            if (false == regexVoiceUrl.Match(this.VoiceUrl).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VoiceUrl, must match a pattern of " + regexVoiceUrl, new [] { "VoiceUrl" });
            }

            yield break;
        }
    }

}
