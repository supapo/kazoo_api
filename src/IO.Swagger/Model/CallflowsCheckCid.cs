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
    /// Validator for the check_cid callflow data object
    /// </summary>
    [DataContract]
    public partial class CallflowsCheckCid :  IEquatable<CallflowsCheckCid>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CallflowsCheckCid" /> class.
        /// </summary>
        /// <param name="callerId">callerId.</param>
        /// <param name="regex">Determine match/nomatch when use_absolute_mode is false (default to &quot;.*&quot;).</param>
        /// <param name="skipModule">When set to true this callflow action is skipped, advancing to the wildcard branch (if any).</param>
        /// <param name="useAbsoluteMode">If true, direct call down a branch that matches the caller ID (default to false).</param>
        /// <param name="userId">kazoo User ID to use as owner_id instead of detected owner_id.</param>
        public CallflowsCheckCid(CallflowsCheckCidCallerId callerId = default(CallflowsCheckCidCallerId), string regex = ".*", bool? skipModule = default(bool?), bool? useAbsoluteMode = false, string userId = default(string))
        {
            this.CallerId = callerId;
            // use default value if no "regex" provided
            if (regex == null)
            {
                this.Regex = ".*";
            }
            else
            {
                this.Regex = regex;
            }
            this.SkipModule = skipModule;
            // use default value if no "useAbsoluteMode" provided
            if (useAbsoluteMode == null)
            {
                this.UseAbsoluteMode = false;
            }
            else
            {
                this.UseAbsoluteMode = useAbsoluteMode;
            }
            this.UserId = userId;
        }
        
        /// <summary>
        /// Gets or Sets CallerId
        /// </summary>
        [DataMember(Name="caller_id", EmitDefaultValue=false)]
        public CallflowsCheckCidCallerId CallerId { get; set; }

        /// <summary>
        /// Determine match/nomatch when use_absolute_mode is false
        /// </summary>
        /// <value>Determine match/nomatch when use_absolute_mode is false</value>
        [DataMember(Name="regex", EmitDefaultValue=false)]
        public string Regex { get; set; }

        /// <summary>
        /// When set to true this callflow action is skipped, advancing to the wildcard branch (if any)
        /// </summary>
        /// <value>When set to true this callflow action is skipped, advancing to the wildcard branch (if any)</value>
        [DataMember(Name="skip_module", EmitDefaultValue=false)]
        public bool? SkipModule { get; set; }

        /// <summary>
        /// If true, direct call down a branch that matches the caller ID
        /// </summary>
        /// <value>If true, direct call down a branch that matches the caller ID</value>
        [DataMember(Name="use_absolute_mode", EmitDefaultValue=false)]
        public bool? UseAbsoluteMode { get; set; }

        /// <summary>
        /// kazoo User ID to use as owner_id instead of detected owner_id
        /// </summary>
        /// <value>kazoo User ID to use as owner_id instead of detected owner_id</value>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public string UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CallflowsCheckCid {\n");
            sb.Append("  CallerId: ").Append(CallerId).Append("\n");
            sb.Append("  Regex: ").Append(Regex).Append("\n");
            sb.Append("  SkipModule: ").Append(SkipModule).Append("\n");
            sb.Append("  UseAbsoluteMode: ").Append(UseAbsoluteMode).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(input as CallflowsCheckCid);
        }

        /// <summary>
        /// Returns true if CallflowsCheckCid instances are equal
        /// </summary>
        /// <param name="input">Instance of CallflowsCheckCid to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallflowsCheckCid input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CallerId == input.CallerId ||
                    (this.CallerId != null &&
                    this.CallerId.Equals(input.CallerId))
                ) && 
                (
                    this.Regex == input.Regex ||
                    (this.Regex != null &&
                    this.Regex.Equals(input.Regex))
                ) && 
                (
                    this.SkipModule == input.SkipModule ||
                    (this.SkipModule != null &&
                    this.SkipModule.Equals(input.SkipModule))
                ) && 
                (
                    this.UseAbsoluteMode == input.UseAbsoluteMode ||
                    (this.UseAbsoluteMode != null &&
                    this.UseAbsoluteMode.Equals(input.UseAbsoluteMode))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                if (this.CallerId != null)
                    hashCode = hashCode * 59 + this.CallerId.GetHashCode();
                if (this.Regex != null)
                    hashCode = hashCode * 59 + this.Regex.GetHashCode();
                if (this.SkipModule != null)
                    hashCode = hashCode * 59 + this.SkipModule.GetHashCode();
                if (this.UseAbsoluteMode != null)
                    hashCode = hashCode * 59 + this.UseAbsoluteMode.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
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
