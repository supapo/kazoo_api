# IO.Swagger.Model.Directories
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConfirmMatch** | **bool?** | When one match is found, require caller to confirm the match before connecting | [optional] [default to true]
**Flags** | **List&lt;string&gt;** | Flags set by external applications | [optional] 
**MaxDtmf** | **int?** | Cap the number of DTMF characters collected from a caller, 0 for unlimited | [optional] 
**MinDtmf** | **int?** | How many DTMF characters to collect from a caller before processing the directory | [optional] 
**Name** | **string** | The name of the directory | 
**SortBy** | **string** | What field to sort on in matching documents when a caller enters characters | [optional] [default to SortByEnum.Lastname]
**Users** | **List&lt;string&gt;** | The list of users associated with this directory | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

