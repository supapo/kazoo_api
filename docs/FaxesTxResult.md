# IO.Swagger.Model.FaxesTxResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ErrorMessage** | **string** | A description of any error that occurred | [optional] [default to ""]
**FaxBadRows** | **int?** | The number of bad rows | [optional] 
**FaxErrorCorrection** | **bool?** | True if fax error correction was used | [optional] [default to false]
**FaxReceiverId** | **string** | The receiver id reported by the remote fax device | [optional] [default to ""]
**FaxSpeed** | **int?** | The speed (Baud-Rate) achieved during transmission | [optional] 
**PagesSent** | **int?** | The number of pages transmitted | [optional] 
**Success** | **bool?** | True if the fax transmission was successful | [optional] [default to false]
**TimeElapsed** | **int?** | The amount of time from submission to completion | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

