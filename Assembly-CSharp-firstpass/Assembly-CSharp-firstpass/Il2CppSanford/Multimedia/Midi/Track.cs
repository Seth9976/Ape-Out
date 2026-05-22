using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x020001D3 RID: 467
	public sealed class Track : Object
	{
		// Token: 0x06001702 RID: 5890 RVA: 0x0006803C File Offset: 0x0006623C
		// Note: this type is marked as 'beforefieldinit'.
		static Track()
		{
			Il2CppClassPointerStore<Track>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "Track");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Track>.NativeClassPtr);
			Track.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Track>.NativeClassPtr, "count");
			Track.NativeFieldInfoPtr_endOfTrackOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Track>.NativeClassPtr, "endOfTrackOffset");
			Track.NativeFieldInfoPtr_head = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Track>.NativeClassPtr, "head");
			Track.NativeFieldInfoPtr_tail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Track>.NativeClassPtr, "tail");
			Track.NativeFieldInfoPtr_endOfTrackMidiEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Track>.NativeClassPtr, "endOfTrackMidiEvent");
			Track.NativeMethodInfoPtr_Iterator_Public_IEnumerable_1_MidiEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Track>.NativeClassPtr, 100666555);
			Track.NativeMethodInfoPtr_DispatcherIterator_Public_IEnumerable_1_Int32_MessageDispatcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Track>.NativeClassPtr, 100666556);
			Track.NativeMethodInfoPtr_TickIterator_Public_IEnumerable_1_Int32_Int32_ChannelChaser_MessageDispatcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Track>.NativeClassPtr, 100666557);
			Track.NativeMethodInfoPtr_Test_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Track>.NativeClassPtr, 100666558);
			Track.NativeMethodInfoPtr_TestInsert_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Track>.NativeClassPtr, 100666559);
			Track.NativeMethodInfoPtr_TestRemoveAt_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Track>.NativeClassPtr, 100666560);
			Track.NativeMethodInfoPtr_TestMerge_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Track>.NativeClassPtr, 100666561);
			Track.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Track>.NativeClassPtr, 100666562);
			Track.NativeMethodInfoPtr_Insert_Public_Void_Int32_IMidiMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Track>.NativeClassPtr, 100666563);
			Track.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Track>.NativeClassPtr, 100666564);
			Track.NativeMethodInfoPtr_Merge_Public_Void_Track_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Track>.NativeClassPtr, 100666565);
			Track.NativeMethodInfoPtr_RemoveAt_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Track>.NativeClassPtr, 100666566);
			Track.NativeMethodInfoPtr_GetMidiEvent_Public_MidiEvent_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Track>.NativeClassPtr, 100666567);
			Track.NativeMethodInfoPtr_Move_Public_Void_MidiEvent_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Track>.NativeClassPtr, 100666568);
			Track.NativeMethodInfoPtr_AssertValid_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Track>.NativeClassPtr, 100666569);
			Track.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Track>.NativeClassPtr, 100666570);
			Track.NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Track>.NativeClassPtr, 100666571);
			Track.NativeMethodInfoPtr_get_EndOfTrackOffset_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Track>.NativeClassPtr, 100666572);
			Track.NativeMethodInfoPtr_set_EndOfTrackOffset_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Track>.NativeClassPtr, 100666573);
			Track.NativeMethodInfoPtr_get_SyncRoot_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Track>.NativeClassPtr, 100666574);
		}

		// Token: 0x06001703 RID: 5891 RVA: 0x00068260 File Offset: 0x00066460
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 18029, RefRangeEnd = 18031, XrefRangeStart = 18024, XrefRangeEnd = 18029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<MidiEvent> Iterator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Track.NativeMethodInfoPtr_Iterator_Public_IEnumerable_1_MidiEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<MidiEvent>>(intPtr3) : null;
		}

		// Token: 0x06001704 RID: 5892 RVA: 0x000682A0 File Offset: 0x000664A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18031, XrefRangeEnd = 18036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<int> DispatcherIterator(MessageDispatcher dispatcher)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dispatcher);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Track.NativeMethodInfoPtr_DispatcherIterator_Public_IEnumerable_1_Int32_MessageDispatcher_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}
		}

		// Token: 0x06001705 RID: 5893 RVA: 0x000682F0 File Offset: 0x000664F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18036, XrefRangeEnd = 18041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<int> TickIterator(int startPosition, ChannelChaser chaser, MessageDispatcher dispatcher)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startPosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(chaser);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dispatcher);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Track.NativeMethodInfoPtr_TickIterator_Public_IEnumerable_1_Int32_Int32_ChannelChaser_MessageDispatcher_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
		}

		// Token: 0x06001706 RID: 5894 RVA: 0x00068360 File Offset: 0x00066560
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Test()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Track.NativeMethodInfoPtr_Test_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001707 RID: 5895 RVA: 0x00068388 File Offset: 0x00066588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18041, XrefRangeEnd = 18055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TestInsert()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Track.NativeMethodInfoPtr_TestInsert_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001708 RID: 5896 RVA: 0x000683B0 File Offset: 0x000665B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18055, XrefRangeEnd = 18073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TestRemoveAt()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Track.NativeMethodInfoPtr_TestRemoveAt_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001709 RID: 5897 RVA: 0x000683D8 File Offset: 0x000665D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18073, XrefRangeEnd = 18148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TestMerge()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Track.NativeMethodInfoPtr_TestMerge_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600170A RID: 5898 RVA: 0x00068400 File Offset: 0x00066600
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 18156, RefRangeEnd = 18166, XrefRangeStart = 18148, XrefRangeEnd = 18156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Track()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Track>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Track.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600170B RID: 5899 RVA: 0x0006843C File Offset: 0x0006663C
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 18180, RefRangeEnd = 18200, XrefRangeStart = 18166, XrefRangeEnd = 18180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Insert(int position, IMidiMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Track.NativeMethodInfoPtr_Insert_Public_Void_Int32_IMidiMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600170C RID: 5900 RVA: 0x0006848C File Offset: 0x0006668C
		[CallerCount(0)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Track.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600170D RID: 5901 RVA: 0x000684C0 File Offset: 0x000666C0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 18217, RefRangeEnd = 18220, XrefRangeStart = 18200, XrefRangeEnd = 18217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Merge(Track trk)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(trk);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Track.NativeMethodInfoPtr_Merge_Public_Void_Track_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600170E RID: 5902 RVA: 0x00068504 File Offset: 0x00066704
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 18229, RefRangeEnd = 18234, XrefRangeStart = 18220, XrefRangeEnd = 18229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Track.NativeMethodInfoPtr_RemoveAt_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600170F RID: 5903 RVA: 0x00068544 File Offset: 0x00066744
		[CallerCount(0)]
		public unsafe MidiEvent GetMidiEvent(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Track.NativeMethodInfoPtr_GetMidiEvent_Public_MidiEvent_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MidiEvent>(intPtr3) : null;
			}
		}

		// Token: 0x06001710 RID: 5904 RVA: 0x00068590 File Offset: 0x00066790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18234, XrefRangeEnd = 18240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Move(MidiEvent e, int newPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Track.NativeMethodInfoPtr_Move_Public_Void_MidiEvent_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001711 RID: 5905 RVA: 0x000685E0 File Offset: 0x000667E0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssertValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Track.NativeMethodInfoPtr_AssertValid_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06001712 RID: 5906 RVA: 0x00068614 File Offset: 0x00066814
		public unsafe int Count
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Track.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06001713 RID: 5907 RVA: 0x00068650 File Offset: 0x00066850
		public unsafe int Length
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Track.NativeMethodInfoPtr_get_Length_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06001714 RID: 5908 RVA: 0x0006868C File Offset: 0x0006688C
		// (set) Token: 0x06001715 RID: 5909 RVA: 0x000686C8 File Offset: 0x000668C8
		public unsafe int EndOfTrackOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Track.NativeMethodInfoPtr_get_EndOfTrackOffset_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 18240, RefRangeEnd = 18241, XrefRangeStart = 18240, XrefRangeEnd = 18240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Track.NativeMethodInfoPtr_set_EndOfTrackOffset_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06001716 RID: 5910 RVA: 0x00068708 File Offset: 0x00066908
		public unsafe Object SyncRoot
		{
			[CallerCount(397)]
			[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Track.NativeMethodInfoPtr_get_SyncRoot_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001717 RID: 5911 RVA: 0x000093AE File Offset: 0x000075AE
		public Track(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06001718 RID: 5912 RVA: 0x00068748 File Offset: 0x00066948
		// (set) Token: 0x06001719 RID: 5913 RVA: 0x000093B7 File Offset: 0x000075B7
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x0600171A RID: 5914 RVA: 0x00068770 File Offset: 0x00066970
		// (set) Token: 0x0600171B RID: 5915 RVA: 0x000093D2 File Offset: 0x000075D2
		public unsafe int endOfTrackOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track.NativeFieldInfoPtr_endOfTrackOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track.NativeFieldInfoPtr_endOfTrackOffset)) = value;
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x0600171C RID: 5916 RVA: 0x00068798 File Offset: 0x00066998
		// (set) Token: 0x0600171D RID: 5917 RVA: 0x000093ED File Offset: 0x000075ED
		public unsafe MidiEvent head
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track.NativeFieldInfoPtr_head);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MidiEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track.NativeFieldInfoPtr_head), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x0600171E RID: 5918 RVA: 0x000687C8 File Offset: 0x000669C8
		// (set) Token: 0x0600171F RID: 5919 RVA: 0x0000940C File Offset: 0x0000760C
		public unsafe MidiEvent tail
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track.NativeFieldInfoPtr_tail);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MidiEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track.NativeFieldInfoPtr_tail), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06001720 RID: 5920 RVA: 0x000687F8 File Offset: 0x000669F8
		// (set) Token: 0x06001721 RID: 5921 RVA: 0x0000942B File Offset: 0x0000762B
		public unsafe MidiEvent endOfTrackMidiEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track.NativeFieldInfoPtr_endOfTrackMidiEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MidiEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track.NativeFieldInfoPtr_endOfTrackMidiEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400188A RID: 6282
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x0400188B RID: 6283
		private static readonly IntPtr NativeFieldInfoPtr_endOfTrackOffset;

		// Token: 0x0400188C RID: 6284
		private static readonly IntPtr NativeFieldInfoPtr_head;

		// Token: 0x0400188D RID: 6285
		private static readonly IntPtr NativeFieldInfoPtr_tail;

		// Token: 0x0400188E RID: 6286
		private static readonly IntPtr NativeFieldInfoPtr_endOfTrackMidiEvent;

		// Token: 0x0400188F RID: 6287
		private static readonly IntPtr NativeMethodInfoPtr_Iterator_Public_IEnumerable_1_MidiEvent_0;

		// Token: 0x04001890 RID: 6288
		private static readonly IntPtr NativeMethodInfoPtr_DispatcherIterator_Public_IEnumerable_1_Int32_MessageDispatcher_0;

		// Token: 0x04001891 RID: 6289
		private static readonly IntPtr NativeMethodInfoPtr_TickIterator_Public_IEnumerable_1_Int32_Int32_ChannelChaser_MessageDispatcher_0;

		// Token: 0x04001892 RID: 6290
		private static readonly IntPtr NativeMethodInfoPtr_Test_Public_Static_Void_0;

		// Token: 0x04001893 RID: 6291
		private static readonly IntPtr NativeMethodInfoPtr_TestInsert_Private_Static_Void_0;

		// Token: 0x04001894 RID: 6292
		private static readonly IntPtr NativeMethodInfoPtr_TestRemoveAt_Private_Static_Void_0;

		// Token: 0x04001895 RID: 6293
		private static readonly IntPtr NativeMethodInfoPtr_TestMerge_Private_Static_Void_0;

		// Token: 0x04001896 RID: 6294
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001897 RID: 6295
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_Void_Int32_IMidiMessage_0;

		// Token: 0x04001898 RID: 6296
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04001899 RID: 6297
		private static readonly IntPtr NativeMethodInfoPtr_Merge_Public_Void_Track_0;

		// Token: 0x0400189A RID: 6298
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAt_Public_Void_Int32_0;

		// Token: 0x0400189B RID: 6299
		private static readonly IntPtr NativeMethodInfoPtr_GetMidiEvent_Public_MidiEvent_Int32_0;

		// Token: 0x0400189C RID: 6300
		private static readonly IntPtr NativeMethodInfoPtr_Move_Public_Void_MidiEvent_Int32_0;

		// Token: 0x0400189D RID: 6301
		private static readonly IntPtr NativeMethodInfoPtr_AssertValid_Private_Void_0;

		// Token: 0x0400189E RID: 6302
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x0400189F RID: 6303
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;

		// Token: 0x040018A0 RID: 6304
		private static readonly IntPtr NativeMethodInfoPtr_get_EndOfTrackOffset_Public_get_Int32_0;

		// Token: 0x040018A1 RID: 6305
		private static readonly IntPtr NativeMethodInfoPtr_set_EndOfTrackOffset_Public_set_Void_Int32_0;

		// Token: 0x040018A2 RID: 6306
		private static readonly IntPtr NativeMethodInfoPtr_get_SyncRoot_Public_get_Object_0;

		// Token: 0x02000256 RID: 598
		[ObfuscatedName("Sanford.Multimedia.Midi.Track+<Iterator>d__0")]
		public sealed class _Iterator_d__0 : Object
		{
			// Token: 0x06002081 RID: 8321 RVA: 0x0008E57C File Offset: 0x0008C77C
			// Note: this type is marked as 'beforefieldinit'.
			static _Iterator_d__0()
			{
				Il2CppClassPointerStore<Track._Iterator_d__0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Track>.NativeClassPtr, "<Iterator>d__0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Track._Iterator_d__0>.NativeClassPtr);
				Track._Iterator_d__0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Track._Iterator_d__0>.NativeClassPtr, "<>1__state");
				Track._Iterator_d__0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Track._Iterator_d__0>.NativeClassPtr, "<>2__current");
				Track._Iterator_d__0.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Track._Iterator_d__0>.NativeClassPtr, "<>l__initialThreadId");
				Track._Iterator_d__0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Track._Iterator_d__0>.NativeClassPtr, "<>4__this");
				Track._Iterator_d__0.NativeFieldInfoPtr__current_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Track._Iterator_d__0>.NativeClassPtr, "<current>5__2");
				Track._Iterator_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Track._Iterator_d__0>.NativeClassPtr, 100666575);
				Track._Iterator_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Track._Iterator_d__0>.NativeClassPtr, 100666576);
				Track._Iterator_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Track._Iterator_d__0>.NativeClassPtr, 100666577);
				Track._Iterator_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Sanford_Multimedia_Midi_MidiEvent__get_Current_Private_Virtual_Final_New_get_MidiEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Track._Iterator_d__0>.NativeClassPtr, 100666578);
				Track._Iterator_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Track._Iterator_d__0>.NativeClassPtr, 100666579);
				Track._Iterator_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Track._Iterator_d__0>.NativeClassPtr, 100666580);
				Track._Iterator_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Sanford_Multimedia_Midi_MidiEvent__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_MidiEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Track._Iterator_d__0>.NativeClassPtr, 100666581);
				Track._Iterator_d__0.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Track._Iterator_d__0>.NativeClassPtr, 100666582);
			}

			// Token: 0x06002082 RID: 8322 RVA: 0x0008E6AC File Offset: 0x0008C8AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17961, XrefRangeEnd = 17963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Iterator_d__0(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Track._Iterator_d__0>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Track._Iterator_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002083 RID: 8323 RVA: 0x0008E6F4 File Offset: 0x0008C8F4
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Track._Iterator_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002084 RID: 8324 RVA: 0x0008E728 File Offset: 0x0008C928
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Track._Iterator_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000669 RID: 1641
			// (get) Token: 0x06002085 RID: 8325 RVA: 0x0008E764 File Offset: 0x0008C964
			public unsafe MidiEvent System.Collections.Generic.IEnumerator<Sanford.Multimedia.Midi.MidiEvent>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Track._Iterator_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Sanford_Multimedia_Midi_MidiEvent__get_Current_Private_Virtual_Final_New_get_MidiEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<MidiEvent>(intPtr3) : null;
				}
			}

			// Token: 0x06002086 RID: 8326 RVA: 0x0008E7A4 File Offset: 0x0008C9A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17963, XrefRangeEnd = 17968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Track._Iterator_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700066A RID: 1642
			// (get) Token: 0x06002087 RID: 8327 RVA: 0x0008E7D8 File Offset: 0x0008C9D8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Track._Iterator_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002088 RID: 8328 RVA: 0x0008E818 File Offset: 0x0008CA18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17968, XrefRangeEnd = 17971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<MidiEvent> System_Collections_Generic_IEnumerable_Sanford_Multimedia_Midi_MidiEvent__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Track._Iterator_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Sanford_Multimedia_Midi_MidiEvent__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_MidiEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<MidiEvent>>(intPtr3) : null;
			}

			// Token: 0x06002089 RID: 8329 RVA: 0x0008E858 File Offset: 0x0008CA58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Track._Iterator_d__0.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600208A RID: 8330 RVA: 0x0000BF82 File Offset: 0x0000A182
			public _Iterator_d__0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000664 RID: 1636
			// (get) Token: 0x0600208B RID: 8331 RVA: 0x0008E898 File Offset: 0x0008CA98
			// (set) Token: 0x0600208C RID: 8332 RVA: 0x0000BF8B File Offset: 0x0000A18B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track._Iterator_d__0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track._Iterator_d__0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000665 RID: 1637
			// (get) Token: 0x0600208D RID: 8333 RVA: 0x0008E8C0 File Offset: 0x0008CAC0
			// (set) Token: 0x0600208E RID: 8334 RVA: 0x0000BFA6 File Offset: 0x0000A1A6
			public unsafe MidiEvent __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track._Iterator_d__0.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MidiEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track._Iterator_d__0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000666 RID: 1638
			// (get) Token: 0x0600208F RID: 8335 RVA: 0x0008E8F0 File Offset: 0x0008CAF0
			// (set) Token: 0x06002090 RID: 8336 RVA: 0x0000BFC5 File Offset: 0x0000A1C5
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track._Iterator_d__0.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track._Iterator_d__0.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000667 RID: 1639
			// (get) Token: 0x06002091 RID: 8337 RVA: 0x0008E918 File Offset: 0x0008CB18
			// (set) Token: 0x06002092 RID: 8338 RVA: 0x0000BFE0 File Offset: 0x0000A1E0
			public unsafe Track __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track._Iterator_d__0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Track>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track._Iterator_d__0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000668 RID: 1640
			// (get) Token: 0x06002093 RID: 8339 RVA: 0x0008E948 File Offset: 0x0008CB48
			// (set) Token: 0x06002094 RID: 8340 RVA: 0x0000BFFF File Offset: 0x0000A1FF
			public unsafe MidiEvent _current_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track._Iterator_d__0.NativeFieldInfoPtr__current_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MidiEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track._Iterator_d__0.NativeFieldInfoPtr__current_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400205A RID: 8282
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400205B RID: 8283
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400205C RID: 8284
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400205D RID: 8285
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400205E RID: 8286
			private static readonly IntPtr NativeFieldInfoPtr__current_5__2;

			// Token: 0x0400205F RID: 8287
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002060 RID: 8288
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002061 RID: 8289
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002062 RID: 8290
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Sanford_Multimedia_Midi_MidiEvent__get_Current_Private_Virtual_Final_New_get_MidiEvent_0;

			// Token: 0x04002063 RID: 8291
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002064 RID: 8292
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002065 RID: 8293
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Sanford_Multimedia_Midi_MidiEvent__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_MidiEvent_0;

			// Token: 0x04002066 RID: 8294
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000257 RID: 599
		[ObfuscatedName("Sanford.Multimedia.Midi.Track+<DispatcherIterator>d__1")]
		public sealed class _DispatcherIterator_d__1 : Object
		{
			// Token: 0x06002095 RID: 8341 RVA: 0x0008E978 File Offset: 0x0008CB78
			// Note: this type is marked as 'beforefieldinit'.
			static _DispatcherIterator_d__1()
			{
				Il2CppClassPointerStore<Track._DispatcherIterator_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Track>.NativeClassPtr, "<DispatcherIterator>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Track._DispatcherIterator_d__1>.NativeClassPtr);
				Track._DispatcherIterator_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Track._DispatcherIterator_d__1>.NativeClassPtr, "<>1__state");
				Track._DispatcherIterator_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Track._DispatcherIterator_d__1>.NativeClassPtr, "<>2__current");
				Track._DispatcherIterator_d__1.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Track._DispatcherIterator_d__1>.NativeClassPtr, "<>l__initialThreadId");
				Track._DispatcherIterator_d__1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Track._DispatcherIterator_d__1>.NativeClassPtr, "<>4__this");
				Track._DispatcherIterator_d__1.NativeFieldInfoPtr_dispatcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Track._DispatcherIterator_d__1>.NativeClassPtr, "dispatcher");
				Track._DispatcherIterator_d__1.NativeFieldInfoPtr___3__dispatcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Track._DispatcherIterator_d__1>.NativeClassPtr, "<>3__dispatcher");
				Track._DispatcherIterator_d__1.NativeFieldInfoPtr__enumerator_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Track._DispatcherIterator_d__1>.NativeClassPtr, "<enumerator>5__2");
				Track._DispatcherIterator_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Track._DispatcherIterator_d__1>.NativeClassPtr, 100666583);
				Track._DispatcherIterator_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Track._DispatcherIterator_d__1>.NativeClassPtr, 100666584);
				Track._DispatcherIterator_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Track._DispatcherIterator_d__1>.NativeClassPtr, 100666585);
				Track._DispatcherIterator_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Int32__get_Current_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Track._DispatcherIterator_d__1>.NativeClassPtr, 100666586);
				Track._DispatcherIterator_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Track._DispatcherIterator_d__1>.NativeClassPtr, 100666587);
				Track._DispatcherIterator_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Track._DispatcherIterator_d__1>.NativeClassPtr, 100666588);
				Track._DispatcherIterator_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Int32__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Track._DispatcherIterator_d__1>.NativeClassPtr, 100666589);
				Track._DispatcherIterator_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Track._DispatcherIterator_d__1>.NativeClassPtr, 100666590);
			}

			// Token: 0x06002096 RID: 8342 RVA: 0x0008EAD0 File Offset: 0x0008CCD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17971, XrefRangeEnd = 17973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DispatcherIterator_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Track._DispatcherIterator_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Track._DispatcherIterator_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002097 RID: 8343 RVA: 0x0008EB18 File Offset: 0x0008CD18
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Track._DispatcherIterator_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002098 RID: 8344 RVA: 0x0008EB4C File Offset: 0x0008CD4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17973, XrefRangeEnd = 17985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Track._DispatcherIterator_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000672 RID: 1650
			// (get) Token: 0x06002099 RID: 8345 RVA: 0x0008EB88 File Offset: 0x0008CD88
			public unsafe int System.Collections.Generic.IEnumerator<System.Int32>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Track._DispatcherIterator_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Int32__get_Current_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600209A RID: 8346 RVA: 0x0008EBC4 File Offset: 0x0008CDC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17985, XrefRangeEnd = 17990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Track._DispatcherIterator_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000673 RID: 1651
			// (get) Token: 0x0600209B RID: 8347 RVA: 0x0008EBF8 File Offset: 0x0008CDF8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17990, XrefRangeEnd = 17993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Track._DispatcherIterator_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600209C RID: 8348 RVA: 0x0008EC38 File Offset: 0x0008CE38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17993, XrefRangeEnd = 18001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<int> System_Collections_Generic_IEnumerable_System_Int32__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Track._DispatcherIterator_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Int32__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<int>>(intPtr3) : null;
			}

			// Token: 0x0600209D RID: 8349 RVA: 0x0008EC78 File Offset: 0x0008CE78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Track._DispatcherIterator_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600209E RID: 8350 RVA: 0x0000C01E File Offset: 0x0000A21E
			public _DispatcherIterator_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700066B RID: 1643
			// (get) Token: 0x0600209F RID: 8351 RVA: 0x0008ECB8 File Offset: 0x0008CEB8
			// (set) Token: 0x060020A0 RID: 8352 RVA: 0x0000C027 File Offset: 0x0000A227
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track._DispatcherIterator_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track._DispatcherIterator_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700066C RID: 1644
			// (get) Token: 0x060020A1 RID: 8353 RVA: 0x0008ECE0 File Offset: 0x0008CEE0
			// (set) Token: 0x060020A2 RID: 8354 RVA: 0x0000C042 File Offset: 0x0000A242
			public unsafe int __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track._DispatcherIterator_d__1.NativeFieldInfoPtr___2__current);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track._DispatcherIterator_d__1.NativeFieldInfoPtr___2__current)) = value;
				}
			}

			// Token: 0x1700066D RID: 1645
			// (get) Token: 0x060020A3 RID: 8355 RVA: 0x0008ED08 File Offset: 0x0008CF08
			// (set) Token: 0x060020A4 RID: 8356 RVA: 0x0000C05D File Offset: 0x0000A25D
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track._DispatcherIterator_d__1.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track._DispatcherIterator_d__1.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700066E RID: 1646
			// (get) Token: 0x060020A5 RID: 8357 RVA: 0x0008ED30 File Offset: 0x0008CF30
			// (set) Token: 0x060020A6 RID: 8358 RVA: 0x0000C078 File Offset: 0x0000A278
			public unsafe Track __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track._DispatcherIterator_d__1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Track>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track._DispatcherIterator_d__1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700066F RID: 1647
			// (get) Token: 0x060020A7 RID: 8359 RVA: 0x0008ED60 File Offset: 0x0008CF60
			// (set) Token: 0x060020A8 RID: 8360 RVA: 0x0000C097 File Offset: 0x0000A297
			public unsafe MessageDispatcher dispatcher
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track._DispatcherIterator_d__1.NativeFieldInfoPtr_dispatcher);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MessageDispatcher>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track._DispatcherIterator_d__1.NativeFieldInfoPtr_dispatcher), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000670 RID: 1648
			// (get) Token: 0x060020A9 RID: 8361 RVA: 0x0008ED90 File Offset: 0x0008CF90
			// (set) Token: 0x060020AA RID: 8362 RVA: 0x0000C0B6 File Offset: 0x0000A2B6
			public unsafe MessageDispatcher __3__dispatcher
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track._DispatcherIterator_d__1.NativeFieldInfoPtr___3__dispatcher);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MessageDispatcher>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track._DispatcherIterator_d__1.NativeFieldInfoPtr___3__dispatcher), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000671 RID: 1649
			// (get) Token: 0x060020AB RID: 8363 RVA: 0x0008EDC0 File Offset: 0x0008CFC0
			// (set) Token: 0x060020AC RID: 8364 RVA: 0x0000C0D5 File Offset: 0x0000A2D5
			public unsafe IEnumerator<MidiEvent> _enumerator_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track._DispatcherIterator_d__1.NativeFieldInfoPtr__enumerator_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<MidiEvent>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track._DispatcherIterator_d__1.NativeFieldInfoPtr__enumerator_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002067 RID: 8295
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002068 RID: 8296
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002069 RID: 8297
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400206A RID: 8298
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400206B RID: 8299
			private static readonly IntPtr NativeFieldInfoPtr_dispatcher;

			// Token: 0x0400206C RID: 8300
			private static readonly IntPtr NativeFieldInfoPtr___3__dispatcher;

			// Token: 0x0400206D RID: 8301
			private static readonly IntPtr NativeFieldInfoPtr__enumerator_5__2;

			// Token: 0x0400206E RID: 8302
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400206F RID: 8303
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002070 RID: 8304
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002071 RID: 8305
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Int32__get_Current_Private_Virtual_Final_New_get_Int32_0;

			// Token: 0x04002072 RID: 8306
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002073 RID: 8307
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002074 RID: 8308
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Int32__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Int32_0;

			// Token: 0x04002075 RID: 8309
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000258 RID: 600
		[ObfuscatedName("Sanford.Multimedia.Midi.Track+<TickIterator>d__2")]
		public sealed class _TickIterator_d__2 : Object
		{
			// Token: 0x060020AD RID: 8365 RVA: 0x0008EDF0 File Offset: 0x0008CFF0
			// Note: this type is marked as 'beforefieldinit'.
			static _TickIterator_d__2()
			{
				Il2CppClassPointerStore<Track._TickIterator_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Track>.NativeClassPtr, "<TickIterator>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Track._TickIterator_d__2>.NativeClassPtr);
				Track._TickIterator_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Track._TickIterator_d__2>.NativeClassPtr, "<>1__state");
				Track._TickIterator_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Track._TickIterator_d__2>.NativeClassPtr, "<>2__current");
				Track._TickIterator_d__2.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Track._TickIterator_d__2>.NativeClassPtr, "<>l__initialThreadId");
				Track._TickIterator_d__2.NativeFieldInfoPtr_startPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Track._TickIterator_d__2>.NativeClassPtr, "startPosition");
				Track._TickIterator_d__2.NativeFieldInfoPtr___3__startPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Track._TickIterator_d__2>.NativeClassPtr, "<>3__startPosition");
				Track._TickIterator_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Track._TickIterator_d__2>.NativeClassPtr, "<>4__this");
				Track._TickIterator_d__2.NativeFieldInfoPtr_chaser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Track._TickIterator_d__2>.NativeClassPtr, "chaser");
				Track._TickIterator_d__2.NativeFieldInfoPtr___3__chaser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Track._TickIterator_d__2>.NativeClassPtr, "<>3__chaser");
				Track._TickIterator_d__2.NativeFieldInfoPtr_dispatcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Track._TickIterator_d__2>.NativeClassPtr, "dispatcher");
				Track._TickIterator_d__2.NativeFieldInfoPtr___3__dispatcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Track._TickIterator_d__2>.NativeClassPtr, "<>3__dispatcher");
				Track._TickIterator_d__2.NativeFieldInfoPtr__enumerator_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Track._TickIterator_d__2>.NativeClassPtr, "<enumerator>5__2");
				Track._TickIterator_d__2.NativeFieldInfoPtr__notFinished_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Track._TickIterator_d__2>.NativeClassPtr, "<notFinished>5__3");
				Track._TickIterator_d__2.NativeFieldInfoPtr__ticks_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Track._TickIterator_d__2>.NativeClassPtr, "<ticks>5__4");
				Track._TickIterator_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Track._TickIterator_d__2>.NativeClassPtr, 100666591);
				Track._TickIterator_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Track._TickIterator_d__2>.NativeClassPtr, 100666592);
				Track._TickIterator_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Track._TickIterator_d__2>.NativeClassPtr, 100666593);
				Track._TickIterator_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Int32__get_Current_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Track._TickIterator_d__2>.NativeClassPtr, 100666594);
				Track._TickIterator_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Track._TickIterator_d__2>.NativeClassPtr, 100666595);
				Track._TickIterator_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Track._TickIterator_d__2>.NativeClassPtr, 100666596);
				Track._TickIterator_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Int32__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Track._TickIterator_d__2>.NativeClassPtr, 100666597);
				Track._TickIterator_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Track._TickIterator_d__2>.NativeClassPtr, 100666598);
			}

			// Token: 0x060020AE RID: 8366 RVA: 0x0008EFC0 File Offset: 0x0008D1C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _TickIterator_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Track._TickIterator_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Track._TickIterator_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060020AF RID: 8367 RVA: 0x0008F008 File Offset: 0x0008D208
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Track._TickIterator_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060020B0 RID: 8368 RVA: 0x0008F03C File Offset: 0x0008D23C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18001, XrefRangeEnd = 18006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Track._TickIterator_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000681 RID: 1665
			// (get) Token: 0x060020B1 RID: 8369 RVA: 0x0008F078 File Offset: 0x0008D278
			public unsafe int System.Collections.Generic.IEnumerator<System.Int32>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Track._TickIterator_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Int32__get_Current_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060020B2 RID: 8370 RVA: 0x0008F0B4 File Offset: 0x0008D2B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18006, XrefRangeEnd = 18011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Track._TickIterator_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000682 RID: 1666
			// (get) Token: 0x060020B3 RID: 8371 RVA: 0x0008F0E8 File Offset: 0x0008D2E8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18011, XrefRangeEnd = 18014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Track._TickIterator_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060020B4 RID: 8372 RVA: 0x0008F128 File Offset: 0x0008D328
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 18022, RefRangeEnd = 18023, XrefRangeStart = 18014, XrefRangeEnd = 18022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<int> System_Collections_Generic_IEnumerable_System_Int32__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Track._TickIterator_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Int32__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<int>>(intPtr3) : null;
			}

			// Token: 0x060020B5 RID: 8373 RVA: 0x0008F168 File Offset: 0x0008D368
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18023, XrefRangeEnd = 18024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Track._TickIterator_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060020B6 RID: 8374 RVA: 0x0000C0F4 File Offset: 0x0000A2F4
			public _TickIterator_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000674 RID: 1652
			// (get) Token: 0x060020B7 RID: 8375 RVA: 0x0008F1A8 File Offset: 0x0008D3A8
			// (set) Token: 0x060020B8 RID: 8376 RVA: 0x0000C0FD File Offset: 0x0000A2FD
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track._TickIterator_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track._TickIterator_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000675 RID: 1653
			// (get) Token: 0x060020B9 RID: 8377 RVA: 0x0008F1D0 File Offset: 0x0008D3D0
			// (set) Token: 0x060020BA RID: 8378 RVA: 0x0000C118 File Offset: 0x0000A318
			public unsafe int __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track._TickIterator_d__2.NativeFieldInfoPtr___2__current);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track._TickIterator_d__2.NativeFieldInfoPtr___2__current)) = value;
				}
			}

			// Token: 0x17000676 RID: 1654
			// (get) Token: 0x060020BB RID: 8379 RVA: 0x0008F1F8 File Offset: 0x0008D3F8
			// (set) Token: 0x060020BC RID: 8380 RVA: 0x0000C133 File Offset: 0x0000A333
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track._TickIterator_d__2.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track._TickIterator_d__2.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000677 RID: 1655
			// (get) Token: 0x060020BD RID: 8381 RVA: 0x0008F220 File Offset: 0x0008D420
			// (set) Token: 0x060020BE RID: 8382 RVA: 0x0000C14E File Offset: 0x0000A34E
			public unsafe int startPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track._TickIterator_d__2.NativeFieldInfoPtr_startPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track._TickIterator_d__2.NativeFieldInfoPtr_startPosition)) = value;
				}
			}

			// Token: 0x17000678 RID: 1656
			// (get) Token: 0x060020BF RID: 8383 RVA: 0x0008F248 File Offset: 0x0008D448
			// (set) Token: 0x060020C0 RID: 8384 RVA: 0x0000C169 File Offset: 0x0000A369
			public unsafe int __3__startPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track._TickIterator_d__2.NativeFieldInfoPtr___3__startPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track._TickIterator_d__2.NativeFieldInfoPtr___3__startPosition)) = value;
				}
			}

			// Token: 0x17000679 RID: 1657
			// (get) Token: 0x060020C1 RID: 8385 RVA: 0x0008F270 File Offset: 0x0008D470
			// (set) Token: 0x060020C2 RID: 8386 RVA: 0x0000C184 File Offset: 0x0000A384
			public unsafe Track __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track._TickIterator_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Track>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track._TickIterator_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700067A RID: 1658
			// (get) Token: 0x060020C3 RID: 8387 RVA: 0x0008F2A0 File Offset: 0x0008D4A0
			// (set) Token: 0x060020C4 RID: 8388 RVA: 0x0000C1A3 File Offset: 0x0000A3A3
			public unsafe ChannelChaser chaser
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track._TickIterator_d__2.NativeFieldInfoPtr_chaser);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChannelChaser>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track._TickIterator_d__2.NativeFieldInfoPtr_chaser), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700067B RID: 1659
			// (get) Token: 0x060020C5 RID: 8389 RVA: 0x0008F2D0 File Offset: 0x0008D4D0
			// (set) Token: 0x060020C6 RID: 8390 RVA: 0x0000C1C2 File Offset: 0x0000A3C2
			public unsafe ChannelChaser __3__chaser
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track._TickIterator_d__2.NativeFieldInfoPtr___3__chaser);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChannelChaser>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track._TickIterator_d__2.NativeFieldInfoPtr___3__chaser), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700067C RID: 1660
			// (get) Token: 0x060020C7 RID: 8391 RVA: 0x0008F300 File Offset: 0x0008D500
			// (set) Token: 0x060020C8 RID: 8392 RVA: 0x0000C1E1 File Offset: 0x0000A3E1
			public unsafe MessageDispatcher dispatcher
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track._TickIterator_d__2.NativeFieldInfoPtr_dispatcher);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MessageDispatcher>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track._TickIterator_d__2.NativeFieldInfoPtr_dispatcher), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700067D RID: 1661
			// (get) Token: 0x060020C9 RID: 8393 RVA: 0x0008F330 File Offset: 0x0008D530
			// (set) Token: 0x060020CA RID: 8394 RVA: 0x0000C200 File Offset: 0x0000A400
			public unsafe MessageDispatcher __3__dispatcher
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track._TickIterator_d__2.NativeFieldInfoPtr___3__dispatcher);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MessageDispatcher>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track._TickIterator_d__2.NativeFieldInfoPtr___3__dispatcher), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700067E RID: 1662
			// (get) Token: 0x060020CB RID: 8395 RVA: 0x0008F360 File Offset: 0x0008D560
			// (set) Token: 0x060020CC RID: 8396 RVA: 0x0000C21F File Offset: 0x0000A41F
			public unsafe IEnumerator<MidiEvent> _enumerator_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track._TickIterator_d__2.NativeFieldInfoPtr__enumerator_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<MidiEvent>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track._TickIterator_d__2.NativeFieldInfoPtr__enumerator_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700067F RID: 1663
			// (get) Token: 0x060020CD RID: 8397 RVA: 0x0008F390 File Offset: 0x0008D590
			// (set) Token: 0x060020CE RID: 8398 RVA: 0x0000C23E File Offset: 0x0000A43E
			public unsafe bool _notFinished_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track._TickIterator_d__2.NativeFieldInfoPtr__notFinished_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track._TickIterator_d__2.NativeFieldInfoPtr__notFinished_5__3)) = value;
				}
			}

			// Token: 0x17000680 RID: 1664
			// (get) Token: 0x060020CF RID: 8399 RVA: 0x0008F3B8 File Offset: 0x0008D5B8
			// (set) Token: 0x060020D0 RID: 8400 RVA: 0x0000C259 File Offset: 0x0000A459
			public unsafe int _ticks_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track._TickIterator_d__2.NativeFieldInfoPtr__ticks_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track._TickIterator_d__2.NativeFieldInfoPtr__ticks_5__4)) = value;
				}
			}

			// Token: 0x04002076 RID: 8310
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002077 RID: 8311
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002078 RID: 8312
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04002079 RID: 8313
			private static readonly IntPtr NativeFieldInfoPtr_startPosition;

			// Token: 0x0400207A RID: 8314
			private static readonly IntPtr NativeFieldInfoPtr___3__startPosition;

			// Token: 0x0400207B RID: 8315
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400207C RID: 8316
			private static readonly IntPtr NativeFieldInfoPtr_chaser;

			// Token: 0x0400207D RID: 8317
			private static readonly IntPtr NativeFieldInfoPtr___3__chaser;

			// Token: 0x0400207E RID: 8318
			private static readonly IntPtr NativeFieldInfoPtr_dispatcher;

			// Token: 0x0400207F RID: 8319
			private static readonly IntPtr NativeFieldInfoPtr___3__dispatcher;

			// Token: 0x04002080 RID: 8320
			private static readonly IntPtr NativeFieldInfoPtr__enumerator_5__2;

			// Token: 0x04002081 RID: 8321
			private static readonly IntPtr NativeFieldInfoPtr__notFinished_5__3;

			// Token: 0x04002082 RID: 8322
			private static readonly IntPtr NativeFieldInfoPtr__ticks_5__4;

			// Token: 0x04002083 RID: 8323
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002084 RID: 8324
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002085 RID: 8325
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002086 RID: 8326
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Int32__get_Current_Private_Virtual_Final_New_get_Int32_0;

			// Token: 0x04002087 RID: 8327
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002088 RID: 8328
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002089 RID: 8329
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Int32__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Int32_0;

			// Token: 0x0400208A RID: 8330
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
