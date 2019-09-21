﻿using Newbe.Mahua.Apis;
using Newbe.Mahua.Logging;

namespace Newbe.Mahua.Samples.ApiExtensions.MahuaApis
{
    public class SendPrivateMessageApiMahuaCommandHandler
        : IApiCommandHandler<SendPrivateMessageApiMahuaCommand, SendPrivateMessageApiMahuaCommandResult>
    {
        public SendPrivateMessageApiMahuaCommandResult Handle(SendPrivateMessageApiMahuaCommand message)
        {
            var logger = LogProvider.For<SendPrivateMessageApiMahuaCommandHandler>();

            // 将好友消息写入到日志当中
            logger.Info(message.Message);
            return new SendPrivateMessageApiMahuaCommandResult
            {
                MessageCancelToken = null
            };
        }
    }
}