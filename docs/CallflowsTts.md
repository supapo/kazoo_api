# IO.Swagger.Model.CallflowsTts
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EndlessPlayback** | **bool?** | Loop the media until canceled | [optional] 
**Engine** | **string** | What TTS engine to use | [optional] 
**Language** | **string** | The language of the speaker | [optional] 
**SkipModule** | **bool?** | When set to true this callflow action is skipped, advancing to the wildcard branch (if any) | [optional] 
**Terminators** | **List&lt;string&gt;** | What DTMF can terminate playback of the audio | [optional] 
**Text** | **string** | The text to speak | 
**Voice** | **string** | What voice to use when speaking the text | [optional] [default to "female"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

