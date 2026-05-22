using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004C9 RID: 1225
	public class EventDataAttribute : Attribute
	{
		// Token: 0x0600496B RID: 18795 RVA: 0x00153D4C File Offset: 0x00151F4C
		// Note: this type is marked as 'beforefieldinit'.
		static EventDataAttribute()
		{
			Il2CppClassPointerStore<EventDataAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "EventDataAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventDataAttribute>.NativeClassPtr);
			EventDataAttribute.NativeFieldInfoPtr_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDataAttribute>.NativeClassPtr, "level");
			EventDataAttribute.NativeFieldInfoPtr_opcode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDataAttribute>.NativeClassPtr, "opcode");
			EventDataAttribute.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDataAttribute>.NativeClassPtr, "<Name>k__BackingField");
			EventDataAttribute.NativeFieldInfoPtr__Keywords_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDataAttribute>.NativeClassPtr, "<Keywords>k__BackingField");
			EventDataAttribute.NativeFieldInfoPtr__Tags_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDataAttribute>.NativeClassPtr, "<Tags>k__BackingField");
			EventDataAttribute.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDataAttribute>.NativeClassPtr, 100674275);
			EventDataAttribute.NativeMethodInfoPtr_get_Level_Internal_get_EventLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDataAttribute>.NativeClassPtr, 100674276);
			EventDataAttribute.NativeMethodInfoPtr_get_Opcode_Internal_get_EventOpcode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDataAttribute>.NativeClassPtr, 100674277);
			EventDataAttribute.NativeMethodInfoPtr_get_Keywords_Internal_get_EventKeywords_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDataAttribute>.NativeClassPtr, 100674278);
			EventDataAttribute.NativeMethodInfoPtr_get_Tags_Internal_get_EventTags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDataAttribute>.NativeClassPtr, 100674279);
		}

		// Token: 0x1700129C RID: 4764
		// (get) Token: 0x0600496C RID: 18796 RVA: 0x00153E44 File Offset: 0x00152044
		public unsafe string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDataAttribute.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700129D RID: 4765
		// (get) Token: 0x0600496D RID: 18797 RVA: 0x00153E7C File Offset: 0x0015207C
		public unsafe EventLevel Level
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDataAttribute.NativeMethodInfoPtr_get_Level_Internal_get_EventLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700129E RID: 4766
		// (get) Token: 0x0600496E RID: 18798 RVA: 0x00153EB8 File Offset: 0x001520B8
		public unsafe EventOpcode Opcode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDataAttribute.NativeMethodInfoPtr_get_Opcode_Internal_get_EventOpcode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700129F RID: 4767
		// (get) Token: 0x0600496F RID: 18799 RVA: 0x00153EF4 File Offset: 0x001520F4
		public unsafe EventKeywords Keywords
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDataAttribute.NativeMethodInfoPtr_get_Keywords_Internal_get_EventKeywords_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170012A0 RID: 4768
		// (get) Token: 0x06004970 RID: 18800 RVA: 0x00153F30 File Offset: 0x00152130
		public unsafe EventTags Tags
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDataAttribute.NativeMethodInfoPtr_get_Tags_Internal_get_EventTags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004971 RID: 18801 RVA: 0x0001B79F File Offset: 0x0001999F
		public EventDataAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001297 RID: 4759
		// (get) Token: 0x06004972 RID: 18802 RVA: 0x00153F6C File Offset: 0x0015216C
		// (set) Token: 0x06004973 RID: 18803 RVA: 0x0001B7A8 File Offset: 0x000199A8
		public unsafe EventLevel level
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDataAttribute.NativeFieldInfoPtr_level);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDataAttribute.NativeFieldInfoPtr_level)) = value;
			}
		}

		// Token: 0x17001298 RID: 4760
		// (get) Token: 0x06004974 RID: 18804 RVA: 0x00153F94 File Offset: 0x00152194
		// (set) Token: 0x06004975 RID: 18805 RVA: 0x0001B7C3 File Offset: 0x000199C3
		public unsafe EventOpcode opcode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDataAttribute.NativeFieldInfoPtr_opcode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDataAttribute.NativeFieldInfoPtr_opcode)) = value;
			}
		}

		// Token: 0x17001299 RID: 4761
		// (get) Token: 0x06004976 RID: 18806 RVA: 0x00153FBC File Offset: 0x001521BC
		// (set) Token: 0x06004977 RID: 18807 RVA: 0x0001B7DE File Offset: 0x000199DE
		public unsafe string _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDataAttribute.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDataAttribute.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700129A RID: 4762
		// (get) Token: 0x06004978 RID: 18808 RVA: 0x00153FE4 File Offset: 0x001521E4
		// (set) Token: 0x06004979 RID: 18809 RVA: 0x0001B7FD File Offset: 0x000199FD
		public unsafe EventKeywords _Keywords_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDataAttribute.NativeFieldInfoPtr__Keywords_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDataAttribute.NativeFieldInfoPtr__Keywords_k__BackingField)) = value;
			}
		}

		// Token: 0x1700129B RID: 4763
		// (get) Token: 0x0600497A RID: 18810 RVA: 0x0015400C File Offset: 0x0015220C
		// (set) Token: 0x0600497B RID: 18811 RVA: 0x0001B818 File Offset: 0x00019A18
		public unsafe EventTags _Tags_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDataAttribute.NativeFieldInfoPtr__Tags_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDataAttribute.NativeFieldInfoPtr__Tags_k__BackingField)) = value;
			}
		}

		// Token: 0x04003B68 RID: 15208
		private static readonly IntPtr NativeFieldInfoPtr_level;

		// Token: 0x04003B69 RID: 15209
		private static readonly IntPtr NativeFieldInfoPtr_opcode;

		// Token: 0x04003B6A RID: 15210
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x04003B6B RID: 15211
		private static readonly IntPtr NativeFieldInfoPtr__Keywords_k__BackingField;

		// Token: 0x04003B6C RID: 15212
		private static readonly IntPtr NativeFieldInfoPtr__Tags_k__BackingField;

		// Token: 0x04003B6D RID: 15213
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04003B6E RID: 15214
		private static readonly IntPtr NativeMethodInfoPtr_get_Level_Internal_get_EventLevel_0;

		// Token: 0x04003B6F RID: 15215
		private static readonly IntPtr NativeMethodInfoPtr_get_Opcode_Internal_get_EventOpcode_0;

		// Token: 0x04003B70 RID: 15216
		private static readonly IntPtr NativeMethodInfoPtr_get_Keywords_Internal_get_EventKeywords_0;

		// Token: 0x04003B71 RID: 15217
		private static readonly IntPtr NativeMethodInfoPtr_get_Tags_Internal_get_EventTags_0;
	}
}
