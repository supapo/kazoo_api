# IO.Swagger.Model.SystemConfigHotornot
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DefaultRateCost** | **decimal?** | default cost per minute for rate | [optional] 
**DefaultRateIncrement** | **int?** | default increment time for rate | [optional] 
**DefaultRateInternalCost** | **decimal?** | default internal cost per minute for rate | [optional] 
**DefaultRateMinimum** | **int?** | default minimal duration for rate | [optional] 
**DefaultRateNochargeTime** | **int?** | default nocharge time for rate | [optional] 
**DefaultRateSurcharge** | **decimal?** | default surcharge amount for rate | [optional] 
**DefaultRatedeck** | **string** | default ratedeck database to use | [optional] [default to "ratedeck"]
**FilterList** | **List&lt;string&gt;** | List of filters for rates | [optional] 
**MobileRate** | **Object** | Object defining rate for Kazoo mobile | [optional] 
**RateVersion** | **string** | If defined, use rates with this version | [optional] 
**ShouldPublishSystemAlert** | [**SystemConfigHotornotShouldPublishSystemAlert**](SystemConfigHotornotShouldPublishSystemAlert.md) |  | [optional] 
**SortByWeight** | **bool?** | sort rates by weight (true) or cost (false) | [optional] [default to true]
**TrieBuildTimeoutMs** | **int?** | build timeout (ms) for trie | [optional] 
**TrieLruExpiresS** | **int?** | How long an entry in the LRU trie can remain | [optional] 
**TrieModule** | **string** | Which trie module to use | [optional] [default to "hon_trie"]
**UseTrie** | **bool?** | whether to use the trie to store rates in the VM | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

