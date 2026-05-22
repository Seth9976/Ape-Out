using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020003E0 RID: 992
	[Serializable]
	public sealed class LogicalCallContext : Object
	{
		// Token: 0x06003FE7 RID: 16359 RVA: 0x0012BAF0 File Offset: 0x00129CF0
		// Note: this type is marked as 'beforefieldinit'.
		static LogicalCallContext()
		{
			Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "LogicalCallContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr);
			LogicalCallContext.NativeFieldInfoPtr_s_callContextType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr, "s_callContextType");
			LogicalCallContext.NativeFieldInfoPtr_s_CorrelationMgrSlotName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr, "s_CorrelationMgrSlotName");
			LogicalCallContext.NativeFieldInfoPtr_m_Datastore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr, "m_Datastore");
			LogicalCallContext.NativeFieldInfoPtr_m_RemotingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr, "m_RemotingData");
			LogicalCallContext.NativeFieldInfoPtr_m_SecurityData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr, "m_SecurityData");
			LogicalCallContext.NativeFieldInfoPtr_m_HostContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr, "m_HostContext");
			LogicalCallContext.NativeFieldInfoPtr_m_IsCorrelationMgr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr, "m_IsCorrelationMgr");
			LogicalCallContext.NativeFieldInfoPtr__sendHeaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr, "_sendHeaders");
			LogicalCallContext.NativeFieldInfoPtr__recvHeaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr, "_recvHeaders");
			LogicalCallContext.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr, 100672717);
			LogicalCallContext.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr, 100672718);
			LogicalCallContext.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr, 100672719);
			LogicalCallContext.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr, 100672720);
			LogicalCallContext.NativeMethodInfoPtr_Merge_Internal_Void_LogicalCallContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr, 100672721);
			LogicalCallContext.NativeMethodInfoPtr_get_HasInfo_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr, 100672722);
			LogicalCallContext.NativeMethodInfoPtr_get_HasUserData_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr, 100672723);
			LogicalCallContext.NativeMethodInfoPtr_get_Datastore_Private_get_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr, 100672724);
		}

		// Token: 0x06003FE8 RID: 16360 RVA: 0x0012BC74 File Offset: 0x00129E74
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LogicalCallContext()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogicalCallContext.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003FE9 RID: 16361 RVA: 0x0012BCB0 File Offset: 0x00129EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223735, XrefRangeEnd = 223776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LogicalCallContext(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogicalCallContext.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003FEA RID: 16362 RVA: 0x0012BD14 File Offset: 0x00129F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223776, XrefRangeEnd = 223823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogicalCallContext.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003FEB RID: 16363 RVA: 0x0012BD70 File Offset: 0x00129F70
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 223876, RefRangeEnd = 223880, XrefRangeStart = 223823, XrefRangeEnd = 223876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogicalCallContext.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003FEC RID: 16364 RVA: 0x0012BDB0 File Offset: 0x00129FB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223896, RefRangeEnd = 223897, XrefRangeStart = 223880, XrefRangeEnd = 223896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Merge(LogicalCallContext lc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogicalCallContext.NativeMethodInfoPtr_Merge_Internal_Void_LogicalCallContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001017 RID: 4119
		// (get) Token: 0x06003FED RID: 16365 RVA: 0x0012BDF4 File Offset: 0x00129FF4
		public unsafe bool HasInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogicalCallContext.NativeMethodInfoPtr_get_HasInfo_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001018 RID: 4120
		// (get) Token: 0x06003FEE RID: 16366 RVA: 0x0012BE30 File Offset: 0x0012A030
		public unsafe bool HasUserData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogicalCallContext.NativeMethodInfoPtr_get_HasUserData_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001019 RID: 4121
		// (get) Token: 0x06003FEF RID: 16367 RVA: 0x0012BE6C File Offset: 0x0012A06C
		public unsafe Hashtable Datastore
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 223901, RefRangeEnd = 223909, XrefRangeStart = 223897, XrefRangeEnd = 223901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogicalCallContext.NativeMethodInfoPtr_get_Datastore_Private_get_Hashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr3) : null;
			}
		}

		// Token: 0x06003FF0 RID: 16368 RVA: 0x00017F0B File Offset: 0x0001610B
		public LogicalCallContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700100E RID: 4110
		// (get) Token: 0x06003FF1 RID: 16369 RVA: 0x0012BEAC File Offset: 0x0012A0AC
		// (set) Token: 0x06003FF2 RID: 16370 RVA: 0x00017F14 File Offset: 0x00016114
		public unsafe static Type s_callContextType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LogicalCallContext.NativeFieldInfoPtr_s_callContextType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LogicalCallContext.NativeFieldInfoPtr_s_callContextType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700100F RID: 4111
		// (get) Token: 0x06003FF3 RID: 16371 RVA: 0x0012BED4 File Offset: 0x0012A0D4
		// (set) Token: 0x06003FF4 RID: 16372 RVA: 0x00017F26 File Offset: 0x00016126
		public unsafe static string s_CorrelationMgrSlotName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LogicalCallContext.NativeFieldInfoPtr_s_CorrelationMgrSlotName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LogicalCallContext.NativeFieldInfoPtr_s_CorrelationMgrSlotName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001010 RID: 4112
		// (get) Token: 0x06003FF5 RID: 16373 RVA: 0x0012BEF4 File Offset: 0x0012A0F4
		// (set) Token: 0x06003FF6 RID: 16374 RVA: 0x00017F38 File Offset: 0x00016138
		public unsafe Hashtable m_Datastore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogicalCallContext.NativeFieldInfoPtr_m_Datastore);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogicalCallContext.NativeFieldInfoPtr_m_Datastore), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001011 RID: 4113
		// (get) Token: 0x06003FF7 RID: 16375 RVA: 0x0012BF24 File Offset: 0x0012A124
		// (set) Token: 0x06003FF8 RID: 16376 RVA: 0x00017F57 File Offset: 0x00016157
		public unsafe CallContextRemotingData m_RemotingData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogicalCallContext.NativeFieldInfoPtr_m_RemotingData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallContextRemotingData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogicalCallContext.NativeFieldInfoPtr_m_RemotingData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001012 RID: 4114
		// (get) Token: 0x06003FF9 RID: 16377 RVA: 0x0012BF54 File Offset: 0x0012A154
		// (set) Token: 0x06003FFA RID: 16378 RVA: 0x00017F76 File Offset: 0x00016176
		public unsafe CallContextSecurityData m_SecurityData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogicalCallContext.NativeFieldInfoPtr_m_SecurityData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallContextSecurityData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogicalCallContext.NativeFieldInfoPtr_m_SecurityData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001013 RID: 4115
		// (get) Token: 0x06003FFB RID: 16379 RVA: 0x0012BF84 File Offset: 0x0012A184
		// (set) Token: 0x06003FFC RID: 16380 RVA: 0x00017F95 File Offset: 0x00016195
		public unsafe Object m_HostContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogicalCallContext.NativeFieldInfoPtr_m_HostContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogicalCallContext.NativeFieldInfoPtr_m_HostContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001014 RID: 4116
		// (get) Token: 0x06003FFD RID: 16381 RVA: 0x0012BFB4 File Offset: 0x0012A1B4
		// (set) Token: 0x06003FFE RID: 16382 RVA: 0x00017FB4 File Offset: 0x000161B4
		public unsafe bool m_IsCorrelationMgr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogicalCallContext.NativeFieldInfoPtr_m_IsCorrelationMgr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogicalCallContext.NativeFieldInfoPtr_m_IsCorrelationMgr)) = value;
			}
		}

		// Token: 0x17001015 RID: 4117
		// (get) Token: 0x06003FFF RID: 16383 RVA: 0x0012BFDC File Offset: 0x0012A1DC
		// (set) Token: 0x06004000 RID: 16384 RVA: 0x00017FCF File Offset: 0x000161CF
		public unsafe Il2CppReferenceArray<Header> _sendHeaders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogicalCallContext.NativeFieldInfoPtr__sendHeaders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Header>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogicalCallContext.NativeFieldInfoPtr__sendHeaders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001016 RID: 4118
		// (get) Token: 0x06004001 RID: 16385 RVA: 0x0012C00C File Offset: 0x0012A20C
		// (set) Token: 0x06004002 RID: 16386 RVA: 0x00017FEE File Offset: 0x000161EE
		public unsafe Il2CppReferenceArray<Header> _recvHeaders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogicalCallContext.NativeFieldInfoPtr__recvHeaders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Header>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogicalCallContext.NativeFieldInfoPtr__recvHeaders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003481 RID: 13441
		private static readonly IntPtr NativeFieldInfoPtr_s_callContextType;

		// Token: 0x04003482 RID: 13442
		private static readonly IntPtr NativeFieldInfoPtr_s_CorrelationMgrSlotName;

		// Token: 0x04003483 RID: 13443
		private static readonly IntPtr NativeFieldInfoPtr_m_Datastore;

		// Token: 0x04003484 RID: 13444
		private static readonly IntPtr NativeFieldInfoPtr_m_RemotingData;

		// Token: 0x04003485 RID: 13445
		private static readonly IntPtr NativeFieldInfoPtr_m_SecurityData;

		// Token: 0x04003486 RID: 13446
		private static readonly IntPtr NativeFieldInfoPtr_m_HostContext;

		// Token: 0x04003487 RID: 13447
		private static readonly IntPtr NativeFieldInfoPtr_m_IsCorrelationMgr;

		// Token: 0x04003488 RID: 13448
		private static readonly IntPtr NativeFieldInfoPtr__sendHeaders;

		// Token: 0x04003489 RID: 13449
		private static readonly IntPtr NativeFieldInfoPtr__recvHeaders;

		// Token: 0x0400348A RID: 13450
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x0400348B RID: 13451
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x0400348C RID: 13452
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x0400348D RID: 13453
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

		// Token: 0x0400348E RID: 13454
		private static readonly IntPtr NativeMethodInfoPtr_Merge_Internal_Void_LogicalCallContext_0;

		// Token: 0x0400348F RID: 13455
		private static readonly IntPtr NativeMethodInfoPtr_get_HasInfo_Public_get_Boolean_0;

		// Token: 0x04003490 RID: 13456
		private static readonly IntPtr NativeMethodInfoPtr_get_HasUserData_Private_get_Boolean_0;

		// Token: 0x04003491 RID: 13457
		private static readonly IntPtr NativeMethodInfoPtr_get_Datastore_Private_get_Hashtable_0;

		// Token: 0x02000633 RID: 1587
		public sealed class Reader : ValueType
		{
			// Token: 0x0600561B RID: 22043 RVA: 0x001806D0 File Offset: 0x0017E8D0
			// Note: this type is marked as 'beforefieldinit'.
			static Reader()
			{
				Il2CppClassPointerStore<LogicalCallContext.Reader>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr, "Reader");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogicalCallContext.Reader>.NativeClassPtr);
				LogicalCallContext.Reader.NativeFieldInfoPtr_m_ctx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogicalCallContext.Reader>.NativeClassPtr, "m_ctx");
				LogicalCallContext.Reader.NativeMethodInfoPtr__ctor_Public_Void_LogicalCallContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogicalCallContext.Reader>.NativeClassPtr, 100672726);
				LogicalCallContext.Reader.NativeMethodInfoPtr_get_IsNull_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogicalCallContext.Reader>.NativeClassPtr, 100672727);
				LogicalCallContext.Reader.NativeMethodInfoPtr_get_HasInfo_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogicalCallContext.Reader>.NativeClassPtr, 100672728);
				LogicalCallContext.Reader.NativeMethodInfoPtr_Clone_Public_LogicalCallContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogicalCallContext.Reader>.NativeClassPtr, 100672729);
			}

			// Token: 0x0600561C RID: 22044 RVA: 0x00180760 File Offset: 0x0017E960
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 99329, RefRangeEnd = 99331, XrefRangeStart = 99329, XrefRangeEnd = 99331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Reader(LogicalCallContext ctx)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogicalCallContext.Reader>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctx);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogicalCallContext.Reader.NativeMethodInfoPtr__ctor_Public_Void_LogicalCallContext_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17001626 RID: 5670
			// (get) Token: 0x0600561D RID: 22045 RVA: 0x001807B0 File Offset: 0x0017E9B0
			public unsafe bool IsNull
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogicalCallContext.Reader.NativeMethodInfoPtr_get_IsNull_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001627 RID: 5671
			// (get) Token: 0x0600561E RID: 22046 RVA: 0x001807F4 File Offset: 0x0017E9F4
			public unsafe bool HasInfo
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogicalCallContext.Reader.NativeMethodInfoPtr_get_HasInfo_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600561F RID: 22047 RVA: 0x00180838 File Offset: 0x0017EA38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223732, XrefRangeEnd = 223735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LogicalCallContext Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogicalCallContext.Reader.NativeMethodInfoPtr_Clone_Public_LogicalCallContext_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LogicalCallContext>(intPtr3) : null;
			}

			// Token: 0x06005620 RID: 22048 RVA: 0x00020D37 File Offset: 0x0001EF37
			public Reader(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005621 RID: 22049 RVA: 0x00020D40 File Offset: 0x0001EF40
			public Reader()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogicalCallContext.Reader>.NativeClassPtr))
			{
			}

			// Token: 0x17001625 RID: 5669
			// (get) Token: 0x06005622 RID: 22050 RVA: 0x0018087C File Offset: 0x0017EA7C
			// (set) Token: 0x06005623 RID: 22051 RVA: 0x00020D52 File Offset: 0x0001EF52
			public unsafe LogicalCallContext m_ctx
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogicalCallContext.Reader.NativeFieldInfoPtr_m_ctx);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LogicalCallContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogicalCallContext.Reader.NativeFieldInfoPtr_m_ctx), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004553 RID: 17747
			private static readonly IntPtr NativeFieldInfoPtr_m_ctx;

			// Token: 0x04004554 RID: 17748
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_LogicalCallContext_0;

			// Token: 0x04004555 RID: 17749
			private static readonly IntPtr NativeMethodInfoPtr_get_IsNull_Public_get_Boolean_0;

			// Token: 0x04004556 RID: 17750
			private static readonly IntPtr NativeMethodInfoPtr_get_HasInfo_Public_get_Boolean_0;

			// Token: 0x04004557 RID: 17751
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_LogicalCallContext_0;
		}
	}
}
