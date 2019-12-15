using Newbe.Mahua.Commands;
using System;
using System.Runtime.Serialization;
using Newbe.Mahua.Logging;

namespace Newbe.Mahua.QQLight.Commands
{
    [DataContract]
    public class InformationCommand : QqLightCommand<InformationCommandResult>
    {
        [DataMember] public int AuthCode { get; set; }
    }

    [DataContract]
    public class InformationCommandResult : QqLightCommandResult
    {
        [DataMember] public string Info { get; set; }
    }

    internal class InformationCommandHandler : ICommandHandler<InformationCommand, InformationCommandResult>
    {
        private static readonly ILog Logger = LogProvider.For<InformationCommandHandler>();

        private const string SdkVersion = "1";
        private readonly IPluginInfo _pluginInfo;
        private readonly IQqLightAuthCodeContainer _QqLightAuthCodeContainer;

        public InformationCommandHandler(
            IPluginInfo pluginInfo,
            IQqLightAuthCodeContainer QqLightAuthCodeContainer)
        {
            _pluginInfo = pluginInfo;
            _QqLightAuthCodeContainer = QqLightAuthCodeContainer;
        }

        public InformationCommandResult Handle(InformationCommand message)
        {
            _QqLightAuthCodeContainer.AuthCode = message.AuthCode;
            var info =
                $"{{\"plugin_id\":\"{_pluginInfo.Id}\",\"plugin_name\":\"{_pluginInfo.Name}\",\"plugin_author\":\"{_pluginInfo.Author}\",\"plugin_version\":\"{_pluginInfo.Version}\",\"plugin_brief\":\"{_pluginInfo.Description}\",\"plugin_sdk\":\"{SdkVersion}\",\"plugin_menu\":\"true\"}}";
            Logger.Info("Plugin Info :{info}", info);
            return new InformationCommandResult
            {
                Info = info
            };
        }
    }
}