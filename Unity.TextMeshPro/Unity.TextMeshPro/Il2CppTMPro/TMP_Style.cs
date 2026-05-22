using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppTMPro
{
	// Token: 0x02000042 RID: 66
	[Serializable]
	public class TMP_Style : Object
	{
		// Token: 0x0600073A RID: 1850 RVA: 0x00021D58 File Offset: 0x0001FF58
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_Style()
		{
			Il2CppClassPointerStore<TMP_Style>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_Style");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Style>.NativeClassPtr);
			TMP_Style.NativeFieldInfoPtr_k_NormalStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Style>.NativeClassPtr, "k_NormalStyle");
			TMP_Style.NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Style>.NativeClassPtr, "m_Name");
			TMP_Style.NativeFieldInfoPtr_m_HashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Style>.NativeClassPtr, "m_HashCode");
			TMP_Style.NativeFieldInfoPtr_m_OpeningDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Style>.NativeClassPtr, "m_OpeningDefinition");
			TMP_Style.NativeFieldInfoPtr_m_ClosingDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Style>.NativeClassPtr, "m_ClosingDefinition");
			TMP_Style.NativeFieldInfoPtr_m_OpeningTagArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Style>.NativeClassPtr, "m_OpeningTagArray");
			TMP_Style.NativeFieldInfoPtr_m_ClosingTagArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Style>.NativeClassPtr, "m_ClosingTagArray");
			TMP_Style.NativeFieldInfoPtr_m_OpeningTagUnicodeArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Style>.NativeClassPtr, "m_OpeningTagUnicodeArray");
			TMP_Style.NativeFieldInfoPtr_m_ClosingTagUnicodeArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Style>.NativeClassPtr, "m_ClosingTagUnicodeArray");
			TMP_Style.NativeMethodInfoPtr_get_NormalStyle_Public_Static_get_TMP_Style_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Style>.NativeClassPtr, 100664137);
			TMP_Style.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Style>.NativeClassPtr, 100664138);
			TMP_Style.NativeMethodInfoPtr_set_name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Style>.NativeClassPtr, 100664139);
			TMP_Style.NativeMethodInfoPtr_get_hashCode_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Style>.NativeClassPtr, 100664140);
			TMP_Style.NativeMethodInfoPtr_set_hashCode_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Style>.NativeClassPtr, 100664141);
			TMP_Style.NativeMethodInfoPtr_get_styleOpeningDefinition_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Style>.NativeClassPtr, 100664142);
			TMP_Style.NativeMethodInfoPtr_get_styleClosingDefinition_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Style>.NativeClassPtr, 100664143);
			TMP_Style.NativeMethodInfoPtr_get_styleOpeningTagArray_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Style>.NativeClassPtr, 100664144);
			TMP_Style.NativeMethodInfoPtr_get_styleClosingTagArray_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Style>.NativeClassPtr, 100664145);
			TMP_Style.NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Style>.NativeClassPtr, 100664146);
			TMP_Style.NativeMethodInfoPtr_RefreshStyle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Style>.NativeClassPtr, 100664147);
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x0600073B RID: 1851 RVA: 0x00021F18 File Offset: 0x00020118
		public unsafe static TMP_Style NormalStyle
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459678, XrefRangeEnd = 459688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Style.NativeMethodInfoPtr_get_NormalStyle_Public_Static_get_TMP_Style_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Style>(intPtr3) : null;
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x0600073C RID: 1852 RVA: 0x00021F4C File Offset: 0x0002014C
		// (set) Token: 0x0600073D RID: 1853 RVA: 0x00021F84 File Offset: 0x00020184
		public unsafe string name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Style.NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Style.NativeMethodInfoPtr_set_name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x0600073E RID: 1854 RVA: 0x00021FC8 File Offset: 0x000201C8
		// (set) Token: 0x0600073F RID: 1855 RVA: 0x00022004 File Offset: 0x00020204
		public unsafe int hashCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Style.NativeMethodInfoPtr_get_hashCode_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Style.NativeMethodInfoPtr_set_hashCode_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000740 RID: 1856 RVA: 0x00022044 File Offset: 0x00020244
		public unsafe string styleOpeningDefinition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Style.NativeMethodInfoPtr_get_styleOpeningDefinition_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000741 RID: 1857 RVA: 0x0002207C File Offset: 0x0002027C
		public unsafe string styleClosingDefinition
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Style.NativeMethodInfoPtr_get_styleClosingDefinition_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000742 RID: 1858 RVA: 0x000220B4 File Offset: 0x000202B4
		public unsafe Il2CppStructArray<int> styleOpeningTagArray
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Style.NativeMethodInfoPtr_get_styleOpeningTagArray_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000743 RID: 1859 RVA: 0x000220F4 File Offset: 0x000202F4
		public unsafe Il2CppStructArray<int> styleClosingTagArray
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 621, RefRangeEnd = 626, XrefRangeStart = 621, XrefRangeEnd = 626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Style.NativeMethodInfoPtr_get_styleClosingTagArray_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x00022134 File Offset: 0x00020334
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 459693, RefRangeEnd = 459696, XrefRangeStart = 459688, XrefRangeEnd = 459693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_Style(string styleName, string styleOpeningDefinition, string styleClosingDefinition)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Style>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(styleName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(styleOpeningDefinition);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(styleClosingDefinition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Style.NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x000221A4 File Offset: 0x000203A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 459710, RefRangeEnd = 459712, XrefRangeStart = 459696, XrefRangeEnd = 459710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshStyle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Style.NativeMethodInfoPtr_RefreshStyle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x00005493 File Offset: 0x00003693
		public TMP_Style(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000747 RID: 1863 RVA: 0x000221D8 File Offset: 0x000203D8
		// (set) Token: 0x06000748 RID: 1864 RVA: 0x0000549C File Offset: 0x0000369C
		public unsafe static TMP_Style k_NormalStyle
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_Style.NativeFieldInfoPtr_k_NormalStyle, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Style>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Style.NativeFieldInfoPtr_k_NormalStyle, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000749 RID: 1865 RVA: 0x00022200 File Offset: 0x00020400
		// (set) Token: 0x0600074A RID: 1866 RVA: 0x000054AE File Offset: 0x000036AE
		public unsafe string m_Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Style.NativeFieldInfoPtr_m_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Style.NativeFieldInfoPtr_m_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x0600074B RID: 1867 RVA: 0x00022228 File Offset: 0x00020428
		// (set) Token: 0x0600074C RID: 1868 RVA: 0x000054CD File Offset: 0x000036CD
		public unsafe int m_HashCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Style.NativeFieldInfoPtr_m_HashCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Style.NativeFieldInfoPtr_m_HashCode)) = value;
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x0600074D RID: 1869 RVA: 0x00022250 File Offset: 0x00020450
		// (set) Token: 0x0600074E RID: 1870 RVA: 0x000054E8 File Offset: 0x000036E8
		public unsafe string m_OpeningDefinition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Style.NativeFieldInfoPtr_m_OpeningDefinition);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Style.NativeFieldInfoPtr_m_OpeningDefinition), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x0600074F RID: 1871 RVA: 0x00022278 File Offset: 0x00020478
		// (set) Token: 0x06000750 RID: 1872 RVA: 0x00005507 File Offset: 0x00003707
		public unsafe string m_ClosingDefinition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Style.NativeFieldInfoPtr_m_ClosingDefinition);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Style.NativeFieldInfoPtr_m_ClosingDefinition), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000751 RID: 1873 RVA: 0x000222A0 File Offset: 0x000204A0
		// (set) Token: 0x06000752 RID: 1874 RVA: 0x00005526 File Offset: 0x00003726
		public unsafe Il2CppStructArray<int> m_OpeningTagArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Style.NativeFieldInfoPtr_m_OpeningTagArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Style.NativeFieldInfoPtr_m_OpeningTagArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000753 RID: 1875 RVA: 0x000222D0 File Offset: 0x000204D0
		// (set) Token: 0x06000754 RID: 1876 RVA: 0x00005545 File Offset: 0x00003745
		public unsafe Il2CppStructArray<int> m_ClosingTagArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Style.NativeFieldInfoPtr_m_ClosingTagArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Style.NativeFieldInfoPtr_m_ClosingTagArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000755 RID: 1877 RVA: 0x00022300 File Offset: 0x00020500
		// (set) Token: 0x06000756 RID: 1878 RVA: 0x00005564 File Offset: 0x00003764
		public unsafe Il2CppStructArray<uint> m_OpeningTagUnicodeArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Style.NativeFieldInfoPtr_m_OpeningTagUnicodeArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Style.NativeFieldInfoPtr_m_OpeningTagUnicodeArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000757 RID: 1879 RVA: 0x00022330 File Offset: 0x00020530
		// (set) Token: 0x06000758 RID: 1880 RVA: 0x00005583 File Offset: 0x00003783
		public unsafe Il2CppStructArray<uint> m_ClosingTagUnicodeArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Style.NativeFieldInfoPtr_m_ClosingTagUnicodeArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Style.NativeFieldInfoPtr_m_ClosingTagUnicodeArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005BF RID: 1471
		private static readonly IntPtr NativeFieldInfoPtr_k_NormalStyle;

		// Token: 0x040005C0 RID: 1472
		private static readonly IntPtr NativeFieldInfoPtr_m_Name;

		// Token: 0x040005C1 RID: 1473
		private static readonly IntPtr NativeFieldInfoPtr_m_HashCode;

		// Token: 0x040005C2 RID: 1474
		private static readonly IntPtr NativeFieldInfoPtr_m_OpeningDefinition;

		// Token: 0x040005C3 RID: 1475
		private static readonly IntPtr NativeFieldInfoPtr_m_ClosingDefinition;

		// Token: 0x040005C4 RID: 1476
		private static readonly IntPtr NativeFieldInfoPtr_m_OpeningTagArray;

		// Token: 0x040005C5 RID: 1477
		private static readonly IntPtr NativeFieldInfoPtr_m_ClosingTagArray;

		// Token: 0x040005C6 RID: 1478
		private static readonly IntPtr NativeFieldInfoPtr_m_OpeningTagUnicodeArray;

		// Token: 0x040005C7 RID: 1479
		private static readonly IntPtr NativeFieldInfoPtr_m_ClosingTagUnicodeArray;

		// Token: 0x040005C8 RID: 1480
		private static readonly IntPtr NativeMethodInfoPtr_get_NormalStyle_Public_Static_get_TMP_Style_0;

		// Token: 0x040005C9 RID: 1481
		private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

		// Token: 0x040005CA RID: 1482
		private static readonly IntPtr NativeMethodInfoPtr_set_name_Public_set_Void_String_0;

		// Token: 0x040005CB RID: 1483
		private static readonly IntPtr NativeMethodInfoPtr_get_hashCode_Public_get_Int32_0;

		// Token: 0x040005CC RID: 1484
		private static readonly IntPtr NativeMethodInfoPtr_set_hashCode_Public_set_Void_Int32_0;

		// Token: 0x040005CD RID: 1485
		private static readonly IntPtr NativeMethodInfoPtr_get_styleOpeningDefinition_Public_get_String_0;

		// Token: 0x040005CE RID: 1486
		private static readonly IntPtr NativeMethodInfoPtr_get_styleClosingDefinition_Public_get_String_0;

		// Token: 0x040005CF RID: 1487
		private static readonly IntPtr NativeMethodInfoPtr_get_styleOpeningTagArray_Public_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x040005D0 RID: 1488
		private static readonly IntPtr NativeMethodInfoPtr_get_styleClosingTagArray_Public_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x040005D1 RID: 1489
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_0;

		// Token: 0x040005D2 RID: 1490
		private static readonly IntPtr NativeMethodInfoPtr_RefreshStyle_Public_Void_0;
	}
}
