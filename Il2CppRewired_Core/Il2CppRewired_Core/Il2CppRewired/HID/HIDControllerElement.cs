using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Utils.Classes.Data;
using Il2CppSystem;

namespace Il2CppRewired.HID
{
	// Token: 0x02000110 RID: 272
	public class HIDControllerElement : Object
	{
		// Token: 0x06001A33 RID: 6707 RVA: 0x00092FB4 File Offset: 0x000911B4
		// Note: this type is marked as 'beforefieldinit'.
		static HIDControllerElement()
		{
			Il2CppClassPointerStore<HIDControllerElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.HID", "HIDControllerElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HIDControllerElement>.NativeClassPtr);
			HIDControllerElement.NativeFieldInfoPtr_reportId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDControllerElement>.NativeClassPtr, "reportId");
			HIDControllerElement.NativeFieldInfoPtr_hidInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDControllerElement>.NativeClassPtr, "hidInfo");
			HIDControllerElement.NativeMethodInfoPtr__ctor_Public_Void_Byte_HIDInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDControllerElement>.NativeClassPtr, 100669488);
			HIDControllerElement.NativeMethodInfoPtr_UpdateValue_Public_Abstract_Virtual_New_Void_NativeBuffer_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDControllerElement>.NativeClassPtr, 100669489);
		}

		// Token: 0x06001A34 RID: 6708 RVA: 0x00093034 File Offset: 0x00091234
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 126351, RefRangeEnd = 126356, XrefRangeStart = 126351, XrefRangeEnd = 126356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HIDControllerElement(byte reportId, HIDControllerElement.HIDInfo hidInfo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HIDControllerElement>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref reportId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hidInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDControllerElement.NativeMethodInfoPtr__ctor_Public_Void_Byte_HIDInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A35 RID: 6709 RVA: 0x00093090 File Offset: 0x00091290
		[CallerCount(0)]
		public unsafe virtual void UpdateValue(NativeBuffer inputReport, double timestamp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputReport);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timestamp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HIDControllerElement.NativeMethodInfoPtr_UpdateValue_Public_Abstract_Virtual_New_Void_NativeBuffer_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A36 RID: 6710 RVA: 0x0000AB68 File Offset: 0x00008D68
		public HIDControllerElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x06001A37 RID: 6711 RVA: 0x000930EC File Offset: 0x000912EC
		// (set) Token: 0x06001A38 RID: 6712 RVA: 0x0000AB71 File Offset: 0x00008D71
		public unsafe byte reportId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDControllerElement.NativeFieldInfoPtr_reportId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDControllerElement.NativeFieldInfoPtr_reportId)) = value;
			}
		}

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x06001A39 RID: 6713 RVA: 0x00093114 File Offset: 0x00091314
		// (set) Token: 0x06001A3A RID: 6714 RVA: 0x0000AB8C File Offset: 0x00008D8C
		public unsafe HIDControllerElement.HIDInfo hidInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDControllerElement.NativeFieldInfoPtr_hidInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HIDControllerElement.HIDInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDControllerElement.NativeFieldInfoPtr_hidInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001688 RID: 5768
		private static readonly IntPtr NativeFieldInfoPtr_reportId;

		// Token: 0x04001689 RID: 5769
		private static readonly IntPtr NativeFieldInfoPtr_hidInfo;

		// Token: 0x0400168A RID: 5770
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_HIDInfo_0;

		// Token: 0x0400168B RID: 5771
		private static readonly IntPtr NativeMethodInfoPtr_UpdateValue_Public_Abstract_Virtual_New_Void_NativeBuffer_Double_0;

		// Token: 0x02000326 RID: 806
		public class HIDInfo : Object
		{
			// Token: 0x06004517 RID: 17687 RVA: 0x00142E2C File Offset: 0x0014102C
			// Note: this type is marked as 'beforefieldinit'.
			static HIDInfo()
			{
				Il2CppClassPointerStore<HIDControllerElement.HIDInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HIDControllerElement>.NativeClassPtr, "HIDInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HIDControllerElement.HIDInfo>.NativeClassPtr);
				HIDControllerElement.HIDInfo.NativeFieldInfoPtr_usagePage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDControllerElement.HIDInfo>.NativeClassPtr, "usagePage");
				HIDControllerElement.HIDInfo.NativeFieldInfoPtr_usage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDControllerElement.HIDInfo>.NativeClassPtr, "usage");
				HIDControllerElement.HIDInfo.NativeFieldInfoPtr_dataIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDControllerElement.HIDInfo>.NativeClassPtr, "dataIndex");
				HIDControllerElement.HIDInfo.NativeFieldInfoPtr_bitSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDControllerElement.HIDInfo>.NativeClassPtr, "bitSize");
				HIDControllerElement.HIDInfo.NativeFieldInfoPtr_logicalMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDControllerElement.HIDInfo>.NativeClassPtr, "logicalMin");
				HIDControllerElement.HIDInfo.NativeFieldInfoPtr_logicalMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDControllerElement.HIDInfo>.NativeClassPtr, "logicalMax");
				HIDControllerElement.HIDInfo.NativeFieldInfoPtr_physicalMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDControllerElement.HIDInfo>.NativeClassPtr, "physicalMin");
				HIDControllerElement.HIDInfo.NativeFieldInfoPtr_physicalMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDControllerElement.HIDInfo>.NativeClassPtr, "physicalMax");
				HIDControllerElement.HIDInfo.NativeFieldInfoPtr_units = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDControllerElement.HIDInfo>.NativeClassPtr, "units");
				HIDControllerElement.HIDInfo.NativeFieldInfoPtr_unitsExp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDControllerElement.HIDInfo>.NativeClassPtr, "unitsExp");
				HIDControllerElement.HIDInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDControllerElement.HIDInfo>.NativeClassPtr, 100669490);
			}

			// Token: 0x06004518 RID: 17688 RVA: 0x00142F34 File Offset: 0x00141134
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HIDInfo()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HIDControllerElement.HIDInfo>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDControllerElement.HIDInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004519 RID: 17689 RVA: 0x00018C98 File Offset: 0x00016E98
			public HIDInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001591 RID: 5521
			// (get) Token: 0x0600451A RID: 17690 RVA: 0x00142F70 File Offset: 0x00141170
			// (set) Token: 0x0600451B RID: 17691 RVA: 0x00018CA1 File Offset: 0x00016EA1
			public unsafe ushort usagePage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDControllerElement.HIDInfo.NativeFieldInfoPtr_usagePage);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDControllerElement.HIDInfo.NativeFieldInfoPtr_usagePage)) = value;
				}
			}

			// Token: 0x17001592 RID: 5522
			// (get) Token: 0x0600451C RID: 17692 RVA: 0x00142F98 File Offset: 0x00141198
			// (set) Token: 0x0600451D RID: 17693 RVA: 0x00018CBC File Offset: 0x00016EBC
			public unsafe ushort usage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDControllerElement.HIDInfo.NativeFieldInfoPtr_usage);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDControllerElement.HIDInfo.NativeFieldInfoPtr_usage)) = value;
				}
			}

			// Token: 0x17001593 RID: 5523
			// (get) Token: 0x0600451E RID: 17694 RVA: 0x00142FC0 File Offset: 0x001411C0
			// (set) Token: 0x0600451F RID: 17695 RVA: 0x00018CD7 File Offset: 0x00016ED7
			public unsafe int dataIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDControllerElement.HIDInfo.NativeFieldInfoPtr_dataIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDControllerElement.HIDInfo.NativeFieldInfoPtr_dataIndex)) = value;
				}
			}

			// Token: 0x17001594 RID: 5524
			// (get) Token: 0x06004520 RID: 17696 RVA: 0x00142FE8 File Offset: 0x001411E8
			// (set) Token: 0x06004521 RID: 17697 RVA: 0x00018CF2 File Offset: 0x00016EF2
			public unsafe int bitSize
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDControllerElement.HIDInfo.NativeFieldInfoPtr_bitSize);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDControllerElement.HIDInfo.NativeFieldInfoPtr_bitSize)) = value;
				}
			}

			// Token: 0x17001595 RID: 5525
			// (get) Token: 0x06004522 RID: 17698 RVA: 0x00143010 File Offset: 0x00141210
			// (set) Token: 0x06004523 RID: 17699 RVA: 0x00018D0D File Offset: 0x00016F0D
			public unsafe int logicalMin
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDControllerElement.HIDInfo.NativeFieldInfoPtr_logicalMin);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDControllerElement.HIDInfo.NativeFieldInfoPtr_logicalMin)) = value;
				}
			}

			// Token: 0x17001596 RID: 5526
			// (get) Token: 0x06004524 RID: 17700 RVA: 0x00143038 File Offset: 0x00141238
			// (set) Token: 0x06004525 RID: 17701 RVA: 0x00018D28 File Offset: 0x00016F28
			public unsafe int logicalMax
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDControllerElement.HIDInfo.NativeFieldInfoPtr_logicalMax);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDControllerElement.HIDInfo.NativeFieldInfoPtr_logicalMax)) = value;
				}
			}

			// Token: 0x17001597 RID: 5527
			// (get) Token: 0x06004526 RID: 17702 RVA: 0x00143060 File Offset: 0x00141260
			// (set) Token: 0x06004527 RID: 17703 RVA: 0x00018D43 File Offset: 0x00016F43
			public unsafe int physicalMin
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDControllerElement.HIDInfo.NativeFieldInfoPtr_physicalMin);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDControllerElement.HIDInfo.NativeFieldInfoPtr_physicalMin)) = value;
				}
			}

			// Token: 0x17001598 RID: 5528
			// (get) Token: 0x06004528 RID: 17704 RVA: 0x00143088 File Offset: 0x00141288
			// (set) Token: 0x06004529 RID: 17705 RVA: 0x00018D5E File Offset: 0x00016F5E
			public unsafe int physicalMax
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDControllerElement.HIDInfo.NativeFieldInfoPtr_physicalMax);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDControllerElement.HIDInfo.NativeFieldInfoPtr_physicalMax)) = value;
				}
			}

			// Token: 0x17001599 RID: 5529
			// (get) Token: 0x0600452A RID: 17706 RVA: 0x001430B0 File Offset: 0x001412B0
			// (set) Token: 0x0600452B RID: 17707 RVA: 0x00018D79 File Offset: 0x00016F79
			public unsafe uint units
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDControllerElement.HIDInfo.NativeFieldInfoPtr_units);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDControllerElement.HIDInfo.NativeFieldInfoPtr_units)) = value;
				}
			}

			// Token: 0x1700159A RID: 5530
			// (get) Token: 0x0600452C RID: 17708 RVA: 0x001430D8 File Offset: 0x001412D8
			// (set) Token: 0x0600452D RID: 17709 RVA: 0x00018D94 File Offset: 0x00016F94
			public unsafe uint unitsExp
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDControllerElement.HIDInfo.NativeFieldInfoPtr_unitsExp);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDControllerElement.HIDInfo.NativeFieldInfoPtr_unitsExp)) = value;
				}
			}

			// Token: 0x04003880 RID: 14464
			private static readonly IntPtr NativeFieldInfoPtr_usagePage;

			// Token: 0x04003881 RID: 14465
			private static readonly IntPtr NativeFieldInfoPtr_usage;

			// Token: 0x04003882 RID: 14466
			private static readonly IntPtr NativeFieldInfoPtr_dataIndex;

			// Token: 0x04003883 RID: 14467
			private static readonly IntPtr NativeFieldInfoPtr_bitSize;

			// Token: 0x04003884 RID: 14468
			private static readonly IntPtr NativeFieldInfoPtr_logicalMin;

			// Token: 0x04003885 RID: 14469
			private static readonly IntPtr NativeFieldInfoPtr_logicalMax;

			// Token: 0x04003886 RID: 14470
			private static readonly IntPtr NativeFieldInfoPtr_physicalMin;

			// Token: 0x04003887 RID: 14471
			private static readonly IntPtr NativeFieldInfoPtr_physicalMax;

			// Token: 0x04003888 RID: 14472
			private static readonly IntPtr NativeFieldInfoPtr_units;

			// Token: 0x04003889 RID: 14473
			private static readonly IntPtr NativeFieldInfoPtr_unitsExp;

			// Token: 0x0400388A RID: 14474
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
