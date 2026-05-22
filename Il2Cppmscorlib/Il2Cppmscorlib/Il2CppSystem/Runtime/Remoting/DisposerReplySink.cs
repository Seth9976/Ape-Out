using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x020003A1 RID: 929
	public class DisposerReplySink : Object
	{
		// Token: 0x06003D7E RID: 15742 RVA: 0x001234D8 File Offset: 0x001216D8
		// Note: this type is marked as 'beforefieldinit'.
		static DisposerReplySink()
		{
			Il2CppClassPointerStore<DisposerReplySink>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "DisposerReplySink");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisposerReplySink>.NativeClassPtr);
			DisposerReplySink.NativeFieldInfoPtr__next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisposerReplySink>.NativeClassPtr, "_next");
			DisposerReplySink.NativeFieldInfoPtr__disposable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisposerReplySink>.NativeClassPtr, "_disposable");
			DisposerReplySink.NativeMethodInfoPtr__ctor_Public_Void_IMessageSink_IDisposable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisposerReplySink>.NativeClassPtr, 100672424);
			DisposerReplySink.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisposerReplySink>.NativeClassPtr, 100672425);
			DisposerReplySink.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisposerReplySink>.NativeClassPtr, 100672426);
		}

		// Token: 0x06003D7F RID: 15743 RVA: 0x0012356C File Offset: 0x0012176C
		[CallerCount(76)]
		[CachedScanResults(RefRangeStart = 19789, RefRangeEnd = 19865, XrefRangeStart = 19789, XrefRangeEnd = 19865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DisposerReplySink(IMessageSink next, IDisposable disposable)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DisposerReplySink>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(next);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(disposable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisposerReplySink.NativeMethodInfoPtr__ctor_Public_Void_IMessageSink_IDisposable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D80 RID: 15744 RVA: 0x001235CC File Offset: 0x001217CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221111, XrefRangeEnd = 221118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IMessage SyncProcessMessage(IMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisposerReplySink.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06003D81 RID: 15745 RVA: 0x0012361C File Offset: 0x0012181C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221118, XrefRangeEnd = 221123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisposerReplySink.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageCtrl>(intPtr3) : null;
		}

		// Token: 0x06003D82 RID: 15746 RVA: 0x00016EDD File Offset: 0x000150DD
		public DisposerReplySink(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F54 RID: 3924
		// (get) Token: 0x06003D83 RID: 15747 RVA: 0x00123680 File Offset: 0x00121880
		// (set) Token: 0x06003D84 RID: 15748 RVA: 0x00016EE6 File Offset: 0x000150E6
		public unsafe IMessageSink _next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisposerReplySink.NativeFieldInfoPtr__next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisposerReplySink.NativeFieldInfoPtr__next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F55 RID: 3925
		// (get) Token: 0x06003D85 RID: 15749 RVA: 0x001236B0 File Offset: 0x001218B0
		// (set) Token: 0x06003D86 RID: 15750 RVA: 0x00016F05 File Offset: 0x00015105
		public unsafe IDisposable _disposable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisposerReplySink.NativeFieldInfoPtr__disposable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDisposable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisposerReplySink.NativeFieldInfoPtr__disposable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040032F8 RID: 13048
		private static readonly IntPtr NativeFieldInfoPtr__next;

		// Token: 0x040032F9 RID: 13049
		private static readonly IntPtr NativeFieldInfoPtr__disposable;

		// Token: 0x040032FA RID: 13050
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IMessageSink_IDisposable_0;

		// Token: 0x040032FB RID: 13051
		private static readonly IntPtr NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0;

		// Token: 0x040032FC RID: 13052
		private static readonly IntPtr NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0;
	}
}
