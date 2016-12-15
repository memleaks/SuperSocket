using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SuperSocket.SocketBase.Protocol;
using SuperSocket.WebSocket.Protocol;

namespace SuperSocket.WebSocket.Compatible
{
	public interface ICompatibleSession : IWebSocketSession
	{
		IReceiveFilter<IWebSocketFragment> DetectedNonWebSocketFilter(byte[] data);
		void NonWebSocketSessionStarted();
		void NonWebSocketSend(byte[] data, int offset, int length);
	}
}
