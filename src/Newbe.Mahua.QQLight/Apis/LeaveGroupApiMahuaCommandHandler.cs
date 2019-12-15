using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.QQLight.Apis
{
    public class LeaveGroupApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<LeaveGroupApiMahuaCommand>
    {
        private readonly IQqLightAuthCodeContainer _qqLightAuthCodeContainer;

        public LeaveGroupApiMahuaCommandHandler(
            IQqLightApi QqLightApi,
            IQqLightAuthCodeContainer qqLightAuthCodeContainer)
            : base(QqLightApi)
        {
            _qqLightAuthCodeContainer = qqLightAuthCodeContainer;
        }

        public override void Handle(LeaveGroupApiMahuaCommand message)
        {
            QqLightApi.Api_QuitGroup(message.ToGroup, _qqLightAuthCodeContainer.AuthCode);
        }
    }
}