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
    /// Defines a rate for a given prefix
    /// </summary>
    [DataContract]
    public partial class Rates :  IEquatable<Rates>, IValidatableObject
    {
        /// <summary>
        /// Defines Direction
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DirectionEnum
        {
            
            /// <summary>
            /// Enum Inbound for value: inbound
            /// </summary>
            [EnumMember(Value = "inbound")]
            Inbound = 1,
            
            /// <summary>
            /// Enum Outbound for value: outbound
            /// </summary>
            [EnumMember(Value = "outbound")]
            Outbound = 2
        }


        /// <summary>
        /// Apply this rate based on the direction of the call (relative to FreeSWITCH)
        /// </summary>
        /// <value>Apply this rate based on the direction of the call (relative to FreeSWITCH)</value>
        [DataMember(Name="direction", EmitDefaultValue=false)]
        public List<DirectionEnum> Direction { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Rates" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Rates() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Rates" /> class.
        /// </summary>
        /// <param name="accountId">Reseller&#39;s account ID.</param>
        /// <param name="callerIdNumbers">String of caller id prefixes separated by &#39;:&#39;.</param>
        /// <param name="carrier">Friendly name for the carrier providing this rate.</param>
        /// <param name="description">Friendly description of the rate.</param>
        /// <param name="direction">Apply this rate based on the direction of the call (relative to FreeSWITCH).</param>
        /// <param name="internalRateCost">The per-min rate charged by the upstream provider.</param>
        /// <param name="isoCountryCode">Country code this rate applies to.</param>
        /// <param name="options">List of options this rate is good for, to be matched against a customer&#39;s options.</param>
        /// <param name="prefix">E.164 prefix (ignoring the +) (required).</param>
        /// <param name="rateCost">The per-min rate charged to the downstream customer (required).</param>
        /// <param name="rateIncrement">The time slice, in seconds, to bill in..</param>
        /// <param name="rateMinimum">The minimum time slice, in seconds to bill a call.</param>
        /// <param name="rateName">Friendly name of the rate.</param>
        /// <param name="rateNochargeTime">If the call duration is shorter than this threshold (seconds), the call is not billed.</param>
        /// <param name="rateSuffix">Suffix applied to rate name.</param>
        /// <param name="rateSurcharge">The upfront cost of connecting the call.</param>
        /// <param name="rateVersion">Rate version.</param>
        /// <param name="ratedeckId">ID of the ratedeck this rate belongs to.</param>
        /// <param name="routes">List of regexps that match valid DIDs for this rate.</param>
        /// <param name="weight">Ordering against other rates, 1 being most preferred, 100 being least preferred.</param>
        public Rates(string accountId = default(string), string callerIdNumbers = default(string), string carrier = default(string), string description = default(string), List<DirectionEnum> direction = default(List<DirectionEnum>), decimal? internalRateCost = default(decimal?), string isoCountryCode = default(string), List<string> options = default(List<string>), int? prefix = default(int?), decimal? rateCost = default(decimal?), int? rateIncrement = default(int?), int? rateMinimum = default(int?), string rateName = default(string), int? rateNochargeTime = default(int?), string rateSuffix = default(string), decimal? rateSurcharge = default(decimal?), string rateVersion = default(string), string ratedeckId = default(string), List<string> routes = default(List<string>), int? weight = default(int?))
        {
            // to ensure "prefix" is required (not null)
            if (prefix == null)
            {
                throw new InvalidDataException("prefix is a required property for Rates and cannot be null");
            }
            else
            {
                this.Prefix = prefix;
            }
            // to ensure "rateCost" is required (not null)
            if (rateCost == null)
            {
                throw new InvalidDataException("rateCost is a required property for Rates and cannot be null");
            }
            else
            {
                this.RateCost = rateCost;
            }
            this.AccountId = accountId;
            this.CallerIdNumbers = callerIdNumbers;
            this.Carrier = carrier;
            this.Description = description;
            this.Direction = direction;
            this.InternalRateCost = internalRateCost;
            this.IsoCountryCode = isoCountryCode;
            this.Options = options;
            this.RateIncrement = rateIncrement;
            this.RateMinimum = rateMinimum;
            this.RateName = rateName;
            this.RateNochargeTime = rateNochargeTime;
            this.RateSuffix = rateSuffix;
            this.RateSurcharge = rateSurcharge;
            this.RateVersion = rateVersion;
            this.RatedeckId = ratedeckId;
            this.Routes = routes;
            this.Weight = weight;
        }
        
        /// <summary>
        /// Reseller&#39;s account ID
        /// </summary>
        /// <value>Reseller&#39;s account ID</value>
        [DataMember(Name="account_id", EmitDefaultValue=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// String of caller id prefixes separated by &#39;:&#39;
        /// </summary>
        /// <value>String of caller id prefixes separated by &#39;:&#39;</value>
        [DataMember(Name="caller_id_numbers", EmitDefaultValue=false)]
        public string CallerIdNumbers { get; set; }

        /// <summary>
        /// Friendly name for the carrier providing this rate
        /// </summary>
        /// <value>Friendly name for the carrier providing this rate</value>
        [DataMember(Name="carrier", EmitDefaultValue=false)]
        public string Carrier { get; set; }

        /// <summary>
        /// Friendly description of the rate
        /// </summary>
        /// <value>Friendly description of the rate</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }


        /// <summary>
        /// The per-min rate charged by the upstream provider
        /// </summary>
        /// <value>The per-min rate charged by the upstream provider</value>
        [DataMember(Name="internal_rate_cost", EmitDefaultValue=false)]
        public decimal? InternalRateCost { get; set; }

        /// <summary>
        /// Country code this rate applies to
        /// </summary>
        /// <value>Country code this rate applies to</value>
        [DataMember(Name="iso_country_code", EmitDefaultValue=false)]
        public string IsoCountryCode { get; set; }

        /// <summary>
        /// List of options this rate is good for, to be matched against a customer&#39;s options
        /// </summary>
        /// <value>List of options this rate is good for, to be matched against a customer&#39;s options</value>
        [DataMember(Name="options", EmitDefaultValue=false)]
        public List<string> Options { get; set; }

        /// <summary>
        /// E.164 prefix (ignoring the +)
        /// </summary>
        /// <value>E.164 prefix (ignoring the +)</value>
        [DataMember(Name="prefix", EmitDefaultValue=false)]
        public int? Prefix { get; set; }

        /// <summary>
        /// The per-min rate charged to the downstream customer
        /// </summary>
        /// <value>The per-min rate charged to the downstream customer</value>
        [DataMember(Name="rate_cost", EmitDefaultValue=false)]
        public decimal? RateCost { get; set; }

        /// <summary>
        /// The time slice, in seconds, to bill in.
        /// </summary>
        /// <value>The time slice, in seconds, to bill in.</value>
        [DataMember(Name="rate_increment", EmitDefaultValue=false)]
        public int? RateIncrement { get; set; }

        /// <summary>
        /// The minimum time slice, in seconds to bill a call
        /// </summary>
        /// <value>The minimum time slice, in seconds to bill a call</value>
        [DataMember(Name="rate_minimum", EmitDefaultValue=false)]
        public int? RateMinimum { get; set; }

        /// <summary>
        /// Friendly name of the rate
        /// </summary>
        /// <value>Friendly name of the rate</value>
        [DataMember(Name="rate_name", EmitDefaultValue=false)]
        public string RateName { get; set; }

        /// <summary>
        /// If the call duration is shorter than this threshold (seconds), the call is not billed
        /// </summary>
        /// <value>If the call duration is shorter than this threshold (seconds), the call is not billed</value>
        [DataMember(Name="rate_nocharge_time", EmitDefaultValue=false)]
        public int? RateNochargeTime { get; set; }

        /// <summary>
        /// Suffix applied to rate name
        /// </summary>
        /// <value>Suffix applied to rate name</value>
        [DataMember(Name="rate_suffix", EmitDefaultValue=false)]
        public string RateSuffix { get; set; }

        /// <summary>
        /// The upfront cost of connecting the call
        /// </summary>
        /// <value>The upfront cost of connecting the call</value>
        [DataMember(Name="rate_surcharge", EmitDefaultValue=false)]
        public decimal? RateSurcharge { get; set; }

        /// <summary>
        /// Rate version
        /// </summary>
        /// <value>Rate version</value>
        [DataMember(Name="rate_version", EmitDefaultValue=false)]
        public string RateVersion { get; set; }

        /// <summary>
        /// ID of the ratedeck this rate belongs to
        /// </summary>
        /// <value>ID of the ratedeck this rate belongs to</value>
        [DataMember(Name="ratedeck_id", EmitDefaultValue=false)]
        public string RatedeckId { get; set; }

        /// <summary>
        /// List of regexps that match valid DIDs for this rate
        /// </summary>
        /// <value>List of regexps that match valid DIDs for this rate</value>
        [DataMember(Name="routes", EmitDefaultValue=false)]
        public List<string> Routes { get; set; }

        /// <summary>
        /// Ordering against other rates, 1 being most preferred, 100 being least preferred
        /// </summary>
        /// <value>Ordering against other rates, 1 being most preferred, 100 being least preferred</value>
        [DataMember(Name="weight", EmitDefaultValue=false)]
        public int? Weight { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Rates {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  CallerIdNumbers: ").Append(CallerIdNumbers).Append("\n");
            sb.Append("  Carrier: ").Append(Carrier).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  InternalRateCost: ").Append(InternalRateCost).Append("\n");
            sb.Append("  IsoCountryCode: ").Append(IsoCountryCode).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  Prefix: ").Append(Prefix).Append("\n");
            sb.Append("  RateCost: ").Append(RateCost).Append("\n");
            sb.Append("  RateIncrement: ").Append(RateIncrement).Append("\n");
            sb.Append("  RateMinimum: ").Append(RateMinimum).Append("\n");
            sb.Append("  RateName: ").Append(RateName).Append("\n");
            sb.Append("  RateNochargeTime: ").Append(RateNochargeTime).Append("\n");
            sb.Append("  RateSuffix: ").Append(RateSuffix).Append("\n");
            sb.Append("  RateSurcharge: ").Append(RateSurcharge).Append("\n");
            sb.Append("  RateVersion: ").Append(RateVersion).Append("\n");
            sb.Append("  RatedeckId: ").Append(RatedeckId).Append("\n");
            sb.Append("  Routes: ").Append(Routes).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
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
            return this.Equals(input as Rates);
        }

        /// <summary>
        /// Returns true if Rates instances are equal
        /// </summary>
        /// <param name="input">Instance of Rates to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Rates input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.CallerIdNumbers == input.CallerIdNumbers ||
                    (this.CallerIdNumbers != null &&
                    this.CallerIdNumbers.Equals(input.CallerIdNumbers))
                ) && 
                (
                    this.Carrier == input.Carrier ||
                    (this.Carrier != null &&
                    this.Carrier.Equals(input.Carrier))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Direction == input.Direction ||
                    this.Direction != null &&
                    this.Direction.SequenceEqual(input.Direction)
                ) && 
                (
                    this.InternalRateCost == input.InternalRateCost ||
                    (this.InternalRateCost != null &&
                    this.InternalRateCost.Equals(input.InternalRateCost))
                ) && 
                (
                    this.IsoCountryCode == input.IsoCountryCode ||
                    (this.IsoCountryCode != null &&
                    this.IsoCountryCode.Equals(input.IsoCountryCode))
                ) && 
                (
                    this.Options == input.Options ||
                    this.Options != null &&
                    this.Options.SequenceEqual(input.Options)
                ) && 
                (
                    this.Prefix == input.Prefix ||
                    (this.Prefix != null &&
                    this.Prefix.Equals(input.Prefix))
                ) && 
                (
                    this.RateCost == input.RateCost ||
                    (this.RateCost != null &&
                    this.RateCost.Equals(input.RateCost))
                ) && 
                (
                    this.RateIncrement == input.RateIncrement ||
                    (this.RateIncrement != null &&
                    this.RateIncrement.Equals(input.RateIncrement))
                ) && 
                (
                    this.RateMinimum == input.RateMinimum ||
                    (this.RateMinimum != null &&
                    this.RateMinimum.Equals(input.RateMinimum))
                ) && 
                (
                    this.RateName == input.RateName ||
                    (this.RateName != null &&
                    this.RateName.Equals(input.RateName))
                ) && 
                (
                    this.RateNochargeTime == input.RateNochargeTime ||
                    (this.RateNochargeTime != null &&
                    this.RateNochargeTime.Equals(input.RateNochargeTime))
                ) && 
                (
                    this.RateSuffix == input.RateSuffix ||
                    (this.RateSuffix != null &&
                    this.RateSuffix.Equals(input.RateSuffix))
                ) && 
                (
                    this.RateSurcharge == input.RateSurcharge ||
                    (this.RateSurcharge != null &&
                    this.RateSurcharge.Equals(input.RateSurcharge))
                ) && 
                (
                    this.RateVersion == input.RateVersion ||
                    (this.RateVersion != null &&
                    this.RateVersion.Equals(input.RateVersion))
                ) && 
                (
                    this.RatedeckId == input.RatedeckId ||
                    (this.RatedeckId != null &&
                    this.RatedeckId.Equals(input.RatedeckId))
                ) && 
                (
                    this.Routes == input.Routes ||
                    this.Routes != null &&
                    this.Routes.SequenceEqual(input.Routes)
                ) && 
                (
                    this.Weight == input.Weight ||
                    (this.Weight != null &&
                    this.Weight.Equals(input.Weight))
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
                if (this.AccountId != null)
                    hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.CallerIdNumbers != null)
                    hashCode = hashCode * 59 + this.CallerIdNumbers.GetHashCode();
                if (this.Carrier != null)
                    hashCode = hashCode * 59 + this.Carrier.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Direction != null)
                    hashCode = hashCode * 59 + this.Direction.GetHashCode();
                if (this.InternalRateCost != null)
                    hashCode = hashCode * 59 + this.InternalRateCost.GetHashCode();
                if (this.IsoCountryCode != null)
                    hashCode = hashCode * 59 + this.IsoCountryCode.GetHashCode();
                if (this.Options != null)
                    hashCode = hashCode * 59 + this.Options.GetHashCode();
                if (this.Prefix != null)
                    hashCode = hashCode * 59 + this.Prefix.GetHashCode();
                if (this.RateCost != null)
                    hashCode = hashCode * 59 + this.RateCost.GetHashCode();
                if (this.RateIncrement != null)
                    hashCode = hashCode * 59 + this.RateIncrement.GetHashCode();
                if (this.RateMinimum != null)
                    hashCode = hashCode * 59 + this.RateMinimum.GetHashCode();
                if (this.RateName != null)
                    hashCode = hashCode * 59 + this.RateName.GetHashCode();
                if (this.RateNochargeTime != null)
                    hashCode = hashCode * 59 + this.RateNochargeTime.GetHashCode();
                if (this.RateSuffix != null)
                    hashCode = hashCode * 59 + this.RateSuffix.GetHashCode();
                if (this.RateSurcharge != null)
                    hashCode = hashCode * 59 + this.RateSurcharge.GetHashCode();
                if (this.RateVersion != null)
                    hashCode = hashCode * 59 + this.RateVersion.GetHashCode();
                if (this.RatedeckId != null)
                    hashCode = hashCode * 59 + this.RatedeckId.GetHashCode();
                if (this.Routes != null)
                    hashCode = hashCode * 59 + this.Routes.GetHashCode();
                if (this.Weight != null)
                    hashCode = hashCode * 59 + this.Weight.GetHashCode();
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
            // InternalRateCost (decimal?) minimum
            if(this.InternalRateCost < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InternalRateCost, must be a value greater than or equal to 0.", new [] { "InternalRateCost" });
            }

            // RateCost (decimal?) minimum
            if(this.RateCost < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RateCost, must be a value greater than or equal to 0.", new [] { "RateCost" });
            }

            // RateIncrement (int?) minimum
            if(this.RateIncrement < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RateIncrement, must be a value greater than or equal to 1.", new [] { "RateIncrement" });
            }

            // RateMinimum (int?) minimum
            if(this.RateMinimum < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RateMinimum, must be a value greater than or equal to 1.", new [] { "RateMinimum" });
            }

            // RateNochargeTime (int?) minimum
            if(this.RateNochargeTime < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RateNochargeTime, must be a value greater than or equal to 0.", new [] { "RateNochargeTime" });
            }

            // RateSurcharge (decimal?) minimum
            if(this.RateSurcharge < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RateSurcharge, must be a value greater than or equal to 0.", new [] { "RateSurcharge" });
            }

            // Weight (int?) maximum
            if(this.Weight > (int?)100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Weight, must be a value less than or equal to 100.", new [] { "Weight" });
            }

            // Weight (int?) minimum
            if(this.Weight < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Weight, must be a value greater than or equal to 1.", new [] { "Weight" });
            }

            yield break;
        }
    }

}
