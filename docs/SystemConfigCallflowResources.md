# IO.Swagger.Model.SystemConfigCallflowResources
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DefaultAssertedIdentity** | **bool?** | When set to true, the asserted identity will have defaults and force the use of P-Asserted-Identity (instead of RPID) on all outbound offnet calls.  When set to false, P-Asserted-Identity is only used if explicitly set in the account/user/device hierarchy. | [optional] [default to false]
**DefaultEmitAccountId** | **bool?** | When set to true, all outbound offnet calls will include a SIP header X-Account-ID with a value of the Kazoo account UUID. | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

