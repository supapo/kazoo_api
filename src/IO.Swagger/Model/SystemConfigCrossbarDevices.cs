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
    /// Schema for crossbar.devices system_config
    /// </summary>
    [DataContract]
    public partial class SystemConfigCrossbarDevices :  IEquatable<SystemConfigCrossbarDevices>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemConfigCrossbarDevices" /> class.
        /// </summary>
        /// <param name="allowAggregates">crossbar.devices allow aggregates (default to true).</param>
        /// <param name="provisionerHost">crossbar.devices provisioner host.</param>
        /// <param name="provisionerReferer">crossbar.devices provisioner referer.</param>
        /// <param name="provisioningHost">crossbar.devices provisioning host.</param>
        /// <param name="provisioningReferer">crossbar.devices provisioning referer.</param>
        /// <param name="provisioningType">crossbar.devices provisioning type.</param>
        /// <param name="provisioningUrl">crossbar.devices provisioning url.</param>
        public SystemConfigCrossbarDevices(bool? allowAggregates = true, string provisionerHost = default(string), string provisionerReferer = default(string), string provisioningHost = default(string), string provisioningReferer = default(string), string provisioningType = default(string), string provisioningUrl = default(string))
        {
            // use default value if no "allowAggregates" provided
            if (allowAggregates == null)
            {
                this.AllowAggregates = true;
            }
            else
            {
                this.AllowAggregates = allowAggregates;
            }
            this.ProvisionerHost = provisionerHost;
            this.ProvisionerReferer = provisionerReferer;
            this.ProvisioningHost = provisioningHost;
            this.ProvisioningReferer = provisioningReferer;
            this.ProvisioningType = provisioningType;
            this.ProvisioningUrl = provisioningUrl;
        }
        
        /// <summary>
        /// crossbar.devices allow aggregates
        /// </summary>
        /// <value>crossbar.devices allow aggregates</value>
        [DataMember(Name="allow_aggregates", EmitDefaultValue=false)]
        public bool? AllowAggregates { get; set; }

        /// <summary>
        /// crossbar.devices provisioner host
        /// </summary>
        /// <value>crossbar.devices provisioner host</value>
        [DataMember(Name="provisioner_host", EmitDefaultValue=false)]
        public string ProvisionerHost { get; set; }

        /// <summary>
        /// crossbar.devices provisioner referer
        /// </summary>
        /// <value>crossbar.devices provisioner referer</value>
        [DataMember(Name="provisioner_referer", EmitDefaultValue=false)]
        public string ProvisionerReferer { get; set; }

        /// <summary>
        /// crossbar.devices provisioning host
        /// </summary>
        /// <value>crossbar.devices provisioning host</value>
        [DataMember(Name="provisioning_host", EmitDefaultValue=false)]
        public string ProvisioningHost { get; set; }

        /// <summary>
        /// crossbar.devices provisioning referer
        /// </summary>
        /// <value>crossbar.devices provisioning referer</value>
        [DataMember(Name="provisioning_referer", EmitDefaultValue=false)]
        public string ProvisioningReferer { get; set; }

        /// <summary>
        /// crossbar.devices provisioning type
        /// </summary>
        /// <value>crossbar.devices provisioning type</value>
        [DataMember(Name="provisioning_type", EmitDefaultValue=false)]
        public string ProvisioningType { get; set; }

        /// <summary>
        /// crossbar.devices provisioning url
        /// </summary>
        /// <value>crossbar.devices provisioning url</value>
        [DataMember(Name="provisioning_url", EmitDefaultValue=false)]
        public string ProvisioningUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SystemConfigCrossbarDevices {\n");
            sb.Append("  AllowAggregates: ").Append(AllowAggregates).Append("\n");
            sb.Append("  ProvisionerHost: ").Append(ProvisionerHost).Append("\n");
            sb.Append("  ProvisionerReferer: ").Append(ProvisionerReferer).Append("\n");
            sb.Append("  ProvisioningHost: ").Append(ProvisioningHost).Append("\n");
            sb.Append("  ProvisioningReferer: ").Append(ProvisioningReferer).Append("\n");
            sb.Append("  ProvisioningType: ").Append(ProvisioningType).Append("\n");
            sb.Append("  ProvisioningUrl: ").Append(ProvisioningUrl).Append("\n");
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
            return this.Equals(input as SystemConfigCrossbarDevices);
        }

        /// <summary>
        /// Returns true if SystemConfigCrossbarDevices instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemConfigCrossbarDevices to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemConfigCrossbarDevices input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllowAggregates == input.AllowAggregates ||
                    (this.AllowAggregates != null &&
                    this.AllowAggregates.Equals(input.AllowAggregates))
                ) && 
                (
                    this.ProvisionerHost == input.ProvisionerHost ||
                    (this.ProvisionerHost != null &&
                    this.ProvisionerHost.Equals(input.ProvisionerHost))
                ) && 
                (
                    this.ProvisionerReferer == input.ProvisionerReferer ||
                    (this.ProvisionerReferer != null &&
                    this.ProvisionerReferer.Equals(input.ProvisionerReferer))
                ) && 
                (
                    this.ProvisioningHost == input.ProvisioningHost ||
                    (this.ProvisioningHost != null &&
                    this.ProvisioningHost.Equals(input.ProvisioningHost))
                ) && 
                (
                    this.ProvisioningReferer == input.ProvisioningReferer ||
                    (this.ProvisioningReferer != null &&
                    this.ProvisioningReferer.Equals(input.ProvisioningReferer))
                ) && 
                (
                    this.ProvisioningType == input.ProvisioningType ||
                    (this.ProvisioningType != null &&
                    this.ProvisioningType.Equals(input.ProvisioningType))
                ) && 
                (
                    this.ProvisioningUrl == input.ProvisioningUrl ||
                    (this.ProvisioningUrl != null &&
                    this.ProvisioningUrl.Equals(input.ProvisioningUrl))
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
                if (this.AllowAggregates != null)
                    hashCode = hashCode * 59 + this.AllowAggregates.GetHashCode();
                if (this.ProvisionerHost != null)
                    hashCode = hashCode * 59 + this.ProvisionerHost.GetHashCode();
                if (this.ProvisionerReferer != null)
                    hashCode = hashCode * 59 + this.ProvisionerReferer.GetHashCode();
                if (this.ProvisioningHost != null)
                    hashCode = hashCode * 59 + this.ProvisioningHost.GetHashCode();
                if (this.ProvisioningReferer != null)
                    hashCode = hashCode * 59 + this.ProvisioningReferer.GetHashCode();
                if (this.ProvisioningType != null)
                    hashCode = hashCode * 59 + this.ProvisioningType.GetHashCode();
                if (this.ProvisioningUrl != null)
                    hashCode = hashCode * 59 + this.ProvisioningUrl.GetHashCode();
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