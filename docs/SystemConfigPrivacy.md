# IO.Swagger.Model.SystemConfigPrivacy
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AnonymousCidNames** | **List&lt;string&gt;** | Additional CID name patterns to match for anonymous call rejection | [optional] 
**AnonymousCidNumbers** | **List&lt;string&gt;** | Additional CID number/userpart patterns to match for anonymous call rejection | [optional] 
**BlockAnonymousCallerId** | **bool?** | Controls blocking of anonymous calls | [optional] [default to false]
**CheckAdditionalAnonymousCidNames** | **bool?** | use the anonymous_cid_names values to check if a number is anonymous | [optional] [default to false]
**CheckAdditionalAnonymousCidNumbers** | **bool?** | use the anonymous_cid_numbers values to check if a name is anonymous | [optional] [default to false]
**DefaultPrivacyName** | **string** | privacy default_privacy_name | [optional] [default to "Anonymous"]
**DefaultPrivacyNumber** | **string** | privacy default_privacy_number | [optional] [default to "anonymous"]
**Method** | **string** | privacy method | [optional] [default to "kazoo"]
**PrivacyMode** | **string** | Default privacy mode for anonymous calls | [optional] [default to "kazoo"]
**PrivacyName** | **string** | Default Caller ID Name should be shown for anonymous calls | [optional] [default to "anonymous"]
**PrivacyNumber** | **string** | Default Caller ID Number should be shown for anonymous calls | [optional] [default to "0000000000"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

