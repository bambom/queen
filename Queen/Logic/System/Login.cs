﻿using Queen.Common.Database.Readers;
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

        private void OnC2SLogin(NetChannel channel, C2SLoginMsg msg)
        {
            engine.logger.Log($"a user try to login userName -> {msg.userName}");
            if (false == engine.dbo.Query<RoleReader>($"select * from roles where username='{msg.userName}';", out var readers))
            {
                channel.Send(new S2CLoginMsg { opt = 2 });
                engine.logger.Log($"a user unregister -> {msg.userName}");

                return;
            }

            var reader = readers.First();
            if (false == reader.username.Equals(msg.userName) && false == reader.password.Equals(msg.password))
            {
                channel.Send(new S2CLoginMsg { opt = 3 });
                engine.logger.Log($"user's password is wrong -> {msg.userName}");

                return;
            }

            engine.party.Join(new RoleJoinInfo { channel = channel, pid = reader.pid, userName = reader.username, nickName = reader.nickName });
            engine.logger.Log($"user login success. pid -> {reader.pid}, username -> {msg.userName}");

            channel.Send(new S2CLoginMsg { opt = 1 });
        }

        private void OnC2SRegister(NetChannel channel, C2SRegisterMsg msg)
        {

        }
    }
}
