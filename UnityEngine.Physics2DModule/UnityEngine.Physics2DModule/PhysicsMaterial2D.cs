using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000017 RID: 23
	public sealed class PhysicsMaterial2D : Object
	{
		// Token: 0x06000361 RID: 865 RVA: 0x0000D458 File Offset: 0x0000B658
		// Note: this type is marked as 'beforefieldinit'.
		static PhysicsMaterial2D()
		{
			Il2CppClassPointerStore<PhysicsMaterial2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Physics2DModule.dll", "UnityEngine", "PhysicsMaterial2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhysicsMaterial2D>.NativeClassPtr);
			PhysicsMaterial2D.Create_InternalDelegateField = IL2CPP.ResolveICall<PhysicsMaterial2D.Create_InternalDelegate>("UnityEngine.PhysicsMaterial2D::Create_Internal");
			PhysicsMaterial2D.get_bouncinessDelegateField = IL2CPP.ResolveICall<PhysicsMaterial2D.get_bouncinessDelegate>("UnityEngine.PhysicsMaterial2D::get_bounciness");
			PhysicsMaterial2D.set_bouncinessDelegateField = IL2CPP.ResolveICall<PhysicsMaterial2D.set_bouncinessDelegate>("UnityEngine.PhysicsMaterial2D::set_bounciness");
			PhysicsMaterial2D.get_frictionDelegateField = IL2CPP.ResolveICall<PhysicsMaterial2D.get_frictionDelegate>("UnityEngine.PhysicsMaterial2D::get_friction");
			PhysicsMaterial2D.set_frictionDelegateField = IL2CPP.ResolveICall<PhysicsMaterial2D.set_frictionDelegate>("UnityEngine.PhysicsMaterial2D::set_friction");
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00003700 File Offset: 0x00001900
		public PhysicsMaterial2D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00003709 File Offset: 0x00001909
		public static void Create_Internal(PhysicsMaterial2D scriptMaterial, string name)
		{
			PhysicsMaterial2D.Create_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(scriptMaterial), IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000364 RID: 868 RVA: 0x00003721 File Offset: 0x00001921
		// (set) Token: 0x06000365 RID: 869 RVA: 0x00003733 File Offset: 0x00001933
		public float bounciness
		{
			get
			{
				return PhysicsMaterial2D.get_bouncinessDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PhysicsMaterial2D.set_bouncinessDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000366 RID: 870 RVA: 0x00003746 File Offset: 0x00001946
		// (set) Token: 0x06000367 RID: 871 RVA: 0x00003758 File Offset: 0x00001958
		public float friction
		{
			get
			{
				return PhysicsMaterial2D.get_frictionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PhysicsMaterial2D.set_frictionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x040001F4 RID: 500
		private static readonly PhysicsMaterial2D.Create_InternalDelegate Create_InternalDelegateField;

		// Token: 0x040001F5 RID: 501
		private static readonly PhysicsMaterial2D.get_bouncinessDelegate get_bouncinessDelegateField;

		// Token: 0x040001F6 RID: 502
		private static readonly PhysicsMaterial2D.set_bouncinessDelegate set_bouncinessDelegateField;

		// Token: 0x040001F7 RID: 503
		private static readonly PhysicsMaterial2D.get_frictionDelegate get_frictionDelegateField;

		// Token: 0x040001F8 RID: 504
		private static readonly PhysicsMaterial2D.set_frictionDelegate set_frictionDelegateField;

		// Token: 0x0200012C RID: 300
		// (Invoke) Token: 0x06000632 RID: 1586
		private delegate void Create_InternalDelegate(IntPtr scriptMaterial, IntPtr name);

		// Token: 0x0200012D RID: 301
		// (Invoke) Token: 0x06000634 RID: 1588
		private delegate float get_bouncinessDelegate(IntPtr @this);

		// Token: 0x0200012E RID: 302
		// (Invoke) Token: 0x06000636 RID: 1590
		private delegate void set_bouncinessDelegate(IntPtr @this, float value);

		// Token: 0x0200012F RID: 303
		// (Invoke) Token: 0x06000638 RID: 1592
		private delegate float get_frictionDelegate(IntPtr @this);

		// Token: 0x02000130 RID: 304
		// (Invoke) Token: 0x0600063A RID: 1594
		private delegate void set_frictionDelegate(IntPtr @this, float value);
	}
}
