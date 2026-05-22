using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSanford.Multimedia.Timers;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x020001A0 RID: 416
	public sealed class OutputStream : OutputDeviceBase
	{
		// Token: 0x060013C5 RID: 5061 RVA: 0x0005C268 File Offset: 0x0005A468
		// Note: this type is marked as 'beforefieldinit'.
		static OutputStream()
		{
			Il2CppClassPointerStore<OutputStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "OutputStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OutputStream>.NativeClassPtr);
			OutputStream.NativeFieldInfoPtr_MIDIPROP_SET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputStream>.NativeClassPtr, "MIDIPROP_SET");
			OutputStream.NativeFieldInfoPtr_MIDIPROP_GET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputStream>.NativeClassPtr, "MIDIPROP_GET");
			OutputStream.NativeFieldInfoPtr_MIDIPROP_TIMEDIV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputStream>.NativeClassPtr, "MIDIPROP_TIMEDIV");
			OutputStream.NativeFieldInfoPtr_MIDIPROP_TEMPO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputStream>.NativeClassPtr, "MIDIPROP_TEMPO");
			OutputStream.NativeFieldInfoPtr_MEVT_CALLBACK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputStream>.NativeClassPtr, "MEVT_CALLBACK");
			OutputStream.NativeFieldInfoPtr_MEVT_SHORTMSG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputStream>.NativeClassPtr, "MEVT_SHORTMSG");
			OutputStream.NativeFieldInfoPtr_MEVT_TEMPO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputStream>.NativeClassPtr, "MEVT_TEMPO");
			OutputStream.NativeFieldInfoPtr_MEVT_NOP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputStream>.NativeClassPtr, "MEVT_NOP");
			OutputStream.NativeFieldInfoPtr_MEVT_LONGMSG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputStream>.NativeClassPtr, "MEVT_LONGMSG");
			OutputStream.NativeFieldInfoPtr_MEVT_COMMENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputStream>.NativeClassPtr, "MEVT_COMMENT");
			OutputStream.NativeFieldInfoPtr_MEVT_VERSION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputStream>.NativeClassPtr, "MEVT_VERSION");
			OutputStream.NativeFieldInfoPtr_MOM_POSITIONCB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputStream>.NativeClassPtr, "MOM_POSITIONCB");
			OutputStream.NativeFieldInfoPtr_SizeOfMidiEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputStream>.NativeClassPtr, "SizeOfMidiEvent");
			OutputStream.NativeFieldInfoPtr_EventTypeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputStream>.NativeClassPtr, "EventTypeIndex");
			OutputStream.NativeFieldInfoPtr_EventCodeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputStream>.NativeClassPtr, "EventCodeOffset");
			OutputStream.NativeFieldInfoPtr_midiOutProc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputStream>.NativeClassPtr, "midiOutProc");
			OutputStream.NativeFieldInfoPtr_offsetTicks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputStream>.NativeClassPtr, "offsetTicks");
			OutputStream.NativeFieldInfoPtr_streamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputStream>.NativeClassPtr, "streamID");
			OutputStream.NativeFieldInfoPtr_events = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputStream>.NativeClassPtr, "events");
			OutputStream.NativeFieldInfoPtr_headerBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputStream>.NativeClassPtr, "headerBuilder");
			OutputStream.NativeFieldInfoPtr_NoOpOccurred = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputStream>.NativeClassPtr, "NoOpOccurred");
			OutputStream.NativeMethodInfoPtr_midiStreamOpen_Private_Static_Int32_byref_IntPtr_byref_Int32_Int32_MidiOutProc_IntPtr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputStream>.NativeClassPtr, 100666122);
			OutputStream.NativeMethodInfoPtr_midiStreamClose_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputStream>.NativeClassPtr, 100666123);
			OutputStream.NativeMethodInfoPtr_midiStreamOut_Private_Static_Int32_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputStream>.NativeClassPtr, 100666124);
			OutputStream.NativeMethodInfoPtr_midiStreamPause_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputStream>.NativeClassPtr, 100666125);
			OutputStream.NativeMethodInfoPtr_midiStreamPosition_Private_Static_Int32_IntPtr_byref_Time_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputStream>.NativeClassPtr, 100666126);
			OutputStream.NativeMethodInfoPtr_midiStreamProperty_Private_Static_Int32_IntPtr_byref_Property_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputStream>.NativeClassPtr, 100666127);
			OutputStream.NativeMethodInfoPtr_midiStreamRestart_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputStream>.NativeClassPtr, 100666128);
			OutputStream.NativeMethodInfoPtr_midiStreamStop_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputStream>.NativeClassPtr, 100666129);
			OutputStream.NativeMethodInfoPtr_add_NoOpOccurred_Public_add_Void_EventHandler_1_NoOpEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputStream>.NativeClassPtr, 100666130);
			OutputStream.NativeMethodInfoPtr_remove_NoOpOccurred_Public_rem_Void_EventHandler_1_NoOpEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputStream>.NativeClassPtr, 100666131);
			OutputStream.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputStream>.NativeClassPtr, 100666132);
			OutputStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputStream>.NativeClassPtr, 100666133);
			OutputStream.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputStream>.NativeClassPtr, 100666134);
			OutputStream.NativeMethodInfoPtr_StartPlaying_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputStream>.NativeClassPtr, 100666135);
			OutputStream.NativeMethodInfoPtr_PausePlaying_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputStream>.NativeClassPtr, 100666136);
			OutputStream.NativeMethodInfoPtr_StopPlaying_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputStream>.NativeClassPtr, 100666137);
			OutputStream.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputStream>.NativeClassPtr, 100666138);
			OutputStream.NativeMethodInfoPtr_Write_Public_Void_MidiEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputStream>.NativeClassPtr, 100666139);
			OutputStream.NativeMethodInfoPtr_Write_Private_Void_Int32_ShortMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputStream>.NativeClassPtr, 100666140);
			OutputStream.NativeMethodInfoPtr_Write_Private_Void_Int32_SysExMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputStream>.NativeClassPtr, 100666141);
			OutputStream.NativeMethodInfoPtr_Write_Private_Void_Int32_MetaMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputStream>.NativeClassPtr, 100666142);
			OutputStream.NativeMethodInfoPtr_WriteNoOp_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputStream>.NativeClassPtr, 100666143);
			OutputStream.NativeMethodInfoPtr_Flush_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputStream>.NativeClassPtr, 100666144);
			OutputStream.NativeMethodInfoPtr_GetTime_Public_Time_TimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputStream>.NativeClassPtr, 100666145);
			OutputStream.NativeMethodInfoPtr_OnNoOpOccurred_Private_Void_NoOpEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputStream>.NativeClassPtr, 100666146);
			OutputStream.NativeMethodInfoPtr_HandleMessage_Protected_Virtual_Void_IntPtr_Int32_IntPtr_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputStream>.NativeClassPtr, 100666147);
			OutputStream.NativeMethodInfoPtr_HandleNoOp_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputStream>.NativeClassPtr, 100666148);
			OutputStream.NativeMethodInfoPtr_get_Division_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputStream>.NativeClassPtr, 100666149);
			OutputStream.NativeMethodInfoPtr_set_Division_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputStream>.NativeClassPtr, 100666150);
			OutputStream.NativeMethodInfoPtr_get_Tempo_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputStream>.NativeClassPtr, 100666151);
			OutputStream.NativeMethodInfoPtr_set_Tempo_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputStream>.NativeClassPtr, 100666152);
		}

		// Token: 0x060013C6 RID: 5062 RVA: 0x0005C6A8 File Offset: 0x0005A8A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15832, XrefRangeEnd = 15834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int midiStreamOpen(ref IntPtr handle, ref int deviceID, int reserved, OutputDeviceBase.MidiOutProc proc, IntPtr instance, uint flag)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &deviceID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reserved;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(proc);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instance;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flag;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputStream.NativeMethodInfoPtr_midiStreamOpen_Private_Static_Int32_byref_IntPtr_byref_Int32_Int32_MidiOutProc_IntPtr_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013C7 RID: 5063 RVA: 0x0005C730 File Offset: 0x0005A930
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 15836, RefRangeEnd = 15838, XrefRangeStart = 15834, XrefRangeEnd = 15836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int midiStreamClose(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputStream.NativeMethodInfoPtr_midiStreamClose_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013C8 RID: 5064 RVA: 0x0005C770 File Offset: 0x0005A970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15838, XrefRangeEnd = 15840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int midiStreamOut(IntPtr handle, IntPtr headerPtr, int sizeOfMidiHeader)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref headerPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sizeOfMidiHeader;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputStream.NativeMethodInfoPtr_midiStreamOut_Private_Static_Int32_IntPtr_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013C9 RID: 5065 RVA: 0x0005C7CC File Offset: 0x0005A9CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15840, XrefRangeEnd = 15842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int midiStreamPause(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputStream.NativeMethodInfoPtr_midiStreamPause_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013CA RID: 5066 RVA: 0x0005C80C File Offset: 0x0005AA0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15842, XrefRangeEnd = 15844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int midiStreamPosition(IntPtr handle, ref Time t, int sizeOfTime)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &t;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sizeOfTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputStream.NativeMethodInfoPtr_midiStreamPosition_Private_Static_Int32_IntPtr_byref_Time_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013CB RID: 5067 RVA: 0x0005C868 File Offset: 0x0005AA68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15844, XrefRangeEnd = 15846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int midiStreamProperty(IntPtr handle, ref OutputStream.Property p, uint flags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &p;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputStream.NativeMethodInfoPtr_midiStreamProperty_Private_Static_Int32_IntPtr_byref_Property_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013CC RID: 5068 RVA: 0x0005C8C4 File Offset: 0x0005AAC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15846, XrefRangeEnd = 15848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int midiStreamRestart(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputStream.NativeMethodInfoPtr_midiStreamRestart_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013CD RID: 5069 RVA: 0x0005C904 File Offset: 0x0005AB04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15848, XrefRangeEnd = 15850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int midiStreamStop(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputStream.NativeMethodInfoPtr_midiStreamStop_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013CE RID: 5070 RVA: 0x0005C944 File Offset: 0x0005AB44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15850, XrefRangeEnd = 15853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_NoOpOccurred(EventHandler<NoOpEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputStream.NativeMethodInfoPtr_add_NoOpOccurred_Public_add_Void_EventHandler_1_NoOpEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013CF RID: 5071 RVA: 0x0005C988 File Offset: 0x0005AB88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15853, XrefRangeEnd = 15856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_NoOpOccurred(EventHandler<NoOpEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputStream.NativeMethodInfoPtr_remove_NoOpOccurred_Public_rem_Void_EventHandler_1_NoOpEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013D0 RID: 5072 RVA: 0x0005C9CC File Offset: 0x0005ABCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15856, XrefRangeEnd = 15875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OutputStream(int deviceID)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OutputStream>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deviceID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputStream.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013D1 RID: 5073 RVA: 0x0005CA14 File Offset: 0x0005AC14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15875, XrefRangeEnd = 15898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013D2 RID: 5074 RVA: 0x0005CA54 File Offset: 0x0005AC54
		[CallerCount(0)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputStream.NativeMethodInfoPtr_Close_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013D3 RID: 5075 RVA: 0x0005CA88 File Offset: 0x0005AC88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15898, XrefRangeEnd = 15903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartPlaying()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputStream.NativeMethodInfoPtr_StartPlaying_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013D4 RID: 5076 RVA: 0x0005CABC File Offset: 0x0005ACBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15903, XrefRangeEnd = 15908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PausePlaying()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputStream.NativeMethodInfoPtr_PausePlaying_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013D5 RID: 5077 RVA: 0x0005CAF0 File Offset: 0x0005ACF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15908, XrefRangeEnd = 15913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopPlaying()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputStream.NativeMethodInfoPtr_StopPlaying_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013D6 RID: 5078 RVA: 0x0005CB24 File Offset: 0x0005AD24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15913, XrefRangeEnd = 15923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputStream.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013D7 RID: 5079 RVA: 0x0005CB58 File Offset: 0x0005AD58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15923, XrefRangeEnd = 15931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(MidiEvent e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputStream.NativeMethodInfoPtr_Write_Public_Void_MidiEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013D8 RID: 5080 RVA: 0x0005CB9C File Offset: 0x0005AD9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15931, XrefRangeEnd = 15943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(int deltaTicks, ShortMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deltaTicks;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputStream.NativeMethodInfoPtr_Write_Private_Void_Int32_ShortMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013D9 RID: 5081 RVA: 0x0005CBEC File Offset: 0x0005ADEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15943, XrefRangeEnd = 15966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(int deltaTicks, SysExMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deltaTicks;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputStream.NativeMethodInfoPtr_Write_Private_Void_Int32_SysExMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013DA RID: 5082 RVA: 0x0005CC3C File Offset: 0x0005AE3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 15969, RefRangeEnd = 15970, XrefRangeStart = 15966, XrefRangeEnd = 15969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(int deltaTicks, MetaMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deltaTicks;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputStream.NativeMethodInfoPtr_Write_Private_Void_Int32_MetaMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013DB RID: 5083 RVA: 0x0005CC8C File Offset: 0x0005AE8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15970, XrefRangeEnd = 15985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteNoOp(int deltaTicks, int data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deltaTicks;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputStream.NativeMethodInfoPtr_WriteNoOp_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013DC RID: 5084 RVA: 0x0005CCD8 File Offset: 0x0005AED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15985, XrefRangeEnd = 16010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputStream.NativeMethodInfoPtr_Flush_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013DD RID: 5085 RVA: 0x0005CD0C File Offset: 0x0005AF0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16010, XrefRangeEnd = 16025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Time GetTime(Il2CppSanford.Multimedia.Timers.TimeType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputStream.NativeMethodInfoPtr_GetTime_Public_Time_TimeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013DE RID: 5086 RVA: 0x0005CD58 File Offset: 0x0005AF58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16025, XrefRangeEnd = 16028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnNoOpOccurred(NoOpEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputStream.NativeMethodInfoPtr_OnNoOpOccurred_Private_Void_NoOpEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013DF RID: 5087 RVA: 0x0005CD9C File Offset: 0x0005AF9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16028, XrefRangeEnd = 16039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void HandleMessage(IntPtr hnd, int msg, IntPtr instance, IntPtr param1, IntPtr param2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hnd;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref msg;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref param1;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref param2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputStream.NativeMethodInfoPtr_HandleMessage_Protected_Virtual_Void_IntPtr_Int32_IntPtr_IntPtr_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013E0 RID: 5088 RVA: 0x0005CE14 File Offset: 0x0005B014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16039, XrefRangeEnd = 16077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleNoOp(Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputStream.NativeMethodInfoPtr_HandleNoOp_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x060013E1 RID: 5089 RVA: 0x0005CE58 File Offset: 0x0005B058
		// (set) Token: 0x060013E2 RID: 5090 RVA: 0x0005CE94 File Offset: 0x0005B094
		public unsafe int Division
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16077, XrefRangeEnd = 16092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputStream.NativeMethodInfoPtr_get_Division_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16092, XrefRangeEnd = 16107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputStream.NativeMethodInfoPtr_set_Division_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x060013E3 RID: 5091 RVA: 0x0005CED4 File Offset: 0x0005B0D4
		// (set) Token: 0x060013E4 RID: 5092 RVA: 0x0005CF10 File Offset: 0x0005B110
		public unsafe int Tempo
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16107, XrefRangeEnd = 16122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputStream.NativeMethodInfoPtr_get_Tempo_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16122, XrefRangeEnd = 16137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputStream.NativeMethodInfoPtr_set_Tempo_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060013E5 RID: 5093 RVA: 0x00008249 File Offset: 0x00006449
		public OutputStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x060013E6 RID: 5094 RVA: 0x0005CF50 File Offset: 0x0005B150
		// (set) Token: 0x060013E7 RID: 5095 RVA: 0x00008252 File Offset: 0x00006452
		public unsafe static uint MIDIPROP_SET
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(OutputStream.NativeFieldInfoPtr_MIDIPROP_SET, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OutputStream.NativeFieldInfoPtr_MIDIPROP_SET, (void*)(&value));
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x060013E8 RID: 5096 RVA: 0x0005CF6C File Offset: 0x0005B16C
		// (set) Token: 0x060013E9 RID: 5097 RVA: 0x00008260 File Offset: 0x00006460
		public unsafe static uint MIDIPROP_GET
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(OutputStream.NativeFieldInfoPtr_MIDIPROP_GET, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OutputStream.NativeFieldInfoPtr_MIDIPROP_GET, (void*)(&value));
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x060013EA RID: 5098 RVA: 0x0005CF88 File Offset: 0x0005B188
		// (set) Token: 0x060013EB RID: 5099 RVA: 0x0000826E File Offset: 0x0000646E
		public unsafe static uint MIDIPROP_TIMEDIV
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(OutputStream.NativeFieldInfoPtr_MIDIPROP_TIMEDIV, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OutputStream.NativeFieldInfoPtr_MIDIPROP_TIMEDIV, (void*)(&value));
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x060013EC RID: 5100 RVA: 0x0005CFA4 File Offset: 0x0005B1A4
		// (set) Token: 0x060013ED RID: 5101 RVA: 0x0000827C File Offset: 0x0000647C
		public unsafe static uint MIDIPROP_TEMPO
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(OutputStream.NativeFieldInfoPtr_MIDIPROP_TEMPO, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OutputStream.NativeFieldInfoPtr_MIDIPROP_TEMPO, (void*)(&value));
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x060013EE RID: 5102 RVA: 0x0005CFC0 File Offset: 0x0005B1C0
		// (set) Token: 0x060013EF RID: 5103 RVA: 0x0000828A File Offset: 0x0000648A
		public unsafe static byte MEVT_CALLBACK
		{
			get
			{
				byte b;
				IL2CPP.il2cpp_field_static_get_value(OutputStream.NativeFieldInfoPtr_MEVT_CALLBACK, (void*)(&b));
				return b;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OutputStream.NativeFieldInfoPtr_MEVT_CALLBACK, (void*)(&value));
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x060013F0 RID: 5104 RVA: 0x0005CFDC File Offset: 0x0005B1DC
		// (set) Token: 0x060013F1 RID: 5105 RVA: 0x00008298 File Offset: 0x00006498
		public unsafe static byte MEVT_SHORTMSG
		{
			get
			{
				byte b;
				IL2CPP.il2cpp_field_static_get_value(OutputStream.NativeFieldInfoPtr_MEVT_SHORTMSG, (void*)(&b));
				return b;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OutputStream.NativeFieldInfoPtr_MEVT_SHORTMSG, (void*)(&value));
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x060013F2 RID: 5106 RVA: 0x0005CFF8 File Offset: 0x0005B1F8
		// (set) Token: 0x060013F3 RID: 5107 RVA: 0x000082A6 File Offset: 0x000064A6
		public unsafe static byte MEVT_TEMPO
		{
			get
			{
				byte b;
				IL2CPP.il2cpp_field_static_get_value(OutputStream.NativeFieldInfoPtr_MEVT_TEMPO, (void*)(&b));
				return b;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OutputStream.NativeFieldInfoPtr_MEVT_TEMPO, (void*)(&value));
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x060013F4 RID: 5108 RVA: 0x0005D014 File Offset: 0x0005B214
		// (set) Token: 0x060013F5 RID: 5109 RVA: 0x000082B4 File Offset: 0x000064B4
		public unsafe static byte MEVT_NOP
		{
			get
			{
				byte b;
				IL2CPP.il2cpp_field_static_get_value(OutputStream.NativeFieldInfoPtr_MEVT_NOP, (void*)(&b));
				return b;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OutputStream.NativeFieldInfoPtr_MEVT_NOP, (void*)(&value));
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x060013F6 RID: 5110 RVA: 0x0005D030 File Offset: 0x0005B230
		// (set) Token: 0x060013F7 RID: 5111 RVA: 0x000082C2 File Offset: 0x000064C2
		public unsafe static byte MEVT_LONGMSG
		{
			get
			{
				byte b;
				IL2CPP.il2cpp_field_static_get_value(OutputStream.NativeFieldInfoPtr_MEVT_LONGMSG, (void*)(&b));
				return b;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OutputStream.NativeFieldInfoPtr_MEVT_LONGMSG, (void*)(&value));
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x060013F8 RID: 5112 RVA: 0x0005D04C File Offset: 0x0005B24C
		// (set) Token: 0x060013F9 RID: 5113 RVA: 0x000082D0 File Offset: 0x000064D0
		public unsafe static byte MEVT_COMMENT
		{
			get
			{
				byte b;
				IL2CPP.il2cpp_field_static_get_value(OutputStream.NativeFieldInfoPtr_MEVT_COMMENT, (void*)(&b));
				return b;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OutputStream.NativeFieldInfoPtr_MEVT_COMMENT, (void*)(&value));
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x060013FA RID: 5114 RVA: 0x0005D068 File Offset: 0x0005B268
		// (set) Token: 0x060013FB RID: 5115 RVA: 0x000082DE File Offset: 0x000064DE
		public unsafe static byte MEVT_VERSION
		{
			get
			{
				byte b;
				IL2CPP.il2cpp_field_static_get_value(OutputStream.NativeFieldInfoPtr_MEVT_VERSION, (void*)(&b));
				return b;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OutputStream.NativeFieldInfoPtr_MEVT_VERSION, (void*)(&value));
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x060013FC RID: 5116 RVA: 0x0005D084 File Offset: 0x0005B284
		// (set) Token: 0x060013FD RID: 5117 RVA: 0x000082EC File Offset: 0x000064EC
		public unsafe static int MOM_POSITIONCB
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(OutputStream.NativeFieldInfoPtr_MOM_POSITIONCB, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OutputStream.NativeFieldInfoPtr_MOM_POSITIONCB, (void*)(&value));
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x060013FE RID: 5118 RVA: 0x0005D0A0 File Offset: 0x0005B2A0
		// (set) Token: 0x060013FF RID: 5119 RVA: 0x000082FA File Offset: 0x000064FA
		public unsafe static int SizeOfMidiEvent
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(OutputStream.NativeFieldInfoPtr_SizeOfMidiEvent, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OutputStream.NativeFieldInfoPtr_SizeOfMidiEvent, (void*)(&value));
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06001400 RID: 5120 RVA: 0x0005D0BC File Offset: 0x0005B2BC
		// (set) Token: 0x06001401 RID: 5121 RVA: 0x00008308 File Offset: 0x00006508
		public unsafe static int EventTypeIndex
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(OutputStream.NativeFieldInfoPtr_EventTypeIndex, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OutputStream.NativeFieldInfoPtr_EventTypeIndex, (void*)(&value));
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06001402 RID: 5122 RVA: 0x0005D0D8 File Offset: 0x0005B2D8
		// (set) Token: 0x06001403 RID: 5123 RVA: 0x00008316 File Offset: 0x00006516
		public unsafe static int EventCodeOffset
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(OutputStream.NativeFieldInfoPtr_EventCodeOffset, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OutputStream.NativeFieldInfoPtr_EventCodeOffset, (void*)(&value));
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06001404 RID: 5124 RVA: 0x0005D0F4 File Offset: 0x0005B2F4
		// (set) Token: 0x06001405 RID: 5125 RVA: 0x00008324 File Offset: 0x00006524
		public unsafe OutputDeviceBase.MidiOutProc midiOutProc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutputStream.NativeFieldInfoPtr_midiOutProc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OutputDeviceBase.MidiOutProc>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutputStream.NativeFieldInfoPtr_midiOutProc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06001406 RID: 5126 RVA: 0x0005D124 File Offset: 0x0005B324
		// (set) Token: 0x06001407 RID: 5127 RVA: 0x00008343 File Offset: 0x00006543
		public unsafe int offsetTicks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutputStream.NativeFieldInfoPtr_offsetTicks);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutputStream.NativeFieldInfoPtr_offsetTicks)) = value;
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06001408 RID: 5128 RVA: 0x0005D14C File Offset: 0x0005B34C
		// (set) Token: 0x06001409 RID: 5129 RVA: 0x0000835E File Offset: 0x0000655E
		public unsafe Il2CppStructArray<byte> streamID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutputStream.NativeFieldInfoPtr_streamID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutputStream.NativeFieldInfoPtr_streamID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x0600140A RID: 5130 RVA: 0x0005D17C File Offset: 0x0005B37C
		// (set) Token: 0x0600140B RID: 5131 RVA: 0x0000837D File Offset: 0x0000657D
		public unsafe List<byte> events
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutputStream.NativeFieldInfoPtr_events);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutputStream.NativeFieldInfoPtr_events), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x0600140C RID: 5132 RVA: 0x0005D1AC File Offset: 0x0005B3AC
		// (set) Token: 0x0600140D RID: 5133 RVA: 0x0000839C File Offset: 0x0000659C
		public new unsafe MidiHeaderBuilder headerBuilder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutputStream.NativeFieldInfoPtr_headerBuilder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MidiHeaderBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutputStream.NativeFieldInfoPtr_headerBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x0600140E RID: 5134 RVA: 0x0005D1DC File Offset: 0x0005B3DC
		// (set) Token: 0x0600140F RID: 5135 RVA: 0x000083BB File Offset: 0x000065BB
		public unsafe EventHandler<NoOpEventArgs> NoOpOccurred
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutputStream.NativeFieldInfoPtr_NoOpOccurred);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<NoOpEventArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutputStream.NativeFieldInfoPtr_NoOpOccurred), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001545 RID: 5445
		private static readonly IntPtr NativeFieldInfoPtr_MIDIPROP_SET;

		// Token: 0x04001546 RID: 5446
		private static readonly IntPtr NativeFieldInfoPtr_MIDIPROP_GET;

		// Token: 0x04001547 RID: 5447
		private static readonly IntPtr NativeFieldInfoPtr_MIDIPROP_TIMEDIV;

		// Token: 0x04001548 RID: 5448
		private static readonly IntPtr NativeFieldInfoPtr_MIDIPROP_TEMPO;

		// Token: 0x04001549 RID: 5449
		private static readonly IntPtr NativeFieldInfoPtr_MEVT_CALLBACK;

		// Token: 0x0400154A RID: 5450
		private static readonly IntPtr NativeFieldInfoPtr_MEVT_SHORTMSG;

		// Token: 0x0400154B RID: 5451
		private static readonly IntPtr NativeFieldInfoPtr_MEVT_TEMPO;

		// Token: 0x0400154C RID: 5452
		private static readonly IntPtr NativeFieldInfoPtr_MEVT_NOP;

		// Token: 0x0400154D RID: 5453
		private static readonly IntPtr NativeFieldInfoPtr_MEVT_LONGMSG;

		// Token: 0x0400154E RID: 5454
		private static readonly IntPtr NativeFieldInfoPtr_MEVT_COMMENT;

		// Token: 0x0400154F RID: 5455
		private static readonly IntPtr NativeFieldInfoPtr_MEVT_VERSION;

		// Token: 0x04001550 RID: 5456
		private static readonly IntPtr NativeFieldInfoPtr_MOM_POSITIONCB;

		// Token: 0x04001551 RID: 5457
		private static readonly IntPtr NativeFieldInfoPtr_SizeOfMidiEvent;

		// Token: 0x04001552 RID: 5458
		private static readonly IntPtr NativeFieldInfoPtr_EventTypeIndex;

		// Token: 0x04001553 RID: 5459
		private static readonly IntPtr NativeFieldInfoPtr_EventCodeOffset;

		// Token: 0x04001554 RID: 5460
		private static readonly IntPtr NativeFieldInfoPtr_midiOutProc;

		// Token: 0x04001555 RID: 5461
		private static readonly IntPtr NativeFieldInfoPtr_offsetTicks;

		// Token: 0x04001556 RID: 5462
		private static readonly IntPtr NativeFieldInfoPtr_streamID;

		// Token: 0x04001557 RID: 5463
		private static readonly IntPtr NativeFieldInfoPtr_events;

		// Token: 0x04001558 RID: 5464
		private static readonly IntPtr NativeFieldInfoPtr_headerBuilder;

		// Token: 0x04001559 RID: 5465
		private static readonly IntPtr NativeFieldInfoPtr_NoOpOccurred;

		// Token: 0x0400155A RID: 5466
		private static readonly IntPtr NativeMethodInfoPtr_midiStreamOpen_Private_Static_Int32_byref_IntPtr_byref_Int32_Int32_MidiOutProc_IntPtr_UInt32_0;

		// Token: 0x0400155B RID: 5467
		private static readonly IntPtr NativeMethodInfoPtr_midiStreamClose_Private_Static_Int32_IntPtr_0;

		// Token: 0x0400155C RID: 5468
		private static readonly IntPtr NativeMethodInfoPtr_midiStreamOut_Private_Static_Int32_IntPtr_IntPtr_Int32_0;

		// Token: 0x0400155D RID: 5469
		private static readonly IntPtr NativeMethodInfoPtr_midiStreamPause_Private_Static_Int32_IntPtr_0;

		// Token: 0x0400155E RID: 5470
		private static readonly IntPtr NativeMethodInfoPtr_midiStreamPosition_Private_Static_Int32_IntPtr_byref_Time_Int32_0;

		// Token: 0x0400155F RID: 5471
		private static readonly IntPtr NativeMethodInfoPtr_midiStreamProperty_Private_Static_Int32_IntPtr_byref_Property_UInt32_0;

		// Token: 0x04001560 RID: 5472
		private static readonly IntPtr NativeMethodInfoPtr_midiStreamRestart_Private_Static_Int32_IntPtr_0;

		// Token: 0x04001561 RID: 5473
		private static readonly IntPtr NativeMethodInfoPtr_midiStreamStop_Private_Static_Int32_IntPtr_0;

		// Token: 0x04001562 RID: 5474
		private static readonly IntPtr NativeMethodInfoPtr_add_NoOpOccurred_Public_add_Void_EventHandler_1_NoOpEventArgs_0;

		// Token: 0x04001563 RID: 5475
		private static readonly IntPtr NativeMethodInfoPtr_remove_NoOpOccurred_Public_rem_Void_EventHandler_1_NoOpEventArgs_0;

		// Token: 0x04001564 RID: 5476
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001565 RID: 5477
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04001566 RID: 5478
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x04001567 RID: 5479
		private static readonly IntPtr NativeMethodInfoPtr_StartPlaying_Public_Void_0;

		// Token: 0x04001568 RID: 5480
		private static readonly IntPtr NativeMethodInfoPtr_PausePlaying_Public_Void_0;

		// Token: 0x04001569 RID: 5481
		private static readonly IntPtr NativeMethodInfoPtr_StopPlaying_Public_Void_0;

		// Token: 0x0400156A RID: 5482
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x0400156B RID: 5483
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_MidiEvent_0;

		// Token: 0x0400156C RID: 5484
		private static readonly IntPtr NativeMethodInfoPtr_Write_Private_Void_Int32_ShortMessage_0;

		// Token: 0x0400156D RID: 5485
		private static readonly IntPtr NativeMethodInfoPtr_Write_Private_Void_Int32_SysExMessage_0;

		// Token: 0x0400156E RID: 5486
		private static readonly IntPtr NativeMethodInfoPtr_Write_Private_Void_Int32_MetaMessage_0;

		// Token: 0x0400156F RID: 5487
		private static readonly IntPtr NativeMethodInfoPtr_WriteNoOp_Public_Void_Int32_Int32_0;

		// Token: 0x04001570 RID: 5488
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Void_0;

		// Token: 0x04001571 RID: 5489
		private static readonly IntPtr NativeMethodInfoPtr_GetTime_Public_Time_TimeType_0;

		// Token: 0x04001572 RID: 5490
		private static readonly IntPtr NativeMethodInfoPtr_OnNoOpOccurred_Private_Void_NoOpEventArgs_0;

		// Token: 0x04001573 RID: 5491
		private static readonly IntPtr NativeMethodInfoPtr_HandleMessage_Protected_Virtual_Void_IntPtr_Int32_IntPtr_IntPtr_IntPtr_0;

		// Token: 0x04001574 RID: 5492
		private static readonly IntPtr NativeMethodInfoPtr_HandleNoOp_Private_Void_Object_0;

		// Token: 0x04001575 RID: 5493
		private static readonly IntPtr NativeMethodInfoPtr_get_Division_Public_get_Int32_0;

		// Token: 0x04001576 RID: 5494
		private static readonly IntPtr NativeMethodInfoPtr_set_Division_Public_set_Void_Int32_0;

		// Token: 0x04001577 RID: 5495
		private static readonly IntPtr NativeMethodInfoPtr_get_Tempo_Public_get_Int32_0;

		// Token: 0x04001578 RID: 5496
		private static readonly IntPtr NativeMethodInfoPtr_set_Tempo_Public_set_Void_Int32_0;

		// Token: 0x02000252 RID: 594
		[StructLayout(2)]
		public struct Property
		{
			// Token: 0x0600206B RID: 8299 RVA: 0x0008E1B0 File Offset: 0x0008C3B0
			// Note: this type is marked as 'beforefieldinit'.
			static Property()
			{
				Il2CppClassPointerStore<OutputStream.Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OutputStream>.NativeClassPtr, "Property");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OutputStream.Property>.NativeClassPtr);
				OutputStream.Property.NativeFieldInfoPtr_sizeOfProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputStream.Property>.NativeClassPtr, "sizeOfProperty");
				OutputStream.Property.NativeFieldInfoPtr_property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputStream.Property>.NativeClassPtr, "property");
			}

			// Token: 0x0600206C RID: 8300 RVA: 0x0000BECB File Offset: 0x0000A0CB
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OutputStream.Property>.NativeClassPtr, ref this));
			}

			// Token: 0x0400204D RID: 8269
			private static readonly IntPtr NativeFieldInfoPtr_sizeOfProperty;

			// Token: 0x0400204E RID: 8270
			private static readonly IntPtr NativeFieldInfoPtr_property;

			// Token: 0x0400204F RID: 8271
			[FieldOffset(0)]
			public int sizeOfProperty;

			// Token: 0x04002050 RID: 8272
			[FieldOffset(4)]
			public int property;
		}

		// Token: 0x02000253 RID: 595
		[ObfuscatedName("Sanford.Multimedia.Midi.OutputStream+<>c__DisplayClass48_0")]
		public sealed class __c__DisplayClass48_0 : Object
		{
			// Token: 0x0600206D RID: 8301 RVA: 0x0008E204 File Offset: 0x0008C404
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass48_0()
			{
				Il2CppClassPointerStore<OutputStream.__c__DisplayClass48_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OutputStream>.NativeClassPtr, "<>c__DisplayClass48_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OutputStream.__c__DisplayClass48_0>.NativeClassPtr);
				OutputStream.__c__DisplayClass48_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputStream.__c__DisplayClass48_0>.NativeClassPtr, "<>4__this");
				OutputStream.__c__DisplayClass48_0.NativeFieldInfoPtr_e = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputStream.__c__DisplayClass48_0>.NativeClassPtr, "e");
				OutputStream.__c__DisplayClass48_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputStream.__c__DisplayClass48_0>.NativeClassPtr, 100666153);
				OutputStream.__c__DisplayClass48_0.NativeMethodInfoPtr__HandleNoOp_b__0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputStream.__c__DisplayClass48_0>.NativeClassPtr, 100666154);
			}

			// Token: 0x0600206E RID: 8302 RVA: 0x0008E280 File Offset: 0x0008C480
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass48_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OutputStream.__c__DisplayClass48_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputStream.__c__DisplayClass48_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600206F RID: 8303 RVA: 0x0008E2BC File Offset: 0x0008C4BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15829, XrefRangeEnd = 15832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _HandleNoOp_b__0(Object s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputStream.__c__DisplayClass48_0.NativeMethodInfoPtr__HandleNoOp_b__0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002070 RID: 8304 RVA: 0x0000BEDD File Offset: 0x0000A0DD
			public __c__DisplayClass48_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000660 RID: 1632
			// (get) Token: 0x06002071 RID: 8305 RVA: 0x0008E300 File Offset: 0x0008C500
			// (set) Token: 0x06002072 RID: 8306 RVA: 0x0000BEE6 File Offset: 0x0000A0E6
			public unsafe OutputStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutputStream.__c__DisplayClass48_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OutputStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutputStream.__c__DisplayClass48_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000661 RID: 1633
			// (get) Token: 0x06002073 RID: 8307 RVA: 0x0008E330 File Offset: 0x0008C530
			// (set) Token: 0x06002074 RID: 8308 RVA: 0x0000BF05 File Offset: 0x0000A105
			public unsafe NoOpEventArgs e
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutputStream.__c__DisplayClass48_0.NativeFieldInfoPtr_e);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoOpEventArgs>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutputStream.__c__DisplayClass48_0.NativeFieldInfoPtr_e), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002051 RID: 8273
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002052 RID: 8274
			private static readonly IntPtr NativeFieldInfoPtr_e;

			// Token: 0x04002053 RID: 8275
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002054 RID: 8276
			private static readonly IntPtr NativeMethodInfoPtr__HandleNoOp_b__0_Internal_Void_Object_0;
		}
	}
}
