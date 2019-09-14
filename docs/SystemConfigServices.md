# IO.Swagger.Model.SystemConfigServices
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CascadeCommitsToMasterAccount** | **bool?** | services cascade_commits_to_master_account | [optional] [default to true]
**DebugServicesQuantities** | **bool?** | services debug_services_quantities | [optional] [default to false]
**DefaultAllowUpdates** | **bool?** | services default allow updates | [optional] [default to true]
**EnforceGoodStanding** | **bool?** | services enforce_good_standing | [optional] [default to false]
**GetItemsFromQuantities** | **bool?** | services get_items_from_quantities | [optional] 
**HydrateCascadeCommits** | **bool?** | When an account makes a change it triggers a propagation up the account hiearchy updating the cascade quantities, if this is set to false the cascade quantities are summed with the account update deltas.  If this is set to true then the views will be invoked to fully reconcile the quantities (hydrate) during the cascade commits, a more expensive DB operation but provides self-corrective quantities. | [optional] [default to true]
**MasterAccountBookkeeper** | **string** | services master account bookkeeper | [optional] [default to "kz_bookkeeper_local"]
**MergeStrategyPriority** | **Object** | the object keys map to merge strategies and the values are expected to be an integer defining the merge priority between strategies | [optional] 
**Modules** | **List&lt;string&gt;** | services modules | [optional] 
**ResellerBookkeeperLookup** | **bool?** | allow resellers configure bookkeeper for children billing | [optional] [default to false]
**ScanRate** | **int?** | services scan rate | [optional] 
**ShouldSaveMasterAuditLogs** | **bool?** | services should save master audit logs | [optional] [default to false]
**SupportBillingId** | **bool?** | services support billing id | [optional] [default to true]
**SyncBufferPeriod** | **int?** | services sync buffer period | [optional] 
**SyncServices** | **bool?** | services sync services | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

