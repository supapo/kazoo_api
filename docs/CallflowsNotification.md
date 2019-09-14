# IO.Swagger.Model.CallflowsNotification
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Comments** | **string** | Text message that need to include into notification | [optional] 
**NotificationMedia** | **List&lt;string&gt;** | What is media need to use for notification | [optional] 
**Recipients** | [**List&lt;CallflowsMissedCallAlertRecipients&gt;**](CallflowsMissedCallAlertRecipients.md) | One or more specific email addresses, Kazoo user ids or a combination of both | 
**SendAt** | **string** | Defines when send customer defined notification. For &#x60;callflow_exec&#x60; value notifications is send during callflow execution. For &#x60;channel_destroy&#x60; value notification is send after channel(bridge) is destroyed | [optional] [default to SendAtEnum.Channeldestroy]
**TemplateId** | **string** | Template ID of account defined notification | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

