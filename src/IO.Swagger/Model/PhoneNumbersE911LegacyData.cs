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
    /// Legacy E911 information
    /// </summary>
    [DataContract]
    public partial class PhoneNumbersE911LegacyData :  IEquatable<PhoneNumbersE911LegacyData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumbersE911LegacyData" /> class.
        /// </summary>
        /// <param name="houseNumber">The name that will show to emergency services.</param>
        /// <param name="predirectional">The name that will show to emergency services.</param>
        /// <param name="streetname">The name that will show to emergency services.</param>
        /// <param name="suite">The name that will show to emergency services.</param>
        public PhoneNumbersE911LegacyData(string houseNumber = default(string), string predirectional = default(string), string streetname = default(string), string suite = default(string))
        {
            this.HouseNumber = houseNumber;
            this.Predirectional = predirectional;
            this.Streetname = streetname;
            this.Suite = suite;
        }
        
        /// <summary>
        /// The name that will show to emergency services
        /// </summary>
        /// <value>The name that will show to emergency services</value>
        [DataMember(Name="house_number", EmitDefaultValue=false)]
        public string HouseNumber { get; set; }

        /// <summary>
        /// The name that will show to emergency services
        /// </summary>
        /// <value>The name that will show to emergency services</value>
        [DataMember(Name="predirectional", EmitDefaultValue=false)]
        public string Predirectional { get; set; }

        /// <summary>
        /// The name that will show to emergency services
        /// </summary>
        /// <value>The name that will show to emergency services</value>
        [DataMember(Name="streetname", EmitDefaultValue=false)]
        public string Streetname { get; set; }

        /// <summary>
        /// The name that will show to emergency services
        /// </summary>
        /// <value>The name that will show to emergency services</value>
        [DataMember(Name="suite", EmitDefaultValue=false)]
        public string Suite { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PhoneNumbersE911LegacyData {\n");
            sb.Append("  HouseNumber: ").Append(HouseNumber).Append("\n");
            sb.Append("  Predirectional: ").Append(Predirectional).Append("\n");
            sb.Append("  Streetname: ").Append(Streetname).Append("\n");
            sb.Append("  Suite: ").Append(Suite).Append("\n");
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
            return this.Equals(input as PhoneNumbersE911LegacyData);
        }

        /// <summary>
        /// Returns true if PhoneNumbersE911LegacyData instances are equal
        /// </summary>
        /// <param name="input">Instance of PhoneNumbersE911LegacyData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhoneNumbersE911LegacyData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HouseNumber == input.HouseNumber ||
                    (this.HouseNumber != null &&
                    this.HouseNumber.Equals(input.HouseNumber))
                ) && 
                (
                    this.Predirectional == input.Predirectional ||
                    (this.Predirectional != null &&
                    this.Predirectional.Equals(input.Predirectional))
                ) && 
                (
                    this.Streetname == input.Streetname ||
                    (this.Streetname != null &&
                    this.Streetname.Equals(input.Streetname))
                ) && 
                (
                    this.Suite == input.Suite ||
                    (this.Suite != null &&
                    this.Suite.Equals(input.Suite))
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
                if (this.HouseNumber != null)
                    hashCode = hashCode * 59 + this.HouseNumber.GetHashCode();
                if (this.Predirectional != null)
                    hashCode = hashCode * 59 + this.Predirectional.GetHashCode();
                if (this.Streetname != null)
                    hashCode = hashCode * 59 + this.Streetname.GetHashCode();
                if (this.Suite != null)
                    hashCode = hashCode * 59 + this.Suite.GetHashCode();
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
