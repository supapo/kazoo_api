# IO.Swagger.Model.Limits
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowPrepay** | **bool?** | Determines if the account would like to allow per-minute calls if they have no available credit | [optional] [default to true]
**AuthzResourceTypes** | **List&lt;string&gt;** | List of Resource-Types that will authorize the call; bypassing limit checks and billing | [optional] 
**BurstTrunks** | **int?** | The number of two-way, flat-rate trunks used only if no other trunks are available | [optional] 
**Calls** | **int?** | A hard limit for the total number calls | [optional] 
**InboundTrunks** | **int?** | The number of inbound, flat-rate trunks | [optional] 
**OutboundTrunks** | **int?** | The number of outbound, flat-rate trunks | [optional] 
**ResourceConsumingCalls** | **int?** | A hard limit for the number of resource consuming calls | [optional] 
**TwowayTrunks** | **int?** | The number of two-way, flat-rate trunks | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

