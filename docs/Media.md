# IO.Swagger.Model.Media
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ContentLength** | **int?** | Length, in bytes, of the file | [optional] 
**ContentType** | **string** | Used to override the automatic upload type | [optional] 
**Description** | **string** | A brief description of the media update, usually the original file name | [optional] 
**Language** | **string** | The language of the media file or text | [optional] [default to "en-us"]
**MediaSource** | **string** | Defines the source of the media | [default to MediaSourceEnum.Upload]
**Name** | **string** | A friendly name for the media | 
**PromptId** | **string** | The prompt this media file represents | [optional] 
**SourceId** | **string** | If the media was generated from a callflow module, this is ID of the properties | [optional] 
**SourceType** | **string** | If the media was generated from a callflow module, this is the module name | [optional] 
**Streamable** | **bool?** | Determines if the media can be streamed | [optional] [default to true]
**Tts** | [**MediaTts**](MediaTts.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

