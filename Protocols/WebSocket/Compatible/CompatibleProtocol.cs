using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Protocol;
using SuperSocket.WebSocket.Protocol;

namespace SuperSocket.WebSocket.Compatible
{
	/// <summary>
	/// Compatible protocol
	/// </summary>
	public class CompatibleProtocol : IReceiveFilterFactory<IWebSocketFragment>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="WebSocketProtocol"/> class.
		/// </summary>
		public CompatibleProtocol() { }

		/// <summary>
		/// Creates the compatible filter.
		/// </summary>
		/// <param name="appServer">The app server.</param>
		/// <param name="appSession">The app session.</param>
		/// <param name="remoteEndPoint">The remote end point.</param>
		/// <returns></returns>
		public IReceiveFilter<IWebSocketFragment> CreateFilter(
			IAppServer appServer, IAppSession appSession, IPEndPoint remoteEndPoint)
		{
			return new CompatibleReceiveFilter((ICompatibleSession)appSession);
		}
	}
}
