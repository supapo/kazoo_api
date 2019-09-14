# IO.Swagger.Model.CallflowsOffnet
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BypassE164** | **bool?** | Use the original requested number instead of normalizing to E164 | [optional] 
**CallerIdType** | **string** | Which configured caller-id to use (key in the &#39;caller_id&#39; object) | [optional] [default to "external"]
**CustomSipHeaders** | **Object** | A property list of SIP headers | [optional] 
**DoNotNormalize** | **bool?** | Use the original requested number instead of normalizing; otherwise try to apply the endpoint&#39;s dialplan to the requested number | [optional] 
**DynamicFlags** | **List&lt;string&gt;** | List of function names (or &#39;zone&#39;) that are called on the Call record to populate the &#39;flags&#39; array sent to the resource(s) for matching | [optional] 
**EmitAccountId** | **bool?** | Toggles whether to put the account id in the SIP packets | [optional] 
**FormatFromUri** | **bool?** | If true, puts the account realm in the From header | [optional] 
**FromUriRealm** | **string** | Override the From realm in the SIP packets | [optional] 
**HuntAccountId** | **string** | When using local resources, use this account instead of the account making the call (useful for resellers) | [optional] 
**IgnoreEarlyMedia** | **bool?** | Toggle whether to ignore early media | [optional] [default to false]
**OutboundFlags** | **List&lt;string&gt;** | List of flags to use when matching resources to route the call | [optional] 
**ResourceType** | **string** | sets a custom resource type for the published amqp message | [optional] 
**Ringback** | **string** | Tone or file to play while waiting for the leg to be answered | [optional] 
**SkipModule** | **bool?** | When set to true this callflow action is skipped, advancing to the wildcard branch (if any) | [optional] 
**Timeout** | **int?** | How long, in seconds, to wait for the call to be answered | [optional] 
**ToDid** | **string** | Statically set the DID to dial | [optional] 
**UseLocalResources** | **bool?** | Toggle whether to use the account&#39;s (or hunt_account_id&#39;s) resources vs the system resources | [optional] [default to true]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

