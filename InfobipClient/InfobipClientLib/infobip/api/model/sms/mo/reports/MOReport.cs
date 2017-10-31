using System.Collections.Generic;
using InfobipClient.infobip.api.model;
using Newtonsoft.Json;
using System;

namespace InfobipClient.infobip.api.model.sms.mo.reports
{
    /// <summary>
    /// This is a generated class and is not intended for modification!
    /// </summary>
    public class MOReport
    {
        [JsonProperty("cleanText")]
        public string CleanText { get; set; }

        [JsonProperty("smsCount")]
        public int SmsCount { get; set; }

        [JsonProperty("price")]
        public Price Price { get; set; }

        [JsonProperty("callbackData")]
        public string CallbackData { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("keyword")]
        public string Keyword { get; set; }

        [JsonProperty("receivedAt")]
        public DateTimeOffset ReceivedAt { get; set; }

        public override bool Equals(object obj)
        {
            var thisClass = obj as MOReport;
            return thisClass != null &&
                EqualityComparer<string>.Default.Equals(CleanText, thisClass.CleanText) &&
                EqualityComparer<int>.Default.Equals(SmsCount, thisClass.SmsCount) &&
                EqualityComparer<Price>.Default.Equals(Price, thisClass.Price) &&
                EqualityComparer<string>.Default.Equals(CallbackData, thisClass.CallbackData) &&
                EqualityComparer<string>.Default.Equals(MessageId, thisClass.MessageId) &&
                EqualityComparer<string>.Default.Equals(From, thisClass.From) &&
                EqualityComparer<string>.Default.Equals(To, thisClass.To) &&
                EqualityComparer<string>.Default.Equals(Text, thisClass.Text) &&
                EqualityComparer<string>.Default.Equals(Keyword, thisClass.Keyword) &&
                EqualityComparer<DateTimeOffset>.Default.Equals(ReceivedAt, thisClass.ReceivedAt);
        }

        public override int GetHashCode()
        {
            var hashCode = -1559463931;
            hashCode = hashCode * -1521134295 +  EqualityComparer<string>.Default.GetHashCode(CleanText);
            hashCode = hashCode * -1521134295 +  EqualityComparer<int>.Default.GetHashCode(SmsCount);
            hashCode = hashCode * -1521134295 +  EqualityComparer<Price>.Default.GetHashCode(Price);
            hashCode = hashCode * -1521134295 +  EqualityComparer<string>.Default.GetHashCode(CallbackData);
            hashCode = hashCode * -1521134295 +  EqualityComparer<string>.Default.GetHashCode(MessageId);
            hashCode = hashCode * -1521134295 +  EqualityComparer<string>.Default.GetHashCode(From);
            hashCode = hashCode * -1521134295 +  EqualityComparer<string>.Default.GetHashCode(To);
            hashCode = hashCode * -1521134295 +  EqualityComparer<string>.Default.GetHashCode(Text);
            hashCode = hashCode * -1521134295 +  EqualityComparer<string>.Default.GetHashCode(Keyword);
            hashCode = hashCode * -1521134295 +  EqualityComparer<DateTimeOffset>.Default.GetHashCode(ReceivedAt);
            return hashCode;
        }
    }
}