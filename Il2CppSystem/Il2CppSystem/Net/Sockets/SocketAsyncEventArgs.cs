using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Net.Sockets
{
	// Token: 0x02000156 RID: 342
	public class SocketAsyncEventArgs : EventArgs
	{
		// Token: 0x060015C4 RID: 5572 RVA: 0x00062DD8 File Offset: 0x00060FD8
		// Note: this type is marked as 'beforefieldinit'.
		static SocketAsyncEventArgs()
		{
			Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Sockets", "SocketAsyncEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr);
			SocketAsyncEventArgs.NativeFieldInfoPtr_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, "disposed");
			SocketAsyncEventArgs.NativeFieldInfoPtr_in_progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, "in_progress");
			SocketAsyncEventArgs.NativeFieldInfoPtr_remote_ep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, "remote_ep");
			SocketAsyncEventArgs.NativeFieldInfoPtr_current_socket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, "current_socket");
			SocketAsyncEventArgs.NativeFieldInfoPtr_socket_async_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, "socket_async_result");
			SocketAsyncEventArgs.NativeFieldInfoPtr__ConnectByNameError_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, "<ConnectByNameError>k__BackingField");
			SocketAsyncEventArgs.NativeFieldInfoPtr__AcceptSocket_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, "<AcceptSocket>k__BackingField");
			SocketAsyncEventArgs.NativeFieldInfoPtr__Buffer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, "<Buffer>k__BackingField");
			SocketAsyncEventArgs.NativeFieldInfoPtr_m_BufferList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, "m_BufferList");
			SocketAsyncEventArgs.NativeFieldInfoPtr__BytesTransferred_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, "<BytesTransferred>k__BackingField");
			SocketAsyncEventArgs.NativeFieldInfoPtr__Count_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, "<Count>k__BackingField");
			SocketAsyncEventArgs.NativeFieldInfoPtr__DisconnectReuseSocket_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, "<DisconnectReuseSocket>k__BackingField");
			SocketAsyncEventArgs.NativeFieldInfoPtr__LastOperation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, "<LastOperation>k__BackingField");
			SocketAsyncEventArgs.NativeFieldInfoPtr__Offset_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, "<Offset>k__BackingField");
			SocketAsyncEventArgs.NativeFieldInfoPtr__ReceiveMessageFromPacketInfo_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, "<ReceiveMessageFromPacketInfo>k__BackingField");
			SocketAsyncEventArgs.NativeFieldInfoPtr__SendPacketsElements_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, "<SendPacketsElements>k__BackingField");
			SocketAsyncEventArgs.NativeFieldInfoPtr__SendPacketsFlags_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, "<SendPacketsFlags>k__BackingField");
			SocketAsyncEventArgs.NativeFieldInfoPtr__SendPacketsSendSize_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, "<SendPacketsSendSize>k__BackingField");
			SocketAsyncEventArgs.NativeFieldInfoPtr__SocketError_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, "<SocketError>k__BackingField");
			SocketAsyncEventArgs.NativeFieldInfoPtr__SocketFlags_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, "<SocketFlags>k__BackingField");
			SocketAsyncEventArgs.NativeFieldInfoPtr__UserToken_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, "<UserToken>k__BackingField");
			SocketAsyncEventArgs.NativeFieldInfoPtr__PolicyRestricted_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, "<PolicyRestricted>k__BackingField");
			SocketAsyncEventArgs.NativeFieldInfoPtr_Completed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, "Completed");
			SocketAsyncEventArgs.NativeMethodInfoPtr_set_ConnectByNameError_Internal_set_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100666410);
			SocketAsyncEventArgs.NativeMethodInfoPtr_get_AcceptSocket_Public_get_Socket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100666411);
			SocketAsyncEventArgs.NativeMethodInfoPtr_set_AcceptSocket_Public_set_Void_Socket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100666412);
			SocketAsyncEventArgs.NativeMethodInfoPtr_get_Buffer_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100666413);
			SocketAsyncEventArgs.NativeMethodInfoPtr_set_Buffer_Private_set_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100666414);
			SocketAsyncEventArgs.NativeMethodInfoPtr_get_BufferList_Public_get_IList_1_ArraySegment_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100666415);
			SocketAsyncEventArgs.NativeMethodInfoPtr_set_BytesTransferred_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100666416);
			SocketAsyncEventArgs.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100666417);
			SocketAsyncEventArgs.NativeMethodInfoPtr_set_Count_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100666418);
			SocketAsyncEventArgs.NativeMethodInfoPtr_set_LastOperation_Private_set_Void_SocketAsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100666419);
			SocketAsyncEventArgs.NativeMethodInfoPtr_get_Offset_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100666420);
			SocketAsyncEventArgs.NativeMethodInfoPtr_set_Offset_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100666421);
			SocketAsyncEventArgs.NativeMethodInfoPtr_get_RemoteEndPoint_Public_get_EndPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100666422);
			SocketAsyncEventArgs.NativeMethodInfoPtr_set_RemoteEndPoint_Public_set_Void_EndPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100666423);
			SocketAsyncEventArgs.NativeMethodInfoPtr_set_SendPacketsSendSize_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100666424);
			SocketAsyncEventArgs.NativeMethodInfoPtr_get_SocketError_Public_get_SocketError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100666425);
			SocketAsyncEventArgs.NativeMethodInfoPtr_set_SocketError_Public_set_Void_SocketError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100666426);
			SocketAsyncEventArgs.NativeMethodInfoPtr_set_UserToken_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100666427);
			SocketAsyncEventArgs.NativeMethodInfoPtr_add_Completed_Public_add_Void_EventHandler_1_SocketAsyncEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100666428);
			SocketAsyncEventArgs.NativeMethodInfoPtr_remove_Completed_Public_rem_Void_EventHandler_1_SocketAsyncEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100666429);
			SocketAsyncEventArgs.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100666430);
			SocketAsyncEventArgs.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100666431);
			SocketAsyncEventArgs.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100666432);
			SocketAsyncEventArgs.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100666433);
			SocketAsyncEventArgs.NativeMethodInfoPtr_SetLastOperation_Internal_Void_SocketAsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100666434);
			SocketAsyncEventArgs.NativeMethodInfoPtr_Complete_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100666435);
			SocketAsyncEventArgs.NativeMethodInfoPtr_OnCompleted_Protected_Virtual_New_Void_SocketAsyncEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100666436);
			SocketAsyncEventArgs.NativeMethodInfoPtr_SetBuffer_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100666437);
		}

		// Token: 0x17000712 RID: 1810
		// (set) Token: 0x060015C5 RID: 5573 RVA: 0x00063204 File Offset: 0x00061404
		public unsafe Exception ConnectByNameError
		{
			[CallerCount(38)]
			[CachedScanResults(RefRangeStart = 14017, RefRangeEnd = 14055, XrefRangeStart = 14017, XrefRangeEnd = 14055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_set_ConnectByNameError_Internal_set_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x060015C6 RID: 5574 RVA: 0x00063248 File Offset: 0x00061448
		// (set) Token: 0x060015C7 RID: 5575 RVA: 0x00063288 File Offset: 0x00061488
		public unsafe Socket AcceptSocket
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 621, RefRangeEnd = 626, XrefRangeStart = 621, XrefRangeEnd = 626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_get_AcceptSocket_Public_get_Socket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Socket>(intPtr3) : null;
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 99340, RefRangeEnd = 99363, XrefRangeStart = 99340, XrefRangeEnd = 99363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_set_AcceptSocket_Public_set_Void_Socket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x060015C8 RID: 5576 RVA: 0x000632CC File Offset: 0x000614CC
		// (set) Token: 0x060015C9 RID: 5577 RVA: 0x0006330C File Offset: 0x0006150C
		public unsafe Il2CppStructArray<byte> Buffer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_get_Buffer_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
			[CallerCount(43)]
			[CachedScanResults(RefRangeStart = 13782, RefRangeEnd = 13825, XrefRangeStart = 13782, XrefRangeEnd = 13825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_set_Buffer_Private_set_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x060015CA RID: 5578 RVA: 0x00063350 File Offset: 0x00061550
		public unsafe IList<ArraySegment<byte>> BufferList
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_get_BufferList_Public_get_IList_1_ArraySegment_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<ArraySegment<byte>>>(intPtr3) : null;
			}
		}

		// Token: 0x17000716 RID: 1814
		// (set) Token: 0x060015CB RID: 5579 RVA: 0x00063390 File Offset: 0x00061590
		public unsafe int BytesTransferred
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_set_BytesTransferred_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x060015CC RID: 5580 RVA: 0x000633D0 File Offset: 0x000615D0
		// (set) Token: 0x060015CD RID: 5581 RVA: 0x0006340C File Offset: 0x0006160C
		public unsafe int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_set_Count_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000718 RID: 1816
		// (set) Token: 0x060015CE RID: 5582 RVA: 0x0006344C File Offset: 0x0006164C
		public unsafe SocketAsyncOperation LastOperation
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_set_LastOperation_Private_set_Void_SocketAsyncOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x060015CF RID: 5583 RVA: 0x0006348C File Offset: 0x0006168C
		// (set) Token: 0x060015D0 RID: 5584 RVA: 0x000634C8 File Offset: 0x000616C8
		public unsafe int Offset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_get_Offset_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_set_Offset_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x060015D1 RID: 5585 RVA: 0x00063508 File Offset: 0x00061708
		// (set) Token: 0x060015D2 RID: 5586 RVA: 0x00063548 File Offset: 0x00061748
		public unsafe EndPoint RemoteEndPoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_get_RemoteEndPoint_Public_get_EndPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EndPoint>(intPtr3) : null;
			}
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 18562, RefRangeEnd = 18620, XrefRangeStart = 18562, XrefRangeEnd = 18620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_set_RemoteEndPoint_Public_set_Void_EndPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700071B RID: 1819
		// (set) Token: 0x060015D3 RID: 5587 RVA: 0x0006358C File Offset: 0x0006178C
		public unsafe int SendPacketsSendSize
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_set_SendPacketsSendSize_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x060015D4 RID: 5588 RVA: 0x000635CC File Offset: 0x000617CC
		// (set) Token: 0x060015D5 RID: 5589 RVA: 0x00063608 File Offset: 0x00061808
		public unsafe SocketError SocketError
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_get_SocketError_Public_get_SocketError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_set_SocketError_Public_set_Void_SocketError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700071D RID: 1821
		// (set) Token: 0x060015D6 RID: 5590 RVA: 0x00063648 File Offset: 0x00061848
		public unsafe Object UserToken
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 388203, RefRangeEnd = 388211, XrefRangeStart = 388203, XrefRangeEnd = 388203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_set_UserToken_Public_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060015D7 RID: 5591 RVA: 0x0006368C File Offset: 0x0006188C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 388214, RefRangeEnd = 388215, XrefRangeStart = 388211, XrefRangeEnd = 388214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_Completed(EventHandler<SocketAsyncEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_add_Completed_Public_add_Void_EventHandler_1_SocketAsyncEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015D8 RID: 5592 RVA: 0x000636D0 File Offset: 0x000618D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388215, XrefRangeEnd = 388218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_Completed(EventHandler<SocketAsyncEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_remove_Completed_Public_rem_Void_EventHandler_1_SocketAsyncEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015D9 RID: 5593 RVA: 0x00063714 File Offset: 0x00061914
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 388224, RefRangeEnd = 388225, XrefRangeStart = 388218, XrefRangeEnd = 388224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SocketAsyncEventArgs()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015DA RID: 5594 RVA: 0x00063750 File Offset: 0x00061950
		[CallerCount(0)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SocketAsyncEventArgs.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015DB RID: 5595 RVA: 0x0006378C File Offset: 0x0006198C
		[CallerCount(0)]
		public unsafe void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015DC RID: 5596 RVA: 0x000637CC File Offset: 0x000619CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388225, XrefRangeEnd = 388229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015DD RID: 5597 RVA: 0x00063800 File Offset: 0x00061A00
		[CallerCount(0)]
		public unsafe void SetLastOperation(SocketAsyncOperation op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref op;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_SetLastOperation_Internal_Void_SocketAsyncOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015DE RID: 5598 RVA: 0x00063840 File Offset: 0x00061A40
		[CallerCount(0)]
		public unsafe void Complete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_Complete_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015DF RID: 5599 RVA: 0x00063874 File Offset: 0x00061A74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388229, XrefRangeEnd = 388232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnCompleted(SocketAsyncEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SocketAsyncEventArgs.NativeMethodInfoPtr_OnCompleted_Protected_Virtual_New_Void_SocketAsyncEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015E0 RID: 5600 RVA: 0x000638C4 File Offset: 0x00061AC4
		[CallerCount(0)]
		public unsafe void SetBuffer(Il2CppStructArray<byte> buffer, int offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_SetBuffer_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015E1 RID: 5601 RVA: 0x0000ACD4 File Offset: 0x00008ED4
		public SocketAsyncEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x060015E2 RID: 5602 RVA: 0x00063924 File Offset: 0x00061B24
		// (set) Token: 0x060015E3 RID: 5603 RVA: 0x0000ACDD File Offset: 0x00008EDD
		public unsafe bool disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr_disposed)) = value;
			}
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x060015E4 RID: 5604 RVA: 0x0006394C File Offset: 0x00061B4C
		// (set) Token: 0x060015E5 RID: 5605 RVA: 0x0000ACF8 File Offset: 0x00008EF8
		public unsafe int in_progress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr_in_progress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr_in_progress)) = value;
			}
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x060015E6 RID: 5606 RVA: 0x00063974 File Offset: 0x00061B74
		// (set) Token: 0x060015E7 RID: 5607 RVA: 0x0000AD13 File Offset: 0x00008F13
		public unsafe EndPoint remote_ep
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr_remote_ep);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EndPoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr_remote_ep), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x060015E8 RID: 5608 RVA: 0x000639A4 File Offset: 0x00061BA4
		// (set) Token: 0x060015E9 RID: 5609 RVA: 0x0000AD32 File Offset: 0x00008F32
		public unsafe Socket current_socket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr_current_socket);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Socket>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr_current_socket), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x060015EA RID: 5610 RVA: 0x000639D4 File Offset: 0x00061BD4
		// (set) Token: 0x060015EB RID: 5611 RVA: 0x0000AD51 File Offset: 0x00008F51
		public unsafe SocketAsyncResult socket_async_result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr_socket_async_result);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SocketAsyncResult>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr_socket_async_result), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x060015EC RID: 5612 RVA: 0x00063A04 File Offset: 0x00061C04
		// (set) Token: 0x060015ED RID: 5613 RVA: 0x0000AD70 File Offset: 0x00008F70
		public unsafe Exception _ConnectByNameError_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__ConnectByNameError_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__ConnectByNameError_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x060015EE RID: 5614 RVA: 0x00063A34 File Offset: 0x00061C34
		// (set) Token: 0x060015EF RID: 5615 RVA: 0x0000AD8F File Offset: 0x00008F8F
		public unsafe Socket _AcceptSocket_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__AcceptSocket_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Socket>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__AcceptSocket_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x060015F0 RID: 5616 RVA: 0x00063A64 File Offset: 0x00061C64
		// (set) Token: 0x060015F1 RID: 5617 RVA: 0x0000ADAE File Offset: 0x00008FAE
		public unsafe Il2CppStructArray<byte> _Buffer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__Buffer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__Buffer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x060015F2 RID: 5618 RVA: 0x00063A94 File Offset: 0x00061C94
		// (set) Token: 0x060015F3 RID: 5619 RVA: 0x0000ADCD File Offset: 0x00008FCD
		public unsafe IList<ArraySegment<byte>> m_BufferList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr_m_BufferList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<ArraySegment<byte>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr_m_BufferList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x060015F4 RID: 5620 RVA: 0x00063AC4 File Offset: 0x00061CC4
		// (set) Token: 0x060015F5 RID: 5621 RVA: 0x0000ADEC File Offset: 0x00008FEC
		public unsafe int _BytesTransferred_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__BytesTransferred_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__BytesTransferred_k__BackingField)) = value;
			}
		}

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x060015F6 RID: 5622 RVA: 0x00063AEC File Offset: 0x00061CEC
		// (set) Token: 0x060015F7 RID: 5623 RVA: 0x0000AE07 File Offset: 0x00009007
		public unsafe int _Count_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__Count_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__Count_k__BackingField)) = value;
			}
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x060015F8 RID: 5624 RVA: 0x00063B14 File Offset: 0x00061D14
		// (set) Token: 0x060015F9 RID: 5625 RVA: 0x0000AE22 File Offset: 0x00009022
		public unsafe bool _DisconnectReuseSocket_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__DisconnectReuseSocket_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__DisconnectReuseSocket_k__BackingField)) = value;
			}
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x060015FA RID: 5626 RVA: 0x00063B3C File Offset: 0x00061D3C
		// (set) Token: 0x060015FB RID: 5627 RVA: 0x0000AE3D File Offset: 0x0000903D
		public unsafe SocketAsyncOperation _LastOperation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__LastOperation_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__LastOperation_k__BackingField)) = value;
			}
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x060015FC RID: 5628 RVA: 0x00063B64 File Offset: 0x00061D64
		// (set) Token: 0x060015FD RID: 5629 RVA: 0x0000AE58 File Offset: 0x00009058
		public unsafe int _Offset_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__Offset_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__Offset_k__BackingField)) = value;
			}
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x060015FE RID: 5630 RVA: 0x00063B8C File Offset: 0x00061D8C
		// (set) Token: 0x060015FF RID: 5631 RVA: 0x0000AE73 File Offset: 0x00009073
		public IPPacketInformation _ReceiveMessageFromPacketInfo_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__ReceiveMessageFromPacketInfo_k__BackingField);
				return new IPPacketInformation(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IPPacketInformation>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__ReceiveMessageFromPacketInfo_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<IPPacketInformation>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x06001600 RID: 5632 RVA: 0x00063BBC File Offset: 0x00061DBC
		// (set) Token: 0x06001601 RID: 5633 RVA: 0x0000AEA1 File Offset: 0x000090A1
		public unsafe Il2CppReferenceArray<SendPacketsElement> _SendPacketsElements_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__SendPacketsElements_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SendPacketsElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__SendPacketsElements_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x06001602 RID: 5634 RVA: 0x00063BEC File Offset: 0x00061DEC
		// (set) Token: 0x06001603 RID: 5635 RVA: 0x0000AEC0 File Offset: 0x000090C0
		public unsafe TransmitFileOptions _SendPacketsFlags_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__SendPacketsFlags_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__SendPacketsFlags_k__BackingField)) = value;
			}
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x06001604 RID: 5636 RVA: 0x00063C14 File Offset: 0x00061E14
		// (set) Token: 0x06001605 RID: 5637 RVA: 0x0000AEDB File Offset: 0x000090DB
		public unsafe int _SendPacketsSendSize_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__SendPacketsSendSize_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__SendPacketsSendSize_k__BackingField)) = value;
			}
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x06001606 RID: 5638 RVA: 0x00063C3C File Offset: 0x00061E3C
		// (set) Token: 0x06001607 RID: 5639 RVA: 0x0000AEF6 File Offset: 0x000090F6
		public unsafe SocketError _SocketError_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__SocketError_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__SocketError_k__BackingField)) = value;
			}
		}

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x06001608 RID: 5640 RVA: 0x00063C64 File Offset: 0x00061E64
		// (set) Token: 0x06001609 RID: 5641 RVA: 0x0000AF11 File Offset: 0x00009111
		public unsafe SocketFlags _SocketFlags_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__SocketFlags_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__SocketFlags_k__BackingField)) = value;
			}
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x0600160A RID: 5642 RVA: 0x00063C8C File Offset: 0x00061E8C
		// (set) Token: 0x0600160B RID: 5643 RVA: 0x0000AF2C File Offset: 0x0000912C
		public unsafe Object _UserToken_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__UserToken_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__UserToken_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x0600160C RID: 5644 RVA: 0x00063CBC File Offset: 0x00061EBC
		// (set) Token: 0x0600160D RID: 5645 RVA: 0x0000AF4B File Offset: 0x0000914B
		public unsafe bool _PolicyRestricted_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__PolicyRestricted_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__PolicyRestricted_k__BackingField)) = value;
			}
		}

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x0600160E RID: 5646 RVA: 0x00063CE4 File Offset: 0x00061EE4
		// (set) Token: 0x0600160F RID: 5647 RVA: 0x0000AF66 File Offset: 0x00009166
		public unsafe EventHandler<SocketAsyncEventArgs> Completed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr_Completed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<SocketAsyncEventArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr_Completed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001176 RID: 4470
		private static readonly IntPtr NativeFieldInfoPtr_disposed;

		// Token: 0x04001177 RID: 4471
		private static readonly IntPtr NativeFieldInfoPtr_in_progress;

		// Token: 0x04001178 RID: 4472
		private static readonly IntPtr NativeFieldInfoPtr_remote_ep;

		// Token: 0x04001179 RID: 4473
		private static readonly IntPtr NativeFieldInfoPtr_current_socket;

		// Token: 0x0400117A RID: 4474
		private static readonly IntPtr NativeFieldInfoPtr_socket_async_result;

		// Token: 0x0400117B RID: 4475
		private static readonly IntPtr NativeFieldInfoPtr__ConnectByNameError_k__BackingField;

		// Token: 0x0400117C RID: 4476
		private static readonly IntPtr NativeFieldInfoPtr__AcceptSocket_k__BackingField;

		// Token: 0x0400117D RID: 4477
		private static readonly IntPtr NativeFieldInfoPtr__Buffer_k__BackingField;

		// Token: 0x0400117E RID: 4478
		private static readonly IntPtr NativeFieldInfoPtr_m_BufferList;

		// Token: 0x0400117F RID: 4479
		private static readonly IntPtr NativeFieldInfoPtr__BytesTransferred_k__BackingField;

		// Token: 0x04001180 RID: 4480
		private static readonly IntPtr NativeFieldInfoPtr__Count_k__BackingField;

		// Token: 0x04001181 RID: 4481
		private static readonly IntPtr NativeFieldInfoPtr__DisconnectReuseSocket_k__BackingField;

		// Token: 0x04001182 RID: 4482
		private static readonly IntPtr NativeFieldInfoPtr__LastOperation_k__BackingField;

		// Token: 0x04001183 RID: 4483
		private static readonly IntPtr NativeFieldInfoPtr__Offset_k__BackingField;

		// Token: 0x04001184 RID: 4484
		private static readonly IntPtr NativeFieldInfoPtr__ReceiveMessageFromPacketInfo_k__BackingField;

		// Token: 0x04001185 RID: 4485
		private static readonly IntPtr NativeFieldInfoPtr__SendPacketsElements_k__BackingField;

		// Token: 0x04001186 RID: 4486
		private static readonly IntPtr NativeFieldInfoPtr__SendPacketsFlags_k__BackingField;

		// Token: 0x04001187 RID: 4487
		private static readonly IntPtr NativeFieldInfoPtr__SendPacketsSendSize_k__BackingField;

		// Token: 0x04001188 RID: 4488
		private static readonly IntPtr NativeFieldInfoPtr__SocketError_k__BackingField;

		// Token: 0x04001189 RID: 4489
		private static readonly IntPtr NativeFieldInfoPtr__SocketFlags_k__BackingField;

		// Token: 0x0400118A RID: 4490
		private static readonly IntPtr NativeFieldInfoPtr__UserToken_k__BackingField;

		// Token: 0x0400118B RID: 4491
		private static readonly IntPtr NativeFieldInfoPtr__PolicyRestricted_k__BackingField;

		// Token: 0x0400118C RID: 4492
		private static readonly IntPtr NativeFieldInfoPtr_Completed;

		// Token: 0x0400118D RID: 4493
		private static readonly IntPtr NativeMethodInfoPtr_set_ConnectByNameError_Internal_set_Void_Exception_0;

		// Token: 0x0400118E RID: 4494
		private static readonly IntPtr NativeMethodInfoPtr_get_AcceptSocket_Public_get_Socket_0;

		// Token: 0x0400118F RID: 4495
		private static readonly IntPtr NativeMethodInfoPtr_set_AcceptSocket_Public_set_Void_Socket_0;

		// Token: 0x04001190 RID: 4496
		private static readonly IntPtr NativeMethodInfoPtr_get_Buffer_Public_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001191 RID: 4497
		private static readonly IntPtr NativeMethodInfoPtr_set_Buffer_Private_set_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001192 RID: 4498
		private static readonly IntPtr NativeMethodInfoPtr_get_BufferList_Public_get_IList_1_ArraySegment_1_Byte_0;

		// Token: 0x04001193 RID: 4499
		private static readonly IntPtr NativeMethodInfoPtr_set_BytesTransferred_Internal_set_Void_Int32_0;

		// Token: 0x04001194 RID: 4500
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x04001195 RID: 4501
		private static readonly IntPtr NativeMethodInfoPtr_set_Count_Internal_set_Void_Int32_0;

		// Token: 0x04001196 RID: 4502
		private static readonly IntPtr NativeMethodInfoPtr_set_LastOperation_Private_set_Void_SocketAsyncOperation_0;

		// Token: 0x04001197 RID: 4503
		private static readonly IntPtr NativeMethodInfoPtr_get_Offset_Public_get_Int32_0;

		// Token: 0x04001198 RID: 4504
		private static readonly IntPtr NativeMethodInfoPtr_set_Offset_Private_set_Void_Int32_0;

		// Token: 0x04001199 RID: 4505
		private static readonly IntPtr NativeMethodInfoPtr_get_RemoteEndPoint_Public_get_EndPoint_0;

		// Token: 0x0400119A RID: 4506
		private static readonly IntPtr NativeMethodInfoPtr_set_RemoteEndPoint_Public_set_Void_EndPoint_0;

		// Token: 0x0400119B RID: 4507
		private static readonly IntPtr NativeMethodInfoPtr_set_SendPacketsSendSize_Public_set_Void_Int32_0;

		// Token: 0x0400119C RID: 4508
		private static readonly IntPtr NativeMethodInfoPtr_get_SocketError_Public_get_SocketError_0;

		// Token: 0x0400119D RID: 4509
		private static readonly IntPtr NativeMethodInfoPtr_set_SocketError_Public_set_Void_SocketError_0;

		// Token: 0x0400119E RID: 4510
		private static readonly IntPtr NativeMethodInfoPtr_set_UserToken_Public_set_Void_Object_0;

		// Token: 0x0400119F RID: 4511
		private static readonly IntPtr NativeMethodInfoPtr_add_Completed_Public_add_Void_EventHandler_1_SocketAsyncEventArgs_0;

		// Token: 0x040011A0 RID: 4512
		private static readonly IntPtr NativeMethodInfoPtr_remove_Completed_Public_rem_Void_EventHandler_1_SocketAsyncEventArgs_0;

		// Token: 0x040011A1 RID: 4513
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040011A2 RID: 4514
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x040011A3 RID: 4515
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0;

		// Token: 0x040011A4 RID: 4516
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x040011A5 RID: 4517
		private static readonly IntPtr NativeMethodInfoPtr_SetLastOperation_Internal_Void_SocketAsyncOperation_0;

		// Token: 0x040011A6 RID: 4518
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Internal_Void_0;

		// Token: 0x040011A7 RID: 4519
		private static readonly IntPtr NativeMethodInfoPtr_OnCompleted_Protected_Virtual_New_Void_SocketAsyncEventArgs_0;

		// Token: 0x040011A8 RID: 4520
		private static readonly IntPtr NativeMethodInfoPtr_SetBuffer_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;
	}
}
