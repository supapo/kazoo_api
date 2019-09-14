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
    /// Put the leg on hold
    /// </summary>
    [DataContract]
    public partial class MetaflowsHold :  IEquatable<MetaflowsHold>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetaflowsHold" /> class.
        /// </summary>
        /// <param name="mohAleg">MOH ID for the a-leg.</param>
        /// <param name="mohBleg">MOH ID for the b-leg.</param>
        /// <param name="unholdKey">DTMF to press to unhold the call (default to &quot;1&quot;).</param>
        public MetaflowsHold(string mohAleg = default(string), string mohBleg = default(string), string unholdKey = "1")
        {
            this.MohAleg = mohAleg;
            this.MohBleg = mohBleg;
            // use default value if no "unholdKey" provided
            if (unholdKey == null)
            {
                this.UnholdKey = "1";
            }
            else
            {
                this.UnholdKey = unholdKey;
            }
        }
        
        /// <summary>
        /// MOH ID for the a-leg
        /// </summary>
        /// <value>MOH ID for the a-leg</value>
        [DataMember(Name="moh_aleg", EmitDefaultValue=false)]
        public string MohAleg { get; set; }

        /// <summary>
        /// MOH ID for the b-leg
        /// </summary>
        /// <value>MOH ID for the b-leg</value>
        [DataMember(Name="moh_bleg", EmitDefaultValue=false)]
        public string MohBleg { get; set; }

        /// <summary>
        /// DTMF to press to unhold the call
        /// </summary>
        /// <value>DTMF to press to unhold the call</value>
        [DataMember(Name="unhold_key", EmitDefaultValue=false)]
        public string UnholdKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetaflowsHold {\n");
            sb.Append("  MohAleg: ").Append(MohAleg).Append("\n");
            sb.Append("  MohBleg: ").Append(MohBleg).Append("\n");
            sb.Append("  UnholdKey: ").Append(UnholdKey).Append("\n");
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
            return this.Equals(input as MetaflowsHold);
        }

        /// <summary>
        /// Returns true if MetaflowsHold instances are equal
        /// </summary>
        /// <param name="input">Instance of MetaflowsHold to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MetaflowsHold input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MohAleg == input.MohAleg ||
                    (this.MohAleg != null &&
                    this.MohAleg.Equals(input.MohAleg))
                ) && 
                (
                    this.MohBleg == input.MohBleg ||
                    (this.MohBleg != null &&
                    this.MohBleg.Equals(input.MohBleg))
                ) && 
                (
                    this.UnholdKey == input.UnholdKey ||
                    (this.UnholdKey != null &&
                    this.UnholdKey.Equals(input.UnholdKey))
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
                if (this.MohAleg != null)
                    hashCode = hashCode * 59 + this.MohAleg.GetHashCode();
                if (this.MohBleg != null)
                    hashCode = hashCode * 59 + this.MohBleg.GetHashCode();
                if (this.UnholdKey != null)
                    hashCode = hashCode * 59 + this.UnholdKey.GetHashCode();
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
