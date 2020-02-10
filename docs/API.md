# 支持的事件和API

## MahuaEvent支持列表

| 事件                                         | 说明                             | CQP | MPQ | QQLight |
| -------------------------------------------- | -------------------------------- | --- | --- | ------- |
| IExceptionOccuredMahuaEvent                  | 运行出现异常事件                 | √   | √   | √       |
| IDiscussMessageReceivedMahuaEvent            | 讨论组消息接受事件               | √   | √   | √       |
| IFriendAddedMahuaEvent                       | 已添加新好友事件                 | √   | √   | √       |
| IFriendAddingRequestMahuaEvent               | 好友申请接受事件                 | √   | √   | √       |
| IGroupAdminChangedMahuaEvent                 | 群管理员变更事件                 | √   | √   | √       |
| IGroupAdminDisabledMahuaEvent                | 解除群管理员事件                 | √   | √   | √       |
| IGroupAdminEnabledMahuaEvent                 | 任命新管理员事件                 | √   | √   | √       |
| IMahuaMenuClickedMahuaEvent                  | 菜单处理事件                     | √   | √   | √       |
| IGroupJoiningInvitationReceivedMahuaEvent    | 入群邀请接收事件                 | √   | √   | √       |
| IGroupJoiningRequestReceivedMahuaEvent       | 入群申请接收事件                 | √   | √   | √       |
| IGroupMemberChangedMahuaEvent                | 群成员变更事件                   | √   | √   | √       |
| IGroupMemberDecreasedMahuaEvent              | 群成员减少事件                   | √   | √   | √       |
| IGroupMemberIncreasedMahuaEvent              | 群成员增多事件                   | √   | √   | √       |
| IGroupMessageReceivedMahuaEvent              | 群消息接收事件                   | √   | √   | √       |
| IGroupUploadedMahuaEvent                     | 群文件上传事件                   | √   |     |         |
| IInitializationMahuaEvent                    | 插件初始化事件                   | √   | √   | √       |
| IPlatformExitedMahuaEvent                    | 机器人平台退出事件               | √   |     |         |
| IPluginDisabledMahuaEvent                    | 插件被禁用事件                   | √   | √   | √       |
| IPluginEnabledMahuaEvent                     | 插件被启用事件                   | √   | √   | √       |
| IPluginHotUpgradedMahuaEvent                 | 插件热更新成功事件               | √   | √   | √       |
| IPluginHotUpgradingMahuaEvent                | 开始插件热更新事件               | √   | √   | √       |
| IPrivateMessageFromDiscussReceivedMahuaEvent | 来自讨论组成员的私聊消息接收事件 | √   |     | √       |
| IPrivateMessageFromFriendReceivedMahuaEvent  | 来自好友的私聊消息接收事件       | √   | √   | √       |
| IPrivateMessageFromGroupReceivedMahuaEvent   | 来自群成员的私聊消息接收事件     | √   | √   | √       |
| IPrivateMessageFromOnlineReceivedMahuaEvent  | 来自在线状态的私聊消息接收事件   | √   | √   | √       |
| IPrivateMessageReceivedMahuaEvent            | 私聊消息接收事件                 | √   | √   | √       |

## MahuaApi支持列表

标记为`√`表示该平台下支持该API。未标记则表示不支持。

标记为`√(ext)`表示可以安装相应的API扩展包来支持该平台。

| Api                          | 说明                         | Cqp    | Mpq | QqLight |
| ---------------------------- | ---------------------------- | ------ | --- | ------- |
| AcceptFriendAddingRequest    | 同意添加好友请求             | √      | √   | √       |
| AcceptGroupJoiningInvitation | 接受入群邀请                 | √      | √   | √       |
| AcceptGroupJoiningRequest    | 管理员同意入群申请           | √      | √   | √       |
| BanFriend                    | 将QQ移入黑名单               |        | √   |         |
| BanGroupAnonymousMember      | 设置禁言某匿名群员           | √      |     |         |
| BanGroupMember               | 禁言某群成员                 | √      | √   | √       |
| CreateDiscuss                | 创建讨论组                   |        | √   |         |
| DisableGroupAdmin            | 删除群管理员                 | √      |     | √       |
| DissolveGroup                | 解散群                       | √      | √   | √       |
| EnableGroupAdmin             | 设置群管理员                 | √      |     | √       |
| GetBkn                       | 取bkn                        | √      | √   | √       |
| GetCookies                   | 取Cookies                    | √      | √   | √       |
| GetDiscusses                 | 获取讨论组列表               |        | √   |         |
| GetFriends                   | 获取好友列表                 |        | √   | √       |
| GetGroupMemebers             | 获取群成员列表（返回字符串） | √      | √   | √       |
| GetGroupMemebersWithModel    | 获取群成员列表               | √      | √   |         |
| GetGroups                    | 获取群列表（返回字符串）     | √      | √   | √       |
| GetGroupsWithModel           | 获取群列表                   | √      | √   |         |
| GetLoginNick                 | 取当前登录QQ昵称             | √      | √   | √       |
| GetLoginQq                   | 取当前登录QQ                 | √      | √   | √       |
| JoinGroup                    | 主动加群                     |        | √   | √       |
| KickDiscussMember            | 踢出讨论组                   |        | √   |         |
| KickGroupMember              | 移出群成员                   | √      | √   | √       |
| LeaveDiscuss                 | 退出讨论组                   | √      | √   | √       |
| LeaveGroup                   | 退出群                       | √      | √   | √       |
| RejectFriendAddingRequest    | 拒绝添加好友请求             | √      | √   | √       |
| RejectGroupJoiningInvitation | 拒绝入群邀请                 | √      | √   | √       |
| RejectGroupJoiningRequest    | 管理员拒绝入群申请           | √      | √   | √       |
| RemoveBanFriend              | 将QQ移出黑名单               |        | √   |         |
| RemoveBanGroupMember         | 取消禁言某群成员             | √      | √   | √       |
| RemoveFriend                 | 删除好友                     |        | √   | √       |
| SendDiscussJoiningInvitation | 发送讨论组邀请               |        | √   |         |
| SendDiscussMessage           | 发送讨论组消息               | √      | √   | √       |
| SendGroupJoiningInvitation   | 发送入群邀请                 |        | √   |         |
| SendGroupMessage             | 发送群消息                   | √      | √   | √       |
| SendLike                     | 发送名片赞                   | √      |     | √       |
| SendPrivateMessage           | 发送私聊消息                 | √      | √   | √       |
| SetBanAllGroupMembersOption  | 设置全群禁言                 | √      | √   | √       |
| SetGroupAnonymousOption      | 设置群匿名设置               | √      |     | √       |
| SetGroupMemberCard           | 设置群成员名片               | √      | √   | √       |
| SetGroupMemberSpecialTitle   | 设置群成员专属头衔           | √      |     |         |
| SetNotice                    | 发布群公告                   | √(ext) | √   |         |

### 消息撤回特别说明

标记为`√`表示该平台下支持撤回。

| 功能               | Cqp | Mpq | QqLight |
| ------------------ | --- | --- | ------- |
| 撤回自己发送的消息 | √   |     |         |
| 撤回群成员消息     | √   |     | √       |
