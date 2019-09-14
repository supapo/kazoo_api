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
    /// Schema for services.http_sync system_config
    /// </summary>
    [DataContract]
    public partial class SystemConfigServicesHttpSync :  IEquatable<SystemConfigServicesHttpSync>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemConfigServicesHttpSync" /> class.
        /// </summary>
        /// <param name="authorizationHeader">services http sync authorization header (default to &quot;&quot;).</param>
        /// <param name="connectTimeoutMs">services http sync connect timeout in milliseconds.</param>
        /// <param name="httpUrl">services http sync http url (default to &quot;&quot;).</param>
        public SystemConfigServicesHttpSync(string authorizationHeader = "", int? connectTimeoutMs = default(int?), string httpUrl = "")
        {
            // use default value if no "authorizationHeader" provided
            if (authorizationHeader == null)
            {
                this.AuthorizationHeader = "";
            }
            else
            {
                this.AuthorizationHeader = authorizationHeader;
            }
            this.ConnectTimeoutMs = connectTimeoutMs;
            // use default value if no "httpUrl" provided
            if (httpUrl == null)
            {
                this.HttpUrl = "";
            }
            else
            {
                this.HttpUrl = httpUrl;
            }
        }
        
        /// <summary>
        /// services http sync authorization header
        /// </summary>
        /// <value>services http sync authorization header</value>
        [DataMember(Name="authorization_header", EmitDefaultValue=false)]
        public string AuthorizationHeader { get; set; }

        /// <summary>
        /// services http sync connect timeout in milliseconds
        /// </summary>
        /// <value>services http sync connect timeout in milliseconds</value>
        [DataMember(Name="connect_timeout_ms", EmitDefaultValue=false)]
        public int? ConnectTimeoutMs { get; set; }

        /// <summary>
        /// services http sync http url
        /// </summary>
        /// <value>services http sync http url</value>
        [DataMember(Name="http_url", EmitDefaultValue=false)]
        public string HttpUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SystemConfigServicesHttpSync {\n");
            sb.Append("  AuthorizationHeader: ").Append(AuthorizationHeader).Append("\n");
            sb.Append("  ConnectTimeoutMs: ").Append(ConnectTimeoutMs).Append("\n");
            sb.Append("  HttpUrl: ").Append(HttpUrl).Append("\n");
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
            return this.Equals(input as SystemConfigServicesHttpSync);
        }

        /// <summary>
        /// Returns true if SystemConfigServicesHttpSync instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemConfigServicesHttpSync to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemConfigServicesHttpSync input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AuthorizationHeader == input.AuthorizationHeader ||
                    (this.AuthorizationHeader != null &&
                    this.AuthorizationHeader.Equals(input.AuthorizationHeader))
                ) && 
                (
                    this.ConnectTimeoutMs == input.ConnectTimeoutMs ||
                    (this.ConnectTimeoutMs != null &&
                    this.ConnectTimeoutMs.Equals(input.ConnectTimeoutMs))
                ) && 
                (
                    this.HttpUrl == input.HttpUrl ||
                    (this.HttpUrl != null &&
                    this.HttpUrl.Equals(input.HttpUrl))
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
                if (this.AuthorizationHeader != null)
                    hashCode = hashCode * 59 + this.AuthorizationHeader.GetHashCode();
                if (this.ConnectTimeoutMs != null)
                    hashCode = hashCode * 59 + this.ConnectTimeoutMs.GetHashCode();
                if (this.HttpUrl != null)
                    hashCode = hashCode * 59 + this.HttpUrl.GetHashCode();
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