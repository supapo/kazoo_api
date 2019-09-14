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
    /// Schema for conference profiles
    /// </summary>
    [DataContract]
    public partial class ConferencesProfile :  IEquatable<ConferencesProfile>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConferencesProfile" /> class.
        /// </summary>
        /// <param name="aloneSound">Audio that plays while you are alone in the conference.</param>
        /// <param name="announceCount">Play member count to conference when above this threshold.</param>
        /// <param name="callerControls">Name of the caller control group.</param>
        /// <param name="comfortNoise">The volume level of background white noise.</param>
        /// <param name="energyLevel">Energy level required for audio to be sent to other users.</param>
        /// <param name="enterSound">Audio to play when entering a conference.</param>
        /// <param name="exitSound">Audio to play when exiting a conference.</param>
        /// <param name="interval">Milliseconds per frame.</param>
        /// <param name="lockedSound">Audio to play when the conference is locked.</param>
        /// <param name="maxMembers">Set the maximum number of members in the conference.</param>
        /// <param name="maxMembersSound">If max-members has been reached, audio to play to caller instead of joining the conference.</param>
        /// <param name="moderatorControls">Name of the moderator control group to use.</param>
        /// <param name="mohSound">Audio to play, on a loop, while participant count is 1.</param>
        /// <param name="mutedSound">Audio to play when muted.</param>
        /// <param name="rate">Audio sample rate.</param>
        /// <param name="unmutedSound">Audio to play when unmuted.</param>
        public ConferencesProfile(string aloneSound = default(string), int? announceCount = default(int?), string callerControls = default(string), int? comfortNoise = default(int?), int? energyLevel = default(int?), string enterSound = default(string), string exitSound = default(string), int? interval = default(int?), string lockedSound = default(string), int? maxMembers = default(int?), string maxMembersSound = default(string), string moderatorControls = default(string), string mohSound = default(string), string mutedSound = default(string), int? rate = default(int?), string unmutedSound = default(string))
        {
            this.AloneSound = aloneSound;
            this.AnnounceCount = announceCount;
            this.CallerControls = callerControls;
            this.ComfortNoise = comfortNoise;
            this.EnergyLevel = energyLevel;
            this.EnterSound = enterSound;
            this.ExitSound = exitSound;
            this.Interval = interval;
            this.LockedSound = lockedSound;
            this.MaxMembers = maxMembers;
            this.MaxMembersSound = maxMembersSound;
            this.ModeratorControls = moderatorControls;
            this.MohSound = mohSound;
            this.MutedSound = mutedSound;
            this.Rate = rate;
            this.UnmutedSound = unmutedSound;
        }
        
        /// <summary>
        /// Audio that plays while you are alone in the conference
        /// </summary>
        /// <value>Audio that plays while you are alone in the conference</value>
        [DataMember(Name="alone-sound", EmitDefaultValue=false)]
        public string AloneSound { get; set; }

        /// <summary>
        /// Play member count to conference when above this threshold
        /// </summary>
        /// <value>Play member count to conference when above this threshold</value>
        [DataMember(Name="announce-count", EmitDefaultValue=false)]
        public int? AnnounceCount { get; set; }

        /// <summary>
        /// Name of the caller control group
        /// </summary>
        /// <value>Name of the caller control group</value>
        [DataMember(Name="caller-controls", EmitDefaultValue=false)]
        public string CallerControls { get; set; }

        /// <summary>
        /// The volume level of background white noise
        /// </summary>
        /// <value>The volume level of background white noise</value>
        [DataMember(Name="comfort-noise", EmitDefaultValue=false)]
        public int? ComfortNoise { get; set; }

        /// <summary>
        /// Energy level required for audio to be sent to other users
        /// </summary>
        /// <value>Energy level required for audio to be sent to other users</value>
        [DataMember(Name="energy-level", EmitDefaultValue=false)]
        public int? EnergyLevel { get; set; }

        /// <summary>
        /// Audio to play when entering a conference
        /// </summary>
        /// <value>Audio to play when entering a conference</value>
        [DataMember(Name="enter-sound", EmitDefaultValue=false)]
        public string EnterSound { get; set; }

        /// <summary>
        /// Audio to play when exiting a conference
        /// </summary>
        /// <value>Audio to play when exiting a conference</value>
        [DataMember(Name="exit-sound", EmitDefaultValue=false)]
        public string ExitSound { get; set; }

        /// <summary>
        /// Milliseconds per frame
        /// </summary>
        /// <value>Milliseconds per frame</value>
        [DataMember(Name="interval", EmitDefaultValue=false)]
        public int? Interval { get; set; }

        /// <summary>
        /// Audio to play when the conference is locked
        /// </summary>
        /// <value>Audio to play when the conference is locked</value>
        [DataMember(Name="locked-sound", EmitDefaultValue=false)]
        public string LockedSound { get; set; }

        /// <summary>
        /// Set the maximum number of members in the conference
        /// </summary>
        /// <value>Set the maximum number of members in the conference</value>
        [DataMember(Name="max-members", EmitDefaultValue=false)]
        public int? MaxMembers { get; set; }

        /// <summary>
        /// If max-members has been reached, audio to play to caller instead of joining the conference
        /// </summary>
        /// <value>If max-members has been reached, audio to play to caller instead of joining the conference</value>
        [DataMember(Name="max-members-sound", EmitDefaultValue=false)]
        public string MaxMembersSound { get; set; }

        /// <summary>
        /// Name of the moderator control group to use
        /// </summary>
        /// <value>Name of the moderator control group to use</value>
        [DataMember(Name="moderator-controls", EmitDefaultValue=false)]
        public string ModeratorControls { get; set; }

        /// <summary>
        /// Audio to play, on a loop, while participant count is 1
        /// </summary>
        /// <value>Audio to play, on a loop, while participant count is 1</value>
        [DataMember(Name="moh-sound", EmitDefaultValue=false)]
        public string MohSound { get; set; }

        /// <summary>
        /// Audio to play when muted
        /// </summary>
        /// <value>Audio to play when muted</value>
        [DataMember(Name="muted-sound", EmitDefaultValue=false)]
        public string MutedSound { get; set; }

        /// <summary>
        /// Audio sample rate
        /// </summary>
        /// <value>Audio sample rate</value>
        [DataMember(Name="rate", EmitDefaultValue=false)]
        public int? Rate { get; set; }

        /// <summary>
        /// Audio to play when unmuted
        /// </summary>
        /// <value>Audio to play when unmuted</value>
        [DataMember(Name="unmuted-sound", EmitDefaultValue=false)]
        public string UnmutedSound { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConferencesProfile {\n");
            sb.Append("  AloneSound: ").Append(AloneSound).Append("\n");
            sb.Append("  AnnounceCount: ").Append(AnnounceCount).Append("\n");
            sb.Append("  CallerControls: ").Append(CallerControls).Append("\n");
            sb.Append("  ComfortNoise: ").Append(ComfortNoise).Append("\n");
            sb.Append("  EnergyLevel: ").Append(EnergyLevel).Append("\n");
            sb.Append("  EnterSound: ").Append(EnterSound).Append("\n");
            sb.Append("  ExitSound: ").Append(ExitSound).Append("\n");
            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  LockedSound: ").Append(LockedSound).Append("\n");
            sb.Append("  MaxMembers: ").Append(MaxMembers).Append("\n");
            sb.Append("  MaxMembersSound: ").Append(MaxMembersSound).Append("\n");
            sb.Append("  ModeratorControls: ").Append(ModeratorControls).Append("\n");
            sb.Append("  MohSound: ").Append(MohSound).Append("\n");
            sb.Append("  MutedSound: ").Append(MutedSound).Append("\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
            sb.Append("  UnmutedSound: ").Append(UnmutedSound).Append("\n");
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
            return this.Equals(input as ConferencesProfile);
        }

        /// <summary>
        /// Returns true if ConferencesProfile instances are equal
        /// </summary>
        /// <param name="input">Instance of ConferencesProfile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConferencesProfile input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AloneSound == input.AloneSound ||
                    (this.AloneSound != null &&
                    this.AloneSound.Equals(input.AloneSound))
                ) && 
                (
                    this.AnnounceCount == input.AnnounceCount ||
                    (this.AnnounceCount != null &&
                    this.AnnounceCount.Equals(input.AnnounceCount))
                ) && 
                (
                    this.CallerControls == input.CallerControls ||
                    (this.CallerControls != null &&
                    this.CallerControls.Equals(input.CallerControls))
                ) && 
                (
                    this.ComfortNoise == input.ComfortNoise ||
                    (this.ComfortNoise != null &&
                    this.ComfortNoise.Equals(input.ComfortNoise))
                ) && 
                (
                    this.EnergyLevel == input.EnergyLevel ||
                    (this.EnergyLevel != null &&
                    this.EnergyLevel.Equals(input.EnergyLevel))
                ) && 
                (
                    this.EnterSound == input.EnterSound ||
                    (this.EnterSound != null &&
                    this.EnterSound.Equals(input.EnterSound))
                ) && 
                (
                    this.ExitSound == input.ExitSound ||
                    (this.ExitSound != null &&
                    this.ExitSound.Equals(input.ExitSound))
                ) && 
                (
                    this.Interval == input.Interval ||
                    (this.Interval != null &&
                    this.Interval.Equals(input.Interval))
                ) && 
                (
                    this.LockedSound == input.LockedSound ||
                    (this.LockedSound != null &&
                    this.LockedSound.Equals(input.LockedSound))
                ) && 
                (
                    this.MaxMembers == input.MaxMembers ||
                    (this.MaxMembers != null &&
                    this.MaxMembers.Equals(input.MaxMembers))
                ) && 
                (
                    this.MaxMembersSound == input.MaxMembersSound ||
                    (this.MaxMembersSound != null &&
                    this.MaxMembersSound.Equals(input.MaxMembersSound))
                ) && 
                (
                    this.ModeratorControls == input.ModeratorControls ||
                    (this.ModeratorControls != null &&
                    this.ModeratorControls.Equals(input.ModeratorControls))
                ) && 
                (
                    this.MohSound == input.MohSound ||
                    (this.MohSound != null &&
                    this.MohSound.Equals(input.MohSound))
                ) && 
                (
                    this.MutedSound == input.MutedSound ||
                    (this.MutedSound != null &&
                    this.MutedSound.Equals(input.MutedSound))
                ) && 
                (
                    this.Rate == input.Rate ||
                    (this.Rate != null &&
                    this.Rate.Equals(input.Rate))
                ) && 
                (
                    this.UnmutedSound == input.UnmutedSound ||
                    (this.UnmutedSound != null &&
                    this.UnmutedSound.Equals(input.UnmutedSound))
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
                if (this.AloneSound != null)
                    hashCode = hashCode * 59 + this.AloneSound.GetHashCode();
                if (this.AnnounceCount != null)
                    hashCode = hashCode * 59 + this.AnnounceCount.GetHashCode();
                if (this.CallerControls != null)
                    hashCode = hashCode * 59 + this.CallerControls.GetHashCode();
                if (this.ComfortNoise != null)
                    hashCode = hashCode * 59 + this.ComfortNoise.GetHashCode();
                if (this.EnergyLevel != null)
                    hashCode = hashCode * 59 + this.EnergyLevel.GetHashCode();
                if (this.EnterSound != null)
                    hashCode = hashCode * 59 + this.EnterSound.GetHashCode();
                if (this.ExitSound != null)
                    hashCode = hashCode * 59 + this.ExitSound.GetHashCode();
                if (this.Interval != null)
                    hashCode = hashCode * 59 + this.Interval.GetHashCode();
                if (this.LockedSound != null)
                    hashCode = hashCode * 59 + this.LockedSound.GetHashCode();
                if (this.MaxMembers != null)
                    hashCode = hashCode * 59 + this.MaxMembers.GetHashCode();
                if (this.MaxMembersSound != null)
                    hashCode = hashCode * 59 + this.MaxMembersSound.GetHashCode();
                if (this.ModeratorControls != null)
                    hashCode = hashCode * 59 + this.ModeratorControls.GetHashCode();
                if (this.MohSound != null)
                    hashCode = hashCode * 59 + this.MohSound.GetHashCode();
                if (this.MutedSound != null)
                    hashCode = hashCode * 59 + this.MutedSound.GetHashCode();
                if (this.Rate != null)
                    hashCode = hashCode * 59 + this.Rate.GetHashCode();
                if (this.UnmutedSound != null)
                    hashCode = hashCode * 59 + this.UnmutedSound.GetHashCode();
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
            // ComfortNoise (int?) maximum
            if(this.ComfortNoise > (int?)10000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ComfortNoise, must be a value less than or equal to 10000.", new [] { "ComfortNoise" });
            }

            // ComfortNoise (int?) minimum
            if(this.ComfortNoise < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ComfortNoise, must be a value greater than or equal to 0.", new [] { "ComfortNoise" });
            }

            // EnergyLevel (int?) maximum
            if(this.EnergyLevel > (int?)1800)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EnergyLevel, must be a value less than or equal to 1800.", new [] { "EnergyLevel" });
            }

            // EnergyLevel (int?) minimum
            if(this.EnergyLevel < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EnergyLevel, must be a value greater than or equal to 0.", new [] { "EnergyLevel" });
            }

            // Interval (int?) maximum
            if(this.Interval > (int?)120)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Interval, must be a value less than or equal to 120.", new [] { "Interval" });
            }

            // Interval (int?) minimum
            if(this.Interval < (int?)10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Interval, must be a value greater than or equal to 10.", new [] { "Interval" });
            }

            // MaxMembers (int?) minimum
            if(this.MaxMembers < (int?)2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaxMembers, must be a value greater than or equal to 2.", new [] { "MaxMembers" });
            }

            yield break;
        }
    }

}
