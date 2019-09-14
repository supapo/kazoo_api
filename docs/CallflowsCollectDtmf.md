# IO.Swagger.Model.CallflowsCollectDtmf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CollectionName** | **string** | Store collected DTMF in a named key | [optional] 
**InterdigitTimeout** | **int?** | How long, in milliseconds, to wait for the next DTMF | [optional] 
**MaxDigits** | **int?** | How many DTMFs to collect from the caller | [optional] 
**SkipModule** | **bool?** | When set to true this callflow action is skipped, advancing to the wildcard branch (if any) | [optional] 
**Terminator** | **string** | What DTMF will terminate collection before the timeout occurs | [optional] [default to TerminatorEnum.Hash]
**Terminators** | **List&lt;string&gt;** | What DTMFs will terminate collection before the timeout occurs | [optional] 
**Timeout** | **int?** | How long, in milliseconds, to wait for the first DTMF | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

