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
    /// Describes a service plan item
    /// </summary>
    [DataContract]
    public partial class ServicePlanItem :  IEquatable<ServicePlanItem>, IValidatableObject
    {
        /// <summary>
        /// How rate for this usage is calculated
        /// </summary>
        /// <value>How rate for this usage is calculated</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MarkupTypeEnum
        {
            
            /// <summary>
            /// Enum Fixedprice for value: fixed_price
            /// </summary>
            [EnumMember(Value = "fixed_price")]
            Fixedprice = 1,
            
            /// <summary>
            /// Enum Percentage for value: percentage
            /// </summary>
            [EnumMember(Value = "percentage")]
            Percentage = 2,
            
            /// <summary>
            /// Enum Rate for value: rate
            /// </summary>
            [EnumMember(Value = "rate")]
            Rate = 3
        }

        /// <summary>
        /// How rate for this usage is calculated
        /// </summary>
        /// <value>How rate for this usage is calculated</value>
        [DataMember(Name="markup_type", EmitDefaultValue=false)]
        public MarkupTypeEnum? MarkupType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ServicePlanItem" /> class.
        /// </summary>
        /// <param name="activationCharge">What to charge when activating an Item.</param>
        /// <param name="_as">Count Item as if it was another Item.</param>
        /// <param name="cascade">Whether to count quantities among all sub-accounts or just the account (default to false).</param>
        /// <param name="discounts">discounts.</param>
        /// <param name="flatRate">Takes precedence over rates and rate, charges only the provided amount.</param>
        /// <param name="flatRates">Takes precedence over flat_rate, rates and rate, charges only the provided amount.</param>
        /// <param name="markupType">How rate for this usage is calculated.</param>
        /// <param name="maximum">The maximum quantity of items to bill for.</param>
        /// <param name="minimum">The minimum quantity of items to bill for.</param>
        /// <param name="name">Friendly name for this Item.</param>
        /// <param name="prorate">prorate.</param>
        /// <param name="rate">Used if no flat_rates, flat_rate or rates apply, resulting charges is billable quantity multipled with rate.</param>
        /// <param name="rates">Takes precedence over rate, resulting charges is billable quantity multipled with tiered rate.</param>
        /// <param name="step">Step size for quantity.</param>
        /// <param name="taxes">taxes.</param>
        public ServicePlanItem(decimal? activationCharge = default(decimal?), string _as = default(string), bool? cascade = false, ServicePlanItemDiscounts discounts = default(ServicePlanItemDiscounts), decimal? flatRate = default(decimal?), Object flatRates = default(Object), MarkupTypeEnum? markupType = default(MarkupTypeEnum?), int? maximum = default(int?), int? minimum = default(int?), string name = default(string), ServicePlanItemProrate prorate = default(ServicePlanItemProrate), decimal? rate = default(decimal?), Object rates = default(Object), int? step = default(int?), List<ServicePlanItemTaxes> taxes = default(List<ServicePlanItemTaxes>))
        {
            this.ActivationCharge = activationCharge;
            this.As = _as;
            // use default value if no "cascade" provided
            if (cascade == null)
            {
                this.Cascade = false;
            }
            else
            {
                this.Cascade = cascade;
            }
            this.Discounts = discounts;
            this.FlatRate = flatRate;
            this.FlatRates = flatRates;
            this.MarkupType = markupType;
            this.Maximum = maximum;
            this.Minimum = minimum;
            this.Name = name;
            this.Prorate = prorate;
            this.Rate = rate;
            this.Rates = rates;
            this.Step = step;
            this.Taxes = taxes;
        }
        
        /// <summary>
        /// What to charge when activating an Item
        /// </summary>
        /// <value>What to charge when activating an Item</value>
        [DataMember(Name="activation_charge", EmitDefaultValue=false)]
        public decimal? ActivationCharge { get; set; }

        /// <summary>
        /// Count Item as if it was another Item
        /// </summary>
        /// <value>Count Item as if it was another Item</value>
        [DataMember(Name="as", EmitDefaultValue=false)]
        public string As { get; set; }

        /// <summary>
        /// Whether to count quantities among all sub-accounts or just the account
        /// </summary>
        /// <value>Whether to count quantities among all sub-accounts or just the account</value>
        [DataMember(Name="cascade", EmitDefaultValue=false)]
        public bool? Cascade { get; set; }

        /// <summary>
        /// Gets or Sets Discounts
        /// </summary>
        [DataMember(Name="discounts", EmitDefaultValue=false)]
        public ServicePlanItemDiscounts Discounts { get; set; }

        /// <summary>
        /// Takes precedence over rates and rate, charges only the provided amount
        /// </summary>
        /// <value>Takes precedence over rates and rate, charges only the provided amount</value>
        [DataMember(Name="flat_rate", EmitDefaultValue=false)]
        public decimal? FlatRate { get; set; }

        /// <summary>
        /// Takes precedence over flat_rate, rates and rate, charges only the provided amount
        /// </summary>
        /// <value>Takes precedence over flat_rate, rates and rate, charges only the provided amount</value>
        [DataMember(Name="flat_rates", EmitDefaultValue=false)]
        public Object FlatRates { get; set; }


        /// <summary>
        /// The maximum quantity of items to bill for
        /// </summary>
        /// <value>The maximum quantity of items to bill for</value>
        [DataMember(Name="maximum", EmitDefaultValue=false)]
        public int? Maximum { get; set; }

        /// <summary>
        /// The minimum quantity of items to bill for
        /// </summary>
        /// <value>The minimum quantity of items to bill for</value>
        [DataMember(Name="minimum", EmitDefaultValue=false)]
        public int? Minimum { get; set; }

        /// <summary>
        /// Friendly name for this Item
        /// </summary>
        /// <value>Friendly name for this Item</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Prorate
        /// </summary>
        [DataMember(Name="prorate", EmitDefaultValue=false)]
        public ServicePlanItemProrate Prorate { get; set; }

        /// <summary>
        /// Used if no flat_rates, flat_rate or rates apply, resulting charges is billable quantity multipled with rate
        /// </summary>
        /// <value>Used if no flat_rates, flat_rate or rates apply, resulting charges is billable quantity multipled with rate</value>
        [DataMember(Name="rate", EmitDefaultValue=false)]
        public decimal? Rate { get; set; }

        /// <summary>
        /// Takes precedence over rate, resulting charges is billable quantity multipled with tiered rate
        /// </summary>
        /// <value>Takes precedence over rate, resulting charges is billable quantity multipled with tiered rate</value>
        [DataMember(Name="rates", EmitDefaultValue=false)]
        public Object Rates { get; set; }

        /// <summary>
        /// Step size for quantity
        /// </summary>
        /// <value>Step size for quantity</value>
        [DataMember(Name="step", EmitDefaultValue=false)]
        public int? Step { get; set; }

        /// <summary>
        /// Gets or Sets Taxes
        /// </summary>
        [DataMember(Name="taxes", EmitDefaultValue=false)]
        public List<ServicePlanItemTaxes> Taxes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServicePlanItem {\n");
            sb.Append("  ActivationCharge: ").Append(ActivationCharge).Append("\n");
            sb.Append("  As: ").Append(As).Append("\n");
            sb.Append("  Cascade: ").Append(Cascade).Append("\n");
            sb.Append("  Discounts: ").Append(Discounts).Append("\n");
            sb.Append("  FlatRate: ").Append(FlatRate).Append("\n");
            sb.Append("  FlatRates: ").Append(FlatRates).Append("\n");
            sb.Append("  MarkupType: ").Append(MarkupType).Append("\n");
            sb.Append("  Maximum: ").Append(Maximum).Append("\n");
            sb.Append("  Minimum: ").Append(Minimum).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Prorate: ").Append(Prorate).Append("\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
            sb.Append("  Rates: ").Append(Rates).Append("\n");
            sb.Append("  Step: ").Append(Step).Append("\n");
            sb.Append("  Taxes: ").Append(Taxes).Append("\n");
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
            return this.Equals(input as ServicePlanItem);
        }

        /// <summary>
        /// Returns true if ServicePlanItem instances are equal
        /// </summary>
        /// <param name="input">Instance of ServicePlanItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServicePlanItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ActivationCharge == input.ActivationCharge ||
                    (this.ActivationCharge != null &&
                    this.ActivationCharge.Equals(input.ActivationCharge))
                ) && 
                (
                    this.As == input.As ||
                    (this.As != null &&
                    this.As.Equals(input.As))
                ) && 
                (
                    this.Cascade == input.Cascade ||
                    (this.Cascade != null &&
                    this.Cascade.Equals(input.Cascade))
                ) && 
                (
                    this.Discounts == input.Discounts ||
                    (this.Discounts != null &&
                    this.Discounts.Equals(input.Discounts))
                ) && 
                (
                    this.FlatRate == input.FlatRate ||
                    (this.FlatRate != null &&
                    this.FlatRate.Equals(input.FlatRate))
                ) && 
                (
                    this.FlatRates == input.FlatRates ||
                    (this.FlatRates != null &&
                    this.FlatRates.Equals(input.FlatRates))
                ) && 
                (
                    this.MarkupType == input.MarkupType ||
                    (this.MarkupType != null &&
                    this.MarkupType.Equals(input.MarkupType))
                ) && 
                (
                    this.Maximum == input.Maximum ||
                    (this.Maximum != null &&
                    this.Maximum.Equals(input.Maximum))
                ) && 
                (
                    this.Minimum == input.Minimum ||
                    (this.Minimum != null &&
                    this.Minimum.Equals(input.Minimum))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Prorate == input.Prorate ||
                    (this.Prorate != null &&
                    this.Prorate.Equals(input.Prorate))
                ) && 
                (
                    this.Rate == input.Rate ||
                    (this.Rate != null &&
                    this.Rate.Equals(input.Rate))
                ) && 
                (
                    this.Rates == input.Rates ||
                    (this.Rates != null &&
                    this.Rates.Equals(input.Rates))
                ) && 
                (
                    this.Step == input.Step ||
                    (this.Step != null &&
                    this.Step.Equals(input.Step))
                ) && 
                (
                    this.Taxes == input.Taxes ||
                    this.Taxes != null &&
                    this.Taxes.SequenceEqual(input.Taxes)
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
                if (this.ActivationCharge != null)
                    hashCode = hashCode * 59 + this.ActivationCharge.GetHashCode();
                if (this.As != null)
                    hashCode = hashCode * 59 + this.As.GetHashCode();
                if (this.Cascade != null)
                    hashCode = hashCode * 59 + this.Cascade.GetHashCode();
                if (this.Discounts != null)
                    hashCode = hashCode * 59 + this.Discounts.GetHashCode();
                if (this.FlatRate != null)
                    hashCode = hashCode * 59 + this.FlatRate.GetHashCode();
                if (this.FlatRates != null)
                    hashCode = hashCode * 59 + this.FlatRates.GetHashCode();
                if (this.MarkupType != null)
                    hashCode = hashCode * 59 + this.MarkupType.GetHashCode();
                if (this.Maximum != null)
                    hashCode = hashCode * 59 + this.Maximum.GetHashCode();
                if (this.Minimum != null)
                    hashCode = hashCode * 59 + this.Minimum.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Prorate != null)
                    hashCode = hashCode * 59 + this.Prorate.GetHashCode();
                if (this.Rate != null)
                    hashCode = hashCode * 59 + this.Rate.GetHashCode();
                if (this.Rates != null)
                    hashCode = hashCode * 59 + this.Rates.GetHashCode();
                if (this.Step != null)
                    hashCode = hashCode * 59 + this.Step.GetHashCode();
                if (this.Taxes != null)
                    hashCode = hashCode * 59 + this.Taxes.GetHashCode();
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