using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004CB RID: 1227
	public class EventFieldAttribute : Attribute
	{
		// Token: 0x0600497C RID: 18812 RVA: 0x00154034 File Offset: 0x00152234
		// Note: this type is marked as 'beforefieldinit'.
		static EventFieldAttribute()
		{
			Il2CppClassPointerStore<EventFieldAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "EventFieldAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventFieldAttribute>.NativeClassPtr);
			EventFieldAttribute.NativeFieldInfoPtr__Tags_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventFieldAttribute>.NativeClassPtr, "<Tags>k__BackingField");
			EventFieldAttribute.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventFieldAttribute>.NativeClassPtr, "<Name>k__BackingField");
			EventFieldAttribute.NativeFieldInfoPtr__Format_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventFieldAttribute>.NativeClassPtr, "<Format>k__BackingField");
			EventFieldAttribute.NativeMethodInfoPtr_get_Tags_Public_get_EventFieldTags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventFieldAttribute>.NativeClassPtr, 100674280);
			EventFieldAttribute.NativeMethodInfoPtr_get_Name_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventFieldAttribute>.NativeClassPtr, 100674281);
			EventFieldAttribute.NativeMethodInfoPtr_get_Format_Public_get_EventFieldFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventFieldAttribute>.NativeClassPtr, 100674282);
		}

		// Token: 0x170012A4 RID: 4772
		// (get) Token: 0x0600497D RID: 18813 RVA: 0x001540DC File Offset: 0x001522DC
		public unsafe EventFieldTags Tags
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventFieldAttribute.NativeMethodInfoPtr_get_Tags_Public_get_EventFieldTags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170012A5 RID: 4773
		// (get) Token: 0x0600497E RID: 18814 RVA: 0x00154118 File Offset: 0x00152318
		public unsafe string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventFieldAttribute.NativeMethodInfoPtr_get_Name_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170012A6 RID: 4774
		// (get) Token: 0x0600497F RID: 18815 RVA: 0x00154150 File Offset: 0x00152350
		public unsafe EventFieldFormat Format
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventFieldAttribute.NativeMethodInfoPtr_get_Format_Public_get_EventFieldFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004980 RID: 18816 RVA: 0x0001B833 File Offset: 0x00019A33
		public EventFieldAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170012A1 RID: 4769
		// (get) Token: 0x06004981 RID: 18817 RVA: 0x0015418C File Offset: 0x0015238C
		// (set) Token: 0x06004982 RID: 18818 RVA: 0x0001B83C File Offset: 0x00019A3C
		public unsafe EventFieldTags _Tags_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventFieldAttribute.NativeFieldInfoPtr__Tags_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventFieldAttribute.NativeFieldInfoPtr__Tags_k__BackingField)) = value;
			}
		}

		// Token: 0x170012A2 RID: 4770
		// (get) Token: 0x06004983 RID: 18819 RVA: 0x001541B4 File Offset: 0x001523B4
		// (set) Token: 0x06004984 RID: 18820 RVA: 0x0001B857 File Offset: 0x00019A57
		public unsafe string _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventFieldAttribute.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventFieldAttribute.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170012A3 RID: 4771
		// (get) Token: 0x06004985 RID: 18821 RVA: 0x001541DC File Offset: 0x001523DC
		// (set) Token: 0x06004986 RID: 18822 RVA: 0x0001B876 File Offset: 0x00019A76
		public unsafe EventFieldFormat _Format_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventFieldAttribute.NativeFieldInfoPtr__Format_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventFieldAttribute.NativeFieldInfoPtr__Format_k__BackingField)) = value;
			}
		}

		// Token: 0x04003B74 RID: 15220
		private static readonly IntPtr NativeFieldInfoPtr__Tags_k__BackingField;

		// Token: 0x04003B75 RID: 15221
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x04003B76 RID: 15222
		private static readonly IntPtr NativeFieldInfoPtr__Format_k__BackingField;

		// Token: 0x04003B77 RID: 15223
		private static readonly IntPtr NativeMethodInfoPtr_get_Tags_Public_get_EventFieldTags_0;

		// Token: 0x04003B78 RID: 15224
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Internal_get_String_0;

		// Token: 0x04003B79 RID: 15225
		private static readonly IntPtr NativeMethodInfoPtr_get_Format_Public_get_EventFieldFormat_0;
	}
}
