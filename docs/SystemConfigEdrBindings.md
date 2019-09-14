# IO.Swagger.Model.SystemConfigEdrBindings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountId** | **Object** |  | [optional] 
**AppName** | **string** | Which apps should we receive events from? If not specified or * then events for all apps will be received | [optional] [default to "*"]
**ExactSeverity** | **bool?** | If true, then only events with severity exactly matching the severity field will be received. If false then more severe events will also be received | [optional] [default to false]
**ExactVerbosity** | **bool?** | If true, then only events with verbosity exactly matching the verbosity field will be received. If false then less verbose events will also be received | [optional] [default to false]
**IncludeDescendants** | **bool?** | Should we receive events relating to descendant accounts if an account is specified? | [optional] [default to false]
**Severity** | **Object** |  | [optional] 
**Verbosity** | **Object** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

