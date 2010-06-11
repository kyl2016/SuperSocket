﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SuperSocket.SocketServiceCore.Command;

namespace EchoService.Command
{
    public class ECHO : ICommand<EchoSession>
    {
        #region ICommand<EchoSession> Members

        public void Execute(EchoSession session, CommandInfo commandData)
        {
            session.SendResponse(commandData.Param);
        }

        #endregion
    }
}