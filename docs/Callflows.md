# IO.Swagger.Model.Callflows
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Featurecode** | [**CallflowsFeaturecode**](CallflowsFeaturecode.md) |  | [optional] 
**Flags** | **List&lt;string&gt;** | Flags set by external applications | [optional] 
**Flow** | [**CallflowsAction**](CallflowsAction.md) | A callflow node defines a module to execute, data to provide to that module, and zero or more children to branch to | [optional] 
**Metaflow** | [**Metaflows**](Metaflows.md) | Actions applied to a call outside of the normal callflow, initiated by the caller(s) | [optional] 
**Numbers** | **List&lt;string&gt;** | A list of static numbers that the callflow should execute for | [optional] 
**Patterns** | **List&lt;string&gt;** | A list of regular expressions that the callflow should execute for, with optional capture groups | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

