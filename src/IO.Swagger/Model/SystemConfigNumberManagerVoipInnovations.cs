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
    /// Schema for number_manager.voip_innovations system_config
    /// </summary>
    [DataContract]
    public partial class SystemConfigNumberManagerVoipInnovations :  IEquatable<SystemConfigNumberManagerVoipInnovations>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemConfigNumberManagerVoipInnovations" /> class.
        /// </summary>
        /// <param name="debug">number_manager.voip_innovations debug (default to false).</param>
        /// <param name="enableProvisioning">number_manager.voip_innovations enable provisioning (default to true).</param>
        /// <param name="endpointGroup">number_manager.voip_innovations endpoint group (default to &quot;&quot;).</param>
        /// <param name="login">number_manager.voip_innovations login (default to &quot;&quot;).</param>
        /// <param name="password">number_manager.voip_innovations password (default to &quot;&quot;).</param>
        /// <param name="sandboxProvisioning">number_manager.voip_innovations sandbox provisioning (default to false).</param>
        public SystemConfigNumberManagerVoipInnovations(bool? debug = false, bool? enableProvisioning = true, string endpointGroup = "", string login = "", string password = "", bool? sandboxProvisioning = false)
        {
            // use default value if no "debug" provided
            if (debug == null)
            {
                this.Debug = false;
            }
            else
            {
                this.Debug = debug;
            }
            // use default value if no "enableProvisioning" provided
            if (enableProvisioning == null)
            {
                this.EnableProvisioning = true;
            }
            else
            {
                this.EnableProvisioning = enableProvisioning;
            }
            // use default value if no "endpointGroup" provided
            if (endpointGroup == null)
            {
                this.EndpointGroup = "";
            }
            else
            {
                this.EndpointGroup = endpointGroup;
            }
            // use default value if no "login" provided
            if (login == null)
            {
                this.Login = "";
            }
            else
            {
                this.Login = login;
            }
            // use default value if no "password" provided
            if (password == null)
            {
                this.Password = "";
            }
            else
            {
                this.Password = password;
            }
            // use default value if no "sandboxProvisioning" provided
            if (sandboxProvisioning == null)
            {
                this.SandboxProvisioning = false;
            }
            else
            {
                this.SandboxProvisioning = sandboxProvisioning;
            }
        }
        
        /// <summary>
        /// number_manager.voip_innovations debug
        /// </summary>
        /// <value>number_manager.voip_innovations debug</value>
        [DataMember(Name="debug", EmitDefaultValue=false)]
        public bool? Debug { get; set; }

        /// <summary>
        /// number_manager.voip_innovations enable provisioning
        /// </summary>
        /// <value>number_manager.voip_innovations enable provisioning</value>
        [DataMember(Name="enable_provisioning", EmitDefaultValue=false)]
        public bool? EnableProvisioning { get; set; }

        /// <summary>
        /// number_manager.voip_innovations endpoint group
        /// </summary>
        /// <value>number_manager.voip_innovations endpoint group</value>
        [DataMember(Name="endpoint_group", EmitDefaultValue=false)]
        public string EndpointGroup { get; set; }

        /// <summary>
        /// number_manager.voip_innovations login
        /// </summary>
        /// <value>number_manager.voip_innovations login</value>
        [DataMember(Name="login", EmitDefaultValue=false)]
        public string Login { get; set; }

        /// <summary>
        /// number_manager.voip_innovations password
        /// </summary>
        /// <value>number_manager.voip_innovations password</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// number_manager.voip_innovations sandbox provisioning
        /// </summary>
        /// <value>number_manager.voip_innovations sandbox provisioning</value>
        [DataMember(Name="sandbox_provisioning", EmitDefaultValue=false)]
        public bool? SandboxProvisioning { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SystemConfigNumberManagerVoipInnovations {\n");
            sb.Append("  Debug: ").Append(Debug).Append("\n");
            sb.Append("  EnableProvisioning: ").Append(EnableProvisioning).Append("\n");
            sb.Append("  EndpointGroup: ").Append(EndpointGroup).Append("\n");
            sb.Append("  Login: ").Append(Login).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  SandboxProvisioning: ").Append(SandboxProvisioning).Append("\n");
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
            return this.Equals(input as SystemConfigNumberManagerVoipInnovations);
        }

        /// <summary>
        /// Returns true if SystemConfigNumberManagerVoipInnovations instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemConfigNumberManagerVoipInnovations to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemConfigNumberManagerVoipInnovations input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Debug == input.Debug ||
                    (this.Debug != null &&
                    this.Debug.Equals(input.Debug))
                ) && 
                (
                    this.EnableProvisioning == input.EnableProvisioning ||
                    (this.EnableProvisioning != null &&
                    this.EnableProvisioning.Equals(input.EnableProvisioning))
                ) && 
                (
                    this.EndpointGroup == input.EndpointGroup ||
                    (this.EndpointGroup != null &&
                    this.EndpointGroup.Equals(input.EndpointGroup))
                ) && 
                (
                    this.Login == input.Login ||
                    (this.Login != null &&
                    this.Login.Equals(input.Login))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.SandboxProvisioning == input.SandboxProvisioning ||
                    (this.SandboxProvisioning != null &&
                    this.SandboxProvisioning.Equals(input.SandboxProvisioning))
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
                if (this.Debug != null)
                    hashCode = hashCode * 59 + this.Debug.GetHashCode();
                if (this.EnableProvisioning != null)
                    hashCode = hashCode * 59 + this.EnableProvisioning.GetHashCode();
                if (this.EndpointGroup != null)
                    hashCode = hashCode * 59 + this.EndpointGroup.GetHashCode();
                if (this.Login != null)
                    hashCode = hashCode * 59 + this.Login.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.SandboxProvisioning != null)
                    hashCode = hashCode * 59 + this.SandboxProvisioning.GetHashCode();
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
