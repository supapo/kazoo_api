# IO.Swagger.Model.Users
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CallForward** | [**UsersCallForward**](UsersCallForward.md) |  | [optional] 
**CallRecording** | [**CallRecording**](CallRecording.md) |  | [optional] 
**CallRestriction** | [**Dictionary&lt;string, AccountsCallRestriction&gt;**](AccountsCallRestriction.md) | Device level call restrictions for each available number classification | [optional] 
**CallWaiting** | [**CallWaiting**](CallWaiting.md) |  | [optional] 
**CallerId** | [**CallerId**](CallerId.md) | The device caller ID parameters | [optional] 
**CallerIdOptions** | [**DevicesCallerIdOptions**](DevicesCallerIdOptions.md) |  | [optional] 
**ContactList** | [**DevicesContactList**](DevicesContactList.md) |  | [optional] 
**DialPlan** | [**Dialplans**](Dialplans.md) | A list of rules used to modify dialed numbers | [optional] 
**Directories** | **Object** | Provides the mappings for what directory the user is a part of (the key), and what callflow (the value) to invoke if the user is selected by the caller. | [optional] 
**DoNotDisturb** | [**UsersDoNotDisturb**](UsersDoNotDisturb.md) |  | [optional] 
**Email** | **string** | The email of the user | [optional] 
**Enabled** | **bool?** | Determines if the user is currently enabled | [optional] [default to true]
**FeatureLevel** | **string** | The user level for assigning feature sets | [optional] 
**FirstName** | **string** | The first name of the user | 
**Flags** | **List&lt;string&gt;** | Flags set by external applications | [optional] 
**Formatters** | [**Formatters**](Formatters.md) |  | [optional] 
**Hotdesk** | [**UsersHotdesk**](UsersHotdesk.md) |  | [optional] 
**Language** | **string** | The language for this user | [optional] 
**LastName** | **string** | The last name of the user | 
**Media** | [**EndpointMedia**](EndpointMedia.md) | Configure audio/video/etc media options for this user | [optional] 
**Metaflows** | [**Metaflows**](Metaflows.md) | The device metaflow parameters | [optional] 
**MusicOnHold** | [**UsersMusicOnHold**](UsersMusicOnHold.md) |  | [optional] 
**Password** | **string** | The GUI login password | [optional] 
**PresenceId** | **string** | Static presence ID (used instead of SIP username) | [optional] 
**PrivLevel** | **string** | The privilege level of the user | [optional] [default to PrivLevelEnum.User]
**Profile** | [**Profile**](Profile.md) | User&#39;s profile data | [optional] 
**PronouncedName** | [**UsersPronouncedName**](UsersPronouncedName.md) |  | [optional] 
**RequirePasswordUpdate** | **bool?** | UI flag that the user should update their password. | [optional] [default to false]
**Ringtones** | [**AccountsRingtones**](AccountsRingtones.md) |  | [optional] 
**Timezone** | **string** | User&#39;s timezone | [optional] 
**Username** | **string** | The GUI login username - alpha-numeric, dashes, at symbol, periods, plusses, and underscores allowed | [optional] 
**Verified** | **bool?** | Determines if the user has been verified | [optional] [default to false]
**VmToEmailEnabled** | **bool?** | Determines if the user would like voicemails emailed to them | [optional] [default to true]
**Voicemail** | [**AccountsVoicemail**](AccountsVoicemail.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

