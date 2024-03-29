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
    /// AMQP API for authz.balance_check_resp
    /// </summary>
    [DataContract]
    public partial class KapiAuthzBalanceCheckResp :  IEquatable<KapiAuthzBalanceCheckResp>, IValidatableObject
    {
        /// <summary>
        /// Defines EventCategory
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventCategoryEnum
        {
            
            /// <summary>
            /// Enum Authz for value: authz
            /// </summary>
            [EnumMember(Value = "authz")]
            Authz = 1
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
            /// Enum Balancecheckresp for value: balance_check_resp
            /// </summary>
            [EnumMember(Value = "balance_check_resp")]
            Balancecheckresp = 1
        }

        /// <summary>
        /// Gets or Sets EventName
        /// </summary>
        [DataMember(Name="Event-Name", EmitDefaultValue=false)]
        public EventNameEnum? EventName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiAuthzBalanceCheckResp" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KapiAuthzBalanceCheckResp() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiAuthzBalanceCheckResp" /> class.
        /// </summary>
        /// <param name="balances">balances (required).</param>
        /// <param name="eventCategory">eventCategory.</param>
        /// <param name="eventName">eventName.</param>
        public KapiAuthzBalanceCheckResp(Object balances = default(Object), EventCategoryEnum? eventCategory = default(EventCategoryEnum?), EventNameEnum? eventName = default(EventNameEnum?))
        {
            // to ensure "balances" is required (not null)
            if (balances == null)
            {
                throw new InvalidDataException("balances is a required property for KapiAuthzBalanceCheckResp and cannot be null");
            }
            else
            {
                this.Balances = balances;
            }
            this.EventCategory = eventCategory;
            this.EventName = eventName;
        }
        
        /// <summary>
        /// Gets or Sets Balances
        /// </summary>
        [DataMember(Name="Balances", EmitDefaultValue=false)]
        public Object Balances { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KapiAuthzBalanceCheckResp {\n");
            sb.Append("  Balances: ").Append(Balances).Append("\n");
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
            return this.Equals(input as KapiAuthzBalanceCheckResp);
        }

        /// <summary>
        /// Returns true if KapiAuthzBalanceCheckResp instances are equal
        /// </summary>
        /// <param name="input">Instance of KapiAuthzBalanceCheckResp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KapiAuthzBalanceCheckResp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Balances == input.Balances ||
                    (this.Balances != null &&
                    this.Balances.Equals(input.Balances))
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
                if (this.Balances != null)
                    hashCode = hashCode * 59 + this.Balances.GetHashCode();
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
