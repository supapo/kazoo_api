# IO.Swagger.Model.TrunkstoreOptions
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CallerId** | [**TrunkstoreAccountCallerId**](TrunkstoreAccountCallerId.md) |  | [optional] 
**Delay** | **int?** | The time, in seconds, to wait before attempting to call the server | [optional] 
**Enabled** | **bool?** | Is the server ready for sending and receiving calls | [optional] [default to true]
**Failover** | [**ConnectivityOptionsFailover**](ConnectivityOptionsFailover.md) |  | [optional] 
**ForceOutbound** | **bool?** | If true, will send the call over configured carriers instead of to the server (as opposed to the &#39;enabled&#39; flag, which will reject the calls) | [optional] [default to false]
**IgnoreEarlyMedia** | **bool?** |  | [optional] 
**InboundFormat** | **string** | Determines how the INVITE is sent to the server | [optional] [default to InboundFormatEnum.Npan]
**MediaHandling** | **string** | Determine whether the switch should be in the media path or not | [optional] [default to MediaHandlingEnum.Bypass]
**ProgressTimeout** | **int?** | The time, in seconds, to wait for the server to progress in the call, before trying an optionally defined failover route or terminating the call | [optional] 
**SipHeaders** | **List&lt;Object&gt;** | List of arbitrary SIP headers to add to the INVITE | [optional] 
**Timeout** | **int?** | The time, in seconds, to wait for an answer from the server | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

