using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x02000108 RID: 264
	public class NetRes : Object
	{
		// Token: 0x06000E7A RID: 3706 RVA: 0x00047260 File Offset: 0x00045460
		// Note: this type is marked as 'beforefieldinit'.
		static NetRes()
		{
			Il2CppClassPointerStore<NetRes>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "NetRes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetRes>.NativeClassPtr);
			NetRes.NativeMethodInfoPtr_GetWebStatusString_Public_Static_String_String_WebExceptionStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetRes>.NativeClassPtr, 100665380);
			NetRes.NativeMethodInfoPtr_GetWebStatusString_Public_Static_String_WebExceptionStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetRes>.NativeClassPtr, 100665381);
		}

		// Token: 0x06000E7B RID: 3707 RVA: 0x000472B8 File Offset: 0x000454B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 378179, RefRangeEnd = 378181, XrefRangeStart = 378168, XrefRangeEnd = 378179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetWebStatusString(string Res, WebExceptionStatus Status)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Status;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetRes.NativeMethodInfoPtr_GetWebStatusString_Public_Static_String_String_WebExceptionStatus_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x00047304 File Offset: 0x00045504
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 378185, RefRangeEnd = 378186, XrefRangeStart = 378181, XrefRangeEnd = 378185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetWebStatusString(WebExceptionStatus Status)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref Status;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetRes.NativeMethodInfoPtr_GetWebStatusString_Public_Static_String_WebExceptionStatus_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000E7D RID: 3709 RVA: 0x00007A8C File Offset: 0x00005C8C
		public NetRes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B4F RID: 2895
		private static readonly IntPtr NativeMethodInfoPtr_GetWebStatusString_Public_Static_String_String_WebExceptionStatus_0;

		// Token: 0x04000B50 RID: 2896
		private static readonly IntPtr NativeMethodInfoPtr_GetWebStatusString_Public_Static_String_WebExceptionStatus_0;
	}
}
