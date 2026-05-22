using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000214 RID: 532
	public sealed class Flare : Object
	{
		// Token: 0x06002115 RID: 8469 RVA: 0x00011645 File Offset: 0x0000F845
		public static void Internal_Create(Flare self)
		{
			Flare.Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self));
		}

		// Token: 0x04001AD9 RID: 6873
		private static readonly Flare.Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<Flare.Internal_CreateDelegate>("UnityEngine.Flare::Internal_Create");

		// Token: 0x02000B29 RID: 2857
		// (Invoke) Token: 0x060034B2 RID: 13490
		private delegate void Internal_CreateDelegate(IntPtr self);
	}
}
