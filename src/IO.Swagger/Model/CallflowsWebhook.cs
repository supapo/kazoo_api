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
    /// Validator for the webhook callflow data object
    /// </summary>
    [DataContract]
    public partial class CallflowsWebhook :  IEquatable<CallflowsWebhook>, IValidatableObject
    {
        /// <summary>
        /// What HTTP verb to use when sending the request
        /// </summary>
        /// <value>What HTTP verb to use when sending the request</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HttpVerbEnum
        {
            
            /// <summary>
            /// Enum Post for value: post
            /// </summary>
            [EnumMember(Value = "post")]
            Post = 1,
            
            /// <summary>
            /// Enum Get for value: get
            /// </summary>
            [EnumMember(Value = "get")]
            Get = 2
        }

        /// <summary>
        /// What HTTP verb to use when sending the request
        /// </summary>
        /// <value>What HTTP verb to use when sending the request</value>
        [DataMember(Name="http_verb", EmitDefaultValue=false)]
        public HttpVerbEnum? HttpVerb { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CallflowsWebhook" /> class.
        /// </summary>
        /// <param name="customData">JSON object of custom data included on the HTTP request.</param>
        /// <param name="httpVerb">What HTTP verb to use when sending the request.</param>
        /// <param name="retries">How many times to retry the request if the host isn&#39;t available.</param>
        /// <param name="skipModule">When set to true this callflow action is skipped, advancing to the wildcard branch (if any).</param>
        /// <param name="uri">The HTTP URI to send the request.</param>
        public CallflowsWebhook(Object customData = default(Object), HttpVerbEnum? httpVerb = default(HttpVerbEnum?), int? retries = default(int?), bool? skipModule = default(bool?), string uri = default(string))
        {
            this.CustomData = customData;
            this.HttpVerb = httpVerb;
            this.Retries = retries;
            this.SkipModule = skipModule;
            this.Uri = uri;
        }
        
        /// <summary>
        /// JSON object of custom data included on the HTTP request
        /// </summary>
        /// <value>JSON object of custom data included on the HTTP request</value>
        [DataMember(Name="custom_data", EmitDefaultValue=false)]
        public Object CustomData { get; set; }


        /// <summary>
        /// How many times to retry the request if the host isn&#39;t available
        /// </summary>
        /// <value>How many times to retry the request if the host isn&#39;t available</value>
        [DataMember(Name="retries", EmitDefaultValue=false)]
        public int? Retries { get; set; }

        /// <summary>
        /// When set to true this callflow action is skipped, advancing to the wildcard branch (if any)
        /// </summary>
        /// <value>When set to true this callflow action is skipped, advancing to the wildcard branch (if any)</value>
        [DataMember(Name="skip_module", EmitDefaultValue=false)]
        public bool? SkipModule { get; set; }

        /// <summary>
        /// The HTTP URI to send the request
        /// </summary>
        /// <value>The HTTP URI to send the request</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CallflowsWebhook {\n");
            sb.Append("  CustomData: ").Append(CustomData).Append("\n");
            sb.Append("  HttpVerb: ").Append(HttpVerb).Append("\n");
            sb.Append("  Retries: ").Append(Retries).Append("\n");
            sb.Append("  SkipModule: ").Append(SkipModule).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
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
            return this.Equals(input as CallflowsWebhook);
        }

        /// <summary>
        /// Returns true if CallflowsWebhook instances are equal
        /// </summary>
        /// <param name="input">Instance of CallflowsWebhook to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallflowsWebhook input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CustomData == input.CustomData ||
                    (this.CustomData != null &&
                    this.CustomData.Equals(input.CustomData))
                ) && 
                (
                    this.HttpVerb == input.HttpVerb ||
                    (this.HttpVerb != null &&
                    this.HttpVerb.Equals(input.HttpVerb))
                ) && 
                (
                    this.Retries == input.Retries ||
                    (this.Retries != null &&
                    this.Retries.Equals(input.Retries))
                ) && 
                (
                    this.SkipModule == input.SkipModule ||
                    (this.SkipModule != null &&
                    this.SkipModule.Equals(input.SkipModule))
                ) && 
                (
                    this.Uri == input.Uri ||
                    (this.Uri != null &&
                    this.Uri.Equals(input.Uri))
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
                if (this.CustomData != null)
                    hashCode = hashCode * 59 + this.CustomData.GetHashCode();
                if (this.HttpVerb != null)
                    hashCode = hashCode * 59 + this.HttpVerb.GetHashCode();
                if (this.Retries != null)
                    hashCode = hashCode * 59 + this.Retries.GetHashCode();
                if (this.SkipModule != null)
                    hashCode = hashCode * 59 + this.SkipModule.GetHashCode();
                if (this.Uri != null)
                    hashCode = hashCode * 59 + this.Uri.GetHashCode();
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
