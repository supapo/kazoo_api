# IO.Swagger.Model.FormattersFormatOptions
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Direction** | **string** | Only apply the formatter on the relevant request direction | [optional] 
**MatchInviteFormat** | **bool?** | Applicable on fields with SIP URIs. Will format the username portion to match the invite format of the outbound request. | [optional] 
**Prefix** | **string** | Prepends value against the result of a successful regex match | [optional] 
**Regex** | **string** | Matches against the value, with optional capture group | [optional] 
**Strip** | **bool?** | If set to true, the field will be stripped from the payload | [optional] 
**Suffix** | **string** | Appends value against the result of a successful regex match | [optional] 
**Value** | **string** | Replaces the current value with the static value defined | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

