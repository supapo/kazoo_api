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
    /// AMQP API for notifications.denied_emergency_bridge
    /// </summary>
    [DataContract]
    public partial class KapiNotificationsDeniedEmergencyBridge :  IEquatable<KapiNotificationsDeniedEmergencyBridge>, IValidatableObject
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
            /// Enum Deniedemergencybridge for value: denied_emergency_bridge
            /// </summary>
            [EnumMember(Value = "denied_emergency_bridge")]
            Deniedemergencybridge = 1
        }

        /// <summary>
        /// Gets or Sets EventName
        /// </summary>
        [DataMember(Name="Event-Name", EmitDefaultValue=false)]
        public EventNameEnum? EventName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiNotificationsDeniedEmergencyBridge" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KapiNotificationsDeniedEmergencyBridge() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiNotificationsDeniedEmergencyBridge" /> class.
        /// </summary>
        /// <param name="accountDB">accountDB.</param>
        /// <param name="accountID">accountID (required).</param>
        /// <param name="attachmentURL">attachmentURL.</param>
        /// <param name="bcc">bcc.</param>
        /// <param name="callID">callID (required).</param>
        /// <param name="cc">cc.</param>
        /// <param name="emergencyCallerIDName">emergencyCallerIDName.</param>
        /// <param name="emergencyCallerIDNumber">emergencyCallerIDNumber.</param>
        /// <param name="eventCategory">eventCategory.</param>
        /// <param name="eventName">eventName.</param>
        /// <param name="from">from.</param>
        /// <param name="hTML">hTML.</param>
        /// <param name="outboundCallerIDName">outboundCallerIDName.</param>
        /// <param name="outboundCallerIDNumber">outboundCallerIDNumber.</param>
        /// <param name="preview">preview.</param>
        /// <param name="replyTo">replyTo.</param>
        /// <param name="subject">subject.</param>
        /// <param name="text">text.</param>
        /// <param name="to">to.</param>
        public KapiNotificationsDeniedEmergencyBridge(string accountDB = default(string), string accountID = default(string), string attachmentURL = default(string), string bcc = default(string), string callID = default(string), string cc = default(string), string emergencyCallerIDName = default(string), string emergencyCallerIDNumber = default(string), EventCategoryEnum? eventCategory = default(EventCategoryEnum?), EventNameEnum? eventName = default(EventNameEnum?), string from = default(string), string hTML = default(string), string outboundCallerIDName = default(string), string outboundCallerIDNumber = default(string), string preview = default(string), string replyTo = default(string), string subject = default(string), string text = default(string), string to = default(string))
        {
            // to ensure "accountID" is required (not null)
            if (accountID == null)
            {
                throw new InvalidDataException("accountID is a required property for KapiNotificationsDeniedEmergencyBridge and cannot be null");
            }
            else
            {
                this.AccountID = accountID;
            }
            // to ensure "callID" is required (not null)
            if (callID == null)
            {
                throw new InvalidDataException("callID is a required property for KapiNotificationsDeniedEmergencyBridge and cannot be null");
            }
            else
            {
                this.CallID = callID;
            }
            this.AccountDB = accountDB;
            this.AttachmentURL = attachmentURL;
            this.Bcc = bcc;
            this.Cc = cc;
            this.EmergencyCallerIDName = emergencyCallerIDName;
            this.EmergencyCallerIDNumber = emergencyCallerIDNumber;
            this.EventCategory = eventCategory;
            this.EventName = eventName;
            this.From = from;
            this.HTML = hTML;
            this.OutboundCallerIDName = outboundCallerIDName;
            this.OutboundCallerIDNumber = outboundCallerIDNumber;
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
        /// Gets or Sets Cc
        /// </summary>
        [DataMember(Name="Cc", EmitDefaultValue=false)]
        public string Cc { get; set; }

        /// <summary>
        /// Gets or Sets EmergencyCallerIDName
        /// </summary>
        [DataMember(Name="Emergency-Caller-ID-Name", EmitDefaultValue=false)]
        public string EmergencyCallerIDName { get; set; }

        /// <summary>
        /// Gets or Sets EmergencyCallerIDNumber
        /// </summary>
        [DataMember(Name="Emergency-Caller-ID-Number", EmitDefaultValue=false)]
        public string EmergencyCallerIDNumber { get; set; }



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
        /// Gets or Sets OutboundCallerIDName
        /// </summary>
        [DataMember(Name="Outbound-Caller-ID-Name", EmitDefaultValue=false)]
        public string OutboundCallerIDName { get; set; }

        /// <summary>
        /// Gets or Sets OutboundCallerIDNumber
        /// </summary>
        [DataMember(Name="Outbound-Caller-ID-Number", EmitDefaultValue=false)]
        public string OutboundCallerIDNumber { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KapiNotificationsDeniedEmergencyBridge {\n");
            sb.Append("  AccountDB: ").Append(AccountDB).Append("\n");
            sb.Append("  AccountID: ").Append(AccountID).Append("\n");
            sb.Append("  AttachmentURL: ").Append(AttachmentURL).Append("\n");
            sb.Append("  Bcc: ").Append(Bcc).Append("\n");
            sb.Append("  CallID: ").Append(CallID).Append("\n");
            sb.Append("  Cc: ").Append(Cc).Append("\n");
            sb.Append("  EmergencyCallerIDName: ").Append(EmergencyCallerIDName).Append("\n");
            sb.Append("  EmergencyCallerIDNumber: ").Append(EmergencyCallerIDNumber).Append("\n");
            sb.Append("  EventCategory: ").Append(EventCategory).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  HTML: ").Append(HTML).Append("\n");
            sb.Append("  OutboundCallerIDName: ").Append(OutboundCallerIDName).Append("\n");
            sb.Append("  OutboundCallerIDNumber: ").Append(OutboundCallerIDNumber).Append("\n");
            sb.Append("  Preview: ").Append(Preview).Append("\n");
            sb.Append("  ReplyTo: ").Append(ReplyTo).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
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
            return this.Equals(input as KapiNotificationsDeniedEmergencyBridge);
        }

        /// <summary>
        /// Returns true if KapiNotificationsDeniedEmergencyBridge instances are equal
        /// </summary>
        /// <param name="input">Instance of KapiNotificationsDeniedEmergencyBridge to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KapiNotificationsDeniedEmergencyBridge input)
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
                    this.Cc == input.Cc ||
                    (this.Cc != null &&
                    this.Cc.Equals(input.Cc))
                ) && 
                (
                    this.EmergencyCallerIDName == input.EmergencyCallerIDName ||
                    (this.EmergencyCallerIDName != null &&
                    this.EmergencyCallerIDName.Equals(input.EmergencyCallerIDName))
                ) && 
                (
                    this.EmergencyCallerIDNumber == input.EmergencyCallerIDNumber ||
                    (this.EmergencyCallerIDNumber != null &&
                    this.EmergencyCallerIDNumber.Equals(input.EmergencyCallerIDNumber))
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
                    this.OutboundCallerIDName == input.OutboundCallerIDName ||
                    (this.OutboundCallerIDName != null &&
                    this.OutboundCallerIDName.Equals(input.OutboundCallerIDName))
                ) && 
                (
                    this.OutboundCallerIDNumber == input.OutboundCallerIDNumber ||
                    (this.OutboundCallerIDNumber != null &&
                    this.OutboundCallerIDNumber.Equals(input.OutboundCallerIDNumber))
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
                if (this.Cc != null)
                    hashCode = hashCode * 59 + this.Cc.GetHashCode();
                if (this.EmergencyCallerIDName != null)
                    hashCode = hashCode * 59 + this.EmergencyCallerIDName.GetHashCode();
                if (this.EmergencyCallerIDNumber != null)
                    hashCode = hashCode * 59 + this.EmergencyCallerIDNumber.GetHashCode();
                if (this.EventCategory != null)
                    hashCode = hashCode * 59 + this.EventCategory.GetHashCode();
                if (this.EventName != null)
                    hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.HTML != null)
                    hashCode = hashCode * 59 + this.HTML.GetHashCode();
                if (this.OutboundCallerIDName != null)
                    hashCode = hashCode * 59 + this.OutboundCallerIDName.GetHashCode();
                if (this.OutboundCallerIDNumber != null)
                    hashCode = hashCode * 59 + this.OutboundCallerIDNumber.GetHashCode();
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
