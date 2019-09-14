# IO.Swagger.Model.CallflowsPrependCid
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Action** | **string** | Action to perform | [optional] [default to ActionEnum.Prepend]
**ApplyTo** | **string** | Apply the prepend to which caller ID | [optional] [default to ApplyToEnum.Current]
**CallerIdNamePrefix** | **string** | Prefix caller ID name | [optional] [default to ""]
**CallerIdNumberPrefix** | **string** | Prefix caller ID number | [optional] [default to ""]
**SkipModule** | **bool?** | When set to true this callflow action is skipped, advancing to the wildcard branch (if any) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

