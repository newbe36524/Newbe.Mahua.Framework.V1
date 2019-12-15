using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.QQLight.Apis
{
    public class KickGroupMemberApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<KickGroupMemberApiMahuaCommand>
    {
        private readonly IQqLightAuthCodeContainer _qqLightAuthCodeContainer;

        public KickGroupMemberApiMahuaCommandHandler(
            IQqLightApi QqLightApi,
            IQqLightAuthCodeContainer qqLightAuthCodeContainer)
            : base(QqLightApi)
        {
            _qqLightAuthCodeContainer = qqLightAuthCodeContainer;
        }

        public override void Handle(KickGroupMemberApiMahuaCommand message)
        {
            QqLightApi.Api_RemoveMember(message.ToGroup,
                message.ToQq,
                message.RejectForever,
                _qqLightAuthCodeContainer.AuthCode);
        }
    }
}