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
    /// Schema for tasks.fax_cleanup system_config
    /// </summary>
    [DataContract]
    public partial class SystemConfigTasksFaxCleanup :  IEquatable<SystemConfigTasksFaxCleanup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemConfigTasksFaxCleanup" /> class.
        /// </summary>
        /// <param name="enabled">Enables the cluster to run the fax cleanup task (default to true).</param>
        /// <param name="pageSize">The number of documents to process in one fetch operation.</param>
        /// <param name="perPagePauseMs">How many milliseconds to pause between chunk fetches.</param>
        /// <param name="staleAfterS">The number of seconds old a document is before it is considered to be stale.</param>
        public SystemConfigTasksFaxCleanup(bool? enabled = true, int? pageSize = default(int?), int? perPagePauseMs = default(int?), int? staleAfterS = default(int?))
        {
            // use default value if no "enabled" provided
            if (enabled == null)
            {
                this.Enabled = true;
            }
            else
            {
                this.Enabled = enabled;
            }
            this.PageSize = pageSize;
            this.PerPagePauseMs = perPagePauseMs;
            this.StaleAfterS = staleAfterS;
        }
        
        /// <summary>
        /// Enables the cluster to run the fax cleanup task
        /// </summary>
        /// <value>Enables the cluster to run the fax cleanup task</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The number of documents to process in one fetch operation
        /// </summary>
        /// <value>The number of documents to process in one fetch operation</value>
        [DataMember(Name="page_size", EmitDefaultValue=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// How many milliseconds to pause between chunk fetches
        /// </summary>
        /// <value>How many milliseconds to pause between chunk fetches</value>
        [DataMember(Name="per_page_pause_ms", EmitDefaultValue=false)]
        public int? PerPagePauseMs { get; set; }

        /// <summary>
        /// The number of seconds old a document is before it is considered to be stale
        /// </summary>
        /// <value>The number of seconds old a document is before it is considered to be stale</value>
        [DataMember(Name="stale_after_s", EmitDefaultValue=false)]
        public int? StaleAfterS { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SystemConfigTasksFaxCleanup {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  PerPagePauseMs: ").Append(PerPagePauseMs).Append("\n");
            sb.Append("  StaleAfterS: ").Append(StaleAfterS).Append("\n");
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
            return this.Equals(input as SystemConfigTasksFaxCleanup);
        }

        /// <summary>
        /// Returns true if SystemConfigTasksFaxCleanup instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemConfigTasksFaxCleanup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemConfigTasksFaxCleanup input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    (this.PageSize != null &&
                    this.PageSize.Equals(input.PageSize))
                ) && 
                (
                    this.PerPagePauseMs == input.PerPagePauseMs ||
                    (this.PerPagePauseMs != null &&
                    this.PerPagePauseMs.Equals(input.PerPagePauseMs))
                ) && 
                (
                    this.StaleAfterS == input.StaleAfterS ||
                    (this.StaleAfterS != null &&
                    this.StaleAfterS.Equals(input.StaleAfterS))
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
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.PageSize != null)
                    hashCode = hashCode * 59 + this.PageSize.GetHashCode();
                if (this.PerPagePauseMs != null)
                    hashCode = hashCode * 59 + this.PerPagePauseMs.GetHashCode();
                if (this.StaleAfterS != null)
                    hashCode = hashCode * 59 + this.StaleAfterS.GetHashCode();
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