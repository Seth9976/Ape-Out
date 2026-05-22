using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x02000063 RID: 99
	public sealed class RegexReplacement : Object
	{
		// Token: 0x060006EB RID: 1771 RVA: 0x0002B5B8 File Offset: 0x000297B8
		// Note: this type is marked as 'beforefieldinit'.
		static RegexReplacement()
		{
			Il2CppClassPointerStore<RegexReplacement>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "RegexReplacement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexReplacement>.NativeClassPtr);
			RegexReplacement.NativeFieldInfoPtr__rep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexReplacement>.NativeClassPtr, "_rep");
			RegexReplacement.NativeFieldInfoPtr__strings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexReplacement>.NativeClassPtr, "_strings");
			RegexReplacement.NativeFieldInfoPtr__rules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexReplacement>.NativeClassPtr, "_rules");
			RegexReplacement.NativeMethodInfoPtr__ctor_Internal_Void_String_RegexNode_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexReplacement>.NativeClassPtr, 100664349);
			RegexReplacement.NativeMethodInfoPtr_ReplacementImpl_Private_Void_StringBuilder_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexReplacement>.NativeClassPtr, 100664350);
			RegexReplacement.NativeMethodInfoPtr_ReplacementImplRTL_Private_Void_List_1_String_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexReplacement>.NativeClassPtr, 100664351);
			RegexReplacement.NativeMethodInfoPtr_get_Pattern_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexReplacement>.NativeClassPtr, 100664352);
			RegexReplacement.NativeMethodInfoPtr_Replace_Internal_String_Regex_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexReplacement>.NativeClassPtr, 100664353);
			RegexReplacement.NativeMethodInfoPtr_Replace_Internal_Static_String_MatchEvaluator_Regex_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexReplacement>.NativeClassPtr, 100664354);
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x0002B69C File Offset: 0x0002989C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 372066, RefRangeEnd = 372067, XrefRangeStart = 372021, XrefRangeEnd = 372066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexReplacement(string rep, RegexNode concat, Hashtable _caps)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexReplacement>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(rep);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(concat);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_caps);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexReplacement.NativeMethodInfoPtr__ctor_Internal_Void_String_RegexNode_Hashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x0002B70C File Offset: 0x0002990C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372067, XrefRangeEnd = 372079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReplacementImpl(StringBuilder sb, Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexReplacement.NativeMethodInfoPtr_ReplacementImpl_Private_Void_StringBuilder_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x0002B760 File Offset: 0x00029960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372079, XrefRangeEnd = 372092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReplacementImplRTL(List<string> al, Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(al);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexReplacement.NativeMethodInfoPtr_ReplacementImplRTL_Private_Void_List_1_String_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x060006EF RID: 1775 RVA: 0x0002B7B4 File Offset: 0x000299B4
		public unsafe string Pattern
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexReplacement.NativeMethodInfoPtr_get_Pattern_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x0002B7EC File Offset: 0x000299EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 372147, RefRangeEnd = 372148, XrefRangeStart = 372092, XrefRangeEnd = 372147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Replace(Regex regex, string input, int count, int startat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(regex);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(input);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexReplacement.NativeMethodInfoPtr_Replace_Internal_String_Regex_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x0002B864 File Offset: 0x00029A64
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 372187, RefRangeEnd = 372191, XrefRangeStart = 372148, XrefRangeEnd = 372187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Replace(MatchEvaluator evaluator, Regex regex, string input, int count, int startat)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evaluator);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(regex);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(input);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexReplacement.NativeMethodInfoPtr_Replace_Internal_Static_String_MatchEvaluator_Regex_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x000049CA File Offset: 0x00002BCA
		public RegexReplacement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x060006F3 RID: 1779 RVA: 0x0002B8E0 File Offset: 0x00029AE0
		// (set) Token: 0x060006F4 RID: 1780 RVA: 0x000049D3 File Offset: 0x00002BD3
		public unsafe string _rep
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexReplacement.NativeFieldInfoPtr__rep);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexReplacement.NativeFieldInfoPtr__rep), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x060006F5 RID: 1781 RVA: 0x0002B908 File Offset: 0x00029B08
		// (set) Token: 0x060006F6 RID: 1782 RVA: 0x000049F2 File Offset: 0x00002BF2
		public unsafe List<string> _strings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexReplacement.NativeFieldInfoPtr__strings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexReplacement.NativeFieldInfoPtr__strings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x060006F7 RID: 1783 RVA: 0x0002B938 File Offset: 0x00029B38
		// (set) Token: 0x060006F8 RID: 1784 RVA: 0x00004A11 File Offset: 0x00002C11
		public unsafe List<int> _rules
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexReplacement.NativeFieldInfoPtr__rules);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexReplacement.NativeFieldInfoPtr__rules), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000540 RID: 1344
		private static readonly IntPtr NativeFieldInfoPtr__rep;

		// Token: 0x04000541 RID: 1345
		private static readonly IntPtr NativeFieldInfoPtr__strings;

		// Token: 0x04000542 RID: 1346
		private static readonly IntPtr NativeFieldInfoPtr__rules;

		// Token: 0x04000543 RID: 1347
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_RegexNode_Hashtable_0;

		// Token: 0x04000544 RID: 1348
		private static readonly IntPtr NativeMethodInfoPtr_ReplacementImpl_Private_Void_StringBuilder_Match_0;

		// Token: 0x04000545 RID: 1349
		private static readonly IntPtr NativeMethodInfoPtr_ReplacementImplRTL_Private_Void_List_1_String_Match_0;

		// Token: 0x04000546 RID: 1350
		private static readonly IntPtr NativeMethodInfoPtr_get_Pattern_Internal_get_String_0;

		// Token: 0x04000547 RID: 1351
		private static readonly IntPtr NativeMethodInfoPtr_Replace_Internal_String_Regex_String_Int32_Int32_0;

		// Token: 0x04000548 RID: 1352
		private static readonly IntPtr NativeMethodInfoPtr_Replace_Internal_Static_String_MatchEvaluator_Regex_String_Int32_Int32_0;
	}
}
