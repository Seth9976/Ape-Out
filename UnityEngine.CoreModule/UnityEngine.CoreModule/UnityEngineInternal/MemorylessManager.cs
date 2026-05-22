using System;
using Il2CppInterop.Runtime;

namespace UnityEngineInternal
{
	// Token: 0x020001B4 RID: 436
	public class MemorylessManager
	{
		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x06001FA8 RID: 8104 RVA: 0x00073B78 File Offset: 0x00071D78
		// (set) Token: 0x06001FA9 RID: 8105 RVA: 0x0001067E File Offset: 0x0000E87E
		public static MemorylessMode depthMemorylessMode
		{
			get
			{
				return MemorylessManager.GetFramebufferDepthMemorylessMode();
			}
			set
			{
				MemorylessManager.SetFramebufferDepthMemorylessMode(value);
			}
		}

		// Token: 0x06001FAA RID: 8106 RVA: 0x00010688 File Offset: 0x0000E888
		public static MemorylessMode GetFramebufferDepthMemorylessMode()
		{
			return MemorylessManager.GetFramebufferDepthMemorylessModeDelegateField();
		}

		// Token: 0x06001FAB RID: 8107 RVA: 0x00010694 File Offset: 0x0000E894
		public static void SetFramebufferDepthMemorylessMode(MemorylessMode mode)
		{
			MemorylessManager.SetFramebufferDepthMemorylessModeDelegateField(mode);
		}

		// Token: 0x040019A5 RID: 6565
		private static readonly MemorylessManager.GetFramebufferDepthMemorylessModeDelegate GetFramebufferDepthMemorylessModeDelegateField = IL2CPP.ResolveICall<MemorylessManager.GetFramebufferDepthMemorylessModeDelegate>("UnityEngineInternal.MemorylessManager::GetFramebufferDepthMemorylessMode");

		// Token: 0x040019A6 RID: 6566
		private static readonly MemorylessManager.SetFramebufferDepthMemorylessModeDelegate SetFramebufferDepthMemorylessModeDelegateField = IL2CPP.ResolveICall<MemorylessManager.SetFramebufferDepthMemorylessModeDelegate>("UnityEngineInternal.MemorylessManager::SetFramebufferDepthMemorylessMode");

		// Token: 0x02000A8D RID: 2701
		// (Invoke) Token: 0x0600339A RID: 13210
		private delegate MemorylessMode GetFramebufferDepthMemorylessModeDelegate();

		// Token: 0x02000A8E RID: 2702
		// (Invoke) Token: 0x0600339C RID: 13212
		private delegate void SetFramebufferDepthMemorylessModeDelegate(MemorylessMode mode);
	}
}
