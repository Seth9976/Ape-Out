using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppI2.Loc
{
	// Token: 0x02000234 RID: 564
	public class TranslationJob_GET : TranslationJob_WWW
	{
		// Token: 0x06004303 RID: 17155 RVA: 0x000F93A0 File Offset: 0x000F75A0
		// Note: this type is marked as 'beforefieldinit'.
		static TranslationJob_GET()
		{
			Il2CppClassPointerStore<TranslationJob_GET>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "TranslationJob_GET");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TranslationJob_GET>.NativeClassPtr);
			TranslationJob_GET.NativeFieldInfoPtr__requests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TranslationJob_GET>.NativeClassPtr, "_requests");
			TranslationJob_GET.NativeFieldInfoPtr__OnTranslationReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TranslationJob_GET>.NativeClassPtr, "_OnTranslationReady");
			TranslationJob_GET.NativeFieldInfoPtr_mQueries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TranslationJob_GET>.NativeClassPtr, "mQueries");
			TranslationJob_GET.NativeFieldInfoPtr_mErrorMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TranslationJob_GET>.NativeClassPtr, "mErrorMessage");
			TranslationJob_GET.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_String_TranslationQuery_fnOnTranslationReady_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TranslationJob_GET>.NativeClassPtr, 100669895);
			TranslationJob_GET.NativeMethodInfoPtr_ExecuteNextQuery_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TranslationJob_GET>.NativeClassPtr, 100669896);
			TranslationJob_GET.NativeMethodInfoPtr_GetState_Public_Virtual_eJobState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TranslationJob_GET>.NativeClassPtr, 100669897);
			TranslationJob_GET.NativeMethodInfoPtr_ProcessResult_Public_Void_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TranslationJob_GET>.NativeClassPtr, 100669898);
		}

		// Token: 0x06004304 RID: 17156 RVA: 0x000F9470 File Offset: 0x000F7670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108373, XrefRangeEnd = 108377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TranslationJob_GET(Dictionary<string, TranslationQuery> requests, GoogleTranslation.fnOnTranslationReady OnTranslationReady)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TranslationJob_GET>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(requests);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(OnTranslationReady);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TranslationJob_GET.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_String_TranslationQuery_fnOnTranslationReady_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004305 RID: 17157 RVA: 0x000F94D0 File Offset: 0x000F76D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108377, XrefRangeEnd = 108391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecuteNextQuery()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TranslationJob_GET.NativeMethodInfoPtr_ExecuteNextQuery_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004306 RID: 17158 RVA: 0x000F9504 File Offset: 0x000F7704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108391, XrefRangeEnd = 108417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override TranslationJob.eJobState GetState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TranslationJob_GET.NativeMethodInfoPtr_GetState_Public_Virtual_eJobState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004307 RID: 17159 RVA: 0x000F954C File Offset: 0x000F774C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108417, XrefRangeEnd = 108422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessResult(Il2CppStructArray<byte> bytes, string errorMsg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(errorMsg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TranslationJob_GET.NativeMethodInfoPtr_ProcessResult_Public_Void_Il2CppStructArray_1_Byte_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004308 RID: 17160 RVA: 0x00028AC5 File Offset: 0x00026CC5
		public TranslationJob_GET(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001910 RID: 6416
		// (get) Token: 0x06004309 RID: 17161 RVA: 0x000F95A0 File Offset: 0x000F77A0
		// (set) Token: 0x0600430A RID: 17162 RVA: 0x00028ACE File Offset: 0x00026CCE
		public unsafe Dictionary<string, TranslationQuery> _requests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranslationJob_GET.NativeFieldInfoPtr__requests);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, TranslationQuery>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranslationJob_GET.NativeFieldInfoPtr__requests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001911 RID: 6417
		// (get) Token: 0x0600430B RID: 17163 RVA: 0x000F95D0 File Offset: 0x000F77D0
		// (set) Token: 0x0600430C RID: 17164 RVA: 0x00028AED File Offset: 0x00026CED
		public unsafe GoogleTranslation.fnOnTranslationReady _OnTranslationReady
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranslationJob_GET.NativeFieldInfoPtr__OnTranslationReady);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GoogleTranslation.fnOnTranslationReady>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranslationJob_GET.NativeFieldInfoPtr__OnTranslationReady), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001912 RID: 6418
		// (get) Token: 0x0600430D RID: 17165 RVA: 0x000F9600 File Offset: 0x000F7800
		// (set) Token: 0x0600430E RID: 17166 RVA: 0x00028B0C File Offset: 0x00026D0C
		public unsafe List<string> mQueries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranslationJob_GET.NativeFieldInfoPtr_mQueries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranslationJob_GET.NativeFieldInfoPtr_mQueries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001913 RID: 6419
		// (get) Token: 0x0600430F RID: 17167 RVA: 0x000F9630 File Offset: 0x000F7830
		// (set) Token: 0x06004310 RID: 17168 RVA: 0x00028B2B File Offset: 0x00026D2B
		public unsafe string mErrorMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranslationJob_GET.NativeFieldInfoPtr_mErrorMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranslationJob_GET.NativeFieldInfoPtr_mErrorMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400293F RID: 10559
		private static readonly IntPtr NativeFieldInfoPtr__requests;

		// Token: 0x04002940 RID: 10560
		private static readonly IntPtr NativeFieldInfoPtr__OnTranslationReady;

		// Token: 0x04002941 RID: 10561
		private static readonly IntPtr NativeFieldInfoPtr_mQueries;

		// Token: 0x04002942 RID: 10562
		private static readonly IntPtr NativeFieldInfoPtr_mErrorMessage;

		// Token: 0x04002943 RID: 10563
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_String_TranslationQuery_fnOnTranslationReady_0;

		// Token: 0x04002944 RID: 10564
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteNextQuery_Private_Void_0;

		// Token: 0x04002945 RID: 10565
		private static readonly IntPtr NativeMethodInfoPtr_GetState_Public_Virtual_eJobState_0;

		// Token: 0x04002946 RID: 10566
		private static readonly IntPtr NativeMethodInfoPtr_ProcessResult_Public_Void_Il2CppStructArray_1_Byte_String_0;
	}
}
