using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppI2.Loc
{
	// Token: 0x02000224 RID: 548
	public class RealTimeTranslation : MonoBehaviour
	{
		// Token: 0x06004257 RID: 16983 RVA: 0x000F66C8 File Offset: 0x000F48C8
		// Note: this type is marked as 'beforefieldinit'.
		static RealTimeTranslation()
		{
			Il2CppClassPointerStore<RealTimeTranslation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "RealTimeTranslation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RealTimeTranslation>.NativeClassPtr);
			RealTimeTranslation.NativeFieldInfoPtr_OriginalText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealTimeTranslation>.NativeClassPtr, "OriginalText");
			RealTimeTranslation.NativeFieldInfoPtr_TranslatedText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealTimeTranslation>.NativeClassPtr, "TranslatedText");
			RealTimeTranslation.NativeFieldInfoPtr_IsTranslating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealTimeTranslation>.NativeClassPtr, "IsTranslating");
			RealTimeTranslation.NativeMethodInfoPtr_OnGUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealTimeTranslation>.NativeClassPtr, 100669775);
			RealTimeTranslation.NativeMethodInfoPtr_StartTranslating_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealTimeTranslation>.NativeClassPtr, 100669776);
			RealTimeTranslation.NativeMethodInfoPtr_OnTranslationReady_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealTimeTranslation>.NativeClassPtr, 100669777);
			RealTimeTranslation.NativeMethodInfoPtr_ExampleMultiTranslations_Blocking_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealTimeTranslation>.NativeClassPtr, 100669778);
			RealTimeTranslation.NativeMethodInfoPtr_ExampleMultiTranslations_Async_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealTimeTranslation>.NativeClassPtr, 100669779);
			RealTimeTranslation.NativeMethodInfoPtr_OnMultitranslationReady_Private_Void_Dictionary_2_String_TranslationQuery_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealTimeTranslation>.NativeClassPtr, 100669780);
			RealTimeTranslation.NativeMethodInfoPtr_IsWaitingForTranslation_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealTimeTranslation>.NativeClassPtr, 100669781);
			RealTimeTranslation.NativeMethodInfoPtr_GetTranslatedText_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealTimeTranslation>.NativeClassPtr, 100669782);
			RealTimeTranslation.NativeMethodInfoPtr_SetOriginalText_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealTimeTranslation>.NativeClassPtr, 100669783);
			RealTimeTranslation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealTimeTranslation>.NativeClassPtr, 100669784);
		}

		// Token: 0x06004258 RID: 16984 RVA: 0x000F67FC File Offset: 0x000F49FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106564, XrefRangeEnd = 106647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealTimeTranslation.NativeMethodInfoPtr_OnGUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004259 RID: 16985 RVA: 0x000F6830 File Offset: 0x000F4A30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 106656, RefRangeEnd = 106658, XrefRangeStart = 106647, XrefRangeEnd = 106656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartTranslating(string fromCode, string toCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fromCode);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(toCode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealTimeTranslation.NativeMethodInfoPtr_StartTranslating_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600425A RID: 16986 RVA: 0x000F6884 File Offset: 0x000F4A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106658, XrefRangeEnd = 106659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTranslationReady(string Translation, string errorMsg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Translation);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(errorMsg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealTimeTranslation.NativeMethodInfoPtr_OnTranslationReady_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600425B RID: 16987 RVA: 0x000F68D8 File Offset: 0x000F4AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106659, XrefRangeEnd = 106711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExampleMultiTranslations_Blocking()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealTimeTranslation.NativeMethodInfoPtr_ExampleMultiTranslations_Blocking_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600425C RID: 16988 RVA: 0x000F690C File Offset: 0x000F4B0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 106744, RefRangeEnd = 106745, XrefRangeStart = 106711, XrefRangeEnd = 106744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExampleMultiTranslations_Async()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealTimeTranslation.NativeMethodInfoPtr_ExampleMultiTranslations_Async_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600425D RID: 16989 RVA: 0x000F6940 File Offset: 0x000F4B40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106745, XrefRangeEnd = 106779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMultitranslationReady(Dictionary<string, TranslationQuery> dict, string errorMsg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dict);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(errorMsg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealTimeTranslation.NativeMethodInfoPtr_OnMultitranslationReady_Private_Void_Dictionary_2_String_TranslationQuery_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600425E RID: 16990 RVA: 0x000F6994 File Offset: 0x000F4B94
		[CallerCount(0)]
		public unsafe bool IsWaitingForTranslation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealTimeTranslation.NativeMethodInfoPtr_IsWaitingForTranslation_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600425F RID: 16991 RVA: 0x000F69D0 File Offset: 0x000F4BD0
		[CallerCount(0)]
		public unsafe string GetTranslatedText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealTimeTranslation.NativeMethodInfoPtr_GetTranslatedText_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004260 RID: 16992 RVA: 0x000F6A08 File Offset: 0x000F4C08
		[CallerCount(58)]
		[CachedScanResults(RefRangeStart = 18562, RefRangeEnd = 18620, XrefRangeStart = 18562, XrefRangeEnd = 18620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOriginalText(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealTimeTranslation.NativeMethodInfoPtr_SetOriginalText_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004261 RID: 16993 RVA: 0x000F6A4C File Offset: 0x000F4C4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106779, XrefRangeEnd = 106786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RealTimeTranslation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RealTimeTranslation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealTimeTranslation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004262 RID: 16994 RVA: 0x00028797 File Offset: 0x00026997
		public RealTimeTranslation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170018FC RID: 6396
		// (get) Token: 0x06004263 RID: 16995 RVA: 0x000F6A88 File Offset: 0x000F4C88
		// (set) Token: 0x06004264 RID: 16996 RVA: 0x000287A0 File Offset: 0x000269A0
		public unsafe string OriginalText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealTimeTranslation.NativeFieldInfoPtr_OriginalText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealTimeTranslation.NativeFieldInfoPtr_OriginalText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170018FD RID: 6397
		// (get) Token: 0x06004265 RID: 16997 RVA: 0x000F6AB0 File Offset: 0x000F4CB0
		// (set) Token: 0x06004266 RID: 16998 RVA: 0x000287BF File Offset: 0x000269BF
		public unsafe string TranslatedText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealTimeTranslation.NativeFieldInfoPtr_TranslatedText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealTimeTranslation.NativeFieldInfoPtr_TranslatedText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170018FE RID: 6398
		// (get) Token: 0x06004267 RID: 16999 RVA: 0x000F6AD8 File Offset: 0x000F4CD8
		// (set) Token: 0x06004268 RID: 17000 RVA: 0x000287DE File Offset: 0x000269DE
		public unsafe bool IsTranslating
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealTimeTranslation.NativeFieldInfoPtr_IsTranslating);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealTimeTranslation.NativeFieldInfoPtr_IsTranslating)) = value;
			}
		}

		// Token: 0x040028BF RID: 10431
		private static readonly IntPtr NativeFieldInfoPtr_OriginalText;

		// Token: 0x040028C0 RID: 10432
		private static readonly IntPtr NativeFieldInfoPtr_TranslatedText;

		// Token: 0x040028C1 RID: 10433
		private static readonly IntPtr NativeFieldInfoPtr_IsTranslating;

		// Token: 0x040028C2 RID: 10434
		private static readonly IntPtr NativeMethodInfoPtr_OnGUI_Public_Void_0;

		// Token: 0x040028C3 RID: 10435
		private static readonly IntPtr NativeMethodInfoPtr_StartTranslating_Public_Void_String_String_0;

		// Token: 0x040028C4 RID: 10436
		private static readonly IntPtr NativeMethodInfoPtr_OnTranslationReady_Private_Void_String_String_0;

		// Token: 0x040028C5 RID: 10437
		private static readonly IntPtr NativeMethodInfoPtr_ExampleMultiTranslations_Blocking_Public_Void_0;

		// Token: 0x040028C6 RID: 10438
		private static readonly IntPtr NativeMethodInfoPtr_ExampleMultiTranslations_Async_Public_Void_0;

		// Token: 0x040028C7 RID: 10439
		private static readonly IntPtr NativeMethodInfoPtr_OnMultitranslationReady_Private_Void_Dictionary_2_String_TranslationQuery_String_0;

		// Token: 0x040028C8 RID: 10440
		private static readonly IntPtr NativeMethodInfoPtr_IsWaitingForTranslation_Public_Boolean_0;

		// Token: 0x040028C9 RID: 10441
		private static readonly IntPtr NativeMethodInfoPtr_GetTranslatedText_Public_String_0;

		// Token: 0x040028CA RID: 10442
		private static readonly IntPtr NativeMethodInfoPtr_SetOriginalText_Public_Void_String_0;

		// Token: 0x040028CB RID: 10443
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
