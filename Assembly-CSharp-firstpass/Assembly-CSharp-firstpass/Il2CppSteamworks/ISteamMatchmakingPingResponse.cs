using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.InteropServices;

namespace Il2CppSteamworks
{
	// Token: 0x02000013 RID: 19
	public class ISteamMatchmakingPingResponse : Object
	{
		// Token: 0x060000C2 RID: 194 RVA: 0x00010558 File Offset: 0x0000E758
		// Note: this type is marked as 'beforefieldinit'.
		static ISteamMatchmakingPingResponse()
		{
			Il2CppClassPointerStore<ISteamMatchmakingPingResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "ISteamMatchmakingPingResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ISteamMatchmakingPingResponse>.NativeClassPtr);
			ISteamMatchmakingPingResponse.NativeFieldInfoPtr_m_VTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingPingResponse>.NativeClassPtr, "m_VTable");
			ISteamMatchmakingPingResponse.NativeFieldInfoPtr_m_pVTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingPingResponse>.NativeClassPtr, "m_pVTable");
			ISteamMatchmakingPingResponse.NativeFieldInfoPtr_m_pGCHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingPingResponse>.NativeClassPtr, "m_pGCHandle");
			ISteamMatchmakingPingResponse.NativeFieldInfoPtr_m_ServerResponded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingPingResponse>.NativeClassPtr, "m_ServerResponded");
			ISteamMatchmakingPingResponse.NativeFieldInfoPtr_m_ServerFailedToRespond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingPingResponse>.NativeClassPtr, "m_ServerFailedToRespond");
			ISteamMatchmakingPingResponse.NativeMethodInfoPtr__ctor_Public_Void_ServerResponded_ServerFailedToRespond_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPingResponse>.NativeClassPtr, 100663418);
			ISteamMatchmakingPingResponse.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPingResponse>.NativeClassPtr, 100663419);
			ISteamMatchmakingPingResponse.NativeMethodInfoPtr_InternalOnServerResponded_Private_Void_IntPtr_gameserveritem_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPingResponse>.NativeClassPtr, 100663420);
			ISteamMatchmakingPingResponse.NativeMethodInfoPtr_InternalOnServerFailedToRespond_Private_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPingResponse>.NativeClassPtr, 100663421);
			ISteamMatchmakingPingResponse.NativeMethodInfoPtr_op_Explicit_Public_Static_IntPtr_ISteamMatchmakingPingResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPingResponse>.NativeClassPtr, 100663422);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00010650 File Offset: 0x0000E850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1212, XrefRangeEnd = 1247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ISteamMatchmakingPingResponse(ISteamMatchmakingPingResponse.ServerResponded onServerResponded, ISteamMatchmakingPingResponse.ServerFailedToRespond onServerFailedToRespond)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingPingResponse>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(onServerResponded);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onServerFailedToRespond);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPingResponse.NativeMethodInfoPtr__ctor_Public_Void_ServerResponded_ServerFailedToRespond_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x000106B0 File Offset: 0x0000E8B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247, XrefRangeEnd = 1253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamMatchmakingPingResponse.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x000106EC File Offset: 0x0000E8EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253, XrefRangeEnd = 1255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalOnServerResponded(IntPtr thisptr, gameserveritem_t server)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref thisptr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(server);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPingResponse.NativeMethodInfoPtr_InternalOnServerResponded_Private_Void_IntPtr_gameserveritem_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0001073C File Offset: 0x0000E93C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255, XrefRangeEnd = 1257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalOnServerFailedToRespond(IntPtr thisptr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref thisptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPingResponse.NativeMethodInfoPtr_InternalOnServerFailedToRespond_Private_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0001077C File Offset: 0x0000E97C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator IntPtr(ISteamMatchmakingPingResponse that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(that);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPingResponse.NativeMethodInfoPtr_op_Explicit_Public_Static_IntPtr_ISteamMatchmakingPingResponse_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x000025CC File Offset: 0x000007CC
		public ISteamMatchmakingPingResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x000107C0 File Offset: 0x0000E9C0
		// (set) Token: 0x060000CA RID: 202 RVA: 0x000025D5 File Offset: 0x000007D5
		public unsafe ISteamMatchmakingPingResponse.VTable m_VTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPingResponse.NativeFieldInfoPtr_m_VTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISteamMatchmakingPingResponse.VTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPingResponse.NativeFieldInfoPtr_m_VTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000CB RID: 203 RVA: 0x000107F0 File Offset: 0x0000E9F0
		// (set) Token: 0x060000CC RID: 204 RVA: 0x000025F4 File Offset: 0x000007F4
		public unsafe IntPtr m_pVTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPingResponse.NativeFieldInfoPtr_m_pVTable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPingResponse.NativeFieldInfoPtr_m_pVTable)) = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00010818 File Offset: 0x0000EA18
		// (set) Token: 0x060000CE RID: 206 RVA: 0x0000260F File Offset: 0x0000080F
		public unsafe GCHandle m_pGCHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPingResponse.NativeFieldInfoPtr_m_pGCHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPingResponse.NativeFieldInfoPtr_m_pGCHandle)) = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00010840 File Offset: 0x0000EA40
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x0000262A File Offset: 0x0000082A
		public unsafe ISteamMatchmakingPingResponse.ServerResponded m_ServerResponded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPingResponse.NativeFieldInfoPtr_m_ServerResponded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISteamMatchmakingPingResponse.ServerResponded>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPingResponse.NativeFieldInfoPtr_m_ServerResponded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00010870 File Offset: 0x0000EA70
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x00002649 File Offset: 0x00000849
		public unsafe ISteamMatchmakingPingResponse.ServerFailedToRespond m_ServerFailedToRespond
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPingResponse.NativeFieldInfoPtr_m_ServerFailedToRespond);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISteamMatchmakingPingResponse.ServerFailedToRespond>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPingResponse.NativeFieldInfoPtr_m_ServerFailedToRespond), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeFieldInfoPtr_m_VTable;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeFieldInfoPtr_m_pVTable;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeFieldInfoPtr_m_pGCHandle;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeFieldInfoPtr_m_ServerResponded;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeFieldInfoPtr_m_ServerFailedToRespond;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ServerResponded_ServerFailedToRespond_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_InternalOnServerResponded_Private_Void_IntPtr_gameserveritem_t_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_InternalOnServerFailedToRespond_Private_Void_IntPtr_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_IntPtr_ISteamMatchmakingPingResponse_0;

		// Token: 0x02000225 RID: 549
		public sealed class ServerResponded : MulticastDelegate
		{
			// Token: 0x06001EDF RID: 7903 RVA: 0x000894A0 File Offset: 0x000876A0
			// Note: this type is marked as 'beforefieldinit'.
			static ServerResponded()
			{
				Il2CppClassPointerStore<ISteamMatchmakingPingResponse.ServerResponded>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ISteamMatchmakingPingResponse>.NativeClassPtr, "ServerResponded");
				ISteamMatchmakingPingResponse.ServerResponded.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPingResponse.ServerResponded>.NativeClassPtr, 100663423);
				ISteamMatchmakingPingResponse.ServerResponded.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_gameserveritem_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPingResponse.ServerResponded>.NativeClassPtr, 100663424);
				ISteamMatchmakingPingResponse.ServerResponded.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_gameserveritem_t_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPingResponse.ServerResponded>.NativeClassPtr, 100663425);
				ISteamMatchmakingPingResponse.ServerResponded.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPingResponse.ServerResponded>.NativeClassPtr, 100663426);
			}

			// Token: 0x06001EE0 RID: 7904 RVA: 0x00089514 File Offset: 0x00087714
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ServerResponded(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingPingResponse.ServerResponded>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPingResponse.ServerResponded.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EE1 RID: 7905 RVA: 0x00089570 File Offset: 0x00087770
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 1006, RefRangeEnd = 1022, XrefRangeStart = 1006, XrefRangeEnd = 1006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(gameserveritem_t server)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(server);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPingResponse.ServerResponded.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_gameserveritem_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001EE2 RID: 7906 RVA: 0x000895B4 File Offset: 0x000877B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1022, XrefRangeEnd = 1023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(gameserveritem_t server, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(server);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPingResponse.ServerResponded.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_gameserveritem_t_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001EE3 RID: 7907 RVA: 0x00089628 File Offset: 0x00087828
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPingResponse.ServerResponded.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001EE4 RID: 7908 RVA: 0x0000B363 File Offset: 0x00009563
			public ServerResponded(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001EE5 RID: 7909 RVA: 0x0000B36C File Offset: 0x0000956C
			public static implicit operator ISteamMatchmakingPingResponse.ServerResponded(Action<gameserveritem_t> A_0)
			{
				return DelegateSupport.ConvertDelegate<ISteamMatchmakingPingResponse.ServerResponded>(A_0);
			}

			// Token: 0x06001EE6 RID: 7910 RVA: 0x0000B374 File Offset: 0x00009574
			public static ISteamMatchmakingPingResponse.ServerResponded operator +(ISteamMatchmakingPingResponse.ServerResponded A_0, ISteamMatchmakingPingResponse.ServerResponded A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ISteamMatchmakingPingResponse.ServerResponded>();
			}

			// Token: 0x06001EE7 RID: 7911 RVA: 0x0000B382 File Offset: 0x00009582
			public static ISteamMatchmakingPingResponse.ServerResponded operator -(ISteamMatchmakingPingResponse.ServerResponded A_0, ISteamMatchmakingPingResponse.ServerResponded A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ISteamMatchmakingPingResponse.ServerResponded>();
				}
				return delegate2;
			}

			// Token: 0x04001F80 RID: 8064
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001F81 RID: 8065
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_gameserveritem_t_0;

			// Token: 0x04001F82 RID: 8066
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_gameserveritem_t_AsyncCallback_Object_0;

			// Token: 0x04001F83 RID: 8067
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000226 RID: 550
		public sealed class ServerFailedToRespond : MulticastDelegate
		{
			// Token: 0x06001EE8 RID: 7912 RVA: 0x0008966C File Offset: 0x0008786C
			// Note: this type is marked as 'beforefieldinit'.
			static ServerFailedToRespond()
			{
				Il2CppClassPointerStore<ISteamMatchmakingPingResponse.ServerFailedToRespond>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ISteamMatchmakingPingResponse>.NativeClassPtr, "ServerFailedToRespond");
				ISteamMatchmakingPingResponse.ServerFailedToRespond.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPingResponse.ServerFailedToRespond>.NativeClassPtr, 100663427);
				ISteamMatchmakingPingResponse.ServerFailedToRespond.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPingResponse.ServerFailedToRespond>.NativeClassPtr, 100663428);
				ISteamMatchmakingPingResponse.ServerFailedToRespond.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPingResponse.ServerFailedToRespond>.NativeClassPtr, 100663429);
				ISteamMatchmakingPingResponse.ServerFailedToRespond.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPingResponse.ServerFailedToRespond>.NativeClassPtr, 100663430);
			}

			// Token: 0x06001EE9 RID: 7913 RVA: 0x000896E0 File Offset: 0x000878E0
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ServerFailedToRespond(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingPingResponse.ServerFailedToRespond>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPingResponse.ServerFailedToRespond.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EEA RID: 7914 RVA: 0x0008973C File Offset: 0x0008793C
			[CallerCount(171)]
			[CachedScanResults(RefRangeStart = 1023, RefRangeEnd = 1194, XrefRangeStart = 1023, XrefRangeEnd = 1023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPingResponse.ServerFailedToRespond.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EEB RID: 7915 RVA: 0x00089770 File Offset: 0x00087970
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194, XrefRangeEnd = 1195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPingResponse.ServerFailedToRespond.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001EEC RID: 7916 RVA: 0x000897D4 File Offset: 0x000879D4
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPingResponse.ServerFailedToRespond.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001EED RID: 7917 RVA: 0x0000B393 File Offset: 0x00009593
			public ServerFailedToRespond(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001EEE RID: 7918 RVA: 0x0000B39C File Offset: 0x0000959C
			public static implicit operator ISteamMatchmakingPingResponse.ServerFailedToRespond(Action A_0)
			{
				return DelegateSupport.ConvertDelegate<ISteamMatchmakingPingResponse.ServerFailedToRespond>(A_0);
			}

			// Token: 0x06001EEF RID: 7919 RVA: 0x0000B3A4 File Offset: 0x000095A4
			public static ISteamMatchmakingPingResponse.ServerFailedToRespond operator +(ISteamMatchmakingPingResponse.ServerFailedToRespond A_0, ISteamMatchmakingPingResponse.ServerFailedToRespond A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ISteamMatchmakingPingResponse.ServerFailedToRespond>();
			}

			// Token: 0x06001EF0 RID: 7920 RVA: 0x0000B3B2 File Offset: 0x000095B2
			public static ISteamMatchmakingPingResponse.ServerFailedToRespond operator -(ISteamMatchmakingPingResponse.ServerFailedToRespond A_0, ISteamMatchmakingPingResponse.ServerFailedToRespond A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ISteamMatchmakingPingResponse.ServerFailedToRespond>();
				}
				return delegate2;
			}

			// Token: 0x04001F84 RID: 8068
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001F85 RID: 8069
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

			// Token: 0x04001F86 RID: 8070
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

			// Token: 0x04001F87 RID: 8071
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000227 RID: 551
		public sealed class InternalServerResponded : MulticastDelegate
		{
			// Token: 0x06001EF1 RID: 7921 RVA: 0x00089818 File Offset: 0x00087A18
			// Note: this type is marked as 'beforefieldinit'.
			static InternalServerResponded()
			{
				Il2CppClassPointerStore<ISteamMatchmakingPingResponse.InternalServerResponded>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ISteamMatchmakingPingResponse>.NativeClassPtr, "InternalServerResponded");
				ISteamMatchmakingPingResponse.InternalServerResponded.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPingResponse.InternalServerResponded>.NativeClassPtr, 100663431);
				ISteamMatchmakingPingResponse.InternalServerResponded.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_gameserveritem_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPingResponse.InternalServerResponded>.NativeClassPtr, 100663432);
				ISteamMatchmakingPingResponse.InternalServerResponded.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_gameserveritem_t_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPingResponse.InternalServerResponded>.NativeClassPtr, 100663433);
				ISteamMatchmakingPingResponse.InternalServerResponded.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPingResponse.InternalServerResponded>.NativeClassPtr, 100663434);
			}

			// Token: 0x06001EF2 RID: 7922 RVA: 0x0008988C File Offset: 0x00087A8C
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InternalServerResponded(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingPingResponse.InternalServerResponded>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPingResponse.InternalServerResponded.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EF3 RID: 7923 RVA: 0x000898E8 File Offset: 0x00087AE8
			[CallerCount(0)]
			public unsafe void Invoke(IntPtr thisptr, gameserveritem_t server)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref thisptr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(server);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPingResponse.InternalServerResponded.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_gameserveritem_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EF4 RID: 7924 RVA: 0x00089938 File Offset: 0x00087B38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1195, XrefRangeEnd = 1199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(IntPtr thisptr, gameserveritem_t server, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref thisptr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(server);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPingResponse.InternalServerResponded.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_gameserveritem_t_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001EF5 RID: 7925 RVA: 0x000899BC File Offset: 0x00087BBC
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPingResponse.InternalServerResponded.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001EF6 RID: 7926 RVA: 0x0000B3C3 File Offset: 0x000095C3
			public InternalServerResponded(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001EF7 RID: 7927 RVA: 0x0000B3CC File Offset: 0x000095CC
			public static implicit operator ISteamMatchmakingPingResponse.InternalServerResponded(Action<IntPtr, gameserveritem_t> A_0)
			{
				return DelegateSupport.ConvertDelegate<ISteamMatchmakingPingResponse.InternalServerResponded>(A_0);
			}

			// Token: 0x06001EF8 RID: 7928 RVA: 0x0000B3D4 File Offset: 0x000095D4
			public static ISteamMatchmakingPingResponse.InternalServerResponded operator +(ISteamMatchmakingPingResponse.InternalServerResponded A_0, ISteamMatchmakingPingResponse.InternalServerResponded A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ISteamMatchmakingPingResponse.InternalServerResponded>();
			}

			// Token: 0x06001EF9 RID: 7929 RVA: 0x0000B3E2 File Offset: 0x000095E2
			public static ISteamMatchmakingPingResponse.InternalServerResponded operator -(ISteamMatchmakingPingResponse.InternalServerResponded A_0, ISteamMatchmakingPingResponse.InternalServerResponded A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ISteamMatchmakingPingResponse.InternalServerResponded>();
				}
				return delegate2;
			}

			// Token: 0x04001F88 RID: 8072
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001F89 RID: 8073
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_gameserveritem_t_0;

			// Token: 0x04001F8A RID: 8074
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_gameserveritem_t_AsyncCallback_Object_0;

			// Token: 0x04001F8B RID: 8075
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000228 RID: 552
		public sealed class InternalServerFailedToRespond : MulticastDelegate
		{
			// Token: 0x06001EFA RID: 7930 RVA: 0x00089A00 File Offset: 0x00087C00
			// Note: this type is marked as 'beforefieldinit'.
			static InternalServerFailedToRespond()
			{
				Il2CppClassPointerStore<ISteamMatchmakingPingResponse.InternalServerFailedToRespond>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ISteamMatchmakingPingResponse>.NativeClassPtr, "InternalServerFailedToRespond");
				ISteamMatchmakingPingResponse.InternalServerFailedToRespond.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPingResponse.InternalServerFailedToRespond>.NativeClassPtr, 100663435);
				ISteamMatchmakingPingResponse.InternalServerFailedToRespond.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPingResponse.InternalServerFailedToRespond>.NativeClassPtr, 100663436);
				ISteamMatchmakingPingResponse.InternalServerFailedToRespond.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPingResponse.InternalServerFailedToRespond>.NativeClassPtr, 100663437);
				ISteamMatchmakingPingResponse.InternalServerFailedToRespond.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPingResponse.InternalServerFailedToRespond>.NativeClassPtr, 100663438);
			}

			// Token: 0x06001EFB RID: 7931 RVA: 0x00089A74 File Offset: 0x00087C74
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InternalServerFailedToRespond(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingPingResponse.InternalServerFailedToRespond>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPingResponse.InternalServerFailedToRespond.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EFC RID: 7932 RVA: 0x00089AD0 File Offset: 0x00087CD0
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 1199, RefRangeEnd = 1208, XrefRangeStart = 1199, XrefRangeEnd = 1199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(IntPtr thisptr)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref thisptr;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPingResponse.InternalServerFailedToRespond.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001EFD RID: 7933 RVA: 0x00089B10 File Offset: 0x00087D10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208, XrefRangeEnd = 1212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPingResponse.InternalServerFailedToRespond.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001EFE RID: 7934 RVA: 0x00089B80 File Offset: 0x00087D80
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPingResponse.InternalServerFailedToRespond.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001EFF RID: 7935 RVA: 0x0000B3F3 File Offset: 0x000095F3
			public InternalServerFailedToRespond(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001F00 RID: 7936 RVA: 0x0000B3FC File Offset: 0x000095FC
			public static implicit operator ISteamMatchmakingPingResponse.InternalServerFailedToRespond(Action<IntPtr> A_0)
			{
				return DelegateSupport.ConvertDelegate<ISteamMatchmakingPingResponse.InternalServerFailedToRespond>(A_0);
			}

			// Token: 0x06001F01 RID: 7937 RVA: 0x0000B404 File Offset: 0x00009604
			public static ISteamMatchmakingPingResponse.InternalServerFailedToRespond operator +(ISteamMatchmakingPingResponse.InternalServerFailedToRespond A_0, ISteamMatchmakingPingResponse.InternalServerFailedToRespond A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ISteamMatchmakingPingResponse.InternalServerFailedToRespond>();
			}

			// Token: 0x06001F02 RID: 7938 RVA: 0x0000B412 File Offset: 0x00009612
			public static ISteamMatchmakingPingResponse.InternalServerFailedToRespond operator -(ISteamMatchmakingPingResponse.InternalServerFailedToRespond A_0, ISteamMatchmakingPingResponse.InternalServerFailedToRespond A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ISteamMatchmakingPingResponse.InternalServerFailedToRespond>();
				}
				return delegate2;
			}

			// Token: 0x04001F8C RID: 8076
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001F8D RID: 8077
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0;

			// Token: 0x04001F8E RID: 8078
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0;

			// Token: 0x04001F8F RID: 8079
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000229 RID: 553
		public class VTable : Object
		{
			// Token: 0x06001F03 RID: 7939 RVA: 0x00089BC4 File Offset: 0x00087DC4
			// Note: this type is marked as 'beforefieldinit'.
			static VTable()
			{
				Il2CppClassPointerStore<ISteamMatchmakingPingResponse.VTable>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ISteamMatchmakingPingResponse>.NativeClassPtr, "VTable");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ISteamMatchmakingPingResponse.VTable>.NativeClassPtr);
				ISteamMatchmakingPingResponse.VTable.NativeFieldInfoPtr_m_VTServerResponded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingPingResponse.VTable>.NativeClassPtr, "m_VTServerResponded");
				ISteamMatchmakingPingResponse.VTable.NativeFieldInfoPtr_m_VTServerFailedToRespond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingPingResponse.VTable>.NativeClassPtr, "m_VTServerFailedToRespond");
				ISteamMatchmakingPingResponse.VTable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPingResponse.VTable>.NativeClassPtr, 100663439);
			}

			// Token: 0x06001F04 RID: 7940 RVA: 0x00089C2C File Offset: 0x00087E2C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe VTable()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingPingResponse.VTable>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPingResponse.VTable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F05 RID: 7941 RVA: 0x0000B423 File Offset: 0x00009623
			public VTable(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000627 RID: 1575
			// (get) Token: 0x06001F06 RID: 7942 RVA: 0x00089C68 File Offset: 0x00087E68
			// (set) Token: 0x06001F07 RID: 7943 RVA: 0x0000B42C File Offset: 0x0000962C
			public unsafe ISteamMatchmakingPingResponse.InternalServerResponded m_VTServerResponded
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPingResponse.VTable.NativeFieldInfoPtr_m_VTServerResponded);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISteamMatchmakingPingResponse.InternalServerResponded>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPingResponse.VTable.NativeFieldInfoPtr_m_VTServerResponded), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000628 RID: 1576
			// (get) Token: 0x06001F08 RID: 7944 RVA: 0x00089C98 File Offset: 0x00087E98
			// (set) Token: 0x06001F09 RID: 7945 RVA: 0x0000B44B File Offset: 0x0000964B
			public unsafe ISteamMatchmakingPingResponse.InternalServerFailedToRespond m_VTServerFailedToRespond
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPingResponse.VTable.NativeFieldInfoPtr_m_VTServerFailedToRespond);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISteamMatchmakingPingResponse.InternalServerFailedToRespond>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPingResponse.VTable.NativeFieldInfoPtr_m_VTServerFailedToRespond), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001F90 RID: 8080
			private static readonly IntPtr NativeFieldInfoPtr_m_VTServerResponded;

			// Token: 0x04001F91 RID: 8081
			private static readonly IntPtr NativeFieldInfoPtr_m_VTServerFailedToRespond;

			// Token: 0x04001F92 RID: 8082
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
