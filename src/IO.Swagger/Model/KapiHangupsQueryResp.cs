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
    /// AMQP API for hangups.query_resp
    /// </summary>
    [DataContract]
    public partial class KapiHangupsQueryResp :  IEquatable<KapiHangupsQueryResp>, IValidatableObject
    {
        /// <summary>
        /// Defines EventCategory
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventCategoryEnum
        {
            
            /// <summary>
            /// Enum Hangups for value: hangups
            /// </summary>
            [EnumMember(Value = "hangups")]
            Hangups = 1
        }

        /// <summary>
        /// Gets or Sets EventCategory
        /// </summary>
        [DataMember(Name="Event-Category", EmitDefaultValue=false)]
        public EventCategoryEnum? EventCategory { get; set; }
        /// <summary>
        /// Defines EventName
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventNameEnum
        {
            
            /// <summary>
            /// Enum Queryresp for value: query_resp
            /// </summary>
            [EnumMember(Value = "query_resp")]
            Queryresp = 1
        }

        /// <summary>
        /// Gets or Sets EventName
        /// </summary>
        [DataMember(Name="Event-Name", EmitDefaultValue=false)]
        public EventNameEnum? EventName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapiHangupsQueryResp" /> class.
        /// </summary>
        /// <param name="eventCategory">eventCategory.</param>
        /// <param name="eventName">eventName.</param>
        /// <param name="accountId">accountId.</param>
        /// <param name="count">count.</param>
        /// <param name="day">day.</param>
        /// <param name="fifteen">fifteen.</param>
        /// <param name="five">five.</param>
        /// <param name="fiveToFifteen">fiveToFifteen.</param>
        /// <param name="hangupCause">hangupCause.</param>
        /// <param name="mean">mean.</param>
        /// <param name="meters">meters.</param>
        /// <param name="one">one.</param>
        /// <param name="oneToFifteen">oneToFifteen.</param>
        /// <param name="oneToFive">oneToFive.</param>
        /// <param name="startTime">startTime.</param>
        public KapiHangupsQueryResp(EventCategoryEnum? eventCategory = default(EventCategoryEnum?), EventNameEnum? eventName = default(EventNameEnum?), string accountId = default(string), string count = default(string), string day = default(string), string fifteen = default(string), string five = default(string), string fiveToFifteen = default(string), string hangupCause = default(string), string mean = default(string), string meters = default(string), string one = default(string), string oneToFifteen = default(string), string oneToFive = default(string), int? startTime = default(int?))
        {
            this.EventCategory = eventCategory;
            this.EventName = eventName;
            this.AccountId = accountId;
            this.Count = count;
            this.Day = day;
            this.Fifteen = fifteen;
            this.Five = five;
            this.FiveToFifteen = fiveToFifteen;
            this.HangupCause = hangupCause;
            this.Mean = mean;
            this.Meters = meters;
            this.One = one;
            this.OneToFifteen = oneToFifteen;
            this.OneToFive = oneToFive;
            this.StartTime = startTime;
        }
        


        /// <summary>
        /// Gets or Sets AccountId
        /// </summary>
        [DataMember(Name="account_id", EmitDefaultValue=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public string Count { get; set; }

        /// <summary>
        /// Gets or Sets Day
        /// </summary>
        [DataMember(Name="day", EmitDefaultValue=false)]
        public string Day { get; set; }

        /// <summary>
        /// Gets or Sets Fifteen
        /// </summary>
        [DataMember(Name="fifteen", EmitDefaultValue=false)]
        public string Fifteen { get; set; }

        /// <summary>
        /// Gets or Sets Five
        /// </summary>
        [DataMember(Name="five", EmitDefaultValue=false)]
        public string Five { get; set; }

        /// <summary>
        /// Gets or Sets FiveToFifteen
        /// </summary>
        [DataMember(Name="five_to_fifteen", EmitDefaultValue=false)]
        public string FiveToFifteen { get; set; }

        /// <summary>
        /// Gets or Sets HangupCause
        /// </summary>
        [DataMember(Name="hangup_cause", EmitDefaultValue=false)]
        public string HangupCause { get; set; }

        /// <summary>
        /// Gets or Sets Mean
        /// </summary>
        [DataMember(Name="mean", EmitDefaultValue=false)]
        public string Mean { get; set; }

        /// <summary>
        /// Gets or Sets Meters
        /// </summary>
        [DataMember(Name="meters", EmitDefaultValue=false)]
        public string Meters { get; set; }

        /// <summary>
        /// Gets or Sets One
        /// </summary>
        [DataMember(Name="one", EmitDefaultValue=false)]
        public string One { get; set; }

        /// <summary>
        /// Gets or Sets OneToFifteen
        /// </summary>
        [DataMember(Name="one_to_fifteen", EmitDefaultValue=false)]
        public string OneToFifteen { get; set; }

        /// <summary>
        /// Gets or Sets OneToFive
        /// </summary>
        [DataMember(Name="one_to_five", EmitDefaultValue=false)]
        public string OneToFive { get; set; }

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [DataMember(Name="start_time", EmitDefaultValue=false)]
        public int? StartTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KapiHangupsQueryResp {\n");
            sb.Append("  EventCategory: ").Append(EventCategory).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Day: ").Append(Day).Append("\n");
            sb.Append("  Fifteen: ").Append(Fifteen).Append("\n");
            sb.Append("  Five: ").Append(Five).Append("\n");
            sb.Append("  FiveToFifteen: ").Append(FiveToFifteen).Append("\n");
            sb.Append("  HangupCause: ").Append(HangupCause).Append("\n");
            sb.Append("  Mean: ").Append(Mean).Append("\n");
            sb.Append("  Meters: ").Append(Meters).Append("\n");
            sb.Append("  One: ").Append(One).Append("\n");
            sb.Append("  OneToFifteen: ").Append(OneToFifteen).Append("\n");
            sb.Append("  OneToFive: ").Append(OneToFive).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
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
            return this.Equals(input as KapiHangupsQueryResp);
        }

        /// <summary>
        /// Returns true if KapiHangupsQueryResp instances are equal
        /// </summary>
        /// <param name="input">Instance of KapiHangupsQueryResp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KapiHangupsQueryResp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EventCategory == input.EventCategory ||
                    (this.EventCategory != null &&
                    this.EventCategory.Equals(input.EventCategory))
                ) && 
                (
                    this.EventName == input.EventName ||
                    (this.EventName != null &&
                    this.EventName.Equals(input.EventName))
                ) && 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.Day == input.Day ||
                    (this.Day != null &&
                    this.Day.Equals(input.Day))
                ) && 
                (
                    this.Fifteen == input.Fifteen ||
                    (this.Fifteen != null &&
                    this.Fifteen.Equals(input.Fifteen))
                ) && 
                (
                    this.Five == input.Five ||
                    (this.Five != null &&
                    this.Five.Equals(input.Five))
                ) && 
                (
                    this.FiveToFifteen == input.FiveToFifteen ||
                    (this.FiveToFifteen != null &&
                    this.FiveToFifteen.Equals(input.FiveToFifteen))
                ) && 
                (
                    this.HangupCause == input.HangupCause ||
                    (this.HangupCause != null &&
                    this.HangupCause.Equals(input.HangupCause))
                ) && 
                (
                    this.Mean == input.Mean ||
                    (this.Mean != null &&
                    this.Mean.Equals(input.Mean))
                ) && 
                (
                    this.Meters == input.Meters ||
                    (this.Meters != null &&
                    this.Meters.Equals(input.Meters))
                ) && 
                (
                    this.One == input.One ||
                    (this.One != null &&
                    this.One.Equals(input.One))
                ) && 
                (
                    this.OneToFifteen == input.OneToFifteen ||
                    (this.OneToFifteen != null &&
                    this.OneToFifteen.Equals(input.OneToFifteen))
                ) && 
                (
                    this.OneToFive == input.OneToFive ||
                    (this.OneToFive != null &&
                    this.OneToFive.Equals(input.OneToFive))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
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
                if (this.EventCategory != null)
                    hashCode = hashCode * 59 + this.EventCategory.GetHashCode();
                if (this.EventName != null)
                    hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.AccountId != null)
                    hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.Day != null)
                    hashCode = hashCode * 59 + this.Day.GetHashCode();
                if (this.Fifteen != null)
                    hashCode = hashCode * 59 + this.Fifteen.GetHashCode();
                if (this.Five != null)
                    hashCode = hashCode * 59 + this.Five.GetHashCode();
                if (this.FiveToFifteen != null)
                    hashCode = hashCode * 59 + this.FiveToFifteen.GetHashCode();
                if (this.HangupCause != null)
                    hashCode = hashCode * 59 + this.HangupCause.GetHashCode();
                if (this.Mean != null)
                    hashCode = hashCode * 59 + this.Mean.GetHashCode();
                if (this.Meters != null)
                    hashCode = hashCode * 59 + this.Meters.GetHashCode();
                if (this.One != null)
                    hashCode = hashCode * 59 + this.One.GetHashCode();
                if (this.OneToFifteen != null)
                    hashCode = hashCode * 59 + this.OneToFifteen.GetHashCode();
                if (this.OneToFive != null)
                    hashCode = hashCode * 59 + this.OneToFive.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
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
