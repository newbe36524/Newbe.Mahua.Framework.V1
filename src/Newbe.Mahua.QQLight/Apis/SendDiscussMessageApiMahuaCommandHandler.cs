using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;
using Newbe.Mahua.QQLight.Messages.CancelMessage;

namespace Newbe.Mahua.QQLight.Apis
{
    public class SendDiscussMessageApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<SendDiscussMessageApiMahuaCommand, SendDiscussMessageApiMahuaCommandResult>
    {
        private readonly IQqLightAuthCodeContainer _qqLightAuthCodeContainer;

        public SendDiscussMessageApiMahuaCommandHandler(
            IQqLightApi qqLightApi,
            IQqLightAuthCodeContainer qqLightAuthCodeContainer)
            : base(qqLightApi)
        {
            _qqLightAuthCodeContainer = qqLightAuthCodeContainer;
        }

        public override SendDiscussMessageApiMahuaCommandResult Handle(SendDiscussMessageApiMahuaCommand message)
        {
            QqLightApi.Api_SendMsg(QqLightConstants.MsgType讨论组消息,
                message.ToDiscuss,
                null,
                message.Message,
                _qqLightAuthCodeContainer.AuthCode);
            var re = new SendDiscussMessageApiMahuaCommandResult
            {
                MessageCancelToken = QqLightMessageCancelToken.EmptyActionToken
            };
            return re;
        }
    }
}