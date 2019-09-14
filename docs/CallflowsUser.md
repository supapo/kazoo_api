# IO.Swagger.Model.CallflowsUser
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CanCallSelf** | **bool?** | Toggle whether devices of this use can call each other | [optional] 
**CanTextSelf** | **bool?** | Toggle whether devices of this use can text each other | [optional] 
**CustomSipHeaders** | **Object** | KV Object where the name is the SIP header and the value is the SIP field | [optional] 
**Delay** | **int?** | How long to delay the endpoint(s) before bridging | [optional] 
**FailOnSingleReject** | **bool?** | If any leg rejects the call, cancel all other legs | [optional] 
**Id** | **string** | User ID | [optional] 
**SkipModule** | **bool?** | When set to true this callflow action is skipped, advancing to the wildcard branch (if any) | [optional] 
**StaticInvite** | **string** | Override the SIP Username | [optional] 
**Strategy** | **string** | Ringing strategy for the endpoint(s) | [optional] [default to StrategyEnum.Simultaneous]
**SuppressClid** | **bool?** | Toggle whether to suppress caller ID | [optional] 
**Timeout** | **int?** | Timeout, in seconds, to wait for answer | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

