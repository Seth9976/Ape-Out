using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000213 RID: 531
	public sealed class OcclusionArea : Component
	{
		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x0600210C RID: 8460 RVA: 0x00075948 File Offset: 0x00073B48
		// (set) Token: 0x0600210D RID: 8461 RVA: 0x000115D4 File Offset: 0x0000F7D4
		public Vector3 center
		{
			get
			{
				Vector3 vector;
				this.get_center_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_center_Injected(ref value);
			}
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x0600210E RID: 8462 RVA: 0x00075960 File Offset: 0x00073B60
		// (set) Token: 0x0600210F RID: 8463 RVA: 0x000115DE File Offset: 0x0000F7DE
		public Vector3 size
		{
			get
			{
				Vector3 vector;
				this.get_size_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_size_Injected(ref value);
			}
		}

		// Token: 0x06002110 RID: 8464 RVA: 0x000115E8 File Offset: 0x0000F7E8
		public void get_center_Injected(out Vector3 ret)
		{
			OcclusionArea.get_center_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06002111 RID: 8465 RVA: 0x000115FB File Offset: 0x0000F7FB
		public void set_center_Injected(ref Vector3 value)
		{
			OcclusionArea.set_center_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06002112 RID: 8466 RVA: 0x0001160E File Offset: 0x0000F80E
		public void get_size_Injected(out Vector3 ret)
		{
			OcclusionArea.get_size_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06002113 RID: 8467 RVA: 0x00011621 File Offset: 0x0000F821
		public void set_size_Injected(ref Vector3 value)
		{
			OcclusionArea.set_size_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x04001AD5 RID: 6869
		private static readonly OcclusionArea.get_center_InjectedDelegate get_center_InjectedDelegateField = IL2CPP.ResolveICall<OcclusionArea.get_center_InjectedDelegate>("UnityEngine.OcclusionArea::get_center_Injected");

		// Token: 0x04001AD6 RID: 6870
		private static readonly OcclusionArea.set_center_InjectedDelegate set_center_InjectedDelegateField = IL2CPP.ResolveICall<OcclusionArea.set_center_InjectedDelegate>("UnityEngine.OcclusionArea::set_center_Injected");

		// Token: 0x04001AD7 RID: 6871
		private static readonly OcclusionArea.get_size_InjectedDelegate get_size_InjectedDelegateField = IL2CPP.ResolveICall<OcclusionArea.get_size_InjectedDelegate>("UnityEngine.OcclusionArea::get_size_Injected");

		// Token: 0x04001AD8 RID: 6872
		private static readonly OcclusionArea.set_size_InjectedDelegate set_size_InjectedDelegateField = IL2CPP.ResolveICall<OcclusionArea.set_size_InjectedDelegate>("UnityEngine.OcclusionArea::set_size_Injected");

		// Token: 0x02000B25 RID: 2853
		// (Invoke) Token: 0x060034AA RID: 13482
		private delegate void get_center_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000B26 RID: 2854
		// (Invoke) Token: 0x060034AC RID: 13484
		private delegate void set_center_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000B27 RID: 2855
		// (Invoke) Token: 0x060034AE RID: 13486
		private delegate void get_size_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000B28 RID: 2856
		// (Invoke) Token: 0x060034B0 RID: 13488
		private delegate void set_size_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
