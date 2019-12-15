using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.QQLight.Apis
{
    public class JoinGroupApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<JoinGroupApiMahuaCommand>
    {
        private readonly IQqLightAuthCodeContainer _qqLightAuthCodeContainer;

        public JoinGroupApiMahuaCommandHandler(
            IQqLightApi QqLightApi,
            IQqLightAuthCodeContainer qqLightAuthCodeContainer)
            : base(QqLightApi)
        {
            _qqLightAuthCodeContainer = qqLightAuthCodeContainer;
        }

        public override void Handle(JoinGroupApiMahuaCommand message)
        {
            QqLightApi.Api_AddGroup(message.ToGroup, message.Reason, _qqLightAuthCodeContainer.AuthCode);
        }
    }
}