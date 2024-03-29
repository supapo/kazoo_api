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
    /// StoragePlanDatabaseAttachmentParams
    /// </summary>
    [DataContract]
    public partial class StoragePlanDatabaseAttachmentParams :  IEquatable<StoragePlanDatabaseAttachmentParams>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoragePlanDatabaseAttachmentParams" /> class.
        /// </summary>
        /// <param name="folderPath">folder path.</param>
        public StoragePlanDatabaseAttachmentParams(string folderPath = default(string))
        {
            this.FolderPath = folderPath;
        }
        
        /// <summary>
        /// folder path
        /// </summary>
        /// <value>folder path</value>
        [DataMember(Name="folder_path", EmitDefaultValue=false)]
        public string FolderPath { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StoragePlanDatabaseAttachmentParams {\n");
            sb.Append("  FolderPath: ").Append(FolderPath).Append("\n");
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
            return this.Equals(input as StoragePlanDatabaseAttachmentParams);
        }

        /// <summary>
        /// Returns true if StoragePlanDatabaseAttachmentParams instances are equal
        /// </summary>
        /// <param name="input">Instance of StoragePlanDatabaseAttachmentParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StoragePlanDatabaseAttachmentParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FolderPath == input.FolderPath ||
                    (this.FolderPath != null &&
                    this.FolderPath.Equals(input.FolderPath))
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
                if (this.FolderPath != null)
                    hashCode = hashCode * 59 + this.FolderPath.GetHashCode();
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
