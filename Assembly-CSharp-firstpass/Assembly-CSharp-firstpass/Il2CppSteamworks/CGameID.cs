using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000158 RID: 344
	[Serializable]
	[StructLayout(2)]
	public struct CGameID
	{
		// Token: 0x06000E7F RID: 3711 RVA: 0x00048658 File Offset: 0x00046858
		// Note: this type is marked as 'beforefieldinit'.
		static CGameID()
		{
			Il2CppClassPointerStore<CGameID>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "CGameID");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CGameID>.NativeClassPtr);
			CGameID.NativeFieldInfoPtr_m_GameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CGameID>.NativeClassPtr, "m_GameID");
			CGameID.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CGameID>.NativeClassPtr, 100665292);
			CGameID.NativeMethodInfoPtr__ctor_Public_Void_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CGameID>.NativeClassPtr, 100665293);
			CGameID.NativeMethodInfoPtr__ctor_Public_Void_AppId_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CGameID>.NativeClassPtr, 100665294);
			CGameID.NativeMethodInfoPtr_IsSteamApp_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CGameID>.NativeClassPtr, 100665295);
			CGameID.NativeMethodInfoPtr_IsMod_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CGameID>.NativeClassPtr, 100665296);
			CGameID.NativeMethodInfoPtr_IsShortcut_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CGameID>.NativeClassPtr, 100665297);
			CGameID.NativeMethodInfoPtr_IsP2PFile_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CGameID>.NativeClassPtr, 100665298);
			CGameID.NativeMethodInfoPtr_AppID_Public_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CGameID>.NativeClassPtr, 100665299);
			CGameID.NativeMethodInfoPtr_Type_Public_EGameIDType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CGameID>.NativeClassPtr, 100665300);
			CGameID.NativeMethodInfoPtr_ModID_Public_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CGameID>.NativeClassPtr, 100665301);
			CGameID.NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CGameID>.NativeClassPtr, 100665302);
			CGameID.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CGameID>.NativeClassPtr, 100665303);
			CGameID.NativeMethodInfoPtr_Set_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CGameID>.NativeClassPtr, 100665304);
			CGameID.NativeMethodInfoPtr_SetAppID_Private_Void_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CGameID>.NativeClassPtr, 100665305);
			CGameID.NativeMethodInfoPtr_SetType_Private_Void_EGameIDType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CGameID>.NativeClassPtr, 100665306);
			CGameID.NativeMethodInfoPtr_SetModID_Private_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CGameID>.NativeClassPtr, 100665307);
			CGameID.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CGameID>.NativeClassPtr, 100665308);
			CGameID.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CGameID>.NativeClassPtr, 100665309);
			CGameID.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CGameID>.NativeClassPtr, 100665310);
			CGameID.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CGameID_CGameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CGameID>.NativeClassPtr, 100665311);
			CGameID.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_CGameID_CGameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CGameID>.NativeClassPtr, 100665312);
			CGameID.NativeMethodInfoPtr_op_Explicit_Public_Static_CGameID_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CGameID>.NativeClassPtr, 100665313);
			CGameID.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_CGameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CGameID>.NativeClassPtr, 100665314);
			CGameID.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CGameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CGameID>.NativeClassPtr, 100665315);
			CGameID.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_CGameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CGameID>.NativeClassPtr, 100665316);
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x00048890 File Offset: 0x00046A90
		[CallerCount(0)]
		public unsafe CGameID(ulong GameID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref GameID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CGameID.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x000488C4 File Offset: 0x00046AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12906, XrefRangeEnd = 12907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CGameID(AppId_t nAppID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nAppID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CGameID.NativeMethodInfoPtr__ctor_Public_Void_AppId_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x000488F8 File Offset: 0x00046AF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12907, XrefRangeEnd = 12908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CGameID(AppId_t nAppID, uint nModID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nAppID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nModID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CGameID.NativeMethodInfoPtr__ctor_Public_Void_AppId_t_UInt32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x00048938 File Offset: 0x00046B38
		[CallerCount(0)]
		public unsafe bool IsSteamApp()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CGameID.NativeMethodInfoPtr_IsSteamApp_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x00048968 File Offset: 0x00046B68
		[CallerCount(0)]
		public unsafe bool IsMod()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CGameID.NativeMethodInfoPtr_IsMod_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E85 RID: 3717 RVA: 0x00048998 File Offset: 0x00046B98
		[CallerCount(0)]
		public unsafe bool IsShortcut()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CGameID.NativeMethodInfoPtr_IsShortcut_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x000489C8 File Offset: 0x00046BC8
		[CallerCount(0)]
		public unsafe bool IsP2PFile()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CGameID.NativeMethodInfoPtr_IsP2PFile_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E87 RID: 3719 RVA: 0x000489F8 File Offset: 0x00046BF8
		[CallerCount(0)]
		public unsafe AppId_t AppID()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CGameID.NativeMethodInfoPtr_AppID_Public_AppId_t_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E88 RID: 3720 RVA: 0x00048A28 File Offset: 0x00046C28
		[CallerCount(0)]
		public unsafe CGameID.EGameIDType Type()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CGameID.NativeMethodInfoPtr_Type_Public_EGameIDType_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x00048A58 File Offset: 0x00046C58
		[CallerCount(0)]
		public unsafe uint ModID()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CGameID.NativeMethodInfoPtr_ModID_Public_UInt32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x00048A88 File Offset: 0x00046C88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12908, XrefRangeEnd = 12912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValid()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CGameID.NativeMethodInfoPtr_IsValid_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E8B RID: 3723 RVA: 0x00048AB8 File Offset: 0x00046CB8
		[CallerCount(0)]
		public unsafe void Reset()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CGameID.NativeMethodInfoPtr_Reset_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x00048AE0 File Offset: 0x00046CE0
		[CallerCount(0)]
		public unsafe void Set(ulong GameID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref GameID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CGameID.NativeMethodInfoPtr_Set_Public_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E8D RID: 3725 RVA: 0x00048B14 File Offset: 0x00046D14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 12915, RefRangeEnd = 12917, XrefRangeStart = 12912, XrefRangeEnd = 12915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAppID(AppId_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CGameID.NativeMethodInfoPtr_SetAppID_Private_Void_AppId_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x00048B48 File Offset: 0x00046D48
		[CallerCount(0)]
		public unsafe void SetType(CGameID.EGameIDType other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CGameID.NativeMethodInfoPtr_SetType_Private_Void_EGameIDType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x00048B7C File Offset: 0x00046D7C
		[CallerCount(0)]
		public unsafe void SetModID(uint other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CGameID.NativeMethodInfoPtr_SetModID_Private_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x00048BB0 File Offset: 0x00046DB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12917, XrefRangeEnd = 12919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CGameID.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x00048BDC File Offset: 0x00046DDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12919, XrefRangeEnd = 12921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CGameID.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E92 RID: 3730 RVA: 0x00048C20 File Offset: 0x00046E20
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CGameID.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E93 RID: 3731 RVA: 0x00048C50 File Offset: 0x00046E50
		[CallerCount(0)]
		public unsafe static bool operator ==(CGameID x, CGameID y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CGameID.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CGameID_CGameID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E94 RID: 3732 RVA: 0x00048C9C File Offset: 0x00046E9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 12921, RefRangeEnd = 12922, XrefRangeStart = 12921, XrefRangeEnd = 12921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(CGameID x, CGameID y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CGameID.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_CGameID_CGameID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E95 RID: 3733 RVA: 0x00048CE8 File Offset: 0x00046EE8
		[CallerCount(397)]
		[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 12922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator CGameID(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CGameID.NativeMethodInfoPtr_op_Explicit_Public_Static_CGameID_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E96 RID: 3734 RVA: 0x00048D28 File Offset: 0x00046F28
		[CallerCount(397)]
		[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ulong(CGameID that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CGameID.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_CGameID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x00048D68 File Offset: 0x00046F68
		[CallerCount(0)]
		public unsafe bool Equals(CGameID other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CGameID.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CGameID_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E98 RID: 3736 RVA: 0x00048DA8 File Offset: 0x00046FA8
		[CallerCount(0)]
		public unsafe int CompareTo(CGameID other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CGameID.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_CGameID_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E99 RID: 3737 RVA: 0x00006824 File Offset: 0x00004A24
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CGameID>.NativeClassPtr, ref this));
		}

		// Token: 0x040010D7 RID: 4311
		private static readonly IntPtr NativeFieldInfoPtr_m_GameID;

		// Token: 0x040010D8 RID: 4312
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_0;

		// Token: 0x040010D9 RID: 4313
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AppId_t_0;

		// Token: 0x040010DA RID: 4314
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AppId_t_UInt32_0;

		// Token: 0x040010DB RID: 4315
		private static readonly IntPtr NativeMethodInfoPtr_IsSteamApp_Public_Boolean_0;

		// Token: 0x040010DC RID: 4316
		private static readonly IntPtr NativeMethodInfoPtr_IsMod_Public_Boolean_0;

		// Token: 0x040010DD RID: 4317
		private static readonly IntPtr NativeMethodInfoPtr_IsShortcut_Public_Boolean_0;

		// Token: 0x040010DE RID: 4318
		private static readonly IntPtr NativeMethodInfoPtr_IsP2PFile_Public_Boolean_0;

		// Token: 0x040010DF RID: 4319
		private static readonly IntPtr NativeMethodInfoPtr_AppID_Public_AppId_t_0;

		// Token: 0x040010E0 RID: 4320
		private static readonly IntPtr NativeMethodInfoPtr_Type_Public_EGameIDType_0;

		// Token: 0x040010E1 RID: 4321
		private static readonly IntPtr NativeMethodInfoPtr_ModID_Public_UInt32_0;

		// Token: 0x040010E2 RID: 4322
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;

		// Token: 0x040010E3 RID: 4323
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x040010E4 RID: 4324
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_UInt64_0;

		// Token: 0x040010E5 RID: 4325
		private static readonly IntPtr NativeMethodInfoPtr_SetAppID_Private_Void_AppId_t_0;

		// Token: 0x040010E6 RID: 4326
		private static readonly IntPtr NativeMethodInfoPtr_SetType_Private_Void_EGameIDType_0;

		// Token: 0x040010E7 RID: 4327
		private static readonly IntPtr NativeMethodInfoPtr_SetModID_Private_Void_UInt32_0;

		// Token: 0x040010E8 RID: 4328
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040010E9 RID: 4329
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040010EA RID: 4330
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040010EB RID: 4331
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CGameID_CGameID_0;

		// Token: 0x040010EC RID: 4332
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_CGameID_CGameID_0;

		// Token: 0x040010ED RID: 4333
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_CGameID_UInt64_0;

		// Token: 0x040010EE RID: 4334
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_CGameID_0;

		// Token: 0x040010EF RID: 4335
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CGameID_0;

		// Token: 0x040010F0 RID: 4336
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_CGameID_0;

		// Token: 0x040010F1 RID: 4337
		[FieldOffset(0)]
		public ulong m_GameID;

		// Token: 0x0200023B RID: 571
		[OriginalName("Assembly-CSharp-firstpass.dll", "", "EGameIDType")]
		public enum EGameIDType
		{
			// Token: 0x04001FDC RID: 8156
			k_EGameIDTypeApp,
			// Token: 0x04001FDD RID: 8157
			k_EGameIDTypeGameMod,
			// Token: 0x04001FDE RID: 8158
			k_EGameIDTypeShortcut,
			// Token: 0x04001FDF RID: 8159
			k_EGameIDTypeP2P
		}
	}
}
