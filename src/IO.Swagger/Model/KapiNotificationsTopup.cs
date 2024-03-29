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
    /// AMQP API for notifications.topup
    /// </summary>
    [DataContract]
    public partial class KapiNotificationsTopup :  IEquatable<KapiNotificationsTopup>, IValidatableObject
    {
        /// <summary>
        /// Defines EventCategory
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventCategoryEnum
        {
            
            /// <summary>
            /// Enum Notification for value: notification
            /// </summary>
            [EnumMember(Value = "notification")]
            Notification = 1
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
            /// Enum Topup for value: topup
            /// </summary>
            [EnumMember(Value = "topup")]
            Topup = 1
        }

        /// <summary>
        /// Gets or Sets EventName
        /// </summary>
        [DataMember(Name="Event-Name", EmitDefaultValue=false)]
        public EventNameEnum? EventName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiNotificationsTopup" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KapiNotificationsTopup() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiNotificationsTopup" /> class.
        /// </summary>
        /// <param name="accountDB">accountDB.</param>
        /// <param name="accountID">accountID (required).</param>
        /// <param name="addOns">addOns.</param>
        /// <param name="amount">amount (required).</param>
        /// <param name="attachmentURL">attachmentURL.</param>
        /// <param name="bcc">bcc.</param>
        /// <param name="billingAddress">billingAddress.</param>
        /// <param name="cardLastFour">cardLastFour.</param>
        /// <param name="cc">cc.</param>
        /// <param name="currencyCode">currencyCode.</param>
        /// <param name="discounts">discounts.</param>
        /// <param name="eventCategory">eventCategory.</param>
        /// <param name="eventName">eventName.</param>
        /// <param name="from">from.</param>
        /// <param name="hTML">hTML.</param>
        /// <param name="iD">iD.</param>
        /// <param name="preview">preview.</param>
        /// <param name="purchaseOrder">purchaseOrder.</param>
        /// <param name="replyTo">replyTo.</param>
        /// <param name="response">response (required).</param>
        /// <param name="subject">subject.</param>
        /// <param name="success">success (required).</param>
        /// <param name="taxAmount">taxAmount.</param>
        /// <param name="text">text.</param>
        /// <param name="timestamp">timestamp (required).</param>
        /// <param name="to">to.</param>
        public KapiNotificationsTopup(string accountDB = default(string), string accountID = default(string), string addOns = default(string), string amount = default(string), string attachmentURL = default(string), string bcc = default(string), string billingAddress = default(string), string cardLastFour = default(string), string cc = default(string), string currencyCode = default(string), string discounts = default(string), EventCategoryEnum? eventCategory = default(EventCategoryEnum?), EventNameEnum? eventName = default(EventNameEnum?), string from = default(string), string hTML = default(string), string iD = default(string), string preview = default(string), string purchaseOrder = default(string), string replyTo = default(string), string response = default(string), string subject = default(string), string success = default(string), string taxAmount = default(string), string text = default(string), string timestamp = default(string), string to = default(string))
        {
            // to ensure "accountID" is required (not null)
            if (accountID == null)
            {
                throw new InvalidDataException("accountID is a required property for KapiNotificationsTopup and cannot be null");
            }
            else
            {
                this.AccountID = accountID;
            }
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new InvalidDataException("amount is a required property for KapiNotificationsTopup and cannot be null");
            }
            else
            {
                this.Amount = amount;
            }
            // to ensure "response" is required (not null)
            if (response == null)
            {
                throw new InvalidDataException("response is a required property for KapiNotificationsTopup and cannot be null");
            }
            else
            {
                this.Response = response;
            }
            // to ensure "success" is required (not null)
            if (success == null)
            {
                throw new InvalidDataException("success is a required property for KapiNotificationsTopup and cannot be null");
            }
            else
            {
                this.Success = success;
            }
            // to ensure "timestamp" is required (not null)
            if (timestamp == null)
            {
                throw new InvalidDataException("timestamp is a required property for KapiNotificationsTopup and cannot be null");
            }
            else
            {
                this.Timestamp = timestamp;
            }
            this.AccountDB = accountDB;
            this.AddOns = addOns;
            this.AttachmentURL = attachmentURL;
            this.Bcc = bcc;
            this.BillingAddress = billingAddress;
            this.CardLastFour = cardLastFour;
            this.Cc = cc;
            this.CurrencyCode = currencyCode;
            this.Discounts = discounts;
            this.EventCategory = eventCategory;
            this.EventName = eventName;
            this.From = from;
            this.HTML = hTML;
            this.ID = iD;
            this.Preview = preview;
            this.PurchaseOrder = purchaseOrder;
            this.ReplyTo = replyTo;
            this.Subject = subject;
            this.TaxAmount = taxAmount;
            this.Text = text;
            this.To = to;
        }
        
        /// <summary>
        /// Gets or Sets AccountDB
        /// </summary>
        [DataMember(Name="Account-DB", EmitDefaultValue=false)]
        public string AccountDB { get; set; }

        /// <summary>
        /// Gets or Sets AccountID
        /// </summary>
        [DataMember(Name="Account-ID", EmitDefaultValue=false)]
        public string AccountID { get; set; }

        /// <summary>
        /// Gets or Sets AddOns
        /// </summary>
        [DataMember(Name="Add-Ons", EmitDefaultValue=false)]
        public string AddOns { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="Amount", EmitDefaultValue=false)]
        public string Amount { get; set; }

        /// <summary>
        /// Gets or Sets AttachmentURL
        /// </summary>
        [DataMember(Name="Attachment-URL", EmitDefaultValue=false)]
        public string AttachmentURL { get; set; }

        /// <summary>
        /// Gets or Sets Bcc
        /// </summary>
        [DataMember(Name="Bcc", EmitDefaultValue=false)]
        public string Bcc { get; set; }

        /// <summary>
        /// Gets or Sets BillingAddress
        /// </summary>
        [DataMember(Name="Billing-Address", EmitDefaultValue=false)]
        public string BillingAddress { get; set; }

        /// <summary>
        /// Gets or Sets CardLastFour
        /// </summary>
        [DataMember(Name="Card-Last-Four", EmitDefaultValue=false)]
        public string CardLastFour { get; set; }

        /// <summary>
        /// Gets or Sets Cc
        /// </summary>
        [DataMember(Name="Cc", EmitDefaultValue=false)]
        public string Cc { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyCode
        /// </summary>
        [DataMember(Name="Currency-Code", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Gets or Sets Discounts
        /// </summary>
        [DataMember(Name="Discounts", EmitDefaultValue=false)]
        public string Discounts { get; set; }



        /// <summary>
        /// Gets or Sets From
        /// </summary>
        [DataMember(Name="From", EmitDefaultValue=false)]
        public string From { get; set; }

        /// <summary>
        /// Gets or Sets HTML
        /// </summary>
        [DataMember(Name="HTML", EmitDefaultValue=false)]
        public string HTML { get; set; }

        /// <summary>
        /// Gets or Sets ID
        /// </summary>
        [DataMember(Name="ID", EmitDefaultValue=false)]
        public string ID { get; set; }

        /// <summary>
        /// Gets or Sets Preview
        /// </summary>
        [DataMember(Name="Preview", EmitDefaultValue=false)]
        public string Preview { get; set; }

        /// <summary>
        /// Gets or Sets PurchaseOrder
        /// </summary>
        [DataMember(Name="Purchase-Order", EmitDefaultValue=false)]
        public string PurchaseOrder { get; set; }

        /// <summary>
        /// Gets or Sets ReplyTo
        /// </summary>
        [DataMember(Name="Reply-To", EmitDefaultValue=false)]
        public string ReplyTo { get; set; }

        /// <summary>
        /// Gets or Sets Response
        /// </summary>
        [DataMember(Name="Response", EmitDefaultValue=false)]
        public string Response { get; set; }

        /// <summary>
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name="Subject", EmitDefaultValue=false)]
        public string Subject { get; set; }

        /// <summary>
        /// Gets or Sets Success
        /// </summary>
        [DataMember(Name="Success", EmitDefaultValue=false)]
        public string Success { get; set; }

        /// <summary>
        /// Gets or Sets TaxAmount
        /// </summary>
        [DataMember(Name="Tax-Amount", EmitDefaultValue=false)]
        public string TaxAmount { get; set; }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name="Text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name="Timestamp", EmitDefaultValue=false)]
        public string Timestamp { get; set; }

        /// <summary>
        /// Gets or Sets To
        /// </summary>
        [DataMember(Name="To", EmitDefaultValue=false)]
        public string To { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KapiNotificationsTopup {\n");
            sb.Append("  AccountDB: ").Append(AccountDB).Append("\n");
            sb.Append("  AccountID: ").Append(AccountID).Append("\n");
            sb.Append("  AddOns: ").Append(AddOns).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  AttachmentURL: ").Append(AttachmentURL).Append("\n");
            sb.Append("  Bcc: ").Append(Bcc).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  CardLastFour: ").Append(CardLastFour).Append("\n");
            sb.Append("  Cc: ").Append(Cc).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  Discounts: ").Append(Discounts).Append("\n");
            sb.Append("  EventCategory: ").Append(EventCategory).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  HTML: ").Append(HTML).Append("\n");
            sb.Append("  ID: ").Append(ID).Append("\n");
            sb.Append("  Preview: ").Append(Preview).Append("\n");
            sb.Append("  PurchaseOrder: ").Append(PurchaseOrder).Append("\n");
            sb.Append("  ReplyTo: ").Append(ReplyTo).Append("\n");
            sb.Append("  Response: ").Append(Response).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
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
            return this.Equals(input as KapiNotificationsTopup);
        }

        /// <summary>
        /// Returns true if KapiNotificationsTopup instances are equal
        /// </summary>
        /// <param name="input">Instance of KapiNotificationsTopup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KapiNotificationsTopup input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountDB == input.AccountDB ||
                    (this.AccountDB != null &&
                    this.AccountDB.Equals(input.AccountDB))
                ) && 
                (
                    this.AccountID == input.AccountID ||
                    (this.AccountID != null &&
                    this.AccountID.Equals(input.AccountID))
                ) && 
                (
                    this.AddOns == input.AddOns ||
                    (this.AddOns != null &&
                    this.AddOns.Equals(input.AddOns))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.AttachmentURL == input.AttachmentURL ||
                    (this.AttachmentURL != null &&
                    this.AttachmentURL.Equals(input.AttachmentURL))
                ) && 
                (
                    this.Bcc == input.Bcc ||
                    (this.Bcc != null &&
                    this.Bcc.Equals(input.Bcc))
                ) && 
                (
                    this.BillingAddress == input.BillingAddress ||
                    (this.BillingAddress != null &&
                    this.BillingAddress.Equals(input.BillingAddress))
                ) && 
                (
                    this.CardLastFour == input.CardLastFour ||
                    (this.CardLastFour != null &&
                    this.CardLastFour.Equals(input.CardLastFour))
                ) && 
                (
                    this.Cc == input.Cc ||
                    (this.Cc != null &&
                    this.Cc.Equals(input.Cc))
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
                ) && 
                (
                    this.Discounts == input.Discounts ||
                    (this.Discounts != null &&
                    this.Discounts.Equals(input.Discounts))
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
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.HTML == input.HTML ||
                    (this.HTML != null &&
                    this.HTML.Equals(input.HTML))
                ) && 
                (
                    this.ID == input.ID ||
                    (this.ID != null &&
                    this.ID.Equals(input.ID))
                ) && 
                (
                    this.Preview == input.Preview ||
                    (this.Preview != null &&
                    this.Preview.Equals(input.Preview))
                ) && 
                (
                    this.PurchaseOrder == input.PurchaseOrder ||
                    (this.PurchaseOrder != null &&
                    this.PurchaseOrder.Equals(input.PurchaseOrder))
                ) && 
                (
                    this.ReplyTo == input.ReplyTo ||
                    (this.ReplyTo != null &&
                    this.ReplyTo.Equals(input.ReplyTo))
                ) && 
                (
                    this.Response == input.Response ||
                    (this.Response != null &&
                    this.Response.Equals(input.Response))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.Success == input.Success ||
                    (this.Success != null &&
                    this.Success.Equals(input.Success))
                ) && 
                (
                    this.TaxAmount == input.TaxAmount ||
                    (this.TaxAmount != null &&
                    this.TaxAmount.Equals(input.TaxAmount))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
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
                if (this.AccountDB != null)
                    hashCode = hashCode * 59 + this.AccountDB.GetHashCode();
                if (this.AccountID != null)
                    hashCode = hashCode * 59 + this.AccountID.GetHashCode();
                if (this.AddOns != null)
                    hashCode = hashCode * 59 + this.AddOns.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.AttachmentURL != null)
                    hashCode = hashCode * 59 + this.AttachmentURL.GetHashCode();
                if (this.Bcc != null)
                    hashCode = hashCode * 59 + this.Bcc.GetHashCode();
                if (this.BillingAddress != null)
                    hashCode = hashCode * 59 + this.BillingAddress.GetHashCode();
                if (this.CardLastFour != null)
                    hashCode = hashCode * 59 + this.CardLastFour.GetHashCode();
                if (this.Cc != null)
                    hashCode = hashCode * 59 + this.Cc.GetHashCode();
                if (this.CurrencyCode != null)
                    hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                if (this.Discounts != null)
                    hashCode = hashCode * 59 + this.Discounts.GetHashCode();
                if (this.EventCategory != null)
                    hashCode = hashCode * 59 + this.EventCategory.GetHashCode();
                if (this.EventName != null)
                    hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.HTML != null)
                    hashCode = hashCode * 59 + this.HTML.GetHashCode();
                if (this.ID != null)
                    hashCode = hashCode * 59 + this.ID.GetHashCode();
                if (this.Preview != null)
                    hashCode = hashCode * 59 + this.Preview.GetHashCode();
                if (this.PurchaseOrder != null)
                    hashCode = hashCode * 59 + this.PurchaseOrder.GetHashCode();
                if (this.ReplyTo != null)
                    hashCode = hashCode * 59 + this.ReplyTo.GetHashCode();
                if (this.Response != null)
                    hashCode = hashCode * 59 + this.Response.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.Success != null)
                    hashCode = hashCode * 59 + this.Success.GetHashCode();
                if (this.TaxAmount != null)
                    hashCode = hashCode * 59 + this.TaxAmount.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
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
