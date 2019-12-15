using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.QQLight.Apis
{
    public class LeaveDiscussApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<LeaveDiscussApiMahuaCommand>
    {
        private readonly IQqLightAuthCodeContainer _qqLightAuthCodeContainer;

        public LeaveDiscussApiMahuaCommandHandler(
            IQqLightApi QqLightApi,
            IQqLightAuthCodeContainer qqLightAuthCodeContainer)
            : base(QqLightApi)
        {
            _qqLightAuthCodeContainer = qqLightAuthCodeContainer;
        }

        public override void Handle(LeaveDiscussApiMahuaCommand message)
        {
            QqLightApi.Api_QuitDiscussGroup(message.ToDiscuss, _qqLightAuthCodeContainer.AuthCode);
        }
    }
}