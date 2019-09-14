# IO.Swagger.Model.StorageAttachmentHttpSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Base64EncodeData** | **bool?** | Toggles whether to base64-encode the attachment data | [optional] [default to false]
**SendMultipart** | **bool?** | Toggle whether to send multipart payload when storing attachment - will include metadata JSON if true | [optional] 
**Url** | **string** | The base HTTP(s) URL to use when creating the request | 
**Verb** | **string** | The HTTP verb to use when sending the data | [optional] [default to VerbEnum.Put]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

