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
    /// Schema for conferences system_config
    /// </summary>
    [DataContract]
    public partial class SystemConfigConferences :  IEquatable<SystemConfigConferences>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemConfigConferences" /> class.
        /// </summary>
        /// <param name="bridgePassword">conferences bridge password.</param>
        /// <param name="bridgeUsername">conferences bridge username.</param>
        /// <param name="controls">controls.</param>
        /// <param name="entryTone">conferences entry tone (default to &quot;tone_stream://v&#x3D;-7;&gt;&#x3D;2;+&#x3D;.1;%(300,0,523,659);v&#x3D;-7;&gt;&#x3D;3;+&#x3D;.1;%(800,0,659,783)&quot;).</param>
        /// <param name="exitTone">conferences exit tone (default to &quot;tone_stream://v&#x3D;-7;&gt;&#x3D;2;+&#x3D;.1;%(300,0,523,440);v&#x3D;-7;&gt;&#x3D;3;+&#x3D;.1;%(800,0,349,440)&quot;).</param>
        /// <param name="moderatorEntryTone">conferences moderator entry tone (default to &quot;tone_stream://v&#x3D;-7;&gt;&#x3D;2;+&#x3D;.1;%(300,0,523,659);v&#x3D;-7;&gt;&#x3D;3;+&#x3D;.1;%(800,0,659,783)&quot;).</param>
        /// <param name="moderatorExitTone">conferences moderator exit tone (default to &quot;tone_stream://v&#x3D;-7;&gt;&#x3D;2;+&#x3D;.1;%(300,0,523,440);v&#x3D;-7;&gt;&#x3D;3;+&#x3D;.1;%(800,0,349,440)&quot;).</param>
        /// <param name="numberTimeout">conferences number timeout.</param>
        /// <param name="participantSanityCheckMs">conferences participant_sanity_check_ms.</param>
        /// <param name="pinTimeout">conferences pin timeout.</param>
        /// <param name="profiles">profiles.</param>
        /// <param name="reviewName">conferences review name (default to false).</param>
        /// <param name="routeWinTimeout">conferences route win timeout.</param>
        /// <param name="supportNameAnnouncement">conferences support name announcement (default to true).</param>
        public SystemConfigConferences(string bridgePassword = default(string), string bridgeUsername = default(string), AccountConfigConferencesControls controls = default(AccountConfigConferencesControls), string entryTone = "tone_stream://v=-7;>=2;+=.1;%(300,0,523,659);v=-7;>=3;+=.1;%(800,0,659,783)", string exitTone = "tone_stream://v=-7;>=2;+=.1;%(300,0,523,440);v=-7;>=3;+=.1;%(800,0,349,440)", string moderatorEntryTone = "tone_stream://v=-7;>=2;+=.1;%(300,0,523,659);v=-7;>=3;+=.1;%(800,0,659,783)", string moderatorExitTone = "tone_stream://v=-7;>=2;+=.1;%(300,0,523,440);v=-7;>=3;+=.1;%(800,0,349,440)", int? numberTimeout = default(int?), int? participantSanityCheckMs = default(int?), int? pinTimeout = default(int?), SystemConfigConferencesProfiles profiles = default(SystemConfigConferencesProfiles), bool? reviewName = false, int? routeWinTimeout = default(int?), bool? supportNameAnnouncement = true)
        {
            this.BridgePassword = bridgePassword;
            this.BridgeUsername = bridgeUsername;
            this.Controls = controls;
            // use default value if no "entryTone" provided
            if (entryTone == null)
            {
                this.EntryTone = "tone_stream://v=-7;>=2;+=.1;%(300,0,523,659);v=-7;>=3;+=.1;%(800,0,659,783)";
            }
            else
            {
                this.EntryTone = entryTone;
            }
            // use default value if no "exitTone" provided
            if (exitTone == null)
            {
                this.ExitTone = "tone_stream://v=-7;>=2;+=.1;%(300,0,523,440);v=-7;>=3;+=.1;%(800,0,349,440)";
            }
            else
            {
                this.ExitTone = exitTone;
            }
            // use default value if no "moderatorEntryTone" provided
            if (moderatorEntryTone == null)
            {
                this.ModeratorEntryTone = "tone_stream://v=-7;>=2;+=.1;%(300,0,523,659);v=-7;>=3;+=.1;%(800,0,659,783)";
            }
            else
            {
                this.ModeratorEntryTone = moderatorEntryTone;
            }
            // use default value if no "moderatorExitTone" provided
            if (moderatorExitTone == null)
            {
                this.ModeratorExitTone = "tone_stream://v=-7;>=2;+=.1;%(300,0,523,440);v=-7;>=3;+=.1;%(800,0,349,440)";
            }
            else
            {
                this.ModeratorExitTone = moderatorExitTone;
            }
            this.NumberTimeout = numberTimeout;
            this.ParticipantSanityCheckMs = participantSanityCheckMs;
            this.PinTimeout = pinTimeout;
            this.Profiles = profiles;
            // use default value if no "reviewName" provided
            if (reviewName == null)
            {
                this.ReviewName = false;
            }
            else
            {
                this.ReviewName = reviewName;
            }
            this.RouteWinTimeout = routeWinTimeout;
            // use default value if no "supportNameAnnouncement" provided
            if (supportNameAnnouncement == null)
            {
                this.SupportNameAnnouncement = true;
            }
            else
            {
                this.SupportNameAnnouncement = supportNameAnnouncement;
            }
        }
        
        /// <summary>
        /// conferences bridge password
        /// </summary>
        /// <value>conferences bridge password</value>
        [DataMember(Name="bridge_password", EmitDefaultValue=false)]
        public string BridgePassword { get; set; }

        /// <summary>
        /// conferences bridge username
        /// </summary>
        /// <value>conferences bridge username</value>
        [DataMember(Name="bridge_username", EmitDefaultValue=false)]
        public string BridgeUsername { get; set; }

        /// <summary>
        /// Gets or Sets Controls
        /// </summary>
        [DataMember(Name="controls", EmitDefaultValue=false)]
        public AccountConfigConferencesControls Controls { get; set; }

        /// <summary>
        /// conferences entry tone
        /// </summary>
        /// <value>conferences entry tone</value>
        [DataMember(Name="entry_tone", EmitDefaultValue=false)]
        public string EntryTone { get; set; }

        /// <summary>
        /// conferences exit tone
        /// </summary>
        /// <value>conferences exit tone</value>
        [DataMember(Name="exit_tone", EmitDefaultValue=false)]
        public string ExitTone { get; set; }

        /// <summary>
        /// conferences moderator entry tone
        /// </summary>
        /// <value>conferences moderator entry tone</value>
        [DataMember(Name="moderator_entry_tone", EmitDefaultValue=false)]
        public string ModeratorEntryTone { get; set; }

        /// <summary>
        /// conferences moderator exit tone
        /// </summary>
        /// <value>conferences moderator exit tone</value>
        [DataMember(Name="moderator_exit_tone", EmitDefaultValue=false)]
        public string ModeratorExitTone { get; set; }

        /// <summary>
        /// conferences number timeout
        /// </summary>
        /// <value>conferences number timeout</value>
        [DataMember(Name="number_timeout", EmitDefaultValue=false)]
        public int? NumberTimeout { get; set; }

        /// <summary>
        /// conferences participant_sanity_check_ms
        /// </summary>
        /// <value>conferences participant_sanity_check_ms</value>
        [DataMember(Name="participant_sanity_check_ms", EmitDefaultValue=false)]
        public int? ParticipantSanityCheckMs { get; set; }

        /// <summary>
        /// conferences pin timeout
        /// </summary>
        /// <value>conferences pin timeout</value>
        [DataMember(Name="pin_timeout", EmitDefaultValue=false)]
        public int? PinTimeout { get; set; }

        /// <summary>
        /// Gets or Sets Profiles
        /// </summary>
        [DataMember(Name="profiles", EmitDefaultValue=false)]
        public SystemConfigConferencesProfiles Profiles { get; set; }

        /// <summary>
        /// conferences review name
        /// </summary>
        /// <value>conferences review name</value>
        [DataMember(Name="review_name", EmitDefaultValue=false)]
        public bool? ReviewName { get; set; }

        /// <summary>
        /// conferences route win timeout
        /// </summary>
        /// <value>conferences route win timeout</value>
        [DataMember(Name="route_win_timeout", EmitDefaultValue=false)]
        public int? RouteWinTimeout { get; set; }

        /// <summary>
        /// conferences support name announcement
        /// </summary>
        /// <value>conferences support name announcement</value>
        [DataMember(Name="support_name_announcement", EmitDefaultValue=false)]
        public bool? SupportNameAnnouncement { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SystemConfigConferences {\n");
            sb.Append("  BridgePassword: ").Append(BridgePassword).Append("\n");
            sb.Append("  BridgeUsername: ").Append(BridgeUsername).Append("\n");
            sb.Append("  Controls: ").Append(Controls).Append("\n");
            sb.Append("  EntryTone: ").Append(EntryTone).Append("\n");
            sb.Append("  ExitTone: ").Append(ExitTone).Append("\n");
            sb.Append("  ModeratorEntryTone: ").Append(ModeratorEntryTone).Append("\n");
            sb.Append("  ModeratorExitTone: ").Append(ModeratorExitTone).Append("\n");
            sb.Append("  NumberTimeout: ").Append(NumberTimeout).Append("\n");
            sb.Append("  ParticipantSanityCheckMs: ").Append(ParticipantSanityCheckMs).Append("\n");
            sb.Append("  PinTimeout: ").Append(PinTimeout).Append("\n");
            sb.Append("  Profiles: ").Append(Profiles).Append("\n");
            sb.Append("  ReviewName: ").Append(ReviewName).Append("\n");
            sb.Append("  RouteWinTimeout: ").Append(RouteWinTimeout).Append("\n");
            sb.Append("  SupportNameAnnouncement: ").Append(SupportNameAnnouncement).Append("\n");
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
            return this.Equals(input as SystemConfigConferences);
        }

        /// <summary>
        /// Returns true if SystemConfigConferences instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemConfigConferences to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemConfigConferences input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BridgePassword == input.BridgePassword ||
                    (this.BridgePassword != null &&
                    this.BridgePassword.Equals(input.BridgePassword))
                ) && 
                (
                    this.BridgeUsername == input.BridgeUsername ||
                    (this.BridgeUsername != null &&
                    this.BridgeUsername.Equals(input.BridgeUsername))
                ) && 
                (
                    this.Controls == input.Controls ||
                    (this.Controls != null &&
                    this.Controls.Equals(input.Controls))
                ) && 
                (
                    this.EntryTone == input.EntryTone ||
                    (this.EntryTone != null &&
                    this.EntryTone.Equals(input.EntryTone))
                ) && 
                (
                    this.ExitTone == input.ExitTone ||
                    (this.ExitTone != null &&
                    this.ExitTone.Equals(input.ExitTone))
                ) && 
                (
                    this.ModeratorEntryTone == input.ModeratorEntryTone ||
                    (this.ModeratorEntryTone != null &&
                    this.ModeratorEntryTone.Equals(input.ModeratorEntryTone))
                ) && 
                (
                    this.ModeratorExitTone == input.ModeratorExitTone ||
                    (this.ModeratorExitTone != null &&
                    this.ModeratorExitTone.Equals(input.ModeratorExitTone))
                ) && 
                (
                    this.NumberTimeout == input.NumberTimeout ||
                    (this.NumberTimeout != null &&
                    this.NumberTimeout.Equals(input.NumberTimeout))
                ) && 
                (
                    this.ParticipantSanityCheckMs == input.ParticipantSanityCheckMs ||
                    (this.ParticipantSanityCheckMs != null &&
                    this.ParticipantSanityCheckMs.Equals(input.ParticipantSanityCheckMs))
                ) && 
                (
                    this.PinTimeout == input.PinTimeout ||
                    (this.PinTimeout != null &&
                    this.PinTimeout.Equals(input.PinTimeout))
                ) && 
                (
                    this.Profiles == input.Profiles ||
                    (this.Profiles != null &&
                    this.Profiles.Equals(input.Profiles))
                ) && 
                (
                    this.ReviewName == input.ReviewName ||
                    (this.ReviewName != null &&
                    this.ReviewName.Equals(input.ReviewName))
                ) && 
                (
                    this.RouteWinTimeout == input.RouteWinTimeout ||
                    (this.RouteWinTimeout != null &&
                    this.RouteWinTimeout.Equals(input.RouteWinTimeout))
                ) && 
                (
                    this.SupportNameAnnouncement == input.SupportNameAnnouncement ||
                    (this.SupportNameAnnouncement != null &&
                    this.SupportNameAnnouncement.Equals(input.SupportNameAnnouncement))
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
                if (this.BridgePassword != null)
                    hashCode = hashCode * 59 + this.BridgePassword.GetHashCode();
                if (this.BridgeUsername != null)
                    hashCode = hashCode * 59 + this.BridgeUsername.GetHashCode();
                if (this.Controls != null)
                    hashCode = hashCode * 59 + this.Controls.GetHashCode();
                if (this.EntryTone != null)
                    hashCode = hashCode * 59 + this.EntryTone.GetHashCode();
                if (this.ExitTone != null)
                    hashCode = hashCode * 59 + this.ExitTone.GetHashCode();
                if (this.ModeratorEntryTone != null)
                    hashCode = hashCode * 59 + this.ModeratorEntryTone.GetHashCode();
                if (this.ModeratorExitTone != null)
                    hashCode = hashCode * 59 + this.ModeratorExitTone.GetHashCode();
                if (this.NumberTimeout != null)
                    hashCode = hashCode * 59 + this.NumberTimeout.GetHashCode();
                if (this.ParticipantSanityCheckMs != null)
                    hashCode = hashCode * 59 + this.ParticipantSanityCheckMs.GetHashCode();
                if (this.PinTimeout != null)
                    hashCode = hashCode * 59 + this.PinTimeout.GetHashCode();
                if (this.Profiles != null)
                    hashCode = hashCode * 59 + this.Profiles.GetHashCode();
                if (this.ReviewName != null)
                    hashCode = hashCode * 59 + this.ReviewName.GetHashCode();
                if (this.RouteWinTimeout != null)
                    hashCode = hashCode * 59 + this.RouteWinTimeout.GetHashCode();
                if (this.SupportNameAnnouncement != null)
                    hashCode = hashCode * 59 + this.SupportNameAnnouncement.GetHashCode();
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