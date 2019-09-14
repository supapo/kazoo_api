# IO.Swagger.Model.Menus
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowRecordFromOffnet** | **bool?** | Determines if the record pin can be used by external calls | [optional] [default to false]
**Flags** | **List&lt;string&gt;** | Flags set by external applications | [optional] 
**Hunt** | **bool?** | Determines if the callers can dial internal extensions directly | [optional] [default to true]
**HuntAllow** | **string** | A regular expression that an extension the caller dialed must match to be allowed to continue | [optional] 
**HuntDeny** | **string** | A regular expression that if matched does not allow the caller to dial directly | [optional] 
**InterdigitTimeout** | **int?** | The amount of time (in milliseconds) to wait for the caller to press the next digit after pressing a digit | [optional] 
**MaxExtensionLength** | **int?** | The maximum number of digits that can be collected | [optional] 
**Media** | [**MenusMedia**](MenusMedia.md) |  | [optional] 
**Name** | **string** | A friendly name for the menu | 
**RecordPin** | **string** | The pin number used to record the menu prompt | [optional] 
**Retries** | **int?** | The number of times a menu should be played until a valid entry is collected | [optional] 
**SuppressMedia** | **bool?** | Determines if the playing of &#39;Invalid Entry&#39; is suppressed. | [optional] [default to false]
**Timeout** | **int?** | The amount of time (in milliseconds) to wait for the caller to begin entering digits | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

