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
    /// Schema for number_manager.vitelity system_config
    /// </summary>
    [DataContract]
    public partial class SystemConfigNumberManagerVitelity :  IEquatable<SystemConfigNumberManagerVitelity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemConfigNumberManagerVitelity" /> class.
        /// </summary>
        /// <param name="apiUri">number_manager.vitelity api uri (default to &quot;http://api.vitelity.net/api.php&quot;).</param>
        /// <param name="routesip">number_manager.vitelity routesip.</param>
        /// <param name="useStepswitchCnam">number_manager.vitelity use_stepswitch_cnam (default to false).</param>
        public SystemConfigNumberManagerVitelity(string apiUri = "http://api.vitelity.net/api.php", Object routesip = default(Object), bool? useStepswitchCnam = false)
        {
            // use default value if no "apiUri" provided
            if (apiUri == null)
            {
                this.ApiUri = "http://api.vitelity.net/api.php";
            }
            else
            {
                this.ApiUri = apiUri;
            }
            this.Routesip = routesip;
            // use default value if no "useStepswitchCnam" provided
            if (useStepswitchCnam == null)
            {
                this.UseStepswitchCnam = false;
            }
            else
            {
                this.UseStepswitchCnam = useStepswitchCnam;
            }
        }
        
        /// <summary>
        /// number_manager.vitelity api uri
        /// </summary>
        /// <value>number_manager.vitelity api uri</value>
        [DataMember(Name="api_uri", EmitDefaultValue=false)]
        public string ApiUri { get; set; }

        /// <summary>
        /// number_manager.vitelity routesip
        /// </summary>
        /// <value>number_manager.vitelity routesip</value>
        [DataMember(Name="routesip", EmitDefaultValue=false)]
        public Object Routesip { get; set; }

        /// <summary>
        /// number_manager.vitelity use_stepswitch_cnam
        /// </summary>
        /// <value>number_manager.vitelity use_stepswitch_cnam</value>
        [DataMember(Name="use_stepswitch_cnam", EmitDefaultValue=false)]
        public bool? UseStepswitchCnam { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SystemConfigNumberManagerVitelity {\n");
            sb.Append("  ApiUri: ").Append(ApiUri).Append("\n");
            sb.Append("  Routesip: ").Append(Routesip).Append("\n");
            sb.Append("  UseStepswitchCnam: ").Append(UseStepswitchCnam).Append("\n");
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
            return this.Equals(input as SystemConfigNumberManagerVitelity);
        }

        /// <summary>
        /// Returns true if SystemConfigNumberManagerVitelity instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemConfigNumberManagerVitelity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemConfigNumberManagerVitelity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApiUri == input.ApiUri ||
                    (this.ApiUri != null &&
                    this.ApiUri.Equals(input.ApiUri))
                ) && 
                (
                    this.Routesip == input.Routesip ||
                    (this.Routesip != null &&
                    this.Routesip.Equals(input.Routesip))
                ) && 
                (
                    this.UseStepswitchCnam == input.UseStepswitchCnam ||
                    (this.UseStepswitchCnam != null &&
                    this.UseStepswitchCnam.Equals(input.UseStepswitchCnam))
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
                if (this.ApiUri != null)
                    hashCode = hashCode * 59 + this.ApiUri.GetHashCode();
                if (this.Routesip != null)
                    hashCode = hashCode * 59 + this.Routesip.GetHashCode();
                if (this.UseStepswitchCnam != null)
                    hashCode = hashCode * 59 + this.UseStepswitchCnam.GetHashCode();
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
