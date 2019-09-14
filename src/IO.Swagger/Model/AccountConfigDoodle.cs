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
    /// Schema for doodle account_config
    /// </summary>
    [DataContract]
    public partial class AccountConfigDoodle :  IEquatable<AccountConfigDoodle>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountConfigDoodle" /> class.
        /// </summary>
        /// <param name="apiPreserveCallerId">doodle.api preserve caller id (default to true).</param>
        /// <param name="reschedule">doodle reschedule.</param>
        public AccountConfigDoodle(bool? apiPreserveCallerId = true, Object reschedule = default(Object))
        {
            // use default value if no "apiPreserveCallerId" provided
            if (apiPreserveCallerId == null)
            {
                this.ApiPreserveCallerId = true;
            }
            else
            {
                this.ApiPreserveCallerId = apiPreserveCallerId;
            }
            this.Reschedule = reschedule;
        }
        
        /// <summary>
        /// doodle.api preserve caller id
        /// </summary>
        /// <value>doodle.api preserve caller id</value>
        [DataMember(Name="api_preserve_caller_id", EmitDefaultValue=false)]
        public bool? ApiPreserveCallerId { get; set; }

        /// <summary>
        /// doodle reschedule
        /// </summary>
        /// <value>doodle reschedule</value>
        [DataMember(Name="reschedule", EmitDefaultValue=false)]
        public Object Reschedule { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountConfigDoodle {\n");
            sb.Append("  ApiPreserveCallerId: ").Append(ApiPreserveCallerId).Append("\n");
            sb.Append("  Reschedule: ").Append(Reschedule).Append("\n");
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
            return this.Equals(input as AccountConfigDoodle);
        }

        /// <summary>
        /// Returns true if AccountConfigDoodle instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountConfigDoodle to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountConfigDoodle input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApiPreserveCallerId == input.ApiPreserveCallerId ||
                    (this.ApiPreserveCallerId != null &&
                    this.ApiPreserveCallerId.Equals(input.ApiPreserveCallerId))
                ) && 
                (
                    this.Reschedule == input.Reschedule ||
                    (this.Reschedule != null &&
                    this.Reschedule.Equals(input.Reschedule))
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
                if (this.ApiPreserveCallerId != null)
                    hashCode = hashCode * 59 + this.ApiPreserveCallerId.GetHashCode();
                if (this.Reschedule != null)
                    hashCode = hashCode * 59 + this.Reschedule.GetHashCode();
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