﻿using System;
using System.ComponentModel;
using Newbe.Mahua.Messages.CancelMessage;

namespace Newbe.Mahua.MahuaEvents
{
    /// <summary>
    /// 来自讨论组成员的私聊消息接收事件
    /// </summary>
    [Description("来自讨论组成员的私聊消息接收事件")]
    public interface IPrivateMessageFromDiscussReceivedMahuaEvent : IMahuaEvent
    {
        /// <summary>
        /// 处理事件
        /// </summary>
        /// <param name="context"></param>
        void ProcessDiscussGroupMessage(PrivateMessageFromDiscussReceivedContext context);
    }

    /// <summary>
    /// 事件上下文
    /// </summary>
    public class PrivateMessageFromDiscussReceivedContext
    {
        /// <summary>
        /// 事件时间
        /// </summary>
        public DateTime SendTime { get; set; }

        /// <summary>
        /// 来自讨论组
        /// </summary>
        public string FromDiscuss { get; set; }

        /// <summary>
        /// 来自QQ
        /// </summary>
        public string FromQq { get; set; }

        /// <summary>
        /// 消息内容
        /// </summary>
        public string Message { get; set; }
        
        /// <summary>
        /// 用于撤回消息的Token
        /// </summary>
        public IMessageCancelToken MessageCancelToken { get; set; }
    }
}