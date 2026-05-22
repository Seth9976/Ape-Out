using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004D1 RID: 1233
	public sealed class InvokeTypeInfo<ContainerType> : TraceLoggingTypeInfo<ContainerType>
	{
		// Token: 0x060049BA RID: 18874 RVA: 0x00154EB8 File Offset: 0x001530B8
		// Note: this type is marked as 'beforefieldinit'.
		static InvokeTypeInfo()
		{
			Il2CppClassPointerStore<InvokeTypeInfo<ContainerType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "InvokeTypeInfo`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ContainerType>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvokeTypeInfo<ContainerType>>.NativeClassPtr);
			InvokeTypeInfo<ContainerType>.NativeFieldInfoPtr_properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvokeTypeInfo<ContainerType>>.NativeClassPtr, "properties");
			InvokeTypeInfo<ContainerType>.NativeFieldInfoPtr_accessors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvokeTypeInfo<ContainerType>>.NativeClassPtr, "accessors");
			InvokeTypeInfo<ContainerType>.NativeMethodInfoPtr__ctor_Public_Void_TypeAnalysis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokeTypeInfo<ContainerType>>.NativeClassPtr, 100674314);
			InvokeTypeInfo<ContainerType>.NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokeTypeInfo<ContainerType>>.NativeClassPtr, 100674315);
			InvokeTypeInfo<ContainerType>.NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_ContainerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokeTypeInfo<ContainerType>>.NativeClassPtr, 100674316);
			InvokeTypeInfo<ContainerType>.NativeMethodInfoPtr_GetData_Public_Virtual_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokeTypeInfo<ContainerType>>.NativeClassPtr, 100674317);
			InvokeTypeInfo<ContainerType>.NativeMethodInfoPtr_WriteObjectData_Public_Virtual_Void_TraceLoggingDataCollector_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokeTypeInfo<ContainerType>>.NativeClassPtr, 100674318);
		}

		// Token: 0x060049BB RID: 18875 RVA: 0x00154FB0 File Offset: 0x001531B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233775, XrefRangeEnd = 233780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvokeTypeInfo(TypeAnalysis typeAnalysis)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvokeTypeInfo<ContainerType>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeAnalysis);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokeTypeInfo<ContainerType>.NativeMethodInfoPtr__ctor_Public_Void_TypeAnalysis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060049BC RID: 18876 RVA: 0x00154FFC File Offset: 0x001531FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233780, XrefRangeEnd = 233783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collector);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokeTypeInfo<ContainerType>.NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049BD RID: 18877 RVA: 0x00155060 File Offset: 0x00153260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233783, XrefRangeEnd = 233784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteData(TraceLoggingDataCollector collector, ref ContainerType value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collector);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(InvokeTypeInfo<ContainerType>.NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_ContainerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			value = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<ContainerType>(intPtr4, false, false));
		}

		// Token: 0x060049BE RID: 18878 RVA: 0x001550CC File Offset: 0x001532CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233784, XrefRangeEnd = 233791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object GetData(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokeTypeInfo<ContainerType>.NativeMethodInfoPtr_GetData_Public_Virtual_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060049BF RID: 18879 RVA: 0x0015511C File Offset: 0x0015331C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233791, XrefRangeEnd = 233793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteObjectData(TraceLoggingDataCollector collector, Object valueObj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collector);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(valueObj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokeTypeInfo<ContainerType>.NativeMethodInfoPtr_WriteObjectData_Public_Virtual_Void_TraceLoggingDataCollector_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049C0 RID: 18880 RVA: 0x0001B9E6 File Offset: 0x00019BE6
		public InvokeTypeInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170012B8 RID: 4792
		// (get) Token: 0x060049C1 RID: 18881 RVA: 0x00155170 File Offset: 0x00153370
		// (set) Token: 0x060049C2 RID: 18882 RVA: 0x0001B9EF File Offset: 0x00019BEF
		public unsafe Il2CppReferenceArray<PropertyAnalysis> properties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvokeTypeInfo<ContainerType>.NativeFieldInfoPtr_properties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PropertyAnalysis>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvokeTypeInfo<ContainerType>.NativeFieldInfoPtr_properties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012B9 RID: 4793
		// (get) Token: 0x060049C3 RID: 18883 RVA: 0x001551A0 File Offset: 0x001533A0
		// (set) Token: 0x060049C4 RID: 18884 RVA: 0x0001BA0E File Offset: 0x00019C0E
		public unsafe Il2CppReferenceArray<PropertyAccessor<ContainerType>> accessors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvokeTypeInfo<ContainerType>.NativeFieldInfoPtr_accessors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PropertyAccessor<ContainerType>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvokeTypeInfo<ContainerType>.NativeFieldInfoPtr_accessors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003BB0 RID: 15280
		private static readonly IntPtr NativeFieldInfoPtr_properties;

		// Token: 0x04003BB1 RID: 15281
		private static readonly IntPtr NativeFieldInfoPtr_accessors;

		// Token: 0x04003BB2 RID: 15282
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TypeAnalysis_0;

		// Token: 0x04003BB3 RID: 15283
		private static readonly IntPtr NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0;

		// Token: 0x04003BB4 RID: 15284
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_ContainerType_0;

		// Token: 0x04003BB5 RID: 15285
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_Virtual_Object_Object_0;

		// Token: 0x04003BB6 RID: 15286
		private static readonly IntPtr NativeMethodInfoPtr_WriteObjectData_Public_Virtual_Void_TraceLoggingDataCollector_Object_0;
	}
}
