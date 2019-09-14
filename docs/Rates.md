# IO.Swagger.Model.Rates
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountId** | **string** | Reseller&#39;s account ID | [optional] 
**CallerIdNumbers** | **string** | String of caller id prefixes separated by &#39;:&#39; | [optional] 
**Carrier** | **string** | Friendly name for the carrier providing this rate | [optional] 
**Description** | **string** | Friendly description of the rate | [optional] 
**Direction** | **List&lt;string&gt;** | Apply this rate based on the direction of the call (relative to FreeSWITCH) | [optional] 
**InternalRateCost** | **decimal?** | The per-min rate charged by the upstream provider | [optional] 
**IsoCountryCode** | **string** | Country code this rate applies to | [optional] 
**Options** | **List&lt;string&gt;** | List of options this rate is good for, to be matched against a customer&#39;s options | [optional] 
**Prefix** | **int?** | E.164 prefix (ignoring the +) | 
**RateCost** | **decimal?** | The per-min rate charged to the downstream customer | 
**RateIncrement** | **int?** | The time slice, in seconds, to bill in. | [optional] 
**RateMinimum** | **int?** | The minimum time slice, in seconds to bill a call | [optional] 
**RateName** | **string** | Friendly name of the rate | [optional] 
**RateNochargeTime** | **int?** | If the call duration is shorter than this threshold (seconds), the call is not billed | [optional] 
**RateSuffix** | **string** | Suffix applied to rate name | [optional] 
**RateSurcharge** | **decimal?** | The upfront cost of connecting the call | [optional] 
**RateVersion** | **string** | Rate version | [optional] 
**RatedeckId** | **string** | ID of the ratedeck this rate belongs to | [optional] 
**Routes** | **List&lt;string&gt;** | List of regexps that match valid DIDs for this rate | [optional] 
**Weight** | **int?** | Ordering against other rates, 1 being most preferred, 100 being least preferred | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

