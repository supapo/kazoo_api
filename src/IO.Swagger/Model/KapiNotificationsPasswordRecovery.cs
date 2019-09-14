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
    /// AMQP API for notifications.password_recovery
    /// </summary>
    [DataContract]
    public partial class KapiNotificationsPasswordRecovery :  IEquatable<KapiNotificationsPasswordRecovery>, IValidatableObject
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
            /// Enum Passwordrecovery for value: password_recovery
            /// </summary>
            [EnumMember(Value = "password_recovery")]
            Passwordrecovery = 1
        }

        /// <summary>
        /// Gets or Sets EventName
        /// </summary>
        [DataMember(Name="Event-Name", EmitDefaultValue=false)]
        public EventNameEnum? EventName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiNotificationsPasswordRecovery" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KapiNotificationsPasswordRecovery() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiNotificationsPasswordRecovery" /> class.
        /// </summary>
        /// <param name="accountDB">accountDB.</param>
        /// <param name="accountID">accountID (required).</param>
        /// <param name="attachmentURL">attachmentURL.</param>
        /// <param name="bcc">bcc.</param>
        /// <param name="cc">cc.</param>
        /// <param name="email">email (required).</param>
        /// <param name="eventCategory">eventCategory.</param>
        /// <param name="eventName">eventName.</param>
        /// <param name="firstName">firstName.</param>
        /// <param name="from">from.</param>
        /// <param name="hTML">hTML.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="passwordResetLink">passwordResetLink (required).</param>
        /// <param name="preview">preview.</param>
        /// <param name="replyTo">replyTo.</param>
        /// <param name="subject">subject.</param>
        /// <param name="text">text.</param>
        /// <param name="timezone">timezone.</param>
        /// <param name="to">to.</param>
        /// <param name="userID">userID.</param>
        public KapiNotificationsPasswordRecovery(string accountDB = default(string), string accountID = default(string), string attachmentURL = default(string), string bcc = default(string), string cc = default(string), string email = default(string), EventCategoryEnum? eventCategory = default(EventCategoryEnum?), EventNameEnum? eventName = default(EventNameEnum?), string firstName = default(string), string from = default(string), string hTML = default(string), string lastName = default(string), string passwordResetLink = default(string), string preview = default(string), string replyTo = default(string), string subject = default(string), string text = default(string), string timezone = default(string), string to = default(string), string userID = default(string))
        {
            // to ensure "accountID" is required (not null)
            if (accountID == null)
            {
                throw new InvalidDataException("accountID is a required property for KapiNotificationsPasswordRecovery and cannot be null");
            }
            else
            {
                this.AccountID = accountID;
            }
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new InvalidDataException("email is a required property for KapiNotificationsPasswordRecovery and cannot be null");
            }
            else
            {
                this.Email = email;
            }
            // to ensure "passwordResetLink" is required (not null)
            if (passwordResetLink == null)
            {
                throw new InvalidDataException("passwordResetLink is a required property for KapiNotificationsPasswordRecovery and cannot be null");
            }
            else
            {
                this.PasswordResetLink = passwordResetLink;
            }
            this.AccountDB = accountDB;
            this.AttachmentURL = attachmentURL;
            this.Bcc = bcc;
            this.Cc = cc;
            this.EventCategory = eventCategory;
            this.EventName = eventName;
            this.FirstName = firstName;
            this.From = from;
            this.HTML = hTML;
            this.LastName = lastName;
            this.Preview = preview;
            this.ReplyTo = replyTo;
            this.Subject = subject;
            this.Text = text;
            this.Timezone = timezone;
            this.To = to;
            this.UserID = userID;
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
        /// Gets or Sets Cc
        /// </summary>
        [DataMember(Name="Cc", EmitDefaultValue=false)]
        public string Cc { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="Email", EmitDefaultValue=false)]
        public string Email { get; set; }



        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name="First-Name", EmitDefaultValue=false)]
        public string FirstName { get; set; }

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
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name="Last-Name", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets PasswordResetLink
        /// </summary>
        [DataMember(Name="Password-Reset-Link", EmitDefaultValue=false)]
        public string PasswordResetLink { get; set; }

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
        /// Gets or Sets Timezone
        /// </summary>
        [DataMember(Name="Timezone", EmitDefaultValue=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// Gets or Sets To
        /// </summary>
        [DataMember(Name="To", EmitDefaultValue=false)]
        public string To { get; set; }

        /// <summary>
        /// Gets or Sets UserID
        /// </summary>
        [DataMember(Name="User-ID", EmitDefaultValue=false)]
        public string UserID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KapiNotificationsPasswordRecovery {\n");
            sb.Append("  AccountDB: ").Append(AccountDB).Append("\n");
            sb.Append("  AccountID: ").Append(AccountID).Append("\n");
            sb.Append("  AttachmentURL: ").Append(AttachmentURL).Append("\n");
            sb.Append("  Bcc: ").Append(Bcc).Append("\n");
            sb.Append("  Cc: ").Append(Cc).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  EventCategory: ").Append(EventCategory).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  HTML: ").Append(HTML).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  PasswordResetLink: ").Append(PasswordResetLink).Append("\n");
            sb.Append("  Preview: ").Append(Preview).Append("\n");
            sb.Append("  ReplyTo: ").Append(ReplyTo).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  UserID: ").Append(UserID).Append("\n");
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
            return this.Equals(input as KapiNotificationsPasswordRecovery);
        }

        /// <summary>
        /// Returns true if KapiNotificationsPasswordRecovery instances are equal
        /// </summary>
        /// <param name="input">Instance of KapiNotificationsPasswordRecovery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KapiNotificationsPasswordRecovery input)
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
                    this.Cc == input.Cc ||
                    (this.Cc != null &&
                    this.Cc.Equals(input.Cc))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
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
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
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
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.PasswordResetLink == input.PasswordResetLink ||
                    (this.PasswordResetLink != null &&
                    this.PasswordResetLink.Equals(input.PasswordResetLink))
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
                    this.Timezone == input.Timezone ||
                    (this.Timezone != null &&
                    this.Timezone.Equals(input.Timezone))
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.UserID == input.UserID ||
                    (this.UserID != null &&
                    this.UserID.Equals(input.UserID))
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
                if (this.Cc != null)
                    hashCode = hashCode * 59 + this.Cc.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.EventCategory != null)
                    hashCode = hashCode * 59 + this.EventCategory.GetHashCode();
                if (this.EventName != null)
                    hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.HTML != null)
                    hashCode = hashCode * 59 + this.HTML.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.PasswordResetLink != null)
                    hashCode = hashCode * 59 + this.PasswordResetLink.GetHashCode();
                if (this.Preview != null)
                    hashCode = hashCode * 59 + this.Preview.GetHashCode();
                if (this.ReplyTo != null)
                    hashCode = hashCode * 59 + this.ReplyTo.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.Timezone != null)
                    hashCode = hashCode * 59 + this.Timezone.GetHashCode();
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.UserID != null)
                    hashCode = hashCode * 59 + this.UserID.GetHashCode();
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
