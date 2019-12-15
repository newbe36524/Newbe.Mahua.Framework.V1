using System;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.QQLight
{
    public class QqProvider : IQqProvider
    {
        private readonly IQqLightAuthCodeContainer _qqLightAuthCodeContainer;
        private readonly IQqLightApi _QqLightApi;

        public QqProvider(
            IQqLightAuthCodeContainer qqLightAuthCodeContainer,
            IQqLightApi QqLightApi)
        {
            _qqLightAuthCodeContainer = qqLightAuthCodeContainer;
            _QqLightApi = QqLightApi;
        }

        public Func<string> DefaultQqProvider => () => _QqLightApi.Api_GetLoginQQ(_qqLightAuthCodeContainer.AuthCode);

        public bool CheckQq(string qq)
        {
            return DefaultQqProvider() == qq;
        }
    }
}