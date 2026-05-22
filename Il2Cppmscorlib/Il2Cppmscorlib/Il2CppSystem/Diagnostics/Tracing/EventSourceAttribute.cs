using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x0200051A RID: 1306
	public sealed class EventSourceAttribute : Attribute
	{
		// Token: 0x06004CED RID: 19693 RVA: 0x001628E4 File Offset: 0x00160AE4
		// Note: this type is marked as 'beforefieldinit'.
		static EventSourceAttribute()
		{
			Il2CppClassPointerStore<EventSourceAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "EventSourceAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventSourceAttribute>.NativeClassPtr);
			EventSourceAttribute.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSourceAttribute>.NativeClassPtr, "<Name>k__BackingField");
			EventSourceAttribute.NativeFieldInfoPtr__Guid_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSourceAttribute>.NativeClassPtr, "<Guid>k__BackingField");
			EventSourceAttribute.NativeFieldInfoPtr__LocalizationResources_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSourceAttribute>.NativeClassPtr, "<LocalizationResources>k__BackingField");
			EventSourceAttribute.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSourceAttribute>.NativeClassPtr, 100674785);
			EventSourceAttribute.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSourceAttribute>.NativeClassPtr, 100674786);
			EventSourceAttribute.NativeMethodInfoPtr_get_Guid_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSourceAttribute>.NativeClassPtr, 100674787);
			EventSourceAttribute.NativeMethodInfoPtr_set_Guid_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSourceAttribute>.NativeClassPtr, 100674788);
			EventSourceAttribute.NativeMethodInfoPtr_get_LocalizationResources_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSourceAttribute>.NativeClassPtr, 100674789);
			EventSourceAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSourceAttribute>.NativeClassPtr, 100674790);
		}

		// Token: 0x17001363 RID: 4963
		// (get) Token: 0x06004CEE RID: 19694 RVA: 0x001629C8 File Offset: 0x00160BC8
		// (set) Token: 0x06004CEF RID: 19695 RVA: 0x00162A00 File Offset: 0x00160C00
		public unsafe string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSourceAttribute.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSourceAttribute.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001364 RID: 4964
		// (get) Token: 0x06004CF0 RID: 19696 RVA: 0x00162A44 File Offset: 0x00160C44
		// (set) Token: 0x06004CF1 RID: 19697 RVA: 0x00162A7C File Offset: 0x00160C7C
		public unsafe string Guid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSourceAttribute.NativeMethodInfoPtr_get_Guid_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 18562, RefRangeEnd = 18620, XrefRangeStart = 18562, XrefRangeEnd = 18620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSourceAttribute.NativeMethodInfoPtr_set_Guid_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001365 RID: 4965
		// (get) Token: 0x06004CF2 RID: 19698 RVA: 0x00162AC0 File Offset: 0x00160CC0
		public unsafe string LocalizationResources
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSourceAttribute.NativeMethodInfoPtr_get_LocalizationResources_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06004CF3 RID: 19699 RVA: 0x00162AF8 File Offset: 0x00160CF8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventSourceAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventSourceAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSourceAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004CF4 RID: 19700 RVA: 0x0001CA05 File Offset: 0x0001AC05
		public EventSourceAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001360 RID: 4960
		// (get) Token: 0x06004CF5 RID: 19701 RVA: 0x00162B34 File Offset: 0x00160D34
		// (set) Token: 0x06004CF6 RID: 19702 RVA: 0x0001CA0E File Offset: 0x0001AC0E
		public unsafe string _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSourceAttribute.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSourceAttribute.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001361 RID: 4961
		// (get) Token: 0x06004CF7 RID: 19703 RVA: 0x00162B5C File Offset: 0x00160D5C
		// (set) Token: 0x06004CF8 RID: 19704 RVA: 0x0001CA2D File Offset: 0x0001AC2D
		public unsafe string _Guid_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSourceAttribute.NativeFieldInfoPtr__Guid_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSourceAttribute.NativeFieldInfoPtr__Guid_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001362 RID: 4962
		// (get) Token: 0x06004CF9 RID: 19705 RVA: 0x00162B84 File Offset: 0x00160D84
		// (set) Token: 0x06004CFA RID: 19706 RVA: 0x0001CA4C File Offset: 0x0001AC4C
		public unsafe string _LocalizationResources_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSourceAttribute.NativeFieldInfoPtr__LocalizationResources_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSourceAttribute.NativeFieldInfoPtr__LocalizationResources_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003E1D RID: 15901
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x04003E1E RID: 15902
		private static readonly IntPtr NativeFieldInfoPtr__Guid_k__BackingField;

		// Token: 0x04003E1F RID: 15903
		private static readonly IntPtr NativeFieldInfoPtr__LocalizationResources_k__BackingField;

		// Token: 0x04003E20 RID: 15904
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04003E21 RID: 15905
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Public_set_Void_String_0;

		// Token: 0x04003E22 RID: 15906
		private static readonly IntPtr NativeMethodInfoPtr_get_Guid_Public_get_String_0;

		// Token: 0x04003E23 RID: 15907
		private static readonly IntPtr NativeMethodInfoPtr_set_Guid_Public_set_Void_String_0;

		// Token: 0x04003E24 RID: 15908
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalizationResources_Public_get_String_0;

		// Token: 0x04003E25 RID: 15909
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
