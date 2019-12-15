using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.QQLight.Apis
{
    public class RemoveBanGroupMemberApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<RemoveBanGroupMemberApiMahuaCommand>
    {
        private readonly IQqLightAuthCodeContainer _qqLightAuthCodeContainer;

        public RemoveBanGroupMemberApiMahuaCommandHandler(
            IQqLightApi QqLightApi,
            IQqLightAuthCodeContainer qqLightAuthCodeContainer)
            : base(QqLightApi)
        {
            _qqLightAuthCodeContainer = qqLightAuthCodeContainer;
        }

        public override void Handle(RemoveBanGroupMemberApiMahuaCommand message)
        {
            QqLightApi.Api_Ban(message.ToGroup, message.ToQq, 0, _qqLightAuthCodeContainer.AuthCode);
        }
    }
}