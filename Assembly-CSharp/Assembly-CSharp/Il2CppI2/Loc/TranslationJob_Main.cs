using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppI2.Loc
{
	// Token: 0x02000235 RID: 565
	public class TranslationJob_Main : TranslationJob
	{
		// Token: 0x06004311 RID: 17169 RVA: 0x000F9658 File Offset: 0x000F7858
		// Note: this type is marked as 'beforefieldinit'.
		static TranslationJob_Main()
		{
			Il2CppClassPointerStore<TranslationJob_Main>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "TranslationJob_Main");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TranslationJob_Main>.NativeClassPtr);
			TranslationJob_Main.NativeFieldInfoPtr_mWeb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TranslationJob_Main>.NativeClassPtr, "mWeb");
			TranslationJob_Main.NativeFieldInfoPtr_mPost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TranslationJob_Main>.NativeClassPtr, "mPost");
			TranslationJob_Main.NativeFieldInfoPtr_mGet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TranslationJob_Main>.NativeClassPtr, "mGet");
			TranslationJob_Main.NativeFieldInfoPtr__requests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TranslationJob_Main>.NativeClassPtr, "_requests");
			TranslationJob_Main.NativeFieldInfoPtr__OnTranslationReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TranslationJob_Main>.NativeClassPtr, "_OnTranslationReady");
			TranslationJob_Main.NativeFieldInfoPtr_mErrorMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TranslationJob_Main>.NativeClassPtr, "mErrorMessage");
			TranslationJob_Main.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_String_TranslationQuery_fnOnTranslationReady_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TranslationJob_Main>.NativeClassPtr, 100669899);
			TranslationJob_Main.NativeMethodInfoPtr_GetState_Public_Virtual_eJobState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TranslationJob_Main>.NativeClassPtr, 100669900);
			TranslationJob_Main.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TranslationJob_Main>.NativeClassPtr, 100669901);
		}

		// Token: 0x06004312 RID: 17170 RVA: 0x000F973C File Offset: 0x000F793C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 108426, RefRangeEnd = 108430, XrefRangeStart = 108422, XrefRangeEnd = 108426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TranslationJob_Main(Dictionary<string, TranslationQuery> requests, GoogleTranslation.fnOnTranslationReady OnTranslationReady)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TranslationJob_Main>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(requests);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(OnTranslationReady);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TranslationJob_Main.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_String_TranslationQuery_fnOnTranslationReady_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004313 RID: 17171 RVA: 0x000F979C File Offset: 0x000F799C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108430, XrefRangeEnd = 108448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override TranslationJob.eJobState GetState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TranslationJob_Main.NativeMethodInfoPtr_GetState_Public_Virtual_eJobState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004314 RID: 17172 RVA: 0x000F97E4 File Offset: 0x000F79E4
		[CallerCount(0)]
		public unsafe override void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TranslationJob_Main.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004315 RID: 17173 RVA: 0x00028B4A File Offset: 0x00026D4A
		public TranslationJob_Main(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001914 RID: 6420
		// (get) Token: 0x06004316 RID: 17174 RVA: 0x000F9820 File Offset: 0x000F7A20
		// (set) Token: 0x06004317 RID: 17175 RVA: 0x00028B53 File Offset: 0x00026D53
		public unsafe TranslationJob_WEB mWeb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranslationJob_Main.NativeFieldInfoPtr_mWeb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TranslationJob_WEB>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranslationJob_Main.NativeFieldInfoPtr_mWeb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001915 RID: 6421
		// (get) Token: 0x06004318 RID: 17176 RVA: 0x000F9850 File Offset: 0x000F7A50
		// (set) Token: 0x06004319 RID: 17177 RVA: 0x00028B72 File Offset: 0x00026D72
		public unsafe TranslationJob_POST mPost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranslationJob_Main.NativeFieldInfoPtr_mPost);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TranslationJob_POST>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranslationJob_Main.NativeFieldInfoPtr_mPost), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001916 RID: 6422
		// (get) Token: 0x0600431A RID: 17178 RVA: 0x000F9880 File Offset: 0x000F7A80
		// (set) Token: 0x0600431B RID: 17179 RVA: 0x00028B91 File Offset: 0x00026D91
		public unsafe TranslationJob_GET mGet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranslationJob_Main.NativeFieldInfoPtr_mGet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TranslationJob_GET>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranslationJob_Main.NativeFieldInfoPtr_mGet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001917 RID: 6423
		// (get) Token: 0x0600431C RID: 17180 RVA: 0x000F98B0 File Offset: 0x000F7AB0
		// (set) Token: 0x0600431D RID: 17181 RVA: 0x00028BB0 File Offset: 0x00026DB0
		public unsafe Dictionary<string, TranslationQuery> _requests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranslationJob_Main.NativeFieldInfoPtr__requests);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, TranslationQuery>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranslationJob_Main.NativeFieldInfoPtr__requests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001918 RID: 6424
		// (get) Token: 0x0600431E RID: 17182 RVA: 0x000F98E0 File Offset: 0x000F7AE0
		// (set) Token: 0x0600431F RID: 17183 RVA: 0x00028BCF File Offset: 0x00026DCF
		public unsafe GoogleTranslation.fnOnTranslationReady _OnTranslationReady
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranslationJob_Main.NativeFieldInfoPtr__OnTranslationReady);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GoogleTranslation.fnOnTranslationReady>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranslationJob_Main.NativeFieldInfoPtr__OnTranslationReady), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001919 RID: 6425
		// (get) Token: 0x06004320 RID: 17184 RVA: 0x000F9910 File Offset: 0x000F7B10
		// (set) Token: 0x06004321 RID: 17185 RVA: 0x00028BEE File Offset: 0x00026DEE
		public unsafe string mErrorMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranslationJob_Main.NativeFieldInfoPtr_mErrorMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranslationJob_Main.NativeFieldInfoPtr_mErrorMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002947 RID: 10567
		private static readonly IntPtr NativeFieldInfoPtr_mWeb;

		// Token: 0x04002948 RID: 10568
		private static readonly IntPtr NativeFieldInfoPtr_mPost;

		// Token: 0x04002949 RID: 10569
		private static readonly IntPtr NativeFieldInfoPtr_mGet;

		// Token: 0x0400294A RID: 10570
		private static readonly IntPtr NativeFieldInfoPtr__requests;

		// Token: 0x0400294B RID: 10571
		private static readonly IntPtr NativeFieldInfoPtr__OnTranslationReady;

		// Token: 0x0400294C RID: 10572
		private static readonly IntPtr NativeFieldInfoPtr_mErrorMessage;

		// Token: 0x0400294D RID: 10573
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_String_TranslationQuery_fnOnTranslationReady_0;

		// Token: 0x0400294E RID: 10574
		private static readonly IntPtr NativeMethodInfoPtr_GetState_Public_Virtual_eJobState_0;

		// Token: 0x0400294F RID: 10575
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0;
	}
}
