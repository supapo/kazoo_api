# IO.Swagger.Model.SystemConfigCallflow
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowAuthzContextOverrides** | **bool?** | callflow allow_authz_context_overrides | [optional] [default to false]
**AuthzContexts** | **List&lt;string&gt;** | callflow authz_contexts | [optional] 
**CallRecording** | [**SystemConfigCallflowCallRecording**](SystemConfigCallflowCallRecording.md) |  | [optional] 
**CallsConsumeTokens** | **bool?** | callflow calls consume tokens | [optional] [default to true]
**DefaultPinLength** | **int?** | callflow default pin length | [optional] 
**DefaultUseAccountCallerId** | **bool?** | callflow default use account caller id | [optional] [default to true]
**DialogSubscribedMwiPrefix** | **string** | callflow dialog_subscribed_mwi_prefix | [optional] 
**EnsureValidCallerId** | **bool?** | callflow ensure valid caller id | [optional] [default to false]
**FaxDetectDurationS** | **int?** | callflow fax detect duration in seconds | [optional] 
**MaxBranchCount** | **int?** | callflow maximum branch count | [optional] 
**MinBucketCost** | **int?** | callflow minimum bucket cost | [optional] 
**MwiSendUnsolicitedUpdates** | **bool?** | callflow mwi send unsolicited updates | [optional] [default to true]
**OperatorKey** | **string** | callflow operator key | [optional] [default to "0"]
**PoolOverflow** | **int?** | callflow pool_overflow | [optional] 
**PoolServerConfirms** | **bool?** | callflow pool_server_confirms | [optional] [default to false]
**PoolSize** | **int?** | callflow pool_size | [optional] 
**PoolThreshold** | **int?** | callflow pool_threshold | [optional] 
**PostAnswerDelay** | **int?** | callflow post answer delay | [optional] 
**RingReadyOffnet** | **bool?** | callflow ring ready offnet | [optional] [default to true]
**RouteWinTimeout** | **int?** | callflow route win timeout | [optional] 
**ShouldDryRunTokenRestrictions** | **bool?** | callflow should_dry_run_token_restrictions | [optional] [default to false]
**SingularCallHookUrl** | **string** | callflow singular call hook url | [optional] [default to ""]
**Voicemail** | [**SystemConfigCallflowVoicemail**](SystemConfigCallflowVoicemail.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

