using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.QQLight.Apis
{
    public class GetLoginNickApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<GetLoginNickApiMahuaCommand, GetLoginNickApiMahuaCommandResult>
    {
        private readonly IQqLightAuthCodeContainer _qqLightAuthCodeContainer;

        public GetLoginNickApiMahuaCommandHandler(
            IQqLightApi QqLightApi,
            IQqLightAuthCodeContainer qqLightAuthCodeContainer)
            : base(QqLightApi)
        {
            _qqLightAuthCodeContainer = qqLightAuthCodeContainer;
        }

        public override GetLoginNickApiMahuaCommandResult Handle(GetLoginNickApiMahuaCommand message)
        {
            var qq = QqLightApi.Api_GetLoginQQ(_qqLightAuthCodeContainer.AuthCode);
            var nick = QqLightApi.Api_GetNick(qq, _qqLightAuthCodeContainer.AuthCode);
            var re = new GetLoginNickApiMahuaCommandResult
            {
                Nick = nick
            };
            return re;
        }
    }
}