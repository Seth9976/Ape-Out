using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x0200050B RID: 1291
	public class TraceLoggingMetadataCollector : Object
	{
		// Token: 0x06004BEA RID: 19434 RVA: 0x0015ED68 File Offset: 0x0015CF68
		// Note: this type is marked as 'beforefieldinit'.
		static TraceLoggingMetadataCollector()
		{
			Il2CppClassPointerStore<TraceLoggingMetadataCollector>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "TraceLoggingMetadataCollector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TraceLoggingMetadataCollector>.NativeClassPtr);
			TraceLoggingMetadataCollector.NativeFieldInfoPtr_impl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingMetadataCollector>.NativeClassPtr, "impl");
			TraceLoggingMetadataCollector.NativeFieldInfoPtr_currentGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingMetadataCollector>.NativeClassPtr, "currentGroup");
			TraceLoggingMetadataCollector.NativeFieldInfoPtr_bufferedArrayFieldCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingMetadataCollector>.NativeClassPtr, "bufferedArrayFieldCount");
			TraceLoggingMetadataCollector.NativeFieldInfoPtr__Tags_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingMetadataCollector>.NativeClassPtr, "<Tags>k__BackingField");
			TraceLoggingMetadataCollector.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingMetadataCollector>.NativeClassPtr, 100674653);
			TraceLoggingMetadataCollector.NativeMethodInfoPtr__ctor_Private_Void_TraceLoggingMetadataCollector_FieldMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingMetadataCollector>.NativeClassPtr, 100674654);
			TraceLoggingMetadataCollector.NativeMethodInfoPtr_get_Tags_Internal_get_EventFieldTags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingMetadataCollector>.NativeClassPtr, 100674655);
			TraceLoggingMetadataCollector.NativeMethodInfoPtr_set_Tags_Internal_set_Void_EventFieldTags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingMetadataCollector>.NativeClassPtr, 100674656);
			TraceLoggingMetadataCollector.NativeMethodInfoPtr_get_ScratchSize_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingMetadataCollector>.NativeClassPtr, 100674657);
			TraceLoggingMetadataCollector.NativeMethodInfoPtr_get_DataCount_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingMetadataCollector>.NativeClassPtr, 100674658);
			TraceLoggingMetadataCollector.NativeMethodInfoPtr_get_PinCount_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingMetadataCollector>.NativeClassPtr, 100674659);
			TraceLoggingMetadataCollector.NativeMethodInfoPtr_get_BeginningBufferedArray_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingMetadataCollector>.NativeClassPtr, 100674660);
			TraceLoggingMetadataCollector.NativeMethodInfoPtr_AddGroup_Public_TraceLoggingMetadataCollector_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingMetadataCollector>.NativeClassPtr, 100674661);
			TraceLoggingMetadataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_String_TraceLoggingDataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingMetadataCollector>.NativeClassPtr, 100674662);
			TraceLoggingMetadataCollector.NativeMethodInfoPtr_AddBinary_Public_Void_String_TraceLoggingDataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingMetadataCollector>.NativeClassPtr, 100674663);
			TraceLoggingMetadataCollector.NativeMethodInfoPtr_AddArray_Public_Void_String_TraceLoggingDataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingMetadataCollector>.NativeClassPtr, 100674664);
			TraceLoggingMetadataCollector.NativeMethodInfoPtr_BeginBufferedArray_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingMetadataCollector>.NativeClassPtr, 100674665);
			TraceLoggingMetadataCollector.NativeMethodInfoPtr_EndBufferedArray_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingMetadataCollector>.NativeClassPtr, 100674666);
			TraceLoggingMetadataCollector.NativeMethodInfoPtr_GetMetadata_Internal_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingMetadataCollector>.NativeClassPtr, 100674667);
			TraceLoggingMetadataCollector.NativeMethodInfoPtr_AddField_Private_Void_FieldMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingMetadataCollector>.NativeClassPtr, 100674668);
		}

		// Token: 0x06004BEB RID: 19435 RVA: 0x0015EF28 File Offset: 0x0015D128
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 239831, RefRangeEnd = 239833, XrefRangeStart = 239822, XrefRangeEnd = 239831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TraceLoggingMetadataCollector()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TraceLoggingMetadataCollector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingMetadataCollector.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BEC RID: 19436 RVA: 0x0015EF64 File Offset: 0x0015D164
		[CallerCount(0)]
		public unsafe TraceLoggingMetadataCollector(TraceLoggingMetadataCollector other, FieldMetadata group)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TraceLoggingMetadataCollector>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(group);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingMetadataCollector.NativeMethodInfoPtr__ctor_Private_Void_TraceLoggingMetadataCollector_FieldMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001304 RID: 4868
		// (get) Token: 0x06004BED RID: 19437 RVA: 0x0015EFC4 File Offset: 0x0015D1C4
		// (set) Token: 0x06004BEE RID: 19438 RVA: 0x0015F000 File Offset: 0x0015D200
		public unsafe EventFieldTags Tags
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingMetadataCollector.NativeMethodInfoPtr_get_Tags_Internal_get_EventFieldTags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingMetadataCollector.NativeMethodInfoPtr_set_Tags_Internal_set_Void_EventFieldTags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001305 RID: 4869
		// (get) Token: 0x06004BEF RID: 19439 RVA: 0x0015F040 File Offset: 0x0015D240
		public unsafe int ScratchSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingMetadataCollector.NativeMethodInfoPtr_get_ScratchSize_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001306 RID: 4870
		// (get) Token: 0x06004BF0 RID: 19440 RVA: 0x0015F07C File Offset: 0x0015D27C
		public unsafe int DataCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingMetadataCollector.NativeMethodInfoPtr_get_DataCount_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001307 RID: 4871
		// (get) Token: 0x06004BF1 RID: 19441 RVA: 0x0015F0B8 File Offset: 0x0015D2B8
		public unsafe int PinCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingMetadataCollector.NativeMethodInfoPtr_get_PinCount_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001308 RID: 4872
		// (get) Token: 0x06004BF2 RID: 19442 RVA: 0x0015F0F4 File Offset: 0x0015D2F4
		public unsafe bool BeginningBufferedArray
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingMetadataCollector.NativeMethodInfoPtr_get_BeginningBufferedArray_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004BF3 RID: 19443 RVA: 0x0015F130 File Offset: 0x0015D330
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 239841, RefRangeEnd = 239845, XrefRangeStart = 239833, XrefRangeEnd = 239841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TraceLoggingMetadataCollector AddGroup(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingMetadataCollector.NativeMethodInfoPtr_AddGroup_Public_TraceLoggingMetadataCollector_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TraceLoggingMetadataCollector>(intPtr3) : null;
			}
		}

		// Token: 0x06004BF4 RID: 19444 RVA: 0x0015F180 File Offset: 0x0015D380
		[CallerCount(364)]
		[CachedScanResults(RefRangeStart = 239871, RefRangeEnd = 240235, XrefRangeStart = 239845, XrefRangeEnd = 239871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddScalar(string name, TraceLoggingDataType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingMetadataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_String_TraceLoggingDataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BF5 RID: 19445 RVA: 0x0015F1D0 File Offset: 0x0015D3D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 240249, RefRangeEnd = 240251, XrefRangeStart = 240235, XrefRangeEnd = 240249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddBinary(string name, TraceLoggingDataType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingMetadataCollector.NativeMethodInfoPtr_AddBinary_Public_Void_String_TraceLoggingDataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BF6 RID: 19446 RVA: 0x0015F220 File Offset: 0x0015D420
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 240272, RefRangeEnd = 240288, XrefRangeStart = 240251, XrefRangeEnd = 240272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddArray(string name, TraceLoggingDataType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingMetadataCollector.NativeMethodInfoPtr_AddArray_Public_Void_String_TraceLoggingDataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BF7 RID: 19447 RVA: 0x0015F270 File Offset: 0x0015D470
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 240289, RefRangeEnd = 240291, XrefRangeStart = 240288, XrefRangeEnd = 240289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginBufferedArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingMetadataCollector.NativeMethodInfoPtr_BeginBufferedArray_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BF8 RID: 19448 RVA: 0x0015F2A4 File Offset: 0x0015D4A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 240291, RefRangeEnd = 240293, XrefRangeStart = 240291, XrefRangeEnd = 240291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndBufferedArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingMetadataCollector.NativeMethodInfoPtr_EndBufferedArray_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BF9 RID: 19449 RVA: 0x0015F2D8 File Offset: 0x0015D4D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 240298, RefRangeEnd = 240300, XrefRangeStart = 240293, XrefRangeEnd = 240298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetMetadata()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingMetadataCollector.NativeMethodInfoPtr_GetMetadata_Internal_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06004BFA RID: 19450 RVA: 0x0015F318 File Offset: 0x0015D518
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 240303, RefRangeEnd = 240307, XrefRangeStart = 240300, XrefRangeEnd = 240303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddField(FieldMetadata fieldMetadata)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fieldMetadata);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingMetadataCollector.NativeMethodInfoPtr_AddField_Private_Void_FieldMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004BFB RID: 19451 RVA: 0x0001C2F9 File Offset: 0x0001A4F9
		public TraceLoggingMetadataCollector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001300 RID: 4864
		// (get) Token: 0x06004BFC RID: 19452 RVA: 0x0015F35C File Offset: 0x0015D55C
		// (set) Token: 0x06004BFD RID: 19453 RVA: 0x0001C302 File Offset: 0x0001A502
		public unsafe TraceLoggingMetadataCollector.Impl impl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingMetadataCollector.NativeFieldInfoPtr_impl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TraceLoggingMetadataCollector.Impl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingMetadataCollector.NativeFieldInfoPtr_impl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001301 RID: 4865
		// (get) Token: 0x06004BFE RID: 19454 RVA: 0x0015F38C File Offset: 0x0015D58C
		// (set) Token: 0x06004BFF RID: 19455 RVA: 0x0001C321 File Offset: 0x0001A521
		public unsafe FieldMetadata currentGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingMetadataCollector.NativeFieldInfoPtr_currentGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FieldMetadata>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingMetadataCollector.NativeFieldInfoPtr_currentGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001302 RID: 4866
		// (get) Token: 0x06004C00 RID: 19456 RVA: 0x0015F3BC File Offset: 0x0015D5BC
		// (set) Token: 0x06004C01 RID: 19457 RVA: 0x0001C340 File Offset: 0x0001A540
		public unsafe int bufferedArrayFieldCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingMetadataCollector.NativeFieldInfoPtr_bufferedArrayFieldCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingMetadataCollector.NativeFieldInfoPtr_bufferedArrayFieldCount)) = value;
			}
		}

		// Token: 0x17001303 RID: 4867
		// (get) Token: 0x06004C02 RID: 19458 RVA: 0x0015F3E4 File Offset: 0x0015D5E4
		// (set) Token: 0x06004C03 RID: 19459 RVA: 0x0001C35B File Offset: 0x0001A55B
		public unsafe EventFieldTags _Tags_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingMetadataCollector.NativeFieldInfoPtr__Tags_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingMetadataCollector.NativeFieldInfoPtr__Tags_k__BackingField)) = value;
			}
		}

		// Token: 0x04003D53 RID: 15699
		private static readonly IntPtr NativeFieldInfoPtr_impl;

		// Token: 0x04003D54 RID: 15700
		private static readonly IntPtr NativeFieldInfoPtr_currentGroup;

		// Token: 0x04003D55 RID: 15701
		private static readonly IntPtr NativeFieldInfoPtr_bufferedArrayFieldCount;

		// Token: 0x04003D56 RID: 15702
		private static readonly IntPtr NativeFieldInfoPtr__Tags_k__BackingField;

		// Token: 0x04003D57 RID: 15703
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04003D58 RID: 15704
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_TraceLoggingMetadataCollector_FieldMetadata_0;

		// Token: 0x04003D59 RID: 15705
		private static readonly IntPtr NativeMethodInfoPtr_get_Tags_Internal_get_EventFieldTags_0;

		// Token: 0x04003D5A RID: 15706
		private static readonly IntPtr NativeMethodInfoPtr_set_Tags_Internal_set_Void_EventFieldTags_0;

		// Token: 0x04003D5B RID: 15707
		private static readonly IntPtr NativeMethodInfoPtr_get_ScratchSize_Internal_get_Int32_0;

		// Token: 0x04003D5C RID: 15708
		private static readonly IntPtr NativeMethodInfoPtr_get_DataCount_Internal_get_Int32_0;

		// Token: 0x04003D5D RID: 15709
		private static readonly IntPtr NativeMethodInfoPtr_get_PinCount_Internal_get_Int32_0;

		// Token: 0x04003D5E RID: 15710
		private static readonly IntPtr NativeMethodInfoPtr_get_BeginningBufferedArray_Private_get_Boolean_0;

		// Token: 0x04003D5F RID: 15711
		private static readonly IntPtr NativeMethodInfoPtr_AddGroup_Public_TraceLoggingMetadataCollector_String_0;

		// Token: 0x04003D60 RID: 15712
		private static readonly IntPtr NativeMethodInfoPtr_AddScalar_Public_Void_String_TraceLoggingDataType_0;

		// Token: 0x04003D61 RID: 15713
		private static readonly IntPtr NativeMethodInfoPtr_AddBinary_Public_Void_String_TraceLoggingDataType_0;

		// Token: 0x04003D62 RID: 15714
		private static readonly IntPtr NativeMethodInfoPtr_AddArray_Public_Void_String_TraceLoggingDataType_0;

		// Token: 0x04003D63 RID: 15715
		private static readonly IntPtr NativeMethodInfoPtr_BeginBufferedArray_Public_Void_0;

		// Token: 0x04003D64 RID: 15716
		private static readonly IntPtr NativeMethodInfoPtr_EndBufferedArray_Public_Void_0;

		// Token: 0x04003D65 RID: 15717
		private static readonly IntPtr NativeMethodInfoPtr_GetMetadata_Internal_Il2CppStructArray_1_Byte_0;

		// Token: 0x04003D66 RID: 15718
		private static readonly IntPtr NativeMethodInfoPtr_AddField_Private_Void_FieldMetadata_0;

		// Token: 0x02000680 RID: 1664
		public class Impl : Object
		{
			// Token: 0x060058B6 RID: 22710 RVA: 0x0018AA28 File Offset: 0x00188C28
			// Note: this type is marked as 'beforefieldinit'.
			static Impl()
			{
				Il2CppClassPointerStore<TraceLoggingMetadataCollector.Impl>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TraceLoggingMetadataCollector>.NativeClassPtr, "Impl");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TraceLoggingMetadataCollector.Impl>.NativeClassPtr);
				TraceLoggingMetadataCollector.Impl.NativeFieldInfoPtr_fields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingMetadataCollector.Impl>.NativeClassPtr, "fields");
				TraceLoggingMetadataCollector.Impl.NativeFieldInfoPtr_scratchSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingMetadataCollector.Impl>.NativeClassPtr, "scratchSize");
				TraceLoggingMetadataCollector.Impl.NativeFieldInfoPtr_dataCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingMetadataCollector.Impl>.NativeClassPtr, "dataCount");
				TraceLoggingMetadataCollector.Impl.NativeFieldInfoPtr_pinCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingMetadataCollector.Impl>.NativeClassPtr, "pinCount");
				TraceLoggingMetadataCollector.Impl.NativeFieldInfoPtr_bufferNesting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingMetadataCollector.Impl>.NativeClassPtr, "bufferNesting");
				TraceLoggingMetadataCollector.Impl.NativeFieldInfoPtr_scalar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingMetadataCollector.Impl>.NativeClassPtr, "scalar");
				TraceLoggingMetadataCollector.Impl.NativeMethodInfoPtr_AddScalar_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingMetadataCollector.Impl>.NativeClassPtr, 100674669);
				TraceLoggingMetadataCollector.Impl.NativeMethodInfoPtr_AddNonscalar_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingMetadataCollector.Impl>.NativeClassPtr, 100674670);
				TraceLoggingMetadataCollector.Impl.NativeMethodInfoPtr_BeginBuffered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingMetadataCollector.Impl>.NativeClassPtr, 100674671);
				TraceLoggingMetadataCollector.Impl.NativeMethodInfoPtr_EndBuffered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingMetadataCollector.Impl>.NativeClassPtr, 100674672);
				TraceLoggingMetadataCollector.Impl.NativeMethodInfoPtr_Encode_Public_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingMetadataCollector.Impl>.NativeClassPtr, 100674673);
				TraceLoggingMetadataCollector.Impl.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingMetadataCollector.Impl>.NativeClassPtr, 100674674);
			}

			// Token: 0x060058B7 RID: 22711 RVA: 0x0018AB44 File Offset: 0x00188D44
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 239796, RefRangeEnd = 239799, XrefRangeStart = 239795, XrefRangeEnd = 239796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void AddScalar(int size)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref size;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingMetadataCollector.Impl.NativeMethodInfoPtr_AddScalar_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060058B8 RID: 22712 RVA: 0x0018AB84 File Offset: 0x00188D84
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 239800, RefRangeEnd = 239804, XrefRangeStart = 239799, XrefRangeEnd = 239800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void AddNonscalar()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingMetadataCollector.Impl.NativeMethodInfoPtr_AddNonscalar_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060058B9 RID: 22713 RVA: 0x0018ABB8 File Offset: 0x00188DB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239804, XrefRangeEnd = 239805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void BeginBuffered()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingMetadataCollector.Impl.NativeMethodInfoPtr_BeginBuffered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060058BA RID: 22714 RVA: 0x0018ABEC File Offset: 0x00188DEC
			[CallerCount(0)]
			public unsafe void EndBuffered()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingMetadataCollector.Impl.NativeMethodInfoPtr_EndBuffered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060058BB RID: 22715 RVA: 0x0018AC20 File Offset: 0x00188E20
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 239814, RefRangeEnd = 239816, XrefRangeStart = 239805, XrefRangeEnd = 239814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int Encode(Il2CppStructArray<byte> metadata)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(metadata);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingMetadataCollector.Impl.NativeMethodInfoPtr_Encode_Public_Int32_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060058BC RID: 22716 RVA: 0x0018AC70 File Offset: 0x00188E70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239816, XrefRangeEnd = 239822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Impl()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TraceLoggingMetadataCollector.Impl>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingMetadataCollector.Impl.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060058BD RID: 22717 RVA: 0x00021D9D File Offset: 0x0001FF9D
			public Impl(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170016F7 RID: 5879
			// (get) Token: 0x060058BE RID: 22718 RVA: 0x0018ACAC File Offset: 0x00188EAC
			// (set) Token: 0x060058BF RID: 22719 RVA: 0x00021DA6 File Offset: 0x0001FFA6
			public unsafe List<FieldMetadata> fields
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingMetadataCollector.Impl.NativeFieldInfoPtr_fields);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FieldMetadata>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingMetadataCollector.Impl.NativeFieldInfoPtr_fields), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170016F8 RID: 5880
			// (get) Token: 0x060058C0 RID: 22720 RVA: 0x0018ACDC File Offset: 0x00188EDC
			// (set) Token: 0x060058C1 RID: 22721 RVA: 0x00021DC5 File Offset: 0x0001FFC5
			public unsafe short scratchSize
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingMetadataCollector.Impl.NativeFieldInfoPtr_scratchSize);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingMetadataCollector.Impl.NativeFieldInfoPtr_scratchSize)) = value;
				}
			}

			// Token: 0x170016F9 RID: 5881
			// (get) Token: 0x060058C2 RID: 22722 RVA: 0x0018AD04 File Offset: 0x00188F04
			// (set) Token: 0x060058C3 RID: 22723 RVA: 0x00021DE0 File Offset: 0x0001FFE0
			public unsafe sbyte dataCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingMetadataCollector.Impl.NativeFieldInfoPtr_dataCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingMetadataCollector.Impl.NativeFieldInfoPtr_dataCount)) = value;
				}
			}

			// Token: 0x170016FA RID: 5882
			// (get) Token: 0x060058C4 RID: 22724 RVA: 0x0018AD2C File Offset: 0x00188F2C
			// (set) Token: 0x060058C5 RID: 22725 RVA: 0x00021DFB File Offset: 0x0001FFFB
			public unsafe sbyte pinCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingMetadataCollector.Impl.NativeFieldInfoPtr_pinCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingMetadataCollector.Impl.NativeFieldInfoPtr_pinCount)) = value;
				}
			}

			// Token: 0x170016FB RID: 5883
			// (get) Token: 0x060058C6 RID: 22726 RVA: 0x0018AD54 File Offset: 0x00188F54
			// (set) Token: 0x060058C7 RID: 22727 RVA: 0x00021E16 File Offset: 0x00020016
			public unsafe int bufferNesting
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingMetadataCollector.Impl.NativeFieldInfoPtr_bufferNesting);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingMetadataCollector.Impl.NativeFieldInfoPtr_bufferNesting)) = value;
				}
			}

			// Token: 0x170016FC RID: 5884
			// (get) Token: 0x060058C8 RID: 22728 RVA: 0x0018AD7C File Offset: 0x00188F7C
			// (set) Token: 0x060058C9 RID: 22729 RVA: 0x00021E31 File Offset: 0x00020031
			public unsafe bool scalar
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingMetadataCollector.Impl.NativeFieldInfoPtr_scalar);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingMetadataCollector.Impl.NativeFieldInfoPtr_scalar)) = value;
				}
			}

			// Token: 0x04004714 RID: 18196
			private static readonly IntPtr NativeFieldInfoPtr_fields;

			// Token: 0x04004715 RID: 18197
			private static readonly IntPtr NativeFieldInfoPtr_scratchSize;

			// Token: 0x04004716 RID: 18198
			private static readonly IntPtr NativeFieldInfoPtr_dataCount;

			// Token: 0x04004717 RID: 18199
			private static readonly IntPtr NativeFieldInfoPtr_pinCount;

			// Token: 0x04004718 RID: 18200
			private static readonly IntPtr NativeFieldInfoPtr_bufferNesting;

			// Token: 0x04004719 RID: 18201
			private static readonly IntPtr NativeFieldInfoPtr_scalar;

			// Token: 0x0400471A RID: 18202
			private static readonly IntPtr NativeMethodInfoPtr_AddScalar_Public_Void_Int32_0;

			// Token: 0x0400471B RID: 18203
			private static readonly IntPtr NativeMethodInfoPtr_AddNonscalar_Public_Void_0;

			// Token: 0x0400471C RID: 18204
			private static readonly IntPtr NativeMethodInfoPtr_BeginBuffered_Public_Void_0;

			// Token: 0x0400471D RID: 18205
			private static readonly IntPtr NativeMethodInfoPtr_EndBuffered_Public_Void_0;

			// Token: 0x0400471E RID: 18206
			private static readonly IntPtr NativeMethodInfoPtr_Encode_Public_Int32_Il2CppStructArray_1_Byte_0;

			// Token: 0x0400471F RID: 18207
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
