using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Threading;

namespace Il2CppSystem.Net.Sockets
{
	// Token: 0x02000157 RID: 343
	public sealed class SocketAsyncResult : IOAsyncResult
	{
		// Token: 0x06001610 RID: 5648 RVA: 0x00063D14 File Offset: 0x00061F14
		// Note: this type is marked as 'beforefieldinit'.
		static SocketAsyncResult()
		{
			Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Sockets", "SocketAsyncResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr);
			SocketAsyncResult.NativeFieldInfoPtr_socket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "socket");
			SocketAsyncResult.NativeFieldInfoPtr_operation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "operation");
			SocketAsyncResult.NativeFieldInfoPtr_DelayedException = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "DelayedException");
			SocketAsyncResult.NativeFieldInfoPtr_EndPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "EndPoint");
			SocketAsyncResult.NativeFieldInfoPtr_Buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "Buffer");
			SocketAsyncResult.NativeFieldInfoPtr_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "Offset");
			SocketAsyncResult.NativeFieldInfoPtr_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "Size");
			SocketAsyncResult.NativeFieldInfoPtr_SockFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "SockFlags");
			SocketAsyncResult.NativeFieldInfoPtr_AcceptSocket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "AcceptSocket");
			SocketAsyncResult.NativeFieldInfoPtr_Addresses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "Addresses");
			SocketAsyncResult.NativeFieldInfoPtr_Port = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "Port");
			SocketAsyncResult.NativeFieldInfoPtr_Buffers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "Buffers");
			SocketAsyncResult.NativeFieldInfoPtr_ReuseSocket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "ReuseSocket");
			SocketAsyncResult.NativeFieldInfoPtr_CurrentAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "CurrentAddress");
			SocketAsyncResult.NativeFieldInfoPtr_AcceptedSocket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "AcceptedSocket");
			SocketAsyncResult.NativeFieldInfoPtr_Total = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "Total");
			SocketAsyncResult.NativeFieldInfoPtr_error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "error");
			SocketAsyncResult.NativeFieldInfoPtr_EndCalled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "EndCalled");
			SocketAsyncResult.NativeMethodInfoPtr_get_Handle_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, 100666438);
			SocketAsyncResult.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, 100666439);
			SocketAsyncResult.NativeMethodInfoPtr_Init_Public_Void_Socket_AsyncCallback_Object_SocketOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, 100666440);
			SocketAsyncResult.NativeMethodInfoPtr__ctor_Public_Void_Socket_AsyncCallback_Object_SocketOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, 100666441);
			SocketAsyncResult.NativeMethodInfoPtr_get_ErrorCode_Public_get_SocketError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, 100666442);
			SocketAsyncResult.NativeMethodInfoPtr_CheckIfThrowDelayedException_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, 100666443);
			SocketAsyncResult.NativeMethodInfoPtr_CompleteDisposed_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, 100666444);
			SocketAsyncResult.NativeMethodInfoPtr_Complete_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, 100666445);
			SocketAsyncResult.NativeMethodInfoPtr_Complete_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, 100666446);
			SocketAsyncResult.NativeMethodInfoPtr_Complete_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, 100666447);
			SocketAsyncResult.NativeMethodInfoPtr_Complete_Public_Void_Exception_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, 100666448);
			SocketAsyncResult.NativeMethodInfoPtr_Complete_Public_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, 100666449);
			SocketAsyncResult.NativeMethodInfoPtr_Complete_Public_Void_Socket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, 100666450);
			SocketAsyncResult.NativeMethodInfoPtr_Complete_Public_Void_Socket_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, 100666451);
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x06001611 RID: 5649 RVA: 0x00063FC4 File Offset: 0x000621C4
		public unsafe IntPtr Handle
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388241, XrefRangeEnd = 388242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncResult.NativeMethodInfoPtr_get_Handle_Public_get_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001612 RID: 5650 RVA: 0x00064000 File Offset: 0x00062200
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SocketAsyncResult()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncResult.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001613 RID: 5651 RVA: 0x0006403C File Offset: 0x0006223C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 388243, RefRangeEnd = 388246, XrefRangeStart = 388242, XrefRangeEnd = 388243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(Socket socket, AsyncCallback callback, Object state, SocketOperation operation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(socket);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref operation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncResult.NativeMethodInfoPtr_Init_Public_Void_Socket_AsyncCallback_Object_SocketOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001614 RID: 5652 RVA: 0x000640B0 File Offset: 0x000622B0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 388246, RefRangeEnd = 388250, XrefRangeStart = 388246, XrefRangeEnd = 388246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SocketAsyncResult(Socket socket, AsyncCallback callback, Object state, SocketOperation operation)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(socket);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref operation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncResult.NativeMethodInfoPtr__ctor_Public_Void_Socket_AsyncCallback_Object_SocketOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x06001615 RID: 5653 RVA: 0x00064130 File Offset: 0x00062330
		public unsafe SocketError ErrorCode
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 388252, RefRangeEnd = 388256, XrefRangeStart = 388250, XrefRangeEnd = 388252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncResult.NativeMethodInfoPtr_get_ErrorCode_Public_get_SocketError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001616 RID: 5654 RVA: 0x0006416C File Offset: 0x0006236C
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 388256, RefRangeEnd = 388271, XrefRangeStart = 388256, XrefRangeEnd = 388256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckIfThrowDelayedException()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncResult.NativeMethodInfoPtr_CheckIfThrowDelayedException_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001617 RID: 5655 RVA: 0x000641A0 File Offset: 0x000623A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388271, XrefRangeEnd = 388272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CompleteDisposed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncResult.NativeMethodInfoPtr_CompleteDisposed_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001618 RID: 5656 RVA: 0x000641D4 File Offset: 0x000623D4
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 388296, RefRangeEnd = 388312, XrefRangeStart = 388272, XrefRangeEnd = 388296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Complete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncResult.NativeMethodInfoPtr_Complete_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001619 RID: 5657 RVA: 0x00064208 File Offset: 0x00062408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388312, XrefRangeEnd = 388313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Complete(bool synch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref synch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncResult.NativeMethodInfoPtr_Complete_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600161A RID: 5658 RVA: 0x00064248 File Offset: 0x00062448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388313, XrefRangeEnd = 388314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Complete(int total)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref total;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncResult.NativeMethodInfoPtr_Complete_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600161B RID: 5659 RVA: 0x00064288 File Offset: 0x00062488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388314, XrefRangeEnd = 388315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Complete(Exception e, bool synch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref synch;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncResult.NativeMethodInfoPtr_Complete_Public_Void_Exception_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600161C RID: 5660 RVA: 0x000642D8 File Offset: 0x000624D8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 388316, RefRangeEnd = 388321, XrefRangeStart = 388315, XrefRangeEnd = 388316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Complete(Exception e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncResult.NativeMethodInfoPtr_Complete_Public_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600161D RID: 5661 RVA: 0x0006431C File Offset: 0x0006251C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388321, XrefRangeEnd = 388322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Complete(Socket s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncResult.NativeMethodInfoPtr_Complete_Public_Void_Socket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600161E RID: 5662 RVA: 0x00064360 File Offset: 0x00062560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388322, XrefRangeEnd = 388323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Complete(Socket s, int total)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref total;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncResult.NativeMethodInfoPtr_Complete_Public_Void_Socket_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600161F RID: 5663 RVA: 0x0000AF85 File Offset: 0x00009185
		public SocketAsyncResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x06001620 RID: 5664 RVA: 0x000643B0 File Offset: 0x000625B0
		// (set) Token: 0x06001621 RID: 5665 RVA: 0x0000AF8E File Offset: 0x0000918E
		public unsafe Socket socket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_socket);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Socket>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_socket), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x06001622 RID: 5666 RVA: 0x000643E0 File Offset: 0x000625E0
		// (set) Token: 0x06001623 RID: 5667 RVA: 0x0000AFAD File Offset: 0x000091AD
		public unsafe SocketOperation operation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_operation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_operation)) = value;
			}
		}

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x06001624 RID: 5668 RVA: 0x00064408 File Offset: 0x00062608
		// (set) Token: 0x06001625 RID: 5669 RVA: 0x0000AFC8 File Offset: 0x000091C8
		public unsafe Exception DelayedException
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_DelayedException);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_DelayedException), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x06001626 RID: 5670 RVA: 0x00064438 File Offset: 0x00062638
		// (set) Token: 0x06001627 RID: 5671 RVA: 0x0000AFE7 File Offset: 0x000091E7
		public unsafe EndPoint EndPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_EndPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EndPoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_EndPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x06001628 RID: 5672 RVA: 0x00064468 File Offset: 0x00062668
		// (set) Token: 0x06001629 RID: 5673 RVA: 0x0000B006 File Offset: 0x00009206
		public unsafe Il2CppStructArray<byte> Buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_Buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_Buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x0600162A RID: 5674 RVA: 0x00064498 File Offset: 0x00062698
		// (set) Token: 0x0600162B RID: 5675 RVA: 0x0000B025 File Offset: 0x00009225
		public unsafe int Offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_Offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_Offset)) = value;
			}
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x0600162C RID: 5676 RVA: 0x000644C0 File Offset: 0x000626C0
		// (set) Token: 0x0600162D RID: 5677 RVA: 0x0000B040 File Offset: 0x00009240
		public unsafe int Size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_Size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_Size)) = value;
			}
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x0600162E RID: 5678 RVA: 0x000644E8 File Offset: 0x000626E8
		// (set) Token: 0x0600162F RID: 5679 RVA: 0x0000B05B File Offset: 0x0000925B
		public unsafe SocketFlags SockFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_SockFlags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_SockFlags)) = value;
			}
		}

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x06001630 RID: 5680 RVA: 0x00064510 File Offset: 0x00062710
		// (set) Token: 0x06001631 RID: 5681 RVA: 0x0000B076 File Offset: 0x00009276
		public unsafe Socket AcceptSocket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_AcceptSocket);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Socket>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_AcceptSocket), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x06001632 RID: 5682 RVA: 0x00064540 File Offset: 0x00062740
		// (set) Token: 0x06001633 RID: 5683 RVA: 0x0000B095 File Offset: 0x00009295
		public unsafe Il2CppReferenceArray<IPAddress> Addresses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_Addresses);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IPAddress>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_Addresses), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x06001634 RID: 5684 RVA: 0x00064570 File Offset: 0x00062770
		// (set) Token: 0x06001635 RID: 5685 RVA: 0x0000B0B4 File Offset: 0x000092B4
		public unsafe int Port
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_Port);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_Port)) = value;
			}
		}

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x06001636 RID: 5686 RVA: 0x00064598 File Offset: 0x00062798
		// (set) Token: 0x06001637 RID: 5687 RVA: 0x0000B0CF File Offset: 0x000092CF
		public unsafe IList<ArraySegment<byte>> Buffers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_Buffers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<ArraySegment<byte>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_Buffers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x06001638 RID: 5688 RVA: 0x000645C8 File Offset: 0x000627C8
		// (set) Token: 0x06001639 RID: 5689 RVA: 0x0000B0EE File Offset: 0x000092EE
		public unsafe bool ReuseSocket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_ReuseSocket);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_ReuseSocket)) = value;
			}
		}

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x0600163A RID: 5690 RVA: 0x000645F0 File Offset: 0x000627F0
		// (set) Token: 0x0600163B RID: 5691 RVA: 0x0000B109 File Offset: 0x00009309
		public unsafe int CurrentAddress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_CurrentAddress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_CurrentAddress)) = value;
			}
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x0600163C RID: 5692 RVA: 0x00064618 File Offset: 0x00062818
		// (set) Token: 0x0600163D RID: 5693 RVA: 0x0000B124 File Offset: 0x00009324
		public unsafe Socket AcceptedSocket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_AcceptedSocket);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Socket>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_AcceptedSocket), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x0600163E RID: 5694 RVA: 0x00064648 File Offset: 0x00062848
		// (set) Token: 0x0600163F RID: 5695 RVA: 0x0000B143 File Offset: 0x00009343
		public unsafe int Total
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_Total);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_Total)) = value;
			}
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x06001640 RID: 5696 RVA: 0x00064670 File Offset: 0x00062870
		// (set) Token: 0x06001641 RID: 5697 RVA: 0x0000B15E File Offset: 0x0000935E
		public unsafe int error
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_error);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_error)) = value;
			}
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x06001642 RID: 5698 RVA: 0x00064698 File Offset: 0x00062898
		// (set) Token: 0x06001643 RID: 5699 RVA: 0x0000B179 File Offset: 0x00009379
		public unsafe int EndCalled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_EndCalled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_EndCalled)) = value;
			}
		}

		// Token: 0x040011A9 RID: 4521
		private static readonly IntPtr NativeFieldInfoPtr_socket;

		// Token: 0x040011AA RID: 4522
		private static readonly IntPtr NativeFieldInfoPtr_operation;

		// Token: 0x040011AB RID: 4523
		private static readonly IntPtr NativeFieldInfoPtr_DelayedException;

		// Token: 0x040011AC RID: 4524
		private static readonly IntPtr NativeFieldInfoPtr_EndPoint;

		// Token: 0x040011AD RID: 4525
		private static readonly IntPtr NativeFieldInfoPtr_Buffer;

		// Token: 0x040011AE RID: 4526
		private static readonly IntPtr NativeFieldInfoPtr_Offset;

		// Token: 0x040011AF RID: 4527
		private static readonly IntPtr NativeFieldInfoPtr_Size;

		// Token: 0x040011B0 RID: 4528
		private static readonly IntPtr NativeFieldInfoPtr_SockFlags;

		// Token: 0x040011B1 RID: 4529
		private static readonly IntPtr NativeFieldInfoPtr_AcceptSocket;

		// Token: 0x040011B2 RID: 4530
		private static readonly IntPtr NativeFieldInfoPtr_Addresses;

		// Token: 0x040011B3 RID: 4531
		private static readonly IntPtr NativeFieldInfoPtr_Port;

		// Token: 0x040011B4 RID: 4532
		private static readonly IntPtr NativeFieldInfoPtr_Buffers;

		// Token: 0x040011B5 RID: 4533
		private static readonly IntPtr NativeFieldInfoPtr_ReuseSocket;

		// Token: 0x040011B6 RID: 4534
		private static readonly IntPtr NativeFieldInfoPtr_CurrentAddress;

		// Token: 0x040011B7 RID: 4535
		private static readonly IntPtr NativeFieldInfoPtr_AcceptedSocket;

		// Token: 0x040011B8 RID: 4536
		private static readonly IntPtr NativeFieldInfoPtr_Total;

		// Token: 0x040011B9 RID: 4537
		private static readonly IntPtr NativeFieldInfoPtr_error;

		// Token: 0x040011BA RID: 4538
		private static readonly IntPtr NativeFieldInfoPtr_EndCalled;

		// Token: 0x040011BB RID: 4539
		private static readonly IntPtr NativeMethodInfoPtr_get_Handle_Public_get_IntPtr_0;

		// Token: 0x040011BC RID: 4540
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040011BD RID: 4541
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_Socket_AsyncCallback_Object_SocketOperation_0;

		// Token: 0x040011BE RID: 4542
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Socket_AsyncCallback_Object_SocketOperation_0;

		// Token: 0x040011BF RID: 4543
		private static readonly IntPtr NativeMethodInfoPtr_get_ErrorCode_Public_get_SocketError_0;

		// Token: 0x040011C0 RID: 4544
		private static readonly IntPtr NativeMethodInfoPtr_CheckIfThrowDelayedException_Public_Void_0;

		// Token: 0x040011C1 RID: 4545
		private static readonly IntPtr NativeMethodInfoPtr_CompleteDisposed_Internal_Virtual_Void_0;

		// Token: 0x040011C2 RID: 4546
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Public_Void_0;

		// Token: 0x040011C3 RID: 4547
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Public_Void_Boolean_0;

		// Token: 0x040011C4 RID: 4548
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Public_Void_Int32_0;

		// Token: 0x040011C5 RID: 4549
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Public_Void_Exception_Boolean_0;

		// Token: 0x040011C6 RID: 4550
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Public_Void_Exception_0;

		// Token: 0x040011C7 RID: 4551
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Public_Void_Socket_0;

		// Token: 0x040011C8 RID: 4552
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Public_Void_Socket_Int32_0;

		// Token: 0x02000213 RID: 531
		[ObfuscatedName("System.Net.Sockets.SocketAsyncResult+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001D7A RID: 7546 RVA: 0x00077D58 File Offset: 0x00075F58
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SocketAsyncResult.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SocketAsyncResult.__c>.NativeClassPtr);
				SocketAsyncResult.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult.__c>.NativeClassPtr, "<>9");
				SocketAsyncResult.__c.NativeFieldInfoPtr___9__27_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult.__c>.NativeClassPtr, "<>9__27_0");
				SocketAsyncResult.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncResult.__c>.NativeClassPtr, 100666453);
				SocketAsyncResult.__c.NativeMethodInfoPtr__Complete_b__27_0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncResult.__c>.NativeClassPtr, 100666454);
			}

			// Token: 0x06001D7B RID: 7547 RVA: 0x00077DD4 File Offset: 0x00075FD4
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SocketAsyncResult.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncResult.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D7C RID: 7548 RVA: 0x00077E10 File Offset: 0x00076010
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388232, XrefRangeEnd = 388241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Complete_b__27_0(Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncResult.__c.NativeMethodInfoPtr__Complete_b__27_0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D7D RID: 7549 RVA: 0x00010231 File Offset: 0x0000E431
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700097E RID: 2430
			// (get) Token: 0x06001D7E RID: 7550 RVA: 0x00077E54 File Offset: 0x00076054
			// (set) Token: 0x06001D7F RID: 7551 RVA: 0x0001023A File Offset: 0x0000E43A
			public unsafe static SocketAsyncResult.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SocketAsyncResult.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SocketAsyncResult.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SocketAsyncResult.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700097F RID: 2431
			// (get) Token: 0x06001D80 RID: 7552 RVA: 0x00077E7C File Offset: 0x0007607C
			// (set) Token: 0x06001D81 RID: 7553 RVA: 0x0001024C File Offset: 0x0000E44C
			public unsafe static WaitCallback __9__27_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SocketAsyncResult.__c.NativeFieldInfoPtr___9__27_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitCallback>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SocketAsyncResult.__c.NativeFieldInfoPtr___9__27_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400165C RID: 5724
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400165D RID: 5725
			private static readonly IntPtr NativeFieldInfoPtr___9__27_0;

			// Token: 0x0400165E RID: 5726
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400165F RID: 5727
			private static readonly IntPtr NativeMethodInfoPtr__Complete_b__27_0_Internal_Void_Object_0;
		}
	}
}
