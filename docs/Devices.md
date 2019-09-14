# IO.Swagger.Model.Devices
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CallForward** | [**DevicesCallForward**](DevicesCallForward.md) |  | [optional] 
**CallRecording** | [**CallRecording**](CallRecording.md) |  | [optional] 
**CallRestriction** | [**Dictionary&lt;string, AccountsCallRestriction&gt;**](AccountsCallRestriction.md) | Device level call restrictions for each available number classification | [optional] 
**CallWaiting** | [**CallWaiting**](CallWaiting.md) |  | [optional] 
**CallerId** | [**CallerId**](CallerId.md) | The device caller ID parameters | [optional] 
**CallerIdOptions** | [**DevicesCallerIdOptions**](DevicesCallerIdOptions.md) |  | [optional] 
**ContactList** | [**DevicesContactList**](DevicesContactList.md) |  | [optional] 
**DeviceType** | **string** | Arbitrary device type used by the UI and billing system | [optional] 
**DialPlan** | [**Dialplans**](Dialplans.md) | A list of rules used to modify dialed numbers | [optional] 
**DoNotDisturb** | [**DevicesDoNotDisturb**](DevicesDoNotDisturb.md) |  | [optional] 
**Enabled** | **bool?** | Determines if the device is currently enabled | [optional] [default to true]
**ExcludeFromQueues** | **bool?** | Do not ring this device when calling user/agent in queue | [optional] [default to false]
**Flags** | **List&lt;string&gt;** | Flags set by external applications | [optional] 
**Formatters** | [**Formatters**](Formatters.md) |  | [optional] 
**Hotdesk** | [**DevicesHotdesk**](DevicesHotdesk.md) |  | [optional] 
**Language** | **string** | The language for the device | [optional] 
**MacAddress** | **string** | The MAC Address of the device (if applicable) | [optional] 
**Media** | [**EndpointMedia**](EndpointMedia.md) | Configure audio/video/etc media options for this device | [optional] 
**Metaflows** | [**Metaflows**](Metaflows.md) | The device metaflow parameters | [optional] 
**MusicOnHold** | [**ClicktocallMusicOnHold**](ClicktocallMusicOnHold.md) |  | [optional] 
**MwiUnsolicitedUpdates** | **bool?** | When true enables unsolicited mwi notifications | [optional] [default to true]
**Name** | **string** | A friendly name for the device | 
**OutboundFlags** | **Object** | List of flags (features) this device requires when making outbound calls | [optional] 
**OwnerId** | **string** | The ID of the user object that &#39;owns&#39; the device | [optional] 
**PresenceId** | **string** | Static presence ID (used instead of SIP username) | [optional] 
**Provision** | [**DevicesProvision**](DevicesProvision.md) |  | [optional] 
**RegisterOverwriteNotify** | **bool?** | When true enables overwrite notifications | [optional] [default to false]
**Ringtones** | [**AccountsRingtones**](AccountsRingtones.md) |  | [optional] 
**Sip** | [**DevicesSip**](DevicesSip.md) |  | [optional] 
**SuppressUnregisterNotifications** | **bool?** | When true disables deregister notifications | [optional] [default to false]
**Timezone** | **string** | Device&#39;s timezone | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

