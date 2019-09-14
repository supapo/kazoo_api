# IO.Swagger.Model.Faxbox
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Attempts** | **int?** | The number of attempts made, this will be set by the system and reset automatically on put/post | [optional] 
**CallerId** | **string** | The Caller-ID-Number | [optional] 
**CallerName** | **string** | The Caller-ID-Name | [optional] [default to "Kazoo Fax Printer"]
**CustomSmtpEmailAddress** | **string** | custom smtp address | [optional] 
**FaxHeader** | **string** | The name printed at the top of the fax | [optional] [default to "Kazoo Fax Printer"]
**FaxIdentity** | **string** | The number printed at the top of the fax | [optional] 
**FaxTimezone** | **string** | The timezone announced | [optional] 
**Flags** | **List&lt;string&gt;** | Flags set by external applications | [optional] 
**Media** | [**FaxboxMedia**](FaxboxMedia.md) |  | [optional] 
**Name** | **string** | A friendly name for the faxbox | 
**Notifications** | [**FaxboxNotifications**](FaxboxNotifications.md) |  | [optional] 
**Retries** | **int?** | The number of times to retry | [optional] 
**SmtpPermissionList** | **List&lt;string&gt;** | smtp permission list. accepts regular expressions | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

