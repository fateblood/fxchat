using FX110.AutoMap.BaseProfile;
using JsonPropertyTest.APIModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonPropertyTest.AutoMap
{
    public class ChatMsgToCacheModelMap : ObjectToObjectProfile<JsonChatMessage, JsonPropertyTest.RedisModel.JsonChatMessage>
    {
        public ChatMsgToCacheModelMap()
        {
            //Include(typeof(ChatMsgContent), typeof(RedisModel.ChatMsgContent));
            //Include(typeof(Receiver), typeof(RedisModel.Receiver));
            //Include(typeof(Sender), typeof(RedisModel.Sender));
            //Include(typeof(ChatImage), typeof(RedisModel.ChatImage));
            //ForMemberMap(t => t.ChatMsgContent, opts => opts.MapFrom(a => a.ChatMsgContent));
            //ForMemberMap(t => t.ChatMsgContent.AtUsers, opts => opts.MapFrom(a => a.ChatMsgContent.AtUsers));
            //ForMemberMap(t => t.ChatMsgContent.Images, opts => opts.MapFrom(a => a.ChatMsgContent.Images));
            //ForMemberMap(t => t.Sender, opts => opts.MapFrom(a => a.Sender));
            //ForMemberMap(t => t.Receiver, opts => opts.MapFrom(a => a.Receiver));
        }
    }
}
