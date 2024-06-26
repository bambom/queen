﻿using Queen.Common.Database;
using Queen.Common.Database.Readers;
using Queen.Logic.Common;
using Queen.Logic.Player.Common;
using Queen.Network.Common;
using Queen.Network.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queen.Logic.Sys
{
    /// <summary>
    /// 登录
    /// </summary>
    public class Login : Behavior
    {
        protected override void OnCreate()
        {
            base.OnCreate();
            engine.slave.Recv<C2SLoginMsg>(OnC2SLogin);
            engine.slave.Recv<C2SRegisterMsg>(OnC2SRegister);
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            engine.slave.UnRecv<C2SLoginMsg>(OnC2SLogin);
            engine.slave.UnRecv<C2SRegisterMsg>(OnC2SRegister);
        }

        /// <summary>
        /// 玩家登录
        /// </summary>
        /// <param name="channel">通信渠道</param>
        /// <param name="msg">消息</param>
        private void OnC2SLogin(NetChannel channel, C2SLoginMsg msg)
        {
            engine.logger.Log($"a user try to login. username -> {msg.username}");
            if (false == engine.dbo.Query<RoleReader>($"select * from roles where username=@condi;", out var readers, new SQLParamInfo { key = "@condi", value = msg.username }))
            {
                channel.Send(new S2CLoginMsg { code = 2 });
                engine.logger.Log($"the user unregistered. username -> {msg.username}");

                return;
            }

            var reader = readers.First();
            if (false == reader.password.Equals(msg.password))
            {
                channel.Send(new S2CLoginMsg { code = 3 });
                engine.logger.Log($"user's password is wrong. username -> {msg.username}");

                return;
            }

            engine.party.Join(new RoleJoinInfo { channel = channel, pid = reader.pid, username = reader.username, nickname = reader.nickName });
            engine.logger.Log($"user login success. pid -> {reader.pid}, username -> {msg.username}");

            channel.Send(new S2CLoginMsg { code = 1 });
        }

        /// <summary>
        /// 玩家注册
        /// </summary>
        /// <param name="channel">通信渠道</param>
        /// <param name="msg">消息</param>
        private void OnC2SRegister(NetChannel channel, C2SRegisterMsg msg)
        {
            engine.logger.Log($"a new user try to register username -> {msg.username}");
            if (engine.dbo.Query<RoleReader>($"select * from roles where username=@username;", out var readers, new SQLParamInfo { key = "@username", value = msg.username }))
            {
                channel.Send(new S2CRegisterMsg { code = 2 });
                engine.logger.Log($"this username has already been registered. username -> {msg.username}");

                return;
            }

            var pid = Guid.NewGuid().ToString();
            engine.dbo.Execute($"insert into roles (pid, username, password) values(@pid, @username, @password)", new SQLParamInfo { key = "@pid", value = pid }, new SQLParamInfo { key = "@username", value = msg.username }, new SQLParamInfo { key = "@password", value = msg.password });

            channel.Send(new S2CRegisterMsg { code = 1 });
            engine.logger.Log($"registration success. pid -> {pid}, username -> {msg.username}");
        }
    }
}
