# IO.Swagger.Model.SystemConfigLimits
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowPostpay** | **bool?** | Permit postpay settings on accounts by default | [optional] [default to false]
**AllowPrepay** | **bool?** | Permit prepay settings on accounts by default | [optional] [default to true]
**AuthzResourceTypes** | **List&lt;string&gt;** | List of Resource-Types that will authorize the call; bypassing limit checks and billing per account by default | [optional] 
**BurstTrunks** | **int?** | A hard limit for number of burst trunks permitted per account by default | [optional] 
**Calls** | **int?** | A hard limit for the total number calls per account by default | [optional] 
**Enabled** | **bool?** | Determines if the limits should be enforced on accounts by default | [optional] [default to true]
**InboundTrunks** | **int?** | A hard limit for the number of inbound trunks per account by default | [optional] 
**MaxPostpayAmmount** | **int?** | A hard limit for the postpay before limiting calls per account by default | [optional] 
**OutboundTrunks** | **int?** | A hard limit for the number of outbound trunks per account by default | [optional] 
**ReserveAmmount** | **int?** | The amount to hold in reserve per account by default | [optional] 
**ResourceConsumingCalls** | **int?** | A hard limit for the number of resource consuming calls per account by default | [optional] 
**SoftLimitInbound** | **bool?** | Permit calls on inbound calls accounts which have exceeded the limit per account by default | [optional] [default to false]
**SoftLimitOutbound** | **bool?** | Permit calls on outbound calls for accounts which have exceeded the limit per account by default | [optional] [default to false]
**TwowayTrunks** | **int?** | A hard limit for the number of twoway trunks per account by default | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

