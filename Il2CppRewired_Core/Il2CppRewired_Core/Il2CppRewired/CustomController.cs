using System;
using Il2Cpp;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired
{
	// Token: 0x02000060 RID: 96
	public sealed class CustomController : ControllerWithAxes
	{
		// Token: 0x06000E2F RID: 3631 RVA: 0x0005FFC0 File Offset: 0x0005E1C0
		// Note: this type is marked as 'beforefieldinit'.
		static CustomController()
		{
			Il2CppClassPointerStore<CustomController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "CustomController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomController>.NativeClassPtr);
			CustomController.NativeFieldInfoPtr_yeyHutzWTBEJjolfblRPvdpJcst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomController>.NativeClassPtr, "yeyHutzWTBEJjolfblRPvdpJcst");
			CustomController.NativeFieldInfoPtr_JmanxZhdoDxkdAZNUZSVIqutbES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomController>.NativeClassPtr, "JmanxZhdoDxkdAZNUZSVIqutbES");
			CustomController.NativeFieldInfoPtr_rlCYeQMHFGmJCCGSJYGdrPzsACD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomController>.NativeClassPtr, "rlCYeQMHFGmJCCGSJYGdrPzsACD");
			CustomController.NativeFieldInfoPtr_yddPOqFsfUPPololSsmuSowvKto = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomController>.NativeClassPtr, "yddPOqFsfUPPololSsmuSowvKto");
			CustomController.NativeFieldInfoPtr_eQJBlDDZPAKtTdYDEAPfLSqyIfwd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomController>.NativeClassPtr, "eQJBlDDZPAKtTdYDEAPfLSqyIfwd");
			CustomController.NativeMethodInfoPtr_get_sourceControllerId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController>.NativeClassPtr, 100665482);
			CustomController.NativeMethodInfoPtr_get_deviceInstanceGuid_Public_Virtual_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController>.NativeClassPtr, 100665483);
			CustomController.NativeMethodInfoPtr__ctor_Internal_Void_ZgRDTijhtRlqiGNmMEbDYFdnvgEO_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController>.NativeClassPtr, 100665484);
			CustomController.NativeMethodInfoPtr__ctor_Private_Void_Int32_Int32_Guid_InputSource_String_String_String_Int32_Int32_HardwareControllerMap_Game_Extension_ControllerDataUpdater_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController>.NativeClassPtr, 100665485);
			CustomController.NativeMethodInfoPtr_dMGpQXdGVtBibJVnNPdLAdnODsZX_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController>.NativeClassPtr, 100665486);
			CustomController.NativeMethodInfoPtr_SetAxisValue_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController>.NativeClassPtr, 100665487);
			CustomController.NativeMethodInfoPtr_SetAxisValue_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController>.NativeClassPtr, 100665488);
			CustomController.NativeMethodInfoPtr_SetAxisValueById_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController>.NativeClassPtr, 100665489);
			CustomController.NativeMethodInfoPtr_SetButtonValue_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController>.NativeClassPtr, 100665490);
			CustomController.NativeMethodInfoPtr_SetButtonValue_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController>.NativeClassPtr, 100665491);
			CustomController.NativeMethodInfoPtr_SetButtonValueById_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController>.NativeClassPtr, 100665492);
			CustomController.NativeMethodInfoPtr_SetAxisUpdateCallback_Public_Void_Func_2_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController>.NativeClassPtr, 100665493);
			CustomController.NativeMethodInfoPtr_SetButtonUpdateCallback_Public_Void_Func_2_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController>.NativeClassPtr, 100665494);
			CustomController.NativeMethodInfoPtr_ClearAxisValue_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController>.NativeClassPtr, 100665495);
			CustomController.NativeMethodInfoPtr_ClearAxisValue_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController>.NativeClassPtr, 100665496);
			CustomController.NativeMethodInfoPtr_ClearAxisValueById_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController>.NativeClassPtr, 100665497);
			CustomController.NativeMethodInfoPtr_ClearButtonValue_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController>.NativeClassPtr, 100665498);
			CustomController.NativeMethodInfoPtr_ClearButtonValue_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController>.NativeClassPtr, 100665499);
			CustomController.NativeMethodInfoPtr_ClearButtonValueById_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController>.NativeClassPtr, 100665500);
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06000E30 RID: 3632 RVA: 0x000601D0 File Offset: 0x0005E3D0
		public unsafe int sourceControllerId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.NativeMethodInfoPtr_get_sourceControllerId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06000E31 RID: 3633 RVA: 0x0006020C File Offset: 0x0005E40C
		public unsafe override Guid deviceInstanceGuid
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255079, XrefRangeEnd = 255090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.NativeMethodInfoPtr_get_deviceInstanceGuid_Public_Virtual_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E32 RID: 3634 RVA: 0x00060248 File Offset: 0x0005E448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255090, XrefRangeEnd = 255095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomController(ZgRDTijhtRlqiGNmMEbDYFdnvgEO data)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomController>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.NativeMethodInfoPtr__ctor_Internal_Void_ZgRDTijhtRlqiGNmMEbDYFdnvgEO_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E33 RID: 3635 RVA: 0x00060294 File Offset: 0x0005E494
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 255132, RefRangeEnd = 255134, XrefRangeStart = 255095, XrefRangeEnd = 255132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomController(int controllerId, int sourceControllerId, Guid hardwareTypeGuid, InputSource inputSource, string name, string hardwareName, string hardwareIdentifier, int axisCount, int buttonCount, HardwareControllerMap_Game hardwareMap, Controller.Extension extension, ControllerDataUpdater dataUpdater)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomController>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceControllerId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hardwareTypeGuid;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputSource;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(hardwareName);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(hardwareIdentifier);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisCount;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buttonCount;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hardwareMap);
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(extension);
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dataUpdater);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.NativeMethodInfoPtr__ctor_Private_Void_Int32_Int32_Guid_InputSource_String_String_String_Int32_Int32_HardwareControllerMap_Game_Extension_ControllerDataUpdater_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E34 RID: 3636 RVA: 0x00060398 File Offset: 0x0005E598
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 255140, RefRangeEnd = 255141, XrefRangeStart = 255134, XrefRangeEnd = 255140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void dMGpQXdGVtBibJVnNPdLAdnODsZX()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.NativeMethodInfoPtr_dMGpQXdGVtBibJVnNPdLAdnODsZX_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x000603CC File Offset: 0x0005E5CC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 255159, RefRangeEnd = 255165, XrefRangeStart = 255141, XrefRangeEnd = 255159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAxisValue(int index, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.NativeMethodInfoPtr_SetAxisValue_Public_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E36 RID: 3638 RVA: 0x00060418 File Offset: 0x0005E618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255165, XrefRangeEnd = 255174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAxisValue(string elementName, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(elementName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.NativeMethodInfoPtr_SetAxisValue_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E37 RID: 3639 RVA: 0x00060468 File Offset: 0x0005E668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255174, XrefRangeEnd = 255193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAxisValueById(int elementId, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elementId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.NativeMethodInfoPtr_SetAxisValueById_Public_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E38 RID: 3640 RVA: 0x000604B4 File Offset: 0x0005E6B4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 255211, RefRangeEnd = 255215, XrefRangeStart = 255193, XrefRangeEnd = 255211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetButtonValue(int index, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.NativeMethodInfoPtr_SetButtonValue_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x00060500 File Offset: 0x0005E700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255215, XrefRangeEnd = 255236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetButtonValue(string elementName, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(elementName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.NativeMethodInfoPtr_SetButtonValue_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x00060550 File Offset: 0x0005E750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255236, XrefRangeEnd = 255255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetButtonValueById(int elementId, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elementId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.NativeMethodInfoPtr_SetButtonValueById_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x0006059C File Offset: 0x0005E79C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255255, XrefRangeEnd = 255259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAxisUpdateCallback(Func<int, float> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.NativeMethodInfoPtr_SetAxisUpdateCallback_Public_Void_Func_2_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x000605E0 File Offset: 0x0005E7E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255259, XrefRangeEnd = 255263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetButtonUpdateCallback(Func<int, bool> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.NativeMethodInfoPtr_SetButtonUpdateCallback_Public_Void_Func_2_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E3D RID: 3645 RVA: 0x00060624 File Offset: 0x0005E824
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 255272, RefRangeEnd = 255275, XrefRangeStart = 255263, XrefRangeEnd = 255272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearAxisValue(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.NativeMethodInfoPtr_ClearAxisValue_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E3E RID: 3646 RVA: 0x00060664 File Offset: 0x0005E864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255275, XrefRangeEnd = 255285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearAxisValue(string elementName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(elementName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.NativeMethodInfoPtr_ClearAxisValue_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E3F RID: 3647 RVA: 0x000606A8 File Offset: 0x0005E8A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255285, XrefRangeEnd = 255303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearAxisValueById(int elementId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elementId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.NativeMethodInfoPtr_ClearAxisValueById_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E40 RID: 3648 RVA: 0x000606E8 File Offset: 0x0005E8E8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 255310, RefRangeEnd = 255313, XrefRangeStart = 255303, XrefRangeEnd = 255310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearButtonValue(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.NativeMethodInfoPtr_ClearButtonValue_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E41 RID: 3649 RVA: 0x00060728 File Offset: 0x0005E928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255313, XrefRangeEnd = 255323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearButtonValue(string elementName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(elementName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.NativeMethodInfoPtr_ClearButtonValue_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E42 RID: 3650 RVA: 0x0006076C File Offset: 0x0005E96C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255323, XrefRangeEnd = 255341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearButtonValueById(int elementId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elementId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.NativeMethodInfoPtr_ClearButtonValueById_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E43 RID: 3651 RVA: 0x00006E34 File Offset: 0x00005034
		public CustomController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06000E44 RID: 3652 RVA: 0x000607AC File Offset: 0x0005E9AC
		// (set) Token: 0x06000E45 RID: 3653 RVA: 0x00006E3D File Offset: 0x0000503D
		public unsafe int yeyHutzWTBEJjolfblRPvdpJcst
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController.NativeFieldInfoPtr_yeyHutzWTBEJjolfblRPvdpJcst);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController.NativeFieldInfoPtr_yeyHutzWTBEJjolfblRPvdpJcst)) = value;
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06000E46 RID: 3654 RVA: 0x000607D4 File Offset: 0x0005E9D4
		// (set) Token: 0x06000E47 RID: 3655 RVA: 0x00006E58 File Offset: 0x00005058
		public unsafe Func<int, float> JmanxZhdoDxkdAZNUZSVIqutbES
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController.NativeFieldInfoPtr_JmanxZhdoDxkdAZNUZSVIqutbES);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController.NativeFieldInfoPtr_JmanxZhdoDxkdAZNUZSVIqutbES), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06000E48 RID: 3656 RVA: 0x00060804 File Offset: 0x0005EA04
		// (set) Token: 0x06000E49 RID: 3657 RVA: 0x00006E77 File Offset: 0x00005077
		public unsafe Func<int, bool> rlCYeQMHFGmJCCGSJYGdrPzsACD
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController.NativeFieldInfoPtr_rlCYeQMHFGmJCCGSJYGdrPzsACD);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController.NativeFieldInfoPtr_rlCYeQMHFGmJCCGSJYGdrPzsACD), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06000E4A RID: 3658 RVA: 0x00060834 File Offset: 0x0005EA34
		// (set) Token: 0x06000E4B RID: 3659 RVA: 0x00006E96 File Offset: 0x00005096
		public unsafe bool yddPOqFsfUPPololSsmuSowvKto
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController.NativeFieldInfoPtr_yddPOqFsfUPPololSsmuSowvKto);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController.NativeFieldInfoPtr_yddPOqFsfUPPololSsmuSowvKto)) = value;
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06000E4C RID: 3660 RVA: 0x0006085C File Offset: 0x0005EA5C
		// (set) Token: 0x06000E4D RID: 3661 RVA: 0x00006EB1 File Offset: 0x000050B1
		public unsafe Guid eQJBlDDZPAKtTdYDEAPfLSqyIfwd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController.NativeFieldInfoPtr_eQJBlDDZPAKtTdYDEAPfLSqyIfwd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController.NativeFieldInfoPtr_eQJBlDDZPAKtTdYDEAPfLSqyIfwd)) = value;
			}
		}

		// Token: 0x04000AD7 RID: 2775
		private static readonly IntPtr NativeFieldInfoPtr_yeyHutzWTBEJjolfblRPvdpJcst;

		// Token: 0x04000AD8 RID: 2776
		private static readonly IntPtr NativeFieldInfoPtr_JmanxZhdoDxkdAZNUZSVIqutbES;

		// Token: 0x04000AD9 RID: 2777
		private static readonly IntPtr NativeFieldInfoPtr_rlCYeQMHFGmJCCGSJYGdrPzsACD;

		// Token: 0x04000ADA RID: 2778
		private static readonly IntPtr NativeFieldInfoPtr_yddPOqFsfUPPololSsmuSowvKto;

		// Token: 0x04000ADB RID: 2779
		private static readonly IntPtr NativeFieldInfoPtr_eQJBlDDZPAKtTdYDEAPfLSqyIfwd;

		// Token: 0x04000ADC RID: 2780
		private static readonly IntPtr NativeMethodInfoPtr_get_sourceControllerId_Public_get_Int32_0;

		// Token: 0x04000ADD RID: 2781
		private static readonly IntPtr NativeMethodInfoPtr_get_deviceInstanceGuid_Public_Virtual_get_Guid_0;

		// Token: 0x04000ADE RID: 2782
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ZgRDTijhtRlqiGNmMEbDYFdnvgEO_0;

		// Token: 0x04000ADF RID: 2783
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Int32_Int32_Guid_InputSource_String_String_String_Int32_Int32_HardwareControllerMap_Game_Extension_ControllerDataUpdater_0;

		// Token: 0x04000AE0 RID: 2784
		private static readonly IntPtr NativeMethodInfoPtr_dMGpQXdGVtBibJVnNPdLAdnODsZX_Internal_Void_0;

		// Token: 0x04000AE1 RID: 2785
		private static readonly IntPtr NativeMethodInfoPtr_SetAxisValue_Public_Void_Int32_Single_0;

		// Token: 0x04000AE2 RID: 2786
		private static readonly IntPtr NativeMethodInfoPtr_SetAxisValue_Public_Void_String_Single_0;

		// Token: 0x04000AE3 RID: 2787
		private static readonly IntPtr NativeMethodInfoPtr_SetAxisValueById_Public_Void_Int32_Single_0;

		// Token: 0x04000AE4 RID: 2788
		private static readonly IntPtr NativeMethodInfoPtr_SetButtonValue_Public_Void_Int32_Boolean_0;

		// Token: 0x04000AE5 RID: 2789
		private static readonly IntPtr NativeMethodInfoPtr_SetButtonValue_Public_Void_String_Boolean_0;

		// Token: 0x04000AE6 RID: 2790
		private static readonly IntPtr NativeMethodInfoPtr_SetButtonValueById_Public_Void_Int32_Boolean_0;

		// Token: 0x04000AE7 RID: 2791
		private static readonly IntPtr NativeMethodInfoPtr_SetAxisUpdateCallback_Public_Void_Func_2_Int32_Single_0;

		// Token: 0x04000AE8 RID: 2792
		private static readonly IntPtr NativeMethodInfoPtr_SetButtonUpdateCallback_Public_Void_Func_2_Int32_Boolean_0;

		// Token: 0x04000AE9 RID: 2793
		private static readonly IntPtr NativeMethodInfoPtr_ClearAxisValue_Public_Void_Int32_0;

		// Token: 0x04000AEA RID: 2794
		private static readonly IntPtr NativeMethodInfoPtr_ClearAxisValue_Public_Void_String_0;

		// Token: 0x04000AEB RID: 2795
		private static readonly IntPtr NativeMethodInfoPtr_ClearAxisValueById_Public_Void_Int32_0;

		// Token: 0x04000AEC RID: 2796
		private static readonly IntPtr NativeMethodInfoPtr_ClearButtonValue_Public_Void_Int32_0;

		// Token: 0x04000AED RID: 2797
		private static readonly IntPtr NativeMethodInfoPtr_ClearButtonValue_Public_Void_String_0;

		// Token: 0x04000AEE RID: 2798
		private static readonly IntPtr NativeMethodInfoPtr_ClearButtonValueById_Public_Void_Int32_0;
	}
}
