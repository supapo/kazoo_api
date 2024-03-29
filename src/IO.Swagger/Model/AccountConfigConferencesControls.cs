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
    /// AccountConfigConferencesControls
    /// </summary>
    [DataContract]
    public partial class AccountConfigConferencesControls :  IEquatable<AccountConfigConferencesControls>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountConfigConferencesControls" /> class.
        /// </summary>
        /// <param name="_default">conferences controls default.</param>
        /// <param name="page">conferences controls page.</param>
        public AccountConfigConferencesControls(List<AccountConfigConferencesControlsDefault> _default = default(List<AccountConfigConferencesControlsDefault>), List<AccountConfigConferencesControlsDefault> page = default(List<AccountConfigConferencesControlsDefault>))
        {
            this.Default = _default;
            this.Page = page;
        }
        
        /// <summary>
        /// conferences controls default
        /// </summary>
        /// <value>conferences controls default</value>
        [DataMember(Name="default", EmitDefaultValue=false)]
        public List<AccountConfigConferencesControlsDefault> Default { get; set; }

        /// <summary>
        /// conferences controls page
        /// </summary>
        /// <value>conferences controls page</value>
        [DataMember(Name="page", EmitDefaultValue=false)]
        public List<AccountConfigConferencesControlsDefault> Page { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountConfigConferencesControls {\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
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
            return this.Equals(input as AccountConfigConferencesControls);
        }

        /// <summary>
        /// Returns true if AccountConfigConferencesControls instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountConfigConferencesControls to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountConfigConferencesControls input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Default == input.Default ||
                    this.Default != null &&
                    this.Default.SequenceEqual(input.Default)
                ) && 
                (
                    this.Page == input.Page ||
                    this.Page != null &&
                    this.Page.SequenceEqual(input.Page)
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
                if (this.Default != null)
                    hashCode = hashCode * 59 + this.Default.GetHashCode();
                if (this.Page != null)
                    hashCode = hashCode * 59 + this.Page.GetHashCode();
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
