using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.HID
{
	// Token: 0x02000121 RID: 289
	public class HIDLight : Object
	{
		// Token: 0x06001DA1 RID: 7585 RVA: 0x0009D098 File Offset: 0x0009B298
		// Note: this type is marked as 'beforefieldinit'.
		static HIDLight()
		{
			Il2CppClassPointerStore<HIDLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.HID", "HIDLight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HIDLight>.NativeClassPtr);
			HIDLight.NativeFieldInfoPtr_KnDGiVPPbwzazdSHhKOfyJYHZC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDLight>.NativeClassPtr, "KnDGiVPPbwzazdSHhKOfyJYHZC");
			HIDLight.NativeFieldInfoPtr_wbumxyjWSuaKSpNoEtCcxNnsbZMB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDLight>.NativeClassPtr, "wbumxyjWSuaKSpNoEtCcxNnsbZMB");
			HIDLight.NativeFieldInfoPtr_HRwftSnxCXcHVEpnKxvKSfuCBIc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDLight>.NativeClassPtr, "HRwftSnxCXcHVEpnKxvKSfuCBIc");
			HIDLight.NativeFieldInfoPtr_aXfPutNdDZalxEUghgtFUonzmkcd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDLight>.NativeClassPtr, "aXfPutNdDZalxEUghgtFUonzmkcd");
			HIDLight.NativeMethodInfoPtr_get_ColorR_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDLight>.NativeClassPtr, 100669794);
			HIDLight.NativeMethodInfoPtr_set_ColorR_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDLight>.NativeClassPtr, 100669795);
			HIDLight.NativeMethodInfoPtr_get_ColorG_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDLight>.NativeClassPtr, 100669796);
			HIDLight.NativeMethodInfoPtr_set_ColorG_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDLight>.NativeClassPtr, 100669797);
			HIDLight.NativeMethodInfoPtr_get_ColorB_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDLight>.NativeClassPtr, 100669798);
			HIDLight.NativeMethodInfoPtr_set_ColorB_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDLight>.NativeClassPtr, 100669799);
			HIDLight.NativeMethodInfoPtr_get_ColorRRaw_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDLight>.NativeClassPtr, 100669800);
			HIDLight.NativeMethodInfoPtr_set_ColorRRaw_Public_set_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDLight>.NativeClassPtr, 100669801);
			HIDLight.NativeMethodInfoPtr_get_ColorGRaw_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDLight>.NativeClassPtr, 100669802);
			HIDLight.NativeMethodInfoPtr_set_ColorGRaw_Public_set_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDLight>.NativeClassPtr, 100669803);
			HIDLight.NativeMethodInfoPtr_get_ColorBRaw_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDLight>.NativeClassPtr, 100669804);
			HIDLight.NativeMethodInfoPtr_set_ColorBRaw_Public_set_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDLight>.NativeClassPtr, 100669805);
			HIDLight.NativeMethodInfoPtr_add_ValueChangedEvent_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDLight>.NativeClassPtr, 100669806);
			HIDLight.NativeMethodInfoPtr_remove_ValueChangedEvent_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDLight>.NativeClassPtr, 100669807);
			HIDLight.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDLight>.NativeClassPtr, 100669808);
			HIDLight.NativeMethodInfoPtr__ctor_Public_Void_Byte_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDLight>.NativeClassPtr, 100669809);
		}

		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x06001DA2 RID: 7586 RVA: 0x0009D258 File Offset: 0x0009B458
		// (set) Token: 0x06001DA3 RID: 7587 RVA: 0x0009D294 File Offset: 0x0009B494
		public unsafe float ColorR
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDLight.NativeMethodInfoPtr_get_ColorR_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280713, XrefRangeEnd = 280715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDLight.NativeMethodInfoPtr_set_ColorR_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x06001DA4 RID: 7588 RVA: 0x0009D2D4 File Offset: 0x0009B4D4
		// (set) Token: 0x06001DA5 RID: 7589 RVA: 0x0009D310 File Offset: 0x0009B510
		public unsafe float ColorG
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDLight.NativeMethodInfoPtr_get_ColorG_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280715, XrefRangeEnd = 280717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDLight.NativeMethodInfoPtr_set_ColorG_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x06001DA6 RID: 7590 RVA: 0x0009D350 File Offset: 0x0009B550
		// (set) Token: 0x06001DA7 RID: 7591 RVA: 0x0009D38C File Offset: 0x0009B58C
		public unsafe float ColorB
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDLight.NativeMethodInfoPtr_get_ColorB_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280717, XrefRangeEnd = 280719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDLight.NativeMethodInfoPtr_set_ColorB_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x06001DA8 RID: 7592 RVA: 0x0009D3CC File Offset: 0x0009B5CC
		// (set) Token: 0x06001DA9 RID: 7593 RVA: 0x0009D408 File Offset: 0x0009B608
		public unsafe byte ColorRRaw
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDLight.NativeMethodInfoPtr_get_ColorRRaw_Public_get_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280719, XrefRangeEnd = 280720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDLight.NativeMethodInfoPtr_set_ColorRRaw_Public_set_Void_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x06001DAA RID: 7594 RVA: 0x0009D448 File Offset: 0x0009B648
		// (set) Token: 0x06001DAB RID: 7595 RVA: 0x0009D484 File Offset: 0x0009B684
		public unsafe byte ColorGRaw
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDLight.NativeMethodInfoPtr_get_ColorGRaw_Public_get_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280720, XrefRangeEnd = 280721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDLight.NativeMethodInfoPtr_set_ColorGRaw_Public_set_Void_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x06001DAC RID: 7596 RVA: 0x0009D4C4 File Offset: 0x0009B6C4
		// (set) Token: 0x06001DAD RID: 7597 RVA: 0x0009D500 File Offset: 0x0009B700
		public unsafe byte ColorBRaw
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDLight.NativeMethodInfoPtr_get_ColorBRaw_Public_get_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280721, XrefRangeEnd = 280722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDLight.NativeMethodInfoPtr_set_ColorBRaw_Public_set_Void_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001DAE RID: 7598 RVA: 0x0009D540 File Offset: 0x0009B740
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 280725, RefRangeEnd = 280727, XrefRangeStart = 280722, XrefRangeEnd = 280725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_ValueChangedEvent(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDLight.NativeMethodInfoPtr_add_ValueChangedEvent_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DAF RID: 7599 RVA: 0x0009D584 File Offset: 0x0009B784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280727, XrefRangeEnd = 280730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_ValueChangedEvent(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDLight.NativeMethodInfoPtr_remove_ValueChangedEvent_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DB0 RID: 7600 RVA: 0x0009D5C8 File Offset: 0x0009B7C8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HIDLight()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HIDLight>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDLight.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DB1 RID: 7601 RVA: 0x0009D604 File Offset: 0x0009B804
		[CallerCount(0)]
		public unsafe HIDLight(byte colorRRaw, byte colorGRaw, byte colorBRaw)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HIDLight>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref colorRRaw;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorGRaw;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorBRaw;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDLight.NativeMethodInfoPtr__ctor_Public_Void_Byte_Byte_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DB2 RID: 7602 RVA: 0x0000C415 File Offset: 0x0000A615
		public HIDLight(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x06001DB3 RID: 7603 RVA: 0x0009D668 File Offset: 0x0009B868
		// (set) Token: 0x06001DB4 RID: 7604 RVA: 0x0000C41E File Offset: 0x0000A61E
		public unsafe byte KnDGiVPPbwzazdSHhKOfyJYHZC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDLight.NativeFieldInfoPtr_KnDGiVPPbwzazdSHhKOfyJYHZC);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDLight.NativeFieldInfoPtr_KnDGiVPPbwzazdSHhKOfyJYHZC)) = value;
			}
		}

		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x06001DB5 RID: 7605 RVA: 0x0009D690 File Offset: 0x0009B890
		// (set) Token: 0x06001DB6 RID: 7606 RVA: 0x0000C439 File Offset: 0x0000A639
		public unsafe byte wbumxyjWSuaKSpNoEtCcxNnsbZMB
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDLight.NativeFieldInfoPtr_wbumxyjWSuaKSpNoEtCcxNnsbZMB);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDLight.NativeFieldInfoPtr_wbumxyjWSuaKSpNoEtCcxNnsbZMB)) = value;
			}
		}

		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x06001DB7 RID: 7607 RVA: 0x0009D6B8 File Offset: 0x0009B8B8
		// (set) Token: 0x06001DB8 RID: 7608 RVA: 0x0000C454 File Offset: 0x0000A654
		public unsafe byte HRwftSnxCXcHVEpnKxvKSfuCBIc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDLight.NativeFieldInfoPtr_HRwftSnxCXcHVEpnKxvKSfuCBIc);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDLight.NativeFieldInfoPtr_HRwftSnxCXcHVEpnKxvKSfuCBIc)) = value;
			}
		}

		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x06001DB9 RID: 7609 RVA: 0x0009D6E0 File Offset: 0x0009B8E0
		// (set) Token: 0x06001DBA RID: 7610 RVA: 0x0000C46F File Offset: 0x0000A66F
		public unsafe Action aXfPutNdDZalxEUghgtFUonzmkcd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDLight.NativeFieldInfoPtr_aXfPutNdDZalxEUghgtFUonzmkcd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDLight.NativeFieldInfoPtr_aXfPutNdDZalxEUghgtFUonzmkcd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040018C0 RID: 6336
		private static readonly IntPtr NativeFieldInfoPtr_KnDGiVPPbwzazdSHhKOfyJYHZC;

		// Token: 0x040018C1 RID: 6337
		private static readonly IntPtr NativeFieldInfoPtr_wbumxyjWSuaKSpNoEtCcxNnsbZMB;

		// Token: 0x040018C2 RID: 6338
		private static readonly IntPtr NativeFieldInfoPtr_HRwftSnxCXcHVEpnKxvKSfuCBIc;

		// Token: 0x040018C3 RID: 6339
		private static readonly IntPtr NativeFieldInfoPtr_aXfPutNdDZalxEUghgtFUonzmkcd;

		// Token: 0x040018C4 RID: 6340
		private static readonly IntPtr NativeMethodInfoPtr_get_ColorR_Public_get_Single_0;

		// Token: 0x040018C5 RID: 6341
		private static readonly IntPtr NativeMethodInfoPtr_set_ColorR_Public_set_Void_Single_0;

		// Token: 0x040018C6 RID: 6342
		private static readonly IntPtr NativeMethodInfoPtr_get_ColorG_Public_get_Single_0;

		// Token: 0x040018C7 RID: 6343
		private static readonly IntPtr NativeMethodInfoPtr_set_ColorG_Public_set_Void_Single_0;

		// Token: 0x040018C8 RID: 6344
		private static readonly IntPtr NativeMethodInfoPtr_get_ColorB_Public_get_Single_0;

		// Token: 0x040018C9 RID: 6345
		private static readonly IntPtr NativeMethodInfoPtr_set_ColorB_Public_set_Void_Single_0;

		// Token: 0x040018CA RID: 6346
		private static readonly IntPtr NativeMethodInfoPtr_get_ColorRRaw_Public_get_Byte_0;

		// Token: 0x040018CB RID: 6347
		private static readonly IntPtr NativeMethodInfoPtr_set_ColorRRaw_Public_set_Void_Byte_0;

		// Token: 0x040018CC RID: 6348
		private static readonly IntPtr NativeMethodInfoPtr_get_ColorGRaw_Public_get_Byte_0;

		// Token: 0x040018CD RID: 6349
		private static readonly IntPtr NativeMethodInfoPtr_set_ColorGRaw_Public_set_Void_Byte_0;

		// Token: 0x040018CE RID: 6350
		private static readonly IntPtr NativeMethodInfoPtr_get_ColorBRaw_Public_get_Byte_0;

		// Token: 0x040018CF RID: 6351
		private static readonly IntPtr NativeMethodInfoPtr_set_ColorBRaw_Public_set_Void_Byte_0;

		// Token: 0x040018D0 RID: 6352
		private static readonly IntPtr NativeMethodInfoPtr_add_ValueChangedEvent_Public_add_Void_Action_0;

		// Token: 0x040018D1 RID: 6353
		private static readonly IntPtr NativeMethodInfoPtr_remove_ValueChangedEvent_Public_rem_Void_Action_0;

		// Token: 0x040018D2 RID: 6354
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040018D3 RID: 6355
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_Byte_Byte_0;
	}
}
