using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.QQLight.Apis
{
    public class RejectGroupJoiningRequestApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<RejectGroupJoiningRequestApiMahuaCommand>
    {
        private readonly IQqLightAuthCodeContainer _qqLightAuthCodeContainer;

        public RejectGroupJoiningRequestApiMahuaCommandHandler(
            IQqLightApi QqLightApi,
            IQqLightAuthCodeContainer qqLightAuthCodeContainer)
            : base(QqLightApi)
        {
            _qqLightAuthCodeContainer = qqLightAuthCodeContainer;
        }

        public override void Handle(RejectGroupJoiningRequestApiMahuaCommand message)
        {
            QqLightApi.Api_SetGroupAdd(
                message.ToGroup,
                message.FromQq,
                message.GroupJoiningRequestId,
                QqLightConstants.Operation拒绝,
                null,
                _qqLightAuthCodeContainer.AuthCode);
        }
    }
}