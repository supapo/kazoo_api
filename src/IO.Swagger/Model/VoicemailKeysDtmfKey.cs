/* 
 * Crossbar
 *
 * The Crossbar APIs
 *
 * OpenAPI spec version: v2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Defines voicemail_keys.dtmf_key
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum VoicemailKeysDtmfKey
    {
        
        /// <summary>
        /// Enum _1 for value: 1
        /// </summary>
        [EnumMember(Value = "1")]
        _1 = 1,
        
        /// <summary>
        /// Enum _2 for value: 2
        /// </summary>
        [EnumMember(Value = "2")]
        _2 = 2,
        
        /// <summary>
        /// Enum _3 for value: 3
        /// </summary>
        [EnumMember(Value = "3")]
        _3 = 3,
        
        /// <summary>
        /// Enum _4 for value: 4
        /// </summary>
        [EnumMember(Value = "4")]
        _4 = 4,
        
        /// <summary>
        /// Enum _5 for value: 5
        /// </summary>
        [EnumMember(Value = "5")]
        _5 = 5,
        
        /// <summary>
        /// Enum _6 for value: 6
        /// </summary>
        [EnumMember(Value = "6")]
        _6 = 6,
        
        /// <summary>
        /// Enum _7 for value: 7
        /// </summary>
        [EnumMember(Value = "7")]
        _7 = 7,
        
        /// <summary>
        /// Enum _8 for value: 8
        /// </summary>
        [EnumMember(Value = "8")]
        _8 = 8,
        
        /// <summary>
        /// Enum _9 for value: 9
        /// </summary>
        [EnumMember(Value = "9")]
        _9 = 9,
        
        /// <summary>
        /// Enum _0 for value: 0
        /// </summary>
        [EnumMember(Value = "0")]
        _0 = 10,
        
        /// <summary>
        /// Enum Star for value: *
        /// </summary>
        [EnumMember(Value = "*")]
        Star = 11,
        
        /// <summary>
        /// Enum Hash for value: #
        /// </summary>
        [EnumMember(Value = "#")]
        Hash = 12
    }

}