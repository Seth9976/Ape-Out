using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000212 RID: 530
	public sealed class OcclusionPortal : Component
	{
		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x06002109 RID: 8457 RVA: 0x00011571 File Offset: 0x0000F771
		// (set) Token: 0x0600210A RID: 8458 RVA: 0x00011583 File Offset: 0x0000F783
		public bool open
		{
			get
			{
				return OcclusionPortal.get_openDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				OcclusionPortal.set_openDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x04001AD3 RID: 6867
		private static readonly OcclusionPortal.get_openDelegate get_openDelegateField = IL2CPP.ResolveICall<OcclusionPortal.get_openDelegate>("UnityEngine.OcclusionPortal::get_open");

		// Token: 0x04001AD4 RID: 6868
		private static readonly OcclusionPortal.set_openDelegate set_openDelegateField = IL2CPP.ResolveICall<OcclusionPortal.set_openDelegate>("UnityEngine.OcclusionPortal::set_open");

		// Token: 0x02000B23 RID: 2851
		// (Invoke) Token: 0x060034A6 RID: 13478
		private delegate bool get_openDelegate(IntPtr @this);

		// Token: 0x02000B24 RID: 2852
		// (Invoke) Token: 0x060034A8 RID: 13480
		private delegate void set_openDelegate(IntPtr @this, bool value);
	}
}
