using System;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200000F RID: 15
	public class DisposeHelper
	{
		// Token: 0x0600002F RID: 47 RVA: 0x0000863C File Offset: 0x0000683C
		public static void NotifyMissingDispose(IDisposable disposable)
		{
			bool flag = disposable == null;
			if (!flag)
			{
				Debug.LogError(String.Concat("An IDisposable instance of type '", disposable.GetType().FullName, "' has not been disposed."));
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002254 File Offset: 0x00000454
		public static void NotifyDisposedUsed(IDisposable disposable)
		{
			Debug.LogError(String.Concat("An instance of type '", disposable.GetType().FullName, "' is being used although it has been disposed."));
		}
	}
}
