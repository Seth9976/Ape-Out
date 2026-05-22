using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppI2.Loc
{
	// Token: 0x02000262 RID: 610
	public class RTLFixer : Object
	{
		// Token: 0x06004641 RID: 17985 RVA: 0x00106300 File Offset: 0x00104500
		// Note: this type is marked as 'beforefieldinit'.
		static RTLFixer()
		{
			Il2CppClassPointerStore<RTLFixer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "RTLFixer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTLFixer>.NativeClassPtr);
			RTLFixer.NativeMethodInfoPtr_Fix_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTLFixer>.NativeClassPtr, 100670403);
			RTLFixer.NativeMethodInfoPtr_Fix_Public_Static_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTLFixer>.NativeClassPtr, 100670404);
			RTLFixer.NativeMethodInfoPtr_Fix_Public_Static_String_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTLFixer>.NativeClassPtr, 100670405);
			RTLFixer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTLFixer>.NativeClassPtr, 100670406);
		}

		// Token: 0x06004642 RID: 17986 RVA: 0x00106380 File Offset: 0x00104580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114623, XrefRangeEnd = 114624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Fix(string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTLFixer.NativeMethodInfoPtr_Fix_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06004643 RID: 17987 RVA: 0x001063BC File Offset: 0x001045BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114624, XrefRangeEnd = 114647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Fix(string str, bool rtl)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rtl;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTLFixer.NativeMethodInfoPtr_Fix_Public_Static_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004644 RID: 17988 RVA: 0x00106408 File Offset: 0x00104608
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 114651, RefRangeEnd = 114655, XrefRangeStart = 114647, XrefRangeEnd = 114651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Fix(string str, bool showTashkeel, bool useHinduNumbers)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref showTashkeel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useHinduNumbers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTLFixer.NativeMethodInfoPtr_Fix_Public_Static_String_String_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004645 RID: 17989 RVA: 0x00106460 File Offset: 0x00104660
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTLFixer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTLFixer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTLFixer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004646 RID: 17990 RVA: 0x00029D66 File Offset: 0x00027F66
		public RTLFixer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002B9F RID: 11167
		private static readonly IntPtr NativeMethodInfoPtr_Fix_Public_Static_String_String_0;

		// Token: 0x04002BA0 RID: 11168
		private static readonly IntPtr NativeMethodInfoPtr_Fix_Public_Static_String_String_Boolean_0;

		// Token: 0x04002BA1 RID: 11169
		private static readonly IntPtr NativeMethodInfoPtr_Fix_Public_Static_String_String_Boolean_Boolean_0;

		// Token: 0x04002BA2 RID: 11170
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
