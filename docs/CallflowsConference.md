# IO.Swagger.Model.CallflowsConference
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Config** | [**Conferences**](Conferences.md) | Build an ad-hoc conference using the conferences JSON schema | [optional] 
**Id** | **string** | Kazoo ID of the conference | [optional] 
**Moderator** | **bool?** | Is the caller entering the conference as a moderator | [optional] 
**PlayEntryTone** | **Object** | Should the Entry Tone be played | [optional] 
**PlayExitTone** | **Object** | Should the Exit Tone be played | [optional] 
**SkipModule** | **bool?** | When set to true this callflow action is skipped, advancing to the wildcard branch (if any) | [optional] 
**WelcomePrompt** | [**CallflowsConferenceWelcomePrompt**](CallflowsConferenceWelcomePrompt.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

