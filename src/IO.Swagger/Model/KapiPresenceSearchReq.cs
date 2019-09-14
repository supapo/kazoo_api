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
    /// AMQP API for presence.search_req
    /// </summary>
    [DataContract]
    public partial class KapiPresenceSearchReq :  IEquatable<KapiPresenceSearchReq>, IValidatableObject
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
            /// Enum Searchreq for value: search_req
            /// </summary>
            [EnumMember(Value = "search_req")]
            Searchreq = 1
        }

        /// <summary>
        /// Gets or Sets EventName
        /// </summary>
        [DataMember(Name="Event-Name", EmitDefaultValue=false)]
        public EventNameEnum? EventName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiPresenceSearchReq" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KapiPresenceSearchReq() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiPresenceSearchReq" /> class.
        /// </summary>
        /// <param name="eventCategory">eventCategory.</param>
        /// <param name="eventName">eventName.</param>
        /// <param name="eventPackage">eventPackage.</param>
        /// <param name="realm">realm (required).</param>
        /// <param name="searchType">searchType.</param>
        /// <param name="username">username.</param>
        public KapiPresenceSearchReq(EventCategoryEnum? eventCategory = default(EventCategoryEnum?), EventNameEnum? eventName = default(EventNameEnum?), string eventPackage = default(string), string realm = default(string), string searchType = default(string), string username = default(string))
        {
            // to ensure "realm" is required (not null)
            if (realm == null)
            {
                throw new InvalidDataException("realm is a required property for KapiPresenceSearchReq and cannot be null");
            }
            else
            {
                this.Realm = realm;
            }
            this.EventCategory = eventCategory;
            this.EventName = eventName;
            this.EventPackage = eventPackage;
            this.SearchType = searchType;
            this.Username = username;
        }
        


        /// <summary>
        /// Gets or Sets EventPackage
        /// </summary>
        [DataMember(Name="Event-Package", EmitDefaultValue=false)]
        public string EventPackage { get; set; }

        /// <summary>
        /// Gets or Sets Realm
        /// </summary>
        [DataMember(Name="Realm", EmitDefaultValue=false)]
        public string Realm { get; set; }

        /// <summary>
        /// Gets or Sets SearchType
        /// </summary>
        [DataMember(Name="Search-Type", EmitDefaultValue=false)]
        public string SearchType { get; set; }

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
            sb.Append("class KapiPresenceSearchReq {\n");
            sb.Append("  EventCategory: ").Append(EventCategory).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  EventPackage: ").Append(EventPackage).Append("\n");
            sb.Append("  Realm: ").Append(Realm).Append("\n");
            sb.Append("  SearchType: ").Append(SearchType).Append("\n");
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
            return this.Equals(input as KapiPresenceSearchReq);
        }

        /// <summary>
        /// Returns true if KapiPresenceSearchReq instances are equal
        /// </summary>
        /// <param name="input">Instance of KapiPresenceSearchReq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KapiPresenceSearchReq input)
        {
            if (input == null)
                return false;

            return 
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
                    this.Realm == input.Realm ||
                    (this.Realm != null &&
                    this.Realm.Equals(input.Realm))
                ) && 
                (
                    this.SearchType == input.SearchType ||
                    (this.SearchType != null &&
                    this.SearchType.Equals(input.SearchType))
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
                if (this.EventCategory != null)
                    hashCode = hashCode * 59 + this.EventCategory.GetHashCode();
                if (this.EventName != null)
                    hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.EventPackage != null)
                    hashCode = hashCode * 59 + this.EventPackage.GetHashCode();
                if (this.Realm != null)
                    hashCode = hashCode * 59 + this.Realm.GetHashCode();
                if (this.SearchType != null)
                    hashCode = hashCode * 59 + this.SearchType.GetHashCode();
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