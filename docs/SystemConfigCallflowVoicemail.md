# IO.Swagger.Model.SystemConfigCallflowVoicemail
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeleteAfterNotify** | **bool?** | callflow delete after notify | [optional] [default to false]
**Extension** | **string** | Default media file format for Callflow modules | [optional] [default to "mp3"]
**ForceRequirePin** | **bool?** | If true, ignore the setting on the vmbox and require all users to enter a pin | [optional] [default to false]
**IsVoicemailFfRwEnabled** | **bool?** | callflow allow fastforward and rewind during voicemail message playback | [optional] [default to false]
**MaxBoxNumberLength** | **int?** | callflow maximum box number length | [optional] 
**MaxLoginAttempts** | **int?** | callflow max login attempts | [optional] 
**MaxMessageCount** | **int?** | callflow maximum message count | [optional] 
**MaxMessageLength** | **int?** | callflow maximum message length | [optional] 
**MaxPinLength** | **int?** | callflow maximum pin length | [optional] 
**MessageRetentionDuration** | **int?** | Voicemail message retention duration in days | [optional] 
**MigrateInteraccountDelayMs** | **int?** | callflow migrate interaccount delay in milliseconds | [optional] 
**MigrateMaxBulkInsert** | **int?** | callflow migrate maximum bulk insert | [optional] 
**MigrateMaxWorker** | **int?** | callflow migrate max worker | [optional] 
**MinMessageSize** | **int?** | callflow minimum message size | [optional] 
**SaveAfterNotify** | **bool?** | callflow save after notify | [optional] [default to false]
**SeekDurationMs** | **int?** | callflow fastforward and rewind seek duration | [optional] 
**VmMessageForwardType** | **string** | Enable or disable the ability to prepend a message when forwarding a voicemail message | [optional] [default to VmMessageForwardTypeEnum.Onlyforward]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

