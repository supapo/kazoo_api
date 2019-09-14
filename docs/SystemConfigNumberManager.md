# IO.Swagger.Model.SystemConfigNumberManager
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowPortTransitionFromSubmittedToScheduled** | **bool?** | should number ports be allowed to transition from submitted to scheduled? | [optional] [default to false]
**AvailableModuleName** | **string** | default carrier module name to use when creating a number | [optional] [default to "knm_local"]
**CarrierModules** | **List&lt;string&gt;** | carrier modules to perform number search &amp; ordering from | [optional] 
**Classifiers** | **Object** | regular expressions &amp; billing names for numbers | [optional] 
**Converters** | **List&lt;string&gt;** | suffix for the KNM module to use for E164, NPAN and 1NPAN normalization of numbers | [optional] 
**DefaultForceOutbound** | **bool?** | should we &#39;force_outbound&#39; when this feature is not set on the number? | [optional] [default to false]
**E164Converters** | **Object** | regular expressions to convert numbers to E164 format | [optional] 
**Features** | [**SystemConfigNumberManagerFeatures**](SystemConfigNumberManagerFeatures.md) |  | [optional] 
**FetchAccountFromPorts** | **bool?** | should we also search ports when trying to &#x60;/identify&#x60; a number? | [optional] [default to true]
**ForceLocalOutbound** | **bool?** | default value for &#39;force_outbound&#39; for local numbers only | [optional] [default to true]
**ForcePortInOutbound** | **bool?** | default value for &#39;force_outbound&#39; for port_in numbers only | [optional] [default to true]
**ForcePortOutOutbound** | **bool?** | default value for &#39;force_outbound&#39; for port_out numbers only | [optional] [default to true]
**LocalFeatureOverride** | **bool?** | overrides the filtering of external features for local numbers | [optional] [default to false]
**MaximumSearchQuantity** | **int?** | maximum number of returned DIDs in a search query | [optional] 
**NumberSearchTimeoutMs** | **int?** | number manager number search timeout in milliseconds | [optional] 
**ParallelJobsCount** | **int?** | number of concurrent workers that can process a migration at the same time (1&#x3D;non parallel behavior, MUST be &gt;0) | [optional] 
**PortInModuleName** | **string** | completed port requests will create numbers with this carrier module name | [optional] [default to "knm_local"]
**Providers** | **List&lt;string&gt;** | legacy value for number_manager.features.allow | [optional] 
**ReconcileRegex** | **string** | if a number matches this regular expression then it is reconcilable | [optional] [default to "^(\+?1)?\d{10}$|^\+[2-9]\d{7,}$|^011\d*$|^00\d*$"]
**ReleasedState** | **string** | state to put numbers in when they are being released and their reserve history is empty | [optional] [default to "available"]
**ShouldAge** | **bool?** | Should numbers go through an aging period before being available? | [optional] [default to false]
**ShouldPermanentlyDelete** | **bool?** | when disconnecting numbers, if this flag is true they will be deleted otherwise they will go back to a pool. Local numbers are not affected by this flag | [optional] [default to false]
**TimeBetweenAccountsMs** | **int?** | time to pause in between the processing of accounts in milliseconds | [optional] 
**TimeBetweenDbMs** | **int?** | number_manager time_between_db_ms | [optional] 
**TimeBetweenNumbersMs** | **int?** | time to pause in between the processing of numbers in milliseconds | [optional] 
**UnauthorizedNumbersLookup** | **bool?** | should number search be allowed for unauthenticated API requests? | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

