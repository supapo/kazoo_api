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
    /// pusher apple
    /// </summary>
    [DataContract]
    public partial class SystemConfigPusherApple :  IEquatable<SystemConfigPusherApple>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemConfigPusherApple" /> class.
        /// </summary>
        /// <param name="apnsTopic">APNs topic for push notifications payload.</param>
        /// <param name="certificate">PEM-encoded key and certificate.</param>
        /// <param name="headers">pusher apple headers.</param>
        /// <param name="host">APNs server host (default to &quot;api.push.apple.com&quot;).</param>
        public SystemConfigPusherApple(string apnsTopic = default(string), string certificate = default(string), Object headers = default(Object), string host = "api.push.apple.com")
        {
            this.ApnsTopic = apnsTopic;
            this.Certificate = certificate;
            this.Headers = headers;
            // use default value if no "host" provided
            if (host == null)
            {
                this.Host = "api.push.apple.com";
            }
            else
            {
                this.Host = host;
            }
        }
        
        /// <summary>
        /// APNs topic for push notifications payload
        /// </summary>
        /// <value>APNs topic for push notifications payload</value>
        [DataMember(Name="apns_topic", EmitDefaultValue=false)]
        public string ApnsTopic { get; set; }

        /// <summary>
        /// PEM-encoded key and certificate
        /// </summary>
        /// <value>PEM-encoded key and certificate</value>
        [DataMember(Name="certificate", EmitDefaultValue=false)]
        public string Certificate { get; set; }

        /// <summary>
        /// pusher apple headers
        /// </summary>
        /// <value>pusher apple headers</value>
        [DataMember(Name="headers", EmitDefaultValue=false)]
        public Object Headers { get; set; }

        /// <summary>
        /// APNs server host
        /// </summary>
        /// <value>APNs server host</value>
        [DataMember(Name="host", EmitDefaultValue=false)]
        public string Host { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SystemConfigPusherApple {\n");
            sb.Append("  ApnsTopic: ").Append(ApnsTopic).Append("\n");
            sb.Append("  Certificate: ").Append(Certificate).Append("\n");
            sb.Append("  Headers: ").Append(Headers).Append("\n");
            sb.Append("  Host: ").Append(Host).Append("\n");
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
            return this.Equals(input as SystemConfigPusherApple);
        }

        /// <summary>
        /// Returns true if SystemConfigPusherApple instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemConfigPusherApple to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemConfigPusherApple input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApnsTopic == input.ApnsTopic ||
                    (this.ApnsTopic != null &&
                    this.ApnsTopic.Equals(input.ApnsTopic))
                ) && 
                (
                    this.Certificate == input.Certificate ||
                    (this.Certificate != null &&
                    this.Certificate.Equals(input.Certificate))
                ) && 
                (
                    this.Headers == input.Headers ||
                    (this.Headers != null &&
                    this.Headers.Equals(input.Headers))
                ) && 
                (
                    this.Host == input.Host ||
                    (this.Host != null &&
                    this.Host.Equals(input.Host))
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
                if (this.ApnsTopic != null)
                    hashCode = hashCode * 59 + this.ApnsTopic.GetHashCode();
                if (this.Certificate != null)
                    hashCode = hashCode * 59 + this.Certificate.GetHashCode();
                if (this.Headers != null)
                    hashCode = hashCode * 59 + this.Headers.GetHashCode();
                if (this.Host != null)
                    hashCode = hashCode * 59 + this.Host.GetHashCode();
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
