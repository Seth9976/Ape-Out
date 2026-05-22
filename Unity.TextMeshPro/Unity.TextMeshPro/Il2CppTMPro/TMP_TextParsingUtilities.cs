using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppTMPro
{
	// Token: 0x02000057 RID: 87
	public class TMP_TextParsingUtilities : Object
	{
		// Token: 0x06000B53 RID: 2899 RVA: 0x00030430 File Offset: 0x0002E630
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_TextParsingUtilities()
		{
			Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_TextParsingUtilities");
			TMP_TextParsingUtilities.NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr, "s_Instance");
			TMP_TextParsingUtilities.NativeFieldInfoPtr_k_LookupStringL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr, "k_LookupStringL");
			TMP_TextParsingUtilities.NativeFieldInfoPtr_k_LookupStringU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr, "k_LookupStringU");
			TMP_TextParsingUtilities.NativeMethodInfoPtr_get_instance_Public_Static_get_TMP_TextParsingUtilities_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr, 100664583);
			TMP_TextParsingUtilities.NativeMethodInfoPtr_GetHashCode_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr, 100664584);
			TMP_TextParsingUtilities.NativeMethodInfoPtr_GetHashCodeCaseSensitive_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr, 100664585);
			TMP_TextParsingUtilities.NativeMethodInfoPtr_ToLowerASCIIFast_Public_Static_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr, 100664586);
			TMP_TextParsingUtilities.NativeMethodInfoPtr_ToUpperASCIIFast_Public_Static_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr, 100664587);
			TMP_TextParsingUtilities.NativeMethodInfoPtr_ToUpperASCIIFast_Public_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr, 100664588);
			TMP_TextParsingUtilities.NativeMethodInfoPtr_ToLowerASCIIFast_Public_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr, 100664589);
			TMP_TextParsingUtilities.NativeMethodInfoPtr_IsHighSurrogate_Public_Static_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr, 100664590);
			TMP_TextParsingUtilities.NativeMethodInfoPtr_IsLowSurrogate_Public_Static_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr, 100664591);
			TMP_TextParsingUtilities.NativeMethodInfoPtr_ConvertToUTF32_Internal_Static_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr, 100664592);
			TMP_TextParsingUtilities.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr, 100664593);
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06000B54 RID: 2900 RVA: 0x00030570 File Offset: 0x0002E770
		public unsafe static TMP_TextParsingUtilities instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 463449, XrefRangeEnd = 463453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextParsingUtilities.NativeMethodInfoPtr_get_instance_Public_Static_get_TMP_TextParsingUtilities_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_TextParsingUtilities>(intPtr3) : null;
			}
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x000305A4 File Offset: 0x0002E7A4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 463458, RefRangeEnd = 463462, XrefRangeStart = 463453, XrefRangeEnd = 463458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetHashCode(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextParsingUtilities.NativeMethodInfoPtr_GetHashCode_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x000305E8 File Offset: 0x0002E7E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 463462, XrefRangeEnd = 463463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetHashCodeCaseSensitive(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextParsingUtilities.NativeMethodInfoPtr_GetHashCodeCaseSensitive_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x0003062C File Offset: 0x0002E82C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 463463, XrefRangeEnd = 463465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char ToLowerASCIIFast(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextParsingUtilities.NativeMethodInfoPtr_ToLowerASCIIFast_Public_Static_Char_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x0003066C File Offset: 0x0002E86C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 463467, RefRangeEnd = 463472, XrefRangeStart = 463465, XrefRangeEnd = 463467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char ToUpperASCIIFast(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextParsingUtilities.NativeMethodInfoPtr_ToUpperASCIIFast_Public_Static_Char_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x000306AC File Offset: 0x0002E8AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 463472, XrefRangeEnd = 463474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ToUpperASCIIFast(uint c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextParsingUtilities.NativeMethodInfoPtr_ToUpperASCIIFast_Public_Static_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x000306EC File Offset: 0x0002E8EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 463474, XrefRangeEnd = 463476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ToLowerASCIIFast(uint c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextParsingUtilities.NativeMethodInfoPtr_ToLowerASCIIFast_Public_Static_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x0003072C File Offset: 0x0002E92C
		[CallerCount(0)]
		public unsafe static bool IsHighSurrogate(uint c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextParsingUtilities.NativeMethodInfoPtr_IsHighSurrogate_Public_Static_Boolean_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x0003076C File Offset: 0x0002E96C
		[CallerCount(0)]
		public unsafe static bool IsLowSurrogate(uint c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextParsingUtilities.NativeMethodInfoPtr_IsLowSurrogate_Public_Static_Boolean_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x000307AC File Offset: 0x0002E9AC
		[CallerCount(0)]
		public unsafe static uint ConvertToUTF32(uint highSurrogate, uint lowSurrogate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref highSurrogate;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lowSurrogate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextParsingUtilities.NativeMethodInfoPtr_ConvertToUTF32_Internal_Static_UInt32_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x000307F8 File Offset: 0x0002E9F8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_TextParsingUtilities()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextParsingUtilities.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x000075C6 File Offset: 0x000057C6
		public TMP_TextParsingUtilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06000B60 RID: 2912 RVA: 0x00030834 File Offset: 0x0002EA34
		// (set) Token: 0x06000B61 RID: 2913 RVA: 0x000075CF File Offset: 0x000057CF
		public unsafe static TMP_TextParsingUtilities s_Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_TextParsingUtilities.NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_TextParsingUtilities>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_TextParsingUtilities.NativeFieldInfoPtr_s_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06000B62 RID: 2914 RVA: 0x0003085C File Offset: 0x0002EA5C
		// (set) Token: 0x06000B63 RID: 2915 RVA: 0x000075E1 File Offset: 0x000057E1
		public unsafe static string k_LookupStringL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_TextParsingUtilities.NativeFieldInfoPtr_k_LookupStringL, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_TextParsingUtilities.NativeFieldInfoPtr_k_LookupStringL, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06000B64 RID: 2916 RVA: 0x0003087C File Offset: 0x0002EA7C
		// (set) Token: 0x06000B65 RID: 2917 RVA: 0x000075F3 File Offset: 0x000057F3
		public unsafe static string k_LookupStringU
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_TextParsingUtilities.NativeFieldInfoPtr_k_LookupStringU, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_TextParsingUtilities.NativeFieldInfoPtr_k_LookupStringU, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000901 RID: 2305
		private static readonly IntPtr NativeFieldInfoPtr_s_Instance;

		// Token: 0x04000902 RID: 2306
		private static readonly IntPtr NativeFieldInfoPtr_k_LookupStringL;

		// Token: 0x04000903 RID: 2307
		private static readonly IntPtr NativeFieldInfoPtr_k_LookupStringU;

		// Token: 0x04000904 RID: 2308
		private static readonly IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_TMP_TextParsingUtilities_0;

		// Token: 0x04000905 RID: 2309
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Static_Int32_String_0;

		// Token: 0x04000906 RID: 2310
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCodeCaseSensitive_Public_Static_Int32_String_0;

		// Token: 0x04000907 RID: 2311
		private static readonly IntPtr NativeMethodInfoPtr_ToLowerASCIIFast_Public_Static_Char_Char_0;

		// Token: 0x04000908 RID: 2312
		private static readonly IntPtr NativeMethodInfoPtr_ToUpperASCIIFast_Public_Static_Char_Char_0;

		// Token: 0x04000909 RID: 2313
		private static readonly IntPtr NativeMethodInfoPtr_ToUpperASCIIFast_Public_Static_UInt32_UInt32_0;

		// Token: 0x0400090A RID: 2314
		private static readonly IntPtr NativeMethodInfoPtr_ToLowerASCIIFast_Public_Static_UInt32_UInt32_0;

		// Token: 0x0400090B RID: 2315
		private static readonly IntPtr NativeMethodInfoPtr_IsHighSurrogate_Public_Static_Boolean_UInt32_0;

		// Token: 0x0400090C RID: 2316
		private static readonly IntPtr NativeMethodInfoPtr_IsLowSurrogate_Public_Static_Boolean_UInt32_0;

		// Token: 0x0400090D RID: 2317
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToUTF32_Internal_Static_UInt32_UInt32_UInt32_0;

		// Token: 0x0400090E RID: 2318
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
