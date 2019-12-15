using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.QQLight.Apis
{
    public class GetGroupsApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<GetGroupsApiMahuaCommand, GetGroupsApiMahuaCommandResult>
    {
        private readonly IQqLightAuthCodeContainer _qqLightAuthCodeContainer;

        public GetGroupsApiMahuaCommandHandler(
            IQqLightApi QqLightApi,
            IQqLightAuthCodeContainer qqLightAuthCodeContainer)
            : base(QqLightApi)
        {
            _qqLightAuthCodeContainer = qqLightAuthCodeContainer;
        }

        public override GetGroupsApiMahuaCommandResult Handle(GetGroupsApiMahuaCommand message)
        {
            var groupsString = QqLightApi.Api_GetGroupList(false, _qqLightAuthCodeContainer.AuthCode);
            var re = new GetGroupsApiMahuaCommandResult
            {
                GroupsString = groupsString
            };
            return re;
        }
    }
}