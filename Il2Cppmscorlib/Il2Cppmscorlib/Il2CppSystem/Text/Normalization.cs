using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text
{
	// Token: 0x02000179 RID: 377
	public class Normalization : Object
	{
		// Token: 0x06001A63 RID: 6755 RVA: 0x0009C848 File Offset: 0x0009AA48
		// Note: this type is marked as 'beforefieldinit'.
		static Normalization()
		{
			Il2CppClassPointerStore<Normalization>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "Normalization");
			Normalization.NativeFieldInfoPtr_props = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Normalization>.NativeClassPtr, "props");
			Normalization.NativeFieldInfoPtr_mappedChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Normalization>.NativeClassPtr, "mappedChars");
			Normalization.NativeFieldInfoPtr_charMapIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Normalization>.NativeClassPtr, "charMapIndex");
			Normalization.NativeFieldInfoPtr_helperIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Normalization>.NativeClassPtr, "helperIndex");
			Normalization.NativeFieldInfoPtr_mapIdxToComposite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Normalization>.NativeClassPtr, "mapIdxToComposite");
			Normalization.NativeFieldInfoPtr_combiningClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Normalization>.NativeClassPtr, "combiningClass");
			Normalization.NativeFieldInfoPtr_forLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Normalization>.NativeClassPtr, "forLock");
			Normalization.NativeFieldInfoPtr_isReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Normalization>.NativeClassPtr, "isReady");
			Normalization.NativeMethodInfoPtr_PropValue_Private_Static_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100667830);
			Normalization.NativeMethodInfoPtr_CharMapIdx_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100667831);
			Normalization.NativeMethodInfoPtr_GetCombiningClass_Private_Static_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100667832);
			Normalization.NativeMethodInfoPtr_GetPrimaryCompositeFromMapIndex_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100667833);
			Normalization.NativeMethodInfoPtr_GetPrimaryCompositeHelperIndex_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100667834);
			Normalization.NativeMethodInfoPtr_Compose_Private_Static_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100667835);
			Normalization.NativeMethodInfoPtr_Combine_Private_Static_StringBuilder_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100667836);
			Normalization.NativeMethodInfoPtr_Combine_Private_Static_Void_StringBuilder_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100667837);
			Normalization.NativeMethodInfoPtr_CombineHangul_Private_Static_Int32_StringBuilder_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100667838);
			Normalization.NativeMethodInfoPtr_Fetch_Private_Static_Int32_StringBuilder_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100667839);
			Normalization.NativeMethodInfoPtr_TryComposeWithPreviousStarter_Private_Static_Int32_StringBuilder_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100667840);
			Normalization.NativeMethodInfoPtr_TryCompose_Private_Static_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100667841);
			Normalization.NativeMethodInfoPtr_Decompose_Private_Static_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100667842);
			Normalization.NativeMethodInfoPtr_Decompose_Private_Static_Void_String_byref_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100667843);
			Normalization.NativeMethodInfoPtr_ReorderCanonical_Private_Static_Void_String_byref_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100667844);
			Normalization.NativeMethodInfoPtr_DecomposeChar_Private_Static_Void_byref_StringBuilder_byref_Il2CppStructArray_1_Int32_String_Int32_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100667845);
			Normalization.NativeMethodInfoPtr_QuickCheck_Public_Static_NormalizationCheck_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100667846);
			Normalization.NativeMethodInfoPtr_GetCanonicalHangul_Private_Static_Int32_Int32_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100667847);
			Normalization.NativeMethodInfoPtr_GetCanonical_Private_Static_Int32_Int32_Il2CppStructArray_1_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100667848);
			Normalization.NativeMethodInfoPtr_Normalize_Public_Static_String_String_NormalizationForm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100667849);
			Normalization.NativeMethodInfoPtr_Normalize_Public_Static_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100667850);
			Normalization.NativeMethodInfoPtr_load_normalization_resource_Private_Static_Void_byref_IntPtr_byref_IntPtr_byref_IntPtr_byref_IntPtr_byref_IntPtr_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100667851);
		}

		// Token: 0x06001A64 RID: 6756 RVA: 0x0009CAC8 File Offset: 0x0009ACC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 184417, RefRangeEnd = 184419, XrefRangeStart = 184404, XrefRangeEnd = 184417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint PropValue(int cp)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cp;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_PropValue_Private_Static_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A65 RID: 6757 RVA: 0x0009CB08 File Offset: 0x0009AD08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184419, XrefRangeEnd = 184432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CharMapIdx(int cp)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cp;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_CharMapIdx_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A66 RID: 6758 RVA: 0x0009CB48 File Offset: 0x0009AD48
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 184441, RefRangeEnd = 184447, XrefRangeStart = 184432, XrefRangeEnd = 184441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte GetCombiningClass(int c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_GetCombiningClass_Private_Static_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A67 RID: 6759 RVA: 0x0009CB88 File Offset: 0x0009AD88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 184456, RefRangeEnd = 184457, XrefRangeStart = 184447, XrefRangeEnd = 184456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetPrimaryCompositeFromMapIndex(int src)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref src;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_GetPrimaryCompositeFromMapIndex_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A68 RID: 6760 RVA: 0x0009CBC8 File Offset: 0x0009ADC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184457, XrefRangeEnd = 184466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetPrimaryCompositeHelperIndex(int cp)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cp;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_GetPrimaryCompositeHelperIndex_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A69 RID: 6761 RVA: 0x0009CC08 File Offset: 0x0009AE08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 184490, RefRangeEnd = 184491, XrefRangeStart = 184466, XrefRangeEnd = 184490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Compose(string source, int checkType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_Compose_Private_Static_String_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001A6A RID: 6762 RVA: 0x0009CC54 File Offset: 0x0009AE54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184491, XrefRangeEnd = 184504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StringBuilder Combine(string source, int start, int checkType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_Combine_Private_Static_StringBuilder_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
		}

		// Token: 0x06001A6B RID: 6763 RVA: 0x0009CCB4 File Offset: 0x0009AEB4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 184528, RefRangeEnd = 184531, XrefRangeStart = 184504, XrefRangeEnd = 184528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Combine(StringBuilder sb, int i, int checkType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_Combine_Private_Static_Void_StringBuilder_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A6C RID: 6764 RVA: 0x0009CD08 File Offset: 0x0009AF08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184531, XrefRangeEnd = 184545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CombineHangul(StringBuilder sb, string s, int current)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(s);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref current;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_CombineHangul_Private_Static_Int32_StringBuilder_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A6D RID: 6765 RVA: 0x0009CD6C File Offset: 0x0009AF6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184545, XrefRangeEnd = 184546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Fetch(StringBuilder sb, string s, int i)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(s);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_Fetch_Private_Static_Int32_StringBuilder_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A6E RID: 6766 RVA: 0x0009CDD0 File Offset: 0x0009AFD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 184557, RefRangeEnd = 184558, XrefRangeStart = 184546, XrefRangeEnd = 184557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int TryComposeWithPreviousStarter(StringBuilder sb, string s, int current)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(s);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref current;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_TryComposeWithPreviousStarter_Private_Static_Int32_StringBuilder_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A6F RID: 6767 RVA: 0x0009CE34 File Offset: 0x0009B034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184558, XrefRangeEnd = 184575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int TryCompose(int i, int starter, int candidate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref starter;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref candidate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_TryCompose_Private_Static_Int32_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A70 RID: 6768 RVA: 0x0009CE90 File Offset: 0x0009B090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184575, XrefRangeEnd = 184579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Decompose(string source, int checkType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_Decompose_Private_Static_String_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001A71 RID: 6769 RVA: 0x0009CEDC File Offset: 0x0009B0DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 184591, RefRangeEnd = 184594, XrefRangeStart = 184579, XrefRangeEnd = 184591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Decompose(string source, ref StringBuilder sb, int checkType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkType;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_Decompose_Private_Static_Void_String_byref_StringBuilder_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			sb = ((intPtr4 == 0) ? null : new StringBuilder(intPtr4));
		}

		// Token: 0x06001A72 RID: 6770 RVA: 0x0009CF48 File Offset: 0x0009B148
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 184628, RefRangeEnd = 184629, XrefRangeStart = 184594, XrefRangeEnd = 184628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReorderCanonical(string src, ref StringBuilder sb, int start)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(src);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_ReorderCanonical_Private_Static_Void_String_byref_StringBuilder_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			sb = ((intPtr4 == 0) ? null : new StringBuilder(intPtr4));
		}

		// Token: 0x06001A73 RID: 6771 RVA: 0x0009CFB4 File Offset: 0x0009B1B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 184647, RefRangeEnd = 184648, XrefRangeStart = 184629, XrefRangeEnd = 184647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DecomposeChar(ref StringBuilder sb, ref Il2CppStructArray<int> buf, string s, int i, int checkType, ref int start)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(buf);
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(s);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkType;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &start;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_DecomposeChar_Private_Static_Void_byref_StringBuilder_byref_Il2CppStructArray_1_Int32_String_Int32_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			sb = ((intPtr5 == 0) ? null : new StringBuilder(intPtr5));
			IntPtr intPtr6 = intPtr2;
			buf = ((intPtr6 == 0) ? null : new Il2CppStructArray<int>(intPtr6));
		}

		// Token: 0x06001A74 RID: 6772 RVA: 0x0009D068 File Offset: 0x0009B268
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 184652, RefRangeEnd = 184656, XrefRangeStart = 184648, XrefRangeEnd = 184652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NormalizationCheck QuickCheck(char c, int type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_QuickCheck_Public_Static_NormalizationCheck_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A75 RID: 6773 RVA: 0x0009D0B4 File Offset: 0x0009B2B4
		[CallerCount(0)]
		public unsafe static int GetCanonicalHangul(int s, Il2CppStructArray<int> buf, int bufIdx)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref s;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buf);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufIdx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_GetCanonicalHangul_Private_Static_Int32_Int32_Il2CppStructArray_1_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A76 RID: 6774 RVA: 0x0009D114 File Offset: 0x0009B314
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 184660, RefRangeEnd = 184661, XrefRangeStart = 184656, XrefRangeEnd = 184660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetCanonical(int c, Il2CppStructArray<int> buf, int bufIdx, int checkType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buf);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufIdx;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_GetCanonical_Private_Static_Int32_Int32_Il2CppStructArray_1_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A77 RID: 6775 RVA: 0x0009D180 File Offset: 0x0009B380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184661, XrefRangeEnd = 184674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Normalize(string source, NormalizationForm normalizationForm)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref normalizationForm;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_Normalize_Public_Static_String_String_NormalizationForm_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001A78 RID: 6776 RVA: 0x0009D1CC File Offset: 0x0009B3CC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 184685, RefRangeEnd = 184690, XrefRangeStart = 184674, XrefRangeEnd = 184685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Normalize(string source, int type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_Normalize_Public_Static_String_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001A79 RID: 6777 RVA: 0x0009D218 File Offset: 0x0009B418
		[CallerCount(0)]
		public unsafe static void load_normalization_resource(out IntPtr props, out IntPtr mappedChars, out IntPtr charMapIndex, out IntPtr helperIndex, out IntPtr mapIdxToComposite, out IntPtr combiningClass)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &props;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &mappedChars;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charMapIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &helperIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &mapIdxToComposite;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &combiningClass;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_load_normalization_resource_Private_Static_Void_byref_IntPtr_byref_IntPtr_byref_IntPtr_byref_IntPtr_byref_IntPtr_byref_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A7A RID: 6778 RVA: 0x00008E49 File Offset: 0x00007049
		public Normalization(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06001A7B RID: 6779 RVA: 0x0009D294 File Offset: 0x0009B494
		// (set) Token: 0x06001A7C RID: 6780 RVA: 0x00008E52 File Offset: 0x00007052
		public unsafe static byte* props
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Normalization.NativeFieldInfoPtr_props, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Normalization.NativeFieldInfoPtr_props, (void*)value);
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06001A7D RID: 6781 RVA: 0x0009D2B0 File Offset: 0x0009B4B0
		// (set) Token: 0x06001A7E RID: 6782 RVA: 0x00008E5F File Offset: 0x0000705F
		public unsafe static int* mappedChars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Normalization.NativeFieldInfoPtr_mappedChars, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Normalization.NativeFieldInfoPtr_mappedChars, (void*)value);
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06001A7F RID: 6783 RVA: 0x0009D2CC File Offset: 0x0009B4CC
		// (set) Token: 0x06001A80 RID: 6784 RVA: 0x00008E6C File Offset: 0x0000706C
		public unsafe static short* charMapIndex
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Normalization.NativeFieldInfoPtr_charMapIndex, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Normalization.NativeFieldInfoPtr_charMapIndex, (void*)value);
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06001A81 RID: 6785 RVA: 0x0009D2E8 File Offset: 0x0009B4E8
		// (set) Token: 0x06001A82 RID: 6786 RVA: 0x00008E79 File Offset: 0x00007079
		public unsafe static short* helperIndex
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Normalization.NativeFieldInfoPtr_helperIndex, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Normalization.NativeFieldInfoPtr_helperIndex, (void*)value);
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06001A83 RID: 6787 RVA: 0x0009D304 File Offset: 0x0009B504
		// (set) Token: 0x06001A84 RID: 6788 RVA: 0x00008E86 File Offset: 0x00007086
		public unsafe static ushort* mapIdxToComposite
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Normalization.NativeFieldInfoPtr_mapIdxToComposite, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Normalization.NativeFieldInfoPtr_mapIdxToComposite, (void*)value);
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06001A85 RID: 6789 RVA: 0x0009D320 File Offset: 0x0009B520
		// (set) Token: 0x06001A86 RID: 6790 RVA: 0x00008E93 File Offset: 0x00007093
		public unsafe static byte* combiningClass
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Normalization.NativeFieldInfoPtr_combiningClass, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Normalization.NativeFieldInfoPtr_combiningClass, (void*)value);
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06001A87 RID: 6791 RVA: 0x0009D33C File Offset: 0x0009B53C
		// (set) Token: 0x06001A88 RID: 6792 RVA: 0x00008EA0 File Offset: 0x000070A0
		public unsafe static Object forLock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Normalization.NativeFieldInfoPtr_forLock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Normalization.NativeFieldInfoPtr_forLock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06001A89 RID: 6793 RVA: 0x0009D364 File Offset: 0x0009B564
		// (set) Token: 0x06001A8A RID: 6794 RVA: 0x00008EB2 File Offset: 0x000070B2
		public unsafe static bool isReady
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Normalization.NativeFieldInfoPtr_isReady, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Normalization.NativeFieldInfoPtr_isReady, (void*)(&value));
			}
		}

		// Token: 0x0400181D RID: 6173
		private static readonly IntPtr NativeFieldInfoPtr_props;

		// Token: 0x0400181E RID: 6174
		private static readonly IntPtr NativeFieldInfoPtr_mappedChars;

		// Token: 0x0400181F RID: 6175
		private static readonly IntPtr NativeFieldInfoPtr_charMapIndex;

		// Token: 0x04001820 RID: 6176
		private static readonly IntPtr NativeFieldInfoPtr_helperIndex;

		// Token: 0x04001821 RID: 6177
		private static readonly IntPtr NativeFieldInfoPtr_mapIdxToComposite;

		// Token: 0x04001822 RID: 6178
		private static readonly IntPtr NativeFieldInfoPtr_combiningClass;

		// Token: 0x04001823 RID: 6179
		private static readonly IntPtr NativeFieldInfoPtr_forLock;

		// Token: 0x04001824 RID: 6180
		private static readonly IntPtr NativeFieldInfoPtr_isReady;

		// Token: 0x04001825 RID: 6181
		private static readonly IntPtr NativeMethodInfoPtr_PropValue_Private_Static_UInt32_Int32_0;

		// Token: 0x04001826 RID: 6182
		private static readonly IntPtr NativeMethodInfoPtr_CharMapIdx_Private_Static_Int32_Int32_0;

		// Token: 0x04001827 RID: 6183
		private static readonly IntPtr NativeMethodInfoPtr_GetCombiningClass_Private_Static_Byte_Int32_0;

		// Token: 0x04001828 RID: 6184
		private static readonly IntPtr NativeMethodInfoPtr_GetPrimaryCompositeFromMapIndex_Private_Static_Int32_Int32_0;

		// Token: 0x04001829 RID: 6185
		private static readonly IntPtr NativeMethodInfoPtr_GetPrimaryCompositeHelperIndex_Private_Static_Int32_Int32_0;

		// Token: 0x0400182A RID: 6186
		private static readonly IntPtr NativeMethodInfoPtr_Compose_Private_Static_String_String_Int32_0;

		// Token: 0x0400182B RID: 6187
		private static readonly IntPtr NativeMethodInfoPtr_Combine_Private_Static_StringBuilder_String_Int32_Int32_0;

		// Token: 0x0400182C RID: 6188
		private static readonly IntPtr NativeMethodInfoPtr_Combine_Private_Static_Void_StringBuilder_Int32_Int32_0;

		// Token: 0x0400182D RID: 6189
		private static readonly IntPtr NativeMethodInfoPtr_CombineHangul_Private_Static_Int32_StringBuilder_String_Int32_0;

		// Token: 0x0400182E RID: 6190
		private static readonly IntPtr NativeMethodInfoPtr_Fetch_Private_Static_Int32_StringBuilder_String_Int32_0;

		// Token: 0x0400182F RID: 6191
		private static readonly IntPtr NativeMethodInfoPtr_TryComposeWithPreviousStarter_Private_Static_Int32_StringBuilder_String_Int32_0;

		// Token: 0x04001830 RID: 6192
		private static readonly IntPtr NativeMethodInfoPtr_TryCompose_Private_Static_Int32_Int32_Int32_Int32_0;

		// Token: 0x04001831 RID: 6193
		private static readonly IntPtr NativeMethodInfoPtr_Decompose_Private_Static_String_String_Int32_0;

		// Token: 0x04001832 RID: 6194
		private static readonly IntPtr NativeMethodInfoPtr_Decompose_Private_Static_Void_String_byref_StringBuilder_Int32_0;

		// Token: 0x04001833 RID: 6195
		private static readonly IntPtr NativeMethodInfoPtr_ReorderCanonical_Private_Static_Void_String_byref_StringBuilder_Int32_0;

		// Token: 0x04001834 RID: 6196
		private static readonly IntPtr NativeMethodInfoPtr_DecomposeChar_Private_Static_Void_byref_StringBuilder_byref_Il2CppStructArray_1_Int32_String_Int32_Int32_byref_Int32_0;

		// Token: 0x04001835 RID: 6197
		private static readonly IntPtr NativeMethodInfoPtr_QuickCheck_Public_Static_NormalizationCheck_Char_Int32_0;

		// Token: 0x04001836 RID: 6198
		private static readonly IntPtr NativeMethodInfoPtr_GetCanonicalHangul_Private_Static_Int32_Int32_Il2CppStructArray_1_Int32_Int32_0;

		// Token: 0x04001837 RID: 6199
		private static readonly IntPtr NativeMethodInfoPtr_GetCanonical_Private_Static_Int32_Int32_Il2CppStructArray_1_Int32_Int32_Int32_0;

		// Token: 0x04001838 RID: 6200
		private static readonly IntPtr NativeMethodInfoPtr_Normalize_Public_Static_String_String_NormalizationForm_0;

		// Token: 0x04001839 RID: 6201
		private static readonly IntPtr NativeMethodInfoPtr_Normalize_Public_Static_String_String_Int32_0;

		// Token: 0x0400183A RID: 6202
		private static readonly IntPtr NativeMethodInfoPtr_load_normalization_resource_Private_Static_Void_byref_IntPtr_byref_IntPtr_byref_IntPtr_byref_IntPtr_byref_IntPtr_byref_IntPtr_0;
	}
}
