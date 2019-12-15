using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.QQLight.Apis
{
    public class GetCookiesApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<GetCookiesApiMahuaCommand, GetCookiesApiMahuaCommandResult>
    {
        private readonly IQqLightAuthCodeContainer _qqLightAuthCodeContainer;

        public GetCookiesApiMahuaCommandHandler(
            IQqLightApi QqLightApi,
            IQqLightAuthCodeContainer qqLightAuthCodeContainer)
            : base(QqLightApi)
        {
            _qqLightAuthCodeContainer = qqLightAuthCodeContainer;
        }

        public override GetCookiesApiMahuaCommandResult Handle(GetCookiesApiMahuaCommand message)
        {
            var cookies = QqLightApi.Api_GetCookies(_qqLightAuthCodeContainer.AuthCode);
            var re = new GetCookiesApiMahuaCommandResult
            {
                Cookies = cookies
            };
            return re;
        }
    }
}