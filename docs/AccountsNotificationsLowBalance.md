# IO.Swagger.Model.AccountsNotificationsLowBalance
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **bool?** | should the account be checked for this alert | [optional] 
**LastNotification** | **int?** | Timestamp, in Gregorian seconds, of when the last low_balance alert was sent | [optional] 
**SentLowBalance** | **bool?** | has the alert been sent (avoids duplication/spamming) | [optional] 
**Threshold** | **decimal?** | account balance to send alert on | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

