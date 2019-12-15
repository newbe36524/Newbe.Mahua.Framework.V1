using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.QQLight.Apis
{
    public class RejectFriendAddingRequestApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<RejectFriendAddingRequestApiMahuaCommand>
    {
        private readonly IQqLightAuthCodeContainer _qqLightAuthCodeContainer;

        public RejectFriendAddingRequestApiMahuaCommandHandler(
            IQqLightApi QqLightApi,
            IQqLightAuthCodeContainer qqLightAuthCodeContainer)
            : base(QqLightApi)
        {
            _qqLightAuthCodeContainer = qqLightAuthCodeContainer;
        }

        public override void Handle(RejectFriendAddingRequestApiMahuaCommand message)
        {
            QqLightApi.Api_SetFriendAdd(message.FromQq,
                QqLightConstants.Operation拒绝,
                null,
                _qqLightAuthCodeContainer.AuthCode);
        }
    }
}