using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x0200050A RID: 1290
	public class TraceLoggingEventTypes : Object
	{
		// Token: 0x06004BC9 RID: 19401 RVA: 0x0015E734 File Offset: 0x0015C934
		// Note: this type is marked as 'beforefieldinit'.
		static TraceLoggingEventTypes()
		{
			Il2CppClassPointerStore<TraceLoggingEventTypes>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "TraceLoggingEventTypes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TraceLoggingEventTypes>.NativeClassPtr);
			TraceLoggingEventTypes.NativeFieldInfoPtr_typeInfos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingEventTypes>.NativeClassPtr, "typeInfos");
			TraceLoggingEventTypes.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingEventTypes>.NativeClassPtr, "name");
			TraceLoggingEventTypes.NativeFieldInfoPtr_tags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingEventTypes>.NativeClassPtr, "tags");
			TraceLoggingEventTypes.NativeFieldInfoPtr_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingEventTypes>.NativeClassPtr, "level");
			TraceLoggingEventTypes.NativeFieldInfoPtr_opcode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingEventTypes>.NativeClassPtr, "opcode");
			TraceLoggingEventTypes.NativeFieldInfoPtr_keywords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingEventTypes>.NativeClassPtr, "keywords");
			TraceLoggingEventTypes.NativeFieldInfoPtr_typeMetadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingEventTypes>.NativeClassPtr, "typeMetadata");
			TraceLoggingEventTypes.NativeFieldInfoPtr_scratchSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingEventTypes>.NativeClassPtr, "scratchSize");
			TraceLoggingEventTypes.NativeFieldInfoPtr_dataCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingEventTypes>.NativeClassPtr, "dataCount");
			TraceLoggingEventTypes.NativeFieldInfoPtr_pinCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingEventTypes>.NativeClassPtr, "pinCount");
			TraceLoggingEventTypes.NativeFieldInfoPtr_nameInfos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingEventTypes>.NativeClassPtr, "nameInfos");
			TraceLoggingEventTypes.NativeMethodInfoPtr__ctor_Internal_Void_String_EventTags_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingEventTypes>.NativeClassPtr, 100674645);
			TraceLoggingEventTypes.NativeMethodInfoPtr__ctor_Internal_Void_String_EventTags_Il2CppReferenceArray_1_ParameterInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingEventTypes>.NativeClassPtr, 100674646);
			TraceLoggingEventTypes.NativeMethodInfoPtr__ctor_Private_Void_EventTags_String_Il2CppReferenceArray_1_TraceLoggingTypeInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingEventTypes>.NativeClassPtr, 100674647);
			TraceLoggingEventTypes.NativeMethodInfoPtr_get_Name_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingEventTypes>.NativeClassPtr, 100674648);
			TraceLoggingEventTypes.NativeMethodInfoPtr_get_Tags_Internal_get_EventTags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingEventTypes>.NativeClassPtr, 100674649);
			TraceLoggingEventTypes.NativeMethodInfoPtr_GetNameInfo_Internal_NameInfo_String_EventTags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingEventTypes>.NativeClassPtr, 100674650);
			TraceLoggingEventTypes.NativeMethodInfoPtr_MakeArray_Private_Il2CppReferenceArray_1_TraceLoggingTypeInfo_Il2CppReferenceArray_1_ParameterInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingEventTypes>.NativeClassPtr, 100674651);
			TraceLoggingEventTypes.NativeMethodInfoPtr_MakeArray_Private_Static_Il2CppReferenceArray_1_TraceLoggingTypeInfo_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingEventTypes>.NativeClassPtr, 100674652);
		}

		// Token: 0x06004BCA RID: 19402 RVA: 0x0015E8E0 File Offset: 0x0015CAE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239719, XrefRangeEnd = 239721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TraceLoggingEventTypes(string name, EventTags tags, [Optional] Il2CppReferenceArray<Type> types)
		{
			if (types == null)
			{
				types = new Il2CppReferenceArray<Type>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TraceLoggingEventTypes>.NativeClassPtr));
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tags;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(types);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingEventTypes.NativeMethodInfoPtr__ctor_Internal_Void_String_EventTags_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BCB RID: 19403 RVA: 0x0015E958 File Offset: 0x0015CB58
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 239733, RefRangeEnd = 239736, XrefRangeStart = 239721, XrefRangeEnd = 239733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TraceLoggingEventTypes(string name, EventTags tags, Il2CppReferenceArray<ParameterInfo> paramInfos)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TraceLoggingEventTypes>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tags;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paramInfos);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingEventTypes.NativeMethodInfoPtr__ctor_Internal_Void_String_EventTags_Il2CppReferenceArray_1_ParameterInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BCC RID: 19404 RVA: 0x0015E9C4 File Offset: 0x0015CBC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 239746, RefRangeEnd = 239747, XrefRangeStart = 239736, XrefRangeEnd = 239746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TraceLoggingEventTypes(EventTags tags, string defaultName, Il2CppReferenceArray<TraceLoggingTypeInfo> typeInfos)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TraceLoggingEventTypes>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tags;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeInfos);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingEventTypes.NativeMethodInfoPtr__ctor_Private_Void_EventTags_String_Il2CppReferenceArray_1_TraceLoggingTypeInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170012FE RID: 4862
		// (get) Token: 0x06004BCD RID: 19405 RVA: 0x0015EA30 File Offset: 0x0015CC30
		public unsafe string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingEventTypes.NativeMethodInfoPtr_get_Name_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170012FF RID: 4863
		// (get) Token: 0x06004BCE RID: 19406 RVA: 0x0015EA68 File Offset: 0x0015CC68
		public unsafe EventTags Tags
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingEventTypes.NativeMethodInfoPtr_get_Tags_Internal_get_EventTags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004BCF RID: 19407 RVA: 0x0015EAA4 File Offset: 0x0015CCA4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 239758, RefRangeEnd = 239761, XrefRangeStart = 239747, XrefRangeEnd = 239758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameInfo GetNameInfo(string name, EventTags tags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingEventTypes.NativeMethodInfoPtr_GetNameInfo_Internal_NameInfo_String_EventTags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NameInfo>(intPtr3) : null;
		}

		// Token: 0x06004BD0 RID: 19408 RVA: 0x0015EB04 File Offset: 0x0015CD04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 239777, RefRangeEnd = 239778, XrefRangeStart = 239761, XrefRangeEnd = 239777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<TraceLoggingTypeInfo> MakeArray(Il2CppReferenceArray<ParameterInfo> paramInfos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(paramInfos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingEventTypes.NativeMethodInfoPtr_MakeArray_Private_Il2CppReferenceArray_1_TraceLoggingTypeInfo_Il2CppReferenceArray_1_ParameterInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TraceLoggingTypeInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06004BD1 RID: 19409 RVA: 0x0015EB54 File Offset: 0x0015CD54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 239794, RefRangeEnd = 239795, XrefRangeStart = 239778, XrefRangeEnd = 239794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<TraceLoggingTypeInfo> MakeArray(Il2CppReferenceArray<Type> types)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(types);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingEventTypes.NativeMethodInfoPtr_MakeArray_Private_Static_Il2CppReferenceArray_1_TraceLoggingTypeInfo_Il2CppReferenceArray_1_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TraceLoggingTypeInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06004BD2 RID: 19410 RVA: 0x0001C198 File Offset: 0x0001A398
		public TraceLoggingEventTypes(string name, EventTags tags, params Type[] types)
			: this(name, tags, new Il2CppReferenceArray<Type>(types))
		{
		}

		// Token: 0x06004BD3 RID: 19411 RVA: 0x0001C1A8 File Offset: 0x0001A3A8
		public TraceLoggingEventTypes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170012F3 RID: 4851
		// (get) Token: 0x06004BD4 RID: 19412 RVA: 0x0015EB98 File Offset: 0x0015CD98
		// (set) Token: 0x06004BD5 RID: 19413 RVA: 0x0001C1B1 File Offset: 0x0001A3B1
		public unsafe Il2CppReferenceArray<TraceLoggingTypeInfo> typeInfos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingEventTypes.NativeFieldInfoPtr_typeInfos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TraceLoggingTypeInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingEventTypes.NativeFieldInfoPtr_typeInfos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012F4 RID: 4852
		// (get) Token: 0x06004BD6 RID: 19414 RVA: 0x0015EBC8 File Offset: 0x0015CDC8
		// (set) Token: 0x06004BD7 RID: 19415 RVA: 0x0001C1D0 File Offset: 0x0001A3D0
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingEventTypes.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingEventTypes.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170012F5 RID: 4853
		// (get) Token: 0x06004BD8 RID: 19416 RVA: 0x0015EBF0 File Offset: 0x0015CDF0
		// (set) Token: 0x06004BD9 RID: 19417 RVA: 0x0001C1EF File Offset: 0x0001A3EF
		public unsafe EventTags tags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingEventTypes.NativeFieldInfoPtr_tags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingEventTypes.NativeFieldInfoPtr_tags)) = value;
			}
		}

		// Token: 0x170012F6 RID: 4854
		// (get) Token: 0x06004BDA RID: 19418 RVA: 0x0015EC18 File Offset: 0x0015CE18
		// (set) Token: 0x06004BDB RID: 19419 RVA: 0x0001C20A File Offset: 0x0001A40A
		public unsafe byte level
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingEventTypes.NativeFieldInfoPtr_level);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingEventTypes.NativeFieldInfoPtr_level)) = value;
			}
		}

		// Token: 0x170012F7 RID: 4855
		// (get) Token: 0x06004BDC RID: 19420 RVA: 0x0015EC40 File Offset: 0x0015CE40
		// (set) Token: 0x06004BDD RID: 19421 RVA: 0x0001C225 File Offset: 0x0001A425
		public unsafe byte opcode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingEventTypes.NativeFieldInfoPtr_opcode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingEventTypes.NativeFieldInfoPtr_opcode)) = value;
			}
		}

		// Token: 0x170012F8 RID: 4856
		// (get) Token: 0x06004BDE RID: 19422 RVA: 0x0015EC68 File Offset: 0x0015CE68
		// (set) Token: 0x06004BDF RID: 19423 RVA: 0x0001C240 File Offset: 0x0001A440
		public unsafe EventKeywords keywords
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingEventTypes.NativeFieldInfoPtr_keywords);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingEventTypes.NativeFieldInfoPtr_keywords)) = value;
			}
		}

		// Token: 0x170012F9 RID: 4857
		// (get) Token: 0x06004BE0 RID: 19424 RVA: 0x0015EC90 File Offset: 0x0015CE90
		// (set) Token: 0x06004BE1 RID: 19425 RVA: 0x0001C25B File Offset: 0x0001A45B
		public unsafe Il2CppStructArray<byte> typeMetadata
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingEventTypes.NativeFieldInfoPtr_typeMetadata);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingEventTypes.NativeFieldInfoPtr_typeMetadata), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012FA RID: 4858
		// (get) Token: 0x06004BE2 RID: 19426 RVA: 0x0015ECC0 File Offset: 0x0015CEC0
		// (set) Token: 0x06004BE3 RID: 19427 RVA: 0x0001C27A File Offset: 0x0001A47A
		public unsafe int scratchSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingEventTypes.NativeFieldInfoPtr_scratchSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingEventTypes.NativeFieldInfoPtr_scratchSize)) = value;
			}
		}

		// Token: 0x170012FB RID: 4859
		// (get) Token: 0x06004BE4 RID: 19428 RVA: 0x0015ECE8 File Offset: 0x0015CEE8
		// (set) Token: 0x06004BE5 RID: 19429 RVA: 0x0001C295 File Offset: 0x0001A495
		public unsafe int dataCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingEventTypes.NativeFieldInfoPtr_dataCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingEventTypes.NativeFieldInfoPtr_dataCount)) = value;
			}
		}

		// Token: 0x170012FC RID: 4860
		// (get) Token: 0x06004BE6 RID: 19430 RVA: 0x0015ED10 File Offset: 0x0015CF10
		// (set) Token: 0x06004BE7 RID: 19431 RVA: 0x0001C2B0 File Offset: 0x0001A4B0
		public unsafe int pinCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingEventTypes.NativeFieldInfoPtr_pinCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingEventTypes.NativeFieldInfoPtr_pinCount)) = value;
			}
		}

		// Token: 0x170012FD RID: 4861
		// (get) Token: 0x06004BE8 RID: 19432 RVA: 0x0015ED38 File Offset: 0x0015CF38
		// (set) Token: 0x06004BE9 RID: 19433 RVA: 0x0001C2CB File Offset: 0x0001A4CB
		public ConcurrentSet<KeyValuePair<string, EventTags>, NameInfo> nameInfos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingEventTypes.NativeFieldInfoPtr_nameInfos);
				return new ConcurrentSet<KeyValuePair<string, EventTags>, NameInfo>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConcurrentSet<KeyValuePair<string, EventTags>, NameInfo>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingEventTypes.NativeFieldInfoPtr_nameInfos), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConcurrentSet<KeyValuePair<string, EventTags>, NameInfo>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04003D40 RID: 15680
		private static readonly IntPtr NativeFieldInfoPtr_typeInfos;

		// Token: 0x04003D41 RID: 15681
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04003D42 RID: 15682
		private static readonly IntPtr NativeFieldInfoPtr_tags;

		// Token: 0x04003D43 RID: 15683
		private static readonly IntPtr NativeFieldInfoPtr_level;

		// Token: 0x04003D44 RID: 15684
		private static readonly IntPtr NativeFieldInfoPtr_opcode;

		// Token: 0x04003D45 RID: 15685
		private static readonly IntPtr NativeFieldInfoPtr_keywords;

		// Token: 0x04003D46 RID: 15686
		private static readonly IntPtr NativeFieldInfoPtr_typeMetadata;

		// Token: 0x04003D47 RID: 15687
		private static readonly IntPtr NativeFieldInfoPtr_scratchSize;

		// Token: 0x04003D48 RID: 15688
		private static readonly IntPtr NativeFieldInfoPtr_dataCount;

		// Token: 0x04003D49 RID: 15689
		private static readonly IntPtr NativeFieldInfoPtr_pinCount;

		// Token: 0x04003D4A RID: 15690
		private static readonly IntPtr NativeFieldInfoPtr_nameInfos;

		// Token: 0x04003D4B RID: 15691
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_EventTags_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04003D4C RID: 15692
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_EventTags_Il2CppReferenceArray_1_ParameterInfo_0;

		// Token: 0x04003D4D RID: 15693
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_EventTags_String_Il2CppReferenceArray_1_TraceLoggingTypeInfo_0;

		// Token: 0x04003D4E RID: 15694
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Internal_get_String_0;

		// Token: 0x04003D4F RID: 15695
		private static readonly IntPtr NativeMethodInfoPtr_get_Tags_Internal_get_EventTags_0;

		// Token: 0x04003D50 RID: 15696
		private static readonly IntPtr NativeMethodInfoPtr_GetNameInfo_Internal_NameInfo_String_EventTags_0;

		// Token: 0x04003D51 RID: 15697
		private static readonly IntPtr NativeMethodInfoPtr_MakeArray_Private_Il2CppReferenceArray_1_TraceLoggingTypeInfo_Il2CppReferenceArray_1_ParameterInfo_0;

		// Token: 0x04003D52 RID: 15698
		private static readonly IntPtr NativeMethodInfoPtr_MakeArray_Private_Static_Il2CppReferenceArray_1_TraceLoggingTypeInfo_Il2CppReferenceArray_1_Type_0;
	}
}
