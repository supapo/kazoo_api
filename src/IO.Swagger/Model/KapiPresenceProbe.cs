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
    /// AMQP API for presence.probe
    /// </summary>
    [DataContract]
    public partial class KapiPresenceProbe :  IEquatable<KapiPresenceProbe>, IValidatableObject
    {
        /// <summary>
        /// Defines EventCategory
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventCategoryEnum
        {
            
            /// <summary>
            /// Enum Presence for value: presence
            /// </summary>
            [EnumMember(Value = "presence")]
            Presence = 1
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
            /// Enum Probe for value: probe
            /// </summary>
            [EnumMember(Value = "probe")]
            Probe = 1
        }

        /// <summary>
        /// Gets or Sets EventName
        /// </summary>
        [DataMember(Name="Event-Name", EmitDefaultValue=false)]
        public EventNameEnum? EventName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiPresenceProbe" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KapiPresenceProbe() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiPresenceProbe" /> class.
        /// </summary>
        /// <param name="callID">callID.</param>
        /// <param name="eventCategory">eventCategory.</param>
        /// <param name="eventName">eventName.</param>
        /// <param name="eventPackage">eventPackage (required).</param>
        /// <param name="expires">expires.</param>
        /// <param name="fromRealm">fromRealm.</param>
        /// <param name="fromUser">fromUser.</param>
        /// <param name="realm">realm (required).</param>
        /// <param name="toRealm">toRealm.</param>
        /// <param name="toUser">toUser.</param>
        /// <param name="username">username (required).</param>
        public KapiPresenceProbe(string callID = default(string), EventCategoryEnum? eventCategory = default(EventCategoryEnum?), EventNameEnum? eventName = default(EventNameEnum?), string eventPackage = default(string), string expires = default(string), string fromRealm = default(string), string fromUser = default(string), string realm = default(string), string toRealm = default(string), string toUser = default(string), string username = default(string))
        {
            // to ensure "eventPackage" is required (not null)
            if (eventPackage == null)
            {
                throw new InvalidDataException("eventPackage is a required property for KapiPresenceProbe and cannot be null");
            }
            else
            {
                this.EventPackage = eventPackage;
            }
            // to ensure "realm" is required (not null)
            if (realm == null)
            {
                throw new InvalidDataException("realm is a required property for KapiPresenceProbe and cannot be null");
            }
            else
            {
                this.Realm = realm;
            }
            // to ensure "username" is required (not null)
            if (username == null)
            {
                throw new InvalidDataException("username is a required property for KapiPresenceProbe and cannot be null");
            }
            else
            {
                this.Username = username;
            }
            this.CallID = callID;
            this.EventCategory = eventCategory;
            this.EventName = eventName;
            this.Expires = expires;
            this.FromRealm = fromRealm;
            this.FromUser = fromUser;
            this.ToRealm = toRealm;
            this.ToUser = toUser;
        }
        
        /// <summary>
        /// Gets or Sets CallID
        /// </summary>
        [DataMember(Name="Call-ID", EmitDefaultValue=false)]
        public string CallID { get; set; }



        /// <summary>
        /// Gets or Sets EventPackage
        /// </summary>
        [DataMember(Name="Event-Package", EmitDefaultValue=false)]
        public string EventPackage { get; set; }

        /// <summary>
        /// Gets or Sets Expires
        /// </summary>
        [DataMember(Name="Expires", EmitDefaultValue=false)]
        public string Expires { get; set; }

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
        /// Gets or Sets Realm
        /// </summary>
        [DataMember(Name="Realm", EmitDefaultValue=false)]
        public string Realm { get; set; }

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
            sb.Append("class KapiPresenceProbe {\n");
            sb.Append("  CallID: ").Append(CallID).Append("\n");
            sb.Append("  EventCategory: ").Append(EventCategory).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  EventPackage: ").Append(EventPackage).Append("\n");
            sb.Append("  Expires: ").Append(Expires).Append("\n");
            sb.Append("  FromRealm: ").Append(FromRealm).Append("\n");
            sb.Append("  FromUser: ").Append(FromUser).Append("\n");
            sb.Append("  Realm: ").Append(Realm).Append("\n");
            sb.Append("  ToRealm: ").Append(ToRealm).Append("\n");
            sb.Append("  ToUser: ").Append(ToUser).Append("\n");
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
            return this.Equals(input as KapiPresenceProbe);
        }

        /// <summary>
        /// Returns true if KapiPresenceProbe instances are equal
        /// </summary>
        /// <param name="input">Instance of KapiPresenceProbe to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KapiPresenceProbe input)
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
                    this.EventPackage == input.EventPackage ||
                    (this.EventPackage != null &&
                    this.EventPackage.Equals(input.EventPackage))
                ) && 
                (
                    this.Expires == input.Expires ||
                    (this.Expires != null &&
                    this.Expires.Equals(input.Expires))
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
                    this.Realm == input.Realm ||
                    (this.Realm != null &&
                    this.Realm.Equals(input.Realm))
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
                if (this.EventCategory != null)
                    hashCode = hashCode * 59 + this.EventCategory.GetHashCode();
                if (this.EventName != null)
                    hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.EventPackage != null)
                    hashCode = hashCode * 59 + this.EventPackage.GetHashCode();
                if (this.Expires != null)
                    hashCode = hashCode * 59 + this.Expires.GetHashCode();
                if (this.FromRealm != null)
                    hashCode = hashCode * 59 + this.FromRealm.GetHashCode();
                if (this.FromUser != null)
                    hashCode = hashCode * 59 + this.FromUser.GetHashCode();
                if (this.Realm != null)
                    hashCode = hashCode * 59 + this.Realm.GetHashCode();
                if (this.ToRealm != null)
                    hashCode = hashCode * 59 + this.ToRealm.GetHashCode();
                if (this.ToUser != null)
                    hashCode = hashCode * 59 + this.ToUser.GetHashCode();
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