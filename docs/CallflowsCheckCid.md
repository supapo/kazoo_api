# IO.Swagger.Model.CallflowsCheckCid
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CallerId** | [**CallflowsCheckCidCallerId**](CallflowsCheckCidCallerId.md) |  | [optional] 
**Regex** | **string** | Determine match/nomatch when use_absolute_mode is false | [optional] [default to ".*"]
**SkipModule** | **bool?** | When set to true this callflow action is skipped, advancing to the wildcard branch (if any) | [optional] 
**UseAbsoluteMode** | **bool?** | If true, direct call down a branch that matches the caller ID | [optional] [default to false]
**UserId** | **string** | kazoo User ID to use as owner_id instead of detected owner_id | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

