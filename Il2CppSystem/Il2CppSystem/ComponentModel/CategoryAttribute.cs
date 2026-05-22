using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000072 RID: 114
	public class CategoryAttribute : Attribute
	{
		// Token: 0x060007F5 RID: 2037 RVA: 0x0002ECE8 File Offset: 0x0002CEE8
		// Note: this type is marked as 'beforefieldinit'.
		static CategoryAttribute()
		{
			Il2CppClassPointerStore<CategoryAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "CategoryAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CategoryAttribute>.NativeClassPtr);
			CategoryAttribute.NativeFieldInfoPtr_localized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CategoryAttribute>.NativeClassPtr, "localized");
			CategoryAttribute.NativeFieldInfoPtr_categoryValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CategoryAttribute>.NativeClassPtr, "categoryValue");
			CategoryAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CategoryAttribute>.NativeClassPtr, 100664460);
			CategoryAttribute.NativeMethodInfoPtr_get_Category_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CategoryAttribute>.NativeClassPtr, 100664461);
			CategoryAttribute.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CategoryAttribute>.NativeClassPtr, 100664462);
			CategoryAttribute.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CategoryAttribute>.NativeClassPtr, 100664463);
			CategoryAttribute.NativeMethodInfoPtr_GetLocalizedString_Protected_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CategoryAttribute>.NativeClassPtr, 100664464);
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x0002EDA4 File Offset: 0x0002CFA4
		[CallerCount(0)]
		public unsafe CategoryAttribute(string category)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CategoryAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(category);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CategoryAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x060007F7 RID: 2039 RVA: 0x0002EDF0 File Offset: 0x0002CFF0
		public unsafe string Category
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372702, XrefRangeEnd = 372703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CategoryAttribute.NativeMethodInfoPtr_get_Category_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x0002EE28 File Offset: 0x0002D028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372703, XrefRangeEnd = 372708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CategoryAttribute.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x0002EE80 File Offset: 0x0002D080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372708, XrefRangeEnd = 372710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CategoryAttribute.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x0002EEC8 File Offset: 0x0002D0C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372710, XrefRangeEnd = 372729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetLocalizedString(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CategoryAttribute.NativeMethodInfoPtr_GetLocalizedString_Protected_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x00005205 File Offset: 0x00003405
		public CategoryAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x060007FC RID: 2044 RVA: 0x0002EF1C File Offset: 0x0002D11C
		// (set) Token: 0x060007FD RID: 2045 RVA: 0x0000520E File Offset: 0x0000340E
		public unsafe bool localized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CategoryAttribute.NativeFieldInfoPtr_localized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CategoryAttribute.NativeFieldInfoPtr_localized)) = value;
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x060007FE RID: 2046 RVA: 0x0002EF44 File Offset: 0x0002D144
		// (set) Token: 0x060007FF RID: 2047 RVA: 0x00005229 File Offset: 0x00003429
		public unsafe string categoryValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CategoryAttribute.NativeFieldInfoPtr_categoryValue);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CategoryAttribute.NativeFieldInfoPtr_categoryValue), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040005EA RID: 1514
		private static readonly IntPtr NativeFieldInfoPtr_localized;

		// Token: 0x040005EB RID: 1515
		private static readonly IntPtr NativeFieldInfoPtr_categoryValue;

		// Token: 0x040005EC RID: 1516
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040005ED RID: 1517
		private static readonly IntPtr NativeMethodInfoPtr_get_Category_Public_get_String_0;

		// Token: 0x040005EE RID: 1518
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040005EF RID: 1519
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040005F0 RID: 1520
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedString_Protected_Virtual_New_String_String_0;
	}
}
