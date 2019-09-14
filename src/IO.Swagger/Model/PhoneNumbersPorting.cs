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
    /// Porting (in) information for the phone number
    /// </summary>
    [DataContract]
    public partial class PhoneNumbersPorting :  IEquatable<PhoneNumbersPorting>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumbersPorting" /> class.
        /// </summary>
        /// <param name="billingAccountId">The account id the losing carrier has on file.</param>
        /// <param name="billingExtendedAddress">The suit/floor/apt. address the losing carrier has on file.</param>
        /// <param name="billingLocality">The locality (city) the losing carrier has on file.</param>
        /// <param name="billingName">The name or company name the losing carrier has on file.</param>
        /// <param name="billingPostalCode">The zip/postal code the losing carrier has on file.</param>
        /// <param name="billingRegion">The region (state) the losing carrier has on file.</param>
        /// <param name="billingStreetAddress">The street address the losing carrier has on file.</param>
        /// <param name="billingTelephoneNumber">The BTN of the account the number belongs to.</param>
        /// <param name="comments">An array of comments.</param>
        /// <param name="customerContact">The phone number that can be used to contact the owner of the number.</param>
        /// <param name="portId">The id of the port request.</param>
        /// <param name="requestedPortDate">The requested port date.</param>
        /// <param name="serviceProvider">The name of the losing carrier.</param>
        public PhoneNumbersPorting(string billingAccountId = default(string), string billingExtendedAddress = default(string), string billingLocality = default(string), string billingName = default(string), string billingPostalCode = default(string), string billingRegion = default(string), string billingStreetAddress = default(string), string billingTelephoneNumber = default(string), List<string> comments = default(List<string>), string customerContact = default(string), string portId = default(string), string requestedPortDate = default(string), string serviceProvider = default(string))
        {
            this.BillingAccountId = billingAccountId;
            this.BillingExtendedAddress = billingExtendedAddress;
            this.BillingLocality = billingLocality;
            this.BillingName = billingName;
            this.BillingPostalCode = billingPostalCode;
            this.BillingRegion = billingRegion;
            this.BillingStreetAddress = billingStreetAddress;
            this.BillingTelephoneNumber = billingTelephoneNumber;
            this.Comments = comments;
            this.CustomerContact = customerContact;
            this.PortId = portId;
            this.RequestedPortDate = requestedPortDate;
            this.ServiceProvider = serviceProvider;
        }
        
        /// <summary>
        /// The account id the losing carrier has on file
        /// </summary>
        /// <value>The account id the losing carrier has on file</value>
        [DataMember(Name="billing_account_id", EmitDefaultValue=false)]
        public string BillingAccountId { get; set; }

        /// <summary>
        /// The suit/floor/apt. address the losing carrier has on file
        /// </summary>
        /// <value>The suit/floor/apt. address the losing carrier has on file</value>
        [DataMember(Name="billing_extended_address", EmitDefaultValue=false)]
        public string BillingExtendedAddress { get; set; }

        /// <summary>
        /// The locality (city) the losing carrier has on file
        /// </summary>
        /// <value>The locality (city) the losing carrier has on file</value>
        [DataMember(Name="billing_locality", EmitDefaultValue=false)]
        public string BillingLocality { get; set; }

        /// <summary>
        /// The name or company name the losing carrier has on file
        /// </summary>
        /// <value>The name or company name the losing carrier has on file</value>
        [DataMember(Name="billing_name", EmitDefaultValue=false)]
        public string BillingName { get; set; }

        /// <summary>
        /// The zip/postal code the losing carrier has on file
        /// </summary>
        /// <value>The zip/postal code the losing carrier has on file</value>
        [DataMember(Name="billing_postal_code", EmitDefaultValue=false)]
        public string BillingPostalCode { get; set; }

        /// <summary>
        /// The region (state) the losing carrier has on file
        /// </summary>
        /// <value>The region (state) the losing carrier has on file</value>
        [DataMember(Name="billing_region", EmitDefaultValue=false)]
        public string BillingRegion { get; set; }

        /// <summary>
        /// The street address the losing carrier has on file
        /// </summary>
        /// <value>The street address the losing carrier has on file</value>
        [DataMember(Name="billing_street_address", EmitDefaultValue=false)]
        public string BillingStreetAddress { get; set; }

        /// <summary>
        /// The BTN of the account the number belongs to
        /// </summary>
        /// <value>The BTN of the account the number belongs to</value>
        [DataMember(Name="billing_telephone_number", EmitDefaultValue=false)]
        public string BillingTelephoneNumber { get; set; }

        /// <summary>
        /// An array of comments
        /// </summary>
        /// <value>An array of comments</value>
        [DataMember(Name="comments", EmitDefaultValue=false)]
        public List<string> Comments { get; set; }

        /// <summary>
        /// The phone number that can be used to contact the owner of the number
        /// </summary>
        /// <value>The phone number that can be used to contact the owner of the number</value>
        [DataMember(Name="customer_contact", EmitDefaultValue=false)]
        public string CustomerContact { get; set; }

        /// <summary>
        /// The id of the port request
        /// </summary>
        /// <value>The id of the port request</value>
        [DataMember(Name="port_id", EmitDefaultValue=false)]
        public string PortId { get; set; }

        /// <summary>
        /// The requested port date
        /// </summary>
        /// <value>The requested port date</value>
        [DataMember(Name="requested_port_date", EmitDefaultValue=false)]
        public string RequestedPortDate { get; set; }

        /// <summary>
        /// The name of the losing carrier
        /// </summary>
        /// <value>The name of the losing carrier</value>
        [DataMember(Name="service_provider", EmitDefaultValue=false)]
        public string ServiceProvider { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PhoneNumbersPorting {\n");
            sb.Append("  BillingAccountId: ").Append(BillingAccountId).Append("\n");
            sb.Append("  BillingExtendedAddress: ").Append(BillingExtendedAddress).Append("\n");
            sb.Append("  BillingLocality: ").Append(BillingLocality).Append("\n");
            sb.Append("  BillingName: ").Append(BillingName).Append("\n");
            sb.Append("  BillingPostalCode: ").Append(BillingPostalCode).Append("\n");
            sb.Append("  BillingRegion: ").Append(BillingRegion).Append("\n");
            sb.Append("  BillingStreetAddress: ").Append(BillingStreetAddress).Append("\n");
            sb.Append("  BillingTelephoneNumber: ").Append(BillingTelephoneNumber).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  CustomerContact: ").Append(CustomerContact).Append("\n");
            sb.Append("  PortId: ").Append(PortId).Append("\n");
            sb.Append("  RequestedPortDate: ").Append(RequestedPortDate).Append("\n");
            sb.Append("  ServiceProvider: ").Append(ServiceProvider).Append("\n");
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
            return this.Equals(input as PhoneNumbersPorting);
        }

        /// <summary>
        /// Returns true if PhoneNumbersPorting instances are equal
        /// </summary>
        /// <param name="input">Instance of PhoneNumbersPorting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhoneNumbersPorting input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BillingAccountId == input.BillingAccountId ||
                    (this.BillingAccountId != null &&
                    this.BillingAccountId.Equals(input.BillingAccountId))
                ) && 
                (
                    this.BillingExtendedAddress == input.BillingExtendedAddress ||
                    (this.BillingExtendedAddress != null &&
                    this.BillingExtendedAddress.Equals(input.BillingExtendedAddress))
                ) && 
                (
                    this.BillingLocality == input.BillingLocality ||
                    (this.BillingLocality != null &&
                    this.BillingLocality.Equals(input.BillingLocality))
                ) && 
                (
                    this.BillingName == input.BillingName ||
                    (this.BillingName != null &&
                    this.BillingName.Equals(input.BillingName))
                ) && 
                (
                    this.BillingPostalCode == input.BillingPostalCode ||
                    (this.BillingPostalCode != null &&
                    this.BillingPostalCode.Equals(input.BillingPostalCode))
                ) && 
                (
                    this.BillingRegion == input.BillingRegion ||
                    (this.BillingRegion != null &&
                    this.BillingRegion.Equals(input.BillingRegion))
                ) && 
                (
                    this.BillingStreetAddress == input.BillingStreetAddress ||
                    (this.BillingStreetAddress != null &&
                    this.BillingStreetAddress.Equals(input.BillingStreetAddress))
                ) && 
                (
                    this.BillingTelephoneNumber == input.BillingTelephoneNumber ||
                    (this.BillingTelephoneNumber != null &&
                    this.BillingTelephoneNumber.Equals(input.BillingTelephoneNumber))
                ) && 
                (
                    this.Comments == input.Comments ||
                    this.Comments != null &&
                    this.Comments.SequenceEqual(input.Comments)
                ) && 
                (
                    this.CustomerContact == input.CustomerContact ||
                    (this.CustomerContact != null &&
                    this.CustomerContact.Equals(input.CustomerContact))
                ) && 
                (
                    this.PortId == input.PortId ||
                    (this.PortId != null &&
                    this.PortId.Equals(input.PortId))
                ) && 
                (
                    this.RequestedPortDate == input.RequestedPortDate ||
                    (this.RequestedPortDate != null &&
                    this.RequestedPortDate.Equals(input.RequestedPortDate))
                ) && 
                (
                    this.ServiceProvider == input.ServiceProvider ||
                    (this.ServiceProvider != null &&
                    this.ServiceProvider.Equals(input.ServiceProvider))
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
                if (this.BillingAccountId != null)
                    hashCode = hashCode * 59 + this.BillingAccountId.GetHashCode();
                if (this.BillingExtendedAddress != null)
                    hashCode = hashCode * 59 + this.BillingExtendedAddress.GetHashCode();
                if (this.BillingLocality != null)
                    hashCode = hashCode * 59 + this.BillingLocality.GetHashCode();
                if (this.BillingName != null)
                    hashCode = hashCode * 59 + this.BillingName.GetHashCode();
                if (this.BillingPostalCode != null)
                    hashCode = hashCode * 59 + this.BillingPostalCode.GetHashCode();
                if (this.BillingRegion != null)
                    hashCode = hashCode * 59 + this.BillingRegion.GetHashCode();
                if (this.BillingStreetAddress != null)
                    hashCode = hashCode * 59 + this.BillingStreetAddress.GetHashCode();
                if (this.BillingTelephoneNumber != null)
                    hashCode = hashCode * 59 + this.BillingTelephoneNumber.GetHashCode();
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
                if (this.CustomerContact != null)
                    hashCode = hashCode * 59 + this.CustomerContact.GetHashCode();
                if (this.PortId != null)
                    hashCode = hashCode * 59 + this.PortId.GetHashCode();
                if (this.RequestedPortDate != null)
                    hashCode = hashCode * 59 + this.RequestedPortDate.GetHashCode();
                if (this.ServiceProvider != null)
                    hashCode = hashCode * 59 + this.ServiceProvider.GetHashCode();
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
