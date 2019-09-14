# IO.Swagger.Model.Vmboxes
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CheckIfOwner** | **bool?** | Determines if when the user calls their own voicemail they should be prompted to sign in | [optional] [default to true]
**DeleteAfterNotify** | **bool?** | Move the voicemail to delete folder after the notification has been sent | [optional] [default to false]
**Flags** | **List&lt;string&gt;** | Flags set by external applications | [optional] 
**IsSetup** | **bool?** | Determines if the user has completed the initial configuration | [optional] [default to false]
**IsVoicemailFfRwEnabled** | **bool?** | callflow allow fastforward and rewind during voicemail message playback | [optional] [default to false]
**Mailbox** | **string** | The voicemail box number | 
**Media** | [**VmboxesMedia**](VmboxesMedia.md) |  | [optional] 
**MediaExtension** | **string** | Voicemail audio format | [optional] [default to MediaExtensionEnum.Mp3]
**Name** | **string** | A friendly name for the voicemail box | 
**NotConfigurable** | **bool?** | Determines if the user can configure this voicemail. | [optional] [default to false]
**Notify** | [**AccountsVoicemailNotify**](AccountsVoicemailNotify.md) |  | [optional] 
**NotifyEmailAddresses** | **List&lt;string&gt;** | List of email addresses to send notifications to (in addition to owner&#39;s email, if any) | [optional] 
**OldestMessageFirst** | **bool?** | Play older voicemail messages before new ones | [optional] [default to false]
**OwnerId** | **string** | The ID of the user object that &#39;owns&#39; the voicemail box | [optional] 
**Pin** | **string** | The pin number for the voicemail box | [optional] 
**RequirePin** | **bool?** | Determines if a pin is required to check the voicemail from the users devices | [optional] [default to false]
**SaveAfterNotify** | **bool?** | Move the voicemail to save folder after the notification has been sent (This setting will override delete_after_notify) | [optional] [default to false]
**SeekDurationMs** | **int?** | callflow fastforward and rewind seek duration | [optional] 
**SkipEnvelope** | **bool?** | Determines if the envelope should be skipped | [optional] [default to false]
**SkipGreeting** | **bool?** | Determines if the greeting should be skipped | [optional] [default to false]
**SkipInstructions** | **bool?** | Determines if the instructions after the greeting and prior to composing a message should be played | [optional] [default to false]
**Timezone** | **string** | The default timezone | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

