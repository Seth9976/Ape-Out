using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.Utils.Classes.Utility
{
	// Token: 0x02000205 RID: 517
	public class DualThreadLowLevelInputEventQueue : Object
	{
		// Token: 0x060035F1 RID: 13809 RVA: 0x0010B988 File Offset: 0x00109B88
		// Note: this type is marked as 'beforefieldinit'.
		static DualThreadLowLevelInputEventQueue()
		{
			Il2CppClassPointerStore<DualThreadLowLevelInputEventQueue>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Classes.Utility", "DualThreadLowLevelInputEventQueue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DualThreadLowLevelInputEventQueue>.NativeClassPtr);
			DualThreadLowLevelInputEventQueue.NativeFieldInfoPtr_mdkgXRMSLuFxnpMmHuKRNYkWqsG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualThreadLowLevelInputEventQueue>.NativeClassPtr, "mdkgXRMSLuFxnpMmHuKRNYkWqsG");
			DualThreadLowLevelInputEventQueue.NativeFieldInfoPtr_ZpJkFnggwcfhBxKBFtgZDaTYobF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualThreadLowLevelInputEventQueue>.NativeClassPtr, "ZpJkFnggwcfhBxKBFtgZDaTYobF");
			DualThreadLowLevelInputEventQueue.NativeFieldInfoPtr_bZgjcWQExtnaaWilsTqqqVBAdry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualThreadLowLevelInputEventQueue>.NativeClassPtr, "bZgjcWQExtnaaWilsTqqqVBAdry");
			DualThreadLowLevelInputEventQueue.NativeFieldInfoPtr_EVuifZLYtalaTJddzhqJFiCZweUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualThreadLowLevelInputEventQueue>.NativeClassPtr, "EVuifZLYtalaTJddzhqJFiCZweUp");
			DualThreadLowLevelInputEventQueue.NativeFieldInfoPtr_uQgGhzQzBAmGpPRFGjfmfWEIqHx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualThreadLowLevelInputEventQueue>.NativeClassPtr, "uQgGhzQzBAmGpPRFGjfmfWEIqHx");
			DualThreadLowLevelInputEventQueue.NativeFieldInfoPtr_KzjIOSBUhbasNubZmCZrFhikNqWL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualThreadLowLevelInputEventQueue>.NativeClassPtr, "KzjIOSBUhbasNubZmCZrFhikNqWL");
			DualThreadLowLevelInputEventQueue.NativeFieldInfoPtr_PqvDKoHgyLqWYTLfIDXTeDybfkGG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualThreadLowLevelInputEventQueue>.NativeClassPtr, "PqvDKoHgyLqWYTLfIDXTeDybfkGG");
			DualThreadLowLevelInputEventQueue.NativeFieldInfoPtr_MhYwMCZcOIRqrcjFvrGCagpqnEu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualThreadLowLevelInputEventQueue>.NativeClassPtr, "MhYwMCZcOIRqrcjFvrGCagpqnEu");
			DualThreadLowLevelInputEventQueue.NativeFieldInfoPtr_currentEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualThreadLowLevelInputEventQueue>.NativeClassPtr, "currentEvent");
			DualThreadLowLevelInputEventQueue.NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualThreadLowLevelInputEventQueue>.NativeClassPtr, "OGPdMfJpwRsSVAGxJGrPBlthhPYj");
			DualThreadLowLevelInputEventQueue.NativeMethodInfoPtr_get_lastProcessedEventId_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualThreadLowLevelInputEventQueue>.NativeClassPtr, 100676666);
			DualThreadLowLevelInputEventQueue.NativeMethodInfoPtr_get_count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualThreadLowLevelInputEventQueue>.NativeClassPtr, 100676667);
			DualThreadLowLevelInputEventQueue.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualThreadLowLevelInputEventQueue>.NativeClassPtr, 100676668);
			DualThreadLowLevelInputEventQueue.NativeMethodInfoPtr_T_CreateEvent_Public_INewEventWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualThreadLowLevelInputEventQueue>.NativeClassPtr, 100676669);
			DualThreadLowLevelInputEventQueue.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualThreadLowLevelInputEventQueue>.NativeClassPtr, 100676670);
			DualThreadLowLevelInputEventQueue.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualThreadLowLevelInputEventQueue>.NativeClassPtr, 100676671);
			DualThreadLowLevelInputEventQueue.NativeMethodInfoPtr_ProcessNewEvents_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualThreadLowLevelInputEventQueue>.NativeClassPtr, 100676672);
			DualThreadLowLevelInputEventQueue.NativeMethodInfoPtr_StopProcessingEvents_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualThreadLowLevelInputEventQueue>.NativeClassPtr, 100676673);
			DualThreadLowLevelInputEventQueue.NativeMethodInfoPtr_ImportAll_Public_Void_DualThreadLowLevelInputEventQueue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualThreadLowLevelInputEventQueue>.NativeClassPtr, 100676674);
			DualThreadLowLevelInputEventQueue.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualThreadLowLevelInputEventQueue>.NativeClassPtr, 100676675);
			DualThreadLowLevelInputEventQueue.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualThreadLowLevelInputEventQueue>.NativeClassPtr, 100676676);
			DualThreadLowLevelInputEventQueue.NativeMethodInfoPtr_Dispose_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualThreadLowLevelInputEventQueue>.NativeClassPtr, 100676677);
		}

		// Token: 0x1700101D RID: 4125
		// (get) Token: 0x060035F2 RID: 13810 RVA: 0x0010BB70 File Offset: 0x00109D70
		public unsafe uint lastProcessedEventId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualThreadLowLevelInputEventQueue.NativeMethodInfoPtr_get_lastProcessedEventId_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700101E RID: 4126
		// (get) Token: 0x060035F3 RID: 13811 RVA: 0x0010BBAC File Offset: 0x00109DAC
		public unsafe int count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346492, XrefRangeEnd = 346496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualThreadLowLevelInputEventQueue.NativeMethodInfoPtr_get_count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060035F4 RID: 13812 RVA: 0x0010BBE8 File Offset: 0x00109DE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 346510, RefRangeEnd = 346512, XrefRangeStart = 346496, XrefRangeEnd = 346510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DualThreadLowLevelInputEventQueue(int capacity, int buttonCount, int axisCount, int hatCount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DualThreadLowLevelInputEventQueue>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualThreadLowLevelInputEventQueue.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035F5 RID: 13813 RVA: 0x0010BC5C File Offset: 0x00109E5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 346527, RefRangeEnd = 346529, XrefRangeStart = 346512, XrefRangeEnd = 346527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DualThreadLowLevelInputEventQueue.INewEventWrapper T_CreateEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualThreadLowLevelInputEventQueue.NativeMethodInfoPtr_T_CreateEvent_Public_INewEventWrapper_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DualThreadLowLevelInputEventQueue.INewEventWrapper>(intPtr3) : null;
		}

		// Token: 0x060035F6 RID: 13814 RVA: 0x0010BC9C File Offset: 0x00109E9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 346534, RefRangeEnd = 346535, XrefRangeStart = 346529, XrefRangeEnd = 346534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualThreadLowLevelInputEventQueue.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035F7 RID: 13815 RVA: 0x0010BCD0 File Offset: 0x00109ED0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 346539, RefRangeEnd = 346541, XrefRangeStart = 346535, XrefRangeEnd = 346539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualThreadLowLevelInputEventQueue.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035F8 RID: 13816 RVA: 0x0010BD04 File Offset: 0x00109F04
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 346546, RefRangeEnd = 346550, XrefRangeStart = 346541, XrefRangeEnd = 346546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ProcessNewEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualThreadLowLevelInputEventQueue.NativeMethodInfoPtr_ProcessNewEvents_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060035F9 RID: 13817 RVA: 0x0010BD40 File Offset: 0x00109F40
		[CallerCount(0)]
		public unsafe void StopProcessingEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualThreadLowLevelInputEventQueue.NativeMethodInfoPtr_StopProcessingEvents_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035FA RID: 13818 RVA: 0x0010BD74 File Offset: 0x00109F74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 346559, RefRangeEnd = 346560, XrefRangeStart = 346550, XrefRangeEnd = 346559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ImportAll(DualThreadLowLevelInputEventQueue other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualThreadLowLevelInputEventQueue.NativeMethodInfoPtr_ImportAll_Public_Void_DualThreadLowLevelInputEventQueue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035FB RID: 13819 RVA: 0x0010BDB8 File Offset: 0x00109FB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 346565, RefRangeEnd = 346567, XrefRangeStart = 346560, XrefRangeEnd = 346565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualThreadLowLevelInputEventQueue.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035FC RID: 13820 RVA: 0x0010BDEC File Offset: 0x00109FEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346567, XrefRangeEnd = 346569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DualThreadLowLevelInputEventQueue.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035FD RID: 13821 RVA: 0x0010BE28 File Offset: 0x0010A028
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 346575, RefRangeEnd = 346577, XrefRangeStart = 346569, XrefRangeEnd = 346575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualThreadLowLevelInputEventQueue.NativeMethodInfoPtr_Dispose_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035FE RID: 13822 RVA: 0x0001299D File Offset: 0x00010B9D
		public DualThreadLowLevelInputEventQueue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001013 RID: 4115
		// (get) Token: 0x060035FF RID: 13823 RVA: 0x0010BE68 File Offset: 0x0010A068
		// (set) Token: 0x06003600 RID: 13824 RVA: 0x000129A6 File Offset: 0x00010BA6
		public unsafe LowLevelInputEventQueue mdkgXRMSLuFxnpMmHuKRNYkWqsG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualThreadLowLevelInputEventQueue.NativeFieldInfoPtr_mdkgXRMSLuFxnpMmHuKRNYkWqsG);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LowLevelInputEventQueue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualThreadLowLevelInputEventQueue.NativeFieldInfoPtr_mdkgXRMSLuFxnpMmHuKRNYkWqsG), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001014 RID: 4116
		// (get) Token: 0x06003601 RID: 13825 RVA: 0x0010BE98 File Offset: 0x0010A098
		// (set) Token: 0x06003602 RID: 13826 RVA: 0x000129C5 File Offset: 0x00010BC5
		public unsafe LowLevelInputEventQueue ZpJkFnggwcfhBxKBFtgZDaTYobF
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualThreadLowLevelInputEventQueue.NativeFieldInfoPtr_ZpJkFnggwcfhBxKBFtgZDaTYobF);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LowLevelInputEventQueue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualThreadLowLevelInputEventQueue.NativeFieldInfoPtr_ZpJkFnggwcfhBxKBFtgZDaTYobF), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001015 RID: 4117
		// (get) Token: 0x06003603 RID: 13827 RVA: 0x0010BEC8 File Offset: 0x0010A0C8
		// (set) Token: 0x06003604 RID: 13828 RVA: 0x000129E4 File Offset: 0x00010BE4
		public unsafe Object bZgjcWQExtnaaWilsTqqqVBAdry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualThreadLowLevelInputEventQueue.NativeFieldInfoPtr_bZgjcWQExtnaaWilsTqqqVBAdry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualThreadLowLevelInputEventQueue.NativeFieldInfoPtr_bZgjcWQExtnaaWilsTqqqVBAdry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001016 RID: 4118
		// (get) Token: 0x06003605 RID: 13829 RVA: 0x0010BEF8 File Offset: 0x0010A0F8
		// (set) Token: 0x06003606 RID: 13830 RVA: 0x00012A03 File Offset: 0x00010C03
		public unsafe uint EVuifZLYtalaTJddzhqJFiCZweUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualThreadLowLevelInputEventQueue.NativeFieldInfoPtr_EVuifZLYtalaTJddzhqJFiCZweUp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualThreadLowLevelInputEventQueue.NativeFieldInfoPtr_EVuifZLYtalaTJddzhqJFiCZweUp)) = value;
			}
		}

		// Token: 0x17001017 RID: 4119
		// (get) Token: 0x06003607 RID: 13831 RVA: 0x0010BF20 File Offset: 0x0010A120
		// (set) Token: 0x06003608 RID: 13832 RVA: 0x00012A1E File Offset: 0x00010C1E
		public unsafe bool uQgGhzQzBAmGpPRFGjfmfWEIqHx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualThreadLowLevelInputEventQueue.NativeFieldInfoPtr_uQgGhzQzBAmGpPRFGjfmfWEIqHx);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualThreadLowLevelInputEventQueue.NativeFieldInfoPtr_uQgGhzQzBAmGpPRFGjfmfWEIqHx)) = value;
			}
		}

		// Token: 0x17001018 RID: 4120
		// (get) Token: 0x06003609 RID: 13833 RVA: 0x0010BF48 File Offset: 0x0010A148
		// (set) Token: 0x0600360A RID: 13834 RVA: 0x00012A39 File Offset: 0x00010C39
		public unsafe int KzjIOSBUhbasNubZmCZrFhikNqWL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualThreadLowLevelInputEventQueue.NativeFieldInfoPtr_KzjIOSBUhbasNubZmCZrFhikNqWL);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualThreadLowLevelInputEventQueue.NativeFieldInfoPtr_KzjIOSBUhbasNubZmCZrFhikNqWL)) = value;
			}
		}

		// Token: 0x17001019 RID: 4121
		// (get) Token: 0x0600360B RID: 13835 RVA: 0x0010BF70 File Offset: 0x0010A170
		// (set) Token: 0x0600360C RID: 13836 RVA: 0x00012A54 File Offset: 0x00010C54
		public unsafe int PqvDKoHgyLqWYTLfIDXTeDybfkGG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualThreadLowLevelInputEventQueue.NativeFieldInfoPtr_PqvDKoHgyLqWYTLfIDXTeDybfkGG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualThreadLowLevelInputEventQueue.NativeFieldInfoPtr_PqvDKoHgyLqWYTLfIDXTeDybfkGG)) = value;
			}
		}

		// Token: 0x1700101A RID: 4122
		// (get) Token: 0x0600360D RID: 13837 RVA: 0x0010BF98 File Offset: 0x0010A198
		// (set) Token: 0x0600360E RID: 13838 RVA: 0x00012A6F File Offset: 0x00010C6F
		public unsafe DualThreadLowLevelInputEventQueue.sNPSNNdSThxrSeUNoFWWlEhqgsj MhYwMCZcOIRqrcjFvrGCagpqnEu
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualThreadLowLevelInputEventQueue.NativeFieldInfoPtr_MhYwMCZcOIRqrcjFvrGCagpqnEu);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DualThreadLowLevelInputEventQueue.sNPSNNdSThxrSeUNoFWWlEhqgsj>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualThreadLowLevelInputEventQueue.NativeFieldInfoPtr_MhYwMCZcOIRqrcjFvrGCagpqnEu), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700101B RID: 4123
		// (get) Token: 0x0600360F RID: 13839 RVA: 0x0010BFC8 File Offset: 0x0010A1C8
		// (set) Token: 0x06003610 RID: 13840 RVA: 0x00012A8E File Offset: 0x00010C8E
		public unsafe LowLevelInputEvent currentEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualThreadLowLevelInputEventQueue.NativeFieldInfoPtr_currentEvent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualThreadLowLevelInputEventQueue.NativeFieldInfoPtr_currentEvent)) = value;
			}
		}

		// Token: 0x1700101C RID: 4124
		// (get) Token: 0x06003611 RID: 13841 RVA: 0x0010BFF0 File Offset: 0x0010A1F0
		// (set) Token: 0x06003612 RID: 13842 RVA: 0x00012AA9 File Offset: 0x00010CA9
		public unsafe bool OGPdMfJpwRsSVAGxJGrPBlthhPYj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualThreadLowLevelInputEventQueue.NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualThreadLowLevelInputEventQueue.NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj)) = value;
			}
		}

		// Token: 0x04002DD2 RID: 11730
		private static readonly IntPtr NativeFieldInfoPtr_mdkgXRMSLuFxnpMmHuKRNYkWqsG;

		// Token: 0x04002DD3 RID: 11731
		private static readonly IntPtr NativeFieldInfoPtr_ZpJkFnggwcfhBxKBFtgZDaTYobF;

		// Token: 0x04002DD4 RID: 11732
		private static readonly IntPtr NativeFieldInfoPtr_bZgjcWQExtnaaWilsTqqqVBAdry;

		// Token: 0x04002DD5 RID: 11733
		private static readonly IntPtr NativeFieldInfoPtr_EVuifZLYtalaTJddzhqJFiCZweUp;

		// Token: 0x04002DD6 RID: 11734
		private static readonly IntPtr NativeFieldInfoPtr_uQgGhzQzBAmGpPRFGjfmfWEIqHx;

		// Token: 0x04002DD7 RID: 11735
		private static readonly IntPtr NativeFieldInfoPtr_KzjIOSBUhbasNubZmCZrFhikNqWL;

		// Token: 0x04002DD8 RID: 11736
		private static readonly IntPtr NativeFieldInfoPtr_PqvDKoHgyLqWYTLfIDXTeDybfkGG;

		// Token: 0x04002DD9 RID: 11737
		private static readonly IntPtr NativeFieldInfoPtr_MhYwMCZcOIRqrcjFvrGCagpqnEu;

		// Token: 0x04002DDA RID: 11738
		private static readonly IntPtr NativeFieldInfoPtr_currentEvent;

		// Token: 0x04002DDB RID: 11739
		private static readonly IntPtr NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj;

		// Token: 0x04002DDC RID: 11740
		private static readonly IntPtr NativeMethodInfoPtr_get_lastProcessedEventId_Public_get_UInt32_0;

		// Token: 0x04002DDD RID: 11741
		private static readonly IntPtr NativeMethodInfoPtr_get_count_Public_get_Int32_0;

		// Token: 0x04002DDE RID: 11742
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0;

		// Token: 0x04002DDF RID: 11743
		private static readonly IntPtr NativeMethodInfoPtr_T_CreateEvent_Public_INewEventWrapper_0;

		// Token: 0x04002DE0 RID: 11744
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04002DE1 RID: 11745
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04002DE2 RID: 11746
		private static readonly IntPtr NativeMethodInfoPtr_ProcessNewEvents_Public_Boolean_0;

		// Token: 0x04002DE3 RID: 11747
		private static readonly IntPtr NativeMethodInfoPtr_StopProcessingEvents_Public_Void_0;

		// Token: 0x04002DE4 RID: 11748
		private static readonly IntPtr NativeMethodInfoPtr_ImportAll_Public_Void_DualThreadLowLevelInputEventQueue_0;

		// Token: 0x04002DE5 RID: 11749
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002DE6 RID: 11750
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04002DE7 RID: 11751
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Void_Boolean_0;

		// Token: 0x020004A9 RID: 1193
		public class INewEventWrapper : Il2CppObjectBase
		{
			// Token: 0x0600519A RID: 20890 RVA: 0x0001D734 File Offset: 0x0001B934
			// Note: this type is marked as 'beforefieldinit'.
			static INewEventWrapper()
			{
				Il2CppClassPointerStore<DualThreadLowLevelInputEventQueue.INewEventWrapper>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DualThreadLowLevelInputEventQueue>.NativeClassPtr, "INewEventWrapper");
				DualThreadLowLevelInputEventQueue.INewEventWrapper.NativeMethodInfoPtr_get_Event_Public_Abstract_Virtual_New_get_LowLevelInputEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualThreadLowLevelInputEventQueue.INewEventWrapper>.NativeClassPtr, 100676678);
				DualThreadLowLevelInputEventQueue.INewEventWrapper.NativeMethodInfoPtr_set_Event_Public_Abstract_Virtual_New_set_Void_LowLevelInputEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualThreadLowLevelInputEventQueue.INewEventWrapper>.NativeClassPtr, 100676679);
			}

			// Token: 0x1700190C RID: 6412
			// (get) Token: 0x0600519B RID: 20891 RVA: 0x00173384 File Offset: 0x00171584
			// (set) Token: 0x0600519C RID: 20892 RVA: 0x001733CC File Offset: 0x001715CC
			public unsafe virtual LowLevelInputEvent Event
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DualThreadLowLevelInputEventQueue.INewEventWrapper.NativeMethodInfoPtr_get_Event_Public_Abstract_Virtual_New_get_LowLevelInputEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DualThreadLowLevelInputEventQueue.INewEventWrapper.NativeMethodInfoPtr_set_Event_Public_Abstract_Virtual_New_set_Void_LowLevelInputEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x0600519D RID: 20893 RVA: 0x0001D772 File Offset: 0x0001B972
			public INewEventWrapper(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400449E RID: 17566
			private static readonly IntPtr NativeMethodInfoPtr_get_Event_Public_Abstract_Virtual_New_get_LowLevelInputEvent_0;

			// Token: 0x0400449F RID: 17567
			private static readonly IntPtr NativeMethodInfoPtr_set_Event_Public_Abstract_Virtual_New_set_Void_LowLevelInputEvent_0;
		}

		// Token: 0x020004AA RID: 1194
		public class sNPSNNdSThxrSeUNoFWWlEhqgsj : LockedObject<LowLevelInputEvent>
		{
			// Token: 0x0600519E RID: 20894 RVA: 0x00173418 File Offset: 0x00171618
			// Note: this type is marked as 'beforefieldinit'.
			static sNPSNNdSThxrSeUNoFWWlEhqgsj()
			{
				Il2CppClassPointerStore<DualThreadLowLevelInputEventQueue.sNPSNNdSThxrSeUNoFWWlEhqgsj>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DualThreadLowLevelInputEventQueue>.NativeClassPtr, "sNPSNNdSThxrSeUNoFWWlEhqgsj");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DualThreadLowLevelInputEventQueue.sNPSNNdSThxrSeUNoFWWlEhqgsj>.NativeClassPtr);
				DualThreadLowLevelInputEventQueue.sNPSNNdSThxrSeUNoFWWlEhqgsj.NativeMethodInfoPtr_get_Event_Public_Virtual_Final_New_get_LowLevelInputEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualThreadLowLevelInputEventQueue.sNPSNNdSThxrSeUNoFWWlEhqgsj>.NativeClassPtr, 100676680);
				DualThreadLowLevelInputEventQueue.sNPSNNdSThxrSeUNoFWWlEhqgsj.NativeMethodInfoPtr_set_Event_Public_Virtual_Final_New_set_Void_LowLevelInputEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualThreadLowLevelInputEventQueue.sNPSNNdSThxrSeUNoFWWlEhqgsj>.NativeClassPtr, 100676681);
				DualThreadLowLevelInputEventQueue.sNPSNNdSThxrSeUNoFWWlEhqgsj.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualThreadLowLevelInputEventQueue.sNPSNNdSThxrSeUNoFWWlEhqgsj>.NativeClassPtr, 100676682);
			}

			// Token: 0x1700190D RID: 6413
			// (get) Token: 0x0600519F RID: 20895 RVA: 0x00173480 File Offset: 0x00171680
			// (set) Token: 0x060051A0 RID: 20896 RVA: 0x001734BC File Offset: 0x001716BC
			public unsafe virtual LowLevelInputEvent Event
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualThreadLowLevelInputEventQueue.sNPSNNdSThxrSeUNoFWWlEhqgsj.NativeMethodInfoPtr_get_Event_Public_Virtual_Final_New_get_LowLevelInputEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualThreadLowLevelInputEventQueue.sNPSNNdSThxrSeUNoFWWlEhqgsj.NativeMethodInfoPtr_set_Event_Public_Virtual_Final_New_set_Void_LowLevelInputEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x060051A1 RID: 20897 RVA: 0x001734FC File Offset: 0x001716FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346491, XrefRangeEnd = 346492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe sNPSNNdSThxrSeUNoFWWlEhqgsj(Object lockObject)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DualThreadLowLevelInputEventQueue.sNPSNNdSThxrSeUNoFWWlEhqgsj>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(lockObject);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualThreadLowLevelInputEventQueue.sNPSNNdSThxrSeUNoFWWlEhqgsj.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060051A2 RID: 20898 RVA: 0x0001D77B File Offset: 0x0001B97B
			public sNPSNNdSThxrSeUNoFWWlEhqgsj(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040044A0 RID: 17568
			private static readonly IntPtr NativeMethodInfoPtr_get_Event_Public_Virtual_Final_New_get_LowLevelInputEvent_0;

			// Token: 0x040044A1 RID: 17569
			private static readonly IntPtr NativeMethodInfoPtr_set_Event_Public_Virtual_Final_New_set_Void_LowLevelInputEvent_0;

			// Token: 0x040044A2 RID: 17570
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;
		}
	}
}
