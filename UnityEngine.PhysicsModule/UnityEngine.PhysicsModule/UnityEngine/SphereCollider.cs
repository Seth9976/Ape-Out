using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200000F RID: 15
	public class SphereCollider : Collider
	{
		// Token: 0x0600014B RID: 331 RVA: 0x00006A7C File Offset: 0x00004C7C
		// Note: this type is marked as 'beforefieldinit'.
		static SphereCollider()
		{
			Il2CppClassPointerStore<SphereCollider>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PhysicsModule.dll", "UnityEngine", "SphereCollider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SphereCollider>.NativeClassPtr);
			SphereCollider.NativeMethodInfoPtr_get_center_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereCollider>.NativeClassPtr, 100663359);
			SphereCollider.NativeMethodInfoPtr_get_radius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereCollider>.NativeClassPtr, 100663360);
			SphereCollider.NativeMethodInfoPtr_get_center_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereCollider>.NativeClassPtr, 100663361);
			SphereCollider.set_radiusDelegateField = IL2CPP.ResolveICall<SphereCollider.set_radiusDelegate>("UnityEngine.SphereCollider::set_radius");
			SphereCollider.set_center_InjectedDelegateField = IL2CPP.ResolveICall<SphereCollider.set_center_InjectedDelegate>("UnityEngine.SphereCollider::set_center_Injected");
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600014C RID: 332 RVA: 0x00006B08 File Offset: 0x00004D08
		// (set) Token: 0x06000150 RID: 336 RVA: 0x00002C7A File Offset: 0x00000E7A
		public unsafe Vector3 center
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513703, XrefRangeEnd = 513705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereCollider.NativeMethodInfoPtr_get_center_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.set_center_Injected(ref value);
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600014D RID: 333 RVA: 0x00006B44 File Offset: 0x00004D44
		// (set) Token: 0x06000151 RID: 337 RVA: 0x00002C84 File Offset: 0x00000E84
		public unsafe float radius
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 513709, RefRangeEnd = 513711, XrefRangeStart = 513705, XrefRangeEnd = 513709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereCollider.NativeMethodInfoPtr_get_radius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				SphereCollider.set_radiusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00006B80 File Offset: 0x00004D80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513711, XrefRangeEnd = 513715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_center_Injected(out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereCollider.NativeMethodInfoPtr_get_center_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00002C71 File Offset: 0x00000E71
		public SphereCollider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00002C97 File Offset: 0x00000E97
		public void set_center_Injected(ref Vector3 value)
		{
			SphereCollider.set_center_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeMethodInfoPtr_get_center_Public_get_Vector3_0;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeMethodInfoPtr_get_radius_Public_get_Single_0;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeMethodInfoPtr_get_center_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x040000D9 RID: 217
		private static readonly SphereCollider.set_radiusDelegate set_radiusDelegateField;

		// Token: 0x040000DA RID: 218
		private static readonly SphereCollider.set_center_InjectedDelegate set_center_InjectedDelegateField;

		// Token: 0x02000095 RID: 149
		// (Invoke) Token: 0x0600044E RID: 1102
		private delegate void set_radiusDelegate(IntPtr @this, float value);

		// Token: 0x02000096 RID: 150
		// (Invoke) Token: 0x06000450 RID: 1104
		private delegate void set_center_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
