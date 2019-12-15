using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CQP.Apis
{
    internal class GetCookiesApiMahuaCommandHandler
        : CqpApiMahuaCommandHandlerBase<GetCookiesApiMahuaCommand, GetCookiesApiMahuaCommandResult>
    {
        public GetCookiesApiMahuaCommandHandler(
            ICoolQApi coolQApi,
            ICqpAuthCodeContainer cqpAuthCodeContainer)
            : base(coolQApi, cqpAuthCodeContainer)
        {
        }

        public override GetCookiesApiMahuaCommandResult Handle(GetCookiesApiMahuaCommand message)
        {
            // TODO doamin
            const string domain = ".qq.com";
            var cqGetCookies = CoolQApi.CQ_getCookiesV2(AuthCode, domain);
            return new GetCookiesApiMahuaCommandResult
            {
                Cookies = cqGetCookies
            };
        }
    }
}