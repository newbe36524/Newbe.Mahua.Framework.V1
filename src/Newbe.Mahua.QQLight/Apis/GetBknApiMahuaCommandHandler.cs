using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.QQLight.Apis
{
    public class GetBknApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<GetBknApiMahuaCommand, GetBknApiMahuaCommandResult>
    {
        private readonly IQqLightAuthCodeContainer _qqLightAuthCodeContainer;

        public GetBknApiMahuaCommandHandler(
            IQqLightApi QqLightApi,
            IQqLightAuthCodeContainer qqLightAuthCodeContainer)
            : base(QqLightApi)
        {
            _qqLightAuthCodeContainer = qqLightAuthCodeContainer;
        }

        public override GetBknApiMahuaCommandResult Handle(GetBknApiMahuaCommand message)
        {
            var cookie = QqLightApi.Api_GetCookies(_qqLightAuthCodeContainer.AuthCode);
            var bkn = QqLightApi.Api_Getbkn(cookie, _qqLightAuthCodeContainer.AuthCode);
            var re = new GetBknApiMahuaCommandResult
            {
                Bkn = bkn
            };
            return re;
        }
    }
}