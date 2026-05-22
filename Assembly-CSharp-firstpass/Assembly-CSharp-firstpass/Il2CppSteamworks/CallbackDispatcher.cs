using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200000A RID: 10
	public static class CallbackDispatcher : Object
	{
		// Token: 0x0600003A RID: 58 RVA: 0x000021C3 File Offset: 0x000003C3
		// Note: this type is marked as 'beforefieldinit'.
		static CallbackDispatcher()
		{
			Il2CppClassPointerStore<CallbackDispatcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "CallbackDispatcher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallbackDispatcher>.NativeClassPtr);
			CallbackDispatcher.NativeMethodInfoPtr_ExceptionHandler_Public_Static_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackDispatcher>.NativeClassPtr, 100663320);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x0000E928 File Offset: 0x0000CB28
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 399, RefRangeEnd = 403, XrefRangeStart = 395, XrefRangeEnd = 399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExceptionHandler(Exception e)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackDispatcher.NativeMethodInfoPtr_ExceptionHandler_Public_Static_Void_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000021FC File Offset: 0x000003FC
		public CallbackDispatcher(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr_ExceptionHandler_Public_Static_Void_Exception_0;
	}
}
