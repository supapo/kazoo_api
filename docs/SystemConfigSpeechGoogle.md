# IO.Swagger.Model.SystemConfigSpeechGoogle
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AsrApiKey** | **string** | API key for Google Cloud Speech | [default to ""]
**AsrEnableAutomaticPunctuation** | **bool?** | detect and insert punctuation in transcription results | [optional] [default to true]
**AsrEnableWordTimeOffsets** | **bool?** | top result includes a list of words and the start and end time offsets | [optional] 
**AsrModel** | **string** | model to select for the given request | [optional] [default to AsrModelEnum.Phonecall]
**AsrProfanityFilter** | **bool?** | server will attempt to filter out profanities, replacing all but the initial character in each filtered word with asterisk | [optional] 
**AsrUrl** | **string** | Google Cloud Speech API url | [optional] [default to "https://speech.googleapis.com/v1/speech:recognize"]
**AsrUseEnhanced** | **bool?** | use an enhanced model for speech recognition | [optional] [default to true]
**TtsApiKey** | **string** | speech google tts_api_key | [optional] [default to ""]
**TtsUrl** | **string** | speech google tts_url | [optional] [default to "https://texttospeech.googleapis.com/v1/text:synthesize"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

