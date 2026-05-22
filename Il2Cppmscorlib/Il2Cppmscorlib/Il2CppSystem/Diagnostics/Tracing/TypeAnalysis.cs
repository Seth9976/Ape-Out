using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x0200050E RID: 1294
	public sealed class TypeAnalysis : Object
	{
		// Token: 0x06004C28 RID: 19496 RVA: 0x0015FD78 File Offset: 0x0015DF78
		// Note: this type is marked as 'beforefieldinit'.
		static TypeAnalysis()
		{
			Il2CppClassPointerStore<TypeAnalysis>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "TypeAnalysis");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeAnalysis>.NativeClassPtr);
			TypeAnalysis.NativeFieldInfoPtr_properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeAnalysis>.NativeClassPtr, "properties");
			TypeAnalysis.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeAnalysis>.NativeClassPtr, "name");
			TypeAnalysis.NativeFieldInfoPtr_keywords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeAnalysis>.NativeClassPtr, "keywords");
			TypeAnalysis.NativeFieldInfoPtr_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeAnalysis>.NativeClassPtr, "level");
			TypeAnalysis.NativeFieldInfoPtr_opcode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeAnalysis>.NativeClassPtr, "opcode");
			TypeAnalysis.NativeFieldInfoPtr_tags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeAnalysis>.NativeClassPtr, "tags");
			TypeAnalysis.NativeMethodInfoPtr__ctor_Public_Void_Type_EventDataAttribute_List_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeAnalysis>.NativeClassPtr, 100674693);
		}

		// Token: 0x06004C29 RID: 19497 RVA: 0x0015FE34 File Offset: 0x0015E034
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 240486, RefRangeEnd = 240487, XrefRangeStart = 240427, XrefRangeEnd = 240486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeAnalysis(Type dataType, EventDataAttribute eventAttrib, List<Type> recursionCheck)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeAnalysis>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventAttrib);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(recursionCheck);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeAnalysis.NativeMethodInfoPtr__ctor_Public_Void_Type_EventDataAttribute_List_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C2A RID: 19498 RVA: 0x0001C444 File Offset: 0x0001A644
		public TypeAnalysis(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001317 RID: 4887
		// (get) Token: 0x06004C2B RID: 19499 RVA: 0x0015FEA4 File Offset: 0x0015E0A4
		// (set) Token: 0x06004C2C RID: 19500 RVA: 0x0001C44D File Offset: 0x0001A64D
		public unsafe Il2CppReferenceArray<PropertyAnalysis> properties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeAnalysis.NativeFieldInfoPtr_properties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PropertyAnalysis>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeAnalysis.NativeFieldInfoPtr_properties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001318 RID: 4888
		// (get) Token: 0x06004C2D RID: 19501 RVA: 0x0015FED4 File Offset: 0x0015E0D4
		// (set) Token: 0x06004C2E RID: 19502 RVA: 0x0001C46C File Offset: 0x0001A66C
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeAnalysis.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeAnalysis.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001319 RID: 4889
		// (get) Token: 0x06004C2F RID: 19503 RVA: 0x0015FEFC File Offset: 0x0015E0FC
		// (set) Token: 0x06004C30 RID: 19504 RVA: 0x0001C48B File Offset: 0x0001A68B
		public unsafe EventKeywords keywords
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeAnalysis.NativeFieldInfoPtr_keywords);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeAnalysis.NativeFieldInfoPtr_keywords)) = value;
			}
		}

		// Token: 0x1700131A RID: 4890
		// (get) Token: 0x06004C31 RID: 19505 RVA: 0x0015FF24 File Offset: 0x0015E124
		// (set) Token: 0x06004C32 RID: 19506 RVA: 0x0001C4A6 File Offset: 0x0001A6A6
		public unsafe EventLevel level
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeAnalysis.NativeFieldInfoPtr_level);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeAnalysis.NativeFieldInfoPtr_level)) = value;
			}
		}

		// Token: 0x1700131B RID: 4891
		// (get) Token: 0x06004C33 RID: 19507 RVA: 0x0015FF4C File Offset: 0x0015E14C
		// (set) Token: 0x06004C34 RID: 19508 RVA: 0x0001C4C1 File Offset: 0x0001A6C1
		public unsafe EventOpcode opcode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeAnalysis.NativeFieldInfoPtr_opcode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeAnalysis.NativeFieldInfoPtr_opcode)) = value;
			}
		}

		// Token: 0x1700131C RID: 4892
		// (get) Token: 0x06004C35 RID: 19509 RVA: 0x0015FF74 File Offset: 0x0015E174
		// (set) Token: 0x06004C36 RID: 19510 RVA: 0x0001C4DC File Offset: 0x0001A6DC
		public unsafe EventTags tags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeAnalysis.NativeFieldInfoPtr_tags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeAnalysis.NativeFieldInfoPtr_tags)) = value;
			}
		}

		// Token: 0x04003D80 RID: 15744
		private static readonly IntPtr NativeFieldInfoPtr_properties;

		// Token: 0x04003D81 RID: 15745
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04003D82 RID: 15746
		private static readonly IntPtr NativeFieldInfoPtr_keywords;

		// Token: 0x04003D83 RID: 15747
		private static readonly IntPtr NativeFieldInfoPtr_level;

		// Token: 0x04003D84 RID: 15748
		private static readonly IntPtr NativeFieldInfoPtr_opcode;

		// Token: 0x04003D85 RID: 15749
		private static readonly IntPtr NativeFieldInfoPtr_tags;

		// Token: 0x04003D86 RID: 15750
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_EventDataAttribute_List_1_Type_0;
	}
}
