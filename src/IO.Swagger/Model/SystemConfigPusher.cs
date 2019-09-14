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
    /// Schema for pusher system_config
    /// </summary>
    [DataContract]
    public partial class SystemConfigPusher :  IEquatable<SystemConfigPusher>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemConfigPusher" /> class.
        /// </summary>
        /// <param name="userAgents">pusher User-Agents.</param>
        /// <param name="apple">apple.</param>
        /// <param name="firebase">firebase.</param>
        /// <param name="google">google.</param>
        /// <param name="modules">pusher modules.</param>
        public SystemConfigPusher(Object userAgents = default(Object), SystemConfigPusherApple apple = default(SystemConfigPusherApple), SystemConfigPusherFirebase firebase = default(SystemConfigPusherFirebase), SystemConfigPusherGoogle google = default(SystemConfigPusherGoogle), List<string> modules = default(List<string>))
        {
            this.UserAgents = userAgents;
            this.Apple = apple;
            this.Firebase = firebase;
            this.Google = google;
            this.Modules = modules;
        }
        
        /// <summary>
        /// pusher User-Agents
        /// </summary>
        /// <value>pusher User-Agents</value>
        [DataMember(Name="User-Agents", EmitDefaultValue=false)]
        public Object UserAgents { get; set; }

        /// <summary>
        /// Gets or Sets Apple
        /// </summary>
        [DataMember(Name="apple", EmitDefaultValue=false)]
        public SystemConfigPusherApple Apple { get; set; }

        /// <summary>
        /// Gets or Sets Firebase
        /// </summary>
        [DataMember(Name="firebase", EmitDefaultValue=false)]
        public SystemConfigPusherFirebase Firebase { get; set; }

        /// <summary>
        /// Gets or Sets Google
        /// </summary>
        [DataMember(Name="google", EmitDefaultValue=false)]
        public SystemConfigPusherGoogle Google { get; set; }

        /// <summary>
        /// pusher modules
        /// </summary>
        /// <value>pusher modules</value>
        [DataMember(Name="modules", EmitDefaultValue=false)]
        public List<string> Modules { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SystemConfigPusher {\n");
            sb.Append("  UserAgents: ").Append(UserAgents).Append("\n");
            sb.Append("  Apple: ").Append(Apple).Append("\n");
            sb.Append("  Firebase: ").Append(Firebase).Append("\n");
            sb.Append("  Google: ").Append(Google).Append("\n");
            sb.Append("  Modules: ").Append(Modules).Append("\n");
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
            return this.Equals(input as SystemConfigPusher);
        }

        /// <summary>
        /// Returns true if SystemConfigPusher instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemConfigPusher to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemConfigPusher input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserAgents == input.UserAgents ||
                    (this.UserAgents != null &&
                    this.UserAgents.Equals(input.UserAgents))
                ) && 
                (
                    this.Apple == input.Apple ||
                    (this.Apple != null &&
                    this.Apple.Equals(input.Apple))
                ) && 
                (
                    this.Firebase == input.Firebase ||
                    (this.Firebase != null &&
                    this.Firebase.Equals(input.Firebase))
                ) && 
                (
                    this.Google == input.Google ||
                    (this.Google != null &&
                    this.Google.Equals(input.Google))
                ) && 
                (
                    this.Modules == input.Modules ||
                    this.Modules != null &&
                    this.Modules.SequenceEqual(input.Modules)
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
                if (this.UserAgents != null)
                    hashCode = hashCode * 59 + this.UserAgents.GetHashCode();
                if (this.Apple != null)
                    hashCode = hashCode * 59 + this.Apple.GetHashCode();
                if (this.Firebase != null)
                    hashCode = hashCode * 59 + this.Firebase.GetHashCode();
                if (this.Google != null)
                    hashCode = hashCode * 59 + this.Google.GetHashCode();
                if (this.Modules != null)
                    hashCode = hashCode * 59 + this.Modules.GetHashCode();
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
