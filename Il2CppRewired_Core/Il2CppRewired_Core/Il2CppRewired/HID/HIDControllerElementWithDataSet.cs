using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Config;
using Il2CppSystem;

namespace Il2CppRewired.HID
{
	// Token: 0x02000116 RID: 278
	public class HIDControllerElementWithDataSet : HIDControllerElement
	{
		// Token: 0x06001A7A RID: 6778 RVA: 0x00093D00 File Offset: 0x00091F00
		// Note: this type is marked as 'beforefieldinit'.
		static HIDControllerElementWithDataSet()
		{
			Il2CppClassPointerStore<HIDControllerElementWithDataSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.HID", "HIDControllerElementWithDataSet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HIDControllerElementWithDataSet>.NativeClassPtr);
			HIDControllerElementWithDataSet.NativeFieldInfoPtr_dataSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDControllerElementWithDataSet>.NativeClassPtr, "dataSet");
			HIDControllerElementWithDataSet.NativeMethodInfoPtr__ctor_Public_Void_minEAYGbVFUHmbVTFIBMhSqoDeq_Byte_HIDInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDControllerElementWithDataSet>.NativeClassPtr, 100669506);
			HIDControllerElementWithDataSet.NativeMethodInfoPtr_Update_Public_Virtual_New_Void_UpdateLoopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDControllerElementWithDataSet>.NativeClassPtr, 100669507);
		}

		// Token: 0x06001A7B RID: 6779 RVA: 0x00093D6C File Offset: 0x00091F6C
		[CallerCount(0)]
		public unsafe HIDControllerElementWithDataSet(HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq dataSet, byte reportId, HIDControllerElement.HIDInfo hidInfo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HIDControllerElementWithDataSet>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataSet);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reportId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hidInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDControllerElementWithDataSet.NativeMethodInfoPtr__ctor_Public_Void_minEAYGbVFUHmbVTFIBMhSqoDeq_Byte_HIDInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A7C RID: 6780 RVA: 0x00093DD8 File Offset: 0x00091FD8
		[CallerCount(0)]
		public unsafe virtual void Update(UpdateLoopType updateLoop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateLoop;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HIDControllerElementWithDataSet.NativeMethodInfoPtr_Update_Public_Virtual_New_Void_UpdateLoopType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A7D RID: 6781 RVA: 0x0000ADF6 File Offset: 0x00008FF6
		public HIDControllerElementWithDataSet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x06001A7E RID: 6782 RVA: 0x00093E24 File Offset: 0x00092024
		// (set) Token: 0x06001A7F RID: 6783 RVA: 0x0000ADFF File Offset: 0x00008FFF
		public unsafe HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq dataSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDControllerElementWithDataSet.NativeFieldInfoPtr_dataSet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDControllerElementWithDataSet.NativeFieldInfoPtr_dataSet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040016B6 RID: 5814
		private static readonly IntPtr NativeFieldInfoPtr_dataSet;

		// Token: 0x040016B7 RID: 5815
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_minEAYGbVFUHmbVTFIBMhSqoDeq_Byte_HIDInfo_0;

		// Token: 0x040016B8 RID: 5816
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_New_Void_UpdateLoopType_0;

		// Token: 0x02000327 RID: 807
		public class minEAYGbVFUHmbVTFIBMhSqoDeq : Object
		{
			// Token: 0x0600452E RID: 17710 RVA: 0x00143100 File Offset: 0x00141300
			// Note: this type is marked as 'beforefieldinit'.
			static minEAYGbVFUHmbVTFIBMhSqoDeq()
			{
				Il2CppClassPointerStore<HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HIDControllerElementWithDataSet>.NativeClassPtr, "minEAYGbVFUHmbVTFIBMhSqoDeq");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq>.NativeClassPtr);
				HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq.NativeFieldInfoPtr_pOyrbcDhEcyeuLdPwWQMbdvxeipc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq>.NativeClassPtr, "pOyrbcDhEcyeuLdPwWQMbdvxeipc");
				HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq.NativeFieldInfoPtr_UNhrDlHVHupYurOqDONrxjcNRWM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq>.NativeClassPtr, "UNhrDlHVHupYurOqDONrxjcNRWM");
				HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq.NativeFieldInfoPtr_FdnRvmaTOwBrRhxTobULlZTUAPv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq>.NativeClassPtr, "FdnRvmaTOwBrRhxTobULlZTUAPv");
				HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq.NativeFieldInfoPtr_EDWjCkozGqmyQyquicPQVDMTCVq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq>.NativeClassPtr, "EDWjCkozGqmyQyquicPQVDMTCVq");
				HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq.NativeFieldInfoPtr_czPgrBYcuMpJrlqXpuRJAvvkFiI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq>.NativeClassPtr, "czPgrBYcuMpJrlqXpuRJAvvkFiI");
				HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq.NativeFieldInfoPtr_wkOliZmFNdcmVbcKCVrLJZyhQJc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq>.NativeClassPtr, "wkOliZmFNdcmVbcKCVrLJZyhQJc");
				HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq.NativeFieldInfoPtr_hvGDCWectQgzwVNffhRCeUEVaDyy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq>.NativeClassPtr, "hvGDCWectQgzwVNffhRCeUEVaDyy");
				HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq.NativeMethodInfoPtr_get_dataCount_Protected_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq>.NativeClassPtr, 100669508);
				HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq.NativeMethodInfoPtr_get_updateLoopIndex_Protected_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq>.NativeClassPtr, 100669509);
				HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq.NativeMethodInfoPtr_set_updateLoop_Public_set_Void_UpdateLoopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq>.NativeClassPtr, 100669510);
				HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq>.NativeClassPtr, 100669511);
				HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq.NativeMethodInfoPtr_dVWYISriGymYqjVVPecmomHdCufb_Public_Void_UpdateLoopSetting_Func_2_UpdateLoopType_SqbCLQdqFuOIjgxIadvYefGbeDa_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq>.NativeClassPtr, 100669512);
				HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq.NativeMethodInfoPtr_CbsEmnnwyFQdDSAIjxPQXifCiCb_Private_Void_UpdateLoopType_SqbCLQdqFuOIjgxIadvYefGbeDa_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq>.NativeClassPtr, 100669513);
				HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq.NativeMethodInfoPtr_xozDTcGUrsCTUDmjINWIvPSceAOJ_Public_Virtual_New_Void_UpdateLoopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq>.NativeClassPtr, 100669514);
				HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq.NativeMethodInfoPtr_vsfKIEzLYgmvYXdfRKJgdqwirYk_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq>.NativeClassPtr, 100669515);
			}

			// Token: 0x170015A2 RID: 5538
			// (get) Token: 0x0600452F RID: 17711 RVA: 0x00143258 File Offset: 0x00141458
			public unsafe int dbbSwkArnKBFftKDiGfmukfGPWR
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq.NativeMethodInfoPtr_get_dataCount_Protected_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170015A3 RID: 5539
			// (get) Token: 0x06004530 RID: 17712 RVA: 0x00143294 File Offset: 0x00141494
			public unsafe Il2CppStructArray<int> jtZTOBUiTDkSIlXnntPwHKTcYMp
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq.NativeMethodInfoPtr_get_updateLoopIndex_Protected_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
				}
			}

			// Token: 0x170015A4 RID: 5540
			// (set) Token: 0x06004531 RID: 17713 RVA: 0x001432D4 File Offset: 0x001414D4
			public unsafe UpdateLoopType HmLJOEaFHWwVymwfHWYgZGnwyFG
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 252153, RefRangeEnd = 252157, XrefRangeStart = 252153, XrefRangeEnd = 252157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq.NativeMethodInfoPtr_set_updateLoop_Public_set_Void_UpdateLoopType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06004532 RID: 17714 RVA: 0x00143314 File Offset: 0x00141514
			[CallerCount(0)]
			public unsafe minEAYGbVFUHmbVTFIBMhSqoDeq()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004533 RID: 17715 RVA: 0x00143350 File Offset: 0x00141550
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 279199, RefRangeEnd = 279201, XrefRangeStart = 279165, XrefRangeEnd = 279199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void dVWYISriGymYqjVVPecmomHdCufb(UpdateLoopSetting A_1, Func<UpdateLoopType, HIDControllerElementWithDataSet.SqbCLQdqFuOIjgxIadvYefGbeDa> A_2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq.NativeMethodInfoPtr_dVWYISriGymYqjVVPecmomHdCufb_Public_Void_UpdateLoopSetting_Func_2_UpdateLoopType_SqbCLQdqFuOIjgxIadvYefGbeDa_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004534 RID: 17716 RVA: 0x001433A0 File Offset: 0x001415A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279201, XrefRangeEnd = 279202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CbsEmnnwyFQdDSAIjxPQXifCiCb(UpdateLoopType A_1, HIDControllerElementWithDataSet.SqbCLQdqFuOIjgxIadvYefGbeDa A_2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq.NativeMethodInfoPtr_CbsEmnnwyFQdDSAIjxPQXifCiCb_Private_Void_UpdateLoopType_SqbCLQdqFuOIjgxIadvYefGbeDa_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004535 RID: 17717 RVA: 0x001433F0 File Offset: 0x001415F0
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 252153, RefRangeEnd = 252157, XrefRangeStart = 252153, XrefRangeEnd = 252157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void xozDTcGUrsCTUDmjINWIvPSceAOJ(UpdateLoopType A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq.NativeMethodInfoPtr_xozDTcGUrsCTUDmjINWIvPSceAOJ_Public_Virtual_New_Void_UpdateLoopType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004536 RID: 17718 RVA: 0x0014343C File Offset: 0x0014163C
			[CallerCount(0)]
			public unsafe void vsfKIEzLYgmvYXdfRKJgdqwirYk()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq.NativeMethodInfoPtr_vsfKIEzLYgmvYXdfRKJgdqwirYk_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004537 RID: 17719 RVA: 0x00018DAF File Offset: 0x00016FAF
			public minEAYGbVFUHmbVTFIBMhSqoDeq(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700159B RID: 5531
			// (get) Token: 0x06004538 RID: 17720 RVA: 0x00143470 File Offset: 0x00141670
			// (set) Token: 0x06004539 RID: 17721 RVA: 0x00018DB8 File Offset: 0x00016FB8
			public unsafe int pOyrbcDhEcyeuLdPwWQMbdvxeipc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq.NativeFieldInfoPtr_pOyrbcDhEcyeuLdPwWQMbdvxeipc);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq.NativeFieldInfoPtr_pOyrbcDhEcyeuLdPwWQMbdvxeipc)) = value;
				}
			}

			// Token: 0x1700159C RID: 5532
			// (get) Token: 0x0600453A RID: 17722 RVA: 0x00143498 File Offset: 0x00141698
			// (set) Token: 0x0600453B RID: 17723 RVA: 0x00018DD3 File Offset: 0x00016FD3
			public unsafe Il2CppStructArray<int> UNhrDlHVHupYurOqDONrxjcNRWM
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq.NativeFieldInfoPtr_UNhrDlHVHupYurOqDONrxjcNRWM);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq.NativeFieldInfoPtr_UNhrDlHVHupYurOqDONrxjcNRWM), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700159D RID: 5533
			// (get) Token: 0x0600453C RID: 17724 RVA: 0x001434C8 File Offset: 0x001416C8
			// (set) Token: 0x0600453D RID: 17725 RVA: 0x00018DF2 File Offset: 0x00016FF2
			public unsafe Il2CppReferenceArray<HIDControllerElementWithDataSet.SqbCLQdqFuOIjgxIadvYefGbeDa> FdnRvmaTOwBrRhxTobULlZTUAPv
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq.NativeFieldInfoPtr_FdnRvmaTOwBrRhxTobULlZTUAPv);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<HIDControllerElementWithDataSet.SqbCLQdqFuOIjgxIadvYefGbeDa>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq.NativeFieldInfoPtr_FdnRvmaTOwBrRhxTobULlZTUAPv), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700159E RID: 5534
			// (get) Token: 0x0600453E RID: 17726 RVA: 0x001434F8 File Offset: 0x001416F8
			// (set) Token: 0x0600453F RID: 17727 RVA: 0x00018E11 File Offset: 0x00017011
			public unsafe HIDControllerElementWithDataSet.SqbCLQdqFuOIjgxIadvYefGbeDa EDWjCkozGqmyQyquicPQVDMTCVq
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq.NativeFieldInfoPtr_EDWjCkozGqmyQyquicPQVDMTCVq);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HIDControllerElementWithDataSet.SqbCLQdqFuOIjgxIadvYefGbeDa>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq.NativeFieldInfoPtr_EDWjCkozGqmyQyquicPQVDMTCVq), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700159F RID: 5535
			// (get) Token: 0x06004540 RID: 17728 RVA: 0x00143528 File Offset: 0x00141728
			// (set) Token: 0x06004541 RID: 17729 RVA: 0x00018E30 File Offset: 0x00017030
			public unsafe int czPgrBYcuMpJrlqXpuRJAvvkFiI
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq.NativeFieldInfoPtr_czPgrBYcuMpJrlqXpuRJAvvkFiI);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq.NativeFieldInfoPtr_czPgrBYcuMpJrlqXpuRJAvvkFiI)) = value;
				}
			}

			// Token: 0x170015A0 RID: 5536
			// (get) Token: 0x06004542 RID: 17730 RVA: 0x00143550 File Offset: 0x00141750
			// (set) Token: 0x06004543 RID: 17731 RVA: 0x00018E4B File Offset: 0x0001704B
			public unsafe int wkOliZmFNdcmVbcKCVrLJZyhQJc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq.NativeFieldInfoPtr_wkOliZmFNdcmVbcKCVrLJZyhQJc);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq.NativeFieldInfoPtr_wkOliZmFNdcmVbcKCVrLJZyhQJc)) = value;
				}
			}

			// Token: 0x170015A1 RID: 5537
			// (get) Token: 0x06004544 RID: 17732 RVA: 0x00143578 File Offset: 0x00141778
			// (set) Token: 0x06004545 RID: 17733 RVA: 0x00018E66 File Offset: 0x00017066
			public unsafe bool hvGDCWectQgzwVNffhRCeUEVaDyy
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq.NativeFieldInfoPtr_hvGDCWectQgzwVNffhRCeUEVaDyy);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq.NativeFieldInfoPtr_hvGDCWectQgzwVNffhRCeUEVaDyy)) = value;
				}
			}

			// Token: 0x0400388B RID: 14475
			private static readonly IntPtr NativeFieldInfoPtr_pOyrbcDhEcyeuLdPwWQMbdvxeipc;

			// Token: 0x0400388C RID: 14476
			private static readonly IntPtr NativeFieldInfoPtr_UNhrDlHVHupYurOqDONrxjcNRWM;

			// Token: 0x0400388D RID: 14477
			private static readonly IntPtr NativeFieldInfoPtr_FdnRvmaTOwBrRhxTobULlZTUAPv;

			// Token: 0x0400388E RID: 14478
			private static readonly IntPtr NativeFieldInfoPtr_EDWjCkozGqmyQyquicPQVDMTCVq;

			// Token: 0x0400388F RID: 14479
			private static readonly IntPtr NativeFieldInfoPtr_czPgrBYcuMpJrlqXpuRJAvvkFiI;

			// Token: 0x04003890 RID: 14480
			private static readonly IntPtr NativeFieldInfoPtr_wkOliZmFNdcmVbcKCVrLJZyhQJc;

			// Token: 0x04003891 RID: 14481
			private static readonly IntPtr NativeFieldInfoPtr_hvGDCWectQgzwVNffhRCeUEVaDyy;

			// Token: 0x04003892 RID: 14482
			private static readonly IntPtr NativeMethodInfoPtr_get_dataCount_Protected_get_Int32_0;

			// Token: 0x04003893 RID: 14483
			private static readonly IntPtr NativeMethodInfoPtr_get_updateLoopIndex_Protected_get_Il2CppStructArray_1_Int32_0;

			// Token: 0x04003894 RID: 14484
			private static readonly IntPtr NativeMethodInfoPtr_set_updateLoop_Public_set_Void_UpdateLoopType_0;

			// Token: 0x04003895 RID: 14485
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003896 RID: 14486
			private static readonly IntPtr NativeMethodInfoPtr_dVWYISriGymYqjVVPecmomHdCufb_Public_Void_UpdateLoopSetting_Func_2_UpdateLoopType_SqbCLQdqFuOIjgxIadvYefGbeDa_0;

			// Token: 0x04003897 RID: 14487
			private static readonly IntPtr NativeMethodInfoPtr_CbsEmnnwyFQdDSAIjxPQXifCiCb_Private_Void_UpdateLoopType_SqbCLQdqFuOIjgxIadvYefGbeDa_0;

			// Token: 0x04003898 RID: 14488
			private static readonly IntPtr NativeMethodInfoPtr_xozDTcGUrsCTUDmjINWIvPSceAOJ_Public_Virtual_New_Void_UpdateLoopType_0;

			// Token: 0x04003899 RID: 14489
			private static readonly IntPtr NativeMethodInfoPtr_vsfKIEzLYgmvYXdfRKJgdqwirYk_Public_Void_0;
		}

		// Token: 0x02000328 RID: 808
		public class SqbCLQdqFuOIjgxIadvYefGbeDa : Object
		{
			// Token: 0x06004546 RID: 17734 RVA: 0x001435A0 File Offset: 0x001417A0
			// Note: this type is marked as 'beforefieldinit'.
			static SqbCLQdqFuOIjgxIadvYefGbeDa()
			{
				Il2CppClassPointerStore<HIDControllerElementWithDataSet.SqbCLQdqFuOIjgxIadvYefGbeDa>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HIDControllerElementWithDataSet>.NativeClassPtr, "SqbCLQdqFuOIjgxIadvYefGbeDa");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HIDControllerElementWithDataSet.SqbCLQdqFuOIjgxIadvYefGbeDa>.NativeClassPtr);
				HIDControllerElementWithDataSet.SqbCLQdqFuOIjgxIadvYefGbeDa.NativeFieldInfoPtr_HmLJOEaFHWwVymwfHWYgZGnwyFG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDControllerElementWithDataSet.SqbCLQdqFuOIjgxIadvYefGbeDa>.NativeClassPtr, "HmLJOEaFHWwVymwfHWYgZGnwyFG");
				HIDControllerElementWithDataSet.SqbCLQdqFuOIjgxIadvYefGbeDa.NativeMethodInfoPtr__ctor_Public_Void_UpdateLoopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDControllerElementWithDataSet.SqbCLQdqFuOIjgxIadvYefGbeDa>.NativeClassPtr, 100669516);
				HIDControllerElementWithDataSet.SqbCLQdqFuOIjgxIadvYefGbeDa.NativeMethodInfoPtr_vsfKIEzLYgmvYXdfRKJgdqwirYk_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDControllerElementWithDataSet.SqbCLQdqFuOIjgxIadvYefGbeDa>.NativeClassPtr, 100669517);
			}

			// Token: 0x06004547 RID: 17735 RVA: 0x00143608 File Offset: 0x00141808
			[CallerCount(0)]
			public unsafe SqbCLQdqFuOIjgxIadvYefGbeDa(UpdateLoopType updateLoop)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HIDControllerElementWithDataSet.SqbCLQdqFuOIjgxIadvYefGbeDa>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref updateLoop;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDControllerElementWithDataSet.SqbCLQdqFuOIjgxIadvYefGbeDa.NativeMethodInfoPtr__ctor_Public_Void_UpdateLoopType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004548 RID: 17736 RVA: 0x00143650 File Offset: 0x00141850
			[CallerCount(0)]
			public unsafe virtual void vsfKIEzLYgmvYXdfRKJgdqwirYk()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HIDControllerElementWithDataSet.SqbCLQdqFuOIjgxIadvYefGbeDa.NativeMethodInfoPtr_vsfKIEzLYgmvYXdfRKJgdqwirYk_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004549 RID: 17737 RVA: 0x00018E81 File Offset: 0x00017081
			public SqbCLQdqFuOIjgxIadvYefGbeDa(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015A5 RID: 5541
			// (get) Token: 0x0600454A RID: 17738 RVA: 0x0014368C File Offset: 0x0014188C
			// (set) Token: 0x0600454B RID: 17739 RVA: 0x00018E8A File Offset: 0x0001708A
			public unsafe UpdateLoopType HmLJOEaFHWwVymwfHWYgZGnwyFG
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDControllerElementWithDataSet.SqbCLQdqFuOIjgxIadvYefGbeDa.NativeFieldInfoPtr_HmLJOEaFHWwVymwfHWYgZGnwyFG);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDControllerElementWithDataSet.SqbCLQdqFuOIjgxIadvYefGbeDa.NativeFieldInfoPtr_HmLJOEaFHWwVymwfHWYgZGnwyFG)) = value;
				}
			}

			// Token: 0x0400389A RID: 14490
			private static readonly IntPtr NativeFieldInfoPtr_HmLJOEaFHWwVymwfHWYgZGnwyFG;

			// Token: 0x0400389B RID: 14491
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UpdateLoopType_0;

			// Token: 0x0400389C RID: 14492
			private static readonly IntPtr NativeMethodInfoPtr_vsfKIEzLYgmvYXdfRKJgdqwirYk_Public_Abstract_Virtual_New_Void_0;
		}
	}
}
