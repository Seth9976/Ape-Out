using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x0200023A RID: 570
	[Serializable]
	public class EraInfo : Object
	{
		// Token: 0x06002690 RID: 9872 RVA: 0x000CF948 File Offset: 0x000CDB48
		// Note: this type is marked as 'beforefieldinit'.
		static EraInfo()
		{
			Il2CppClassPointerStore<EraInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "EraInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EraInfo>.NativeClassPtr);
			EraInfo.NativeFieldInfoPtr_era = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EraInfo>.NativeClassPtr, "era");
			EraInfo.NativeFieldInfoPtr_ticks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EraInfo>.NativeClassPtr, "ticks");
			EraInfo.NativeFieldInfoPtr_yearOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EraInfo>.NativeClassPtr, "yearOffset");
			EraInfo.NativeFieldInfoPtr_minEraYear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EraInfo>.NativeClassPtr, "minEraYear");
			EraInfo.NativeFieldInfoPtr_maxEraYear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EraInfo>.NativeClassPtr, "maxEraYear");
			EraInfo.NativeFieldInfoPtr_eraName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EraInfo>.NativeClassPtr, "eraName");
			EraInfo.NativeFieldInfoPtr_abbrevEraName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EraInfo>.NativeClassPtr, "abbrevEraName");
			EraInfo.NativeFieldInfoPtr_englishEraName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EraInfo>.NativeClassPtr, "englishEraName");
			EraInfo.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EraInfo>.NativeClassPtr, 100669663);
			EraInfo.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EraInfo>.NativeClassPtr, 100669664);
		}

		// Token: 0x06002691 RID: 9873 RVA: 0x000CFA40 File Offset: 0x000CDC40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196006, XrefRangeEnd = 196010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EraInfo(int era, int startYear, int startMonth, int startDay, int yearOffset, int minEraYear, int maxEraYear)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EraInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref era;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startYear;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startMonth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startDay;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yearOffset;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minEraYear;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxEraYear;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EraInfo.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002692 RID: 9874 RVA: 0x000CFADC File Offset: 0x000CDCDC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 196014, RefRangeEnd = 196018, XrefRangeStart = 196010, XrefRangeEnd = 196014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EraInfo(int era, int startYear, int startMonth, int startDay, int yearOffset, int minEraYear, int maxEraYear, string eraName, string abbrevEraName, string englishEraName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EraInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref era;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startYear;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startMonth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startDay;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yearOffset;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minEraYear;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxEraYear;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(eraName);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(abbrevEraName);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(englishEraName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EraInfo.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002693 RID: 9875 RVA: 0x0000D0D0 File Offset: 0x0000B2D0
		public EraInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x06002694 RID: 9876 RVA: 0x000CFBB4 File Offset: 0x000CDDB4
		// (set) Token: 0x06002695 RID: 9877 RVA: 0x0000D0D9 File Offset: 0x0000B2D9
		public unsafe int era
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EraInfo.NativeFieldInfoPtr_era);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EraInfo.NativeFieldInfoPtr_era)) = value;
			}
		}

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x06002696 RID: 9878 RVA: 0x000CFBDC File Offset: 0x000CDDDC
		// (set) Token: 0x06002697 RID: 9879 RVA: 0x0000D0F4 File Offset: 0x0000B2F4
		public unsafe long ticks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EraInfo.NativeFieldInfoPtr_ticks);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EraInfo.NativeFieldInfoPtr_ticks)) = value;
			}
		}

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x06002698 RID: 9880 RVA: 0x000CFC04 File Offset: 0x000CDE04
		// (set) Token: 0x06002699 RID: 9881 RVA: 0x0000D10F File Offset: 0x0000B30F
		public unsafe int yearOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EraInfo.NativeFieldInfoPtr_yearOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EraInfo.NativeFieldInfoPtr_yearOffset)) = value;
			}
		}

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x0600269A RID: 9882 RVA: 0x000CFC2C File Offset: 0x000CDE2C
		// (set) Token: 0x0600269B RID: 9883 RVA: 0x0000D12A File Offset: 0x0000B32A
		public unsafe int minEraYear
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EraInfo.NativeFieldInfoPtr_minEraYear);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EraInfo.NativeFieldInfoPtr_minEraYear)) = value;
			}
		}

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x0600269C RID: 9884 RVA: 0x000CFC54 File Offset: 0x000CDE54
		// (set) Token: 0x0600269D RID: 9885 RVA: 0x0000D145 File Offset: 0x0000B345
		public unsafe int maxEraYear
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EraInfo.NativeFieldInfoPtr_maxEraYear);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EraInfo.NativeFieldInfoPtr_maxEraYear)) = value;
			}
		}

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x0600269E RID: 9886 RVA: 0x000CFC7C File Offset: 0x000CDE7C
		// (set) Token: 0x0600269F RID: 9887 RVA: 0x0000D160 File Offset: 0x0000B360
		public unsafe string eraName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EraInfo.NativeFieldInfoPtr_eraName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EraInfo.NativeFieldInfoPtr_eraName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x060026A0 RID: 9888 RVA: 0x000CFCA4 File Offset: 0x000CDEA4
		// (set) Token: 0x060026A1 RID: 9889 RVA: 0x0000D17F File Offset: 0x0000B37F
		public unsafe string abbrevEraName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EraInfo.NativeFieldInfoPtr_abbrevEraName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EraInfo.NativeFieldInfoPtr_abbrevEraName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x060026A2 RID: 9890 RVA: 0x000CFCCC File Offset: 0x000CDECC
		// (set) Token: 0x060026A3 RID: 9891 RVA: 0x0000D19E File Offset: 0x0000B39E
		public unsafe string englishEraName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EraInfo.NativeFieldInfoPtr_englishEraName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EraInfo.NativeFieldInfoPtr_englishEraName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400226A RID: 8810
		private static readonly IntPtr NativeFieldInfoPtr_era;

		// Token: 0x0400226B RID: 8811
		private static readonly IntPtr NativeFieldInfoPtr_ticks;

		// Token: 0x0400226C RID: 8812
		private static readonly IntPtr NativeFieldInfoPtr_yearOffset;

		// Token: 0x0400226D RID: 8813
		private static readonly IntPtr NativeFieldInfoPtr_minEraYear;

		// Token: 0x0400226E RID: 8814
		private static readonly IntPtr NativeFieldInfoPtr_maxEraYear;

		// Token: 0x0400226F RID: 8815
		private static readonly IntPtr NativeFieldInfoPtr_eraName;

		// Token: 0x04002270 RID: 8816
		private static readonly IntPtr NativeFieldInfoPtr_abbrevEraName;

		// Token: 0x04002271 RID: 8817
		private static readonly IntPtr NativeFieldInfoPtr_englishEraName;

		// Token: 0x04002272 RID: 8818
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x04002273 RID: 8819
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_String_String_String_0;
	}
}
