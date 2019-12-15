using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.QQLight.Apis
{
    public class RemoveFriendApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<RemoveFriendApiMahuaCommand>
    {
        private readonly IQqLightAuthCodeContainer _qqLightAuthCodeContainer;

        public RemoveFriendApiMahuaCommandHandler(
            IQqLightApi QqLightApi,
            IQqLightAuthCodeContainer qqLightAuthCodeContainer)
            : base(QqLightApi)
        {
            _qqLightAuthCodeContainer = qqLightAuthCodeContainer;
        }

        public override void Handle(RemoveFriendApiMahuaCommand message)
        {
            QqLightApi.Api_DeleteFriend(message.ToQq, _qqLightAuthCodeContainer.AuthCode);
        }
    }
}