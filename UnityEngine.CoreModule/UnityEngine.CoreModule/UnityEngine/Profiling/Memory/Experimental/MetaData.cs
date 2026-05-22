using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Profiling.Memory.Experimental
{
	// Token: 0x0200010F RID: 271
	public class MetaData : Object
	{
		// Token: 0x06001708 RID: 5896 RVA: 0x00059500 File Offset: 0x00057700
		// Note: this type is marked as 'beforefieldinit'.
		static MetaData()
		{
			Il2CppClassPointerStore<MetaData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Profiling.Memory.Experimental", "MetaData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MetaData>.NativeClassPtr);
			MetaData.NativeFieldInfoPtr_content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaData>.NativeClassPtr, "content");
			MetaData.NativeFieldInfoPtr_platform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaData>.NativeClassPtr, "platform");
			MetaData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaData>.NativeClassPtr, 100665343);
		}

		// Token: 0x06001709 RID: 5897 RVA: 0x0005956C File Offset: 0x0005776C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MetaData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MetaData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetaData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600170A RID: 5898 RVA: 0x0000C515 File Offset: 0x0000A715
		public MetaData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x0600170B RID: 5899 RVA: 0x000595A8 File Offset: 0x000577A8
		// (set) Token: 0x0600170C RID: 5900 RVA: 0x0000C51E File Offset: 0x0000A71E
		public unsafe string content
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaData.NativeFieldInfoPtr_content);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaData.NativeFieldInfoPtr_content), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x0600170D RID: 5901 RVA: 0x000595D0 File Offset: 0x000577D0
		// (set) Token: 0x0600170E RID: 5902 RVA: 0x0000C53D File Offset: 0x0000A73D
		public unsafe string platform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaData.NativeFieldInfoPtr_platform);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaData.NativeFieldInfoPtr_platform), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001200 RID: 4608
		private static readonly IntPtr NativeFieldInfoPtr_content;

		// Token: 0x04001201 RID: 4609
		private static readonly IntPtr NativeFieldInfoPtr_platform;

		// Token: 0x04001202 RID: 4610
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
