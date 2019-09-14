# IO.Swagger.Model.SystemConfigTasksFaxCleanup
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **bool?** | Enables the cluster to run the fax cleanup task | [optional] [default to true]
**PageSize** | **int?** | The number of documents to process in one fetch operation | [optional] 
**PerPagePauseMs** | **int?** | How many milliseconds to pause between chunk fetches | [optional] 
**StaleAfterS** | **int?** | The number of seconds old a document is before it is considered to be stale | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

