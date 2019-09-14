# IO.Swagger.Model.Cccps
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Active** | **bool?** | Show&#39;s whether CID/PIN active | [optional] [default to false]
**Cid** | **string** | CID to authorize | [optional] 
**Comment** | **string** | Some notes regarding what this pin/cid for | [optional] 
**MaxConcurentCallsPerUser** | **int?** | Calls per user limit. Counts all user&#39;s legs and compares to max_concurrent_calls_per_user multiplied by 2 | [optional] 
**Pin** | **string** | PIN to authorize | [optional] 
**RetainCid** | **bool?** | Pass initial caller number to the callee | [optional] 
**UserId** | **string** | The ID of the user object that &#39;owns&#39; cid/pin | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

