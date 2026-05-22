using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine.Android
{
	// Token: 0x02000015 RID: 21
	public class DownloadAssetPackAsyncOperation : CustomYieldInstruction
	{
		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x0000283D File Offset: 0x00000A3D
		public override bool keepWaiting
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x0000284A File Offset: 0x00000A4A
		public bool isDone
		{
			get
			{
				return !this.keepWaiting;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x00002855 File Offset: 0x00000A55
		public float progress
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x00002862 File Offset: 0x00000A62
		public Il2CppStringArray downloadedAssetPacks
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x0000286F File Offset: 0x00000A6F
		public Il2CppStringArray downloadFailedAssetPacks
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0000287C File Offset: 0x00000A7C
		public void OnUpdate(AndroidAssetPackInfo info)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x02000071 RID: 113
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
