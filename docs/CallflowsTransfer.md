# IO.Swagger.Model.CallflowsTransfer
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Captures** | **List&lt;string&gt;** | What to default to using if no capture group is present | [optional] 
**Leg** | **string** | Which leg to transfer (transferee) | [optional] 
**SkipModule** | **bool?** | When set to true this callflow action is skipped, advancing to the wildcard branch (if any) | [optional] 
**Target** | **string** | The target destination (extension or DID) | [optional] 
**TransferType** | **string** | The type of transfer to perform | [optional] [default to TransferTypeEnum.Blind]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

