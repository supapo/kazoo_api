# IO.Swagger.Model.Accounts
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CallRecording** | [**AccountsCallRecording**](AccountsCallRecording.md) |  | [optional] 
**CallRestriction** | [**Dictionary&lt;string, AccountsCallRestriction&gt;**](AccountsCallRestriction.md) | Account level call restrictions for each available number classification | [optional] 
**CallWaiting** | [**CallWaiting**](CallWaiting.md) |  | [optional] 
**CallerId** | [**CallerId**](CallerId.md) | The account default caller ID parameters | [optional] 
**CallerIdOptions** | [**AccountsCallerIdOptions**](AccountsCallerIdOptions.md) |  | [optional] 
**DialPlan** | [**Dialplans**](Dialplans.md) | A list of default rules used to modify dialed numbers | [optional] 
**DoNotDisturb** | [**AccountsDoNotDisturb**](AccountsDoNotDisturb.md) |  | [optional] 
**Enabled** | **bool?** | Determines if the account is currently enabled | [optional] [default to true]
**Flags** | **List&lt;string&gt;** | Flags set by external applications | [optional] 
**Formatters** | [**Formatters**](Formatters.md) |  | [optional] 
**Language** | **string** | The language for this account | [optional] 
**Metaflows** | [**Metaflows**](Metaflows.md) |  | [optional] 
**MusicOnHold** | [**AccountsMusicOnHold**](AccountsMusicOnHold.md) |  | [optional] 
**Name** | **string** | A friendly name for the account | 
**Notifications** | [**AccountsNotifications**](AccountsNotifications.md) |  | [optional] 
**Org** | **string** | Full legal name of the organization | [optional] 
**Preflow** | [**AccountsPreflow**](AccountsPreflow.md) |  | [optional] 
**Realm** | **string** | The realm of the account, ie: &#39;account1.2600hz.com&#39; | [optional] 
**Ringtones** | [**AccountsRingtones**](AccountsRingtones.md) |  | [optional] 
**Timezone** | **string** | The default timezone | [optional] 
**Topup** | [**AccountsTopup**](AccountsTopup.md) |  | [optional] 
**Voicemail** | [**AccountsVoicemail**](AccountsVoicemail.md) |  | [optional] 
**Zones** | **Object** | A priority ordered mapping of zones for the account | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

