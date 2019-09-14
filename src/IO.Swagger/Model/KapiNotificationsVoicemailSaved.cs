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
    /// AMQP API for notifications.voicemail_saved
    /// </summary>
    [DataContract]
    public partial class KapiNotificationsVoicemailSaved :  IEquatable<KapiNotificationsVoicemailSaved>, IValidatableObject
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
            /// Enum Voicemailsaved for value: voicemail_saved
            /// </summary>
            [EnumMember(Value = "voicemail_saved")]
            Voicemailsaved = 1
        }

        /// <summary>
        /// Gets or Sets EventName
        /// </summary>
        [DataMember(Name="Event-Name", EmitDefaultValue=false)]
        public EventNameEnum? EventName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiNotificationsVoicemailSaved" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KapiNotificationsVoicemailSaved() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiNotificationsVoicemailSaved" /> class.
        /// </summary>
        /// <param name="accountDB">accountDB.</param>
        /// <param name="accountID">accountID (required).</param>
        /// <param name="attachmentURL">attachmentURL.</param>
        /// <param name="bcc">bcc.</param>
        /// <param name="callID">callID.</param>
        /// <param name="callerIDName">callerIDName.</param>
        /// <param name="callerIDNumber">callerIDNumber.</param>
        /// <param name="cc">cc.</param>
        /// <param name="eventCategory">eventCategory.</param>
        /// <param name="eventName">eventName.</param>
        /// <param name="from">from.</param>
        /// <param name="fromRealm">fromRealm (required).</param>
        /// <param name="fromUser">fromUser (required).</param>
        /// <param name="hTML">hTML.</param>
        /// <param name="preview">preview.</param>
        /// <param name="replyTo">replyTo.</param>
        /// <param name="subject">subject.</param>
        /// <param name="text">text.</param>
        /// <param name="to">to.</param>
        /// <param name="toRealm">toRealm (required).</param>
        /// <param name="toUser">toUser (required).</param>
        /// <param name="voicemailBox">voicemailBox (required).</param>
        /// <param name="voicemailID">voicemailID (required).</param>
        /// <param name="voicemailLength">voicemailLength.</param>
        /// <param name="voicemailTimestamp">voicemailTimestamp (required).</param>
        /// <param name="voicemailTranscription">voicemailTranscription.</param>
        public KapiNotificationsVoicemailSaved(string accountDB = default(string), string accountID = default(string), string attachmentURL = default(string), string bcc = default(string), string callID = default(string), string callerIDName = default(string), string callerIDNumber = default(string), string cc = default(string), EventCategoryEnum? eventCategory = default(EventCategoryEnum?), EventNameEnum? eventName = default(EventNameEnum?), string from = default(string), string fromRealm = default(string), string fromUser = default(string), string hTML = default(string), string preview = default(string), string replyTo = default(string), string subject = default(string), string text = default(string), string to = default(string), string toRealm = default(string), string toUser = default(string), string voicemailBox = default(string), string voicemailID = default(string), string voicemailLength = default(string), string voicemailTimestamp = default(string), string voicemailTranscription = default(string))
        {
            // to ensure "accountID" is required (not null)
            if (accountID == null)
            {
                throw new InvalidDataException("accountID is a required property for KapiNotificationsVoicemailSaved and cannot be null");
            }
            else
            {
                this.AccountID = accountID;
            }
            // to ensure "fromRealm" is required (not null)
            if (fromRealm == null)
            {
                throw new InvalidDataException("fromRealm is a required property for KapiNotificationsVoicemailSaved and cannot be null");
            }
            else
            {
                this.FromRealm = fromRealm;
            }
            // to ensure "fromUser" is required (not null)
            if (fromUser == null)
            {
                throw new InvalidDataException("fromUser is a required property for KapiNotificationsVoicemailSaved and cannot be null");
            }
            else
            {
                this.FromUser = fromUser;
            }
            // to ensure "toRealm" is required (not null)
            if (toRealm == null)
            {
                throw new InvalidDataException("toRealm is a required property for KapiNotificationsVoicemailSaved and cannot be null");
            }
            else
            {
                this.ToRealm = toRealm;
            }
            // to ensure "toUser" is required (not null)
            if (toUser == null)
            {
                throw new InvalidDataException("toUser is a required property for KapiNotificationsVoicemailSaved and cannot be null");
            }
            else
            {
                this.ToUser = toUser;
            }
            // to ensure "voicemailBox" is required (not null)
            if (voicemailBox == null)
            {
                throw new InvalidDataException("voicemailBox is a required property for KapiNotificationsVoicemailSaved and cannot be null");
            }
            else
            {
                this.VoicemailBox = voicemailBox;
            }
            // to ensure "voicemailID" is required (not null)
            if (voicemailID == null)
            {
                throw new InvalidDataException("voicemailID is a required property for KapiNotificationsVoicemailSaved and cannot be null");
            }
            else
            {
                this.VoicemailID = voicemailID;
            }
            // to ensure "voicemailTimestamp" is required (not null)
            if (voicemailTimestamp == null)
            {
                throw new InvalidDataException("voicemailTimestamp is a required property for KapiNotificationsVoicemailSaved and cannot be null");
            }
            else
            {
                this.VoicemailTimestamp = voicemailTimestamp;
            }
            this.AccountDB = accountDB;
            this.AttachmentURL = attachmentURL;
            this.Bcc = bcc;
            this.CallID = callID;
            this.CallerIDName = callerIDName;
            this.CallerIDNumber = callerIDNumber;
            this.Cc = cc;
            this.EventCategory = eventCategory;
            this.EventName = eventName;
            this.From = from;
            this.HTML = hTML;
            this.Preview = preview;
            this.ReplyTo = replyTo;
            this.Subject = subject;
            this.Text = text;
            this.To = to;
            this.VoicemailLength = voicemailLength;
            this.VoicemailTranscription = voicemailTranscription;
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
        /// Gets or Sets VoicemailBox
        /// </summary>
        [DataMember(Name="Voicemail-Box", EmitDefaultValue=false)]
        public string VoicemailBox { get; set; }

        /// <summary>
        /// Gets or Sets VoicemailID
        /// </summary>
        [DataMember(Name="Voicemail-ID", EmitDefaultValue=false)]
        public string VoicemailID { get; set; }

        /// <summary>
        /// Gets or Sets VoicemailLength
        /// </summary>
        [DataMember(Name="Voicemail-Length", EmitDefaultValue=false)]
        public string VoicemailLength { get; set; }

        /// <summary>
        /// Gets or Sets VoicemailTimestamp
        /// </summary>
        [DataMember(Name="Voicemail-Timestamp", EmitDefaultValue=false)]
        public string VoicemailTimestamp { get; set; }

        /// <summary>
        /// Gets or Sets VoicemailTranscription
        /// </summary>
        [DataMember(Name="Voicemail-Transcription", EmitDefaultValue=false)]
        public string VoicemailTranscription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KapiNotificationsVoicemailSaved {\n");
            sb.Append("  AccountDB: ").Append(AccountDB).Append("\n");
            sb.Append("  AccountID: ").Append(AccountID).Append("\n");
            sb.Append("  AttachmentURL: ").Append(AttachmentURL).Append("\n");
            sb.Append("  Bcc: ").Append(Bcc).Append("\n");
            sb.Append("  CallID: ").Append(CallID).Append("\n");
            sb.Append("  CallerIDName: ").Append(CallerIDName).Append("\n");
            sb.Append("  CallerIDNumber: ").Append(CallerIDNumber).Append("\n");
            sb.Append("  Cc: ").Append(Cc).Append("\n");
            sb.Append("  EventCategory: ").Append(EventCategory).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  FromRealm: ").Append(FromRealm).Append("\n");
            sb.Append("  FromUser: ").Append(FromUser).Append("\n");
            sb.Append("  HTML: ").Append(HTML).Append("\n");
            sb.Append("  Preview: ").Append(Preview).Append("\n");
            sb.Append("  ReplyTo: ").Append(ReplyTo).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  ToRealm: ").Append(ToRealm).Append("\n");
            sb.Append("  ToUser: ").Append(ToUser).Append("\n");
            sb.Append("  VoicemailBox: ").Append(VoicemailBox).Append("\n");
            sb.Append("  VoicemailID: ").Append(VoicemailID).Append("\n");
            sb.Append("  VoicemailLength: ").Append(VoicemailLength).Append("\n");
            sb.Append("  VoicemailTimestamp: ").Append(VoicemailTimestamp).Append("\n");
            sb.Append("  VoicemailTranscription: ").Append(VoicemailTranscription).Append("\n");
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
            return this.Equals(input as KapiNotificationsVoicemailSaved);
        }

        /// <summary>
        /// Returns true if KapiNotificationsVoicemailSaved instances are equal
        /// </summary>
        /// <param name="input">Instance of KapiNotificationsVoicemailSaved to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KapiNotificationsVoicemailSaved input)
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
                ) && 
                (
                    this.VoicemailBox == input.VoicemailBox ||
                    (this.VoicemailBox != null &&
                    this.VoicemailBox.Equals(input.VoicemailBox))
                ) && 
                (
                    this.VoicemailID == input.VoicemailID ||
                    (this.VoicemailID != null &&
                    this.VoicemailID.Equals(input.VoicemailID))
                ) && 
                (
                    this.VoicemailLength == input.VoicemailLength ||
                    (this.VoicemailLength != null &&
                    this.VoicemailLength.Equals(input.VoicemailLength))
                ) && 
                (
                    this.VoicemailTimestamp == input.VoicemailTimestamp ||
                    (this.VoicemailTimestamp != null &&
                    this.VoicemailTimestamp.Equals(input.VoicemailTimestamp))
                ) && 
                (
                    this.VoicemailTranscription == input.VoicemailTranscription ||
                    (this.VoicemailTranscription != null &&
                    this.VoicemailTranscription.Equals(input.VoicemailTranscription))
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
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.FromRealm != null)
                    hashCode = hashCode * 59 + this.FromRealm.GetHashCode();
                if (this.FromUser != null)
                    hashCode = hashCode * 59 + this.FromUser.GetHashCode();
                if (this.HTML != null)
                    hashCode = hashCode * 59 + this.HTML.GetHashCode();
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
                if (this.VoicemailBox != null)
                    hashCode = hashCode * 59 + this.VoicemailBox.GetHashCode();
                if (this.VoicemailID != null)
                    hashCode = hashCode * 59 + this.VoicemailID.GetHashCode();
                if (this.VoicemailLength != null)
                    hashCode = hashCode * 59 + this.VoicemailLength.GetHashCode();
                if (this.VoicemailTimestamp != null)
                    hashCode = hashCode * 59 + this.VoicemailTimestamp.GetHashCode();
                if (this.VoicemailTranscription != null)
                    hashCode = hashCode * 59 + this.VoicemailTranscription.GetHashCode();
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