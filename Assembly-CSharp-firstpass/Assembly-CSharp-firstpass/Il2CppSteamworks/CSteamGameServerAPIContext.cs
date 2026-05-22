using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200001F RID: 31
	public static class CSteamGameServerAPIContext : Object
	{
		// Token: 0x06000182 RID: 386 RVA: 0x0001297C File Offset: 0x00010B7C
		// Note: this type is marked as 'beforefieldinit'.
		static CSteamGameServerAPIContext()
		{
			Il2CppClassPointerStore<CSteamGameServerAPIContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "CSteamGameServerAPIContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CSteamGameServerAPIContext>.NativeClassPtr);
			CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamClient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamGameServerAPIContext>.NativeClassPtr, "m_pSteamClient");
			CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamGameServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamGameServerAPIContext>.NativeClassPtr, "m_pSteamGameServer");
			CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamUtils = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamGameServerAPIContext>.NativeClassPtr, "m_pSteamUtils");
			CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamNetworking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamGameServerAPIContext>.NativeClassPtr, "m_pSteamNetworking");
			CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamGameServerStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamGameServerAPIContext>.NativeClassPtr, "m_pSteamGameServerStats");
			CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamHTTP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamGameServerAPIContext>.NativeClassPtr, "m_pSteamHTTP");
			CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamInventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamGameServerAPIContext>.NativeClassPtr, "m_pSteamInventory");
			CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamUGC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamGameServerAPIContext>.NativeClassPtr, "m_pSteamUGC");
			CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamApps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamGameServerAPIContext>.NativeClassPtr, "m_pSteamApps");
			CSteamGameServerAPIContext.NativeMethodInfoPtr_Clear_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamGameServerAPIContext>.NativeClassPtr, 100663566);
			CSteamGameServerAPIContext.NativeMethodInfoPtr_Init_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamGameServerAPIContext>.NativeClassPtr, 100663567);
			CSteamGameServerAPIContext.NativeMethodInfoPtr_GetSteamClient_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamGameServerAPIContext>.NativeClassPtr, 100663568);
			CSteamGameServerAPIContext.NativeMethodInfoPtr_GetSteamGameServer_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamGameServerAPIContext>.NativeClassPtr, 100663569);
			CSteamGameServerAPIContext.NativeMethodInfoPtr_GetSteamUtils_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamGameServerAPIContext>.NativeClassPtr, 100663570);
			CSteamGameServerAPIContext.NativeMethodInfoPtr_GetSteamNetworking_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamGameServerAPIContext>.NativeClassPtr, 100663571);
			CSteamGameServerAPIContext.NativeMethodInfoPtr_GetSteamGameServerStats_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamGameServerAPIContext>.NativeClassPtr, 100663572);
			CSteamGameServerAPIContext.NativeMethodInfoPtr_GetSteamHTTP_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamGameServerAPIContext>.NativeClassPtr, 100663573);
			CSteamGameServerAPIContext.NativeMethodInfoPtr_GetSteamInventory_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamGameServerAPIContext>.NativeClassPtr, 100663574);
			CSteamGameServerAPIContext.NativeMethodInfoPtr_GetSteamUGC_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamGameServerAPIContext>.NativeClassPtr, 100663575);
			CSteamGameServerAPIContext.NativeMethodInfoPtr_GetSteamApps_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamGameServerAPIContext>.NativeClassPtr, 100663576);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00012B3C File Offset: 0x00010D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3210, XrefRangeEnd = 3221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Clear()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamGameServerAPIContext.NativeMethodInfoPtr_Clear_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00012B64 File Offset: 0x00010D64
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 3280, RefRangeEnd = 3282, XrefRangeStart = 3221, XrefRangeEnd = 3280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Init()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamGameServerAPIContext.NativeMethodInfoPtr_Init_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00012B94 File Offset: 0x00010D94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3282, XrefRangeEnd = 3284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamClient()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamGameServerAPIContext.NativeMethodInfoPtr_GetSteamClient_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00012BC4 File Offset: 0x00010DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3284, XrefRangeEnd = 3286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamGameServer()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamGameServerAPIContext.NativeMethodInfoPtr_GetSteamGameServer_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00012BF4 File Offset: 0x00010DF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3286, XrefRangeEnd = 3288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamUtils()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamGameServerAPIContext.NativeMethodInfoPtr_GetSteamUtils_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00012C24 File Offset: 0x00010E24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3288, XrefRangeEnd = 3290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamNetworking()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamGameServerAPIContext.NativeMethodInfoPtr_GetSteamNetworking_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00012C54 File Offset: 0x00010E54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3290, XrefRangeEnd = 3292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamGameServerStats()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamGameServerAPIContext.NativeMethodInfoPtr_GetSteamGameServerStats_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00012C84 File Offset: 0x00010E84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3292, XrefRangeEnd = 3294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamHTTP()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamGameServerAPIContext.NativeMethodInfoPtr_GetSteamHTTP_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00012CB4 File Offset: 0x00010EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3294, XrefRangeEnd = 3296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamInventory()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamGameServerAPIContext.NativeMethodInfoPtr_GetSteamInventory_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00012CE4 File Offset: 0x00010EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3296, XrefRangeEnd = 3298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamUGC()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamGameServerAPIContext.NativeMethodInfoPtr_GetSteamUGC_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00012D14 File Offset: 0x00010F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3298, XrefRangeEnd = 3300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamApps()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamGameServerAPIContext.NativeMethodInfoPtr_GetSteamApps_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600018E RID: 398 RVA: 0x000029EB File Offset: 0x00000BEB
		public CSteamGameServerAPIContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600018F RID: 399 RVA: 0x00012D44 File Offset: 0x00010F44
		// (set) Token: 0x06000190 RID: 400 RVA: 0x000029F4 File Offset: 0x00000BF4
		public unsafe static IntPtr m_pSteamClient
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamClient, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamClient, (void*)(&value));
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000191 RID: 401 RVA: 0x00012D60 File Offset: 0x00010F60
		// (set) Token: 0x06000192 RID: 402 RVA: 0x00002A02 File Offset: 0x00000C02
		public unsafe static IntPtr m_pSteamGameServer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamGameServer, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamGameServer, (void*)(&value));
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000193 RID: 403 RVA: 0x00012D7C File Offset: 0x00010F7C
		// (set) Token: 0x06000194 RID: 404 RVA: 0x00002A10 File Offset: 0x00000C10
		public unsafe static IntPtr m_pSteamUtils
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamUtils, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamUtils, (void*)(&value));
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000195 RID: 405 RVA: 0x00012D98 File Offset: 0x00010F98
		// (set) Token: 0x06000196 RID: 406 RVA: 0x00002A1E File Offset: 0x00000C1E
		public unsafe static IntPtr m_pSteamNetworking
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamNetworking, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamNetworking, (void*)(&value));
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000197 RID: 407 RVA: 0x00012DB4 File Offset: 0x00010FB4
		// (set) Token: 0x06000198 RID: 408 RVA: 0x00002A2C File Offset: 0x00000C2C
		public unsafe static IntPtr m_pSteamGameServerStats
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamGameServerStats, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamGameServerStats, (void*)(&value));
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000199 RID: 409 RVA: 0x00012DD0 File Offset: 0x00010FD0
		// (set) Token: 0x0600019A RID: 410 RVA: 0x00002A3A File Offset: 0x00000C3A
		public unsafe static IntPtr m_pSteamHTTP
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamHTTP, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamHTTP, (void*)(&value));
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600019B RID: 411 RVA: 0x00012DEC File Offset: 0x00010FEC
		// (set) Token: 0x0600019C RID: 412 RVA: 0x00002A48 File Offset: 0x00000C48
		public unsafe static IntPtr m_pSteamInventory
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamInventory, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamInventory, (void*)(&value));
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600019D RID: 413 RVA: 0x00012E08 File Offset: 0x00011008
		// (set) Token: 0x0600019E RID: 414 RVA: 0x00002A56 File Offset: 0x00000C56
		public unsafe static IntPtr m_pSteamUGC
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamUGC, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamUGC, (void*)(&value));
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600019F RID: 415 RVA: 0x00012E24 File Offset: 0x00011024
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x00002A64 File Offset: 0x00000C64
		public unsafe static IntPtr m_pSteamApps
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamApps, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamApps, (void*)(&value));
			}
		}

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamClient;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamGameServer;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamUtils;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamNetworking;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamGameServerStats;

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamHTTP;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamInventory;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamUGC;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamApps;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Internal_Static_Void_0;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeMethodInfoPtr_Init_Internal_Static_Boolean_0;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamClient_Internal_Static_IntPtr_0;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamGameServer_Internal_Static_IntPtr_0;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamUtils_Internal_Static_IntPtr_0;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamNetworking_Internal_Static_IntPtr_0;

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamGameServerStats_Internal_Static_IntPtr_0;

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamHTTP_Internal_Static_IntPtr_0;

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamInventory_Internal_Static_IntPtr_0;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamUGC_Internal_Static_IntPtr_0;

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamApps_Internal_Static_IntPtr_0;
	}
}
