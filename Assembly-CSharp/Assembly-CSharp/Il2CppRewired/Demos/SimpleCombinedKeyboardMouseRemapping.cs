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
	// Token: 0x0200021A RID: 538
	public class SimpleCombinedKeyboardMouseRemapping : MonoBehaviour
	{
		// Token: 0x06004159 RID: 16729 RVA: 0x000F3888 File Offset: 0x000F1A88
		// Note: this type is marked as 'beforefieldinit'.
		static SimpleCombinedKeyboardMouseRemapping()
		{
			Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Demos", "SimpleCombinedKeyboardMouseRemapping");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr);
			SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, "category");
			SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_layout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, "layout");
			SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_uiCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, "uiCategory");
			SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_inputMapper_keyboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, "inputMapper_keyboard");
			SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_inputMapper_mouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, "inputMapper_mouse");
			SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_buttonPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, "buttonPrefab");
			SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_textPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, "textPrefab");
			SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_fieldGroupTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, "fieldGroupTransform");
			SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_actionGroupTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, "actionGroupTransform");
			SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_controllerNameUIText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, "controllerNameUIText");
			SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_statusUIText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, "statusUIText");
			SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_rows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, "rows");
			SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr__replaceTargetMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, "_replaceTargetMapping");
			SimpleCombinedKeyboardMouseRemapping.NativeMethodInfoPtr_get_player_Private_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, 100669670);
			SimpleCombinedKeyboardMouseRemapping.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, 100669671);
			SimpleCombinedKeyboardMouseRemapping.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, 100669672);
			SimpleCombinedKeyboardMouseRemapping.NativeMethodInfoPtr_RedrawUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, 100669673);
			SimpleCombinedKeyboardMouseRemapping.NativeMethodInfoPtr_ClearUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, 100669674);
			SimpleCombinedKeyboardMouseRemapping.NativeMethodInfoPtr_InitializeUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, 100669675);
			SimpleCombinedKeyboardMouseRemapping.NativeMethodInfoPtr_CreateUIRow_Private_Void_InputAction_AxisRange_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, 100669676);
			SimpleCombinedKeyboardMouseRemapping.NativeMethodInfoPtr_OnInputFieldClicked_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, 100669677);
			SimpleCombinedKeyboardMouseRemapping.NativeMethodInfoPtr_StartListeningDelayed_Private_IEnumerator_Int32_ControllerMap_ControllerMap_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, 100669678);
			SimpleCombinedKeyboardMouseRemapping.NativeMethodInfoPtr_OnInputMapped_Private_Void_InputMappedEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, 100669679);
			SimpleCombinedKeyboardMouseRemapping.NativeMethodInfoPtr_OnStopped_Private_Void_StoppedEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, 100669680);
			SimpleCombinedKeyboardMouseRemapping.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, 100669681);
		}

		// Token: 0x170018B3 RID: 6323
		// (get) Token: 0x0600415A RID: 16730 RVA: 0x000F3AAC File Offset: 0x000F1CAC
		public unsafe Player player
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 104970, RefRangeEnd = 104973, XrefRangeStart = 104964, XrefRangeEnd = 104970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCombinedKeyboardMouseRemapping.NativeMethodInfoPtr_get_player_Private_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
		}

		// Token: 0x0600415B RID: 16731 RVA: 0x000F3AEC File Offset: 0x000F1CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104973, XrefRangeEnd = 105006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCombinedKeyboardMouseRemapping.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600415C RID: 16732 RVA: 0x000F3B20 File Offset: 0x000F1D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105006, XrefRangeEnd = 105015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCombinedKeyboardMouseRemapping.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600415D RID: 16733 RVA: 0x000F3B54 File Offset: 0x000F1D54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 105053, RefRangeEnd = 105055, XrefRangeStart = 105015, XrefRangeEnd = 105053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RedrawUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCombinedKeyboardMouseRemapping.NativeMethodInfoPtr_RedrawUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600415E RID: 16734 RVA: 0x000F3B88 File Offset: 0x000F1D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105055, XrefRangeEnd = 105061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCombinedKeyboardMouseRemapping.NativeMethodInfoPtr_ClearUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600415F RID: 16735 RVA: 0x000F3BBC File Offset: 0x000F1DBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 105152, RefRangeEnd = 105153, XrefRangeStart = 105061, XrefRangeEnd = 105152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCombinedKeyboardMouseRemapping.NativeMethodInfoPtr_InitializeUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004160 RID: 16736 RVA: 0x000F3BF0 File Offset: 0x000F1DF0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 105208, RefRangeEnd = 105212, XrefRangeStart = 105153, XrefRangeEnd = 105208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCombinedKeyboardMouseRemapping.NativeMethodInfoPtr_CreateUIRow_Private_Void_InputAction_AxisRange_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004161 RID: 16737 RVA: 0x000F3C54 File Offset: 0x000F1E54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 105227, RefRangeEnd = 105228, XrefRangeStart = 105212, XrefRangeEnd = 105227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCombinedKeyboardMouseRemapping.NativeMethodInfoPtr_OnInputFieldClicked_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004162 RID: 16738 RVA: 0x000F3CA0 File Offset: 0x000F1EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105228, XrefRangeEnd = 105231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator StartListeningDelayed(int index, ControllerMap keyboardMap, ControllerMap mouseMap, int actionElementMapToReplaceId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keyboardMap);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mouseMap);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionElementMapToReplaceId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCombinedKeyboardMouseRemapping.NativeMethodInfoPtr_StartListeningDelayed_Private_IEnumerator_Int32_ControllerMap_ControllerMap_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004163 RID: 16739 RVA: 0x000F3D20 File Offset: 0x000F1F20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105231, XrefRangeEnd = 105239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnInputMapped(InputMapper.InputMappedEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCombinedKeyboardMouseRemapping.NativeMethodInfoPtr_OnInputMapped_Private_Void_InputMappedEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004164 RID: 16740 RVA: 0x000F3D64 File Offset: 0x000F1F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105239, XrefRangeEnd = 105250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnStopped(InputMapper.StoppedEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCombinedKeyboardMouseRemapping.NativeMethodInfoPtr_OnStopped_Private_Void_StoppedEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004165 RID: 16741 RVA: 0x000F3DA8 File Offset: 0x000F1FA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105250, XrefRangeEnd = 105266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SimpleCombinedKeyboardMouseRemapping()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCombinedKeyboardMouseRemapping.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004166 RID: 16742 RVA: 0x00027E02 File Offset: 0x00026002
		public SimpleCombinedKeyboardMouseRemapping(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170018A6 RID: 6310
		// (get) Token: 0x06004167 RID: 16743 RVA: 0x000F3DE4 File Offset: 0x000F1FE4
		// (set) Token: 0x06004168 RID: 16744 RVA: 0x00027E0B File Offset: 0x0002600B
		public unsafe static string category
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_category, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_category, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170018A7 RID: 6311
		// (get) Token: 0x06004169 RID: 16745 RVA: 0x000F3E04 File Offset: 0x000F2004
		// (set) Token: 0x0600416A RID: 16746 RVA: 0x00027E1D File Offset: 0x0002601D
		public unsafe static string layout
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_layout, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_layout, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170018A8 RID: 6312
		// (get) Token: 0x0600416B RID: 16747 RVA: 0x000F3E24 File Offset: 0x000F2024
		// (set) Token: 0x0600416C RID: 16748 RVA: 0x00027E2F File Offset: 0x0002602F
		public unsafe static string uiCategory
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_uiCategory, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_uiCategory, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170018A9 RID: 6313
		// (get) Token: 0x0600416D RID: 16749 RVA: 0x000F3E44 File Offset: 0x000F2044
		// (set) Token: 0x0600416E RID: 16750 RVA: 0x00027E41 File Offset: 0x00026041
		public unsafe InputMapper inputMapper_keyboard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_inputMapper_keyboard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputMapper>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_inputMapper_keyboard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018AA RID: 6314
		// (get) Token: 0x0600416F RID: 16751 RVA: 0x000F3E74 File Offset: 0x000F2074
		// (set) Token: 0x06004170 RID: 16752 RVA: 0x00027E60 File Offset: 0x00026060
		public unsafe InputMapper inputMapper_mouse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_inputMapper_mouse);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputMapper>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_inputMapper_mouse), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018AB RID: 6315
		// (get) Token: 0x06004171 RID: 16753 RVA: 0x000F3EA4 File Offset: 0x000F20A4
		// (set) Token: 0x06004172 RID: 16754 RVA: 0x00027E7F File Offset: 0x0002607F
		public unsafe GameObject buttonPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_buttonPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_buttonPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018AC RID: 6316
		// (get) Token: 0x06004173 RID: 16755 RVA: 0x000F3ED4 File Offset: 0x000F20D4
		// (set) Token: 0x06004174 RID: 16756 RVA: 0x00027E9E File Offset: 0x0002609E
		public unsafe GameObject textPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_textPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_textPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018AD RID: 6317
		// (get) Token: 0x06004175 RID: 16757 RVA: 0x000F3F04 File Offset: 0x000F2104
		// (set) Token: 0x06004176 RID: 16758 RVA: 0x00027EBD File Offset: 0x000260BD
		public unsafe RectTransform fieldGroupTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_fieldGroupTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_fieldGroupTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018AE RID: 6318
		// (get) Token: 0x06004177 RID: 16759 RVA: 0x000F3F34 File Offset: 0x000F2134
		// (set) Token: 0x06004178 RID: 16760 RVA: 0x00027EDC File Offset: 0x000260DC
		public unsafe RectTransform actionGroupTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_actionGroupTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_actionGroupTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018AF RID: 6319
		// (get) Token: 0x06004179 RID: 16761 RVA: 0x000F3F64 File Offset: 0x000F2164
		// (set) Token: 0x0600417A RID: 16762 RVA: 0x00027EFB File Offset: 0x000260FB
		public unsafe Text controllerNameUIText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_controllerNameUIText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_controllerNameUIText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018B0 RID: 6320
		// (get) Token: 0x0600417B RID: 16763 RVA: 0x000F3F94 File Offset: 0x000F2194
		// (set) Token: 0x0600417C RID: 16764 RVA: 0x00027F1A File Offset: 0x0002611A
		public unsafe Text statusUIText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_statusUIText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_statusUIText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018B1 RID: 6321
		// (get) Token: 0x0600417D RID: 16765 RVA: 0x000F3FC4 File Offset: 0x000F21C4
		// (set) Token: 0x0600417E RID: 16766 RVA: 0x00027F39 File Offset: 0x00026139
		public unsafe List<SimpleCombinedKeyboardMouseRemapping.Row> rows
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_rows);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SimpleCombinedKeyboardMouseRemapping.Row>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_rows), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018B2 RID: 6322
		// (get) Token: 0x0600417F RID: 16767 RVA: 0x000F3FF4 File Offset: 0x000F21F4
		// (set) Token: 0x06004180 RID: 16768 RVA: 0x00027F58 File Offset: 0x00026158
		public SimpleCombinedKeyboardMouseRemapping.TargetMapping _replaceTargetMapping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr__replaceTargetMapping);
				return new SimpleCombinedKeyboardMouseRemapping.TargetMapping(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping.TargetMapping>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr__replaceTargetMapping), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping.TargetMapping>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04002825 RID: 10277
		private static readonly IntPtr NativeFieldInfoPtr_category;

		// Token: 0x04002826 RID: 10278
		private static readonly IntPtr NativeFieldInfoPtr_layout;

		// Token: 0x04002827 RID: 10279
		private static readonly IntPtr NativeFieldInfoPtr_uiCategory;

		// Token: 0x04002828 RID: 10280
		private static readonly IntPtr NativeFieldInfoPtr_inputMapper_keyboard;

		// Token: 0x04002829 RID: 10281
		private static readonly IntPtr NativeFieldInfoPtr_inputMapper_mouse;

		// Token: 0x0400282A RID: 10282
		private static readonly IntPtr NativeFieldInfoPtr_buttonPrefab;

		// Token: 0x0400282B RID: 10283
		private static readonly IntPtr NativeFieldInfoPtr_textPrefab;

		// Token: 0x0400282C RID: 10284
		private static readonly IntPtr NativeFieldInfoPtr_fieldGroupTransform;

		// Token: 0x0400282D RID: 10285
		private static readonly IntPtr NativeFieldInfoPtr_actionGroupTransform;

		// Token: 0x0400282E RID: 10286
		private static readonly IntPtr NativeFieldInfoPtr_controllerNameUIText;

		// Token: 0x0400282F RID: 10287
		private static readonly IntPtr NativeFieldInfoPtr_statusUIText;

		// Token: 0x04002830 RID: 10288
		private static readonly IntPtr NativeFieldInfoPtr_rows;

		// Token: 0x04002831 RID: 10289
		private static readonly IntPtr NativeFieldInfoPtr__replaceTargetMapping;

		// Token: 0x04002832 RID: 10290
		private static readonly IntPtr NativeMethodInfoPtr_get_player_Private_get_Player_0;

		// Token: 0x04002833 RID: 10291
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04002834 RID: 10292
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04002835 RID: 10293
		private static readonly IntPtr NativeMethodInfoPtr_RedrawUI_Private_Void_0;

		// Token: 0x04002836 RID: 10294
		private static readonly IntPtr NativeMethodInfoPtr_ClearUI_Private_Void_0;

		// Token: 0x04002837 RID: 10295
		private static readonly IntPtr NativeMethodInfoPtr_InitializeUI_Private_Void_0;

		// Token: 0x04002838 RID: 10296
		private static readonly IntPtr NativeMethodInfoPtr_CreateUIRow_Private_Void_InputAction_AxisRange_String_0;

		// Token: 0x04002839 RID: 10297
		private static readonly IntPtr NativeMethodInfoPtr_OnInputFieldClicked_Private_Void_Int32_Int32_0;

		// Token: 0x0400283A RID: 10298
		private static readonly IntPtr NativeMethodInfoPtr_StartListeningDelayed_Private_IEnumerator_Int32_ControllerMap_ControllerMap_Int32_0;

		// Token: 0x0400283B RID: 10299
		private static readonly IntPtr NativeMethodInfoPtr_OnInputMapped_Private_Void_InputMappedEventData_0;

		// Token: 0x0400283C RID: 10300
		private static readonly IntPtr NativeMethodInfoPtr_OnStopped_Private_Void_StoppedEventData_0;

		// Token: 0x0400283D RID: 10301
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003AB RID: 939
		public class Row : global::Il2CppSystem.Object
		{
			// Token: 0x06005911 RID: 22801 RVA: 0x00142B48 File Offset: 0x00140D48
			// Note: this type is marked as 'beforefieldinit'.
			static Row()
			{
				Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping.Row>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, "Row");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping.Row>.NativeClassPtr);
				SimpleCombinedKeyboardMouseRemapping.Row.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping.Row>.NativeClassPtr, "action");
				SimpleCombinedKeyboardMouseRemapping.Row.NativeFieldInfoPtr_actionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping.Row>.NativeClassPtr, "actionRange");
				SimpleCombinedKeyboardMouseRemapping.Row.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping.Row>.NativeClassPtr, "button");
				SimpleCombinedKeyboardMouseRemapping.Row.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping.Row>.NativeClassPtr, "text");
				SimpleCombinedKeyboardMouseRemapping.Row.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping.Row>.NativeClassPtr, 100669682);
			}

			// Token: 0x06005912 RID: 22802 RVA: 0x00142BD8 File Offset: 0x00140DD8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Row()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping.Row>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCombinedKeyboardMouseRemapping.Row.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005913 RID: 22803 RVA: 0x00033019 File Offset: 0x00031219
			public Row(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700208E RID: 8334
			// (get) Token: 0x06005914 RID: 22804 RVA: 0x00142C14 File Offset: 0x00140E14
			// (set) Token: 0x06005915 RID: 22805 RVA: 0x00033022 File Offset: 0x00031222
			public unsafe InputAction action
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.Row.NativeFieldInfoPtr_action);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.Row.NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700208F RID: 8335
			// (get) Token: 0x06005916 RID: 22806 RVA: 0x00142C44 File Offset: 0x00140E44
			// (set) Token: 0x06005917 RID: 22807 RVA: 0x00033041 File Offset: 0x00031241
			public unsafe AxisRange actionRange
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.Row.NativeFieldInfoPtr_actionRange);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.Row.NativeFieldInfoPtr_actionRange)) = value;
				}
			}

			// Token: 0x17002090 RID: 8336
			// (get) Token: 0x06005918 RID: 22808 RVA: 0x00142C6C File Offset: 0x00140E6C
			// (set) Token: 0x06005919 RID: 22809 RVA: 0x0003305C File Offset: 0x0003125C
			public unsafe Button button
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.Row.NativeFieldInfoPtr_button);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.Row.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002091 RID: 8337
			// (get) Token: 0x0600591A RID: 22810 RVA: 0x00142C9C File Offset: 0x00140E9C
			// (set) Token: 0x0600591B RID: 22811 RVA: 0x0003307B File Offset: 0x0003127B
			public unsafe Text text
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.Row.NativeFieldInfoPtr_text);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.Row.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003B32 RID: 15154
			private static readonly IntPtr NativeFieldInfoPtr_action;

			// Token: 0x04003B33 RID: 15155
			private static readonly IntPtr NativeFieldInfoPtr_actionRange;

			// Token: 0x04003B34 RID: 15156
			private static readonly IntPtr NativeFieldInfoPtr_button;

			// Token: 0x04003B35 RID: 15157
			private static readonly IntPtr NativeFieldInfoPtr_text;

			// Token: 0x04003B36 RID: 15158
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020003AC RID: 940
		public sealed class TargetMapping : ValueType
		{
			// Token: 0x0600591C RID: 22812 RVA: 0x00142CCC File Offset: 0x00140ECC
			// Note: this type is marked as 'beforefieldinit'.
			static TargetMapping()
			{
				Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping.TargetMapping>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, "TargetMapping");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping.TargetMapping>.NativeClassPtr);
				SimpleCombinedKeyboardMouseRemapping.TargetMapping.NativeFieldInfoPtr_controllerMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping.TargetMapping>.NativeClassPtr, "controllerMap");
				SimpleCombinedKeyboardMouseRemapping.TargetMapping.NativeFieldInfoPtr_actionElementMapId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping.TargetMapping>.NativeClassPtr, "actionElementMapId");
			}

			// Token: 0x0600591D RID: 22813 RVA: 0x0003309A File Offset: 0x0003129A
			public TargetMapping(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600591E RID: 22814 RVA: 0x000330A3 File Offset: 0x000312A3
			public TargetMapping()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping.TargetMapping>.NativeClassPtr))
			{
			}

			// Token: 0x17002092 RID: 8338
			// (get) Token: 0x0600591F RID: 22815 RVA: 0x00142D20 File Offset: 0x00140F20
			// (set) Token: 0x06005920 RID: 22816 RVA: 0x000330B5 File Offset: 0x000312B5
			public unsafe ControllerMap controllerMap
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.TargetMapping.NativeFieldInfoPtr_controllerMap);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerMap>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.TargetMapping.NativeFieldInfoPtr_controllerMap), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002093 RID: 8339
			// (get) Token: 0x06005921 RID: 22817 RVA: 0x00142D50 File Offset: 0x00140F50
			// (set) Token: 0x06005922 RID: 22818 RVA: 0x000330D4 File Offset: 0x000312D4
			public unsafe int actionElementMapId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.TargetMapping.NativeFieldInfoPtr_actionElementMapId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.TargetMapping.NativeFieldInfoPtr_actionElementMapId)) = value;
				}
			}

			// Token: 0x04003B37 RID: 15159
			private static readonly IntPtr NativeFieldInfoPtr_controllerMap;

			// Token: 0x04003B38 RID: 15160
			private static readonly IntPtr NativeFieldInfoPtr_actionElementMapId;
		}

		// Token: 0x020003AD RID: 941
		[ObfuscatedName("Rewired.Demos.SimpleCombinedKeyboardMouseRemapping+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06005923 RID: 22819 RVA: 0x00142D78 File Offset: 0x00140F78
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping.__c__DisplayClass17_0>.NativeClassPtr);
				SimpleCombinedKeyboardMouseRemapping.__c__DisplayClass17_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping.__c__DisplayClass17_0>.NativeClassPtr, "index");
				SimpleCombinedKeyboardMouseRemapping.__c__DisplayClass17_0.NativeFieldInfoPtr_actionElementMapId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping.__c__DisplayClass17_0>.NativeClassPtr, "actionElementMapId");
				SimpleCombinedKeyboardMouseRemapping.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping.__c__DisplayClass17_0>.NativeClassPtr, "<>4__this");
				SimpleCombinedKeyboardMouseRemapping.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping.__c__DisplayClass17_0>.NativeClassPtr, 100669683);
				SimpleCombinedKeyboardMouseRemapping.__c__DisplayClass17_0.NativeMethodInfoPtr__RedrawUI_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping.__c__DisplayClass17_0>.NativeClassPtr, 100669684);
			}

			// Token: 0x06005924 RID: 22820 RVA: 0x00142E08 File Offset: 0x00141008
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCombinedKeyboardMouseRemapping.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005925 RID: 22821 RVA: 0x00142E44 File Offset: 0x00141044
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104950, XrefRangeEnd = 104952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RedrawUI_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCombinedKeyboardMouseRemapping.__c__DisplayClass17_0.NativeMethodInfoPtr__RedrawUI_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005926 RID: 22822 RVA: 0x000330EF File Offset: 0x000312EF
			public __c__DisplayClass17_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002094 RID: 8340
			// (get) Token: 0x06005927 RID: 22823 RVA: 0x00142E78 File Offset: 0x00141078
			// (set) Token: 0x06005928 RID: 22824 RVA: 0x000330F8 File Offset: 0x000312F8
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.__c__DisplayClass17_0.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.__c__DisplayClass17_0.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x17002095 RID: 8341
			// (get) Token: 0x06005929 RID: 22825 RVA: 0x00142EA0 File Offset: 0x001410A0
			// (set) Token: 0x0600592A RID: 22826 RVA: 0x00033113 File Offset: 0x00031313
			public unsafe int actionElementMapId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.__c__DisplayClass17_0.NativeFieldInfoPtr_actionElementMapId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.__c__DisplayClass17_0.NativeFieldInfoPtr_actionElementMapId)) = value;
				}
			}

			// Token: 0x17002096 RID: 8342
			// (get) Token: 0x0600592B RID: 22827 RVA: 0x00142EC8 File Offset: 0x001410C8
			// (set) Token: 0x0600592C RID: 22828 RVA: 0x0003312E File Offset: 0x0003132E
			public unsafe SimpleCombinedKeyboardMouseRemapping __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SimpleCombinedKeyboardMouseRemapping>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003B39 RID: 15161
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x04003B3A RID: 15162
			private static readonly IntPtr NativeFieldInfoPtr_actionElementMapId;

			// Token: 0x04003B3B RID: 15163
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003B3C RID: 15164
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003B3D RID: 15165
			private static readonly IntPtr NativeMethodInfoPtr__RedrawUI_b__0_Internal_Void_0;
		}

		// Token: 0x020003AE RID: 942
		[ObfuscatedName("Rewired.Demos.SimpleCombinedKeyboardMouseRemapping+<StartListeningDelayed>d__22")]
		public sealed class _StartListeningDelayed_d__22 : global::Il2CppSystem.Object
		{
			// Token: 0x0600592D RID: 22829 RVA: 0x00142EF8 File Offset: 0x001410F8
			// Note: this type is marked as 'beforefieldinit'.
			static _StartListeningDelayed_d__22()
			{
				Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, "<StartListeningDelayed>d__22");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22>.NativeClassPtr);
				SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22>.NativeClassPtr, "<>1__state");
				SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22>.NativeClassPtr, "<>2__current");
				SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22>.NativeClassPtr, "<>4__this");
				SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22>.NativeClassPtr, "index");
				SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeFieldInfoPtr_keyboardMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22>.NativeClassPtr, "keyboardMap");
				SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeFieldInfoPtr_actionElementMapToReplaceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22>.NativeClassPtr, "actionElementMapToReplaceId");
				SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeFieldInfoPtr_mouseMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22>.NativeClassPtr, "mouseMap");
				SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22>.NativeClassPtr, 100669685);
				SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22>.NativeClassPtr, 100669686);
				SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22>.NativeClassPtr, 100669687);
				SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22>.NativeClassPtr, 100669688);
				SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22>.NativeClassPtr, 100669689);
				SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22>.NativeClassPtr, 100669690);
			}

			// Token: 0x0600592E RID: 22830 RVA: 0x00143028 File Offset: 0x00141228
			[CallerCount(0)]
			public unsafe _StartListeningDelayed_d__22(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600592F RID: 22831 RVA: 0x00143070 File Offset: 0x00141270
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005930 RID: 22832 RVA: 0x001430A4 File Offset: 0x001412A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104952, XrefRangeEnd = 104959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700209E RID: 8350
			// (get) Token: 0x06005931 RID: 22833 RVA: 0x001430E0 File Offset: 0x001412E0
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005932 RID: 22834 RVA: 0x00143120 File Offset: 0x00141320
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104959, XrefRangeEnd = 104964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700209F RID: 8351
			// (get) Token: 0x06005933 RID: 22835 RVA: 0x00143154 File Offset: 0x00141354
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005934 RID: 22836 RVA: 0x0003314D File Offset: 0x0003134D
			public _StartListeningDelayed_d__22(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002097 RID: 8343
			// (get) Token: 0x06005935 RID: 22837 RVA: 0x00143194 File Offset: 0x00141394
			// (set) Token: 0x06005936 RID: 22838 RVA: 0x00033156 File Offset: 0x00031356
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002098 RID: 8344
			// (get) Token: 0x06005937 RID: 22839 RVA: 0x001431BC File Offset: 0x001413BC
			// (set) Token: 0x06005938 RID: 22840 RVA: 0x00033171 File Offset: 0x00031371
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002099 RID: 8345
			// (get) Token: 0x06005939 RID: 22841 RVA: 0x001431EC File Offset: 0x001413EC
			// (set) Token: 0x0600593A RID: 22842 RVA: 0x00033190 File Offset: 0x00031390
			public unsafe SimpleCombinedKeyboardMouseRemapping __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SimpleCombinedKeyboardMouseRemapping>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700209A RID: 8346
			// (get) Token: 0x0600593B RID: 22843 RVA: 0x0014321C File Offset: 0x0014141C
			// (set) Token: 0x0600593C RID: 22844 RVA: 0x000331AF File Offset: 0x000313AF
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x1700209B RID: 8347
			// (get) Token: 0x0600593D RID: 22845 RVA: 0x00143244 File Offset: 0x00141444
			// (set) Token: 0x0600593E RID: 22846 RVA: 0x000331CA File Offset: 0x000313CA
			public unsafe ControllerMap keyboardMap
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeFieldInfoPtr_keyboardMap);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerMap>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeFieldInfoPtr_keyboardMap), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700209C RID: 8348
			// (get) Token: 0x0600593F RID: 22847 RVA: 0x00143274 File Offset: 0x00141474
			// (set) Token: 0x06005940 RID: 22848 RVA: 0x000331E9 File Offset: 0x000313E9
			public unsafe int actionElementMapToReplaceId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeFieldInfoPtr_actionElementMapToReplaceId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeFieldInfoPtr_actionElementMapToReplaceId)) = value;
				}
			}

			// Token: 0x1700209D RID: 8349
			// (get) Token: 0x06005941 RID: 22849 RVA: 0x0014329C File Offset: 0x0014149C
			// (set) Token: 0x06005942 RID: 22850 RVA: 0x00033204 File Offset: 0x00031404
			public unsafe ControllerMap mouseMap
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeFieldInfoPtr_mouseMap);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerMap>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeFieldInfoPtr_mouseMap), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003B3E RID: 15166
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003B3F RID: 15167
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003B40 RID: 15168
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003B41 RID: 15169
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x04003B42 RID: 15170
			private static readonly IntPtr NativeFieldInfoPtr_keyboardMap;

			// Token: 0x04003B43 RID: 15171
			private static readonly IntPtr NativeFieldInfoPtr_actionElementMapToReplaceId;

			// Token: 0x04003B44 RID: 15172
			private static readonly IntPtr NativeFieldInfoPtr_mouseMap;

			// Token: 0x04003B45 RID: 15173
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003B46 RID: 15174
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003B47 RID: 15175
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003B48 RID: 15176
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003B49 RID: 15177
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003B4A RID: 15178
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
