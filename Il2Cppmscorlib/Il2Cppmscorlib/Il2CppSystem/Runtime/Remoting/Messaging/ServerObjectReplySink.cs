using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x0200040A RID: 1034
	public class ServerObjectReplySink : Object
	{
		// Token: 0x06004255 RID: 16981 RVA: 0x001348DC File Offset: 0x00132ADC
		// Note: this type is marked as 'beforefieldinit'.
		static ServerObjectReplySink()
		{
			Il2CppClassPointerStore<ServerObjectReplySink>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "ServerObjectReplySink");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerObjectReplySink>.NativeClassPtr);
			ServerObjectReplySink.NativeFieldInfoPtr__replySink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerObjectReplySink>.NativeClassPtr, "_replySink");
			ServerObjectReplySink.NativeFieldInfoPtr__identity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerObjectReplySink>.NativeClassPtr, "_identity");
			ServerObjectReplySink.NativeMethodInfoPtr__ctor_Public_Void_ServerIdentity_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerObjectReplySink>.NativeClassPtr, 100673011);
			ServerObjectReplySink.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerObjectReplySink>.NativeClassPtr, 100673012);
			ServerObjectReplySink.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerObjectReplySink>.NativeClassPtr, 100673013);
		}

		// Token: 0x06004256 RID: 16982 RVA: 0x00134970 File Offset: 0x00132B70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 223384, RefRangeEnd = 223386, XrefRangeStart = 223384, XrefRangeEnd = 223386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServerObjectReplySink(ServerIdentity identity, IMessageSink replySink)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerObjectReplySink>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(identity);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(replySink);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerObjectReplySink.NativeMethodInfoPtr__ctor_Public_Void_ServerIdentity_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004257 RID: 16983 RVA: 0x001349D0 File Offset: 0x00132BD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225653, XrefRangeEnd = 225658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IMessage SyncProcessMessage(IMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerObjectReplySink.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06004258 RID: 16984 RVA: 0x00134A20 File Offset: 0x00132C20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225658, XrefRangeEnd = 225663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerObjectReplySink.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageCtrl>(intPtr3) : null;
		}

		// Token: 0x06004259 RID: 16985 RVA: 0x0001903B File Offset: 0x0001723B
		public ServerObjectReplySink(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001105 RID: 4357
		// (get) Token: 0x0600425A RID: 16986 RVA: 0x00134A84 File Offset: 0x00132C84
		// (set) Token: 0x0600425B RID: 16987 RVA: 0x00019044 File Offset: 0x00017244
		public unsafe IMessageSink _replySink
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerObjectReplySink.NativeFieldInfoPtr__replySink);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerObjectReplySink.NativeFieldInfoPtr__replySink), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001106 RID: 4358
		// (get) Token: 0x0600425C RID: 16988 RVA: 0x00134AB4 File Offset: 0x00132CB4
		// (set) Token: 0x0600425D RID: 16989 RVA: 0x00019063 File Offset: 0x00017263
		public unsafe ServerIdentity _identity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerObjectReplySink.NativeFieldInfoPtr__identity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServerIdentity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerObjectReplySink.NativeFieldInfoPtr__identity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003620 RID: 13856
		private static readonly IntPtr NativeFieldInfoPtr__replySink;

		// Token: 0x04003621 RID: 13857
		private static readonly IntPtr NativeFieldInfoPtr__identity;

		// Token: 0x04003622 RID: 13858
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ServerIdentity_IMessageSink_0;

		// Token: 0x04003623 RID: 13859
		private static readonly IntPtr NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0;

		// Token: 0x04003624 RID: 13860
		private static readonly IntPtr NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0;
	}
}
