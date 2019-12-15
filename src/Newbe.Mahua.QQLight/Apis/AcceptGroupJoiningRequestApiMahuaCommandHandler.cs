using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.QQLight.Apis
{
    public class AcceptGroupJoiningRequestApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<AcceptGroupJoiningRequestApiMahuaCommand>
    {
        private readonly IQqLightAuthCodeContainer _qqLightAuthCodeContainer;

        public AcceptGroupJoiningRequestApiMahuaCommandHandler(
            IQqLightApi QqLightApi,
            IQqLightAuthCodeContainer qqLightAuthCodeContainer)
            : base(QqLightApi)
        {
            _qqLightAuthCodeContainer = qqLightAuthCodeContainer;
        }

        public override void Handle(AcceptGroupJoiningRequestApiMahuaCommand message)
        {
            QqLightApi.Api_SetGroupAdd(
                message.ToGroup,
                message.FromQq,
                message.GroupJoiningRequestId,
                QqLightConstants.Operation同意,
                null,
                _qqLightAuthCodeContainer.AuthCode);
        }
    }
}