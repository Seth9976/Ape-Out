using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppRewired.Demos
{
	// Token: 0x0200021B RID: 539
	public class SimpleControlRemapping : MonoBehaviour
	{
		// Token: 0x06004181 RID: 16769 RVA: 0x000F4024 File Offset: 0x000F2224
		// Note: this type is marked as 'beforefieldinit'.
		static SimpleControlRemapping()
		{
			Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Demos", "SimpleControlRemapping");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr);
			SimpleControlRemapping.NativeFieldInfoPtr_category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, "category");
			SimpleControlRemapping.NativeFieldInfoPtr_layout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, "layout");
			SimpleControlRemapping.NativeFieldInfoPtr_uiCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, "uiCategory");
			SimpleControlRemapping.NativeFieldInfoPtr_inputMapper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, "inputMapper");
			SimpleControlRemapping.NativeFieldInfoPtr_buttonPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, "buttonPrefab");
			SimpleControlRemapping.NativeFieldInfoPtr_textPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, "textPrefab");
			SimpleControlRemapping.NativeFieldInfoPtr_fieldGroupTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, "fieldGroupTransform");
			SimpleControlRemapping.NativeFieldInfoPtr_actionGroupTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, "actionGroupTransform");
			SimpleControlRemapping.NativeFieldInfoPtr_controllerNameUIText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, "controllerNameUIText");
			SimpleControlRemapping.NativeFieldInfoPtr_statusUIText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, "statusUIText");
			SimpleControlRemapping.NativeFieldInfoPtr_selectedControllerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, "selectedControllerType");
			SimpleControlRemapping.NativeFieldInfoPtr_selectedControllerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, "selectedControllerId");
			SimpleControlRemapping.NativeFieldInfoPtr_rows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, "rows");
			SimpleControlRemapping.NativeMethodInfoPtr_get_player_Private_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, 100669691);
			SimpleControlRemapping.NativeMethodInfoPtr_get_controllerMap_Private_get_ControllerMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, 100669692);
			SimpleControlRemapping.NativeMethodInfoPtr_get_controller_Private_get_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, 100669693);
			SimpleControlRemapping.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, 100669694);
			SimpleControlRemapping.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, 100669695);
			SimpleControlRemapping.NativeMethodInfoPtr_RedrawUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, 100669696);
			SimpleControlRemapping.NativeMethodInfoPtr_ClearUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, 100669697);
			SimpleControlRemapping.NativeMethodInfoPtr_InitializeUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, 100669698);
			SimpleControlRemapping.NativeMethodInfoPtr_CreateUIRow_Private_Void_InputAction_AxisRange_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, 100669699);
			SimpleControlRemapping.NativeMethodInfoPtr_SetSelectedController_Private_Void_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, 100669700);
			SimpleControlRemapping.NativeMethodInfoPtr_OnControllerSelected_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, 100669701);
			SimpleControlRemapping.NativeMethodInfoPtr_OnInputFieldClicked_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, 100669702);
			SimpleControlRemapping.NativeMethodInfoPtr_StartListeningDelayed_Private_IEnumerator_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, 100669703);
			SimpleControlRemapping.NativeMethodInfoPtr_OnControllerChanged_Private_Void_ControllerStatusChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, 100669704);
			SimpleControlRemapping.NativeMethodInfoPtr_OnInputMapped_Private_Void_InputMappedEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, 100669705);
			SimpleControlRemapping.NativeMethodInfoPtr_OnStopped_Private_Void_StoppedEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, 100669706);
			SimpleControlRemapping.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, 100669707);
		}

		// Token: 0x170018C1 RID: 6337
		// (get) Token: 0x06004182 RID: 16770 RVA: 0x000F42AC File Offset: 0x000F24AC
		public unsafe Player player
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 105290, RefRangeEnd = 105293, XrefRangeStart = 105284, XrefRangeEnd = 105290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleControlRemapping.NativeMethodInfoPtr_get_player_Private_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
		}

		// Token: 0x170018C2 RID: 6338
		// (get) Token: 0x06004183 RID: 16771 RVA: 0x000F42EC File Offset: 0x000F24EC
		public unsafe ControllerMap controllerMap
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 105301, RefRangeEnd = 105302, XrefRangeStart = 105293, XrefRangeEnd = 105301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleControlRemapping.NativeMethodInfoPtr_get_controllerMap_Private_get_ControllerMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerMap>(intPtr3) : null;
			}
		}

		// Token: 0x170018C3 RID: 6339
		// (get) Token: 0x06004184 RID: 16772 RVA: 0x000F432C File Offset: 0x000F252C
		public unsafe Controller controller
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 105309, RefRangeEnd = 105316, XrefRangeStart = 105302, XrefRangeEnd = 105309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleControlRemapping.NativeMethodInfoPtr_get_controller_Private_get_Controller_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Controller>(intPtr3) : null;
			}
		}

		// Token: 0x06004185 RID: 16773 RVA: 0x000F436C File Offset: 0x000F256C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105316, XrefRangeEnd = 105351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleControlRemapping.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004186 RID: 16774 RVA: 0x000F43A0 File Offset: 0x000F25A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105351, XrefRangeEnd = 105370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleControlRemapping.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004187 RID: 16775 RVA: 0x000F43D4 File Offset: 0x000F25D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 105414, RefRangeEnd = 105417, XrefRangeStart = 105370, XrefRangeEnd = 105414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RedrawUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleControlRemapping.NativeMethodInfoPtr_RedrawUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004188 RID: 16776 RVA: 0x000F4408 File Offset: 0x000F2608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105417, XrefRangeEnd = 105426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleControlRemapping.NativeMethodInfoPtr_ClearUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004189 RID: 16777 RVA: 0x000F443C File Offset: 0x000F263C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 105517, RefRangeEnd = 105518, XrefRangeStart = 105426, XrefRangeEnd = 105517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleControlRemapping.NativeMethodInfoPtr_InitializeUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600418A RID: 16778 RVA: 0x000F4470 File Offset: 0x000F2670
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 105573, RefRangeEnd = 105577, XrefRangeStart = 105518, XrefRangeEnd = 105573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateUIRow(InputAction action, AxisRange actionRange, string label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionRange;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(label);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleControlRemapping.NativeMethodInfoPtr_CreateUIRow_Private_Void_InputAction_AxisRange_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600418B RID: 16779 RVA: 0x000F44D4 File Offset: 0x000F26D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 105589, RefRangeEnd = 105591, XrefRangeStart = 105577, XrefRangeEnd = 105589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSelectedController(ControllerType controllerType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleControlRemapping.NativeMethodInfoPtr_SetSelectedController_Private_Void_ControllerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600418C RID: 16780 RVA: 0x000F4514 File Offset: 0x000F2714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105591, XrefRangeEnd = 105592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnControllerSelected(int controllerType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleControlRemapping.NativeMethodInfoPtr_OnControllerSelected_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600418D RID: 16781 RVA: 0x000F4554 File Offset: 0x000F2754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105592, XrefRangeEnd = 105598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnInputFieldClicked(int index, int actionElementMapToReplaceId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionElementMapToReplaceId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleControlRemapping.NativeMethodInfoPtr_OnInputFieldClicked_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600418E RID: 16782 RVA: 0x000F45A0 File Offset: 0x000F27A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105598, XrefRangeEnd = 105601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator StartListeningDelayed(int index, int actionElementMapToReplaceId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionElementMapToReplaceId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleControlRemapping.NativeMethodInfoPtr_StartListeningDelayed_Private_IEnumerator_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600418F RID: 16783 RVA: 0x000F45FC File Offset: 0x000F27FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105601, XrefRangeEnd = 105602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnControllerChanged(ControllerStatusChangedEventArgs args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleControlRemapping.NativeMethodInfoPtr_OnControllerChanged_Private_Void_ControllerStatusChangedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004190 RID: 16784 RVA: 0x000F4640 File Offset: 0x000F2840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105602, XrefRangeEnd = 105603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnInputMapped(InputMapper.InputMappedEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleControlRemapping.NativeMethodInfoPtr_OnInputMapped_Private_Void_InputMappedEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004191 RID: 16785 RVA: 0x000F4684 File Offset: 0x000F2884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105603, XrefRangeEnd = 105614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnStopped(InputMapper.StoppedEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleControlRemapping.NativeMethodInfoPtr_OnStopped_Private_Void_StoppedEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004192 RID: 16786 RVA: 0x000F46C8 File Offset: 0x000F28C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105614, XrefRangeEnd = 105627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SimpleControlRemapping()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleControlRemapping.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004193 RID: 16787 RVA: 0x00027F86 File Offset: 0x00026186
		public SimpleControlRemapping(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170018B4 RID: 6324
		// (get) Token: 0x06004194 RID: 16788 RVA: 0x000F4704 File Offset: 0x000F2904
		// (set) Token: 0x06004195 RID: 16789 RVA: 0x00027F8F File Offset: 0x0002618F
		public unsafe static string category
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SimpleControlRemapping.NativeFieldInfoPtr_category, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SimpleControlRemapping.NativeFieldInfoPtr_category, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170018B5 RID: 6325
		// (get) Token: 0x06004196 RID: 16790 RVA: 0x000F4724 File Offset: 0x000F2924
		// (set) Token: 0x06004197 RID: 16791 RVA: 0x00027FA1 File Offset: 0x000261A1
		public unsafe static string layout
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SimpleControlRemapping.NativeFieldInfoPtr_layout, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SimpleControlRemapping.NativeFieldInfoPtr_layout, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170018B6 RID: 6326
		// (get) Token: 0x06004198 RID: 16792 RVA: 0x000F4744 File Offset: 0x000F2944
		// (set) Token: 0x06004199 RID: 16793 RVA: 0x00027FB3 File Offset: 0x000261B3
		public unsafe static string uiCategory
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SimpleControlRemapping.NativeFieldInfoPtr_uiCategory, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SimpleControlRemapping.NativeFieldInfoPtr_uiCategory, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170018B7 RID: 6327
		// (get) Token: 0x0600419A RID: 16794 RVA: 0x000F4764 File Offset: 0x000F2964
		// (set) Token: 0x0600419B RID: 16795 RVA: 0x00027FC5 File Offset: 0x000261C5
		public unsafe InputMapper inputMapper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.NativeFieldInfoPtr_inputMapper);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputMapper>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.NativeFieldInfoPtr_inputMapper), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018B8 RID: 6328
		// (get) Token: 0x0600419C RID: 16796 RVA: 0x000F4794 File Offset: 0x000F2994
		// (set) Token: 0x0600419D RID: 16797 RVA: 0x00027FE4 File Offset: 0x000261E4
		public unsafe GameObject buttonPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.NativeFieldInfoPtr_buttonPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.NativeFieldInfoPtr_buttonPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018B9 RID: 6329
		// (get) Token: 0x0600419E RID: 16798 RVA: 0x000F47C4 File Offset: 0x000F29C4
		// (set) Token: 0x0600419F RID: 16799 RVA: 0x00028003 File Offset: 0x00026203
		public unsafe GameObject textPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.NativeFieldInfoPtr_textPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.NativeFieldInfoPtr_textPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018BA RID: 6330
		// (get) Token: 0x060041A0 RID: 16800 RVA: 0x000F47F4 File Offset: 0x000F29F4
		// (set) Token: 0x060041A1 RID: 16801 RVA: 0x00028022 File Offset: 0x00026222
		public unsafe RectTransform fieldGroupTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.NativeFieldInfoPtr_fieldGroupTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.NativeFieldInfoPtr_fieldGroupTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018BB RID: 6331
		// (get) Token: 0x060041A2 RID: 16802 RVA: 0x000F4824 File Offset: 0x000F2A24
		// (set) Token: 0x060041A3 RID: 16803 RVA: 0x00028041 File Offset: 0x00026241
		public unsafe RectTransform actionGroupTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.NativeFieldInfoPtr_actionGroupTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.NativeFieldInfoPtr_actionGroupTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018BC RID: 6332
		// (get) Token: 0x060041A4 RID: 16804 RVA: 0x000F4854 File Offset: 0x000F2A54
		// (set) Token: 0x060041A5 RID: 16805 RVA: 0x00028060 File Offset: 0x00026260
		public unsafe Text controllerNameUIText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.NativeFieldInfoPtr_controllerNameUIText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.NativeFieldInfoPtr_controllerNameUIText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018BD RID: 6333
		// (get) Token: 0x060041A6 RID: 16806 RVA: 0x000F4884 File Offset: 0x000F2A84
		// (set) Token: 0x060041A7 RID: 16807 RVA: 0x0002807F File Offset: 0x0002627F
		public unsafe Text statusUIText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.NativeFieldInfoPtr_statusUIText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.NativeFieldInfoPtr_statusUIText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018BE RID: 6334
		// (get) Token: 0x060041A8 RID: 16808 RVA: 0x000F48B4 File Offset: 0x000F2AB4
		// (set) Token: 0x060041A9 RID: 16809 RVA: 0x0002809E File Offset: 0x0002629E
		public unsafe ControllerType selectedControllerType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.NativeFieldInfoPtr_selectedControllerType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.NativeFieldInfoPtr_selectedControllerType)) = value;
			}
		}

		// Token: 0x170018BF RID: 6335
		// (get) Token: 0x060041AA RID: 16810 RVA: 0x000F48DC File Offset: 0x000F2ADC
		// (set) Token: 0x060041AB RID: 16811 RVA: 0x000280B9 File Offset: 0x000262B9
		public unsafe int selectedControllerId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.NativeFieldInfoPtr_selectedControllerId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.NativeFieldInfoPtr_selectedControllerId)) = value;
			}
		}

		// Token: 0x170018C0 RID: 6336
		// (get) Token: 0x060041AC RID: 16812 RVA: 0x000F4904 File Offset: 0x000F2B04
		// (set) Token: 0x060041AD RID: 16813 RVA: 0x000280D4 File Offset: 0x000262D4
		public unsafe List<SimpleControlRemapping.Row> rows
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.NativeFieldInfoPtr_rows);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SimpleControlRemapping.Row>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.NativeFieldInfoPtr_rows), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400283E RID: 10302
		private static readonly IntPtr NativeFieldInfoPtr_category;

		// Token: 0x0400283F RID: 10303
		private static readonly IntPtr NativeFieldInfoPtr_layout;

		// Token: 0x04002840 RID: 10304
		private static readonly IntPtr NativeFieldInfoPtr_uiCategory;

		// Token: 0x04002841 RID: 10305
		private static readonly IntPtr NativeFieldInfoPtr_inputMapper;

		// Token: 0x04002842 RID: 10306
		private static readonly IntPtr NativeFieldInfoPtr_buttonPrefab;

		// Token: 0x04002843 RID: 10307
		private static readonly IntPtr NativeFieldInfoPtr_textPrefab;

		// Token: 0x04002844 RID: 10308
		private static readonly IntPtr NativeFieldInfoPtr_fieldGroupTransform;

		// Token: 0x04002845 RID: 10309
		private static readonly IntPtr NativeFieldInfoPtr_actionGroupTransform;

		// Token: 0x04002846 RID: 10310
		private static readonly IntPtr NativeFieldInfoPtr_controllerNameUIText;

		// Token: 0x04002847 RID: 10311
		private static readonly IntPtr NativeFieldInfoPtr_statusUIText;

		// Token: 0x04002848 RID: 10312
		private static readonly IntPtr NativeFieldInfoPtr_selectedControllerType;

		// Token: 0x04002849 RID: 10313
		private static readonly IntPtr NativeFieldInfoPtr_selectedControllerId;

		// Token: 0x0400284A RID: 10314
		private static readonly IntPtr NativeFieldInfoPtr_rows;

		// Token: 0x0400284B RID: 10315
		private static readonly IntPtr NativeMethodInfoPtr_get_player_Private_get_Player_0;

		// Token: 0x0400284C RID: 10316
		private static readonly IntPtr NativeMethodInfoPtr_get_controllerMap_Private_get_ControllerMap_0;

		// Token: 0x0400284D RID: 10317
		private static readonly IntPtr NativeMethodInfoPtr_get_controller_Private_get_Controller_0;

		// Token: 0x0400284E RID: 10318
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x0400284F RID: 10319
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04002850 RID: 10320
		private static readonly IntPtr NativeMethodInfoPtr_RedrawUI_Private_Void_0;

		// Token: 0x04002851 RID: 10321
		private static readonly IntPtr NativeMethodInfoPtr_ClearUI_Private_Void_0;

		// Token: 0x04002852 RID: 10322
		private static readonly IntPtr NativeMethodInfoPtr_InitializeUI_Private_Void_0;

		// Token: 0x04002853 RID: 10323
		private static readonly IntPtr NativeMethodInfoPtr_CreateUIRow_Private_Void_InputAction_AxisRange_String_0;

		// Token: 0x04002854 RID: 10324
		private static readonly IntPtr NativeMethodInfoPtr_SetSelectedController_Private_Void_ControllerType_0;

		// Token: 0x04002855 RID: 10325
		private static readonly IntPtr NativeMethodInfoPtr_OnControllerSelected_Public_Void_Int32_0;

		// Token: 0x04002856 RID: 10326
		private static readonly IntPtr NativeMethodInfoPtr_OnInputFieldClicked_Private_Void_Int32_Int32_0;

		// Token: 0x04002857 RID: 10327
		private static readonly IntPtr NativeMethodInfoPtr_StartListeningDelayed_Private_IEnumerator_Int32_Int32_0;

		// Token: 0x04002858 RID: 10328
		private static readonly IntPtr NativeMethodInfoPtr_OnControllerChanged_Private_Void_ControllerStatusChangedEventArgs_0;

		// Token: 0x04002859 RID: 10329
		private static readonly IntPtr NativeMethodInfoPtr_OnInputMapped_Private_Void_InputMappedEventData_0;

		// Token: 0x0400285A RID: 10330
		private static readonly IntPtr NativeMethodInfoPtr_OnStopped_Private_Void_StoppedEventData_0;

		// Token: 0x0400285B RID: 10331
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003AF RID: 943
		public class Row : global::Il2CppSystem.Object
		{
			// Token: 0x06005943 RID: 22851 RVA: 0x001432CC File Offset: 0x001414CC
			// Note: this type is marked as 'beforefieldinit'.
			static Row()
			{
				Il2CppClassPointerStore<SimpleControlRemapping.Row>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, "Row");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleControlRemapping.Row>.NativeClassPtr);
				SimpleControlRemapping.Row.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleControlRemapping.Row>.NativeClassPtr, "action");
				SimpleControlRemapping.Row.NativeFieldInfoPtr_actionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleControlRemapping.Row>.NativeClassPtr, "actionRange");
				SimpleControlRemapping.Row.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleControlRemapping.Row>.NativeClassPtr, "button");
				SimpleControlRemapping.Row.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleControlRemapping.Row>.NativeClassPtr, "text");
				SimpleControlRemapping.Row.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleControlRemapping.Row>.NativeClassPtr, 100669708);
			}

			// Token: 0x06005944 RID: 22852 RVA: 0x0014335C File Offset: 0x0014155C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Row()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleControlRemapping.Row>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleControlRemapping.Row.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005945 RID: 22853 RVA: 0x00033223 File Offset: 0x00031423
			public Row(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170020A0 RID: 8352
			// (get) Token: 0x06005946 RID: 22854 RVA: 0x00143398 File Offset: 0x00141598
			// (set) Token: 0x06005947 RID: 22855 RVA: 0x0003322C File Offset: 0x0003142C
			public unsafe InputAction action
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.Row.NativeFieldInfoPtr_action);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.Row.NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170020A1 RID: 8353
			// (get) Token: 0x06005948 RID: 22856 RVA: 0x001433C8 File Offset: 0x001415C8
			// (set) Token: 0x06005949 RID: 22857 RVA: 0x0003324B File Offset: 0x0003144B
			public unsafe AxisRange actionRange
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.Row.NativeFieldInfoPtr_actionRange);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.Row.NativeFieldInfoPtr_actionRange)) = value;
				}
			}

			// Token: 0x170020A2 RID: 8354
			// (get) Token: 0x0600594A RID: 22858 RVA: 0x001433F0 File Offset: 0x001415F0
			// (set) Token: 0x0600594B RID: 22859 RVA: 0x00033266 File Offset: 0x00031466
			public unsafe Button button
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.Row.NativeFieldInfoPtr_button);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.Row.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170020A3 RID: 8355
			// (get) Token: 0x0600594C RID: 22860 RVA: 0x00143420 File Offset: 0x00141620
			// (set) Token: 0x0600594D RID: 22861 RVA: 0x00033285 File Offset: 0x00031485
			public unsafe Text text
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.Row.NativeFieldInfoPtr_text);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.Row.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003B4B RID: 15179
			private static readonly IntPtr NativeFieldInfoPtr_action;

			// Token: 0x04003B4C RID: 15180
			private static readonly IntPtr NativeFieldInfoPtr_actionRange;

			// Token: 0x04003B4D RID: 15181
			private static readonly IntPtr NativeFieldInfoPtr_button;

			// Token: 0x04003B4E RID: 15182
			private static readonly IntPtr NativeFieldInfoPtr_text;

			// Token: 0x04003B4F RID: 15183
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020003B0 RID: 944
		[ObfuscatedName("Rewired.Demos.SimpleControlRemapping+<>c__DisplayClass21_0")]
		public sealed class __c__DisplayClass21_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600594E RID: 22862 RVA: 0x00143450 File Offset: 0x00141650
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass21_0()
			{
				Il2CppClassPointerStore<SimpleControlRemapping.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, "<>c__DisplayClass21_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleControlRemapping.__c__DisplayClass21_0>.NativeClassPtr);
				SimpleControlRemapping.__c__DisplayClass21_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleControlRemapping.__c__DisplayClass21_0>.NativeClassPtr, "index");
				SimpleControlRemapping.__c__DisplayClass21_0.NativeFieldInfoPtr_actionElementMapId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleControlRemapping.__c__DisplayClass21_0>.NativeClassPtr, "actionElementMapId");
				SimpleControlRemapping.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleControlRemapping.__c__DisplayClass21_0>.NativeClassPtr, "<>4__this");
				SimpleControlRemapping.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleControlRemapping.__c__DisplayClass21_0>.NativeClassPtr, 100669709);
				SimpleControlRemapping.__c__DisplayClass21_0.NativeMethodInfoPtr__RedrawUI_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleControlRemapping.__c__DisplayClass21_0>.NativeClassPtr, 100669710);
			}

			// Token: 0x0600594F RID: 22863 RVA: 0x001434E0 File Offset: 0x001416E0
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass21_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleControlRemapping.__c__DisplayClass21_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleControlRemapping.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005950 RID: 22864 RVA: 0x0014351C File Offset: 0x0014171C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105266, XrefRangeEnd = 105272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RedrawUI_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleControlRemapping.__c__DisplayClass21_0.NativeMethodInfoPtr__RedrawUI_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005951 RID: 22865 RVA: 0x000332A4 File Offset: 0x000314A4
			public __c__DisplayClass21_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170020A4 RID: 8356
			// (get) Token: 0x06005952 RID: 22866 RVA: 0x00143550 File Offset: 0x00141750
			// (set) Token: 0x06005953 RID: 22867 RVA: 0x000332AD File Offset: 0x000314AD
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.__c__DisplayClass21_0.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.__c__DisplayClass21_0.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x170020A5 RID: 8357
			// (get) Token: 0x06005954 RID: 22868 RVA: 0x00143578 File Offset: 0x00141778
			// (set) Token: 0x06005955 RID: 22869 RVA: 0x000332C8 File Offset: 0x000314C8
			public unsafe int actionElementMapId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.__c__DisplayClass21_0.NativeFieldInfoPtr_actionElementMapId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.__c__DisplayClass21_0.NativeFieldInfoPtr_actionElementMapId)) = value;
				}
			}

			// Token: 0x170020A6 RID: 8358
			// (get) Token: 0x06005956 RID: 22870 RVA: 0x001435A0 File Offset: 0x001417A0
			// (set) Token: 0x06005957 RID: 22871 RVA: 0x000332E3 File Offset: 0x000314E3
			public unsafe SimpleControlRemapping __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SimpleControlRemapping>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003B50 RID: 15184
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x04003B51 RID: 15185
			private static readonly IntPtr NativeFieldInfoPtr_actionElementMapId;

			// Token: 0x04003B52 RID: 15186
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003B53 RID: 15187
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003B54 RID: 15188
			private static readonly IntPtr NativeMethodInfoPtr__RedrawUI_b__0_Internal_Void_0;
		}

		// Token: 0x020003B1 RID: 945
		[ObfuscatedName("Rewired.Demos.SimpleControlRemapping+<StartListeningDelayed>d__28")]
		public sealed class _StartListeningDelayed_d__28 : global::Il2CppSystem.Object
		{
			// Token: 0x06005958 RID: 22872 RVA: 0x001435D0 File Offset: 0x001417D0
			// Note: this type is marked as 'beforefieldinit'.
			static _StartListeningDelayed_d__28()
			{
				Il2CppClassPointerStore<SimpleControlRemapping._StartListeningDelayed_d__28>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, "<StartListeningDelayed>d__28");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleControlRemapping._StartListeningDelayed_d__28>.NativeClassPtr);
				SimpleControlRemapping._StartListeningDelayed_d__28.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleControlRemapping._StartListeningDelayed_d__28>.NativeClassPtr, "<>1__state");
				SimpleControlRemapping._StartListeningDelayed_d__28.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleControlRemapping._StartListeningDelayed_d__28>.NativeClassPtr, "<>2__current");
				SimpleControlRemapping._StartListeningDelayed_d__28.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleControlRemapping._StartListeningDelayed_d__28>.NativeClassPtr, "<>4__this");
				SimpleControlRemapping._StartListeningDelayed_d__28.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleControlRemapping._StartListeningDelayed_d__28>.NativeClassPtr, "index");
				SimpleControlRemapping._StartListeningDelayed_d__28.NativeFieldInfoPtr_actionElementMapToReplaceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleControlRemapping._StartListeningDelayed_d__28>.NativeClassPtr, "actionElementMapToReplaceId");
				SimpleControlRemapping._StartListeningDelayed_d__28.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleControlRemapping._StartListeningDelayed_d__28>.NativeClassPtr, 100669711);
				SimpleControlRemapping._StartListeningDelayed_d__28.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleControlRemapping._StartListeningDelayed_d__28>.NativeClassPtr, 100669712);
				SimpleControlRemapping._StartListeningDelayed_d__28.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleControlRemapping._StartListeningDelayed_d__28>.NativeClassPtr, 100669713);
				SimpleControlRemapping._StartListeningDelayed_d__28.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleControlRemapping._StartListeningDelayed_d__28>.NativeClassPtr, 100669714);
				SimpleControlRemapping._StartListeningDelayed_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleControlRemapping._StartListeningDelayed_d__28>.NativeClassPtr, 100669715);
				SimpleControlRemapping._StartListeningDelayed_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleControlRemapping._StartListeningDelayed_d__28>.NativeClassPtr, 100669716);
			}

			// Token: 0x06005959 RID: 22873 RVA: 0x001436D8 File Offset: 0x001418D8
			[CallerCount(0)]
			public unsafe _StartListeningDelayed_d__28(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleControlRemapping._StartListeningDelayed_d__28>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleControlRemapping._StartListeningDelayed_d__28.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600595A RID: 22874 RVA: 0x00143720 File Offset: 0x00141920
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleControlRemapping._StartListeningDelayed_d__28.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600595B RID: 22875 RVA: 0x00143754 File Offset: 0x00141954
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105272, XrefRangeEnd = 105279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleControlRemapping._StartListeningDelayed_d__28.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170020AC RID: 8364
			// (get) Token: 0x0600595C RID: 22876 RVA: 0x00143790 File Offset: 0x00141990
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleControlRemapping._StartListeningDelayed_d__28.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600595D RID: 22877 RVA: 0x001437D0 File Offset: 0x001419D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105279, XrefRangeEnd = 105284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleControlRemapping._StartListeningDelayed_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170020AD RID: 8365
			// (get) Token: 0x0600595E RID: 22878 RVA: 0x00143804 File Offset: 0x00141A04
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleControlRemapping._StartListeningDelayed_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600595F RID: 22879 RVA: 0x00033302 File Offset: 0x00031502
			public _StartListeningDelayed_d__28(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170020A7 RID: 8359
			// (get) Token: 0x06005960 RID: 22880 RVA: 0x00143844 File Offset: 0x00141A44
			// (set) Token: 0x06005961 RID: 22881 RVA: 0x0003330B File Offset: 0x0003150B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping._StartListeningDelayed_d__28.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping._StartListeningDelayed_d__28.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170020A8 RID: 8360
			// (get) Token: 0x06005962 RID: 22882 RVA: 0x0014386C File Offset: 0x00141A6C
			// (set) Token: 0x06005963 RID: 22883 RVA: 0x00033326 File Offset: 0x00031526
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping._StartListeningDelayed_d__28.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping._StartListeningDelayed_d__28.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170020A9 RID: 8361
			// (get) Token: 0x06005964 RID: 22884 RVA: 0x0014389C File Offset: 0x00141A9C
			// (set) Token: 0x06005965 RID: 22885 RVA: 0x00033345 File Offset: 0x00031545
			public unsafe SimpleControlRemapping __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping._StartListeningDelayed_d__28.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SimpleControlRemapping>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping._StartListeningDelayed_d__28.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170020AA RID: 8362
			// (get) Token: 0x06005966 RID: 22886 RVA: 0x001438CC File Offset: 0x00141ACC
			// (set) Token: 0x06005967 RID: 22887 RVA: 0x00033364 File Offset: 0x00031564
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping._StartListeningDelayed_d__28.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping._StartListeningDelayed_d__28.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x170020AB RID: 8363
			// (get) Token: 0x06005968 RID: 22888 RVA: 0x001438F4 File Offset: 0x00141AF4
			// (set) Token: 0x06005969 RID: 22889 RVA: 0x0003337F File Offset: 0x0003157F
			public unsafe int actionElementMapToReplaceId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping._StartListeningDelayed_d__28.NativeFieldInfoPtr_actionElementMapToReplaceId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping._StartListeningDelayed_d__28.NativeFieldInfoPtr_actionElementMapToReplaceId)) = value;
				}
			}

			// Token: 0x04003B55 RID: 15189
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003B56 RID: 15190
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003B57 RID: 15191
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003B58 RID: 15192
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x04003B59 RID: 15193
			private static readonly IntPtr NativeFieldInfoPtr_actionElementMapToReplaceId;

			// Token: 0x04003B5A RID: 15194
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003B5B RID: 15195
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003B5C RID: 15196
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003B5D RID: 15197
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003B5E RID: 15198
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003B5F RID: 15199
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
