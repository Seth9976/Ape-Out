using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Il2CppAudioHelm
{
	// Token: 0x02000283 RID: 643
	public static class Native : Object
	{
		// Token: 0x060047B1 RID: 18353 RVA: 0x0010BC04 File Offset: 0x00109E04
		// Note: this type is marked as 'beforefieldinit'.
		static Native()
		{
			Il2CppClassPointerStore<Native>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AudioHelm", "Native");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Native>.NativeClassPtr);
			Native.NativeMethodInfoPtr_HelmNoteOn_Public_Static_Void_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100670666);
			Native.NativeMethodInfoPtr_HelmNoteOff_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100670667);
			Native.NativeMethodInfoPtr_HelmFrequencyOn_Public_Static_Void_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100670668);
			Native.NativeMethodInfoPtr_HelmFrequencyOff_Public_Static_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100670669);
			Native.NativeMethodInfoPtr_HelmAllNotesOff_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100670670);
			Native.NativeMethodInfoPtr_HelmSetPitchWheel_Public_Static_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100670671);
			Native.NativeMethodInfoPtr_HelmSetModWheel_Public_Static_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100670672);
			Native.NativeMethodInfoPtr_HelmSetAftertouch_Public_Static_Void_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100670673);
			Native.NativeMethodInfoPtr_HelmClearModulations_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100670674);
			Native.NativeMethodInfoPtr_HelmAddModulation_Public_Static_Void_Int32_Int32_String_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100670675);
			Native.NativeMethodInfoPtr_HelmGetParameterMinimum_Public_Static_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100670676);
			Native.NativeMethodInfoPtr_HelmGetParameterMaximum_Public_Static_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100670677);
			Native.NativeMethodInfoPtr_HelmGetParameterValue_Public_Static_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100670678);
			Native.NativeMethodInfoPtr_HelmSetParameterValue_Public_Static_Boolean_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100670679);
			Native.NativeMethodInfoPtr_HelmGetParameterPercent_Public_Static_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100670680);
			Native.NativeMethodInfoPtr_HelmSetParameterPercent_Public_Static_Boolean_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100670681);
			Native.NativeMethodInfoPtr_HelmSilence_Public_Static_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100670682);
			Native.NativeMethodInfoPtr_HelmGetBufferData_Public_Static_Boolean_Int32_Il2CppStructArray_1_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100670683);
			Native.NativeMethodInfoPtr_SetBpm_Public_Static_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100670684);
			Native.NativeMethodInfoPtr_CreateSequencer_Public_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100670685);
			Native.NativeMethodInfoPtr_DeleteSequencer_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100670686);
			Native.NativeMethodInfoPtr_EnableSequencer_Public_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100670687);
			Native.NativeMethodInfoPtr_ChangeSequencerLength_Public_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100670688);
			Native.NativeMethodInfoPtr_LoopSequencer_Public_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100670689);
			Native.NativeMethodInfoPtr_ChangeSequencerChannel_Public_Static_Boolean_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100670690);
			Native.NativeMethodInfoPtr_SetSequencerStart_Public_Static_Void_IntPtr_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100670691);
			Native.NativeMethodInfoPtr_CreateNote_Public_Static_IntPtr_IntPtr_Int32_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100670692);
			Native.NativeMethodInfoPtr_DeleteNote_Public_Static_IntPtr_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100670693);
			Native.NativeMethodInfoPtr_ChangeNoteStart_Public_Static_IntPtr_IntPtr_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100670694);
			Native.NativeMethodInfoPtr_ChangeNoteEnd_Public_Static_IntPtr_IntPtr_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100670695);
			Native.NativeMethodInfoPtr_ChangeNoteValues_Public_Static_IntPtr_IntPtr_IntPtr_Int32_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100670696);
			Native.NativeMethodInfoPtr_ChangeNoteKey_Public_Static_IntPtr_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100670697);
			Native.NativeMethodInfoPtr_ChangeNoteVelocity_Public_Static_IntPtr_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100670698);
			Native.NativeMethodInfoPtr_SetBeatTime_Public_Static_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100670699);
			Native.NativeMethodInfoPtr_Pause_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100670700);
		}

		// Token: 0x060047B2 RID: 18354 RVA: 0x0010BEF0 File Offset: 0x0010A0F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116933, XrefRangeEnd = 116935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void HelmNoteOn(int channel, int note, float velocity)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref note;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_HelmNoteOn_Public_Static_Void_Int32_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047B3 RID: 18355 RVA: 0x0010BF40 File Offset: 0x0010A140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116935, XrefRangeEnd = 116937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void HelmNoteOff(int channel, int note)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref note;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_HelmNoteOff_Public_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047B4 RID: 18356 RVA: 0x0010BF80 File Offset: 0x0010A180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116937, XrefRangeEnd = 116939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void HelmFrequencyOn(int channel, float frequency, float velocity)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref frequency;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_HelmFrequencyOn_Public_Static_Void_Int32_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047B5 RID: 18357 RVA: 0x0010BFD0 File Offset: 0x0010A1D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116939, XrefRangeEnd = 116941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void HelmFrequencyOff(int channel, float frequency)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref frequency;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_HelmFrequencyOff_Public_Static_Void_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047B6 RID: 18358 RVA: 0x0010C010 File Offset: 0x0010A210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116941, XrefRangeEnd = 116943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void HelmAllNotesOff(int channel)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_HelmAllNotesOff_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060047B7 RID: 18359 RVA: 0x0010C044 File Offset: 0x0010A244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116943, XrefRangeEnd = 116945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void HelmSetPitchWheel(int channel, float value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_HelmSetPitchWheel_Public_Static_Void_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047B8 RID: 18360 RVA: 0x0010C084 File Offset: 0x0010A284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116945, XrefRangeEnd = 116947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void HelmSetModWheel(int channel, float value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_HelmSetModWheel_Public_Static_Void_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047B9 RID: 18361 RVA: 0x0010C0C4 File Offset: 0x0010A2C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116947, XrefRangeEnd = 116949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void HelmSetAftertouch(int channel, int note, float value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref note;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_HelmSetAftertouch_Public_Static_Void_Int32_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047BA RID: 18362 RVA: 0x0010C114 File Offset: 0x0010A314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116949, XrefRangeEnd = 116951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void HelmClearModulations(int channel)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_HelmClearModulations_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060047BB RID: 18363 RVA: 0x0010C148 File Offset: 0x0010A348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116951, XrefRangeEnd = 116954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void HelmAddModulation(int channel, int index, string source, string dest, float amount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(source);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dest);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_HelmAddModulation_Public_Static_Void_Int32_Int32_String_String_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047BC RID: 18364 RVA: 0x0010C1BC File Offset: 0x0010A3BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116954, XrefRangeEnd = 116956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float HelmGetParameterMinimum(int index)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_HelmGetParameterMinimum_Public_Static_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060047BD RID: 18365 RVA: 0x0010C1FC File Offset: 0x0010A3FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116956, XrefRangeEnd = 116958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float HelmGetParameterMaximum(int index)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_HelmGetParameterMaximum_Public_Static_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060047BE RID: 18366 RVA: 0x0010C23C File Offset: 0x0010A43C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116958, XrefRangeEnd = 116960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float HelmGetParameterValue(int channel, int paramIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref paramIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_HelmGetParameterValue_Public_Static_Single_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047BF RID: 18367 RVA: 0x0010C288 File Offset: 0x0010A488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116960, XrefRangeEnd = 116962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HelmSetParameterValue(int channel, int paramIndex, float newValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref paramIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_HelmSetParameterValue_Public_Static_Boolean_Int32_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047C0 RID: 18368 RVA: 0x0010C2E4 File Offset: 0x0010A4E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116962, XrefRangeEnd = 116964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float HelmGetParameterPercent(int channel, int paramIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref paramIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_HelmGetParameterPercent_Public_Static_Single_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047C1 RID: 18369 RVA: 0x0010C330 File Offset: 0x0010A530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116964, XrefRangeEnd = 116966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HelmSetParameterPercent(int channel, int paramIndex, float newPercent)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref paramIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newPercent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_HelmSetParameterPercent_Public_Static_Boolean_Int32_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047C2 RID: 18370 RVA: 0x0010C38C File Offset: 0x0010A58C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116966, XrefRangeEnd = 116968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HelmSilence(int channel, bool silent)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref silent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_HelmSilence_Public_Static_Boolean_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047C3 RID: 18371 RVA: 0x0010C3D8 File Offset: 0x0010A5D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116968, XrefRangeEnd = 116970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HelmGetBufferData(int channel, Il2CppStructArray<float> buffer, int samples, int numAudioChannels)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref samples;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numAudioChannels;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_HelmGetBufferData_Public_Static_Boolean_Int32_Il2CppStructArray_1_Single_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047C4 RID: 18372 RVA: 0x0010C444 File Offset: 0x0010A644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116970, XrefRangeEnd = 116972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetBpm(float bpm)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bpm;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_SetBpm_Public_Static_Void_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060047C5 RID: 18373 RVA: 0x0010C478 File Offset: 0x0010A678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116972, XrefRangeEnd = 116974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CreateSequencer()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_CreateSequencer_Public_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047C6 RID: 18374 RVA: 0x0010C4A8 File Offset: 0x0010A6A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116974, XrefRangeEnd = 116976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DeleteSequencer(IntPtr sequencer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sequencer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_DeleteSequencer_Public_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060047C7 RID: 18375 RVA: 0x0010C4DC File Offset: 0x0010A6DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116976, XrefRangeEnd = 116978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EnableSequencer(IntPtr sequencer, bool enable)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sequencer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_EnableSequencer_Public_Static_Void_IntPtr_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047C8 RID: 18376 RVA: 0x0010C51C File Offset: 0x0010A71C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116978, XrefRangeEnd = 116980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ChangeSequencerLength(IntPtr sequencer, float length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sequencer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_ChangeSequencerLength_Public_Static_Void_IntPtr_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047C9 RID: 18377 RVA: 0x0010C55C File Offset: 0x0010A75C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116980, XrefRangeEnd = 116982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LoopSequencer(IntPtr sequencer, bool loop)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sequencer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loop;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_LoopSequencer_Public_Static_Void_IntPtr_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047CA RID: 18378 RVA: 0x0010C59C File Offset: 0x0010A79C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116982, XrefRangeEnd = 116984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ChangeSequencerChannel(IntPtr sequencer, int channel)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sequencer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_ChangeSequencerChannel_Public_Static_Boolean_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047CB RID: 18379 RVA: 0x0010C5E8 File Offset: 0x0010A7E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116984, XrefRangeEnd = 116986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetSequencerStart(IntPtr sequencer, double startBeat)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sequencer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startBeat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_SetSequencerStart_Public_Static_Void_IntPtr_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047CC RID: 18380 RVA: 0x0010C628 File Offset: 0x0010A828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116986, XrefRangeEnd = 116988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CreateNote(IntPtr sequencer, int note, float velocity, float start, float end)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sequencer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref note;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_CreateNote_Public_Static_IntPtr_IntPtr_Int32_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047CD RID: 18381 RVA: 0x0010C6A0 File Offset: 0x0010A8A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116988, XrefRangeEnd = 116990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr DeleteNote(IntPtr sequencer, IntPtr note)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sequencer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref note;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_DeleteNote_Public_Static_IntPtr_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047CE RID: 18382 RVA: 0x0010C6EC File Offset: 0x0010A8EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116990, XrefRangeEnd = 116992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ChangeNoteStart(IntPtr sequencer, IntPtr note, float newStart)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sequencer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref note;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newStart;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_ChangeNoteStart_Public_Static_IntPtr_IntPtr_IntPtr_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047CF RID: 18383 RVA: 0x0010C748 File Offset: 0x0010A948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116992, XrefRangeEnd = 116994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ChangeNoteEnd(IntPtr sequencer, IntPtr note, float newEnd)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sequencer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref note;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newEnd;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_ChangeNoteEnd_Public_Static_IntPtr_IntPtr_IntPtr_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047D0 RID: 18384 RVA: 0x0010C7A4 File Offset: 0x0010A9A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116994, XrefRangeEnd = 116996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ChangeNoteValues(IntPtr sequencer, IntPtr note, int newMidiKey, float newStart, float newEnd, float newVelocity)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sequencer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref note;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newMidiKey;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newStart;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newEnd;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newVelocity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_ChangeNoteValues_Public_Static_IntPtr_IntPtr_IntPtr_Int32_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047D1 RID: 18385 RVA: 0x0010C828 File Offset: 0x0010AA28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116996, XrefRangeEnd = 116998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ChangeNoteKey(IntPtr sequencer, IntPtr note, int key)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sequencer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref note;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_ChangeNoteKey_Public_Static_IntPtr_IntPtr_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047D2 RID: 18386 RVA: 0x0010C884 File Offset: 0x0010AA84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116998, XrefRangeEnd = 117000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ChangeNoteVelocity(IntPtr note, float velocity)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref note;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_ChangeNoteVelocity_Public_Static_IntPtr_IntPtr_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047D3 RID: 18387 RVA: 0x0010C8D0 File Offset: 0x0010AAD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117000, XrefRangeEnd = 117002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetBeatTime(double time)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_SetBeatTime_Public_Static_Void_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060047D4 RID: 18388 RVA: 0x0010C904 File Offset: 0x0010AB04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117002, XrefRangeEnd = 117004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Pause(bool pause)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pause;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_Pause_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060047D5 RID: 18389 RVA: 0x0002A43D File Offset: 0x0002863D
		public Native(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002DD6 RID: 11734
		private static readonly IntPtr NativeMethodInfoPtr_HelmNoteOn_Public_Static_Void_Int32_Int32_Single_0;

		// Token: 0x04002DD7 RID: 11735
		private static readonly IntPtr NativeMethodInfoPtr_HelmNoteOff_Public_Static_Void_Int32_Int32_0;

		// Token: 0x04002DD8 RID: 11736
		private static readonly IntPtr NativeMethodInfoPtr_HelmFrequencyOn_Public_Static_Void_Int32_Single_Single_0;

		// Token: 0x04002DD9 RID: 11737
		private static readonly IntPtr NativeMethodInfoPtr_HelmFrequencyOff_Public_Static_Void_Int32_Single_0;

		// Token: 0x04002DDA RID: 11738
		private static readonly IntPtr NativeMethodInfoPtr_HelmAllNotesOff_Public_Static_Void_Int32_0;

		// Token: 0x04002DDB RID: 11739
		private static readonly IntPtr NativeMethodInfoPtr_HelmSetPitchWheel_Public_Static_Void_Int32_Single_0;

		// Token: 0x04002DDC RID: 11740
		private static readonly IntPtr NativeMethodInfoPtr_HelmSetModWheel_Public_Static_Void_Int32_Single_0;

		// Token: 0x04002DDD RID: 11741
		private static readonly IntPtr NativeMethodInfoPtr_HelmSetAftertouch_Public_Static_Void_Int32_Int32_Single_0;

		// Token: 0x04002DDE RID: 11742
		private static readonly IntPtr NativeMethodInfoPtr_HelmClearModulations_Public_Static_Void_Int32_0;

		// Token: 0x04002DDF RID: 11743
		private static readonly IntPtr NativeMethodInfoPtr_HelmAddModulation_Public_Static_Void_Int32_Int32_String_String_Single_0;

		// Token: 0x04002DE0 RID: 11744
		private static readonly IntPtr NativeMethodInfoPtr_HelmGetParameterMinimum_Public_Static_Single_Int32_0;

		// Token: 0x04002DE1 RID: 11745
		private static readonly IntPtr NativeMethodInfoPtr_HelmGetParameterMaximum_Public_Static_Single_Int32_0;

		// Token: 0x04002DE2 RID: 11746
		private static readonly IntPtr NativeMethodInfoPtr_HelmGetParameterValue_Public_Static_Single_Int32_Int32_0;

		// Token: 0x04002DE3 RID: 11747
		private static readonly IntPtr NativeMethodInfoPtr_HelmSetParameterValue_Public_Static_Boolean_Int32_Int32_Single_0;

		// Token: 0x04002DE4 RID: 11748
		private static readonly IntPtr NativeMethodInfoPtr_HelmGetParameterPercent_Public_Static_Single_Int32_Int32_0;

		// Token: 0x04002DE5 RID: 11749
		private static readonly IntPtr NativeMethodInfoPtr_HelmSetParameterPercent_Public_Static_Boolean_Int32_Int32_Single_0;

		// Token: 0x04002DE6 RID: 11750
		private static readonly IntPtr NativeMethodInfoPtr_HelmSilence_Public_Static_Boolean_Int32_Boolean_0;

		// Token: 0x04002DE7 RID: 11751
		private static readonly IntPtr NativeMethodInfoPtr_HelmGetBufferData_Public_Static_Boolean_Int32_Il2CppStructArray_1_Single_Int32_Int32_0;

		// Token: 0x04002DE8 RID: 11752
		private static readonly IntPtr NativeMethodInfoPtr_SetBpm_Public_Static_Void_Single_0;

		// Token: 0x04002DE9 RID: 11753
		private static readonly IntPtr NativeMethodInfoPtr_CreateSequencer_Public_Static_IntPtr_0;

		// Token: 0x04002DEA RID: 11754
		private static readonly IntPtr NativeMethodInfoPtr_DeleteSequencer_Public_Static_Void_IntPtr_0;

		// Token: 0x04002DEB RID: 11755
		private static readonly IntPtr NativeMethodInfoPtr_EnableSequencer_Public_Static_Void_IntPtr_Boolean_0;

		// Token: 0x04002DEC RID: 11756
		private static readonly IntPtr NativeMethodInfoPtr_ChangeSequencerLength_Public_Static_Void_IntPtr_Single_0;

		// Token: 0x04002DED RID: 11757
		private static readonly IntPtr NativeMethodInfoPtr_LoopSequencer_Public_Static_Void_IntPtr_Boolean_0;

		// Token: 0x04002DEE RID: 11758
		private static readonly IntPtr NativeMethodInfoPtr_ChangeSequencerChannel_Public_Static_Boolean_IntPtr_Int32_0;

		// Token: 0x04002DEF RID: 11759
		private static readonly IntPtr NativeMethodInfoPtr_SetSequencerStart_Public_Static_Void_IntPtr_Double_0;

		// Token: 0x04002DF0 RID: 11760
		private static readonly IntPtr NativeMethodInfoPtr_CreateNote_Public_Static_IntPtr_IntPtr_Int32_Single_Single_Single_0;

		// Token: 0x04002DF1 RID: 11761
		private static readonly IntPtr NativeMethodInfoPtr_DeleteNote_Public_Static_IntPtr_IntPtr_IntPtr_0;

		// Token: 0x04002DF2 RID: 11762
		private static readonly IntPtr NativeMethodInfoPtr_ChangeNoteStart_Public_Static_IntPtr_IntPtr_IntPtr_Single_0;

		// Token: 0x04002DF3 RID: 11763
		private static readonly IntPtr NativeMethodInfoPtr_ChangeNoteEnd_Public_Static_IntPtr_IntPtr_IntPtr_Single_0;

		// Token: 0x04002DF4 RID: 11764
		private static readonly IntPtr NativeMethodInfoPtr_ChangeNoteValues_Public_Static_IntPtr_IntPtr_IntPtr_Int32_Single_Single_Single_0;

		// Token: 0x04002DF5 RID: 11765
		private static readonly IntPtr NativeMethodInfoPtr_ChangeNoteKey_Public_Static_IntPtr_IntPtr_IntPtr_Int32_0;

		// Token: 0x04002DF6 RID: 11766
		private static readonly IntPtr NativeMethodInfoPtr_ChangeNoteVelocity_Public_Static_IntPtr_IntPtr_Single_0;

		// Token: 0x04002DF7 RID: 11767
		private static readonly IntPtr NativeMethodInfoPtr_SetBeatTime_Public_Static_Void_Double_0;

		// Token: 0x04002DF8 RID: 11768
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Static_Void_Boolean_0;
	}
}
