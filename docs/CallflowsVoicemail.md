# IO.Swagger.Model.CallflowsVoicemail
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Action** | **string** | Whether to check voicemail box or compose a new voicemail message | [optional] [default to ActionEnum.Compose]
**CalleridMatchLogin** | **bool?** | Whether to match the caller ID to a voicemail box | [optional] [default to false]
**Id** | **string** | The ID of the voicemail box | [optional] 
**InterdigitTimeout** | **int?** | The amount of time (in milliseconds) to wait for the caller to press the next digit after pressing a digit | [optional] 
**MaxMessageLength** | **int?** | Max length of the message that caller can leave in voicemail box | [optional] 
**SingleMailboxLogin** | **bool?** | Allow login if caller has a single mailbox | [optional] [default to false]
**SkipModule** | **bool?** | When set to true this callflow action is skipped, advancing to the wildcard branch (if any) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

