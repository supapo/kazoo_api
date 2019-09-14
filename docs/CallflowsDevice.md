# IO.Swagger.Model.CallflowsDevice
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CanCallSelf** | **bool?** | Toggle whether devices of the same owner can call each other | [optional] 
**CanTextSelf** | **bool?** | Toggle whether devices of the same owner can text each other | [optional] 
**CustomSipHeaders** | **Object** | KV Object where the name is the SIP header and the value is the SIP field | [optional] 
**Delay** | **int?** | How long to delay ringing the device, in seconds | [optional] 
**DialStrategy** | **string** | Dial strategy for the device | [optional] [default to DialStrategyEnum.Simultaneous]
**Id** | **string** | Device ID | [optional] 
**SkipModule** | **bool?** | When set to true this callflow action is skipped, advancing to the wildcard branch (if any) | [optional] 
**StaticInvite** | **string** | Override the SIP Username | [optional] 
**SuppressClid** | **bool?** | Suppress sending caller ID | [optional] 
**Timeout** | **int?** | Time, in seconds, to wait for device to bridge | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

