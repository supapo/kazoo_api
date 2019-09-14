# IO.Swagger.Model.Clicktocall
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AuthRequired** | **bool?** | Determines if this click to call requires valid auth-tokens when invoked | [optional] [default to true]
**BypassMedia** | **Object** | Default bypass media mode (The string type is deprecated, please use this as a boolean) | [optional] 
**CallerIdNumber** | **string** | Explicitly set caller id number | [optional] 
**CustomApplicationVars** | **Object** | Key-value pairs to set as custom_application_vars on the channel | [optional] 
**CustomSipHeaders** | **Object** | A property list of SIP headers | [optional] 
**DialFirst** | **string** | Determines what will be dialed first: extension or contact | [optional] 
**Extension** | **string** | The extension to connect to when the click to call is invoked | 
**Media** | [**ClicktocallMedia**](ClicktocallMedia.md) |  | [optional] 
**MusicOnHold** | [**ClicktocallMusicOnHold**](ClicktocallMusicOnHold.md) |  | [optional] 
**Name** | **string** | A friendly name for the click to call | 
**OutboundCalleeIdName** | **string** | Callee ID Name of the device calling out to the contact number | [optional] 
**OutboundCalleeIdNumber** | **string** | Callee ID Number of the device calling out to the contact number | [optional] 
**PresenceId** | **string** | Static presence ID (used instead of SIP username) | [optional] 
**Ringback** | **string** | Ringback to use | [optional] 
**Throttle** | **int?** | The rate that this click to call can be invoked | [optional] 
**Timeout** | **int?** | How long, in seconds, to wait for the call to progress | [optional] 
**Whitelist** | **List&lt;string&gt;** | A list of regular expressions that the click to call can dial to | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

