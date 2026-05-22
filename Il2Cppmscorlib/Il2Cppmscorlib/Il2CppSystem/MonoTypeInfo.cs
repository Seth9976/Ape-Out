using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem
{
	// Token: 0x0200010A RID: 266
	public class MonoTypeInfo : Object
	{
		// Token: 0x060013D7 RID: 5079 RVA: 0x0007FFE0 File Offset: 0x0007E1E0
		// Note: this type is marked as 'beforefieldinit'.
		static MonoTypeInfo()
		{
			Il2CppClassPointerStore<MonoTypeInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "MonoTypeInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoTypeInfo>.NativeClassPtr);
			MonoTypeInfo.NativeFieldInfoPtr_full_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTypeInfo>.NativeClassPtr, "full_name");
			MonoTypeInfo.NativeFieldInfoPtr_default_ctor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTypeInfo>.NativeClassPtr, "default_ctor");
			MonoTypeInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTypeInfo>.NativeClassPtr, 100666791);
		}

		// Token: 0x060013D8 RID: 5080 RVA: 0x0008004C File Offset: 0x0007E24C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoTypeInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoTypeInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTypeInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013D9 RID: 5081 RVA: 0x00006B2D File Offset: 0x00004D2D
		public MonoTypeInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x060013DA RID: 5082 RVA: 0x00080088 File Offset: 0x0007E288
		// (set) Token: 0x060013DB RID: 5083 RVA: 0x00006B36 File Offset: 0x00004D36
		public unsafe string full_name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTypeInfo.NativeFieldInfoPtr_full_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTypeInfo.NativeFieldInfoPtr_full_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x060013DC RID: 5084 RVA: 0x000800B0 File Offset: 0x0007E2B0
		// (set) Token: 0x060013DD RID: 5085 RVA: 0x00006B55 File Offset: 0x00004D55
		public unsafe MonoCMethod default_ctor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTypeInfo.NativeFieldInfoPtr_default_ctor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoCMethod>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTypeInfo.NativeFieldInfoPtr_default_ctor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001129 RID: 4393
		private static readonly IntPtr NativeFieldInfoPtr_full_name;

		// Token: 0x0400112A RID: 4394
		private static readonly IntPtr NativeFieldInfoPtr_default_ctor;

		// Token: 0x0400112B RID: 4395
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
