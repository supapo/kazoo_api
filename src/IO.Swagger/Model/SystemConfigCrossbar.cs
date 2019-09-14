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
    /// Schema for crossbar system_config
    /// </summary>
    [DataContract]
    public partial class SystemConfigCrossbar :  IEquatable<SystemConfigCrossbar>, IValidatableObject
    {
        /// <summary>
        /// crossbar stability_level
        /// </summary>
        /// <value>crossbar stability_level</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StabilityLevelEnum
        {
            
            /// <summary>
            /// Enum Alpha for value: alpha
            /// </summary>
            [EnumMember(Value = "alpha")]
            Alpha = 1,
            
            /// <summary>
            /// Enum Beta for value: beta
            /// </summary>
            [EnumMember(Value = "beta")]
            Beta = 2,
            
            /// <summary>
            /// Enum Stable for value: stable
            /// </summary>
            [EnumMember(Value = "stable")]
            Stable = 3
        }

        /// <summary>
        /// crossbar stability_level
        /// </summary>
        /// <value>crossbar stability_level</value>
        [DataMember(Name="stability_level", EmitDefaultValue=false)]
        public StabilityLevelEnum? StabilityLevel { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemConfigCrossbar" /> class.
        /// </summary>
        /// <param name="allowTracing">crossbar allow tracing (default to false).</param>
        /// <param name="apiAuthTokens">crossbar api auth tokens.</param>
        /// <param name="autoloadModules">crossbar autoload modules.</param>
        /// <param name="checkReverseProxies">If request is proxied, should Crossbar check allowed reverse proxies (default to true).</param>
        /// <param name="compressResponseBody">crossbar compress response body (default to true).</param>
        /// <param name="defaultAllowAnonymousQuickcalls">crossbar default allow anonymous quickcalls (default to true).</param>
        /// <param name="defaultLanguage">crossbar default language (default to &quot;en-US&quot;).</param>
        /// <param name="ensureValidSchema">crossbar ensure valid schema (default to true).</param>
        /// <param name="idleTimeoutMs">timeout (in milliseconds) when no data is being sent.</param>
        /// <param name="ip">crossbar ip.</param>
        /// <param name="loadViewChunkSize">crossbar load_view_chunk_size.</param>
        /// <param name="magicPathPatterns">crossbar magic path patterns.</param>
        /// <param name="maxUploadSize">crossbar maximum upload size.</param>
        /// <param name="maximumChunkSize">crossbar maximum_chunk_size.</param>
        /// <param name="maximumRange">crossbar maximum range.</param>
        /// <param name="paginationPageSize">crossbar pagination page size.</param>
        /// <param name="port">crossbar port.</param>
        /// <param name="prettyMetrics">crossbar pretty metrics (default to true).</param>
        /// <param name="refreshAppKeys">crossbar refresh_app_keys.</param>
        /// <param name="requestTimeoutMs">crossbar request timeout in milliseconds.</param>
        /// <param name="resetIdSize">crossbar reset id size.</param>
        /// <param name="reverseProxies">crossbar reverse proxies.</param>
        /// <param name="schemaStrictValidation">crossbar schema strict validation (default to false).</param>
        /// <param name="sslCaCert">crossbar ssl ca cert.</param>
        /// <param name="sslCert">crossbar ssl cert.</param>
        /// <param name="sslKey">crossbar ssl key.</param>
        /// <param name="sslPassword">crossbar ssl password (default to &quot;&quot;).</param>
        /// <param name="sslPort">crossbar ssl port.</param>
        /// <param name="sslWorkers">crossbar ssl workers.</param>
        /// <param name="stabilityLevel">crossbar stability_level.</param>
        /// <param name="tokenCosts">crossbar token costs.</param>
        /// <param name="tracePath">crossbar trace path (default to &quot;/tmp&quot;).</param>
        /// <param name="usePlaintext">crossbar use plaintext (default to true).</param>
        /// <param name="useSsl">crossbar use ssl (default to false).</param>
        /// <param name="userAuthTokens">crossbar user auth tokens.</param>
        /// <param name="workers">crossbar workers.</param>
        public SystemConfigCrossbar(bool? allowTracing = false, int? apiAuthTokens = default(int?), List<string> autoloadModules = default(List<string>), bool? checkReverseProxies = true, bool? compressResponseBody = true, bool? defaultAllowAnonymousQuickcalls = true, string defaultLanguage = "en-US", bool? ensureValidSchema = true, int? idleTimeoutMs = default(int?), string ip = default(string), int? loadViewChunkSize = default(int?), List<string> magicPathPatterns = default(List<string>), int? maxUploadSize = default(int?), int? maximumChunkSize = default(int?), int? maximumRange = default(int?), int? paginationPageSize = default(int?), int? port = default(int?), bool? prettyMetrics = true, List<string> refreshAppKeys = default(List<string>), int? requestTimeoutMs = default(int?), int? resetIdSize = default(int?), List<string> reverseProxies = default(List<string>), bool? schemaStrictValidation = false, string sslCaCert = default(string), string sslCert = default(string), string sslKey = default(string), string sslPassword = "", int? sslPort = default(int?), int? sslWorkers = default(int?), StabilityLevelEnum? stabilityLevel = default(StabilityLevelEnum?), int? tokenCosts = default(int?), string tracePath = "/tmp", bool? usePlaintext = true, bool? useSsl = false, int? userAuthTokens = default(int?), int? workers = default(int?))
        {
            // use default value if no "allowTracing" provided
            if (allowTracing == null)
            {
                this.AllowTracing = false;
            }
            else
            {
                this.AllowTracing = allowTracing;
            }
            this.ApiAuthTokens = apiAuthTokens;
            this.AutoloadModules = autoloadModules;
            // use default value if no "checkReverseProxies" provided
            if (checkReverseProxies == null)
            {
                this.CheckReverseProxies = true;
            }
            else
            {
                this.CheckReverseProxies = checkReverseProxies;
            }
            // use default value if no "compressResponseBody" provided
            if (compressResponseBody == null)
            {
                this.CompressResponseBody = true;
            }
            else
            {
                this.CompressResponseBody = compressResponseBody;
            }
            // use default value if no "defaultAllowAnonymousQuickcalls" provided
            if (defaultAllowAnonymousQuickcalls == null)
            {
                this.DefaultAllowAnonymousQuickcalls = true;
            }
            else
            {
                this.DefaultAllowAnonymousQuickcalls = defaultAllowAnonymousQuickcalls;
            }
            // use default value if no "defaultLanguage" provided
            if (defaultLanguage == null)
            {
                this.DefaultLanguage = "en-US";
            }
            else
            {
                this.DefaultLanguage = defaultLanguage;
            }
            // use default value if no "ensureValidSchema" provided
            if (ensureValidSchema == null)
            {
                this.EnsureValidSchema = true;
            }
            else
            {
                this.EnsureValidSchema = ensureValidSchema;
            }
            this.IdleTimeoutMs = idleTimeoutMs;
            this.Ip = ip;
            this.LoadViewChunkSize = loadViewChunkSize;
            this.MagicPathPatterns = magicPathPatterns;
            this.MaxUploadSize = maxUploadSize;
            this.MaximumChunkSize = maximumChunkSize;
            this.MaximumRange = maximumRange;
            this.PaginationPageSize = paginationPageSize;
            this.Port = port;
            // use default value if no "prettyMetrics" provided
            if (prettyMetrics == null)
            {
                this.PrettyMetrics = true;
            }
            else
            {
                this.PrettyMetrics = prettyMetrics;
            }
            this.RefreshAppKeys = refreshAppKeys;
            this.RequestTimeoutMs = requestTimeoutMs;
            this.ResetIdSize = resetIdSize;
            this.ReverseProxies = reverseProxies;
            // use default value if no "schemaStrictValidation" provided
            if (schemaStrictValidation == null)
            {
                this.SchemaStrictValidation = false;
            }
            else
            {
                this.SchemaStrictValidation = schemaStrictValidation;
            }
            this.SslCaCert = sslCaCert;
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
            this.SslWorkers = sslWorkers;
            this.StabilityLevel = stabilityLevel;
            this.TokenCosts = tokenCosts;
            // use default value if no "tracePath" provided
            if (tracePath == null)
            {
                this.TracePath = "/tmp";
            }
            else
            {
                this.TracePath = tracePath;
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
            // use default value if no "useSsl" provided
            if (useSsl == null)
            {
                this.UseSsl = false;
            }
            else
            {
                this.UseSsl = useSsl;
            }
            this.UserAuthTokens = userAuthTokens;
            this.Workers = workers;
        }
        
        /// <summary>
        /// crossbar allow tracing
        /// </summary>
        /// <value>crossbar allow tracing</value>
        [DataMember(Name="allow_tracing", EmitDefaultValue=false)]
        public bool? AllowTracing { get; set; }

        /// <summary>
        /// crossbar api auth tokens
        /// </summary>
        /// <value>crossbar api auth tokens</value>
        [DataMember(Name="api_auth_tokens", EmitDefaultValue=false)]
        public int? ApiAuthTokens { get; set; }

        /// <summary>
        /// crossbar autoload modules
        /// </summary>
        /// <value>crossbar autoload modules</value>
        [DataMember(Name="autoload_modules", EmitDefaultValue=false)]
        public List<string> AutoloadModules { get; set; }

        /// <summary>
        /// If request is proxied, should Crossbar check allowed reverse proxies
        /// </summary>
        /// <value>If request is proxied, should Crossbar check allowed reverse proxies</value>
        [DataMember(Name="check_reverse_proxies", EmitDefaultValue=false)]
        public bool? CheckReverseProxies { get; set; }

        /// <summary>
        /// crossbar compress response body
        /// </summary>
        /// <value>crossbar compress response body</value>
        [DataMember(Name="compress_response_body", EmitDefaultValue=false)]
        public bool? CompressResponseBody { get; set; }

        /// <summary>
        /// crossbar default allow anonymous quickcalls
        /// </summary>
        /// <value>crossbar default allow anonymous quickcalls</value>
        [DataMember(Name="default_allow_anonymous_quickcalls", EmitDefaultValue=false)]
        public bool? DefaultAllowAnonymousQuickcalls { get; set; }

        /// <summary>
        /// crossbar default language
        /// </summary>
        /// <value>crossbar default language</value>
        [DataMember(Name="default_language", EmitDefaultValue=false)]
        public string DefaultLanguage { get; set; }

        /// <summary>
        /// crossbar ensure valid schema
        /// </summary>
        /// <value>crossbar ensure valid schema</value>
        [DataMember(Name="ensure_valid_schema", EmitDefaultValue=false)]
        public bool? EnsureValidSchema { get; set; }

        /// <summary>
        /// timeout (in milliseconds) when no data is being sent
        /// </summary>
        /// <value>timeout (in milliseconds) when no data is being sent</value>
        [DataMember(Name="idle_timeout_ms", EmitDefaultValue=false)]
        public int? IdleTimeoutMs { get; set; }

        /// <summary>
        /// crossbar ip
        /// </summary>
        /// <value>crossbar ip</value>
        [DataMember(Name="ip", EmitDefaultValue=false)]
        public string Ip { get; set; }

        /// <summary>
        /// crossbar load_view_chunk_size
        /// </summary>
        /// <value>crossbar load_view_chunk_size</value>
        [DataMember(Name="load_view_chunk_size", EmitDefaultValue=false)]
        public int? LoadViewChunkSize { get; set; }

        /// <summary>
        /// crossbar magic path patterns
        /// </summary>
        /// <value>crossbar magic path patterns</value>
        [DataMember(Name="magic_path_patterns", EmitDefaultValue=false)]
        public List<string> MagicPathPatterns { get; set; }

        /// <summary>
        /// crossbar maximum upload size
        /// </summary>
        /// <value>crossbar maximum upload size</value>
        [DataMember(Name="max_upload_size", EmitDefaultValue=false)]
        public int? MaxUploadSize { get; set; }

        /// <summary>
        /// crossbar maximum_chunk_size
        /// </summary>
        /// <value>crossbar maximum_chunk_size</value>
        [DataMember(Name="maximum_chunk_size", EmitDefaultValue=false)]
        public int? MaximumChunkSize { get; set; }

        /// <summary>
        /// crossbar maximum range
        /// </summary>
        /// <value>crossbar maximum range</value>
        [DataMember(Name="maximum_range", EmitDefaultValue=false)]
        public int? MaximumRange { get; set; }

        /// <summary>
        /// crossbar pagination page size
        /// </summary>
        /// <value>crossbar pagination page size</value>
        [DataMember(Name="pagination_page_size", EmitDefaultValue=false)]
        public int? PaginationPageSize { get; set; }

        /// <summary>
        /// crossbar port
        /// </summary>
        /// <value>crossbar port</value>
        [DataMember(Name="port", EmitDefaultValue=false)]
        public int? Port { get; set; }

        /// <summary>
        /// crossbar pretty metrics
        /// </summary>
        /// <value>crossbar pretty metrics</value>
        [DataMember(Name="pretty_metrics", EmitDefaultValue=false)]
        public bool? PrettyMetrics { get; set; }

        /// <summary>
        /// crossbar refresh_app_keys
        /// </summary>
        /// <value>crossbar refresh_app_keys</value>
        [DataMember(Name="refresh_app_keys", EmitDefaultValue=false)]
        public List<string> RefreshAppKeys { get; set; }

        /// <summary>
        /// crossbar request timeout in milliseconds
        /// </summary>
        /// <value>crossbar request timeout in milliseconds</value>
        [DataMember(Name="request_timeout_ms", EmitDefaultValue=false)]
        public int? RequestTimeoutMs { get; set; }

        /// <summary>
        /// crossbar reset id size
        /// </summary>
        /// <value>crossbar reset id size</value>
        [DataMember(Name="reset_id_size", EmitDefaultValue=false)]
        public int? ResetIdSize { get; set; }

        /// <summary>
        /// crossbar reverse proxies
        /// </summary>
        /// <value>crossbar reverse proxies</value>
        [DataMember(Name="reverse_proxies", EmitDefaultValue=false)]
        public List<string> ReverseProxies { get; set; }

        /// <summary>
        /// crossbar schema strict validation
        /// </summary>
        /// <value>crossbar schema strict validation</value>
        [DataMember(Name="schema_strict_validation", EmitDefaultValue=false)]
        public bool? SchemaStrictValidation { get; set; }

        /// <summary>
        /// crossbar ssl ca cert
        /// </summary>
        /// <value>crossbar ssl ca cert</value>
        [DataMember(Name="ssl_ca_cert", EmitDefaultValue=false)]
        public string SslCaCert { get; set; }

        /// <summary>
        /// crossbar ssl cert
        /// </summary>
        /// <value>crossbar ssl cert</value>
        [DataMember(Name="ssl_cert", EmitDefaultValue=false)]
        public string SslCert { get; set; }

        /// <summary>
        /// crossbar ssl key
        /// </summary>
        /// <value>crossbar ssl key</value>
        [DataMember(Name="ssl_key", EmitDefaultValue=false)]
        public string SslKey { get; set; }

        /// <summary>
        /// crossbar ssl password
        /// </summary>
        /// <value>crossbar ssl password</value>
        [DataMember(Name="ssl_password", EmitDefaultValue=false)]
        public string SslPassword { get; set; }

        /// <summary>
        /// crossbar ssl port
        /// </summary>
        /// <value>crossbar ssl port</value>
        [DataMember(Name="ssl_port", EmitDefaultValue=false)]
        public int? SslPort { get; set; }

        /// <summary>
        /// crossbar ssl workers
        /// </summary>
        /// <value>crossbar ssl workers</value>
        [DataMember(Name="ssl_workers", EmitDefaultValue=false)]
        public int? SslWorkers { get; set; }


        /// <summary>
        /// crossbar token costs
        /// </summary>
        /// <value>crossbar token costs</value>
        [DataMember(Name="token_costs", EmitDefaultValue=false)]
        public int? TokenCosts { get; set; }

        /// <summary>
        /// crossbar trace path
        /// </summary>
        /// <value>crossbar trace path</value>
        [DataMember(Name="trace_path", EmitDefaultValue=false)]
        public string TracePath { get; set; }

        /// <summary>
        /// crossbar use plaintext
        /// </summary>
        /// <value>crossbar use plaintext</value>
        [DataMember(Name="use_plaintext", EmitDefaultValue=false)]
        public bool? UsePlaintext { get; set; }

        /// <summary>
        /// crossbar use ssl
        /// </summary>
        /// <value>crossbar use ssl</value>
        [DataMember(Name="use_ssl", EmitDefaultValue=false)]
        public bool? UseSsl { get; set; }

        /// <summary>
        /// crossbar user auth tokens
        /// </summary>
        /// <value>crossbar user auth tokens</value>
        [DataMember(Name="user_auth_tokens", EmitDefaultValue=false)]
        public int? UserAuthTokens { get; set; }

        /// <summary>
        /// crossbar workers
        /// </summary>
        /// <value>crossbar workers</value>
        [DataMember(Name="workers", EmitDefaultValue=false)]
        public int? Workers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SystemConfigCrossbar {\n");
            sb.Append("  AllowTracing: ").Append(AllowTracing).Append("\n");
            sb.Append("  ApiAuthTokens: ").Append(ApiAuthTokens).Append("\n");
            sb.Append("  AutoloadModules: ").Append(AutoloadModules).Append("\n");
            sb.Append("  CheckReverseProxies: ").Append(CheckReverseProxies).Append("\n");
            sb.Append("  CompressResponseBody: ").Append(CompressResponseBody).Append("\n");
            sb.Append("  DefaultAllowAnonymousQuickcalls: ").Append(DefaultAllowAnonymousQuickcalls).Append("\n");
            sb.Append("  DefaultLanguage: ").Append(DefaultLanguage).Append("\n");
            sb.Append("  EnsureValidSchema: ").Append(EnsureValidSchema).Append("\n");
            sb.Append("  IdleTimeoutMs: ").Append(IdleTimeoutMs).Append("\n");
            sb.Append("  Ip: ").Append(Ip).Append("\n");
            sb.Append("  LoadViewChunkSize: ").Append(LoadViewChunkSize).Append("\n");
            sb.Append("  MagicPathPatterns: ").Append(MagicPathPatterns).Append("\n");
            sb.Append("  MaxUploadSize: ").Append(MaxUploadSize).Append("\n");
            sb.Append("  MaximumChunkSize: ").Append(MaximumChunkSize).Append("\n");
            sb.Append("  MaximumRange: ").Append(MaximumRange).Append("\n");
            sb.Append("  PaginationPageSize: ").Append(PaginationPageSize).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
            sb.Append("  PrettyMetrics: ").Append(PrettyMetrics).Append("\n");
            sb.Append("  RefreshAppKeys: ").Append(RefreshAppKeys).Append("\n");
            sb.Append("  RequestTimeoutMs: ").Append(RequestTimeoutMs).Append("\n");
            sb.Append("  ResetIdSize: ").Append(ResetIdSize).Append("\n");
            sb.Append("  ReverseProxies: ").Append(ReverseProxies).Append("\n");
            sb.Append("  SchemaStrictValidation: ").Append(SchemaStrictValidation).Append("\n");
            sb.Append("  SslCaCert: ").Append(SslCaCert).Append("\n");
            sb.Append("  SslCert: ").Append(SslCert).Append("\n");
            sb.Append("  SslKey: ").Append(SslKey).Append("\n");
            sb.Append("  SslPassword: ").Append(SslPassword).Append("\n");
            sb.Append("  SslPort: ").Append(SslPort).Append("\n");
            sb.Append("  SslWorkers: ").Append(SslWorkers).Append("\n");
            sb.Append("  StabilityLevel: ").Append(StabilityLevel).Append("\n");
            sb.Append("  TokenCosts: ").Append(TokenCosts).Append("\n");
            sb.Append("  TracePath: ").Append(TracePath).Append("\n");
            sb.Append("  UsePlaintext: ").Append(UsePlaintext).Append("\n");
            sb.Append("  UseSsl: ").Append(UseSsl).Append("\n");
            sb.Append("  UserAuthTokens: ").Append(UserAuthTokens).Append("\n");
            sb.Append("  Workers: ").Append(Workers).Append("\n");
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
            return this.Equals(input as SystemConfigCrossbar);
        }

        /// <summary>
        /// Returns true if SystemConfigCrossbar instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemConfigCrossbar to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemConfigCrossbar input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllowTracing == input.AllowTracing ||
                    (this.AllowTracing != null &&
                    this.AllowTracing.Equals(input.AllowTracing))
                ) && 
                (
                    this.ApiAuthTokens == input.ApiAuthTokens ||
                    (this.ApiAuthTokens != null &&
                    this.ApiAuthTokens.Equals(input.ApiAuthTokens))
                ) && 
                (
                    this.AutoloadModules == input.AutoloadModules ||
                    this.AutoloadModules != null &&
                    this.AutoloadModules.SequenceEqual(input.AutoloadModules)
                ) && 
                (
                    this.CheckReverseProxies == input.CheckReverseProxies ||
                    (this.CheckReverseProxies != null &&
                    this.CheckReverseProxies.Equals(input.CheckReverseProxies))
                ) && 
                (
                    this.CompressResponseBody == input.CompressResponseBody ||
                    (this.CompressResponseBody != null &&
                    this.CompressResponseBody.Equals(input.CompressResponseBody))
                ) && 
                (
                    this.DefaultAllowAnonymousQuickcalls == input.DefaultAllowAnonymousQuickcalls ||
                    (this.DefaultAllowAnonymousQuickcalls != null &&
                    this.DefaultAllowAnonymousQuickcalls.Equals(input.DefaultAllowAnonymousQuickcalls))
                ) && 
                (
                    this.DefaultLanguage == input.DefaultLanguage ||
                    (this.DefaultLanguage != null &&
                    this.DefaultLanguage.Equals(input.DefaultLanguage))
                ) && 
                (
                    this.EnsureValidSchema == input.EnsureValidSchema ||
                    (this.EnsureValidSchema != null &&
                    this.EnsureValidSchema.Equals(input.EnsureValidSchema))
                ) && 
                (
                    this.IdleTimeoutMs == input.IdleTimeoutMs ||
                    (this.IdleTimeoutMs != null &&
                    this.IdleTimeoutMs.Equals(input.IdleTimeoutMs))
                ) && 
                (
                    this.Ip == input.Ip ||
                    (this.Ip != null &&
                    this.Ip.Equals(input.Ip))
                ) && 
                (
                    this.LoadViewChunkSize == input.LoadViewChunkSize ||
                    (this.LoadViewChunkSize != null &&
                    this.LoadViewChunkSize.Equals(input.LoadViewChunkSize))
                ) && 
                (
                    this.MagicPathPatterns == input.MagicPathPatterns ||
                    this.MagicPathPatterns != null &&
                    this.MagicPathPatterns.SequenceEqual(input.MagicPathPatterns)
                ) && 
                (
                    this.MaxUploadSize == input.MaxUploadSize ||
                    (this.MaxUploadSize != null &&
                    this.MaxUploadSize.Equals(input.MaxUploadSize))
                ) && 
                (
                    this.MaximumChunkSize == input.MaximumChunkSize ||
                    (this.MaximumChunkSize != null &&
                    this.MaximumChunkSize.Equals(input.MaximumChunkSize))
                ) && 
                (
                    this.MaximumRange == input.MaximumRange ||
                    (this.MaximumRange != null &&
                    this.MaximumRange.Equals(input.MaximumRange))
                ) && 
                (
                    this.PaginationPageSize == input.PaginationPageSize ||
                    (this.PaginationPageSize != null &&
                    this.PaginationPageSize.Equals(input.PaginationPageSize))
                ) && 
                (
                    this.Port == input.Port ||
                    (this.Port != null &&
                    this.Port.Equals(input.Port))
                ) && 
                (
                    this.PrettyMetrics == input.PrettyMetrics ||
                    (this.PrettyMetrics != null &&
                    this.PrettyMetrics.Equals(input.PrettyMetrics))
                ) && 
                (
                    this.RefreshAppKeys == input.RefreshAppKeys ||
                    this.RefreshAppKeys != null &&
                    this.RefreshAppKeys.SequenceEqual(input.RefreshAppKeys)
                ) && 
                (
                    this.RequestTimeoutMs == input.RequestTimeoutMs ||
                    (this.RequestTimeoutMs != null &&
                    this.RequestTimeoutMs.Equals(input.RequestTimeoutMs))
                ) && 
                (
                    this.ResetIdSize == input.ResetIdSize ||
                    (this.ResetIdSize != null &&
                    this.ResetIdSize.Equals(input.ResetIdSize))
                ) && 
                (
                    this.ReverseProxies == input.ReverseProxies ||
                    this.ReverseProxies != null &&
                    this.ReverseProxies.SequenceEqual(input.ReverseProxies)
                ) && 
                (
                    this.SchemaStrictValidation == input.SchemaStrictValidation ||
                    (this.SchemaStrictValidation != null &&
                    this.SchemaStrictValidation.Equals(input.SchemaStrictValidation))
                ) && 
                (
                    this.SslCaCert == input.SslCaCert ||
                    (this.SslCaCert != null &&
                    this.SslCaCert.Equals(input.SslCaCert))
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
                    this.SslWorkers == input.SslWorkers ||
                    (this.SslWorkers != null &&
                    this.SslWorkers.Equals(input.SslWorkers))
                ) && 
                (
                    this.StabilityLevel == input.StabilityLevel ||
                    (this.StabilityLevel != null &&
                    this.StabilityLevel.Equals(input.StabilityLevel))
                ) && 
                (
                    this.TokenCosts == input.TokenCosts ||
                    (this.TokenCosts != null &&
                    this.TokenCosts.Equals(input.TokenCosts))
                ) && 
                (
                    this.TracePath == input.TracePath ||
                    (this.TracePath != null &&
                    this.TracePath.Equals(input.TracePath))
                ) && 
                (
                    this.UsePlaintext == input.UsePlaintext ||
                    (this.UsePlaintext != null &&
                    this.UsePlaintext.Equals(input.UsePlaintext))
                ) && 
                (
                    this.UseSsl == input.UseSsl ||
                    (this.UseSsl != null &&
                    this.UseSsl.Equals(input.UseSsl))
                ) && 
                (
                    this.UserAuthTokens == input.UserAuthTokens ||
                    (this.UserAuthTokens != null &&
                    this.UserAuthTokens.Equals(input.UserAuthTokens))
                ) && 
                (
                    this.Workers == input.Workers ||
                    (this.Workers != null &&
                    this.Workers.Equals(input.Workers))
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
                if (this.AllowTracing != null)
                    hashCode = hashCode * 59 + this.AllowTracing.GetHashCode();
                if (this.ApiAuthTokens != null)
                    hashCode = hashCode * 59 + this.ApiAuthTokens.GetHashCode();
                if (this.AutoloadModules != null)
                    hashCode = hashCode * 59 + this.AutoloadModules.GetHashCode();
                if (this.CheckReverseProxies != null)
                    hashCode = hashCode * 59 + this.CheckReverseProxies.GetHashCode();
                if (this.CompressResponseBody != null)
                    hashCode = hashCode * 59 + this.CompressResponseBody.GetHashCode();
                if (this.DefaultAllowAnonymousQuickcalls != null)
                    hashCode = hashCode * 59 + this.DefaultAllowAnonymousQuickcalls.GetHashCode();
                if (this.DefaultLanguage != null)
                    hashCode = hashCode * 59 + this.DefaultLanguage.GetHashCode();
                if (this.EnsureValidSchema != null)
                    hashCode = hashCode * 59 + this.EnsureValidSchema.GetHashCode();
                if (this.IdleTimeoutMs != null)
                    hashCode = hashCode * 59 + this.IdleTimeoutMs.GetHashCode();
                if (this.Ip != null)
                    hashCode = hashCode * 59 + this.Ip.GetHashCode();
                if (this.LoadViewChunkSize != null)
                    hashCode = hashCode * 59 + this.LoadViewChunkSize.GetHashCode();
                if (this.MagicPathPatterns != null)
                    hashCode = hashCode * 59 + this.MagicPathPatterns.GetHashCode();
                if (this.MaxUploadSize != null)
                    hashCode = hashCode * 59 + this.MaxUploadSize.GetHashCode();
                if (this.MaximumChunkSize != null)
                    hashCode = hashCode * 59 + this.MaximumChunkSize.GetHashCode();
                if (this.MaximumRange != null)
                    hashCode = hashCode * 59 + this.MaximumRange.GetHashCode();
                if (this.PaginationPageSize != null)
                    hashCode = hashCode * 59 + this.PaginationPageSize.GetHashCode();
                if (this.Port != null)
                    hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.PrettyMetrics != null)
                    hashCode = hashCode * 59 + this.PrettyMetrics.GetHashCode();
                if (this.RefreshAppKeys != null)
                    hashCode = hashCode * 59 + this.RefreshAppKeys.GetHashCode();
                if (this.RequestTimeoutMs != null)
                    hashCode = hashCode * 59 + this.RequestTimeoutMs.GetHashCode();
                if (this.ResetIdSize != null)
                    hashCode = hashCode * 59 + this.ResetIdSize.GetHashCode();
                if (this.ReverseProxies != null)
                    hashCode = hashCode * 59 + this.ReverseProxies.GetHashCode();
                if (this.SchemaStrictValidation != null)
                    hashCode = hashCode * 59 + this.SchemaStrictValidation.GetHashCode();
                if (this.SslCaCert != null)
                    hashCode = hashCode * 59 + this.SslCaCert.GetHashCode();
                if (this.SslCert != null)
                    hashCode = hashCode * 59 + this.SslCert.GetHashCode();
                if (this.SslKey != null)
                    hashCode = hashCode * 59 + this.SslKey.GetHashCode();
                if (this.SslPassword != null)
                    hashCode = hashCode * 59 + this.SslPassword.GetHashCode();
                if (this.SslPort != null)
                    hashCode = hashCode * 59 + this.SslPort.GetHashCode();
                if (this.SslWorkers != null)
                    hashCode = hashCode * 59 + this.SslWorkers.GetHashCode();
                if (this.StabilityLevel != null)
                    hashCode = hashCode * 59 + this.StabilityLevel.GetHashCode();
                if (this.TokenCosts != null)
                    hashCode = hashCode * 59 + this.TokenCosts.GetHashCode();
                if (this.TracePath != null)
                    hashCode = hashCode * 59 + this.TracePath.GetHashCode();
                if (this.UsePlaintext != null)
                    hashCode = hashCode * 59 + this.UsePlaintext.GetHashCode();
                if (this.UseSsl != null)
                    hashCode = hashCode * 59 + this.UseSsl.GetHashCode();
                if (this.UserAuthTokens != null)
                    hashCode = hashCode * 59 + this.UserAuthTokens.GetHashCode();
                if (this.Workers != null)
                    hashCode = hashCode * 59 + this.Workers.GetHashCode();
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
            // LoadViewChunkSize (int?) minimum
            if(this.LoadViewChunkSize < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LoadViewChunkSize, must be a value greater than or equal to 1.", new [] { "LoadViewChunkSize" });
            }

            // MaximumChunkSize (int?) minimum
            if(this.MaximumChunkSize < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaximumChunkSize, must be a value greater than or equal to 1.", new [] { "MaximumChunkSize" });
            }

            // MaximumRange (int?) minimum
            if(this.MaximumRange < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaximumRange, must be a value greater than or equal to 1.", new [] { "MaximumRange" });
            }

            // PaginationPageSize (int?) minimum
            if(this.PaginationPageSize < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PaginationPageSize, must be a value greater than or equal to 1.", new [] { "PaginationPageSize" });
            }

            yield break;
        }
    }

}