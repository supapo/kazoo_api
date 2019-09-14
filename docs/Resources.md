# IO.Swagger.Model.Resources
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Emergency** | **bool?** | Determines if the resource represents emergency services | [optional] [default to false]
**Enabled** | **bool?** | Determines if the resource is currently enabled | [optional] [default to true]
**Flags** | **List&lt;string&gt;** | A list of flags that can be provided on the request and must match for the resource to be eligible | [optional] 
**FlatRateBlacklist** | **string** | Regex for determining if a number should not be eligible for flat-rate trunking | [optional] 
**FlatRateWhitelist** | **string** | Regex for determining if the number is eligible for flat-rate trunking | [optional] 
**FormatFromUri** | **bool?** | When set to true requests to this resource will have a reformatted SIP From Header | [optional] 
**Formatters** | [**Formatters**](Formatters.md) |  | [optional] 
**FromUriRealm** | **string** | When formatting SIP From on outbound requests this can be used to override the realm | [optional] 
**Gateways** | [**List&lt;ResourcesGateways&gt;**](ResourcesGateways.md) | A list of gateways available for this resource | 
**GracePeriod** | **int?** | The amount of time, in seconds, to wait before starting another resource | [optional] 
**IgnoreFlags** | **bool?** | When set to true this resource is used if the rules/classifiers match regardless of flags | [optional] 
**Media** | [**EndpointMedia**](EndpointMedia.md) | Media options for resources | [optional] 
**Name** | **string** | A friendly name for the resource | 
**RequireFlags** | **bool?** | When set to true this resource is ignored if the request does not specify outbound flags | [optional] 
**Rules** | **List&lt;string&gt;** | A list of regular expressions of which one must match for the rule to be eligible, they can optionally contain capture groups | [optional] 
**WeightCost** | **int?** | A value between 0 and 100 that determines the order of resources when multiple can be used | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

