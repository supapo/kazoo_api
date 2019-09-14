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
    /// Schema for smtp_client system_config
    /// </summary>
    [DataContract]
    public partial class SystemConfigSmtpClient :  IEquatable<SystemConfigSmtpClient>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemConfigSmtpClient" /> class.
        /// </summary>
        /// <param name="auth">smtp_client auth (default to &quot;never&quot;).</param>
        /// <param name="noMxLookups">smtp_client no mx lookups (default to true).</param>
        /// <param name="password">smtp_client password (default to &quot;&quot;).</param>
        /// <param name="port">smtp_client port.</param>
        /// <param name="relay">smtp_client relay (default to &quot;localhost&quot;).</param>
        /// <param name="retries">smtp_client retries.</param>
        /// <param name="sendTimeoutMs">Timeout in milliseconds waiting for response from SMTP server.</param>
        /// <param name="tls">smtp_client tls.</param>
        /// <param name="useSsl">smtp_client use SSL (default to false).</param>
        /// <param name="username">smtp_client username (default to &quot;&quot;).</param>
        public SystemConfigSmtpClient(string auth = "never", bool? noMxLookups = true, string password = "", int? port = default(int?), string relay = "localhost", int? retries = default(int?), int? sendTimeoutMs = default(int?), string tls = default(string), bool? useSsl = false, string username = "")
        {
            // use default value if no "auth" provided
            if (auth == null)
            {
                this.Auth = "never";
            }
            else
            {
                this.Auth = auth;
            }
            // use default value if no "noMxLookups" provided
            if (noMxLookups == null)
            {
                this.NoMxLookups = true;
            }
            else
            {
                this.NoMxLookups = noMxLookups;
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
            this.Port = port;
            // use default value if no "relay" provided
            if (relay == null)
            {
                this.Relay = "localhost";
            }
            else
            {
                this.Relay = relay;
            }
            this.Retries = retries;
            this.SendTimeoutMs = sendTimeoutMs;
            this.Tls = tls;
            // use default value if no "useSsl" provided
            if (useSsl == null)
            {
                this.UseSsl = false;
            }
            else
            {
                this.UseSsl = useSsl;
            }
            // use default value if no "username" provided
            if (username == null)
            {
                this.Username = "";
            }
            else
            {
                this.Username = username;
            }
        }
        
        /// <summary>
        /// smtp_client auth
        /// </summary>
        /// <value>smtp_client auth</value>
        [DataMember(Name="auth", EmitDefaultValue=false)]
        public string Auth { get; set; }

        /// <summary>
        /// smtp_client no mx lookups
        /// </summary>
        /// <value>smtp_client no mx lookups</value>
        [DataMember(Name="no_mx_lookups", EmitDefaultValue=false)]
        public bool? NoMxLookups { get; set; }

        /// <summary>
        /// smtp_client password
        /// </summary>
        /// <value>smtp_client password</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// smtp_client port
        /// </summary>
        /// <value>smtp_client port</value>
        [DataMember(Name="port", EmitDefaultValue=false)]
        public int? Port { get; set; }

        /// <summary>
        /// smtp_client relay
        /// </summary>
        /// <value>smtp_client relay</value>
        [DataMember(Name="relay", EmitDefaultValue=false)]
        public string Relay { get; set; }

        /// <summary>
        /// smtp_client retries
        /// </summary>
        /// <value>smtp_client retries</value>
        [DataMember(Name="retries", EmitDefaultValue=false)]
        public int? Retries { get; set; }

        /// <summary>
        /// Timeout in milliseconds waiting for response from SMTP server
        /// </summary>
        /// <value>Timeout in milliseconds waiting for response from SMTP server</value>
        [DataMember(Name="send_timeout_ms", EmitDefaultValue=false)]
        public int? SendTimeoutMs { get; set; }

        /// <summary>
        /// smtp_client tls
        /// </summary>
        /// <value>smtp_client tls</value>
        [DataMember(Name="tls", EmitDefaultValue=false)]
        public string Tls { get; set; }

        /// <summary>
        /// smtp_client use SSL
        /// </summary>
        /// <value>smtp_client use SSL</value>
        [DataMember(Name="use_ssl", EmitDefaultValue=false)]
        public bool? UseSsl { get; set; }

        /// <summary>
        /// smtp_client username
        /// </summary>
        /// <value>smtp_client username</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SystemConfigSmtpClient {\n");
            sb.Append("  Auth: ").Append(Auth).Append("\n");
            sb.Append("  NoMxLookups: ").Append(NoMxLookups).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
            sb.Append("  Relay: ").Append(Relay).Append("\n");
            sb.Append("  Retries: ").Append(Retries).Append("\n");
            sb.Append("  SendTimeoutMs: ").Append(SendTimeoutMs).Append("\n");
            sb.Append("  Tls: ").Append(Tls).Append("\n");
            sb.Append("  UseSsl: ").Append(UseSsl).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
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
            return this.Equals(input as SystemConfigSmtpClient);
        }

        /// <summary>
        /// Returns true if SystemConfigSmtpClient instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemConfigSmtpClient to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemConfigSmtpClient input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Auth == input.Auth ||
                    (this.Auth != null &&
                    this.Auth.Equals(input.Auth))
                ) && 
                (
                    this.NoMxLookups == input.NoMxLookups ||
                    (this.NoMxLookups != null &&
                    this.NoMxLookups.Equals(input.NoMxLookups))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.Port == input.Port ||
                    (this.Port != null &&
                    this.Port.Equals(input.Port))
                ) && 
                (
                    this.Relay == input.Relay ||
                    (this.Relay != null &&
                    this.Relay.Equals(input.Relay))
                ) && 
                (
                    this.Retries == input.Retries ||
                    (this.Retries != null &&
                    this.Retries.Equals(input.Retries))
                ) && 
                (
                    this.SendTimeoutMs == input.SendTimeoutMs ||
                    (this.SendTimeoutMs != null &&
                    this.SendTimeoutMs.Equals(input.SendTimeoutMs))
                ) && 
                (
                    this.Tls == input.Tls ||
                    (this.Tls != null &&
                    this.Tls.Equals(input.Tls))
                ) && 
                (
                    this.UseSsl == input.UseSsl ||
                    (this.UseSsl != null &&
                    this.UseSsl.Equals(input.UseSsl))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
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
                if (this.Auth != null)
                    hashCode = hashCode * 59 + this.Auth.GetHashCode();
                if (this.NoMxLookups != null)
                    hashCode = hashCode * 59 + this.NoMxLookups.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Port != null)
                    hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.Relay != null)
                    hashCode = hashCode * 59 + this.Relay.GetHashCode();
                if (this.Retries != null)
                    hashCode = hashCode * 59 + this.Retries.GetHashCode();
                if (this.SendTimeoutMs != null)
                    hashCode = hashCode * 59 + this.SendTimeoutMs.GetHashCode();
                if (this.Tls != null)
                    hashCode = hashCode * 59 + this.Tls.GetHashCode();
                if (this.UseSsl != null)
                    hashCode = hashCode * 59 + this.UseSsl.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
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
            // SendTimeoutMs (int?) minimum
            if(this.SendTimeoutMs < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SendTimeoutMs, must be a value greater than or equal to 1.", new [] { "SendTimeoutMs" });
            }

            yield break;
        }
    }

}