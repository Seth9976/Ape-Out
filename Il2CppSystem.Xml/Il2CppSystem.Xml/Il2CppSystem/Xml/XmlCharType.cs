using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000094 RID: 148
	public sealed class XmlCharType : ValueType
	{
		// Token: 0x06000F17 RID: 3863 RVA: 0x00054CD4 File Offset: 0x00052ED4
		// Note: this type is marked as 'beforefieldinit'.
		static XmlCharType()
		{
			Il2CppClassPointerStore<XmlCharType>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlCharType");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr);
			XmlCharType.NativeFieldInfoPtr_s_Lock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, "s_Lock");
			XmlCharType.NativeFieldInfoPtr_s_CharProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, "s_CharProperties");
			XmlCharType.NativeFieldInfoPtr_charProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, "charProperties");
			XmlCharType.NativeMethodInfoPtr_get_StaticLock_Private_Static_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100665690);
			XmlCharType.NativeMethodInfoPtr_InitInstance_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100665691);
			XmlCharType.NativeMethodInfoPtr_SetProperties_Private_Static_Void_String_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100665692);
			XmlCharType.NativeMethodInfoPtr__ctor_Private_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100665693);
			XmlCharType.NativeMethodInfoPtr_get_Instance_Public_Static_get_XmlCharType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100665694);
			XmlCharType.NativeMethodInfoPtr_IsWhiteSpace_Public_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100665695);
			XmlCharType.NativeMethodInfoPtr_IsNCNameSingleChar_Public_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100665696);
			XmlCharType.NativeMethodInfoPtr_IsStartNCNameSingleChar_Public_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100665697);
			XmlCharType.NativeMethodInfoPtr_IsNameSingleChar_Public_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100665698);
			XmlCharType.NativeMethodInfoPtr_IsCharData_Public_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100665699);
			XmlCharType.NativeMethodInfoPtr_IsPubidChar_Public_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100665700);
			XmlCharType.NativeMethodInfoPtr_IsTextChar_Internal_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100665701);
			XmlCharType.NativeMethodInfoPtr_IsLetter_Public_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100665702);
			XmlCharType.NativeMethodInfoPtr_IsNCNameCharXml4e_Public_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100665703);
			XmlCharType.NativeMethodInfoPtr_IsStartNCNameCharXml4e_Public_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100665704);
			XmlCharType.NativeMethodInfoPtr_IsNameCharXml4e_Public_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100665705);
			XmlCharType.NativeMethodInfoPtr_IsDigit_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100665706);
			XmlCharType.NativeMethodInfoPtr_IsHighSurrogate_Internal_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100665707);
			XmlCharType.NativeMethodInfoPtr_IsLowSurrogate_Internal_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100665708);
			XmlCharType.NativeMethodInfoPtr_IsSurrogate_Internal_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100665709);
			XmlCharType.NativeMethodInfoPtr_CombineSurrogateChar_Internal_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100665710);
			XmlCharType.NativeMethodInfoPtr_SplitSurrogateChar_Internal_Static_Void_Int32_byref_Char_byref_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100665711);
			XmlCharType.NativeMethodInfoPtr_IsOnlyWhitespace_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100665712);
			XmlCharType.NativeMethodInfoPtr_IsOnlyWhitespaceWithPos_Internal_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100665713);
			XmlCharType.NativeMethodInfoPtr_IsOnlyCharData_Internal_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100665714);
			XmlCharType.NativeMethodInfoPtr_IsOnlyDigits_Internal_Static_Boolean_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100665715);
			XmlCharType.NativeMethodInfoPtr_IsPublicId_Internal_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100665716);
			XmlCharType.NativeMethodInfoPtr_InRange_Private_Static_Boolean_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100665717);
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06000F18 RID: 3864 RVA: 0x00054F70 File Offset: 0x00053170
		public unsafe static Object StaticLock
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400938, XrefRangeEnd = 400945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_get_StaticLock_Private_Static_get_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000F19 RID: 3865 RVA: 0x00054FA4 File Offset: 0x000531A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 400986, RefRangeEnd = 400987, XrefRangeStart = 400945, XrefRangeEnd = 400986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitInstance()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_InitInstance_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F1A RID: 3866 RVA: 0x00054FCC File Offset: 0x000531CC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 400990, RefRangeEnd = 400998, XrefRangeStart = 400987, XrefRangeEnd = 400990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetProperties(string ranges, byte value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ranges);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_SetProperties_Private_Static_Void_String_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F1B RID: 3867 RVA: 0x00055010 File Offset: 0x00053210
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 99329, RefRangeEnd = 99331, XrefRangeStart = 99329, XrefRangeEnd = 99331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlCharType(Il2CppStructArray<byte> charProperties)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(charProperties);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr__ctor_Private_Void_Il2CppStructArray_1_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06000F1C RID: 3868 RVA: 0x00055060 File Offset: 0x00053260
		public unsafe static XmlCharType Instance
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 401002, RefRangeEnd = 401024, XrefRangeStart = 400998, XrefRangeEnd = 401002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_get_Instance_Public_Static_get_XmlCharType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new XmlCharType(intPtr);
			}
		}

		// Token: 0x06000F1D RID: 3869 RVA: 0x0005508C File Offset: 0x0005328C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 401024, RefRangeEnd = 401026, XrefRangeStart = 401024, XrefRangeEnd = 401024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsWhiteSpace(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_IsWhiteSpace_Public_Boolean_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F1E RID: 3870 RVA: 0x000550DC File Offset: 0x000532DC
		[CallerCount(0)]
		public unsafe bool IsNCNameSingleChar(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_IsNCNameSingleChar_Public_Boolean_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F1F RID: 3871 RVA: 0x0005512C File Offset: 0x0005332C
		[CallerCount(0)]
		public unsafe bool IsStartNCNameSingleChar(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_IsStartNCNameSingleChar_Public_Boolean_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F20 RID: 3872 RVA: 0x0005517C File Offset: 0x0005337C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 401026, RefRangeEnd = 401027, XrefRangeStart = 401026, XrefRangeEnd = 401026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsNameSingleChar(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_IsNameSingleChar_Public_Boolean_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F21 RID: 3873 RVA: 0x000551CC File Offset: 0x000533CC
		[CallerCount(0)]
		public unsafe bool IsCharData(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_IsCharData_Public_Boolean_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F22 RID: 3874 RVA: 0x0005521C File Offset: 0x0005341C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 401028, RefRangeEnd = 401030, XrefRangeStart = 401027, XrefRangeEnd = 401028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPubidChar(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_IsPubidChar_Public_Boolean_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F23 RID: 3875 RVA: 0x0005526C File Offset: 0x0005346C
		[CallerCount(0)]
		public unsafe bool IsTextChar(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_IsTextChar_Internal_Boolean_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F24 RID: 3876 RVA: 0x000552BC File Offset: 0x000534BC
		[CallerCount(0)]
		public unsafe bool IsLetter(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_IsLetter_Public_Boolean_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F25 RID: 3877 RVA: 0x0005530C File Offset: 0x0005350C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 401030, RefRangeEnd = 401031, XrefRangeStart = 401030, XrefRangeEnd = 401030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsNCNameCharXml4e(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_IsNCNameCharXml4e_Public_Boolean_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F26 RID: 3878 RVA: 0x0005535C File Offset: 0x0005355C
		[CallerCount(0)]
		public unsafe bool IsStartNCNameCharXml4e(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_IsStartNCNameCharXml4e_Public_Boolean_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F27 RID: 3879 RVA: 0x000553AC File Offset: 0x000535AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 401031, RefRangeEnd = 401032, XrefRangeStart = 401031, XrefRangeEnd = 401031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsNameCharXml4e(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_IsNameCharXml4e_Public_Boolean_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F28 RID: 3880 RVA: 0x000553FC File Offset: 0x000535FC
		[CallerCount(0)]
		public unsafe static bool IsDigit(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_IsDigit_Public_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F29 RID: 3881 RVA: 0x0005543C File Offset: 0x0005363C
		[CallerCount(0)]
		public unsafe static bool IsHighSurrogate(int ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_IsHighSurrogate_Internal_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x0005547C File Offset: 0x0005367C
		[CallerCount(0)]
		public unsafe static bool IsLowSurrogate(int ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_IsLowSurrogate_Internal_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F2B RID: 3883 RVA: 0x000554BC File Offset: 0x000536BC
		[CallerCount(0)]
		public unsafe static bool IsSurrogate(int ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_IsSurrogate_Internal_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F2C RID: 3884 RVA: 0x000554FC File Offset: 0x000536FC
		[CallerCount(0)]
		public unsafe static int CombineSurrogateChar(int lowChar, int highChar)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lowChar;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref highChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_CombineSurrogateChar_Internal_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F2D RID: 3885 RVA: 0x00055548 File Offset: 0x00053748
		[CallerCount(0)]
		public unsafe static void SplitSurrogateChar(int combinedChar, out char lowChar, out char highChar)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref combinedChar;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lowChar;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &highChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_SplitSurrogateChar_Internal_Static_Void_Int32_byref_Char_byref_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F2E RID: 3886 RVA: 0x00055598 File Offset: 0x00053798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401032, XrefRangeEnd = 401033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsOnlyWhitespace(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_IsOnlyWhitespace_Internal_Boolean_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F2F RID: 3887 RVA: 0x000555EC File Offset: 0x000537EC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 401034, RefRangeEnd = 401040, XrefRangeStart = 401033, XrefRangeEnd = 401034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IsOnlyWhitespaceWithPos(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_IsOnlyWhitespaceWithPos_Internal_Int32_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F30 RID: 3888 RVA: 0x00055640 File Offset: 0x00053840
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 401044, RefRangeEnd = 401047, XrefRangeStart = 401040, XrefRangeEnd = 401044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IsOnlyCharData(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_IsOnlyCharData_Internal_Int32_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F31 RID: 3889 RVA: 0x00055694 File Offset: 0x00053894
		[CallerCount(0)]
		public unsafe static bool IsOnlyDigits(string str, int startPos, int len)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_IsOnlyDigits_Internal_Static_Boolean_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x000556F4 File Offset: 0x000538F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 401050, RefRangeEnd = 401052, XrefRangeStart = 401047, XrefRangeEnd = 401050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IsPublicId(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_IsPublicId_Internal_Int32_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F33 RID: 3891 RVA: 0x00055748 File Offset: 0x00053948
		[CallerCount(0)]
		public unsafe static bool InRange(int value, int start, int end)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_InRange_Private_Static_Boolean_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F34 RID: 3892 RVA: 0x0000721B File Offset: 0x0000541B
		public XmlCharType(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000F35 RID: 3893 RVA: 0x00007224 File Offset: 0x00005424
		public XmlCharType()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr))
		{
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06000F36 RID: 3894 RVA: 0x000557A4 File Offset: 0x000539A4
		// (set) Token: 0x06000F37 RID: 3895 RVA: 0x00007236 File Offset: 0x00005436
		public unsafe static Object s_Lock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlCharType.NativeFieldInfoPtr_s_Lock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlCharType.NativeFieldInfoPtr_s_Lock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06000F38 RID: 3896 RVA: 0x000557CC File Offset: 0x000539CC
		// (set) Token: 0x06000F39 RID: 3897 RVA: 0x00007248 File Offset: 0x00005448
		public unsafe static Il2CppStructArray<byte> s_CharProperties
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlCharType.NativeFieldInfoPtr_s_CharProperties, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlCharType.NativeFieldInfoPtr_s_CharProperties, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06000F3A RID: 3898 RVA: 0x000557F4 File Offset: 0x000539F4
		// (set) Token: 0x06000F3B RID: 3899 RVA: 0x0000725A File Offset: 0x0000545A
		public unsafe Il2CppStructArray<byte> charProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlCharType.NativeFieldInfoPtr_charProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlCharType.NativeFieldInfoPtr_charProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BC4 RID: 3012
		private static readonly IntPtr NativeFieldInfoPtr_s_Lock;

		// Token: 0x04000BC5 RID: 3013
		private static readonly IntPtr NativeFieldInfoPtr_s_CharProperties;

		// Token: 0x04000BC6 RID: 3014
		private static readonly IntPtr NativeFieldInfoPtr_charProperties;

		// Token: 0x04000BC7 RID: 3015
		private static readonly IntPtr NativeMethodInfoPtr_get_StaticLock_Private_Static_get_Object_0;

		// Token: 0x04000BC8 RID: 3016
		private static readonly IntPtr NativeMethodInfoPtr_InitInstance_Private_Static_Void_0;

		// Token: 0x04000BC9 RID: 3017
		private static readonly IntPtr NativeMethodInfoPtr_SetProperties_Private_Static_Void_String_Byte_0;

		// Token: 0x04000BCA RID: 3018
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000BCB RID: 3019
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_XmlCharType_0;

		// Token: 0x04000BCC RID: 3020
		private static readonly IntPtr NativeMethodInfoPtr_IsWhiteSpace_Public_Boolean_Char_0;

		// Token: 0x04000BCD RID: 3021
		private static readonly IntPtr NativeMethodInfoPtr_IsNCNameSingleChar_Public_Boolean_Char_0;

		// Token: 0x04000BCE RID: 3022
		private static readonly IntPtr NativeMethodInfoPtr_IsStartNCNameSingleChar_Public_Boolean_Char_0;

		// Token: 0x04000BCF RID: 3023
		private static readonly IntPtr NativeMethodInfoPtr_IsNameSingleChar_Public_Boolean_Char_0;

		// Token: 0x04000BD0 RID: 3024
		private static readonly IntPtr NativeMethodInfoPtr_IsCharData_Public_Boolean_Char_0;

		// Token: 0x04000BD1 RID: 3025
		private static readonly IntPtr NativeMethodInfoPtr_IsPubidChar_Public_Boolean_Char_0;

		// Token: 0x04000BD2 RID: 3026
		private static readonly IntPtr NativeMethodInfoPtr_IsTextChar_Internal_Boolean_Char_0;

		// Token: 0x04000BD3 RID: 3027
		private static readonly IntPtr NativeMethodInfoPtr_IsLetter_Public_Boolean_Char_0;

		// Token: 0x04000BD4 RID: 3028
		private static readonly IntPtr NativeMethodInfoPtr_IsNCNameCharXml4e_Public_Boolean_Char_0;

		// Token: 0x04000BD5 RID: 3029
		private static readonly IntPtr NativeMethodInfoPtr_IsStartNCNameCharXml4e_Public_Boolean_Char_0;

		// Token: 0x04000BD6 RID: 3030
		private static readonly IntPtr NativeMethodInfoPtr_IsNameCharXml4e_Public_Boolean_Char_0;

		// Token: 0x04000BD7 RID: 3031
		private static readonly IntPtr NativeMethodInfoPtr_IsDigit_Public_Static_Boolean_Char_0;

		// Token: 0x04000BD8 RID: 3032
		private static readonly IntPtr NativeMethodInfoPtr_IsHighSurrogate_Internal_Static_Boolean_Int32_0;

		// Token: 0x04000BD9 RID: 3033
		private static readonly IntPtr NativeMethodInfoPtr_IsLowSurrogate_Internal_Static_Boolean_Int32_0;

		// Token: 0x04000BDA RID: 3034
		private static readonly IntPtr NativeMethodInfoPtr_IsSurrogate_Internal_Static_Boolean_Int32_0;

		// Token: 0x04000BDB RID: 3035
		private static readonly IntPtr NativeMethodInfoPtr_CombineSurrogateChar_Internal_Static_Int32_Int32_Int32_0;

		// Token: 0x04000BDC RID: 3036
		private static readonly IntPtr NativeMethodInfoPtr_SplitSurrogateChar_Internal_Static_Void_Int32_byref_Char_byref_Char_0;

		// Token: 0x04000BDD RID: 3037
		private static readonly IntPtr NativeMethodInfoPtr_IsOnlyWhitespace_Internal_Boolean_String_0;

		// Token: 0x04000BDE RID: 3038
		private static readonly IntPtr NativeMethodInfoPtr_IsOnlyWhitespaceWithPos_Internal_Int32_String_0;

		// Token: 0x04000BDF RID: 3039
		private static readonly IntPtr NativeMethodInfoPtr_IsOnlyCharData_Internal_Int32_String_0;

		// Token: 0x04000BE0 RID: 3040
		private static readonly IntPtr NativeMethodInfoPtr_IsOnlyDigits_Internal_Static_Boolean_String_Int32_Int32_0;

		// Token: 0x04000BE1 RID: 3041
		private static readonly IntPtr NativeMethodInfoPtr_IsPublicId_Internal_Int32_String_0;

		// Token: 0x04000BE2 RID: 3042
		private static readonly IntPtr NativeMethodInfoPtr_InRange_Private_Static_Boolean_Int32_Int32_Int32_0;
	}
}
