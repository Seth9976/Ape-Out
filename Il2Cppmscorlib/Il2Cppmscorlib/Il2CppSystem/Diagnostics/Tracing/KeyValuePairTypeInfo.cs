using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x02000503 RID: 1283
	public sealed class KeyValuePairTypeInfo<K, V> : TraceLoggingTypeInfo<KeyValuePair<K, V>>
	{
		// Token: 0x06004ADF RID: 19167 RVA: 0x0015A328 File Offset: 0x00158528
		// Note: this type is marked as 'beforefieldinit'.
		static KeyValuePairTypeInfo()
		{
			Il2CppClassPointerStore<KeyValuePairTypeInfo<K, V>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "KeyValuePairTypeInfo`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<K>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<V>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyValuePairTypeInfo<K, V>>.NativeClassPtr);
			KeyValuePairTypeInfo<K, V>.NativeFieldInfoPtr_keyInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyValuePairTypeInfo<K, V>>.NativeClassPtr, "keyInfo");
			KeyValuePairTypeInfo<K, V>.NativeFieldInfoPtr_valueInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyValuePairTypeInfo<K, V>>.NativeClassPtr, "valueInfo");
			KeyValuePairTypeInfo<K, V>.NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyValuePairTypeInfo<K, V>>.NativeClassPtr, 100674482);
			KeyValuePairTypeInfo<K, V>.NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_KeyValuePair_2_K_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyValuePairTypeInfo<K, V>>.NativeClassPtr, 100674483);
		}

		// Token: 0x06004AE0 RID: 19168 RVA: 0x0015A3F8 File Offset: 0x001585F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236380, XrefRangeEnd = 236386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyValuePairTypeInfo<K, V>.NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AE1 RID: 19169 RVA: 0x0015A45C File Offset: 0x0015865C
		[CallerCount(0)]
		public unsafe override void WriteData(TraceLoggingDataCollector collector, ref KeyValuePair<K, V> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collector);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyValuePairTypeInfo<K, V>.NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_KeyValuePair_2_K_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AE2 RID: 19170 RVA: 0x0001BD60 File Offset: 0x00019F60
		public KeyValuePairTypeInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170012C7 RID: 4807
		// (get) Token: 0x06004AE3 RID: 19171 RVA: 0x0015A4B8 File Offset: 0x001586B8
		// (set) Token: 0x06004AE4 RID: 19172 RVA: 0x0001BD69 File Offset: 0x00019F69
		public unsafe TraceLoggingTypeInfo<K> keyInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyValuePairTypeInfo<K, V>.NativeFieldInfoPtr_keyInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TraceLoggingTypeInfo<K>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyValuePairTypeInfo<K, V>.NativeFieldInfoPtr_keyInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012C8 RID: 4808
		// (get) Token: 0x06004AE5 RID: 19173 RVA: 0x0015A4E8 File Offset: 0x001586E8
		// (set) Token: 0x06004AE6 RID: 19174 RVA: 0x0001BD88 File Offset: 0x00019F88
		public unsafe TraceLoggingTypeInfo<V> valueInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyValuePairTypeInfo<K, V>.NativeFieldInfoPtr_valueInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TraceLoggingTypeInfo<V>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyValuePairTypeInfo<K, V>.NativeFieldInfoPtr_valueInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003C62 RID: 15458
		private static readonly IntPtr NativeFieldInfoPtr_keyInfo;

		// Token: 0x04003C63 RID: 15459
		private static readonly IntPtr NativeFieldInfoPtr_valueInfo;

		// Token: 0x04003C64 RID: 15460
		private static readonly IntPtr NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0;

		// Token: 0x04003C65 RID: 15461
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_KeyValuePair_2_K_V_0;
	}
}
