using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000265 RID: 613
	public class UnityEventQueueSystem
	{
		// Token: 0x060021FA RID: 8698 RVA: 0x000120AF File Offset: 0x000102AF
		public static string GenerateEventIdForPayload(string eventPayloadName)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060021FB RID: 8699 RVA: 0x000120BC File Offset: 0x000102BC
		public static IntPtr GetGlobalEventQueue()
		{
			return UnityEventQueueSystem.GetGlobalEventQueueDelegateField();
		}

		// Token: 0x04001BFF RID: 7167
		private static readonly UnityEventQueueSystem.GetGlobalEventQueueDelegate GetGlobalEventQueueDelegateField = IL2CPP.ResolveICall<UnityEventQueueSystem.GetGlobalEventQueueDelegate>("UnityEngine.UnityEventQueueSystem::GetGlobalEventQueue");

		// Token: 0x02000B9E RID: 2974
		// (Invoke) Token: 0x06003596 RID: 13718
		private delegate IntPtr GetGlobalEventQueueDelegate();
	}
}
