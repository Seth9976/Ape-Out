using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.Data.Mapping
{
	// Token: 0x020000B9 RID: 185
	[Serializable]
	public class HardwareAxisInfo : Object
	{
		// Token: 0x06001556 RID: 5462 RVA: 0x0007CF24 File Offset: 0x0007B124
		// Note: this type is marked as 'beforefieldinit'.
		static HardwareAxisInfo()
		{
			Il2CppClassPointerStore<HardwareAxisInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Data.Mapping", "HardwareAxisInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HardwareAxisInfo>.NativeClassPtr);
			HardwareAxisInfo.NativeFieldInfoPtr__dataFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareAxisInfo>.NativeClassPtr, "_dataFormat");
			HardwareAxisInfo.NativeFieldInfoPtr__excludeFromPolling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareAxisInfo>.NativeClassPtr, "_excludeFromPolling");
			HardwareAxisInfo.NativeFieldInfoPtr__specialAxisType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareAxisInfo>.NativeClassPtr, "_specialAxisType");
			HardwareAxisInfo.NativeFieldInfoPtr__pollingDeadZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareAxisInfo>.NativeClassPtr, "_pollingDeadZone");
			HardwareAxisInfo.NativeMethodInfoPtr_get_dataFormat_Public_get_AxisCoordinateMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareAxisInfo>.NativeClassPtr, 100668362);
			HardwareAxisInfo.NativeMethodInfoPtr_get_excludeFromPolling_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareAxisInfo>.NativeClassPtr, 100668363);
			HardwareAxisInfo.NativeMethodInfoPtr_get_specialAxisType_Public_get_SpecialAxisType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareAxisInfo>.NativeClassPtr, 100668364);
			HardwareAxisInfo.NativeMethodInfoPtr_get_pollingDeadZone_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareAxisInfo>.NativeClassPtr, 100668365);
			HardwareAxisInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareAxisInfo>.NativeClassPtr, 100668366);
			HardwareAxisInfo.NativeMethodInfoPtr__ctor_Internal_Void_AxisCoordinateMode_Boolean_Single_SpecialAxisType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareAxisInfo>.NativeClassPtr, 100668367);
			HardwareAxisInfo.NativeMethodInfoPtr_get_Default_Internal_Static_get_HardwareAxisInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareAxisInfo>.NativeClassPtr, 100668368);
			HardwareAxisInfo.NativeMethodInfoPtr_DeepClone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareAxisInfo>.NativeClassPtr, 100668369);
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x06001557 RID: 5463 RVA: 0x0007D044 File Offset: 0x0007B244
		public unsafe AxisCoordinateMode dataFormat
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareAxisInfo.NativeMethodInfoPtr_get_dataFormat_Public_get_AxisCoordinateMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x06001558 RID: 5464 RVA: 0x0007D080 File Offset: 0x0007B280
		public unsafe bool excludeFromPolling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareAxisInfo.NativeMethodInfoPtr_get_excludeFromPolling_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x06001559 RID: 5465 RVA: 0x0007D0BC File Offset: 0x0007B2BC
		public unsafe SpecialAxisType specialAxisType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareAxisInfo.NativeMethodInfoPtr_get_specialAxisType_Public_get_SpecialAxisType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x0600155A RID: 5466 RVA: 0x0007D0F8 File Offset: 0x0007B2F8
		public unsafe float pollingDeadZone
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareAxisInfo.NativeMethodInfoPtr_get_pollingDeadZone_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x0007D134 File Offset: 0x0007B334
		[CallerCount(0)]
		public unsafe HardwareAxisInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HardwareAxisInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareAxisInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x0007D170 File Offset: 0x0007B370
		[CallerCount(0)]
		public unsafe HardwareAxisInfo(AxisCoordinateMode dataFormat, bool excludeFromPolling, float pollingDeadZone, SpecialAxisType specialAxisType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HardwareAxisInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dataFormat;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref excludeFromPolling;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pollingDeadZone;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref specialAxisType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareAxisInfo.NativeMethodInfoPtr__ctor_Internal_Void_AxisCoordinateMode_Boolean_Single_SpecialAxisType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x0600155D RID: 5469 RVA: 0x0007D1E4 File Offset: 0x0007B3E4
		public unsafe static HardwareAxisInfo Default
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 271468, RefRangeEnd = 271469, XrefRangeStart = 271465, XrefRangeEnd = 271468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareAxisInfo.NativeMethodInfoPtr_get_Default_Internal_Static_get_HardwareAxisInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HardwareAxisInfo>(intPtr3) : null;
			}
		}

		// Token: 0x0600155E RID: 5470 RVA: 0x0007D218 File Offset: 0x0007B418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271469, XrefRangeEnd = 271472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object DeepClone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareAxisInfo.NativeMethodInfoPtr_DeepClone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600155F RID: 5471 RVA: 0x0000959E File Offset: 0x0000779E
		public HardwareAxisInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x06001560 RID: 5472 RVA: 0x0007D258 File Offset: 0x0007B458
		// (set) Token: 0x06001561 RID: 5473 RVA: 0x000095A7 File Offset: 0x000077A7
		public unsafe AxisCoordinateMode _dataFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareAxisInfo.NativeFieldInfoPtr__dataFormat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareAxisInfo.NativeFieldInfoPtr__dataFormat)) = value;
			}
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x06001562 RID: 5474 RVA: 0x0007D280 File Offset: 0x0007B480
		// (set) Token: 0x06001563 RID: 5475 RVA: 0x000095C2 File Offset: 0x000077C2
		public unsafe bool _excludeFromPolling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareAxisInfo.NativeFieldInfoPtr__excludeFromPolling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareAxisInfo.NativeFieldInfoPtr__excludeFromPolling)) = value;
			}
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x06001564 RID: 5476 RVA: 0x0007D2A8 File Offset: 0x0007B4A8
		// (set) Token: 0x06001565 RID: 5477 RVA: 0x000095DD File Offset: 0x000077DD
		public unsafe SpecialAxisType _specialAxisType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareAxisInfo.NativeFieldInfoPtr__specialAxisType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareAxisInfo.NativeFieldInfoPtr__specialAxisType)) = value;
			}
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x06001566 RID: 5478 RVA: 0x0007D2D0 File Offset: 0x0007B4D0
		// (set) Token: 0x06001567 RID: 5479 RVA: 0x000095F8 File Offset: 0x000077F8
		public unsafe float _pollingDeadZone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareAxisInfo.NativeFieldInfoPtr__pollingDeadZone);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareAxisInfo.NativeFieldInfoPtr__pollingDeadZone)) = value;
			}
		}

		// Token: 0x04001137 RID: 4407
		private static readonly IntPtr NativeFieldInfoPtr__dataFormat;

		// Token: 0x04001138 RID: 4408
		private static readonly IntPtr NativeFieldInfoPtr__excludeFromPolling;

		// Token: 0x04001139 RID: 4409
		private static readonly IntPtr NativeFieldInfoPtr__specialAxisType;

		// Token: 0x0400113A RID: 4410
		private static readonly IntPtr NativeFieldInfoPtr__pollingDeadZone;

		// Token: 0x0400113B RID: 4411
		private static readonly IntPtr NativeMethodInfoPtr_get_dataFormat_Public_get_AxisCoordinateMode_0;

		// Token: 0x0400113C RID: 4412
		private static readonly IntPtr NativeMethodInfoPtr_get_excludeFromPolling_Public_get_Boolean_0;

		// Token: 0x0400113D RID: 4413
		private static readonly IntPtr NativeMethodInfoPtr_get_specialAxisType_Public_get_SpecialAxisType_0;

		// Token: 0x0400113E RID: 4414
		private static readonly IntPtr NativeMethodInfoPtr_get_pollingDeadZone_Public_get_Single_0;

		// Token: 0x0400113F RID: 4415
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001140 RID: 4416
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_AxisCoordinateMode_Boolean_Single_SpecialAxisType_0;

		// Token: 0x04001141 RID: 4417
		private static readonly IntPtr NativeMethodInfoPtr_get_Default_Internal_Static_get_HardwareAxisInfo_0;

		// Token: 0x04001142 RID: 4418
		private static readonly IntPtr NativeMethodInfoPtr_DeepClone_Public_Virtual_Final_New_Object_0;
	}
}
