# IO.Swagger.Model.CallflowsPark
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Action** | **string** | Action to take for the caller | [optional] [default to ActionEnum.Park]
**CustomPresenceId** | **bool?** | use configured presence_id and fallback to request | [optional] [default to false]
**DefaultCallbackTimeout** | **int?** | How long, in seconds, to wait before calling back the parker | [optional] 
**DefaultPresenceType** | **string** | Type of presence to update | [optional] 
**DefaultRingbackTimeout** | **int?** | How long, in milliseconds, before ringing back | [optional] 
**MaxSlotNumber** | **int?** | Continue past this module if the selected slot number exceeds this number. Used to restrict the max number of auto-generated slot numbers | [optional] 
**PresenceId** | **string** | use this presence_id | [optional] 
**SkipModule** | **bool?** | When set to true this callflow action is skipped, advancing to the wildcard branch (if any) | [optional] 
**Slot** | **string** | Static slot number to use | [optional] 
**Slots** | **Object** | Statically define slots and their configuration | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

