# IO.Swagger.Model.CallflowsRecordCaller
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Format** | **string** | What format to store the recording on disk | [optional] 
**Method** | **string** | What HTTP method to use when sending the recording | [optional] [default to MethodEnum.Put]
**SkipModule** | **bool?** | When set to true this callflow action is skipped, advancing to the wildcard branch (if any) | [optional] 
**TimeLimit** | **int?** | Time limit, in seconds, for the recording | [optional] 
**Url** | **string** | The URL to use when sending the recording for storage | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

