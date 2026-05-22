using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppRewired.ComponentControls
{
	// Token: 0x0200004F RID: 79
	[Serializable]
	public sealed class TouchController : CustomController
	{
		// Token: 0x06000908 RID: 2312 RVA: 0x000503F4 File Offset: 0x0004E5F4
		// Note: this type is marked as 'beforefieldinit'.
		static TouchController()
		{
			Il2CppClassPointerStore<TouchController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.ComponentControls", "TouchController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchController>.NativeClassPtr);
			TouchController.NativeFieldInfoPtr__disableMouseInputWhenEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchController>.NativeClassPtr, "_disableMouseInputWhenEnabled");
			TouchController.NativeFieldInfoPtr__useCustomController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchController>.NativeClassPtr, "_useCustomController");
			TouchController.NativeFieldInfoPtr_VWUNUGCpcYKxmeXaOBYvpTfORa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchController>.NativeClassPtr, "VWUNUGCpcYKxmeXaOBYvpTfORa");
			TouchController.NativeMethodInfoPtr_get_disableMouseInputWhenEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchController>.NativeClassPtr, 100664776);
			TouchController.NativeMethodInfoPtr_set_disableMouseInputWhenEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchController>.NativeClassPtr, 100664777);
			TouchController.NativeMethodInfoPtr_get_useCustomController_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchController>.NativeClassPtr, 100664778);
			TouchController.NativeMethodInfoPtr_set_useCustomController_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchController>.NativeClassPtr, 100664779);
			TouchController.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchController>.NativeClassPtr, 100664780);
			TouchController.NativeMethodInfoPtr_OnDisable_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchController>.NativeClassPtr, 100664781);
			TouchController.NativeMethodInfoPtr_nSRkgireMOAkpBoLMmrDfIispUMG_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchController>.NativeClassPtr, 100664782);
			TouchController.NativeMethodInfoPtr_GetUseCustomController_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchController>.NativeClassPtr, 100664783);
			TouchController.NativeMethodInfoPtr_SetUseCustomController_Internal_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchController>.NativeClassPtr, 100664784);
			TouchController.NativeMethodInfoPtr_swfUjsLRSJiaKcpKtgBOzUMHcgda_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchController>.NativeClassPtr, 100664785);
			TouchController.NativeMethodInfoPtr_VcVpHMiieyhyUeIXveeGUlXtjUXf_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchController>.NativeClassPtr, 100664786);
			TouchController.NativeMethodInfoPtr_sPqdYqrwdeRfNxfmsZSsBqAynDp_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchController>.NativeClassPtr, 100664787);
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000909 RID: 2313 RVA: 0x00050550 File Offset: 0x0004E750
		// (set) Token: 0x0600090A RID: 2314 RVA: 0x0005058C File Offset: 0x0004E78C
		public unsafe bool disableMouseInputWhenEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchController.NativeMethodInfoPtr_get_disableMouseInputWhenEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchController.NativeMethodInfoPtr_set_disableMouseInputWhenEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x0600090B RID: 2315 RVA: 0x000505CC File Offset: 0x0004E7CC
		// (set) Token: 0x0600090C RID: 2316 RVA: 0x00050608 File Offset: 0x0004E808
		public unsafe bool useCustomController
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchController.NativeMethodInfoPtr_get_useCustomController_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249973, XrefRangeEnd = 249980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchController.NativeMethodInfoPtr_set_useCustomController_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x00050648 File Offset: 0x0004E848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249980, XrefRangeEnd = 249981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TouchController()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchController.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x00050684 File Offset: 0x0004E884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249981, XrefRangeEnd = 249992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchController.NativeMethodInfoPtr_OnDisable_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x000506B8 File Offset: 0x0004E8B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249992, XrefRangeEnd = 250000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool nSRkgireMOAkpBoLMmrDfIispUMG()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchController.NativeMethodInfoPtr_nSRkgireMOAkpBoLMmrDfIispUMG_Internal_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x000506F4 File Offset: 0x0004E8F4
		[CallerCount(0)]
		public unsafe override bool GetUseCustomController()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchController.NativeMethodInfoPtr_GetUseCustomController_Internal_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x00050730 File Offset: 0x0004E930
		[CallerCount(0)]
		public unsafe override void SetUseCustomController(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchController.NativeMethodInfoPtr_SetUseCustomController_Internal_Virtual_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x00050770 File Offset: 0x0004E970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250000, XrefRangeEnd = 250005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void swfUjsLRSJiaKcpKtgBOzUMHcgda(bool A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchController.NativeMethodInfoPtr_swfUjsLRSJiaKcpKtgBOzUMHcgda_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x000507B0 File Offset: 0x0004E9B0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void VcVpHMiieyhyUeIXveeGUlXtjUXf()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchController.NativeMethodInfoPtr_VcVpHMiieyhyUeIXveeGUlXtjUXf_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x000507E4 File Offset: 0x0004E9E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250005, XrefRangeEnd = 250012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe bool sPqdYqrwdeRfNxfmsZSsBqAynDp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchController.NativeMethodInfoPtr_sPqdYqrwdeRfNxfmsZSsBqAynDp_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x00005036 File Offset: 0x00003236
		public TouchController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000916 RID: 2326 RVA: 0x00050820 File Offset: 0x0004EA20
		// (set) Token: 0x06000917 RID: 2327 RVA: 0x0000503F File Offset: 0x0000323F
		public unsafe bool _disableMouseInputWhenEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchController.NativeFieldInfoPtr__disableMouseInputWhenEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchController.NativeFieldInfoPtr__disableMouseInputWhenEnabled)) = value;
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000918 RID: 2328 RVA: 0x00050848 File Offset: 0x0004EA48
		// (set) Token: 0x06000919 RID: 2329 RVA: 0x0000505A File Offset: 0x0000325A
		public unsafe bool _useCustomController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchController.NativeFieldInfoPtr__useCustomController);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchController.NativeFieldInfoPtr__useCustomController)) = value;
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x0600091A RID: 2330 RVA: 0x00050870 File Offset: 0x0004EA70
		// (set) Token: 0x0600091B RID: 2331 RVA: 0x00005075 File Offset: 0x00003275
		public unsafe bool VWUNUGCpcYKxmeXaOBYvpTfORa
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchController.NativeFieldInfoPtr_VWUNUGCpcYKxmeXaOBYvpTfORa);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchController.NativeFieldInfoPtr_VWUNUGCpcYKxmeXaOBYvpTfORa)) = value;
			}
		}

		// Token: 0x04000754 RID: 1876
		private static readonly IntPtr NativeFieldInfoPtr__disableMouseInputWhenEnabled;

		// Token: 0x04000755 RID: 1877
		private static readonly IntPtr NativeFieldInfoPtr__useCustomController;

		// Token: 0x04000756 RID: 1878
		private static readonly IntPtr NativeFieldInfoPtr_VWUNUGCpcYKxmeXaOBYvpTfORa;

		// Token: 0x04000757 RID: 1879
		private static readonly IntPtr NativeMethodInfoPtr_get_disableMouseInputWhenEnabled_Public_get_Boolean_0;

		// Token: 0x04000758 RID: 1880
		private static readonly IntPtr NativeMethodInfoPtr_set_disableMouseInputWhenEnabled_Public_set_Void_Boolean_0;

		// Token: 0x04000759 RID: 1881
		private static readonly IntPtr NativeMethodInfoPtr_get_useCustomController_Public_get_Boolean_0;

		// Token: 0x0400075A RID: 1882
		private static readonly IntPtr NativeMethodInfoPtr_set_useCustomController_Public_set_Void_Boolean_0;

		// Token: 0x0400075B RID: 1883
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x0400075C RID: 1884
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Internal_Virtual_Void_0;

		// Token: 0x0400075D RID: 1885
		private static readonly IntPtr NativeMethodInfoPtr_nSRkgireMOAkpBoLMmrDfIispUMG_Internal_Virtual_Boolean_0;

		// Token: 0x0400075E RID: 1886
		private static readonly IntPtr NativeMethodInfoPtr_GetUseCustomController_Internal_Virtual_Boolean_0;

		// Token: 0x0400075F RID: 1887
		private static readonly IntPtr NativeMethodInfoPtr_SetUseCustomController_Internal_Virtual_Void_Boolean_0;

		// Token: 0x04000760 RID: 1888
		private static readonly IntPtr NativeMethodInfoPtr_swfUjsLRSJiaKcpKtgBOzUMHcgda_Private_Void_Boolean_0;

		// Token: 0x04000761 RID: 1889
		private static readonly IntPtr NativeMethodInfoPtr_VcVpHMiieyhyUeIXveeGUlXtjUXf_Private_Void_0;

		// Token: 0x04000762 RID: 1890
		private static readonly IntPtr NativeMethodInfoPtr_sPqdYqrwdeRfNxfmsZSsBqAynDp_Private_Boolean_0;
	}
}
