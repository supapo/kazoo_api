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
    /// Schema for a port request
    /// </summary>
    [DataContract]
    public partial class PortRequests :  IEquatable<PortRequests>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PortRequests" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PortRequests() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PortRequests" /> class.
        /// </summary>
        /// <param name="bill">bill.</param>
        /// <param name="comments">The history of comments made on a port request.</param>
        /// <param name="name">A friendly name for the port request (required).</param>
        /// <param name="notifications">notifications.</param>
        /// <param name="numbers">The numbers to port in (required).</param>
        /// <param name="referenceNumber">Winning carrier reference number or order ID.</param>
        /// <param name="signeeName">The name of the person authorizing the release of numbers from the losing carrier.</param>
        /// <param name="signingDate">The date in Gregorian timestamp on which the document releasing the numbers from the losing carrier was signed.</param>
        /// <param name="transferDate">Requested transfer date in Gregorian timestamp.</param>
        /// <param name="winningCarrier">The name of winning carrier.</param>
        public PortRequests(PortRequestsBill bill = default(PortRequestsBill), List<Comment> comments = default(List<Comment>), string name = default(string), PortRequestsNotifications notifications = default(PortRequestsNotifications), Object numbers = default(Object), string referenceNumber = default(string), string signeeName = default(string), int? signingDate = default(int?), int? transferDate = default(int?), string winningCarrier = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for PortRequests and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "numbers" is required (not null)
            if (numbers == null)
            {
                throw new InvalidDataException("numbers is a required property for PortRequests and cannot be null");
            }
            else
            {
                this.Numbers = numbers;
            }
            this.Bill = bill;
            this.Comments = comments;
            this.Notifications = notifications;
            this.ReferenceNumber = referenceNumber;
            this.SigneeName = signeeName;
            this.SigningDate = signingDate;
            this.TransferDate = transferDate;
            this.WinningCarrier = winningCarrier;
        }
        
        /// <summary>
        /// Gets or Sets Bill
        /// </summary>
        [DataMember(Name="bill", EmitDefaultValue=false)]
        public PortRequestsBill Bill { get; set; }

        /// <summary>
        /// The history of comments made on a port request
        /// </summary>
        /// <value>The history of comments made on a port request</value>
        [DataMember(Name="comments", EmitDefaultValue=false)]
        public List<Comment> Comments { get; set; }

        /// <summary>
        /// A friendly name for the port request
        /// </summary>
        /// <value>A friendly name for the port request</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Notifications
        /// </summary>
        [DataMember(Name="notifications", EmitDefaultValue=false)]
        public PortRequestsNotifications Notifications { get; set; }

        /// <summary>
        /// The numbers to port in
        /// </summary>
        /// <value>The numbers to port in</value>
        [DataMember(Name="numbers", EmitDefaultValue=false)]
        public Object Numbers { get; set; }

        /// <summary>
        /// Winning carrier reference number or order ID
        /// </summary>
        /// <value>Winning carrier reference number or order ID</value>
        [DataMember(Name="reference_number", EmitDefaultValue=false)]
        public string ReferenceNumber { get; set; }

        /// <summary>
        /// The name of the person authorizing the release of numbers from the losing carrier
        /// </summary>
        /// <value>The name of the person authorizing the release of numbers from the losing carrier</value>
        [DataMember(Name="signee_name", EmitDefaultValue=false)]
        public string SigneeName { get; set; }

        /// <summary>
        /// The date in Gregorian timestamp on which the document releasing the numbers from the losing carrier was signed
        /// </summary>
        /// <value>The date in Gregorian timestamp on which the document releasing the numbers from the losing carrier was signed</value>
        [DataMember(Name="signing_date", EmitDefaultValue=false)]
        public int? SigningDate { get; set; }

        /// <summary>
        /// Requested transfer date in Gregorian timestamp
        /// </summary>
        /// <value>Requested transfer date in Gregorian timestamp</value>
        [DataMember(Name="transfer_date", EmitDefaultValue=false)]
        public int? TransferDate { get; set; }

        /// <summary>
        /// The name of winning carrier
        /// </summary>
        /// <value>The name of winning carrier</value>
        [DataMember(Name="winning_carrier", EmitDefaultValue=false)]
        public string WinningCarrier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PortRequests {\n");
            sb.Append("  Bill: ").Append(Bill).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Notifications: ").Append(Notifications).Append("\n");
            sb.Append("  Numbers: ").Append(Numbers).Append("\n");
            sb.Append("  ReferenceNumber: ").Append(ReferenceNumber).Append("\n");
            sb.Append("  SigneeName: ").Append(SigneeName).Append("\n");
            sb.Append("  SigningDate: ").Append(SigningDate).Append("\n");
            sb.Append("  TransferDate: ").Append(TransferDate).Append("\n");
            sb.Append("  WinningCarrier: ").Append(WinningCarrier).Append("\n");
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
            return this.Equals(input as PortRequests);
        }

        /// <summary>
        /// Returns true if PortRequests instances are equal
        /// </summary>
        /// <param name="input">Instance of PortRequests to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PortRequests input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Bill == input.Bill ||
                    (this.Bill != null &&
                    this.Bill.Equals(input.Bill))
                ) && 
                (
                    this.Comments == input.Comments ||
                    this.Comments != null &&
                    this.Comments.SequenceEqual(input.Comments)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Notifications == input.Notifications ||
                    (this.Notifications != null &&
                    this.Notifications.Equals(input.Notifications))
                ) && 
                (
                    this.Numbers == input.Numbers ||
                    (this.Numbers != null &&
                    this.Numbers.Equals(input.Numbers))
                ) && 
                (
                    this.ReferenceNumber == input.ReferenceNumber ||
                    (this.ReferenceNumber != null &&
                    this.ReferenceNumber.Equals(input.ReferenceNumber))
                ) && 
                (
                    this.SigneeName == input.SigneeName ||
                    (this.SigneeName != null &&
                    this.SigneeName.Equals(input.SigneeName))
                ) && 
                (
                    this.SigningDate == input.SigningDate ||
                    (this.SigningDate != null &&
                    this.SigningDate.Equals(input.SigningDate))
                ) && 
                (
                    this.TransferDate == input.TransferDate ||
                    (this.TransferDate != null &&
                    this.TransferDate.Equals(input.TransferDate))
                ) && 
                (
                    this.WinningCarrier == input.WinningCarrier ||
                    (this.WinningCarrier != null &&
                    this.WinningCarrier.Equals(input.WinningCarrier))
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
                if (this.Bill != null)
                    hashCode = hashCode * 59 + this.Bill.GetHashCode();
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Notifications != null)
                    hashCode = hashCode * 59 + this.Notifications.GetHashCode();
                if (this.Numbers != null)
                    hashCode = hashCode * 59 + this.Numbers.GetHashCode();
                if (this.ReferenceNumber != null)
                    hashCode = hashCode * 59 + this.ReferenceNumber.GetHashCode();
                if (this.SigneeName != null)
                    hashCode = hashCode * 59 + this.SigneeName.GetHashCode();
                if (this.SigningDate != null)
                    hashCode = hashCode * 59 + this.SigningDate.GetHashCode();
                if (this.TransferDate != null)
                    hashCode = hashCode * 59 + this.TransferDate.GetHashCode();
                if (this.WinningCarrier != null)
                    hashCode = hashCode * 59 + this.WinningCarrier.GetHashCode();
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

            yield break;
        }
    }

}
