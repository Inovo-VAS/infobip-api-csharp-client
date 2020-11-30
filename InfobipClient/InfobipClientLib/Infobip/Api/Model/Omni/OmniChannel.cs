using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Infobip.Api.Model.Omni
{
    /// <summary>
    /// This is a generated class and is not intended for modification!
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OmniChannel
    {
        SMS,
        EMAIL,
        VOICE,
        PARSECO,
        PUSH,
        VIBER,
        FACEBOOK,
        LINE,
        VKONTAKTE,
        KAKAO_ALIM,
        WHATSAPP
    }
}