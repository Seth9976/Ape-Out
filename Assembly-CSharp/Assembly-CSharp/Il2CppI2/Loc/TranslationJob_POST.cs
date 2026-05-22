using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppI2.Loc
{
	// Token: 0x02000236 RID: 566
	public class TranslationJob_POST : TranslationJob_WWW
	{
		// Token: 0x06004322 RID: 17186 RVA: 0x000F9938 File Offset: 0x000F7B38
		// Note: this type is marked as 'beforefieldinit'.
		static TranslationJob_POST()
		{
			Il2CppClassPointerStore<TranslationJob_POST>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "TranslationJob_POST");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TranslationJob_POST>.NativeClassPtr);
			TranslationJob_POST.NativeFieldInfoPtr__requests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TranslationJob_POST>.NativeClassPtr, "_requests");
			TranslationJob_POST.NativeFieldInfoPtr__OnTranslationReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TranslationJob_POST>.NativeClassPtr, "_OnTranslationReady");
			TranslationJob_POST.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_String_TranslationQuery_fnOnTranslationReady_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TranslationJob_POST>.NativeClassPtr, 100669902);
			TranslationJob_POST.NativeMethodInfoPtr_GetState_Public_Virtual_eJobState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TranslationJob_POST>.NativeClassPtr, 100669903);
			TranslationJob_POST.NativeMethodInfoPtr_ProcessResult_Public_Void_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TranslationJob_POST>.NativeClassPtr, 100669904);
		}

		// Token: 0x06004323 RID: 17187 RVA: 0x000F99CC File Offset: 0x000F7BCC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 108473, RefRangeEnd = 108475, XrefRangeStart = 108448, XrefRangeEnd = 108473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TranslationJob_POST(Dictionary<string, TranslationQuery> requests, GoogleTranslation.fnOnTranslationReady OnTranslationReady)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TranslationJob_POST>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(requests);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(OnTranslationReady);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TranslationJob_POST.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_String_TranslationQuery_fnOnTranslationReady_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004324 RID: 17188 RVA: 0x000F9A2C File Offset: 0x000F7C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108475, XrefRangeEnd = 108487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override TranslationJob.eJobState GetState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TranslationJob_POST.NativeMethodInfoPtr_GetState_Public_Virtual_eJobState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004325 RID: 17189 RVA: 0x000F9A74 File Offset: 0x000F7C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108487, XrefRangeEnd = 108488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TranslationJob_POST.NativeMethodInfoPtr_ProcessResult_Public_Void_Il2CppStructArray_1_Byte_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004326 RID: 17190 RVA: 0x00028C0D File Offset: 0x00026E0D
		public TranslationJob_POST(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700191A RID: 6426
		// (get) Token: 0x06004327 RID: 17191 RVA: 0x000F9AC8 File Offset: 0x000F7CC8
		// (set) Token: 0x06004328 RID: 17192 RVA: 0x00028C16 File Offset: 0x00026E16
		public unsafe Dictionary<string, TranslationQuery> _requests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranslationJob_POST.NativeFieldInfoPtr__requests);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, TranslationQuery>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranslationJob_POST.NativeFieldInfoPtr__requests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700191B RID: 6427
		// (get) Token: 0x06004329 RID: 17193 RVA: 0x000F9AF8 File Offset: 0x000F7CF8
		// (set) Token: 0x0600432A RID: 17194 RVA: 0x00028C35 File Offset: 0x00026E35
		public unsafe GoogleTranslation.fnOnTranslationReady _OnTranslationReady
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranslationJob_POST.NativeFieldInfoPtr__OnTranslationReady);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GoogleTranslation.fnOnTranslationReady>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranslationJob_POST.NativeFieldInfoPtr__OnTranslationReady), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002950 RID: 10576
		private static readonly IntPtr NativeFieldInfoPtr__requests;

		// Token: 0x04002951 RID: 10577
		private static readonly IntPtr NativeFieldInfoPtr__OnTranslationReady;

		// Token: 0x04002952 RID: 10578
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_String_TranslationQuery_fnOnTranslationReady_0;

		// Token: 0x04002953 RID: 10579
		private static readonly IntPtr NativeMethodInfoPtr_GetState_Public_Virtual_eJobState_0;

		// Token: 0x04002954 RID: 10580
		private static readonly IntPtr NativeMethodInfoPtr_ProcessResult_Public_Void_Il2CppStructArray_1_Byte_String_0;
	}
}
