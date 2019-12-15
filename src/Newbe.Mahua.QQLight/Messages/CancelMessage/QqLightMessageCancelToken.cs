using Newbe.Mahua.Messages.CancelMessage;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.QQLight.Messages.CancelMessage
{
    public class QqLightMessageCancelToken : IMessageCancelToken
    {
        public delegate QqLightMessageCancelToken Factory(int type, string qqGroup, string qqId, string messageId);

        public static readonly IMessageCancelToken EmptyActionToken = new EmptyCancelToken();

        private readonly int _type;
        private readonly string _qqId;
        private readonly IQqLightAuthCodeContainer _qqLightAuthCodeContainer;
        private readonly IQqLightApi _qqLightApi;

        public QqLightMessageCancelToken(
            int type,
            string qqGroup,
            string qqId,
            string messageId,
            IQqLightAuthCodeContainer qqLightAuthCodeContainer,
            IQqLightApi qqLightApi)
        {
            QqGroup = qqGroup;
            MessageId = messageId;
            _type = type;
            _qqId = qqId;
            _qqLightAuthCodeContainer = qqLightAuthCodeContainer;
            _qqLightApi = qqLightApi;
        }

        public string QqGroup { get; }
        public string MessageId { get; }

        public void Cancel()
        {
            _qqLightApi.Api_DeleteMsg(_type, QqGroup, _qqId, MessageId, _qqLightAuthCodeContainer.AuthCode);
        }

        private class EmptyCancelToken : IMessageCancelToken
        {
            public void Cancel()
            {
                // 不支持发出消息的撤回 
            }
        }
    }
}