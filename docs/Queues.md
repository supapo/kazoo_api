# IO.Swagger.Model.Queues
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AgentRingTimeout** | **int?** | In seconds, how long to ring an agent before progressing to the next agent available | [optional] 
**AgentWrapupTime** | **int?** | Pre-defined wait period applied after an agent handles a customer call | [optional] 
**Announce** | **string** | Media ID (or appropriate media URI) of media to play when caller is about to be connected. | [optional] 
**Announcements** | [**QueuesAnnouncements**](QueuesAnnouncements.md) |  | [optional] 
**CallerExitKey** | **string** | Key caller can press while on hold to exit the queue and continue in the callflow | [optional] [default to CallerExitKeyEnum.Hash]
**CdrUrl** | **string** | An optional HTTP URL to POST the CDR | [optional] 
**ConnectionTimeout** | **int?** | In seconds, how long to try to connect the caller before progressing past the queue callflow action | [optional] 
**EnterWhenEmpty** | **bool?** | Allows a caller to enter a queue and wait when no agents are available | [optional] [default to true]
**MaxPriority** | **int?** | Maximum possible priority level queue will support. Can not be redefined for existing queue. | [optional] 
**MaxQueueSize** | **int?** | How many callers are allowed to wait on hold in the queue (0 for no limit) | [optional] 
**Moh** | **string** | Media ID (or appropriate media URI) of media to play while caller is on hold. | [optional] 
**Name** | **string** | A friendly name for the queue | 
**RecordCaller** | **bool?** | When enabled, a caller&#39;s audio will be recorded | [optional] [default to false]
**RecordingUrl** | **string** | An optional HTTP URL to PUT the call recording after the call ends (and should respond to GET for retrieving the audio data) | [optional] 
**RingSimultaneously** | **int?** | The number of agents to try in parallel when connecting a caller | [optional] 
**Strategy** | **string** | The queue strategy for connecting agents to callers | [optional] [default to StrategyEnum.Roundrobin]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

