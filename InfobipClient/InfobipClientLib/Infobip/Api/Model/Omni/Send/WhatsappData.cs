using System.Collections.Generic;
using Newtonsoft.Json;
using Infobip.Api.Config;
using Infobip.Api.Model.Omni.Send;
using System;

namespace Infobip.Api.Model.Omni.Send
{    
    public class WhatsappData
    {
       // [JsonProperty("transliteration")]
        //public string Transliteration { get; set; }

        //[JsonProperty("language")]
        //public Language Language { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        //[JsonProperty("validityPeriod")]
        //public long? ValidityPeriod { get; set; }

        //[JsonProperty("validityPeriodTimeUnit")]
        //public TimeUnit ValidityPeriodTimeUnit { get; set; }

    }
}
