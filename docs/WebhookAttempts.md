# IO.Swagger.Model.WebhookAttempts
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientError** | **string** | Kazoo-side error string, if any | [optional] 
**HookId** | **string** | Id of the hook attempted | 
**Reason** | **string** | short reason for the failure | [optional] 
**ResponseBody** | **string** | HTTP response body received, if any | [optional] 
**ResponseCode** | **string** | HTTP response code received, if any | [optional] 
**Result** | **string** | Whether the attempt succeeded or not | 
**RetriesLeft** | **int?** | How many retries were left after this attempt | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

