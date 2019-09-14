# IO.Swagger.Model.CallflowsGroup
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Endpoints** | **List&lt;string&gt;** | List of endpoint (device/user/group) IDs | [optional] 
**FailOnSingleReject** | **bool?** | If any leg rejects the call, cancel all other legs | [optional] 
**Id** | **string** | Group ID | [optional] 
**IgnoreForward** | **bool?** | Whether to ignore forwarded phones | [optional] [default to true]
**Repeats** | **int?** | How many times to repeat dialing the group | [optional] 
**Ringback** | **string** | Ringback to use | [optional] 
**Ringtones** | [**CallflowsGroupRingtones**](CallflowsGroupRingtones.md) |  | [optional] 
**SkipModule** | **bool?** | When set to true this callflow action is skipped, advancing to the wildcard branch (if any) | [optional] 
**Strategy** | **string** | How to ring the endpoints | [optional] [default to StrategyEnum.Simultaneous]
**Timeout** | **int?** | How long to attempt the group | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

