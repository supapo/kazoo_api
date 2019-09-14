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
    /// endpoint recording settings
    /// </summary>
    [DataContract]
    public partial class CallRecordings :  IEquatable<CallRecordings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CallRecordings" /> class.
        /// </summary>
        /// <param name="callId">call_id.</param>
        /// <param name="calleeIdName">callee_id_name.</param>
        /// <param name="calleeIdNumber">callee_id_number.</param>
        /// <param name="callerIdName">caller_id_name.</param>
        /// <param name="callerIdNumber">caller_id_number.</param>
        /// <param name="cdrId">cdr_id.</param>
        /// <param name="contentType">content_type.</param>
        /// <param name="customChannelVars">custom_channel_vars.</param>
        /// <param name="description">description.</param>
        /// <param name="direction">direction.</param>
        /// <param name="duration">duration.</param>
        /// <param name="durationMs">duration_ms.</param>
        /// <param name="from">from.</param>
        /// <param name="interactionId">interaction_id.</param>
        /// <param name="mediaSource">media_source.</param>
        /// <param name="mediaType">media_type.</param>
        /// <param name="name">name.</param>
        /// <param name="origin">origin.</param>
        /// <param name="ownerId">owner_id.</param>
        /// <param name="request">request.</param>
        /// <param name="sourceType">source_type.</param>
        /// <param name="start">start timestamp, in Gregorian seconds.</param>
        /// <param name="to">to.</param>
        /// <param name="url">url.</param>
        public CallRecordings(string callId = default(string), string calleeIdName = default(string), string calleeIdNumber = default(string), string callerIdName = default(string), string callerIdNumber = default(string), string cdrId = default(string), string contentType = default(string), Object customChannelVars = default(Object), string description = default(string), string direction = default(string), int? duration = default(int?), int? durationMs = default(int?), string from = default(string), string interactionId = default(string), string mediaSource = default(string), string mediaType = default(string), string name = default(string), string origin = default(string), string ownerId = default(string), string request = default(string), string sourceType = default(string), int? start = default(int?), string to = default(string), string url = default(string))
        {
            this.CallId = callId;
            this.CalleeIdName = calleeIdName;
            this.CalleeIdNumber = calleeIdNumber;
            this.CallerIdName = callerIdName;
            this.CallerIdNumber = callerIdNumber;
            this.CdrId = cdrId;
            this.ContentType = contentType;
            this.CustomChannelVars = customChannelVars;
            this.Description = description;
            this.Direction = direction;
            this.Duration = duration;
            this.DurationMs = durationMs;
            this.From = from;
            this.InteractionId = interactionId;
            this.MediaSource = mediaSource;
            this.MediaType = mediaType;
            this.Name = name;
            this.Origin = origin;
            this.OwnerId = ownerId;
            this.Request = request;
            this.SourceType = sourceType;
            this.Start = start;
            this.To = to;
            this.Url = url;
        }
        
        /// <summary>
        /// call_id
        /// </summary>
        /// <value>call_id</value>
        [DataMember(Name="call_id", EmitDefaultValue=false)]
        public string CallId { get; set; }

        /// <summary>
        /// callee_id_name
        /// </summary>
        /// <value>callee_id_name</value>
        [DataMember(Name="callee_id_name", EmitDefaultValue=false)]
        public string CalleeIdName { get; set; }

        /// <summary>
        /// callee_id_number
        /// </summary>
        /// <value>callee_id_number</value>
        [DataMember(Name="callee_id_number", EmitDefaultValue=false)]
        public string CalleeIdNumber { get; set; }

        /// <summary>
        /// caller_id_name
        /// </summary>
        /// <value>caller_id_name</value>
        [DataMember(Name="caller_id_name", EmitDefaultValue=false)]
        public string CallerIdName { get; set; }

        /// <summary>
        /// caller_id_number
        /// </summary>
        /// <value>caller_id_number</value>
        [DataMember(Name="caller_id_number", EmitDefaultValue=false)]
        public string CallerIdNumber { get; set; }

        /// <summary>
        /// cdr_id
        /// </summary>
        /// <value>cdr_id</value>
        [DataMember(Name="cdr_id", EmitDefaultValue=false)]
        public string CdrId { get; set; }

        /// <summary>
        /// content_type
        /// </summary>
        /// <value>content_type</value>
        [DataMember(Name="content_type", EmitDefaultValue=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// custom_channel_vars
        /// </summary>
        /// <value>custom_channel_vars</value>
        [DataMember(Name="custom_channel_vars", EmitDefaultValue=false)]
        public Object CustomChannelVars { get; set; }

        /// <summary>
        /// description
        /// </summary>
        /// <value>description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// direction
        /// </summary>
        /// <value>direction</value>
        [DataMember(Name="direction", EmitDefaultValue=false)]
        public string Direction { get; set; }

        /// <summary>
        /// duration
        /// </summary>
        /// <value>duration</value>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// duration_ms
        /// </summary>
        /// <value>duration_ms</value>
        [DataMember(Name="duration_ms", EmitDefaultValue=false)]
        public int? DurationMs { get; set; }

        /// <summary>
        /// from
        /// </summary>
        /// <value>from</value>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public string From { get; set; }

        /// <summary>
        /// interaction_id
        /// </summary>
        /// <value>interaction_id</value>
        [DataMember(Name="interaction_id", EmitDefaultValue=false)]
        public string InteractionId { get; set; }

        /// <summary>
        /// media_source
        /// </summary>
        /// <value>media_source</value>
        [DataMember(Name="media_source", EmitDefaultValue=false)]
        public string MediaSource { get; set; }

        /// <summary>
        /// media_type
        /// </summary>
        /// <value>media_type</value>
        [DataMember(Name="media_type", EmitDefaultValue=false)]
        public string MediaType { get; set; }

        /// <summary>
        /// name
        /// </summary>
        /// <value>name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// origin
        /// </summary>
        /// <value>origin</value>
        [DataMember(Name="origin", EmitDefaultValue=false)]
        public string Origin { get; set; }

        /// <summary>
        /// owner_id
        /// </summary>
        /// <value>owner_id</value>
        [DataMember(Name="owner_id", EmitDefaultValue=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// request
        /// </summary>
        /// <value>request</value>
        [DataMember(Name="request", EmitDefaultValue=false)]
        public string Request { get; set; }

        /// <summary>
        /// source_type
        /// </summary>
        /// <value>source_type</value>
        [DataMember(Name="source_type", EmitDefaultValue=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// start timestamp, in Gregorian seconds
        /// </summary>
        /// <value>start timestamp, in Gregorian seconds</value>
        [DataMember(Name="start", EmitDefaultValue=false)]
        public int? Start { get; set; }

        /// <summary>
        /// to
        /// </summary>
        /// <value>to</value>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public string To { get; set; }

        /// <summary>
        /// url
        /// </summary>
        /// <value>url</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CallRecordings {\n");
            sb.Append("  CallId: ").Append(CallId).Append("\n");
            sb.Append("  CalleeIdName: ").Append(CalleeIdName).Append("\n");
            sb.Append("  CalleeIdNumber: ").Append(CalleeIdNumber).Append("\n");
            sb.Append("  CallerIdName: ").Append(CallerIdName).Append("\n");
            sb.Append("  CallerIdNumber: ").Append(CallerIdNumber).Append("\n");
            sb.Append("  CdrId: ").Append(CdrId).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  CustomChannelVars: ").Append(CustomChannelVars).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  DurationMs: ").Append(DurationMs).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  InteractionId: ").Append(InteractionId).Append("\n");
            sb.Append("  MediaSource: ").Append(MediaSource).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  Request: ").Append(Request).Append("\n");
            sb.Append("  SourceType: ").Append(SourceType).Append("\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as CallRecordings);
        }

        /// <summary>
        /// Returns true if CallRecordings instances are equal
        /// </summary>
        /// <param name="input">Instance of CallRecordings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallRecordings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CallId == input.CallId ||
                    (this.CallId != null &&
                    this.CallId.Equals(input.CallId))
                ) && 
                (
                    this.CalleeIdName == input.CalleeIdName ||
                    (this.CalleeIdName != null &&
                    this.CalleeIdName.Equals(input.CalleeIdName))
                ) && 
                (
                    this.CalleeIdNumber == input.CalleeIdNumber ||
                    (this.CalleeIdNumber != null &&
                    this.CalleeIdNumber.Equals(input.CalleeIdNumber))
                ) && 
                (
                    this.CallerIdName == input.CallerIdName ||
                    (this.CallerIdName != null &&
                    this.CallerIdName.Equals(input.CallerIdName))
                ) && 
                (
                    this.CallerIdNumber == input.CallerIdNumber ||
                    (this.CallerIdNumber != null &&
                    this.CallerIdNumber.Equals(input.CallerIdNumber))
                ) && 
                (
                    this.CdrId == input.CdrId ||
                    (this.CdrId != null &&
                    this.CdrId.Equals(input.CdrId))
                ) && 
                (
                    this.ContentType == input.ContentType ||
                    (this.ContentType != null &&
                    this.ContentType.Equals(input.ContentType))
                ) && 
                (
                    this.CustomChannelVars == input.CustomChannelVars ||
                    (this.CustomChannelVars != null &&
                    this.CustomChannelVars.Equals(input.CustomChannelVars))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Direction == input.Direction ||
                    (this.Direction != null &&
                    this.Direction.Equals(input.Direction))
                ) && 
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
                ) && 
                (
                    this.DurationMs == input.DurationMs ||
                    (this.DurationMs != null &&
                    this.DurationMs.Equals(input.DurationMs))
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.InteractionId == input.InteractionId ||
                    (this.InteractionId != null &&
                    this.InteractionId.Equals(input.InteractionId))
                ) && 
                (
                    this.MediaSource == input.MediaSource ||
                    (this.MediaSource != null &&
                    this.MediaSource.Equals(input.MediaSource))
                ) && 
                (
                    this.MediaType == input.MediaType ||
                    (this.MediaType != null &&
                    this.MediaType.Equals(input.MediaType))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Origin == input.Origin ||
                    (this.Origin != null &&
                    this.Origin.Equals(input.Origin))
                ) && 
                (
                    this.OwnerId == input.OwnerId ||
                    (this.OwnerId != null &&
                    this.OwnerId.Equals(input.OwnerId))
                ) && 
                (
                    this.Request == input.Request ||
                    (this.Request != null &&
                    this.Request.Equals(input.Request))
                ) && 
                (
                    this.SourceType == input.SourceType ||
                    (this.SourceType != null &&
                    this.SourceType.Equals(input.SourceType))
                ) && 
                (
                    this.Start == input.Start ||
                    (this.Start != null &&
                    this.Start.Equals(input.Start))
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.CallId != null)
                    hashCode = hashCode * 59 + this.CallId.GetHashCode();
                if (this.CalleeIdName != null)
                    hashCode = hashCode * 59 + this.CalleeIdName.GetHashCode();
                if (this.CalleeIdNumber != null)
                    hashCode = hashCode * 59 + this.CalleeIdNumber.GetHashCode();
                if (this.CallerIdName != null)
                    hashCode = hashCode * 59 + this.CallerIdName.GetHashCode();
                if (this.CallerIdNumber != null)
                    hashCode = hashCode * 59 + this.CallerIdNumber.GetHashCode();
                if (this.CdrId != null)
                    hashCode = hashCode * 59 + this.CdrId.GetHashCode();
                if (this.ContentType != null)
                    hashCode = hashCode * 59 + this.ContentType.GetHashCode();
                if (this.CustomChannelVars != null)
                    hashCode = hashCode * 59 + this.CustomChannelVars.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Direction != null)
                    hashCode = hashCode * 59 + this.Direction.GetHashCode();
                if (this.Duration != null)
                    hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.DurationMs != null)
                    hashCode = hashCode * 59 + this.DurationMs.GetHashCode();
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.InteractionId != null)
                    hashCode = hashCode * 59 + this.InteractionId.GetHashCode();
                if (this.MediaSource != null)
                    hashCode = hashCode * 59 + this.MediaSource.GetHashCode();
                if (this.MediaType != null)
                    hashCode = hashCode * 59 + this.MediaType.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Origin != null)
                    hashCode = hashCode * 59 + this.Origin.GetHashCode();
                if (this.OwnerId != null)
                    hashCode = hashCode * 59 + this.OwnerId.GetHashCode();
                if (this.Request != null)
                    hashCode = hashCode * 59 + this.Request.GetHashCode();
                if (this.SourceType != null)
                    hashCode = hashCode * 59 + this.SourceType.GetHashCode();
                if (this.Start != null)
                    hashCode = hashCode * 59 + this.Start.GetHashCode();
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
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
            // Duration (int?) minimum
            if(this.Duration < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Duration, must be a value greater than or equal to 0.", new [] { "Duration" });
            }

            // DurationMs (int?) minimum
            if(this.DurationMs < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DurationMs, must be a value greater than or equal to 0.", new [] { "DurationMs" });
            }

            yield break;
        }
    }

}