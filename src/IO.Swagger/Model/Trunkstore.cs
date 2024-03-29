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
    /// Trunkstore configuration document - this is old stuff; do not recommend building off this if possible
    /// </summary>
    [DataContract]
    public partial class Trunkstore :  IEquatable<Trunkstore>, IValidatableObject
    {
        /// <summary>
        /// The type of the document (pvt_type in Crossbar docs)
        /// </summary>
        /// <value>The type of the document (pvt_type in Crossbar docs)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Sysinfo for value: sys_info
            /// </summary>
            [EnumMember(Value = "sys_info")]
            Sysinfo = 1
        }

        /// <summary>
        /// The type of the document (pvt_type in Crossbar docs)
        /// </summary>
        /// <value>The type of the document (pvt_type in Crossbar docs)</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Trunkstore" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Trunkstore() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Trunkstore" /> class.
        /// </summary>
        /// <param name="account">account (required).</param>
        /// <param name="callRestriction">Trunk level call restrictions for each available number classification.</param>
        /// <param name="name">Human-friendly name of the trunkstore account.</param>
        /// <param name="servers">What servers will be allowed to make/receive calls via this account.</param>
        /// <param name="type">The type of the document (pvt_type in Crossbar docs) (required).</param>
        public Trunkstore(TrunkstoreAccount account = default(TrunkstoreAccount), Dictionary<string, TrunkstoreCallRestriction> callRestriction = default(Dictionary<string, TrunkstoreCallRestriction>), string name = default(string), List<TrunkstoreServers> servers = default(List<TrunkstoreServers>), TypeEnum type = default(TypeEnum))
        {
            // to ensure "account" is required (not null)
            if (account == null)
            {
                throw new InvalidDataException("account is a required property for Trunkstore and cannot be null");
            }
            else
            {
                this.Account = account;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for Trunkstore and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            this.CallRestriction = callRestriction;
            this.Name = name;
            this.Servers = servers;
        }
        
        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name="account", EmitDefaultValue=false)]
        public TrunkstoreAccount Account { get; set; }

        /// <summary>
        /// Trunk level call restrictions for each available number classification
        /// </summary>
        /// <value>Trunk level call restrictions for each available number classification</value>
        [DataMember(Name="call_restriction", EmitDefaultValue=false)]
        public Dictionary<string, TrunkstoreCallRestriction> CallRestriction { get; set; }

        /// <summary>
        /// Human-friendly name of the trunkstore account
        /// </summary>
        /// <value>Human-friendly name of the trunkstore account</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// What servers will be allowed to make/receive calls via this account
        /// </summary>
        /// <value>What servers will be allowed to make/receive calls via this account</value>
        [DataMember(Name="servers", EmitDefaultValue=false)]
        public List<TrunkstoreServers> Servers { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Trunkstore {\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  CallRestriction: ").Append(CallRestriction).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Servers: ").Append(Servers).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as Trunkstore);
        }

        /// <summary>
        /// Returns true if Trunkstore instances are equal
        /// </summary>
        /// <param name="input">Instance of Trunkstore to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Trunkstore input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && 
                (
                    this.CallRestriction == input.CallRestriction ||
                    this.CallRestriction != null &&
                    this.CallRestriction.SequenceEqual(input.CallRestriction)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Servers == input.Servers ||
                    this.Servers != null &&
                    this.Servers.SequenceEqual(input.Servers)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.CallRestriction != null)
                    hashCode = hashCode * 59 + this.CallRestriction.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Servers != null)
                    hashCode = hashCode * 59 + this.Servers.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
