using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Globalization
{
	// Token: 0x0200022F RID: 559
	[Serializable]
	public class CultureNotFoundException : ArgumentException
	{
		// Token: 0x06002536 RID: 9526 RVA: 0x000CAD58 File Offset: 0x000C8F58
		// Note: this type is marked as 'beforefieldinit'.
		static CultureNotFoundException()
		{
			Il2CppClassPointerStore<CultureNotFoundException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "CultureNotFoundException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CultureNotFoundException>.NativeClassPtr);
			CultureNotFoundException.NativeFieldInfoPtr_m_invalidCultureName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureNotFoundException>.NativeClassPtr, "m_invalidCultureName");
			CultureNotFoundException.NativeFieldInfoPtr_m_invalidCultureId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureNotFoundException>.NativeClassPtr, "m_invalidCultureId");
			CultureNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureNotFoundException>.NativeClassPtr, 100669517);
			CultureNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureNotFoundException>.NativeClassPtr, 100669518);
			CultureNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureNotFoundException>.NativeClassPtr, 100669519);
			CultureNotFoundException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureNotFoundException>.NativeClassPtr, 100669520);
			CultureNotFoundException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureNotFoundException>.NativeClassPtr, 100669521);
			CultureNotFoundException.NativeMethodInfoPtr_get_InvalidCultureId_Public_Virtual_New_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureNotFoundException>.NativeClassPtr, 100669522);
			CultureNotFoundException.NativeMethodInfoPtr_get_InvalidCultureName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureNotFoundException>.NativeClassPtr, 100669523);
			CultureNotFoundException.NativeMethodInfoPtr_get_DefaultMessage_Private_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureNotFoundException>.NativeClassPtr, 100669524);
			CultureNotFoundException.NativeMethodInfoPtr_get_FormatedInvalidCultureId_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureNotFoundException>.NativeClassPtr, 100669525);
			CultureNotFoundException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureNotFoundException>.NativeClassPtr, 100669526);
		}

		// Token: 0x06002537 RID: 9527 RVA: 0x000CAE78 File Offset: 0x000C9078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194454, XrefRangeEnd = 194457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CultureNotFoundException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CultureNotFoundException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002538 RID: 9528 RVA: 0x000CAEB4 File Offset: 0x000C90B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 194458, RefRangeEnd = 194459, XrefRangeStart = 194457, XrefRangeEnd = 194458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CultureNotFoundException(string paramName, string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CultureNotFoundException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002539 RID: 9529 RVA: 0x000CAF14 File Offset: 0x000C9114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194459, XrefRangeEnd = 194460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CultureNotFoundException(string paramName, string invalidCultureName, string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CultureNotFoundException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(invalidCultureName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600253A RID: 9530 RVA: 0x000CAF84 File Offset: 0x000C9184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194460, XrefRangeEnd = 194483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CultureNotFoundException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CultureNotFoundException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureNotFoundException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600253B RID: 9531 RVA: 0x000CAFE8 File Offset: 0x000C91E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194483, XrefRangeEnd = 194502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureNotFoundException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x0600253C RID: 9532 RVA: 0x000CB04C File Offset: 0x000C924C
		public unsafe virtual Nullable<int> InvalidCultureId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureNotFoundException.NativeMethodInfoPtr_get_InvalidCultureId_Public_Virtual_New_get_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<int>(intPtr);
			}
		}

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x0600253D RID: 9533 RVA: 0x000CB090 File Offset: 0x000C9290
		public unsafe virtual string InvalidCultureName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureNotFoundException.NativeMethodInfoPtr_get_InvalidCultureName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x0600253E RID: 9534 RVA: 0x000CB0D4 File Offset: 0x000C92D4
		public unsafe static string DefaultMessage
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194502, XrefRangeEnd = 194504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureNotFoundException.NativeMethodInfoPtr_get_DefaultMessage_Private_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x0600253F RID: 9535 RVA: 0x000CB100 File Offset: 0x000C9300
		public unsafe string FormatedInvalidCultureId
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194504, XrefRangeEnd = 194522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureNotFoundException.NativeMethodInfoPtr_get_FormatedInvalidCultureId_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x06002540 RID: 9536 RVA: 0x000CB138 File Offset: 0x000C9338
		public unsafe override string Message
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194522, XrefRangeEnd = 194547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureNotFoundException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002541 RID: 9537 RVA: 0x0000C72A File Offset: 0x0000A92A
		public CultureNotFoundException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x06002542 RID: 9538 RVA: 0x000CB17C File Offset: 0x000C937C
		// (set) Token: 0x06002543 RID: 9539 RVA: 0x0000C733 File Offset: 0x0000A933
		public unsafe string m_invalidCultureName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureNotFoundException.NativeFieldInfoPtr_m_invalidCultureName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureNotFoundException.NativeFieldInfoPtr_m_invalidCultureName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x06002544 RID: 9540 RVA: 0x000CB1A4 File Offset: 0x000C93A4
		// (set) Token: 0x06002545 RID: 9541 RVA: 0x0000C752 File Offset: 0x0000A952
		public Nullable<int> m_invalidCultureId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureNotFoundException.NativeFieldInfoPtr_m_invalidCultureId);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureNotFoundException.NativeFieldInfoPtr_m_invalidCultureId), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04002138 RID: 8504
		private static readonly IntPtr NativeFieldInfoPtr_m_invalidCultureName;

		// Token: 0x04002139 RID: 8505
		private static readonly IntPtr NativeFieldInfoPtr_m_invalidCultureId;

		// Token: 0x0400213A RID: 8506
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400213B RID: 8507
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x0400213C RID: 8508
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0;

		// Token: 0x0400213D RID: 8509
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x0400213E RID: 8510
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x0400213F RID: 8511
		private static readonly IntPtr NativeMethodInfoPtr_get_InvalidCultureId_Public_Virtual_New_get_Nullable_1_Int32_0;

		// Token: 0x04002140 RID: 8512
		private static readonly IntPtr NativeMethodInfoPtr_get_InvalidCultureName_Public_Virtual_New_get_String_0;

		// Token: 0x04002141 RID: 8513
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultMessage_Private_Static_get_String_0;

		// Token: 0x04002142 RID: 8514
		private static readonly IntPtr NativeMethodInfoPtr_get_FormatedInvalidCultureId_Private_get_String_0;

		// Token: 0x04002143 RID: 8515
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0;
	}
}
