# IO.Swagger.Model.ResourcesGateways
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BypassMedia** | **bool?** | The resource gateway bypass media mode | [optional] 
**CallerIdType** | **string** | The type of caller id to use | [optional] 
**ChannelSelection** | **string** | Automatic selection of the channel within the span: ascending starts at 1 and moves up; descending is the opposite | [optional] [default to ChannelSelectionEnum.Ascending]
**Codecs** | **List&lt;string&gt;** | A list of single list codecs supported by this gateway (to support backward compatibility) | [optional] 
**CustomSipHeaders** | **Object** | A property list of SIP headers | [optional] 
**CustomSipInterface** | **string** | The name of a custom SIP interface | [optional] 
**Enabled** | **bool?** | Determines if the resource gateway is currently enabled | [optional] [default to true]
**EndpointType** | **string** | What type of endpoint is this gateway | [optional] [default to EndpointTypeEnum.Sip]
**ForcePort** | **bool?** | Allow request only from this port | [optional] [default to false]
**FormatFromUri** | **bool?** | When set to true requests to this resource gateway will have a reformatted SIP From Header | [optional] 
**FromUriRealm** | **string** | When formatting SIP From on outbound requests this can be used to override the realm | [optional] 
**InviteFormat** | **string** | The format of the DID needed by the underlying hardware/gateway | [optional] [default to InviteFormatEnum.Route]
**InviteParameters** | [**ResourcesInviteParameters**](ResourcesInviteParameters.md) |  | [optional] 
**Media** | [**ResourcesMedia**](ResourcesMedia.md) |  | [optional] 
**Password** | **string** | SIP authentication password | [optional] 
**Port** | **int?** | This resource gateway port | [optional] 
**Prefix** | **string** | A string to prepend to the dialed number or capture group of the matching rule | [optional] 
**ProgressTimeout** | **int?** | The progress timeout to apply to the resource gateway | [optional] 
**Realm** | **string** | This resource gateway authentication realm | [optional] 
**Route** | **string** | A statically configured SIP URI to route all call to | [optional] 
**Server** | **string** | This resource gateway server | 
**SkypeInterface** | **string** | The name of the Skype interface to route the call over | [optional] 
**SkypeRr** | **bool?** | Determines whether to round-robin calls amongst all interfaces (overrides \&quot;skype_interface\&quot; setting) | [optional] [default to true]
**Span** | **string** | The identity of the hardware on the media server | [optional] 
**Suffix** | **string** | A string to append to the dialed number or capture group of the matching rule | [optional] 
**Username** | **string** | SIP authentication username | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

