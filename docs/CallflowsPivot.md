# IO.Swagger.Model.CallflowsPivot
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CdrUrl** | **string** | Optional URL to send the CDR to at the end of the call | [optional] 
**Debug** | **bool?** | Store debug logs related to processing this Pivot call | [optional] [default to false]
**Method** | **string** | What HTTP verb to send the request(s) with | [optional] [default to MethodEnum.Get]
**ReqBodyFormat** | **string** | What format should the request body have | [optional] [default to ReqBodyFormatEnum.Form]
**ReqFormat** | **string** | What format of Pivot will the your server respond with | [optional] [default to ReqFormatEnum.Kazoo]
**SkipModule** | **bool?** | When set to true this callflow action is skipped, advancing to the wildcard branch (if any) | [optional] 
**VoiceUrl** | **string** | What URL to request the initial Pivot callflow | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

