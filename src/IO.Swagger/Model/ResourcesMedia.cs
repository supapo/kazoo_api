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
    /// The media parameters for the resource gateway
    /// </summary>
    [DataContract]
    public partial class ResourcesMedia :  IEquatable<ResourcesMedia>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourcesMedia" /> class.
        /// </summary>
        /// <param name="faxOption">Is T.38 Supported?.</param>
        /// <param name="rtcpMux">RTCP protocol messages mixed with RTP data.</param>
        public ResourcesMedia(bool? faxOption = default(bool?), bool? rtcpMux = default(bool?))
        {
            this.FaxOption = faxOption;
            this.RtcpMux = rtcpMux;
        }
        
        /// <summary>
        /// Is T.38 Supported?
        /// </summary>
        /// <value>Is T.38 Supported?</value>
        [DataMember(Name="fax_option", EmitDefaultValue=false)]
        public bool? FaxOption { get; set; }

        /// <summary>
        /// RTCP protocol messages mixed with RTP data
        /// </summary>
        /// <value>RTCP protocol messages mixed with RTP data</value>
        [DataMember(Name="rtcp_mux", EmitDefaultValue=false)]
        public bool? RtcpMux { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourcesMedia {\n");
            sb.Append("  FaxOption: ").Append(FaxOption).Append("\n");
            sb.Append("  RtcpMux: ").Append(RtcpMux).Append("\n");
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
            return this.Equals(input as ResourcesMedia);
        }

        /// <summary>
        /// Returns true if ResourcesMedia instances are equal
        /// </summary>
        /// <param name="input">Instance of ResourcesMedia to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResourcesMedia input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FaxOption == input.FaxOption ||
                    (this.FaxOption != null &&
                    this.FaxOption.Equals(input.FaxOption))
                ) && 
                (
                    this.RtcpMux == input.RtcpMux ||
                    (this.RtcpMux != null &&
                    this.RtcpMux.Equals(input.RtcpMux))
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
                if (this.FaxOption != null)
                    hashCode = hashCode * 59 + this.FaxOption.GetHashCode();
                if (this.RtcpMux != null)
                    hashCode = hashCode * 59 + this.RtcpMux.GetHashCode();
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