using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x02000055 RID: 85
	public sealed class RegexFC : Object
	{
		// Token: 0x06000565 RID: 1381 RVA: 0x000257A8 File Offset: 0x000239A8
		// Note: this type is marked as 'beforefieldinit'.
		static RegexFC()
		{
			Il2CppClassPointerStore<RegexFC>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "RegexFC");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexFC>.NativeClassPtr);
			RegexFC.NativeFieldInfoPtr__cc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexFC>.NativeClassPtr, "_cc");
			RegexFC.NativeFieldInfoPtr__nullable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexFC>.NativeClassPtr, "_nullable");
			RegexFC.NativeFieldInfoPtr__caseInsensitive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexFC>.NativeClassPtr, "_caseInsensitive");
			RegexFC.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFC>.NativeClassPtr, 100664142);
			RegexFC.NativeMethodInfoPtr__ctor_Internal_Void_Char_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFC>.NativeClassPtr, 100664143);
			RegexFC.NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFC>.NativeClassPtr, 100664144);
			RegexFC.NativeMethodInfoPtr_AddFC_Internal_Boolean_RegexFC_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFC>.NativeClassPtr, 100664145);
			RegexFC.NativeMethodInfoPtr_GetFirstChars_Internal_String_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFC>.NativeClassPtr, 100664146);
			RegexFC.NativeMethodInfoPtr_IsCaseInsensitive_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFC>.NativeClassPtr, 100664147);
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x0002588C File Offset: 0x00023A8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370532, XrefRangeEnd = 370536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexFC(bool nullable)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexFC>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nullable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFC.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x000258D4 File Offset: 0x00023AD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370541, RefRangeEnd = 370542, XrefRangeStart = 370536, XrefRangeEnd = 370541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexFC(char ch, bool not, bool nullable, bool caseInsensitive)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexFC>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref not;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nullable;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref caseInsensitive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFC.NativeMethodInfoPtr__ctor_Internal_Void_Char_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x00025948 File Offset: 0x00023B48
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 370550, RefRangeEnd = 370553, XrefRangeStart = 370542, XrefRangeEnd = 370550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexFC(string charClass, bool nullable, bool caseInsensitive)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexFC>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(charClass);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nullable;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref caseInsensitive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFC.NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x000259B0 File Offset: 0x00023BB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370553, XrefRangeEnd = 370555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AddFC(RegexFC fc, bool concatenate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref concatenate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFC.NativeMethodInfoPtr_AddFC_Internal_Boolean_RegexFC_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x00025A0C File Offset: 0x00023C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370555, XrefRangeEnd = 370558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetFirstChars(CultureInfo culture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFC.NativeMethodInfoPtr_GetFirstChars_Internal_String_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x00025A54 File Offset: 0x00023C54
		[CallerCount(0)]
		public unsafe bool IsCaseInsensitive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFC.NativeMethodInfoPtr_IsCaseInsensitive_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00004057 File Offset: 0x00002257
		public RegexFC(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x0600056D RID: 1389 RVA: 0x00025A90 File Offset: 0x00023C90
		// (set) Token: 0x0600056E RID: 1390 RVA: 0x00004060 File Offset: 0x00002260
		public unsafe RegexCharClass _cc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexFC.NativeFieldInfoPtr__cc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexCharClass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexFC.NativeFieldInfoPtr__cc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x0600056F RID: 1391 RVA: 0x00025AC0 File Offset: 0x00023CC0
		// (set) Token: 0x06000570 RID: 1392 RVA: 0x0000407F File Offset: 0x0000227F
		public unsafe bool _nullable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexFC.NativeFieldInfoPtr__nullable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexFC.NativeFieldInfoPtr__nullable)) = value;
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000571 RID: 1393 RVA: 0x00025AE8 File Offset: 0x00023CE8
		// (set) Token: 0x06000572 RID: 1394 RVA: 0x0000409A File Offset: 0x0000229A
		public unsafe bool _caseInsensitive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexFC.NativeFieldInfoPtr__caseInsensitive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexFC.NativeFieldInfoPtr__caseInsensitive)) = value;
			}
		}

		// Token: 0x0400041A RID: 1050
		private static readonly IntPtr NativeFieldInfoPtr__cc;

		// Token: 0x0400041B RID: 1051
		private static readonly IntPtr NativeFieldInfoPtr__nullable;

		// Token: 0x0400041C RID: 1052
		private static readonly IntPtr NativeFieldInfoPtr__caseInsensitive;

		// Token: 0x0400041D RID: 1053
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0;

		// Token: 0x0400041E RID: 1054
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Char_Boolean_Boolean_Boolean_0;

		// Token: 0x0400041F RID: 1055
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_Boolean_0;

		// Token: 0x04000420 RID: 1056
		private static readonly IntPtr NativeMethodInfoPtr_AddFC_Internal_Boolean_RegexFC_Boolean_0;

		// Token: 0x04000421 RID: 1057
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstChars_Internal_String_CultureInfo_0;

		// Token: 0x04000422 RID: 1058
		private static readonly IntPtr NativeMethodInfoPtr_IsCaseInsensitive_Internal_Boolean_0;
	}
}
