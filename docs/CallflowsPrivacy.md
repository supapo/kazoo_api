# IO.Swagger.Model.CallflowsPrivacy
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EndpointStrategy** | **string** | whether cf_privacy should overwrite or merge with the caller_id_options of the endpoint. | [optional] [default to EndpointStrategyEnum.Overwrite]
**Mode** | **string** | set caller privacy on calls, restricting the presentation some or full parts of Caller ID | [optional] [default to ModeEnum.Full]
**SkipModule** | **bool?** | When set to true this callflow action is skipped, advancing to the wildcard branch (if any) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

