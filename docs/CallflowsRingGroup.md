# IO.Swagger.Model.CallflowsRingGroup
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Endpoints** | [**List&lt;CallflowsPageGroupEndpoints&gt;**](CallflowsPageGroupEndpoints.md) | Endpoint IDs (devices, users, etc) included in the ring group | 
**FailOnSingleReject** | **bool?** | If any leg rejects the call, cancel all other legs | [optional] 
**IgnoreForward** | **bool?** | If true, will ignore SIP redirect requests for call-forwarded devices | [optional] [default to true]
**Repeats** | **int?** | How many times to retry the ring group | [optional] 
**Ringback** | **string** | Ringback to use | [optional] 
**Ringtones** | [**CallflowsGroupRingtones**](CallflowsGroupRingtones.md) |  | [optional] 
**SkipModule** | **bool?** | When set to true this callflow action is skipped, advancing to the wildcard branch (if any) | [optional] 
**Strategy** | **string** | How to ring the members of the group | [optional] [default to StrategyEnum.Simultaneous]
**Timeout** | **int?** | How long to ring the ring group before continuing, in seconds | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

