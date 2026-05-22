using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020000FB RID: 251
	public static class WebExceptionMapping : Object
	{
		// Token: 0x06000D9F RID: 3487 RVA: 0x00043DA0 File Offset: 0x00041FA0
		// Note: this type is marked as 'beforefieldinit'.
		static WebExceptionMapping()
		{
			Il2CppClassPointerStore<WebExceptionMapping>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "WebExceptionMapping");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebExceptionMapping>.NativeClassPtr);
			WebExceptionMapping.NativeFieldInfoPtr_s_Mapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebExceptionMapping>.NativeClassPtr, "s_Mapping");
			WebExceptionMapping.NativeMethodInfoPtr_GetWebStatusString_Internal_Static_String_WebExceptionStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebExceptionMapping>.NativeClassPtr, 100665258);
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x00043DF8 File Offset: 0x00041FF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 377051, RefRangeEnd = 377053, XrefRangeStart = 377036, XrefRangeEnd = 377051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetWebStatusString(WebExceptionStatus status)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref status;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebExceptionMapping.NativeMethodInfoPtr_GetWebStatusString_Internal_Static_String_WebExceptionStatus_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x000075C5 File Offset: 0x000057C5
		public WebExceptionMapping(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06000DA2 RID: 3490 RVA: 0x00043E30 File Offset: 0x00042030
		// (set) Token: 0x06000DA3 RID: 3491 RVA: 0x000075CE File Offset: 0x000057CE
		public unsafe static Il2CppStringArray s_Mapping
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WebExceptionMapping.NativeFieldInfoPtr_s_Mapping, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebExceptionMapping.NativeFieldInfoPtr_s_Mapping, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AA8 RID: 2728
		private static readonly IntPtr NativeFieldInfoPtr_s_Mapping;

		// Token: 0x04000AA9 RID: 2729
		private static readonly IntPtr NativeMethodInfoPtr_GetWebStatusString_Internal_Static_String_WebExceptionStatus_0;
	}
}
