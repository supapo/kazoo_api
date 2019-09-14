# IO.Swagger.Model.UsersCallForward
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DirectCallsOnly** | **bool?** | Determines if the calls that are not directly sent to the device should be forwarded | [optional] [default to false]
**Enabled** | **bool?** | Determines if the call forwarding should be used | [optional] [default to false]
**Failover** | **bool?** | Enable the call-forwarding parameters if the device is offline | [optional] [default to false]
**IgnoreEarlyMedia** | **bool?** | The option to determine if early media from the call forwarded number should ignored | [optional] [default to true]
**KeepCallerId** | **bool?** | Determines if the caller id is kept when the call is forwarded, if not the devices caller id is used | [optional] [default to true]
**Number** | **string** | The number to forward calls to | [optional] 
**RequireKeypress** | **bool?** | Determines if the callee is prompted to press 1 to accept the call | [optional] [default to true]
**Substitute** | **bool?** | Determines if the call forwarding replaces the device | [optional] [default to true]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

