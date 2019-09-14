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
    /// AMQP API for call.channel_status_resp
    /// </summary>
    [DataContract]
    public partial class KapiCallChannelStatusResp :  IEquatable<KapiCallChannelStatusResp>, IValidatableObject
    {
        /// <summary>
        /// Defines EventCategory
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventCategoryEnum
        {
            
            /// <summary>
            /// Enum Callevent for value: call_event
            /// </summary>
            [EnumMember(Value = "call_event")]
            Callevent = 1
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
            /// Enum Channelstatusresp for value: channel_status_resp
            /// </summary>
            [EnumMember(Value = "channel_status_resp")]
            Channelstatusresp = 1
        }

        /// <summary>
        /// Gets or Sets EventName
        /// </summary>
        [DataMember(Name="Event-Name", EmitDefaultValue=false)]
        public EventNameEnum? EventName { get; set; }
        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Active for value: active
            /// </summary>
            [EnumMember(Value = "active")]
            Active = 1,
            
            /// <summary>
            /// Enum Tmpdown for value: tmpdown
            /// </summary>
            [EnumMember(Value = "tmpdown")]
            Tmpdown = 2,
            
            /// <summary>
            /// Enum Terminated for value: terminated
            /// </summary>
            [EnumMember(Value = "terminated")]
            Terminated = 3
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiCallChannelStatusResp" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KapiCallChannelStatusResp() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiCallChannelStatusResp" /> class.
        /// </summary>
        /// <param name="callID">callID (required).</param>
        /// <param name="customApplicationVars">customApplicationVars.</param>
        /// <param name="customChannelVars">customChannelVars.</param>
        /// <param name="errorMsg">errorMsg.</param>
        /// <param name="eventCategory">eventCategory.</param>
        /// <param name="eventName">eventName.</param>
        /// <param name="fromTag">fromTag.</param>
        /// <param name="otherLegCallID">otherLegCallID.</param>
        /// <param name="realm">realm.</param>
        /// <param name="status">status (required).</param>
        /// <param name="switchHostname">switchHostname.</param>
        /// <param name="switchNodename">switchNodename.</param>
        /// <param name="switchURL">switchURL.</param>
        /// <param name="toTag">toTag.</param>
        /// <param name="username">username.</param>
        public KapiCallChannelStatusResp(string callID = default(string), Object customApplicationVars = default(Object), Object customChannelVars = default(Object), string errorMsg = default(string), EventCategoryEnum? eventCategory = default(EventCategoryEnum?), EventNameEnum? eventName = default(EventNameEnum?), string fromTag = default(string), string otherLegCallID = default(string), string realm = default(string), StatusEnum status = default(StatusEnum), string switchHostname = default(string), string switchNodename = default(string), string switchURL = default(string), string toTag = default(string), string username = default(string))
        {
            // to ensure "callID" is required (not null)
            if (callID == null)
            {
                throw new InvalidDataException("callID is a required property for KapiCallChannelStatusResp and cannot be null");
            }
            else
            {
                this.CallID = callID;
            }
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for KapiCallChannelStatusResp and cannot be null");
            }
            else
            {
                this.Status = status;
            }
            this.CustomApplicationVars = customApplicationVars;
            this.CustomChannelVars = customChannelVars;
            this.ErrorMsg = errorMsg;
            this.EventCategory = eventCategory;
            this.EventName = eventName;
            this.FromTag = fromTag;
            this.OtherLegCallID = otherLegCallID;
            this.Realm = realm;
            this.SwitchHostname = switchHostname;
            this.SwitchNodename = switchNodename;
            this.SwitchURL = switchURL;
            this.ToTag = toTag;
            this.Username = username;
        }
        
        /// <summary>
        /// Gets or Sets CallID
        /// </summary>
        [DataMember(Name="Call-ID", EmitDefaultValue=false)]
        public string CallID { get; set; }

        /// <summary>
        /// Gets or Sets CustomApplicationVars
        /// </summary>
        [DataMember(Name="Custom-Application-Vars", EmitDefaultValue=false)]
        public Object CustomApplicationVars { get; set; }

        /// <summary>
        /// Gets or Sets CustomChannelVars
        /// </summary>
        [DataMember(Name="Custom-Channel-Vars", EmitDefaultValue=false)]
        public Object CustomChannelVars { get; set; }

        /// <summary>
        /// Gets or Sets ErrorMsg
        /// </summary>
        [DataMember(Name="Error-Msg", EmitDefaultValue=false)]
        public string ErrorMsg { get; set; }



        /// <summary>
        /// Gets or Sets FromTag
        /// </summary>
        [DataMember(Name="From-Tag", EmitDefaultValue=false)]
        public string FromTag { get; set; }

        /// <summary>
        /// Gets or Sets OtherLegCallID
        /// </summary>
        [DataMember(Name="Other-Leg-Call-ID", EmitDefaultValue=false)]
        public string OtherLegCallID { get; set; }

        /// <summary>
        /// Gets or Sets Realm
        /// </summary>
        [DataMember(Name="Realm", EmitDefaultValue=false)]
        public string Realm { get; set; }


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
        /// Gets or Sets SwitchURL
        /// </summary>
        [DataMember(Name="Switch-URL", EmitDefaultValue=false)]
        public string SwitchURL { get; set; }

        /// <summary>
        /// Gets or Sets ToTag
        /// </summary>
        [DataMember(Name="To-Tag", EmitDefaultValue=false)]
        public string ToTag { get; set; }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name="Username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KapiCallChannelStatusResp {\n");
            sb.Append("  CallID: ").Append(CallID).Append("\n");
            sb.Append("  CustomApplicationVars: ").Append(CustomApplicationVars).Append("\n");
            sb.Append("  CustomChannelVars: ").Append(CustomChannelVars).Append("\n");
            sb.Append("  ErrorMsg: ").Append(ErrorMsg).Append("\n");
            sb.Append("  EventCategory: ").Append(EventCategory).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  FromTag: ").Append(FromTag).Append("\n");
            sb.Append("  OtherLegCallID: ").Append(OtherLegCallID).Append("\n");
            sb.Append("  Realm: ").Append(Realm).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SwitchHostname: ").Append(SwitchHostname).Append("\n");
            sb.Append("  SwitchNodename: ").Append(SwitchNodename).Append("\n");
            sb.Append("  SwitchURL: ").Append(SwitchURL).Append("\n");
            sb.Append("  ToTag: ").Append(ToTag).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
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
            return this.Equals(input as KapiCallChannelStatusResp);
        }

        /// <summary>
        /// Returns true if KapiCallChannelStatusResp instances are equal
        /// </summary>
        /// <param name="input">Instance of KapiCallChannelStatusResp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KapiCallChannelStatusResp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CallID == input.CallID ||
                    (this.CallID != null &&
                    this.CallID.Equals(input.CallID))
                ) && 
                (
                    this.CustomApplicationVars == input.CustomApplicationVars ||
                    (this.CustomApplicationVars != null &&
                    this.CustomApplicationVars.Equals(input.CustomApplicationVars))
                ) && 
                (
                    this.CustomChannelVars == input.CustomChannelVars ||
                    (this.CustomChannelVars != null &&
                    this.CustomChannelVars.Equals(input.CustomChannelVars))
                ) && 
                (
                    this.ErrorMsg == input.ErrorMsg ||
                    (this.ErrorMsg != null &&
                    this.ErrorMsg.Equals(input.ErrorMsg))
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
                    this.FromTag == input.FromTag ||
                    (this.FromTag != null &&
                    this.FromTag.Equals(input.FromTag))
                ) && 
                (
                    this.OtherLegCallID == input.OtherLegCallID ||
                    (this.OtherLegCallID != null &&
                    this.OtherLegCallID.Equals(input.OtherLegCallID))
                ) && 
                (
                    this.Realm == input.Realm ||
                    (this.Realm != null &&
                    this.Realm.Equals(input.Realm))
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
                    this.SwitchURL == input.SwitchURL ||
                    (this.SwitchURL != null &&
                    this.SwitchURL.Equals(input.SwitchURL))
                ) && 
                (
                    this.ToTag == input.ToTag ||
                    (this.ToTag != null &&
                    this.ToTag.Equals(input.ToTag))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
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
                if (this.CallID != null)
                    hashCode = hashCode * 59 + this.CallID.GetHashCode();
                if (this.CustomApplicationVars != null)
                    hashCode = hashCode * 59 + this.CustomApplicationVars.GetHashCode();
                if (this.CustomChannelVars != null)
                    hashCode = hashCode * 59 + this.CustomChannelVars.GetHashCode();
                if (this.ErrorMsg != null)
                    hashCode = hashCode * 59 + this.ErrorMsg.GetHashCode();
                if (this.EventCategory != null)
                    hashCode = hashCode * 59 + this.EventCategory.GetHashCode();
                if (this.EventName != null)
                    hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.FromTag != null)
                    hashCode = hashCode * 59 + this.FromTag.GetHashCode();
                if (this.OtherLegCallID != null)
                    hashCode = hashCode * 59 + this.OtherLegCallID.GetHashCode();
                if (this.Realm != null)
                    hashCode = hashCode * 59 + this.Realm.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.SwitchHostname != null)
                    hashCode = hashCode * 59 + this.SwitchHostname.GetHashCode();
                if (this.SwitchNodename != null)
                    hashCode = hashCode * 59 + this.SwitchNodename.GetHashCode();
                if (this.SwitchURL != null)
                    hashCode = hashCode * 59 + this.SwitchURL.GetHashCode();
                if (this.ToTag != null)
                    hashCode = hashCode * 59 + this.ToTag.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
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