using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200000D RID: 13
	public class CapsuleCollider : Collider
	{
		// Token: 0x0600012F RID: 303 RVA: 0x0000676C File Offset: 0x0000496C
		// Note: this type is marked as 'beforefieldinit'.
		static CapsuleCollider()
		{
			Il2CppClassPointerStore<CapsuleCollider>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PhysicsModule.dll", "UnityEngine", "CapsuleCollider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CapsuleCollider>.NativeClassPtr);
			CapsuleCollider.NativeMethodInfoPtr_set_height_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CapsuleCollider>.NativeClassPtr, 100663354);
			CapsuleCollider.get_radiusDelegateField = IL2CPP.ResolveICall<CapsuleCollider.get_radiusDelegate>("UnityEngine.CapsuleCollider::get_radius");
			CapsuleCollider.set_radiusDelegateField = IL2CPP.ResolveICall<CapsuleCollider.set_radiusDelegate>("UnityEngine.CapsuleCollider::set_radius");
			CapsuleCollider.get_heightDelegateField = IL2CPP.ResolveICall<CapsuleCollider.get_heightDelegate>("UnityEngine.CapsuleCollider::get_height");
			CapsuleCollider.get_directionDelegateField = IL2CPP.ResolveICall<CapsuleCollider.get_directionDelegate>("UnityEngine.CapsuleCollider::get_direction");
			CapsuleCollider.set_directionDelegateField = IL2CPP.ResolveICall<CapsuleCollider.set_directionDelegate>("UnityEngine.CapsuleCollider::set_direction");
			CapsuleCollider.get_center_InjectedDelegateField = IL2CPP.ResolveICall<CapsuleCollider.get_center_InjectedDelegate>("UnityEngine.CapsuleCollider::get_center_Injected");
			CapsuleCollider.set_center_InjectedDelegateField = IL2CPP.ResolveICall<CapsuleCollider.set_center_InjectedDelegate>("UnityEngine.CapsuleCollider::set_center_Injected");
			CapsuleCollider.GetGlobalExtents_InjectedDelegateField = IL2CPP.ResolveICall<CapsuleCollider.GetGlobalExtents_InjectedDelegate>("UnityEngine.CapsuleCollider::GetGlobalExtents_Injected");
			CapsuleCollider.CalculateTransform_InjectedDelegateField = IL2CPP.ResolveICall<CapsuleCollider.CalculateTransform_InjectedDelegate>("UnityEngine.CapsuleCollider::CalculateTransform_Injected");
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000136 RID: 310 RVA: 0x00002B96 File Offset: 0x00000D96
		// (set) Token: 0x06000130 RID: 304 RVA: 0x00006838 File Offset: 0x00004A38
		public unsafe float height
		{
			get
			{
				return CapsuleCollider.get_heightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513687, XrefRangeEnd = 513691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CapsuleCollider.NativeMethodInfoPtr_set_height_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00002B5E File Offset: 0x00000D5E
		public CapsuleCollider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000132 RID: 306 RVA: 0x00006878 File Offset: 0x00004A78
		// (set) Token: 0x06000133 RID: 307 RVA: 0x00002B67 File Offset: 0x00000D67
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

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000134 RID: 308 RVA: 0x00002B71 File Offset: 0x00000D71
		// (set) Token: 0x06000135 RID: 309 RVA: 0x00002B83 File Offset: 0x00000D83
		public float radius
		{
			get
			{
				return CapsuleCollider.get_radiusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CapsuleCollider.set_radiusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000137 RID: 311 RVA: 0x00002BA8 File Offset: 0x00000DA8
		// (set) Token: 0x06000138 RID: 312 RVA: 0x00002BBA File Offset: 0x00000DBA
		public int direction
		{
			get
			{
				return CapsuleCollider.get_directionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CapsuleCollider.set_directionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00006890 File Offset: 0x00004A90
		public Vector2 GetGlobalExtents()
		{
			Vector2 vector;
			this.GetGlobalExtents_Injected(out vector);
			return vector;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x000068A8 File Offset: 0x00004AA8
		public Matrix4x4 CalculateTransform()
		{
			Matrix4x4 matrix4x;
			this.CalculateTransform_Injected(out matrix4x);
			return matrix4x;
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00002BCD File Offset: 0x00000DCD
		public void get_center_Injected(out Vector3 ret)
		{
			CapsuleCollider.get_center_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00002BE0 File Offset: 0x00000DE0
		public void set_center_Injected(ref Vector3 value)
		{
			CapsuleCollider.set_center_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00002BF3 File Offset: 0x00000DF3
		public void GetGlobalExtents_Injected(out Vector2 ret)
		{
			CapsuleCollider.GetGlobalExtents_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00002C06 File Offset: 0x00000E06
		public void CalculateTransform_Injected(out Matrix4x4 ret)
		{
			CapsuleCollider.CalculateTransform_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeMethodInfoPtr_set_height_Public_set_Void_Single_0;

		// Token: 0x040000C7 RID: 199
		private static readonly CapsuleCollider.get_radiusDelegate get_radiusDelegateField;

		// Token: 0x040000C8 RID: 200
		private static readonly CapsuleCollider.set_radiusDelegate set_radiusDelegateField;

		// Token: 0x040000C9 RID: 201
		private static readonly CapsuleCollider.get_heightDelegate get_heightDelegateField;

		// Token: 0x040000CA RID: 202
		private static readonly CapsuleCollider.get_directionDelegate get_directionDelegateField;

		// Token: 0x040000CB RID: 203
		private static readonly CapsuleCollider.set_directionDelegate set_directionDelegateField;

		// Token: 0x040000CC RID: 204
		private static readonly CapsuleCollider.get_center_InjectedDelegate get_center_InjectedDelegateField;

		// Token: 0x040000CD RID: 205
		private static readonly CapsuleCollider.set_center_InjectedDelegate set_center_InjectedDelegateField;

		// Token: 0x040000CE RID: 206
		private static readonly CapsuleCollider.GetGlobalExtents_InjectedDelegate GetGlobalExtents_InjectedDelegateField;

		// Token: 0x040000CF RID: 207
		private static readonly CapsuleCollider.CalculateTransform_InjectedDelegate CalculateTransform_InjectedDelegateField;

		// Token: 0x0200008A RID: 138
		// (Invoke) Token: 0x06000438 RID: 1080
		private delegate float get_radiusDelegate(IntPtr @this);

		// Token: 0x0200008B RID: 139
		// (Invoke) Token: 0x0600043A RID: 1082
		private delegate void set_radiusDelegate(IntPtr @this, float value);

		// Token: 0x0200008C RID: 140
		// (Invoke) Token: 0x0600043C RID: 1084
		private delegate float get_heightDelegate(IntPtr @this);

		// Token: 0x0200008D RID: 141
		// (Invoke) Token: 0x0600043E RID: 1086
		private delegate int get_directionDelegate(IntPtr @this);

		// Token: 0x0200008E RID: 142
		// (Invoke) Token: 0x06000440 RID: 1088
		private delegate void set_directionDelegate(IntPtr @this, int value);

		// Token: 0x0200008F RID: 143
		// (Invoke) Token: 0x06000442 RID: 1090
		private delegate void get_center_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000090 RID: 144
		// (Invoke) Token: 0x06000444 RID: 1092
		private delegate void set_center_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000091 RID: 145
		// (Invoke) Token: 0x06000446 RID: 1094
		private delegate void GetGlobalExtents_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000092 RID: 146
		// (Invoke) Token: 0x06000448 RID: 1096
		private delegate void CalculateTransform_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);
	}
}
