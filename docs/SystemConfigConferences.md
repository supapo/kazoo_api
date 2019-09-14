# IO.Swagger.Model.SystemConfigConferences
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BridgePassword** | **string** | conferences bridge password | [optional] 
**BridgeUsername** | **string** | conferences bridge username | [optional] 
**Controls** | [**AccountConfigConferencesControls**](AccountConfigConferencesControls.md) |  | [optional] 
**EntryTone** | **string** | conferences entry tone | [optional] [default to "tone_stream://v=-7;>=2;+=.1;%(300,0,523,659);v=-7;>=3;+=.1;%(800,0,659,783)"]
**ExitTone** | **string** | conferences exit tone | [optional] [default to "tone_stream://v=-7;>=2;+=.1;%(300,0,523,440);v=-7;>=3;+=.1;%(800,0,349,440)"]
**ModeratorEntryTone** | **string** | conferences moderator entry tone | [optional] [default to "tone_stream://v=-7;>=2;+=.1;%(300,0,523,659);v=-7;>=3;+=.1;%(800,0,659,783)"]
**ModeratorExitTone** | **string** | conferences moderator exit tone | [optional] [default to "tone_stream://v=-7;>=2;+=.1;%(300,0,523,440);v=-7;>=3;+=.1;%(800,0,349,440)"]
**NumberTimeout** | **int?** | conferences number timeout | [optional] 
**ParticipantSanityCheckMs** | **int?** | conferences participant_sanity_check_ms | [optional] 
**PinTimeout** | **int?** | conferences pin timeout | [optional] 
**Profiles** | [**SystemConfigConferencesProfiles**](SystemConfigConferencesProfiles.md) |  | [optional] 
**ReviewName** | **bool?** | conferences review name | [optional] [default to false]
**RouteWinTimeout** | **int?** | conferences route win timeout | [optional] 
**SupportNameAnnouncement** | **bool?** | conferences support name announcement | [optional] [default to true]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

