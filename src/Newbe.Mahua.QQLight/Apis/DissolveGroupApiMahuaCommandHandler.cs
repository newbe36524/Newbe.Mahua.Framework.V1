using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.QQLight.Apis
{
    public class DissolveGroupApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<DissolveGroupApiMahuaCommand>
    {
        private readonly IQqLightAuthCodeContainer _qqLightAuthCodeContainer;

        public DissolveGroupApiMahuaCommandHandler(
            IQqLightApi QqLightApi,
            IQqLightAuthCodeContainer qqLightAuthCodeContainer)
            : base(QqLightApi)
        {
            _qqLightAuthCodeContainer = qqLightAuthCodeContainer;
        }

        public override void Handle(DissolveGroupApiMahuaCommand message)
        {
            QqLightApi.Api_RemoveGroup(message.ToGroup, _qqLightAuthCodeContainer.AuthCode);
        }
    }
}