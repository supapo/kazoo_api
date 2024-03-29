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
    /// Schema for a user
    /// </summary>
    [DataContract]
    public partial class Users :  IEquatable<Users>, IValidatableObject
    {
        /// <summary>
        /// The privilege level of the user
        /// </summary>
        /// <value>The privilege level of the user</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PrivLevelEnum
        {
            
            /// <summary>
            /// Enum User for value: user
            /// </summary>
            [EnumMember(Value = "user")]
            User = 1,
            
            /// <summary>
            /// Enum Admin for value: admin
            /// </summary>
            [EnumMember(Value = "admin")]
            Admin = 2
        }

        /// <summary>
        /// The privilege level of the user
        /// </summary>
        /// <value>The privilege level of the user</value>
        [DataMember(Name="priv_level", EmitDefaultValue=false)]
        public PrivLevelEnum? PrivLevel { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Users" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Users() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Users" /> class.
        /// </summary>
        /// <param name="callForward">callForward.</param>
        /// <param name="callRecording">callRecording.</param>
        /// <param name="callRestriction">Device level call restrictions for each available number classification.</param>
        /// <param name="callWaiting">callWaiting.</param>
        /// <param name="callerId">The device caller ID parameters.</param>
        /// <param name="callerIdOptions">callerIdOptions.</param>
        /// <param name="contactList">contactList.</param>
        /// <param name="dialPlan">A list of rules used to modify dialed numbers.</param>
        /// <param name="directories">Provides the mappings for what directory the user is a part of (the key), and what callflow (the value) to invoke if the user is selected by the caller..</param>
        /// <param name="doNotDisturb">doNotDisturb.</param>
        /// <param name="email">The email of the user.</param>
        /// <param name="enabled">Determines if the user is currently enabled (default to true).</param>
        /// <param name="featureLevel">The user level for assigning feature sets.</param>
        /// <param name="firstName">The first name of the user (required).</param>
        /// <param name="flags">Flags set by external applications.</param>
        /// <param name="formatters">formatters.</param>
        /// <param name="hotdesk">hotdesk.</param>
        /// <param name="language">The language for this user.</param>
        /// <param name="lastName">The last name of the user (required).</param>
        /// <param name="media">Configure audio/video/etc media options for this user.</param>
        /// <param name="metaflows">The device metaflow parameters.</param>
        /// <param name="musicOnHold">musicOnHold.</param>
        /// <param name="password">The GUI login password.</param>
        /// <param name="presenceId">Static presence ID (used instead of SIP username).</param>
        /// <param name="privLevel">The privilege level of the user (default to PrivLevelEnum.User).</param>
        /// <param name="profile">User&#39;s profile data.</param>
        /// <param name="pronouncedName">pronouncedName.</param>
        /// <param name="requirePasswordUpdate">UI flag that the user should update their password. (default to false).</param>
        /// <param name="ringtones">ringtones.</param>
        /// <param name="timezone">User&#39;s timezone.</param>
        /// <param name="username">The GUI login username - alpha-numeric, dashes, at symbol, periods, plusses, and underscores allowed.</param>
        /// <param name="verified">Determines if the user has been verified (default to false).</param>
        /// <param name="vmToEmailEnabled">Determines if the user would like voicemails emailed to them (default to true).</param>
        /// <param name="voicemail">voicemail.</param>
        public Users(UsersCallForward callForward = default(UsersCallForward), CallRecording callRecording = default(CallRecording), Dictionary<string, AccountsCallRestriction> callRestriction = default(Dictionary<string, AccountsCallRestriction>), CallWaiting callWaiting = default(CallWaiting), CallerId callerId = default(CallerId), DevicesCallerIdOptions callerIdOptions = default(DevicesCallerIdOptions), DevicesContactList contactList = default(DevicesContactList), Dialplans dialPlan = default(Dialplans), Object directories = default(Object), UsersDoNotDisturb doNotDisturb = default(UsersDoNotDisturb), string email = default(string), bool? enabled = true, string featureLevel = default(string), string firstName = default(string), List<string> flags = default(List<string>), Formatters formatters = default(Formatters), UsersHotdesk hotdesk = default(UsersHotdesk), string language = default(string), string lastName = default(string), EndpointMedia media = default(EndpointMedia), Metaflows metaflows = default(Metaflows), UsersMusicOnHold musicOnHold = default(UsersMusicOnHold), string password = default(string), string presenceId = default(string), PrivLevelEnum? privLevel = PrivLevelEnum.User, Profile profile = default(Profile), UsersPronouncedName pronouncedName = default(UsersPronouncedName), bool? requirePasswordUpdate = false, AccountsRingtones ringtones = default(AccountsRingtones), string timezone = default(string), string username = default(string), bool? verified = false, bool? vmToEmailEnabled = true, AccountsVoicemail voicemail = default(AccountsVoicemail))
        {
            // to ensure "firstName" is required (not null)
            if (firstName == null)
            {
                throw new InvalidDataException("firstName is a required property for Users and cannot be null");
            }
            else
            {
                this.FirstName = firstName;
            }
            // to ensure "lastName" is required (not null)
            if (lastName == null)
            {
                throw new InvalidDataException("lastName is a required property for Users and cannot be null");
            }
            else
            {
                this.LastName = lastName;
            }
            this.CallForward = callForward;
            this.CallRecording = callRecording;
            this.CallRestriction = callRestriction;
            this.CallWaiting = callWaiting;
            this.CallerId = callerId;
            this.CallerIdOptions = callerIdOptions;
            this.ContactList = contactList;
            this.DialPlan = dialPlan;
            this.Directories = directories;
            this.DoNotDisturb = doNotDisturb;
            this.Email = email;
            // use default value if no "enabled" provided
            if (enabled == null)
            {
                this.Enabled = true;
            }
            else
            {
                this.Enabled = enabled;
            }
            this.FeatureLevel = featureLevel;
            this.Flags = flags;
            this.Formatters = formatters;
            this.Hotdesk = hotdesk;
            this.Language = language;
            this.Media = media;
            this.Metaflows = metaflows;
            this.MusicOnHold = musicOnHold;
            this.Password = password;
            this.PresenceId = presenceId;
            // use default value if no "privLevel" provided
            if (privLevel == null)
            {
                this.PrivLevel = PrivLevelEnum.User;
            }
            else
            {
                this.PrivLevel = privLevel;
            }
            this.Profile = profile;
            this.PronouncedName = pronouncedName;
            // use default value if no "requirePasswordUpdate" provided
            if (requirePasswordUpdate == null)
            {
                this.RequirePasswordUpdate = false;
            }
            else
            {
                this.RequirePasswordUpdate = requirePasswordUpdate;
            }
            this.Ringtones = ringtones;
            this.Timezone = timezone;
            this.Username = username;
            // use default value if no "verified" provided
            if (verified == null)
            {
                this.Verified = false;
            }
            else
            {
                this.Verified = verified;
            }
            // use default value if no "vmToEmailEnabled" provided
            if (vmToEmailEnabled == null)
            {
                this.VmToEmailEnabled = true;
            }
            else
            {
                this.VmToEmailEnabled = vmToEmailEnabled;
            }
            this.Voicemail = voicemail;
        }
        
        /// <summary>
        /// Gets or Sets CallForward
        /// </summary>
        [DataMember(Name="call_forward", EmitDefaultValue=false)]
        public UsersCallForward CallForward { get; set; }

        /// <summary>
        /// Gets or Sets CallRecording
        /// </summary>
        [DataMember(Name="call_recording", EmitDefaultValue=false)]
        public CallRecording CallRecording { get; set; }

        /// <summary>
        /// Device level call restrictions for each available number classification
        /// </summary>
        /// <value>Device level call restrictions for each available number classification</value>
        [DataMember(Name="call_restriction", EmitDefaultValue=false)]
        public Dictionary<string, AccountsCallRestriction> CallRestriction { get; set; }

        /// <summary>
        /// Gets or Sets CallWaiting
        /// </summary>
        [DataMember(Name="call_waiting", EmitDefaultValue=false)]
        public CallWaiting CallWaiting { get; set; }

        /// <summary>
        /// The device caller ID parameters
        /// </summary>
        /// <value>The device caller ID parameters</value>
        [DataMember(Name="caller_id", EmitDefaultValue=false)]
        public CallerId CallerId { get; set; }

        /// <summary>
        /// Gets or Sets CallerIdOptions
        /// </summary>
        [DataMember(Name="caller_id_options", EmitDefaultValue=false)]
        public DevicesCallerIdOptions CallerIdOptions { get; set; }

        /// <summary>
        /// Gets or Sets ContactList
        /// </summary>
        [DataMember(Name="contact_list", EmitDefaultValue=false)]
        public DevicesContactList ContactList { get; set; }

        /// <summary>
        /// A list of rules used to modify dialed numbers
        /// </summary>
        /// <value>A list of rules used to modify dialed numbers</value>
        [DataMember(Name="dial_plan", EmitDefaultValue=false)]
        public Dialplans DialPlan { get; set; }

        /// <summary>
        /// Provides the mappings for what directory the user is a part of (the key), and what callflow (the value) to invoke if the user is selected by the caller.
        /// </summary>
        /// <value>Provides the mappings for what directory the user is a part of (the key), and what callflow (the value) to invoke if the user is selected by the caller.</value>
        [DataMember(Name="directories", EmitDefaultValue=false)]
        public Object Directories { get; set; }

        /// <summary>
        /// Gets or Sets DoNotDisturb
        /// </summary>
        [DataMember(Name="do_not_disturb", EmitDefaultValue=false)]
        public UsersDoNotDisturb DoNotDisturb { get; set; }

        /// <summary>
        /// The email of the user
        /// </summary>
        /// <value>The email of the user</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Determines if the user is currently enabled
        /// </summary>
        /// <value>Determines if the user is currently enabled</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The user level for assigning feature sets
        /// </summary>
        /// <value>The user level for assigning feature sets</value>
        [DataMember(Name="feature_level", EmitDefaultValue=false)]
        public string FeatureLevel { get; set; }

        /// <summary>
        /// The first name of the user
        /// </summary>
        /// <value>The first name of the user</value>
        [DataMember(Name="first_name", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Flags set by external applications
        /// </summary>
        /// <value>Flags set by external applications</value>
        [DataMember(Name="flags", EmitDefaultValue=false)]
        public List<string> Flags { get; set; }

        /// <summary>
        /// Gets or Sets Formatters
        /// </summary>
        [DataMember(Name="formatters", EmitDefaultValue=false)]
        public Formatters Formatters { get; set; }

        /// <summary>
        /// Gets or Sets Hotdesk
        /// </summary>
        [DataMember(Name="hotdesk", EmitDefaultValue=false)]
        public UsersHotdesk Hotdesk { get; set; }

        /// <summary>
        /// The language for this user
        /// </summary>
        /// <value>The language for this user</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }

        /// <summary>
        /// The last name of the user
        /// </summary>
        /// <value>The last name of the user</value>
        [DataMember(Name="last_name", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Configure audio/video/etc media options for this user
        /// </summary>
        /// <value>Configure audio/video/etc media options for this user</value>
        [DataMember(Name="media", EmitDefaultValue=false)]
        public EndpointMedia Media { get; set; }

        /// <summary>
        /// The device metaflow parameters
        /// </summary>
        /// <value>The device metaflow parameters</value>
        [DataMember(Name="metaflows", EmitDefaultValue=false)]
        public Metaflows Metaflows { get; set; }

        /// <summary>
        /// Gets or Sets MusicOnHold
        /// </summary>
        [DataMember(Name="music_on_hold", EmitDefaultValue=false)]
        public UsersMusicOnHold MusicOnHold { get; set; }

        /// <summary>
        /// The GUI login password
        /// </summary>
        /// <value>The GUI login password</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Static presence ID (used instead of SIP username)
        /// </summary>
        /// <value>Static presence ID (used instead of SIP username)</value>
        [DataMember(Name="presence_id", EmitDefaultValue=false)]
        public string PresenceId { get; set; }


        /// <summary>
        /// User&#39;s profile data
        /// </summary>
        /// <value>User&#39;s profile data</value>
        [DataMember(Name="profile", EmitDefaultValue=false)]
        public Profile Profile { get; set; }

        /// <summary>
        /// Gets or Sets PronouncedName
        /// </summary>
        [DataMember(Name="pronounced_name", EmitDefaultValue=false)]
        public UsersPronouncedName PronouncedName { get; set; }

        /// <summary>
        /// UI flag that the user should update their password.
        /// </summary>
        /// <value>UI flag that the user should update their password.</value>
        [DataMember(Name="require_password_update", EmitDefaultValue=false)]
        public bool? RequirePasswordUpdate { get; set; }

        /// <summary>
        /// Gets or Sets Ringtones
        /// </summary>
        [DataMember(Name="ringtones", EmitDefaultValue=false)]
        public AccountsRingtones Ringtones { get; set; }

        /// <summary>
        /// User&#39;s timezone
        /// </summary>
        /// <value>User&#39;s timezone</value>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// The GUI login username - alpha-numeric, dashes, at symbol, periods, plusses, and underscores allowed
        /// </summary>
        /// <value>The GUI login username - alpha-numeric, dashes, at symbol, periods, plusses, and underscores allowed</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Determines if the user has been verified
        /// </summary>
        /// <value>Determines if the user has been verified</value>
        [DataMember(Name="verified", EmitDefaultValue=false)]
        public bool? Verified { get; set; }

        /// <summary>
        /// Determines if the user would like voicemails emailed to them
        /// </summary>
        /// <value>Determines if the user would like voicemails emailed to them</value>
        [DataMember(Name="vm_to_email_enabled", EmitDefaultValue=false)]
        public bool? VmToEmailEnabled { get; set; }

        /// <summary>
        /// Gets or Sets Voicemail
        /// </summary>
        [DataMember(Name="voicemail", EmitDefaultValue=false)]
        public AccountsVoicemail Voicemail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Users {\n");
            sb.Append("  CallForward: ").Append(CallForward).Append("\n");
            sb.Append("  CallRecording: ").Append(CallRecording).Append("\n");
            sb.Append("  CallRestriction: ").Append(CallRestriction).Append("\n");
            sb.Append("  CallWaiting: ").Append(CallWaiting).Append("\n");
            sb.Append("  CallerId: ").Append(CallerId).Append("\n");
            sb.Append("  CallerIdOptions: ").Append(CallerIdOptions).Append("\n");
            sb.Append("  ContactList: ").Append(ContactList).Append("\n");
            sb.Append("  DialPlan: ").Append(DialPlan).Append("\n");
            sb.Append("  Directories: ").Append(Directories).Append("\n");
            sb.Append("  DoNotDisturb: ").Append(DoNotDisturb).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  FeatureLevel: ").Append(FeatureLevel).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  Flags: ").Append(Flags).Append("\n");
            sb.Append("  Formatters: ").Append(Formatters).Append("\n");
            sb.Append("  Hotdesk: ").Append(Hotdesk).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Media: ").Append(Media).Append("\n");
            sb.Append("  Metaflows: ").Append(Metaflows).Append("\n");
            sb.Append("  MusicOnHold: ").Append(MusicOnHold).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  PresenceId: ").Append(PresenceId).Append("\n");
            sb.Append("  PrivLevel: ").Append(PrivLevel).Append("\n");
            sb.Append("  Profile: ").Append(Profile).Append("\n");
            sb.Append("  PronouncedName: ").Append(PronouncedName).Append("\n");
            sb.Append("  RequirePasswordUpdate: ").Append(RequirePasswordUpdate).Append("\n");
            sb.Append("  Ringtones: ").Append(Ringtones).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Verified: ").Append(Verified).Append("\n");
            sb.Append("  VmToEmailEnabled: ").Append(VmToEmailEnabled).Append("\n");
            sb.Append("  Voicemail: ").Append(Voicemail).Append("\n");
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
            return this.Equals(input as Users);
        }

        /// <summary>
        /// Returns true if Users instances are equal
        /// </summary>
        /// <param name="input">Instance of Users to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Users input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CallForward == input.CallForward ||
                    (this.CallForward != null &&
                    this.CallForward.Equals(input.CallForward))
                ) && 
                (
                    this.CallRecording == input.CallRecording ||
                    (this.CallRecording != null &&
                    this.CallRecording.Equals(input.CallRecording))
                ) && 
                (
                    this.CallRestriction == input.CallRestriction ||
                    this.CallRestriction != null &&
                    this.CallRestriction.SequenceEqual(input.CallRestriction)
                ) && 
                (
                    this.CallWaiting == input.CallWaiting ||
                    (this.CallWaiting != null &&
                    this.CallWaiting.Equals(input.CallWaiting))
                ) && 
                (
                    this.CallerId == input.CallerId ||
                    (this.CallerId != null &&
                    this.CallerId.Equals(input.CallerId))
                ) && 
                (
                    this.CallerIdOptions == input.CallerIdOptions ||
                    (this.CallerIdOptions != null &&
                    this.CallerIdOptions.Equals(input.CallerIdOptions))
                ) && 
                (
                    this.ContactList == input.ContactList ||
                    (this.ContactList != null &&
                    this.ContactList.Equals(input.ContactList))
                ) && 
                (
                    this.DialPlan == input.DialPlan ||
                    (this.DialPlan != null &&
                    this.DialPlan.Equals(input.DialPlan))
                ) && 
                (
                    this.Directories == input.Directories ||
                    (this.Directories != null &&
                    this.Directories.Equals(input.Directories))
                ) && 
                (
                    this.DoNotDisturb == input.DoNotDisturb ||
                    (this.DoNotDisturb != null &&
                    this.DoNotDisturb.Equals(input.DoNotDisturb))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.FeatureLevel == input.FeatureLevel ||
                    (this.FeatureLevel != null &&
                    this.FeatureLevel.Equals(input.FeatureLevel))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.Flags == input.Flags ||
                    this.Flags != null &&
                    this.Flags.SequenceEqual(input.Flags)
                ) && 
                (
                    this.Formatters == input.Formatters ||
                    (this.Formatters != null &&
                    this.Formatters.Equals(input.Formatters))
                ) && 
                (
                    this.Hotdesk == input.Hotdesk ||
                    (this.Hotdesk != null &&
                    this.Hotdesk.Equals(input.Hotdesk))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.Media == input.Media ||
                    (this.Media != null &&
                    this.Media.Equals(input.Media))
                ) && 
                (
                    this.Metaflows == input.Metaflows ||
                    (this.Metaflows != null &&
                    this.Metaflows.Equals(input.Metaflows))
                ) && 
                (
                    this.MusicOnHold == input.MusicOnHold ||
                    (this.MusicOnHold != null &&
                    this.MusicOnHold.Equals(input.MusicOnHold))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.PresenceId == input.PresenceId ||
                    (this.PresenceId != null &&
                    this.PresenceId.Equals(input.PresenceId))
                ) && 
                (
                    this.PrivLevel == input.PrivLevel ||
                    (this.PrivLevel != null &&
                    this.PrivLevel.Equals(input.PrivLevel))
                ) && 
                (
                    this.Profile == input.Profile ||
                    (this.Profile != null &&
                    this.Profile.Equals(input.Profile))
                ) && 
                (
                    this.PronouncedName == input.PronouncedName ||
                    (this.PronouncedName != null &&
                    this.PronouncedName.Equals(input.PronouncedName))
                ) && 
                (
                    this.RequirePasswordUpdate == input.RequirePasswordUpdate ||
                    (this.RequirePasswordUpdate != null &&
                    this.RequirePasswordUpdate.Equals(input.RequirePasswordUpdate))
                ) && 
                (
                    this.Ringtones == input.Ringtones ||
                    (this.Ringtones != null &&
                    this.Ringtones.Equals(input.Ringtones))
                ) && 
                (
                    this.Timezone == input.Timezone ||
                    (this.Timezone != null &&
                    this.Timezone.Equals(input.Timezone))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.Verified == input.Verified ||
                    (this.Verified != null &&
                    this.Verified.Equals(input.Verified))
                ) && 
                (
                    this.VmToEmailEnabled == input.VmToEmailEnabled ||
                    (this.VmToEmailEnabled != null &&
                    this.VmToEmailEnabled.Equals(input.VmToEmailEnabled))
                ) && 
                (
                    this.Voicemail == input.Voicemail ||
                    (this.Voicemail != null &&
                    this.Voicemail.Equals(input.Voicemail))
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
                if (this.CallForward != null)
                    hashCode = hashCode * 59 + this.CallForward.GetHashCode();
                if (this.CallRecording != null)
                    hashCode = hashCode * 59 + this.CallRecording.GetHashCode();
                if (this.CallRestriction != null)
                    hashCode = hashCode * 59 + this.CallRestriction.GetHashCode();
                if (this.CallWaiting != null)
                    hashCode = hashCode * 59 + this.CallWaiting.GetHashCode();
                if (this.CallerId != null)
                    hashCode = hashCode * 59 + this.CallerId.GetHashCode();
                if (this.CallerIdOptions != null)
                    hashCode = hashCode * 59 + this.CallerIdOptions.GetHashCode();
                if (this.ContactList != null)
                    hashCode = hashCode * 59 + this.ContactList.GetHashCode();
                if (this.DialPlan != null)
                    hashCode = hashCode * 59 + this.DialPlan.GetHashCode();
                if (this.Directories != null)
                    hashCode = hashCode * 59 + this.Directories.GetHashCode();
                if (this.DoNotDisturb != null)
                    hashCode = hashCode * 59 + this.DoNotDisturb.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.FeatureLevel != null)
                    hashCode = hashCode * 59 + this.FeatureLevel.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.Flags != null)
                    hashCode = hashCode * 59 + this.Flags.GetHashCode();
                if (this.Formatters != null)
                    hashCode = hashCode * 59 + this.Formatters.GetHashCode();
                if (this.Hotdesk != null)
                    hashCode = hashCode * 59 + this.Hotdesk.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.Media != null)
                    hashCode = hashCode * 59 + this.Media.GetHashCode();
                if (this.Metaflows != null)
                    hashCode = hashCode * 59 + this.Metaflows.GetHashCode();
                if (this.MusicOnHold != null)
                    hashCode = hashCode * 59 + this.MusicOnHold.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.PresenceId != null)
                    hashCode = hashCode * 59 + this.PresenceId.GetHashCode();
                if (this.PrivLevel != null)
                    hashCode = hashCode * 59 + this.PrivLevel.GetHashCode();
                if (this.Profile != null)
                    hashCode = hashCode * 59 + this.Profile.GetHashCode();
                if (this.PronouncedName != null)
                    hashCode = hashCode * 59 + this.PronouncedName.GetHashCode();
                if (this.RequirePasswordUpdate != null)
                    hashCode = hashCode * 59 + this.RequirePasswordUpdate.GetHashCode();
                if (this.Ringtones != null)
                    hashCode = hashCode * 59 + this.Ringtones.GetHashCode();
                if (this.Timezone != null)
                    hashCode = hashCode * 59 + this.Timezone.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.Verified != null)
                    hashCode = hashCode * 59 + this.Verified.GetHashCode();
                if (this.VmToEmailEnabled != null)
                    hashCode = hashCode * 59 + this.VmToEmailEnabled.GetHashCode();
                if (this.Voicemail != null)
                    hashCode = hashCode * 59 + this.Voicemail.GetHashCode();
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
            // Email (string) maxLength
            if(this.Email != null && this.Email.Length > 254)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Email, length must be less than 254.", new [] { "Email" });
            }

            // Email (string) minLength
            if(this.Email != null && this.Email.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Email, length must be greater than 3.", new [] { "Email" });
            }

            // FirstName (string) maxLength
            if(this.FirstName != null && this.FirstName.Length > 128)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FirstName, length must be less than 128.", new [] { "FirstName" });
            }

            // FirstName (string) minLength
            if(this.FirstName != null && this.FirstName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FirstName, length must be greater than 1.", new [] { "FirstName" });
            }

            // LastName (string) maxLength
            if(this.LastName != null && this.LastName.Length > 128)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LastName, length must be less than 128.", new [] { "LastName" });
            }

            // LastName (string) minLength
            if(this.LastName != null && this.LastName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LastName, length must be greater than 1.", new [] { "LastName" });
            }

            // Username (string) maxLength
            if(this.Username != null && this.Username.Length > 256)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Username, length must be less than 256.", new [] { "Username" });
            }

            // Username (string) minLength
            if(this.Username != null && this.Username.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Username, length must be greater than 1.", new [] { "Username" });
            }

            // Username (string) pattern
            Regex regexUsername = new Regex(@"^([+@.\\w_-]+)$", RegexOptions.CultureInvariant);
            if (false == regexUsername.Match(this.Username).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Username, must match a pattern of " + regexUsername, new [] { "Username" });
            }

            yield break;
        }
    }

}
