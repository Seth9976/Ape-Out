using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x0200050C RID: 1292
	public class TraceLoggingTypeInfo : Object
	{
		// Token: 0x06004C04 RID: 19460 RVA: 0x0015F40C File Offset: 0x0015D60C
		// Note: this type is marked as 'beforefieldinit'.
		static TraceLoggingTypeInfo()
		{
			Il2CppClassPointerStore<TraceLoggingTypeInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "TraceLoggingTypeInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TraceLoggingTypeInfo>.NativeClassPtr);
			TraceLoggingTypeInfo.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingTypeInfo>.NativeClassPtr, "name");
			TraceLoggingTypeInfo.NativeFieldInfoPtr_keywords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingTypeInfo>.NativeClassPtr, "keywords");
			TraceLoggingTypeInfo.NativeFieldInfoPtr_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingTypeInfo>.NativeClassPtr, "level");
			TraceLoggingTypeInfo.NativeFieldInfoPtr_opcode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingTypeInfo>.NativeClassPtr, "opcode");
			TraceLoggingTypeInfo.NativeFieldInfoPtr_tags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingTypeInfo>.NativeClassPtr, "tags");
			TraceLoggingTypeInfo.NativeFieldInfoPtr_dataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingTypeInfo>.NativeClassPtr, "dataType");
			TraceLoggingTypeInfo.NativeMethodInfoPtr__ctor_Internal_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingTypeInfo>.NativeClassPtr, 100674675);
			TraceLoggingTypeInfo.NativeMethodInfoPtr__ctor_Internal_Void_Type_String_EventLevel_EventOpcode_EventKeywords_EventTags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingTypeInfo>.NativeClassPtr, 100674676);
			TraceLoggingTypeInfo.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingTypeInfo>.NativeClassPtr, 100674677);
			TraceLoggingTypeInfo.NativeMethodInfoPtr_get_Level_Public_get_EventLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingTypeInfo>.NativeClassPtr, 100674678);
			TraceLoggingTypeInfo.NativeMethodInfoPtr_get_Opcode_Public_get_EventOpcode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingTypeInfo>.NativeClassPtr, 100674679);
			TraceLoggingTypeInfo.NativeMethodInfoPtr_get_Keywords_Public_get_EventKeywords_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingTypeInfo>.NativeClassPtr, 100674680);
			TraceLoggingTypeInfo.NativeMethodInfoPtr_get_Tags_Public_get_EventTags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingTypeInfo>.NativeClassPtr, 100674681);
			TraceLoggingTypeInfo.NativeMethodInfoPtr_get_DataType_Internal_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingTypeInfo>.NativeClassPtr, 100674682);
			TraceLoggingTypeInfo.NativeMethodInfoPtr_WriteMetadata_Public_Abstract_Virtual_New_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingTypeInfo>.NativeClassPtr, 100674683);
			TraceLoggingTypeInfo.NativeMethodInfoPtr_WriteObjectData_Public_Abstract_Virtual_New_Void_TraceLoggingDataCollector_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingTypeInfo>.NativeClassPtr, 100674684);
			TraceLoggingTypeInfo.NativeMethodInfoPtr_GetData_Public_Virtual_New_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingTypeInfo>.NativeClassPtr, 100674685);
		}

		// Token: 0x06004C05 RID: 19461 RVA: 0x0015F590 File Offset: 0x0015D790
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 240310, RefRangeEnd = 240347, XrefRangeStart = 240307, XrefRangeEnd = 240310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TraceLoggingTypeInfo(Type dataType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TraceLoggingTypeInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingTypeInfo.NativeMethodInfoPtr__ctor_Internal_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004C06 RID: 19462 RVA: 0x0015F5DC File Offset: 0x0015D7DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 240374, RefRangeEnd = 240376, XrefRangeStart = 240347, XrefRangeEnd = 240374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TraceLoggingTypeInfo(Type dataType, string name, EventLevel level, EventOpcode opcode, EventKeywords keywords, EventTags tags)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TraceLoggingTypeInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opcode;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keywords;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingTypeInfo.NativeMethodInfoPtr__ctor_Internal_Void_Type_String_EventLevel_EventOpcode_EventKeywords_EventTags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700130F RID: 4879
		// (get) Token: 0x06004C07 RID: 19463 RVA: 0x0015F674 File Offset: 0x0015D874
		public unsafe string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingTypeInfo.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001310 RID: 4880
		// (get) Token: 0x06004C08 RID: 19464 RVA: 0x0015F6AC File Offset: 0x0015D8AC
		public unsafe EventLevel Level
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingTypeInfo.NativeMethodInfoPtr_get_Level_Public_get_EventLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001311 RID: 4881
		// (get) Token: 0x06004C09 RID: 19465 RVA: 0x0015F6E8 File Offset: 0x0015D8E8
		public unsafe EventOpcode Opcode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingTypeInfo.NativeMethodInfoPtr_get_Opcode_Public_get_EventOpcode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001312 RID: 4882
		// (get) Token: 0x06004C0A RID: 19466 RVA: 0x0015F724 File Offset: 0x0015D924
		public unsafe EventKeywords Keywords
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingTypeInfo.NativeMethodInfoPtr_get_Keywords_Public_get_EventKeywords_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001313 RID: 4883
		// (get) Token: 0x06004C0B RID: 19467 RVA: 0x0015F760 File Offset: 0x0015D960
		public unsafe EventTags Tags
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingTypeInfo.NativeMethodInfoPtr_get_Tags_Public_get_EventTags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001314 RID: 4884
		// (get) Token: 0x06004C0C RID: 19468 RVA: 0x0015F79C File Offset: 0x0015D99C
		public unsafe Type DataType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingTypeInfo.NativeMethodInfoPtr_get_DataType_Internal_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06004C0D RID: 19469 RVA: 0x0015F7DC File Offset: 0x0015D9DC
		[CallerCount(0)]
		public unsafe virtual void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TraceLoggingTypeInfo.NativeMethodInfoPtr_WriteMetadata_Public_Abstract_Virtual_New_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C0E RID: 19470 RVA: 0x0015F84C File Offset: 0x0015DA4C
		[CallerCount(0)]
		public unsafe virtual void WriteObjectData(TraceLoggingDataCollector collector, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collector);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TraceLoggingTypeInfo.NativeMethodInfoPtr_WriteObjectData_Public_Abstract_Virtual_New_Void_TraceLoggingDataCollector_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C0F RID: 19471 RVA: 0x0015F8AC File Offset: 0x0015DAAC
		[CallerCount(0)]
		public unsafe virtual Object GetData(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TraceLoggingTypeInfo.NativeMethodInfoPtr_GetData_Public_Virtual_New_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06004C10 RID: 19472 RVA: 0x0001C376 File Offset: 0x0001A576
		public TraceLoggingTypeInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001309 RID: 4873
		// (get) Token: 0x06004C11 RID: 19473 RVA: 0x0015F908 File Offset: 0x0015DB08
		// (set) Token: 0x06004C12 RID: 19474 RVA: 0x0001C37F File Offset: 0x0001A57F
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingTypeInfo.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingTypeInfo.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700130A RID: 4874
		// (get) Token: 0x06004C13 RID: 19475 RVA: 0x0015F930 File Offset: 0x0015DB30
		// (set) Token: 0x06004C14 RID: 19476 RVA: 0x0001C39E File Offset: 0x0001A59E
		public unsafe EventKeywords keywords
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingTypeInfo.NativeFieldInfoPtr_keywords);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingTypeInfo.NativeFieldInfoPtr_keywords)) = value;
			}
		}

		// Token: 0x1700130B RID: 4875
		// (get) Token: 0x06004C15 RID: 19477 RVA: 0x0015F958 File Offset: 0x0015DB58
		// (set) Token: 0x06004C16 RID: 19478 RVA: 0x0001C3B9 File Offset: 0x0001A5B9
		public unsafe EventLevel level
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingTypeInfo.NativeFieldInfoPtr_level);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingTypeInfo.NativeFieldInfoPtr_level)) = value;
			}
		}

		// Token: 0x1700130C RID: 4876
		// (get) Token: 0x06004C17 RID: 19479 RVA: 0x0015F980 File Offset: 0x0015DB80
		// (set) Token: 0x06004C18 RID: 19480 RVA: 0x0001C3D4 File Offset: 0x0001A5D4
		public unsafe EventOpcode opcode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingTypeInfo.NativeFieldInfoPtr_opcode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingTypeInfo.NativeFieldInfoPtr_opcode)) = value;
			}
		}

		// Token: 0x1700130D RID: 4877
		// (get) Token: 0x06004C19 RID: 19481 RVA: 0x0015F9A8 File Offset: 0x0015DBA8
		// (set) Token: 0x06004C1A RID: 19482 RVA: 0x0001C3EF File Offset: 0x0001A5EF
		public unsafe EventTags tags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingTypeInfo.NativeFieldInfoPtr_tags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingTypeInfo.NativeFieldInfoPtr_tags)) = value;
			}
		}

		// Token: 0x1700130E RID: 4878
		// (get) Token: 0x06004C1B RID: 19483 RVA: 0x0015F9D0 File Offset: 0x0015DBD0
		// (set) Token: 0x06004C1C RID: 19484 RVA: 0x0001C40A File Offset: 0x0001A60A
		public unsafe Type dataType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingTypeInfo.NativeFieldInfoPtr_dataType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingTypeInfo.NativeFieldInfoPtr_dataType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003D67 RID: 15719
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04003D68 RID: 15720
		private static readonly IntPtr NativeFieldInfoPtr_keywords;

		// Token: 0x04003D69 RID: 15721
		private static readonly IntPtr NativeFieldInfoPtr_level;

		// Token: 0x04003D6A RID: 15722
		private static readonly IntPtr NativeFieldInfoPtr_opcode;

		// Token: 0x04003D6B RID: 15723
		private static readonly IntPtr NativeFieldInfoPtr_tags;

		// Token: 0x04003D6C RID: 15724
		private static readonly IntPtr NativeFieldInfoPtr_dataType;

		// Token: 0x04003D6D RID: 15725
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Type_0;

		// Token: 0x04003D6E RID: 15726
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Type_String_EventLevel_EventOpcode_EventKeywords_EventTags_0;

		// Token: 0x04003D6F RID: 15727
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04003D70 RID: 15728
		private static readonly IntPtr NativeMethodInfoPtr_get_Level_Public_get_EventLevel_0;

		// Token: 0x04003D71 RID: 15729
		private static readonly IntPtr NativeMethodInfoPtr_get_Opcode_Public_get_EventOpcode_0;

		// Token: 0x04003D72 RID: 15730
		private static readonly IntPtr NativeMethodInfoPtr_get_Keywords_Public_get_EventKeywords_0;

		// Token: 0x04003D73 RID: 15731
		private static readonly IntPtr NativeMethodInfoPtr_get_Tags_Public_get_EventTags_0;

		// Token: 0x04003D74 RID: 15732
		private static readonly IntPtr NativeMethodInfoPtr_get_DataType_Internal_get_Type_0;

		// Token: 0x04003D75 RID: 15733
		private static readonly IntPtr NativeMethodInfoPtr_WriteMetadata_Public_Abstract_Virtual_New_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0;

		// Token: 0x04003D76 RID: 15734
		private static readonly IntPtr NativeMethodInfoPtr_WriteObjectData_Public_Abstract_Virtual_New_Void_TraceLoggingDataCollector_Object_0;

		// Token: 0x04003D77 RID: 15735
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_Virtual_New_Object_Object_0;
	}
}
