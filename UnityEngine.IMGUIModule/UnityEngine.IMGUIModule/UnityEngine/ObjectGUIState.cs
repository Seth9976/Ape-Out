using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200002B RID: 43
	public class ObjectGUIState
	{
		// Token: 0x06000626 RID: 1574 RVA: 0x000047DF File Offset: 0x000029DF
		public void Dispose()
		{
			this.Destroy();
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00017FF8 File Offset: 0x000161F8
		public ~ObjectGUIState()
		{
			this.Destroy();
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x000047F0 File Offset: 0x000029F0
		public void Destroy()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x000047FD File Offset: 0x000029FD
		public static IntPtr Internal_Create()
		{
			return ObjectGUIState.Internal_CreateDelegateField();
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00004809 File Offset: 0x00002A09
		public static void Internal_Destroy(IntPtr ptr)
		{
			ObjectGUIState.Internal_DestroyDelegateField(ptr);
		}

		// Token: 0x040003BD RID: 957
		private static readonly ObjectGUIState.Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<ObjectGUIState.Internal_CreateDelegate>("UnityEngine.ObjectGUIState::Internal_Create");

		// Token: 0x040003BE RID: 958
		private static readonly ObjectGUIState.Internal_DestroyDelegate Internal_DestroyDelegateField = IL2CPP.ResolveICall<ObjectGUIState.Internal_DestroyDelegate>("UnityEngine.ObjectGUIState::Internal_Destroy");

		// Token: 0x020000A7 RID: 167
		// (Invoke) Token: 0x06000728 RID: 1832
		private delegate IntPtr Internal_CreateDelegate();

		// Token: 0x020000A8 RID: 168
		// (Invoke) Token: 0x0600072A RID: 1834
		private delegate void Internal_DestroyDelegate(IntPtr ptr);
	}
}
