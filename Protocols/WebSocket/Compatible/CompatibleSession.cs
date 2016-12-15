using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SuperSocket.SocketBase.Protocol;
using SuperSocket.WebSocket.Protocol;
using SuperSocket.SocketBase;

namespace SuperSocket.WebSocket.Compatible
{
	public abstract class CompatibleSession<TSession> : WebSocketSession<TSession>, ICompatibleSession
		where TSession : CompatibleSession<TSession>, new()
	{
		#region ICompatibleSession Members
		public abstract IReceiveFilter<IWebSocketFragment> DetectedNonWebSocketFilter(byte[] data);

		public void NonWebSocketSessionStarted()
		{
			OnHandshakeSuccess();
		}

		public void NonWebSocketSend(byte[] data, int offset, int count)
		{
			BaseSend(data, offset, count);
		}
		#endregion
	}
}
