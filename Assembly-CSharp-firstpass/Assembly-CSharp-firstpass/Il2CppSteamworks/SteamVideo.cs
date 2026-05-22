using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000151 RID: 337
	public static class SteamVideo : Object
	{
		// Token: 0x06000E0A RID: 3594 RVA: 0x00046BFC File Offset: 0x00044DFC
		// Note: this type is marked as 'beforefieldinit'.
		static SteamVideo()
		{
			Il2CppClassPointerStore<SteamVideo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamVideo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamVideo>.NativeClassPtr);
			SteamVideo.NativeMethodInfoPtr_GetVideoURL_Public_Static_Void_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamVideo>.NativeClassPtr, 100665231);
			SteamVideo.NativeMethodInfoPtr_IsBroadcasting_Public_Static_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamVideo>.NativeClassPtr, 100665232);
			SteamVideo.NativeMethodInfoPtr_GetOPFSettings_Public_Static_Void_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamVideo>.NativeClassPtr, 100665233);
			SteamVideo.NativeMethodInfoPtr_GetOPFStringForApp_Public_Static_Boolean_AppId_t_byref_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamVideo>.NativeClassPtr, 100665234);
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x00046C7C File Offset: 0x00044E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12751, XrefRangeEnd = 12756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetVideoURL(AppId_t unVideoAppID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unVideoAppID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamVideo.NativeMethodInfoPtr_GetVideoURL_Public_Static_Void_AppId_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x00046CB0 File Offset: 0x00044EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12756, XrefRangeEnd = 12761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsBroadcasting(out int pnNumViewers)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pnNumViewers;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamVideo.NativeMethodInfoPtr_IsBroadcasting_Public_Static_Boolean_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E0D RID: 3597 RVA: 0x00046CF0 File Offset: 0x00044EF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12761, XrefRangeEnd = 12766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetOPFSettings(AppId_t unVideoAppID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unVideoAppID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamVideo.NativeMethodInfoPtr_GetOPFSettings_Public_Static_Void_AppId_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E0E RID: 3598 RVA: 0x00046D24 File Offset: 0x00044F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12766, XrefRangeEnd = 12782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetOPFStringForApp(AppId_t unVideoAppID, out string pchBuffer, ref int pnBufferSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unVideoAppID;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnBufferSize;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamVideo.NativeMethodInfoPtr_GetOPFStringForApp_Public_Static_Boolean_AppId_t_byref_String_byref_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pchBuffer = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x00006582 File Offset: 0x00004782
		public SteamVideo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400107E RID: 4222
		private static readonly IntPtr NativeMethodInfoPtr_GetVideoURL_Public_Static_Void_AppId_t_0;

		// Token: 0x0400107F RID: 4223
		private static readonly IntPtr NativeMethodInfoPtr_IsBroadcasting_Public_Static_Boolean_byref_Int32_0;

		// Token: 0x04001080 RID: 4224
		private static readonly IntPtr NativeMethodInfoPtr_GetOPFSettings_Public_Static_Void_AppId_t_0;

		// Token: 0x04001081 RID: 4225
		private static readonly IntPtr NativeMethodInfoPtr_GetOPFStringForApp_Public_Static_Boolean_AppId_t_byref_String_byref_Int32_0;
	}
}
