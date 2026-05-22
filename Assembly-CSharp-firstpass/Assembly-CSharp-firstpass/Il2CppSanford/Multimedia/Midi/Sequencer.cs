using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.ComponentModel;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x020001D2 RID: 466
	public class Sequencer : Object
	{
		// Token: 0x060016C6 RID: 5830 RVA: 0x000671C4 File Offset: 0x000653C4
		// Note: this type is marked as 'beforefieldinit'.
		static Sequencer()
		{
			Il2CppClassPointerStore<Sequencer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "Sequencer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sequencer>.NativeClassPtr);
			Sequencer.NativeFieldInfoPtr_sequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "sequence");
			Sequencer.NativeFieldInfoPtr_enumerators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "enumerators");
			Sequencer.NativeFieldInfoPtr_dispatcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "dispatcher");
			Sequencer.NativeFieldInfoPtr_chaser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "chaser");
			Sequencer.NativeFieldInfoPtr_stopper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "stopper");
			Sequencer.NativeFieldInfoPtr_clock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "clock");
			Sequencer.NativeFieldInfoPtr_tracksPlayingCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "tracksPlayingCount");
			Sequencer.NativeFieldInfoPtr_lockObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "lockObject");
			Sequencer.NativeFieldInfoPtr_playing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "playing");
			Sequencer.NativeFieldInfoPtr_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "disposed");
			Sequencer.NativeFieldInfoPtr_site = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "site");
			Sequencer.NativeFieldInfoPtr_PlayingCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "PlayingCompleted");
			Sequencer.NativeFieldInfoPtr_Disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "Disposed");
			Sequencer.NativeMethodInfoPtr_add_PlayingCompleted_Public_add_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100666523);
			Sequencer.NativeMethodInfoPtr_remove_PlayingCompleted_Public_rem_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100666524);
			Sequencer.NativeMethodInfoPtr_add_ChannelMessagePlayed_Public_add_Void_EventHandler_1_ChannelMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100666525);
			Sequencer.NativeMethodInfoPtr_remove_ChannelMessagePlayed_Public_rem_Void_EventHandler_1_ChannelMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100666526);
			Sequencer.NativeMethodInfoPtr_add_SysExMessagePlayed_Public_add_Void_EventHandler_1_SysExMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100666527);
			Sequencer.NativeMethodInfoPtr_remove_SysExMessagePlayed_Public_rem_Void_EventHandler_1_SysExMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100666528);
			Sequencer.NativeMethodInfoPtr_add_MetaMessagePlayed_Public_add_Void_EventHandler_1_MetaMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100666529);
			Sequencer.NativeMethodInfoPtr_remove_MetaMessagePlayed_Public_rem_Void_EventHandler_1_MetaMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100666530);
			Sequencer.NativeMethodInfoPtr_add_Chased_Public_add_Void_EventHandler_1_ChasedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100666531);
			Sequencer.NativeMethodInfoPtr_remove_Chased_Public_rem_Void_EventHandler_1_ChasedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100666532);
			Sequencer.NativeMethodInfoPtr_add_Stopped_Public_add_Void_EventHandler_1_StoppedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100666533);
			Sequencer.NativeMethodInfoPtr_remove_Stopped_Public_rem_Void_EventHandler_1_StoppedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100666534);
			Sequencer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100666535);
			Sequencer.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100666536);
			Sequencer.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100666537);
			Sequencer.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100666538);
			Sequencer.NativeMethodInfoPtr_Continue_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100666539);
			Sequencer.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100666540);
			Sequencer.NativeMethodInfoPtr_OnPlayingCompleted_Protected_Virtual_New_Void_EventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100666541);
			Sequencer.NativeMethodInfoPtr_OnDisposed_Protected_Virtual_New_Void_EventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100666542);
			Sequencer.NativeMethodInfoPtr_get_Position_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100666543);
			Sequencer.NativeMethodInfoPtr_set_Position_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100666544);
			Sequencer.NativeMethodInfoPtr_get_Sequence_Public_get_Sequence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100666545);
			Sequencer.NativeMethodInfoPtr_set_Sequence_Public_set_Void_Sequence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100666546);
			Sequencer.NativeMethodInfoPtr_add_Disposed_Public_Virtual_Final_New_add_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100666547);
			Sequencer.NativeMethodInfoPtr_remove_Disposed_Public_Virtual_Final_New_rem_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100666548);
			Sequencer.NativeMethodInfoPtr_get_Site_Public_Virtual_Final_New_get_ISite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100666549);
			Sequencer.NativeMethodInfoPtr_set_Site_Public_Virtual_Final_New_set_Void_ISite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100666550);
			Sequencer.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100666551);
			Sequencer.NativeMethodInfoPtr___ctor_b__29_0_Private_Void_Object_MetaMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100666552);
			Sequencer.NativeMethodInfoPtr___ctor_b__29_1_Private_Void_Object_ChannelMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100666553);
			Sequencer.NativeMethodInfoPtr___ctor_b__29_2_Private_Void_Object_EventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100666554);
		}

		// Token: 0x060016C7 RID: 5831 RVA: 0x00067578 File Offset: 0x00065778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17735, XrefRangeEnd = 17738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_PlayingCompleted(EventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_add_PlayingCompleted_Public_add_Void_EventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016C8 RID: 5832 RVA: 0x000675BC File Offset: 0x000657BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17738, XrefRangeEnd = 17741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_PlayingCompleted(EventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_remove_PlayingCompleted_Public_rem_Void_EventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016C9 RID: 5833 RVA: 0x00067600 File Offset: 0x00065800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17741, XrefRangeEnd = 17743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_ChannelMessagePlayed(EventHandler<ChannelMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_add_ChannelMessagePlayed_Public_add_Void_EventHandler_1_ChannelMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016CA RID: 5834 RVA: 0x00067644 File Offset: 0x00065844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17743, XrefRangeEnd = 17746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_ChannelMessagePlayed(EventHandler<ChannelMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_remove_ChannelMessagePlayed_Public_rem_Void_EventHandler_1_ChannelMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016CB RID: 5835 RVA: 0x00067688 File Offset: 0x00065888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17746, XrefRangeEnd = 17749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_SysExMessagePlayed(EventHandler<SysExMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_add_SysExMessagePlayed_Public_add_Void_EventHandler_1_SysExMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016CC RID: 5836 RVA: 0x000676CC File Offset: 0x000658CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17749, XrefRangeEnd = 17752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_SysExMessagePlayed(EventHandler<SysExMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_remove_SysExMessagePlayed_Public_rem_Void_EventHandler_1_SysExMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016CD RID: 5837 RVA: 0x00067710 File Offset: 0x00065910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17752, XrefRangeEnd = 17754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_MetaMessagePlayed(EventHandler<MetaMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_add_MetaMessagePlayed_Public_add_Void_EventHandler_1_MetaMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016CE RID: 5838 RVA: 0x00067754 File Offset: 0x00065954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17754, XrefRangeEnd = 17757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_MetaMessagePlayed(EventHandler<MetaMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_remove_MetaMessagePlayed_Public_rem_Void_EventHandler_1_MetaMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016CF RID: 5839 RVA: 0x00067798 File Offset: 0x00065998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17757, XrefRangeEnd = 17760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_Chased(EventHandler<ChasedEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_add_Chased_Public_add_Void_EventHandler_1_ChasedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016D0 RID: 5840 RVA: 0x000677DC File Offset: 0x000659DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17760, XrefRangeEnd = 17763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_Chased(EventHandler<ChasedEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_remove_Chased_Public_rem_Void_EventHandler_1_ChasedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016D1 RID: 5841 RVA: 0x00067820 File Offset: 0x00065A20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17763, XrefRangeEnd = 17766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_Stopped(EventHandler<StoppedEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_add_Stopped_Public_add_Void_EventHandler_1_StoppedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016D2 RID: 5842 RVA: 0x00067864 File Offset: 0x00065A64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17766, XrefRangeEnd = 17769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_Stopped(EventHandler<StoppedEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_remove_Stopped_Public_rem_Void_EventHandler_1_StoppedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016D3 RID: 5843 RVA: 0x000678A8 File Offset: 0x00065AA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17769, XrefRangeEnd = 17815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sequencer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sequencer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016D4 RID: 5844 RVA: 0x000678E4 File Offset: 0x00065AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sequencer.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016D5 RID: 5845 RVA: 0x00067920 File Offset: 0x00065B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17815, XrefRangeEnd = 17837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sequencer.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016D6 RID: 5846 RVA: 0x0006796C File Offset: 0x00065B6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17837, XrefRangeEnd = 17843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016D7 RID: 5847 RVA: 0x000679A0 File Offset: 0x00065BA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 17883, RefRangeEnd = 17885, XrefRangeStart = 17843, XrefRangeEnd = 17883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Continue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_Continue_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016D8 RID: 5848 RVA: 0x000679D4 File Offset: 0x00065BD4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 17891, RefRangeEnd = 17896, XrefRangeStart = 17885, XrefRangeEnd = 17891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016D9 RID: 5849 RVA: 0x00067A08 File Offset: 0x00065C08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPlayingCompleted(EventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sequencer.NativeMethodInfoPtr_OnPlayingCompleted_Protected_Virtual_New_Void_EventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016DA RID: 5850 RVA: 0x00067A58 File Offset: 0x00065C58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDisposed(EventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sequencer.NativeMethodInfoPtr_OnDisposed_Protected_Virtual_New_Void_EventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x060016DB RID: 5851 RVA: 0x00067AA8 File Offset: 0x00065CA8
		// (set) Token: 0x060016DC RID: 5852 RVA: 0x00067AE4 File Offset: 0x00065CE4
		public unsafe int Position
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17896, XrefRangeEnd = 17905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_get_Position_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17914, RefRangeEnd = 17915, XrefRangeStart = 17905, XrefRangeEnd = 17914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_set_Position_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x060016DD RID: 5853 RVA: 0x00067B24 File Offset: 0x00065D24
		// (set) Token: 0x060016DE RID: 5854 RVA: 0x00067B64 File Offset: 0x00065D64
		public unsafe Sequence Sequence
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_get_Sequence_Public_get_Sequence_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sequence>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17915, XrefRangeEnd = 17919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_set_Sequence_Public_set_Void_Sequence_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060016DF RID: 5855 RVA: 0x00067BA8 File Offset: 0x00065DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17919, XrefRangeEnd = 17922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void add_Disposed(EventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_add_Disposed_Public_Virtual_Final_New_add_Void_EventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016E0 RID: 5856 RVA: 0x00067BEC File Offset: 0x00065DEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17922, XrefRangeEnd = 17925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void remove_Disposed(EventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_remove_Disposed_Public_Virtual_Final_New_rem_Void_EventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x060016E1 RID: 5857 RVA: 0x00067C30 File Offset: 0x00065E30
		// (set) Token: 0x060016E2 RID: 5858 RVA: 0x00067C70 File Offset: 0x00065E70
		public unsafe virtual ISite Site
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_get_Site_Public_Virtual_Final_New_get_ISite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISite>(intPtr3) : null;
			}
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 17925, RefRangeEnd = 17937, XrefRangeStart = 17925, XrefRangeEnd = 17925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_set_Site_Public_Virtual_Final_New_set_Void_ISite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060016E3 RID: 5859 RVA: 0x00067CB4 File Offset: 0x00065EB4
		[CallerCount(0)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016E4 RID: 5860 RVA: 0x00067CE8 File Offset: 0x00065EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17937, XrefRangeEnd = 17942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__29_0(Object sender, MetaMessageEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr___ctor_b__29_0_Private_Void_Object_MetaMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016E5 RID: 5861 RVA: 0x00067D3C File Offset: 0x00065F3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17942, XrefRangeEnd = 17944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__29_1(Object sender, ChannelMessageEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr___ctor_b__29_1_Private_Void_Object_ChannelMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016E6 RID: 5862 RVA: 0x00067D90 File Offset: 0x00065F90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17944, XrefRangeEnd = 17961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__29_2(Object sender, EventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr___ctor_b__29_2_Private_Void_Object_EventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016E7 RID: 5863 RVA: 0x0000921E File Offset: 0x0000741E
		public Sequencer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x060016E8 RID: 5864 RVA: 0x00067DE4 File Offset: 0x00065FE4
		// (set) Token: 0x060016E9 RID: 5865 RVA: 0x00009227 File Offset: 0x00007427
		public unsafe Sequence sequence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_sequence);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sequence>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_sequence), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x060016EA RID: 5866 RVA: 0x00067E14 File Offset: 0x00066014
		// (set) Token: 0x060016EB RID: 5867 RVA: 0x00009246 File Offset: 0x00007446
		public unsafe List<IEnumerator<int>> enumerators
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_enumerators);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IEnumerator<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_enumerators), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x060016EC RID: 5868 RVA: 0x00067E44 File Offset: 0x00066044
		// (set) Token: 0x060016ED RID: 5869 RVA: 0x00009265 File Offset: 0x00007465
		public unsafe MessageDispatcher dispatcher
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_dispatcher);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MessageDispatcher>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_dispatcher), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x060016EE RID: 5870 RVA: 0x00067E74 File Offset: 0x00066074
		// (set) Token: 0x060016EF RID: 5871 RVA: 0x00009284 File Offset: 0x00007484
		public unsafe ChannelChaser chaser
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_chaser);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChannelChaser>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_chaser), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x060016F0 RID: 5872 RVA: 0x00067EA4 File Offset: 0x000660A4
		// (set) Token: 0x060016F1 RID: 5873 RVA: 0x000092A3 File Offset: 0x000074A3
		public unsafe ChannelStopper stopper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_stopper);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChannelStopper>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_stopper), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x060016F2 RID: 5874 RVA: 0x00067ED4 File Offset: 0x000660D4
		// (set) Token: 0x060016F3 RID: 5875 RVA: 0x000092C2 File Offset: 0x000074C2
		public unsafe MidiInternalClock clock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_clock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MidiInternalClock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_clock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x060016F4 RID: 5876 RVA: 0x00067F04 File Offset: 0x00066104
		// (set) Token: 0x060016F5 RID: 5877 RVA: 0x000092E1 File Offset: 0x000074E1
		public unsafe int tracksPlayingCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_tracksPlayingCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_tracksPlayingCount)) = value;
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x060016F6 RID: 5878 RVA: 0x00067F2C File Offset: 0x0006612C
		// (set) Token: 0x060016F7 RID: 5879 RVA: 0x000092FC File Offset: 0x000074FC
		public unsafe Object lockObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_lockObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_lockObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x060016F8 RID: 5880 RVA: 0x00067F5C File Offset: 0x0006615C
		// (set) Token: 0x060016F9 RID: 5881 RVA: 0x0000931B File Offset: 0x0000751B
		public unsafe bool playing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_playing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_playing)) = value;
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x060016FA RID: 5882 RVA: 0x00067F84 File Offset: 0x00066184
		// (set) Token: 0x060016FB RID: 5883 RVA: 0x00009336 File Offset: 0x00007536
		public unsafe bool disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_disposed)) = value;
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x060016FC RID: 5884 RVA: 0x00067FAC File Offset: 0x000661AC
		// (set) Token: 0x060016FD RID: 5885 RVA: 0x00009351 File Offset: 0x00007551
		public unsafe ISite site
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_site);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_site), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x060016FE RID: 5886 RVA: 0x00067FDC File Offset: 0x000661DC
		// (set) Token: 0x060016FF RID: 5887 RVA: 0x00009370 File Offset: 0x00007570
		public unsafe EventHandler PlayingCompleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_PlayingCompleted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_PlayingCompleted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06001700 RID: 5888 RVA: 0x0006800C File Offset: 0x0006620C
		// (set) Token: 0x06001701 RID: 5889 RVA: 0x0000938F File Offset: 0x0000758F
		public unsafe EventHandler Disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_Disposed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_Disposed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400185D RID: 6237
		private static readonly IntPtr NativeFieldInfoPtr_sequence;

		// Token: 0x0400185E RID: 6238
		private static readonly IntPtr NativeFieldInfoPtr_enumerators;

		// Token: 0x0400185F RID: 6239
		private static readonly IntPtr NativeFieldInfoPtr_dispatcher;

		// Token: 0x04001860 RID: 6240
		private static readonly IntPtr NativeFieldInfoPtr_chaser;

		// Token: 0x04001861 RID: 6241
		private static readonly IntPtr NativeFieldInfoPtr_stopper;

		// Token: 0x04001862 RID: 6242
		private static readonly IntPtr NativeFieldInfoPtr_clock;

		// Token: 0x04001863 RID: 6243
		private static readonly IntPtr NativeFieldInfoPtr_tracksPlayingCount;

		// Token: 0x04001864 RID: 6244
		private static readonly IntPtr NativeFieldInfoPtr_lockObject;

		// Token: 0x04001865 RID: 6245
		private static readonly IntPtr NativeFieldInfoPtr_playing;

		// Token: 0x04001866 RID: 6246
		private static readonly IntPtr NativeFieldInfoPtr_disposed;

		// Token: 0x04001867 RID: 6247
		private static readonly IntPtr NativeFieldInfoPtr_site;

		// Token: 0x04001868 RID: 6248
		private static readonly IntPtr NativeFieldInfoPtr_PlayingCompleted;

		// Token: 0x04001869 RID: 6249
		private static readonly IntPtr NativeFieldInfoPtr_Disposed;

		// Token: 0x0400186A RID: 6250
		private static readonly IntPtr NativeMethodInfoPtr_add_PlayingCompleted_Public_add_Void_EventHandler_0;

		// Token: 0x0400186B RID: 6251
		private static readonly IntPtr NativeMethodInfoPtr_remove_PlayingCompleted_Public_rem_Void_EventHandler_0;

		// Token: 0x0400186C RID: 6252
		private static readonly IntPtr NativeMethodInfoPtr_add_ChannelMessagePlayed_Public_add_Void_EventHandler_1_ChannelMessageEventArgs_0;

		// Token: 0x0400186D RID: 6253
		private static readonly IntPtr NativeMethodInfoPtr_remove_ChannelMessagePlayed_Public_rem_Void_EventHandler_1_ChannelMessageEventArgs_0;

		// Token: 0x0400186E RID: 6254
		private static readonly IntPtr NativeMethodInfoPtr_add_SysExMessagePlayed_Public_add_Void_EventHandler_1_SysExMessageEventArgs_0;

		// Token: 0x0400186F RID: 6255
		private static readonly IntPtr NativeMethodInfoPtr_remove_SysExMessagePlayed_Public_rem_Void_EventHandler_1_SysExMessageEventArgs_0;

		// Token: 0x04001870 RID: 6256
		private static readonly IntPtr NativeMethodInfoPtr_add_MetaMessagePlayed_Public_add_Void_EventHandler_1_MetaMessageEventArgs_0;

		// Token: 0x04001871 RID: 6257
		private static readonly IntPtr NativeMethodInfoPtr_remove_MetaMessagePlayed_Public_rem_Void_EventHandler_1_MetaMessageEventArgs_0;

		// Token: 0x04001872 RID: 6258
		private static readonly IntPtr NativeMethodInfoPtr_add_Chased_Public_add_Void_EventHandler_1_ChasedEventArgs_0;

		// Token: 0x04001873 RID: 6259
		private static readonly IntPtr NativeMethodInfoPtr_remove_Chased_Public_rem_Void_EventHandler_1_ChasedEventArgs_0;

		// Token: 0x04001874 RID: 6260
		private static readonly IntPtr NativeMethodInfoPtr_add_Stopped_Public_add_Void_EventHandler_1_StoppedEventArgs_0;

		// Token: 0x04001875 RID: 6261
		private static readonly IntPtr NativeMethodInfoPtr_remove_Stopped_Public_rem_Void_EventHandler_1_StoppedEventArgs_0;

		// Token: 0x04001876 RID: 6262
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001877 RID: 6263
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04001878 RID: 6264
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04001879 RID: 6265
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x0400187A RID: 6266
		private static readonly IntPtr NativeMethodInfoPtr_Continue_Public_Void_0;

		// Token: 0x0400187B RID: 6267
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

		// Token: 0x0400187C RID: 6268
		private static readonly IntPtr NativeMethodInfoPtr_OnPlayingCompleted_Protected_Virtual_New_Void_EventArgs_0;

		// Token: 0x0400187D RID: 6269
		private static readonly IntPtr NativeMethodInfoPtr_OnDisposed_Protected_Virtual_New_Void_EventArgs_0;

		// Token: 0x0400187E RID: 6270
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_get_Int32_0;

		// Token: 0x0400187F RID: 6271
		private static readonly IntPtr NativeMethodInfoPtr_set_Position_Public_set_Void_Int32_0;

		// Token: 0x04001880 RID: 6272
		private static readonly IntPtr NativeMethodInfoPtr_get_Sequence_Public_get_Sequence_0;

		// Token: 0x04001881 RID: 6273
		private static readonly IntPtr NativeMethodInfoPtr_set_Sequence_Public_set_Void_Sequence_0;

		// Token: 0x04001882 RID: 6274
		private static readonly IntPtr NativeMethodInfoPtr_add_Disposed_Public_Virtual_Final_New_add_Void_EventHandler_0;

		// Token: 0x04001883 RID: 6275
		private static readonly IntPtr NativeMethodInfoPtr_remove_Disposed_Public_Virtual_Final_New_rem_Void_EventHandler_0;

		// Token: 0x04001884 RID: 6276
		private static readonly IntPtr NativeMethodInfoPtr_get_Site_Public_Virtual_Final_New_get_ISite_0;

		// Token: 0x04001885 RID: 6277
		private static readonly IntPtr NativeMethodInfoPtr_set_Site_Public_Virtual_Final_New_set_Void_ISite_0;

		// Token: 0x04001886 RID: 6278
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001887 RID: 6279
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__29_0_Private_Void_Object_MetaMessageEventArgs_0;

		// Token: 0x04001888 RID: 6280
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__29_1_Private_Void_Object_ChannelMessageEventArgs_0;

		// Token: 0x04001889 RID: 6281
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__29_2_Private_Void_Object_EventArgs_0;
	}
}
