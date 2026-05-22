using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200000E RID: 14
	public class BoxCollider : Collider
	{
		// Token: 0x0600013F RID: 319 RVA: 0x000068C0 File Offset: 0x00004AC0
		// Note: this type is marked as 'beforefieldinit'.
		static BoxCollider()
		{
			Il2CppClassPointerStore<BoxCollider>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PhysicsModule.dll", "UnityEngine", "BoxCollider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoxCollider>.NativeClassPtr);
			BoxCollider.NativeMethodInfoPtr_get_center_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxCollider>.NativeClassPtr, 100663355);
			BoxCollider.NativeMethodInfoPtr_get_size_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxCollider>.NativeClassPtr, 100663356);
			BoxCollider.NativeMethodInfoPtr_get_center_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxCollider>.NativeClassPtr, 100663357);
			BoxCollider.NativeMethodInfoPtr_get_size_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxCollider>.NativeClassPtr, 100663358);
			BoxCollider.set_center_InjectedDelegateField = IL2CPP.ResolveICall<BoxCollider.set_center_InjectedDelegate>("UnityEngine.BoxCollider::set_center_Injected");
			BoxCollider.set_size_InjectedDelegateField = IL2CPP.ResolveICall<BoxCollider.set_size_InjectedDelegate>("UnityEngine.BoxCollider::set_size_Injected");
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000140 RID: 320 RVA: 0x00006960 File Offset: 0x00004B60
		// (set) Token: 0x06000145 RID: 325 RVA: 0x00002C22 File Offset: 0x00000E22
		public unsafe Vector3 center
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513691, XrefRangeEnd = 513693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxCollider.NativeMethodInfoPtr_get_center_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.set_center_Injected(ref value);
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000141 RID: 321 RVA: 0x0000699C File Offset: 0x00004B9C
		// (set) Token: 0x06000146 RID: 326 RVA: 0x00002C2C File Offset: 0x00000E2C
		public unsafe Vector3 size
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513693, XrefRangeEnd = 513695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxCollider.NativeMethodInfoPtr_get_size_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.set_size_Injected(ref value);
			}
		}

		// Token: 0x06000142 RID: 322 RVA: 0x000069D8 File Offset: 0x00004BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513695, XrefRangeEnd = 513699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_center_Injected(out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxCollider.NativeMethodInfoPtr_get_center_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00006A18 File Offset: 0x00004C18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513699, XrefRangeEnd = 513703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_size_Injected(out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxCollider.NativeMethodInfoPtr_get_size_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00002C19 File Offset: 0x00000E19
		public BoxCollider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000147 RID: 327 RVA: 0x00006A58 File Offset: 0x00004C58
		// (set) Token: 0x06000148 RID: 328 RVA: 0x00002C36 File Offset: 0x00000E36
		public Vector3 extents
		{
			get
			{
				return this.size * 0.5f;
			}
			set
			{
				this.size = value * 2f;
			}
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00002C4B File Offset: 0x00000E4B
		public void set_center_Injected(ref Vector3 value)
		{
			BoxCollider.set_center_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00002C5E File Offset: 0x00000E5E
		public void set_size_Injected(ref Vector3 value)
		{
			BoxCollider.set_size_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeMethodInfoPtr_get_center_Public_get_Vector3_0;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeMethodInfoPtr_get_size_Public_get_Vector3_0;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeMethodInfoPtr_get_center_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeMethodInfoPtr_get_size_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x040000D4 RID: 212
		private static readonly BoxCollider.set_center_InjectedDelegate set_center_InjectedDelegateField;

		// Token: 0x040000D5 RID: 213
		private static readonly BoxCollider.set_size_InjectedDelegate set_size_InjectedDelegateField;

		// Token: 0x02000093 RID: 147
		// (Invoke) Token: 0x0600044A RID: 1098
		private delegate void set_center_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000094 RID: 148
		// (Invoke) Token: 0x0600044C RID: 1100
		private delegate void set_size_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
