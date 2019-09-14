# IO.Swagger.Model.SystemConfigNotify
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AutoloadModules** | **List&lt;string&gt;** | teletype modules to start when teletype is started | [optional] 
**BackoffFudgeMs** | **int?** | notify backoff fudge in milliseconds | [optional] 
**NotificationApp** | **string** | notify notification app | [optional] [default to "teletype"]
**NotifyPersistEnabled** | **bool?** | notify notify_persist_enabled | [optional] [default to true]
**NotifyPersistExceptions** | **List&lt;string&gt;** | notify notify_persist_exceptions | [optional] 
**NotifyPersistTemporaryForceExceptions** | **List&lt;string&gt;** | notify notify_persist_temporary_force_exceptions | [optional] 
**NotifyPublisherTimeoutMs** | **int?** | Timeout in milliseconds when publishing notification using notify publisher | [optional] 
**SearchRepEmail** | **bool?** | notify search rep email | [optional] [default to true]
**ShouldPersistForRetry** | **bool?** | notify should_persist_for_retry | [optional] [default to true]
**UseFederatedListener** | **bool?** | notify use federated listener | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

