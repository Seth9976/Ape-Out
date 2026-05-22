using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net.Cache
{
	// Token: 0x02000172 RID: 370
	public class RequestCachePolicy : Object
	{
		// Token: 0x060016FC RID: 5884 RVA: 0x00066B5C File Offset: 0x00064D5C
		// Note: this type is marked as 'beforefieldinit'.
		static RequestCachePolicy()
		{
			Il2CppClassPointerStore<RequestCachePolicy>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Cache", "RequestCachePolicy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestCachePolicy>.NativeClassPtr);
			RequestCachePolicy.NativeFieldInfoPtr_m_Level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestCachePolicy>.NativeClassPtr, "m_Level");
			RequestCachePolicy.NativeMethodInfoPtr_get_Level_Public_get_RequestCacheLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestCachePolicy>.NativeClassPtr, 100666528);
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x060016FD RID: 5885 RVA: 0x00066BB4 File Offset: 0x00064DB4
		public unsafe RequestCacheLevel Level
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestCachePolicy.NativeMethodInfoPtr_get_Level_Public_get_RequestCacheLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060016FE RID: 5886 RVA: 0x0000B764 File Offset: 0x00009964
		public RequestCachePolicy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x060016FF RID: 5887 RVA: 0x00066BF0 File Offset: 0x00064DF0
		// (set) Token: 0x06001700 RID: 5888 RVA: 0x0000B76D File Offset: 0x0000996D
		public unsafe RequestCacheLevel m_Level
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestCachePolicy.NativeFieldInfoPtr_m_Level);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestCachePolicy.NativeFieldInfoPtr_m_Level)) = value;
			}
		}

		// Token: 0x04001255 RID: 4693
		private static readonly IntPtr NativeFieldInfoPtr_m_Level;

		// Token: 0x04001256 RID: 4694
		private static readonly IntPtr NativeMethodInfoPtr_get_Level_Public_get_RequestCacheLevel_0;
	}
}
