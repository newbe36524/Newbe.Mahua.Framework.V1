using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;
using Newbe.Mahua.QQLight.Messages.CancelMessage;

namespace Newbe.Mahua.QQLight.Apis
{
    public class SendPrivateMessageApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<SendPrivateMessageApiMahuaCommand, SendPrivateMessageApiMahuaCommandResult>
    {
        private readonly IQqLightAuthCodeContainer _qqLightAuthCodeContainer;

        public SendPrivateMessageApiMahuaCommandHandler(
            IQqLightApi qqLightApi,
            IQqLightAuthCodeContainer qqLightAuthCodeContainer)
            : base(qqLightApi)
        {
            _qqLightAuthCodeContainer = qqLightAuthCodeContainer;
        }

        public override SendPrivateMessageApiMahuaCommandResult Handle(SendPrivateMessageApiMahuaCommand message)
        {
            QqLightApi.Api_SendMsg(QqLightConstants.MsgType好友消息,
                null,
                message.ToQq,
                message.Message,
                _qqLightAuthCodeContainer.AuthCode);
            var re = new SendPrivateMessageApiMahuaCommandResult
            {
                MessageCancelToken = QqLightMessageCancelToken.EmptyActionToken
            };
            return re;
        }
    }
}