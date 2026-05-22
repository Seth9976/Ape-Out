using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using UnityEngine.Networking.PlayerConnection;

namespace UnityEngine.Diagnostics
{
	// Token: 0x020002CE RID: 718
	public static class PlayerConnection
	{
		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x060022FB RID: 8955 RVA: 0x00078A38 File Offset: 0x00076C38
		public static bool connected
		{
			get
			{
				return UnityEngine.Networking.PlayerConnection.PlayerConnection.instance.isConnected;
			}
		}

		// Token: 0x060022FC RID: 8956 RVA: 0x00012B32 File Offset: 0x00010D32
		public static void SendFile(string remoteFilePath, Il2CppStructArray<byte> data)
		{
		}
	}
}
