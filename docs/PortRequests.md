# IO.Swagger.Model.PortRequests
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Bill** | [**PortRequestsBill**](PortRequestsBill.md) |  | [optional] 
**Comments** | [**List&lt;Comment&gt;**](Comment.md) | The history of comments made on a port request | [optional] 
**Name** | **string** | A friendly name for the port request | 
**Notifications** | [**PortRequestsNotifications**](PortRequestsNotifications.md) |  | [optional] 
**Numbers** | **Object** | The numbers to port in | 
**ReferenceNumber** | **string** | Winning carrier reference number or order ID | [optional] 
**SigneeName** | **string** | The name of the person authorizing the release of numbers from the losing carrier | [optional] 
**SigningDate** | **int?** | The date in Gregorian timestamp on which the document releasing the numbers from the losing carrier was signed | [optional] 
**TransferDate** | **int?** | Requested transfer date in Gregorian timestamp | [optional] 
**WinningCarrier** | **string** | The name of winning carrier | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

