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
    /// Schema for accounts system_config
    /// </summary>
    [DataContract]
    public partial class SystemConfigAccounts :  IEquatable<SystemConfigAccounts>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemConfigAccounts" /> class.
        /// </summary>
        /// <param name="allowSubaccountsForDirect">accounts allow subaccounts for direct (default to true).</param>
        /// <param name="defaultTimezone">accounts default timezone (default to &quot;America/Los_Angeles&quot;).</param>
        /// <param name="masterAccountId">accounts master account id.</param>
        public SystemConfigAccounts(bool? allowSubaccountsForDirect = true, string defaultTimezone = "America/Los_Angeles", string masterAccountId = default(string))
        {
            // use default value if no "allowSubaccountsForDirect" provided
            if (allowSubaccountsForDirect == null)
            {
                this.AllowSubaccountsForDirect = true;
            }
            else
            {
                this.AllowSubaccountsForDirect = allowSubaccountsForDirect;
            }
            // use default value if no "defaultTimezone" provided
            if (defaultTimezone == null)
            {
                this.DefaultTimezone = "America/Los_Angeles";
            }
            else
            {
                this.DefaultTimezone = defaultTimezone;
            }
            this.MasterAccountId = masterAccountId;
        }
        
        /// <summary>
        /// accounts allow subaccounts for direct
        /// </summary>
        /// <value>accounts allow subaccounts for direct</value>
        [DataMember(Name="allow_subaccounts_for_direct", EmitDefaultValue=false)]
        public bool? AllowSubaccountsForDirect { get; set; }

        /// <summary>
        /// accounts default timezone
        /// </summary>
        /// <value>accounts default timezone</value>
        [DataMember(Name="default_timezone", EmitDefaultValue=false)]
        public string DefaultTimezone { get; set; }

        /// <summary>
        /// accounts master account id
        /// </summary>
        /// <value>accounts master account id</value>
        [DataMember(Name="master_account_id", EmitDefaultValue=false)]
        public string MasterAccountId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SystemConfigAccounts {\n");
            sb.Append("  AllowSubaccountsForDirect: ").Append(AllowSubaccountsForDirect).Append("\n");
            sb.Append("  DefaultTimezone: ").Append(DefaultTimezone).Append("\n");
            sb.Append("  MasterAccountId: ").Append(MasterAccountId).Append("\n");
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
            return this.Equals(input as SystemConfigAccounts);
        }

        /// <summary>
        /// Returns true if SystemConfigAccounts instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemConfigAccounts to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemConfigAccounts input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllowSubaccountsForDirect == input.AllowSubaccountsForDirect ||
                    (this.AllowSubaccountsForDirect != null &&
                    this.AllowSubaccountsForDirect.Equals(input.AllowSubaccountsForDirect))
                ) && 
                (
                    this.DefaultTimezone == input.DefaultTimezone ||
                    (this.DefaultTimezone != null &&
                    this.DefaultTimezone.Equals(input.DefaultTimezone))
                ) && 
                (
                    this.MasterAccountId == input.MasterAccountId ||
                    (this.MasterAccountId != null &&
                    this.MasterAccountId.Equals(input.MasterAccountId))
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
                if (this.AllowSubaccountsForDirect != null)
                    hashCode = hashCode * 59 + this.AllowSubaccountsForDirect.GetHashCode();
                if (this.DefaultTimezone != null)
                    hashCode = hashCode * 59 + this.DefaultTimezone.GetHashCode();
                if (this.MasterAccountId != null)
                    hashCode = hashCode * 59 + this.MasterAccountId.GetHashCode();
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