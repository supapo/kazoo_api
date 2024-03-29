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
    /// AMQP API for qubicle_session.join_queue
    /// </summary>
    [DataContract]
    public partial class KapiQubicleSessionJoinQueue :  IEquatable<KapiQubicleSessionJoinQueue>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiQubicleSessionJoinQueue" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KapiQubicleSessionJoinQueue() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiQubicleSessionJoinQueue" /> class.
        /// </summary>
        /// <param name="accountID">accountID (required).</param>
        /// <param name="call">call (required).</param>
        /// <param name="callID">callID (required).</param>
        /// <param name="joinQueueID">joinQueueID (required).</param>
        /// <param name="sessionID">sessionID (required).</param>
        public KapiQubicleSessionJoinQueue(string accountID = default(string), Object call = default(Object), string callID = default(string), string joinQueueID = default(string), string sessionID = default(string))
        {
            // to ensure "accountID" is required (not null)
            if (accountID == null)
            {
                throw new InvalidDataException("accountID is a required property for KapiQubicleSessionJoinQueue and cannot be null");
            }
            else
            {
                this.AccountID = accountID;
            }
            // to ensure "call" is required (not null)
            if (call == null)
            {
                throw new InvalidDataException("call is a required property for KapiQubicleSessionJoinQueue and cannot be null");
            }
            else
            {
                this.Call = call;
            }
            // to ensure "callID" is required (not null)
            if (callID == null)
            {
                throw new InvalidDataException("callID is a required property for KapiQubicleSessionJoinQueue and cannot be null");
            }
            else
            {
                this.CallID = callID;
            }
            // to ensure "joinQueueID" is required (not null)
            if (joinQueueID == null)
            {
                throw new InvalidDataException("joinQueueID is a required property for KapiQubicleSessionJoinQueue and cannot be null");
            }
            else
            {
                this.JoinQueueID = joinQueueID;
            }
            // to ensure "sessionID" is required (not null)
            if (sessionID == null)
            {
                throw new InvalidDataException("sessionID is a required property for KapiQubicleSessionJoinQueue and cannot be null");
            }
            else
            {
                this.SessionID = sessionID;
            }
        }
        
        /// <summary>
        /// Gets or Sets AccountID
        /// </summary>
        [DataMember(Name="Account-ID", EmitDefaultValue=false)]
        public string AccountID { get; set; }

        /// <summary>
        /// Gets or Sets Call
        /// </summary>
        [DataMember(Name="Call", EmitDefaultValue=false)]
        public Object Call { get; set; }

        /// <summary>
        /// Gets or Sets CallID
        /// </summary>
        [DataMember(Name="Call-ID", EmitDefaultValue=false)]
        public string CallID { get; set; }

        /// <summary>
        /// Gets or Sets JoinQueueID
        /// </summary>
        [DataMember(Name="Join-Queue-ID", EmitDefaultValue=false)]
        public string JoinQueueID { get; set; }

        /// <summary>
        /// Gets or Sets SessionID
        /// </summary>
        [DataMember(Name="Session-ID", EmitDefaultValue=false)]
        public string SessionID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KapiQubicleSessionJoinQueue {\n");
            sb.Append("  AccountID: ").Append(AccountID).Append("\n");
            sb.Append("  Call: ").Append(Call).Append("\n");
            sb.Append("  CallID: ").Append(CallID).Append("\n");
            sb.Append("  JoinQueueID: ").Append(JoinQueueID).Append("\n");
            sb.Append("  SessionID: ").Append(SessionID).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as KapiQubicleSessionJoinQueue);
        }

        /// <summary>
        /// Returns true if KapiQubicleSessionJoinQueue instances are equal
        /// </summary>
        /// <param name="input">Instance of KapiQubicleSessionJoinQueue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KapiQubicleSessionJoinQueue input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountID == input.AccountID ||
                    (this.AccountID != null &&
                    this.AccountID.Equals(input.AccountID))
                ) && 
                (
                    this.Call == input.Call ||
                    (this.Call != null &&
                    this.Call.Equals(input.Call))
                ) && 
                (
                    this.CallID == input.CallID ||
                    (this.CallID != null &&
                    this.CallID.Equals(input.CallID))
                ) && 
                (
                    this.JoinQueueID == input.JoinQueueID ||
                    (this.JoinQueueID != null &&
                    this.JoinQueueID.Equals(input.JoinQueueID))
                ) && 
                (
                    this.SessionID == input.SessionID ||
                    (this.SessionID != null &&
                    this.SessionID.Equals(input.SessionID))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AccountID != null)
                    hashCode = hashCode * 59 + this.AccountID.GetHashCode();
                if (this.Call != null)
                    hashCode = hashCode * 59 + this.Call.GetHashCode();
                if (this.CallID != null)
                    hashCode = hashCode * 59 + this.CallID.GetHashCode();
                if (this.JoinQueueID != null)
                    hashCode = hashCode * 59 + this.JoinQueueID.GetHashCode();
                if (this.SessionID != null)
                    hashCode = hashCode * 59 + this.SessionID.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
