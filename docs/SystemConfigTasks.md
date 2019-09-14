# IO.Swagger.Model.SystemConfigTasks
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AgingExpiryD** | **int?** | tasks aging expiry in days | [optional] 
**AttemptUploadOutputTimes** | **int?** | how many times will the upload of the resulting CSV be attempted, cannot be zero | [optional] 
**BrowseDbsIntervalS** | **int?** | tasks browse dbs interval in seconds | [optional] 
**CrawlerDelayTimeMs** | **int?** | tasks crawler delay time in milliseconds | [optional] 
**CrawlerTimerMs** | **int?** | tasks crawler timer in milliseconds | [optional] 
**CycleDelayTimeMs** | **int?** | tasks cycle delay time in milliseconds | [optional] 
**DiscoveryExpiryD** | **int?** | tasks discovery expiry in days | [optional] 
**InteraccountDelayMs** | **int?** | tasks interaccount delay in milliseconds | [optional] 
**LowBalanceRepeatS** | **int?** | tasks low balance repeat in seconds | [optional] 
**PauseBetweenUploadOutputAttemptsS** | **int?** | the amount of time to pause between attempts to upload resulting CSV in seconds | [optional] 
**ScanRate** | **int?** | tasks scan_rate | [optional] 
**SendProgressAfterProcessed** | **int?** | tasks send progress after processed | [optional] 
**ShouldArchiveModbs** | **bool?** | tasks should archive modbs | [optional] [default to false]
**ShouldCrawlForFirstOccurrence** | **bool?** | tasks should crawl for first occurrence | [optional] [default to true]
**ShouldCrawlForLowBalance** | **bool?** | tasks should crawl for low balance | [optional] [default to true]
**SoftDeletePauseMs** | **int?** | tasks soft delete pause in milliseconds | [optional] 
**SupportBillingId** | **bool?** | tasks support_billing_id | [optional] [default to true]
**SyncBufferPeriod** | **int?** | tasks sync_buffer_period | [optional] 
**SyncServices** | **bool?** | tasks sync_services | [optional] [default to false]
**UnfinishedPortRequestLifetimeS** | **int?** | tasks unfinished port request lifetime in seconds | [optional] 
**WaitAfterRowMs** | **int?** | tasks wait after row in milliseconds | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

