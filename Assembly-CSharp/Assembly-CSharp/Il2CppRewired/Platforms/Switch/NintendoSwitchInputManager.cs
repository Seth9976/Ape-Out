using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Il2CppRewired.Platforms.Switch
{
	// Token: 0x020001E4 RID: 484
	public sealed class NintendoSwitchInputManager : MonoBehaviour
	{
		// Token: 0x06003826 RID: 14374 RVA: 0x000D039C File Offset: 0x000CE59C
		// Note: this type is marked as 'beforefieldinit'.
		static NintendoSwitchInputManager()
		{
			Il2CppClassPointerStore<NintendoSwitchInputManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Platforms.Switch", "NintendoSwitchInputManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NintendoSwitchInputManager>.NativeClassPtr);
			NintendoSwitchInputManager.NativeFieldInfoPtr__userData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager>.NativeClassPtr, "_userData");
			NintendoSwitchInputManager.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IExternalInputManager_Initialize_Private_Virtual_Final_New_Object_Platform_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager>.NativeClassPtr, 100667781);
			NintendoSwitchInputManager.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IExternalInputManager_Deinitialize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager>.NativeClassPtr, 100667782);
			NintendoSwitchInputManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager>.NativeClassPtr, 100667783);
		}

		// Token: 0x06003827 RID: 14375 RVA: 0x000D041C File Offset: 0x000CE61C
		[CallerCount(0)]
		public unsafe global::Il2CppSystem.Object Rewired_Utils_Interfaces_IExternalInputManager_Initialize(Platform platform, global::Il2CppSystem.Object configVars)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref platform;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(configVars);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IExternalInputManager_Initialize_Private_Virtual_Final_New_Object_Platform_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
		}

		// Token: 0x06003828 RID: 14376 RVA: 0x000D047C File Offset: 0x000CE67C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Rewired_Utils_Interfaces_IExternalInputManager_Deinitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IExternalInputManager_Deinitialize_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003829 RID: 14377 RVA: 0x000D04B0 File Offset: 0x000CE6B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87354, XrefRangeEnd = 87361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NintendoSwitchInputManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NintendoSwitchInputManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600382A RID: 14378 RVA: 0x0002436E File Offset: 0x0002256E
		public NintendoSwitchInputManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700159A RID: 5530
		// (get) Token: 0x0600382B RID: 14379 RVA: 0x000D04EC File Offset: 0x000CE6EC
		// (set) Token: 0x0600382C RID: 14380 RVA: 0x00024377 File Offset: 0x00022577
		public unsafe NintendoSwitchInputManager.UserData _userData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.NativeFieldInfoPtr__userData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NintendoSwitchInputManager.UserData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.NativeFieldInfoPtr__userData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400215C RID: 8540
		private static readonly IntPtr NativeFieldInfoPtr__userData;

		// Token: 0x0400215D RID: 8541
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_Utils_Interfaces_IExternalInputManager_Initialize_Private_Virtual_Final_New_Object_Platform_Object_0;

		// Token: 0x0400215E RID: 8542
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_Utils_Interfaces_IExternalInputManager_Deinitialize_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400215F RID: 8543
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000357 RID: 855
		[Serializable]
		public class UserData : global::Il2CppSystem.Object
		{
			// Token: 0x060053CA RID: 21450 RVA: 0x0012FBBC File Offset: 0x0012DDBC
			// Note: this type is marked as 'beforefieldinit'.
			static UserData()
			{
				Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NintendoSwitchInputManager>.NativeClassPtr, "UserData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr);
				NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__allowedNpadStyles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, "_allowedNpadStyles");
				NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__joyConGripStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, "_joyConGripStyle");
				NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__adjustIMUsForGripStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, "_adjustIMUsForGripStyle");
				NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__handheldActivationMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, "_handheldActivationMode");
				NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__assignJoysticksByNpadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, "_assignJoysticksByNpadId");
				NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, "_npadNo1");
				NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, "_npadNo2");
				NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, "_npadNo3");
				NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, "_npadNo4");
				NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, "_npadNo5");
				NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, "_npadNo6");
				NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, "_npadNo7");
				NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, "_npadNo8");
				NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadHandheld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, "_npadHandheld");
				NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__debugPad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, "_debugPad");
				NintendoSwitchInputManager.UserData.NativeFieldInfoPtr___delegates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, "__delegates");
				NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_allowedNpadStyles_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100667784);
				NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_set_allowedNpadStyles_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100667785);
				NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_joyConGripStyle_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100667786);
				NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_set_joyConGripStyle_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100667787);
				NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_adjustIMUsForGripStyle_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100667788);
				NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_set_adjustIMUsForGripStyle_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100667789);
				NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_handheldActivationMode_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100667790);
				NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_set_handheldActivationMode_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100667791);
				NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_assignJoysticksByNpadId_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100667792);
				NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_set_assignJoysticksByNpadId_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100667793);
				NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_npadNo1_Private_get_NpadSettings_Internal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100667794);
				NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_npadNo2_Private_get_NpadSettings_Internal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100667795);
				NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_npadNo3_Private_get_NpadSettings_Internal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100667796);
				NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_npadNo4_Private_get_NpadSettings_Internal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100667797);
				NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_npadNo5_Private_get_NpadSettings_Internal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100667798);
				NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_npadNo6_Private_get_NpadSettings_Internal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100667799);
				NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_npadNo7_Private_get_NpadSettings_Internal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100667800);
				NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_npadNo8_Private_get_NpadSettings_Internal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100667801);
				NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_npadHandheld_Private_get_NpadSettings_Internal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100667802);
				NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_debugPad_Public_get_DebugPadSettings_Internal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100667803);
				NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_delegates_Private_get_Dictionary_2_Int32_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100667804);
				NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TryGetValue_Private_Virtual_Final_New_Boolean_Int32_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100667805);
				NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TrySetValue_Private_Virtual_Final_New_Boolean_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100667806);
				NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100667807);
				NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__52_0_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100667808);
				NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__52_1_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100667809);
				NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__52_2_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100667810);
				NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__52_3_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100667811);
				NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__52_4_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100667812);
				NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__52_5_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100667813);
				NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__52_6_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100667814);
				NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__52_7_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100667815);
				NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__52_8_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100667816);
				NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__52_9_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100667817);
				NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__52_10_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100667818);
				NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__52_11_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100667819);
				NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__52_12_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100667820);
				NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__52_13_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100667821);
				NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__52_14_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100667822);
				NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__52_15_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100667823);
				NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__52_16_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100667824);
				NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__52_17_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100667825);
				NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__52_18_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100667826);
				NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__52_19_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100667827);
			}

			// Token: 0x17001E9C RID: 7836
			// (get) Token: 0x060053CB RID: 21451 RVA: 0x00130098 File Offset: 0x0012E298
			// (set) Token: 0x060053CC RID: 21452 RVA: 0x001300D4 File Offset: 0x0012E2D4
			public unsafe int allowedNpadStyles
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_allowedNpadStyles_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_set_allowedNpadStyles_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001E9D RID: 7837
			// (get) Token: 0x060053CD RID: 21453 RVA: 0x00130114 File Offset: 0x0012E314
			// (set) Token: 0x060053CE RID: 21454 RVA: 0x00130150 File Offset: 0x0012E350
			public unsafe int joyConGripStyle
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_joyConGripStyle_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_set_joyConGripStyle_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001E9E RID: 7838
			// (get) Token: 0x060053CF RID: 21455 RVA: 0x00130190 File Offset: 0x0012E390
			// (set) Token: 0x060053D0 RID: 21456 RVA: 0x001301CC File Offset: 0x0012E3CC
			public unsafe bool adjustIMUsForGripStyle
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_adjustIMUsForGripStyle_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_set_adjustIMUsForGripStyle_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001E9F RID: 7839
			// (get) Token: 0x060053D1 RID: 21457 RVA: 0x0013020C File Offset: 0x0012E40C
			// (set) Token: 0x060053D2 RID: 21458 RVA: 0x00130248 File Offset: 0x0012E448
			public unsafe int handheldActivationMode
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_handheldActivationMode_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_set_handheldActivationMode_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001EA0 RID: 7840
			// (get) Token: 0x060053D3 RID: 21459 RVA: 0x00130288 File Offset: 0x0012E488
			// (set) Token: 0x060053D4 RID: 21460 RVA: 0x001302C4 File Offset: 0x0012E4C4
			public unsafe bool assignJoysticksByNpadId
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_assignJoysticksByNpadId_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_set_assignJoysticksByNpadId_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001EA1 RID: 7841
			// (get) Token: 0x060053D5 RID: 21461 RVA: 0x00130304 File Offset: 0x0012E504
			public unsafe NintendoSwitchInputManager.NpadSettings_Internal npadNo1
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_npadNo1_Private_get_NpadSettings_Internal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<NintendoSwitchInputManager.NpadSettings_Internal>(intPtr3) : null;
				}
			}

			// Token: 0x17001EA2 RID: 7842
			// (get) Token: 0x060053D6 RID: 21462 RVA: 0x00130344 File Offset: 0x0012E544
			public unsafe NintendoSwitchInputManager.NpadSettings_Internal npadNo2
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_npadNo2_Private_get_NpadSettings_Internal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<NintendoSwitchInputManager.NpadSettings_Internal>(intPtr3) : null;
				}
			}

			// Token: 0x17001EA3 RID: 7843
			// (get) Token: 0x060053D7 RID: 21463 RVA: 0x00130384 File Offset: 0x0012E584
			public unsafe NintendoSwitchInputManager.NpadSettings_Internal npadNo3
			{
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 621, RefRangeEnd = 626, XrefRangeStart = 621, XrefRangeEnd = 626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_npadNo3_Private_get_NpadSettings_Internal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<NintendoSwitchInputManager.NpadSettings_Internal>(intPtr3) : null;
				}
			}

			// Token: 0x17001EA4 RID: 7844
			// (get) Token: 0x060053D8 RID: 21464 RVA: 0x001303C4 File Offset: 0x0012E5C4
			public unsafe NintendoSwitchInputManager.NpadSettings_Internal npadNo4
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_npadNo4_Private_get_NpadSettings_Internal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<NintendoSwitchInputManager.NpadSettings_Internal>(intPtr3) : null;
				}
			}

			// Token: 0x17001EA5 RID: 7845
			// (get) Token: 0x060053D9 RID: 21465 RVA: 0x00130404 File Offset: 0x0012E604
			public unsafe NintendoSwitchInputManager.NpadSettings_Internal npadNo5
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_npadNo5_Private_get_NpadSettings_Internal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<NintendoSwitchInputManager.NpadSettings_Internal>(intPtr3) : null;
				}
			}

			// Token: 0x17001EA6 RID: 7846
			// (get) Token: 0x060053DA RID: 21466 RVA: 0x00130444 File Offset: 0x0012E644
			public unsafe NintendoSwitchInputManager.NpadSettings_Internal npadNo6
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_npadNo6_Private_get_NpadSettings_Internal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<NintendoSwitchInputManager.NpadSettings_Internal>(intPtr3) : null;
				}
			}

			// Token: 0x17001EA7 RID: 7847
			// (get) Token: 0x060053DB RID: 21467 RVA: 0x00130484 File Offset: 0x0012E684
			public unsafe NintendoSwitchInputManager.NpadSettings_Internal npadNo7
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_npadNo7_Private_get_NpadSettings_Internal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<NintendoSwitchInputManager.NpadSettings_Internal>(intPtr3) : null;
				}
			}

			// Token: 0x17001EA8 RID: 7848
			// (get) Token: 0x060053DC RID: 21468 RVA: 0x001304C4 File Offset: 0x0012E6C4
			public unsafe NintendoSwitchInputManager.NpadSettings_Internal npadNo8
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_npadNo8_Private_get_NpadSettings_Internal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<NintendoSwitchInputManager.NpadSettings_Internal>(intPtr3) : null;
				}
			}

			// Token: 0x17001EA9 RID: 7849
			// (get) Token: 0x060053DD RID: 21469 RVA: 0x00130504 File Offset: 0x0012E704
			public unsafe NintendoSwitchInputManager.NpadSettings_Internal npadHandheld
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_npadHandheld_Private_get_NpadSettings_Internal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<NintendoSwitchInputManager.NpadSettings_Internal>(intPtr3) : null;
				}
			}

			// Token: 0x17001EAA RID: 7850
			// (get) Token: 0x060053DE RID: 21470 RVA: 0x00130544 File Offset: 0x0012E744
			public unsafe NintendoSwitchInputManager.DebugPadSettings_Internal debugPad
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_debugPad_Public_get_DebugPadSettings_Internal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<NintendoSwitchInputManager.DebugPadSettings_Internal>(intPtr3) : null;
				}
			}

			// Token: 0x17001EAB RID: 7851
			// (get) Token: 0x060053DF RID: 21471 RVA: 0x00130584 File Offset: 0x0012E784
			public unsafe Dictionary<int, Il2CppReferenceArray<global::Il2CppSystem.Object>> delegates
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 87190, RefRangeEnd = 87192, XrefRangeStart = 87008, XrefRangeEnd = 87190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_delegates_Private_get_Dictionary_2_Int32_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Il2CppReferenceArray<global::Il2CppSystem.Object>>>(intPtr3) : null;
				}
			}

			// Token: 0x060053E0 RID: 21472 RVA: 0x001305C4 File Offset: 0x0012E7C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87192, XrefRangeEnd = 87197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool Rewired_Utils_Interfaces_IKeyedData_System_Int32__TryGetValue<T>(int key, out T value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref key;
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr;
				IntPtr intPtr2;
				if (!typeof(T).IsValueType)
				{
					intPtr = 0;
					intPtr2 = &intPtr;
				}
				else
				{
					intPtr2 = ref value;
				}
				ptr2 = intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.MethodInfoStoreGeneric_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TryGetValue_Private_Virtual_Final_New_Boolean_Int32_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				if (!typeof(T).IsValueType)
				{
					IntPtr intPtr5 = intPtr;
					value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
				}
				return *IL2CPP.il2cpp_object_unbox(intPtr3);
			}

			// Token: 0x060053E1 RID: 21473 RVA: 0x0013065C File Offset: 0x0012E85C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87197, XrefRangeEnd = 87202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool Rewired_Utils_Interfaces_IKeyedData_System_Int32__TrySetValue<T>(int key, T value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref key;
				}
				IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					if (!(t is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref value;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.MethodInfoStoreGeneric_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TrySetValue_Private_Virtual_Final_New_Boolean_Int32_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060053E2 RID: 21474 RVA: 0x00130704 File Offset: 0x0012E904
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 87224, RefRangeEnd = 87225, XrefRangeStart = 87202, XrefRangeEnd = 87224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UserData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060053E3 RID: 21475 RVA: 0x00130740 File Offset: 0x0012E940
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _get_delegates_b__52_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__52_0_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060053E4 RID: 21476 RVA: 0x0013077C File Offset: 0x0012E97C
			[CallerCount(0)]
			public unsafe void _get_delegates_b__52_1(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__52_1_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060053E5 RID: 21477 RVA: 0x001307BC File Offset: 0x0012E9BC
			[CallerCount(0)]
			public unsafe int _get_delegates_b__52_2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__52_2_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060053E6 RID: 21478 RVA: 0x001307F8 File Offset: 0x0012E9F8
			[CallerCount(0)]
			public unsafe void _get_delegates_b__52_3(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__52_3_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060053E7 RID: 21479 RVA: 0x00130838 File Offset: 0x0012EA38
			[CallerCount(0)]
			public unsafe bool _get_delegates_b__52_4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__52_4_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060053E8 RID: 21480 RVA: 0x00130874 File Offset: 0x0012EA74
			[CallerCount(0)]
			public unsafe void _get_delegates_b__52_5(bool x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__52_5_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060053E9 RID: 21481 RVA: 0x001308B4 File Offset: 0x0012EAB4
			[CallerCount(0)]
			public unsafe int _get_delegates_b__52_6()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__52_6_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060053EA RID: 21482 RVA: 0x001308F0 File Offset: 0x0012EAF0
			[CallerCount(0)]
			public unsafe void _get_delegates_b__52_7(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__52_7_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060053EB RID: 21483 RVA: 0x00130930 File Offset: 0x0012EB30
			[CallerCount(0)]
			public unsafe bool _get_delegates_b__52_8()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__52_8_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060053EC RID: 21484 RVA: 0x0013096C File Offset: 0x0012EB6C
			[CallerCount(0)]
			public unsafe void _get_delegates_b__52_9(bool x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__52_9_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060053ED RID: 21485 RVA: 0x001309AC File Offset: 0x0012EBAC
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe global::Il2CppSystem.Object _get_delegates_b__52_10()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__52_10_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}

			// Token: 0x060053EE RID: 21486 RVA: 0x001309EC File Offset: 0x0012EBEC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe global::Il2CppSystem.Object _get_delegates_b__52_11()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__52_11_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}

			// Token: 0x060053EF RID: 21487 RVA: 0x00130A2C File Offset: 0x0012EC2C
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 621, RefRangeEnd = 626, XrefRangeStart = 621, XrefRangeEnd = 626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe global::Il2CppSystem.Object _get_delegates_b__52_12()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__52_12_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}

			// Token: 0x060053F0 RID: 21488 RVA: 0x00130A6C File Offset: 0x0012EC6C
			[CallerCount(0)]
			public unsafe global::Il2CppSystem.Object _get_delegates_b__52_13()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__52_13_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}

			// Token: 0x060053F1 RID: 21489 RVA: 0x00130AAC File Offset: 0x0012ECAC
			[CallerCount(0)]
			public unsafe global::Il2CppSystem.Object _get_delegates_b__52_14()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__52_14_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}

			// Token: 0x060053F2 RID: 21490 RVA: 0x00130AEC File Offset: 0x0012ECEC
			[CallerCount(0)]
			public unsafe global::Il2CppSystem.Object _get_delegates_b__52_15()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__52_15_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}

			// Token: 0x060053F3 RID: 21491 RVA: 0x00130B2C File Offset: 0x0012ED2C
			[CallerCount(0)]
			public unsafe global::Il2CppSystem.Object _get_delegates_b__52_16()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__52_16_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}

			// Token: 0x060053F4 RID: 21492 RVA: 0x00130B6C File Offset: 0x0012ED6C
			[CallerCount(0)]
			public unsafe global::Il2CppSystem.Object _get_delegates_b__52_17()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__52_17_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}

			// Token: 0x060053F5 RID: 21493 RVA: 0x00130BAC File Offset: 0x0012EDAC
			[CallerCount(0)]
			public unsafe global::Il2CppSystem.Object _get_delegates_b__52_18()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__52_18_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}

			// Token: 0x060053F6 RID: 21494 RVA: 0x00130BEC File Offset: 0x0012EDEC
			[CallerCount(0)]
			public unsafe global::Il2CppSystem.Object _get_delegates_b__52_19()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__52_19_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}

			// Token: 0x060053F7 RID: 21495 RVA: 0x00030B7E File Offset: 0x0002ED7E
			public UserData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001E8C RID: 7820
			// (get) Token: 0x060053F8 RID: 21496 RVA: 0x00130C2C File Offset: 0x0012EE2C
			// (set) Token: 0x060053F9 RID: 21497 RVA: 0x00030B87 File Offset: 0x0002ED87
			public unsafe int _allowedNpadStyles
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__allowedNpadStyles);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__allowedNpadStyles)) = value;
				}
			}

			// Token: 0x17001E8D RID: 7821
			// (get) Token: 0x060053FA RID: 21498 RVA: 0x00130C54 File Offset: 0x0012EE54
			// (set) Token: 0x060053FB RID: 21499 RVA: 0x00030BA2 File Offset: 0x0002EDA2
			public unsafe int _joyConGripStyle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__joyConGripStyle);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__joyConGripStyle)) = value;
				}
			}

			// Token: 0x17001E8E RID: 7822
			// (get) Token: 0x060053FC RID: 21500 RVA: 0x00130C7C File Offset: 0x0012EE7C
			// (set) Token: 0x060053FD RID: 21501 RVA: 0x00030BBD File Offset: 0x0002EDBD
			public unsafe bool _adjustIMUsForGripStyle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__adjustIMUsForGripStyle);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__adjustIMUsForGripStyle)) = value;
				}
			}

			// Token: 0x17001E8F RID: 7823
			// (get) Token: 0x060053FE RID: 21502 RVA: 0x00130CA4 File Offset: 0x0012EEA4
			// (set) Token: 0x060053FF RID: 21503 RVA: 0x00030BD8 File Offset: 0x0002EDD8
			public unsafe int _handheldActivationMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__handheldActivationMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__handheldActivationMode)) = value;
				}
			}

			// Token: 0x17001E90 RID: 7824
			// (get) Token: 0x06005400 RID: 21504 RVA: 0x00130CCC File Offset: 0x0012EECC
			// (set) Token: 0x06005401 RID: 21505 RVA: 0x00030BF3 File Offset: 0x0002EDF3
			public unsafe bool _assignJoysticksByNpadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__assignJoysticksByNpadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__assignJoysticksByNpadId)) = value;
				}
			}

			// Token: 0x17001E91 RID: 7825
			// (get) Token: 0x06005402 RID: 21506 RVA: 0x00130CF4 File Offset: 0x0012EEF4
			// (set) Token: 0x06005403 RID: 21507 RVA: 0x00030C0E File Offset: 0x0002EE0E
			public unsafe NintendoSwitchInputManager.NpadSettings_Internal _npadNo1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NintendoSwitchInputManager.NpadSettings_Internal>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001E92 RID: 7826
			// (get) Token: 0x06005404 RID: 21508 RVA: 0x00130D24 File Offset: 0x0012EF24
			// (set) Token: 0x06005405 RID: 21509 RVA: 0x00030C2D File Offset: 0x0002EE2D
			public unsafe NintendoSwitchInputManager.NpadSettings_Internal _npadNo2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NintendoSwitchInputManager.NpadSettings_Internal>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001E93 RID: 7827
			// (get) Token: 0x06005406 RID: 21510 RVA: 0x00130D54 File Offset: 0x0012EF54
			// (set) Token: 0x06005407 RID: 21511 RVA: 0x00030C4C File Offset: 0x0002EE4C
			public unsafe NintendoSwitchInputManager.NpadSettings_Internal _npadNo3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NintendoSwitchInputManager.NpadSettings_Internal>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001E94 RID: 7828
			// (get) Token: 0x06005408 RID: 21512 RVA: 0x00130D84 File Offset: 0x0012EF84
			// (set) Token: 0x06005409 RID: 21513 RVA: 0x00030C6B File Offset: 0x0002EE6B
			public unsafe NintendoSwitchInputManager.NpadSettings_Internal _npadNo4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NintendoSwitchInputManager.NpadSettings_Internal>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001E95 RID: 7829
			// (get) Token: 0x0600540A RID: 21514 RVA: 0x00130DB4 File Offset: 0x0012EFB4
			// (set) Token: 0x0600540B RID: 21515 RVA: 0x00030C8A File Offset: 0x0002EE8A
			public unsafe NintendoSwitchInputManager.NpadSettings_Internal _npadNo5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NintendoSwitchInputManager.NpadSettings_Internal>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001E96 RID: 7830
			// (get) Token: 0x0600540C RID: 21516 RVA: 0x00130DE4 File Offset: 0x0012EFE4
			// (set) Token: 0x0600540D RID: 21517 RVA: 0x00030CA9 File Offset: 0x0002EEA9
			public unsafe NintendoSwitchInputManager.NpadSettings_Internal _npadNo6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NintendoSwitchInputManager.NpadSettings_Internal>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001E97 RID: 7831
			// (get) Token: 0x0600540E RID: 21518 RVA: 0x00130E14 File Offset: 0x0012F014
			// (set) Token: 0x0600540F RID: 21519 RVA: 0x00030CC8 File Offset: 0x0002EEC8
			public unsafe NintendoSwitchInputManager.NpadSettings_Internal _npadNo7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NintendoSwitchInputManager.NpadSettings_Internal>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001E98 RID: 7832
			// (get) Token: 0x06005410 RID: 21520 RVA: 0x00130E44 File Offset: 0x0012F044
			// (set) Token: 0x06005411 RID: 21521 RVA: 0x00030CE7 File Offset: 0x0002EEE7
			public unsafe NintendoSwitchInputManager.NpadSettings_Internal _npadNo8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NintendoSwitchInputManager.NpadSettings_Internal>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001E99 RID: 7833
			// (get) Token: 0x06005412 RID: 21522 RVA: 0x00130E74 File Offset: 0x0012F074
			// (set) Token: 0x06005413 RID: 21523 RVA: 0x00030D06 File Offset: 0x0002EF06
			public unsafe NintendoSwitchInputManager.NpadSettings_Internal _npadHandheld
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadHandheld);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NintendoSwitchInputManager.NpadSettings_Internal>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadHandheld), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001E9A RID: 7834
			// (get) Token: 0x06005414 RID: 21524 RVA: 0x00130EA4 File Offset: 0x0012F0A4
			// (set) Token: 0x06005415 RID: 21525 RVA: 0x00030D25 File Offset: 0x0002EF25
			public unsafe NintendoSwitchInputManager.DebugPadSettings_Internal _debugPad
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__debugPad);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NintendoSwitchInputManager.DebugPadSettings_Internal>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__debugPad), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001E9B RID: 7835
			// (get) Token: 0x06005416 RID: 21526 RVA: 0x00130ED4 File Offset: 0x0012F0D4
			// (set) Token: 0x06005417 RID: 21527 RVA: 0x00030D44 File Offset: 0x0002EF44
			public unsafe Dictionary<int, Il2CppReferenceArray<global::Il2CppSystem.Object>> __delegates
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr___delegates);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Il2CppReferenceArray<global::Il2CppSystem.Object>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr___delegates), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400375C RID: 14172
			private static readonly IntPtr NativeFieldInfoPtr__allowedNpadStyles;

			// Token: 0x0400375D RID: 14173
			private static readonly IntPtr NativeFieldInfoPtr__joyConGripStyle;

			// Token: 0x0400375E RID: 14174
			private static readonly IntPtr NativeFieldInfoPtr__adjustIMUsForGripStyle;

			// Token: 0x0400375F RID: 14175
			private static readonly IntPtr NativeFieldInfoPtr__handheldActivationMode;

			// Token: 0x04003760 RID: 14176
			private static readonly IntPtr NativeFieldInfoPtr__assignJoysticksByNpadId;

			// Token: 0x04003761 RID: 14177
			private static readonly IntPtr NativeFieldInfoPtr__npadNo1;

			// Token: 0x04003762 RID: 14178
			private static readonly IntPtr NativeFieldInfoPtr__npadNo2;

			// Token: 0x04003763 RID: 14179
			private static readonly IntPtr NativeFieldInfoPtr__npadNo3;

			// Token: 0x04003764 RID: 14180
			private static readonly IntPtr NativeFieldInfoPtr__npadNo4;

			// Token: 0x04003765 RID: 14181
			private static readonly IntPtr NativeFieldInfoPtr__npadNo5;

			// Token: 0x04003766 RID: 14182
			private static readonly IntPtr NativeFieldInfoPtr__npadNo6;

			// Token: 0x04003767 RID: 14183
			private static readonly IntPtr NativeFieldInfoPtr__npadNo7;

			// Token: 0x04003768 RID: 14184
			private static readonly IntPtr NativeFieldInfoPtr__npadNo8;

			// Token: 0x04003769 RID: 14185
			private static readonly IntPtr NativeFieldInfoPtr__npadHandheld;

			// Token: 0x0400376A RID: 14186
			private static readonly IntPtr NativeFieldInfoPtr__debugPad;

			// Token: 0x0400376B RID: 14187
			private static readonly IntPtr NativeFieldInfoPtr___delegates;

			// Token: 0x0400376C RID: 14188
			private static readonly IntPtr NativeMethodInfoPtr_get_allowedNpadStyles_Public_get_Int32_0;

			// Token: 0x0400376D RID: 14189
			private static readonly IntPtr NativeMethodInfoPtr_set_allowedNpadStyles_Public_set_Void_Int32_0;

			// Token: 0x0400376E RID: 14190
			private static readonly IntPtr NativeMethodInfoPtr_get_joyConGripStyle_Public_get_Int32_0;

			// Token: 0x0400376F RID: 14191
			private static readonly IntPtr NativeMethodInfoPtr_set_joyConGripStyle_Public_set_Void_Int32_0;

			// Token: 0x04003770 RID: 14192
			private static readonly IntPtr NativeMethodInfoPtr_get_adjustIMUsForGripStyle_Public_get_Boolean_0;

			// Token: 0x04003771 RID: 14193
			private static readonly IntPtr NativeMethodInfoPtr_set_adjustIMUsForGripStyle_Public_set_Void_Boolean_0;

			// Token: 0x04003772 RID: 14194
			private static readonly IntPtr NativeMethodInfoPtr_get_handheldActivationMode_Public_get_Int32_0;

			// Token: 0x04003773 RID: 14195
			private static readonly IntPtr NativeMethodInfoPtr_set_handheldActivationMode_Public_set_Void_Int32_0;

			// Token: 0x04003774 RID: 14196
			private static readonly IntPtr NativeMethodInfoPtr_get_assignJoysticksByNpadId_Public_get_Boolean_0;

			// Token: 0x04003775 RID: 14197
			private static readonly IntPtr NativeMethodInfoPtr_set_assignJoysticksByNpadId_Public_set_Void_Boolean_0;

			// Token: 0x04003776 RID: 14198
			private static readonly IntPtr NativeMethodInfoPtr_get_npadNo1_Private_get_NpadSettings_Internal_0;

			// Token: 0x04003777 RID: 14199
			private static readonly IntPtr NativeMethodInfoPtr_get_npadNo2_Private_get_NpadSettings_Internal_0;

			// Token: 0x04003778 RID: 14200
			private static readonly IntPtr NativeMethodInfoPtr_get_npadNo3_Private_get_NpadSettings_Internal_0;

			// Token: 0x04003779 RID: 14201
			private static readonly IntPtr NativeMethodInfoPtr_get_npadNo4_Private_get_NpadSettings_Internal_0;

			// Token: 0x0400377A RID: 14202
			private static readonly IntPtr NativeMethodInfoPtr_get_npadNo5_Private_get_NpadSettings_Internal_0;

			// Token: 0x0400377B RID: 14203
			private static readonly IntPtr NativeMethodInfoPtr_get_npadNo6_Private_get_NpadSettings_Internal_0;

			// Token: 0x0400377C RID: 14204
			private static readonly IntPtr NativeMethodInfoPtr_get_npadNo7_Private_get_NpadSettings_Internal_0;

			// Token: 0x0400377D RID: 14205
			private static readonly IntPtr NativeMethodInfoPtr_get_npadNo8_Private_get_NpadSettings_Internal_0;

			// Token: 0x0400377E RID: 14206
			private static readonly IntPtr NativeMethodInfoPtr_get_npadHandheld_Private_get_NpadSettings_Internal_0;

			// Token: 0x0400377F RID: 14207
			private static readonly IntPtr NativeMethodInfoPtr_get_debugPad_Public_get_DebugPadSettings_Internal_0;

			// Token: 0x04003780 RID: 14208
			private static readonly IntPtr NativeMethodInfoPtr_get_delegates_Private_get_Dictionary_2_Int32_Il2CppReferenceArray_1_Object_0;

			// Token: 0x04003781 RID: 14209
			private static readonly IntPtr NativeMethodInfoPtr_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TryGetValue_Private_Virtual_Final_New_Boolean_Int32_byref_T_0;

			// Token: 0x04003782 RID: 14210
			private static readonly IntPtr NativeMethodInfoPtr_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TrySetValue_Private_Virtual_Final_New_Boolean_Int32_T_0;

			// Token: 0x04003783 RID: 14211
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003784 RID: 14212
			private static readonly IntPtr NativeMethodInfoPtr__get_delegates_b__52_0_Private_Int32_0;

			// Token: 0x04003785 RID: 14213
			private static readonly IntPtr NativeMethodInfoPtr__get_delegates_b__52_1_Private_Void_Int32_0;

			// Token: 0x04003786 RID: 14214
			private static readonly IntPtr NativeMethodInfoPtr__get_delegates_b__52_2_Private_Int32_0;

			// Token: 0x04003787 RID: 14215
			private static readonly IntPtr NativeMethodInfoPtr__get_delegates_b__52_3_Private_Void_Int32_0;

			// Token: 0x04003788 RID: 14216
			private static readonly IntPtr NativeMethodInfoPtr__get_delegates_b__52_4_Private_Boolean_0;

			// Token: 0x04003789 RID: 14217
			private static readonly IntPtr NativeMethodInfoPtr__get_delegates_b__52_5_Private_Void_Boolean_0;

			// Token: 0x0400378A RID: 14218
			private static readonly IntPtr NativeMethodInfoPtr__get_delegates_b__52_6_Private_Int32_0;

			// Token: 0x0400378B RID: 14219
			private static readonly IntPtr NativeMethodInfoPtr__get_delegates_b__52_7_Private_Void_Int32_0;

			// Token: 0x0400378C RID: 14220
			private static readonly IntPtr NativeMethodInfoPtr__get_delegates_b__52_8_Private_Boolean_0;

			// Token: 0x0400378D RID: 14221
			private static readonly IntPtr NativeMethodInfoPtr__get_delegates_b__52_9_Private_Void_Boolean_0;

			// Token: 0x0400378E RID: 14222
			private static readonly IntPtr NativeMethodInfoPtr__get_delegates_b__52_10_Private_Object_0;

			// Token: 0x0400378F RID: 14223
			private static readonly IntPtr NativeMethodInfoPtr__get_delegates_b__52_11_Private_Object_0;

			// Token: 0x04003790 RID: 14224
			private static readonly IntPtr NativeMethodInfoPtr__get_delegates_b__52_12_Private_Object_0;

			// Token: 0x04003791 RID: 14225
			private static readonly IntPtr NativeMethodInfoPtr__get_delegates_b__52_13_Private_Object_0;

			// Token: 0x04003792 RID: 14226
			private static readonly IntPtr NativeMethodInfoPtr__get_delegates_b__52_14_Private_Object_0;

			// Token: 0x04003793 RID: 14227
			private static readonly IntPtr NativeMethodInfoPtr__get_delegates_b__52_15_Private_Object_0;

			// Token: 0x04003794 RID: 14228
			private static readonly IntPtr NativeMethodInfoPtr__get_delegates_b__52_16_Private_Object_0;

			// Token: 0x04003795 RID: 14229
			private static readonly IntPtr NativeMethodInfoPtr__get_delegates_b__52_17_Private_Object_0;

			// Token: 0x04003796 RID: 14230
			private static readonly IntPtr NativeMethodInfoPtr__get_delegates_b__52_18_Private_Object_0;

			// Token: 0x04003797 RID: 14231
			private static readonly IntPtr NativeMethodInfoPtr__get_delegates_b__52_19_Private_Object_0;

			// Token: 0x020003FC RID: 1020
			private sealed class MethodInfoStoreGeneric_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TryGetValue_Private_Virtual_Final_New_Boolean_Int32_byref_T_0<T>
			{
				// Token: 0x04003CD2 RID: 15570
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TryGetValue_Private_Virtual_Final_New_Boolean_Int32_byref_T_0, Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
			}

			// Token: 0x020003FD RID: 1021
			private sealed class MethodInfoStoreGeneric_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TrySetValue_Private_Virtual_Final_New_Boolean_Int32_T_0<T>
			{
				// Token: 0x04003CD3 RID: 15571
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TrySetValue_Private_Virtual_Final_New_Boolean_Int32_T_0, Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
			}
		}

		// Token: 0x02000358 RID: 856
		[Serializable]
		public sealed class NpadSettings_Internal : global::Il2CppSystem.Object
		{
			// Token: 0x06005418 RID: 21528 RVA: 0x00130F04 File Offset: 0x0012F104
			// Note: this type is marked as 'beforefieldinit'.
			static NpadSettings_Internal()
			{
				Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NintendoSwitchInputManager>.NativeClassPtr, "NpadSettings_Internal");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr);
				NintendoSwitchInputManager.NpadSettings_Internal.NativeFieldInfoPtr__isAllowed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, "_isAllowed");
				NintendoSwitchInputManager.NpadSettings_Internal.NativeFieldInfoPtr__rewiredPlayerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, "_rewiredPlayerId");
				NintendoSwitchInputManager.NpadSettings_Internal.NativeFieldInfoPtr__joyConAssignmentMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, "_joyConAssignmentMode");
				NintendoSwitchInputManager.NpadSettings_Internal.NativeFieldInfoPtr___delegates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, "__delegates");
				NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr_get_isAllowed_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, 100667828);
				NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr_set_isAllowed_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, 100667829);
				NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr_get_rewiredPlayerId_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, 100667830);
				NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr_set_rewiredPlayerId_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, 100667831);
				NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr_get_joyConAssignmentMode_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, 100667832);
				NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr_set_joyConAssignmentMode_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, 100667833);
				NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, 100667834);
				NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr_get_delegates_Private_get_Dictionary_2_Int32_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, 100667835);
				NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TryGetValue_Private_Virtual_Final_New_Boolean_Int32_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, 100667836);
				NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TrySetValue_Private_Virtual_Final_New_Boolean_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, 100667837);
				NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__15_0_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, 100667838);
				NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__15_1_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, 100667839);
				NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__15_2_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, 100667840);
				NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__15_3_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, 100667841);
				NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__15_4_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, 100667842);
				NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__15_5_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, 100667843);
			}

			// Token: 0x17001EB0 RID: 7856
			// (get) Token: 0x06005419 RID: 21529 RVA: 0x001310C0 File Offset: 0x0012F2C0
			// (set) Token: 0x0600541A RID: 21530 RVA: 0x001310FC File Offset: 0x0012F2FC
			public unsafe bool isAllowed
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr_get_isAllowed_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr_set_isAllowed_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001EB1 RID: 7857
			// (get) Token: 0x0600541B RID: 21531 RVA: 0x0013113C File Offset: 0x0012F33C
			// (set) Token: 0x0600541C RID: 21532 RVA: 0x00131178 File Offset: 0x0012F378
			public unsafe int rewiredPlayerId
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr_get_rewiredPlayerId_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr_set_rewiredPlayerId_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001EB2 RID: 7858
			// (get) Token: 0x0600541D RID: 21533 RVA: 0x001311B8 File Offset: 0x0012F3B8
			// (set) Token: 0x0600541E RID: 21534 RVA: 0x001311F4 File Offset: 0x0012F3F4
			public unsafe int joyConAssignmentMode
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr_get_joyConAssignmentMode_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr_set_joyConAssignmentMode_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x0600541F RID: 21535 RVA: 0x00131234 File Offset: 0x0012F434
			[CallerCount(0)]
			public unsafe NpadSettings_Internal(int playerId)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref playerId;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17001EB3 RID: 7859
			// (get) Token: 0x06005420 RID: 21536 RVA: 0x0013127C File Offset: 0x0012F47C
			public unsafe Dictionary<int, Il2CppReferenceArray<global::Il2CppSystem.Object>> delegates
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 87285, RefRangeEnd = 87287, XrefRangeStart = 87225, XrefRangeEnd = 87285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr_get_delegates_Private_get_Dictionary_2_Int32_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Il2CppReferenceArray<global::Il2CppSystem.Object>>>(intPtr3) : null;
				}
			}

			// Token: 0x06005421 RID: 21537 RVA: 0x001312BC File Offset: 0x0012F4BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87287, XrefRangeEnd = 87292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Rewired_Utils_Interfaces_IKeyedData_System_Int32__TryGetValue<T>(int key, out T value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref key;
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr;
				IntPtr intPtr2;
				if (!typeof(T).IsValueType)
				{
					intPtr = 0;
					intPtr2 = &intPtr;
				}
				else
				{
					intPtr2 = ref value;
				}
				ptr2 = intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NpadSettings_Internal.MethodInfoStoreGeneric_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TryGetValue_Private_Virtual_Final_New_Boolean_Int32_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				if (!typeof(T).IsValueType)
				{
					IntPtr intPtr5 = intPtr;
					value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
				}
				return *IL2CPP.il2cpp_object_unbox(intPtr3);
			}

			// Token: 0x06005422 RID: 21538 RVA: 0x00131354 File Offset: 0x0012F554
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87292, XrefRangeEnd = 87297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Rewired_Utils_Interfaces_IKeyedData_System_Int32__TrySetValue<T>(int key, T value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref key;
				}
				IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					if (!(t is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref value;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NpadSettings_Internal.MethodInfoStoreGeneric_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TrySetValue_Private_Virtual_Final_New_Boolean_Int32_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005423 RID: 21539 RVA: 0x001313FC File Offset: 0x0012F5FC
			[CallerCount(0)]
			public unsafe bool _get_delegates_b__15_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__15_0_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005424 RID: 21540 RVA: 0x00131438 File Offset: 0x0012F638
			[CallerCount(0)]
			public unsafe void _get_delegates_b__15_1(bool x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__15_1_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005425 RID: 21541 RVA: 0x00131478 File Offset: 0x0012F678
			[CallerCount(0)]
			public unsafe int _get_delegates_b__15_2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__15_2_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005426 RID: 21542 RVA: 0x001314B4 File Offset: 0x0012F6B4
			[CallerCount(0)]
			public unsafe void _get_delegates_b__15_3(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__15_3_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005427 RID: 21543 RVA: 0x001314F4 File Offset: 0x0012F6F4
			[CallerCount(0)]
			public unsafe int _get_delegates_b__15_4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__15_4_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005428 RID: 21544 RVA: 0x00131530 File Offset: 0x0012F730
			[CallerCount(0)]
			public unsafe void _get_delegates_b__15_5(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__15_5_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005429 RID: 21545 RVA: 0x00030D63 File Offset: 0x0002EF63
			public NpadSettings_Internal(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001EAC RID: 7852
			// (get) Token: 0x0600542A RID: 21546 RVA: 0x00131570 File Offset: 0x0012F770
			// (set) Token: 0x0600542B RID: 21547 RVA: 0x00030D6C File Offset: 0x0002EF6C
			public unsafe bool _isAllowed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.NpadSettings_Internal.NativeFieldInfoPtr__isAllowed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.NpadSettings_Internal.NativeFieldInfoPtr__isAllowed)) = value;
				}
			}

			// Token: 0x17001EAD RID: 7853
			// (get) Token: 0x0600542C RID: 21548 RVA: 0x00131598 File Offset: 0x0012F798
			// (set) Token: 0x0600542D RID: 21549 RVA: 0x00030D87 File Offset: 0x0002EF87
			public unsafe int _rewiredPlayerId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.NpadSettings_Internal.NativeFieldInfoPtr__rewiredPlayerId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.NpadSettings_Internal.NativeFieldInfoPtr__rewiredPlayerId)) = value;
				}
			}

			// Token: 0x17001EAE RID: 7854
			// (get) Token: 0x0600542E RID: 21550 RVA: 0x001315C0 File Offset: 0x0012F7C0
			// (set) Token: 0x0600542F RID: 21551 RVA: 0x00030DA2 File Offset: 0x0002EFA2
			public unsafe int _joyConAssignmentMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.NpadSettings_Internal.NativeFieldInfoPtr__joyConAssignmentMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.NpadSettings_Internal.NativeFieldInfoPtr__joyConAssignmentMode)) = value;
				}
			}

			// Token: 0x17001EAF RID: 7855
			// (get) Token: 0x06005430 RID: 21552 RVA: 0x001315E8 File Offset: 0x0012F7E8
			// (set) Token: 0x06005431 RID: 21553 RVA: 0x00030DBD File Offset: 0x0002EFBD
			public unsafe Dictionary<int, Il2CppReferenceArray<global::Il2CppSystem.Object>> __delegates
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.NpadSettings_Internal.NativeFieldInfoPtr___delegates);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Il2CppReferenceArray<global::Il2CppSystem.Object>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.NpadSettings_Internal.NativeFieldInfoPtr___delegates), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003798 RID: 14232
			private static readonly IntPtr NativeFieldInfoPtr__isAllowed;

			// Token: 0x04003799 RID: 14233
			private static readonly IntPtr NativeFieldInfoPtr__rewiredPlayerId;

			// Token: 0x0400379A RID: 14234
			private static readonly IntPtr NativeFieldInfoPtr__joyConAssignmentMode;

			// Token: 0x0400379B RID: 14235
			private static readonly IntPtr NativeFieldInfoPtr___delegates;

			// Token: 0x0400379C RID: 14236
			private static readonly IntPtr NativeMethodInfoPtr_get_isAllowed_Private_get_Boolean_0;

			// Token: 0x0400379D RID: 14237
			private static readonly IntPtr NativeMethodInfoPtr_set_isAllowed_Private_set_Void_Boolean_0;

			// Token: 0x0400379E RID: 14238
			private static readonly IntPtr NativeMethodInfoPtr_get_rewiredPlayerId_Private_get_Int32_0;

			// Token: 0x0400379F RID: 14239
			private static readonly IntPtr NativeMethodInfoPtr_set_rewiredPlayerId_Private_set_Void_Int32_0;

			// Token: 0x040037A0 RID: 14240
			private static readonly IntPtr NativeMethodInfoPtr_get_joyConAssignmentMode_Private_get_Int32_0;

			// Token: 0x040037A1 RID: 14241
			private static readonly IntPtr NativeMethodInfoPtr_set_joyConAssignmentMode_Private_set_Void_Int32_0;

			// Token: 0x040037A2 RID: 14242
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

			// Token: 0x040037A3 RID: 14243
			private static readonly IntPtr NativeMethodInfoPtr_get_delegates_Private_get_Dictionary_2_Int32_Il2CppReferenceArray_1_Object_0;

			// Token: 0x040037A4 RID: 14244
			private static readonly IntPtr NativeMethodInfoPtr_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TryGetValue_Private_Virtual_Final_New_Boolean_Int32_byref_T_0;

			// Token: 0x040037A5 RID: 14245
			private static readonly IntPtr NativeMethodInfoPtr_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TrySetValue_Private_Virtual_Final_New_Boolean_Int32_T_0;

			// Token: 0x040037A6 RID: 14246
			private static readonly IntPtr NativeMethodInfoPtr__get_delegates_b__15_0_Private_Boolean_0;

			// Token: 0x040037A7 RID: 14247
			private static readonly IntPtr NativeMethodInfoPtr__get_delegates_b__15_1_Private_Void_Boolean_0;

			// Token: 0x040037A8 RID: 14248
			private static readonly IntPtr NativeMethodInfoPtr__get_delegates_b__15_2_Private_Int32_0;

			// Token: 0x040037A9 RID: 14249
			private static readonly IntPtr NativeMethodInfoPtr__get_delegates_b__15_3_Private_Void_Int32_0;

			// Token: 0x040037AA RID: 14250
			private static readonly IntPtr NativeMethodInfoPtr__get_delegates_b__15_4_Private_Int32_0;

			// Token: 0x040037AB RID: 14251
			private static readonly IntPtr NativeMethodInfoPtr__get_delegates_b__15_5_Private_Void_Int32_0;

			// Token: 0x020003FE RID: 1022
			private sealed class MethodInfoStoreGeneric_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TryGetValue_Private_Virtual_Final_New_Boolean_Int32_byref_T_0<T>
			{
				// Token: 0x04003CD4 RID: 15572
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TryGetValue_Private_Virtual_Final_New_Boolean_Int32_byref_T_0, Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
			}

			// Token: 0x020003FF RID: 1023
			private sealed class MethodInfoStoreGeneric_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TrySetValue_Private_Virtual_Final_New_Boolean_Int32_T_0<T>
			{
				// Token: 0x04003CD5 RID: 15573
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TrySetValue_Private_Virtual_Final_New_Boolean_Int32_T_0, Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
			}
		}

		// Token: 0x02000359 RID: 857
		[Serializable]
		public sealed class DebugPadSettings_Internal : global::Il2CppSystem.Object
		{
			// Token: 0x06005432 RID: 21554 RVA: 0x00131618 File Offset: 0x0012F818
			// Note: this type is marked as 'beforefieldinit'.
			static DebugPadSettings_Internal()
			{
				Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NintendoSwitchInputManager>.NativeClassPtr, "DebugPadSettings_Internal");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr);
				NintendoSwitchInputManager.DebugPadSettings_Internal.NativeFieldInfoPtr__enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr, "_enabled");
				NintendoSwitchInputManager.DebugPadSettings_Internal.NativeFieldInfoPtr__rewiredPlayerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr, "_rewiredPlayerId");
				NintendoSwitchInputManager.DebugPadSettings_Internal.NativeFieldInfoPtr___delegates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr, "__delegates");
				NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr_get_rewiredPlayerId_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr, 100667844);
				NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr_set_rewiredPlayerId_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr, 100667845);
				NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr_get_enabled_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr, 100667846);
				NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr_set_enabled_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr, 100667847);
				NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr, 100667848);
				NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr_get_delegates_Private_get_Dictionary_2_Int32_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr, 100667849);
				NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TryGetValue_Private_Virtual_Final_New_Boolean_Int32_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr, 100667850);
				NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TrySetValue_Private_Virtual_Final_New_Boolean_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr, 100667851);
				NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__11_0_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr, 100667852);
				NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__11_1_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr, 100667853);
				NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__11_2_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr, 100667854);
				NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__11_3_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr, 100667855);
			}

			// Token: 0x17001EB7 RID: 7863
			// (get) Token: 0x06005433 RID: 21555 RVA: 0x00131770 File Offset: 0x0012F970
			// (set) Token: 0x06005434 RID: 21556 RVA: 0x001317AC File Offset: 0x0012F9AC
			public unsafe int rewiredPlayerId
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr_get_rewiredPlayerId_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr_set_rewiredPlayerId_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001EB8 RID: 7864
			// (get) Token: 0x06005435 RID: 21557 RVA: 0x001317EC File Offset: 0x0012F9EC
			// (set) Token: 0x06005436 RID: 21558 RVA: 0x00131828 File Offset: 0x0012FA28
			public unsafe bool enabled
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr_get_enabled_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr_set_enabled_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06005437 RID: 21559 RVA: 0x00131868 File Offset: 0x0012FA68
			[CallerCount(0)]
			public unsafe DebugPadSettings_Internal(int playerId)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref playerId;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17001EB9 RID: 7865
			// (get) Token: 0x06005438 RID: 21560 RVA: 0x001318B0 File Offset: 0x0012FAB0
			public unsafe Dictionary<int, Il2CppReferenceArray<global::Il2CppSystem.Object>> delegates
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 87342, RefRangeEnd = 87344, XrefRangeStart = 87297, XrefRangeEnd = 87342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr_get_delegates_Private_get_Dictionary_2_Int32_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Il2CppReferenceArray<global::Il2CppSystem.Object>>>(intPtr3) : null;
				}
			}

			// Token: 0x06005439 RID: 21561 RVA: 0x001318F0 File Offset: 0x0012FAF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87344, XrefRangeEnd = 87349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Rewired_Utils_Interfaces_IKeyedData_System_Int32__TryGetValue<T>(int key, out T value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref key;
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr;
				IntPtr intPtr2;
				if (!typeof(T).IsValueType)
				{
					intPtr = 0;
					intPtr2 = &intPtr;
				}
				else
				{
					intPtr2 = ref value;
				}
				ptr2 = intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.DebugPadSettings_Internal.MethodInfoStoreGeneric_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TryGetValue_Private_Virtual_Final_New_Boolean_Int32_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				if (!typeof(T).IsValueType)
				{
					IntPtr intPtr5 = intPtr;
					value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
				}
				return *IL2CPP.il2cpp_object_unbox(intPtr3);
			}

			// Token: 0x0600543A RID: 21562 RVA: 0x00131988 File Offset: 0x0012FB88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87349, XrefRangeEnd = 87354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Rewired_Utils_Interfaces_IKeyedData_System_Int32__TrySetValue<T>(int key, T value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref key;
				}
				IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					if (!(t is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref value;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.DebugPadSettings_Internal.MethodInfoStoreGeneric_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TrySetValue_Private_Virtual_Final_New_Boolean_Int32_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600543B RID: 21563 RVA: 0x00131A30 File Offset: 0x0012FC30
			[CallerCount(0)]
			public unsafe bool _get_delegates_b__11_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__11_0_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600543C RID: 21564 RVA: 0x00131A6C File Offset: 0x0012FC6C
			[CallerCount(0)]
			public unsafe void _get_delegates_b__11_1(bool x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__11_1_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600543D RID: 21565 RVA: 0x00131AAC File Offset: 0x0012FCAC
			[CallerCount(0)]
			public unsafe int _get_delegates_b__11_2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__11_2_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600543E RID: 21566 RVA: 0x00131AE8 File Offset: 0x0012FCE8
			[CallerCount(0)]
			public unsafe void _get_delegates_b__11_3(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__11_3_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600543F RID: 21567 RVA: 0x00030DDC File Offset: 0x0002EFDC
			public DebugPadSettings_Internal(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001EB4 RID: 7860
			// (get) Token: 0x06005440 RID: 21568 RVA: 0x00131B28 File Offset: 0x0012FD28
			// (set) Token: 0x06005441 RID: 21569 RVA: 0x00030DE5 File Offset: 0x0002EFE5
			public unsafe bool _enabled
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.DebugPadSettings_Internal.NativeFieldInfoPtr__enabled);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.DebugPadSettings_Internal.NativeFieldInfoPtr__enabled)) = value;
				}
			}

			// Token: 0x17001EB5 RID: 7861
			// (get) Token: 0x06005442 RID: 21570 RVA: 0x00131B50 File Offset: 0x0012FD50
			// (set) Token: 0x06005443 RID: 21571 RVA: 0x00030E00 File Offset: 0x0002F000
			public unsafe int _rewiredPlayerId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.DebugPadSettings_Internal.NativeFieldInfoPtr__rewiredPlayerId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.DebugPadSettings_Internal.NativeFieldInfoPtr__rewiredPlayerId)) = value;
				}
			}

			// Token: 0x17001EB6 RID: 7862
			// (get) Token: 0x06005444 RID: 21572 RVA: 0x00131B78 File Offset: 0x0012FD78
			// (set) Token: 0x06005445 RID: 21573 RVA: 0x00030E1B File Offset: 0x0002F01B
			public unsafe Dictionary<int, Il2CppReferenceArray<global::Il2CppSystem.Object>> __delegates
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.DebugPadSettings_Internal.NativeFieldInfoPtr___delegates);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Il2CppReferenceArray<global::Il2CppSystem.Object>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.DebugPadSettings_Internal.NativeFieldInfoPtr___delegates), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040037AC RID: 14252
			private static readonly IntPtr NativeFieldInfoPtr__enabled;

			// Token: 0x040037AD RID: 14253
			private static readonly IntPtr NativeFieldInfoPtr__rewiredPlayerId;

			// Token: 0x040037AE RID: 14254
			private static readonly IntPtr NativeFieldInfoPtr___delegates;

			// Token: 0x040037AF RID: 14255
			private static readonly IntPtr NativeMethodInfoPtr_get_rewiredPlayerId_Private_get_Int32_0;

			// Token: 0x040037B0 RID: 14256
			private static readonly IntPtr NativeMethodInfoPtr_set_rewiredPlayerId_Private_set_Void_Int32_0;

			// Token: 0x040037B1 RID: 14257
			private static readonly IntPtr NativeMethodInfoPtr_get_enabled_Private_get_Boolean_0;

			// Token: 0x040037B2 RID: 14258
			private static readonly IntPtr NativeMethodInfoPtr_set_enabled_Private_set_Void_Boolean_0;

			// Token: 0x040037B3 RID: 14259
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

			// Token: 0x040037B4 RID: 14260
			private static readonly IntPtr NativeMethodInfoPtr_get_delegates_Private_get_Dictionary_2_Int32_Il2CppReferenceArray_1_Object_0;

			// Token: 0x040037B5 RID: 14261
			private static readonly IntPtr NativeMethodInfoPtr_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TryGetValue_Private_Virtual_Final_New_Boolean_Int32_byref_T_0;

			// Token: 0x040037B6 RID: 14262
			private static readonly IntPtr NativeMethodInfoPtr_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TrySetValue_Private_Virtual_Final_New_Boolean_Int32_T_0;

			// Token: 0x040037B7 RID: 14263
			private static readonly IntPtr NativeMethodInfoPtr__get_delegates_b__11_0_Private_Boolean_0;

			// Token: 0x040037B8 RID: 14264
			private static readonly IntPtr NativeMethodInfoPtr__get_delegates_b__11_1_Private_Void_Boolean_0;

			// Token: 0x040037B9 RID: 14265
			private static readonly IntPtr NativeMethodInfoPtr__get_delegates_b__11_2_Private_Int32_0;

			// Token: 0x040037BA RID: 14266
			private static readonly IntPtr NativeMethodInfoPtr__get_delegates_b__11_3_Private_Void_Int32_0;

			// Token: 0x02000400 RID: 1024
			private sealed class MethodInfoStoreGeneric_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TryGetValue_Private_Virtual_Final_New_Boolean_Int32_byref_T_0<T>
			{
				// Token: 0x04003CD6 RID: 15574
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TryGetValue_Private_Virtual_Final_New_Boolean_Int32_byref_T_0, Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
			}

			// Token: 0x02000401 RID: 1025
			private sealed class MethodInfoStoreGeneric_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TrySetValue_Private_Virtual_Final_New_Boolean_Int32_T_0<T>
			{
				// Token: 0x04003CD7 RID: 15575
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TrySetValue_Private_Virtual_Final_New_Boolean_Int32_T_0, Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
			}
		}
	}
}
