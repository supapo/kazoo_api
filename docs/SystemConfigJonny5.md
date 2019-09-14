# IO.Swagger.Model.SystemConfigJonny5
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CheckServiceStanding** | **bool?** | jonny5 check_service_standing | [optional] [default to true]
**DefaultAllowPostpay** | **bool?** | jonny5 default_allow_postpay | [optional] 
**DefaultInboundTrunks** | **int?** | jonny5 default inbound trunks | [optional] 
**DefaultMaxPostpayAmount** | **decimal?** | jonny5 default_max_postpay_amount | [optional] 
**DefaultTwowayTrunks** | **int?** | jonny5 default twoway trunks | [optional] 
**FlatRateBlacklist** | **string** | jonny5 flat rate blacklist | [optional] [default to "^\+1(684|264|268|242|246|441|284|345|767|809|829|849|473|671|876|664|670|787|939|869|758|784|721|868|649|340|900|800|888|877|866|855|844)\d{7}$"]
**FlatRateWhitelist** | **string** | jonny5 flat rate whitelist | [optional] [default to "^\+1\d{10}$"]
**ResourceFlatRateLookup** | **bool?** | lookup flat rate regexps per resource | [optional] [default to false]
**ServiceStandingCacheAcceptable** | **bool?** | jonny5 service_standing_cache_acceptable | [optional] [default to true]
**ServiceStandingCacheExpirationS** | **int?** | jonny5 service_standing_cache_expiration_s | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

