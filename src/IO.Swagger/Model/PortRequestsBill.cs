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
    /// Billing information of the losing carrier
    /// </summary>
    [DataContract]
    public partial class PortRequestsBill :  IEquatable<PortRequestsBill>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PortRequestsBill" /> class.
        /// </summary>
        /// <param name="accountNumber">Account Number to identify account.</param>
        /// <param name="btn">Billing Telephone Number (BTN) to identify account.</param>
        /// <param name="carrier">The name of the losing carrier.</param>
        /// <param name="locality">The locality (city) of the billing address the losing carrier has on record.</param>
        /// <param name="name">The losing carrier billing/account name.</param>
        /// <param name="pin">Personal Identification Number (PIN) to identify account.</param>
        /// <param name="postalCode">The zip/postal code of the billing address the losing carrier has on record.</param>
        /// <param name="region">The region (state) of the billing address the losing carrier has on record.</param>
        /// <param name="streetAddress">The street name of the billing address the losing carrier has on record.</param>
        /// <param name="streetNumber">The street number of the billing address the losing carrier has on record.</param>
        /// <param name="streetPostDir">Street Post-Direction.</param>
        /// <param name="streetPreDir">Street Pre-Direction.</param>
        /// <param name="streetType">The street type of the billing address the losing carrier has on record.</param>
        public PortRequestsBill(string accountNumber = default(string), string btn = default(string), string carrier = default(string), string locality = default(string), string name = default(string), string pin = default(string), string postalCode = default(string), string region = default(string), string streetAddress = default(string), string streetNumber = default(string), string streetPostDir = default(string), string streetPreDir = default(string), string streetType = default(string))
        {
            this.AccountNumber = accountNumber;
            this.Btn = btn;
            this.Carrier = carrier;
            this.Locality = locality;
            this.Name = name;
            this.Pin = pin;
            this.PostalCode = postalCode;
            this.Region = region;
            this.StreetAddress = streetAddress;
            this.StreetNumber = streetNumber;
            this.StreetPostDir = streetPostDir;
            this.StreetPreDir = streetPreDir;
            this.StreetType = streetType;
        }
        
        /// <summary>
        /// Account Number to identify account
        /// </summary>
        /// <value>Account Number to identify account</value>
        [DataMember(Name="account_number", EmitDefaultValue=false)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Billing Telephone Number (BTN) to identify account
        /// </summary>
        /// <value>Billing Telephone Number (BTN) to identify account</value>
        [DataMember(Name="btn", EmitDefaultValue=false)]
        public string Btn { get; set; }

        /// <summary>
        /// The name of the losing carrier
        /// </summary>
        /// <value>The name of the losing carrier</value>
        [DataMember(Name="carrier", EmitDefaultValue=false)]
        public string Carrier { get; set; }

        /// <summary>
        /// The locality (city) of the billing address the losing carrier has on record
        /// </summary>
        /// <value>The locality (city) of the billing address the losing carrier has on record</value>
        [DataMember(Name="locality", EmitDefaultValue=false)]
        public string Locality { get; set; }

        /// <summary>
        /// The losing carrier billing/account name
        /// </summary>
        /// <value>The losing carrier billing/account name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Personal Identification Number (PIN) to identify account
        /// </summary>
        /// <value>Personal Identification Number (PIN) to identify account</value>
        [DataMember(Name="pin", EmitDefaultValue=false)]
        public string Pin { get; set; }

        /// <summary>
        /// The zip/postal code of the billing address the losing carrier has on record
        /// </summary>
        /// <value>The zip/postal code of the billing address the losing carrier has on record</value>
        [DataMember(Name="postal_code", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// The region (state) of the billing address the losing carrier has on record
        /// </summary>
        /// <value>The region (state) of the billing address the losing carrier has on record</value>
        [DataMember(Name="region", EmitDefaultValue=false)]
        public string Region { get; set; }

        /// <summary>
        /// The street name of the billing address the losing carrier has on record
        /// </summary>
        /// <value>The street name of the billing address the losing carrier has on record</value>
        [DataMember(Name="street_address", EmitDefaultValue=false)]
        public string StreetAddress { get; set; }

        /// <summary>
        /// The street number of the billing address the losing carrier has on record
        /// </summary>
        /// <value>The street number of the billing address the losing carrier has on record</value>
        [DataMember(Name="street_number", EmitDefaultValue=false)]
        public string StreetNumber { get; set; }

        /// <summary>
        /// Street Post-Direction
        /// </summary>
        /// <value>Street Post-Direction</value>
        [DataMember(Name="street_post_dir", EmitDefaultValue=false)]
        public string StreetPostDir { get; set; }

        /// <summary>
        /// Street Pre-Direction
        /// </summary>
        /// <value>Street Pre-Direction</value>
        [DataMember(Name="street_pre_dir", EmitDefaultValue=false)]
        public string StreetPreDir { get; set; }

        /// <summary>
        /// The street type of the billing address the losing carrier has on record
        /// </summary>
        /// <value>The street type of the billing address the losing carrier has on record</value>
        [DataMember(Name="street_type", EmitDefaultValue=false)]
        public string StreetType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PortRequestsBill {\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  Btn: ").Append(Btn).Append("\n");
            sb.Append("  Carrier: ").Append(Carrier).Append("\n");
            sb.Append("  Locality: ").Append(Locality).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Pin: ").Append(Pin).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  StreetAddress: ").Append(StreetAddress).Append("\n");
            sb.Append("  StreetNumber: ").Append(StreetNumber).Append("\n");
            sb.Append("  StreetPostDir: ").Append(StreetPostDir).Append("\n");
            sb.Append("  StreetPreDir: ").Append(StreetPreDir).Append("\n");
            sb.Append("  StreetType: ").Append(StreetType).Append("\n");
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
            return this.Equals(input as PortRequestsBill);
        }

        /// <summary>
        /// Returns true if PortRequestsBill instances are equal
        /// </summary>
        /// <param name="input">Instance of PortRequestsBill to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PortRequestsBill input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountNumber == input.AccountNumber ||
                    (this.AccountNumber != null &&
                    this.AccountNumber.Equals(input.AccountNumber))
                ) && 
                (
                    this.Btn == input.Btn ||
                    (this.Btn != null &&
                    this.Btn.Equals(input.Btn))
                ) && 
                (
                    this.Carrier == input.Carrier ||
                    (this.Carrier != null &&
                    this.Carrier.Equals(input.Carrier))
                ) && 
                (
                    this.Locality == input.Locality ||
                    (this.Locality != null &&
                    this.Locality.Equals(input.Locality))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Pin == input.Pin ||
                    (this.Pin != null &&
                    this.Pin.Equals(input.Pin))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && 
                (
                    this.StreetAddress == input.StreetAddress ||
                    (this.StreetAddress != null &&
                    this.StreetAddress.Equals(input.StreetAddress))
                ) && 
                (
                    this.StreetNumber == input.StreetNumber ||
                    (this.StreetNumber != null &&
                    this.StreetNumber.Equals(input.StreetNumber))
                ) && 
                (
                    this.StreetPostDir == input.StreetPostDir ||
                    (this.StreetPostDir != null &&
                    this.StreetPostDir.Equals(input.StreetPostDir))
                ) && 
                (
                    this.StreetPreDir == input.StreetPreDir ||
                    (this.StreetPreDir != null &&
                    this.StreetPreDir.Equals(input.StreetPreDir))
                ) && 
                (
                    this.StreetType == input.StreetType ||
                    (this.StreetType != null &&
                    this.StreetType.Equals(input.StreetType))
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
                if (this.AccountNumber != null)
                    hashCode = hashCode * 59 + this.AccountNumber.GetHashCode();
                if (this.Btn != null)
                    hashCode = hashCode * 59 + this.Btn.GetHashCode();
                if (this.Carrier != null)
                    hashCode = hashCode * 59 + this.Carrier.GetHashCode();
                if (this.Locality != null)
                    hashCode = hashCode * 59 + this.Locality.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Pin != null)
                    hashCode = hashCode * 59 + this.Pin.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.StreetAddress != null)
                    hashCode = hashCode * 59 + this.StreetAddress.GetHashCode();
                if (this.StreetNumber != null)
                    hashCode = hashCode * 59 + this.StreetNumber.GetHashCode();
                if (this.StreetPostDir != null)
                    hashCode = hashCode * 59 + this.StreetPostDir.GetHashCode();
                if (this.StreetPreDir != null)
                    hashCode = hashCode * 59 + this.StreetPreDir.GetHashCode();
                if (this.StreetType != null)
                    hashCode = hashCode * 59 + this.StreetType.GetHashCode();
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