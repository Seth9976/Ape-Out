using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200001F RID: 31
	public sealed class CapsuleCollider2D : Collider2D
	{
		// Token: 0x1700008C RID: 140
		// (get) Token: 0x0600036D RID: 877 RVA: 0x0000D53C File Offset: 0x0000B73C
		// (set) Token: 0x0600036E RID: 878 RVA: 0x000037C8 File Offset: 0x000019C8
		public Vector2 size
		{
			get
			{
				Vector2 vector;
				this.get_size_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_size_Injected(ref value);
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600036F RID: 879 RVA: 0x000037D2 File Offset: 0x000019D2
		// (set) Token: 0x06000370 RID: 880 RVA: 0x000037E4 File Offset: 0x000019E4
		public CapsuleDirection2D direction
		{
			get
			{
				return CapsuleCollider2D.get_directionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CapsuleCollider2D.set_directionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000371 RID: 881 RVA: 0x000037F7 File Offset: 0x000019F7
		public void get_size_Injected(out Vector2 ret)
		{
			CapsuleCollider2D.get_size_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000372 RID: 882 RVA: 0x0000380A File Offset: 0x00001A0A
		public void set_size_Injected(ref Vector2 value)
		{
			CapsuleCollider2D.set_size_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x04000214 RID: 532
		private static readonly CapsuleCollider2D.get_directionDelegate get_directionDelegateField = IL2CPP.ResolveICall<CapsuleCollider2D.get_directionDelegate>("UnityEngine.CapsuleCollider2D::get_direction");

		// Token: 0x04000215 RID: 533
		private static readonly CapsuleCollider2D.set_directionDelegate set_directionDelegateField = IL2CPP.ResolveICall<CapsuleCollider2D.set_directionDelegate>("UnityEngine.CapsuleCollider2D::set_direction");

		// Token: 0x04000216 RID: 534
		private static readonly CapsuleCollider2D.get_size_InjectedDelegate get_size_InjectedDelegateField = IL2CPP.ResolveICall<CapsuleCollider2D.get_size_InjectedDelegate>("UnityEngine.CapsuleCollider2D::get_size_Injected");

		// Token: 0x04000217 RID: 535
		private static readonly CapsuleCollider2D.set_size_InjectedDelegate set_size_InjectedDelegateField = IL2CPP.ResolveICall<CapsuleCollider2D.set_size_InjectedDelegate>("UnityEngine.CapsuleCollider2D::set_size_Injected");

		// Token: 0x02000132 RID: 306
		// (Invoke) Token: 0x0600063E RID: 1598
		private delegate CapsuleDirection2D get_directionDelegate(IntPtr @this);

		// Token: 0x02000133 RID: 307
		// (Invoke) Token: 0x06000640 RID: 1600
		private delegate void set_directionDelegate(IntPtr @this, CapsuleDirection2D value);

		// Token: 0x02000134 RID: 308
		// (Invoke) Token: 0x06000642 RID: 1602
		private delegate void get_size_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000135 RID: 309
		// (Invoke) Token: 0x06000644 RID: 1604
		private delegate void set_size_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
