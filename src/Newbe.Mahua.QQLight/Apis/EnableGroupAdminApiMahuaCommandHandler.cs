using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.QQLight.Apis
{
    public class EnableGroupAdminApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<EnableGroupAdminApiMahuaCommand>
    {
        private readonly IQqLightAuthCodeContainer _qqLightAuthCodeContainer;

        public EnableGroupAdminApiMahuaCommandHandler(
            IQqLightApi QqLightApi,
            IQqLightAuthCodeContainer qqLightAuthCodeContainer)
            : base(QqLightApi)
        {
            _qqLightAuthCodeContainer = qqLightAuthCodeContainer;
        }

        public override void Handle(EnableGroupAdminApiMahuaCommand message)
        {
            QqLightApi.Api_SetManager(message.ToGroup, message.ToQq, true, _qqLightAuthCodeContainer.AuthCode);
        }
    }
}