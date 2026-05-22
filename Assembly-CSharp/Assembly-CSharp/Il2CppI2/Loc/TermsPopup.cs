using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppI2.Loc
{
	// Token: 0x02000259 RID: 601
	public class TermsPopup : PropertyAttribute
	{
		// Token: 0x060045E9 RID: 17897 RVA: 0x0010501C File Offset: 0x0010321C
		// Note: this type is marked as 'beforefieldinit'.
		static TermsPopup()
		{
			Il2CppClassPointerStore<TermsPopup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "TermsPopup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TermsPopup>.NativeClassPtr);
			TermsPopup.NativeFieldInfoPtr__Filter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermsPopup>.NativeClassPtr, "<Filter>k__BackingField");
			TermsPopup.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermsPopup>.NativeClassPtr, 100670354);
			TermsPopup.NativeMethodInfoPtr_get_Filter_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermsPopup>.NativeClassPtr, 100670355);
			TermsPopup.NativeMethodInfoPtr_set_Filter_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermsPopup>.NativeClassPtr, 100670356);
		}

		// Token: 0x060045EA RID: 17898 RVA: 0x0010509C File Offset: 0x0010329C
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TermsPopup(string filter = "")
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TermsPopup>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(filter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermsPopup.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170019B0 RID: 6576
		// (get) Token: 0x060045EB RID: 17899 RVA: 0x001050E8 File Offset: 0x001032E8
		// (set) Token: 0x060045EC RID: 17900 RVA: 0x00105120 File Offset: 0x00103320
		public unsafe string Filter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermsPopup.NativeMethodInfoPtr_get_Filter_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermsPopup.NativeMethodInfoPtr_set_Filter_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060045ED RID: 17901 RVA: 0x00029B89 File Offset: 0x00027D89
		public TermsPopup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170019AF RID: 6575
		// (get) Token: 0x060045EE RID: 17902 RVA: 0x00105164 File Offset: 0x00103364
		// (set) Token: 0x060045EF RID: 17903 RVA: 0x00029B92 File Offset: 0x00027D92
		public unsafe string _Filter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermsPopup.NativeFieldInfoPtr__Filter_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermsPopup.NativeFieldInfoPtr__Filter_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002B67 RID: 11111
		private static readonly IntPtr NativeFieldInfoPtr__Filter_k__BackingField;

		// Token: 0x04002B68 RID: 11112
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04002B69 RID: 11113
		private static readonly IntPtr NativeMethodInfoPtr_get_Filter_Public_get_String_0;

		// Token: 0x04002B6A RID: 11114
		private static readonly IntPtr NativeMethodInfoPtr_set_Filter_Private_set_Void_String_0;
	}
}
