# IO.Swagger.Model.CallflowsWebhook
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomData** | **Object** | JSON object of custom data included on the HTTP request | [optional] 
**HttpVerb** | **string** | What HTTP verb to use when sending the request | [optional] 
**Retries** | **int?** | How many times to retry the request if the host isn&#39;t available | [optional] 
**SkipModule** | **bool?** | When set to true this callflow action is skipped, advancing to the wildcard branch (if any) | [optional] 
**Uri** | **string** | The HTTP URI to send the request | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

