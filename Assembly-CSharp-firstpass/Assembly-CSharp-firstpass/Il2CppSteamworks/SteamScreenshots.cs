using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200014C RID: 332
	public static class SteamScreenshots : Object
	{
		// Token: 0x06000D48 RID: 3400 RVA: 0x00042538 File Offset: 0x00040738
		// Note: this type is marked as 'beforefieldinit'.
		static SteamScreenshots()
		{
			Il2CppClassPointerStore<SteamScreenshots>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamScreenshots");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamScreenshots>.NativeClassPtr);
			SteamScreenshots.NativeMethodInfoPtr_WriteScreenshot_Public_Static_ScreenshotHandle_Il2CppStructArray_1_Byte_UInt32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamScreenshots>.NativeClassPtr, 100665047);
			SteamScreenshots.NativeMethodInfoPtr_AddScreenshotToLibrary_Public_Static_ScreenshotHandle_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamScreenshots>.NativeClassPtr, 100665048);
			SteamScreenshots.NativeMethodInfoPtr_TriggerScreenshot_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamScreenshots>.NativeClassPtr, 100665049);
			SteamScreenshots.NativeMethodInfoPtr_HookScreenshots_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamScreenshots>.NativeClassPtr, 100665050);
			SteamScreenshots.NativeMethodInfoPtr_SetLocation_Public_Static_Boolean_ScreenshotHandle_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamScreenshots>.NativeClassPtr, 100665051);
			SteamScreenshots.NativeMethodInfoPtr_TagUser_Public_Static_Boolean_ScreenshotHandle_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamScreenshots>.NativeClassPtr, 100665052);
			SteamScreenshots.NativeMethodInfoPtr_TagPublishedFile_Public_Static_Boolean_ScreenshotHandle_PublishedFileId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamScreenshots>.NativeClassPtr, 100665053);
			SteamScreenshots.NativeMethodInfoPtr_IsScreenshotsHooked_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamScreenshots>.NativeClassPtr, 100665054);
			SteamScreenshots.NativeMethodInfoPtr_AddVRScreenshotToLibrary_Public_Static_ScreenshotHandle_EVRScreenshotType_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamScreenshots>.NativeClassPtr, 100665055);
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x0004261C File Offset: 0x0004081C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11199, XrefRangeEnd = 11207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScreenshotHandle WriteScreenshot(Il2CppStructArray<byte> pubRGB, uint cubRGB, int nWidth, int nHeight)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pubRGB);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubRGB;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nWidth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nHeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamScreenshots.NativeMethodInfoPtr_WriteScreenshot_Public_Static_ScreenshotHandle_Il2CppStructArray_1_Byte_UInt32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x00042688 File Offset: 0x00040888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11207, XrefRangeEnd = 11233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScreenshotHandle AddScreenshotToLibrary(string pchFilename, string pchThumbnailFilename, int nWidth, int nHeight)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchFilename);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchThumbnailFilename);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nWidth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nHeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamScreenshots.NativeMethodInfoPtr_AddScreenshotToLibrary_Public_Static_ScreenshotHandle_String_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x000426F8 File Offset: 0x000408F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11233, XrefRangeEnd = 11238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TriggerScreenshot()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamScreenshots.NativeMethodInfoPtr_TriggerScreenshot_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x00042720 File Offset: 0x00040920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11238, XrefRangeEnd = 11243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void HookScreenshots(bool bHook)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bHook;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamScreenshots.NativeMethodInfoPtr_HookScreenshots_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x00042754 File Offset: 0x00040954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11243, XrefRangeEnd = 11257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetLocation(ScreenshotHandle hScreenshot, string pchLocation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hScreenshot;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchLocation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamScreenshots.NativeMethodInfoPtr_SetLocation_Public_Static_Boolean_ScreenshotHandle_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x000427A4 File Offset: 0x000409A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11257, XrefRangeEnd = 11262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TagUser(ScreenshotHandle hScreenshot, CSteamID steamID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hScreenshot;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamScreenshots.NativeMethodInfoPtr_TagUser_Public_Static_Boolean_ScreenshotHandle_CSteamID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x000427F0 File Offset: 0x000409F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11262, XrefRangeEnd = 11267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TagPublishedFile(ScreenshotHandle hScreenshot, PublishedFileId_t unPublishedFileID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hScreenshot;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unPublishedFileID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamScreenshots.NativeMethodInfoPtr_TagPublishedFile_Public_Static_Boolean_ScreenshotHandle_PublishedFileId_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x0004283C File Offset: 0x00040A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11267, XrefRangeEnd = 11272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsScreenshotsHooked()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamScreenshots.NativeMethodInfoPtr_IsScreenshotsHooked_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x0004286C File Offset: 0x00040A6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11272, XrefRangeEnd = 11298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScreenshotHandle AddVRScreenshotToLibrary(EVRScreenshotType eType, string pchFilename, string pchVRFilename)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchFilename);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVRFilename);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamScreenshots.NativeMethodInfoPtr_AddVRScreenshotToLibrary_Public_Static_ScreenshotHandle_EVRScreenshotType_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x00006555 File Offset: 0x00004755
		public SteamScreenshots(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000FC6 RID: 4038
		private static readonly IntPtr NativeMethodInfoPtr_WriteScreenshot_Public_Static_ScreenshotHandle_Il2CppStructArray_1_Byte_UInt32_Int32_Int32_0;

		// Token: 0x04000FC7 RID: 4039
		private static readonly IntPtr NativeMethodInfoPtr_AddScreenshotToLibrary_Public_Static_ScreenshotHandle_String_String_Int32_Int32_0;

		// Token: 0x04000FC8 RID: 4040
		private static readonly IntPtr NativeMethodInfoPtr_TriggerScreenshot_Public_Static_Void_0;

		// Token: 0x04000FC9 RID: 4041
		private static readonly IntPtr NativeMethodInfoPtr_HookScreenshots_Public_Static_Void_Boolean_0;

		// Token: 0x04000FCA RID: 4042
		private static readonly IntPtr NativeMethodInfoPtr_SetLocation_Public_Static_Boolean_ScreenshotHandle_String_0;

		// Token: 0x04000FCB RID: 4043
		private static readonly IntPtr NativeMethodInfoPtr_TagUser_Public_Static_Boolean_ScreenshotHandle_CSteamID_0;

		// Token: 0x04000FCC RID: 4044
		private static readonly IntPtr NativeMethodInfoPtr_TagPublishedFile_Public_Static_Boolean_ScreenshotHandle_PublishedFileId_t_0;

		// Token: 0x04000FCD RID: 4045
		private static readonly IntPtr NativeMethodInfoPtr_IsScreenshotsHooked_Public_Static_Boolean_0;

		// Token: 0x04000FCE RID: 4046
		private static readonly IntPtr NativeMethodInfoPtr_AddVRScreenshotToLibrary_Public_Static_ScreenshotHandle_EVRScreenshotType_String_String_0;
	}
}
