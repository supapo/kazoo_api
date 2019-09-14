# IO.Swagger.Model.SystemConfigFax
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowAllAddressesWhenEmpty** | **bool?** | fax allow all addresses when empty | [optional] [default to false]
**AllowedContentTypes** | **List&lt;Object&gt;** | fax allowed content types | [optional] 
**CloudRegistrationPoolInterval** | **int?** | fax cloud registration pool interval | [optional] 
**DefaultCompareField** | **string** | fax default compare field | [optional] [default to "result_cause"]
**DefaultRetryCount** | **int?** | fax default retry count | [optional] 
**DefaultRetryPeriod** | **int?** | fax default retry period | [optional] 
**DefaultSmtpDomain** | **string** | fax default SMTP domain | [optional] [default to "fax.kazoo.io"]
**DeleteEmptyFaxes** | **bool?** | fax delete empty faxes | [optional] [default to false]
**DeniedContentTypes** | **List&lt;Object&gt;** | fax denied content types | [optional] 
**EndpointTimeout** | **int?** | fax endpoint timeout | [optional] 
**EnsureValidCallerId** | **bool?** | fax ensure valid caller id | [optional] [default to true]
**FaxFilePath** | **string** | fax fax file path | [optional] [default to "/tmp/"]
**FaxSettings** | **Object** | fax fax settings | [optional] 
**FileCachePath** | **string** | fax file cache path | [optional] [default to "/tmp/"]
**IgnoreEarlyMedia** | **bool?** | fax ignore early media | [optional] [default to false]
**ImageMinSize** | **string** | fax image minimum size | [optional] [default to "700x10"]
**ImageSizeCmdFormat** | **string** | fax image size cmd format | [optional] [default to "echo -n `identify -format "%[fx:w]x%[fx:h]" ~s`"]
**InboundT38Default** | **string** | fax inbound t38 default | [optional] [default to "true"]
**LogFaxboxErrors** | **bool?** | fax log faxbox errors | [optional] [default to true]
**MaxOutbound** | **int?** | fax max outbound | [optional] 
**MaxStorageRetry** | **int?** | fax maximum storage retry | [optional] 
**Port** | **int?** | fax port | [optional] 
**ReportAnonymousSystemErrors** | **bool?** | fax report anonymous system errors | [optional] [default to false]
**ReportFaxboxSystemErrors** | **bool?** | fax report faxbox system errors | [optional] [default to true]
**ReportSmtpErrors** | **bool?** | Report SMTP-related errors via notifications | [optional] [default to true]
**Reschedule** | **Object** | fax reschedule | [optional] 
**SerializeOutboundNumbers** | **bool?** | Serialize fax transmissions by outbound number globally | [optional] [default to true]
**SmtpMaxMsgSize** | **int?** | fax smtp maximum msg size | [optional] 
**SmtpPort** | **int?** | fax smtp port | [optional] 
**SmtpSessions** | **int?** | fax smtp sessions | [optional] 
**StoreFaxPdf** | **bool?** | store the post processed fax document | [optional] [default to true]
**StoreFaxTiff** | **bool?** | store a pdf copy of the post processed fax document | [optional] [default to true]
**StoreUrlDocument** | **bool?** | store the document url result in the database | [optional] [default to true]
**WaitForFaxTimeoutMs** | **int?** | fax wait for fax timeout in milliseconds | [optional] 
**Workers** | **int?** | fax workers | [optional] 
**XmppInterval** | **int?** | fax xmpp interval | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

