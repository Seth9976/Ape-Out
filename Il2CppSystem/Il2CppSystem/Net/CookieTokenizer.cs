using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x0200010E RID: 270
	public class CookieTokenizer : Object
	{
		// Token: 0x06000EF1 RID: 3825 RVA: 0x000489DC File Offset: 0x00046BDC
		// Note: this type is marked as 'beforefieldinit'.
		static CookieTokenizer()
		{
			Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "CookieTokenizer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr);
			CookieTokenizer.NativeFieldInfoPtr_m_eofCookie = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, "m_eofCookie");
			CookieTokenizer.NativeFieldInfoPtr_m_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, "m_index");
			CookieTokenizer.NativeFieldInfoPtr_m_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, "m_length");
			CookieTokenizer.NativeFieldInfoPtr_m_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, "m_name");
			CookieTokenizer.NativeFieldInfoPtr_m_quoted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, "m_quoted");
			CookieTokenizer.NativeFieldInfoPtr_m_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, "m_start");
			CookieTokenizer.NativeFieldInfoPtr_m_token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, "m_token");
			CookieTokenizer.NativeFieldInfoPtr_m_tokenLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, "m_tokenLength");
			CookieTokenizer.NativeFieldInfoPtr_m_tokenStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, "m_tokenStream");
			CookieTokenizer.NativeFieldInfoPtr_m_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, "m_value");
			CookieTokenizer.NativeFieldInfoPtr_RecognizedAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, "RecognizedAttributes");
			CookieTokenizer.NativeFieldInfoPtr_RecognizedServerAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, "RecognizedServerAttributes");
			CookieTokenizer.NativeMethodInfoPtr__ctor_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, 100665443);
			CookieTokenizer.NativeMethodInfoPtr_get_EndOfCookie_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, 100665444);
			CookieTokenizer.NativeMethodInfoPtr_set_EndOfCookie_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, 100665445);
			CookieTokenizer.NativeMethodInfoPtr_get_Eof_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, 100665446);
			CookieTokenizer.NativeMethodInfoPtr_get_Name_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, 100665447);
			CookieTokenizer.NativeMethodInfoPtr_set_Name_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, 100665448);
			CookieTokenizer.NativeMethodInfoPtr_get_Quoted_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, 100665449);
			CookieTokenizer.NativeMethodInfoPtr_set_Quoted_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, 100665450);
			CookieTokenizer.NativeMethodInfoPtr_get_Token_Internal_get_CookieToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, 100665451);
			CookieTokenizer.NativeMethodInfoPtr_set_Token_Internal_set_Void_CookieToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, 100665452);
			CookieTokenizer.NativeMethodInfoPtr_get_Value_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, 100665453);
			CookieTokenizer.NativeMethodInfoPtr_set_Value_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, 100665454);
			CookieTokenizer.NativeMethodInfoPtr_Extract_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, 100665455);
			CookieTokenizer.NativeMethodInfoPtr_FindNext_Internal_CookieToken_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, 100665456);
			CookieTokenizer.NativeMethodInfoPtr_Next_Internal_CookieToken_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, 100665457);
			CookieTokenizer.NativeMethodInfoPtr_Reset_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, 100665458);
			CookieTokenizer.NativeMethodInfoPtr_TokenFromName_Internal_CookieToken_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, 100665459);
		}

		// Token: 0x06000EF2 RID: 3826 RVA: 0x00048C50 File Offset: 0x00046E50
		[CallerCount(0)]
		public unsafe CookieTokenizer(string tokenStream)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tokenStream);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.NativeMethodInfoPtr__ctor_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06000EF3 RID: 3827 RVA: 0x00048C9C File Offset: 0x00046E9C
		// (set) Token: 0x06000EF4 RID: 3828 RVA: 0x00048CD8 File Offset: 0x00046ED8
		public unsafe bool EndOfCookie
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.NativeMethodInfoPtr_get_EndOfCookie_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.NativeMethodInfoPtr_set_EndOfCookie_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06000EF5 RID: 3829 RVA: 0x00048D18 File Offset: 0x00046F18
		public unsafe bool Eof
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.NativeMethodInfoPtr_get_Eof_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06000EF6 RID: 3830 RVA: 0x00048D54 File Offset: 0x00046F54
		// (set) Token: 0x06000EF7 RID: 3831 RVA: 0x00048D8C File Offset: 0x00046F8C
		public unsafe string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.NativeMethodInfoPtr_get_Name_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(33)]
			[CachedScanResults(RefRangeStart = 18620, RefRangeEnd = 18653, XrefRangeStart = 18620, XrefRangeEnd = 18653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.NativeMethodInfoPtr_set_Name_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06000EF8 RID: 3832 RVA: 0x00048DD0 File Offset: 0x00046FD0
		// (set) Token: 0x06000EF9 RID: 3833 RVA: 0x00048E0C File Offset: 0x0004700C
		public unsafe bool Quoted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.NativeMethodInfoPtr_get_Quoted_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.NativeMethodInfoPtr_set_Quoted_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06000EFA RID: 3834 RVA: 0x00048E4C File Offset: 0x0004704C
		// (set) Token: 0x06000EFB RID: 3835 RVA: 0x00048E88 File Offset: 0x00047088
		public unsafe CookieToken Token
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.NativeMethodInfoPtr_get_Token_Internal_get_CookieToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.NativeMethodInfoPtr_set_Token_Internal_set_Void_CookieToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06000EFC RID: 3836 RVA: 0x00048EC8 File Offset: 0x000470C8
		// (set) Token: 0x06000EFD RID: 3837 RVA: 0x00048F00 File Offset: 0x00047100
		public unsafe string Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.NativeMethodInfoPtr_get_Value_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(43)]
			[CachedScanResults(RefRangeStart = 13782, RefRangeEnd = 13825, XrefRangeStart = 13782, XrefRangeEnd = 13825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.NativeMethodInfoPtr_set_Value_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000EFE RID: 3838 RVA: 0x00048F44 File Offset: 0x00047144
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 378581, RefRangeEnd = 378582, XrefRangeStart = 378577, XrefRangeEnd = 378581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Extract()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.NativeMethodInfoPtr_Extract_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000EFF RID: 3839 RVA: 0x00048F7C File Offset: 0x0004717C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 378590, RefRangeEnd = 378591, XrefRangeStart = 378582, XrefRangeEnd = 378590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CookieToken FindNext(bool ignoreComma, bool ignoreEquals)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ignoreComma;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreEquals;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.NativeMethodInfoPtr_FindNext_Internal_CookieToken_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F00 RID: 3840 RVA: 0x00048FD4 File Offset: 0x000471D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 378596, RefRangeEnd = 378597, XrefRangeStart = 378591, XrefRangeEnd = 378596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CookieToken Next(bool first, bool parseResponseCookies)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref first;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parseResponseCookies;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.NativeMethodInfoPtr_Next_Internal_CookieToken_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F01 RID: 3841 RVA: 0x0004902C File Offset: 0x0004722C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378597, XrefRangeEnd = 378600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.NativeMethodInfoPtr_Reset_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F02 RID: 3842 RVA: 0x00049060 File Offset: 0x00047260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378600, XrefRangeEnd = 378622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CookieToken TokenFromName(bool parseResponseCookies)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref parseResponseCookies;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.NativeMethodInfoPtr_TokenFromName_Internal_CookieToken_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F03 RID: 3843 RVA: 0x00007DEC File Offset: 0x00005FEC
		public CookieTokenizer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06000F04 RID: 3844 RVA: 0x000490AC File Offset: 0x000472AC
		// (set) Token: 0x06000F05 RID: 3845 RVA: 0x00007DF5 File Offset: 0x00005FF5
		public unsafe bool m_eofCookie
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_eofCookie);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_eofCookie)) = value;
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06000F06 RID: 3846 RVA: 0x000490D4 File Offset: 0x000472D4
		// (set) Token: 0x06000F07 RID: 3847 RVA: 0x00007E10 File Offset: 0x00006010
		public unsafe int m_index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_index)) = value;
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06000F08 RID: 3848 RVA: 0x000490FC File Offset: 0x000472FC
		// (set) Token: 0x06000F09 RID: 3849 RVA: 0x00007E2B File Offset: 0x0000602B
		public unsafe int m_length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_length)) = value;
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06000F0A RID: 3850 RVA: 0x00049124 File Offset: 0x00047324
		// (set) Token: 0x06000F0B RID: 3851 RVA: 0x00007E46 File Offset: 0x00006046
		public unsafe string m_name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06000F0C RID: 3852 RVA: 0x0004914C File Offset: 0x0004734C
		// (set) Token: 0x06000F0D RID: 3853 RVA: 0x00007E65 File Offset: 0x00006065
		public unsafe bool m_quoted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_quoted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_quoted)) = value;
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06000F0E RID: 3854 RVA: 0x00049174 File Offset: 0x00047374
		// (set) Token: 0x06000F0F RID: 3855 RVA: 0x00007E80 File Offset: 0x00006080
		public unsafe int m_start
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_start);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_start)) = value;
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06000F10 RID: 3856 RVA: 0x0004919C File Offset: 0x0004739C
		// (set) Token: 0x06000F11 RID: 3857 RVA: 0x00007E9B File Offset: 0x0000609B
		public unsafe CookieToken m_token
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_token);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_token)) = value;
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06000F12 RID: 3858 RVA: 0x000491C4 File Offset: 0x000473C4
		// (set) Token: 0x06000F13 RID: 3859 RVA: 0x00007EB6 File Offset: 0x000060B6
		public unsafe int m_tokenLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_tokenLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_tokenLength)) = value;
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06000F14 RID: 3860 RVA: 0x000491EC File Offset: 0x000473EC
		// (set) Token: 0x06000F15 RID: 3861 RVA: 0x00007ED1 File Offset: 0x000060D1
		public unsafe string m_tokenStream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_tokenStream);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_tokenStream), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06000F16 RID: 3862 RVA: 0x00049214 File Offset: 0x00047414
		// (set) Token: 0x06000F17 RID: 3863 RVA: 0x00007EF0 File Offset: 0x000060F0
		public unsafe string m_value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_value);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_value), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06000F18 RID: 3864 RVA: 0x0004923C File Offset: 0x0004743C
		// (set) Token: 0x06000F19 RID: 3865 RVA: 0x00007F0F File Offset: 0x0000610F
		public unsafe static Il2CppReferenceArray<CookieTokenizer.RecognizedAttribute> RecognizedAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CookieTokenizer.NativeFieldInfoPtr_RecognizedAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CookieTokenizer.RecognizedAttribute>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CookieTokenizer.NativeFieldInfoPtr_RecognizedAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06000F1A RID: 3866 RVA: 0x00049264 File Offset: 0x00047464
		// (set) Token: 0x06000F1B RID: 3867 RVA: 0x00007F21 File Offset: 0x00006121
		public unsafe static Il2CppReferenceArray<CookieTokenizer.RecognizedAttribute> RecognizedServerAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CookieTokenizer.NativeFieldInfoPtr_RecognizedServerAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CookieTokenizer.RecognizedAttribute>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CookieTokenizer.NativeFieldInfoPtr_RecognizedServerAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BB8 RID: 3000
		private static readonly IntPtr NativeFieldInfoPtr_m_eofCookie;

		// Token: 0x04000BB9 RID: 3001
		private static readonly IntPtr NativeFieldInfoPtr_m_index;

		// Token: 0x04000BBA RID: 3002
		private static readonly IntPtr NativeFieldInfoPtr_m_length;

		// Token: 0x04000BBB RID: 3003
		private static readonly IntPtr NativeFieldInfoPtr_m_name;

		// Token: 0x04000BBC RID: 3004
		private static readonly IntPtr NativeFieldInfoPtr_m_quoted;

		// Token: 0x04000BBD RID: 3005
		private static readonly IntPtr NativeFieldInfoPtr_m_start;

		// Token: 0x04000BBE RID: 3006
		private static readonly IntPtr NativeFieldInfoPtr_m_token;

		// Token: 0x04000BBF RID: 3007
		private static readonly IntPtr NativeFieldInfoPtr_m_tokenLength;

		// Token: 0x04000BC0 RID: 3008
		private static readonly IntPtr NativeFieldInfoPtr_m_tokenStream;

		// Token: 0x04000BC1 RID: 3009
		private static readonly IntPtr NativeFieldInfoPtr_m_value;

		// Token: 0x04000BC2 RID: 3010
		private static readonly IntPtr NativeFieldInfoPtr_RecognizedAttributes;

		// Token: 0x04000BC3 RID: 3011
		private static readonly IntPtr NativeFieldInfoPtr_RecognizedServerAttributes;

		// Token: 0x04000BC4 RID: 3012
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_0;

		// Token: 0x04000BC5 RID: 3013
		private static readonly IntPtr NativeMethodInfoPtr_get_EndOfCookie_Internal_get_Boolean_0;

		// Token: 0x04000BC6 RID: 3014
		private static readonly IntPtr NativeMethodInfoPtr_set_EndOfCookie_Internal_set_Void_Boolean_0;

		// Token: 0x04000BC7 RID: 3015
		private static readonly IntPtr NativeMethodInfoPtr_get_Eof_Internal_get_Boolean_0;

		// Token: 0x04000BC8 RID: 3016
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Internal_get_String_0;

		// Token: 0x04000BC9 RID: 3017
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Internal_set_Void_String_0;

		// Token: 0x04000BCA RID: 3018
		private static readonly IntPtr NativeMethodInfoPtr_get_Quoted_Internal_get_Boolean_0;

		// Token: 0x04000BCB RID: 3019
		private static readonly IntPtr NativeMethodInfoPtr_set_Quoted_Internal_set_Void_Boolean_0;

		// Token: 0x04000BCC RID: 3020
		private static readonly IntPtr NativeMethodInfoPtr_get_Token_Internal_get_CookieToken_0;

		// Token: 0x04000BCD RID: 3021
		private static readonly IntPtr NativeMethodInfoPtr_set_Token_Internal_set_Void_CookieToken_0;

		// Token: 0x04000BCE RID: 3022
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Internal_get_String_0;

		// Token: 0x04000BCF RID: 3023
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Internal_set_Void_String_0;

		// Token: 0x04000BD0 RID: 3024
		private static readonly IntPtr NativeMethodInfoPtr_Extract_Internal_String_0;

		// Token: 0x04000BD1 RID: 3025
		private static readonly IntPtr NativeMethodInfoPtr_FindNext_Internal_CookieToken_Boolean_Boolean_0;

		// Token: 0x04000BD2 RID: 3026
		private static readonly IntPtr NativeMethodInfoPtr_Next_Internal_CookieToken_Boolean_Boolean_0;

		// Token: 0x04000BD3 RID: 3027
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Internal_Void_0;

		// Token: 0x04000BD4 RID: 3028
		private static readonly IntPtr NativeMethodInfoPtr_TokenFromName_Internal_CookieToken_Boolean_0;

		// Token: 0x020001DA RID: 474
		public sealed class RecognizedAttribute : ValueType
		{
			// Token: 0x06001A25 RID: 6693 RVA: 0x0006FA8C File Offset: 0x0006DC8C
			// Note: this type is marked as 'beforefieldinit'.
			static RecognizedAttribute()
			{
				Il2CppClassPointerStore<CookieTokenizer.RecognizedAttribute>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, "RecognizedAttribute");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CookieTokenizer.RecognizedAttribute>.NativeClassPtr);
				CookieTokenizer.RecognizedAttribute.NativeFieldInfoPtr_m_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieTokenizer.RecognizedAttribute>.NativeClassPtr, "m_name");
				CookieTokenizer.RecognizedAttribute.NativeFieldInfoPtr_m_token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieTokenizer.RecognizedAttribute>.NativeClassPtr, "m_token");
				CookieTokenizer.RecognizedAttribute.NativeMethodInfoPtr__ctor_Internal_Void_String_CookieToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer.RecognizedAttribute>.NativeClassPtr, 100665461);
				CookieTokenizer.RecognizedAttribute.NativeMethodInfoPtr_get_Token_Internal_get_CookieToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer.RecognizedAttribute>.NativeClassPtr, 100665462);
				CookieTokenizer.RecognizedAttribute.NativeMethodInfoPtr_IsEqualTo_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer.RecognizedAttribute>.NativeClassPtr, 100665463);
			}

			// Token: 0x06001A26 RID: 6694 RVA: 0x0006FB1C File Offset: 0x0006DD1C
			[CallerCount(0)]
			public unsafe RecognizedAttribute(string name, CookieToken token)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CookieTokenizer.RecognizedAttribute>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.RecognizedAttribute.NativeMethodInfoPtr__ctor_Internal_Void_String_CookieToken_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000854 RID: 2132
			// (get) Token: 0x06001A27 RID: 6695 RVA: 0x0006FB7C File Offset: 0x0006DD7C
			public unsafe CookieToken Token
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.RecognizedAttribute.NativeMethodInfoPtr_get_Token_Internal_get_CookieToken_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001A28 RID: 6696 RVA: 0x0006FBC0 File Offset: 0x0006DDC0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 378575, RefRangeEnd = 378577, XrefRangeStart = 378573, XrefRangeEnd = 378575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool IsEqualTo(string value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.RecognizedAttribute.NativeMethodInfoPtr_IsEqualTo_Internal_Boolean_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001A29 RID: 6697 RVA: 0x0000D6C0 File Offset: 0x0000B8C0
			public RecognizedAttribute(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001A2A RID: 6698 RVA: 0x0000D6C9 File Offset: 0x0000B8C9
			public RecognizedAttribute()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CookieTokenizer.RecognizedAttribute>.NativeClassPtr))
			{
			}

			// Token: 0x17000852 RID: 2130
			// (get) Token: 0x06001A2B RID: 6699 RVA: 0x0006FC14 File Offset: 0x0006DE14
			// (set) Token: 0x06001A2C RID: 6700 RVA: 0x0000D6DB File Offset: 0x0000B8DB
			public unsafe string m_name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.RecognizedAttribute.NativeFieldInfoPtr_m_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.RecognizedAttribute.NativeFieldInfoPtr_m_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000853 RID: 2131
			// (get) Token: 0x06001A2D RID: 6701 RVA: 0x0006FC3C File Offset: 0x0006DE3C
			// (set) Token: 0x06001A2E RID: 6702 RVA: 0x0000D6FA File Offset: 0x0000B8FA
			public unsafe CookieToken m_token
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.RecognizedAttribute.NativeFieldInfoPtr_m_token);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.RecognizedAttribute.NativeFieldInfoPtr_m_token)) = value;
				}
			}

			// Token: 0x0400148B RID: 5259
			private static readonly IntPtr NativeFieldInfoPtr_m_name;

			// Token: 0x0400148C RID: 5260
			private static readonly IntPtr NativeFieldInfoPtr_m_token;

			// Token: 0x0400148D RID: 5261
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_CookieToken_0;

			// Token: 0x0400148E RID: 5262
			private static readonly IntPtr NativeMethodInfoPtr_get_Token_Internal_get_CookieToken_0;

			// Token: 0x0400148F RID: 5263
			private static readonly IntPtr NativeMethodInfoPtr_IsEqualTo_Internal_Boolean_String_0;
		}
	}
}
