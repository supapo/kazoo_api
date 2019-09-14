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
    /// Schema for privacy system_config
    /// </summary>
    [DataContract]
    public partial class SystemConfigPrivacy :  IEquatable<SystemConfigPrivacy>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemConfigPrivacy" /> class.
        /// </summary>
        /// <param name="anonymousCidNames">Additional CID name patterns to match for anonymous call rejection.</param>
        /// <param name="anonymousCidNumbers">Additional CID number/userpart patterns to match for anonymous call rejection.</param>
        /// <param name="blockAnonymousCallerId">Controls blocking of anonymous calls (default to false).</param>
        /// <param name="checkAdditionalAnonymousCidNames">use the anonymous_cid_names values to check if a number is anonymous (default to false).</param>
        /// <param name="checkAdditionalAnonymousCidNumbers">use the anonymous_cid_numbers values to check if a name is anonymous (default to false).</param>
        /// <param name="defaultPrivacyName">privacy default_privacy_name (default to &quot;Anonymous&quot;).</param>
        /// <param name="defaultPrivacyNumber">privacy default_privacy_number (default to &quot;anonymous&quot;).</param>
        /// <param name="method">privacy method (default to &quot;kazoo&quot;).</param>
        /// <param name="privacyMode">Default privacy mode for anonymous calls (default to &quot;kazoo&quot;).</param>
        /// <param name="privacyName">Default Caller ID Name should be shown for anonymous calls (default to &quot;anonymous&quot;).</param>
        /// <param name="privacyNumber">Default Caller ID Number should be shown for anonymous calls (default to &quot;0000000000&quot;).</param>
        public SystemConfigPrivacy(List<string> anonymousCidNames = default(List<string>), List<string> anonymousCidNumbers = default(List<string>), bool? blockAnonymousCallerId = false, bool? checkAdditionalAnonymousCidNames = false, bool? checkAdditionalAnonymousCidNumbers = false, string defaultPrivacyName = "Anonymous", string defaultPrivacyNumber = "anonymous", string method = "kazoo", string privacyMode = "kazoo", string privacyName = "anonymous", string privacyNumber = "0000000000")
        {
            this.AnonymousCidNames = anonymousCidNames;
            this.AnonymousCidNumbers = anonymousCidNumbers;
            // use default value if no "blockAnonymousCallerId" provided
            if (blockAnonymousCallerId == null)
            {
                this.BlockAnonymousCallerId = false;
            }
            else
            {
                this.BlockAnonymousCallerId = blockAnonymousCallerId;
            }
            // use default value if no "checkAdditionalAnonymousCidNames" provided
            if (checkAdditionalAnonymousCidNames == null)
            {
                this.CheckAdditionalAnonymousCidNames = false;
            }
            else
            {
                this.CheckAdditionalAnonymousCidNames = checkAdditionalAnonymousCidNames;
            }
            // use default value if no "checkAdditionalAnonymousCidNumbers" provided
            if (checkAdditionalAnonymousCidNumbers == null)
            {
                this.CheckAdditionalAnonymousCidNumbers = false;
            }
            else
            {
                this.CheckAdditionalAnonymousCidNumbers = checkAdditionalAnonymousCidNumbers;
            }
            // use default value if no "defaultPrivacyName" provided
            if (defaultPrivacyName == null)
            {
                this.DefaultPrivacyName = "Anonymous";
            }
            else
            {
                this.DefaultPrivacyName = defaultPrivacyName;
            }
            // use default value if no "defaultPrivacyNumber" provided
            if (defaultPrivacyNumber == null)
            {
                this.DefaultPrivacyNumber = "anonymous";
            }
            else
            {
                this.DefaultPrivacyNumber = defaultPrivacyNumber;
            }
            // use default value if no "method" provided
            if (method == null)
            {
                this.Method = "kazoo";
            }
            else
            {
                this.Method = method;
            }
            // use default value if no "privacyMode" provided
            if (privacyMode == null)
            {
                this.PrivacyMode = "kazoo";
            }
            else
            {
                this.PrivacyMode = privacyMode;
            }
            // use default value if no "privacyName" provided
            if (privacyName == null)
            {
                this.PrivacyName = "anonymous";
            }
            else
            {
                this.PrivacyName = privacyName;
            }
            // use default value if no "privacyNumber" provided
            if (privacyNumber == null)
            {
                this.PrivacyNumber = "0000000000";
            }
            else
            {
                this.PrivacyNumber = privacyNumber;
            }
        }
        
        /// <summary>
        /// Additional CID name patterns to match for anonymous call rejection
        /// </summary>
        /// <value>Additional CID name patterns to match for anonymous call rejection</value>
        [DataMember(Name="anonymous_cid_names", EmitDefaultValue=false)]
        public List<string> AnonymousCidNames { get; set; }

        /// <summary>
        /// Additional CID number/userpart patterns to match for anonymous call rejection
        /// </summary>
        /// <value>Additional CID number/userpart patterns to match for anonymous call rejection</value>
        [DataMember(Name="anonymous_cid_numbers", EmitDefaultValue=false)]
        public List<string> AnonymousCidNumbers { get; set; }

        /// <summary>
        /// Controls blocking of anonymous calls
        /// </summary>
        /// <value>Controls blocking of anonymous calls</value>
        [DataMember(Name="block_anonymous_caller_id", EmitDefaultValue=false)]
        public bool? BlockAnonymousCallerId { get; set; }

        /// <summary>
        /// use the anonymous_cid_names values to check if a number is anonymous
        /// </summary>
        /// <value>use the anonymous_cid_names values to check if a number is anonymous</value>
        [DataMember(Name="check_additional_anonymous_cid_names", EmitDefaultValue=false)]
        public bool? CheckAdditionalAnonymousCidNames { get; set; }

        /// <summary>
        /// use the anonymous_cid_numbers values to check if a name is anonymous
        /// </summary>
        /// <value>use the anonymous_cid_numbers values to check if a name is anonymous</value>
        [DataMember(Name="check_additional_anonymous_cid_numbers", EmitDefaultValue=false)]
        public bool? CheckAdditionalAnonymousCidNumbers { get; set; }

        /// <summary>
        /// privacy default_privacy_name
        /// </summary>
        /// <value>privacy default_privacy_name</value>
        [DataMember(Name="default_privacy_name", EmitDefaultValue=false)]
        public string DefaultPrivacyName { get; set; }

        /// <summary>
        /// privacy default_privacy_number
        /// </summary>
        /// <value>privacy default_privacy_number</value>
        [DataMember(Name="default_privacy_number", EmitDefaultValue=false)]
        public string DefaultPrivacyNumber { get; set; }

        /// <summary>
        /// privacy method
        /// </summary>
        /// <value>privacy method</value>
        [DataMember(Name="method", EmitDefaultValue=false)]
        public string Method { get; set; }

        /// <summary>
        /// Default privacy mode for anonymous calls
        /// </summary>
        /// <value>Default privacy mode for anonymous calls</value>
        [DataMember(Name="privacy_mode", EmitDefaultValue=false)]
        public string PrivacyMode { get; set; }

        /// <summary>
        /// Default Caller ID Name should be shown for anonymous calls
        /// </summary>
        /// <value>Default Caller ID Name should be shown for anonymous calls</value>
        [DataMember(Name="privacy_name", EmitDefaultValue=false)]
        public string PrivacyName { get; set; }

        /// <summary>
        /// Default Caller ID Number should be shown for anonymous calls
        /// </summary>
        /// <value>Default Caller ID Number should be shown for anonymous calls</value>
        [DataMember(Name="privacy_number", EmitDefaultValue=false)]
        public string PrivacyNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SystemConfigPrivacy {\n");
            sb.Append("  AnonymousCidNames: ").Append(AnonymousCidNames).Append("\n");
            sb.Append("  AnonymousCidNumbers: ").Append(AnonymousCidNumbers).Append("\n");
            sb.Append("  BlockAnonymousCallerId: ").Append(BlockAnonymousCallerId).Append("\n");
            sb.Append("  CheckAdditionalAnonymousCidNames: ").Append(CheckAdditionalAnonymousCidNames).Append("\n");
            sb.Append("  CheckAdditionalAnonymousCidNumbers: ").Append(CheckAdditionalAnonymousCidNumbers).Append("\n");
            sb.Append("  DefaultPrivacyName: ").Append(DefaultPrivacyName).Append("\n");
            sb.Append("  DefaultPrivacyNumber: ").Append(DefaultPrivacyNumber).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  PrivacyMode: ").Append(PrivacyMode).Append("\n");
            sb.Append("  PrivacyName: ").Append(PrivacyName).Append("\n");
            sb.Append("  PrivacyNumber: ").Append(PrivacyNumber).Append("\n");
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
            return this.Equals(input as SystemConfigPrivacy);
        }

        /// <summary>
        /// Returns true if SystemConfigPrivacy instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemConfigPrivacy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemConfigPrivacy input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AnonymousCidNames == input.AnonymousCidNames ||
                    this.AnonymousCidNames != null &&
                    this.AnonymousCidNames.SequenceEqual(input.AnonymousCidNames)
                ) && 
                (
                    this.AnonymousCidNumbers == input.AnonymousCidNumbers ||
                    this.AnonymousCidNumbers != null &&
                    this.AnonymousCidNumbers.SequenceEqual(input.AnonymousCidNumbers)
                ) && 
                (
                    this.BlockAnonymousCallerId == input.BlockAnonymousCallerId ||
                    (this.BlockAnonymousCallerId != null &&
                    this.BlockAnonymousCallerId.Equals(input.BlockAnonymousCallerId))
                ) && 
                (
                    this.CheckAdditionalAnonymousCidNames == input.CheckAdditionalAnonymousCidNames ||
                    (this.CheckAdditionalAnonymousCidNames != null &&
                    this.CheckAdditionalAnonymousCidNames.Equals(input.CheckAdditionalAnonymousCidNames))
                ) && 
                (
                    this.CheckAdditionalAnonymousCidNumbers == input.CheckAdditionalAnonymousCidNumbers ||
                    (this.CheckAdditionalAnonymousCidNumbers != null &&
                    this.CheckAdditionalAnonymousCidNumbers.Equals(input.CheckAdditionalAnonymousCidNumbers))
                ) && 
                (
                    this.DefaultPrivacyName == input.DefaultPrivacyName ||
                    (this.DefaultPrivacyName != null &&
                    this.DefaultPrivacyName.Equals(input.DefaultPrivacyName))
                ) && 
                (
                    this.DefaultPrivacyNumber == input.DefaultPrivacyNumber ||
                    (this.DefaultPrivacyNumber != null &&
                    this.DefaultPrivacyNumber.Equals(input.DefaultPrivacyNumber))
                ) && 
                (
                    this.Method == input.Method ||
                    (this.Method != null &&
                    this.Method.Equals(input.Method))
                ) && 
                (
                    this.PrivacyMode == input.PrivacyMode ||
                    (this.PrivacyMode != null &&
                    this.PrivacyMode.Equals(input.PrivacyMode))
                ) && 
                (
                    this.PrivacyName == input.PrivacyName ||
                    (this.PrivacyName != null &&
                    this.PrivacyName.Equals(input.PrivacyName))
                ) && 
                (
                    this.PrivacyNumber == input.PrivacyNumber ||
                    (this.PrivacyNumber != null &&
                    this.PrivacyNumber.Equals(input.PrivacyNumber))
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
                if (this.AnonymousCidNames != null)
                    hashCode = hashCode * 59 + this.AnonymousCidNames.GetHashCode();
                if (this.AnonymousCidNumbers != null)
                    hashCode = hashCode * 59 + this.AnonymousCidNumbers.GetHashCode();
                if (this.BlockAnonymousCallerId != null)
                    hashCode = hashCode * 59 + this.BlockAnonymousCallerId.GetHashCode();
                if (this.CheckAdditionalAnonymousCidNames != null)
                    hashCode = hashCode * 59 + this.CheckAdditionalAnonymousCidNames.GetHashCode();
                if (this.CheckAdditionalAnonymousCidNumbers != null)
                    hashCode = hashCode * 59 + this.CheckAdditionalAnonymousCidNumbers.GetHashCode();
                if (this.DefaultPrivacyName != null)
                    hashCode = hashCode * 59 + this.DefaultPrivacyName.GetHashCode();
                if (this.DefaultPrivacyNumber != null)
                    hashCode = hashCode * 59 + this.DefaultPrivacyNumber.GetHashCode();
                if (this.Method != null)
                    hashCode = hashCode * 59 + this.Method.GetHashCode();
                if (this.PrivacyMode != null)
                    hashCode = hashCode * 59 + this.PrivacyMode.GetHashCode();
                if (this.PrivacyName != null)
                    hashCode = hashCode * 59 + this.PrivacyName.GetHashCode();
                if (this.PrivacyNumber != null)
                    hashCode = hashCode * 59 + this.PrivacyNumber.GetHashCode();
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