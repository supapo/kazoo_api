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
    /// Run a callflow on an active call
    /// </summary>
    [DataContract]
    public partial class MetaflowsCallflow :  IEquatable<MetaflowsCallflow>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetaflowsCallflow" /> class.
        /// </summary>
        /// <param name="captures">Callflow extension.</param>
        /// <param name="collected">Callflow extension.</param>
        /// <param name="flow">include the flow you&#39;d like to run (Pivot without the HTTP interaction).</param>
        /// <param name="id">The callflow ID to run.</param>
        public MetaflowsCallflow(string captures = default(string), string collected = default(string), CallflowsAction flow = default(CallflowsAction), string id = default(string))
        {
            this.Captures = captures;
            this.Collected = collected;
            this.Flow = flow;
            this.Id = id;
        }
        
        /// <summary>
        /// Callflow extension
        /// </summary>
        /// <value>Callflow extension</value>
        [DataMember(Name="captures", EmitDefaultValue=false)]
        public string Captures { get; set; }

        /// <summary>
        /// Callflow extension
        /// </summary>
        /// <value>Callflow extension</value>
        [DataMember(Name="collected", EmitDefaultValue=false)]
        public string Collected { get; set; }

        /// <summary>
        /// include the flow you&#39;d like to run (Pivot without the HTTP interaction)
        /// </summary>
        /// <value>include the flow you&#39;d like to run (Pivot without the HTTP interaction)</value>
        [DataMember(Name="flow", EmitDefaultValue=false)]
        public CallflowsAction Flow { get; set; }

        /// <summary>
        /// The callflow ID to run
        /// </summary>
        /// <value>The callflow ID to run</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetaflowsCallflow {\n");
            sb.Append("  Captures: ").Append(Captures).Append("\n");
            sb.Append("  Collected: ").Append(Collected).Append("\n");
            sb.Append("  Flow: ").Append(Flow).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as MetaflowsCallflow);
        }

        /// <summary>
        /// Returns true if MetaflowsCallflow instances are equal
        /// </summary>
        /// <param name="input">Instance of MetaflowsCallflow to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MetaflowsCallflow input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Captures == input.Captures ||
                    (this.Captures != null &&
                    this.Captures.Equals(input.Captures))
                ) && 
                (
                    this.Collected == input.Collected ||
                    (this.Collected != null &&
                    this.Collected.Equals(input.Collected))
                ) && 
                (
                    this.Flow == input.Flow ||
                    (this.Flow != null &&
                    this.Flow.Equals(input.Flow))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.Captures != null)
                    hashCode = hashCode * 59 + this.Captures.GetHashCode();
                if (this.Collected != null)
                    hashCode = hashCode * 59 + this.Collected.GetHashCode();
                if (this.Flow != null)
                    hashCode = hashCode * 59 + this.Flow.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
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