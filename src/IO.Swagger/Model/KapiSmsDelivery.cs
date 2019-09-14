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
    /// AMQP API for sms.delivery
    /// </summary>
    [DataContract]
    public partial class KapiSmsDelivery :  IEquatable<KapiSmsDelivery>, IValidatableObject
    {
        /// <summary>
        /// Defines EventCategory
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventCategoryEnum
        {
            
            /// <summary>
            /// Enum Message for value: message
            /// </summary>
            [EnumMember(Value = "message")]
            Message = 1
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
            /// Enum Delivery for value: delivery
            /// </summary>
            [EnumMember(Value = "delivery")]
            Delivery = 1
        }

        /// <summary>
        /// Gets or Sets EventName
        /// </summary>
        [DataMember(Name="Event-Name", EmitDefaultValue=false)]
        public EventNameEnum? EventName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiSmsDelivery" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KapiSmsDelivery() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiSmsDelivery" /> class.
        /// </summary>
        /// <param name="accountID">accountID.</param>
        /// <param name="body">body.</param>
        /// <param name="callID">callID (required).</param>
        /// <param name="callerIDName">callerIDName.</param>
        /// <param name="callerIDNumber">callerIDNumber.</param>
        /// <param name="contact">contact.</param>
        /// <param name="contactIP">contactIP.</param>
        /// <param name="contactPort">contactPort.</param>
        /// <param name="contactUsername">contactUsername.</param>
        /// <param name="customChannelVars">customChannelVars.</param>
        /// <param name="customSIPHeaders">customSIPHeaders.</param>
        /// <param name="deliveryFailure">deliveryFailure.</param>
        /// <param name="deliveryResultCode">deliveryResultCode.</param>
        /// <param name="deliveryResultText">deliveryResultText.</param>
        /// <param name="errorCode">errorCode.</param>
        /// <param name="errorMessage">errorMessage.</param>
        /// <param name="eventCategory">eventCategory.</param>
        /// <param name="eventName">eventName.</param>
        /// <param name="eventQueue">eventQueue.</param>
        /// <param name="from">from.</param>
        /// <param name="fromNetworkAddr">fromNetworkAddr.</param>
        /// <param name="geoLocation">geoLocation.</param>
        /// <param name="messageID">messageID (required).</param>
        /// <param name="origIP">origIP.</param>
        /// <param name="origPort">origPort.</param>
        /// <param name="request">request.</param>
        /// <param name="status">status.</param>
        /// <param name="switchHostname">switchHostname.</param>
        /// <param name="switchNodename">switchNodename.</param>
        /// <param name="to">to.</param>
        /// <param name="userAgent">userAgent.</param>
        public KapiSmsDelivery(string accountID = default(string), string body = default(string), string callID = default(string), string callerIDName = default(string), string callerIDNumber = default(string), string contact = default(string), string contactIP = default(string), string contactPort = default(string), string contactUsername = default(string), Object customChannelVars = default(Object), Object customSIPHeaders = default(Object), string deliveryFailure = default(string), string deliveryResultCode = default(string), string deliveryResultText = default(string), string errorCode = default(string), string errorMessage = default(string), EventCategoryEnum? eventCategory = default(EventCategoryEnum?), EventNameEnum? eventName = default(EventNameEnum?), string eventQueue = default(string), string from = default(string), string fromNetworkAddr = default(string), string geoLocation = default(string), string messageID = default(string), string origIP = default(string), string origPort = default(string), string request = default(string), string status = default(string), string switchHostname = default(string), string switchNodename = default(string), string to = default(string), string userAgent = default(string))
        {
            // to ensure "callID" is required (not null)
            if (callID == null)
            {
                throw new InvalidDataException("callID is a required property for KapiSmsDelivery and cannot be null");
            }
            else
            {
                this.CallID = callID;
            }
            // to ensure "messageID" is required (not null)
            if (messageID == null)
            {
                throw new InvalidDataException("messageID is a required property for KapiSmsDelivery and cannot be null");
            }
            else
            {
                this.MessageID = messageID;
            }
            this.AccountID = accountID;
            this.Body = body;
            this.CallerIDName = callerIDName;
            this.CallerIDNumber = callerIDNumber;
            this.Contact = contact;
            this.ContactIP = contactIP;
            this.ContactPort = contactPort;
            this.ContactUsername = contactUsername;
            this.CustomChannelVars = customChannelVars;
            this.CustomSIPHeaders = customSIPHeaders;
            this.DeliveryFailure = deliveryFailure;
            this.DeliveryResultCode = deliveryResultCode;
            this.DeliveryResultText = deliveryResultText;
            this.ErrorCode = errorCode;
            this.ErrorMessage = errorMessage;
            this.EventCategory = eventCategory;
            this.EventName = eventName;
            this.EventQueue = eventQueue;
            this.From = from;
            this.FromNetworkAddr = fromNetworkAddr;
            this.GeoLocation = geoLocation;
            this.OrigIP = origIP;
            this.OrigPort = origPort;
            this.Request = request;
            this.Status = status;
            this.SwitchHostname = switchHostname;
            this.SwitchNodename = switchNodename;
            this.To = to;
            this.UserAgent = userAgent;
        }
        
        /// <summary>
        /// Gets or Sets AccountID
        /// </summary>
        [DataMember(Name="Account-ID", EmitDefaultValue=false)]
        public string AccountID { get; set; }

        /// <summary>
        /// Gets or Sets Body
        /// </summary>
        [DataMember(Name="Body", EmitDefaultValue=false)]
        public string Body { get; set; }

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
        /// Gets or Sets Contact
        /// </summary>
        [DataMember(Name="Contact", EmitDefaultValue=false)]
        public string Contact { get; set; }

        /// <summary>
        /// Gets or Sets ContactIP
        /// </summary>
        [DataMember(Name="Contact-IP", EmitDefaultValue=false)]
        public string ContactIP { get; set; }

        /// <summary>
        /// Gets or Sets ContactPort
        /// </summary>
        [DataMember(Name="Contact-Port", EmitDefaultValue=false)]
        public string ContactPort { get; set; }

        /// <summary>
        /// Gets or Sets ContactUsername
        /// </summary>
        [DataMember(Name="Contact-Username", EmitDefaultValue=false)]
        public string ContactUsername { get; set; }

        /// <summary>
        /// Gets or Sets CustomChannelVars
        /// </summary>
        [DataMember(Name="Custom-Channel-Vars", EmitDefaultValue=false)]
        public Object CustomChannelVars { get; set; }

        /// <summary>
        /// Gets or Sets CustomSIPHeaders
        /// </summary>
        [DataMember(Name="Custom-SIP-Headers", EmitDefaultValue=false)]
        public Object CustomSIPHeaders { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryFailure
        /// </summary>
        [DataMember(Name="Delivery-Failure", EmitDefaultValue=false)]
        public string DeliveryFailure { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryResultCode
        /// </summary>
        [DataMember(Name="Delivery-Result-Code", EmitDefaultValue=false)]
        public string DeliveryResultCode { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryResultText
        /// </summary>
        [DataMember(Name="Delivery-Result-Text", EmitDefaultValue=false)]
        public string DeliveryResultText { get; set; }

        /// <summary>
        /// Gets or Sets ErrorCode
        /// </summary>
        [DataMember(Name="Error-Code", EmitDefaultValue=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Gets or Sets ErrorMessage
        /// </summary>
        [DataMember(Name="Error-Message", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }



        /// <summary>
        /// Gets or Sets EventQueue
        /// </summary>
        [DataMember(Name="Event-Queue", EmitDefaultValue=false)]
        public string EventQueue { get; set; }

        /// <summary>
        /// Gets or Sets From
        /// </summary>
        [DataMember(Name="From", EmitDefaultValue=false)]
        public string From { get; set; }

        /// <summary>
        /// Gets or Sets FromNetworkAddr
        /// </summary>
        [DataMember(Name="From-Network-Addr", EmitDefaultValue=false)]
        public string FromNetworkAddr { get; set; }

        /// <summary>
        /// Gets or Sets GeoLocation
        /// </summary>
        [DataMember(Name="Geo-Location", EmitDefaultValue=false)]
        public string GeoLocation { get; set; }

        /// <summary>
        /// Gets or Sets MessageID
        /// </summary>
        [DataMember(Name="Message-ID", EmitDefaultValue=false)]
        public string MessageID { get; set; }

        /// <summary>
        /// Gets or Sets OrigIP
        /// </summary>
        [DataMember(Name="Orig-IP", EmitDefaultValue=false)]
        public string OrigIP { get; set; }

        /// <summary>
        /// Gets or Sets OrigPort
        /// </summary>
        [DataMember(Name="Orig-Port", EmitDefaultValue=false)]
        public string OrigPort { get; set; }

        /// <summary>
        /// Gets or Sets Request
        /// </summary>
        [DataMember(Name="Request", EmitDefaultValue=false)]
        public string Request { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets SwitchHostname
        /// </summary>
        [DataMember(Name="Switch-Hostname", EmitDefaultValue=false)]
        public string SwitchHostname { get; set; }

        /// <summary>
        /// Gets or Sets SwitchNodename
        /// </summary>
        [DataMember(Name="Switch-Nodename", EmitDefaultValue=false)]
        public string SwitchNodename { get; set; }

        /// <summary>
        /// Gets or Sets To
        /// </summary>
        [DataMember(Name="To", EmitDefaultValue=false)]
        public string To { get; set; }

        /// <summary>
        /// Gets or Sets UserAgent
        /// </summary>
        [DataMember(Name="User-Agent", EmitDefaultValue=false)]
        public string UserAgent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KapiSmsDelivery {\n");
            sb.Append("  AccountID: ").Append(AccountID).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  CallID: ").Append(CallID).Append("\n");
            sb.Append("  CallerIDName: ").Append(CallerIDName).Append("\n");
            sb.Append("  CallerIDNumber: ").Append(CallerIDNumber).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  ContactIP: ").Append(ContactIP).Append("\n");
            sb.Append("  ContactPort: ").Append(ContactPort).Append("\n");
            sb.Append("  ContactUsername: ").Append(ContactUsername).Append("\n");
            sb.Append("  CustomChannelVars: ").Append(CustomChannelVars).Append("\n");
            sb.Append("  CustomSIPHeaders: ").Append(CustomSIPHeaders).Append("\n");
            sb.Append("  DeliveryFailure: ").Append(DeliveryFailure).Append("\n");
            sb.Append("  DeliveryResultCode: ").Append(DeliveryResultCode).Append("\n");
            sb.Append("  DeliveryResultText: ").Append(DeliveryResultText).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  EventCategory: ").Append(EventCategory).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  EventQueue: ").Append(EventQueue).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  FromNetworkAddr: ").Append(FromNetworkAddr).Append("\n");
            sb.Append("  GeoLocation: ").Append(GeoLocation).Append("\n");
            sb.Append("  MessageID: ").Append(MessageID).Append("\n");
            sb.Append("  OrigIP: ").Append(OrigIP).Append("\n");
            sb.Append("  OrigPort: ").Append(OrigPort).Append("\n");
            sb.Append("  Request: ").Append(Request).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SwitchHostname: ").Append(SwitchHostname).Append("\n");
            sb.Append("  SwitchNodename: ").Append(SwitchNodename).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  UserAgent: ").Append(UserAgent).Append("\n");
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
            return this.Equals(input as KapiSmsDelivery);
        }

        /// <summary>
        /// Returns true if KapiSmsDelivery instances are equal
        /// </summary>
        /// <param name="input">Instance of KapiSmsDelivery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KapiSmsDelivery input)
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
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
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
                    this.Contact == input.Contact ||
                    (this.Contact != null &&
                    this.Contact.Equals(input.Contact))
                ) && 
                (
                    this.ContactIP == input.ContactIP ||
                    (this.ContactIP != null &&
                    this.ContactIP.Equals(input.ContactIP))
                ) && 
                (
                    this.ContactPort == input.ContactPort ||
                    (this.ContactPort != null &&
                    this.ContactPort.Equals(input.ContactPort))
                ) && 
                (
                    this.ContactUsername == input.ContactUsername ||
                    (this.ContactUsername != null &&
                    this.ContactUsername.Equals(input.ContactUsername))
                ) && 
                (
                    this.CustomChannelVars == input.CustomChannelVars ||
                    (this.CustomChannelVars != null &&
                    this.CustomChannelVars.Equals(input.CustomChannelVars))
                ) && 
                (
                    this.CustomSIPHeaders == input.CustomSIPHeaders ||
                    (this.CustomSIPHeaders != null &&
                    this.CustomSIPHeaders.Equals(input.CustomSIPHeaders))
                ) && 
                (
                    this.DeliveryFailure == input.DeliveryFailure ||
                    (this.DeliveryFailure != null &&
                    this.DeliveryFailure.Equals(input.DeliveryFailure))
                ) && 
                (
                    this.DeliveryResultCode == input.DeliveryResultCode ||
                    (this.DeliveryResultCode != null &&
                    this.DeliveryResultCode.Equals(input.DeliveryResultCode))
                ) && 
                (
                    this.DeliveryResultText == input.DeliveryResultText ||
                    (this.DeliveryResultText != null &&
                    this.DeliveryResultText.Equals(input.DeliveryResultText))
                ) && 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
                ) && 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
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
                    this.EventQueue == input.EventQueue ||
                    (this.EventQueue != null &&
                    this.EventQueue.Equals(input.EventQueue))
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.FromNetworkAddr == input.FromNetworkAddr ||
                    (this.FromNetworkAddr != null &&
                    this.FromNetworkAddr.Equals(input.FromNetworkAddr))
                ) && 
                (
                    this.GeoLocation == input.GeoLocation ||
                    (this.GeoLocation != null &&
                    this.GeoLocation.Equals(input.GeoLocation))
                ) && 
                (
                    this.MessageID == input.MessageID ||
                    (this.MessageID != null &&
                    this.MessageID.Equals(input.MessageID))
                ) && 
                (
                    this.OrigIP == input.OrigIP ||
                    (this.OrigIP != null &&
                    this.OrigIP.Equals(input.OrigIP))
                ) && 
                (
                    this.OrigPort == input.OrigPort ||
                    (this.OrigPort != null &&
                    this.OrigPort.Equals(input.OrigPort))
                ) && 
                (
                    this.Request == input.Request ||
                    (this.Request != null &&
                    this.Request.Equals(input.Request))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.SwitchHostname == input.SwitchHostname ||
                    (this.SwitchHostname != null &&
                    this.SwitchHostname.Equals(input.SwitchHostname))
                ) && 
                (
                    this.SwitchNodename == input.SwitchNodename ||
                    (this.SwitchNodename != null &&
                    this.SwitchNodename.Equals(input.SwitchNodename))
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.UserAgent == input.UserAgent ||
                    (this.UserAgent != null &&
                    this.UserAgent.Equals(input.UserAgent))
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
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                if (this.CallID != null)
                    hashCode = hashCode * 59 + this.CallID.GetHashCode();
                if (this.CallerIDName != null)
                    hashCode = hashCode * 59 + this.CallerIDName.GetHashCode();
                if (this.CallerIDNumber != null)
                    hashCode = hashCode * 59 + this.CallerIDNumber.GetHashCode();
                if (this.Contact != null)
                    hashCode = hashCode * 59 + this.Contact.GetHashCode();
                if (this.ContactIP != null)
                    hashCode = hashCode * 59 + this.ContactIP.GetHashCode();
                if (this.ContactPort != null)
                    hashCode = hashCode * 59 + this.ContactPort.GetHashCode();
                if (this.ContactUsername != null)
                    hashCode = hashCode * 59 + this.ContactUsername.GetHashCode();
                if (this.CustomChannelVars != null)
                    hashCode = hashCode * 59 + this.CustomChannelVars.GetHashCode();
                if (this.CustomSIPHeaders != null)
                    hashCode = hashCode * 59 + this.CustomSIPHeaders.GetHashCode();
                if (this.DeliveryFailure != null)
                    hashCode = hashCode * 59 + this.DeliveryFailure.GetHashCode();
                if (this.DeliveryResultCode != null)
                    hashCode = hashCode * 59 + this.DeliveryResultCode.GetHashCode();
                if (this.DeliveryResultText != null)
                    hashCode = hashCode * 59 + this.DeliveryResultText.GetHashCode();
                if (this.ErrorCode != null)
                    hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                if (this.EventCategory != null)
                    hashCode = hashCode * 59 + this.EventCategory.GetHashCode();
                if (this.EventName != null)
                    hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.EventQueue != null)
                    hashCode = hashCode * 59 + this.EventQueue.GetHashCode();
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.FromNetworkAddr != null)
                    hashCode = hashCode * 59 + this.FromNetworkAddr.GetHashCode();
                if (this.GeoLocation != null)
                    hashCode = hashCode * 59 + this.GeoLocation.GetHashCode();
                if (this.MessageID != null)
                    hashCode = hashCode * 59 + this.MessageID.GetHashCode();
                if (this.OrigIP != null)
                    hashCode = hashCode * 59 + this.OrigIP.GetHashCode();
                if (this.OrigPort != null)
                    hashCode = hashCode * 59 + this.OrigPort.GetHashCode();
                if (this.Request != null)
                    hashCode = hashCode * 59 + this.Request.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.SwitchHostname != null)
                    hashCode = hashCode * 59 + this.SwitchHostname.GetHashCode();
                if (this.SwitchNodename != null)
                    hashCode = hashCode * 59 + this.SwitchNodename.GetHashCode();
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.UserAgent != null)
                    hashCode = hashCode * 59 + this.UserAgent.GetHashCode();
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
