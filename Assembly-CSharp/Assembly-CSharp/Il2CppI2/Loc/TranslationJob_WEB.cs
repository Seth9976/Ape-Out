using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text.RegularExpressions;

namespace Il2CppI2.Loc
{
	// Token: 0x02000237 RID: 567
	public class TranslationJob_WEB : TranslationJob_WWW
	{
		// Token: 0x0600432B RID: 17195 RVA: 0x000F9B28 File Offset: 0x000F7D28
		// Note: this type is marked as 'beforefieldinit'.
		static TranslationJob_WEB()
		{
			Il2CppClassPointerStore<TranslationJob_WEB>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "TranslationJob_WEB");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TranslationJob_WEB>.NativeClassPtr);
			TranslationJob_WEB.NativeFieldInfoPtr__requests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TranslationJob_WEB>.NativeClassPtr, "_requests");
			TranslationJob_WEB.NativeFieldInfoPtr__OnTranslationReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TranslationJob_WEB>.NativeClassPtr, "_OnTranslationReady");
			TranslationJob_WEB.NativeFieldInfoPtr_mErrorMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TranslationJob_WEB>.NativeClassPtr, "mErrorMessage");
			TranslationJob_WEB.NativeFieldInfoPtr_mCurrentBatch_ToLanguageCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TranslationJob_WEB>.NativeClassPtr, "mCurrentBatch_ToLanguageCode");
			TranslationJob_WEB.NativeFieldInfoPtr_mCurrentBatch_FromLanguageCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TranslationJob_WEB>.NativeClassPtr, "mCurrentBatch_FromLanguageCode");
			TranslationJob_WEB.NativeFieldInfoPtr_mCurrentBatch_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TranslationJob_WEB>.NativeClassPtr, "mCurrentBatch_Text");
			TranslationJob_WEB.NativeFieldInfoPtr_mQueries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TranslationJob_WEB>.NativeClassPtr, "mQueries");
			TranslationJob_WEB.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_String_TranslationQuery_fnOnTranslationReady_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TranslationJob_WEB>.NativeClassPtr, 100669905);
			TranslationJob_WEB.NativeMethodInfoPtr_FindAllQueries_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TranslationJob_WEB>.NativeClassPtr, 100669906);
			TranslationJob_WEB.NativeMethodInfoPtr_ExecuteNextBatch_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TranslationJob_WEB>.NativeClassPtr, 100669907);
			TranslationJob_WEB.NativeMethodInfoPtr_GetState_Public_Virtual_eJobState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TranslationJob_WEB>.NativeClassPtr, 100669908);
			TranslationJob_WEB.NativeMethodInfoPtr_ProcessResult_Public_Void_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TranslationJob_WEB>.NativeClassPtr, 100669909);
			TranslationJob_WEB.NativeMethodInfoPtr_ParseTranslationResult_Private_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TranslationJob_WEB>.NativeClassPtr, 100669910);
		}

		// Token: 0x0600432C RID: 17196 RVA: 0x000F9C5C File Offset: 0x000F7E5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108509, XrefRangeEnd = 108511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TranslationJob_WEB(Dictionary<string, TranslationQuery> requests, GoogleTranslation.fnOnTranslationReady OnTranslationReady)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TranslationJob_WEB>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(requests);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(OnTranslationReady);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TranslationJob_WEB.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_String_TranslationQuery_fnOnTranslationReady_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600432D RID: 17197 RVA: 0x000F9CBC File Offset: 0x000F7EBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108553, RefRangeEnd = 108554, XrefRangeStart = 108511, XrefRangeEnd = 108553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FindAllQueries()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TranslationJob_WEB.NativeMethodInfoPtr_FindAllQueries_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600432E RID: 17198 RVA: 0x000F9CF0 File Offset: 0x000F7EF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 108607, RefRangeEnd = 108609, XrefRangeStart = 108554, XrefRangeEnd = 108607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecuteNextBatch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TranslationJob_WEB.NativeMethodInfoPtr_ExecuteNextBatch_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600432F RID: 17199 RVA: 0x000F9D24 File Offset: 0x000F7F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108609, XrefRangeEnd = 108625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override TranslationJob.eJobState GetState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TranslationJob_WEB.NativeMethodInfoPtr_GetState_Public_Virtual_eJobState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004330 RID: 17200 RVA: 0x000F9D6C File Offset: 0x000F7F6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108625, XrefRangeEnd = 108633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TranslationJob_WEB.NativeMethodInfoPtr_ProcessResult_Public_Void_Il2CppStructArray_1_Byte_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004331 RID: 17201 RVA: 0x000F9DC0 File Offset: 0x000F7FC0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 108715, RefRangeEnd = 108717, XrefRangeStart = 108633, XrefRangeEnd = 108715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ParseTranslationResult(string html, string OriginalText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(html);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(OriginalText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TranslationJob_WEB.NativeMethodInfoPtr_ParseTranslationResult_Private_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004332 RID: 17202 RVA: 0x00028C54 File Offset: 0x00026E54
		public TranslationJob_WEB(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700191C RID: 6428
		// (get) Token: 0x06004333 RID: 17203 RVA: 0x000F9E1C File Offset: 0x000F801C
		// (set) Token: 0x06004334 RID: 17204 RVA: 0x00028C5D File Offset: 0x00026E5D
		public unsafe Dictionary<string, TranslationQuery> _requests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranslationJob_WEB.NativeFieldInfoPtr__requests);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, TranslationQuery>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranslationJob_WEB.NativeFieldInfoPtr__requests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700191D RID: 6429
		// (get) Token: 0x06004335 RID: 17205 RVA: 0x000F9E4C File Offset: 0x000F804C
		// (set) Token: 0x06004336 RID: 17206 RVA: 0x00028C7C File Offset: 0x00026E7C
		public unsafe GoogleTranslation.fnOnTranslationReady _OnTranslationReady
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranslationJob_WEB.NativeFieldInfoPtr__OnTranslationReady);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GoogleTranslation.fnOnTranslationReady>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranslationJob_WEB.NativeFieldInfoPtr__OnTranslationReady), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700191E RID: 6430
		// (get) Token: 0x06004337 RID: 17207 RVA: 0x000F9E7C File Offset: 0x000F807C
		// (set) Token: 0x06004338 RID: 17208 RVA: 0x00028C9B File Offset: 0x00026E9B
		public unsafe string mErrorMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranslationJob_WEB.NativeFieldInfoPtr_mErrorMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranslationJob_WEB.NativeFieldInfoPtr_mErrorMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700191F RID: 6431
		// (get) Token: 0x06004339 RID: 17209 RVA: 0x000F9EA4 File Offset: 0x000F80A4
		// (set) Token: 0x0600433A RID: 17210 RVA: 0x00028CBA File Offset: 0x00026EBA
		public unsafe string mCurrentBatch_ToLanguageCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranslationJob_WEB.NativeFieldInfoPtr_mCurrentBatch_ToLanguageCode);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranslationJob_WEB.NativeFieldInfoPtr_mCurrentBatch_ToLanguageCode), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001920 RID: 6432
		// (get) Token: 0x0600433B RID: 17211 RVA: 0x000F9ECC File Offset: 0x000F80CC
		// (set) Token: 0x0600433C RID: 17212 RVA: 0x00028CD9 File Offset: 0x00026ED9
		public unsafe string mCurrentBatch_FromLanguageCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranslationJob_WEB.NativeFieldInfoPtr_mCurrentBatch_FromLanguageCode);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranslationJob_WEB.NativeFieldInfoPtr_mCurrentBatch_FromLanguageCode), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001921 RID: 6433
		// (get) Token: 0x0600433D RID: 17213 RVA: 0x000F9EF4 File Offset: 0x000F80F4
		// (set) Token: 0x0600433E RID: 17214 RVA: 0x00028CF8 File Offset: 0x00026EF8
		public unsafe List<string> mCurrentBatch_Text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranslationJob_WEB.NativeFieldInfoPtr_mCurrentBatch_Text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranslationJob_WEB.NativeFieldInfoPtr_mCurrentBatch_Text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001922 RID: 6434
		// (get) Token: 0x0600433F RID: 17215 RVA: 0x000F9F24 File Offset: 0x000F8124
		// (set) Token: 0x06004340 RID: 17216 RVA: 0x00028D17 File Offset: 0x00026F17
		public unsafe List<KeyValuePair<string, string>> mQueries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranslationJob_WEB.NativeFieldInfoPtr_mQueries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<KeyValuePair<string, string>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranslationJob_WEB.NativeFieldInfoPtr_mQueries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002955 RID: 10581
		private static readonly IntPtr NativeFieldInfoPtr__requests;

		// Token: 0x04002956 RID: 10582
		private static readonly IntPtr NativeFieldInfoPtr__OnTranslationReady;

		// Token: 0x04002957 RID: 10583
		private static readonly IntPtr NativeFieldInfoPtr_mErrorMessage;

		// Token: 0x04002958 RID: 10584
		private static readonly IntPtr NativeFieldInfoPtr_mCurrentBatch_ToLanguageCode;

		// Token: 0x04002959 RID: 10585
		private static readonly IntPtr NativeFieldInfoPtr_mCurrentBatch_FromLanguageCode;

		// Token: 0x0400295A RID: 10586
		private static readonly IntPtr NativeFieldInfoPtr_mCurrentBatch_Text;

		// Token: 0x0400295B RID: 10587
		private static readonly IntPtr NativeFieldInfoPtr_mQueries;

		// Token: 0x0400295C RID: 10588
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_String_TranslationQuery_fnOnTranslationReady_0;

		// Token: 0x0400295D RID: 10589
		private static readonly IntPtr NativeMethodInfoPtr_FindAllQueries_Private_Void_0;

		// Token: 0x0400295E RID: 10590
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteNextBatch_Private_Void_0;

		// Token: 0x0400295F RID: 10591
		private static readonly IntPtr NativeMethodInfoPtr_GetState_Public_Virtual_eJobState_0;

		// Token: 0x04002960 RID: 10592
		private static readonly IntPtr NativeMethodInfoPtr_ProcessResult_Public_Void_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x04002961 RID: 10593
		private static readonly IntPtr NativeMethodInfoPtr_ParseTranslationResult_Private_String_String_String_0;

		// Token: 0x020003BC RID: 956
		[ObfuscatedName("I2.Loc.TranslationJob_WEB+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060059C4 RID: 22980 RVA: 0x001449C8 File Offset: 0x00142BC8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TranslationJob_WEB.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TranslationJob_WEB>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TranslationJob_WEB.__c>.NativeClassPtr);
				TranslationJob_WEB.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TranslationJob_WEB.__c>.NativeClassPtr, "<>9");
				TranslationJob_WEB.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TranslationJob_WEB.__c>.NativeClassPtr, "<>9__8_0");
				TranslationJob_WEB.__c.NativeFieldInfoPtr___9__12_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TranslationJob_WEB.__c>.NativeClassPtr, "<>9__12_0");
				TranslationJob_WEB.__c.NativeFieldInfoPtr___9__12_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TranslationJob_WEB.__c>.NativeClassPtr, "<>9__12_1");
				TranslationJob_WEB.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TranslationJob_WEB.__c>.NativeClassPtr, 100669912);
				TranslationJob_WEB.__c.NativeMethodInfoPtr__FindAllQueries_b__8_0_Internal_Int32_KeyValuePair_2_String_String_KeyValuePair_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TranslationJob_WEB.__c>.NativeClassPtr, 100669913);
				TranslationJob_WEB.__c.NativeMethodInfoPtr__ParseTranslationResult_b__12_0_Internal_String_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TranslationJob_WEB.__c>.NativeClassPtr, 100669914);
				TranslationJob_WEB.__c.NativeMethodInfoPtr__ParseTranslationResult_b__12_1_Internal_String_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TranslationJob_WEB.__c>.NativeClassPtr, 100669915);
			}

			// Token: 0x060059C5 RID: 22981 RVA: 0x00144A94 File Offset: 0x00142C94
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TranslationJob_WEB.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TranslationJob_WEB.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060059C6 RID: 22982 RVA: 0x00144AD0 File Offset: 0x00142CD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108488, XrefRangeEnd = 108491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _FindAllQueries_b__8_0(KeyValuePair<string, string> a, KeyValuePair<string, string> b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(a));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(b));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TranslationJob_WEB.__c.NativeMethodInfoPtr__FindAllQueries_b__8_0_Internal_Int32_KeyValuePair_2_String_String_KeyValuePair_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060059C7 RID: 22983 RVA: 0x00144B3C File Offset: 0x00142D3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108491, XrefRangeEnd = 108500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ParseTranslationResult_b__12_0(Match match)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TranslationJob_WEB.__c.NativeMethodInfoPtr__ParseTranslationResult_b__12_0_Internal_String_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060059C8 RID: 22984 RVA: 0x00144B84 File Offset: 0x00142D84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108500, XrefRangeEnd = 108509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ParseTranslationResult_b__12_1(Match match)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TranslationJob_WEB.__c.NativeMethodInfoPtr__ParseTranslationResult_b__12_1_Internal_String_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060059C9 RID: 22985 RVA: 0x0003366F File Offset: 0x0003186F
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170020C6 RID: 8390
			// (get) Token: 0x060059CA RID: 22986 RVA: 0x00144BCC File Offset: 0x00142DCC
			// (set) Token: 0x060059CB RID: 22987 RVA: 0x00033678 File Offset: 0x00031878
			public unsafe static TranslationJob_WEB.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TranslationJob_WEB.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TranslationJob_WEB.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TranslationJob_WEB.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170020C7 RID: 8391
			// (get) Token: 0x060059CC RID: 22988 RVA: 0x00144BF4 File Offset: 0x00142DF4
			// (set) Token: 0x060059CD RID: 22989 RVA: 0x0003368A File Offset: 0x0003188A
			public unsafe static Comparison<KeyValuePair<string, string>> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TranslationJob_WEB.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<KeyValuePair<string, string>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TranslationJob_WEB.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170020C8 RID: 8392
			// (get) Token: 0x060059CE RID: 22990 RVA: 0x00144C1C File Offset: 0x00142E1C
			// (set) Token: 0x060059CF RID: 22991 RVA: 0x0003369C File Offset: 0x0003189C
			public unsafe static MatchEvaluator __9__12_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TranslationJob_WEB.__c.NativeFieldInfoPtr___9__12_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MatchEvaluator>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TranslationJob_WEB.__c.NativeFieldInfoPtr___9__12_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170020C9 RID: 8393
			// (get) Token: 0x060059D0 RID: 22992 RVA: 0x00144C44 File Offset: 0x00142E44
			// (set) Token: 0x060059D1 RID: 22993 RVA: 0x000336AE File Offset: 0x000318AE
			public unsafe static MatchEvaluator __9__12_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TranslationJob_WEB.__c.NativeFieldInfoPtr___9__12_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MatchEvaluator>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TranslationJob_WEB.__c.NativeFieldInfoPtr___9__12_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003B99 RID: 15257
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003B9A RID: 15258
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x04003B9B RID: 15259
			private static readonly IntPtr NativeFieldInfoPtr___9__12_0;

			// Token: 0x04003B9C RID: 15260
			private static readonly IntPtr NativeFieldInfoPtr___9__12_1;

			// Token: 0x04003B9D RID: 15261
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003B9E RID: 15262
			private static readonly IntPtr NativeMethodInfoPtr__FindAllQueries_b__8_0_Internal_Int32_KeyValuePair_2_String_String_KeyValuePair_2_String_String_0;

			// Token: 0x04003B9F RID: 15263
			private static readonly IntPtr NativeMethodInfoPtr__ParseTranslationResult_b__12_0_Internal_String_Match_0;

			// Token: 0x04003BA0 RID: 15264
			private static readonly IntPtr NativeMethodInfoPtr__ParseTranslationResult_b__12_1_Internal_String_Match_0;
		}
	}
}
