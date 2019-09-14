# IO.Swagger.Model.ConnectivityOptions
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CallerId** | [**ConnectivityOptionsCallerId**](ConnectivityOptionsCallerId.md) |  | [optional] 
**Delay** | **int?** | The time, in seconds, to wait before attempting to call the server | [optional] 
**DynamicFlags** | **List&lt;string&gt;** | List of function names (or &#39;zone&#39;) that are called on the Call record to populate the &#39;flags&#39; array sent to the resource(s) for matching | [optional] 
**EmergencyCallerId** | [**ConnectivityAccountCallerId**](ConnectivityAccountCallerId.md) |  | [optional] 
**Enabled** | **bool?** | Is the server ready for sending and receiving calls | [optional] [default to true]
**Failover** | [**ConnectivityOptionsFailover**](ConnectivityOptionsFailover.md) |  | [optional] 
**Flags** | **List&lt;string&gt;** | List of flags to use when matching resources to route the call | [optional] 
**ForceOutbound** | **bool?** | If true, will send the call over configured carriers instead of to the server (as opposed to the &#39;enabled&#39; flag, which will reject the calls) | [optional] [default to false]
**HuntAccountId** | **string** | When using local resources, use this account instead of the account making the call (useful for resellers) | [optional] 
**HuntNonReconcilable** | **bool?** | Whether to allow routing to continue on a non-reconcilable TO number | [optional] [default to false]
**IgnoreEarlyMedia** | **bool?** |  | [optional] 
**InboundFormat** | **string** | Determines how the INVITE is sent to the server | [optional] [default to InboundFormatEnum.Npan]
**Ip** | **string** | IP (sip) address for this device | [optional] 
**MediaHandling** | **string** | Determine whether the switch should be in the media path or not | [optional] [default to MediaHandlingEnum.Bypass]
**Port** | **int?** | Port to send SIP traffic for the remote device | [optional] 
**ProgressTimeout** | **int?** | The time, in seconds, to wait for the server to progress in the call, before trying an optionally defined failover route or terminating the call | [optional] 
**SipHeaders** | **List&lt;Object&gt;** | List of arbitrary SIP headers to add to the INVITE | [optional] 
**Timeout** | **int?** | The time, in seconds, to wait for an answer from the server | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

