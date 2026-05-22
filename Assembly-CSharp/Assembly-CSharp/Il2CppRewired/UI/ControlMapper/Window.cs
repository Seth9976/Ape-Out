using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppRewired.UI.ControlMapper
{
	// Token: 0x02000208 RID: 520
	public class Window : MonoBehaviour
	{
		// Token: 0x06003F46 RID: 16198 RVA: 0x000EC998 File Offset: 0x000EAB98
		// Note: this type is marked as 'beforefieldinit'.
		static Window()
		{
			Il2CppClassPointerStore<Window>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.UI.ControlMapper", "Window");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Window>.NativeClassPtr);
			Window.NativeFieldInfoPtr_backgroundImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Window>.NativeClassPtr, "backgroundImage");
			Window.NativeFieldInfoPtr_content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Window>.NativeClassPtr, "content");
			Window.NativeFieldInfoPtr__initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Window>.NativeClassPtr, "_initialized");
			Window.NativeFieldInfoPtr__id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Window>.NativeClassPtr, "_id");
			Window.NativeFieldInfoPtr__rectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Window>.NativeClassPtr, "_rectTransform");
			Window.NativeFieldInfoPtr__titleText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Window>.NativeClassPtr, "_titleText");
			Window.NativeFieldInfoPtr__contentText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Window>.NativeClassPtr, "_contentText");
			Window.NativeFieldInfoPtr__defaultUIElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Window>.NativeClassPtr, "_defaultUIElement");
			Window.NativeFieldInfoPtr__updateCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Window>.NativeClassPtr, "_updateCallback");
			Window.NativeFieldInfoPtr__isFocusedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Window>.NativeClassPtr, "_isFocusedCallback");
			Window.NativeFieldInfoPtr__timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Window>.NativeClassPtr, "_timer");
			Window.NativeFieldInfoPtr__canvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Window>.NativeClassPtr, "_canvasGroup");
			Window.NativeFieldInfoPtr_cancelCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Window>.NativeClassPtr, "cancelCallback");
			Window.NativeFieldInfoPtr_lastUISelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Window>.NativeClassPtr, "lastUISelection");
			Window.NativeMethodInfoPtr_get_hasFocus_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100669352);
			Window.NativeMethodInfoPtr_get_id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100669353);
			Window.NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100669354);
			Window.NativeMethodInfoPtr_get_titleText_Public_get_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100669355);
			Window.NativeMethodInfoPtr_get_contentText_Public_get_List_1_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100669356);
			Window.NativeMethodInfoPtr_get_defaultUIElement_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100669357);
			Window.NativeMethodInfoPtr_set_defaultUIElement_Public_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100669358);
			Window.NativeMethodInfoPtr_get_updateCallback_Public_get_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100669359);
			Window.NativeMethodInfoPtr_set_updateCallback_Public_set_Void_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100669360);
			Window.NativeMethodInfoPtr_get_timer_Public_get_Timer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100669361);
			Window.NativeMethodInfoPtr_get_width_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100669362);
			Window.NativeMethodInfoPtr_set_width_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100669363);
			Window.NativeMethodInfoPtr_get_height_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100669364);
			Window.NativeMethodInfoPtr_set_height_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100669365);
			Window.NativeMethodInfoPtr_get_initialized_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100669366);
			Window.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100669367);
			Window.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100669368);
			Window.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_Int32_Func_2_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100669369);
			Window.NativeMethodInfoPtr_SetSize_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100669370);
			Window.NativeMethodInfoPtr_CreateTitleText_Public_Void_GameObject_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100669371);
			Window.NativeMethodInfoPtr_CreateTitleText_Public_Void_GameObject_Vector2_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100669372);
			Window.NativeMethodInfoPtr_AddContentText_Public_Void_GameObject_UIPivot_UIAnchor_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100669373);
			Window.NativeMethodInfoPtr_AddContentText_Public_Void_GameObject_UIPivot_UIAnchor_Vector2_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100669374);
			Window.NativeMethodInfoPtr_AddContentImage_Public_Void_GameObject_UIPivot_UIAnchor_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100669375);
			Window.NativeMethodInfoPtr_AddContentImage_Public_Void_GameObject_UIPivot_UIAnchor_Vector2_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100669376);
			Window.NativeMethodInfoPtr_CreateButton_Public_Void_GameObject_UIPivot_UIAnchor_Vector2_String_UnityAction_UnityAction_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100669377);
			Window.NativeMethodInfoPtr_GetTitleText_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100669378);
			Window.NativeMethodInfoPtr_SetTitleText_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100669379);
			Window.NativeMethodInfoPtr_GetContentText_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100669380);
			Window.NativeMethodInfoPtr_GetContentTextHeight_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100669381);
			Window.NativeMethodInfoPtr_SetContentText_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100669382);
			Window.NativeMethodInfoPtr_SetUpdateCallback_Public_Void_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100669383);
			Window.NativeMethodInfoPtr_TakeInputFocus_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100669384);
			Window.NativeMethodInfoPtr_Enable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100669385);
			Window.NativeMethodInfoPtr_Disable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100669386);
			Window.NativeMethodInfoPtr_Cancel_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100669387);
			Window.NativeMethodInfoPtr_CreateText_Private_Void_GameObject_byref_Text_String_UIPivot_UIAnchor_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100669388);
			Window.NativeMethodInfoPtr_CreateImage_Private_Void_GameObject_String_UIPivot_UIAnchor_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100669389);
			Window.NativeMethodInfoPtr_CreateButton_Private_GameObject_GameObject_String_UIAnchor_UIPivot_Vector2_byref_ButtonInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100669390);
			Window.NativeMethodInfoPtr_OnEnableAsync_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100669391);
			Window.NativeMethodInfoPtr_CheckUISelection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100669392);
			Window.NativeMethodInfoPtr_RestoreDefaultOrLastUISelection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100669393);
			Window.NativeMethodInfoPtr_SetUISelection_Private_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100669394);
			Window.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100669395);
		}

		// Token: 0x1700181B RID: 6171
		// (get) Token: 0x06003F47 RID: 16199 RVA: 0x000ECE50 File Offset: 0x000EB050
		public unsafe bool hasFocus
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100409, XrefRangeEnd = 100412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_get_hasFocus_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700181C RID: 6172
		// (get) Token: 0x06003F48 RID: 16200 RVA: 0x000ECE8C File Offset: 0x000EB08C
		public unsafe int id
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_get_id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700181D RID: 6173
		// (get) Token: 0x06003F49 RID: 16201 RVA: 0x000ECEC8 File Offset: 0x000EB0C8
		public unsafe RectTransform rectTransform
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 100429, RefRangeEnd = 100437, XrefRangeStart = 100412, XrefRangeEnd = 100429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x1700181E RID: 6174
		// (get) Token: 0x06003F4A RID: 16202 RVA: 0x000ECF08 File Offset: 0x000EB108
		public unsafe Text titleText
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 621, RefRangeEnd = 626, XrefRangeStart = 621, XrefRangeEnd = 626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_get_titleText_Public_get_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Text>(intPtr3) : null;
			}
		}

		// Token: 0x1700181F RID: 6175
		// (get) Token: 0x06003F4B RID: 16203 RVA: 0x000ECF48 File Offset: 0x000EB148
		public unsafe List<Text> contentText
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_get_contentText_Public_get_List_1_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Text>>(intPtr3) : null;
			}
		}

		// Token: 0x17001820 RID: 6176
		// (get) Token: 0x06003F4C RID: 16204 RVA: 0x000ECF88 File Offset: 0x000EB188
		// (set) Token: 0x06003F4D RID: 16205 RVA: 0x000ECFC8 File Offset: 0x000EB1C8
		public unsafe GameObject defaultUIElement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_get_defaultUIElement_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 14747, RefRangeEnd = 14763, XrefRangeStart = 14747, XrefRangeEnd = 14763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_set_defaultUIElement_Public_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001821 RID: 6177
		// (get) Token: 0x06003F4E RID: 16206 RVA: 0x000ED00C File Offset: 0x000EB20C
		// (set) Token: 0x06003F4F RID: 16207 RVA: 0x000ED04C File Offset: 0x000EB24C
		public unsafe Action<int> updateCallback
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_get_updateCallback_Public_get_Action_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr3) : null;
			}
			[CallerCount(26)]
			[CachedScanResults(RefRangeStart = 13543, RefRangeEnd = 13569, XrefRangeStart = 13543, XrefRangeEnd = 13569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_set_updateCallback_Public_set_Void_Action_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001822 RID: 6178
		// (get) Token: 0x06003F50 RID: 16208 RVA: 0x000ED090 File Offset: 0x000EB290
		public unsafe Window.Timer timer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_get_timer_Public_get_Timer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Window.Timer>(intPtr3) : null;
			}
		}

		// Token: 0x17001823 RID: 6179
		// (get) Token: 0x06003F51 RID: 16209 RVA: 0x000ED0D0 File Offset: 0x000EB2D0
		// (set) Token: 0x06003F52 RID: 16210 RVA: 0x000ED10C File Offset: 0x000EB30C
		public unsafe int width
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100437, XrefRangeEnd = 100440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_get_width_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100440, XrefRangeEnd = 100446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_set_width_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001824 RID: 6180
		// (get) Token: 0x06003F53 RID: 16211 RVA: 0x000ED14C File Offset: 0x000EB34C
		// (set) Token: 0x06003F54 RID: 16212 RVA: 0x000ED188 File Offset: 0x000EB388
		public unsafe int height
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100446, XrefRangeEnd = 100449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_get_height_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100449, XrefRangeEnd = 100455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_set_height_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001825 RID: 6181
		// (get) Token: 0x06003F55 RID: 16213 RVA: 0x000ED1C8 File Offset: 0x000EB3C8
		public unsafe bool initialized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_get_initialized_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003F56 RID: 16214 RVA: 0x000ED204 File Offset: 0x000EB404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100455, XrefRangeEnd = 100461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F57 RID: 16215 RVA: 0x000ED238 File Offset: 0x000EB438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100461, XrefRangeEnd = 100468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Window.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F58 RID: 16216 RVA: 0x000ED274 File Offset: 0x000EB474
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 100482, RefRangeEnd = 100484, XrefRangeStart = 100468, XrefRangeEnd = 100482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(int id, Func<int, bool> isFocusedCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(isFocusedCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Window.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_Int32_Func_2_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F59 RID: 16217 RVA: 0x000ED2D0 File Offset: 0x000EB4D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100484, XrefRangeEnd = 100487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSize(int width, int height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_SetSize_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F5A RID: 16218 RVA: 0x000ED31C File Offset: 0x000EB51C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100487, XrefRangeEnd = 100490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateTitleText(GameObject prefab, Vector2 offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_CreateTitleText_Public_Void_GameObject_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F5B RID: 16219 RVA: 0x000ED36C File Offset: 0x000EB56C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 100505, RefRangeEnd = 100519, XrefRangeStart = 100490, XrefRangeEnd = 100505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateTitleText(GameObject prefab, Vector2 offset, string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_CreateTitleText_Public_Void_GameObject_Vector2_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F5C RID: 16220 RVA: 0x000ED3D0 File Offset: 0x000EB5D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100519, XrefRangeEnd = 100525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddContentText(GameObject prefab, UIPivot pivot, UIAnchor anchor, Vector2 offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pivot;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anchor;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_AddContentText_Public_Void_GameObject_UIPivot_UIAnchor_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F5D RID: 16221 RVA: 0x000ED43C File Offset: 0x000EB63C
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 100535, RefRangeEnd = 100555, XrefRangeStart = 100525, XrefRangeEnd = 100535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddContentText(GameObject prefab, UIPivot pivot, UIAnchor anchor, Vector2 offset, string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pivot;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anchor;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_AddContentText_Public_Void_GameObject_UIPivot_UIAnchor_Vector2_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F5E RID: 16222 RVA: 0x000ED4BC File Offset: 0x000EB6BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 100558, RefRangeEnd = 100561, XrefRangeStart = 100555, XrefRangeEnd = 100558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddContentImage(GameObject prefab, UIPivot pivot, UIAnchor anchor, Vector2 offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pivot;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anchor;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_AddContentImage_Public_Void_GameObject_UIPivot_UIAnchor_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F5F RID: 16223 RVA: 0x000ED528 File Offset: 0x000EB728
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 100558, RefRangeEnd = 100561, XrefRangeStart = 100558, XrefRangeEnd = 100561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddContentImage(GameObject prefab, UIPivot pivot, UIAnchor anchor, Vector2 offset, string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pivot;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anchor;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_AddContentImage_Public_Void_GameObject_UIPivot_UIAnchor_Vector2_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F60 RID: 16224 RVA: 0x000ED5A8 File Offset: 0x000EB7A8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 100623, RefRangeEnd = 100635, XrefRangeStart = 100561, XrefRangeEnd = 100623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateButton(GameObject prefab, UIPivot pivot, UIAnchor anchor, Vector2 offset, string buttonText, UnityAction confirmCallback, UnityAction cancelCallback, bool setDefault)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pivot;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anchor;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(buttonText);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(confirmCallback);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cancelCallback);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setDefault;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_CreateButton_Public_Void_GameObject_UIPivot_UIAnchor_Vector2_String_UnityAction_UnityAction_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F61 RID: 16225 RVA: 0x000ED65C File Offset: 0x000EB85C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100635, XrefRangeEnd = 100649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetTitleText(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_GetTitleText_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003F62 RID: 16226 RVA: 0x000ED6A4 File Offset: 0x000EB8A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100649, XrefRangeEnd = 100661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTitleText(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_SetTitleText_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003F63 RID: 16227 RVA: 0x000ED6E8 File Offset: 0x000EB8E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100661, XrefRangeEnd = 100678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetContentText(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_GetContentText_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003F64 RID: 16228 RVA: 0x000ED72C File Offset: 0x000EB92C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 100695, RefRangeEnd = 100696, XrefRangeStart = 100678, XrefRangeEnd = 100695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetContentTextHeight(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_GetContentTextHeight_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003F65 RID: 16229 RVA: 0x000ED778 File Offset: 0x000EB978
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 100710, RefRangeEnd = 100719, XrefRangeStart = 100696, XrefRangeEnd = 100710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetContentText(string text, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_SetContentText_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F66 RID: 16230 RVA: 0x000ED7C8 File Offset: 0x000EB9C8
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 13543, RefRangeEnd = 13569, XrefRangeStart = 13543, XrefRangeEnd = 13569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUpdateCallback(Action<int> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_SetUpdateCallback_Public_Void_Action_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003F67 RID: 16231 RVA: 0x000ED80C File Offset: 0x000EBA0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 100739, RefRangeEnd = 100741, XrefRangeStart = 100719, XrefRangeEnd = 100739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void TakeInputFocus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Window.NativeMethodInfoPtr_TakeInputFocus_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F68 RID: 16232 RVA: 0x000ED848 File Offset: 0x000EBA48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100741, XrefRangeEnd = 100746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Enable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Window.NativeMethodInfoPtr_Enable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F69 RID: 16233 RVA: 0x000ED884 File Offset: 0x000EBA84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100746, XrefRangeEnd = 100751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Window.NativeMethodInfoPtr_Disable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F6A RID: 16234 RVA: 0x000ED8C0 File Offset: 0x000EBAC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100751, XrefRangeEnd = 100752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Window.NativeMethodInfoPtr_Cancel_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F6B RID: 16235 RVA: 0x000ED8FC File Offset: 0x000EBAFC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 100799, RefRangeEnd = 100803, XrefRangeStart = 100752, XrefRangeEnd = 100799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateText(GameObject prefab, ref Text textComponent, string name, UIPivot pivot, UIAnchor anchor, Vector2 offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(textComponent);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pivot;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anchor;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_CreateText_Private_Void_GameObject_byref_Text_String_UIPivot_UIAnchor_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			textComponent = ((intPtr4 == 0) ? null : new Text(intPtr4));
		}

		// Token: 0x06003F6C RID: 16236 RVA: 0x000ED9A4 File Offset: 0x000EBBA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 100832, RefRangeEnd = 100834, XrefRangeStart = 100803, XrefRangeEnd = 100832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateImage(GameObject prefab, string name, UIPivot pivot, UIAnchor anchor, Vector2 offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pivot;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anchor;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_CreateImage_Private_Void_GameObject_String_UIPivot_UIAnchor_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F6D RID: 16237 RVA: 0x000EDA24 File Offset: 0x000EBC24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 100899, RefRangeEnd = 100900, XrefRangeStart = 100834, XrefRangeEnd = 100899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObject CreateButton(GameObject prefab, string name, UIAnchor anchor, UIPivot pivot, Vector2 offset, out ButtonInfo buttonInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anchor;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pivot;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_CreateButton_Private_GameObject_GameObject_String_UIAnchor_UIPivot_Vector2_byref_ButtonInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			buttonInfo = ((intPtr4 == 0) ? null : new ButtonInfo(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr5) : null;
		}

		// Token: 0x06003F6E RID: 16238 RVA: 0x000EDAD4 File Offset: 0x000EBCD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100900, XrefRangeEnd = 100903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator OnEnableAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_OnEnableAsync_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06003F6F RID: 16239 RVA: 0x000EDB14 File Offset: 0x000EBD14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 100940, RefRangeEnd = 100942, XrefRangeStart = 100903, XrefRangeEnd = 100940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckUISelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_CheckUISelection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F70 RID: 16240 RVA: 0x000EDB48 File Offset: 0x000EBD48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 100961, RefRangeEnd = 100962, XrefRangeStart = 100942, XrefRangeEnd = 100961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RestoreDefaultOrLastUISelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_RestoreDefaultOrLastUISelection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F71 RID: 16241 RVA: 0x000EDB7C File Offset: 0x000EBD7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 100982, RefRangeEnd = 100983, XrefRangeStart = 100962, XrefRangeEnd = 100982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUISelection(GameObject selection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_SetUISelection_Private_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003F72 RID: 16242 RVA: 0x000EDBC0 File Offset: 0x000EBDC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Window()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Window>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F73 RID: 16243 RVA: 0x00026E9C File Offset: 0x0002509C
		public Window(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700180D RID: 6157
		// (get) Token: 0x06003F74 RID: 16244 RVA: 0x000EDBFC File Offset: 0x000EBDFC
		// (set) Token: 0x06003F75 RID: 16245 RVA: 0x00026EA5 File Offset: 0x000250A5
		public unsafe Image backgroundImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Window.NativeFieldInfoPtr_backgroundImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Window.NativeFieldInfoPtr_backgroundImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700180E RID: 6158
		// (get) Token: 0x06003F76 RID: 16246 RVA: 0x000EDC2C File Offset: 0x000EBE2C
		// (set) Token: 0x06003F77 RID: 16247 RVA: 0x00026EC4 File Offset: 0x000250C4
		public unsafe GameObject content
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Window.NativeFieldInfoPtr_content);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Window.NativeFieldInfoPtr_content), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700180F RID: 6159
		// (get) Token: 0x06003F78 RID: 16248 RVA: 0x000EDC5C File Offset: 0x000EBE5C
		// (set) Token: 0x06003F79 RID: 16249 RVA: 0x00026EE3 File Offset: 0x000250E3
		public unsafe bool _initialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Window.NativeFieldInfoPtr__initialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Window.NativeFieldInfoPtr__initialized)) = value;
			}
		}

		// Token: 0x17001810 RID: 6160
		// (get) Token: 0x06003F7A RID: 16250 RVA: 0x000EDC84 File Offset: 0x000EBE84
		// (set) Token: 0x06003F7B RID: 16251 RVA: 0x00026EFE File Offset: 0x000250FE
		public unsafe int _id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Window.NativeFieldInfoPtr__id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Window.NativeFieldInfoPtr__id)) = value;
			}
		}

		// Token: 0x17001811 RID: 6161
		// (get) Token: 0x06003F7C RID: 16252 RVA: 0x000EDCAC File Offset: 0x000EBEAC
		// (set) Token: 0x06003F7D RID: 16253 RVA: 0x00026F19 File Offset: 0x00025119
		public unsafe RectTransform _rectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Window.NativeFieldInfoPtr__rectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Window.NativeFieldInfoPtr__rectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001812 RID: 6162
		// (get) Token: 0x06003F7E RID: 16254 RVA: 0x000EDCDC File Offset: 0x000EBEDC
		// (set) Token: 0x06003F7F RID: 16255 RVA: 0x00026F38 File Offset: 0x00025138
		public unsafe Text _titleText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Window.NativeFieldInfoPtr__titleText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Window.NativeFieldInfoPtr__titleText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001813 RID: 6163
		// (get) Token: 0x06003F80 RID: 16256 RVA: 0x000EDD0C File Offset: 0x000EBF0C
		// (set) Token: 0x06003F81 RID: 16257 RVA: 0x00026F57 File Offset: 0x00025157
		public unsafe List<Text> _contentText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Window.NativeFieldInfoPtr__contentText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Text>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Window.NativeFieldInfoPtr__contentText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001814 RID: 6164
		// (get) Token: 0x06003F82 RID: 16258 RVA: 0x000EDD3C File Offset: 0x000EBF3C
		// (set) Token: 0x06003F83 RID: 16259 RVA: 0x00026F76 File Offset: 0x00025176
		public unsafe GameObject _defaultUIElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Window.NativeFieldInfoPtr__defaultUIElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Window.NativeFieldInfoPtr__defaultUIElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001815 RID: 6165
		// (get) Token: 0x06003F84 RID: 16260 RVA: 0x000EDD6C File Offset: 0x000EBF6C
		// (set) Token: 0x06003F85 RID: 16261 RVA: 0x00026F95 File Offset: 0x00025195
		public unsafe Action<int> _updateCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Window.NativeFieldInfoPtr__updateCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Window.NativeFieldInfoPtr__updateCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001816 RID: 6166
		// (get) Token: 0x06003F86 RID: 16262 RVA: 0x000EDD9C File Offset: 0x000EBF9C
		// (set) Token: 0x06003F87 RID: 16263 RVA: 0x00026FB4 File Offset: 0x000251B4
		public unsafe Func<int, bool> _isFocusedCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Window.NativeFieldInfoPtr__isFocusedCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Window.NativeFieldInfoPtr__isFocusedCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001817 RID: 6167
		// (get) Token: 0x06003F88 RID: 16264 RVA: 0x000EDDCC File Offset: 0x000EBFCC
		// (set) Token: 0x06003F89 RID: 16265 RVA: 0x00026FD3 File Offset: 0x000251D3
		public unsafe Window.Timer _timer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Window.NativeFieldInfoPtr__timer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Window.Timer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Window.NativeFieldInfoPtr__timer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001818 RID: 6168
		// (get) Token: 0x06003F8A RID: 16266 RVA: 0x000EDDFC File Offset: 0x000EBFFC
		// (set) Token: 0x06003F8B RID: 16267 RVA: 0x00026FF2 File Offset: 0x000251F2
		public unsafe CanvasGroup _canvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Window.NativeFieldInfoPtr__canvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Window.NativeFieldInfoPtr__canvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001819 RID: 6169
		// (get) Token: 0x06003F8C RID: 16268 RVA: 0x000EDE2C File Offset: 0x000EC02C
		// (set) Token: 0x06003F8D RID: 16269 RVA: 0x00027011 File Offset: 0x00025211
		public unsafe UnityAction cancelCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Window.NativeFieldInfoPtr_cancelCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Window.NativeFieldInfoPtr_cancelCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700181A RID: 6170
		// (get) Token: 0x06003F8E RID: 16270 RVA: 0x000EDE5C File Offset: 0x000EC05C
		// (set) Token: 0x06003F8F RID: 16271 RVA: 0x00027030 File Offset: 0x00025230
		public unsafe GameObject lastUISelection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Window.NativeFieldInfoPtr_lastUISelection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Window.NativeFieldInfoPtr_lastUISelection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040026BD RID: 9917
		private static readonly IntPtr NativeFieldInfoPtr_backgroundImage;

		// Token: 0x040026BE RID: 9918
		private static readonly IntPtr NativeFieldInfoPtr_content;

		// Token: 0x040026BF RID: 9919
		private static readonly IntPtr NativeFieldInfoPtr__initialized;

		// Token: 0x040026C0 RID: 9920
		private static readonly IntPtr NativeFieldInfoPtr__id;

		// Token: 0x040026C1 RID: 9921
		private static readonly IntPtr NativeFieldInfoPtr__rectTransform;

		// Token: 0x040026C2 RID: 9922
		private static readonly IntPtr NativeFieldInfoPtr__titleText;

		// Token: 0x040026C3 RID: 9923
		private static readonly IntPtr NativeFieldInfoPtr__contentText;

		// Token: 0x040026C4 RID: 9924
		private static readonly IntPtr NativeFieldInfoPtr__defaultUIElement;

		// Token: 0x040026C5 RID: 9925
		private static readonly IntPtr NativeFieldInfoPtr__updateCallback;

		// Token: 0x040026C6 RID: 9926
		private static readonly IntPtr NativeFieldInfoPtr__isFocusedCallback;

		// Token: 0x040026C7 RID: 9927
		private static readonly IntPtr NativeFieldInfoPtr__timer;

		// Token: 0x040026C8 RID: 9928
		private static readonly IntPtr NativeFieldInfoPtr__canvasGroup;

		// Token: 0x040026C9 RID: 9929
		private static readonly IntPtr NativeFieldInfoPtr_cancelCallback;

		// Token: 0x040026CA RID: 9930
		private static readonly IntPtr NativeFieldInfoPtr_lastUISelection;

		// Token: 0x040026CB RID: 9931
		private static readonly IntPtr NativeMethodInfoPtr_get_hasFocus_Public_get_Boolean_0;

		// Token: 0x040026CC RID: 9932
		private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_get_Int32_0;

		// Token: 0x040026CD RID: 9933
		private static readonly IntPtr NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0;

		// Token: 0x040026CE RID: 9934
		private static readonly IntPtr NativeMethodInfoPtr_get_titleText_Public_get_Text_0;

		// Token: 0x040026CF RID: 9935
		private static readonly IntPtr NativeMethodInfoPtr_get_contentText_Public_get_List_1_Text_0;

		// Token: 0x040026D0 RID: 9936
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultUIElement_Public_get_GameObject_0;

		// Token: 0x040026D1 RID: 9937
		private static readonly IntPtr NativeMethodInfoPtr_set_defaultUIElement_Public_set_Void_GameObject_0;

		// Token: 0x040026D2 RID: 9938
		private static readonly IntPtr NativeMethodInfoPtr_get_updateCallback_Public_get_Action_1_Int32_0;

		// Token: 0x040026D3 RID: 9939
		private static readonly IntPtr NativeMethodInfoPtr_set_updateCallback_Public_set_Void_Action_1_Int32_0;

		// Token: 0x040026D4 RID: 9940
		private static readonly IntPtr NativeMethodInfoPtr_get_timer_Public_get_Timer_0;

		// Token: 0x040026D5 RID: 9941
		private static readonly IntPtr NativeMethodInfoPtr_get_width_Public_get_Int32_0;

		// Token: 0x040026D6 RID: 9942
		private static readonly IntPtr NativeMethodInfoPtr_set_width_Public_set_Void_Int32_0;

		// Token: 0x040026D7 RID: 9943
		private static readonly IntPtr NativeMethodInfoPtr_get_height_Public_get_Int32_0;

		// Token: 0x040026D8 RID: 9944
		private static readonly IntPtr NativeMethodInfoPtr_set_height_Public_set_Void_Int32_0;

		// Token: 0x040026D9 RID: 9945
		private static readonly IntPtr NativeMethodInfoPtr_get_initialized_Protected_get_Boolean_0;

		// Token: 0x040026DA RID: 9946
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040026DB RID: 9947
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x040026DC RID: 9948
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_Int32_Func_2_Int32_Boolean_0;

		// Token: 0x040026DD RID: 9949
		private static readonly IntPtr NativeMethodInfoPtr_SetSize_Public_Void_Int32_Int32_0;

		// Token: 0x040026DE RID: 9950
		private static readonly IntPtr NativeMethodInfoPtr_CreateTitleText_Public_Void_GameObject_Vector2_0;

		// Token: 0x040026DF RID: 9951
		private static readonly IntPtr NativeMethodInfoPtr_CreateTitleText_Public_Void_GameObject_Vector2_String_0;

		// Token: 0x040026E0 RID: 9952
		private static readonly IntPtr NativeMethodInfoPtr_AddContentText_Public_Void_GameObject_UIPivot_UIAnchor_Vector2_0;

		// Token: 0x040026E1 RID: 9953
		private static readonly IntPtr NativeMethodInfoPtr_AddContentText_Public_Void_GameObject_UIPivot_UIAnchor_Vector2_String_0;

		// Token: 0x040026E2 RID: 9954
		private static readonly IntPtr NativeMethodInfoPtr_AddContentImage_Public_Void_GameObject_UIPivot_UIAnchor_Vector2_0;

		// Token: 0x040026E3 RID: 9955
		private static readonly IntPtr NativeMethodInfoPtr_AddContentImage_Public_Void_GameObject_UIPivot_UIAnchor_Vector2_String_0;

		// Token: 0x040026E4 RID: 9956
		private static readonly IntPtr NativeMethodInfoPtr_CreateButton_Public_Void_GameObject_UIPivot_UIAnchor_Vector2_String_UnityAction_UnityAction_Boolean_0;

		// Token: 0x040026E5 RID: 9957
		private static readonly IntPtr NativeMethodInfoPtr_GetTitleText_Public_String_String_0;

		// Token: 0x040026E6 RID: 9958
		private static readonly IntPtr NativeMethodInfoPtr_SetTitleText_Public_Void_String_0;

		// Token: 0x040026E7 RID: 9959
		private static readonly IntPtr NativeMethodInfoPtr_GetContentText_Public_String_Int32_0;

		// Token: 0x040026E8 RID: 9960
		private static readonly IntPtr NativeMethodInfoPtr_GetContentTextHeight_Public_Single_Int32_0;

		// Token: 0x040026E9 RID: 9961
		private static readonly IntPtr NativeMethodInfoPtr_SetContentText_Public_Void_String_Int32_0;

		// Token: 0x040026EA RID: 9962
		private static readonly IntPtr NativeMethodInfoPtr_SetUpdateCallback_Public_Void_Action_1_Int32_0;

		// Token: 0x040026EB RID: 9963
		private static readonly IntPtr NativeMethodInfoPtr_TakeInputFocus_Public_Virtual_New_Void_0;

		// Token: 0x040026EC RID: 9964
		private static readonly IntPtr NativeMethodInfoPtr_Enable_Public_Virtual_New_Void_0;

		// Token: 0x040026ED RID: 9965
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Virtual_New_Void_0;

		// Token: 0x040026EE RID: 9966
		private static readonly IntPtr NativeMethodInfoPtr_Cancel_Public_Virtual_New_Void_0;

		// Token: 0x040026EF RID: 9967
		private static readonly IntPtr NativeMethodInfoPtr_CreateText_Private_Void_GameObject_byref_Text_String_UIPivot_UIAnchor_Vector2_0;

		// Token: 0x040026F0 RID: 9968
		private static readonly IntPtr NativeMethodInfoPtr_CreateImage_Private_Void_GameObject_String_UIPivot_UIAnchor_Vector2_0;

		// Token: 0x040026F1 RID: 9969
		private static readonly IntPtr NativeMethodInfoPtr_CreateButton_Private_GameObject_GameObject_String_UIAnchor_UIPivot_Vector2_byref_ButtonInfo_0;

		// Token: 0x040026F2 RID: 9970
		private static readonly IntPtr NativeMethodInfoPtr_OnEnableAsync_Private_IEnumerator_0;

		// Token: 0x040026F3 RID: 9971
		private static readonly IntPtr NativeMethodInfoPtr_CheckUISelection_Private_Void_0;

		// Token: 0x040026F4 RID: 9972
		private static readonly IntPtr NativeMethodInfoPtr_RestoreDefaultOrLastUISelection_Private_Void_0;

		// Token: 0x040026F5 RID: 9973
		private static readonly IntPtr NativeMethodInfoPtr_SetUISelection_Private_Void_GameObject_0;

		// Token: 0x040026F6 RID: 9974
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200039B RID: 923
		public class Timer : global::Il2CppSystem.Object
		{
			// Token: 0x06005839 RID: 22585 RVA: 0x0013FED0 File Offset: 0x0013E0D0
			// Note: this type is marked as 'beforefieldinit'.
			static Timer()
			{
				Il2CppClassPointerStore<Window.Timer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Window>.NativeClassPtr, "Timer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Window.Timer>.NativeClassPtr);
				Window.Timer.NativeFieldInfoPtr__started = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Window.Timer>.NativeClassPtr, "_started");
				Window.Timer.NativeFieldInfoPtr_end = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Window.Timer>.NativeClassPtr, "end");
				Window.Timer.NativeMethodInfoPtr_get_started_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window.Timer>.NativeClassPtr, 100669396);
				Window.Timer.NativeMethodInfoPtr_get_finished_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window.Timer>.NativeClassPtr, 100669397);
				Window.Timer.NativeMethodInfoPtr_get_remaining_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window.Timer>.NativeClassPtr, 100669398);
				Window.Timer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window.Timer>.NativeClassPtr, 100669399);
				Window.Timer.NativeMethodInfoPtr_Start_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window.Timer>.NativeClassPtr, 100669400);
				Window.Timer.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window.Timer>.NativeClassPtr, 100669401);
			}

			// Token: 0x17002042 RID: 8258
			// (get) Token: 0x0600583A RID: 22586 RVA: 0x0013FF9C File Offset: 0x0013E19C
			public unsafe bool started
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Window.Timer.NativeMethodInfoPtr_get_started_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17002043 RID: 8259
			// (get) Token: 0x0600583B RID: 22587 RVA: 0x0013FFD8 File Offset: 0x0013E1D8
			public unsafe bool finished
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 100373, RefRangeEnd = 100380, XrefRangeStart = 100371, XrefRangeEnd = 100373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Window.Timer.NativeMethodInfoPtr_get_finished_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17002044 RID: 8260
			// (get) Token: 0x0600583C RID: 22588 RVA: 0x00140014 File Offset: 0x0013E214
			public unsafe float remaining
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 100382, RefRangeEnd = 100389, XrefRangeStart = 100380, XrefRangeEnd = 100382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Window.Timer.NativeMethodInfoPtr_get_remaining_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600583D RID: 22589 RVA: 0x00140050 File Offset: 0x0013E250
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Timer()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Window.Timer>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Window.Timer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600583E RID: 22590 RVA: 0x0014008C File Offset: 0x0013E28C
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 100391, RefRangeEnd = 100399, XrefRangeStart = 100389, XrefRangeEnd = 100391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Start(float length)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref length;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Window.Timer.NativeMethodInfoPtr_Start_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600583F RID: 22591 RVA: 0x001400CC File Offset: 0x0013E2CC
			[CallerCount(0)]
			public unsafe void Stop()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Window.Timer.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005840 RID: 22592 RVA: 0x00032A5E File Offset: 0x00030C5E
			public Timer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002040 RID: 8256
			// (get) Token: 0x06005841 RID: 22593 RVA: 0x00140100 File Offset: 0x0013E300
			// (set) Token: 0x06005842 RID: 22594 RVA: 0x00032A67 File Offset: 0x00030C67
			public unsafe bool _started
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Window.Timer.NativeFieldInfoPtr__started);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Window.Timer.NativeFieldInfoPtr__started)) = value;
				}
			}

			// Token: 0x17002041 RID: 8257
			// (get) Token: 0x06005843 RID: 22595 RVA: 0x00140128 File Offset: 0x0013E328
			// (set) Token: 0x06005844 RID: 22596 RVA: 0x00032A82 File Offset: 0x00030C82
			public unsafe float end
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Window.Timer.NativeFieldInfoPtr_end);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Window.Timer.NativeFieldInfoPtr_end)) = value;
				}
			}

			// Token: 0x04003A94 RID: 14996
			private static readonly IntPtr NativeFieldInfoPtr__started;

			// Token: 0x04003A95 RID: 14997
			private static readonly IntPtr NativeFieldInfoPtr_end;

			// Token: 0x04003A96 RID: 14998
			private static readonly IntPtr NativeMethodInfoPtr_get_started_Public_get_Boolean_0;

			// Token: 0x04003A97 RID: 14999
			private static readonly IntPtr NativeMethodInfoPtr_get_finished_Public_get_Boolean_0;

			// Token: 0x04003A98 RID: 15000
			private static readonly IntPtr NativeMethodInfoPtr_get_remaining_Public_get_Single_0;

			// Token: 0x04003A99 RID: 15001
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003A9A RID: 15002
			private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_Single_0;

			// Token: 0x04003A9B RID: 15003
			private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;
		}

		// Token: 0x0200039C RID: 924
		[ObfuscatedName("Rewired.UI.ControlMapper.Window+<OnEnableAsync>d__64")]
		public sealed class _OnEnableAsync_d__64 : global::Il2CppSystem.Object
		{
			// Token: 0x06005845 RID: 22597 RVA: 0x00140150 File Offset: 0x0013E350
			// Note: this type is marked as 'beforefieldinit'.
			static _OnEnableAsync_d__64()
			{
				Il2CppClassPointerStore<Window._OnEnableAsync_d__64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Window>.NativeClassPtr, "<OnEnableAsync>d__64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Window._OnEnableAsync_d__64>.NativeClassPtr);
				Window._OnEnableAsync_d__64.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Window._OnEnableAsync_d__64>.NativeClassPtr, "<>1__state");
				Window._OnEnableAsync_d__64.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Window._OnEnableAsync_d__64>.NativeClassPtr, "<>2__current");
				Window._OnEnableAsync_d__64.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Window._OnEnableAsync_d__64>.NativeClassPtr, "<>4__this");
				Window._OnEnableAsync_d__64.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window._OnEnableAsync_d__64>.NativeClassPtr, 100669402);
				Window._OnEnableAsync_d__64.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window._OnEnableAsync_d__64>.NativeClassPtr, 100669403);
				Window._OnEnableAsync_d__64.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window._OnEnableAsync_d__64>.NativeClassPtr, 100669404);
				Window._OnEnableAsync_d__64.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window._OnEnableAsync_d__64>.NativeClassPtr, 100669405);
				Window._OnEnableAsync_d__64.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window._OnEnableAsync_d__64>.NativeClassPtr, 100669406);
				Window._OnEnableAsync_d__64.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window._OnEnableAsync_d__64>.NativeClassPtr, 100669407);
			}

			// Token: 0x06005846 RID: 22598 RVA: 0x00140230 File Offset: 0x0013E430
			[CallerCount(0)]
			public unsafe _OnEnableAsync_d__64(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Window._OnEnableAsync_d__64>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Window._OnEnableAsync_d__64.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005847 RID: 22599 RVA: 0x00140278 File Offset: 0x0013E478
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Window._OnEnableAsync_d__64.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005848 RID: 22600 RVA: 0x001402AC File Offset: 0x0013E4AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100399, XrefRangeEnd = 100404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Window._OnEnableAsync_d__64.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002048 RID: 8264
			// (get) Token: 0x06005849 RID: 22601 RVA: 0x001402E8 File Offset: 0x0013E4E8
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Window._OnEnableAsync_d__64.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600584A RID: 22602 RVA: 0x00140328 File Offset: 0x0013E528
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100404, XrefRangeEnd = 100409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Window._OnEnableAsync_d__64.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002049 RID: 8265
			// (get) Token: 0x0600584B RID: 22603 RVA: 0x0014035C File Offset: 0x0013E55C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Window._OnEnableAsync_d__64.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600584C RID: 22604 RVA: 0x00032A9D File Offset: 0x00030C9D
			public _OnEnableAsync_d__64(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002045 RID: 8261
			// (get) Token: 0x0600584D RID: 22605 RVA: 0x0014039C File Offset: 0x0013E59C
			// (set) Token: 0x0600584E RID: 22606 RVA: 0x00032AA6 File Offset: 0x00030CA6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Window._OnEnableAsync_d__64.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Window._OnEnableAsync_d__64.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002046 RID: 8262
			// (get) Token: 0x0600584F RID: 22607 RVA: 0x001403C4 File Offset: 0x0013E5C4
			// (set) Token: 0x06005850 RID: 22608 RVA: 0x00032AC1 File Offset: 0x00030CC1
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Window._OnEnableAsync_d__64.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Window._OnEnableAsync_d__64.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002047 RID: 8263
			// (get) Token: 0x06005851 RID: 22609 RVA: 0x001403F4 File Offset: 0x0013E5F4
			// (set) Token: 0x06005852 RID: 22610 RVA: 0x00032AE0 File Offset: 0x00030CE0
			public unsafe Window __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Window._OnEnableAsync_d__64.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Window>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Window._OnEnableAsync_d__64.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003A9C RID: 15004
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003A9D RID: 15005
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003A9E RID: 15006
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003A9F RID: 15007
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003AA0 RID: 15008
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003AA1 RID: 15009
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003AA2 RID: 15010
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003AA3 RID: 15011
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003AA4 RID: 15012
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
