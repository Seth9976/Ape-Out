using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMono
{
	// Token: 0x02000005 RID: 5
	public static class Runtime : Object
	{
		// Token: 0x06000012 RID: 18 RVA: 0x00023194 File Offset: 0x00021394
		// Note: this type is marked as 'beforefieldinit'.
		static Runtime()
		{
			Il2CppClassPointerStore<Runtime>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono", "Runtime");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Runtime>.NativeClassPtr);
			Runtime.NativeMethodInfoPtr_mono_runtime_install_handlers_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Runtime>.NativeClassPtr, 100663305);
			Runtime.NativeMethodInfoPtr_InstallSignalHandlers_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Runtime>.NativeClassPtr, 100663306);
			Runtime.NativeMethodInfoPtr_mono_runtime_cleanup_handlers_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Runtime>.NativeClassPtr, 100663307);
			Runtime.NativeMethodInfoPtr_RemoveSignalHandlers_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Runtime>.NativeClassPtr, 100663308);
			Runtime.NativeMethodInfoPtr_GetDisplayName_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Runtime>.NativeClassPtr, 100663309);
			Runtime.NativeMethodInfoPtr_GetNativeStackTrace_Private_Static_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Runtime>.NativeClassPtr, 100663310);
			Runtime.NativeMethodInfoPtr_SetGCAllowSynchronousMajor_Public_Static_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Runtime>.NativeClassPtr, 100663311);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00023250 File Offset: 0x00021450
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131105, RefRangeEnd = 131106, XrefRangeStart = 131104, XrefRangeEnd = 131105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void mono_runtime_install_handlers()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Runtime.NativeMethodInfoPtr_mono_runtime_install_handlers_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00023278 File Offset: 0x00021478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131106, XrefRangeEnd = 131107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InstallSignalHandlers()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Runtime.NativeMethodInfoPtr_InstallSignalHandlers_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000232A0 File Offset: 0x000214A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131107, XrefRangeEnd = 131111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void mono_runtime_cleanup_handlers()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Runtime.NativeMethodInfoPtr_mono_runtime_cleanup_handlers_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000232C8 File Offset: 0x000214C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveSignalHandlers()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Runtime.NativeMethodInfoPtr_RemoveSignalHandlers_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000232F0 File Offset: 0x000214F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131111, XrefRangeEnd = 131112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetDisplayName()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Runtime.NativeMethodInfoPtr_GetDisplayName_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0002331C File Offset: 0x0002151C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 131113, RefRangeEnd = 131119, XrefRangeStart = 131112, XrefRangeEnd = 131113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetNativeStackTrace(Exception exception)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Runtime.NativeMethodInfoPtr_GetNativeStackTrace_Private_Static_String_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00023358 File Offset: 0x00021558
		[CallerCount(0)]
		public unsafe static bool SetGCAllowSynchronousMajor(bool flag)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flag;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Runtime.NativeMethodInfoPtr_SetGCAllowSynchronousMajor_Public_Static_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002079 File Offset: 0x00000279
		public Runtime(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr_mono_runtime_install_handlers_Private_Static_Void_0;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr_InstallSignalHandlers_Public_Static_Void_0;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_mono_runtime_cleanup_handlers_Private_Static_Void_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_RemoveSignalHandlers_Public_Static_Void_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_GetDisplayName_Public_Static_String_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_GetNativeStackTrace_Private_Static_String_Exception_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_SetGCAllowSynchronousMajor_Public_Static_Boolean_Boolean_0;
	}
}
