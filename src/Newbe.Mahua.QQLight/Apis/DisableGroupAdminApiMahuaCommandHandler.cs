using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.QQLight.Apis
{
    public class DisableGroupAdminApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<DisableGroupAdminApiMahuaCommand>
    {
        private readonly IQqLightAuthCodeContainer _qqLightAuthCodeContainer;

        public DisableGroupAdminApiMahuaCommandHandler(
            IQqLightApi QqLightApi,
            IQqLightAuthCodeContainer qqLightAuthCodeContainer)
            : base(QqLightApi)
        {
            _qqLightAuthCodeContainer = qqLightAuthCodeContainer;
        }

        public override void Handle(DisableGroupAdminApiMahuaCommand message)
        {
            QqLightApi.Api_SetManager(message.ToGroup, message.ToQq, false, _qqLightAuthCodeContainer.AuthCode);
        }
    }
}