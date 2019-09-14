# IO.Swagger.Model.CallflowsRecordCall
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Action** | **string** | Whether to start or stop the recording | [default to ActionEnum.Start]
**Format** | **string** | What format to store the recording on disk | [optional] 
**Label** | **string** | Label to include in the origin of call recording | [optional] 
**MediaName** | **string** | the name of media | [optional] 
**Method** | **string** | HTTP verb to use when sending the recording to the supplied URL | [optional] [default to MethodEnum.Put]
**Origin** | **string** | How the recording was started - read-only | [optional] 
**RecordMinSec** | **int?** | The minimum length, in seconds, the recording must be to be considered successful. Otherwise it is deleted | [optional] 
**RecordOnAnswer** | **bool?** | Whether to delay the recording until the channel is answered | [optional] [default to false]
**RecordOnBridge** | **bool?** | Whether to delay the recording until the channel is bridged | [optional] [default to false]
**RecordSampleRate** | **int?** | What sampling rate to use on the recording | [optional] 
**ShouldFollowTransfer** | **bool?** | If true, the recording will continue after a transfer on the active leg | [optional] [default to true]
**SkipModule** | **bool?** | When set to true this callflow action is skipped, advancing to the wildcard branch (if any) | [optional] 
**TimeLimit** | **int?** | Time limit, in seconds, for the recording | [optional] 
**Url** | **string** | The URL to use when sending the recording for storage | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

