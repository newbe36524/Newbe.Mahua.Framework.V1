using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.QQLight.Apis
{
    public class SetBanAllGroupMembersOptionApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<SetBanAllGroupMembersOptionApiMahuaCommand>
    {
        private readonly IQqLightAuthCodeContainer _qqLightAuthCodeContainer;

        public SetBanAllGroupMembersOptionApiMahuaCommandHandler(
            IQqLightApi QqLightApi,
            IQqLightAuthCodeContainer qqLightAuthCodeContainer)
            : base(QqLightApi)
        {
            _qqLightAuthCodeContainer = qqLightAuthCodeContainer;
        }

        public override void Handle(SetBanAllGroupMembersOptionApiMahuaCommand message)
        {
            QqLightApi.Api_BanGroup(message.ToGroup, message.Enabled, _qqLightAuthCodeContainer.AuthCode);
        }
    }
}