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
    /// AMQP API for bookkeepers.refund_req_definition
    /// </summary>
    [DataContract]
    public partial class KapiBookkeepersRefundReqDefinition :  IEquatable<KapiBookkeepersRefundReqDefinition>, IValidatableObject
    {
        /// <summary>
        /// Defines EventCategory
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventCategoryEnum
        {
            
            /// <summary>
            /// Enum Bookkeepers for value: bookkeepers
            /// </summary>
            [EnumMember(Value = "bookkeepers")]
            Bookkeepers = 1
        }

        /// <summary>
        /// Gets or Sets EventCategory
        /// </summary>
        [DataMember(Name="Event-Category", EmitDefaultValue=false)]
        public EventCategoryEnum? EventCategory { get; set; }
        /// <summary>
        /// Defines EventName
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventNameEnum
        {
            
            /// <summary>
            /// Enum Refundreq for value: refund_req
            /// </summary>
            [EnumMember(Value = "refund_req")]
            Refundreq = 1
        }

        /// <summary>
        /// Gets or Sets EventName
        /// </summary>
        [DataMember(Name="Event-Name", EmitDefaultValue=false)]
        public EventNameEnum? EventName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiBookkeepersRefundReqDefinition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KapiBookkeepersRefundReqDefinition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiBookkeepersRefundReqDefinition" /> class.
        /// </summary>
        /// <param name="accountID">accountID (required).</param>
        /// <param name="amount">amount (required).</param>
        /// <param name="bookkeeperType">bookkeeperType (required).</param>
        /// <param name="eventCategory">eventCategory.</param>
        /// <param name="eventName">eventName.</param>
        /// <param name="transactionDB">transactionDB (required).</param>
        /// <param name="transactionID">transactionID (required).</param>
        /// <param name="vendorID">vendorID (required).</param>
        public KapiBookkeepersRefundReqDefinition(string accountID = default(string), string amount = default(string), string bookkeeperType = default(string), EventCategoryEnum? eventCategory = default(EventCategoryEnum?), EventNameEnum? eventName = default(EventNameEnum?), string transactionDB = default(string), string transactionID = default(string), string vendorID = default(string))
        {
            // to ensure "accountID" is required (not null)
            if (accountID == null)
            {
                throw new InvalidDataException("accountID is a required property for KapiBookkeepersRefundReqDefinition and cannot be null");
            }
            else
            {
                this.AccountID = accountID;
            }
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new InvalidDataException("amount is a required property for KapiBookkeepersRefundReqDefinition and cannot be null");
            }
            else
            {
                this.Amount = amount;
            }
            // to ensure "bookkeeperType" is required (not null)
            if (bookkeeperType == null)
            {
                throw new InvalidDataException("bookkeeperType is a required property for KapiBookkeepersRefundReqDefinition and cannot be null");
            }
            else
            {
                this.BookkeeperType = bookkeeperType;
            }
            // to ensure "transactionDB" is required (not null)
            if (transactionDB == null)
            {
                throw new InvalidDataException("transactionDB is a required property for KapiBookkeepersRefundReqDefinition and cannot be null");
            }
            else
            {
                this.TransactionDB = transactionDB;
            }
            // to ensure "transactionID" is required (not null)
            if (transactionID == null)
            {
                throw new InvalidDataException("transactionID is a required property for KapiBookkeepersRefundReqDefinition and cannot be null");
            }
            else
            {
                this.TransactionID = transactionID;
            }
            // to ensure "vendorID" is required (not null)
            if (vendorID == null)
            {
                throw new InvalidDataException("vendorID is a required property for KapiBookkeepersRefundReqDefinition and cannot be null");
            }
            else
            {
                this.VendorID = vendorID;
            }
            this.EventCategory = eventCategory;
            this.EventName = eventName;
        }
        
        /// <summary>
        /// Gets or Sets AccountID
        /// </summary>
        [DataMember(Name="Account-ID", EmitDefaultValue=false)]
        public string AccountID { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="Amount", EmitDefaultValue=false)]
        public string Amount { get; set; }

        /// <summary>
        /// Gets or Sets BookkeeperType
        /// </summary>
        [DataMember(Name="Bookkeeper-Type", EmitDefaultValue=false)]
        public string BookkeeperType { get; set; }



        /// <summary>
        /// Gets or Sets TransactionDB
        /// </summary>
        [DataMember(Name="Transaction-DB", EmitDefaultValue=false)]
        public string TransactionDB { get; set; }

        /// <summary>
        /// Gets or Sets TransactionID
        /// </summary>
        [DataMember(Name="Transaction-ID", EmitDefaultValue=false)]
        public string TransactionID { get; set; }

        /// <summary>
        /// Gets or Sets VendorID
        /// </summary>
        [DataMember(Name="Vendor-ID", EmitDefaultValue=false)]
        public string VendorID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KapiBookkeepersRefundReqDefinition {\n");
            sb.Append("  AccountID: ").Append(AccountID).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  BookkeeperType: ").Append(BookkeeperType).Append("\n");
            sb.Append("  EventCategory: ").Append(EventCategory).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  TransactionDB: ").Append(TransactionDB).Append("\n");
            sb.Append("  TransactionID: ").Append(TransactionID).Append("\n");
            sb.Append("  VendorID: ").Append(VendorID).Append("\n");
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
            return this.Equals(input as KapiBookkeepersRefundReqDefinition);
        }

        /// <summary>
        /// Returns true if KapiBookkeepersRefundReqDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of KapiBookkeepersRefundReqDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KapiBookkeepersRefundReqDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountID == input.AccountID ||
                    (this.AccountID != null &&
                    this.AccountID.Equals(input.AccountID))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.BookkeeperType == input.BookkeeperType ||
                    (this.BookkeeperType != null &&
                    this.BookkeeperType.Equals(input.BookkeeperType))
                ) && 
                (
                    this.EventCategory == input.EventCategory ||
                    (this.EventCategory != null &&
                    this.EventCategory.Equals(input.EventCategory))
                ) && 
                (
                    this.EventName == input.EventName ||
                    (this.EventName != null &&
                    this.EventName.Equals(input.EventName))
                ) && 
                (
                    this.TransactionDB == input.TransactionDB ||
                    (this.TransactionDB != null &&
                    this.TransactionDB.Equals(input.TransactionDB))
                ) && 
                (
                    this.TransactionID == input.TransactionID ||
                    (this.TransactionID != null &&
                    this.TransactionID.Equals(input.TransactionID))
                ) && 
                (
                    this.VendorID == input.VendorID ||
                    (this.VendorID != null &&
                    this.VendorID.Equals(input.VendorID))
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
                if (this.AccountID != null)
                    hashCode = hashCode * 59 + this.AccountID.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.BookkeeperType != null)
                    hashCode = hashCode * 59 + this.BookkeeperType.GetHashCode();
                if (this.EventCategory != null)
                    hashCode = hashCode * 59 + this.EventCategory.GetHashCode();
                if (this.EventName != null)
                    hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.TransactionDB != null)
                    hashCode = hashCode * 59 + this.TransactionDB.GetHashCode();
                if (this.TransactionID != null)
                    hashCode = hashCode * 59 + this.TransactionID.GetHashCode();
                if (this.VendorID != null)
                    hashCode = hashCode * 59 + this.VendorID.GetHashCode();
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
