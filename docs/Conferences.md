# IO.Swagger.Model.Conferences
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BridgePassword** | **string** | the password used for a conference bridge | [optional] 
**BridgeUsername** | **string** | the username used for a conference bridge | [optional] 
**CallerControls** | **string** | caller controls (config settings) | [optional] 
**ConferenceNumbers** | **List&lt;string&gt;** | Defines conference numbers that can be used by members or moderators | [optional] 
**Controls** | **Object** | controls | [optional] 
**Domain** | **string** | domain | [optional] 
**Flags** | **List&lt;string&gt;** | Flags set by external applications | [optional] 
**Focus** | **string** | This is a read-only property indicating the media server hosting the conference | [optional] 
**Language** | **string** | Prompt language to play in the conference | [optional] 
**MaxMembersMedia** | **string** | Media to play when the conference is full | [optional] 
**MaxParticipants** | **int?** | The maximum number of participants that can join | [optional] 
**Member** | [**ConferencesMember**](ConferencesMember.md) |  | [optional] 
**Moderator** | [**ConferencesModerator**](ConferencesModerator.md) |  | [optional] 
**ModeratorControls** | **string** | profile on the switch for controlling the conference as a moderator | [optional] 
**Name** | **string** | A friendly name for the conference | [optional] 
**OwnerId** | **string** | The user ID who manages this conference | [optional] 
**PlayEntryTone** | **Object** | Whether to play an entry tone, or the entry tone to play | [optional] 
**PlayExitTone** | **Object** | Whether to play an exit tone, or the exit tone to play | [optional] 
**PlayName** | **bool?** | Do we need to announce new conference members? | [optional] [default to false]
**PlayWelcome** | **bool?** | Whether to play the welcome prompt | [optional] 
**Profile** | [**ConferencesProfile**](ConferencesProfile.md) | Profile configuration | [optional] 
**ProfileName** | **string** | conference profile name | [optional] 
**RequireModerator** | **bool?** | does the conference require a moderator | [optional] 
**WaitForModerator** | **bool?** | should members wait for a moderator before joining the conference | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

