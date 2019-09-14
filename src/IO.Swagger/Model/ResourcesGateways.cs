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
    /// ResourcesGateways
    /// </summary>
    [DataContract]
    public partial class ResourcesGateways :  IEquatable<ResourcesGateways>, IValidatableObject
    {
        /// <summary>
        /// The type of caller id to use
        /// </summary>
        /// <value>The type of caller id to use</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CallerIdTypeEnum
        {
            
            /// <summary>
            /// Enum Internal for value: internal
            /// </summary>
            [EnumMember(Value = "internal")]
            Internal = 1,
            
            /// <summary>
            /// Enum External for value: external
            /// </summary>
            [EnumMember(Value = "external")]
            External = 2,
            
            /// <summary>
            /// Enum Emergency for value: emergency
            /// </summary>
            [EnumMember(Value = "emergency")]
            Emergency = 3
        }

        /// <summary>
        /// The type of caller id to use
        /// </summary>
        /// <value>The type of caller id to use</value>
        [DataMember(Name="caller_id_type", EmitDefaultValue=false)]
        public CallerIdTypeEnum? CallerIdType { get; set; }
        /// <summary>
        /// Automatic selection of the channel within the span: ascending starts at 1 and moves up; descending is the opposite
        /// </summary>
        /// <value>Automatic selection of the channel within the span: ascending starts at 1 and moves up; descending is the opposite</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChannelSelectionEnum
        {
            
            /// <summary>
            /// Enum Ascending for value: ascending
            /// </summary>
            [EnumMember(Value = "ascending")]
            Ascending = 1,
            
            /// <summary>
            /// Enum Descending for value: descending
            /// </summary>
            [EnumMember(Value = "descending")]
            Descending = 2
        }

        /// <summary>
        /// Automatic selection of the channel within the span: ascending starts at 1 and moves up; descending is the opposite
        /// </summary>
        /// <value>Automatic selection of the channel within the span: ascending starts at 1 and moves up; descending is the opposite</value>
        [DataMember(Name="channel_selection", EmitDefaultValue=false)]
        public ChannelSelectionEnum? ChannelSelection { get; set; }
        /// <summary>
        /// Defines Codecs
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodecsEnum
        {
            
            /// <summary>
            /// Enum G729 for value: G729
            /// </summary>
            [EnumMember(Value = "G729")]
            G729 = 1,
            
            /// <summary>
            /// Enum PCMU for value: PCMU
            /// </summary>
            [EnumMember(Value = "PCMU")]
            PCMU = 2,
            
            /// <summary>
            /// Enum PCMA for value: PCMA
            /// </summary>
            [EnumMember(Value = "PCMA")]
            PCMA = 3,
            
            /// <summary>
            /// Enum G72216 for value: G722_16
            /// </summary>
            [EnumMember(Value = "G722_16")]
            G72216 = 4,
            
            /// <summary>
            /// Enum G72232 for value: G722_32
            /// </summary>
            [EnumMember(Value = "G722_32")]
            G72232 = 5,
            
            /// <summary>
            /// Enum CELT48 for value: CELT_48
            /// </summary>
            [EnumMember(Value = "CELT_48")]
            CELT48 = 6,
            
            /// <summary>
            /// Enum CELT64 for value: CELT_64
            /// </summary>
            [EnumMember(Value = "CELT_64")]
            CELT64 = 7,
            
            /// <summary>
            /// Enum Speex for value: Speex
            /// </summary>
            [EnumMember(Value = "Speex")]
            Speex = 8,
            
            /// <summary>
            /// Enum GSM for value: GSM
            /// </summary>
            [EnumMember(Value = "GSM")]
            GSM = 9,
            
            /// <summary>
            /// Enum OPUS for value: OPUS
            /// </summary>
            [EnumMember(Value = "OPUS")]
            OPUS = 10,
            
            /// <summary>
            /// Enum H261 for value: H261
            /// </summary>
            [EnumMember(Value = "H261")]
            H261 = 11,
            
            /// <summary>
            /// Enum H263 for value: H263
            /// </summary>
            [EnumMember(Value = "H263")]
            H263 = 12,
            
            /// <summary>
            /// Enum H264 for value: H264
            /// </summary>
            [EnumMember(Value = "H264")]
            H264 = 13,
            
            /// <summary>
            /// Enum VP8 for value: VP8
            /// </summary>
            [EnumMember(Value = "VP8")]
            VP8 = 14
        }


        /// <summary>
        /// A list of single list codecs supported by this gateway (to support backward compatibility)
        /// </summary>
        /// <value>A list of single list codecs supported by this gateway (to support backward compatibility)</value>
        [DataMember(Name="codecs", EmitDefaultValue=false)]
        public List<CodecsEnum> Codecs { get; set; }
        /// <summary>
        /// What type of endpoint is this gateway
        /// </summary>
        /// <value>What type of endpoint is this gateway</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EndpointTypeEnum
        {
            
            /// <summary>
            /// Enum Sip for value: sip
            /// </summary>
            [EnumMember(Value = "sip")]
            Sip = 1,
            
            /// <summary>
            /// Enum Freetdm for value: freetdm
            /// </summary>
            [EnumMember(Value = "freetdm")]
            Freetdm = 2,
            
            /// <summary>
            /// Enum Skype for value: skype
            /// </summary>
            [EnumMember(Value = "skype")]
            Skype = 3,
            
            /// <summary>
            /// Enum Amqp for value: amqp
            /// </summary>
            [EnumMember(Value = "amqp")]
            Amqp = 4
        }

        /// <summary>
        /// What type of endpoint is this gateway
        /// </summary>
        /// <value>What type of endpoint is this gateway</value>
        [DataMember(Name="endpoint_type", EmitDefaultValue=false)]
        public EndpointTypeEnum? EndpointType { get; set; }
        /// <summary>
        /// The format of the DID needed by the underlying hardware/gateway
        /// </summary>
        /// <value>The format of the DID needed by the underlying hardware/gateway</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum InviteFormatEnum
        {
            
            /// <summary>
            /// Enum Route for value: route
            /// </summary>
            [EnumMember(Value = "route")]
            Route = 1,
            
            /// <summary>
            /// Enum Username for value: username
            /// </summary>
            [EnumMember(Value = "username")]
            Username = 2,
            
            /// <summary>
            /// Enum E164 for value: e164
            /// </summary>
            [EnumMember(Value = "e164")]
            E164 = 3,
            
            /// <summary>
            /// Enum Npan for value: npan
            /// </summary>
            [EnumMember(Value = "npan")]
            Npan = 4,
            
            /// <summary>
            /// Enum _1npan for value: 1npan
            /// </summary>
            [EnumMember(Value = "1npan")]
            _1npan = 5
        }

        /// <summary>
        /// The format of the DID needed by the underlying hardware/gateway
        /// </summary>
        /// <value>The format of the DID needed by the underlying hardware/gateway</value>
        [DataMember(Name="invite_format", EmitDefaultValue=false)]
        public InviteFormatEnum? InviteFormat { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourcesGateways" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ResourcesGateways() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourcesGateways" /> class.
        /// </summary>
        /// <param name="bypassMedia">The resource gateway bypass media mode.</param>
        /// <param name="callerIdType">The type of caller id to use.</param>
        /// <param name="channelSelection">Automatic selection of the channel within the span: ascending starts at 1 and moves up; descending is the opposite (default to ChannelSelectionEnum.Ascending).</param>
        /// <param name="codecs">A list of single list codecs supported by this gateway (to support backward compatibility).</param>
        /// <param name="customSipHeaders">A property list of SIP headers.</param>
        /// <param name="customSipInterface">The name of a custom SIP interface.</param>
        /// <param name="enabled">Determines if the resource gateway is currently enabled (default to true).</param>
        /// <param name="endpointType">What type of endpoint is this gateway (default to EndpointTypeEnum.Sip).</param>
        /// <param name="forcePort">Allow request only from this port (default to false).</param>
        /// <param name="formatFromUri">When set to true requests to this resource gateway will have a reformatted SIP From Header.</param>
        /// <param name="fromUriRealm">When formatting SIP From on outbound requests this can be used to override the realm.</param>
        /// <param name="inviteFormat">The format of the DID needed by the underlying hardware/gateway (default to InviteFormatEnum.Route).</param>
        /// <param name="inviteParameters">inviteParameters.</param>
        /// <param name="media">media.</param>
        /// <param name="password">SIP authentication password.</param>
        /// <param name="port">This resource gateway port.</param>
        /// <param name="prefix">A string to prepend to the dialed number or capture group of the matching rule.</param>
        /// <param name="progressTimeout">The progress timeout to apply to the resource gateway.</param>
        /// <param name="realm">This resource gateway authentication realm.</param>
        /// <param name="route">A statically configured SIP URI to route all call to.</param>
        /// <param name="server">This resource gateway server (required).</param>
        /// <param name="skypeInterface">The name of the Skype interface to route the call over.</param>
        /// <param name="skypeRr">Determines whether to round-robin calls amongst all interfaces (overrides \&quot;skype_interface\&quot; setting) (default to true).</param>
        /// <param name="span">The identity of the hardware on the media server.</param>
        /// <param name="suffix">A string to append to the dialed number or capture group of the matching rule.</param>
        /// <param name="username">SIP authentication username.</param>
        public ResourcesGateways(bool? bypassMedia = default(bool?), CallerIdTypeEnum? callerIdType = default(CallerIdTypeEnum?), ChannelSelectionEnum? channelSelection = ChannelSelectionEnum.Ascending, List<CodecsEnum> codecs = default(List<CodecsEnum>), Object customSipHeaders = default(Object), string customSipInterface = default(string), bool? enabled = true, EndpointTypeEnum? endpointType = EndpointTypeEnum.Sip, bool? forcePort = false, bool? formatFromUri = default(bool?), string fromUriRealm = default(string), InviteFormatEnum? inviteFormat = InviteFormatEnum.Route, ResourcesInviteParameters inviteParameters = default(ResourcesInviteParameters), ResourcesMedia media = default(ResourcesMedia), string password = default(string), int? port = default(int?), string prefix = default(string), int? progressTimeout = default(int?), string realm = default(string), string route = default(string), string server = default(string), string skypeInterface = default(string), bool? skypeRr = true, string span = default(string), string suffix = default(string), string username = default(string))
        {
            // to ensure "server" is required (not null)
            if (server == null)
            {
                throw new InvalidDataException("server is a required property for ResourcesGateways and cannot be null");
            }
            else
            {
                this.Server = server;
            }
            this.BypassMedia = bypassMedia;
            this.CallerIdType = callerIdType;
            // use default value if no "channelSelection" provided
            if (channelSelection == null)
            {
                this.ChannelSelection = ChannelSelectionEnum.Ascending;
            }
            else
            {
                this.ChannelSelection = channelSelection;
            }
            this.Codecs = codecs;
            this.CustomSipHeaders = customSipHeaders;
            this.CustomSipInterface = customSipInterface;
            // use default value if no "enabled" provided
            if (enabled == null)
            {
                this.Enabled = true;
            }
            else
            {
                this.Enabled = enabled;
            }
            // use default value if no "endpointType" provided
            if (endpointType == null)
            {
                this.EndpointType = EndpointTypeEnum.Sip;
            }
            else
            {
                this.EndpointType = endpointType;
            }
            // use default value if no "forcePort" provided
            if (forcePort == null)
            {
                this.ForcePort = false;
            }
            else
            {
                this.ForcePort = forcePort;
            }
            this.FormatFromUri = formatFromUri;
            this.FromUriRealm = fromUriRealm;
            // use default value if no "inviteFormat" provided
            if (inviteFormat == null)
            {
                this.InviteFormat = InviteFormatEnum.Route;
            }
            else
            {
                this.InviteFormat = inviteFormat;
            }
            this.InviteParameters = inviteParameters;
            this.Media = media;
            this.Password = password;
            this.Port = port;
            this.Prefix = prefix;
            this.ProgressTimeout = progressTimeout;
            this.Realm = realm;
            this.Route = route;
            this.SkypeInterface = skypeInterface;
            // use default value if no "skypeRr" provided
            if (skypeRr == null)
            {
                this.SkypeRr = true;
            }
            else
            {
                this.SkypeRr = skypeRr;
            }
            this.Span = span;
            this.Suffix = suffix;
            this.Username = username;
        }
        
        /// <summary>
        /// The resource gateway bypass media mode
        /// </summary>
        /// <value>The resource gateway bypass media mode</value>
        [DataMember(Name="bypass_media", EmitDefaultValue=false)]
        public bool? BypassMedia { get; set; }




        /// <summary>
        /// A property list of SIP headers
        /// </summary>
        /// <value>A property list of SIP headers</value>
        [DataMember(Name="custom_sip_headers", EmitDefaultValue=false)]
        public Object CustomSipHeaders { get; set; }

        /// <summary>
        /// The name of a custom SIP interface
        /// </summary>
        /// <value>The name of a custom SIP interface</value>
        [DataMember(Name="custom_sip_interface", EmitDefaultValue=false)]
        public string CustomSipInterface { get; set; }

        /// <summary>
        /// Determines if the resource gateway is currently enabled
        /// </summary>
        /// <value>Determines if the resource gateway is currently enabled</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }


        /// <summary>
        /// Allow request only from this port
        /// </summary>
        /// <value>Allow request only from this port</value>
        [DataMember(Name="force_port", EmitDefaultValue=false)]
        public bool? ForcePort { get; set; }

        /// <summary>
        /// When set to true requests to this resource gateway will have a reformatted SIP From Header
        /// </summary>
        /// <value>When set to true requests to this resource gateway will have a reformatted SIP From Header</value>
        [DataMember(Name="format_from_uri", EmitDefaultValue=false)]
        public bool? FormatFromUri { get; set; }

        /// <summary>
        /// When formatting SIP From on outbound requests this can be used to override the realm
        /// </summary>
        /// <value>When formatting SIP From on outbound requests this can be used to override the realm</value>
        [DataMember(Name="from_uri_realm", EmitDefaultValue=false)]
        public string FromUriRealm { get; set; }


        /// <summary>
        /// Gets or Sets InviteParameters
        /// </summary>
        [DataMember(Name="invite_parameters", EmitDefaultValue=false)]
        public ResourcesInviteParameters InviteParameters { get; set; }

        /// <summary>
        /// Gets or Sets Media
        /// </summary>
        [DataMember(Name="media", EmitDefaultValue=false)]
        public ResourcesMedia Media { get; set; }

        /// <summary>
        /// SIP authentication password
        /// </summary>
        /// <value>SIP authentication password</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// This resource gateway port
        /// </summary>
        /// <value>This resource gateway port</value>
        [DataMember(Name="port", EmitDefaultValue=false)]
        public int? Port { get; set; }

        /// <summary>
        /// A string to prepend to the dialed number or capture group of the matching rule
        /// </summary>
        /// <value>A string to prepend to the dialed number or capture group of the matching rule</value>
        [DataMember(Name="prefix", EmitDefaultValue=false)]
        public string Prefix { get; set; }

        /// <summary>
        /// The progress timeout to apply to the resource gateway
        /// </summary>
        /// <value>The progress timeout to apply to the resource gateway</value>
        [DataMember(Name="progress_timeout", EmitDefaultValue=false)]
        public int? ProgressTimeout { get; set; }

        /// <summary>
        /// This resource gateway authentication realm
        /// </summary>
        /// <value>This resource gateway authentication realm</value>
        [DataMember(Name="realm", EmitDefaultValue=false)]
        public string Realm { get; set; }

        /// <summary>
        /// A statically configured SIP URI to route all call to
        /// </summary>
        /// <value>A statically configured SIP URI to route all call to</value>
        [DataMember(Name="route", EmitDefaultValue=false)]
        public string Route { get; set; }

        /// <summary>
        /// This resource gateway server
        /// </summary>
        /// <value>This resource gateway server</value>
        [DataMember(Name="server", EmitDefaultValue=false)]
        public string Server { get; set; }

        /// <summary>
        /// The name of the Skype interface to route the call over
        /// </summary>
        /// <value>The name of the Skype interface to route the call over</value>
        [DataMember(Name="skype_interface", EmitDefaultValue=false)]
        public string SkypeInterface { get; set; }

        /// <summary>
        /// Determines whether to round-robin calls amongst all interfaces (overrides \&quot;skype_interface\&quot; setting)
        /// </summary>
        /// <value>Determines whether to round-robin calls amongst all interfaces (overrides \&quot;skype_interface\&quot; setting)</value>
        [DataMember(Name="skype_rr", EmitDefaultValue=false)]
        public bool? SkypeRr { get; set; }

        /// <summary>
        /// The identity of the hardware on the media server
        /// </summary>
        /// <value>The identity of the hardware on the media server</value>
        [DataMember(Name="span", EmitDefaultValue=false)]
        public string Span { get; set; }

        /// <summary>
        /// A string to append to the dialed number or capture group of the matching rule
        /// </summary>
        /// <value>A string to append to the dialed number or capture group of the matching rule</value>
        [DataMember(Name="suffix", EmitDefaultValue=false)]
        public string Suffix { get; set; }

        /// <summary>
        /// SIP authentication username
        /// </summary>
        /// <value>SIP authentication username</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourcesGateways {\n");
            sb.Append("  BypassMedia: ").Append(BypassMedia).Append("\n");
            sb.Append("  CallerIdType: ").Append(CallerIdType).Append("\n");
            sb.Append("  ChannelSelection: ").Append(ChannelSelection).Append("\n");
            sb.Append("  Codecs: ").Append(Codecs).Append("\n");
            sb.Append("  CustomSipHeaders: ").Append(CustomSipHeaders).Append("\n");
            sb.Append("  CustomSipInterface: ").Append(CustomSipInterface).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  EndpointType: ").Append(EndpointType).Append("\n");
            sb.Append("  ForcePort: ").Append(ForcePort).Append("\n");
            sb.Append("  FormatFromUri: ").Append(FormatFromUri).Append("\n");
            sb.Append("  FromUriRealm: ").Append(FromUriRealm).Append("\n");
            sb.Append("  InviteFormat: ").Append(InviteFormat).Append("\n");
            sb.Append("  InviteParameters: ").Append(InviteParameters).Append("\n");
            sb.Append("  Media: ").Append(Media).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
            sb.Append("  Prefix: ").Append(Prefix).Append("\n");
            sb.Append("  ProgressTimeout: ").Append(ProgressTimeout).Append("\n");
            sb.Append("  Realm: ").Append(Realm).Append("\n");
            sb.Append("  Route: ").Append(Route).Append("\n");
            sb.Append("  Server: ").Append(Server).Append("\n");
            sb.Append("  SkypeInterface: ").Append(SkypeInterface).Append("\n");
            sb.Append("  SkypeRr: ").Append(SkypeRr).Append("\n");
            sb.Append("  Span: ").Append(Span).Append("\n");
            sb.Append("  Suffix: ").Append(Suffix).Append("\n");
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
            return this.Equals(input as ResourcesGateways);
        }

        /// <summary>
        /// Returns true if ResourcesGateways instances are equal
        /// </summary>
        /// <param name="input">Instance of ResourcesGateways to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResourcesGateways input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BypassMedia == input.BypassMedia ||
                    (this.BypassMedia != null &&
                    this.BypassMedia.Equals(input.BypassMedia))
                ) && 
                (
                    this.CallerIdType == input.CallerIdType ||
                    (this.CallerIdType != null &&
                    this.CallerIdType.Equals(input.CallerIdType))
                ) && 
                (
                    this.ChannelSelection == input.ChannelSelection ||
                    (this.ChannelSelection != null &&
                    this.ChannelSelection.Equals(input.ChannelSelection))
                ) && 
                (
                    this.Codecs == input.Codecs ||
                    this.Codecs != null &&
                    this.Codecs.SequenceEqual(input.Codecs)
                ) && 
                (
                    this.CustomSipHeaders == input.CustomSipHeaders ||
                    (this.CustomSipHeaders != null &&
                    this.CustomSipHeaders.Equals(input.CustomSipHeaders))
                ) && 
                (
                    this.CustomSipInterface == input.CustomSipInterface ||
                    (this.CustomSipInterface != null &&
                    this.CustomSipInterface.Equals(input.CustomSipInterface))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.EndpointType == input.EndpointType ||
                    (this.EndpointType != null &&
                    this.EndpointType.Equals(input.EndpointType))
                ) && 
                (
                    this.ForcePort == input.ForcePort ||
                    (this.ForcePort != null &&
                    this.ForcePort.Equals(input.ForcePort))
                ) && 
                (
                    this.FormatFromUri == input.FormatFromUri ||
                    (this.FormatFromUri != null &&
                    this.FormatFromUri.Equals(input.FormatFromUri))
                ) && 
                (
                    this.FromUriRealm == input.FromUriRealm ||
                    (this.FromUriRealm != null &&
                    this.FromUriRealm.Equals(input.FromUriRealm))
                ) && 
                (
                    this.InviteFormat == input.InviteFormat ||
                    (this.InviteFormat != null &&
                    this.InviteFormat.Equals(input.InviteFormat))
                ) && 
                (
                    this.InviteParameters == input.InviteParameters ||
                    (this.InviteParameters != null &&
                    this.InviteParameters.Equals(input.InviteParameters))
                ) && 
                (
                    this.Media == input.Media ||
                    (this.Media != null &&
                    this.Media.Equals(input.Media))
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
                    this.Prefix == input.Prefix ||
                    (this.Prefix != null &&
                    this.Prefix.Equals(input.Prefix))
                ) && 
                (
                    this.ProgressTimeout == input.ProgressTimeout ||
                    (this.ProgressTimeout != null &&
                    this.ProgressTimeout.Equals(input.ProgressTimeout))
                ) && 
                (
                    this.Realm == input.Realm ||
                    (this.Realm != null &&
                    this.Realm.Equals(input.Realm))
                ) && 
                (
                    this.Route == input.Route ||
                    (this.Route != null &&
                    this.Route.Equals(input.Route))
                ) && 
                (
                    this.Server == input.Server ||
                    (this.Server != null &&
                    this.Server.Equals(input.Server))
                ) && 
                (
                    this.SkypeInterface == input.SkypeInterface ||
                    (this.SkypeInterface != null &&
                    this.SkypeInterface.Equals(input.SkypeInterface))
                ) && 
                (
                    this.SkypeRr == input.SkypeRr ||
                    (this.SkypeRr != null &&
                    this.SkypeRr.Equals(input.SkypeRr))
                ) && 
                (
                    this.Span == input.Span ||
                    (this.Span != null &&
                    this.Span.Equals(input.Span))
                ) && 
                (
                    this.Suffix == input.Suffix ||
                    (this.Suffix != null &&
                    this.Suffix.Equals(input.Suffix))
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
                if (this.BypassMedia != null)
                    hashCode = hashCode * 59 + this.BypassMedia.GetHashCode();
                if (this.CallerIdType != null)
                    hashCode = hashCode * 59 + this.CallerIdType.GetHashCode();
                if (this.ChannelSelection != null)
                    hashCode = hashCode * 59 + this.ChannelSelection.GetHashCode();
                if (this.Codecs != null)
                    hashCode = hashCode * 59 + this.Codecs.GetHashCode();
                if (this.CustomSipHeaders != null)
                    hashCode = hashCode * 59 + this.CustomSipHeaders.GetHashCode();
                if (this.CustomSipInterface != null)
                    hashCode = hashCode * 59 + this.CustomSipInterface.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.EndpointType != null)
                    hashCode = hashCode * 59 + this.EndpointType.GetHashCode();
                if (this.ForcePort != null)
                    hashCode = hashCode * 59 + this.ForcePort.GetHashCode();
                if (this.FormatFromUri != null)
                    hashCode = hashCode * 59 + this.FormatFromUri.GetHashCode();
                if (this.FromUriRealm != null)
                    hashCode = hashCode * 59 + this.FromUriRealm.GetHashCode();
                if (this.InviteFormat != null)
                    hashCode = hashCode * 59 + this.InviteFormat.GetHashCode();
                if (this.InviteParameters != null)
                    hashCode = hashCode * 59 + this.InviteParameters.GetHashCode();
                if (this.Media != null)
                    hashCode = hashCode * 59 + this.Media.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Port != null)
                    hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.Prefix != null)
                    hashCode = hashCode * 59 + this.Prefix.GetHashCode();
                if (this.ProgressTimeout != null)
                    hashCode = hashCode * 59 + this.ProgressTimeout.GetHashCode();
                if (this.Realm != null)
                    hashCode = hashCode * 59 + this.Realm.GetHashCode();
                if (this.Route != null)
                    hashCode = hashCode * 59 + this.Route.GetHashCode();
                if (this.Server != null)
                    hashCode = hashCode * 59 + this.Server.GetHashCode();
                if (this.SkypeInterface != null)
                    hashCode = hashCode * 59 + this.SkypeInterface.GetHashCode();
                if (this.SkypeRr != null)
                    hashCode = hashCode * 59 + this.SkypeRr.GetHashCode();
                if (this.Span != null)
                    hashCode = hashCode * 59 + this.Span.GetHashCode();
                if (this.Suffix != null)
                    hashCode = hashCode * 59 + this.Suffix.GetHashCode();
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
            // Password (string) maxLength
            if(this.Password != null && this.Password.Length > 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Password, length must be less than 32.", new [] { "Password" });
            }

            // Prefix (string) maxLength
            if(this.Prefix != null && this.Prefix.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Prefix, length must be less than 64.", new [] { "Prefix" });
            }

            // Realm (string) maxLength
            if(this.Realm != null && this.Realm.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Realm, length must be less than 64.", new [] { "Realm" });
            }

            // Server (string) maxLength
            if(this.Server != null && this.Server.Length > 128)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Server, length must be less than 128.", new [] { "Server" });
            }

            // Server (string) minLength
            if(this.Server != null && this.Server.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Server, length must be greater than 1.", new [] { "Server" });
            }

            // Suffix (string) maxLength
            if(this.Suffix != null && this.Suffix.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Suffix, length must be less than 64.", new [] { "Suffix" });
            }

            // Username (string) maxLength
            if(this.Username != null && this.Username.Length > 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Username, length must be less than 32.", new [] { "Username" });
            }

            yield break;
        }
    }

}
