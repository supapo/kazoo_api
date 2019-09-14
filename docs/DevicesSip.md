# IO.Swagger.Model.DevicesSip
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomSipHeaders** | **Object** | A property list of SIP headers | [optional] 
**ExpireSeconds** | **int?** | The time, in seconds, sent to the provisioner for the registration period that the device should be configured with. | [optional] 
**IgnoreCompletedElsewhere** | **bool?** | When set to false the phone should not consider ring group calls answered elsewhere as missed | [optional] 
**InviteFormat** | **string** | The SIP request URI invite format | [optional] [default to InviteFormatEnum.Contact]
**Ip** | **string** | IP address for this device | [optional] 
**Method** | **string** | Method of authentication | [optional] [default to MethodEnum.Password]
**Number** | **string** | The number used if the invite format is 1npan, npan, or e164 (if not set the dialed number is used) | [optional] 
**Password** | **string** | SIP authentication password | [optional] 
**Realm** | **string** | The realm this device should use, overriding the account realm. Should rarely be necessary. | [optional] 
**Route** | **string** | The SIP URL used if the invite format is &#39;route&#39; | [optional] 
**StaticRoute** | **string** | Sends all inbound calls to this string (instead of dialed number or username) | [optional] 
**Username** | **string** | SIP authentication username | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

