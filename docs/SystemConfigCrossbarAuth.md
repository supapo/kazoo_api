# IO.Swagger.Model.SystemConfigCrossbarAuth
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AuthModules** | [**AccountConfigCrossbarAuthAuthModules**](AccountConfigCrossbarAuthAuthModules.md) |  | [optional] 
**AvailableAuthMethods** | **List&lt;string&gt;** | List of crossbar auth configurable modules | [optional] 
**BasicAuthType** | **string** | crossbar.auth basic auth type | [optional] [default to BasicAuthTypeEnum.Md5]
**LogFailedAttempts** | **bool?** | Should log failed login attempts | [optional] [default to false]
**LogFailedLoginAttempts** | **bool?** | Should log failed login attempts | [optional] [default to false]
**LogSuccessfulAttempts** | **bool?** | Should log successful login attempts | [optional] [default to false]
**TokenAuthExpiryS** | **int?** | crossbar token auth expiry in seconds | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

