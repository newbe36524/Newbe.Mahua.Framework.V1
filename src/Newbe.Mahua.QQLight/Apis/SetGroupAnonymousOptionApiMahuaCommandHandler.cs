using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.QQLight.Apis
{
    public class SetGroupAnonymousOptionApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<SetGroupAnonymousOptionApiMahuaCommand>
    {
        private readonly IQqLightAuthCodeContainer _qqLightAuthCodeContainer;

        public SetGroupAnonymousOptionApiMahuaCommandHandler(
            IQqLightApi QqLightApi,
            IQqLightAuthCodeContainer qqLightAuthCodeContainer)
            : base(QqLightApi)
        {
            _qqLightAuthCodeContainer = qqLightAuthCodeContainer;
        }

        public override void Handle(SetGroupAnonymousOptionApiMahuaCommand message)
        {
            QqLightApi.Api_SetAnony(message.ToGroup, message.Enabled, _qqLightAuthCodeContainer.AuthCode);
        }
    }
}