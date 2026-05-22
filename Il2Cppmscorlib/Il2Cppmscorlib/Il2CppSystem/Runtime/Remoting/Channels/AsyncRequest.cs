using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting.Channels
{
	// Token: 0x020003C8 RID: 968
	public class AsyncRequest : Object
	{
		// Token: 0x06003F39 RID: 16185 RVA: 0x0012996C File Offset: 0x00127B6C
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncRequest()
		{
			Il2CppClassPointerStore<AsyncRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Channels", "AsyncRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncRequest>.NativeClassPtr);
			AsyncRequest.NativeFieldInfoPtr_ReplySink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncRequest>.NativeClassPtr, "ReplySink");
			AsyncRequest.NativeFieldInfoPtr_MsgRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncRequest>.NativeClassPtr, "MsgRequest");
			AsyncRequest.NativeMethodInfoPtr__ctor_Public_Void_IMessage_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncRequest>.NativeClassPtr, 100672649);
		}

		// Token: 0x06003F3A RID: 16186 RVA: 0x001299D8 File Offset: 0x00127BD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 223384, RefRangeEnd = 223386, XrefRangeStart = 223384, XrefRangeEnd = 223384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncRequest(IMessage msgRequest, IMessageSink replySink)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncRequest>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msgRequest);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(replySink);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncRequest.NativeMethodInfoPtr__ctor_Public_Void_IMessage_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F3B RID: 16187 RVA: 0x00017985 File Offset: 0x00015B85
		public AsyncRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FD0 RID: 4048
		// (get) Token: 0x06003F3C RID: 16188 RVA: 0x00129A38 File Offset: 0x00127C38
		// (set) Token: 0x06003F3D RID: 16189 RVA: 0x0001798E File Offset: 0x00015B8E
		public unsafe IMessageSink ReplySink
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncRequest.NativeFieldInfoPtr_ReplySink);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncRequest.NativeFieldInfoPtr_ReplySink), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FD1 RID: 4049
		// (get) Token: 0x06003F3E RID: 16190 RVA: 0x00129A68 File Offset: 0x00127C68
		// (set) Token: 0x06003F3F RID: 16191 RVA: 0x000179AD File Offset: 0x00015BAD
		public unsafe IMessage MsgRequest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncRequest.NativeFieldInfoPtr_MsgRequest);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncRequest.NativeFieldInfoPtr_MsgRequest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003420 RID: 13344
		private static readonly IntPtr NativeFieldInfoPtr_ReplySink;

		// Token: 0x04003421 RID: 13345
		private static readonly IntPtr NativeFieldInfoPtr_MsgRequest;

		// Token: 0x04003422 RID: 13346
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IMessage_IMessageSink_0;
	}
}
