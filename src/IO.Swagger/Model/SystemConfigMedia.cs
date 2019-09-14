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
    /// Schema for media system_config
    /// </summary>
    [DataContract]
    public partial class SystemConfigMedia :  IEquatable<SystemConfigMedia>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemConfigMedia" /> class.
        /// </summary>
        /// <param name="authenticatedPlayback">media authenticated playback (default to false).</param>
        /// <param name="authenticatedStore">media authenticated store (default to true).</param>
        /// <param name="callRecording">callRecording.</param>
        /// <param name="defaultLanguage">media default language.</param>
        /// <param name="distributedProxy">media distributed_proxy.</param>
        /// <param name="fixMediaNames">media fix media names (default to true).</param>
        /// <param name="maxRecordingTimeLimit">media maximum recording time limit.</param>
        /// <param name="normalizeDestinationArgs">media normalize destination args (default to &quot;-r 8000&quot;).</param>
        /// <param name="normalizeExecutable">media normalize executable (default to &quot;sox&quot;).</param>
        /// <param name="normalizeSourceArgs">media normalize source args (default to &quot;&quot;).</param>
        /// <param name="proxyHostname">media proxy hostname to be used with HAProxy.</param>
        /// <param name="proxyIp">media proxy ip.</param>
        /// <param name="proxyListeners">media proxy listeners.</param>
        /// <param name="proxyPassword">media proxy password (default to &quot;&quot;).</param>
        /// <param name="proxyPort">media proxy port.</param>
        /// <param name="proxyStoreAcls">media proxy store acls.</param>
        /// <param name="proxyStoreAuthenticate">media proxy store authenticate (default to true).</param>
        /// <param name="proxyUsername">media proxy username (default to &quot;&quot;).</param>
        /// <param name="recordMinSec">media record minimum sec.</param>
        /// <param name="sslCert">media ssl cert.</param>
        /// <param name="sslKey">media ssl key.</param>
        /// <param name="sslPassword">media ssl password (default to &quot;&quot;).</param>
        /// <param name="sslPort">media ssl port.</param>
        /// <param name="storeRecordings">media store recordings (default to false).</param>
        /// <param name="supportAccountOverrides">media support account overrides (default to true).</param>
        /// <param name="useHttps">media use https (default to false).</param>
        /// <param name="usePlaintext">media use plaintext (default to true).</param>
        /// <param name="useSslProxy">media use ssl proxy (default to false).</param>
        public SystemConfigMedia(bool? authenticatedPlayback = false, bool? authenticatedStore = true, AccountConfigMediaCallRecording callRecording = default(AccountConfigMediaCallRecording), string defaultLanguage = default(string), Object distributedProxy = default(Object), bool? fixMediaNames = true, int? maxRecordingTimeLimit = default(int?), string normalizeDestinationArgs = "-r 8000", string normalizeExecutable = "sox", string normalizeSourceArgs = "", string proxyHostname = default(string), string proxyIp = default(string), int? proxyListeners = default(int?), string proxyPassword = "", int? proxyPort = default(int?), List<string> proxyStoreAcls = default(List<string>), bool? proxyStoreAuthenticate = true, string proxyUsername = "", int? recordMinSec = default(int?), string sslCert = default(string), string sslKey = default(string), string sslPassword = "", int? sslPort = default(int?), bool? storeRecordings = false, bool? supportAccountOverrides = true, bool? useHttps = false, bool? usePlaintext = true, bool? useSslProxy = false)
        {
            // use default value if no "authenticatedPlayback" provided
            if (authenticatedPlayback == null)
            {
                this.AuthenticatedPlayback = false;
            }
            else
            {
                this.AuthenticatedPlayback = authenticatedPlayback;
            }
            // use default value if no "authenticatedStore" provided
            if (authenticatedStore == null)
            {
                this.AuthenticatedStore = true;
            }
            else
            {
                this.AuthenticatedStore = authenticatedStore;
            }
            this.CallRecording = callRecording;
            this.DefaultLanguage = defaultLanguage;
            this.DistributedProxy = distributedProxy;
            // use default value if no "fixMediaNames" provided
            if (fixMediaNames == null)
            {
                this.FixMediaNames = true;
            }
            else
            {
                this.FixMediaNames = fixMediaNames;
            }
            this.MaxRecordingTimeLimit = maxRecordingTimeLimit;
            // use default value if no "normalizeDestinationArgs" provided
            if (normalizeDestinationArgs == null)
            {
                this.NormalizeDestinationArgs = "-r 8000";
            }
            else
            {
                this.NormalizeDestinationArgs = normalizeDestinationArgs;
            }
            // use default value if no "normalizeExecutable" provided
            if (normalizeExecutable == null)
            {
                this.NormalizeExecutable = "sox";
            }
            else
            {
                this.NormalizeExecutable = normalizeExecutable;
            }
            // use default value if no "normalizeSourceArgs" provided
            if (normalizeSourceArgs == null)
            {
                this.NormalizeSourceArgs = "";
            }
            else
            {
                this.NormalizeSourceArgs = normalizeSourceArgs;
            }
            this.ProxyHostname = proxyHostname;
            this.ProxyIp = proxyIp;
            this.ProxyListeners = proxyListeners;
            // use default value if no "proxyPassword" provided
            if (proxyPassword == null)
            {
                this.ProxyPassword = "";
            }
            else
            {
                this.ProxyPassword = proxyPassword;
            }
            this.ProxyPort = proxyPort;
            this.ProxyStoreAcls = proxyStoreAcls;
            // use default value if no "proxyStoreAuthenticate" provided
            if (proxyStoreAuthenticate == null)
            {
                this.ProxyStoreAuthenticate = true;
            }
            else
            {
                this.ProxyStoreAuthenticate = proxyStoreAuthenticate;
            }
            // use default value if no "proxyUsername" provided
            if (proxyUsername == null)
            {
                this.ProxyUsername = "";
            }
            else
            {
                this.ProxyUsername = proxyUsername;
            }
            this.RecordMinSec = recordMinSec;
            this.SslCert = sslCert;
            this.SslKey = sslKey;
            // use default value if no "sslPassword" provided
            if (sslPassword == null)
            {
                this.SslPassword = "";
            }
            else
            {
                this.SslPassword = sslPassword;
            }
            this.SslPort = sslPort;
            // use default value if no "storeRecordings" provided
            if (storeRecordings == null)
            {
                this.StoreRecordings = false;
            }
            else
            {
                this.StoreRecordings = storeRecordings;
            }
            // use default value if no "supportAccountOverrides" provided
            if (supportAccountOverrides == null)
            {
                this.SupportAccountOverrides = true;
            }
            else
            {
                this.SupportAccountOverrides = supportAccountOverrides;
            }
            // use default value if no "useHttps" provided
            if (useHttps == null)
            {
                this.UseHttps = false;
            }
            else
            {
                this.UseHttps = useHttps;
            }
            // use default value if no "usePlaintext" provided
            if (usePlaintext == null)
            {
                this.UsePlaintext = true;
            }
            else
            {
                this.UsePlaintext = usePlaintext;
            }
            // use default value if no "useSslProxy" provided
            if (useSslProxy == null)
            {
                this.UseSslProxy = false;
            }
            else
            {
                this.UseSslProxy = useSslProxy;
            }
        }
        
        /// <summary>
        /// media authenticated playback
        /// </summary>
        /// <value>media authenticated playback</value>
        [DataMember(Name="authenticated_playback", EmitDefaultValue=false)]
        public bool? AuthenticatedPlayback { get; set; }

        /// <summary>
        /// media authenticated store
        /// </summary>
        /// <value>media authenticated store</value>
        [DataMember(Name="authenticated_store", EmitDefaultValue=false)]
        public bool? AuthenticatedStore { get; set; }

        /// <summary>
        /// Gets or Sets CallRecording
        /// </summary>
        [DataMember(Name="call_recording", EmitDefaultValue=false)]
        public AccountConfigMediaCallRecording CallRecording { get; set; }

        /// <summary>
        /// media default language
        /// </summary>
        /// <value>media default language</value>
        [DataMember(Name="default_language", EmitDefaultValue=false)]
        public string DefaultLanguage { get; set; }

        /// <summary>
        /// media distributed_proxy
        /// </summary>
        /// <value>media distributed_proxy</value>
        [DataMember(Name="distributed_proxy", EmitDefaultValue=false)]
        public Object DistributedProxy { get; set; }

        /// <summary>
        /// media fix media names
        /// </summary>
        /// <value>media fix media names</value>
        [DataMember(Name="fix_media_names", EmitDefaultValue=false)]
        public bool? FixMediaNames { get; set; }

        /// <summary>
        /// media maximum recording time limit
        /// </summary>
        /// <value>media maximum recording time limit</value>
        [DataMember(Name="max_recording_time_limit", EmitDefaultValue=false)]
        public int? MaxRecordingTimeLimit { get; set; }

        /// <summary>
        /// media normalize destination args
        /// </summary>
        /// <value>media normalize destination args</value>
        [DataMember(Name="normalize_destination_args", EmitDefaultValue=false)]
        public string NormalizeDestinationArgs { get; set; }

        /// <summary>
        /// media normalize executable
        /// </summary>
        /// <value>media normalize executable</value>
        [DataMember(Name="normalize_executable", EmitDefaultValue=false)]
        public string NormalizeExecutable { get; set; }

        /// <summary>
        /// media normalize source args
        /// </summary>
        /// <value>media normalize source args</value>
        [DataMember(Name="normalize_source_args", EmitDefaultValue=false)]
        public string NormalizeSourceArgs { get; set; }

        /// <summary>
        /// media proxy hostname to be used with HAProxy
        /// </summary>
        /// <value>media proxy hostname to be used with HAProxy</value>
        [DataMember(Name="proxy_hostname", EmitDefaultValue=false)]
        public string ProxyHostname { get; set; }

        /// <summary>
        /// media proxy ip
        /// </summary>
        /// <value>media proxy ip</value>
        [DataMember(Name="proxy_ip", EmitDefaultValue=false)]
        public string ProxyIp { get; set; }

        /// <summary>
        /// media proxy listeners
        /// </summary>
        /// <value>media proxy listeners</value>
        [DataMember(Name="proxy_listeners", EmitDefaultValue=false)]
        public int? ProxyListeners { get; set; }

        /// <summary>
        /// media proxy password
        /// </summary>
        /// <value>media proxy password</value>
        [DataMember(Name="proxy_password", EmitDefaultValue=false)]
        public string ProxyPassword { get; set; }

        /// <summary>
        /// media proxy port
        /// </summary>
        /// <value>media proxy port</value>
        [DataMember(Name="proxy_port", EmitDefaultValue=false)]
        public int? ProxyPort { get; set; }

        /// <summary>
        /// media proxy store acls
        /// </summary>
        /// <value>media proxy store acls</value>
        [DataMember(Name="proxy_store_acls", EmitDefaultValue=false)]
        public List<string> ProxyStoreAcls { get; set; }

        /// <summary>
        /// media proxy store authenticate
        /// </summary>
        /// <value>media proxy store authenticate</value>
        [DataMember(Name="proxy_store_authenticate", EmitDefaultValue=false)]
        public bool? ProxyStoreAuthenticate { get; set; }

        /// <summary>
        /// media proxy username
        /// </summary>
        /// <value>media proxy username</value>
        [DataMember(Name="proxy_username", EmitDefaultValue=false)]
        public string ProxyUsername { get; set; }

        /// <summary>
        /// media record minimum sec
        /// </summary>
        /// <value>media record minimum sec</value>
        [DataMember(Name="record_min_sec", EmitDefaultValue=false)]
        public int? RecordMinSec { get; set; }

        /// <summary>
        /// media ssl cert
        /// </summary>
        /// <value>media ssl cert</value>
        [DataMember(Name="ssl_cert", EmitDefaultValue=false)]
        public string SslCert { get; set; }

        /// <summary>
        /// media ssl key
        /// </summary>
        /// <value>media ssl key</value>
        [DataMember(Name="ssl_key", EmitDefaultValue=false)]
        public string SslKey { get; set; }

        /// <summary>
        /// media ssl password
        /// </summary>
        /// <value>media ssl password</value>
        [DataMember(Name="ssl_password", EmitDefaultValue=false)]
        public string SslPassword { get; set; }

        /// <summary>
        /// media ssl port
        /// </summary>
        /// <value>media ssl port</value>
        [DataMember(Name="ssl_port", EmitDefaultValue=false)]
        public int? SslPort { get; set; }

        /// <summary>
        /// media store recordings
        /// </summary>
        /// <value>media store recordings</value>
        [DataMember(Name="store_recordings", EmitDefaultValue=false)]
        public bool? StoreRecordings { get; set; }

        /// <summary>
        /// media support account overrides
        /// </summary>
        /// <value>media support account overrides</value>
        [DataMember(Name="support_account_overrides", EmitDefaultValue=false)]
        public bool? SupportAccountOverrides { get; set; }

        /// <summary>
        /// media use https
        /// </summary>
        /// <value>media use https</value>
        [DataMember(Name="use_https", EmitDefaultValue=false)]
        public bool? UseHttps { get; set; }

        /// <summary>
        /// media use plaintext
        /// </summary>
        /// <value>media use plaintext</value>
        [DataMember(Name="use_plaintext", EmitDefaultValue=false)]
        public bool? UsePlaintext { get; set; }

        /// <summary>
        /// media use ssl proxy
        /// </summary>
        /// <value>media use ssl proxy</value>
        [DataMember(Name="use_ssl_proxy", EmitDefaultValue=false)]
        public bool? UseSslProxy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SystemConfigMedia {\n");
            sb.Append("  AuthenticatedPlayback: ").Append(AuthenticatedPlayback).Append("\n");
            sb.Append("  AuthenticatedStore: ").Append(AuthenticatedStore).Append("\n");
            sb.Append("  CallRecording: ").Append(CallRecording).Append("\n");
            sb.Append("  DefaultLanguage: ").Append(DefaultLanguage).Append("\n");
            sb.Append("  DistributedProxy: ").Append(DistributedProxy).Append("\n");
            sb.Append("  FixMediaNames: ").Append(FixMediaNames).Append("\n");
            sb.Append("  MaxRecordingTimeLimit: ").Append(MaxRecordingTimeLimit).Append("\n");
            sb.Append("  NormalizeDestinationArgs: ").Append(NormalizeDestinationArgs).Append("\n");
            sb.Append("  NormalizeExecutable: ").Append(NormalizeExecutable).Append("\n");
            sb.Append("  NormalizeSourceArgs: ").Append(NormalizeSourceArgs).Append("\n");
            sb.Append("  ProxyHostname: ").Append(ProxyHostname).Append("\n");
            sb.Append("  ProxyIp: ").Append(ProxyIp).Append("\n");
            sb.Append("  ProxyListeners: ").Append(ProxyListeners).Append("\n");
            sb.Append("  ProxyPassword: ").Append(ProxyPassword).Append("\n");
            sb.Append("  ProxyPort: ").Append(ProxyPort).Append("\n");
            sb.Append("  ProxyStoreAcls: ").Append(ProxyStoreAcls).Append("\n");
            sb.Append("  ProxyStoreAuthenticate: ").Append(ProxyStoreAuthenticate).Append("\n");
            sb.Append("  ProxyUsername: ").Append(ProxyUsername).Append("\n");
            sb.Append("  RecordMinSec: ").Append(RecordMinSec).Append("\n");
            sb.Append("  SslCert: ").Append(SslCert).Append("\n");
            sb.Append("  SslKey: ").Append(SslKey).Append("\n");
            sb.Append("  SslPassword: ").Append(SslPassword).Append("\n");
            sb.Append("  SslPort: ").Append(SslPort).Append("\n");
            sb.Append("  StoreRecordings: ").Append(StoreRecordings).Append("\n");
            sb.Append("  SupportAccountOverrides: ").Append(SupportAccountOverrides).Append("\n");
            sb.Append("  UseHttps: ").Append(UseHttps).Append("\n");
            sb.Append("  UsePlaintext: ").Append(UsePlaintext).Append("\n");
            sb.Append("  UseSslProxy: ").Append(UseSslProxy).Append("\n");
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
            return this.Equals(input as SystemConfigMedia);
        }

        /// <summary>
        /// Returns true if SystemConfigMedia instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemConfigMedia to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemConfigMedia input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AuthenticatedPlayback == input.AuthenticatedPlayback ||
                    (this.AuthenticatedPlayback != null &&
                    this.AuthenticatedPlayback.Equals(input.AuthenticatedPlayback))
                ) && 
                (
                    this.AuthenticatedStore == input.AuthenticatedStore ||
                    (this.AuthenticatedStore != null &&
                    this.AuthenticatedStore.Equals(input.AuthenticatedStore))
                ) && 
                (
                    this.CallRecording == input.CallRecording ||
                    (this.CallRecording != null &&
                    this.CallRecording.Equals(input.CallRecording))
                ) && 
                (
                    this.DefaultLanguage == input.DefaultLanguage ||
                    (this.DefaultLanguage != null &&
                    this.DefaultLanguage.Equals(input.DefaultLanguage))
                ) && 
                (
                    this.DistributedProxy == input.DistributedProxy ||
                    (this.DistributedProxy != null &&
                    this.DistributedProxy.Equals(input.DistributedProxy))
                ) && 
                (
                    this.FixMediaNames == input.FixMediaNames ||
                    (this.FixMediaNames != null &&
                    this.FixMediaNames.Equals(input.FixMediaNames))
                ) && 
                (
                    this.MaxRecordingTimeLimit == input.MaxRecordingTimeLimit ||
                    (this.MaxRecordingTimeLimit != null &&
                    this.MaxRecordingTimeLimit.Equals(input.MaxRecordingTimeLimit))
                ) && 
                (
                    this.NormalizeDestinationArgs == input.NormalizeDestinationArgs ||
                    (this.NormalizeDestinationArgs != null &&
                    this.NormalizeDestinationArgs.Equals(input.NormalizeDestinationArgs))
                ) && 
                (
                    this.NormalizeExecutable == input.NormalizeExecutable ||
                    (this.NormalizeExecutable != null &&
                    this.NormalizeExecutable.Equals(input.NormalizeExecutable))
                ) && 
                (
                    this.NormalizeSourceArgs == input.NormalizeSourceArgs ||
                    (this.NormalizeSourceArgs != null &&
                    this.NormalizeSourceArgs.Equals(input.NormalizeSourceArgs))
                ) && 
                (
                    this.ProxyHostname == input.ProxyHostname ||
                    (this.ProxyHostname != null &&
                    this.ProxyHostname.Equals(input.ProxyHostname))
                ) && 
                (
                    this.ProxyIp == input.ProxyIp ||
                    (this.ProxyIp != null &&
                    this.ProxyIp.Equals(input.ProxyIp))
                ) && 
                (
                    this.ProxyListeners == input.ProxyListeners ||
                    (this.ProxyListeners != null &&
                    this.ProxyListeners.Equals(input.ProxyListeners))
                ) && 
                (
                    this.ProxyPassword == input.ProxyPassword ||
                    (this.ProxyPassword != null &&
                    this.ProxyPassword.Equals(input.ProxyPassword))
                ) && 
                (
                    this.ProxyPort == input.ProxyPort ||
                    (this.ProxyPort != null &&
                    this.ProxyPort.Equals(input.ProxyPort))
                ) && 
                (
                    this.ProxyStoreAcls == input.ProxyStoreAcls ||
                    this.ProxyStoreAcls != null &&
                    this.ProxyStoreAcls.SequenceEqual(input.ProxyStoreAcls)
                ) && 
                (
                    this.ProxyStoreAuthenticate == input.ProxyStoreAuthenticate ||
                    (this.ProxyStoreAuthenticate != null &&
                    this.ProxyStoreAuthenticate.Equals(input.ProxyStoreAuthenticate))
                ) && 
                (
                    this.ProxyUsername == input.ProxyUsername ||
                    (this.ProxyUsername != null &&
                    this.ProxyUsername.Equals(input.ProxyUsername))
                ) && 
                (
                    this.RecordMinSec == input.RecordMinSec ||
                    (this.RecordMinSec != null &&
                    this.RecordMinSec.Equals(input.RecordMinSec))
                ) && 
                (
                    this.SslCert == input.SslCert ||
                    (this.SslCert != null &&
                    this.SslCert.Equals(input.SslCert))
                ) && 
                (
                    this.SslKey == input.SslKey ||
                    (this.SslKey != null &&
                    this.SslKey.Equals(input.SslKey))
                ) && 
                (
                    this.SslPassword == input.SslPassword ||
                    (this.SslPassword != null &&
                    this.SslPassword.Equals(input.SslPassword))
                ) && 
                (
                    this.SslPort == input.SslPort ||
                    (this.SslPort != null &&
                    this.SslPort.Equals(input.SslPort))
                ) && 
                (
                    this.StoreRecordings == input.StoreRecordings ||
                    (this.StoreRecordings != null &&
                    this.StoreRecordings.Equals(input.StoreRecordings))
                ) && 
                (
                    this.SupportAccountOverrides == input.SupportAccountOverrides ||
                    (this.SupportAccountOverrides != null &&
                    this.SupportAccountOverrides.Equals(input.SupportAccountOverrides))
                ) && 
                (
                    this.UseHttps == input.UseHttps ||
                    (this.UseHttps != null &&
                    this.UseHttps.Equals(input.UseHttps))
                ) && 
                (
                    this.UsePlaintext == input.UsePlaintext ||
                    (this.UsePlaintext != null &&
                    this.UsePlaintext.Equals(input.UsePlaintext))
                ) && 
                (
                    this.UseSslProxy == input.UseSslProxy ||
                    (this.UseSslProxy != null &&
                    this.UseSslProxy.Equals(input.UseSslProxy))
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
                if (this.AuthenticatedPlayback != null)
                    hashCode = hashCode * 59 + this.AuthenticatedPlayback.GetHashCode();
                if (this.AuthenticatedStore != null)
                    hashCode = hashCode * 59 + this.AuthenticatedStore.GetHashCode();
                if (this.CallRecording != null)
                    hashCode = hashCode * 59 + this.CallRecording.GetHashCode();
                if (this.DefaultLanguage != null)
                    hashCode = hashCode * 59 + this.DefaultLanguage.GetHashCode();
                if (this.DistributedProxy != null)
                    hashCode = hashCode * 59 + this.DistributedProxy.GetHashCode();
                if (this.FixMediaNames != null)
                    hashCode = hashCode * 59 + this.FixMediaNames.GetHashCode();
                if (this.MaxRecordingTimeLimit != null)
                    hashCode = hashCode * 59 + this.MaxRecordingTimeLimit.GetHashCode();
                if (this.NormalizeDestinationArgs != null)
                    hashCode = hashCode * 59 + this.NormalizeDestinationArgs.GetHashCode();
                if (this.NormalizeExecutable != null)
                    hashCode = hashCode * 59 + this.NormalizeExecutable.GetHashCode();
                if (this.NormalizeSourceArgs != null)
                    hashCode = hashCode * 59 + this.NormalizeSourceArgs.GetHashCode();
                if (this.ProxyHostname != null)
                    hashCode = hashCode * 59 + this.ProxyHostname.GetHashCode();
                if (this.ProxyIp != null)
                    hashCode = hashCode * 59 + this.ProxyIp.GetHashCode();
                if (this.ProxyListeners != null)
                    hashCode = hashCode * 59 + this.ProxyListeners.GetHashCode();
                if (this.ProxyPassword != null)
                    hashCode = hashCode * 59 + this.ProxyPassword.GetHashCode();
                if (this.ProxyPort != null)
                    hashCode = hashCode * 59 + this.ProxyPort.GetHashCode();
                if (this.ProxyStoreAcls != null)
                    hashCode = hashCode * 59 + this.ProxyStoreAcls.GetHashCode();
                if (this.ProxyStoreAuthenticate != null)
                    hashCode = hashCode * 59 + this.ProxyStoreAuthenticate.GetHashCode();
                if (this.ProxyUsername != null)
                    hashCode = hashCode * 59 + this.ProxyUsername.GetHashCode();
                if (this.RecordMinSec != null)
                    hashCode = hashCode * 59 + this.RecordMinSec.GetHashCode();
                if (this.SslCert != null)
                    hashCode = hashCode * 59 + this.SslCert.GetHashCode();
                if (this.SslKey != null)
                    hashCode = hashCode * 59 + this.SslKey.GetHashCode();
                if (this.SslPassword != null)
                    hashCode = hashCode * 59 + this.SslPassword.GetHashCode();
                if (this.SslPort != null)
                    hashCode = hashCode * 59 + this.SslPort.GetHashCode();
                if (this.StoreRecordings != null)
                    hashCode = hashCode * 59 + this.StoreRecordings.GetHashCode();
                if (this.SupportAccountOverrides != null)
                    hashCode = hashCode * 59 + this.SupportAccountOverrides.GetHashCode();
                if (this.UseHttps != null)
                    hashCode = hashCode * 59 + this.UseHttps.GetHashCode();
                if (this.UsePlaintext != null)
                    hashCode = hashCode * 59 + this.UsePlaintext.GetHashCode();
                if (this.UseSslProxy != null)
                    hashCode = hashCode * 59 + this.UseSslProxy.GetHashCode();
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