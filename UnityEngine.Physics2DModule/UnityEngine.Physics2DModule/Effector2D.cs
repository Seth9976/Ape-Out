using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000029 RID: 41
	public class Effector2D : Behaviour
	{
		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060003DE RID: 990 RVA: 0x00003ECD File Offset: 0x000020CD
		// (set) Token: 0x060003DF RID: 991 RVA: 0x00003EDF File Offset: 0x000020DF
		public bool useColliderMask
		{
			get
			{
				return Effector2D.get_useColliderMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Effector2D.set_useColliderMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060003E0 RID: 992 RVA: 0x00003EF2 File Offset: 0x000020F2
		// (set) Token: 0x060003E1 RID: 993 RVA: 0x00003F04 File Offset: 0x00002104
		public int colliderMask
		{
			get
			{
				return Effector2D.get_colliderMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Effector2D.set_colliderMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060003E2 RID: 994 RVA: 0x00003F17 File Offset: 0x00002117
		public bool requiresCollider
		{
			get
			{
				return Effector2D.get_requiresColliderDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060003E3 RID: 995 RVA: 0x00003F29 File Offset: 0x00002129
		public bool designedForTrigger
		{
			get
			{
				return Effector2D.get_designedForTriggerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060003E4 RID: 996 RVA: 0x00003F3B File Offset: 0x0000213B
		public bool designedForNonTrigger
		{
			get
			{
				return Effector2D.get_designedForNonTriggerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x0400026F RID: 623
		private static readonly Effector2D.get_useColliderMaskDelegate get_useColliderMaskDelegateField = IL2CPP.ResolveICall<Effector2D.get_useColliderMaskDelegate>("UnityEngine.Effector2D::get_useColliderMask");

		// Token: 0x04000270 RID: 624
		private static readonly Effector2D.set_useColliderMaskDelegate set_useColliderMaskDelegateField = IL2CPP.ResolveICall<Effector2D.set_useColliderMaskDelegate>("UnityEngine.Effector2D::set_useColliderMask");

		// Token: 0x04000271 RID: 625
		private static readonly Effector2D.get_colliderMaskDelegate get_colliderMaskDelegateField = IL2CPP.ResolveICall<Effector2D.get_colliderMaskDelegate>("UnityEngine.Effector2D::get_colliderMask");

		// Token: 0x04000272 RID: 626
		private static readonly Effector2D.set_colliderMaskDelegate set_colliderMaskDelegateField = IL2CPP.ResolveICall<Effector2D.set_colliderMaskDelegate>("UnityEngine.Effector2D::set_colliderMask");

		// Token: 0x04000273 RID: 627
		private static readonly Effector2D.get_requiresColliderDelegate get_requiresColliderDelegateField = IL2CPP.ResolveICall<Effector2D.get_requiresColliderDelegate>("UnityEngine.Effector2D::get_requiresCollider");

		// Token: 0x04000274 RID: 628
		private static readonly Effector2D.get_designedForTriggerDelegate get_designedForTriggerDelegateField = IL2CPP.ResolveICall<Effector2D.get_designedForTriggerDelegate>("UnityEngine.Effector2D::get_designedForTrigger");

		// Token: 0x04000275 RID: 629
		private static readonly Effector2D.get_designedForNonTriggerDelegate get_designedForNonTriggerDelegateField = IL2CPP.ResolveICall<Effector2D.get_designedForNonTriggerDelegate>("UnityEngine.Effector2D::get_designedForNonTrigger");

		// Token: 0x0200018F RID: 399
		// (Invoke) Token: 0x060006F4 RID: 1780
		private delegate bool get_useColliderMaskDelegate(IntPtr @this);

		// Token: 0x02000190 RID: 400
		// (Invoke) Token: 0x060006F6 RID: 1782
		private delegate void set_useColliderMaskDelegate(IntPtr @this, bool value);

		// Token: 0x02000191 RID: 401
		// (Invoke) Token: 0x060006F8 RID: 1784
		private delegate int get_colliderMaskDelegate(IntPtr @this);

		// Token: 0x02000192 RID: 402
		// (Invoke) Token: 0x060006FA RID: 1786
		private delegate void set_colliderMaskDelegate(IntPtr @this, int value);

		// Token: 0x02000193 RID: 403
		// (Invoke) Token: 0x060006FC RID: 1788
		private delegate bool get_requiresColliderDelegate(IntPtr @this);

		// Token: 0x02000194 RID: 404
		// (Invoke) Token: 0x060006FE RID: 1790
		private delegate bool get_designedForTriggerDelegate(IntPtr @this);

		// Token: 0x02000195 RID: 405
		// (Invoke) Token: 0x06000700 RID: 1792
		private delegate bool get_designedForNonTriggerDelegate(IntPtr @this);
	}
}
