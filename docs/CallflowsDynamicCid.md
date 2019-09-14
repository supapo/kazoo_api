# IO.Swagger.Model.CallflowsDynamicCid
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Action** | **string** | What action to perform | [optional] 
**CallerId** | [**CallflowsDynamicCidCallerId**](CallflowsDynamicCidCallerId.md) |  | [optional] 
**EnforceCallRestriction** | **bool?** | Check classification restrictions against endpoint | [optional] [default to true]
**Id** | **string** | List ID for caller IDs when &#39;action&#39; is &#39;list&#39; | [optional] 
**IdxName** | **string** | Named capture group to use | [optional] 
**InterdigitTimeout** | **int?** | How long, in seconds, to wait for keypresses | [optional] 
**MaxDigits** | **int?** | Max number of digits allowed when collecting Caller ID Number | [optional] 
**MediaId** | **string** | Prompt to play to caller to enter Caller ID Number | [optional] 
**MinDigits** | **int?** | Minimum number of digits that must match the regex to collected DTMF | [optional] 
**PermitCustomCallflow** | **bool?** | Permit a custom callflow to be accepted instead of restricting to no_match only when looking up callflows | [optional] [default to false]
**SkipModule** | **bool?** | When set to true this callflow action is skipped, advancing to the wildcard branch (if any) | [optional] 
**WhitelistRegex** | **string** | Regex to match collected Caller ID Number | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

