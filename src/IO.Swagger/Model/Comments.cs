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
    /// Schema for comments
    /// </summary>
    [DataContract]
    public partial class Comments :  IEquatable<Comments>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Comments" /> class.
        /// </summary>
        /// <param name="comments">The history of comments made on a object.</param>
        public Comments(List<Comment> comments = default(List<Comment>))
        {
            this._Comments = comments;
        }
        
        /// <summary>
        /// The history of comments made on a object
        /// </summary>
        /// <value>The history of comments made on a object</value>
        [DataMember(Name="comments", EmitDefaultValue=false)]
        public List<Comment> _Comments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Comments {\n");
            sb.Append("  _Comments: ").Append(_Comments).Append("\n");
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
            return this.Equals(input as Comments);
        }

        /// <summary>
        /// Returns true if Comments instances are equal
        /// </summary>
        /// <param name="input">Instance of Comments to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Comments input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._Comments == input._Comments ||
                    this._Comments != null &&
                    this._Comments.SequenceEqual(input._Comments)
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
                if (this._Comments != null)
                    hashCode = hashCode * 59 + this._Comments.GetHashCode();
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
