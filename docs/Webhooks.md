# IO.Swagger.Model.Webhooks
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomData** | **Dictionary&lt;string, string&gt;** | These properties will be added to the event and will overwrite existing values. | [optional] 
**Enabled** | **bool?** | Is the webhook enabled and running | [optional] [default to true]
**Format** | **string** | What Body format to use when sending the webhook. only valid for &#39;post&#39; &amp; &#39;put&#39; verbs | [optional] [default to FormatEnum.FormData]
**Hook** | **string** | The trigger event for a request being made to &#39;callback_uri&#39;. | 
**HttpVerb** | **string** | What HTTP method to use when contacting the server | [optional] [default to HttpVerbEnum.Post]
**IncludeInternalLegs** | **bool?** | Whether to filter out call legs that are internal to the system (loopback) | [optional] [default to true]
**IncludeSubaccounts** | **bool?** | Should the webhook be fired for subaccount events. | [optional] 
**Name** | **string** | A friendly name for the webhook | 
**Retries** | **int?** | Retry the request this many times (if it fails) | [optional] 
**Uri** | **string** | The 3rd party URI to call out to an event | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

