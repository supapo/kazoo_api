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
    /// AMQP API for call.query_auth_id_req
    /// </summary>
    [DataContract]
    public partial class KapiCallQueryAuthIdReq :  IEquatable<KapiCallQueryAuthIdReq>, IValidatableObject
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
            /// Enum Queryauthidreq for value: query_auth_id_req
            /// </summary>
            [EnumMember(Value = "query_auth_id_req")]
            Queryauthidreq = 1
        }

        /// <summary>
        /// Gets or Sets EventName
        /// </summary>
        [DataMember(Name="Event-Name", EmitDefaultValue=false)]
        public EventNameEnum? EventName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiCallQueryAuthIdReq" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KapiCallQueryAuthIdReq() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiCallQueryAuthIdReq" /> class.
        /// </summary>
        /// <param name="authID">authID (required).</param>
        /// <param name="eventCategory">eventCategory.</param>
        /// <param name="eventName">eventName.</param>
        public KapiCallQueryAuthIdReq(string authID = default(string), EventCategoryEnum? eventCategory = default(EventCategoryEnum?), EventNameEnum? eventName = default(EventNameEnum?))
        {
            // to ensure "authID" is required (not null)
            if (authID == null)
            {
                throw new InvalidDataException("authID is a required property for KapiCallQueryAuthIdReq and cannot be null");
            }
            else
            {
                this.AuthID = authID;
            }
            this.EventCategory = eventCategory;
            this.EventName = eventName;
        }
        
        /// <summary>
        /// Gets or Sets AuthID
        /// </summary>
        [DataMember(Name="Auth-ID", EmitDefaultValue=false)]
        public string AuthID { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KapiCallQueryAuthIdReq {\n");
            sb.Append("  AuthID: ").Append(AuthID).Append("\n");
            sb.Append("  EventCategory: ").Append(EventCategory).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
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
            return this.Equals(input as KapiCallQueryAuthIdReq);
        }

        /// <summary>
        /// Returns true if KapiCallQueryAuthIdReq instances are equal
        /// </summary>
        /// <param name="input">Instance of KapiCallQueryAuthIdReq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KapiCallQueryAuthIdReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AuthID == input.AuthID ||
                    (this.AuthID != null &&
                    this.AuthID.Equals(input.AuthID))
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
                if (this.AuthID != null)
                    hashCode = hashCode * 59 + this.AuthID.GetHashCode();
                if (this.EventCategory != null)
                    hashCode = hashCode * 59 + this.EventCategory.GetHashCode();
                if (this.EventName != null)
                    hashCode = hashCode * 59 + this.EventName.GetHashCode();
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