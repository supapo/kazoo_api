# IO.Swagger.Model.MetaflowsRecordCall
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Action** | **string** | Whether to start/stop the recording | [optional] [default to ActionEnum.Toggle]
**Format** | **string** | What format to store the recording | [optional] 
**Label** | **string** | Add a custom label to the recording | [optional] 
**MediaName** | **string** | Name of the recording file | [optional] 
**Method** | **string** | HTTP method if using an HTTP destination | [optional] 
**Origin** | **string** | Track how the recording was started | [optional] 
**RecordMinSec** | **int?** | Minimum number of seconds recorded to consider it a valid recording | [optional] 
**RecordOnAnswer** | **bool?** | Whether to start recording when the leg is answered | [optional] [default to false]
**RecordOnBridge** | **bool?** | Whether to start recording when the leg is bridged | [optional] [default to false]
**RecordSampleRate** | **int?** | Sampling rate for the recording | [optional] 
**TimeLimit** | **int?** | How long to allow the recording, in seconds | [optional] 
**Url** | **string** | HTTP URL to send the finished recording | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

