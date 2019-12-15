using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.QQLight.Apis
{
    public class GetGroupMemebersApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<GetGroupMemebersApiMahuaCommand, GetGroupMemebersApiMahuaCommandResult>
    {
        private readonly IQqLightAuthCodeContainer _qqLightAuthCodeContainer;

        public GetGroupMemebersApiMahuaCommandHandler(
            IQqLightApi QqLightApi, IQqLightAuthCodeContainer qqLightAuthCodeContainer)
            : base(QqLightApi)
        {
            _qqLightAuthCodeContainer = qqLightAuthCodeContainer;
        }

        public override GetGroupMemebersApiMahuaCommandResult Handle(GetGroupMemebersApiMahuaCommand message)
        {
            var groupMemebersString = QqLightApi.Api_GetGroupMemberList(message.ToGroup,
                false,
                _qqLightAuthCodeContainer.AuthCode);
            var re = new GetGroupMemebersApiMahuaCommandResult
            {
                GroupMemebersString = groupMemebersString
            };
            return re;
        }
    }
}