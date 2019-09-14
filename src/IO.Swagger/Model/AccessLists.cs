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
    /// Access Control List entries for device or account
    /// </summary>
    [DataContract]
    public partial class AccessLists :  IEquatable<AccessLists>, IValidatableObject
    {
        /// <summary>
        /// Allow-Deny or Deny-Allow?
        /// </summary>
        /// <value>Allow-Deny or Deny-Allow?</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OrderEnum
        {
            
            /// <summary>
            /// Enum Allowdeny for value: allow,deny
            /// </summary>
            [EnumMember(Value = "allow,deny")]
            Allowdeny = 1,
            
            /// <summary>
            /// Enum Denyallow for value: deny,allow
            /// </summary>
            [EnumMember(Value = "deny,allow")]
            Denyallow = 2
        }

        /// <summary>
        /// Allow-Deny or Deny-Allow?
        /// </summary>
        /// <value>Allow-Deny or Deny-Allow?</value>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public OrderEnum Order { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessLists" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccessLists() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessLists" /> class.
        /// </summary>
        /// <param name="cidrs">Classless Inter-Domain Routing IP notation for use on the access lists (required).</param>
        /// <param name="order">Allow-Deny or Deny-Allow? (required).</param>
        /// <param name="userAgent">Regexp to match valid user agent strings.</param>
        public AccessLists(List<string> cidrs = default(List<string>), OrderEnum order = default(OrderEnum), string userAgent = default(string))
        {
            // to ensure "cidrs" is required (not null)
            if (cidrs == null)
            {
                throw new InvalidDataException("cidrs is a required property for AccessLists and cannot be null");
            }
            else
            {
                this.Cidrs = cidrs;
            }
            // to ensure "order" is required (not null)
            if (order == null)
            {
                throw new InvalidDataException("order is a required property for AccessLists and cannot be null");
            }
            else
            {
                this.Order = order;
            }
            this.UserAgent = userAgent;
        }
        
        /// <summary>
        /// Classless Inter-Domain Routing IP notation for use on the access lists
        /// </summary>
        /// <value>Classless Inter-Domain Routing IP notation for use on the access lists</value>
        [DataMember(Name="cidrs", EmitDefaultValue=false)]
        public List<string> Cidrs { get; set; }


        /// <summary>
        /// Regexp to match valid user agent strings
        /// </summary>
        /// <value>Regexp to match valid user agent strings</value>
        [DataMember(Name="user_agent", EmitDefaultValue=false)]
        public string UserAgent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccessLists {\n");
            sb.Append("  Cidrs: ").Append(Cidrs).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
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
            return this.Equals(input as AccessLists);
        }

        /// <summary>
        /// Returns true if AccessLists instances are equal
        /// </summary>
        /// <param name="input">Instance of AccessLists to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccessLists input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Cidrs == input.Cidrs ||
                    this.Cidrs != null &&
                    this.Cidrs.SequenceEqual(input.Cidrs)
                ) && 
                (
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
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
                if (this.Cidrs != null)
                    hashCode = hashCode * 59 + this.Cidrs.GetHashCode();
                if (this.Order != null)
                    hashCode = hashCode * 59 + this.Order.GetHashCode();
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