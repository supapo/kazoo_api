# IO.Swagger.Model.SystemConfigKazooConvertFax
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AttachmentFormat** | **string** | Format to use for receipt email messages and api responses | [optional] [default to "pdf"]
**ConvertCommandTimeout** | **int?** | Timeout value in ms for how long a convert command can run before being killed | [optional] 
**ConvertImageCommand** | **string** | The command to resample a tiff file to a fax compatible format or convert a supported image/_* format to a tiff | [optional] [default to "convert $FROM -resample 200x200 -units PixelsPerInch -resize 1728x2200 -compress group4 $TO"]
**ConvertOpenofficeCommand** | **string** | The command to convert open office documents to pdf | [optional] [default to "libreoffice --headless --convert-to pdf $FROM --outdir $WORKDIR  2>&1 |egrep 'parser error|Error' && exit 1 || exit 0"]
**ConvertPdfCommand** | **string** | The command to convert pdf documents to tiff | [optional] [default to "/usr/bin/gs -q -r200x200 -g1728x2200 -dNOPAUSE -dBATCH -dSAFER -sDEVICE=tiffg4 -sOutputFile=$TO -- $FROM"]
**ConvertTiffCommand** | **string** | The command to convert a tiff file to PDF | [optional] [default to "tiff2pdf -o $TO $FROM"]
**EnableOpenoffice** | **bool?** | Enables the conversion of openoffice compatible documents | [optional] [default to true]
**LargeTiffCommand** | **string** | The command to resize large tiffs to standard dimensions | [optional] [default to "convert $FROM -resample 200x200 -units PixelsPerInch -resize 1728\!x2200 -compress group4 $TO"]
**ResampleImageCommand** | **string** | The command to resample an image file into a fax compliant formatted tiff | [optional] [default to "convert $FROM -resample 200x200 -page +0+0 -compress group4 $TO"]
**SerializeOpenoffice** | **bool?** | Enable Serialization of openoffice compatible document conversions | [optional] [default to true]
**SmallTiffCommand** | **string** | The command to format small tiffs to a fax compatible format | [optional] [default to "convert $FROM -gravity center -resample 200x200 -units PixelsPerInch -extent 1728x2200 -compress group4 $TO"]
**ValidatePdfCommand** | **string** | The command to verify a PDF file is valid | [optional] [default to "gs -dNOPAUSE -dBATCH -sDEVICE=nullpage $FILE"]
**ValidateTiffCommand** | **string** | The command to verify a TIFF file is valid | [optional] [default to "tiffinfo $FILE"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

