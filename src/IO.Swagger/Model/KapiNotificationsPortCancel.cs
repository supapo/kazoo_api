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
    /// AMQP API for notifications.port_cancel
    /// </summary>
    [DataContract]
    public partial class KapiNotificationsPortCancel :  IEquatable<KapiNotificationsPortCancel>, IValidatableObject
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
            /// Enum Portcancel for value: port_cancel
            /// </summary>
            [EnumMember(Value = "port_cancel")]
            Portcancel = 1
        }

        /// <summary>
        /// Gets or Sets EventName
        /// </summary>
        [DataMember(Name="Event-Name", EmitDefaultValue=false)]
        public EventNameEnum? EventName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiNotificationsPortCancel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KapiNotificationsPortCancel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiNotificationsPortCancel" /> class.
        /// </summary>
        /// <param name="accountDB">accountDB.</param>
        /// <param name="accountID">accountID (required).</param>
        /// <param name="attachmentURL">attachmentURL.</param>
        /// <param name="authorizedBy">authorizedBy.</param>
        /// <param name="bcc">bcc.</param>
        /// <param name="cc">cc.</param>
        /// <param name="eventCategory">eventCategory.</param>
        /// <param name="eventName">eventName.</param>
        /// <param name="from">from.</param>
        /// <param name="hTML">hTML.</param>
        /// <param name="localNumber">localNumber.</param>
        /// <param name="number">number.</param>
        /// <param name="numberState">numberState.</param>
        /// <param name="port">port.</param>
        /// <param name="portRequestID">portRequestID.</param>
        /// <param name="preview">preview.</param>
        /// <param name="reason">reason.</param>
        /// <param name="replyTo">replyTo.</param>
        /// <param name="subject">subject.</param>
        /// <param name="text">text.</param>
        /// <param name="to">to.</param>
        /// <param name="version">version.</param>
        public KapiNotificationsPortCancel(string accountDB = default(string), string accountID = default(string), string attachmentURL = default(string), string authorizedBy = default(string), string bcc = default(string), string cc = default(string), EventCategoryEnum? eventCategory = default(EventCategoryEnum?), EventNameEnum? eventName = default(EventNameEnum?), string from = default(string), string hTML = default(string), string localNumber = default(string), string number = default(string), string numberState = default(string), string port = default(string), string portRequestID = default(string), string preview = default(string), Object reason = default(Object), string replyTo = default(string), string subject = default(string), string text = default(string), string to = default(string), string version = default(string))
        {
            // to ensure "accountID" is required (not null)
            if (accountID == null)
            {
                throw new InvalidDataException("accountID is a required property for KapiNotificationsPortCancel and cannot be null");
            }
            else
            {
                this.AccountID = accountID;
            }
            this.AccountDB = accountDB;
            this.AttachmentURL = attachmentURL;
            this.AuthorizedBy = authorizedBy;
            this.Bcc = bcc;
            this.Cc = cc;
            this.EventCategory = eventCategory;
            this.EventName = eventName;
            this.From = from;
            this.HTML = hTML;
            this.LocalNumber = localNumber;
            this.Number = number;
            this.NumberState = numberState;
            this.Port = port;
            this.PortRequestID = portRequestID;
            this.Preview = preview;
            this.Reason = reason;
            this.ReplyTo = replyTo;
            this.Subject = subject;
            this.Text = text;
            this.To = to;
            this.Version = version;
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
        /// Gets or Sets AuthorizedBy
        /// </summary>
        [DataMember(Name="Authorized-By", EmitDefaultValue=false)]
        public string AuthorizedBy { get; set; }

        /// <summary>
        /// Gets or Sets Bcc
        /// </summary>
        [DataMember(Name="Bcc", EmitDefaultValue=false)]
        public string Bcc { get; set; }

        /// <summary>
        /// Gets or Sets Cc
        /// </summary>
        [DataMember(Name="Cc", EmitDefaultValue=false)]
        public string Cc { get; set; }



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
        /// Gets or Sets LocalNumber
        /// </summary>
        [DataMember(Name="Local-Number", EmitDefaultValue=false)]
        public string LocalNumber { get; set; }

        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name="Number", EmitDefaultValue=false)]
        public string Number { get; set; }

        /// <summary>
        /// Gets or Sets NumberState
        /// </summary>
        [DataMember(Name="Number-State", EmitDefaultValue=false)]
        public string NumberState { get; set; }

        /// <summary>
        /// Gets or Sets Port
        /// </summary>
        [DataMember(Name="Port", EmitDefaultValue=false)]
        public string Port { get; set; }

        /// <summary>
        /// Gets or Sets PortRequestID
        /// </summary>
        [DataMember(Name="Port-Request-ID", EmitDefaultValue=false)]
        public string PortRequestID { get; set; }

        /// <summary>
        /// Gets or Sets Preview
        /// </summary>
        [DataMember(Name="Preview", EmitDefaultValue=false)]
        public string Preview { get; set; }

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name="Reason", EmitDefaultValue=false)]
        public Object Reason { get; set; }

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
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="Version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KapiNotificationsPortCancel {\n");
            sb.Append("  AccountDB: ").Append(AccountDB).Append("\n");
            sb.Append("  AccountID: ").Append(AccountID).Append("\n");
            sb.Append("  AttachmentURL: ").Append(AttachmentURL).Append("\n");
            sb.Append("  AuthorizedBy: ").Append(AuthorizedBy).Append("\n");
            sb.Append("  Bcc: ").Append(Bcc).Append("\n");
            sb.Append("  Cc: ").Append(Cc).Append("\n");
            sb.Append("  EventCategory: ").Append(EventCategory).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  HTML: ").Append(HTML).Append("\n");
            sb.Append("  LocalNumber: ").Append(LocalNumber).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  NumberState: ").Append(NumberState).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
            sb.Append("  PortRequestID: ").Append(PortRequestID).Append("\n");
            sb.Append("  Preview: ").Append(Preview).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  ReplyTo: ").Append(ReplyTo).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(input as KapiNotificationsPortCancel);
        }

        /// <summary>
        /// Returns true if KapiNotificationsPortCancel instances are equal
        /// </summary>
        /// <param name="input">Instance of KapiNotificationsPortCancel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KapiNotificationsPortCancel input)
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
                    this.AuthorizedBy == input.AuthorizedBy ||
                    (this.AuthorizedBy != null &&
                    this.AuthorizedBy.Equals(input.AuthorizedBy))
                ) && 
                (
                    this.Bcc == input.Bcc ||
                    (this.Bcc != null &&
                    this.Bcc.Equals(input.Bcc))
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
                    this.LocalNumber == input.LocalNumber ||
                    (this.LocalNumber != null &&
                    this.LocalNumber.Equals(input.LocalNumber))
                ) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.NumberState == input.NumberState ||
                    (this.NumberState != null &&
                    this.NumberState.Equals(input.NumberState))
                ) && 
                (
                    this.Port == input.Port ||
                    (this.Port != null &&
                    this.Port.Equals(input.Port))
                ) && 
                (
                    this.PortRequestID == input.PortRequestID ||
                    (this.PortRequestID != null &&
                    this.PortRequestID.Equals(input.PortRequestID))
                ) && 
                (
                    this.Preview == input.Preview ||
                    (this.Preview != null &&
                    this.Preview.Equals(input.Preview))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
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
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.AuthorizedBy != null)
                    hashCode = hashCode * 59 + this.AuthorizedBy.GetHashCode();
                if (this.Bcc != null)
                    hashCode = hashCode * 59 + this.Bcc.GetHashCode();
                if (this.Cc != null)
                    hashCode = hashCode * 59 + this.Cc.GetHashCode();
                if (this.EventCategory != null)
                    hashCode = hashCode * 59 + this.EventCategory.GetHashCode();
                if (this.EventName != null)
                    hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.HTML != null)
                    hashCode = hashCode * 59 + this.HTML.GetHashCode();
                if (this.LocalNumber != null)
                    hashCode = hashCode * 59 + this.LocalNumber.GetHashCode();
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.NumberState != null)
                    hashCode = hashCode * 59 + this.NumberState.GetHashCode();
                if (this.Port != null)
                    hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.PortRequestID != null)
                    hashCode = hashCode * 59 + this.PortRequestID.GetHashCode();
                if (this.Preview != null)
                    hashCode = hashCode * 59 + this.Preview.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.ReplyTo != null)
                    hashCode = hashCode * 59 + this.ReplyTo.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
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
