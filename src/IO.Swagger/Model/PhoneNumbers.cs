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
    /// Schema for a number
    /// </summary>
    [DataContract]
    public partial class PhoneNumbers :  IEquatable<PhoneNumbers>, IValidatableObject
    {
        /// <summary>
        /// The state to create numbers in
        /// </summary>
        /// <value>The state to create numbers in</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CreateWithStateEnum
        {
            
            /// <summary>
            /// Enum Aging for value: aging
            /// </summary>
            [EnumMember(Value = "aging")]
            Aging = 1,
            
            /// <summary>
            /// Enum Available for value: available
            /// </summary>
            [EnumMember(Value = "available")]
            Available = 2,
            
            /// <summary>
            /// Enum Deleted for value: deleted
            /// </summary>
            [EnumMember(Value = "deleted")]
            Deleted = 3,
            
            /// <summary>
            /// Enum Discovery for value: discovery
            /// </summary>
            [EnumMember(Value = "discovery")]
            Discovery = 4,
            
            /// <summary>
            /// Enum Inservice for value: in_service
            /// </summary>
            [EnumMember(Value = "in_service")]
            Inservice = 5,
            
            /// <summary>
            /// Enum Portin for value: port_in
            /// </summary>
            [EnumMember(Value = "port_in")]
            Portin = 6,
            
            /// <summary>
            /// Enum Portout for value: port_out
            /// </summary>
            [EnumMember(Value = "port_out")]
            Portout = 7,
            
            /// <summary>
            /// Enum Released for value: released
            /// </summary>
            [EnumMember(Value = "released")]
            Released = 8,
            
            /// <summary>
            /// Enum Reserved for value: reserved
            /// </summary>
            [EnumMember(Value = "reserved")]
            Reserved = 9
        }

        /// <summary>
        /// The state to create numbers in
        /// </summary>
        /// <value>The state to create numbers in</value>
        [DataMember(Name="create_with_state", EmitDefaultValue=false)]
        public CreateWithStateEnum? CreateWithState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumbers" /> class.
        /// </summary>
        /// <param name="carrierName">carrierName.</param>
        /// <param name="cnam">cnam.</param>
        /// <param name="createWithState">The state to create numbers in.</param>
        /// <param name="e911">e911.</param>
        /// <param name="porting">porting.</param>
        public PhoneNumbers(string carrierName = default(string), PhoneNumbersCnam cnam = default(PhoneNumbersCnam), CreateWithStateEnum? createWithState = default(CreateWithStateEnum?), PhoneNumbersE911 e911 = default(PhoneNumbersE911), PhoneNumbersPorting porting = default(PhoneNumbersPorting))
        {
            this.CarrierName = carrierName;
            this.Cnam = cnam;
            this.CreateWithState = createWithState;
            this.E911 = e911;
            this.Porting = porting;
        }
        
        /// <summary>
        /// Gets or Sets CarrierName
        /// </summary>
        [DataMember(Name="carrier_name", EmitDefaultValue=false)]
        public string CarrierName { get; set; }

        /// <summary>
        /// Gets or Sets Cnam
        /// </summary>
        [DataMember(Name="cnam", EmitDefaultValue=false)]
        public PhoneNumbersCnam Cnam { get; set; }


        /// <summary>
        /// Gets or Sets E911
        /// </summary>
        [DataMember(Name="e911", EmitDefaultValue=false)]
        public PhoneNumbersE911 E911 { get; set; }

        /// <summary>
        /// Gets or Sets Porting
        /// </summary>
        [DataMember(Name="porting", EmitDefaultValue=false)]
        public PhoneNumbersPorting Porting { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PhoneNumbers {\n");
            sb.Append("  CarrierName: ").Append(CarrierName).Append("\n");
            sb.Append("  Cnam: ").Append(Cnam).Append("\n");
            sb.Append("  CreateWithState: ").Append(CreateWithState).Append("\n");
            sb.Append("  E911: ").Append(E911).Append("\n");
            sb.Append("  Porting: ").Append(Porting).Append("\n");
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
            return this.Equals(input as PhoneNumbers);
        }

        /// <summary>
        /// Returns true if PhoneNumbers instances are equal
        /// </summary>
        /// <param name="input">Instance of PhoneNumbers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhoneNumbers input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CarrierName == input.CarrierName ||
                    (this.CarrierName != null &&
                    this.CarrierName.Equals(input.CarrierName))
                ) && 
                (
                    this.Cnam == input.Cnam ||
                    (this.Cnam != null &&
                    this.Cnam.Equals(input.Cnam))
                ) && 
                (
                    this.CreateWithState == input.CreateWithState ||
                    (this.CreateWithState != null &&
                    this.CreateWithState.Equals(input.CreateWithState))
                ) && 
                (
                    this.E911 == input.E911 ||
                    (this.E911 != null &&
                    this.E911.Equals(input.E911))
                ) && 
                (
                    this.Porting == input.Porting ||
                    (this.Porting != null &&
                    this.Porting.Equals(input.Porting))
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
                if (this.CarrierName != null)
                    hashCode = hashCode * 59 + this.CarrierName.GetHashCode();
                if (this.Cnam != null)
                    hashCode = hashCode * 59 + this.Cnam.GetHashCode();
                if (this.CreateWithState != null)
                    hashCode = hashCode * 59 + this.CreateWithState.GetHashCode();
                if (this.E911 != null)
                    hashCode = hashCode * 59 + this.E911.GetHashCode();
                if (this.Porting != null)
                    hashCode = hashCode * 59 + this.Porting.GetHashCode();
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
            // CarrierName (string) maxLength
            if(this.CarrierName != null && this.CarrierName.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CarrierName, length must be less than 30.", new [] { "CarrierName" });
            }

            // CarrierName (string) minLength
            if(this.CarrierName != null && this.CarrierName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CarrierName, length must be greater than 1.", new [] { "CarrierName" });
            }

            yield break;
        }
    }

}