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
    /// AMQP API for bookkeepers.update_req_definition
    /// </summary>
    [DataContract]
    public partial class KapiBookkeepersUpdateReqDefinition :  IEquatable<KapiBookkeepersUpdateReqDefinition>, IValidatableObject
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
            /// Enum Updatereq for value: update_req
            /// </summary>
            [EnumMember(Value = "update_req")]
            Updatereq = 1
        }

        /// <summary>
        /// Gets or Sets EventName
        /// </summary>
        [DataMember(Name="Event-Name", EmitDefaultValue=false)]
        public EventNameEnum? EventName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiBookkeepersUpdateReqDefinition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KapiBookkeepersUpdateReqDefinition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiBookkeepersUpdateReqDefinition" /> class.
        /// </summary>
        /// <param name="accountID">accountID (required).</param>
        /// <param name="auditID">auditID.</param>
        /// <param name="auditLog">auditLog.</param>
        /// <param name="bookkeeperID">bookkeeperID (required).</param>
        /// <param name="bookkeeperType">bookkeeperType (required).</param>
        /// <param name="dryRun">dryRun.</param>
        /// <param name="eventCategory">eventCategory.</param>
        /// <param name="eventName">eventName.</param>
        /// <param name="invoice">invoice (required).</param>
        /// <param name="vendorID">vendorID (required).</param>
        public KapiBookkeepersUpdateReqDefinition(string accountID = default(string), string auditID = default(string), string auditLog = default(string), string bookkeeperID = default(string), string bookkeeperType = default(string), string dryRun = default(string), EventCategoryEnum? eventCategory = default(EventCategoryEnum?), EventNameEnum? eventName = default(EventNameEnum?), string invoice = default(string), string vendorID = default(string))
        {
            // to ensure "accountID" is required (not null)
            if (accountID == null)
            {
                throw new InvalidDataException("accountID is a required property for KapiBookkeepersUpdateReqDefinition and cannot be null");
            }
            else
            {
                this.AccountID = accountID;
            }
            // to ensure "bookkeeperID" is required (not null)
            if (bookkeeperID == null)
            {
                throw new InvalidDataException("bookkeeperID is a required property for KapiBookkeepersUpdateReqDefinition and cannot be null");
            }
            else
            {
                this.BookkeeperID = bookkeeperID;
            }
            // to ensure "bookkeeperType" is required (not null)
            if (bookkeeperType == null)
            {
                throw new InvalidDataException("bookkeeperType is a required property for KapiBookkeepersUpdateReqDefinition and cannot be null");
            }
            else
            {
                this.BookkeeperType = bookkeeperType;
            }
            // to ensure "invoice" is required (not null)
            if (invoice == null)
            {
                throw new InvalidDataException("invoice is a required property for KapiBookkeepersUpdateReqDefinition and cannot be null");
            }
            else
            {
                this.Invoice = invoice;
            }
            // to ensure "vendorID" is required (not null)
            if (vendorID == null)
            {
                throw new InvalidDataException("vendorID is a required property for KapiBookkeepersUpdateReqDefinition and cannot be null");
            }
            else
            {
                this.VendorID = vendorID;
            }
            this.AuditID = auditID;
            this.AuditLog = auditLog;
            this.DryRun = dryRun;
            this.EventCategory = eventCategory;
            this.EventName = eventName;
        }
        
        /// <summary>
        /// Gets or Sets AccountID
        /// </summary>
        [DataMember(Name="Account-ID", EmitDefaultValue=false)]
        public string AccountID { get; set; }

        /// <summary>
        /// Gets or Sets AuditID
        /// </summary>
        [DataMember(Name="Audit-ID", EmitDefaultValue=false)]
        public string AuditID { get; set; }

        /// <summary>
        /// Gets or Sets AuditLog
        /// </summary>
        [DataMember(Name="Audit-Log", EmitDefaultValue=false)]
        public string AuditLog { get; set; }

        /// <summary>
        /// Gets or Sets BookkeeperID
        /// </summary>
        [DataMember(Name="Bookkeeper-ID", EmitDefaultValue=false)]
        public string BookkeeperID { get; set; }

        /// <summary>
        /// Gets or Sets BookkeeperType
        /// </summary>
        [DataMember(Name="Bookkeeper-Type", EmitDefaultValue=false)]
        public string BookkeeperType { get; set; }

        /// <summary>
        /// Gets or Sets DryRun
        /// </summary>
        [DataMember(Name="Dry-Run", EmitDefaultValue=false)]
        public string DryRun { get; set; }



        /// <summary>
        /// Gets or Sets Invoice
        /// </summary>
        [DataMember(Name="Invoice", EmitDefaultValue=false)]
        public string Invoice { get; set; }

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
            sb.Append("class KapiBookkeepersUpdateReqDefinition {\n");
            sb.Append("  AccountID: ").Append(AccountID).Append("\n");
            sb.Append("  AuditID: ").Append(AuditID).Append("\n");
            sb.Append("  AuditLog: ").Append(AuditLog).Append("\n");
            sb.Append("  BookkeeperID: ").Append(BookkeeperID).Append("\n");
            sb.Append("  BookkeeperType: ").Append(BookkeeperType).Append("\n");
            sb.Append("  DryRun: ").Append(DryRun).Append("\n");
            sb.Append("  EventCategory: ").Append(EventCategory).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  Invoice: ").Append(Invoice).Append("\n");
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
            return this.Equals(input as KapiBookkeepersUpdateReqDefinition);
        }

        /// <summary>
        /// Returns true if KapiBookkeepersUpdateReqDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of KapiBookkeepersUpdateReqDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KapiBookkeepersUpdateReqDefinition input)
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
                    this.AuditID == input.AuditID ||
                    (this.AuditID != null &&
                    this.AuditID.Equals(input.AuditID))
                ) && 
                (
                    this.AuditLog == input.AuditLog ||
                    (this.AuditLog != null &&
                    this.AuditLog.Equals(input.AuditLog))
                ) && 
                (
                    this.BookkeeperID == input.BookkeeperID ||
                    (this.BookkeeperID != null &&
                    this.BookkeeperID.Equals(input.BookkeeperID))
                ) && 
                (
                    this.BookkeeperType == input.BookkeeperType ||
                    (this.BookkeeperType != null &&
                    this.BookkeeperType.Equals(input.BookkeeperType))
                ) && 
                (
                    this.DryRun == input.DryRun ||
                    (this.DryRun != null &&
                    this.DryRun.Equals(input.DryRun))
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
                    this.Invoice == input.Invoice ||
                    (this.Invoice != null &&
                    this.Invoice.Equals(input.Invoice))
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
                if (this.AuditID != null)
                    hashCode = hashCode * 59 + this.AuditID.GetHashCode();
                if (this.AuditLog != null)
                    hashCode = hashCode * 59 + this.AuditLog.GetHashCode();
                if (this.BookkeeperID != null)
                    hashCode = hashCode * 59 + this.BookkeeperID.GetHashCode();
                if (this.BookkeeperType != null)
                    hashCode = hashCode * 59 + this.BookkeeperType.GetHashCode();
                if (this.DryRun != null)
                    hashCode = hashCode * 59 + this.DryRun.GetHashCode();
                if (this.EventCategory != null)
                    hashCode = hashCode * 59 + this.EventCategory.GetHashCode();
                if (this.EventName != null)
                    hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.Invoice != null)
                    hashCode = hashCode * 59 + this.Invoice.GetHashCode();
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