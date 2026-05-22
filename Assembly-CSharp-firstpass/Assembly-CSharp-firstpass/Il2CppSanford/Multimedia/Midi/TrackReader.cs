using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.IO;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x020001D4 RID: 468
	public class TrackReader : Object
	{
		// Token: 0x06001722 RID: 5922 RVA: 0x00068828 File Offset: 0x00066A28
		// Note: this type is marked as 'beforefieldinit'.
		static TrackReader()
		{
			Il2CppClassPointerStore<TrackReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "TrackReader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackReader>.NativeClassPtr);
			TrackReader.NativeFieldInfoPtr_track = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackReader>.NativeClassPtr, "track");
			TrackReader.NativeFieldInfoPtr_newTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackReader>.NativeClassPtr, "newTrack");
			TrackReader.NativeFieldInfoPtr_cmBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackReader>.NativeClassPtr, "cmBuilder");
			TrackReader.NativeFieldInfoPtr_scBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackReader>.NativeClassPtr, "scBuilder");
			TrackReader.NativeFieldInfoPtr_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackReader>.NativeClassPtr, "stream");
			TrackReader.NativeFieldInfoPtr_trackData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackReader>.NativeClassPtr, "trackData");
			TrackReader.NativeFieldInfoPtr_trackIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackReader>.NativeClassPtr, "trackIndex");
			TrackReader.NativeFieldInfoPtr_previousTicks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackReader>.NativeClassPtr, "previousTicks");
			TrackReader.NativeFieldInfoPtr_ticks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackReader>.NativeClassPtr, "ticks");
			TrackReader.NativeFieldInfoPtr_status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackReader>.NativeClassPtr, "status");
			TrackReader.NativeFieldInfoPtr_runningStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackReader>.NativeClassPtr, "runningStatus");
			TrackReader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackReader>.NativeClassPtr, 100666599);
			TrackReader.NativeMethodInfoPtr_Read_Public_Void_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackReader>.NativeClassPtr, 100666600);
			TrackReader.NativeMethodInfoPtr_FindTrack_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackReader>.NativeClassPtr, 100666601);
			TrackReader.NativeMethodInfoPtr_GetTrackLength_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackReader>.NativeClassPtr, 100666602);
			TrackReader.NativeMethodInfoPtr_ParseTrackData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackReader>.NativeClassPtr, 100666603);
			TrackReader.NativeMethodInfoPtr_ParseMessage_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackReader>.NativeClassPtr, 100666604);
			TrackReader.NativeMethodInfoPtr_ParseChannelMessage_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackReader>.NativeClassPtr, 100666605);
			TrackReader.NativeMethodInfoPtr_ParseMetaMessage_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackReader>.NativeClassPtr, 100666606);
			TrackReader.NativeMethodInfoPtr_ParseSysExMessageStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackReader>.NativeClassPtr, 100666607);
			TrackReader.NativeMethodInfoPtr_ParseSysExMessageContinue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackReader>.NativeClassPtr, 100666608);
			TrackReader.NativeMethodInfoPtr_ParseSysCommonMessage_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackReader>.NativeClassPtr, 100666609);
			TrackReader.NativeMethodInfoPtr_ParseSysRealtimeMessage_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackReader>.NativeClassPtr, 100666610);
			TrackReader.NativeMethodInfoPtr_ReadVariableLengthValue_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackReader>.NativeClassPtr, 100666611);
			TrackReader.NativeMethodInfoPtr_get_Track_Public_get_Track_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackReader>.NativeClassPtr, 100666612);
		}

		// Token: 0x06001723 RID: 5923 RVA: 0x00068A4C File Offset: 0x00066C4C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 18254, RefRangeEnd = 18257, XrefRangeStart = 18241, XrefRangeEnd = 18254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrackReader()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackReader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackReader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001724 RID: 5924 RVA: 0x00068A88 File Offset: 0x00066C88
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 18270, RefRangeEnd = 18273, XrefRangeStart = 18257, XrefRangeEnd = 18270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Read(Stream strm)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(strm);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackReader.NativeMethodInfoPtr_Read_Public_Void_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001725 RID: 5925 RVA: 0x00068ACC File Offset: 0x00066CCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18273, XrefRangeEnd = 18274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FindTrack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackReader.NativeMethodInfoPtr_FindTrack_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001726 RID: 5926 RVA: 0x00068B00 File Offset: 0x00066D00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 18296, RefRangeEnd = 18297, XrefRangeStart = 18274, XrefRangeEnd = 18296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTrackLength()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackReader.NativeMethodInfoPtr_GetTrackLength_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001727 RID: 5927 RVA: 0x00068B3C File Offset: 0x00066D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18297, XrefRangeEnd = 18301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseTrackData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackReader.NativeMethodInfoPtr_ParseTrackData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001728 RID: 5928 RVA: 0x00068B70 File Offset: 0x00066D70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 18330, RefRangeEnd = 18332, XrefRangeStart = 18301, XrefRangeEnd = 18330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseMessage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackReader.NativeMethodInfoPtr_ParseMessage_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001729 RID: 5929 RVA: 0x00068BA4 File Offset: 0x00066DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18332, XrefRangeEnd = 18337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseChannelMessage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackReader.NativeMethodInfoPtr_ParseChannelMessage_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600172A RID: 5930 RVA: 0x00068BD8 File Offset: 0x00066DD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18337, XrefRangeEnd = 18347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseMetaMessage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackReader.NativeMethodInfoPtr_ParseMetaMessage_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600172B RID: 5931 RVA: 0x00068C0C File Offset: 0x00066E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18347, XrefRangeEnd = 18357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseSysExMessageStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackReader.NativeMethodInfoPtr_ParseSysExMessageStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600172C RID: 5932 RVA: 0x00068C40 File Offset: 0x00066E40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18357, XrefRangeEnd = 18367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseSysExMessageContinue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackReader.NativeMethodInfoPtr_ParseSysExMessageContinue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600172D RID: 5933 RVA: 0x00068C74 File Offset: 0x00066E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18367, XrefRangeEnd = 18396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseSysCommonMessage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackReader.NativeMethodInfoPtr_ParseSysCommonMessage_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600172E RID: 5934 RVA: 0x00068CA8 File Offset: 0x00066EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18396, XrefRangeEnd = 18426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseSysRealtimeMessage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackReader.NativeMethodInfoPtr_ParseSysRealtimeMessage_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600172F RID: 5935 RVA: 0x00068CDC File Offset: 0x00066EDC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 18426, RefRangeEnd = 18431, XrefRangeStart = 18426, XrefRangeEnd = 18426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ReadVariableLengthValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackReader.NativeMethodInfoPtr_ReadVariableLengthValue_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06001730 RID: 5936 RVA: 0x00068D18 File Offset: 0x00066F18
		public unsafe Track Track
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackReader.NativeMethodInfoPtr_get_Track_Public_get_Track_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Track>(intPtr3) : null;
			}
		}

		// Token: 0x06001731 RID: 5937 RVA: 0x0000944A File Offset: 0x0000764A
		public TrackReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06001732 RID: 5938 RVA: 0x00068D58 File Offset: 0x00066F58
		// (set) Token: 0x06001733 RID: 5939 RVA: 0x00009453 File Offset: 0x00007653
		public unsafe Track track
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackReader.NativeFieldInfoPtr_track);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Track>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackReader.NativeFieldInfoPtr_track), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06001734 RID: 5940 RVA: 0x00068D88 File Offset: 0x00066F88
		// (set) Token: 0x06001735 RID: 5941 RVA: 0x00009472 File Offset: 0x00007672
		public unsafe Track newTrack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackReader.NativeFieldInfoPtr_newTrack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Track>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackReader.NativeFieldInfoPtr_newTrack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06001736 RID: 5942 RVA: 0x00068DB8 File Offset: 0x00066FB8
		// (set) Token: 0x06001737 RID: 5943 RVA: 0x00009491 File Offset: 0x00007691
		public unsafe ChannelMessageBuilder cmBuilder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackReader.NativeFieldInfoPtr_cmBuilder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChannelMessageBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackReader.NativeFieldInfoPtr_cmBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06001738 RID: 5944 RVA: 0x00068DE8 File Offset: 0x00066FE8
		// (set) Token: 0x06001739 RID: 5945 RVA: 0x000094B0 File Offset: 0x000076B0
		public unsafe SysCommonMessageBuilder scBuilder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackReader.NativeFieldInfoPtr_scBuilder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SysCommonMessageBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackReader.NativeFieldInfoPtr_scBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x0600173A RID: 5946 RVA: 0x00068E18 File Offset: 0x00067018
		// (set) Token: 0x0600173B RID: 5947 RVA: 0x000094CF File Offset: 0x000076CF
		public unsafe Stream stream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackReader.NativeFieldInfoPtr_stream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackReader.NativeFieldInfoPtr_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x0600173C RID: 5948 RVA: 0x00068E48 File Offset: 0x00067048
		// (set) Token: 0x0600173D RID: 5949 RVA: 0x000094EE File Offset: 0x000076EE
		public unsafe Il2CppStructArray<byte> trackData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackReader.NativeFieldInfoPtr_trackData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackReader.NativeFieldInfoPtr_trackData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x0600173E RID: 5950 RVA: 0x00068E78 File Offset: 0x00067078
		// (set) Token: 0x0600173F RID: 5951 RVA: 0x0000950D File Offset: 0x0000770D
		public unsafe int trackIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackReader.NativeFieldInfoPtr_trackIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackReader.NativeFieldInfoPtr_trackIndex)) = value;
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06001740 RID: 5952 RVA: 0x00068EA0 File Offset: 0x000670A0
		// (set) Token: 0x06001741 RID: 5953 RVA: 0x00009528 File Offset: 0x00007728
		public unsafe int previousTicks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackReader.NativeFieldInfoPtr_previousTicks);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackReader.NativeFieldInfoPtr_previousTicks)) = value;
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06001742 RID: 5954 RVA: 0x00068EC8 File Offset: 0x000670C8
		// (set) Token: 0x06001743 RID: 5955 RVA: 0x00009543 File Offset: 0x00007743
		public unsafe int ticks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackReader.NativeFieldInfoPtr_ticks);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackReader.NativeFieldInfoPtr_ticks)) = value;
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06001744 RID: 5956 RVA: 0x00068EF0 File Offset: 0x000670F0
		// (set) Token: 0x06001745 RID: 5957 RVA: 0x0000955E File Offset: 0x0000775E
		public unsafe int status
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackReader.NativeFieldInfoPtr_status);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackReader.NativeFieldInfoPtr_status)) = value;
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06001746 RID: 5958 RVA: 0x00068F18 File Offset: 0x00067118
		// (set) Token: 0x06001747 RID: 5959 RVA: 0x00009579 File Offset: 0x00007779
		public unsafe int runningStatus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackReader.NativeFieldInfoPtr_runningStatus);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackReader.NativeFieldInfoPtr_runningStatus)) = value;
			}
		}

		// Token: 0x040018A3 RID: 6307
		private static readonly IntPtr NativeFieldInfoPtr_track;

		// Token: 0x040018A4 RID: 6308
		private static readonly IntPtr NativeFieldInfoPtr_newTrack;

		// Token: 0x040018A5 RID: 6309
		private static readonly IntPtr NativeFieldInfoPtr_cmBuilder;

		// Token: 0x040018A6 RID: 6310
		private static readonly IntPtr NativeFieldInfoPtr_scBuilder;

		// Token: 0x040018A7 RID: 6311
		private static readonly IntPtr NativeFieldInfoPtr_stream;

		// Token: 0x040018A8 RID: 6312
		private static readonly IntPtr NativeFieldInfoPtr_trackData;

		// Token: 0x040018A9 RID: 6313
		private static readonly IntPtr NativeFieldInfoPtr_trackIndex;

		// Token: 0x040018AA RID: 6314
		private static readonly IntPtr NativeFieldInfoPtr_previousTicks;

		// Token: 0x040018AB RID: 6315
		private static readonly IntPtr NativeFieldInfoPtr_ticks;

		// Token: 0x040018AC RID: 6316
		private static readonly IntPtr NativeFieldInfoPtr_status;

		// Token: 0x040018AD RID: 6317
		private static readonly IntPtr NativeFieldInfoPtr_runningStatus;

		// Token: 0x040018AE RID: 6318
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040018AF RID: 6319
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Void_Stream_0;

		// Token: 0x040018B0 RID: 6320
		private static readonly IntPtr NativeMethodInfoPtr_FindTrack_Private_Void_0;

		// Token: 0x040018B1 RID: 6321
		private static readonly IntPtr NativeMethodInfoPtr_GetTrackLength_Private_Int32_0;

		// Token: 0x040018B2 RID: 6322
		private static readonly IntPtr NativeMethodInfoPtr_ParseTrackData_Private_Void_0;

		// Token: 0x040018B3 RID: 6323
		private static readonly IntPtr NativeMethodInfoPtr_ParseMessage_Private_Void_0;

		// Token: 0x040018B4 RID: 6324
		private static readonly IntPtr NativeMethodInfoPtr_ParseChannelMessage_Private_Void_0;

		// Token: 0x040018B5 RID: 6325
		private static readonly IntPtr NativeMethodInfoPtr_ParseMetaMessage_Private_Void_0;

		// Token: 0x040018B6 RID: 6326
		private static readonly IntPtr NativeMethodInfoPtr_ParseSysExMessageStart_Private_Void_0;

		// Token: 0x040018B7 RID: 6327
		private static readonly IntPtr NativeMethodInfoPtr_ParseSysExMessageContinue_Private_Void_0;

		// Token: 0x040018B8 RID: 6328
		private static readonly IntPtr NativeMethodInfoPtr_ParseSysCommonMessage_Private_Void_0;

		// Token: 0x040018B9 RID: 6329
		private static readonly IntPtr NativeMethodInfoPtr_ParseSysRealtimeMessage_Private_Void_0;

		// Token: 0x040018BA RID: 6330
		private static readonly IntPtr NativeMethodInfoPtr_ReadVariableLengthValue_Private_Int32_0;

		// Token: 0x040018BB RID: 6331
		private static readonly IntPtr NativeMethodInfoPtr_get_Track_Public_get_Track_0;
	}
}
