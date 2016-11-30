using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SuperSocket.Common;
using SuperSocket.SocketBase.Protocol;
using SuperSocket.WebSocket.Protocol;

namespace SuperSocket.WebSocket.Compatible
{
	internal class CompatibleReceiveFilter : ReceiveFilterBase<IWebSocketFragment>
	{
		private ICompatibleSession _appSession = null;

		public CompatibleReceiveFilter(ICompatibleSession appSession)
		{
			_appSession = appSession;
		}

		public override IWebSocketFragment Filter(byte[] readBuffer, int offset, int length, bool toBeCopied, out int rest)
		{
			rest = length;
			byte[] data = new byte[length];
			Buffer.BlockCopy(readBuffer, offset, data, 0, length);
			var nextFilter = _appSession.DetectedNonWebSocketFilter(data);
			NextReceiveFilter = nextFilter ?? new WebSocketHeaderReceiveFilter((IWebSocketSession)_appSession);
			return null;
		}
	}
}
