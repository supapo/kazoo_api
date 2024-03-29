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
    /// Schema for resources
    /// </summary>
    [DataContract]
    public partial class Resources :  IEquatable<Resources>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Resources" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Resources() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Resources" /> class.
        /// </summary>
        /// <param name="emergency">Determines if the resource represents emergency services (default to false).</param>
        /// <param name="enabled">Determines if the resource is currently enabled (default to true).</param>
        /// <param name="flags">A list of flags that can be provided on the request and must match for the resource to be eligible.</param>
        /// <param name="flatRateBlacklist">Regex for determining if a number should not be eligible for flat-rate trunking.</param>
        /// <param name="flatRateWhitelist">Regex for determining if the number is eligible for flat-rate trunking.</param>
        /// <param name="formatFromUri">When set to true requests to this resource will have a reformatted SIP From Header.</param>
        /// <param name="formatters">formatters.</param>
        /// <param name="fromUriRealm">When formatting SIP From on outbound requests this can be used to override the realm.</param>
        /// <param name="gateways">A list of gateways available for this resource (required).</param>
        /// <param name="gracePeriod">The amount of time, in seconds, to wait before starting another resource.</param>
        /// <param name="ignoreFlags">When set to true this resource is used if the rules/classifiers match regardless of flags.</param>
        /// <param name="media">Media options for resources.</param>
        /// <param name="name">A friendly name for the resource (required).</param>
        /// <param name="requireFlags">When set to true this resource is ignored if the request does not specify outbound flags.</param>
        /// <param name="rules">A list of regular expressions of which one must match for the rule to be eligible, they can optionally contain capture groups.</param>
        /// <param name="weightCost">A value between 0 and 100 that determines the order of resources when multiple can be used.</param>
        public Resources(bool? emergency = false, bool? enabled = true, List<string> flags = default(List<string>), string flatRateBlacklist = default(string), string flatRateWhitelist = default(string), bool? formatFromUri = default(bool?), Formatters formatters = default(Formatters), string fromUriRealm = default(string), List<ResourcesGateways> gateways = default(List<ResourcesGateways>), int? gracePeriod = default(int?), bool? ignoreFlags = default(bool?), EndpointMedia media = default(EndpointMedia), string name = default(string), bool? requireFlags = default(bool?), List<string> rules = default(List<string>), int? weightCost = default(int?))
        {
            // to ensure "gateways" is required (not null)
            if (gateways == null)
            {
                throw new InvalidDataException("gateways is a required property for Resources and cannot be null");
            }
            else
            {
                this.Gateways = gateways;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Resources and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // use default value if no "emergency" provided
            if (emergency == null)
            {
                this.Emergency = false;
            }
            else
            {
                this.Emergency = emergency;
            }
            // use default value if no "enabled" provided
            if (enabled == null)
            {
                this.Enabled = true;
            }
            else
            {
                this.Enabled = enabled;
            }
            this.Flags = flags;
            this.FlatRateBlacklist = flatRateBlacklist;
            this.FlatRateWhitelist = flatRateWhitelist;
            this.FormatFromUri = formatFromUri;
            this.Formatters = formatters;
            this.FromUriRealm = fromUriRealm;
            this.GracePeriod = gracePeriod;
            this.IgnoreFlags = ignoreFlags;
            this.Media = media;
            this.RequireFlags = requireFlags;
            this.Rules = rules;
            this.WeightCost = weightCost;
        }
        
        /// <summary>
        /// Determines if the resource represents emergency services
        /// </summary>
        /// <value>Determines if the resource represents emergency services</value>
        [DataMember(Name="emergency", EmitDefaultValue=false)]
        public bool? Emergency { get; set; }

        /// <summary>
        /// Determines if the resource is currently enabled
        /// </summary>
        /// <value>Determines if the resource is currently enabled</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// A list of flags that can be provided on the request and must match for the resource to be eligible
        /// </summary>
        /// <value>A list of flags that can be provided on the request and must match for the resource to be eligible</value>
        [DataMember(Name="flags", EmitDefaultValue=false)]
        public List<string> Flags { get; set; }

        /// <summary>
        /// Regex for determining if a number should not be eligible for flat-rate trunking
        /// </summary>
        /// <value>Regex for determining if a number should not be eligible for flat-rate trunking</value>
        [DataMember(Name="flat_rate_blacklist", EmitDefaultValue=false)]
        public string FlatRateBlacklist { get; set; }

        /// <summary>
        /// Regex for determining if the number is eligible for flat-rate trunking
        /// </summary>
        /// <value>Regex for determining if the number is eligible for flat-rate trunking</value>
        [DataMember(Name="flat_rate_whitelist", EmitDefaultValue=false)]
        public string FlatRateWhitelist { get; set; }

        /// <summary>
        /// When set to true requests to this resource will have a reformatted SIP From Header
        /// </summary>
        /// <value>When set to true requests to this resource will have a reformatted SIP From Header</value>
        [DataMember(Name="format_from_uri", EmitDefaultValue=false)]
        public bool? FormatFromUri { get; set; }

        /// <summary>
        /// Gets or Sets Formatters
        /// </summary>
        [DataMember(Name="formatters", EmitDefaultValue=false)]
        public Formatters Formatters { get; set; }

        /// <summary>
        /// When formatting SIP From on outbound requests this can be used to override the realm
        /// </summary>
        /// <value>When formatting SIP From on outbound requests this can be used to override the realm</value>
        [DataMember(Name="from_uri_realm", EmitDefaultValue=false)]
        public string FromUriRealm { get; set; }

        /// <summary>
        /// A list of gateways available for this resource
        /// </summary>
        /// <value>A list of gateways available for this resource</value>
        [DataMember(Name="gateways", EmitDefaultValue=false)]
        public List<ResourcesGateways> Gateways { get; set; }

        /// <summary>
        /// The amount of time, in seconds, to wait before starting another resource
        /// </summary>
        /// <value>The amount of time, in seconds, to wait before starting another resource</value>
        [DataMember(Name="grace_period", EmitDefaultValue=false)]
        public int? GracePeriod { get; set; }

        /// <summary>
        /// When set to true this resource is used if the rules/classifiers match regardless of flags
        /// </summary>
        /// <value>When set to true this resource is used if the rules/classifiers match regardless of flags</value>
        [DataMember(Name="ignore_flags", EmitDefaultValue=false)]
        public bool? IgnoreFlags { get; set; }

        /// <summary>
        /// Media options for resources
        /// </summary>
        /// <value>Media options for resources</value>
        [DataMember(Name="media", EmitDefaultValue=false)]
        public EndpointMedia Media { get; set; }

        /// <summary>
        /// A friendly name for the resource
        /// </summary>
        /// <value>A friendly name for the resource</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// When set to true this resource is ignored if the request does not specify outbound flags
        /// </summary>
        /// <value>When set to true this resource is ignored if the request does not specify outbound flags</value>
        [DataMember(Name="require_flags", EmitDefaultValue=false)]
        public bool? RequireFlags { get; set; }

        /// <summary>
        /// A list of regular expressions of which one must match for the rule to be eligible, they can optionally contain capture groups
        /// </summary>
        /// <value>A list of regular expressions of which one must match for the rule to be eligible, they can optionally contain capture groups</value>
        [DataMember(Name="rules", EmitDefaultValue=false)]
        public List<string> Rules { get; set; }

        /// <summary>
        /// A value between 0 and 100 that determines the order of resources when multiple can be used
        /// </summary>
        /// <value>A value between 0 and 100 that determines the order of resources when multiple can be used</value>
        [DataMember(Name="weight_cost", EmitDefaultValue=false)]
        public int? WeightCost { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Resources {\n");
            sb.Append("  Emergency: ").Append(Emergency).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Flags: ").Append(Flags).Append("\n");
            sb.Append("  FlatRateBlacklist: ").Append(FlatRateBlacklist).Append("\n");
            sb.Append("  FlatRateWhitelist: ").Append(FlatRateWhitelist).Append("\n");
            sb.Append("  FormatFromUri: ").Append(FormatFromUri).Append("\n");
            sb.Append("  Formatters: ").Append(Formatters).Append("\n");
            sb.Append("  FromUriRealm: ").Append(FromUriRealm).Append("\n");
            sb.Append("  Gateways: ").Append(Gateways).Append("\n");
            sb.Append("  GracePeriod: ").Append(GracePeriod).Append("\n");
            sb.Append("  IgnoreFlags: ").Append(IgnoreFlags).Append("\n");
            sb.Append("  Media: ").Append(Media).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RequireFlags: ").Append(RequireFlags).Append("\n");
            sb.Append("  Rules: ").Append(Rules).Append("\n");
            sb.Append("  WeightCost: ").Append(WeightCost).Append("\n");
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
            return this.Equals(input as Resources);
        }

        /// <summary>
        /// Returns true if Resources instances are equal
        /// </summary>
        /// <param name="input">Instance of Resources to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Resources input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Emergency == input.Emergency ||
                    (this.Emergency != null &&
                    this.Emergency.Equals(input.Emergency))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.Flags == input.Flags ||
                    this.Flags != null &&
                    this.Flags.SequenceEqual(input.Flags)
                ) && 
                (
                    this.FlatRateBlacklist == input.FlatRateBlacklist ||
                    (this.FlatRateBlacklist != null &&
                    this.FlatRateBlacklist.Equals(input.FlatRateBlacklist))
                ) && 
                (
                    this.FlatRateWhitelist == input.FlatRateWhitelist ||
                    (this.FlatRateWhitelist != null &&
                    this.FlatRateWhitelist.Equals(input.FlatRateWhitelist))
                ) && 
                (
                    this.FormatFromUri == input.FormatFromUri ||
                    (this.FormatFromUri != null &&
                    this.FormatFromUri.Equals(input.FormatFromUri))
                ) && 
                (
                    this.Formatters == input.Formatters ||
                    (this.Formatters != null &&
                    this.Formatters.Equals(input.Formatters))
                ) && 
                (
                    this.FromUriRealm == input.FromUriRealm ||
                    (this.FromUriRealm != null &&
                    this.FromUriRealm.Equals(input.FromUriRealm))
                ) && 
                (
                    this.Gateways == input.Gateways ||
                    this.Gateways != null &&
                    this.Gateways.SequenceEqual(input.Gateways)
                ) && 
                (
                    this.GracePeriod == input.GracePeriod ||
                    (this.GracePeriod != null &&
                    this.GracePeriod.Equals(input.GracePeriod))
                ) && 
                (
                    this.IgnoreFlags == input.IgnoreFlags ||
                    (this.IgnoreFlags != null &&
                    this.IgnoreFlags.Equals(input.IgnoreFlags))
                ) && 
                (
                    this.Media == input.Media ||
                    (this.Media != null &&
                    this.Media.Equals(input.Media))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.RequireFlags == input.RequireFlags ||
                    (this.RequireFlags != null &&
                    this.RequireFlags.Equals(input.RequireFlags))
                ) && 
                (
                    this.Rules == input.Rules ||
                    this.Rules != null &&
                    this.Rules.SequenceEqual(input.Rules)
                ) && 
                (
                    this.WeightCost == input.WeightCost ||
                    (this.WeightCost != null &&
                    this.WeightCost.Equals(input.WeightCost))
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
                if (this.Emergency != null)
                    hashCode = hashCode * 59 + this.Emergency.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.Flags != null)
                    hashCode = hashCode * 59 + this.Flags.GetHashCode();
                if (this.FlatRateBlacklist != null)
                    hashCode = hashCode * 59 + this.FlatRateBlacklist.GetHashCode();
                if (this.FlatRateWhitelist != null)
                    hashCode = hashCode * 59 + this.FlatRateWhitelist.GetHashCode();
                if (this.FormatFromUri != null)
                    hashCode = hashCode * 59 + this.FormatFromUri.GetHashCode();
                if (this.Formatters != null)
                    hashCode = hashCode * 59 + this.Formatters.GetHashCode();
                if (this.FromUriRealm != null)
                    hashCode = hashCode * 59 + this.FromUriRealm.GetHashCode();
                if (this.Gateways != null)
                    hashCode = hashCode * 59 + this.Gateways.GetHashCode();
                if (this.GracePeriod != null)
                    hashCode = hashCode * 59 + this.GracePeriod.GetHashCode();
                if (this.IgnoreFlags != null)
                    hashCode = hashCode * 59 + this.IgnoreFlags.GetHashCode();
                if (this.Media != null)
                    hashCode = hashCode * 59 + this.Media.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.RequireFlags != null)
                    hashCode = hashCode * 59 + this.RequireFlags.GetHashCode();
                if (this.Rules != null)
                    hashCode = hashCode * 59 + this.Rules.GetHashCode();
                if (this.WeightCost != null)
                    hashCode = hashCode * 59 + this.WeightCost.GetHashCode();
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
            // GracePeriod (int?) maximum
            if(this.GracePeriod > (int?)20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GracePeriod, must be a value less than or equal to 20.", new [] { "GracePeriod" });
            }

            // GracePeriod (int?) minimum
            if(this.GracePeriod < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GracePeriod, must be a value greater than or equal to 1.", new [] { "GracePeriod" });
            }

            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 128)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 128.", new [] { "Name" });
            }

            // Name (string) minLength
            if(this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            // WeightCost (int?) maximum
            if(this.WeightCost > (int?)100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WeightCost, must be a value less than or equal to 100.", new [] { "WeightCost" });
            }

            // WeightCost (int?) minimum
            if(this.WeightCost < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WeightCost, must be a value greater than or equal to 0.", new [] { "WeightCost" });
            }

            yield break;
        }
    }

}
