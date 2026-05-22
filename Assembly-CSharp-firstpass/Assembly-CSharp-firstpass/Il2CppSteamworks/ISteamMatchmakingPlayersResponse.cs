using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.InteropServices;

namespace Il2CppSteamworks
{
	// Token: 0x02000014 RID: 20
	public class ISteamMatchmakingPlayersResponse : Object
	{
		// Token: 0x060000D3 RID: 211 RVA: 0x000108A0 File Offset: 0x0000EAA0
		// Note: this type is marked as 'beforefieldinit'.
		static ISteamMatchmakingPlayersResponse()
		{
			Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "ISteamMatchmakingPlayersResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse>.NativeClassPtr);
			ISteamMatchmakingPlayersResponse.NativeFieldInfoPtr_m_VTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse>.NativeClassPtr, "m_VTable");
			ISteamMatchmakingPlayersResponse.NativeFieldInfoPtr_m_pVTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse>.NativeClassPtr, "m_pVTable");
			ISteamMatchmakingPlayersResponse.NativeFieldInfoPtr_m_pGCHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse>.NativeClassPtr, "m_pGCHandle");
			ISteamMatchmakingPlayersResponse.NativeFieldInfoPtr_m_AddPlayerToList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse>.NativeClassPtr, "m_AddPlayerToList");
			ISteamMatchmakingPlayersResponse.NativeFieldInfoPtr_m_PlayersFailedToRespond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse>.NativeClassPtr, "m_PlayersFailedToRespond");
			ISteamMatchmakingPlayersResponse.NativeFieldInfoPtr_m_PlayersRefreshComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse>.NativeClassPtr, "m_PlayersRefreshComplete");
			ISteamMatchmakingPlayersResponse.NativeMethodInfoPtr__ctor_Public_Void_AddPlayerToList_PlayersFailedToRespond_PlayersRefreshComplete_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse>.NativeClassPtr, 100663440);
			ISteamMatchmakingPlayersResponse.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse>.NativeClassPtr, 100663441);
			ISteamMatchmakingPlayersResponse.NativeMethodInfoPtr_InternalOnAddPlayerToList_Private_Void_IntPtr_IntPtr_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse>.NativeClassPtr, 100663442);
			ISteamMatchmakingPlayersResponse.NativeMethodInfoPtr_InternalOnPlayersFailedToRespond_Private_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse>.NativeClassPtr, 100663443);
			ISteamMatchmakingPlayersResponse.NativeMethodInfoPtr_InternalOnPlayersRefreshComplete_Private_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse>.NativeClassPtr, 100663444);
			ISteamMatchmakingPlayersResponse.NativeMethodInfoPtr_op_Explicit_Public_Static_IntPtr_ISteamMatchmakingPlayersResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse>.NativeClassPtr, 100663445);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x000109C0 File Offset: 0x0000EBC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285, XrefRangeEnd = 1326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ISteamMatchmakingPlayersResponse(ISteamMatchmakingPlayersResponse.AddPlayerToList onAddPlayerToList, ISteamMatchmakingPlayersResponse.PlayersFailedToRespond onPlayersFailedToRespond, ISteamMatchmakingPlayersResponse.PlayersRefreshComplete onPlayersRefreshComplete)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(onAddPlayerToList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onPlayersFailedToRespond);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onPlayersRefreshComplete);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.NativeMethodInfoPtr__ctor_Public_Void_AddPlayerToList_PlayersFailedToRespond_PlayersRefreshComplete_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00010A30 File Offset: 0x0000EC30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1326, XrefRangeEnd = 1332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamMatchmakingPlayersResponse.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00010A6C File Offset: 0x0000EC6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1332, XrefRangeEnd = 1335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalOnAddPlayerToList(IntPtr thisptr, IntPtr pchName, int nScore, float flTimePlayed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref thisptr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pchName;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nScore;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flTimePlayed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.NativeMethodInfoPtr_InternalOnAddPlayerToList_Private_Void_IntPtr_IntPtr_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00010AD4 File Offset: 0x0000ECD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalOnPlayersFailedToRespond(IntPtr thisptr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref thisptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.NativeMethodInfoPtr_InternalOnPlayersFailedToRespond_Private_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00010B14 File Offset: 0x0000ED14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1335, XrefRangeEnd = 1337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalOnPlayersRefreshComplete(IntPtr thisptr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref thisptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.NativeMethodInfoPtr_InternalOnPlayersRefreshComplete_Private_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00010B54 File Offset: 0x0000ED54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator IntPtr(ISteamMatchmakingPlayersResponse that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(that);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.NativeMethodInfoPtr_op_Explicit_Public_Static_IntPtr_ISteamMatchmakingPlayersResponse_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00002668 File Offset: 0x00000868
		public ISteamMatchmakingPlayersResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00010B98 File Offset: 0x0000ED98
		// (set) Token: 0x060000DC RID: 220 RVA: 0x00002671 File Offset: 0x00000871
		public unsafe ISteamMatchmakingPlayersResponse.VTable m_VTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPlayersResponse.NativeFieldInfoPtr_m_VTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISteamMatchmakingPlayersResponse.VTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPlayersResponse.NativeFieldInfoPtr_m_VTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000DD RID: 221 RVA: 0x00010BC8 File Offset: 0x0000EDC8
		// (set) Token: 0x060000DE RID: 222 RVA: 0x00002690 File Offset: 0x00000890
		public unsafe IntPtr m_pVTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPlayersResponse.NativeFieldInfoPtr_m_pVTable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPlayersResponse.NativeFieldInfoPtr_m_pVTable)) = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000DF RID: 223 RVA: 0x00010BF0 File Offset: 0x0000EDF0
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x000026AB File Offset: 0x000008AB
		public unsafe GCHandle m_pGCHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPlayersResponse.NativeFieldInfoPtr_m_pGCHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPlayersResponse.NativeFieldInfoPtr_m_pGCHandle)) = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x00010C18 File Offset: 0x0000EE18
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x000026C6 File Offset: 0x000008C6
		public unsafe ISteamMatchmakingPlayersResponse.AddPlayerToList m_AddPlayerToList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPlayersResponse.NativeFieldInfoPtr_m_AddPlayerToList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISteamMatchmakingPlayersResponse.AddPlayerToList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPlayersResponse.NativeFieldInfoPtr_m_AddPlayerToList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x00010C48 File Offset: 0x0000EE48
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x000026E5 File Offset: 0x000008E5
		public unsafe ISteamMatchmakingPlayersResponse.PlayersFailedToRespond m_PlayersFailedToRespond
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPlayersResponse.NativeFieldInfoPtr_m_PlayersFailedToRespond);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISteamMatchmakingPlayersResponse.PlayersFailedToRespond>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPlayersResponse.NativeFieldInfoPtr_m_PlayersFailedToRespond), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x00010C78 File Offset: 0x0000EE78
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x00002704 File Offset: 0x00000904
		public unsafe ISteamMatchmakingPlayersResponse.PlayersRefreshComplete m_PlayersRefreshComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPlayersResponse.NativeFieldInfoPtr_m_PlayersRefreshComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISteamMatchmakingPlayersResponse.PlayersRefreshComplete>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPlayersResponse.NativeFieldInfoPtr_m_PlayersRefreshComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeFieldInfoPtr_m_VTable;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeFieldInfoPtr_m_pVTable;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeFieldInfoPtr_m_pGCHandle;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeFieldInfoPtr_m_AddPlayerToList;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeFieldInfoPtr_m_PlayersFailedToRespond;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeFieldInfoPtr_m_PlayersRefreshComplete;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AddPlayerToList_PlayersFailedToRespond_PlayersRefreshComplete_0;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr_InternalOnAddPlayerToList_Private_Void_IntPtr_IntPtr_Int32_Single_0;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_InternalOnPlayersFailedToRespond_Private_Void_IntPtr_0;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr_InternalOnPlayersRefreshComplete_Private_Void_IntPtr_0;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_IntPtr_ISteamMatchmakingPlayersResponse_0;

		// Token: 0x0200022A RID: 554
		public sealed class AddPlayerToList : MulticastDelegate
		{
			// Token: 0x06001F0A RID: 7946 RVA: 0x00089CC8 File Offset: 0x00087EC8
			// Note: this type is marked as 'beforefieldinit'.
			static AddPlayerToList()
			{
				Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.AddPlayerToList>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse>.NativeClassPtr, "AddPlayerToList");
				ISteamMatchmakingPlayersResponse.AddPlayerToList.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.AddPlayerToList>.NativeClassPtr, 100663446);
				ISteamMatchmakingPlayersResponse.AddPlayerToList.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.AddPlayerToList>.NativeClassPtr, 100663447);
				ISteamMatchmakingPlayersResponse.AddPlayerToList.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_Int32_Single_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.AddPlayerToList>.NativeClassPtr, 100663448);
				ISteamMatchmakingPlayersResponse.AddPlayerToList.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.AddPlayerToList>.NativeClassPtr, 100663449);
			}

			// Token: 0x06001F0B RID: 7947 RVA: 0x00089D3C File Offset: 0x00087F3C
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AddPlayerToList(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.AddPlayerToList>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.AddPlayerToList.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F0C RID: 7948 RVA: 0x00089D98 File Offset: 0x00087F98
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1257, RefRangeEnd = 1258, XrefRangeStart = 1257, XrefRangeEnd = 1257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(string pchName, int nScore, float flTimePlayed)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(pchName);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nScore;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flTimePlayed;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.AddPlayerToList.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F0D RID: 7949 RVA: 0x00089DF8 File Offset: 0x00087FF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258, XrefRangeEnd = 1265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(string pchName, int nScore, float flTimePlayed, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(pchName);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nScore;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flTimePlayed;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.AddPlayerToList.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_Int32_Single_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001F0E RID: 7950 RVA: 0x00089E8C File Offset: 0x0008808C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.AddPlayerToList.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F0F RID: 7951 RVA: 0x0000B46A File Offset: 0x0000966A
			public AddPlayerToList(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001F10 RID: 7952 RVA: 0x0000B473 File Offset: 0x00009673
			public static implicit operator ISteamMatchmakingPlayersResponse.AddPlayerToList(Action<string, int, float> A_0)
			{
				return DelegateSupport.ConvertDelegate<ISteamMatchmakingPlayersResponse.AddPlayerToList>(A_0);
			}

			// Token: 0x06001F11 RID: 7953 RVA: 0x0000B47B File Offset: 0x0000967B
			public static ISteamMatchmakingPlayersResponse.AddPlayerToList operator +(ISteamMatchmakingPlayersResponse.AddPlayerToList A_0, ISteamMatchmakingPlayersResponse.AddPlayerToList A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ISteamMatchmakingPlayersResponse.AddPlayerToList>();
			}

			// Token: 0x06001F12 RID: 7954 RVA: 0x0000B489 File Offset: 0x00009689
			public static ISteamMatchmakingPlayersResponse.AddPlayerToList operator -(ISteamMatchmakingPlayersResponse.AddPlayerToList A_0, ISteamMatchmakingPlayersResponse.AddPlayerToList A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ISteamMatchmakingPlayersResponse.AddPlayerToList>();
				}
				return delegate2;
			}

			// Token: 0x04001F93 RID: 8083
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001F94 RID: 8084
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_Int32_Single_0;

			// Token: 0x04001F95 RID: 8085
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_Int32_Single_AsyncCallback_Object_0;

			// Token: 0x04001F96 RID: 8086
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x0200022B RID: 555
		public sealed class PlayersFailedToRespond : MulticastDelegate
		{
			// Token: 0x06001F13 RID: 7955 RVA: 0x00089ED0 File Offset: 0x000880D0
			// Note: this type is marked as 'beforefieldinit'.
			static PlayersFailedToRespond()
			{
				Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.PlayersFailedToRespond>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse>.NativeClassPtr, "PlayersFailedToRespond");
				ISteamMatchmakingPlayersResponse.PlayersFailedToRespond.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.PlayersFailedToRespond>.NativeClassPtr, 100663450);
				ISteamMatchmakingPlayersResponse.PlayersFailedToRespond.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.PlayersFailedToRespond>.NativeClassPtr, 100663451);
				ISteamMatchmakingPlayersResponse.PlayersFailedToRespond.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.PlayersFailedToRespond>.NativeClassPtr, 100663452);
				ISteamMatchmakingPlayersResponse.PlayersFailedToRespond.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.PlayersFailedToRespond>.NativeClassPtr, 100663453);
			}

			// Token: 0x06001F14 RID: 7956 RVA: 0x00089F44 File Offset: 0x00088144
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PlayersFailedToRespond(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.PlayersFailedToRespond>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.PlayersFailedToRespond.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F15 RID: 7957 RVA: 0x00089FA0 File Offset: 0x000881A0
			[CallerCount(171)]
			[CachedScanResults(RefRangeStart = 1023, RefRangeEnd = 1194, XrefRangeStart = 1023, XrefRangeEnd = 1194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.PlayersFailedToRespond.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F16 RID: 7958 RVA: 0x00089FD4 File Offset: 0x000881D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.PlayersFailedToRespond.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001F17 RID: 7959 RVA: 0x0008A038 File Offset: 0x00088238
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.PlayersFailedToRespond.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F18 RID: 7960 RVA: 0x0000B49A File Offset: 0x0000969A
			public PlayersFailedToRespond(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001F19 RID: 7961 RVA: 0x0000B4A3 File Offset: 0x000096A3
			public static implicit operator ISteamMatchmakingPlayersResponse.PlayersFailedToRespond(Action A_0)
			{
				return DelegateSupport.ConvertDelegate<ISteamMatchmakingPlayersResponse.PlayersFailedToRespond>(A_0);
			}

			// Token: 0x06001F1A RID: 7962 RVA: 0x0000B4AB File Offset: 0x000096AB
			public static ISteamMatchmakingPlayersResponse.PlayersFailedToRespond operator +(ISteamMatchmakingPlayersResponse.PlayersFailedToRespond A_0, ISteamMatchmakingPlayersResponse.PlayersFailedToRespond A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ISteamMatchmakingPlayersResponse.PlayersFailedToRespond>();
			}

			// Token: 0x06001F1B RID: 7963 RVA: 0x0000B4B9 File Offset: 0x000096B9
			public static ISteamMatchmakingPlayersResponse.PlayersFailedToRespond operator -(ISteamMatchmakingPlayersResponse.PlayersFailedToRespond A_0, ISteamMatchmakingPlayersResponse.PlayersFailedToRespond A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ISteamMatchmakingPlayersResponse.PlayersFailedToRespond>();
				}
				return delegate2;
			}

			// Token: 0x04001F97 RID: 8087
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001F98 RID: 8088
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

			// Token: 0x04001F99 RID: 8089
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

			// Token: 0x04001F9A RID: 8090
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x0200022C RID: 556
		public sealed class PlayersRefreshComplete : MulticastDelegate
		{
			// Token: 0x06001F1C RID: 7964 RVA: 0x0008A07C File Offset: 0x0008827C
			// Note: this type is marked as 'beforefieldinit'.
			static PlayersRefreshComplete()
			{
				Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.PlayersRefreshComplete>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse>.NativeClassPtr, "PlayersRefreshComplete");
				ISteamMatchmakingPlayersResponse.PlayersRefreshComplete.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.PlayersRefreshComplete>.NativeClassPtr, 100663454);
				ISteamMatchmakingPlayersResponse.PlayersRefreshComplete.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.PlayersRefreshComplete>.NativeClassPtr, 100663455);
				ISteamMatchmakingPlayersResponse.PlayersRefreshComplete.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.PlayersRefreshComplete>.NativeClassPtr, 100663456);
				ISteamMatchmakingPlayersResponse.PlayersRefreshComplete.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.PlayersRefreshComplete>.NativeClassPtr, 100663457);
			}

			// Token: 0x06001F1D RID: 7965 RVA: 0x0008A0F0 File Offset: 0x000882F0
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PlayersRefreshComplete(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.PlayersRefreshComplete>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.PlayersRefreshComplete.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F1E RID: 7966 RVA: 0x0008A14C File Offset: 0x0008834C
			[CallerCount(171)]
			[CachedScanResults(RefRangeStart = 1023, RefRangeEnd = 1194, XrefRangeStart = 1023, XrefRangeEnd = 1194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.PlayersRefreshComplete.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F1F RID: 7967 RVA: 0x0008A180 File Offset: 0x00088380
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.PlayersRefreshComplete.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001F20 RID: 7968 RVA: 0x0008A1E4 File Offset: 0x000883E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.PlayersRefreshComplete.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F21 RID: 7969 RVA: 0x0000B4CA File Offset: 0x000096CA
			public PlayersRefreshComplete(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001F22 RID: 7970 RVA: 0x0000B4D3 File Offset: 0x000096D3
			public static implicit operator ISteamMatchmakingPlayersResponse.PlayersRefreshComplete(Action A_0)
			{
				return DelegateSupport.ConvertDelegate<ISteamMatchmakingPlayersResponse.PlayersRefreshComplete>(A_0);
			}

			// Token: 0x06001F23 RID: 7971 RVA: 0x0000B4DB File Offset: 0x000096DB
			public static ISteamMatchmakingPlayersResponse.PlayersRefreshComplete operator +(ISteamMatchmakingPlayersResponse.PlayersRefreshComplete A_0, ISteamMatchmakingPlayersResponse.PlayersRefreshComplete A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ISteamMatchmakingPlayersResponse.PlayersRefreshComplete>();
			}

			// Token: 0x06001F24 RID: 7972 RVA: 0x0000B4E9 File Offset: 0x000096E9
			public static ISteamMatchmakingPlayersResponse.PlayersRefreshComplete operator -(ISteamMatchmakingPlayersResponse.PlayersRefreshComplete A_0, ISteamMatchmakingPlayersResponse.PlayersRefreshComplete A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ISteamMatchmakingPlayersResponse.PlayersRefreshComplete>();
				}
				return delegate2;
			}

			// Token: 0x04001F9B RID: 8091
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001F9C RID: 8092
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

			// Token: 0x04001F9D RID: 8093
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

			// Token: 0x04001F9E RID: 8094
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x0200022D RID: 557
		public sealed class InternalAddPlayerToList : MulticastDelegate
		{
			// Token: 0x06001F25 RID: 7973 RVA: 0x0008A228 File Offset: 0x00088428
			// Note: this type is marked as 'beforefieldinit'.
			static InternalAddPlayerToList()
			{
				Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.InternalAddPlayerToList>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse>.NativeClassPtr, "InternalAddPlayerToList");
				ISteamMatchmakingPlayersResponse.InternalAddPlayerToList.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.InternalAddPlayerToList>.NativeClassPtr, 100663458);
				ISteamMatchmakingPlayersResponse.InternalAddPlayerToList.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.InternalAddPlayerToList>.NativeClassPtr, 100663459);
				ISteamMatchmakingPlayersResponse.InternalAddPlayerToList.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_Int32_Single_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.InternalAddPlayerToList>.NativeClassPtr, 100663460);
				ISteamMatchmakingPlayersResponse.InternalAddPlayerToList.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.InternalAddPlayerToList>.NativeClassPtr, 100663461);
			}

			// Token: 0x06001F26 RID: 7974 RVA: 0x0008A29C File Offset: 0x0008849C
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InternalAddPlayerToList(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.InternalAddPlayerToList>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.InternalAddPlayerToList.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F27 RID: 7975 RVA: 0x0008A2F8 File Offset: 0x000884F8
			[CallerCount(0)]
			public unsafe void Invoke(IntPtr thisptr, IntPtr pchName, int nScore, float flTimePlayed)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref thisptr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pchName;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nScore;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flTimePlayed;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.InternalAddPlayerToList.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F28 RID: 7976 RVA: 0x0008A360 File Offset: 0x00088560
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1265, XrefRangeEnd = 1277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(IntPtr thisptr, IntPtr pchName, int nScore, float flTimePlayed, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref thisptr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pchName;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nScore;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flTimePlayed;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.InternalAddPlayerToList.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_Int32_Single_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001F29 RID: 7977 RVA: 0x0008A3FC File Offset: 0x000885FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.InternalAddPlayerToList.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F2A RID: 7978 RVA: 0x0000B4FA File Offset: 0x000096FA
			public InternalAddPlayerToList(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001F2B RID: 7979 RVA: 0x0000B503 File Offset: 0x00009703
			public static implicit operator ISteamMatchmakingPlayersResponse.InternalAddPlayerToList(Action<IntPtr, IntPtr, int, float> A_0)
			{
				return DelegateSupport.ConvertDelegate<ISteamMatchmakingPlayersResponse.InternalAddPlayerToList>(A_0);
			}

			// Token: 0x06001F2C RID: 7980 RVA: 0x0000B50B File Offset: 0x0000970B
			public static ISteamMatchmakingPlayersResponse.InternalAddPlayerToList operator +(ISteamMatchmakingPlayersResponse.InternalAddPlayerToList A_0, ISteamMatchmakingPlayersResponse.InternalAddPlayerToList A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ISteamMatchmakingPlayersResponse.InternalAddPlayerToList>();
			}

			// Token: 0x06001F2D RID: 7981 RVA: 0x0000B519 File Offset: 0x00009719
			public static ISteamMatchmakingPlayersResponse.InternalAddPlayerToList operator -(ISteamMatchmakingPlayersResponse.InternalAddPlayerToList A_0, ISteamMatchmakingPlayersResponse.InternalAddPlayerToList A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ISteamMatchmakingPlayersResponse.InternalAddPlayerToList>();
				}
				return delegate2;
			}

			// Token: 0x04001F9F RID: 8095
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001FA0 RID: 8096
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_Int32_Single_0;

			// Token: 0x04001FA1 RID: 8097
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_Int32_Single_AsyncCallback_Object_0;

			// Token: 0x04001FA2 RID: 8098
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x0200022E RID: 558
		public sealed class InternalPlayersFailedToRespond : MulticastDelegate
		{
			// Token: 0x06001F2E RID: 7982 RVA: 0x0008A440 File Offset: 0x00088640
			// Note: this type is marked as 'beforefieldinit'.
			static InternalPlayersFailedToRespond()
			{
				Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.InternalPlayersFailedToRespond>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse>.NativeClassPtr, "InternalPlayersFailedToRespond");
				ISteamMatchmakingPlayersResponse.InternalPlayersFailedToRespond.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.InternalPlayersFailedToRespond>.NativeClassPtr, 100663462);
				ISteamMatchmakingPlayersResponse.InternalPlayersFailedToRespond.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.InternalPlayersFailedToRespond>.NativeClassPtr, 100663463);
				ISteamMatchmakingPlayersResponse.InternalPlayersFailedToRespond.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.InternalPlayersFailedToRespond>.NativeClassPtr, 100663464);
				ISteamMatchmakingPlayersResponse.InternalPlayersFailedToRespond.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.InternalPlayersFailedToRespond>.NativeClassPtr, 100663465);
			}

			// Token: 0x06001F2F RID: 7983 RVA: 0x0008A4B4 File Offset: 0x000886B4
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InternalPlayersFailedToRespond(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.InternalPlayersFailedToRespond>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.InternalPlayersFailedToRespond.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F30 RID: 7984 RVA: 0x0008A510 File Offset: 0x00088710
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 1199, RefRangeEnd = 1208, XrefRangeStart = 1199, XrefRangeEnd = 1208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(IntPtr thisptr)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref thisptr;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.InternalPlayersFailedToRespond.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F31 RID: 7985 RVA: 0x0008A550 File Offset: 0x00088750
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277, XrefRangeEnd = 1281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(IntPtr thisptr, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref thisptr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.InternalPlayersFailedToRespond.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001F32 RID: 7986 RVA: 0x0008A5C0 File Offset: 0x000887C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.InternalPlayersFailedToRespond.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F33 RID: 7987 RVA: 0x0000B52A File Offset: 0x0000972A
			public InternalPlayersFailedToRespond(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001F34 RID: 7988 RVA: 0x0000B533 File Offset: 0x00009733
			public static implicit operator ISteamMatchmakingPlayersResponse.InternalPlayersFailedToRespond(Action<IntPtr> A_0)
			{
				return DelegateSupport.ConvertDelegate<ISteamMatchmakingPlayersResponse.InternalPlayersFailedToRespond>(A_0);
			}

			// Token: 0x06001F35 RID: 7989 RVA: 0x0000B53B File Offset: 0x0000973B
			public static ISteamMatchmakingPlayersResponse.InternalPlayersFailedToRespond operator +(ISteamMatchmakingPlayersResponse.InternalPlayersFailedToRespond A_0, ISteamMatchmakingPlayersResponse.InternalPlayersFailedToRespond A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ISteamMatchmakingPlayersResponse.InternalPlayersFailedToRespond>();
			}

			// Token: 0x06001F36 RID: 7990 RVA: 0x0000B549 File Offset: 0x00009749
			public static ISteamMatchmakingPlayersResponse.InternalPlayersFailedToRespond operator -(ISteamMatchmakingPlayersResponse.InternalPlayersFailedToRespond A_0, ISteamMatchmakingPlayersResponse.InternalPlayersFailedToRespond A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ISteamMatchmakingPlayersResponse.InternalPlayersFailedToRespond>();
				}
				return delegate2;
			}

			// Token: 0x04001FA3 RID: 8099
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001FA4 RID: 8100
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0;

			// Token: 0x04001FA5 RID: 8101
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0;

			// Token: 0x04001FA6 RID: 8102
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x0200022F RID: 559
		public sealed class InternalPlayersRefreshComplete : MulticastDelegate
		{
			// Token: 0x06001F37 RID: 7991 RVA: 0x0008A604 File Offset: 0x00088804
			// Note: this type is marked as 'beforefieldinit'.
			static InternalPlayersRefreshComplete()
			{
				Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.InternalPlayersRefreshComplete>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse>.NativeClassPtr, "InternalPlayersRefreshComplete");
				ISteamMatchmakingPlayersResponse.InternalPlayersRefreshComplete.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.InternalPlayersRefreshComplete>.NativeClassPtr, 100663466);
				ISteamMatchmakingPlayersResponse.InternalPlayersRefreshComplete.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.InternalPlayersRefreshComplete>.NativeClassPtr, 100663467);
				ISteamMatchmakingPlayersResponse.InternalPlayersRefreshComplete.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.InternalPlayersRefreshComplete>.NativeClassPtr, 100663468);
				ISteamMatchmakingPlayersResponse.InternalPlayersRefreshComplete.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.InternalPlayersRefreshComplete>.NativeClassPtr, 100663469);
			}

			// Token: 0x06001F38 RID: 7992 RVA: 0x0008A678 File Offset: 0x00088878
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InternalPlayersRefreshComplete(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.InternalPlayersRefreshComplete>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.InternalPlayersRefreshComplete.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F39 RID: 7993 RVA: 0x0008A6D4 File Offset: 0x000888D4
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 1199, RefRangeEnd = 1208, XrefRangeStart = 1199, XrefRangeEnd = 1208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(IntPtr thisptr)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref thisptr;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.InternalPlayersRefreshComplete.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F3A RID: 7994 RVA: 0x0008A714 File Offset: 0x00088914
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281, XrefRangeEnd = 1285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(IntPtr thisptr, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref thisptr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.InternalPlayersRefreshComplete.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001F3B RID: 7995 RVA: 0x0008A784 File Offset: 0x00088984
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.InternalPlayersRefreshComplete.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F3C RID: 7996 RVA: 0x0000B55A File Offset: 0x0000975A
			public InternalPlayersRefreshComplete(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001F3D RID: 7997 RVA: 0x0000B563 File Offset: 0x00009763
			public static implicit operator ISteamMatchmakingPlayersResponse.InternalPlayersRefreshComplete(Action<IntPtr> A_0)
			{
				return DelegateSupport.ConvertDelegate<ISteamMatchmakingPlayersResponse.InternalPlayersRefreshComplete>(A_0);
			}

			// Token: 0x06001F3E RID: 7998 RVA: 0x0000B56B File Offset: 0x0000976B
			public static ISteamMatchmakingPlayersResponse.InternalPlayersRefreshComplete operator +(ISteamMatchmakingPlayersResponse.InternalPlayersRefreshComplete A_0, ISteamMatchmakingPlayersResponse.InternalPlayersRefreshComplete A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ISteamMatchmakingPlayersResponse.InternalPlayersRefreshComplete>();
			}

			// Token: 0x06001F3F RID: 7999 RVA: 0x0000B579 File Offset: 0x00009779
			public static ISteamMatchmakingPlayersResponse.InternalPlayersRefreshComplete operator -(ISteamMatchmakingPlayersResponse.InternalPlayersRefreshComplete A_0, ISteamMatchmakingPlayersResponse.InternalPlayersRefreshComplete A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ISteamMatchmakingPlayersResponse.InternalPlayersRefreshComplete>();
				}
				return delegate2;
			}

			// Token: 0x04001FA7 RID: 8103
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001FA8 RID: 8104
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0;

			// Token: 0x04001FA9 RID: 8105
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0;

			// Token: 0x04001FAA RID: 8106
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000230 RID: 560
		public class VTable : Object
		{
			// Token: 0x06001F40 RID: 8000 RVA: 0x0008A7C8 File Offset: 0x000889C8
			// Note: this type is marked as 'beforefieldinit'.
			static VTable()
			{
				Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.VTable>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse>.NativeClassPtr, "VTable");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.VTable>.NativeClassPtr);
				ISteamMatchmakingPlayersResponse.VTable.NativeFieldInfoPtr_m_VTAddPlayerToList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.VTable>.NativeClassPtr, "m_VTAddPlayerToList");
				ISteamMatchmakingPlayersResponse.VTable.NativeFieldInfoPtr_m_VTPlayersFailedToRespond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.VTable>.NativeClassPtr, "m_VTPlayersFailedToRespond");
				ISteamMatchmakingPlayersResponse.VTable.NativeFieldInfoPtr_m_VTPlayersRefreshComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.VTable>.NativeClassPtr, "m_VTPlayersRefreshComplete");
				ISteamMatchmakingPlayersResponse.VTable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.VTable>.NativeClassPtr, 100663470);
			}

			// Token: 0x06001F41 RID: 8001 RVA: 0x0008A844 File Offset: 0x00088A44
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe VTable()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.VTable>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.VTable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F42 RID: 8002 RVA: 0x0000B58A File Offset: 0x0000978A
			public VTable(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000629 RID: 1577
			// (get) Token: 0x06001F43 RID: 8003 RVA: 0x0008A880 File Offset: 0x00088A80
			// (set) Token: 0x06001F44 RID: 8004 RVA: 0x0000B593 File Offset: 0x00009793
			public unsafe ISteamMatchmakingPlayersResponse.InternalAddPlayerToList m_VTAddPlayerToList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPlayersResponse.VTable.NativeFieldInfoPtr_m_VTAddPlayerToList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISteamMatchmakingPlayersResponse.InternalAddPlayerToList>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPlayersResponse.VTable.NativeFieldInfoPtr_m_VTAddPlayerToList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700062A RID: 1578
			// (get) Token: 0x06001F45 RID: 8005 RVA: 0x0008A8B0 File Offset: 0x00088AB0
			// (set) Token: 0x06001F46 RID: 8006 RVA: 0x0000B5B2 File Offset: 0x000097B2
			public unsafe ISteamMatchmakingPlayersResponse.InternalPlayersFailedToRespond m_VTPlayersFailedToRespond
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPlayersResponse.VTable.NativeFieldInfoPtr_m_VTPlayersFailedToRespond);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISteamMatchmakingPlayersResponse.InternalPlayersFailedToRespond>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPlayersResponse.VTable.NativeFieldInfoPtr_m_VTPlayersFailedToRespond), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700062B RID: 1579
			// (get) Token: 0x06001F47 RID: 8007 RVA: 0x0008A8E0 File Offset: 0x00088AE0
			// (set) Token: 0x06001F48 RID: 8008 RVA: 0x0000B5D1 File Offset: 0x000097D1
			public unsafe ISteamMatchmakingPlayersResponse.InternalPlayersRefreshComplete m_VTPlayersRefreshComplete
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPlayersResponse.VTable.NativeFieldInfoPtr_m_VTPlayersRefreshComplete);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISteamMatchmakingPlayersResponse.InternalPlayersRefreshComplete>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPlayersResponse.VTable.NativeFieldInfoPtr_m_VTPlayersRefreshComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001FAB RID: 8107
			private static readonly IntPtr NativeFieldInfoPtr_m_VTAddPlayerToList;

			// Token: 0x04001FAC RID: 8108
			private static readonly IntPtr NativeFieldInfoPtr_m_VTPlayersFailedToRespond;

			// Token: 0x04001FAD RID: 8109
			private static readonly IntPtr NativeFieldInfoPtr_m_VTPlayersRefreshComplete;

			// Token: 0x04001FAE RID: 8110
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
