using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting.Channels
{
	// Token: 0x020003C6 RID: 966
	public class CrossAppDomainSink : Object
	{
		// Token: 0x06003F22 RID: 16162 RVA: 0x00129384 File Offset: 0x00127584
		// Note: this type is marked as 'beforefieldinit'.
		static CrossAppDomainSink()
		{
			Il2CppClassPointerStore<CrossAppDomainSink>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Channels", "CrossAppDomainSink");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CrossAppDomainSink>.NativeClassPtr);
			CrossAppDomainSink.NativeFieldInfoPtr_s_sinks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrossAppDomainSink>.NativeClassPtr, "s_sinks");
			CrossAppDomainSink.NativeFieldInfoPtr_processMessageMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrossAppDomainSink>.NativeClassPtr, "processMessageMethod");
			CrossAppDomainSink.NativeFieldInfoPtr__domainID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrossAppDomainSink>.NativeClassPtr, "_domainID");
			CrossAppDomainSink.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossAppDomainSink>.NativeClassPtr, 100672635);
			CrossAppDomainSink.NativeMethodInfoPtr_GetSink_Internal_Static_CrossAppDomainSink_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossAppDomainSink>.NativeClassPtr, 100672636);
			CrossAppDomainSink.NativeMethodInfoPtr_get_TargetDomainId_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossAppDomainSink>.NativeClassPtr, 100672637);
			CrossAppDomainSink.NativeMethodInfoPtr_ProcessMessageInDomain_Private_Static_ProcessMessageRes_Il2CppStructArray_1_Byte_CADMethodCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossAppDomainSink>.NativeClassPtr, 100672638);
			CrossAppDomainSink.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_New_IMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossAppDomainSink>.NativeClassPtr, 100672639);
			CrossAppDomainSink.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_New_IMessageCtrl_IMessage_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossAppDomainSink>.NativeClassPtr, 100672640);
			CrossAppDomainSink.NativeMethodInfoPtr_SendAsyncMessage_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossAppDomainSink>.NativeClassPtr, 100672641);
			CrossAppDomainSink.NativeMethodInfoPtr__AsyncProcessMessage_b__10_0_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossAppDomainSink>.NativeClassPtr, 100672643);
		}

		// Token: 0x06003F23 RID: 16163 RVA: 0x00129490 File Offset: 0x00127690
		[CallerCount(0)]
		public unsafe CrossAppDomainSink(int domainID)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CrossAppDomainSink>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref domainID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrossAppDomainSink.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003F24 RID: 16164 RVA: 0x001294D8 File Offset: 0x001276D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223197, RefRangeEnd = 223198, XrefRangeStart = 223169, XrefRangeEnd = 223197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CrossAppDomainSink GetSink(int domainID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref domainID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrossAppDomainSink.NativeMethodInfoPtr_GetSink_Internal_Static_CrossAppDomainSink_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CrossAppDomainSink>(intPtr3) : null;
			}
		}

		// Token: 0x17000FCF RID: 4047
		// (get) Token: 0x06003F25 RID: 16165 RVA: 0x00129518 File Offset: 0x00127718
		public unsafe int TargetDomainId
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrossAppDomainSink.NativeMethodInfoPtr_get_TargetDomainId_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003F26 RID: 16166 RVA: 0x00129554 File Offset: 0x00127754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223198, XrefRangeEnd = 223243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CrossAppDomainSink.ProcessMessageRes ProcessMessageInDomain(Il2CppStructArray<byte> arrRequest, CADMethodCallMessage cadMsg)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arrRequest);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cadMsg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrossAppDomainSink.NativeMethodInfoPtr_ProcessMessageInDomain_Private_Static_ProcessMessageRes_Il2CppStructArray_1_Byte_CADMethodCallMessage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new CrossAppDomainSink.ProcessMessageRes(intPtr);
		}

		// Token: 0x06003F27 RID: 16167 RVA: 0x001295A4 File Offset: 0x001277A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223243, XrefRangeEnd = 223276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IMessage SyncProcessMessage(IMessage msgRequest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msgRequest);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CrossAppDomainSink.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_New_IMessage_IMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06003F28 RID: 16168 RVA: 0x00129600 File Offset: 0x00127800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223276, XrefRangeEnd = 223285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IMessageCtrl AsyncProcessMessage(IMessage reqMsg, IMessageSink replySink)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reqMsg);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(replySink);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CrossAppDomainSink.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_New_IMessageCtrl_IMessage_IMessageSink_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageCtrl>(intPtr3) : null;
		}

		// Token: 0x06003F29 RID: 16169 RVA: 0x00129670 File Offset: 0x00127870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223285, XrefRangeEnd = 223307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendAsyncMessage(Object data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrossAppDomainSink.NativeMethodInfoPtr_SendAsyncMessage_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003F2A RID: 16170 RVA: 0x001296B4 File Offset: 0x001278B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223307, XrefRangeEnd = 223313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _AsyncProcessMessage_b__10_0(Object data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrossAppDomainSink.NativeMethodInfoPtr__AsyncProcessMessage_b__10_0_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003F2B RID: 16171 RVA: 0x00017934 File Offset: 0x00015B34
		public CrossAppDomainSink(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FCC RID: 4044
		// (get) Token: 0x06003F2C RID: 16172 RVA: 0x001296F8 File Offset: 0x001278F8
		// (set) Token: 0x06003F2D RID: 16173 RVA: 0x0001793D File Offset: 0x00015B3D
		public unsafe static Hashtable s_sinks
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CrossAppDomainSink.NativeFieldInfoPtr_s_sinks, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CrossAppDomainSink.NativeFieldInfoPtr_s_sinks, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FCD RID: 4045
		// (get) Token: 0x06003F2E RID: 16174 RVA: 0x00129720 File Offset: 0x00127920
		// (set) Token: 0x06003F2F RID: 16175 RVA: 0x0001794F File Offset: 0x00015B4F
		public unsafe static MethodInfo processMessageMethod
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CrossAppDomainSink.NativeFieldInfoPtr_processMessageMethod, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CrossAppDomainSink.NativeFieldInfoPtr_processMessageMethod, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FCE RID: 4046
		// (get) Token: 0x06003F30 RID: 16176 RVA: 0x00129748 File Offset: 0x00127948
		// (set) Token: 0x06003F31 RID: 16177 RVA: 0x00017961 File Offset: 0x00015B61
		public unsafe int _domainID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrossAppDomainSink.NativeFieldInfoPtr__domainID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrossAppDomainSink.NativeFieldInfoPtr__domainID)) = value;
			}
		}

		// Token: 0x04003410 RID: 13328
		private static readonly IntPtr NativeFieldInfoPtr_s_sinks;

		// Token: 0x04003411 RID: 13329
		private static readonly IntPtr NativeFieldInfoPtr_processMessageMethod;

		// Token: 0x04003412 RID: 13330
		private static readonly IntPtr NativeFieldInfoPtr__domainID;

		// Token: 0x04003413 RID: 13331
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

		// Token: 0x04003414 RID: 13332
		private static readonly IntPtr NativeMethodInfoPtr_GetSink_Internal_Static_CrossAppDomainSink_Int32_0;

		// Token: 0x04003415 RID: 13333
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetDomainId_Internal_get_Int32_0;

		// Token: 0x04003416 RID: 13334
		private static readonly IntPtr NativeMethodInfoPtr_ProcessMessageInDomain_Private_Static_ProcessMessageRes_Il2CppStructArray_1_Byte_CADMethodCallMessage_0;

		// Token: 0x04003417 RID: 13335
		private static readonly IntPtr NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_New_IMessage_IMessage_0;

		// Token: 0x04003418 RID: 13336
		private static readonly IntPtr NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_New_IMessageCtrl_IMessage_IMessageSink_0;

		// Token: 0x04003419 RID: 13337
		private static readonly IntPtr NativeMethodInfoPtr_SendAsyncMessage_Public_Void_Object_0;

		// Token: 0x0400341A RID: 13338
		private static readonly IntPtr NativeMethodInfoPtr__AsyncProcessMessage_b__10_0_Private_Void_Object_0;

		// Token: 0x02000632 RID: 1586
		public sealed class ProcessMessageRes : ValueType
		{
			// Token: 0x06005614 RID: 22036 RVA: 0x0018061C File Offset: 0x0017E81C
			// Note: this type is marked as 'beforefieldinit'.
			static ProcessMessageRes()
			{
				Il2CppClassPointerStore<CrossAppDomainSink.ProcessMessageRes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CrossAppDomainSink>.NativeClassPtr, "ProcessMessageRes");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CrossAppDomainSink.ProcessMessageRes>.NativeClassPtr);
				CrossAppDomainSink.ProcessMessageRes.NativeFieldInfoPtr_arrResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrossAppDomainSink.ProcessMessageRes>.NativeClassPtr, "arrResponse");
				CrossAppDomainSink.ProcessMessageRes.NativeFieldInfoPtr_cadMrm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrossAppDomainSink.ProcessMessageRes>.NativeClassPtr, "cadMrm");
			}

			// Token: 0x06005615 RID: 22037 RVA: 0x00020CDE File Offset: 0x0001EEDE
			public ProcessMessageRes(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005616 RID: 22038 RVA: 0x00020CE7 File Offset: 0x0001EEE7
			public ProcessMessageRes()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CrossAppDomainSink.ProcessMessageRes>.NativeClassPtr))
			{
			}

			// Token: 0x17001623 RID: 5667
			// (get) Token: 0x06005617 RID: 22039 RVA: 0x00180670 File Offset: 0x0017E870
			// (set) Token: 0x06005618 RID: 22040 RVA: 0x00020CF9 File Offset: 0x0001EEF9
			public unsafe Il2CppStructArray<byte> arrResponse
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrossAppDomainSink.ProcessMessageRes.NativeFieldInfoPtr_arrResponse);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrossAppDomainSink.ProcessMessageRes.NativeFieldInfoPtr_arrResponse), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001624 RID: 5668
			// (get) Token: 0x06005619 RID: 22041 RVA: 0x001806A0 File Offset: 0x0017E8A0
			// (set) Token: 0x0600561A RID: 22042 RVA: 0x00020D18 File Offset: 0x0001EF18
			public unsafe CADMethodReturnMessage cadMrm
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrossAppDomainSink.ProcessMessageRes.NativeFieldInfoPtr_cadMrm);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CADMethodReturnMessage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrossAppDomainSink.ProcessMessageRes.NativeFieldInfoPtr_cadMrm), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004551 RID: 17745
			private static readonly IntPtr NativeFieldInfoPtr_arrResponse;

			// Token: 0x04004552 RID: 17746
			private static readonly IntPtr NativeFieldInfoPtr_cadMrm;
		}
	}
}
