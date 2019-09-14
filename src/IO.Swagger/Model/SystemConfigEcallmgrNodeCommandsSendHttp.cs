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
    /// SystemConfigEcallmgrNodeCommandsSendHttp
    /// </summary>
    [DataContract]
    public partial class SystemConfigEcallmgrNodeCommandsSendHttp :  IEquatable<SystemConfigEcallmgrNodeCommandsSendHttp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemConfigEcallmgrNodeCommandsSendHttp" /> class.
        /// </summary>
        /// <param name="deleteOnSuccess">ecallmgr delete on success (default to false).</param>
        public SystemConfigEcallmgrNodeCommandsSendHttp(bool? deleteOnSuccess = false)
        {
            // use default value if no "deleteOnSuccess" provided
            if (deleteOnSuccess == null)
            {
                this.DeleteOnSuccess = false;
            }
            else
            {
                this.DeleteOnSuccess = deleteOnSuccess;
            }
        }
        
        /// <summary>
        /// ecallmgr delete on success
        /// </summary>
        /// <value>ecallmgr delete on success</value>
        [DataMember(Name="delete_on_success", EmitDefaultValue=false)]
        public bool? DeleteOnSuccess { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SystemConfigEcallmgrNodeCommandsSendHttp {\n");
            sb.Append("  DeleteOnSuccess: ").Append(DeleteOnSuccess).Append("\n");
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
            return this.Equals(input as SystemConfigEcallmgrNodeCommandsSendHttp);
        }

        /// <summary>
        /// Returns true if SystemConfigEcallmgrNodeCommandsSendHttp instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemConfigEcallmgrNodeCommandsSendHttp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemConfigEcallmgrNodeCommandsSendHttp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DeleteOnSuccess == input.DeleteOnSuccess ||
                    (this.DeleteOnSuccess != null &&
                    this.DeleteOnSuccess.Equals(input.DeleteOnSuccess))
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
                if (this.DeleteOnSuccess != null)
                    hashCode = hashCode * 59 + this.DeleteOnSuccess.GetHashCode();
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
