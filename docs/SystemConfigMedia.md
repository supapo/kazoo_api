# IO.Swagger.Model.SystemConfigMedia
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AuthenticatedPlayback** | **bool?** | media authenticated playback | [optional] [default to false]
**AuthenticatedStore** | **bool?** | media authenticated store | [optional] [default to true]
**CallRecording** | [**AccountConfigMediaCallRecording**](AccountConfigMediaCallRecording.md) |  | [optional] 
**DefaultLanguage** | **string** | media default language | [optional] 
**DistributedProxy** | **Object** | media distributed_proxy | [optional] 
**FixMediaNames** | **bool?** | media fix media names | [optional] [default to true]
**MaxRecordingTimeLimit** | **int?** | media maximum recording time limit | [optional] 
**NormalizeDestinationArgs** | **string** | media normalize destination args | [optional] [default to "-r 8000"]
**NormalizeExecutable** | **string** | media normalize executable | [optional] [default to "sox"]
**NormalizeSourceArgs** | **string** | media normalize source args | [optional] [default to ""]
**ProxyHostname** | **string** | media proxy hostname to be used with HAProxy | [optional] 
**ProxyIp** | **string** | media proxy ip | [optional] 
**ProxyListeners** | **int?** | media proxy listeners | [optional] 
**ProxyPassword** | **string** | media proxy password | [optional] [default to ""]
**ProxyPort** | **int?** | media proxy port | [optional] 
**ProxyStoreAcls** | **List&lt;string&gt;** | media proxy store acls | [optional] 
**ProxyStoreAuthenticate** | **bool?** | media proxy store authenticate | [optional] [default to true]
**ProxyUsername** | **string** | media proxy username | [optional] [default to ""]
**RecordMinSec** | **int?** | media record minimum sec | [optional] 
**SslCert** | **string** | media ssl cert | [optional] 
**SslKey** | **string** | media ssl key | [optional] 
**SslPassword** | **string** | media ssl password | [optional] [default to ""]
**SslPort** | **int?** | media ssl port | [optional] 
**StoreRecordings** | **bool?** | media store recordings | [optional] [default to false]
**SupportAccountOverrides** | **bool?** | media support account overrides | [optional] [default to true]
**UseHttps** | **bool?** | media use https | [optional] [default to false]
**UsePlaintext** | **bool?** | media use plaintext | [optional] [default to true]
**UseSslProxy** | **bool?** | media use ssl proxy | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

