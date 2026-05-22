using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x020001B3 RID: 435
	public class SongPositionPointerBuilder : Object
	{
		// Token: 0x060014AF RID: 5295 RVA: 0x0005F53C File Offset: 0x0005D73C
		// Note: this type is marked as 'beforefieldinit'.
		static SongPositionPointerBuilder()
		{
			Il2CppClassPointerStore<SongPositionPointerBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "SongPositionPointerBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SongPositionPointerBuilder>.NativeClassPtr);
			SongPositionPointerBuilder.NativeFieldInfoPtr_TicksPer16thNote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SongPositionPointerBuilder>.NativeClassPtr, "TicksPer16thNote");
			SongPositionPointerBuilder.NativeFieldInfoPtr_Shift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SongPositionPointerBuilder>.NativeClassPtr, "Shift");
			SongPositionPointerBuilder.NativeFieldInfoPtr_Mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SongPositionPointerBuilder>.NativeClassPtr, "Mask");
			SongPositionPointerBuilder.NativeFieldInfoPtr_tickScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SongPositionPointerBuilder>.NativeClassPtr, "tickScale");
			SongPositionPointerBuilder.NativeFieldInfoPtr_ppqn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SongPositionPointerBuilder>.NativeClassPtr, "ppqn");
			SongPositionPointerBuilder.NativeFieldInfoPtr_builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SongPositionPointerBuilder>.NativeClassPtr, "builder");
			SongPositionPointerBuilder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SongPositionPointerBuilder>.NativeClassPtr, 100666234);
			SongPositionPointerBuilder.NativeMethodInfoPtr__ctor_Public_Void_SysCommonMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SongPositionPointerBuilder>.NativeClassPtr, 100666235);
			SongPositionPointerBuilder.NativeMethodInfoPtr_Initialize_Public_Void_SysCommonMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SongPositionPointerBuilder>.NativeClassPtr, 100666236);
			SongPositionPointerBuilder.NativeMethodInfoPtr_get_PositionInTicks_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SongPositionPointerBuilder>.NativeClassPtr, 100666237);
			SongPositionPointerBuilder.NativeMethodInfoPtr_set_PositionInTicks_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SongPositionPointerBuilder>.NativeClassPtr, 100666238);
			SongPositionPointerBuilder.NativeMethodInfoPtr_get_Ppqn_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SongPositionPointerBuilder>.NativeClassPtr, 100666239);
			SongPositionPointerBuilder.NativeMethodInfoPtr_set_Ppqn_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SongPositionPointerBuilder>.NativeClassPtr, 100666240);
			SongPositionPointerBuilder.NativeMethodInfoPtr_get_SongPosition_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SongPositionPointerBuilder>.NativeClassPtr, 100666241);
			SongPositionPointerBuilder.NativeMethodInfoPtr_set_SongPosition_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SongPositionPointerBuilder>.NativeClassPtr, 100666242);
			SongPositionPointerBuilder.NativeMethodInfoPtr_get_Result_Public_get_SysCommonMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SongPositionPointerBuilder>.NativeClassPtr, 100666243);
			SongPositionPointerBuilder.NativeMethodInfoPtr_Build_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SongPositionPointerBuilder>.NativeClassPtr, 100666244);
		}

		// Token: 0x060014B0 RID: 5296 RVA: 0x0005F6C0 File Offset: 0x0005D8C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16296, XrefRangeEnd = 16299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SongPositionPointerBuilder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SongPositionPointerBuilder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SongPositionPointerBuilder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014B1 RID: 5297 RVA: 0x0005F6FC File Offset: 0x0005D8FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16299, XrefRangeEnd = 16302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SongPositionPointerBuilder(SysCommonMessage message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SongPositionPointerBuilder>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SongPositionPointerBuilder.NativeMethodInfoPtr__ctor_Public_Void_SysCommonMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014B2 RID: 5298 RVA: 0x0005F748 File Offset: 0x0005D948
		[CallerCount(0)]
		public unsafe void Initialize(SysCommonMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SongPositionPointerBuilder.NativeMethodInfoPtr_Initialize_Public_Void_SysCommonMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x060014B3 RID: 5299 RVA: 0x0005F78C File Offset: 0x0005D98C
		// (set) Token: 0x060014B4 RID: 5300 RVA: 0x0005F7C8 File Offset: 0x0005D9C8
		public unsafe int PositionInTicks
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SongPositionPointerBuilder.NativeMethodInfoPtr_get_PositionInTicks_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16302, XrefRangeEnd = 16304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SongPositionPointerBuilder.NativeMethodInfoPtr_set_PositionInTicks_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x060014B5 RID: 5301 RVA: 0x0005F808 File Offset: 0x0005DA08
		// (set) Token: 0x060014B6 RID: 5302 RVA: 0x0005F844 File Offset: 0x0005DA44
		public unsafe int Ppqn
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SongPositionPointerBuilder.NativeMethodInfoPtr_get_Ppqn_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SongPositionPointerBuilder.NativeMethodInfoPtr_set_Ppqn_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x060014B7 RID: 5303 RVA: 0x0005F884 File Offset: 0x0005DA84
		// (set) Token: 0x060014B8 RID: 5304 RVA: 0x0005F8C0 File Offset: 0x0005DAC0
		public unsafe int SongPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SongPositionPointerBuilder.NativeMethodInfoPtr_get_SongPosition_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16304, XrefRangeEnd = 16306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SongPositionPointerBuilder.NativeMethodInfoPtr_set_SongPosition_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x060014B9 RID: 5305 RVA: 0x0005F900 File Offset: 0x0005DB00
		public unsafe SysCommonMessage Result
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SongPositionPointerBuilder.NativeMethodInfoPtr_get_Result_Public_get_SysCommonMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SysCommonMessage>(intPtr3) : null;
			}
		}

		// Token: 0x060014BA RID: 5306 RVA: 0x0005F940 File Offset: 0x0005DB40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16306, XrefRangeEnd = 16308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Build()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SongPositionPointerBuilder.NativeMethodInfoPtr_Build_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014BB RID: 5307 RVA: 0x0000871D File Offset: 0x0000691D
		public SongPositionPointerBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x060014BC RID: 5308 RVA: 0x0005F974 File Offset: 0x0005DB74
		// (set) Token: 0x060014BD RID: 5309 RVA: 0x00008726 File Offset: 0x00006926
		public unsafe static int TicksPer16thNote
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SongPositionPointerBuilder.NativeFieldInfoPtr_TicksPer16thNote, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SongPositionPointerBuilder.NativeFieldInfoPtr_TicksPer16thNote, (void*)(&value));
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x060014BE RID: 5310 RVA: 0x0005F990 File Offset: 0x0005DB90
		// (set) Token: 0x060014BF RID: 5311 RVA: 0x00008734 File Offset: 0x00006934
		public unsafe static int Shift
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SongPositionPointerBuilder.NativeFieldInfoPtr_Shift, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SongPositionPointerBuilder.NativeFieldInfoPtr_Shift, (void*)(&value));
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x060014C0 RID: 5312 RVA: 0x0005F9AC File Offset: 0x0005DBAC
		// (set) Token: 0x060014C1 RID: 5313 RVA: 0x00008742 File Offset: 0x00006942
		public unsafe static int Mask
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SongPositionPointerBuilder.NativeFieldInfoPtr_Mask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SongPositionPointerBuilder.NativeFieldInfoPtr_Mask, (void*)(&value));
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x060014C2 RID: 5314 RVA: 0x0005F9C8 File Offset: 0x0005DBC8
		// (set) Token: 0x060014C3 RID: 5315 RVA: 0x00008750 File Offset: 0x00006950
		public unsafe int tickScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SongPositionPointerBuilder.NativeFieldInfoPtr_tickScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SongPositionPointerBuilder.NativeFieldInfoPtr_tickScale)) = value;
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x060014C4 RID: 5316 RVA: 0x0005F9F0 File Offset: 0x0005DBF0
		// (set) Token: 0x060014C5 RID: 5317 RVA: 0x0000876B File Offset: 0x0000696B
		public unsafe int ppqn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SongPositionPointerBuilder.NativeFieldInfoPtr_ppqn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SongPositionPointerBuilder.NativeFieldInfoPtr_ppqn)) = value;
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x060014C6 RID: 5318 RVA: 0x0005FA18 File Offset: 0x0005DC18
		// (set) Token: 0x060014C7 RID: 5319 RVA: 0x00008786 File Offset: 0x00006986
		public unsafe SysCommonMessageBuilder builder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SongPositionPointerBuilder.NativeFieldInfoPtr_builder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SysCommonMessageBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SongPositionPointerBuilder.NativeFieldInfoPtr_builder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040016B5 RID: 5813
		private static readonly IntPtr NativeFieldInfoPtr_TicksPer16thNote;

		// Token: 0x040016B6 RID: 5814
		private static readonly IntPtr NativeFieldInfoPtr_Shift;

		// Token: 0x040016B7 RID: 5815
		private static readonly IntPtr NativeFieldInfoPtr_Mask;

		// Token: 0x040016B8 RID: 5816
		private static readonly IntPtr NativeFieldInfoPtr_tickScale;

		// Token: 0x040016B9 RID: 5817
		private static readonly IntPtr NativeFieldInfoPtr_ppqn;

		// Token: 0x040016BA RID: 5818
		private static readonly IntPtr NativeFieldInfoPtr_builder;

		// Token: 0x040016BB RID: 5819
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040016BC RID: 5820
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SysCommonMessage_0;

		// Token: 0x040016BD RID: 5821
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_SysCommonMessage_0;

		// Token: 0x040016BE RID: 5822
		private static readonly IntPtr NativeMethodInfoPtr_get_PositionInTicks_Public_get_Int32_0;

		// Token: 0x040016BF RID: 5823
		private static readonly IntPtr NativeMethodInfoPtr_set_PositionInTicks_Public_set_Void_Int32_0;

		// Token: 0x040016C0 RID: 5824
		private static readonly IntPtr NativeMethodInfoPtr_get_Ppqn_Public_get_Int32_0;

		// Token: 0x040016C1 RID: 5825
		private static readonly IntPtr NativeMethodInfoPtr_set_Ppqn_Public_set_Void_Int32_0;

		// Token: 0x040016C2 RID: 5826
		private static readonly IntPtr NativeMethodInfoPtr_get_SongPosition_Public_get_Int32_0;

		// Token: 0x040016C3 RID: 5827
		private static readonly IntPtr NativeMethodInfoPtr_set_SongPosition_Public_set_Void_Int32_0;

		// Token: 0x040016C4 RID: 5828
		private static readonly IntPtr NativeMethodInfoPtr_get_Result_Public_get_SysCommonMessage_0;

		// Token: 0x040016C5 RID: 5829
		private static readonly IntPtr NativeMethodInfoPtr_Build_Public_Virtual_Final_New_Void_0;
	}
}
