using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppRewired
{
	// Token: 0x0200015D RID: 349
	public sealed class PlayerSaveData : ValueType
	{
		// Token: 0x06002768 RID: 10088 RVA: 0x000C7298 File Offset: 0x000C5498
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerSaveData()
		{
			Il2CppClassPointerStore<PlayerSaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "PlayerSaveData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerSaveData>.NativeClassPtr);
			PlayerSaveData.NativeFieldInfoPtr_rDzSVUSebRdwMpUvJAckkwmvUxZg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveData>.NativeClassPtr, "rDzSVUSebRdwMpUvJAckkwmvUxZg");
			PlayerSaveData.NativeFieldInfoPtr_HHDCiukvOOKinRylybJBRkpfPUr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveData>.NativeClassPtr, "HHDCiukvOOKinRylybJBRkpfPUr");
			PlayerSaveData.NativeFieldInfoPtr_pIYYGtPzlyooDQqomiFZZFdWNnP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveData>.NativeClassPtr, "pIYYGtPzlyooDQqomiFZZFdWNnP");
			PlayerSaveData.NativeFieldInfoPtr_bPTdKbmEIrBtnaDWSOOZPbDeGWzc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveData>.NativeClassPtr, "bPTdKbmEIrBtnaDWSOOZPbDeGWzc");
			PlayerSaveData.NativeFieldInfoPtr_ApTbexjdoMDhsONnSiNHciSWNVbf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveData>.NativeClassPtr, "ApTbexjdoMDhsONnSiNHciSWNVbf");
			PlayerSaveData.NativeMethodInfoPtr_get_joystickMapSaveData_Public_get_Il2CppReferenceArray_1_JoystickMapSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveData>.NativeClassPtr, 100671860);
			PlayerSaveData.NativeMethodInfoPtr_get_keyboardMapSaveData_Public_get_Il2CppReferenceArray_1_KeyboardMapSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveData>.NativeClassPtr, 100671861);
			PlayerSaveData.NativeMethodInfoPtr_get_mouseMapSaveData_Public_get_Il2CppReferenceArray_1_MouseMapSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveData>.NativeClassPtr, 100671862);
			PlayerSaveData.NativeMethodInfoPtr_get_customControllerMapSaveData_Public_get_Il2CppReferenceArray_1_CustomControllerMapSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveData>.NativeClassPtr, 100671863);
			PlayerSaveData.NativeMethodInfoPtr_get_inputBehaviors_Public_get_Il2CppReferenceArray_1_InputBehavior_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveData>.NativeClassPtr, 100671864);
			PlayerSaveData.NativeMethodInfoPtr_get_joystickMapCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveData>.NativeClassPtr, 100671865);
			PlayerSaveData.NativeMethodInfoPtr_get_keyboardMapCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveData>.NativeClassPtr, 100671866);
			PlayerSaveData.NativeMethodInfoPtr_get_mouseMapCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveData>.NativeClassPtr, 100671867);
			PlayerSaveData.NativeMethodInfoPtr_get_customControllerMapCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveData>.NativeClassPtr, 100671868);
			PlayerSaveData.NativeMethodInfoPtr_get_inputBehaviorCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveData>.NativeClassPtr, 100671869);
			PlayerSaveData.NativeMethodInfoPtr_get_AllControllerMapSaveData_Public_get_IEnumerable_1_ControllerMapSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveData>.NativeClassPtr, 100671870);
			PlayerSaveData.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppReferenceArray_1_JoystickMapSaveData_Il2CppReferenceArray_1_KeyboardMapSaveData_Il2CppReferenceArray_1_MouseMapSaveData_Il2CppReferenceArray_1_CustomControllerMapSaveData_IList_1_InputBehavior_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveData>.NativeClassPtr, 100671871);
		}

		// Token: 0x17000CEC RID: 3308
		// (get) Token: 0x06002769 RID: 10089 RVA: 0x000C741C File Offset: 0x000C561C
		public unsafe Il2CppReferenceArray<JoystickMapSaveData> joystickMapSaveData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveData.NativeMethodInfoPtr_get_joystickMapSaveData_Public_get_Il2CppReferenceArray_1_JoystickMapSaveData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<JoystickMapSaveData>>(intPtr3) : null;
			}
		}

		// Token: 0x17000CED RID: 3309
		// (get) Token: 0x0600276A RID: 10090 RVA: 0x000C7460 File Offset: 0x000C5660
		public unsafe Il2CppReferenceArray<KeyboardMapSaveData> keyboardMapSaveData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveData.NativeMethodInfoPtr_get_keyboardMapSaveData_Public_get_Il2CppReferenceArray_1_KeyboardMapSaveData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeyboardMapSaveData>>(intPtr3) : null;
			}
		}

		// Token: 0x17000CEE RID: 3310
		// (get) Token: 0x0600276B RID: 10091 RVA: 0x000C74A4 File Offset: 0x000C56A4
		public unsafe Il2CppReferenceArray<MouseMapSaveData> mouseMapSaveData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveData.NativeMethodInfoPtr_get_mouseMapSaveData_Public_get_Il2CppReferenceArray_1_MouseMapSaveData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MouseMapSaveData>>(intPtr3) : null;
			}
		}

		// Token: 0x17000CEF RID: 3311
		// (get) Token: 0x0600276C RID: 10092 RVA: 0x000C74E8 File Offset: 0x000C56E8
		public unsafe Il2CppReferenceArray<CustomControllerMapSaveData> customControllerMapSaveData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveData.NativeMethodInfoPtr_get_customControllerMapSaveData_Public_get_Il2CppReferenceArray_1_CustomControllerMapSaveData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CustomControllerMapSaveData>>(intPtr3) : null;
			}
		}

		// Token: 0x17000CF0 RID: 3312
		// (get) Token: 0x0600276D RID: 10093 RVA: 0x000C752C File Offset: 0x000C572C
		public unsafe Il2CppReferenceArray<InputBehavior> inputBehaviors
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveData.NativeMethodInfoPtr_get_inputBehaviors_Public_get_Il2CppReferenceArray_1_InputBehavior_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InputBehavior>>(intPtr3) : null;
			}
		}

		// Token: 0x17000CF1 RID: 3313
		// (get) Token: 0x0600276E RID: 10094 RVA: 0x000C7570 File Offset: 0x000C5770
		public unsafe int joystickMapCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveData.NativeMethodInfoPtr_get_joystickMapCount_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CF2 RID: 3314
		// (get) Token: 0x0600276F RID: 10095 RVA: 0x000C75B4 File Offset: 0x000C57B4
		public unsafe int keyboardMapCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveData.NativeMethodInfoPtr_get_keyboardMapCount_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CF3 RID: 3315
		// (get) Token: 0x06002770 RID: 10096 RVA: 0x000C75F8 File Offset: 0x000C57F8
		public unsafe int mouseMapCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveData.NativeMethodInfoPtr_get_mouseMapCount_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CF4 RID: 3316
		// (get) Token: 0x06002771 RID: 10097 RVA: 0x000C763C File Offset: 0x000C583C
		public unsafe int customControllerMapCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveData.NativeMethodInfoPtr_get_customControllerMapCount_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CF5 RID: 3317
		// (get) Token: 0x06002772 RID: 10098 RVA: 0x000C7680 File Offset: 0x000C5880
		public unsafe int inputBehaviorCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveData.NativeMethodInfoPtr_get_inputBehaviorCount_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CF6 RID: 3318
		// (get) Token: 0x06002773 RID: 10099 RVA: 0x000C76C4 File Offset: 0x000C58C4
		public unsafe IEnumerable<ControllerMapSaveData> AllControllerMapSaveData
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 296550, RefRangeEnd = 296551, XrefRangeStart = 296545, XrefRangeEnd = 296550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveData.NativeMethodInfoPtr_get_AllControllerMapSaveData_Public_get_IEnumerable_1_ControllerMapSaveData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ControllerMapSaveData>>(intPtr3) : null;
			}
		}

		// Token: 0x06002774 RID: 10100 RVA: 0x000C7708 File Offset: 0x000C5908
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 296565, RefRangeEnd = 296566, XrefRangeStart = 296551, XrefRangeEnd = 296565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerSaveData(Il2CppReferenceArray<JoystickMapSaveData> joystickMapSaveData, Il2CppReferenceArray<KeyboardMapSaveData> keyboardMapSaveData, Il2CppReferenceArray<MouseMapSaveData> mouseMapSaveData, Il2CppReferenceArray<CustomControllerMapSaveData> customControllerMapSaveData, IList<InputBehavior> inputBehaviors)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSaveData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(joystickMapSaveData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keyboardMapSaveData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mouseMapSaveData);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(customControllerMapSaveData);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inputBehaviors);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveData.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppReferenceArray_1_JoystickMapSaveData_Il2CppReferenceArray_1_KeyboardMapSaveData_Il2CppReferenceArray_1_MouseMapSaveData_Il2CppReferenceArray_1_CustomControllerMapSaveData_IList_1_InputBehavior_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002775 RID: 10101 RVA: 0x0000F662 File Offset: 0x0000D862
		public PlayerSaveData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002776 RID: 10102 RVA: 0x0000F66B File Offset: 0x0000D86B
		public PlayerSaveData()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSaveData>.NativeClassPtr))
		{
		}

		// Token: 0x17000CE7 RID: 3303
		// (get) Token: 0x06002777 RID: 10103 RVA: 0x000C77A4 File Offset: 0x000C59A4
		// (set) Token: 0x06002778 RID: 10104 RVA: 0x0000F67D File Offset: 0x0000D87D
		public unsafe Il2CppReferenceArray<JoystickMapSaveData> rDzSVUSebRdwMpUvJAckkwmvUxZg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveData.NativeFieldInfoPtr_rDzSVUSebRdwMpUvJAckkwmvUxZg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<JoystickMapSaveData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveData.NativeFieldInfoPtr_rDzSVUSebRdwMpUvJAckkwmvUxZg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CE8 RID: 3304
		// (get) Token: 0x06002779 RID: 10105 RVA: 0x000C77D4 File Offset: 0x000C59D4
		// (set) Token: 0x0600277A RID: 10106 RVA: 0x0000F69C File Offset: 0x0000D89C
		public unsafe Il2CppReferenceArray<KeyboardMapSaveData> HHDCiukvOOKinRylybJBRkpfPUr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveData.NativeFieldInfoPtr_HHDCiukvOOKinRylybJBRkpfPUr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeyboardMapSaveData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveData.NativeFieldInfoPtr_HHDCiukvOOKinRylybJBRkpfPUr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CE9 RID: 3305
		// (get) Token: 0x0600277B RID: 10107 RVA: 0x000C7804 File Offset: 0x000C5A04
		// (set) Token: 0x0600277C RID: 10108 RVA: 0x0000F6BB File Offset: 0x0000D8BB
		public unsafe Il2CppReferenceArray<MouseMapSaveData> pIYYGtPzlyooDQqomiFZZFdWNnP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveData.NativeFieldInfoPtr_pIYYGtPzlyooDQqomiFZZFdWNnP);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MouseMapSaveData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveData.NativeFieldInfoPtr_pIYYGtPzlyooDQqomiFZZFdWNnP), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CEA RID: 3306
		// (get) Token: 0x0600277D RID: 10109 RVA: 0x000C7834 File Offset: 0x000C5A34
		// (set) Token: 0x0600277E RID: 10110 RVA: 0x0000F6DA File Offset: 0x0000D8DA
		public unsafe Il2CppReferenceArray<CustomControllerMapSaveData> bPTdKbmEIrBtnaDWSOOZPbDeGWzc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveData.NativeFieldInfoPtr_bPTdKbmEIrBtnaDWSOOZPbDeGWzc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CustomControllerMapSaveData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveData.NativeFieldInfoPtr_bPTdKbmEIrBtnaDWSOOZPbDeGWzc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CEB RID: 3307
		// (get) Token: 0x0600277F RID: 10111 RVA: 0x000C7864 File Offset: 0x000C5A64
		// (set) Token: 0x06002780 RID: 10112 RVA: 0x0000F6F9 File Offset: 0x0000D8F9
		public unsafe Il2CppReferenceArray<InputBehavior> ApTbexjdoMDhsONnSiNHciSWNVbf
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveData.NativeFieldInfoPtr_ApTbexjdoMDhsONnSiNHciSWNVbf);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InputBehavior>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveData.NativeFieldInfoPtr_ApTbexjdoMDhsONnSiNHciSWNVbf), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400204C RID: 8268
		private static readonly IntPtr NativeFieldInfoPtr_rDzSVUSebRdwMpUvJAckkwmvUxZg;

		// Token: 0x0400204D RID: 8269
		private static readonly IntPtr NativeFieldInfoPtr_HHDCiukvOOKinRylybJBRkpfPUr;

		// Token: 0x0400204E RID: 8270
		private static readonly IntPtr NativeFieldInfoPtr_pIYYGtPzlyooDQqomiFZZFdWNnP;

		// Token: 0x0400204F RID: 8271
		private static readonly IntPtr NativeFieldInfoPtr_bPTdKbmEIrBtnaDWSOOZPbDeGWzc;

		// Token: 0x04002050 RID: 8272
		private static readonly IntPtr NativeFieldInfoPtr_ApTbexjdoMDhsONnSiNHciSWNVbf;

		// Token: 0x04002051 RID: 8273
		private static readonly IntPtr NativeMethodInfoPtr_get_joystickMapSaveData_Public_get_Il2CppReferenceArray_1_JoystickMapSaveData_0;

		// Token: 0x04002052 RID: 8274
		private static readonly IntPtr NativeMethodInfoPtr_get_keyboardMapSaveData_Public_get_Il2CppReferenceArray_1_KeyboardMapSaveData_0;

		// Token: 0x04002053 RID: 8275
		private static readonly IntPtr NativeMethodInfoPtr_get_mouseMapSaveData_Public_get_Il2CppReferenceArray_1_MouseMapSaveData_0;

		// Token: 0x04002054 RID: 8276
		private static readonly IntPtr NativeMethodInfoPtr_get_customControllerMapSaveData_Public_get_Il2CppReferenceArray_1_CustomControllerMapSaveData_0;

		// Token: 0x04002055 RID: 8277
		private static readonly IntPtr NativeMethodInfoPtr_get_inputBehaviors_Public_get_Il2CppReferenceArray_1_InputBehavior_0;

		// Token: 0x04002056 RID: 8278
		private static readonly IntPtr NativeMethodInfoPtr_get_joystickMapCount_Public_get_Int32_0;

		// Token: 0x04002057 RID: 8279
		private static readonly IntPtr NativeMethodInfoPtr_get_keyboardMapCount_Public_get_Int32_0;

		// Token: 0x04002058 RID: 8280
		private static readonly IntPtr NativeMethodInfoPtr_get_mouseMapCount_Public_get_Int32_0;

		// Token: 0x04002059 RID: 8281
		private static readonly IntPtr NativeMethodInfoPtr_get_customControllerMapCount_Public_get_Int32_0;

		// Token: 0x0400205A RID: 8282
		private static readonly IntPtr NativeMethodInfoPtr_get_inputBehaviorCount_Public_get_Int32_0;

		// Token: 0x0400205B RID: 8283
		private static readonly IntPtr NativeMethodInfoPtr_get_AllControllerMapSaveData_Public_get_IEnumerable_1_ControllerMapSaveData_0;

		// Token: 0x0400205C RID: 8284
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Il2CppReferenceArray_1_JoystickMapSaveData_Il2CppReferenceArray_1_KeyboardMapSaveData_Il2CppReferenceArray_1_MouseMapSaveData_Il2CppReferenceArray_1_CustomControllerMapSaveData_IList_1_InputBehavior_0;

		// Token: 0x0200038A RID: 906
		public sealed class cHfLOrYEoQFlPSeqGAAeqKRLTta : Object
		{
			// Token: 0x06004AC0 RID: 19136 RVA: 0x00155CE8 File Offset: 0x00153EE8
			// Note: this type is marked as 'beforefieldinit'.
			static cHfLOrYEoQFlPSeqGAAeqKRLTta()
			{
				Il2CppClassPointerStore<PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerSaveData>.NativeClassPtr, "cHfLOrYEoQFlPSeqGAAeqKRLTta");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta>.NativeClassPtr);
				PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta>.NativeClassPtr, "NuVnrlTavvGYEgMZhwgjSLwilSSG");
				PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta>.NativeClassPtr, "NsLEWIBMBVGSwXePCZaULRETkiZ");
				PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta>.NativeClassPtr, "wNSJsQuOfbQPTCkuxzljZjIjmsi");
				PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta>.NativeClassPtr, "HbFBVXVdulMdGSmvVCgeOcAyoyn");
				PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta.NativeFieldInfoPtr_HZhKrhGbTaOkiEzaRhgUZyFviFE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta>.NativeClassPtr, "HZhKrhGbTaOkiEzaRhgUZyFviFE");
				PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta.NativeFieldInfoPtr_kUBcJcFfgoKKiApkBmiZbFhcTlkZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta>.NativeClassPtr, "kUBcJcFfgoKKiApkBmiZbFhcTlkZ");
				PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta.NativeFieldInfoPtr_hAStVwJVMBBvRtdqjAJKGEgHfju = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta>.NativeClassPtr, "hAStVwJVMBBvRtdqjAJKGEgHfju");
				PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta.NativeFieldInfoPtr_jNBFAEjkzgoEDtIarJoUKhfdWwep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta>.NativeClassPtr, "jNBFAEjkzgoEDtIarJoUKhfdWwep");
				PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta.NativeFieldInfoPtr_TFDsBsaKeCHdrWhCBRqkvZjrFnV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta>.NativeClassPtr, "TFDsBsaKeCHdrWhCBRqkvZjrFnV");
				PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_ControllerMapSaveData__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ControllerMapSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta>.NativeClassPtr, 100671872);
				PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta>.NativeClassPtr, 100671873);
				PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta>.NativeClassPtr, 100671874);
				PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_ControllerMapSaveData__get_Current_Private_Virtual_Final_New_get_ControllerMapSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta>.NativeClassPtr, 100671875);
				PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta>.NativeClassPtr, 100671876);
				PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta>.NativeClassPtr, 100671877);
				PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta>.NativeClassPtr, 100671878);
				PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta>.NativeClassPtr, 100671879);
			}

			// Token: 0x06004AC1 RID: 19137 RVA: 0x00155E68 File Offset: 0x00154068
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296526, XrefRangeEnd = 296534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ControllerMapSaveData> System_Collections_Generic_IEnumerable_Rewired_ControllerMapSaveData__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_ControllerMapSaveData__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ControllerMapSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ControllerMapSaveData>>(intPtr3) : null;
			}

			// Token: 0x06004AC2 RID: 19138 RVA: 0x00155EA8 File Offset: 0x001540A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06004AC3 RID: 19139 RVA: 0x00155EE8 File Offset: 0x001540E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296534, XrefRangeEnd = 296540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001777 RID: 6007
			// (get) Token: 0x06004AC4 RID: 19140 RVA: 0x00155F24 File Offset: 0x00154124
			public unsafe ControllerMapSaveData ilsOCexDPQWkFreLnAamYMuRKvN
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_ControllerMapSaveData__get_Current_Private_Virtual_Final_New_get_ControllerMapSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerMapSaveData>(intPtr3) : null;
				}
			}

			// Token: 0x06004AC5 RID: 19141 RVA: 0x00155F64 File Offset: 0x00154164
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296540, XrefRangeEnd = 296545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004AC6 RID: 19142 RVA: 0x00155F98 File Offset: 0x00154198
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001778 RID: 6008
			// (get) Token: 0x06004AC7 RID: 19143 RVA: 0x00155FCC File Offset: 0x001541CC
			public unsafe Object EDfTBMmIlQtjWtkIjwQoFCOMpSp
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004AC8 RID: 19144 RVA: 0x0015600C File Offset: 0x0015420C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe cHfLOrYEoQFlPSeqGAAeqKRLTta(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004AC9 RID: 19145 RVA: 0x0001B864 File Offset: 0x00019A64
			public cHfLOrYEoQFlPSeqGAAeqKRLTta(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700176E RID: 5998
			// (get) Token: 0x06004ACA RID: 19146 RVA: 0x00156054 File Offset: 0x00154254
			// (set) Token: 0x06004ACB RID: 19147 RVA: 0x0001B86D File Offset: 0x00019A6D
			public unsafe ControllerMapSaveData NuVnrlTavvGYEgMZhwgjSLwilSSG
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerMapSaveData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700176F RID: 5999
			// (get) Token: 0x06004ACC RID: 19148 RVA: 0x00156084 File Offset: 0x00154284
			// (set) Token: 0x06004ACD RID: 19149 RVA: 0x0001B88C File Offset: 0x00019A8C
			public unsafe int NsLEWIBMBVGSwXePCZaULRETkiZ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ)) = value;
				}
			}

			// Token: 0x17001770 RID: 6000
			// (get) Token: 0x06004ACE RID: 19150 RVA: 0x001560AC File Offset: 0x001542AC
			// (set) Token: 0x06004ACF RID: 19151 RVA: 0x0001B8A7 File Offset: 0x00019AA7
			public unsafe int wNSJsQuOfbQPTCkuxzljZjIjmsi
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi)) = value;
				}
			}

			// Token: 0x17001771 RID: 6001
			// (get) Token: 0x06004AD0 RID: 19152 RVA: 0x001560D4 File Offset: 0x001542D4
			// (set) Token: 0x06004AD1 RID: 19153 RVA: 0x0001B8C2 File Offset: 0x00019AC2
			public PlayerSaveData HbFBVXVdulMdGSmvVCgeOcAyoyn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn);
					return new PlayerSaveData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayerSaveData>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PlayerSaveData>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001772 RID: 6002
			// (get) Token: 0x06004AD2 RID: 19154 RVA: 0x00156104 File Offset: 0x00154304
			// (set) Token: 0x06004AD3 RID: 19155 RVA: 0x0001B8F0 File Offset: 0x00019AF0
			public PlayerSaveData HZhKrhGbTaOkiEzaRhgUZyFviFE
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta.NativeFieldInfoPtr_HZhKrhGbTaOkiEzaRhgUZyFviFE);
					return new PlayerSaveData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayerSaveData>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta.NativeFieldInfoPtr_HZhKrhGbTaOkiEzaRhgUZyFviFE), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PlayerSaveData>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001773 RID: 6003
			// (get) Token: 0x06004AD4 RID: 19156 RVA: 0x00156134 File Offset: 0x00154334
			// (set) Token: 0x06004AD5 RID: 19157 RVA: 0x0001B91E File Offset: 0x00019B1E
			public unsafe int kUBcJcFfgoKKiApkBmiZbFhcTlkZ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta.NativeFieldInfoPtr_kUBcJcFfgoKKiApkBmiZbFhcTlkZ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta.NativeFieldInfoPtr_kUBcJcFfgoKKiApkBmiZbFhcTlkZ)) = value;
				}
			}

			// Token: 0x17001774 RID: 6004
			// (get) Token: 0x06004AD6 RID: 19158 RVA: 0x0015615C File Offset: 0x0015435C
			// (set) Token: 0x06004AD7 RID: 19159 RVA: 0x0001B939 File Offset: 0x00019B39
			public unsafe int hAStVwJVMBBvRtdqjAJKGEgHfju
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta.NativeFieldInfoPtr_hAStVwJVMBBvRtdqjAJKGEgHfju);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta.NativeFieldInfoPtr_hAStVwJVMBBvRtdqjAJKGEgHfju)) = value;
				}
			}

			// Token: 0x17001775 RID: 6005
			// (get) Token: 0x06004AD8 RID: 19160 RVA: 0x00156184 File Offset: 0x00154384
			// (set) Token: 0x06004AD9 RID: 19161 RVA: 0x0001B954 File Offset: 0x00019B54
			public unsafe int jNBFAEjkzgoEDtIarJoUKhfdWwep
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta.NativeFieldInfoPtr_jNBFAEjkzgoEDtIarJoUKhfdWwep);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta.NativeFieldInfoPtr_jNBFAEjkzgoEDtIarJoUKhfdWwep)) = value;
				}
			}

			// Token: 0x17001776 RID: 6006
			// (get) Token: 0x06004ADA RID: 19162 RVA: 0x001561AC File Offset: 0x001543AC
			// (set) Token: 0x06004ADB RID: 19163 RVA: 0x0001B96F File Offset: 0x00019B6F
			public unsafe int TFDsBsaKeCHdrWhCBRqkvZjrFnV
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta.NativeFieldInfoPtr_TFDsBsaKeCHdrWhCBRqkvZjrFnV);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveData.cHfLOrYEoQFlPSeqGAAeqKRLTta.NativeFieldInfoPtr_TFDsBsaKeCHdrWhCBRqkvZjrFnV)) = value;
				}
			}

			// Token: 0x04003C7B RID: 15483
			private static readonly IntPtr NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG;

			// Token: 0x04003C7C RID: 15484
			private static readonly IntPtr NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ;

			// Token: 0x04003C7D RID: 15485
			private static readonly IntPtr NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi;

			// Token: 0x04003C7E RID: 15486
			private static readonly IntPtr NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn;

			// Token: 0x04003C7F RID: 15487
			private static readonly IntPtr NativeFieldInfoPtr_HZhKrhGbTaOkiEzaRhgUZyFviFE;

			// Token: 0x04003C80 RID: 15488
			private static readonly IntPtr NativeFieldInfoPtr_kUBcJcFfgoKKiApkBmiZbFhcTlkZ;

			// Token: 0x04003C81 RID: 15489
			private static readonly IntPtr NativeFieldInfoPtr_hAStVwJVMBBvRtdqjAJKGEgHfju;

			// Token: 0x04003C82 RID: 15490
			private static readonly IntPtr NativeFieldInfoPtr_jNBFAEjkzgoEDtIarJoUKhfdWwep;

			// Token: 0x04003C83 RID: 15491
			private static readonly IntPtr NativeFieldInfoPtr_TFDsBsaKeCHdrWhCBRqkvZjrFnV;

			// Token: 0x04003C84 RID: 15492
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_ControllerMapSaveData__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ControllerMapSaveData_0;

			// Token: 0x04003C85 RID: 15493
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x04003C86 RID: 15494
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003C87 RID: 15495
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_ControllerMapSaveData__get_Current_Private_Virtual_Final_New_get_ControllerMapSaveData_0;

			// Token: 0x04003C88 RID: 15496
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003C89 RID: 15497
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003C8A RID: 15498
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003C8B RID: 15499
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
		}
	}
}
