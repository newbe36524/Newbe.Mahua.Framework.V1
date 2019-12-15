using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.QQLight.Apis
{
    public class SendLikeApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<SendLikeApiMahuaCommand>
    {
        private readonly IQqLightAuthCodeContainer _qqLightAuthCodeContainer;

        public SendLikeApiMahuaCommandHandler(
            IQqLightApi QqLightApi,
            IQqLightAuthCodeContainer qqLightAuthCodeContainer)
            : base(QqLightApi)
        {
            _qqLightAuthCodeContainer = qqLightAuthCodeContainer;
        }

        public override void Handle(SendLikeApiMahuaCommand message)
        {
            QqLightApi.Api_SendPraise(message.ToQq, _qqLightAuthCodeContainer.AuthCode);
        }
    }
}