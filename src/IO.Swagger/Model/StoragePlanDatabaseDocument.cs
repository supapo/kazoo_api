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
    /// schema for document type storage plan
    /// </summary>
    [DataContract]
    public partial class StoragePlanDatabaseDocument :  IEquatable<StoragePlanDatabaseDocument>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoragePlanDatabaseDocument" /> class.
        /// </summary>
        /// <param name="attachments">attachments.</param>
        /// <param name="connection">connection.</param>
        public StoragePlanDatabaseDocument(StoragePlanDatabaseAttachment attachments = default(StoragePlanDatabaseAttachment), string connection = default(string))
        {
            this.Attachments = attachments;
            this.Connection = connection;
        }
        
        /// <summary>
        /// Gets or Sets Attachments
        /// </summary>
        [DataMember(Name="attachments", EmitDefaultValue=false)]
        public StoragePlanDatabaseAttachment Attachments { get; set; }

        /// <summary>
        /// Gets or Sets Connection
        /// </summary>
        [DataMember(Name="connection", EmitDefaultValue=false)]
        public string Connection { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StoragePlanDatabaseDocument {\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  Connection: ").Append(Connection).Append("\n");
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
            return this.Equals(input as StoragePlanDatabaseDocument);
        }

        /// <summary>
        /// Returns true if StoragePlanDatabaseDocument instances are equal
        /// </summary>
        /// <param name="input">Instance of StoragePlanDatabaseDocument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StoragePlanDatabaseDocument input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Attachments == input.Attachments ||
                    (this.Attachments != null &&
                    this.Attachments.Equals(input.Attachments))
                ) && 
                (
                    this.Connection == input.Connection ||
                    (this.Connection != null &&
                    this.Connection.Equals(input.Connection))
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
                if (this.Attachments != null)
                    hashCode = hashCode * 59 + this.Attachments.GetHashCode();
                if (this.Connection != null)
                    hashCode = hashCode * 59 + this.Connection.GetHashCode();
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
