using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting.Contexts
{
	// Token: 0x020003B8 RID: 952
	public class CrossContextChannel : Object
	{
		// Token: 0x06003EC7 RID: 16071 RVA: 0x0012801C File Offset: 0x0012621C
		// Note: this type is marked as 'beforefieldinit'.
		static CrossContextChannel()
		{
			Il2CppClassPointerStore<CrossContextChannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Contexts", "CrossContextChannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CrossContextChannel>.NativeClassPtr);
			CrossContextChannel.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossContextChannel>.NativeClassPtr, 100672588);
			CrossContextChannel.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossContextChannel>.NativeClassPtr, 100672589);
			CrossContextChannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossContextChannel>.NativeClassPtr, 100672590);
		}

		// Token: 0x06003EC8 RID: 16072 RVA: 0x00128088 File Offset: 0x00126288
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 222610, RefRangeEnd = 222613, XrefRangeStart = 222581, XrefRangeEnd = 222610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IMessage SyncProcessMessage(IMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrossContextChannel.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06003EC9 RID: 16073 RVA: 0x001280D8 File Offset: 0x001262D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222613, XrefRangeEnd = 222646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrossContextChannel.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageCtrl>(intPtr3) : null;
		}

		// Token: 0x06003ECA RID: 16074 RVA: 0x0012813C File Offset: 0x0012633C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CrossContextChannel()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CrossContextChannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrossContextChannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003ECB RID: 16075 RVA: 0x000176B0 File Offset: 0x000158B0
		public CrossContextChannel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040033DD RID: 13277
		private static readonly IntPtr NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0;

		// Token: 0x040033DE RID: 13278
		private static readonly IntPtr NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0;

		// Token: 0x040033DF RID: 13279
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000631 RID: 1585
		public class ContextRestoreSink : Object
		{
			// Token: 0x06005609 RID: 22025 RVA: 0x001803C4 File Offset: 0x0017E5C4
			// Note: this type is marked as 'beforefieldinit'.
			static ContextRestoreSink()
			{
				Il2CppClassPointerStore<CrossContextChannel.ContextRestoreSink>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CrossContextChannel>.NativeClassPtr, "ContextRestoreSink");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CrossContextChannel.ContextRestoreSink>.NativeClassPtr);
				CrossContextChannel.ContextRestoreSink.NativeFieldInfoPtr__next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrossContextChannel.ContextRestoreSink>.NativeClassPtr, "_next");
				CrossContextChannel.ContextRestoreSink.NativeFieldInfoPtr__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrossContextChannel.ContextRestoreSink>.NativeClassPtr, "_context");
				CrossContextChannel.ContextRestoreSink.NativeFieldInfoPtr__call = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrossContextChannel.ContextRestoreSink>.NativeClassPtr, "_call");
				CrossContextChannel.ContextRestoreSink.NativeMethodInfoPtr__ctor_Public_Void_IMessageSink_Context_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossContextChannel.ContextRestoreSink>.NativeClassPtr, 100672591);
				CrossContextChannel.ContextRestoreSink.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossContextChannel.ContextRestoreSink>.NativeClassPtr, 100672592);
				CrossContextChannel.ContextRestoreSink.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossContextChannel.ContextRestoreSink>.NativeClassPtr, 100672593);
			}

			// Token: 0x0600560A RID: 22026 RVA: 0x00180468 File Offset: 0x0017E668
			[CallerCount(0)]
			public unsafe ContextRestoreSink(IMessageSink next, Context context, IMessage call)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CrossContextChannel.ContextRestoreSink>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(next);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(call);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrossContextChannel.ContextRestoreSink.NativeMethodInfoPtr__ctor_Public_Void_IMessageSink_Context_IMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600560B RID: 22027 RVA: 0x001804D8 File Offset: 0x0017E6D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222559, XrefRangeEnd = 222576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IMessage SyncProcessMessage(IMessage msg)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrossContextChannel.ContextRestoreSink.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
				}
			}

			// Token: 0x0600560C RID: 22028 RVA: 0x00180528 File Offset: 0x0017E728
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222576, XrefRangeEnd = 222581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrossContextChannel.ContextRestoreSink.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageCtrl>(intPtr3) : null;
			}

			// Token: 0x0600560D RID: 22029 RVA: 0x00020C78 File Offset: 0x0001EE78
			public ContextRestoreSink(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001620 RID: 5664
			// (get) Token: 0x0600560E RID: 22030 RVA: 0x0018058C File Offset: 0x0017E78C
			// (set) Token: 0x0600560F RID: 22031 RVA: 0x00020C81 File Offset: 0x0001EE81
			public unsafe IMessageSink _next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrossContextChannel.ContextRestoreSink.NativeFieldInfoPtr__next);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrossContextChannel.ContextRestoreSink.NativeFieldInfoPtr__next), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001621 RID: 5665
			// (get) Token: 0x06005610 RID: 22032 RVA: 0x001805BC File Offset: 0x0017E7BC
			// (set) Token: 0x06005611 RID: 22033 RVA: 0x00020CA0 File Offset: 0x0001EEA0
			public unsafe Context _context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrossContextChannel.ContextRestoreSink.NativeFieldInfoPtr__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrossContextChannel.ContextRestoreSink.NativeFieldInfoPtr__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001622 RID: 5666
			// (get) Token: 0x06005612 RID: 22034 RVA: 0x001805EC File Offset: 0x0017E7EC
			// (set) Token: 0x06005613 RID: 22035 RVA: 0x00020CBF File Offset: 0x0001EEBF
			public unsafe IMessage _call
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrossContextChannel.ContextRestoreSink.NativeFieldInfoPtr__call);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrossContextChannel.ContextRestoreSink.NativeFieldInfoPtr__call), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400454B RID: 17739
			private static readonly IntPtr NativeFieldInfoPtr__next;

			// Token: 0x0400454C RID: 17740
			private static readonly IntPtr NativeFieldInfoPtr__context;

			// Token: 0x0400454D RID: 17741
			private static readonly IntPtr NativeFieldInfoPtr__call;

			// Token: 0x0400454E RID: 17742
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IMessageSink_Context_IMessage_0;

			// Token: 0x0400454F RID: 17743
			private static readonly IntPtr NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0;

			// Token: 0x04004550 RID: 17744
			private static readonly IntPtr NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0;
		}
	}
}
