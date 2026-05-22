using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppI2.Loc
{
	// Token: 0x02000261 RID: 609
	[Serializable]
	public sealed class LocalizedString : ValueType
	{
		// Token: 0x06004630 RID: 17968 RVA: 0x00106040 File Offset: 0x00104240
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizedString()
		{
			Il2CppClassPointerStore<LocalizedString>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "LocalizedString");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr);
			LocalizedString.NativeFieldInfoPtr_mTerm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, "mTerm");
			LocalizedString.NativeFieldInfoPtr_mRTL_IgnoreArabicFix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, "mRTL_IgnoreArabicFix");
			LocalizedString.NativeFieldInfoPtr_mRTL_MaxLineLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, "mRTL_MaxLineLength");
			LocalizedString.NativeFieldInfoPtr_mRTL_ConvertNumbers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, "mRTL_ConvertNumbers");
			LocalizedString.NativeFieldInfoPtr_m_DontLocalizeParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, "m_DontLocalizeParameters");
			LocalizedString.NativeMethodInfoPtr_op_Implicit_Public_Static_String_LocalizedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100670399);
			LocalizedString.NativeMethodInfoPtr_op_Implicit_Public_Static_LocalizedString_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100670400);
			LocalizedString.NativeMethodInfoPtr__ctor_Public_Void_LocalizedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100670401);
			LocalizedString.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100670402);
		}

		// Token: 0x06004631 RID: 17969 RVA: 0x00106124 File Offset: 0x00104324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114615, XrefRangeEnd = 114616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator string(LocalizedString s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(s));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_op_Implicit_Public_Static_String_LocalizedString_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06004632 RID: 17970 RVA: 0x00106168 File Offset: 0x00104368
		[CallerCount(0)]
		public new unsafe static implicit operator LocalizedString(string term)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(term);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_op_Implicit_Public_Static_LocalizedString_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new LocalizedString(intPtr);
			}
		}

		// Token: 0x06004633 RID: 17971 RVA: 0x001061A4 File Offset: 0x001043A4
		[CallerCount(0)]
		public unsafe LocalizedString(LocalizedString str)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(str));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr__ctor_Public_Void_LocalizedString_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004634 RID: 17972 RVA: 0x001061FC File Offset: 0x001043FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 114621, RefRangeEnd = 114623, XrefRangeStart = 114616, XrefRangeEnd = 114621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004635 RID: 17973 RVA: 0x00029CC0 File Offset: 0x00027EC0
		public LocalizedString(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06004636 RID: 17974 RVA: 0x00029CC9 File Offset: 0x00027EC9
		public LocalizedString()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr))
		{
		}

		// Token: 0x170019B9 RID: 6585
		// (get) Token: 0x06004637 RID: 17975 RVA: 0x00106238 File Offset: 0x00104438
		// (set) Token: 0x06004638 RID: 17976 RVA: 0x00029CDB File Offset: 0x00027EDB
		public unsafe string mTerm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.NativeFieldInfoPtr_mTerm);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.NativeFieldInfoPtr_mTerm), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170019BA RID: 6586
		// (get) Token: 0x06004639 RID: 17977 RVA: 0x00106260 File Offset: 0x00104460
		// (set) Token: 0x0600463A RID: 17978 RVA: 0x00029CFA File Offset: 0x00027EFA
		public unsafe bool mRTL_IgnoreArabicFix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.NativeFieldInfoPtr_mRTL_IgnoreArabicFix);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.NativeFieldInfoPtr_mRTL_IgnoreArabicFix)) = value;
			}
		}

		// Token: 0x170019BB RID: 6587
		// (get) Token: 0x0600463B RID: 17979 RVA: 0x00106288 File Offset: 0x00104488
		// (set) Token: 0x0600463C RID: 17980 RVA: 0x00029D15 File Offset: 0x00027F15
		public unsafe int mRTL_MaxLineLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.NativeFieldInfoPtr_mRTL_MaxLineLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.NativeFieldInfoPtr_mRTL_MaxLineLength)) = value;
			}
		}

		// Token: 0x170019BC RID: 6588
		// (get) Token: 0x0600463D RID: 17981 RVA: 0x001062B0 File Offset: 0x001044B0
		// (set) Token: 0x0600463E RID: 17982 RVA: 0x00029D30 File Offset: 0x00027F30
		public unsafe bool mRTL_ConvertNumbers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.NativeFieldInfoPtr_mRTL_ConvertNumbers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.NativeFieldInfoPtr_mRTL_ConvertNumbers)) = value;
			}
		}

		// Token: 0x170019BD RID: 6589
		// (get) Token: 0x0600463F RID: 17983 RVA: 0x001062D8 File Offset: 0x001044D8
		// (set) Token: 0x06004640 RID: 17984 RVA: 0x00029D4B File Offset: 0x00027F4B
		public unsafe bool m_DontLocalizeParameters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.NativeFieldInfoPtr_m_DontLocalizeParameters);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.NativeFieldInfoPtr_m_DontLocalizeParameters)) = value;
			}
		}

		// Token: 0x04002B96 RID: 11158
		private static readonly IntPtr NativeFieldInfoPtr_mTerm;

		// Token: 0x04002B97 RID: 11159
		private static readonly IntPtr NativeFieldInfoPtr_mRTL_IgnoreArabicFix;

		// Token: 0x04002B98 RID: 11160
		private static readonly IntPtr NativeFieldInfoPtr_mRTL_MaxLineLength;

		// Token: 0x04002B99 RID: 11161
		private static readonly IntPtr NativeFieldInfoPtr_mRTL_ConvertNumbers;

		// Token: 0x04002B9A RID: 11162
		private static readonly IntPtr NativeFieldInfoPtr_m_DontLocalizeParameters;

		// Token: 0x04002B9B RID: 11163
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_String_LocalizedString_0;

		// Token: 0x04002B9C RID: 11164
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_LocalizedString_String_0;

		// Token: 0x04002B9D RID: 11165
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_LocalizedString_0;

		// Token: 0x04002B9E RID: 11166
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
