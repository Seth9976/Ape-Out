using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Proxies;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x0200040B RID: 1035
	public class StackBuilderSink : Object
	{
		// Token: 0x0600425E RID: 16990 RVA: 0x00134AE4 File Offset: 0x00132CE4
		// Note: this type is marked as 'beforefieldinit'.
		static StackBuilderSink()
		{
			Il2CppClassPointerStore<StackBuilderSink>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "StackBuilderSink");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StackBuilderSink>.NativeClassPtr);
			StackBuilderSink.NativeFieldInfoPtr__target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackBuilderSink>.NativeClassPtr, "_target");
			StackBuilderSink.NativeFieldInfoPtr__rp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackBuilderSink>.NativeClassPtr, "_rp");
			StackBuilderSink.NativeMethodInfoPtr__ctor_Public_Void_MarshalByRefObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackBuilderSink>.NativeClassPtr, 100673014);
			StackBuilderSink.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackBuilderSink>.NativeClassPtr, 100673015);
			StackBuilderSink.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackBuilderSink>.NativeClassPtr, 100673016);
			StackBuilderSink.NativeMethodInfoPtr_ExecuteAsyncMessage_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackBuilderSink>.NativeClassPtr, 100673017);
			StackBuilderSink.NativeMethodInfoPtr_CheckParameters_Private_Void_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackBuilderSink>.NativeClassPtr, 100673018);
			StackBuilderSink.NativeMethodInfoPtr__AsyncProcessMessage_b__4_0_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackBuilderSink>.NativeClassPtr, 100673019);
		}

		// Token: 0x0600425F RID: 16991 RVA: 0x00134BB4 File Offset: 0x00132DB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225663, XrefRangeEnd = 225664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StackBuilderSink(MarshalByRefObject obj, bool forceInternalExecute)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StackBuilderSink>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceInternalExecute;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackBuilderSink.NativeMethodInfoPtr__ctor_Public_Void_MarshalByRefObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004260 RID: 16992 RVA: 0x00134C10 File Offset: 0x00132E10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225664, XrefRangeEnd = 225674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IMessage SyncProcessMessage(IMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackBuilderSink.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06004261 RID: 16993 RVA: 0x00134C60 File Offset: 0x00132E60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225674, XrefRangeEnd = 225687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackBuilderSink.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageCtrl>(intPtr3) : null;
		}

		// Token: 0x06004262 RID: 16994 RVA: 0x00134CC4 File Offset: 0x00132EC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 225777, RefRangeEnd = 225778, XrefRangeStart = 225687, XrefRangeEnd = 225777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecuteAsyncMessage(Object ob)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ob);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackBuilderSink.NativeMethodInfoPtr_ExecuteAsyncMessage_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004263 RID: 16995 RVA: 0x00134D08 File Offset: 0x00132F08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 225786, RefRangeEnd = 225787, XrefRangeStart = 225778, XrefRangeEnd = 225786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckParameters(IMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackBuilderSink.NativeMethodInfoPtr_CheckParameters_Private_Void_IMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004264 RID: 16996 RVA: 0x00134D4C File Offset: 0x00132F4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225787, XrefRangeEnd = 225789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _AsyncProcessMessage_b__4_0(Object data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackBuilderSink.NativeMethodInfoPtr__AsyncProcessMessage_b__4_0_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004265 RID: 16997 RVA: 0x00019082 File Offset: 0x00017282
		public StackBuilderSink(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001107 RID: 4359
		// (get) Token: 0x06004266 RID: 16998 RVA: 0x00134D90 File Offset: 0x00132F90
		// (set) Token: 0x06004267 RID: 16999 RVA: 0x0001908B File Offset: 0x0001728B
		public unsafe MarshalByRefObject _target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackBuilderSink.NativeFieldInfoPtr__target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MarshalByRefObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackBuilderSink.NativeFieldInfoPtr__target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001108 RID: 4360
		// (get) Token: 0x06004268 RID: 17000 RVA: 0x00134DC0 File Offset: 0x00132FC0
		// (set) Token: 0x06004269 RID: 17001 RVA: 0x000190AA File Offset: 0x000172AA
		public unsafe RealProxy _rp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackBuilderSink.NativeFieldInfoPtr__rp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RealProxy>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackBuilderSink.NativeFieldInfoPtr__rp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003625 RID: 13861
		private static readonly IntPtr NativeFieldInfoPtr__target;

		// Token: 0x04003626 RID: 13862
		private static readonly IntPtr NativeFieldInfoPtr__rp;

		// Token: 0x04003627 RID: 13863
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MarshalByRefObject_Boolean_0;

		// Token: 0x04003628 RID: 13864
		private static readonly IntPtr NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0;

		// Token: 0x04003629 RID: 13865
		private static readonly IntPtr NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0;

		// Token: 0x0400362A RID: 13866
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteAsyncMessage_Private_Void_Object_0;

		// Token: 0x0400362B RID: 13867
		private static readonly IntPtr NativeMethodInfoPtr_CheckParameters_Private_Void_IMessage_0;

		// Token: 0x0400362C RID: 13868
		private static readonly IntPtr NativeMethodInfoPtr__AsyncProcessMessage_b__4_0_Private_Void_Object_0;
	}
}
