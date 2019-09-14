# IO.Swagger.Model.SystemConfigStepswitch
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AssumeInboundE164** | **bool?** | stepswitch assume inbound destination DID is e164 format | [optional] [default to false]
**AssumeInboundOriginationE164** | **bool?** | stepswitch assume inbound origination DID is e164 format | [optional] [default to false]
**CidRulesHonorDiversions** | **bool?** | stepswitch cid rules honor diversions | [optional] [default to false]
**DefaultAudioCodecs** | **List&lt;string&gt;** | stepswitch default audio codecs | [optional] 
**DefaultBypassMedia** | **bool?** | stepswitch default bypass media | [optional] [default to false]
**DefaultCallerIdType** | **string** | stepswitch default caller id type | [optional] [default to "external"]
**DefaultCodecs** | **List&lt;string&gt;** | stepswitch default codecs | [optional] 
**DefaultEmergencyCidNumber** | **string** | stepswitch default emergency cid number | [optional] 
**DefaultFormatters** | [**List&lt;Formatters&gt;**](Formatters.md) | stepswitch default formatters | [optional] 
**DefaultPrefix** | **string** | stepswitch default prefix | [optional] [default to ""]
**DefaultProgressTimeout** | **int?** | stepswitch default progress timeout | [optional] 
**DefaultRoute** | **string** | stepswitch default route | [optional] 
**DefaultRtcpMux** | **string** | RTCP protocol messages mixed with RTP data | [optional] 
**DefaultSuffix** | **string** | stepswitch default suffix | [optional] [default to ""]
**DefaultVideoCodecs** | **List&lt;string&gt;** | stepswitch default video codecs | [optional] 
**DefaultWeight** | **int?** | stepswitch default weight | [optional] 
**DenyEmergencyBridgeCause** | **string** | stepswitch deny emergency bridge cause | [optional] [default to "Emergency service not configured"]
**DenyEmergencyBridgeCode** | **int?** | stepswitch deny emergency bridge code | [optional] 
**DenyEmergencyBridgeMedia** | **string** | stepswitch deny emergency bridge media | [optional] [default to "prompt://system_media/stepswitch-emergency_not_configured/"]
**DenyInvalidEmergencyCid** | **bool?** | stepswitch deny invalid emergency cid | [optional] [default to false]
**EnsureValidEmergencyCid** | **bool?** | stepswitch ensure valid emergency cid | [optional] [default to false]
**FixedLengthShortdialCorrection** | **int?** | stepswitch fixed_length_shortdial_correction | [optional] 
**FormatFromUri** | **bool?** | stepswitch format from uri | [optional] [default to false]
**InboundUserField** | **string** | stepswitch inbound destination user field | [optional] [default to "Request"]
**InboundUserOriginationField** | **string** | stepswitch inbound origination user field | [optional] [default to "From"]
**MaxShortdialCorrection** | **int?** | stepswitch maximum shortdial correction | [optional] 
**MinShortdialCorrection** | **int?** | stepswitch minimum shortdial correction | [optional] 
**RouteBy** | **string** | stepswitch route by | [optional] [default to "stepswitch_resources"]
**UseFirstDedicatedProxyOnly** | **bool?** | If gateways are generated for assigned dedicated IPs, only generate one for the first IP (usually local to the call). | [optional] [default to true]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

