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
    /// AMQP API for registration.success
    /// </summary>
    [DataContract]
    public partial class KapiRegistrationSuccess :  IEquatable<KapiRegistrationSuccess>, IValidatableObject
    {
        /// <summary>
        /// Defines EventCategory
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventCategoryEnum
        {
            
            /// <summary>
            /// Enum Directory for value: directory
            /// </summary>
            [EnumMember(Value = "directory")]
            Directory = 1
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
            /// Enum Regsuccess for value: reg_success
            /// </summary>
            [EnumMember(Value = "reg_success")]
            Regsuccess = 1
        }

        /// <summary>
        /// Gets or Sets EventName
        /// </summary>
        [DataMember(Name="Event-Name", EmitDefaultValue=false)]
        public EventNameEnum? EventName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiRegistrationSuccess" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KapiRegistrationSuccess() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiRegistrationSuccess" /> class.
        /// </summary>
        /// <param name="aOR">aOR.</param>
        /// <param name="accountDB">accountDB.</param>
        /// <param name="accountID">accountID.</param>
        /// <param name="authorizingID">authorizingID.</param>
        /// <param name="callID">callID.</param>
        /// <param name="contact">contact (required).</param>
        /// <param name="customChannelVars">customChannelVars.</param>
        /// <param name="eventCategory">eventCategory.</param>
        /// <param name="eventName">eventName.</param>
        /// <param name="eventTimestamp">eventTimestamp (required).</param>
        /// <param name="expires">expires (required).</param>
        /// <param name="firstRegistration">firstRegistration.</param>
        /// <param name="freeSWITCHHostname">freeSWITCHHostname.</param>
        /// <param name="freeSWITCHNodename">freeSWITCHNodename.</param>
        /// <param name="fromHost">fromHost.</param>
        /// <param name="fromUser">fromUser.</param>
        /// <param name="networkIP">networkIP.</param>
        /// <param name="networkPort">networkPort.</param>
        /// <param name="originalContact">originalContact.</param>
        /// <param name="presenceHosts">presenceHosts.</param>
        /// <param name="profileName">profileName.</param>
        /// <param name="proxyIP">proxyIP.</param>
        /// <param name="proxyPath">proxyPath.</param>
        /// <param name="proxyPort">proxyPort.</param>
        /// <param name="proxyProtocol">proxyProtocol.</param>
        /// <param name="rPid">rPid.</param>
        /// <param name="rUID">rUID.</param>
        /// <param name="realm">realm (required).</param>
        /// <param name="registerOverwriteNotify">registerOverwriteNotify.</param>
        /// <param name="registrarNode">registrarNode.</param>
        /// <param name="sourceIP">sourceIP.</param>
        /// <param name="sourcePort">sourcePort.</param>
        /// <param name="status">status.</param>
        /// <param name="suppressUnregisterNotify">suppressUnregisterNotify.</param>
        /// <param name="toHost">toHost.</param>
        /// <param name="toUser">toUser.</param>
        /// <param name="userAgent">userAgent.</param>
        /// <param name="username">username (required).</param>
        public KapiRegistrationSuccess(string aOR = default(string), string accountDB = default(string), string accountID = default(string), string authorizingID = default(string), string callID = default(string), string contact = default(string), Object customChannelVars = default(Object), EventCategoryEnum? eventCategory = default(EventCategoryEnum?), EventNameEnum? eventName = default(EventNameEnum?), string eventTimestamp = default(string), string expires = default(string), string firstRegistration = default(string), string freeSWITCHHostname = default(string), string freeSWITCHNodename = default(string), string fromHost = default(string), string fromUser = default(string), string networkIP = default(string), string networkPort = default(string), string originalContact = default(string), string presenceHosts = default(string), string profileName = default(string), string proxyIP = default(string), string proxyPath = default(string), string proxyPort = default(string), string proxyProtocol = default(string), string rPid = default(string), string rUID = default(string), string realm = default(string), string registerOverwriteNotify = default(string), string registrarNode = default(string), string sourceIP = default(string), string sourcePort = default(string), string status = default(string), string suppressUnregisterNotify = default(string), string toHost = default(string), string toUser = default(string), string userAgent = default(string), string username = default(string))
        {
            // to ensure "contact" is required (not null)
            if (contact == null)
            {
                throw new InvalidDataException("contact is a required property for KapiRegistrationSuccess and cannot be null");
            }
            else
            {
                this.Contact = contact;
            }
            // to ensure "eventTimestamp" is required (not null)
            if (eventTimestamp == null)
            {
                throw new InvalidDataException("eventTimestamp is a required property for KapiRegistrationSuccess and cannot be null");
            }
            else
            {
                this.EventTimestamp = eventTimestamp;
            }
            // to ensure "expires" is required (not null)
            if (expires == null)
            {
                throw new InvalidDataException("expires is a required property for KapiRegistrationSuccess and cannot be null");
            }
            else
            {
                this.Expires = expires;
            }
            // to ensure "realm" is required (not null)
            if (realm == null)
            {
                throw new InvalidDataException("realm is a required property for KapiRegistrationSuccess and cannot be null");
            }
            else
            {
                this.Realm = realm;
            }
            // to ensure "username" is required (not null)
            if (username == null)
            {
                throw new InvalidDataException("username is a required property for KapiRegistrationSuccess and cannot be null");
            }
            else
            {
                this.Username = username;
            }
            this.AOR = aOR;
            this.AccountDB = accountDB;
            this.AccountID = accountID;
            this.AuthorizingID = authorizingID;
            this.CallID = callID;
            this.CustomChannelVars = customChannelVars;
            this.EventCategory = eventCategory;
            this.EventName = eventName;
            this.FirstRegistration = firstRegistration;
            this.FreeSWITCHHostname = freeSWITCHHostname;
            this.FreeSWITCHNodename = freeSWITCHNodename;
            this.FromHost = fromHost;
            this.FromUser = fromUser;
            this.NetworkIP = networkIP;
            this.NetworkPort = networkPort;
            this.OriginalContact = originalContact;
            this.PresenceHosts = presenceHosts;
            this.ProfileName = profileName;
            this.ProxyIP = proxyIP;
            this.ProxyPath = proxyPath;
            this.ProxyPort = proxyPort;
            this.ProxyProtocol = proxyProtocol;
            this.RPid = rPid;
            this.RUID = rUID;
            this.RegisterOverwriteNotify = registerOverwriteNotify;
            this.RegistrarNode = registrarNode;
            this.SourceIP = sourceIP;
            this.SourcePort = sourcePort;
            this.Status = status;
            this.SuppressUnregisterNotify = suppressUnregisterNotify;
            this.ToHost = toHost;
            this.ToUser = toUser;
            this.UserAgent = userAgent;
        }
        
        /// <summary>
        /// Gets or Sets AOR
        /// </summary>
        [DataMember(Name="AOR", EmitDefaultValue=false)]
        public string AOR { get; set; }

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
        /// Gets or Sets AuthorizingID
        /// </summary>
        [DataMember(Name="Authorizing-ID", EmitDefaultValue=false)]
        public string AuthorizingID { get; set; }

        /// <summary>
        /// Gets or Sets CallID
        /// </summary>
        [DataMember(Name="Call-ID", EmitDefaultValue=false)]
        public string CallID { get; set; }

        /// <summary>
        /// Gets or Sets Contact
        /// </summary>
        [DataMember(Name="Contact", EmitDefaultValue=false)]
        public string Contact { get; set; }

        /// <summary>
        /// Gets or Sets CustomChannelVars
        /// </summary>
        [DataMember(Name="Custom-Channel-Vars", EmitDefaultValue=false)]
        public Object CustomChannelVars { get; set; }



        /// <summary>
        /// Gets or Sets EventTimestamp
        /// </summary>
        [DataMember(Name="Event-Timestamp", EmitDefaultValue=false)]
        public string EventTimestamp { get; set; }

        /// <summary>
        /// Gets or Sets Expires
        /// </summary>
        [DataMember(Name="Expires", EmitDefaultValue=false)]
        public string Expires { get; set; }

        /// <summary>
        /// Gets or Sets FirstRegistration
        /// </summary>
        [DataMember(Name="First-Registration", EmitDefaultValue=false)]
        public string FirstRegistration { get; set; }

        /// <summary>
        /// Gets or Sets FreeSWITCHHostname
        /// </summary>
        [DataMember(Name="FreeSWITCH-Hostname", EmitDefaultValue=false)]
        public string FreeSWITCHHostname { get; set; }

        /// <summary>
        /// Gets or Sets FreeSWITCHNodename
        /// </summary>
        [DataMember(Name="FreeSWITCH-Nodename", EmitDefaultValue=false)]
        public string FreeSWITCHNodename { get; set; }

        /// <summary>
        /// Gets or Sets FromHost
        /// </summary>
        [DataMember(Name="From-Host", EmitDefaultValue=false)]
        public string FromHost { get; set; }

        /// <summary>
        /// Gets or Sets FromUser
        /// </summary>
        [DataMember(Name="From-User", EmitDefaultValue=false)]
        public string FromUser { get; set; }

        /// <summary>
        /// Gets or Sets NetworkIP
        /// </summary>
        [DataMember(Name="Network-IP", EmitDefaultValue=false)]
        public string NetworkIP { get; set; }

        /// <summary>
        /// Gets or Sets NetworkPort
        /// </summary>
        [DataMember(Name="Network-Port", EmitDefaultValue=false)]
        public string NetworkPort { get; set; }

        /// <summary>
        /// Gets or Sets OriginalContact
        /// </summary>
        [DataMember(Name="Original-Contact", EmitDefaultValue=false)]
        public string OriginalContact { get; set; }

        /// <summary>
        /// Gets or Sets PresenceHosts
        /// </summary>
        [DataMember(Name="Presence-Hosts", EmitDefaultValue=false)]
        public string PresenceHosts { get; set; }

        /// <summary>
        /// Gets or Sets ProfileName
        /// </summary>
        [DataMember(Name="Profile-Name", EmitDefaultValue=false)]
        public string ProfileName { get; set; }

        /// <summary>
        /// Gets or Sets ProxyIP
        /// </summary>
        [DataMember(Name="Proxy-IP", EmitDefaultValue=false)]
        public string ProxyIP { get; set; }

        /// <summary>
        /// Gets or Sets ProxyPath
        /// </summary>
        [DataMember(Name="Proxy-Path", EmitDefaultValue=false)]
        public string ProxyPath { get; set; }

        /// <summary>
        /// Gets or Sets ProxyPort
        /// </summary>
        [DataMember(Name="Proxy-Port", EmitDefaultValue=false)]
        public string ProxyPort { get; set; }

        /// <summary>
        /// Gets or Sets ProxyProtocol
        /// </summary>
        [DataMember(Name="Proxy-Protocol", EmitDefaultValue=false)]
        public string ProxyProtocol { get; set; }

        /// <summary>
        /// Gets or Sets RPid
        /// </summary>
        [DataMember(Name="RPid", EmitDefaultValue=false)]
        public string RPid { get; set; }

        /// <summary>
        /// Gets or Sets RUID
        /// </summary>
        [DataMember(Name="RUID", EmitDefaultValue=false)]
        public string RUID { get; set; }

        /// <summary>
        /// Gets or Sets Realm
        /// </summary>
        [DataMember(Name="Realm", EmitDefaultValue=false)]
        public string Realm { get; set; }

        /// <summary>
        /// Gets or Sets RegisterOverwriteNotify
        /// </summary>
        [DataMember(Name="Register-Overwrite-Notify", EmitDefaultValue=false)]
        public string RegisterOverwriteNotify { get; set; }

        /// <summary>
        /// Gets or Sets RegistrarNode
        /// </summary>
        [DataMember(Name="Registrar-Node", EmitDefaultValue=false)]
        public string RegistrarNode { get; set; }

        /// <summary>
        /// Gets or Sets SourceIP
        /// </summary>
        [DataMember(Name="Source-IP", EmitDefaultValue=false)]
        public string SourceIP { get; set; }

        /// <summary>
        /// Gets or Sets SourcePort
        /// </summary>
        [DataMember(Name="Source-Port", EmitDefaultValue=false)]
        public string SourcePort { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets SuppressUnregisterNotify
        /// </summary>
        [DataMember(Name="Suppress-Unregister-Notify", EmitDefaultValue=false)]
        public string SuppressUnregisterNotify { get; set; }

        /// <summary>
        /// Gets or Sets ToHost
        /// </summary>
        [DataMember(Name="To-Host", EmitDefaultValue=false)]
        public string ToHost { get; set; }

        /// <summary>
        /// Gets or Sets ToUser
        /// </summary>
        [DataMember(Name="To-User", EmitDefaultValue=false)]
        public string ToUser { get; set; }

        /// <summary>
        /// Gets or Sets UserAgent
        /// </summary>
        [DataMember(Name="User-Agent", EmitDefaultValue=false)]
        public string UserAgent { get; set; }

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
            sb.Append("class KapiRegistrationSuccess {\n");
            sb.Append("  AOR: ").Append(AOR).Append("\n");
            sb.Append("  AccountDB: ").Append(AccountDB).Append("\n");
            sb.Append("  AccountID: ").Append(AccountID).Append("\n");
            sb.Append("  AuthorizingID: ").Append(AuthorizingID).Append("\n");
            sb.Append("  CallID: ").Append(CallID).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  CustomChannelVars: ").Append(CustomChannelVars).Append("\n");
            sb.Append("  EventCategory: ").Append(EventCategory).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  EventTimestamp: ").Append(EventTimestamp).Append("\n");
            sb.Append("  Expires: ").Append(Expires).Append("\n");
            sb.Append("  FirstRegistration: ").Append(FirstRegistration).Append("\n");
            sb.Append("  FreeSWITCHHostname: ").Append(FreeSWITCHHostname).Append("\n");
            sb.Append("  FreeSWITCHNodename: ").Append(FreeSWITCHNodename).Append("\n");
            sb.Append("  FromHost: ").Append(FromHost).Append("\n");
            sb.Append("  FromUser: ").Append(FromUser).Append("\n");
            sb.Append("  NetworkIP: ").Append(NetworkIP).Append("\n");
            sb.Append("  NetworkPort: ").Append(NetworkPort).Append("\n");
            sb.Append("  OriginalContact: ").Append(OriginalContact).Append("\n");
            sb.Append("  PresenceHosts: ").Append(PresenceHosts).Append("\n");
            sb.Append("  ProfileName: ").Append(ProfileName).Append("\n");
            sb.Append("  ProxyIP: ").Append(ProxyIP).Append("\n");
            sb.Append("  ProxyPath: ").Append(ProxyPath).Append("\n");
            sb.Append("  ProxyPort: ").Append(ProxyPort).Append("\n");
            sb.Append("  ProxyProtocol: ").Append(ProxyProtocol).Append("\n");
            sb.Append("  RPid: ").Append(RPid).Append("\n");
            sb.Append("  RUID: ").Append(RUID).Append("\n");
            sb.Append("  Realm: ").Append(Realm).Append("\n");
            sb.Append("  RegisterOverwriteNotify: ").Append(RegisterOverwriteNotify).Append("\n");
            sb.Append("  RegistrarNode: ").Append(RegistrarNode).Append("\n");
            sb.Append("  SourceIP: ").Append(SourceIP).Append("\n");
            sb.Append("  SourcePort: ").Append(SourcePort).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SuppressUnregisterNotify: ").Append(SuppressUnregisterNotify).Append("\n");
            sb.Append("  ToHost: ").Append(ToHost).Append("\n");
            sb.Append("  ToUser: ").Append(ToUser).Append("\n");
            sb.Append("  UserAgent: ").Append(UserAgent).Append("\n");
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
            return this.Equals(input as KapiRegistrationSuccess);
        }

        /// <summary>
        /// Returns true if KapiRegistrationSuccess instances are equal
        /// </summary>
        /// <param name="input">Instance of KapiRegistrationSuccess to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KapiRegistrationSuccess input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AOR == input.AOR ||
                    (this.AOR != null &&
                    this.AOR.Equals(input.AOR))
                ) && 
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
                    this.AuthorizingID == input.AuthorizingID ||
                    (this.AuthorizingID != null &&
                    this.AuthorizingID.Equals(input.AuthorizingID))
                ) && 
                (
                    this.CallID == input.CallID ||
                    (this.CallID != null &&
                    this.CallID.Equals(input.CallID))
                ) && 
                (
                    this.Contact == input.Contact ||
                    (this.Contact != null &&
                    this.Contact.Equals(input.Contact))
                ) && 
                (
                    this.CustomChannelVars == input.CustomChannelVars ||
                    (this.CustomChannelVars != null &&
                    this.CustomChannelVars.Equals(input.CustomChannelVars))
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
                    this.EventTimestamp == input.EventTimestamp ||
                    (this.EventTimestamp != null &&
                    this.EventTimestamp.Equals(input.EventTimestamp))
                ) && 
                (
                    this.Expires == input.Expires ||
                    (this.Expires != null &&
                    this.Expires.Equals(input.Expires))
                ) && 
                (
                    this.FirstRegistration == input.FirstRegistration ||
                    (this.FirstRegistration != null &&
                    this.FirstRegistration.Equals(input.FirstRegistration))
                ) && 
                (
                    this.FreeSWITCHHostname == input.FreeSWITCHHostname ||
                    (this.FreeSWITCHHostname != null &&
                    this.FreeSWITCHHostname.Equals(input.FreeSWITCHHostname))
                ) && 
                (
                    this.FreeSWITCHNodename == input.FreeSWITCHNodename ||
                    (this.FreeSWITCHNodename != null &&
                    this.FreeSWITCHNodename.Equals(input.FreeSWITCHNodename))
                ) && 
                (
                    this.FromHost == input.FromHost ||
                    (this.FromHost != null &&
                    this.FromHost.Equals(input.FromHost))
                ) && 
                (
                    this.FromUser == input.FromUser ||
                    (this.FromUser != null &&
                    this.FromUser.Equals(input.FromUser))
                ) && 
                (
                    this.NetworkIP == input.NetworkIP ||
                    (this.NetworkIP != null &&
                    this.NetworkIP.Equals(input.NetworkIP))
                ) && 
                (
                    this.NetworkPort == input.NetworkPort ||
                    (this.NetworkPort != null &&
                    this.NetworkPort.Equals(input.NetworkPort))
                ) && 
                (
                    this.OriginalContact == input.OriginalContact ||
                    (this.OriginalContact != null &&
                    this.OriginalContact.Equals(input.OriginalContact))
                ) && 
                (
                    this.PresenceHosts == input.PresenceHosts ||
                    (this.PresenceHosts != null &&
                    this.PresenceHosts.Equals(input.PresenceHosts))
                ) && 
                (
                    this.ProfileName == input.ProfileName ||
                    (this.ProfileName != null &&
                    this.ProfileName.Equals(input.ProfileName))
                ) && 
                (
                    this.ProxyIP == input.ProxyIP ||
                    (this.ProxyIP != null &&
                    this.ProxyIP.Equals(input.ProxyIP))
                ) && 
                (
                    this.ProxyPath == input.ProxyPath ||
                    (this.ProxyPath != null &&
                    this.ProxyPath.Equals(input.ProxyPath))
                ) && 
                (
                    this.ProxyPort == input.ProxyPort ||
                    (this.ProxyPort != null &&
                    this.ProxyPort.Equals(input.ProxyPort))
                ) && 
                (
                    this.ProxyProtocol == input.ProxyProtocol ||
                    (this.ProxyProtocol != null &&
                    this.ProxyProtocol.Equals(input.ProxyProtocol))
                ) && 
                (
                    this.RPid == input.RPid ||
                    (this.RPid != null &&
                    this.RPid.Equals(input.RPid))
                ) && 
                (
                    this.RUID == input.RUID ||
                    (this.RUID != null &&
                    this.RUID.Equals(input.RUID))
                ) && 
                (
                    this.Realm == input.Realm ||
                    (this.Realm != null &&
                    this.Realm.Equals(input.Realm))
                ) && 
                (
                    this.RegisterOverwriteNotify == input.RegisterOverwriteNotify ||
                    (this.RegisterOverwriteNotify != null &&
                    this.RegisterOverwriteNotify.Equals(input.RegisterOverwriteNotify))
                ) && 
                (
                    this.RegistrarNode == input.RegistrarNode ||
                    (this.RegistrarNode != null &&
                    this.RegistrarNode.Equals(input.RegistrarNode))
                ) && 
                (
                    this.SourceIP == input.SourceIP ||
                    (this.SourceIP != null &&
                    this.SourceIP.Equals(input.SourceIP))
                ) && 
                (
                    this.SourcePort == input.SourcePort ||
                    (this.SourcePort != null &&
                    this.SourcePort.Equals(input.SourcePort))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.SuppressUnregisterNotify == input.SuppressUnregisterNotify ||
                    (this.SuppressUnregisterNotify != null &&
                    this.SuppressUnregisterNotify.Equals(input.SuppressUnregisterNotify))
                ) && 
                (
                    this.ToHost == input.ToHost ||
                    (this.ToHost != null &&
                    this.ToHost.Equals(input.ToHost))
                ) && 
                (
                    this.ToUser == input.ToUser ||
                    (this.ToUser != null &&
                    this.ToUser.Equals(input.ToUser))
                ) && 
                (
                    this.UserAgent == input.UserAgent ||
                    (this.UserAgent != null &&
                    this.UserAgent.Equals(input.UserAgent))
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
                if (this.AOR != null)
                    hashCode = hashCode * 59 + this.AOR.GetHashCode();
                if (this.AccountDB != null)
                    hashCode = hashCode * 59 + this.AccountDB.GetHashCode();
                if (this.AccountID != null)
                    hashCode = hashCode * 59 + this.AccountID.GetHashCode();
                if (this.AuthorizingID != null)
                    hashCode = hashCode * 59 + this.AuthorizingID.GetHashCode();
                if (this.CallID != null)
                    hashCode = hashCode * 59 + this.CallID.GetHashCode();
                if (this.Contact != null)
                    hashCode = hashCode * 59 + this.Contact.GetHashCode();
                if (this.CustomChannelVars != null)
                    hashCode = hashCode * 59 + this.CustomChannelVars.GetHashCode();
                if (this.EventCategory != null)
                    hashCode = hashCode * 59 + this.EventCategory.GetHashCode();
                if (this.EventName != null)
                    hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.EventTimestamp != null)
                    hashCode = hashCode * 59 + this.EventTimestamp.GetHashCode();
                if (this.Expires != null)
                    hashCode = hashCode * 59 + this.Expires.GetHashCode();
                if (this.FirstRegistration != null)
                    hashCode = hashCode * 59 + this.FirstRegistration.GetHashCode();
                if (this.FreeSWITCHHostname != null)
                    hashCode = hashCode * 59 + this.FreeSWITCHHostname.GetHashCode();
                if (this.FreeSWITCHNodename != null)
                    hashCode = hashCode * 59 + this.FreeSWITCHNodename.GetHashCode();
                if (this.FromHost != null)
                    hashCode = hashCode * 59 + this.FromHost.GetHashCode();
                if (this.FromUser != null)
                    hashCode = hashCode * 59 + this.FromUser.GetHashCode();
                if (this.NetworkIP != null)
                    hashCode = hashCode * 59 + this.NetworkIP.GetHashCode();
                if (this.NetworkPort != null)
                    hashCode = hashCode * 59 + this.NetworkPort.GetHashCode();
                if (this.OriginalContact != null)
                    hashCode = hashCode * 59 + this.OriginalContact.GetHashCode();
                if (this.PresenceHosts != null)
                    hashCode = hashCode * 59 + this.PresenceHosts.GetHashCode();
                if (this.ProfileName != null)
                    hashCode = hashCode * 59 + this.ProfileName.GetHashCode();
                if (this.ProxyIP != null)
                    hashCode = hashCode * 59 + this.ProxyIP.GetHashCode();
                if (this.ProxyPath != null)
                    hashCode = hashCode * 59 + this.ProxyPath.GetHashCode();
                if (this.ProxyPort != null)
                    hashCode = hashCode * 59 + this.ProxyPort.GetHashCode();
                if (this.ProxyProtocol != null)
                    hashCode = hashCode * 59 + this.ProxyProtocol.GetHashCode();
                if (this.RPid != null)
                    hashCode = hashCode * 59 + this.RPid.GetHashCode();
                if (this.RUID != null)
                    hashCode = hashCode * 59 + this.RUID.GetHashCode();
                if (this.Realm != null)
                    hashCode = hashCode * 59 + this.Realm.GetHashCode();
                if (this.RegisterOverwriteNotify != null)
                    hashCode = hashCode * 59 + this.RegisterOverwriteNotify.GetHashCode();
                if (this.RegistrarNode != null)
                    hashCode = hashCode * 59 + this.RegistrarNode.GetHashCode();
                if (this.SourceIP != null)
                    hashCode = hashCode * 59 + this.SourceIP.GetHashCode();
                if (this.SourcePort != null)
                    hashCode = hashCode * 59 + this.SourcePort.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.SuppressUnregisterNotify != null)
                    hashCode = hashCode * 59 + this.SuppressUnregisterNotify.GetHashCode();
                if (this.ToHost != null)
                    hashCode = hashCode * 59 + this.ToHost.GetHashCode();
                if (this.ToUser != null)
                    hashCode = hashCode * 59 + this.ToUser.GetHashCode();
                if (this.UserAgent != null)
                    hashCode = hashCode * 59 + this.UserAgent.GetHashCode();
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