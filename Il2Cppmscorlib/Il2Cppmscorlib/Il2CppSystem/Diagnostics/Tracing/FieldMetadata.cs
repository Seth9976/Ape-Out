using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004D0 RID: 1232
	public class FieldMetadata : Object
	{
		// Token: 0x060049A6 RID: 18854 RVA: 0x00154AF8 File Offset: 0x00152CF8
		// Note: this type is marked as 'beforefieldinit'.
		static FieldMetadata()
		{
			Il2CppClassPointerStore<FieldMetadata>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "FieldMetadata");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FieldMetadata>.NativeClassPtr);
			FieldMetadata.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldMetadata>.NativeClassPtr, "name");
			FieldMetadata.NativeFieldInfoPtr_nameSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldMetadata>.NativeClassPtr, "nameSize");
			FieldMetadata.NativeFieldInfoPtr_tags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldMetadata>.NativeClassPtr, "tags");
			FieldMetadata.NativeFieldInfoPtr_custom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldMetadata>.NativeClassPtr, "custom");
			FieldMetadata.NativeFieldInfoPtr_fixedCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldMetadata>.NativeClassPtr, "fixedCount");
			FieldMetadata.NativeFieldInfoPtr_inType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldMetadata>.NativeClassPtr, "inType");
			FieldMetadata.NativeFieldInfoPtr_outType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldMetadata>.NativeClassPtr, "outType");
			FieldMetadata.NativeMethodInfoPtr__ctor_Public_Void_String_TraceLoggingDataType_EventFieldTags_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMetadata>.NativeClassPtr, 100674310);
			FieldMetadata.NativeMethodInfoPtr__ctor_Private_Void_String_TraceLoggingDataType_EventFieldTags_Byte_UInt16_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMetadata>.NativeClassPtr, 100674311);
			FieldMetadata.NativeMethodInfoPtr_IncrementStructFieldCount_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMetadata>.NativeClassPtr, 100674312);
			FieldMetadata.NativeMethodInfoPtr_Encode_Public_Void_byref_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMetadata>.NativeClassPtr, 100674313);
		}

		// Token: 0x060049A7 RID: 18855 RVA: 0x00154C04 File Offset: 0x00152E04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233757, XrefRangeEnd = 233758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FieldMetadata(string name, TraceLoggingDataType type, EventFieldTags tags, bool variableCount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FieldMetadata>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tags;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref variableCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMetadata.NativeMethodInfoPtr__ctor_Public_Void_String_TraceLoggingDataType_EventFieldTags_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049A8 RID: 18856 RVA: 0x00154C7C File Offset: 0x00152E7C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 233763, RefRangeEnd = 233768, XrefRangeStart = 233758, XrefRangeEnd = 233763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FieldMetadata(string name, TraceLoggingDataType dataType, EventFieldTags tags, byte countFlags, ushort fixedCount = 0, Il2CppStructArray<byte> custom = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FieldMetadata>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tags;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref countFlags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fixedCount;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(custom);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMetadata.NativeMethodInfoPtr__ctor_Private_Void_String_TraceLoggingDataType_EventFieldTags_Byte_UInt16_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049A9 RID: 18857 RVA: 0x00154D14 File Offset: 0x00152F14
		[CallerCount(0)]
		public unsafe void IncrementStructFieldCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMetadata.NativeMethodInfoPtr_IncrementStructFieldCount_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049AA RID: 18858 RVA: 0x00154D48 File Offset: 0x00152F48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 233774, RefRangeEnd = 233775, XrefRangeStart = 233768, XrefRangeEnd = 233774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Encode(ref int pos, Il2CppStructArray<byte> metadata)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(metadata);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMetadata.NativeMethodInfoPtr_Encode_Public_Void_byref_Int32_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049AB RID: 18859 RVA: 0x0001B918 File Offset: 0x00019B18
		public FieldMetadata(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170012B1 RID: 4785
		// (get) Token: 0x060049AC RID: 18860 RVA: 0x00154D98 File Offset: 0x00152F98
		// (set) Token: 0x060049AD RID: 18861 RVA: 0x0001B921 File Offset: 0x00019B21
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMetadata.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMetadata.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170012B2 RID: 4786
		// (get) Token: 0x060049AE RID: 18862 RVA: 0x00154DC0 File Offset: 0x00152FC0
		// (set) Token: 0x060049AF RID: 18863 RVA: 0x0001B940 File Offset: 0x00019B40
		public unsafe int nameSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMetadata.NativeFieldInfoPtr_nameSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMetadata.NativeFieldInfoPtr_nameSize)) = value;
			}
		}

		// Token: 0x170012B3 RID: 4787
		// (get) Token: 0x060049B0 RID: 18864 RVA: 0x00154DE8 File Offset: 0x00152FE8
		// (set) Token: 0x060049B1 RID: 18865 RVA: 0x0001B95B File Offset: 0x00019B5B
		public unsafe EventFieldTags tags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMetadata.NativeFieldInfoPtr_tags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMetadata.NativeFieldInfoPtr_tags)) = value;
			}
		}

		// Token: 0x170012B4 RID: 4788
		// (get) Token: 0x060049B2 RID: 18866 RVA: 0x00154E10 File Offset: 0x00153010
		// (set) Token: 0x060049B3 RID: 18867 RVA: 0x0001B976 File Offset: 0x00019B76
		public unsafe Il2CppStructArray<byte> custom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMetadata.NativeFieldInfoPtr_custom);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMetadata.NativeFieldInfoPtr_custom), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012B5 RID: 4789
		// (get) Token: 0x060049B4 RID: 18868 RVA: 0x00154E40 File Offset: 0x00153040
		// (set) Token: 0x060049B5 RID: 18869 RVA: 0x0001B995 File Offset: 0x00019B95
		public unsafe ushort fixedCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMetadata.NativeFieldInfoPtr_fixedCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMetadata.NativeFieldInfoPtr_fixedCount)) = value;
			}
		}

		// Token: 0x170012B6 RID: 4790
		// (get) Token: 0x060049B6 RID: 18870 RVA: 0x00154E68 File Offset: 0x00153068
		// (set) Token: 0x060049B7 RID: 18871 RVA: 0x0001B9B0 File Offset: 0x00019BB0
		public unsafe byte inType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMetadata.NativeFieldInfoPtr_inType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMetadata.NativeFieldInfoPtr_inType)) = value;
			}
		}

		// Token: 0x170012B7 RID: 4791
		// (get) Token: 0x060049B8 RID: 18872 RVA: 0x00154E90 File Offset: 0x00153090
		// (set) Token: 0x060049B9 RID: 18873 RVA: 0x0001B9CB File Offset: 0x00019BCB
		public unsafe byte outType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMetadata.NativeFieldInfoPtr_outType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMetadata.NativeFieldInfoPtr_outType)) = value;
			}
		}

		// Token: 0x04003BA5 RID: 15269
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04003BA6 RID: 15270
		private static readonly IntPtr NativeFieldInfoPtr_nameSize;

		// Token: 0x04003BA7 RID: 15271
		private static readonly IntPtr NativeFieldInfoPtr_tags;

		// Token: 0x04003BA8 RID: 15272
		private static readonly IntPtr NativeFieldInfoPtr_custom;

		// Token: 0x04003BA9 RID: 15273
		private static readonly IntPtr NativeFieldInfoPtr_fixedCount;

		// Token: 0x04003BAA RID: 15274
		private static readonly IntPtr NativeFieldInfoPtr_inType;

		// Token: 0x04003BAB RID: 15275
		private static readonly IntPtr NativeFieldInfoPtr_outType;

		// Token: 0x04003BAC RID: 15276
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_TraceLoggingDataType_EventFieldTags_Boolean_0;

		// Token: 0x04003BAD RID: 15277
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_TraceLoggingDataType_EventFieldTags_Byte_UInt16_Il2CppStructArray_1_Byte_0;

		// Token: 0x04003BAE RID: 15278
		private static readonly IntPtr NativeMethodInfoPtr_IncrementStructFieldCount_Public_Void_0;

		// Token: 0x04003BAF RID: 15279
		private static readonly IntPtr NativeMethodInfoPtr_Encode_Public_Void_byref_Int32_Il2CppStructArray_1_Byte_0;
	}
}
