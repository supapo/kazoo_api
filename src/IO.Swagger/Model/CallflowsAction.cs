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
    /// Call flows describe steps to take in order to process a phone call. They are trees of information related to a phone call such as \&quot;answer, play file, record file\&quot; etc. that are logically grouped together and ordered.
    /// </summary>
    [DataContract]
    public partial class CallflowsAction :  IEquatable<CallflowsAction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CallflowsAction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CallflowsAction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CallflowsAction" /> class.
        /// </summary>
        /// <param name="children">Children callflows.</param>
        /// <param name="data">The data/arguments of the callflow module (required).</param>
        /// <param name="module">The name of the callflow module to execute at this node (required).</param>
        public CallflowsAction(Object children = default(Object), Object data = default(Object), string module = default(string))
        {
            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new InvalidDataException("data is a required property for CallflowsAction and cannot be null");
            }
            else
            {
                this.Data = data;
            }
            // to ensure "module" is required (not null)
            if (module == null)
            {
                throw new InvalidDataException("module is a required property for CallflowsAction and cannot be null");
            }
            else
            {
                this.Module = module;
            }
            this.Children = children;
        }
        
        /// <summary>
        /// Children callflows
        /// </summary>
        /// <value>Children callflows</value>
        [DataMember(Name="children", EmitDefaultValue=false)]
        public Object Children { get; set; }

        /// <summary>
        /// The data/arguments of the callflow module
        /// </summary>
        /// <value>The data/arguments of the callflow module</value>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public Object Data { get; set; }

        /// <summary>
        /// The name of the callflow module to execute at this node
        /// </summary>
        /// <value>The name of the callflow module to execute at this node</value>
        [DataMember(Name="module", EmitDefaultValue=false)]
        public string Module { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CallflowsAction {\n");
            sb.Append("  Children: ").Append(Children).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Module: ").Append(Module).Append("\n");
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
            return this.Equals(input as CallflowsAction);
        }

        /// <summary>
        /// Returns true if CallflowsAction instances are equal
        /// </summary>
        /// <param name="input">Instance of CallflowsAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallflowsAction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Children == input.Children ||
                    (this.Children != null &&
                    this.Children.Equals(input.Children))
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.Module == input.Module ||
                    (this.Module != null &&
                    this.Module.Equals(input.Module))
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
                if (this.Children != null)
                    hashCode = hashCode * 59 + this.Children.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.Module != null)
                    hashCode = hashCode * 59 + this.Module.GetHashCode();
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
            // Module (string) maxLength
            if(this.Module != null && this.Module.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Module, length must be less than 64.", new [] { "Module" });
            }

            // Module (string) minLength
            if(this.Module != null && this.Module.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Module, length must be greater than 1.", new [] { "Module" });
            }

            yield break;
        }
    }

}
