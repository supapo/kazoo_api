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
    /// The limits to apply by a second
    /// </summary>
    [DataContract]
    public partial class DeviceRateLimitsPerSecond :  IEquatable<DeviceRateLimitsPerSecond>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceRateLimitsPerSecond" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeviceRateLimitsPerSecond() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceRateLimitsPerSecond" /> class.
        /// </summary>
        /// <param name="invites">Count for the specified SIP method.</param>
        /// <param name="registrations">Count for the specified SIP method.</param>
        /// <param name="totalPackets">Summary count for all of the SIP methods (required).</param>
        public DeviceRateLimitsPerSecond(int? invites = default(int?), int? registrations = default(int?), int? totalPackets = default(int?))
        {
            // to ensure "totalPackets" is required (not null)
            if (totalPackets == null)
            {
                throw new InvalidDataException("totalPackets is a required property for DeviceRateLimitsPerSecond and cannot be null");
            }
            else
            {
                this.TotalPackets = totalPackets;
            }
            this.Invites = invites;
            this.Registrations = registrations;
        }
        
        /// <summary>
        /// Count for the specified SIP method
        /// </summary>
        /// <value>Count for the specified SIP method</value>
        [DataMember(Name="invites", EmitDefaultValue=false)]
        public int? Invites { get; set; }

        /// <summary>
        /// Count for the specified SIP method
        /// </summary>
        /// <value>Count for the specified SIP method</value>
        [DataMember(Name="registrations", EmitDefaultValue=false)]
        public int? Registrations { get; set; }

        /// <summary>
        /// Summary count for all of the SIP methods
        /// </summary>
        /// <value>Summary count for all of the SIP methods</value>
        [DataMember(Name="total_packets", EmitDefaultValue=false)]
        public int? TotalPackets { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeviceRateLimitsPerSecond {\n");
            sb.Append("  Invites: ").Append(Invites).Append("\n");
            sb.Append("  Registrations: ").Append(Registrations).Append("\n");
            sb.Append("  TotalPackets: ").Append(TotalPackets).Append("\n");
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
            return this.Equals(input as DeviceRateLimitsPerSecond);
        }

        /// <summary>
        /// Returns true if DeviceRateLimitsPerSecond instances are equal
        /// </summary>
        /// <param name="input">Instance of DeviceRateLimitsPerSecond to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceRateLimitsPerSecond input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Invites == input.Invites ||
                    (this.Invites != null &&
                    this.Invites.Equals(input.Invites))
                ) && 
                (
                    this.Registrations == input.Registrations ||
                    (this.Registrations != null &&
                    this.Registrations.Equals(input.Registrations))
                ) && 
                (
                    this.TotalPackets == input.TotalPackets ||
                    (this.TotalPackets != null &&
                    this.TotalPackets.Equals(input.TotalPackets))
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
                if (this.Invites != null)
                    hashCode = hashCode * 59 + this.Invites.GetHashCode();
                if (this.Registrations != null)
                    hashCode = hashCode * 59 + this.Registrations.GetHashCode();
                if (this.TotalPackets != null)
                    hashCode = hashCode * 59 + this.TotalPackets.GetHashCode();
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
