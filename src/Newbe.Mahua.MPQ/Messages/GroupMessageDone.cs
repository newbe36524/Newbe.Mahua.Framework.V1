﻿using System.IO;
using System.Linq;
using Newbe.Mahua.Messages;
using Newbe.Mahua.Messages.CancelMessage;
using Newbe.Mahua.Messages.Steps;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.MPQ.Messages
{
    public class GroupMessageDone : IGroupMessageDone, IMessageBuildStep
    {
        private readonly IMahuaApi _mahuaApi;
        private readonly IMpqMessage _message;
        private readonly IMpqApi _mpqApi;
        private readonly IRobotSessionContext _robotSessionContext;

        public GroupMessageDone(
            IMahuaApi mahuaApi,
            IMpqMessage message,
            IMpqApi mpqApi,
            IRobotSessionContext robotSessionContext)
        {
            _mahuaApi = mahuaApi;
            _message = message;
            _mpqApi = mpqApi;
            _robotSessionContext = robotSessionContext;
        }

        public void Done()
        {
            var msg = CreateMessage();
            _mahuaApi.SendGroupMessage(_message.Target, msg);
        }

        public IMessageCancelToken DoneWithToken()
        {
            var msg = CreateMessage();
            var token = _mahuaApi.SendGroupMessageWithCancelToken(_message.Target, msg);
            return token;
        }

        private string CreateMessage()
        {
            var msg = _message.GetMessage();
            if (_message.Images.Any())
            {
                _message.Images.Upload(file =>
                    _mpqApi.Api_UploadPic(
                        _robotSessionContext.CurrentQq,
                        2,
                        _message.Target,
                        File.ReadAllBytes(file)));
                msg = _message.Images.Formate(msg);
            }

            return msg;
        }
    }
}