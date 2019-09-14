/* 
 * Crossbar
 *
 * The Crossbar APIs
 *
 * OpenAPI spec version: v2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using IO.Swagger.Api;
using IO.Swagger.Model;
using IO.Swagger.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing KapiSmsMessage
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class KapiSmsMessageTests
    {
        // TODO uncomment below to declare an instance variable for KapiSmsMessage
        //private KapiSmsMessage instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of KapiSmsMessage
            //instance = new KapiSmsMessage();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of KapiSmsMessage
        /// </summary>
        [Test]
        public void KapiSmsMessageInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" KapiSmsMessage
            //Assert.IsInstanceOfType<KapiSmsMessage> (instance, "variable 'instance' is a KapiSmsMessage");
        }


        /// <summary>
        /// Test the property 'ApplicationData'
        /// </summary>
        [Test]
        public void ApplicationDataTest()
        {
            // TODO unit test for the property 'ApplicationData'
        }
        /// <summary>
        /// Test the property 'ApplicationName'
        /// </summary>
        [Test]
        public void ApplicationNameTest()
        {
            // TODO unit test for the property 'ApplicationName'
        }
        /// <summary>
        /// Test the property 'AssertedIdentityName'
        /// </summary>
        [Test]
        public void AssertedIdentityNameTest()
        {
            // TODO unit test for the property 'AssertedIdentityName'
        }
        /// <summary>
        /// Test the property 'AssertedIdentityNumber'
        /// </summary>
        [Test]
        public void AssertedIdentityNumberTest()
        {
            // TODO unit test for the property 'AssertedIdentityNumber'
        }
        /// <summary>
        /// Test the property 'AssertedIdentityRealm'
        /// </summary>
        [Test]
        public void AssertedIdentityRealmTest()
        {
            // TODO unit test for the property 'AssertedIdentityRealm'
        }
        /// <summary>
        /// Test the property 'BLegEvents'
        /// </summary>
        [Test]
        public void BLegEventsTest()
        {
            // TODO unit test for the property 'BLegEvents'
        }
        /// <summary>
        /// Test the property 'Body'
        /// </summary>
        [Test]
        public void BodyTest()
        {
            // TODO unit test for the property 'Body'
        }
        /// <summary>
        /// Test the property 'BridgeActions'
        /// </summary>
        [Test]
        public void BridgeActionsTest()
        {
            // TODO unit test for the property 'BridgeActions'
        }
        /// <summary>
        /// Test the property 'CallID'
        /// </summary>
        [Test]
        public void CallIDTest()
        {
            // TODO unit test for the property 'CallID'
        }
        /// <summary>
        /// Test the property 'CalleeIDName'
        /// </summary>
        [Test]
        public void CalleeIDNameTest()
        {
            // TODO unit test for the property 'CalleeIDName'
        }
        /// <summary>
        /// Test the property 'CalleeIDNumber'
        /// </summary>
        [Test]
        public void CalleeIDNumberTest()
        {
            // TODO unit test for the property 'CalleeIDNumber'
        }
        /// <summary>
        /// Test the property 'CallerIDName'
        /// </summary>
        [Test]
        public void CallerIDNameTest()
        {
            // TODO unit test for the property 'CallerIDName'
        }
        /// <summary>
        /// Test the property 'CallerIDNumber'
        /// </summary>
        [Test]
        public void CallerIDNumberTest()
        {
            // TODO unit test for the property 'CallerIDNumber'
        }
        /// <summary>
        /// Test the property 'ConfirmCancelTimeout'
        /// </summary>
        [Test]
        public void ConfirmCancelTimeoutTest()
        {
            // TODO unit test for the property 'ConfirmCancelTimeout'
        }
        /// <summary>
        /// Test the property 'ConfirmFile'
        /// </summary>
        [Test]
        public void ConfirmFileTest()
        {
            // TODO unit test for the property 'ConfirmFile'
        }
        /// <summary>
        /// Test the property 'ConfirmKey'
        /// </summary>
        [Test]
        public void ConfirmKeyTest()
        {
            // TODO unit test for the property 'ConfirmKey'
        }
        /// <summary>
        /// Test the property 'ContinueAfter'
        /// </summary>
        [Test]
        public void ContinueAfterTest()
        {
            // TODO unit test for the property 'ContinueAfter'
        }
        /// <summary>
        /// Test the property 'ContinueOnFail'
        /// </summary>
        [Test]
        public void ContinueOnFailTest()
        {
            // TODO unit test for the property 'ContinueOnFail'
        }
        /// <summary>
        /// Test the property 'CustomApplicationVars'
        /// </summary>
        [Test]
        public void CustomApplicationVarsTest()
        {
            // TODO unit test for the property 'CustomApplicationVars'
        }
        /// <summary>
        /// Test the property 'CustomChannelVars'
        /// </summary>
        [Test]
        public void CustomChannelVarsTest()
        {
            // TODO unit test for the property 'CustomChannelVars'
        }
        /// <summary>
        /// Test the property 'CustomSIPHeaders'
        /// </summary>
        [Test]
        public void CustomSIPHeadersTest()
        {
            // TODO unit test for the property 'CustomSIPHeaders'
        }
        /// <summary>
        /// Test the property 'DialEndpointMethod'
        /// </summary>
        [Test]
        public void DialEndpointMethodTest()
        {
            // TODO unit test for the property 'DialEndpointMethod'
        }
        /// <summary>
        /// Test the property 'EnableT38Fax'
        /// </summary>
        [Test]
        public void EnableT38FaxTest()
        {
            // TODO unit test for the property 'EnableT38Fax'
        }
        /// <summary>
        /// Test the property 'EnableT38FaxRequest'
        /// </summary>
        [Test]
        public void EnableT38FaxRequestTest()
        {
            // TODO unit test for the property 'EnableT38FaxRequest'
        }
        /// <summary>
        /// Test the property 'EnableT38Gateway'
        /// </summary>
        [Test]
        public void EnableT38GatewayTest()
        {
            // TODO unit test for the property 'EnableT38Gateway'
        }
        /// <summary>
        /// Test the property 'EnableT38Passthrough'
        /// </summary>
        [Test]
        public void EnableT38PassthroughTest()
        {
            // TODO unit test for the property 'EnableT38Passthrough'
        }
        /// <summary>
        /// Test the property 'Endpoints'
        /// </summary>
        [Test]
        public void EndpointsTest()
        {
            // TODO unit test for the property 'Endpoints'
        }
        /// <summary>
        /// Test the property 'EventCategory'
        /// </summary>
        [Test]
        public void EventCategoryTest()
        {
            // TODO unit test for the property 'EventCategory'
        }
        /// <summary>
        /// Test the property 'EventName'
        /// </summary>
        [Test]
        public void EventNameTest()
        {
            // TODO unit test for the property 'EventName'
        }
        /// <summary>
        /// Test the property 'ExportBridgeVariables'
        /// </summary>
        [Test]
        public void ExportBridgeVariablesTest()
        {
            // TODO unit test for the property 'ExportBridgeVariables'
        }
        /// <summary>
        /// Test the property 'ExportVariables'
        /// </summary>
        [Test]
        public void ExportVariablesTest()
        {
            // TODO unit test for the property 'ExportVariables'
        }
        /// <summary>
        /// Test the property 'FailOnSingleReject'
        /// </summary>
        [Test]
        public void FailOnSingleRejectTest()
        {
            // TODO unit test for the property 'FailOnSingleReject'
        }
        /// <summary>
        /// Test the property 'ForceFax'
        /// </summary>
        [Test]
        public void ForceFaxTest()
        {
            // TODO unit test for the property 'ForceFax'
        }
        /// <summary>
        /// Test the property 'FromRealm'
        /// </summary>
        [Test]
        public void FromRealmTest()
        {
            // TODO unit test for the property 'FromRealm'
        }
        /// <summary>
        /// Test the property 'FromURI'
        /// </summary>
        [Test]
        public void FromURITest()
        {
            // TODO unit test for the property 'FromURI'
        }
        /// <summary>
        /// Test the property 'FromUser'
        /// </summary>
        [Test]
        public void FromUserTest()
        {
            // TODO unit test for the property 'FromUser'
        }
        /// <summary>
        /// Test the property 'HoldMedia'
        /// </summary>
        [Test]
        public void HoldMediaTest()
        {
            // TODO unit test for the property 'HoldMedia'
        }
        /// <summary>
        /// Test the property 'IgnoreCompletedElsewhere'
        /// </summary>
        [Test]
        public void IgnoreCompletedElsewhereTest()
        {
            // TODO unit test for the property 'IgnoreCompletedElsewhere'
        }
        /// <summary>
        /// Test the property 'IgnoreEarlyMedia'
        /// </summary>
        [Test]
        public void IgnoreEarlyMediaTest()
        {
            // TODO unit test for the property 'IgnoreEarlyMedia'
        }
        /// <summary>
        /// Test the property 'IgnoreForward'
        /// </summary>
        [Test]
        public void IgnoreForwardTest()
        {
            // TODO unit test for the property 'IgnoreForward'
        }
        /// <summary>
        /// Test the property 'InsertAt'
        /// </summary>
        [Test]
        public void InsertAtTest()
        {
            // TODO unit test for the property 'InsertAt'
        }
        /// <summary>
        /// Test the property 'LoopbackBowout'
        /// </summary>
        [Test]
        public void LoopbackBowoutTest()
        {
            // TODO unit test for the property 'LoopbackBowout'
        }
        /// <summary>
        /// Test the property 'Media'
        /// </summary>
        [Test]
        public void MediaTest()
        {
            // TODO unit test for the property 'Media'
        }
        /// <summary>
        /// Test the property 'MessageID'
        /// </summary>
        [Test]
        public void MessageIDTest()
        {
            // TODO unit test for the property 'MessageID'
        }
        /// <summary>
        /// Test the property 'OutboundCalleeIDName'
        /// </summary>
        [Test]
        public void OutboundCalleeIDNameTest()
        {
            // TODO unit test for the property 'OutboundCalleeIDName'
        }
        /// <summary>
        /// Test the property 'OutboundCalleeIDNumber'
        /// </summary>
        [Test]
        public void OutboundCalleeIDNumberTest()
        {
            // TODO unit test for the property 'OutboundCalleeIDNumber'
        }
        /// <summary>
        /// Test the property 'OutboundCallerIDName'
        /// </summary>
        [Test]
        public void OutboundCallerIDNameTest()
        {
            // TODO unit test for the property 'OutboundCallerIDName'
        }
        /// <summary>
        /// Test the property 'OutboundCallerIDNumber'
        /// </summary>
        [Test]
        public void OutboundCallerIDNumberTest()
        {
            // TODO unit test for the property 'OutboundCallerIDNumber'
        }
        /// <summary>
        /// Test the property 'PrivacyHideName'
        /// </summary>
        [Test]
        public void PrivacyHideNameTest()
        {
            // TODO unit test for the property 'PrivacyHideName'
        }
        /// <summary>
        /// Test the property 'PrivacyHideNumber'
        /// </summary>
        [Test]
        public void PrivacyHideNumberTest()
        {
            // TODO unit test for the property 'PrivacyHideNumber'
        }
        /// <summary>
        /// Test the property 'PrivacyMethod'
        /// </summary>
        [Test]
        public void PrivacyMethodTest()
        {
            // TODO unit test for the property 'PrivacyMethod'
        }
        /// <summary>
        /// Test the property 'Ringback'
        /// </summary>
        [Test]
        public void RingbackTest()
        {
            // TODO unit test for the property 'Ringback'
        }
        /// <summary>
        /// Test the property 'RouteID'
        /// </summary>
        [Test]
        public void RouteIDTest()
        {
            // TODO unit test for the property 'RouteID'
        }
        /// <summary>
        /// Test the property 'RouteType'
        /// </summary>
        [Test]
        public void RouteTypeTest()
        {
            // TODO unit test for the property 'RouteType'
        }
        /// <summary>
        /// Test the property 'SIPHeaders'
        /// </summary>
        [Test]
        public void SIPHeadersTest()
        {
            // TODO unit test for the property 'SIPHeaders'
        }
        /// <summary>
        /// Test the property 'SIPInviteParameters'
        /// </summary>
        [Test]
        public void SIPInviteParametersTest()
        {
            // TODO unit test for the property 'SIPInviteParameters'
        }
        /// <summary>
        /// Test the property 'SIPTransport'
        /// </summary>
        [Test]
        public void SIPTransportTest()
        {
            // TODO unit test for the property 'SIPTransport'
        }
        /// <summary>
        /// Test the property 'SecureRTP'
        /// </summary>
        [Test]
        public void SecureRTPTest()
        {
            // TODO unit test for the property 'SecureRTP'
        }
        /// <summary>
        /// Test the property 'SimplifyLoopback'
        /// </summary>
        [Test]
        public void SimplifyLoopbackTest()
        {
            // TODO unit test for the property 'SimplifyLoopback'
        }
        /// <summary>
        /// Test the property 'Timeout'
        /// </summary>
        [Test]
        public void TimeoutTest()
        {
            // TODO unit test for the property 'Timeout'
        }
        /// <summary>
        /// Test the property 'ToRealm'
        /// </summary>
        [Test]
        public void ToRealmTest()
        {
            // TODO unit test for the property 'ToRealm'
        }
        /// <summary>
        /// Test the property 'ToURI'
        /// </summary>
        [Test]
        public void ToURITest()
        {
            // TODO unit test for the property 'ToURI'
        }
        /// <summary>
        /// Test the property 'ToUser'
        /// </summary>
        [Test]
        public void ToUserTest()
        {
            // TODO unit test for the property 'ToUser'
        }

    }

}