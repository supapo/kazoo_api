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
    /// AMQP API for notifications.inbound_fax_error
    /// </summary>
    [DataContract]
    public partial class KapiNotificationsInboundFaxError :  IEquatable<KapiNotificationsInboundFaxError>, IValidatableObject
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
            /// Enum Inboundfaxerror for value: inbound_fax_error
            /// </summary>
            [EnumMember(Value = "inbound_fax_error")]
            Inboundfaxerror = 1
        }

        /// <summary>
        /// Gets or Sets EventName
        /// </summary>
        [DataMember(Name="Event-Name", EmitDefaultValue=false)]
        public EventNameEnum? EventName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiNotificationsInboundFaxError" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KapiNotificationsInboundFaxError() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiNotificationsInboundFaxError" /> class.
        /// </summary>
        /// <param name="accountDB">accountDB.</param>
        /// <param name="accountID">accountID (required).</param>
        /// <param name="attachmentURL">attachmentURL.</param>
        /// <param name="bcc">bcc.</param>
        /// <param name="callID">callID.</param>
        /// <param name="calleeIDName">calleeIDName.</param>
        /// <param name="calleeIDNumber">calleeIDNumber.</param>
        /// <param name="callerIDName">callerIDName.</param>
        /// <param name="callerIDNumber">callerIDNumber.</param>
        /// <param name="cc">cc.</param>
        /// <param name="eventCategory">eventCategory.</param>
        /// <param name="eventName">eventName.</param>
        /// <param name="faxError">faxError.</param>
        /// <param name="faxID">faxID.</param>
        /// <param name="faxInfo">faxInfo.</param>
        /// <param name="faxNotifications">faxNotifications.</param>
        /// <param name="faxResultCode">faxResultCode.</param>
        /// <param name="faxTimestamp">faxTimestamp.</param>
        /// <param name="faxBoxID">faxBoxID.</param>
        /// <param name="from">from.</param>
        /// <param name="fromRealm">fromRealm (required).</param>
        /// <param name="fromUser">fromUser (required).</param>
        /// <param name="hTML">hTML.</param>
        /// <param name="ownerID">ownerID.</param>
        /// <param name="preview">preview.</param>
        /// <param name="replyTo">replyTo.</param>
        /// <param name="subject">subject.</param>
        /// <param name="text">text.</param>
        /// <param name="to">to.</param>
        /// <param name="toRealm">toRealm (required).</param>
        /// <param name="toUser">toUser (required).</param>
        public KapiNotificationsInboundFaxError(string accountDB = default(string), string accountID = default(string), string attachmentURL = default(string), string bcc = default(string), string callID = default(string), string calleeIDName = default(string), string calleeIDNumber = default(string), string callerIDName = default(string), string callerIDNumber = default(string), string cc = default(string), EventCategoryEnum? eventCategory = default(EventCategoryEnum?), EventNameEnum? eventName = default(EventNameEnum?), string faxError = default(string), string faxID = default(string), string faxInfo = default(string), string faxNotifications = default(string), string faxResultCode = default(string), string faxTimestamp = default(string), string faxBoxID = default(string), string from = default(string), string fromRealm = default(string), string fromUser = default(string), string hTML = default(string), string ownerID = default(string), string preview = default(string), string replyTo = default(string), string subject = default(string), string text = default(string), string to = default(string), string toRealm = default(string), string toUser = default(string))
        {
            // to ensure "accountID" is required (not null)
            if (accountID == null)
            {
                throw new InvalidDataException("accountID is a required property for KapiNotificationsInboundFaxError and cannot be null");
            }
            else
            {
                this.AccountID = accountID;
            }
            // to ensure "fromRealm" is required (not null)
            if (fromRealm == null)
            {
                throw new InvalidDataException("fromRealm is a required property for KapiNotificationsInboundFaxError and cannot be null");
            }
            else
            {
                this.FromRealm = fromRealm;
            }
            // to ensure "fromUser" is required (not null)
            if (fromUser == null)
            {
                throw new InvalidDataException("fromUser is a required property for KapiNotificationsInboundFaxError and cannot be null");
            }
            else
            {
                this.FromUser = fromUser;
            }
            // to ensure "toRealm" is required (not null)
            if (toRealm == null)
            {
                throw new InvalidDataException("toRealm is a required property for KapiNotificationsInboundFaxError and cannot be null");
            }
            else
            {
                this.ToRealm = toRealm;
            }
            // to ensure "toUser" is required (not null)
            if (toUser == null)
            {
                throw new InvalidDataException("toUser is a required property for KapiNotificationsInboundFaxError and cannot be null");
            }
            else
            {
                this.ToUser = toUser;
            }
            this.AccountDB = accountDB;
            this.AttachmentURL = attachmentURL;
            this.Bcc = bcc;
            this.CallID = callID;
            this.CalleeIDName = calleeIDName;
            this.CalleeIDNumber = calleeIDNumber;
            this.CallerIDName = callerIDName;
            this.CallerIDNumber = callerIDNumber;
            this.Cc = cc;
            this.EventCategory = eventCategory;
            this.EventName = eventName;
            this.FaxError = faxError;
            this.FaxID = faxID;
            this.FaxInfo = faxInfo;
            this.FaxNotifications = faxNotifications;
            this.FaxResultCode = faxResultCode;
            this.FaxTimestamp = faxTimestamp;
            this.FaxBoxID = faxBoxID;
            this.From = from;
            this.HTML = hTML;
            this.OwnerID = ownerID;
            this.Preview = preview;
            this.ReplyTo = replyTo;
            this.Subject = subject;
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
        /// Gets or Sets CallID
        /// </summary>
        [DataMember(Name="Call-ID", EmitDefaultValue=false)]
        public string CallID { get; set; }

        /// <summary>
        /// Gets or Sets CalleeIDName
        /// </summary>
        [DataMember(Name="Callee-ID-Name", EmitDefaultValue=false)]
        public string CalleeIDName { get; set; }

        /// <summary>
        /// Gets or Sets CalleeIDNumber
        /// </summary>
        [DataMember(Name="Callee-ID-Number", EmitDefaultValue=false)]
        public string CalleeIDNumber { get; set; }

        /// <summary>
        /// Gets or Sets CallerIDName
        /// </summary>
        [DataMember(Name="Caller-ID-Name", EmitDefaultValue=false)]
        public string CallerIDName { get; set; }

        /// <summary>
        /// Gets or Sets CallerIDNumber
        /// </summary>
        [DataMember(Name="Caller-ID-Number", EmitDefaultValue=false)]
        public string CallerIDNumber { get; set; }

        /// <summary>
        /// Gets or Sets Cc
        /// </summary>
        [DataMember(Name="Cc", EmitDefaultValue=false)]
        public string Cc { get; set; }



        /// <summary>
        /// Gets or Sets FaxError
        /// </summary>
        [DataMember(Name="Fax-Error", EmitDefaultValue=false)]
        public string FaxError { get; set; }

        /// <summary>
        /// Gets or Sets FaxID
        /// </summary>
        [DataMember(Name="Fax-ID", EmitDefaultValue=false)]
        public string FaxID { get; set; }

        /// <summary>
        /// Gets or Sets FaxInfo
        /// </summary>
        [DataMember(Name="Fax-Info", EmitDefaultValue=false)]
        public string FaxInfo { get; set; }

        /// <summary>
        /// Gets or Sets FaxNotifications
        /// </summary>
        [DataMember(Name="Fax-Notifications", EmitDefaultValue=false)]
        public string FaxNotifications { get; set; }

        /// <summary>
        /// Gets or Sets FaxResultCode
        /// </summary>
        [DataMember(Name="Fax-Result-Code", EmitDefaultValue=false)]
        public string FaxResultCode { get; set; }

        /// <summary>
        /// Gets or Sets FaxTimestamp
        /// </summary>
        [DataMember(Name="Fax-Timestamp", EmitDefaultValue=false)]
        public string FaxTimestamp { get; set; }

        /// <summary>
        /// Gets or Sets FaxBoxID
        /// </summary>
        [DataMember(Name="FaxBox-ID", EmitDefaultValue=false)]
        public string FaxBoxID { get; set; }

        /// <summary>
        /// Gets or Sets From
        /// </summary>
        [DataMember(Name="From", EmitDefaultValue=false)]
        public string From { get; set; }

        /// <summary>
        /// Gets or Sets FromRealm
        /// </summary>
        [DataMember(Name="From-Realm", EmitDefaultValue=false)]
        public string FromRealm { get; set; }

        /// <summary>
        /// Gets or Sets FromUser
        /// </summary>
        [DataMember(Name="From-User", EmitDefaultValue=false)]
        public string FromUser { get; set; }

        /// <summary>
        /// Gets or Sets HTML
        /// </summary>
        [DataMember(Name="HTML", EmitDefaultValue=false)]
        public string HTML { get; set; }

        /// <summary>
        /// Gets or Sets OwnerID
        /// </summary>
        [DataMember(Name="Owner-ID", EmitDefaultValue=false)]
        public string OwnerID { get; set; }

        /// <summary>
        /// Gets or Sets Preview
        /// </summary>
        [DataMember(Name="Preview", EmitDefaultValue=false)]
        public string Preview { get; set; }

        /// <summary>
        /// Gets or Sets ReplyTo
        /// </summary>
        [DataMember(Name="Reply-To", EmitDefaultValue=false)]
        public string ReplyTo { get; set; }

        /// <summary>
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name="Subject", EmitDefaultValue=false)]
        public string Subject { get; set; }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name="Text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or Sets To
        /// </summary>
        [DataMember(Name="To", EmitDefaultValue=false)]
        public string To { get; set; }

        /// <summary>
        /// Gets or Sets ToRealm
        /// </summary>
        [DataMember(Name="To-Realm", EmitDefaultValue=false)]
        public string ToRealm { get; set; }

        /// <summary>
        /// Gets or Sets ToUser
        /// </summary>
        [DataMember(Name="To-User", EmitDefaultValue=false)]
        public string ToUser { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KapiNotificationsInboundFaxError {\n");
            sb.Append("  AccountDB: ").Append(AccountDB).Append("\n");
            sb.Append("  AccountID: ").Append(AccountID).Append("\n");
            sb.Append("  AttachmentURL: ").Append(AttachmentURL).Append("\n");
            sb.Append("  Bcc: ").Append(Bcc).Append("\n");
            sb.Append("  CallID: ").Append(CallID).Append("\n");
            sb.Append("  CalleeIDName: ").Append(CalleeIDName).Append("\n");
            sb.Append("  CalleeIDNumber: ").Append(CalleeIDNumber).Append("\n");
            sb.Append("  CallerIDName: ").Append(CallerIDName).Append("\n");
            sb.Append("  CallerIDNumber: ").Append(CallerIDNumber).Append("\n");
            sb.Append("  Cc: ").Append(Cc).Append("\n");
            sb.Append("  EventCategory: ").Append(EventCategory).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  FaxError: ").Append(FaxError).Append("\n");
            sb.Append("  FaxID: ").Append(FaxID).Append("\n");
            sb.Append("  FaxInfo: ").Append(FaxInfo).Append("\n");
            sb.Append("  FaxNotifications: ").Append(FaxNotifications).Append("\n");
            sb.Append("  FaxResultCode: ").Append(FaxResultCode).Append("\n");
            sb.Append("  FaxTimestamp: ").Append(FaxTimestamp).Append("\n");
            sb.Append("  FaxBoxID: ").Append(FaxBoxID).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  FromRealm: ").Append(FromRealm).Append("\n");
            sb.Append("  FromUser: ").Append(FromUser).Append("\n");
            sb.Append("  HTML: ").Append(HTML).Append("\n");
            sb.Append("  OwnerID: ").Append(OwnerID).Append("\n");
            sb.Append("  Preview: ").Append(Preview).Append("\n");
            sb.Append("  ReplyTo: ").Append(ReplyTo).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  ToRealm: ").Append(ToRealm).Append("\n");
            sb.Append("  ToUser: ").Append(ToUser).Append("\n");
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
            return this.Equals(input as KapiNotificationsInboundFaxError);
        }

        /// <summary>
        /// Returns true if KapiNotificationsInboundFaxError instances are equal
        /// </summary>
        /// <param name="input">Instance of KapiNotificationsInboundFaxError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KapiNotificationsInboundFaxError input)
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
                    this.CallID == input.CallID ||
                    (this.CallID != null &&
                    this.CallID.Equals(input.CallID))
                ) && 
                (
                    this.CalleeIDName == input.CalleeIDName ||
                    (this.CalleeIDName != null &&
                    this.CalleeIDName.Equals(input.CalleeIDName))
                ) && 
                (
                    this.CalleeIDNumber == input.CalleeIDNumber ||
                    (this.CalleeIDNumber != null &&
                    this.CalleeIDNumber.Equals(input.CalleeIDNumber))
                ) && 
                (
                    this.CallerIDName == input.CallerIDName ||
                    (this.CallerIDName != null &&
                    this.CallerIDName.Equals(input.CallerIDName))
                ) && 
                (
                    this.CallerIDNumber == input.CallerIDNumber ||
                    (this.CallerIDNumber != null &&
                    this.CallerIDNumber.Equals(input.CallerIDNumber))
                ) && 
                (
                    this.Cc == input.Cc ||
                    (this.Cc != null &&
                    this.Cc.Equals(input.Cc))
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
                    this.FaxError == input.FaxError ||
                    (this.FaxError != null &&
                    this.FaxError.Equals(input.FaxError))
                ) && 
                (
                    this.FaxID == input.FaxID ||
                    (this.FaxID != null &&
                    this.FaxID.Equals(input.FaxID))
                ) && 
                (
                    this.FaxInfo == input.FaxInfo ||
                    (this.FaxInfo != null &&
                    this.FaxInfo.Equals(input.FaxInfo))
                ) && 
                (
                    this.FaxNotifications == input.FaxNotifications ||
                    (this.FaxNotifications != null &&
                    this.FaxNotifications.Equals(input.FaxNotifications))
                ) && 
                (
                    this.FaxResultCode == input.FaxResultCode ||
                    (this.FaxResultCode != null &&
                    this.FaxResultCode.Equals(input.FaxResultCode))
                ) && 
                (
                    this.FaxTimestamp == input.FaxTimestamp ||
                    (this.FaxTimestamp != null &&
                    this.FaxTimestamp.Equals(input.FaxTimestamp))
                ) && 
                (
                    this.FaxBoxID == input.FaxBoxID ||
                    (this.FaxBoxID != null &&
                    this.FaxBoxID.Equals(input.FaxBoxID))
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.FromRealm == input.FromRealm ||
                    (this.FromRealm != null &&
                    this.FromRealm.Equals(input.FromRealm))
                ) && 
                (
                    this.FromUser == input.FromUser ||
                    (this.FromUser != null &&
                    this.FromUser.Equals(input.FromUser))
                ) && 
                (
                    this.HTML == input.HTML ||
                    (this.HTML != null &&
                    this.HTML.Equals(input.HTML))
                ) && 
                (
                    this.OwnerID == input.OwnerID ||
                    (this.OwnerID != null &&
                    this.OwnerID.Equals(input.OwnerID))
                ) && 
                (
                    this.Preview == input.Preview ||
                    (this.Preview != null &&
                    this.Preview.Equals(input.Preview))
                ) && 
                (
                    this.ReplyTo == input.ReplyTo ||
                    (this.ReplyTo != null &&
                    this.ReplyTo.Equals(input.ReplyTo))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.ToRealm == input.ToRealm ||
                    (this.ToRealm != null &&
                    this.ToRealm.Equals(input.ToRealm))
                ) && 
                (
                    this.ToUser == input.ToUser ||
                    (this.ToUser != null &&
                    this.ToUser.Equals(input.ToUser))
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
                if (this.AttachmentURL != null)
                    hashCode = hashCode * 59 + this.AttachmentURL.GetHashCode();
                if (this.Bcc != null)
                    hashCode = hashCode * 59 + this.Bcc.GetHashCode();
                if (this.CallID != null)
                    hashCode = hashCode * 59 + this.CallID.GetHashCode();
                if (this.CalleeIDName != null)
                    hashCode = hashCode * 59 + this.CalleeIDName.GetHashCode();
                if (this.CalleeIDNumber != null)
                    hashCode = hashCode * 59 + this.CalleeIDNumber.GetHashCode();
                if (this.CallerIDName != null)
                    hashCode = hashCode * 59 + this.CallerIDName.GetHashCode();
                if (this.CallerIDNumber != null)
                    hashCode = hashCode * 59 + this.CallerIDNumber.GetHashCode();
                if (this.Cc != null)
                    hashCode = hashCode * 59 + this.Cc.GetHashCode();
                if (this.EventCategory != null)
                    hashCode = hashCode * 59 + this.EventCategory.GetHashCode();
                if (this.EventName != null)
                    hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.FaxError != null)
                    hashCode = hashCode * 59 + this.FaxError.GetHashCode();
                if (this.FaxID != null)
                    hashCode = hashCode * 59 + this.FaxID.GetHashCode();
                if (this.FaxInfo != null)
                    hashCode = hashCode * 59 + this.FaxInfo.GetHashCode();
                if (this.FaxNotifications != null)
                    hashCode = hashCode * 59 + this.FaxNotifications.GetHashCode();
                if (this.FaxResultCode != null)
                    hashCode = hashCode * 59 + this.FaxResultCode.GetHashCode();
                if (this.FaxTimestamp != null)
                    hashCode = hashCode * 59 + this.FaxTimestamp.GetHashCode();
                if (this.FaxBoxID != null)
                    hashCode = hashCode * 59 + this.FaxBoxID.GetHashCode();
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.FromRealm != null)
                    hashCode = hashCode * 59 + this.FromRealm.GetHashCode();
                if (this.FromUser != null)
                    hashCode = hashCode * 59 + this.FromUser.GetHashCode();
                if (this.HTML != null)
                    hashCode = hashCode * 59 + this.HTML.GetHashCode();
                if (this.OwnerID != null)
                    hashCode = hashCode * 59 + this.OwnerID.GetHashCode();
                if (this.Preview != null)
                    hashCode = hashCode * 59 + this.Preview.GetHashCode();
                if (this.ReplyTo != null)
                    hashCode = hashCode * 59 + this.ReplyTo.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.ToRealm != null)
                    hashCode = hashCode * 59 + this.ToRealm.GetHashCode();
                if (this.ToUser != null)
                    hashCode = hashCode * 59 + this.ToUser.GetHashCode();
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
