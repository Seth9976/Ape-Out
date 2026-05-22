using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Utils.Classes.Data;
using Il2CppSystem;

namespace Il2CppRewired.Utils.Classes.Utility
{
	// Token: 0x02000206 RID: 518
	public class LowLevelInputEventQueue : Object
	{
		// Token: 0x06003613 RID: 13843 RVA: 0x0010C018 File Offset: 0x0010A218
		// Note: this type is marked as 'beforefieldinit'.
		static LowLevelInputEventQueue()
		{
			Il2CppClassPointerStore<LowLevelInputEventQueue>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Classes.Utility", "LowLevelInputEventQueue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LowLevelInputEventQueue>.NativeClassPtr);
			LowLevelInputEventQueue.NativeFieldInfoPtr_nVqNelhHoXiREFDMSygjaHBfDvVD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LowLevelInputEventQueue>.NativeClassPtr, "nVqNelhHoXiREFDMSygjaHBfDvVD");
			LowLevelInputEventQueue.NativeFieldInfoPtr_gPKtOSTBlBvitsowaGbHpeEVBGje = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LowLevelInputEventQueue>.NativeClassPtr, "gPKtOSTBlBvitsowaGbHpeEVBGje");
			LowLevelInputEventQueue.NativeFieldInfoPtr_AHoQaCqgIOGogOpDnwRoZuWfUKU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LowLevelInputEventQueue>.NativeClassPtr, "AHoQaCqgIOGogOpDnwRoZuWfUKU");
			LowLevelInputEventQueue.NativeFieldInfoPtr_wuJGhDkBlVgWLDdNjgUhulfhZzxt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LowLevelInputEventQueue>.NativeClassPtr, "wuJGhDkBlVgWLDdNjgUhulfhZzxt");
			LowLevelInputEventQueue.NativeFieldInfoPtr_zDyyBaxsowomSCnDgbuHSLXwmRp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LowLevelInputEventQueue>.NativeClassPtr, "zDyyBaxsowomSCnDgbuHSLXwmRp");
			LowLevelInputEventQueue.NativeFieldInfoPtr_ZWqvVQGVEQvbEXgtdIvggmppKWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LowLevelInputEventQueue>.NativeClassPtr, "ZWqvVQGVEQvbEXgtdIvggmppKWs");
			LowLevelInputEventQueue.NativeFieldInfoPtr_qBWhkDkyhhMvevSGcjJIDmXZcRT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LowLevelInputEventQueue>.NativeClassPtr, "qBWhkDkyhhMvevSGcjJIDmXZcRT");
			LowLevelInputEventQueue.NativeFieldInfoPtr_eIqPwSHcGTwMiqaMKiNsVTjnnNU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LowLevelInputEventQueue>.NativeClassPtr, "eIqPwSHcGTwMiqaMKiNsVTjnnNU");
			LowLevelInputEventQueue.NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LowLevelInputEventQueue>.NativeClassPtr, "OGPdMfJpwRsSVAGxJGrPBlthhPYj");
			LowLevelInputEventQueue.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelInputEventQueue>.NativeClassPtr, 100676683);
			LowLevelInputEventQueue.NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelInputEventQueue>.NativeClassPtr, 100676684);
			LowLevelInputEventQueue.NativeMethodInfoPtr_get_Item_Public_get_LowLevelInputEvent_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelInputEventQueue>.NativeClassPtr, 100676685);
			LowLevelInputEventQueue.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelInputEventQueue>.NativeClassPtr, 100676686);
			LowLevelInputEventQueue.NativeMethodInfoPtr_CreateEvent_Public_LowLevelInputEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelInputEventQueue>.NativeClassPtr, 100676687);
			LowLevelInputEventQueue.NativeMethodInfoPtr_FindNextIndex_Public_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelInputEventQueue>.NativeClassPtr, 100676688);
			LowLevelInputEventQueue.NativeMethodInfoPtr_TryGetNext_Public_Boolean_Int32_byref_LowLevelInputEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelInputEventQueue>.NativeClassPtr, 100676689);
			LowLevelInputEventQueue.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelInputEventQueue>.NativeClassPtr, 100676690);
			LowLevelInputEventQueue.NativeMethodInfoPtr_CopyAllFrom_Public_Void_LowLevelInputEventQueue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelInputEventQueue>.NativeClassPtr, 100676691);
			LowLevelInputEventQueue.NativeMethodInfoPtr_CopyNewEventsFrom_Public_Void_LowLevelInputEventQueue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelInputEventQueue>.NativeClassPtr, 100676692);
			LowLevelInputEventQueue.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelInputEventQueue>.NativeClassPtr, 100676693);
			LowLevelInputEventQueue.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelInputEventQueue>.NativeClassPtr, 100676694);
			LowLevelInputEventQueue.NativeMethodInfoPtr_Dispose_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelInputEventQueue>.NativeClassPtr, 100676695);
		}

		// Token: 0x17001028 RID: 4136
		// (get) Token: 0x06003614 RID: 13844 RVA: 0x0010C200 File Offset: 0x0010A400
		public unsafe int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LowLevelInputEventQueue.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001029 RID: 4137
		// (get) Token: 0x06003615 RID: 13845 RVA: 0x0010C23C File Offset: 0x0010A43C
		public unsafe int Capacity
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 93966, RefRangeEnd = 93969, XrefRangeStart = 93966, XrefRangeEnd = 93969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LowLevelInputEventQueue.NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700102A RID: 4138
		public unsafe LowLevelInputEvent this[int index]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346577, XrefRangeEnd = 346579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LowLevelInputEventQueue.NativeMethodInfoPtr_get_Item_Public_get_LowLevelInputEvent_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}
		}

		// Token: 0x06003617 RID: 13847 RVA: 0x0010C2C4 File Offset: 0x0010A4C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 346586, RefRangeEnd = 346588, XrefRangeStart = 346579, XrefRangeEnd = 346586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LowLevelInputEventQueue(int capacity, int buttonCount, int axisCount, int hatCount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LowLevelInputEventQueue>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buttonCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hatCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LowLevelInputEventQueue.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003618 RID: 13848 RVA: 0x0010C338 File Offset: 0x0010A538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346588, XrefRangeEnd = 346597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LowLevelInputEvent CreateEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LowLevelInputEventQueue.NativeMethodInfoPtr_CreateEvent_Public_LowLevelInputEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003619 RID: 13849 RVA: 0x0010C374 File Offset: 0x0010A574
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 346630, RefRangeEnd = 346632, XrefRangeStart = 346597, XrefRangeEnd = 346630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindNextIndex(uint id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LowLevelInputEventQueue.NativeMethodInfoPtr_FindNextIndex_Public_Int32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600361A RID: 13850 RVA: 0x0010C3C0 File Offset: 0x0010A5C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346632, XrefRangeEnd = 346634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetNext(int index, out LowLevelInputEvent @event)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &@event;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LowLevelInputEventQueue.NativeMethodInfoPtr_TryGetNext_Public_Boolean_Int32_byref_LowLevelInputEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600361B RID: 13851 RVA: 0x0010C418 File Offset: 0x0010A618
		[CallerCount(0)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LowLevelInputEventQueue.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600361C RID: 13852 RVA: 0x0010C44C File Offset: 0x0010A64C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 346636, RefRangeEnd = 346638, XrefRangeStart = 346634, XrefRangeEnd = 346636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyAllFrom(LowLevelInputEventQueue other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LowLevelInputEventQueue.NativeMethodInfoPtr_CopyAllFrom_Public_Void_LowLevelInputEventQueue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600361D RID: 13853 RVA: 0x0010C490 File Offset: 0x0010A690
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 346649, RefRangeEnd = 346650, XrefRangeStart = 346638, XrefRangeEnd = 346649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyNewEventsFrom(LowLevelInputEventQueue other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LowLevelInputEventQueue.NativeMethodInfoPtr_CopyNewEventsFrom_Public_Void_LowLevelInputEventQueue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600361E RID: 13854 RVA: 0x0010C4D4 File Offset: 0x0010A6D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 346660, RefRangeEnd = 346662, XrefRangeStart = 346650, XrefRangeEnd = 346660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LowLevelInputEventQueue.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600361F RID: 13855 RVA: 0x0010C508 File Offset: 0x0010A708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346662, XrefRangeEnd = 346663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LowLevelInputEventQueue.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003620 RID: 13856 RVA: 0x0010C544 File Offset: 0x0010A744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346663, XrefRangeEnd = 346668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LowLevelInputEventQueue.NativeMethodInfoPtr_Dispose_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003621 RID: 13857 RVA: 0x00012AC4 File Offset: 0x00010CC4
		public LowLevelInputEventQueue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700101F RID: 4127
		// (get) Token: 0x06003622 RID: 13858 RVA: 0x0010C584 File Offset: 0x0010A784
		// (set) Token: 0x06003623 RID: 13859 RVA: 0x00012ACD File Offset: 0x00010CCD
		public unsafe LowLevelInputEvent nVqNelhHoXiREFDMSygjaHBfDvVD
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LowLevelInputEventQueue.NativeFieldInfoPtr_nVqNelhHoXiREFDMSygjaHBfDvVD);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LowLevelInputEventQueue.NativeFieldInfoPtr_nVqNelhHoXiREFDMSygjaHBfDvVD)) = value;
			}
		}

		// Token: 0x17001020 RID: 4128
		// (get) Token: 0x06003624 RID: 13860 RVA: 0x0010C5AC File Offset: 0x0010A7AC
		// (set) Token: 0x06003625 RID: 13861 RVA: 0x00012AE8 File Offset: 0x00010CE8
		public unsafe NativeRingBuffer gPKtOSTBlBvitsowaGbHpeEVBGje
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LowLevelInputEventQueue.NativeFieldInfoPtr_gPKtOSTBlBvitsowaGbHpeEVBGje);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NativeRingBuffer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LowLevelInputEventQueue.NativeFieldInfoPtr_gPKtOSTBlBvitsowaGbHpeEVBGje), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001021 RID: 4129
		// (get) Token: 0x06003626 RID: 13862 RVA: 0x0010C5DC File Offset: 0x0010A7DC
		// (set) Token: 0x06003627 RID: 13863 RVA: 0x00012B07 File Offset: 0x00010D07
		public unsafe int AHoQaCqgIOGogOpDnwRoZuWfUKU
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LowLevelInputEventQueue.NativeFieldInfoPtr_AHoQaCqgIOGogOpDnwRoZuWfUKU);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LowLevelInputEventQueue.NativeFieldInfoPtr_AHoQaCqgIOGogOpDnwRoZuWfUKU)) = value;
			}
		}

		// Token: 0x17001022 RID: 4130
		// (get) Token: 0x06003628 RID: 13864 RVA: 0x0010C604 File Offset: 0x0010A804
		// (set) Token: 0x06003629 RID: 13865 RVA: 0x00012B22 File Offset: 0x00010D22
		public unsafe int wuJGhDkBlVgWLDdNjgUhulfhZzxt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LowLevelInputEventQueue.NativeFieldInfoPtr_wuJGhDkBlVgWLDdNjgUhulfhZzxt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LowLevelInputEventQueue.NativeFieldInfoPtr_wuJGhDkBlVgWLDdNjgUhulfhZzxt)) = value;
			}
		}

		// Token: 0x17001023 RID: 4131
		// (get) Token: 0x0600362A RID: 13866 RVA: 0x0010C62C File Offset: 0x0010A82C
		// (set) Token: 0x0600362B RID: 13867 RVA: 0x00012B3D File Offset: 0x00010D3D
		public unsafe int zDyyBaxsowomSCnDgbuHSLXwmRp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LowLevelInputEventQueue.NativeFieldInfoPtr_zDyyBaxsowomSCnDgbuHSLXwmRp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LowLevelInputEventQueue.NativeFieldInfoPtr_zDyyBaxsowomSCnDgbuHSLXwmRp)) = value;
			}
		}

		// Token: 0x17001024 RID: 4132
		// (get) Token: 0x0600362C RID: 13868 RVA: 0x0010C654 File Offset: 0x0010A854
		// (set) Token: 0x0600362D RID: 13869 RVA: 0x00012B58 File Offset: 0x00010D58
		public unsafe int ZWqvVQGVEQvbEXgtdIvggmppKWs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LowLevelInputEventQueue.NativeFieldInfoPtr_ZWqvVQGVEQvbEXgtdIvggmppKWs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LowLevelInputEventQueue.NativeFieldInfoPtr_ZWqvVQGVEQvbEXgtdIvggmppKWs)) = value;
			}
		}

		// Token: 0x17001025 RID: 4133
		// (get) Token: 0x0600362E RID: 13870 RVA: 0x0010C67C File Offset: 0x0010A87C
		// (set) Token: 0x0600362F RID: 13871 RVA: 0x00012B73 File Offset: 0x00010D73
		public unsafe int qBWhkDkyhhMvevSGcjJIDmXZcRT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LowLevelInputEventQueue.NativeFieldInfoPtr_qBWhkDkyhhMvevSGcjJIDmXZcRT);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LowLevelInputEventQueue.NativeFieldInfoPtr_qBWhkDkyhhMvevSGcjJIDmXZcRT)) = value;
			}
		}

		// Token: 0x17001026 RID: 4134
		// (get) Token: 0x06003630 RID: 13872 RVA: 0x0010C6A4 File Offset: 0x0010A8A4
		// (set) Token: 0x06003631 RID: 13873 RVA: 0x00012B8E File Offset: 0x00010D8E
		public unsafe uint eIqPwSHcGTwMiqaMKiNsVTjnnNU
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LowLevelInputEventQueue.NativeFieldInfoPtr_eIqPwSHcGTwMiqaMKiNsVTjnnNU);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LowLevelInputEventQueue.NativeFieldInfoPtr_eIqPwSHcGTwMiqaMKiNsVTjnnNU)) = value;
			}
		}

		// Token: 0x17001027 RID: 4135
		// (get) Token: 0x06003632 RID: 13874 RVA: 0x0010C6CC File Offset: 0x0010A8CC
		// (set) Token: 0x06003633 RID: 13875 RVA: 0x00012BA9 File Offset: 0x00010DA9
		public unsafe bool OGPdMfJpwRsSVAGxJGrPBlthhPYj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LowLevelInputEventQueue.NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LowLevelInputEventQueue.NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj)) = value;
			}
		}

		// Token: 0x04002DE8 RID: 11752
		private static readonly IntPtr NativeFieldInfoPtr_nVqNelhHoXiREFDMSygjaHBfDvVD;

		// Token: 0x04002DE9 RID: 11753
		private static readonly IntPtr NativeFieldInfoPtr_gPKtOSTBlBvitsowaGbHpeEVBGje;

		// Token: 0x04002DEA RID: 11754
		private static readonly IntPtr NativeFieldInfoPtr_AHoQaCqgIOGogOpDnwRoZuWfUKU;

		// Token: 0x04002DEB RID: 11755
		private static readonly IntPtr NativeFieldInfoPtr_wuJGhDkBlVgWLDdNjgUhulfhZzxt;

		// Token: 0x04002DEC RID: 11756
		private static readonly IntPtr NativeFieldInfoPtr_zDyyBaxsowomSCnDgbuHSLXwmRp;

		// Token: 0x04002DED RID: 11757
		private static readonly IntPtr NativeFieldInfoPtr_ZWqvVQGVEQvbEXgtdIvggmppKWs;

		// Token: 0x04002DEE RID: 11758
		private static readonly IntPtr NativeFieldInfoPtr_qBWhkDkyhhMvevSGcjJIDmXZcRT;

		// Token: 0x04002DEF RID: 11759
		private static readonly IntPtr NativeFieldInfoPtr_eIqPwSHcGTwMiqaMKiNsVTjnnNU;

		// Token: 0x04002DF0 RID: 11760
		private static readonly IntPtr NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj;

		// Token: 0x04002DF1 RID: 11761
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x04002DF2 RID: 11762
		private static readonly IntPtr NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0;

		// Token: 0x04002DF3 RID: 11763
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_LowLevelInputEvent_Int32_0;

		// Token: 0x04002DF4 RID: 11764
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0;

		// Token: 0x04002DF5 RID: 11765
		private static readonly IntPtr NativeMethodInfoPtr_CreateEvent_Public_LowLevelInputEvent_0;

		// Token: 0x04002DF6 RID: 11766
		private static readonly IntPtr NativeMethodInfoPtr_FindNextIndex_Public_Int32_UInt32_0;

		// Token: 0x04002DF7 RID: 11767
		private static readonly IntPtr NativeMethodInfoPtr_TryGetNext_Public_Boolean_Int32_byref_LowLevelInputEvent_0;

		// Token: 0x04002DF8 RID: 11768
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04002DF9 RID: 11769
		private static readonly IntPtr NativeMethodInfoPtr_CopyAllFrom_Public_Void_LowLevelInputEventQueue_0;

		// Token: 0x04002DFA RID: 11770
		private static readonly IntPtr NativeMethodInfoPtr_CopyNewEventsFrom_Public_Void_LowLevelInputEventQueue_0;

		// Token: 0x04002DFB RID: 11771
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002DFC RID: 11772
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04002DFD RID: 11773
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Void_Boolean_0;
	}
}
