using FX110.AutoMap.BaseProfile;
using JsonPropertyTest.APIModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonPropertyTest.AutoMap
{
    public class ChatReceiverToRedisModel : ObjectToObjectProfile<Receiver, JsonPropertyTest.RedisModel.Receiver>
    {
        public ChatReceiverToRedisModel() { }
    }
}
