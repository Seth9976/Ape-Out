using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000142 RID: 322
	public static class SteamHTMLSurface : Object
	{
		// Token: 0x06000C1F RID: 3103 RVA: 0x0003B9A8 File Offset: 0x00039BA8
		// Note: this type is marked as 'beforefieldinit'.
		static SteamHTMLSurface()
		{
			Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamHTMLSurface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr);
			SteamHTMLSurface.NativeMethodInfoPtr_Init_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100664770);
			SteamHTMLSurface.NativeMethodInfoPtr_Shutdown_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100664771);
			SteamHTMLSurface.NativeMethodInfoPtr_CreateBrowser_Public_Static_SteamAPICall_t_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100664772);
			SteamHTMLSurface.NativeMethodInfoPtr_RemoveBrowser_Public_Static_Void_HHTMLBrowser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100664773);
			SteamHTMLSurface.NativeMethodInfoPtr_LoadURL_Public_Static_Void_HHTMLBrowser_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100664774);
			SteamHTMLSurface.NativeMethodInfoPtr_SetSize_Public_Static_Void_HHTMLBrowser_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100664775);
			SteamHTMLSurface.NativeMethodInfoPtr_StopLoad_Public_Static_Void_HHTMLBrowser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100664776);
			SteamHTMLSurface.NativeMethodInfoPtr_Reload_Public_Static_Void_HHTMLBrowser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100664777);
			SteamHTMLSurface.NativeMethodInfoPtr_GoBack_Public_Static_Void_HHTMLBrowser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100664778);
			SteamHTMLSurface.NativeMethodInfoPtr_GoForward_Public_Static_Void_HHTMLBrowser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100664779);
			SteamHTMLSurface.NativeMethodInfoPtr_AddHeader_Public_Static_Void_HHTMLBrowser_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100664780);
			SteamHTMLSurface.NativeMethodInfoPtr_ExecuteJavascript_Public_Static_Void_HHTMLBrowser_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100664781);
			SteamHTMLSurface.NativeMethodInfoPtr_MouseUp_Public_Static_Void_HHTMLBrowser_EHTMLMouseButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100664782);
			SteamHTMLSurface.NativeMethodInfoPtr_MouseDown_Public_Static_Void_HHTMLBrowser_EHTMLMouseButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100664783);
			SteamHTMLSurface.NativeMethodInfoPtr_MouseDoubleClick_Public_Static_Void_HHTMLBrowser_EHTMLMouseButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100664784);
			SteamHTMLSurface.NativeMethodInfoPtr_MouseMove_Public_Static_Void_HHTMLBrowser_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100664785);
			SteamHTMLSurface.NativeMethodInfoPtr_MouseWheel_Public_Static_Void_HHTMLBrowser_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100664786);
			SteamHTMLSurface.NativeMethodInfoPtr_KeyDown_Public_Static_Void_HHTMLBrowser_UInt32_EHTMLKeyModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100664787);
			SteamHTMLSurface.NativeMethodInfoPtr_KeyUp_Public_Static_Void_HHTMLBrowser_UInt32_EHTMLKeyModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100664788);
			SteamHTMLSurface.NativeMethodInfoPtr_KeyChar_Public_Static_Void_HHTMLBrowser_UInt32_EHTMLKeyModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100664789);
			SteamHTMLSurface.NativeMethodInfoPtr_SetHorizontalScroll_Public_Static_Void_HHTMLBrowser_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100664790);
			SteamHTMLSurface.NativeMethodInfoPtr_SetVerticalScroll_Public_Static_Void_HHTMLBrowser_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100664791);
			SteamHTMLSurface.NativeMethodInfoPtr_SetKeyFocus_Public_Static_Void_HHTMLBrowser_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100664792);
			SteamHTMLSurface.NativeMethodInfoPtr_ViewSource_Public_Static_Void_HHTMLBrowser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100664793);
			SteamHTMLSurface.NativeMethodInfoPtr_CopyToClipboard_Public_Static_Void_HHTMLBrowser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100664794);
			SteamHTMLSurface.NativeMethodInfoPtr_PasteFromClipboard_Public_Static_Void_HHTMLBrowser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100664795);
			SteamHTMLSurface.NativeMethodInfoPtr_Find_Public_Static_Void_HHTMLBrowser_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100664796);
			SteamHTMLSurface.NativeMethodInfoPtr_StopFind_Public_Static_Void_HHTMLBrowser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100664797);
			SteamHTMLSurface.NativeMethodInfoPtr_GetLinkAtPosition_Public_Static_Void_HHTMLBrowser_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100664798);
			SteamHTMLSurface.NativeMethodInfoPtr_SetCookie_Public_Static_Void_String_String_String_String_UInt32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100664799);
			SteamHTMLSurface.NativeMethodInfoPtr_SetPageScaleFactor_Public_Static_Void_HHTMLBrowser_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100664800);
			SteamHTMLSurface.NativeMethodInfoPtr_SetBackgroundMode_Public_Static_Void_HHTMLBrowser_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100664801);
			SteamHTMLSurface.NativeMethodInfoPtr_SetDPIScalingFactor_Public_Static_Void_HHTMLBrowser_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100664802);
			SteamHTMLSurface.NativeMethodInfoPtr_AllowStartRequest_Public_Static_Void_HHTMLBrowser_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100664803);
			SteamHTMLSurface.NativeMethodInfoPtr_JSDialogResponse_Public_Static_Void_HHTMLBrowser_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100664804);
			SteamHTMLSurface.NativeMethodInfoPtr_FileLoadDialogResponse_Public_Static_Void_HHTMLBrowser_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100664805);
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x0003BCA8 File Offset: 0x00039EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9002, XrefRangeEnd = 9007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Init()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_Init_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C21 RID: 3105 RVA: 0x0003BCD8 File Offset: 0x00039ED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9007, XrefRangeEnd = 9012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Shutdown()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_Shutdown_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x0003BD08 File Offset: 0x00039F08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9012, XrefRangeEnd = 9038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t CreateBrowser(string pchUserAgent, string pchUserCSS)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchUserAgent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchUserCSS);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_CreateBrowser_Public_Static_SteamAPICall_t_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x0003BD5C File Offset: 0x00039F5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9038, XrefRangeEnd = 9043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveBrowser(HHTMLBrowser unBrowserHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_RemoveBrowser_Public_Static_Void_HHTMLBrowser_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C24 RID: 3108 RVA: 0x0003BD90 File Offset: 0x00039F90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9043, XrefRangeEnd = 9066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LoadURL(HHTMLBrowser unBrowserHandle, string pchURL, string pchPostData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchURL);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchPostData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_LoadURL_Public_Static_Void_HHTMLBrowser_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C25 RID: 3109 RVA: 0x0003BDE8 File Offset: 0x00039FE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9066, XrefRangeEnd = 9071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetSize(HHTMLBrowser unBrowserHandle, uint unWidth, uint unHeight)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unWidth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unHeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_SetSize_Public_Static_Void_HHTMLBrowser_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C26 RID: 3110 RVA: 0x0003BE38 File Offset: 0x0003A038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9071, XrefRangeEnd = 9076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StopLoad(HHTMLBrowser unBrowserHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_StopLoad_Public_Static_Void_HHTMLBrowser_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C27 RID: 3111 RVA: 0x0003BE6C File Offset: 0x0003A06C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9076, XrefRangeEnd = 9081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Reload(HHTMLBrowser unBrowserHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_Reload_Public_Static_Void_HHTMLBrowser_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C28 RID: 3112 RVA: 0x0003BEA0 File Offset: 0x0003A0A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9081, XrefRangeEnd = 9086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GoBack(HHTMLBrowser unBrowserHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_GoBack_Public_Static_Void_HHTMLBrowser_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C29 RID: 3113 RVA: 0x0003BED4 File Offset: 0x0003A0D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9086, XrefRangeEnd = 9091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GoForward(HHTMLBrowser unBrowserHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_GoForward_Public_Static_Void_HHTMLBrowser_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C2A RID: 3114 RVA: 0x0003BF08 File Offset: 0x0003A108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9091, XrefRangeEnd = 9114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddHeader(HHTMLBrowser unBrowserHandle, string pchKey, string pchValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchKey);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_AddHeader_Public_Static_Void_HHTMLBrowser_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C2B RID: 3115 RVA: 0x0003BF60 File Offset: 0x0003A160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9114, XrefRangeEnd = 9128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExecuteJavascript(HHTMLBrowser unBrowserHandle, string pchScript)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchScript);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_ExecuteJavascript_Public_Static_Void_HHTMLBrowser_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C2C RID: 3116 RVA: 0x0003BFA4 File Offset: 0x0003A1A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9128, XrefRangeEnd = 9133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MouseUp(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eMouseButton;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_MouseUp_Public_Static_Void_HHTMLBrowser_EHTMLMouseButton_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C2D RID: 3117 RVA: 0x0003BFE4 File Offset: 0x0003A1E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9133, XrefRangeEnd = 9138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MouseDown(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eMouseButton;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_MouseDown_Public_Static_Void_HHTMLBrowser_EHTMLMouseButton_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C2E RID: 3118 RVA: 0x0003C024 File Offset: 0x0003A224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9138, XrefRangeEnd = 9143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MouseDoubleClick(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eMouseButton;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_MouseDoubleClick_Public_Static_Void_HHTMLBrowser_EHTMLMouseButton_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C2F RID: 3119 RVA: 0x0003C064 File Offset: 0x0003A264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9143, XrefRangeEnd = 9148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MouseMove(HHTMLBrowser unBrowserHandle, int x, int y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_MouseMove_Public_Static_Void_HHTMLBrowser_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C30 RID: 3120 RVA: 0x0003C0B4 File Offset: 0x0003A2B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9148, XrefRangeEnd = 9153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MouseWheel(HHTMLBrowser unBrowserHandle, int nDelta)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nDelta;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_MouseWheel_Public_Static_Void_HHTMLBrowser_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C31 RID: 3121 RVA: 0x0003C0F4 File Offset: 0x0003A2F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9153, XrefRangeEnd = 9158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void KeyDown(HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nNativeKeyCode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eHTMLKeyModifiers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_KeyDown_Public_Static_Void_HHTMLBrowser_UInt32_EHTMLKeyModifiers_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x0003C144 File Offset: 0x0003A344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9158, XrefRangeEnd = 9163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void KeyUp(HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nNativeKeyCode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eHTMLKeyModifiers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_KeyUp_Public_Static_Void_HHTMLBrowser_UInt32_EHTMLKeyModifiers_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x0003C194 File Offset: 0x0003A394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9163, XrefRangeEnd = 9168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void KeyChar(HHTMLBrowser unBrowserHandle, uint cUnicodeChar, EHTMLKeyModifiers eHTMLKeyModifiers)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cUnicodeChar;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eHTMLKeyModifiers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_KeyChar_Public_Static_Void_HHTMLBrowser_UInt32_EHTMLKeyModifiers_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x0003C1E4 File Offset: 0x0003A3E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9168, XrefRangeEnd = 9173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetHorizontalScroll(HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nAbsolutePixelScroll;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_SetHorizontalScroll_Public_Static_Void_HHTMLBrowser_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x0003C224 File Offset: 0x0003A424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9173, XrefRangeEnd = 9178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetVerticalScroll(HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nAbsolutePixelScroll;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_SetVerticalScroll_Public_Static_Void_HHTMLBrowser_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x0003C264 File Offset: 0x0003A464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9178, XrefRangeEnd = 9183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetKeyFocus(HHTMLBrowser unBrowserHandle, bool bHasKeyFocus)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bHasKeyFocus;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_SetKeyFocus_Public_Static_Void_HHTMLBrowser_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x0003C2A4 File Offset: 0x0003A4A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9183, XrefRangeEnd = 9188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ViewSource(HHTMLBrowser unBrowserHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_ViewSource_Public_Static_Void_HHTMLBrowser_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x0003C2D8 File Offset: 0x0003A4D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9188, XrefRangeEnd = 9193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CopyToClipboard(HHTMLBrowser unBrowserHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_CopyToClipboard_Public_Static_Void_HHTMLBrowser_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x0003C30C File Offset: 0x0003A50C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9193, XrefRangeEnd = 9198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PasteFromClipboard(HHTMLBrowser unBrowserHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_PasteFromClipboard_Public_Static_Void_HHTMLBrowser_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x0003C340 File Offset: 0x0003A540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9198, XrefRangeEnd = 9212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Find(HHTMLBrowser unBrowserHandle, string pchSearchStr, bool bCurrentlyInFind, bool bReverse)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchSearchStr);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bCurrentlyInFind;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bReverse;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_Find_Public_Static_Void_HHTMLBrowser_String_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x0003C3A0 File Offset: 0x0003A5A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9212, XrefRangeEnd = 9217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StopFind(HHTMLBrowser unBrowserHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_StopFind_Public_Static_Void_HHTMLBrowser_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x0003C3D4 File Offset: 0x0003A5D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9217, XrefRangeEnd = 9222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetLinkAtPosition(HHTMLBrowser unBrowserHandle, int x, int y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_GetLinkAtPosition_Public_Static_Void_HHTMLBrowser_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x0003C424 File Offset: 0x0003A624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9222, XrefRangeEnd = 9255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetCookie(string pchHostname, string pchKey, string pchValue, string pchPath = "/", uint nExpires = 0U, bool bSecure = false, bool bHTTPOnly = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchHostname);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchKey);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchValue);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchPath);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nExpires;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bSecure;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bHTTPOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_SetCookie_Public_Static_Void_String_String_String_String_UInt32_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x0003C4BC File Offset: 0x0003A6BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9255, XrefRangeEnd = 9260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetPageScaleFactor(HHTMLBrowser unBrowserHandle, float flZoom, int nPointX, int nPointY)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flZoom;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nPointX;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nPointY;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_SetPageScaleFactor_Public_Static_Void_HHTMLBrowser_Single_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x0003C518 File Offset: 0x0003A718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9260, XrefRangeEnd = 9265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetBackgroundMode(HHTMLBrowser unBrowserHandle, bool bBackgroundMode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bBackgroundMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_SetBackgroundMode_Public_Static_Void_HHTMLBrowser_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C40 RID: 3136 RVA: 0x0003C558 File Offset: 0x0003A758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9265, XrefRangeEnd = 9270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetDPIScalingFactor(HHTMLBrowser unBrowserHandle, float flDPIScaling)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flDPIScaling;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_SetDPIScalingFactor_Public_Static_Void_HHTMLBrowser_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x0003C598 File Offset: 0x0003A798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9270, XrefRangeEnd = 9275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AllowStartRequest(HHTMLBrowser unBrowserHandle, bool bAllowed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bAllowed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_AllowStartRequest_Public_Static_Void_HHTMLBrowser_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x0003C5D8 File Offset: 0x0003A7D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9275, XrefRangeEnd = 9280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void JSDialogResponse(HHTMLBrowser unBrowserHandle, bool bResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bResult;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_JSDialogResponse_Public_Static_Void_HHTMLBrowser_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x0003C618 File Offset: 0x0003A818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9280, XrefRangeEnd = 9285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FileLoadDialogResponse(HHTMLBrowser unBrowserHandle, IntPtr pchSelectedFiles)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pchSelectedFiles;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_FileLoadDialogResponse_Public_Static_Void_HHTMLBrowser_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x000064FB File Offset: 0x000046FB
		public SteamHTMLSurface(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000EB1 RID: 3761
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Static_Boolean_0;

		// Token: 0x04000EB2 RID: 3762
		private static readonly IntPtr NativeMethodInfoPtr_Shutdown_Public_Static_Boolean_0;

		// Token: 0x04000EB3 RID: 3763
		private static readonly IntPtr NativeMethodInfoPtr_CreateBrowser_Public_Static_SteamAPICall_t_String_String_0;

		// Token: 0x04000EB4 RID: 3764
		private static readonly IntPtr NativeMethodInfoPtr_RemoveBrowser_Public_Static_Void_HHTMLBrowser_0;

		// Token: 0x04000EB5 RID: 3765
		private static readonly IntPtr NativeMethodInfoPtr_LoadURL_Public_Static_Void_HHTMLBrowser_String_String_0;

		// Token: 0x04000EB6 RID: 3766
		private static readonly IntPtr NativeMethodInfoPtr_SetSize_Public_Static_Void_HHTMLBrowser_UInt32_UInt32_0;

		// Token: 0x04000EB7 RID: 3767
		private static readonly IntPtr NativeMethodInfoPtr_StopLoad_Public_Static_Void_HHTMLBrowser_0;

		// Token: 0x04000EB8 RID: 3768
		private static readonly IntPtr NativeMethodInfoPtr_Reload_Public_Static_Void_HHTMLBrowser_0;

		// Token: 0x04000EB9 RID: 3769
		private static readonly IntPtr NativeMethodInfoPtr_GoBack_Public_Static_Void_HHTMLBrowser_0;

		// Token: 0x04000EBA RID: 3770
		private static readonly IntPtr NativeMethodInfoPtr_GoForward_Public_Static_Void_HHTMLBrowser_0;

		// Token: 0x04000EBB RID: 3771
		private static readonly IntPtr NativeMethodInfoPtr_AddHeader_Public_Static_Void_HHTMLBrowser_String_String_0;

		// Token: 0x04000EBC RID: 3772
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteJavascript_Public_Static_Void_HHTMLBrowser_String_0;

		// Token: 0x04000EBD RID: 3773
		private static readonly IntPtr NativeMethodInfoPtr_MouseUp_Public_Static_Void_HHTMLBrowser_EHTMLMouseButton_0;

		// Token: 0x04000EBE RID: 3774
		private static readonly IntPtr NativeMethodInfoPtr_MouseDown_Public_Static_Void_HHTMLBrowser_EHTMLMouseButton_0;

		// Token: 0x04000EBF RID: 3775
		private static readonly IntPtr NativeMethodInfoPtr_MouseDoubleClick_Public_Static_Void_HHTMLBrowser_EHTMLMouseButton_0;

		// Token: 0x04000EC0 RID: 3776
		private static readonly IntPtr NativeMethodInfoPtr_MouseMove_Public_Static_Void_HHTMLBrowser_Int32_Int32_0;

		// Token: 0x04000EC1 RID: 3777
		private static readonly IntPtr NativeMethodInfoPtr_MouseWheel_Public_Static_Void_HHTMLBrowser_Int32_0;

		// Token: 0x04000EC2 RID: 3778
		private static readonly IntPtr NativeMethodInfoPtr_KeyDown_Public_Static_Void_HHTMLBrowser_UInt32_EHTMLKeyModifiers_0;

		// Token: 0x04000EC3 RID: 3779
		private static readonly IntPtr NativeMethodInfoPtr_KeyUp_Public_Static_Void_HHTMLBrowser_UInt32_EHTMLKeyModifiers_0;

		// Token: 0x04000EC4 RID: 3780
		private static readonly IntPtr NativeMethodInfoPtr_KeyChar_Public_Static_Void_HHTMLBrowser_UInt32_EHTMLKeyModifiers_0;

		// Token: 0x04000EC5 RID: 3781
		private static readonly IntPtr NativeMethodInfoPtr_SetHorizontalScroll_Public_Static_Void_HHTMLBrowser_UInt32_0;

		// Token: 0x04000EC6 RID: 3782
		private static readonly IntPtr NativeMethodInfoPtr_SetVerticalScroll_Public_Static_Void_HHTMLBrowser_UInt32_0;

		// Token: 0x04000EC7 RID: 3783
		private static readonly IntPtr NativeMethodInfoPtr_SetKeyFocus_Public_Static_Void_HHTMLBrowser_Boolean_0;

		// Token: 0x04000EC8 RID: 3784
		private static readonly IntPtr NativeMethodInfoPtr_ViewSource_Public_Static_Void_HHTMLBrowser_0;

		// Token: 0x04000EC9 RID: 3785
		private static readonly IntPtr NativeMethodInfoPtr_CopyToClipboard_Public_Static_Void_HHTMLBrowser_0;

		// Token: 0x04000ECA RID: 3786
		private static readonly IntPtr NativeMethodInfoPtr_PasteFromClipboard_Public_Static_Void_HHTMLBrowser_0;

		// Token: 0x04000ECB RID: 3787
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_Static_Void_HHTMLBrowser_String_Boolean_Boolean_0;

		// Token: 0x04000ECC RID: 3788
		private static readonly IntPtr NativeMethodInfoPtr_StopFind_Public_Static_Void_HHTMLBrowser_0;

		// Token: 0x04000ECD RID: 3789
		private static readonly IntPtr NativeMethodInfoPtr_GetLinkAtPosition_Public_Static_Void_HHTMLBrowser_Int32_Int32_0;

		// Token: 0x04000ECE RID: 3790
		private static readonly IntPtr NativeMethodInfoPtr_SetCookie_Public_Static_Void_String_String_String_String_UInt32_Boolean_Boolean_0;

		// Token: 0x04000ECF RID: 3791
		private static readonly IntPtr NativeMethodInfoPtr_SetPageScaleFactor_Public_Static_Void_HHTMLBrowser_Single_Int32_Int32_0;

		// Token: 0x04000ED0 RID: 3792
		private static readonly IntPtr NativeMethodInfoPtr_SetBackgroundMode_Public_Static_Void_HHTMLBrowser_Boolean_0;

		// Token: 0x04000ED1 RID: 3793
		private static readonly IntPtr NativeMethodInfoPtr_SetDPIScalingFactor_Public_Static_Void_HHTMLBrowser_Single_0;

		// Token: 0x04000ED2 RID: 3794
		private static readonly IntPtr NativeMethodInfoPtr_AllowStartRequest_Public_Static_Void_HHTMLBrowser_Boolean_0;

		// Token: 0x04000ED3 RID: 3795
		private static readonly IntPtr NativeMethodInfoPtr_JSDialogResponse_Public_Static_Void_HHTMLBrowser_Boolean_0;

		// Token: 0x04000ED4 RID: 3796
		private static readonly IntPtr NativeMethodInfoPtr_FileLoadDialogResponse_Public_Static_Void_HHTMLBrowser_IntPtr_0;
	}
}
