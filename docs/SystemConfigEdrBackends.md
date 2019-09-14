# IO.Swagger.Model.SystemConfigEdrBackends
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Bindings** | [**List&lt;SystemConfigEdrBindings&gt;**](SystemConfigEdrBindings.md) | The types of events the backend should be notified about | 
**Enabled** | **bool?** | Should the backend be started on edr app start? | [default to true]
**Name** | **string** | A unique identifier for the backend | 
**Options** | [**SystemConfigEdrOptions**](SystemConfigEdrOptions.md) |  | [optional] 
**Type** | **string** | The backend module to be used (e.g. amqp refers to edr_be_amqp.erl) | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

