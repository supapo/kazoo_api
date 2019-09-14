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
    /// Schema for token_buckets system_config
    /// </summary>
    [DataContract]
    public partial class SystemConfigTokenBuckets :  IEquatable<SystemConfigTokenBuckets>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemConfigTokenBuckets" /> class.
        /// </summary>
        /// <param name="_default">_default.</param>
        /// <param name="inactivityTimeoutS">token_buckets inactivity timeout in seconds.</param>
        /// <param name="tokensFillRate">token_buckets tokens fill rate.</param>
        /// <param name="tokensFillTime">token_buckets tokens fill time (default to &quot;second&quot;).</param>
        public SystemConfigTokenBuckets(SystemConfigTokenBucketsDefault _default = default(SystemConfigTokenBucketsDefault), int? inactivityTimeoutS = default(int?), int? tokensFillRate = default(int?), string tokensFillTime = "second")
        {
            this.Default = _default;
            this.InactivityTimeoutS = inactivityTimeoutS;
            this.TokensFillRate = tokensFillRate;
            // use default value if no "tokensFillTime" provided
            if (tokensFillTime == null)
            {
                this.TokensFillTime = "second";
            }
            else
            {
                this.TokensFillTime = tokensFillTime;
            }
        }
        
        /// <summary>
        /// Gets or Sets Default
        /// </summary>
        [DataMember(Name="default", EmitDefaultValue=false)]
        public SystemConfigTokenBucketsDefault Default { get; set; }

        /// <summary>
        /// token_buckets inactivity timeout in seconds
        /// </summary>
        /// <value>token_buckets inactivity timeout in seconds</value>
        [DataMember(Name="inactivity_timeout_s", EmitDefaultValue=false)]
        public int? InactivityTimeoutS { get; set; }

        /// <summary>
        /// token_buckets tokens fill rate
        /// </summary>
        /// <value>token_buckets tokens fill rate</value>
        [DataMember(Name="tokens_fill_rate", EmitDefaultValue=false)]
        public int? TokensFillRate { get; set; }

        /// <summary>
        /// token_buckets tokens fill time
        /// </summary>
        /// <value>token_buckets tokens fill time</value>
        [DataMember(Name="tokens_fill_time", EmitDefaultValue=false)]
        public string TokensFillTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SystemConfigTokenBuckets {\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
            sb.Append("  InactivityTimeoutS: ").Append(InactivityTimeoutS).Append("\n");
            sb.Append("  TokensFillRate: ").Append(TokensFillRate).Append("\n");
            sb.Append("  TokensFillTime: ").Append(TokensFillTime).Append("\n");
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
            return this.Equals(input as SystemConfigTokenBuckets);
        }

        /// <summary>
        /// Returns true if SystemConfigTokenBuckets instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemConfigTokenBuckets to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemConfigTokenBuckets input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Default == input.Default ||
                    (this.Default != null &&
                    this.Default.Equals(input.Default))
                ) && 
                (
                    this.InactivityTimeoutS == input.InactivityTimeoutS ||
                    (this.InactivityTimeoutS != null &&
                    this.InactivityTimeoutS.Equals(input.InactivityTimeoutS))
                ) && 
                (
                    this.TokensFillRate == input.TokensFillRate ||
                    (this.TokensFillRate != null &&
                    this.TokensFillRate.Equals(input.TokensFillRate))
                ) && 
                (
                    this.TokensFillTime == input.TokensFillTime ||
                    (this.TokensFillTime != null &&
                    this.TokensFillTime.Equals(input.TokensFillTime))
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
                if (this.Default != null)
                    hashCode = hashCode * 59 + this.Default.GetHashCode();
                if (this.InactivityTimeoutS != null)
                    hashCode = hashCode * 59 + this.InactivityTimeoutS.GetHashCode();
                if (this.TokensFillRate != null)
                    hashCode = hashCode * 59 + this.TokensFillRate.GetHashCode();
                if (this.TokensFillTime != null)
                    hashCode = hashCode * 59 + this.TokensFillTime.GetHashCode();
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
