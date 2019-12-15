using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.QQLight.Apis
{
    public class AcceptFriendAddingRequestApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<AcceptFriendAddingRequestApiMahuaCommand>
    {
        private readonly IQqLightAuthCodeContainer _qqLightAuthCodeContainer;

        public AcceptFriendAddingRequestApiMahuaCommandHandler(
            IQqLightApi QqLightApi,
            IQqLightAuthCodeContainer qqLightAuthCodeContainer)
            : base(QqLightApi)
        {
            _qqLightAuthCodeContainer = qqLightAuthCodeContainer;
        }

        public override void Handle(AcceptFriendAddingRequestApiMahuaCommand message)
        {
            QqLightApi.Api_SetFriendAdd(message.FromQq,
                QqLightConstants.Operation同意,
                null,
                _qqLightAuthCodeContainer.AuthCode);
        }
    }
}