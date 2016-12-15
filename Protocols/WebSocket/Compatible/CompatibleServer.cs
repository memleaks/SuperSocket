using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SuperSocket.SocketBase.Protocol;
using SuperSocket.WebSocket.Protocol;

namespace SuperSocket.WebSocket.Compatible
{
	public class CompatibleServer<TSession> : WebSocketServer<TSession>
		where TSession : CompatibleSession<TSession>, new()
	{
		public CompatibleServer()
			: base(new CompatibleProtocol())
		{
		}
	}
}
