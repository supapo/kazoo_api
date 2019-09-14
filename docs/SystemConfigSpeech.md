# IO.Swagger.Model.SystemConfigSpeech
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AsrApiKey** | **string** | speech asr API key | [optional] [default to ""]
**AsrLocale** | **string** | speech asr default locale | [optional] [default to "en-us"]
**AsrMimeType** | **string** | speech asr mime type | [optional] [default to "application/wav"]
**AsrPreferredContentType** | **string** | speech asr preferred content type | [optional] [default to "application/wav"]
**AsrProvider** | **string** | speech asr provider | [optional] [default to "ispeech"]
**AsrUrl** | **string** | speech asr url | [optional] [default to "http://api.ispeech.org/api/json"]
**TemporaryStoragePath** | **string** | speech temporary storage path | [optional] [default to "/tmp"]
**TtsApiKey** | **string** | speech tts api key | [optional] [default to ""]
**TtsArgsEncode** | **string** | speech tts args encode | [optional] [default to "multipart"]
**TtsCache** | **int?** | How long, in milliseconds, to cache TTS media files | [optional] 
**TtsEndPadding** | **int?** | speech tts end padding | [optional] 
**TtsLanguage** | **string** | speech tts language | [optional] [default to "en-us"]
**TtsProvider** | **string** | speech tts provider | [optional] [default to "flite"]
**TtsSpeed** | **int?** | speech tts speed | [optional] 
**TtsStartPadding** | **int?** | speech tts start padding | [optional] 
**TtsUrlIspeech** | **string** | speech TTS URL for iSpeech provider | [optional] [default to "http://api.ispeech.org/api/json"]
**TtsUrlVoicefabric** | **string** | speech TTS URL for VoiceFabric provider | [optional] [default to "https://voicefabric.ru/WSServer/ws/tts"]
**TtsVoice** | **string** | speech tts voice | [optional] [default to "male"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

