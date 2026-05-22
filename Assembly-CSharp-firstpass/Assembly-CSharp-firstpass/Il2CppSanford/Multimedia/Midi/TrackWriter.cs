using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x020001D5 RID: 469
	public class TrackWriter : Object
	{
		// Token: 0x06001748 RID: 5960 RVA: 0x00068F40 File Offset: 0x00067140
		// Note: this type is marked as 'beforefieldinit'.
		static TrackWriter()
		{
			Il2CppClassPointerStore<TrackWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "TrackWriter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackWriter>.NativeClassPtr);
			TrackWriter.NativeFieldInfoPtr_TrackHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackWriter>.NativeClassPtr, "TrackHeader");
			TrackWriter.NativeFieldInfoPtr_track = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackWriter>.NativeClassPtr, "track");
			TrackWriter.NativeFieldInfoPtr_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackWriter>.NativeClassPtr, "stream");
			TrackWriter.NativeFieldInfoPtr_runningStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackWriter>.NativeClassPtr, "runningStatus");
			TrackWriter.NativeFieldInfoPtr_trackData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackWriter>.NativeClassPtr, "trackData");
			TrackWriter.NativeMethodInfoPtr_Write_Public_Void_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackWriter>.NativeClassPtr, 100666613);
			TrackWriter.NativeMethodInfoPtr_WriteVariableLengthValue_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackWriter>.NativeClassPtr, 100666614);
			TrackWriter.NativeMethodInfoPtr_Write_Private_Void_ShortMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackWriter>.NativeClassPtr, 100666615);
			TrackWriter.NativeMethodInfoPtr_Write_Private_Void_ChannelMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackWriter>.NativeClassPtr, 100666616);
			TrackWriter.NativeMethodInfoPtr_Write_Private_Void_SysExMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackWriter>.NativeClassPtr, 100666617);
			TrackWriter.NativeMethodInfoPtr_Write_Private_Void_MetaMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackWriter>.NativeClassPtr, 100666618);
			TrackWriter.NativeMethodInfoPtr_Write_Private_Void_SysCommonMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackWriter>.NativeClassPtr, 100666619);
			TrackWriter.NativeMethodInfoPtr_Write_Private_Void_SysRealtimeMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackWriter>.NativeClassPtr, 100666620);
			TrackWriter.NativeMethodInfoPtr_get_Track_Public_get_Track_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackWriter>.NativeClassPtr, 100666621);
			TrackWriter.NativeMethodInfoPtr_set_Track_Public_set_Void_Track_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackWriter>.NativeClassPtr, 100666622);
			TrackWriter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackWriter>.NativeClassPtr, 100666623);
		}

		// Token: 0x06001749 RID: 5961 RVA: 0x000690B0 File Offset: 0x000672B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 18501, RefRangeEnd = 18503, XrefRangeStart = 18431, XrefRangeEnd = 18501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(Stream strm)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(strm);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackWriter.NativeMethodInfoPtr_Write_Public_Void_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600174A RID: 5962 RVA: 0x000690F4 File Offset: 0x000672F4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 18508, RefRangeEnd = 18511, XrefRangeStart = 18503, XrefRangeEnd = 18508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteVariableLengthValue(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackWriter.NativeMethodInfoPtr_WriteVariableLengthValue_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600174B RID: 5963 RVA: 0x00069134 File Offset: 0x00067334
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 18515, RefRangeEnd = 18516, XrefRangeStart = 18511, XrefRangeEnd = 18515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(ShortMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackWriter.NativeMethodInfoPtr_Write_Private_Void_ShortMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600174C RID: 5964 RVA: 0x00069178 File Offset: 0x00067378
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 18520, RefRangeEnd = 18521, XrefRangeStart = 18516, XrefRangeEnd = 18520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(ChannelMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackWriter.NativeMethodInfoPtr_Write_Private_Void_ChannelMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600174D RID: 5965 RVA: 0x000691BC File Offset: 0x000673BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 18527, RefRangeEnd = 18528, XrefRangeStart = 18521, XrefRangeEnd = 18527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(SysExMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackWriter.NativeMethodInfoPtr_Write_Private_Void_SysExMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600174E RID: 5966 RVA: 0x00069200 File Offset: 0x00067400
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 18536, RefRangeEnd = 18537, XrefRangeStart = 18528, XrefRangeEnd = 18536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(MetaMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackWriter.NativeMethodInfoPtr_Write_Private_Void_MetaMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600174F RID: 5967 RVA: 0x00069244 File Offset: 0x00067444
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 18541, RefRangeEnd = 18542, XrefRangeStart = 18537, XrefRangeEnd = 18541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(SysCommonMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackWriter.NativeMethodInfoPtr_Write_Private_Void_SysCommonMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001750 RID: 5968 RVA: 0x00069288 File Offset: 0x00067488
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 18546, RefRangeEnd = 18547, XrefRangeStart = 18542, XrefRangeEnd = 18546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(SysRealtimeMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackWriter.NativeMethodInfoPtr_Write_Private_Void_SysRealtimeMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06001751 RID: 5969 RVA: 0x000692CC File Offset: 0x000674CC
		// (set) Token: 0x06001752 RID: 5970 RVA: 0x0006930C File Offset: 0x0006750C
		public unsafe Track Track
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackWriter.NativeMethodInfoPtr_get_Track_Public_get_Track_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Track>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 18549, RefRangeEnd = 18551, XrefRangeStart = 18547, XrefRangeEnd = 18549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackWriter.NativeMethodInfoPtr_set_Track_Public_set_Void_Track_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001753 RID: 5971 RVA: 0x00069350 File Offset: 0x00067550
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 18560, RefRangeEnd = 18562, XrefRangeStart = 18551, XrefRangeEnd = 18560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrackWriter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackWriter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackWriter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001754 RID: 5972 RVA: 0x00009594 File Offset: 0x00007794
		public TrackWriter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06001755 RID: 5973 RVA: 0x0006938C File Offset: 0x0006758C
		// (set) Token: 0x06001756 RID: 5974 RVA: 0x0000959D File Offset: 0x0000779D
		public unsafe static Il2CppStructArray<byte> TrackHeader
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TrackWriter.NativeFieldInfoPtr_TrackHeader, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrackWriter.NativeFieldInfoPtr_TrackHeader, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06001757 RID: 5975 RVA: 0x000693B4 File Offset: 0x000675B4
		// (set) Token: 0x06001758 RID: 5976 RVA: 0x000095AF File Offset: 0x000077AF
		public unsafe Track track
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackWriter.NativeFieldInfoPtr_track);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Track>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackWriter.NativeFieldInfoPtr_track), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06001759 RID: 5977 RVA: 0x000693E4 File Offset: 0x000675E4
		// (set) Token: 0x0600175A RID: 5978 RVA: 0x000095CE File Offset: 0x000077CE
		public unsafe Stream stream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackWriter.NativeFieldInfoPtr_stream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackWriter.NativeFieldInfoPtr_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x0600175B RID: 5979 RVA: 0x00069414 File Offset: 0x00067614
		// (set) Token: 0x0600175C RID: 5980 RVA: 0x000095ED File Offset: 0x000077ED
		public unsafe int runningStatus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackWriter.NativeFieldInfoPtr_runningStatus);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackWriter.NativeFieldInfoPtr_runningStatus)) = value;
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x0600175D RID: 5981 RVA: 0x0006943C File Offset: 0x0006763C
		// (set) Token: 0x0600175E RID: 5982 RVA: 0x00009608 File Offset: 0x00007808
		public unsafe List<byte> trackData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackWriter.NativeFieldInfoPtr_trackData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackWriter.NativeFieldInfoPtr_trackData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040018BC RID: 6332
		private static readonly IntPtr NativeFieldInfoPtr_TrackHeader;

		// Token: 0x040018BD RID: 6333
		private static readonly IntPtr NativeFieldInfoPtr_track;

		// Token: 0x040018BE RID: 6334
		private static readonly IntPtr NativeFieldInfoPtr_stream;

		// Token: 0x040018BF RID: 6335
		private static readonly IntPtr NativeFieldInfoPtr_runningStatus;

		// Token: 0x040018C0 RID: 6336
		private static readonly IntPtr NativeFieldInfoPtr_trackData;

		// Token: 0x040018C1 RID: 6337
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_Stream_0;

		// Token: 0x040018C2 RID: 6338
		private static readonly IntPtr NativeMethodInfoPtr_WriteVariableLengthValue_Private_Void_Int32_0;

		// Token: 0x040018C3 RID: 6339
		private static readonly IntPtr NativeMethodInfoPtr_Write_Private_Void_ShortMessage_0;

		// Token: 0x040018C4 RID: 6340
		private static readonly IntPtr NativeMethodInfoPtr_Write_Private_Void_ChannelMessage_0;

		// Token: 0x040018C5 RID: 6341
		private static readonly IntPtr NativeMethodInfoPtr_Write_Private_Void_SysExMessage_0;

		// Token: 0x040018C6 RID: 6342
		private static readonly IntPtr NativeMethodInfoPtr_Write_Private_Void_MetaMessage_0;

		// Token: 0x040018C7 RID: 6343
		private static readonly IntPtr NativeMethodInfoPtr_Write_Private_Void_SysCommonMessage_0;

		// Token: 0x040018C8 RID: 6344
		private static readonly IntPtr NativeMethodInfoPtr_Write_Private_Void_SysRealtimeMessage_0;

		// Token: 0x040018C9 RID: 6345
		private static readonly IntPtr NativeMethodInfoPtr_get_Track_Public_get_Track_0;

		// Token: 0x040018CA RID: 6346
		private static readonly IntPtr NativeMethodInfoPtr_set_Track_Public_set_Void_Track_0;

		// Token: 0x040018CB RID: 6347
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
