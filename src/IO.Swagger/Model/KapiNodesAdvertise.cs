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
    /// AMQP API for nodes.advertise
    /// </summary>
    [DataContract]
    public partial class KapiNodesAdvertise :  IEquatable<KapiNodesAdvertise>, IValidatableObject
    {
        /// <summary>
        /// Defines EventCategory
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventCategoryEnum
        {
            
            /// <summary>
            /// Enum Nodes for value: nodes
            /// </summary>
            [EnumMember(Value = "nodes")]
            Nodes = 1
        }

        /// <summary>
        /// Gets or Sets EventCategory
        /// </summary>
        [DataMember(Name="Event-Category", EmitDefaultValue=false)]
        public EventCategoryEnum? EventCategory { get; set; }
        /// <summary>
        /// Defines EventName
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventNameEnum
        {
            
            /// <summary>
            /// Enum Advertise for value: advertise
            /// </summary>
            [EnumMember(Value = "advertise")]
            Advertise = 1
        }

        /// <summary>
        /// Gets or Sets EventName
        /// </summary>
        [DataMember(Name="Event-Name", EmitDefaultValue=false)]
        public EventNameEnum? EventName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiNodesAdvertise" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KapiNodesAdvertise() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiNodesAdvertise" /> class.
        /// </summary>
        /// <param name="channels">channels.</param>
        /// <param name="conferences">conferences.</param>
        /// <param name="eventCategory">eventCategory.</param>
        /// <param name="eventName">eventName.</param>
        /// <param name="expires">expires (required).</param>
        /// <param name="globals">globals.</param>
        /// <param name="mediaServers">mediaServers.</param>
        /// <param name="nodeInfo">nodeInfo.</param>
        /// <param name="ports">ports.</param>
        /// <param name="processes">processes.</param>
        /// <param name="registrations">registrations.</param>
        /// <param name="usedMemory">usedMemory.</param>
        /// <param name="version">version.</param>
        /// <param name="whApps">whApps.</param>
        /// <param name="zone">zone.</param>
        /// <param name="md5">md5.</param>
        public KapiNodesAdvertise(string channels = default(string), string conferences = default(string), EventCategoryEnum? eventCategory = default(EventCategoryEnum?), EventNameEnum? eventName = default(EventNameEnum?), string expires = default(string), string globals = default(string), string mediaServers = default(string), string nodeInfo = default(string), string ports = default(string), string processes = default(string), string registrations = default(string), string usedMemory = default(string), string version = default(string), string whApps = default(string), string zone = default(string), string md5 = default(string))
        {
            // to ensure "expires" is required (not null)
            if (expires == null)
            {
                throw new InvalidDataException("expires is a required property for KapiNodesAdvertise and cannot be null");
            }
            else
            {
                this.Expires = expires;
            }
            this.Channels = channels;
            this.Conferences = conferences;
            this.EventCategory = eventCategory;
            this.EventName = eventName;
            this.Globals = globals;
            this.MediaServers = mediaServers;
            this.NodeInfo = nodeInfo;
            this.Ports = ports;
            this.Processes = processes;
            this.Registrations = registrations;
            this.UsedMemory = usedMemory;
            this.Version = version;
            this.WhApps = whApps;
            this.Zone = zone;
            this.Md5 = md5;
        }
        
        /// <summary>
        /// Gets or Sets Channels
        /// </summary>
        [DataMember(Name="Channels", EmitDefaultValue=false)]
        public string Channels { get; set; }

        /// <summary>
        /// Gets or Sets Conferences
        /// </summary>
        [DataMember(Name="Conferences", EmitDefaultValue=false)]
        public string Conferences { get; set; }



        /// <summary>
        /// Gets or Sets Expires
        /// </summary>
        [DataMember(Name="Expires", EmitDefaultValue=false)]
        public string Expires { get; set; }

        /// <summary>
        /// Gets or Sets Globals
        /// </summary>
        [DataMember(Name="Globals", EmitDefaultValue=false)]
        public string Globals { get; set; }

        /// <summary>
        /// Gets or Sets MediaServers
        /// </summary>
        [DataMember(Name="Media-Servers", EmitDefaultValue=false)]
        public string MediaServers { get; set; }

        /// <summary>
        /// Gets or Sets NodeInfo
        /// </summary>
        [DataMember(Name="Node-Info", EmitDefaultValue=false)]
        public string NodeInfo { get; set; }

        /// <summary>
        /// Gets or Sets Ports
        /// </summary>
        [DataMember(Name="Ports", EmitDefaultValue=false)]
        public string Ports { get; set; }

        /// <summary>
        /// Gets or Sets Processes
        /// </summary>
        [DataMember(Name="Processes", EmitDefaultValue=false)]
        public string Processes { get; set; }

        /// <summary>
        /// Gets or Sets Registrations
        /// </summary>
        [DataMember(Name="Registrations", EmitDefaultValue=false)]
        public string Registrations { get; set; }

        /// <summary>
        /// Gets or Sets UsedMemory
        /// </summary>
        [DataMember(Name="Used-Memory", EmitDefaultValue=false)]
        public string UsedMemory { get; set; }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="Version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// Gets or Sets WhApps
        /// </summary>
        [DataMember(Name="WhApps", EmitDefaultValue=false)]
        public string WhApps { get; set; }

        /// <summary>
        /// Gets or Sets Zone
        /// </summary>
        [DataMember(Name="Zone", EmitDefaultValue=false)]
        public string Zone { get; set; }

        /// <summary>
        /// Gets or Sets Md5
        /// </summary>
        [DataMember(Name="md5", EmitDefaultValue=false)]
        public string Md5 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KapiNodesAdvertise {\n");
            sb.Append("  Channels: ").Append(Channels).Append("\n");
            sb.Append("  Conferences: ").Append(Conferences).Append("\n");
            sb.Append("  EventCategory: ").Append(EventCategory).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  Expires: ").Append(Expires).Append("\n");
            sb.Append("  Globals: ").Append(Globals).Append("\n");
            sb.Append("  MediaServers: ").Append(MediaServers).Append("\n");
            sb.Append("  NodeInfo: ").Append(NodeInfo).Append("\n");
            sb.Append("  Ports: ").Append(Ports).Append("\n");
            sb.Append("  Processes: ").Append(Processes).Append("\n");
            sb.Append("  Registrations: ").Append(Registrations).Append("\n");
            sb.Append("  UsedMemory: ").Append(UsedMemory).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  WhApps: ").Append(WhApps).Append("\n");
            sb.Append("  Zone: ").Append(Zone).Append("\n");
            sb.Append("  Md5: ").Append(Md5).Append("\n");
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
            return this.Equals(input as KapiNodesAdvertise);
        }

        /// <summary>
        /// Returns true if KapiNodesAdvertise instances are equal
        /// </summary>
        /// <param name="input">Instance of KapiNodesAdvertise to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KapiNodesAdvertise input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Channels == input.Channels ||
                    (this.Channels != null &&
                    this.Channels.Equals(input.Channels))
                ) && 
                (
                    this.Conferences == input.Conferences ||
                    (this.Conferences != null &&
                    this.Conferences.Equals(input.Conferences))
                ) && 
                (
                    this.EventCategory == input.EventCategory ||
                    (this.EventCategory != null &&
                    this.EventCategory.Equals(input.EventCategory))
                ) && 
                (
                    this.EventName == input.EventName ||
                    (this.EventName != null &&
                    this.EventName.Equals(input.EventName))
                ) && 
                (
                    this.Expires == input.Expires ||
                    (this.Expires != null &&
                    this.Expires.Equals(input.Expires))
                ) && 
                (
                    this.Globals == input.Globals ||
                    (this.Globals != null &&
                    this.Globals.Equals(input.Globals))
                ) && 
                (
                    this.MediaServers == input.MediaServers ||
                    (this.MediaServers != null &&
                    this.MediaServers.Equals(input.MediaServers))
                ) && 
                (
                    this.NodeInfo == input.NodeInfo ||
                    (this.NodeInfo != null &&
                    this.NodeInfo.Equals(input.NodeInfo))
                ) && 
                (
                    this.Ports == input.Ports ||
                    (this.Ports != null &&
                    this.Ports.Equals(input.Ports))
                ) && 
                (
                    this.Processes == input.Processes ||
                    (this.Processes != null &&
                    this.Processes.Equals(input.Processes))
                ) && 
                (
                    this.Registrations == input.Registrations ||
                    (this.Registrations != null &&
                    this.Registrations.Equals(input.Registrations))
                ) && 
                (
                    this.UsedMemory == input.UsedMemory ||
                    (this.UsedMemory != null &&
                    this.UsedMemory.Equals(input.UsedMemory))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.WhApps == input.WhApps ||
                    (this.WhApps != null &&
                    this.WhApps.Equals(input.WhApps))
                ) && 
                (
                    this.Zone == input.Zone ||
                    (this.Zone != null &&
                    this.Zone.Equals(input.Zone))
                ) && 
                (
                    this.Md5 == input.Md5 ||
                    (this.Md5 != null &&
                    this.Md5.Equals(input.Md5))
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
                if (this.Channels != null)
                    hashCode = hashCode * 59 + this.Channels.GetHashCode();
                if (this.Conferences != null)
                    hashCode = hashCode * 59 + this.Conferences.GetHashCode();
                if (this.EventCategory != null)
                    hashCode = hashCode * 59 + this.EventCategory.GetHashCode();
                if (this.EventName != null)
                    hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.Expires != null)
                    hashCode = hashCode * 59 + this.Expires.GetHashCode();
                if (this.Globals != null)
                    hashCode = hashCode * 59 + this.Globals.GetHashCode();
                if (this.MediaServers != null)
                    hashCode = hashCode * 59 + this.MediaServers.GetHashCode();
                if (this.NodeInfo != null)
                    hashCode = hashCode * 59 + this.NodeInfo.GetHashCode();
                if (this.Ports != null)
                    hashCode = hashCode * 59 + this.Ports.GetHashCode();
                if (this.Processes != null)
                    hashCode = hashCode * 59 + this.Processes.GetHashCode();
                if (this.Registrations != null)
                    hashCode = hashCode * 59 + this.Registrations.GetHashCode();
                if (this.UsedMemory != null)
                    hashCode = hashCode * 59 + this.UsedMemory.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.WhApps != null)
                    hashCode = hashCode * 59 + this.WhApps.GetHashCode();
                if (this.Zone != null)
                    hashCode = hashCode * 59 + this.Zone.GetHashCode();
                if (this.Md5 != null)
                    hashCode = hashCode * 59 + this.Md5.GetHashCode();
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
