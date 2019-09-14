# IO.Swagger.Model.SystemConfigTasksNotifyResend
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CycleDelayTimeMs** | **int?** | Timeout in milliseconds between each cycle | [optional] 
**MaxDocRead** | **int?** | Max number of notifications to read from database for each cycle | [optional] 
**MaxRetries** | **int?** | Default max retries to re-publish | [optional] 
**PublishTimeoutMs** | **int?** | Timeout in milliseconds for publishing notification | [optional] 
**RescheduleRules** | **Object** | Re-schedule rules for each notification type to apply | [optional] 
**RetryAfterFudgeS** | **int?** | Constant time in seconds which would be multiplied with attempts to set retry time | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

