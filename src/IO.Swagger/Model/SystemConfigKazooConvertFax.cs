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
    /// SystemConfigKazooConvertFax
    /// </summary>
    [DataContract]
    public partial class SystemConfigKazooConvertFax :  IEquatable<SystemConfigKazooConvertFax>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemConfigKazooConvertFax" /> class.
        /// </summary>
        /// <param name="attachmentFormat">Format to use for receipt email messages and api responses (default to &quot;pdf&quot;).</param>
        /// <param name="convertCommandTimeout">Timeout value in ms for how long a convert command can run before being killed.</param>
        /// <param name="convertImageCommand">The command to resample a tiff file to a fax compatible format or convert a supported image/_* format to a tiff (default to &quot;convert $FROM -resample 200x200 -units PixelsPerInch -resize 1728x2200 -compress group4 $TO&quot;).</param>
        /// <param name="convertOpenofficeCommand">The command to convert open office documents to pdf (default to &quot;libreoffice --headless --convert-to pdf $FROM --outdir $WORKDIR  2&gt;&amp;1 |egrep &#39;parser error|Error&#39; &amp;&amp; exit 1 || exit 0&quot;).</param>
        /// <param name="convertPdfCommand">The command to convert pdf documents to tiff (default to &quot;/usr/bin/gs -q -r200x200 -g1728x2200 -dNOPAUSE -dBATCH -dSAFER -sDEVICE&#x3D;tiffg4 -sOutputFile&#x3D;$TO -- $FROM&quot;).</param>
        /// <param name="convertTiffCommand">The command to convert a tiff file to PDF (default to &quot;tiff2pdf -o $TO $FROM&quot;).</param>
        /// <param name="enableOpenoffice">Enables the conversion of openoffice compatible documents (default to true).</param>
        /// <param name="largeTiffCommand">The command to resize large tiffs to standard dimensions (default to &quot;convert $FROM -resample 200x200 -units PixelsPerInch -resize 1728\!x2200 -compress group4 $TO&quot;).</param>
        /// <param name="resampleImageCommand">The command to resample an image file into a fax compliant formatted tiff (default to &quot;convert $FROM -resample 200x200 -page +0+0 -compress group4 $TO&quot;).</param>
        /// <param name="serializeOpenoffice">Enable Serialization of openoffice compatible document conversions (default to true).</param>
        /// <param name="smallTiffCommand">The command to format small tiffs to a fax compatible format (default to &quot;convert $FROM -gravity center -resample 200x200 -units PixelsPerInch -extent 1728x2200 -compress group4 $TO&quot;).</param>
        /// <param name="validatePdfCommand">The command to verify a PDF file is valid (default to &quot;gs -dNOPAUSE -dBATCH -sDEVICE&#x3D;nullpage $FILE&quot;).</param>
        /// <param name="validateTiffCommand">The command to verify a TIFF file is valid (default to &quot;tiffinfo $FILE&quot;).</param>
        public SystemConfigKazooConvertFax(string attachmentFormat = "pdf", int? convertCommandTimeout = default(int?), string convertImageCommand = "convert $FROM -resample 200x200 -units PixelsPerInch -resize 1728x2200 -compress group4 $TO", string convertOpenofficeCommand = "libreoffice --headless --convert-to pdf $FROM --outdir $WORKDIR  2>&1 |egrep 'parser error|Error' && exit 1 || exit 0", string convertPdfCommand = "/usr/bin/gs -q -r200x200 -g1728x2200 -dNOPAUSE -dBATCH -dSAFER -sDEVICE=tiffg4 -sOutputFile=$TO -- $FROM", string convertTiffCommand = "tiff2pdf -o $TO $FROM", bool? enableOpenoffice = true, string largeTiffCommand = "convert $FROM -resample 200x200 -units PixelsPerInch -resize 1728\!x2200 -compress group4 $TO", string resampleImageCommand = "convert $FROM -resample 200x200 -page +0+0 -compress group4 $TO", bool? serializeOpenoffice = true, string smallTiffCommand = "convert $FROM -gravity center -resample 200x200 -units PixelsPerInch -extent 1728x2200 -compress group4 $TO", string validatePdfCommand = "gs -dNOPAUSE -dBATCH -sDEVICE=nullpage $FILE", string validateTiffCommand = "tiffinfo $FILE")
        {
            // use default value if no "attachmentFormat" provided
            if (attachmentFormat == null)
            {
                this.AttachmentFormat = "pdf";
            }
            else
            {
                this.AttachmentFormat = attachmentFormat;
            }
            this.ConvertCommandTimeout = convertCommandTimeout;
            // use default value if no "convertImageCommand" provided
            if (convertImageCommand == null)
            {
                this.ConvertImageCommand = "convert $FROM -resample 200x200 -units PixelsPerInch -resize 1728x2200 -compress group4 $TO";
            }
            else
            {
                this.ConvertImageCommand = convertImageCommand;
            }
            // use default value if no "convertOpenofficeCommand" provided
            if (convertOpenofficeCommand == null)
            {
                this.ConvertOpenofficeCommand = "libreoffice --headless --convert-to pdf $FROM --outdir $WORKDIR  2>&1 |egrep 'parser error|Error' && exit 1 || exit 0";
            }
            else
            {
                this.ConvertOpenofficeCommand = convertOpenofficeCommand;
            }
            // use default value if no "convertPdfCommand" provided
            if (convertPdfCommand == null)
            {
                this.ConvertPdfCommand = "/usr/bin/gs -q -r200x200 -g1728x2200 -dNOPAUSE -dBATCH -dSAFER -sDEVICE=tiffg4 -sOutputFile=$TO -- $FROM";
            }
            else
            {
                this.ConvertPdfCommand = convertPdfCommand;
            }
            // use default value if no "convertTiffCommand" provided
            if (convertTiffCommand == null)
            {
                this.ConvertTiffCommand = "tiff2pdf -o $TO $FROM";
            }
            else
            {
                this.ConvertTiffCommand = convertTiffCommand;
            }
            // use default value if no "enableOpenoffice" provided
            if (enableOpenoffice == null)
            {
                this.EnableOpenoffice = true;
            }
            else
            {
                this.EnableOpenoffice = enableOpenoffice;
            }
            // use default value if no "largeTiffCommand" provided
            if (largeTiffCommand == null)
            {
                this.LargeTiffCommand = "convert $FROM -resample 200x200 -units PixelsPerInch -resize 1728\!x2200 -compress group4 $TO";
            }
            else
            {
                this.LargeTiffCommand = largeTiffCommand;
            }
            // use default value if no "resampleImageCommand" provided
            if (resampleImageCommand == null)
            {
                this.ResampleImageCommand = "convert $FROM -resample 200x200 -page +0+0 -compress group4 $TO";
            }
            else
            {
                this.ResampleImageCommand = resampleImageCommand;
            }
            // use default value if no "serializeOpenoffice" provided
            if (serializeOpenoffice == null)
            {
                this.SerializeOpenoffice = true;
            }
            else
            {
                this.SerializeOpenoffice = serializeOpenoffice;
            }
            // use default value if no "smallTiffCommand" provided
            if (smallTiffCommand == null)
            {
                this.SmallTiffCommand = "convert $FROM -gravity center -resample 200x200 -units PixelsPerInch -extent 1728x2200 -compress group4 $TO";
            }
            else
            {
                this.SmallTiffCommand = smallTiffCommand;
            }
            // use default value if no "validatePdfCommand" provided
            if (validatePdfCommand == null)
            {
                this.ValidatePdfCommand = "gs -dNOPAUSE -dBATCH -sDEVICE=nullpage $FILE";
            }
            else
            {
                this.ValidatePdfCommand = validatePdfCommand;
            }
            // use default value if no "validateTiffCommand" provided
            if (validateTiffCommand == null)
            {
                this.ValidateTiffCommand = "tiffinfo $FILE";
            }
            else
            {
                this.ValidateTiffCommand = validateTiffCommand;
            }
        }
        
        /// <summary>
        /// Format to use for receipt email messages and api responses
        /// </summary>
        /// <value>Format to use for receipt email messages and api responses</value>
        [DataMember(Name="attachment_format", EmitDefaultValue=false)]
        public string AttachmentFormat { get; set; }

        /// <summary>
        /// Timeout value in ms for how long a convert command can run before being killed
        /// </summary>
        /// <value>Timeout value in ms for how long a convert command can run before being killed</value>
        [DataMember(Name="convert_command_timeout", EmitDefaultValue=false)]
        public int? ConvertCommandTimeout { get; set; }

        /// <summary>
        /// The command to resample a tiff file to a fax compatible format or convert a supported image/_* format to a tiff
        /// </summary>
        /// <value>The command to resample a tiff file to a fax compatible format or convert a supported image/_* format to a tiff</value>
        [DataMember(Name="convert_image_command", EmitDefaultValue=false)]
        public string ConvertImageCommand { get; set; }

        /// <summary>
        /// The command to convert open office documents to pdf
        /// </summary>
        /// <value>The command to convert open office documents to pdf</value>
        [DataMember(Name="convert_openoffice_command", EmitDefaultValue=false)]
        public string ConvertOpenofficeCommand { get; set; }

        /// <summary>
        /// The command to convert pdf documents to tiff
        /// </summary>
        /// <value>The command to convert pdf documents to tiff</value>
        [DataMember(Name="convert_pdf_command", EmitDefaultValue=false)]
        public string ConvertPdfCommand { get; set; }

        /// <summary>
        /// The command to convert a tiff file to PDF
        /// </summary>
        /// <value>The command to convert a tiff file to PDF</value>
        [DataMember(Name="convert_tiff_command", EmitDefaultValue=false)]
        public string ConvertTiffCommand { get; set; }

        /// <summary>
        /// Enables the conversion of openoffice compatible documents
        /// </summary>
        /// <value>Enables the conversion of openoffice compatible documents</value>
        [DataMember(Name="enable_openoffice", EmitDefaultValue=false)]
        public bool? EnableOpenoffice { get; set; }

        /// <summary>
        /// The command to resize large tiffs to standard dimensions
        /// </summary>
        /// <value>The command to resize large tiffs to standard dimensions</value>
        [DataMember(Name="large_tiff_command", EmitDefaultValue=false)]
        public string LargeTiffCommand { get; set; }

        /// <summary>
        /// The command to resample an image file into a fax compliant formatted tiff
        /// </summary>
        /// <value>The command to resample an image file into a fax compliant formatted tiff</value>
        [DataMember(Name="resample_image_command", EmitDefaultValue=false)]
        public string ResampleImageCommand { get; set; }

        /// <summary>
        /// Enable Serialization of openoffice compatible document conversions
        /// </summary>
        /// <value>Enable Serialization of openoffice compatible document conversions</value>
        [DataMember(Name="serialize_openoffice", EmitDefaultValue=false)]
        public bool? SerializeOpenoffice { get; set; }

        /// <summary>
        /// The command to format small tiffs to a fax compatible format
        /// </summary>
        /// <value>The command to format small tiffs to a fax compatible format</value>
        [DataMember(Name="small_tiff_command", EmitDefaultValue=false)]
        public string SmallTiffCommand { get; set; }

        /// <summary>
        /// The command to verify a PDF file is valid
        /// </summary>
        /// <value>The command to verify a PDF file is valid</value>
        [DataMember(Name="validate_pdf_command", EmitDefaultValue=false)]
        public string ValidatePdfCommand { get; set; }

        /// <summary>
        /// The command to verify a TIFF file is valid
        /// </summary>
        /// <value>The command to verify a TIFF file is valid</value>
        [DataMember(Name="validate_tiff_command", EmitDefaultValue=false)]
        public string ValidateTiffCommand { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SystemConfigKazooConvertFax {\n");
            sb.Append("  AttachmentFormat: ").Append(AttachmentFormat).Append("\n");
            sb.Append("  ConvertCommandTimeout: ").Append(ConvertCommandTimeout).Append("\n");
            sb.Append("  ConvertImageCommand: ").Append(ConvertImageCommand).Append("\n");
            sb.Append("  ConvertOpenofficeCommand: ").Append(ConvertOpenofficeCommand).Append("\n");
            sb.Append("  ConvertPdfCommand: ").Append(ConvertPdfCommand).Append("\n");
            sb.Append("  ConvertTiffCommand: ").Append(ConvertTiffCommand).Append("\n");
            sb.Append("  EnableOpenoffice: ").Append(EnableOpenoffice).Append("\n");
            sb.Append("  LargeTiffCommand: ").Append(LargeTiffCommand).Append("\n");
            sb.Append("  ResampleImageCommand: ").Append(ResampleImageCommand).Append("\n");
            sb.Append("  SerializeOpenoffice: ").Append(SerializeOpenoffice).Append("\n");
            sb.Append("  SmallTiffCommand: ").Append(SmallTiffCommand).Append("\n");
            sb.Append("  ValidatePdfCommand: ").Append(ValidatePdfCommand).Append("\n");
            sb.Append("  ValidateTiffCommand: ").Append(ValidateTiffCommand).Append("\n");
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
            return this.Equals(input as SystemConfigKazooConvertFax);
        }

        /// <summary>
        /// Returns true if SystemConfigKazooConvertFax instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemConfigKazooConvertFax to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemConfigKazooConvertFax input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AttachmentFormat == input.AttachmentFormat ||
                    (this.AttachmentFormat != null &&
                    this.AttachmentFormat.Equals(input.AttachmentFormat))
                ) && 
                (
                    this.ConvertCommandTimeout == input.ConvertCommandTimeout ||
                    (this.ConvertCommandTimeout != null &&
                    this.ConvertCommandTimeout.Equals(input.ConvertCommandTimeout))
                ) && 
                (
                    this.ConvertImageCommand == input.ConvertImageCommand ||
                    (this.ConvertImageCommand != null &&
                    this.ConvertImageCommand.Equals(input.ConvertImageCommand))
                ) && 
                (
                    this.ConvertOpenofficeCommand == input.ConvertOpenofficeCommand ||
                    (this.ConvertOpenofficeCommand != null &&
                    this.ConvertOpenofficeCommand.Equals(input.ConvertOpenofficeCommand))
                ) && 
                (
                    this.ConvertPdfCommand == input.ConvertPdfCommand ||
                    (this.ConvertPdfCommand != null &&
                    this.ConvertPdfCommand.Equals(input.ConvertPdfCommand))
                ) && 
                (
                    this.ConvertTiffCommand == input.ConvertTiffCommand ||
                    (this.ConvertTiffCommand != null &&
                    this.ConvertTiffCommand.Equals(input.ConvertTiffCommand))
                ) && 
                (
                    this.EnableOpenoffice == input.EnableOpenoffice ||
                    (this.EnableOpenoffice != null &&
                    this.EnableOpenoffice.Equals(input.EnableOpenoffice))
                ) && 
                (
                    this.LargeTiffCommand == input.LargeTiffCommand ||
                    (this.LargeTiffCommand != null &&
                    this.LargeTiffCommand.Equals(input.LargeTiffCommand))
                ) && 
                (
                    this.ResampleImageCommand == input.ResampleImageCommand ||
                    (this.ResampleImageCommand != null &&
                    this.ResampleImageCommand.Equals(input.ResampleImageCommand))
                ) && 
                (
                    this.SerializeOpenoffice == input.SerializeOpenoffice ||
                    (this.SerializeOpenoffice != null &&
                    this.SerializeOpenoffice.Equals(input.SerializeOpenoffice))
                ) && 
                (
                    this.SmallTiffCommand == input.SmallTiffCommand ||
                    (this.SmallTiffCommand != null &&
                    this.SmallTiffCommand.Equals(input.SmallTiffCommand))
                ) && 
                (
                    this.ValidatePdfCommand == input.ValidatePdfCommand ||
                    (this.ValidatePdfCommand != null &&
                    this.ValidatePdfCommand.Equals(input.ValidatePdfCommand))
                ) && 
                (
                    this.ValidateTiffCommand == input.ValidateTiffCommand ||
                    (this.ValidateTiffCommand != null &&
                    this.ValidateTiffCommand.Equals(input.ValidateTiffCommand))
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
                if (this.AttachmentFormat != null)
                    hashCode = hashCode * 59 + this.AttachmentFormat.GetHashCode();
                if (this.ConvertCommandTimeout != null)
                    hashCode = hashCode * 59 + this.ConvertCommandTimeout.GetHashCode();
                if (this.ConvertImageCommand != null)
                    hashCode = hashCode * 59 + this.ConvertImageCommand.GetHashCode();
                if (this.ConvertOpenofficeCommand != null)
                    hashCode = hashCode * 59 + this.ConvertOpenofficeCommand.GetHashCode();
                if (this.ConvertPdfCommand != null)
                    hashCode = hashCode * 59 + this.ConvertPdfCommand.GetHashCode();
                if (this.ConvertTiffCommand != null)
                    hashCode = hashCode * 59 + this.ConvertTiffCommand.GetHashCode();
                if (this.EnableOpenoffice != null)
                    hashCode = hashCode * 59 + this.EnableOpenoffice.GetHashCode();
                if (this.LargeTiffCommand != null)
                    hashCode = hashCode * 59 + this.LargeTiffCommand.GetHashCode();
                if (this.ResampleImageCommand != null)
                    hashCode = hashCode * 59 + this.ResampleImageCommand.GetHashCode();
                if (this.SerializeOpenoffice != null)
                    hashCode = hashCode * 59 + this.SerializeOpenoffice.GetHashCode();
                if (this.SmallTiffCommand != null)
                    hashCode = hashCode * 59 + this.SmallTiffCommand.GetHashCode();
                if (this.ValidatePdfCommand != null)
                    hashCode = hashCode * 59 + this.ValidatePdfCommand.GetHashCode();
                if (this.ValidateTiffCommand != null)
                    hashCode = hashCode * 59 + this.ValidateTiffCommand.GetHashCode();
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
