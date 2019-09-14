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
    /// Schema for number_manager.other system_config
    /// </summary>
    [DataContract]
    public partial class SystemConfigNumberManagerOther :  IEquatable<SystemConfigNumberManagerOther>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemConfigNumberManagerOther" /> class.
        /// </summary>
        /// <param name="defaultCountry">Country to search and acquire blocks of numbers from (default to &quot;US&quot;).</param>
        /// <param name="endpoints">number_manager.other endpoints.</param>
        /// <param name="phonebookUrl">number_manager.other phonebook url.</param>
        public SystemConfigNumberManagerOther(string defaultCountry = "US", Object endpoints = default(Object), string phonebookUrl = default(string))
        {
            // use default value if no "defaultCountry" provided
            if (defaultCountry == null)
            {
                this.DefaultCountry = "US";
            }
            else
            {
                this.DefaultCountry = defaultCountry;
            }
            this.Endpoints = endpoints;
            this.PhonebookUrl = phonebookUrl;
        }
        
        /// <summary>
        /// Country to search and acquire blocks of numbers from
        /// </summary>
        /// <value>Country to search and acquire blocks of numbers from</value>
        [DataMember(Name="default_country", EmitDefaultValue=false)]
        public string DefaultCountry { get; set; }

        /// <summary>
        /// number_manager.other endpoints
        /// </summary>
        /// <value>number_manager.other endpoints</value>
        [DataMember(Name="endpoints", EmitDefaultValue=false)]
        public Object Endpoints { get; set; }

        /// <summary>
        /// number_manager.other phonebook url
        /// </summary>
        /// <value>number_manager.other phonebook url</value>
        [DataMember(Name="phonebook_url", EmitDefaultValue=false)]
        public string PhonebookUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SystemConfigNumberManagerOther {\n");
            sb.Append("  DefaultCountry: ").Append(DefaultCountry).Append("\n");
            sb.Append("  Endpoints: ").Append(Endpoints).Append("\n");
            sb.Append("  PhonebookUrl: ").Append(PhonebookUrl).Append("\n");
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
            return this.Equals(input as SystemConfigNumberManagerOther);
        }

        /// <summary>
        /// Returns true if SystemConfigNumberManagerOther instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemConfigNumberManagerOther to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemConfigNumberManagerOther input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DefaultCountry == input.DefaultCountry ||
                    (this.DefaultCountry != null &&
                    this.DefaultCountry.Equals(input.DefaultCountry))
                ) && 
                (
                    this.Endpoints == input.Endpoints ||
                    (this.Endpoints != null &&
                    this.Endpoints.Equals(input.Endpoints))
                ) && 
                (
                    this.PhonebookUrl == input.PhonebookUrl ||
                    (this.PhonebookUrl != null &&
                    this.PhonebookUrl.Equals(input.PhonebookUrl))
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
                if (this.DefaultCountry != null)
                    hashCode = hashCode * 59 + this.DefaultCountry.GetHashCode();
                if (this.Endpoints != null)
                    hashCode = hashCode * 59 + this.Endpoints.GetHashCode();
                if (this.PhonebookUrl != null)
                    hashCode = hashCode * 59 + this.PhonebookUrl.GetHashCode();
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
