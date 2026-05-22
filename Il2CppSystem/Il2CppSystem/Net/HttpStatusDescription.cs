using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020000DC RID: 220
	public static class HttpStatusDescription : Object
	{
		// Token: 0x06000C8B RID: 3211 RVA: 0x000402B0 File Offset: 0x0003E4B0
		// Note: this type is marked as 'beforefieldinit'.
		static HttpStatusDescription()
		{
			Il2CppClassPointerStore<HttpStatusDescription>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "HttpStatusDescription");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpStatusDescription>.NativeClassPtr);
			HttpStatusDescription.NativeMethodInfoPtr_Get_Internal_Static_String_HttpStatusCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpStatusDescription>.NativeClassPtr, 100665140);
			HttpStatusDescription.NativeMethodInfoPtr_Get_Internal_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpStatusDescription>.NativeClassPtr, 100665141);
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x00040308 File Offset: 0x0003E508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376529, XrefRangeEnd = 376530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Get(HttpStatusCode code)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref code;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpStatusDescription.NativeMethodInfoPtr_Get_Internal_Static_String_HttpStatusCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x00040340 File Offset: 0x0003E540
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 376578, RefRangeEnd = 376581, XrefRangeStart = 376530, XrefRangeEnd = 376578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Get(int code)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref code;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpStatusDescription.NativeMethodInfoPtr_Get_Internal_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x00006EAA File Offset: 0x000050AA
		public HttpStatusDescription(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400095F RID: 2399
		private static readonly IntPtr NativeMethodInfoPtr_Get_Internal_Static_String_HttpStatusCode_0;

		// Token: 0x04000960 RID: 2400
		private static readonly IntPtr NativeMethodInfoPtr_Get_Internal_Static_String_Int32_0;
	}
}
