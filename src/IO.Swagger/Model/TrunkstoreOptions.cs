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
    /// TrunkstoreOptions
    /// </summary>
    [DataContract]
    public partial class TrunkstoreOptions :  IEquatable<TrunkstoreOptions>, IValidatableObject
    {
        /// <summary>
        /// Determines how the INVITE is sent to the server
        /// </summary>
        /// <value>Determines how the INVITE is sent to the server</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum InboundFormatEnum
        {
            
            /// <summary>
            /// Enum E164 for value: e164
            /// </summary>
            [EnumMember(Value = "e164")]
            E164 = 1,
            
            /// <summary>
            /// Enum Npan for value: npan
            /// </summary>
            [EnumMember(Value = "npan")]
            Npan = 2,
            
            /// <summary>
            /// Enum _1npan for value: 1npan
            /// </summary>
            [EnumMember(Value = "1npan")]
            _1npan = 3,
            
            /// <summary>
            /// Enum Username for value: username
            /// </summary>
            [EnumMember(Value = "username")]
            Username = 4
        }

        /// <summary>
        /// Determines how the INVITE is sent to the server
        /// </summary>
        /// <value>Determines how the INVITE is sent to the server</value>
        [DataMember(Name="inbound_format", EmitDefaultValue=false)]
        public InboundFormatEnum? InboundFormat { get; set; }
        /// <summary>
        /// Determine whether the switch should be in the media path or not
        /// </summary>
        /// <value>Determine whether the switch should be in the media path or not</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MediaHandlingEnum
        {
            
            /// <summary>
            /// Enum Process for value: process
            /// </summary>
            [EnumMember(Value = "process")]
            Process = 1,
            
            /// <summary>
            /// Enum Bypass for value: bypass
            /// </summary>
            [EnumMember(Value = "bypass")]
            Bypass = 2
        }

        /// <summary>
        /// Determine whether the switch should be in the media path or not
        /// </summary>
        /// <value>Determine whether the switch should be in the media path or not</value>
        [DataMember(Name="media_handling", EmitDefaultValue=false)]
        public MediaHandlingEnum? MediaHandling { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrunkstoreOptions" /> class.
        /// </summary>
        /// <param name="callerId">callerId.</param>
        /// <param name="delay">The time, in seconds, to wait before attempting to call the server.</param>
        /// <param name="enabled">Is the server ready for sending and receiving calls (default to true).</param>
        /// <param name="failover">failover.</param>
        /// <param name="forceOutbound">If true, will send the call over configured carriers instead of to the server (as opposed to the &#39;enabled&#39; flag, which will reject the calls) (default to false).</param>
        /// <param name="ignoreEarlyMedia">ignoreEarlyMedia.</param>
        /// <param name="inboundFormat">Determines how the INVITE is sent to the server (default to InboundFormatEnum.Npan).</param>
        /// <param name="mediaHandling">Determine whether the switch should be in the media path or not (default to MediaHandlingEnum.Bypass).</param>
        /// <param name="progressTimeout">The time, in seconds, to wait for the server to progress in the call, before trying an optionally defined failover route or terminating the call.</param>
        /// <param name="sipHeaders">List of arbitrary SIP headers to add to the INVITE.</param>
        /// <param name="timeout">The time, in seconds, to wait for an answer from the server.</param>
        public TrunkstoreOptions(TrunkstoreAccountCallerId callerId = default(TrunkstoreAccountCallerId), int? delay = default(int?), bool? enabled = true, ConnectivityOptionsFailover failover = default(ConnectivityOptionsFailover), bool? forceOutbound = false, bool? ignoreEarlyMedia = default(bool?), InboundFormatEnum? inboundFormat = InboundFormatEnum.Npan, MediaHandlingEnum? mediaHandling = MediaHandlingEnum.Bypass, int? progressTimeout = default(int?), List<Object> sipHeaders = default(List<Object>), int? timeout = default(int?))
        {
            this.CallerId = callerId;
            this.Delay = delay;
            // use default value if no "enabled" provided
            if (enabled == null)
            {
                this.Enabled = true;
            }
            else
            {
                this.Enabled = enabled;
            }
            this.Failover = failover;
            // use default value if no "forceOutbound" provided
            if (forceOutbound == null)
            {
                this.ForceOutbound = false;
            }
            else
            {
                this.ForceOutbound = forceOutbound;
            }
            this.IgnoreEarlyMedia = ignoreEarlyMedia;
            // use default value if no "inboundFormat" provided
            if (inboundFormat == null)
            {
                this.InboundFormat = InboundFormatEnum.Npan;
            }
            else
            {
                this.InboundFormat = inboundFormat;
            }
            // use default value if no "mediaHandling" provided
            if (mediaHandling == null)
            {
                this.MediaHandling = MediaHandlingEnum.Bypass;
            }
            else
            {
                this.MediaHandling = mediaHandling;
            }
            this.ProgressTimeout = progressTimeout;
            this.SipHeaders = sipHeaders;
            this.Timeout = timeout;
        }
        
        /// <summary>
        /// Gets or Sets CallerId
        /// </summary>
        [DataMember(Name="caller_id", EmitDefaultValue=false)]
        public TrunkstoreAccountCallerId CallerId { get; set; }

        /// <summary>
        /// The time, in seconds, to wait before attempting to call the server
        /// </summary>
        /// <value>The time, in seconds, to wait before attempting to call the server</value>
        [DataMember(Name="delay", EmitDefaultValue=false)]
        public int? Delay { get; set; }

        /// <summary>
        /// Is the server ready for sending and receiving calls
        /// </summary>
        /// <value>Is the server ready for sending and receiving calls</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or Sets Failover
        /// </summary>
        [DataMember(Name="failover", EmitDefaultValue=false)]
        public ConnectivityOptionsFailover Failover { get; set; }

        /// <summary>
        /// If true, will send the call over configured carriers instead of to the server (as opposed to the &#39;enabled&#39; flag, which will reject the calls)
        /// </summary>
        /// <value>If true, will send the call over configured carriers instead of to the server (as opposed to the &#39;enabled&#39; flag, which will reject the calls)</value>
        [DataMember(Name="force_outbound", EmitDefaultValue=false)]
        public bool? ForceOutbound { get; set; }

        /// <summary>
        /// Gets or Sets IgnoreEarlyMedia
        /// </summary>
        [DataMember(Name="ignore_early_media", EmitDefaultValue=false)]
        public bool? IgnoreEarlyMedia { get; set; }



        /// <summary>
        /// The time, in seconds, to wait for the server to progress in the call, before trying an optionally defined failover route or terminating the call
        /// </summary>
        /// <value>The time, in seconds, to wait for the server to progress in the call, before trying an optionally defined failover route or terminating the call</value>
        [DataMember(Name="progress_timeout", EmitDefaultValue=false)]
        public int? ProgressTimeout { get; set; }

        /// <summary>
        /// List of arbitrary SIP headers to add to the INVITE
        /// </summary>
        /// <value>List of arbitrary SIP headers to add to the INVITE</value>
        [DataMember(Name="sip_headers", EmitDefaultValue=false)]
        public List<Object> SipHeaders { get; set; }

        /// <summary>
        /// The time, in seconds, to wait for an answer from the server
        /// </summary>
        /// <value>The time, in seconds, to wait for an answer from the server</value>
        [DataMember(Name="timeout", EmitDefaultValue=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrunkstoreOptions {\n");
            sb.Append("  CallerId: ").Append(CallerId).Append("\n");
            sb.Append("  Delay: ").Append(Delay).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Failover: ").Append(Failover).Append("\n");
            sb.Append("  ForceOutbound: ").Append(ForceOutbound).Append("\n");
            sb.Append("  IgnoreEarlyMedia: ").Append(IgnoreEarlyMedia).Append("\n");
            sb.Append("  InboundFormat: ").Append(InboundFormat).Append("\n");
            sb.Append("  MediaHandling: ").Append(MediaHandling).Append("\n");
            sb.Append("  ProgressTimeout: ").Append(ProgressTimeout).Append("\n");
            sb.Append("  SipHeaders: ").Append(SipHeaders).Append("\n");
            sb.Append("  Timeout: ").Append(Timeout).Append("\n");
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
            return this.Equals(input as TrunkstoreOptions);
        }

        /// <summary>
        /// Returns true if TrunkstoreOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of TrunkstoreOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrunkstoreOptions input)
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
                    this.Delay == input.Delay ||
                    (this.Delay != null &&
                    this.Delay.Equals(input.Delay))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.Failover == input.Failover ||
                    (this.Failover != null &&
                    this.Failover.Equals(input.Failover))
                ) && 
                (
                    this.ForceOutbound == input.ForceOutbound ||
                    (this.ForceOutbound != null &&
                    this.ForceOutbound.Equals(input.ForceOutbound))
                ) && 
                (
                    this.IgnoreEarlyMedia == input.IgnoreEarlyMedia ||
                    (this.IgnoreEarlyMedia != null &&
                    this.IgnoreEarlyMedia.Equals(input.IgnoreEarlyMedia))
                ) && 
                (
                    this.InboundFormat == input.InboundFormat ||
                    (this.InboundFormat != null &&
                    this.InboundFormat.Equals(input.InboundFormat))
                ) && 
                (
                    this.MediaHandling == input.MediaHandling ||
                    (this.MediaHandling != null &&
                    this.MediaHandling.Equals(input.MediaHandling))
                ) && 
                (
                    this.ProgressTimeout == input.ProgressTimeout ||
                    (this.ProgressTimeout != null &&
                    this.ProgressTimeout.Equals(input.ProgressTimeout))
                ) && 
                (
                    this.SipHeaders == input.SipHeaders ||
                    this.SipHeaders != null &&
                    this.SipHeaders.SequenceEqual(input.SipHeaders)
                ) && 
                (
                    this.Timeout == input.Timeout ||
                    (this.Timeout != null &&
                    this.Timeout.Equals(input.Timeout))
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
                if (this.Delay != null)
                    hashCode = hashCode * 59 + this.Delay.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.Failover != null)
                    hashCode = hashCode * 59 + this.Failover.GetHashCode();
                if (this.ForceOutbound != null)
                    hashCode = hashCode * 59 + this.ForceOutbound.GetHashCode();
                if (this.IgnoreEarlyMedia != null)
                    hashCode = hashCode * 59 + this.IgnoreEarlyMedia.GetHashCode();
                if (this.InboundFormat != null)
                    hashCode = hashCode * 59 + this.InboundFormat.GetHashCode();
                if (this.MediaHandling != null)
                    hashCode = hashCode * 59 + this.MediaHandling.GetHashCode();
                if (this.ProgressTimeout != null)
                    hashCode = hashCode * 59 + this.ProgressTimeout.GetHashCode();
                if (this.SipHeaders != null)
                    hashCode = hashCode * 59 + this.SipHeaders.GetHashCode();
                if (this.Timeout != null)
                    hashCode = hashCode * 59 + this.Timeout.GetHashCode();
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
            // ProgressTimeout (int?) minimum
            if(this.ProgressTimeout < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProgressTimeout, must be a value greater than or equal to 1.", new [] { "ProgressTimeout" });
            }

            yield break;
        }
    }

}
