using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Windows.Speech
{
	// Token: 0x02000119 RID: 281
	public sealed class PhraseRecognizedEventArgs : ValueType
	{
		// Token: 0x06001746 RID: 5958 RVA: 0x00059FB4 File Offset: 0x000581B4
		// Note: this type is marked as 'beforefieldinit'.
		static PhraseRecognizedEventArgs()
		{
			Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Windows.Speech", "PhraseRecognizedEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr);
			PhraseRecognizedEventArgs.NativeFieldInfoPtr_confidence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr, "confidence");
			PhraseRecognizedEventArgs.NativeFieldInfoPtr_semanticMeanings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr, "semanticMeanings");
			PhraseRecognizedEventArgs.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr, "text");
			PhraseRecognizedEventArgs.NativeFieldInfoPtr_phraseStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr, "phraseStartTime");
			PhraseRecognizedEventArgs.NativeFieldInfoPtr_phraseDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr, "phraseDuration");
			PhraseRecognizedEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_String_ConfidenceLevel_Il2CppReferenceArray_1_SemanticMeaning_DateTime_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr, 100665385);
		}

		// Token: 0x06001747 RID: 5959 RVA: 0x0005A05C File Offset: 0x0005825C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 500417, RefRangeEnd = 500418, XrefRangeStart = 500417, XrefRangeEnd = 500417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PhraseRecognizedEventArgs(string text, ConfidenceLevel confidence, Il2CppReferenceArray<SemanticMeaning> semanticMeanings, DateTime phraseStartTime, TimeSpan phraseDuration)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref confidence;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(semanticMeanings);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref phraseStartTime;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref phraseDuration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhraseRecognizedEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_String_ConfidenceLevel_Il2CppReferenceArray_1_SemanticMeaning_DateTime_TimeSpan_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001748 RID: 5960 RVA: 0x0000C733 File Offset: 0x0000A933
		public PhraseRecognizedEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001749 RID: 5961 RVA: 0x0000C73C File Offset: 0x0000A93C
		public PhraseRecognizedEventArgs()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr))
		{
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x0600174A RID: 5962 RVA: 0x0005A0E8 File Offset: 0x000582E8
		// (set) Token: 0x0600174B RID: 5963 RVA: 0x0000C74E File Offset: 0x0000A94E
		public unsafe ConfidenceLevel confidence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhraseRecognizedEventArgs.NativeFieldInfoPtr_confidence);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhraseRecognizedEventArgs.NativeFieldInfoPtr_confidence)) = value;
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x0600174C RID: 5964 RVA: 0x0005A110 File Offset: 0x00058310
		// (set) Token: 0x0600174D RID: 5965 RVA: 0x0000C769 File Offset: 0x0000A969
		public unsafe Il2CppReferenceArray<SemanticMeaning> semanticMeanings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhraseRecognizedEventArgs.NativeFieldInfoPtr_semanticMeanings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SemanticMeaning>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhraseRecognizedEventArgs.NativeFieldInfoPtr_semanticMeanings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x0600174E RID: 5966 RVA: 0x0005A140 File Offset: 0x00058340
		// (set) Token: 0x0600174F RID: 5967 RVA: 0x0000C788 File Offset: 0x0000A988
		public unsafe string text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhraseRecognizedEventArgs.NativeFieldInfoPtr_text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhraseRecognizedEventArgs.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06001750 RID: 5968 RVA: 0x0005A168 File Offset: 0x00058368
		// (set) Token: 0x06001751 RID: 5969 RVA: 0x0000C7A7 File Offset: 0x0000A9A7
		public unsafe DateTime phraseStartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhraseRecognizedEventArgs.NativeFieldInfoPtr_phraseStartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhraseRecognizedEventArgs.NativeFieldInfoPtr_phraseStartTime)) = value;
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06001752 RID: 5970 RVA: 0x0005A190 File Offset: 0x00058390
		// (set) Token: 0x06001753 RID: 5971 RVA: 0x0000C7C2 File Offset: 0x0000A9C2
		public unsafe TimeSpan phraseDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhraseRecognizedEventArgs.NativeFieldInfoPtr_phraseDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhraseRecognizedEventArgs.NativeFieldInfoPtr_phraseDuration)) = value;
			}
		}

		// Token: 0x0400123C RID: 4668
		private static readonly IntPtr NativeFieldInfoPtr_confidence;

		// Token: 0x0400123D RID: 4669
		private static readonly IntPtr NativeFieldInfoPtr_semanticMeanings;

		// Token: 0x0400123E RID: 4670
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x0400123F RID: 4671
		private static readonly IntPtr NativeFieldInfoPtr_phraseStartTime;

		// Token: 0x04001240 RID: 4672
		private static readonly IntPtr NativeFieldInfoPtr_phraseDuration;

		// Token: 0x04001241 RID: 4673
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_ConfidenceLevel_Il2CppReferenceArray_1_SemanticMeaning_DateTime_TimeSpan_0;
	}
}
