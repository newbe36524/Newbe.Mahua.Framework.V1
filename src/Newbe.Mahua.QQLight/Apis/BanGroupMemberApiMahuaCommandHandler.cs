using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.QQLight.Apis
{
    public class BanGroupMemberApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<BanGroupMemberApiMahuaCommand>
    {
        private readonly IQqLightAuthCodeContainer _qqLightAuthCodeContainer;

        public BanGroupMemberApiMahuaCommandHandler(
            IQqLightApi QqLightApi,
            IQqLightAuthCodeContainer qqLightAuthCodeContainer)
            : base(QqLightApi)
        {
            _qqLightAuthCodeContainer = qqLightAuthCodeContainer;
        }

        public override void Handle(BanGroupMemberApiMahuaCommand message)
        {
            QqLightApi.Api_Ban(message.ToGroup,
                message.ToQq,
                (int) message.Duration.TotalSeconds,
                _qqLightAuthCodeContainer.AuthCode);
        }
    }
}