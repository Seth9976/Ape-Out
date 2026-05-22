using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200002E RID: 46
	public static class IriHelper : Object
	{
		// Token: 0x0600027A RID: 634 RVA: 0x00019E70 File Offset: 0x00018070
		// Note: this type is marked as 'beforefieldinit'.
		static IriHelper()
		{
			Il2CppClassPointerStore<IriHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System", "IriHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IriHelper>.NativeClassPtr);
			IriHelper.NativeMethodInfoPtr_CheckIriUnicodeRange_Internal_Static_Boolean_Char_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IriHelper>.NativeClassPtr, 100663772);
			IriHelper.NativeMethodInfoPtr_CheckIriUnicodeRange_Internal_Static_Boolean_Char_Char_byref_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IriHelper>.NativeClassPtr, 100663773);
			IriHelper.NativeMethodInfoPtr_CheckIsReserved_Internal_Static_Boolean_Char_UriComponents_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IriHelper>.NativeClassPtr, 100663774);
			IriHelper.NativeMethodInfoPtr_EscapeUnescapeIri_Internal_Static_String_ptr_Char_Int32_Int32_UriComponents_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IriHelper>.NativeClassPtr, 100663775);
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00019EF0 File Offset: 0x000180F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 367049, RefRangeEnd = 367052, XrefRangeStart = 367049, XrefRangeEnd = 367049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckIriUnicodeRange(char unicode, bool isQuery)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isQuery;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IriHelper.NativeMethodInfoPtr_CheckIriUnicodeRange_Internal_Static_Boolean_Char_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00019F3C File Offset: 0x0001813C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 367155, RefRangeEnd = 367158, XrefRangeStart = 367052, XrefRangeEnd = 367155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckIriUnicodeRange(char highSurr, char lowSurr, ref bool surrogatePair, bool isQuery)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref highSurr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lowSurr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &surrogatePair;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isQuery;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IriHelper.NativeMethodInfoPtr_CheckIriUnicodeRange_Internal_Static_Boolean_Char_Char_byref_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00019FA4 File Offset: 0x000181A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 367161, RefRangeEnd = 367162, XrefRangeStart = 367158, XrefRangeEnd = 367161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckIsReserved(char ch, UriComponents component)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref component;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IriHelper.NativeMethodInfoPtr_CheckIsReserved_Internal_Static_Boolean_Char_UriComponents_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00019FF0 File Offset: 0x000181F0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 367242, RefRangeEnd = 367247, XrefRangeStart = 367162, XrefRangeEnd = 367242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EscapeUnescapeIri(char* pInput, int start, int end, UriComponents component)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pInput;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref component;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IriHelper.NativeMethodInfoPtr_EscapeUnescapeIri_Internal_Static_String_ptr_Char_Int32_Int32_UriComponents_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00002F8E File Offset: 0x0000118E
		public IriHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001B8 RID: 440
		private static readonly IntPtr NativeMethodInfoPtr_CheckIriUnicodeRange_Internal_Static_Boolean_Char_Boolean_0;

		// Token: 0x040001B9 RID: 441
		private static readonly IntPtr NativeMethodInfoPtr_CheckIriUnicodeRange_Internal_Static_Boolean_Char_Char_byref_Boolean_Boolean_0;

		// Token: 0x040001BA RID: 442
		private static readonly IntPtr NativeMethodInfoPtr_CheckIsReserved_Internal_Static_Boolean_Char_UriComponents_0;

		// Token: 0x040001BB RID: 443
		private static readonly IntPtr NativeMethodInfoPtr_EscapeUnescapeIri_Internal_Static_String_ptr_Char_Int32_Int32_UriComponents_0;
	}
}
