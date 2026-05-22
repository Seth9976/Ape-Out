using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Contexts;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020003ED RID: 1005
	public class ClientContextReplySink : Object
	{
		// Token: 0x060040AD RID: 16557 RVA: 0x0012E564 File Offset: 0x0012C764
		// Note: this type is marked as 'beforefieldinit'.
		static ClientContextReplySink()
		{
			Il2CppClassPointerStore<ClientContextReplySink>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "ClientContextReplySink");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientContextReplySink>.NativeClassPtr);
			ClientContextReplySink.NativeFieldInfoPtr__replySink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientContextReplySink>.NativeClassPtr, "_replySink");
			ClientContextReplySink.NativeFieldInfoPtr__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientContextReplySink>.NativeClassPtr, "_context");
			ClientContextReplySink.NativeMethodInfoPtr__ctor_Public_Void_Context_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientContextReplySink>.NativeClassPtr, 100672797);
			ClientContextReplySink.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientContextReplySink>.NativeClassPtr, 100672798);
			ClientContextReplySink.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientContextReplySink>.NativeClassPtr, 100672799);
		}

		// Token: 0x060040AE RID: 16558 RVA: 0x0012E5F8 File Offset: 0x0012C7F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 223384, RefRangeEnd = 223386, XrefRangeStart = 223384, XrefRangeEnd = 223386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClientContextReplySink(Context ctx, IMessageSink replySink)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientContextReplySink>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctx);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(replySink);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientContextReplySink.NativeMethodInfoPtr__ctor_Public_Void_Context_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040AF RID: 16559 RVA: 0x0012E658 File Offset: 0x0012C858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224451, XrefRangeEnd = 224460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IMessage SyncProcessMessage(IMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientContextReplySink.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
			}
		}

		// Token: 0x060040B0 RID: 16560 RVA: 0x0012E6A8 File Offset: 0x0012C8A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224460, XrefRangeEnd = 224465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(replySink);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientContextReplySink.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageCtrl>(intPtr3) : null;
		}

		// Token: 0x060040B1 RID: 16561 RVA: 0x00018532 File Offset: 0x00016732
		public ClientContextReplySink(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001051 RID: 4177
		// (get) Token: 0x060040B2 RID: 16562 RVA: 0x0012E70C File Offset: 0x0012C90C
		// (set) Token: 0x060040B3 RID: 16563 RVA: 0x0001853B File Offset: 0x0001673B
		public unsafe IMessageSink _replySink
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientContextReplySink.NativeFieldInfoPtr__replySink);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientContextReplySink.NativeFieldInfoPtr__replySink), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001052 RID: 4178
		// (get) Token: 0x060040B4 RID: 16564 RVA: 0x0012E73C File Offset: 0x0012C93C
		// (set) Token: 0x060040B5 RID: 16565 RVA: 0x0001855A File Offset: 0x0001675A
		public unsafe Context _context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientContextReplySink.NativeFieldInfoPtr__context);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientContextReplySink.NativeFieldInfoPtr__context), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003500 RID: 13568
		private static readonly IntPtr NativeFieldInfoPtr__replySink;

		// Token: 0x04003501 RID: 13569
		private static readonly IntPtr NativeFieldInfoPtr__context;

		// Token: 0x04003502 RID: 13570
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Context_IMessageSink_0;

		// Token: 0x04003503 RID: 13571
		private static readonly IntPtr NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0;

		// Token: 0x04003504 RID: 13572
		private static readonly IntPtr NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0;
	}
}
