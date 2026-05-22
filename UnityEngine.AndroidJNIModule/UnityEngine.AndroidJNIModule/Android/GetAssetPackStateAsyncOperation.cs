using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine.Android
{
	// Token: 0x02000016 RID: 22
	public class GetAssetPackStateAsyncOperation : CustomYieldInstruction
	{
		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x00002889 File Offset: 0x00000A89
		public override bool keepWaiting
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060001DA RID: 474 RVA: 0x00002896 File Offset: 0x00000A96
		public bool isDone
		{
			get
			{
				return !this.keepWaiting;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060001DB RID: 475 RVA: 0x000028A1 File Offset: 0x00000AA1
		public ulong size
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060001DC RID: 476 RVA: 0x000028AE File Offset: 0x00000AAE
		public Il2CppReferenceArray<AndroidAssetPackState> states
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x060001DD RID: 477 RVA: 0x000028BB File Offset: 0x00000ABB
		public void OnResult(ulong size, Il2CppReferenceArray<AndroidAssetPackState> states)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
