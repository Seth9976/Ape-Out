using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.InteropServices;

namespace Il2CppSteamworks
{
	// Token: 0x02000012 RID: 18
	public class ISteamMatchmakingServerListResponse : Object
	{
		// Token: 0x060000AE RID: 174 RVA: 0x00010124 File Offset: 0x0000E324
		// Note: this type is marked as 'beforefieldinit'.
		static ISteamMatchmakingServerListResponse()
		{
			Il2CppClassPointerStore<ISteamMatchmakingServerListResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "ISteamMatchmakingServerListResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse>.NativeClassPtr);
			ISteamMatchmakingServerListResponse.NativeFieldInfoPtr_m_VTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse>.NativeClassPtr, "m_VTable");
			ISteamMatchmakingServerListResponse.NativeFieldInfoPtr_m_pVTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse>.NativeClassPtr, "m_pVTable");
			ISteamMatchmakingServerListResponse.NativeFieldInfoPtr_m_pGCHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse>.NativeClassPtr, "m_pGCHandle");
			ISteamMatchmakingServerListResponse.NativeFieldInfoPtr_m_ServerResponded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse>.NativeClassPtr, "m_ServerResponded");
			ISteamMatchmakingServerListResponse.NativeFieldInfoPtr_m_ServerFailedToRespond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse>.NativeClassPtr, "m_ServerFailedToRespond");
			ISteamMatchmakingServerListResponse.NativeFieldInfoPtr_m_RefreshComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse>.NativeClassPtr, "m_RefreshComplete");
			ISteamMatchmakingServerListResponse.NativeMethodInfoPtr__ctor_Public_Void_ServerResponded_ServerFailedToRespond_RefreshComplete_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse>.NativeClassPtr, 100663387);
			ISteamMatchmakingServerListResponse.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse>.NativeClassPtr, 100663388);
			ISteamMatchmakingServerListResponse.NativeMethodInfoPtr_InternalOnServerResponded_Private_Void_IntPtr_HServerListRequest_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse>.NativeClassPtr, 100663389);
			ISteamMatchmakingServerListResponse.NativeMethodInfoPtr_InternalOnServerFailedToRespond_Private_Void_IntPtr_HServerListRequest_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse>.NativeClassPtr, 100663390);
			ISteamMatchmakingServerListResponse.NativeMethodInfoPtr_InternalOnRefreshComplete_Private_Void_IntPtr_HServerListRequest_EMatchMakingServerResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse>.NativeClassPtr, 100663391);
			ISteamMatchmakingServerListResponse.NativeMethodInfoPtr_op_Explicit_Public_Static_IntPtr_ISteamMatchmakingServerListResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse>.NativeClassPtr, 100663392);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00010244 File Offset: 0x0000E444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951, XrefRangeEnd = 992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ISteamMatchmakingServerListResponse(ISteamMatchmakingServerListResponse.ServerResponded onServerResponded, ISteamMatchmakingServerListResponse.ServerFailedToRespond onServerFailedToRespond, ISteamMatchmakingServerListResponse.RefreshComplete onRefreshComplete)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(onServerResponded);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onServerFailedToRespond);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onRefreshComplete);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.NativeMethodInfoPtr__ctor_Public_Void_ServerResponded_ServerFailedToRespond_RefreshComplete_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x000102B4 File Offset: 0x0000E4B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992, XrefRangeEnd = 998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamMatchmakingServerListResponse.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000102F0 File Offset: 0x0000E4F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998, XrefRangeEnd = 1000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalOnServerResponded(IntPtr thisptr, HServerListRequest hRequest, int iServer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref thisptr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hRequest;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.NativeMethodInfoPtr_InternalOnServerResponded_Private_Void_IntPtr_HServerListRequest_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0001034C File Offset: 0x0000E54C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000, XrefRangeEnd = 1002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalOnServerFailedToRespond(IntPtr thisptr, HServerListRequest hRequest, int iServer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref thisptr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hRequest;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.NativeMethodInfoPtr_InternalOnServerFailedToRespond_Private_Void_IntPtr_HServerListRequest_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x000103A8 File Offset: 0x0000E5A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002, XrefRangeEnd = 1004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalOnRefreshComplete(IntPtr thisptr, HServerListRequest hRequest, EMatchMakingServerResponse response)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref thisptr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hRequest;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref response;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.NativeMethodInfoPtr_InternalOnRefreshComplete_Private_Void_IntPtr_HServerListRequest_EMatchMakingServerResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00010404 File Offset: 0x0000E604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1004, XrefRangeEnd = 1006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator IntPtr(ISteamMatchmakingServerListResponse that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(that);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.NativeMethodInfoPtr_op_Explicit_Public_Static_IntPtr_ISteamMatchmakingServerListResponse_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00002511 File Offset: 0x00000711
		public ISteamMatchmakingServerListResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x00010448 File Offset: 0x0000E648
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x0000251A File Offset: 0x0000071A
		public unsafe ISteamMatchmakingServerListResponse.VTable m_VTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingServerListResponse.NativeFieldInfoPtr_m_VTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISteamMatchmakingServerListResponse.VTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingServerListResponse.NativeFieldInfoPtr_m_VTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00010478 File Offset: 0x0000E678
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x00002539 File Offset: 0x00000739
		public unsafe IntPtr m_pVTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingServerListResponse.NativeFieldInfoPtr_m_pVTable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingServerListResponse.NativeFieldInfoPtr_m_pVTable)) = value;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000BA RID: 186 RVA: 0x000104A0 File Offset: 0x0000E6A0
		// (set) Token: 0x060000BB RID: 187 RVA: 0x00002554 File Offset: 0x00000754
		public unsafe GCHandle m_pGCHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingServerListResponse.NativeFieldInfoPtr_m_pGCHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingServerListResponse.NativeFieldInfoPtr_m_pGCHandle)) = value;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000BC RID: 188 RVA: 0x000104C8 File Offset: 0x0000E6C8
		// (set) Token: 0x060000BD RID: 189 RVA: 0x0000256F File Offset: 0x0000076F
		public unsafe ISteamMatchmakingServerListResponse.ServerResponded m_ServerResponded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingServerListResponse.NativeFieldInfoPtr_m_ServerResponded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISteamMatchmakingServerListResponse.ServerResponded>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingServerListResponse.NativeFieldInfoPtr_m_ServerResponded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000BE RID: 190 RVA: 0x000104F8 File Offset: 0x0000E6F8
		// (set) Token: 0x060000BF RID: 191 RVA: 0x0000258E File Offset: 0x0000078E
		public unsafe ISteamMatchmakingServerListResponse.ServerFailedToRespond m_ServerFailedToRespond
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingServerListResponse.NativeFieldInfoPtr_m_ServerFailedToRespond);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISteamMatchmakingServerListResponse.ServerFailedToRespond>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingServerListResponse.NativeFieldInfoPtr_m_ServerFailedToRespond), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x00010528 File Offset: 0x0000E728
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x000025AD File Offset: 0x000007AD
		public unsafe ISteamMatchmakingServerListResponse.RefreshComplete m_RefreshComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingServerListResponse.NativeFieldInfoPtr_m_RefreshComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISteamMatchmakingServerListResponse.RefreshComplete>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingServerListResponse.NativeFieldInfoPtr_m_RefreshComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeFieldInfoPtr_m_VTable;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeFieldInfoPtr_m_pVTable;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeFieldInfoPtr_m_pGCHandle;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeFieldInfoPtr_m_ServerResponded;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeFieldInfoPtr_m_ServerFailedToRespond;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeFieldInfoPtr_m_RefreshComplete;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ServerResponded_ServerFailedToRespond_RefreshComplete_0;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_InternalOnServerResponded_Private_Void_IntPtr_HServerListRequest_Int32_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_InternalOnServerFailedToRespond_Private_Void_IntPtr_HServerListRequest_Int32_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_InternalOnRefreshComplete_Private_Void_IntPtr_HServerListRequest_EMatchMakingServerResponse_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_IntPtr_ISteamMatchmakingServerListResponse_0;

		// Token: 0x0200021E RID: 542
		public sealed class ServerResponded : MulticastDelegate
		{
			// Token: 0x06001EA0 RID: 7840 RVA: 0x000887B8 File Offset: 0x000869B8
			// Note: this type is marked as 'beforefieldinit'.
			static ServerResponded()
			{
				Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.ServerResponded>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse>.NativeClassPtr, "ServerResponded");
				ISteamMatchmakingServerListResponse.ServerResponded.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.ServerResponded>.NativeClassPtr, 100663393);
				ISteamMatchmakingServerListResponse.ServerResponded.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_HServerListRequest_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.ServerResponded>.NativeClassPtr, 100663394);
				ISteamMatchmakingServerListResponse.ServerResponded.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_HServerListRequest_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.ServerResponded>.NativeClassPtr, 100663395);
				ISteamMatchmakingServerListResponse.ServerResponded.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.ServerResponded>.NativeClassPtr, 100663396);
			}

			// Token: 0x06001EA1 RID: 7841 RVA: 0x0008882C File Offset: 0x00086A2C
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ServerResponded(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.ServerResponded>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.ServerResponded.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EA2 RID: 7842 RVA: 0x00088888 File Offset: 0x00086A88
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 897, RefRangeEnd = 900, XrefRangeStart = 897, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(HServerListRequest hRequest, int iServer)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref hRequest;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iServer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.ServerResponded.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_HServerListRequest_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EA3 RID: 7843 RVA: 0x000888D4 File Offset: 0x00086AD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 900, XrefRangeEnd = 907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(HServerListRequest hRequest, int iServer, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref hRequest;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iServer;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.ServerResponded.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_HServerListRequest_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001EA4 RID: 7844 RVA: 0x00088954 File Offset: 0x00086B54
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.ServerResponded.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001EA5 RID: 7845 RVA: 0x0000B1DD File Offset: 0x000093DD
			public ServerResponded(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001EA6 RID: 7846 RVA: 0x0000B1E6 File Offset: 0x000093E6
			public static implicit operator ISteamMatchmakingServerListResponse.ServerResponded(Action<HServerListRequest, int> A_0)
			{
				return DelegateSupport.ConvertDelegate<ISteamMatchmakingServerListResponse.ServerResponded>(A_0);
			}

			// Token: 0x06001EA7 RID: 7847 RVA: 0x0000B1EE File Offset: 0x000093EE
			public static ISteamMatchmakingServerListResponse.ServerResponded operator +(ISteamMatchmakingServerListResponse.ServerResponded A_0, ISteamMatchmakingServerListResponse.ServerResponded A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ISteamMatchmakingServerListResponse.ServerResponded>();
			}

			// Token: 0x06001EA8 RID: 7848 RVA: 0x0000B1FC File Offset: 0x000093FC
			public static ISteamMatchmakingServerListResponse.ServerResponded operator -(ISteamMatchmakingServerListResponse.ServerResponded A_0, ISteamMatchmakingServerListResponse.ServerResponded A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ISteamMatchmakingServerListResponse.ServerResponded>();
				}
				return delegate2;
			}

			// Token: 0x04001F64 RID: 8036
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001F65 RID: 8037
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_HServerListRequest_Int32_0;

			// Token: 0x04001F66 RID: 8038
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_HServerListRequest_Int32_AsyncCallback_Object_0;

			// Token: 0x04001F67 RID: 8039
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x0200021F RID: 543
		public sealed class ServerFailedToRespond : MulticastDelegate
		{
			// Token: 0x06001EA9 RID: 7849 RVA: 0x00088998 File Offset: 0x00086B98
			// Note: this type is marked as 'beforefieldinit'.
			static ServerFailedToRespond()
			{
				Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.ServerFailedToRespond>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse>.NativeClassPtr, "ServerFailedToRespond");
				ISteamMatchmakingServerListResponse.ServerFailedToRespond.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.ServerFailedToRespond>.NativeClassPtr, 100663397);
				ISteamMatchmakingServerListResponse.ServerFailedToRespond.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_HServerListRequest_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.ServerFailedToRespond>.NativeClassPtr, 100663398);
				ISteamMatchmakingServerListResponse.ServerFailedToRespond.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_HServerListRequest_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.ServerFailedToRespond>.NativeClassPtr, 100663399);
				ISteamMatchmakingServerListResponse.ServerFailedToRespond.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.ServerFailedToRespond>.NativeClassPtr, 100663400);
			}

			// Token: 0x06001EAA RID: 7850 RVA: 0x00088A0C File Offset: 0x00086C0C
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ServerFailedToRespond(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.ServerFailedToRespond>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.ServerFailedToRespond.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EAB RID: 7851 RVA: 0x00088A68 File Offset: 0x00086C68
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 897, RefRangeEnd = 900, XrefRangeStart = 897, XrefRangeEnd = 900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(HServerListRequest hRequest, int iServer)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref hRequest;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iServer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.ServerFailedToRespond.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_HServerListRequest_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EAC RID: 7852 RVA: 0x00088AB4 File Offset: 0x00086CB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 907, XrefRangeEnd = 914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(HServerListRequest hRequest, int iServer, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref hRequest;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iServer;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.ServerFailedToRespond.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_HServerListRequest_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001EAD RID: 7853 RVA: 0x00088B34 File Offset: 0x00086D34
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.ServerFailedToRespond.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001EAE RID: 7854 RVA: 0x0000B20D File Offset: 0x0000940D
			public ServerFailedToRespond(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001EAF RID: 7855 RVA: 0x0000B216 File Offset: 0x00009416
			public static implicit operator ISteamMatchmakingServerListResponse.ServerFailedToRespond(Action<HServerListRequest, int> A_0)
			{
				return DelegateSupport.ConvertDelegate<ISteamMatchmakingServerListResponse.ServerFailedToRespond>(A_0);
			}

			// Token: 0x06001EB0 RID: 7856 RVA: 0x0000B21E File Offset: 0x0000941E
			public static ISteamMatchmakingServerListResponse.ServerFailedToRespond operator +(ISteamMatchmakingServerListResponse.ServerFailedToRespond A_0, ISteamMatchmakingServerListResponse.ServerFailedToRespond A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ISteamMatchmakingServerListResponse.ServerFailedToRespond>();
			}

			// Token: 0x06001EB1 RID: 7857 RVA: 0x0000B22C File Offset: 0x0000942C
			public static ISteamMatchmakingServerListResponse.ServerFailedToRespond operator -(ISteamMatchmakingServerListResponse.ServerFailedToRespond A_0, ISteamMatchmakingServerListResponse.ServerFailedToRespond A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ISteamMatchmakingServerListResponse.ServerFailedToRespond>();
				}
				return delegate2;
			}

			// Token: 0x04001F68 RID: 8040
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001F69 RID: 8041
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_HServerListRequest_Int32_0;

			// Token: 0x04001F6A RID: 8042
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_HServerListRequest_Int32_AsyncCallback_Object_0;

			// Token: 0x04001F6B RID: 8043
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000220 RID: 544
		public sealed class RefreshComplete : MulticastDelegate
		{
			// Token: 0x06001EB2 RID: 7858 RVA: 0x00088B78 File Offset: 0x00086D78
			// Note: this type is marked as 'beforefieldinit'.
			static RefreshComplete()
			{
				Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.RefreshComplete>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse>.NativeClassPtr, "RefreshComplete");
				ISteamMatchmakingServerListResponse.RefreshComplete.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.RefreshComplete>.NativeClassPtr, 100663401);
				ISteamMatchmakingServerListResponse.RefreshComplete.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_HServerListRequest_EMatchMakingServerResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.RefreshComplete>.NativeClassPtr, 100663402);
				ISteamMatchmakingServerListResponse.RefreshComplete.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_HServerListRequest_EMatchMakingServerResponse_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.RefreshComplete>.NativeClassPtr, 100663403);
				ISteamMatchmakingServerListResponse.RefreshComplete.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.RefreshComplete>.NativeClassPtr, 100663404);
			}

			// Token: 0x06001EB3 RID: 7859 RVA: 0x00088BEC File Offset: 0x00086DEC
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RefreshComplete(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.RefreshComplete>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.RefreshComplete.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EB4 RID: 7860 RVA: 0x00088C48 File Offset: 0x00086E48
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 897, RefRangeEnd = 900, XrefRangeStart = 897, XrefRangeEnd = 900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(HServerListRequest hRequest, EMatchMakingServerResponse response)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref hRequest;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref response;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.RefreshComplete.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_HServerListRequest_EMatchMakingServerResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EB5 RID: 7861 RVA: 0x00088C94 File Offset: 0x00086E94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 914, XrefRangeEnd = 921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(HServerListRequest hRequest, EMatchMakingServerResponse response, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref hRequest;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref response;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.RefreshComplete.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_HServerListRequest_EMatchMakingServerResponse_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001EB6 RID: 7862 RVA: 0x00088D14 File Offset: 0x00086F14
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.RefreshComplete.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001EB7 RID: 7863 RVA: 0x0000B23D File Offset: 0x0000943D
			public RefreshComplete(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001EB8 RID: 7864 RVA: 0x0000B246 File Offset: 0x00009446
			public static implicit operator ISteamMatchmakingServerListResponse.RefreshComplete(Action<HServerListRequest, EMatchMakingServerResponse> A_0)
			{
				return DelegateSupport.ConvertDelegate<ISteamMatchmakingServerListResponse.RefreshComplete>(A_0);
			}

			// Token: 0x06001EB9 RID: 7865 RVA: 0x0000B24E File Offset: 0x0000944E
			public static ISteamMatchmakingServerListResponse.RefreshComplete operator +(ISteamMatchmakingServerListResponse.RefreshComplete A_0, ISteamMatchmakingServerListResponse.RefreshComplete A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ISteamMatchmakingServerListResponse.RefreshComplete>();
			}

			// Token: 0x06001EBA RID: 7866 RVA: 0x0000B25C File Offset: 0x0000945C
			public static ISteamMatchmakingServerListResponse.RefreshComplete operator -(ISteamMatchmakingServerListResponse.RefreshComplete A_0, ISteamMatchmakingServerListResponse.RefreshComplete A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ISteamMatchmakingServerListResponse.RefreshComplete>();
				}
				return delegate2;
			}

			// Token: 0x04001F6C RID: 8044
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001F6D RID: 8045
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_HServerListRequest_EMatchMakingServerResponse_0;

			// Token: 0x04001F6E RID: 8046
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_HServerListRequest_EMatchMakingServerResponse_AsyncCallback_Object_0;

			// Token: 0x04001F6F RID: 8047
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000221 RID: 545
		public sealed class InternalServerResponded : MulticastDelegate
		{
			// Token: 0x06001EBB RID: 7867 RVA: 0x00088D58 File Offset: 0x00086F58
			// Note: this type is marked as 'beforefieldinit'.
			static InternalServerResponded()
			{
				Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.InternalServerResponded>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse>.NativeClassPtr, "InternalServerResponded");
				ISteamMatchmakingServerListResponse.InternalServerResponded.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.InternalServerResponded>.NativeClassPtr, 100663405);
				ISteamMatchmakingServerListResponse.InternalServerResponded.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_HServerListRequest_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.InternalServerResponded>.NativeClassPtr, 100663406);
				ISteamMatchmakingServerListResponse.InternalServerResponded.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_HServerListRequest_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.InternalServerResponded>.NativeClassPtr, 100663407);
				ISteamMatchmakingServerListResponse.InternalServerResponded.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.InternalServerResponded>.NativeClassPtr, 100663408);
			}

			// Token: 0x06001EBC RID: 7868 RVA: 0x00088DCC File Offset: 0x00086FCC
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InternalServerResponded(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.InternalServerResponded>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.InternalServerResponded.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EBD RID: 7869 RVA: 0x00088E28 File Offset: 0x00087028
			[CallerCount(0)]
			public unsafe void Invoke(IntPtr thisptr, HServerListRequest hRequest, int iServer)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref thisptr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hRequest;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iServer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.InternalServerResponded.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_HServerListRequest_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EBE RID: 7870 RVA: 0x00088E84 File Offset: 0x00087084
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 921, XrefRangeEnd = 931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(IntPtr thisptr, HServerListRequest hRequest, int iServer, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref thisptr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hRequest;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iServer;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.InternalServerResponded.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_HServerListRequest_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001EBF RID: 7871 RVA: 0x00088F14 File Offset: 0x00087114
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.InternalServerResponded.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001EC0 RID: 7872 RVA: 0x0000B26D File Offset: 0x0000946D
			public InternalServerResponded(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001EC1 RID: 7873 RVA: 0x0000B276 File Offset: 0x00009476
			public static implicit operator ISteamMatchmakingServerListResponse.InternalServerResponded(Action<IntPtr, HServerListRequest, int> A_0)
			{
				return DelegateSupport.ConvertDelegate<ISteamMatchmakingServerListResponse.InternalServerResponded>(A_0);
			}

			// Token: 0x06001EC2 RID: 7874 RVA: 0x0000B27E File Offset: 0x0000947E
			public static ISteamMatchmakingServerListResponse.InternalServerResponded operator +(ISteamMatchmakingServerListResponse.InternalServerResponded A_0, ISteamMatchmakingServerListResponse.InternalServerResponded A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ISteamMatchmakingServerListResponse.InternalServerResponded>();
			}

			// Token: 0x06001EC3 RID: 7875 RVA: 0x0000B28C File Offset: 0x0000948C
			public static ISteamMatchmakingServerListResponse.InternalServerResponded operator -(ISteamMatchmakingServerListResponse.InternalServerResponded A_0, ISteamMatchmakingServerListResponse.InternalServerResponded A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ISteamMatchmakingServerListResponse.InternalServerResponded>();
				}
				return delegate2;
			}

			// Token: 0x04001F70 RID: 8048
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001F71 RID: 8049
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_HServerListRequest_Int32_0;

			// Token: 0x04001F72 RID: 8050
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_HServerListRequest_Int32_AsyncCallback_Object_0;

			// Token: 0x04001F73 RID: 8051
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000222 RID: 546
		public sealed class InternalServerFailedToRespond : MulticastDelegate
		{
			// Token: 0x06001EC4 RID: 7876 RVA: 0x00088F58 File Offset: 0x00087158
			// Note: this type is marked as 'beforefieldinit'.
			static InternalServerFailedToRespond()
			{
				Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.InternalServerFailedToRespond>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse>.NativeClassPtr, "InternalServerFailedToRespond");
				ISteamMatchmakingServerListResponse.InternalServerFailedToRespond.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.InternalServerFailedToRespond>.NativeClassPtr, 100663409);
				ISteamMatchmakingServerListResponse.InternalServerFailedToRespond.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_HServerListRequest_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.InternalServerFailedToRespond>.NativeClassPtr, 100663410);
				ISteamMatchmakingServerListResponse.InternalServerFailedToRespond.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_HServerListRequest_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.InternalServerFailedToRespond>.NativeClassPtr, 100663411);
				ISteamMatchmakingServerListResponse.InternalServerFailedToRespond.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.InternalServerFailedToRespond>.NativeClassPtr, 100663412);
			}

			// Token: 0x06001EC5 RID: 7877 RVA: 0x00088FCC File Offset: 0x000871CC
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InternalServerFailedToRespond(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.InternalServerFailedToRespond>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.InternalServerFailedToRespond.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EC6 RID: 7878 RVA: 0x00089028 File Offset: 0x00087228
			[CallerCount(0)]
			public unsafe void Invoke(IntPtr thisptr, HServerListRequest hRequest, int iServer)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref thisptr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hRequest;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iServer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.InternalServerFailedToRespond.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_HServerListRequest_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EC7 RID: 7879 RVA: 0x00089084 File Offset: 0x00087284
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931, XrefRangeEnd = 941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(IntPtr thisptr, HServerListRequest hRequest, int iServer, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref thisptr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hRequest;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iServer;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.InternalServerFailedToRespond.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_HServerListRequest_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001EC8 RID: 7880 RVA: 0x00089114 File Offset: 0x00087314
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.InternalServerFailedToRespond.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001EC9 RID: 7881 RVA: 0x0000B29D File Offset: 0x0000949D
			public InternalServerFailedToRespond(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001ECA RID: 7882 RVA: 0x0000B2A6 File Offset: 0x000094A6
			public static implicit operator ISteamMatchmakingServerListResponse.InternalServerFailedToRespond(Action<IntPtr, HServerListRequest, int> A_0)
			{
				return DelegateSupport.ConvertDelegate<ISteamMatchmakingServerListResponse.InternalServerFailedToRespond>(A_0);
			}

			// Token: 0x06001ECB RID: 7883 RVA: 0x0000B2AE File Offset: 0x000094AE
			public static ISteamMatchmakingServerListResponse.InternalServerFailedToRespond operator +(ISteamMatchmakingServerListResponse.InternalServerFailedToRespond A_0, ISteamMatchmakingServerListResponse.InternalServerFailedToRespond A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ISteamMatchmakingServerListResponse.InternalServerFailedToRespond>();
			}

			// Token: 0x06001ECC RID: 7884 RVA: 0x0000B2BC File Offset: 0x000094BC
			public static ISteamMatchmakingServerListResponse.InternalServerFailedToRespond operator -(ISteamMatchmakingServerListResponse.InternalServerFailedToRespond A_0, ISteamMatchmakingServerListResponse.InternalServerFailedToRespond A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ISteamMatchmakingServerListResponse.InternalServerFailedToRespond>();
				}
				return delegate2;
			}

			// Token: 0x04001F74 RID: 8052
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001F75 RID: 8053
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_HServerListRequest_Int32_0;

			// Token: 0x04001F76 RID: 8054
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_HServerListRequest_Int32_AsyncCallback_Object_0;

			// Token: 0x04001F77 RID: 8055
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000223 RID: 547
		public sealed class InternalRefreshComplete : MulticastDelegate
		{
			// Token: 0x06001ECD RID: 7885 RVA: 0x00089158 File Offset: 0x00087358
			// Note: this type is marked as 'beforefieldinit'.
			static InternalRefreshComplete()
			{
				Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.InternalRefreshComplete>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse>.NativeClassPtr, "InternalRefreshComplete");
				ISteamMatchmakingServerListResponse.InternalRefreshComplete.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.InternalRefreshComplete>.NativeClassPtr, 100663413);
				ISteamMatchmakingServerListResponse.InternalRefreshComplete.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_HServerListRequest_EMatchMakingServerResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.InternalRefreshComplete>.NativeClassPtr, 100663414);
				ISteamMatchmakingServerListResponse.InternalRefreshComplete.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_HServerListRequest_EMatchMakingServerResponse_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.InternalRefreshComplete>.NativeClassPtr, 100663415);
				ISteamMatchmakingServerListResponse.InternalRefreshComplete.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.InternalRefreshComplete>.NativeClassPtr, 100663416);
			}

			// Token: 0x06001ECE RID: 7886 RVA: 0x000891CC File Offset: 0x000873CC
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InternalRefreshComplete(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.InternalRefreshComplete>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.InternalRefreshComplete.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001ECF RID: 7887 RVA: 0x00089228 File Offset: 0x00087428
			[CallerCount(0)]
			public unsafe void Invoke(IntPtr thisptr, HServerListRequest hRequest, EMatchMakingServerResponse response)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref thisptr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hRequest;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref response;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.InternalRefreshComplete.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_HServerListRequest_EMatchMakingServerResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001ED0 RID: 7888 RVA: 0x00089284 File Offset: 0x00087484
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941, XrefRangeEnd = 951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(IntPtr thisptr, HServerListRequest hRequest, EMatchMakingServerResponse response, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref thisptr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hRequest;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref response;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.InternalRefreshComplete.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_HServerListRequest_EMatchMakingServerResponse_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001ED1 RID: 7889 RVA: 0x00089314 File Offset: 0x00087514
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.InternalRefreshComplete.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001ED2 RID: 7890 RVA: 0x0000B2CD File Offset: 0x000094CD
			public InternalRefreshComplete(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001ED3 RID: 7891 RVA: 0x0000B2D6 File Offset: 0x000094D6
			public static implicit operator ISteamMatchmakingServerListResponse.InternalRefreshComplete(Action<IntPtr, HServerListRequest, EMatchMakingServerResponse> A_0)
			{
				return DelegateSupport.ConvertDelegate<ISteamMatchmakingServerListResponse.InternalRefreshComplete>(A_0);
			}

			// Token: 0x06001ED4 RID: 7892 RVA: 0x0000B2DE File Offset: 0x000094DE
			public static ISteamMatchmakingServerListResponse.InternalRefreshComplete operator +(ISteamMatchmakingServerListResponse.InternalRefreshComplete A_0, ISteamMatchmakingServerListResponse.InternalRefreshComplete A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ISteamMatchmakingServerListResponse.InternalRefreshComplete>();
			}

			// Token: 0x06001ED5 RID: 7893 RVA: 0x0000B2EC File Offset: 0x000094EC
			public static ISteamMatchmakingServerListResponse.InternalRefreshComplete operator -(ISteamMatchmakingServerListResponse.InternalRefreshComplete A_0, ISteamMatchmakingServerListResponse.InternalRefreshComplete A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ISteamMatchmakingServerListResponse.InternalRefreshComplete>();
				}
				return delegate2;
			}

			// Token: 0x04001F78 RID: 8056
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001F79 RID: 8057
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_HServerListRequest_EMatchMakingServerResponse_0;

			// Token: 0x04001F7A RID: 8058
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_HServerListRequest_EMatchMakingServerResponse_AsyncCallback_Object_0;

			// Token: 0x04001F7B RID: 8059
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000224 RID: 548
		public class VTable : Object
		{
			// Token: 0x06001ED6 RID: 7894 RVA: 0x00089358 File Offset: 0x00087558
			// Note: this type is marked as 'beforefieldinit'.
			static VTable()
			{
				Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.VTable>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse>.NativeClassPtr, "VTable");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.VTable>.NativeClassPtr);
				ISteamMatchmakingServerListResponse.VTable.NativeFieldInfoPtr_m_VTServerResponded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.VTable>.NativeClassPtr, "m_VTServerResponded");
				ISteamMatchmakingServerListResponse.VTable.NativeFieldInfoPtr_m_VTServerFailedToRespond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.VTable>.NativeClassPtr, "m_VTServerFailedToRespond");
				ISteamMatchmakingServerListResponse.VTable.NativeFieldInfoPtr_m_VTRefreshComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.VTable>.NativeClassPtr, "m_VTRefreshComplete");
				ISteamMatchmakingServerListResponse.VTable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.VTable>.NativeClassPtr, 100663417);
			}

			// Token: 0x06001ED7 RID: 7895 RVA: 0x000893D4 File Offset: 0x000875D4
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe VTable()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.VTable>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.VTable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001ED8 RID: 7896 RVA: 0x0000B2FD File Offset: 0x000094FD
			public VTable(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000624 RID: 1572
			// (get) Token: 0x06001ED9 RID: 7897 RVA: 0x00089410 File Offset: 0x00087610
			// (set) Token: 0x06001EDA RID: 7898 RVA: 0x0000B306 File Offset: 0x00009506
			public unsafe ISteamMatchmakingServerListResponse.InternalServerResponded m_VTServerResponded
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingServerListResponse.VTable.NativeFieldInfoPtr_m_VTServerResponded);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISteamMatchmakingServerListResponse.InternalServerResponded>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingServerListResponse.VTable.NativeFieldInfoPtr_m_VTServerResponded), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000625 RID: 1573
			// (get) Token: 0x06001EDB RID: 7899 RVA: 0x00089440 File Offset: 0x00087640
			// (set) Token: 0x06001EDC RID: 7900 RVA: 0x0000B325 File Offset: 0x00009525
			public unsafe ISteamMatchmakingServerListResponse.InternalServerFailedToRespond m_VTServerFailedToRespond
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingServerListResponse.VTable.NativeFieldInfoPtr_m_VTServerFailedToRespond);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISteamMatchmakingServerListResponse.InternalServerFailedToRespond>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingServerListResponse.VTable.NativeFieldInfoPtr_m_VTServerFailedToRespond), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000626 RID: 1574
			// (get) Token: 0x06001EDD RID: 7901 RVA: 0x00089470 File Offset: 0x00087670
			// (set) Token: 0x06001EDE RID: 7902 RVA: 0x0000B344 File Offset: 0x00009544
			public unsafe ISteamMatchmakingServerListResponse.InternalRefreshComplete m_VTRefreshComplete
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingServerListResponse.VTable.NativeFieldInfoPtr_m_VTRefreshComplete);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISteamMatchmakingServerListResponse.InternalRefreshComplete>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingServerListResponse.VTable.NativeFieldInfoPtr_m_VTRefreshComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001F7C RID: 8060
			private static readonly IntPtr NativeFieldInfoPtr_m_VTServerResponded;

			// Token: 0x04001F7D RID: 8061
			private static readonly IntPtr NativeFieldInfoPtr_m_VTServerFailedToRespond;

			// Token: 0x04001F7E RID: 8062
			private static readonly IntPtr NativeFieldInfoPtr_m_VTRefreshComplete;

			// Token: 0x04001F7F RID: 8063
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
