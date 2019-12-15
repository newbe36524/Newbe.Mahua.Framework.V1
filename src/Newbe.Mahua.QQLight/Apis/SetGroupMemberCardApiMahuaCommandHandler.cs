using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.QQLight.Apis
{
    public class SetGroupMemberCardApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<SetGroupMemberCardApiMahuaCommand>
    {
        private readonly IQqLightAuthCodeContainer _qqLightAuthCodeContainer;

        public SetGroupMemberCardApiMahuaCommandHandler(
            IQqLightApi QqLightApi,
            IQqLightAuthCodeContainer qqLightAuthCodeContainer)
            : base(QqLightApi)
        {
            _qqLightAuthCodeContainer = qqLightAuthCodeContainer;
        }

        public override void Handle(SetGroupMemberCardApiMahuaCommand message)
        {
            QqLightApi.Api_SetGroupCard(message.ToGroup,
                message.ToQq,
                message.GroupMemberCard,
                _qqLightAuthCodeContainer.AuthCode);
        }
    }
}