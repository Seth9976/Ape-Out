using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x0200005F RID: 95
	[Serializable]
	public class RegexMatchTimeoutException : TimeoutException
	{
		// Token: 0x06000640 RID: 1600 RVA: 0x00028994 File Offset: 0x00026B94
		// Note: this type is marked as 'beforefieldinit'.
		static RegexMatchTimeoutException()
		{
			Il2CppClassPointerStore<RegexMatchTimeoutException>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "RegexMatchTimeoutException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexMatchTimeoutException>.NativeClassPtr);
			RegexMatchTimeoutException.NativeFieldInfoPtr_regexInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexMatchTimeoutException>.NativeClassPtr, "regexInput");
			RegexMatchTimeoutException.NativeFieldInfoPtr_regexPattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexMatchTimeoutException>.NativeClassPtr, "regexPattern");
			RegexMatchTimeoutException.NativeFieldInfoPtr_matchTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexMatchTimeoutException>.NativeClassPtr, "matchTimeout");
			RegexMatchTimeoutException.NativeMethodInfoPtr__ctor_Public_Void_String_String_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexMatchTimeoutException>.NativeClassPtr, 100664245);
			RegexMatchTimeoutException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexMatchTimeoutException>.NativeClassPtr, 100664246);
			RegexMatchTimeoutException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexMatchTimeoutException>.NativeClassPtr, 100664247);
			RegexMatchTimeoutException.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexMatchTimeoutException>.NativeClassPtr, 100664248);
			RegexMatchTimeoutException.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexMatchTimeoutException>.NativeClassPtr, 100664249);
			RegexMatchTimeoutException.NativeMethodInfoPtr_Init_Private_Void_String_String_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexMatchTimeoutException>.NativeClassPtr, 100664250);
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x00028A78 File Offset: 0x00026C78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371042, XrefRangeEnd = 371049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexMatchTimeoutException(string regexInput, string regexPattern, TimeSpan matchTimeout)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexMatchTimeoutException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(regexInput);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(regexPattern);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matchTimeout;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexMatchTimeoutException.NativeMethodInfoPtr__ctor_Public_Void_String_String_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x00028AE4 File Offset: 0x00026CE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371049, XrefRangeEnd = 371061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexMatchTimeoutException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexMatchTimeoutException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexMatchTimeoutException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x00028B20 File Offset: 0x00026D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371061, XrefRangeEnd = 371078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexMatchTimeoutException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexMatchTimeoutException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexMatchTimeoutException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x00028B84 File Offset: 0x00026D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371078, XrefRangeEnd = 371153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo si, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(si);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexMatchTimeoutException.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x00028BE0 File Offset: 0x00026DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371153, XrefRangeEnd = 371159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexMatchTimeoutException.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x00028C14 File Offset: 0x00026E14
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 371159, RefRangeEnd = 371163, XrefRangeStart = 371159, XrefRangeEnd = 371159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(string input, string pattern, TimeSpan timeout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pattern);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeout;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexMatchTimeoutException.NativeMethodInfoPtr_Init_Private_Void_String_String_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x0000462F File Offset: 0x0000282F
		public RegexMatchTimeoutException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000648 RID: 1608 RVA: 0x00028C78 File Offset: 0x00026E78
		// (set) Token: 0x06000649 RID: 1609 RVA: 0x00004638 File Offset: 0x00002838
		public unsafe string regexInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexMatchTimeoutException.NativeFieldInfoPtr_regexInput);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexMatchTimeoutException.NativeFieldInfoPtr_regexInput), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x0600064A RID: 1610 RVA: 0x00028CA0 File Offset: 0x00026EA0
		// (set) Token: 0x0600064B RID: 1611 RVA: 0x00004657 File Offset: 0x00002857
		public unsafe string regexPattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexMatchTimeoutException.NativeFieldInfoPtr_regexPattern);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexMatchTimeoutException.NativeFieldInfoPtr_regexPattern), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x0600064C RID: 1612 RVA: 0x00028CC8 File Offset: 0x00026EC8
		// (set) Token: 0x0600064D RID: 1613 RVA: 0x00004676 File Offset: 0x00002876
		public unsafe TimeSpan matchTimeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexMatchTimeoutException.NativeFieldInfoPtr_matchTimeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexMatchTimeoutException.NativeFieldInfoPtr_matchTimeout)) = value;
			}
		}

		// Token: 0x040004AF RID: 1199
		private static readonly IntPtr NativeFieldInfoPtr_regexInput;

		// Token: 0x040004B0 RID: 1200
		private static readonly IntPtr NativeFieldInfoPtr_regexPattern;

		// Token: 0x040004B1 RID: 1201
		private static readonly IntPtr NativeFieldInfoPtr_matchTimeout;

		// Token: 0x040004B2 RID: 1202
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_TimeSpan_0;

		// Token: 0x040004B3 RID: 1203
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040004B4 RID: 1204
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040004B5 RID: 1205
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040004B6 RID: 1206
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

		// Token: 0x040004B7 RID: 1207
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_String_String_TimeSpan_0;
	}
}
