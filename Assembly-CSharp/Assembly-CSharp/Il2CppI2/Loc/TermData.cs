using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppI2.Loc
{
	// Token: 0x02000258 RID: 600
	[Serializable]
	public class TermData : Object
	{
		// Token: 0x060045D1 RID: 17873 RVA: 0x00104AA8 File Offset: 0x00102CA8
		// Note: this type is marked as 'beforefieldinit'.
		static TermData()
		{
			Il2CppClassPointerStore<TermData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "TermData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TermData>.NativeClassPtr);
			TermData.NativeFieldInfoPtr_Term = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermData>.NativeClassPtr, "Term");
			TermData.NativeFieldInfoPtr_TermType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermData>.NativeClassPtr, "TermType");
			TermData.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermData>.NativeClassPtr, "Description");
			TermData.NativeFieldInfoPtr_Languages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermData>.NativeClassPtr, "Languages");
			TermData.NativeFieldInfoPtr_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermData>.NativeClassPtr, "Flags");
			TermData.NativeFieldInfoPtr_Languages_Touch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermData>.NativeClassPtr, "Languages_Touch");
			TermData.NativeMethodInfoPtr_GetTranslation_Public_String_Int32_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermData>.NativeClassPtr, 100670344);
			TermData.NativeMethodInfoPtr_SetTranslation_Public_Void_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermData>.NativeClassPtr, 100670345);
			TermData.NativeMethodInfoPtr_RemoveSpecialization_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermData>.NativeClassPtr, 100670346);
			TermData.NativeMethodInfoPtr_RemoveSpecialization_Public_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermData>.NativeClassPtr, 100670347);
			TermData.NativeMethodInfoPtr_IsAutoTranslated_Public_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermData>.NativeClassPtr, 100670348);
			TermData.NativeMethodInfoPtr_Validate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermData>.NativeClassPtr, 100670349);
			TermData.NativeMethodInfoPtr_IsTerm_Public_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermData>.NativeClassPtr, 100670350);
			TermData.NativeMethodInfoPtr_HasSpecializations_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermData>.NativeClassPtr, 100670351);
			TermData.NativeMethodInfoPtr_GetAllSpecializations_Public_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermData>.NativeClassPtr, 100670352);
			TermData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermData>.NativeClassPtr, 100670353);
		}

		// Token: 0x060045D2 RID: 17874 RVA: 0x00104C18 File Offset: 0x00102E18
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 114017, RefRangeEnd = 114024, XrefRangeStart = 114004, XrefRangeEnd = 114017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetTranslation(int idx, string specialization = null, bool editMode = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref idx;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(specialization);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref editMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermData.NativeMethodInfoPtr_GetTranslation_Public_String_Int32_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060045D3 RID: 17875 RVA: 0x00104C7C File Offset: 0x00102E7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 114049, RefRangeEnd = 114050, XrefRangeStart = 114024, XrefRangeEnd = 114049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTranslation(int idx, string translation, string specialization = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref idx;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(translation);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(specialization);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermData.NativeMethodInfoPtr_SetTranslation_Public_Void_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045D4 RID: 17876 RVA: 0x00104CE0 File Offset: 0x00102EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114050, XrefRangeEnd = 114070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveSpecialization(string specialization)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(specialization);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermData.NativeMethodInfoPtr_RemoveSpecialization_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060045D5 RID: 17877 RVA: 0x00104D24 File Offset: 0x00102F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114070, XrefRangeEnd = 114088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveSpecialization(int idx, string specialization)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref idx;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(specialization);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermData.NativeMethodInfoPtr_RemoveSpecialization_Public_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045D6 RID: 17878 RVA: 0x00104D74 File Offset: 0x00102F74
		[CallerCount(0)]
		public unsafe bool IsAutoTranslated(int idx, bool IsTouch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref idx;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref IsTouch;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermData.NativeMethodInfoPtr_IsAutoTranslated_Public_Boolean_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060045D7 RID: 17879 RVA: 0x00104DCC File Offset: 0x00102FCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 114097, RefRangeEnd = 114098, XrefRangeStart = 114088, XrefRangeEnd = 114097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Validate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermData.NativeMethodInfoPtr_Validate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045D8 RID: 17880 RVA: 0x00104E00 File Offset: 0x00103000
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 114108, RefRangeEnd = 114109, XrefRangeStart = 114098, XrefRangeEnd = 114108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTerm(string name, bool allowCategoryMistmatch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowCategoryMistmatch;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermData.NativeMethodInfoPtr_IsTerm_Public_Boolean_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060045D9 RID: 17881 RVA: 0x00104E5C File Offset: 0x0010305C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114109, XrefRangeEnd = 114113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasSpecializations()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermData.NativeMethodInfoPtr_HasSpecializations_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060045DA RID: 17882 RVA: 0x00104E98 File Offset: 0x00103098
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 114124, RefRangeEnd = 114126, XrefRangeStart = 114113, XrefRangeEnd = 114124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<string> GetAllSpecializations()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermData.NativeMethodInfoPtr_GetAllSpecializations_Public_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x060045DB RID: 17883 RVA: 0x00104ED8 File Offset: 0x001030D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 114138, RefRangeEnd = 114140, XrefRangeStart = 114126, XrefRangeEnd = 114138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TermData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TermData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045DC RID: 17884 RVA: 0x00029ACA File Offset: 0x00027CCA
		public TermData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170019A9 RID: 6569
		// (get) Token: 0x060045DD RID: 17885 RVA: 0x00104F14 File Offset: 0x00103114
		// (set) Token: 0x060045DE RID: 17886 RVA: 0x00029AD3 File Offset: 0x00027CD3
		public unsafe string Term
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermData.NativeFieldInfoPtr_Term);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermData.NativeFieldInfoPtr_Term), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170019AA RID: 6570
		// (get) Token: 0x060045DF RID: 17887 RVA: 0x00104F3C File Offset: 0x0010313C
		// (set) Token: 0x060045E0 RID: 17888 RVA: 0x00029AF2 File Offset: 0x00027CF2
		public unsafe eTermType TermType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermData.NativeFieldInfoPtr_TermType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermData.NativeFieldInfoPtr_TermType)) = value;
			}
		}

		// Token: 0x170019AB RID: 6571
		// (get) Token: 0x060045E1 RID: 17889 RVA: 0x00104F64 File Offset: 0x00103164
		// (set) Token: 0x060045E2 RID: 17890 RVA: 0x00029B0D File Offset: 0x00027D0D
		public unsafe string Description
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermData.NativeFieldInfoPtr_Description);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermData.NativeFieldInfoPtr_Description), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170019AC RID: 6572
		// (get) Token: 0x060045E3 RID: 17891 RVA: 0x00104F8C File Offset: 0x0010318C
		// (set) Token: 0x060045E4 RID: 17892 RVA: 0x00029B2C File Offset: 0x00027D2C
		public unsafe Il2CppStringArray Languages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermData.NativeFieldInfoPtr_Languages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermData.NativeFieldInfoPtr_Languages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019AD RID: 6573
		// (get) Token: 0x060045E5 RID: 17893 RVA: 0x00104FBC File Offset: 0x001031BC
		// (set) Token: 0x060045E6 RID: 17894 RVA: 0x00029B4B File Offset: 0x00027D4B
		public unsafe Il2CppStructArray<byte> Flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermData.NativeFieldInfoPtr_Flags);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermData.NativeFieldInfoPtr_Flags), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019AE RID: 6574
		// (get) Token: 0x060045E7 RID: 17895 RVA: 0x00104FEC File Offset: 0x001031EC
		// (set) Token: 0x060045E8 RID: 17896 RVA: 0x00029B6A File Offset: 0x00027D6A
		public unsafe Il2CppStringArray Languages_Touch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermData.NativeFieldInfoPtr_Languages_Touch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermData.NativeFieldInfoPtr_Languages_Touch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002B57 RID: 11095
		private static readonly IntPtr NativeFieldInfoPtr_Term;

		// Token: 0x04002B58 RID: 11096
		private static readonly IntPtr NativeFieldInfoPtr_TermType;

		// Token: 0x04002B59 RID: 11097
		private static readonly IntPtr NativeFieldInfoPtr_Description;

		// Token: 0x04002B5A RID: 11098
		private static readonly IntPtr NativeFieldInfoPtr_Languages;

		// Token: 0x04002B5B RID: 11099
		private static readonly IntPtr NativeFieldInfoPtr_Flags;

		// Token: 0x04002B5C RID: 11100
		private static readonly IntPtr NativeFieldInfoPtr_Languages_Touch;

		// Token: 0x04002B5D RID: 11101
		private static readonly IntPtr NativeMethodInfoPtr_GetTranslation_Public_String_Int32_String_Boolean_0;

		// Token: 0x04002B5E RID: 11102
		private static readonly IntPtr NativeMethodInfoPtr_SetTranslation_Public_Void_Int32_String_String_0;

		// Token: 0x04002B5F RID: 11103
		private static readonly IntPtr NativeMethodInfoPtr_RemoveSpecialization_Public_Void_String_0;

		// Token: 0x04002B60 RID: 11104
		private static readonly IntPtr NativeMethodInfoPtr_RemoveSpecialization_Public_Void_Int32_String_0;

		// Token: 0x04002B61 RID: 11105
		private static readonly IntPtr NativeMethodInfoPtr_IsAutoTranslated_Public_Boolean_Int32_Boolean_0;

		// Token: 0x04002B62 RID: 11106
		private static readonly IntPtr NativeMethodInfoPtr_Validate_Public_Void_0;

		// Token: 0x04002B63 RID: 11107
		private static readonly IntPtr NativeMethodInfoPtr_IsTerm_Public_Boolean_String_Boolean_0;

		// Token: 0x04002B64 RID: 11108
		private static readonly IntPtr NativeMethodInfoPtr_HasSpecializations_Public_Boolean_0;

		// Token: 0x04002B65 RID: 11109
		private static readonly IntPtr NativeMethodInfoPtr_GetAllSpecializations_Public_List_1_String_0;

		// Token: 0x04002B66 RID: 11110
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
