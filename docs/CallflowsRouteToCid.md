# IO.Swagger.Model.CallflowsRouteToCid
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CanCallSelf** | **bool?** | Toggle whether devices of the same owner can call each other | [optional] 
**CanTextSelf** | **bool?** | Toggle whether devices of the same owner can text each other | [optional] 
**CidTypes** | **List&lt;string&gt;** | CID types to perform search: internal, external, custom | [optional] 
**Delay** | **int?** | How long to delay ringing the device, in seconds | [optional] 
**EndpointTypes** | **List&lt;string&gt;** | Endpoint types to perform search: user, device | [optional] 
**SkipModule** | **bool?** | When set to true this callflow action is skipped, advancing to the wildcard branch (if any) | [optional] 
**StaticInvite** | **string** | Override the SIP Username | [optional] 
**SuppressClid** | **bool?** | Suppress sending caller ID | [optional] 
**Timeout** | **int?** | Time, in seconds, to wait for device to bridge | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

