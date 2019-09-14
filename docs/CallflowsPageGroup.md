# IO.Swagger.Model.CallflowsPageGroup
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Audio** | **string** | What kind of audio for the group members | [default to AudioEnum.OneWay]
**BargeCalls** | **bool?** | Should the Endpoint be interrupted by this call | [optional] 
**Endpoints** | [**List&lt;CallflowsPageGroupEndpoints&gt;**](CallflowsPageGroupEndpoints.md) | Endpoint IDs (devices, users, etc) included in the ring group | 
**SkipModule** | **bool?** | When set to true this callflow action is skipped, advancing to the wildcard branch (if any) | [optional] 
**Timeout** | **int?** | How long to ring the ring group before continuing, in seconds | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

