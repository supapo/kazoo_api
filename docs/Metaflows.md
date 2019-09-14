# IO.Swagger.Model.Metaflows
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BindingDigit** | **string** | What DTMF will trigger the collection and analysis of the subsequent DTMF sequence | [optional] [default to BindingDigitEnum.Star]
**DigitTimeout** | **int?** | How long to wait between DTMF presses before processing the collected sequence (milliseconds) | [optional] 
**ListenOn** | **string** | Which leg(s) of the call to listen for DTMF | [optional] 
**Numbers** | **Object** | A list of static numbers with their flows | [optional] 
**Patterns** | **Object** | A list of patterns with their flows | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

