using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000112 RID: 274
	public sealed class DelegateData : Object
	{
		// Token: 0x06001453 RID: 5203 RVA: 0x00081580 File Offset: 0x0007F780
		// Note: this type is marked as 'beforefieldinit'.
		static DelegateData()
		{
			Il2CppClassPointerStore<DelegateData>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "DelegateData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DelegateData>.NativeClassPtr);
			DelegateData.NativeFieldInfoPtr_target_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateData>.NativeClassPtr, "target_type");
			DelegateData.NativeFieldInfoPtr_method_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateData>.NativeClassPtr, "method_name");
			DelegateData.NativeFieldInfoPtr_curried_first_arg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateData>.NativeClassPtr, "curried_first_arg");
			DelegateData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateData>.NativeClassPtr, 100666840);
		}

		// Token: 0x06001454 RID: 5204 RVA: 0x00081600 File Offset: 0x0007F800
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DelegateData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DelegateData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001455 RID: 5205 RVA: 0x00006F98 File Offset: 0x00005198
		public DelegateData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06001456 RID: 5206 RVA: 0x0008163C File Offset: 0x0007F83C
		// (set) Token: 0x06001457 RID: 5207 RVA: 0x00006FA1 File Offset: 0x000051A1
		public unsafe Type target_type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateData.NativeFieldInfoPtr_target_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateData.NativeFieldInfoPtr_target_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06001458 RID: 5208 RVA: 0x0008166C File Offset: 0x0007F86C
		// (set) Token: 0x06001459 RID: 5209 RVA: 0x00006FC0 File Offset: 0x000051C0
		public unsafe string method_name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateData.NativeFieldInfoPtr_method_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateData.NativeFieldInfoPtr_method_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x0600145A RID: 5210 RVA: 0x00081694 File Offset: 0x0007F894
		// (set) Token: 0x0600145B RID: 5211 RVA: 0x00006FDF File Offset: 0x000051DF
		public unsafe bool curried_first_arg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateData.NativeFieldInfoPtr_curried_first_arg);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateData.NativeFieldInfoPtr_curried_first_arg)) = value;
			}
		}

		// Token: 0x04001176 RID: 4470
		private static readonly IntPtr NativeFieldInfoPtr_target_type;

		// Token: 0x04001177 RID: 4471
		private static readonly IntPtr NativeFieldInfoPtr_method_name;

		// Token: 0x04001178 RID: 4472
		private static readonly IntPtr NativeFieldInfoPtr_curried_first_arg;

		// Token: 0x04001179 RID: 4473
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
