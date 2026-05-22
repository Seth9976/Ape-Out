using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000063 RID: 99
	public class EventSystem : UIBehaviour
	{
		// Token: 0x06000969 RID: 2409 RVA: 0x0002AFFC File Offset: 0x000291FC
		// Note: this type is marked as 'beforefieldinit'.
		static EventSystem()
		{
			Il2CppClassPointerStore<EventSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "EventSystem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventSystem>.NativeClassPtr);
			EventSystem.NativeFieldInfoPtr_m_SystemInputModules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, "m_SystemInputModules");
			EventSystem.NativeFieldInfoPtr_m_CurrentInputModule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, "m_CurrentInputModule");
			EventSystem.NativeFieldInfoPtr_m_EventSystems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, "m_EventSystems");
			EventSystem.NativeFieldInfoPtr_m_FirstSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, "m_FirstSelected");
			EventSystem.NativeFieldInfoPtr_m_sendNavigationEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, "m_sendNavigationEvents");
			EventSystem.NativeFieldInfoPtr_m_DragThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, "m_DragThreshold");
			EventSystem.NativeFieldInfoPtr_m_CurrentSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, "m_CurrentSelected");
			EventSystem.NativeFieldInfoPtr_m_HasFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, "m_HasFocus");
			EventSystem.NativeFieldInfoPtr_m_SelectionGuard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, "m_SelectionGuard");
			EventSystem.NativeFieldInfoPtr_m_DummyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, "m_DummyData");
			EventSystem.NativeFieldInfoPtr_s_RaycastComparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, "s_RaycastComparer");
			EventSystem.NativeMethodInfoPtr_get_current_Public_Static_get_EventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664788);
			EventSystem.NativeMethodInfoPtr_set_current_Public_Static_set_Void_EventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664789);
			EventSystem.NativeMethodInfoPtr_get_sendNavigationEvents_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664790);
			EventSystem.NativeMethodInfoPtr_set_sendNavigationEvents_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664791);
			EventSystem.NativeMethodInfoPtr_get_pixelDragThreshold_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664792);
			EventSystem.NativeMethodInfoPtr_set_pixelDragThreshold_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664793);
			EventSystem.NativeMethodInfoPtr_get_currentInputModule_Public_get_BaseInputModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664794);
			EventSystem.NativeMethodInfoPtr_get_firstSelectedGameObject_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664795);
			EventSystem.NativeMethodInfoPtr_set_firstSelectedGameObject_Public_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664796);
			EventSystem.NativeMethodInfoPtr_get_currentSelectedGameObject_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664797);
			EventSystem.NativeMethodInfoPtr_get_lastSelectedGameObject_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664798);
			EventSystem.NativeMethodInfoPtr_get_isFocused_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664799);
			EventSystem.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664800);
			EventSystem.NativeMethodInfoPtr_UpdateModules_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664801);
			EventSystem.NativeMethodInfoPtr_get_alreadySelecting_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664802);
			EventSystem.NativeMethodInfoPtr_SetSelectedGameObject_Public_Void_GameObject_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664803);
			EventSystem.NativeMethodInfoPtr_get_baseEventDataCache_Private_get_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664804);
			EventSystem.NativeMethodInfoPtr_SetSelectedGameObject_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664805);
			EventSystem.NativeMethodInfoPtr_RaycastComparer_Private_Static_Int32_RaycastResult_RaycastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664806);
			EventSystem.NativeMethodInfoPtr_RaycastAll_Public_Void_PointerEventData_List_1_RaycastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664807);
			EventSystem.NativeMethodInfoPtr_IsPointerOverGameObject_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664808);
			EventSystem.NativeMethodInfoPtr_IsPointerOverGameObject_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664809);
			EventSystem.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664810);
			EventSystem.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664811);
			EventSystem.NativeMethodInfoPtr_TickModules_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664812);
			EventSystem.NativeMethodInfoPtr_OnApplicationFocus_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664813);
			EventSystem.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664814);
			EventSystem.NativeMethodInfoPtr_ChangeEventModule_Private_Void_BaseInputModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664815);
			EventSystem.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664816);
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x0600096A RID: 2410 RVA: 0x0002B34C File Offset: 0x0002954C
		// (set) Token: 0x0600096B RID: 2411 RVA: 0x0002B380 File Offset: 0x00029580
		public unsafe static EventSystem current
		{
			[CallerCount(57)]
			[CachedScanResults(RefRangeStart = 530532, RefRangeEnd = 530589, XrefRangeStart = 530524, XrefRangeEnd = 530532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_get_current_Public_Static_get_EventSystem_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventSystem>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 530605, RefRangeEnd = 530607, XrefRangeStart = 530589, XrefRangeEnd = 530605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_set_current_Public_Static_set_Void_EventSystem_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x0600096C RID: 2412 RVA: 0x0002B3B8 File Offset: 0x000295B8
		// (set) Token: 0x0600096D RID: 2413 RVA: 0x0002B3F4 File Offset: 0x000295F4
		public unsafe bool sendNavigationEvents
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_get_sendNavigationEvents_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_set_sendNavigationEvents_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x0600096E RID: 2414 RVA: 0x0002B434 File Offset: 0x00029634
		// (set) Token: 0x0600096F RID: 2415 RVA: 0x0002B470 File Offset: 0x00029670
		public unsafe int pixelDragThreshold
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_get_pixelDragThreshold_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_set_pixelDragThreshold_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000970 RID: 2416 RVA: 0x0002B4B0 File Offset: 0x000296B0
		public unsafe BaseInputModule currentInputModule
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_get_currentInputModule_Public_get_BaseInputModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseInputModule>(intPtr3) : null;
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000971 RID: 2417 RVA: 0x0002B4F0 File Offset: 0x000296F0
		// (set) Token: 0x06000972 RID: 2418 RVA: 0x0002B530 File Offset: 0x00029730
		public unsafe GameObject firstSelectedGameObject
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_get_firstSelectedGameObject_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
			[CallerCount(38)]
			[CachedScanResults(RefRangeStart = 17089, RefRangeEnd = 17127, XrefRangeStart = 17089, XrefRangeEnd = 17127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_set_firstSelectedGameObject_Public_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000973 RID: 2419 RVA: 0x0002B574 File Offset: 0x00029774
		public unsafe GameObject currentSelectedGameObject
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 621, RefRangeEnd = 626, XrefRangeStart = 621, XrefRangeEnd = 626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_get_currentSelectedGameObject_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000974 RID: 2420 RVA: 0x0002B5B4 File Offset: 0x000297B4
		public unsafe GameObject lastSelectedGameObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_get_lastSelectedGameObject_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000975 RID: 2421 RVA: 0x0002B5F4 File Offset: 0x000297F4
		public unsafe bool isFocused
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_get_isFocused_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x0002B630 File Offset: 0x00029830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 530607, XrefRangeEnd = 530616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventSystem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventSystem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x0002B66C File Offset: 0x0002986C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 530632, RefRangeEnd = 530634, XrefRangeStart = 530616, XrefRangeEnd = 530632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateModules()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_UpdateModules_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000978 RID: 2424 RVA: 0x0002B6A0 File Offset: 0x000298A0
		public unsafe bool alreadySelecting
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_get_alreadySelecting_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x0002B6DC File Offset: 0x000298DC
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 530671, RefRangeEnd = 530683, XrefRangeStart = 530634, XrefRangeEnd = 530671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSelectedGameObject(GameObject selected, BaseEventData pointer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selected);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pointer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_SetSelectedGameObject_Public_Void_GameObject_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x0600097A RID: 2426 RVA: 0x0002B730 File Offset: 0x00029930
		public unsafe BaseEventData baseEventDataCache
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 530683, XrefRangeEnd = 530686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_get_baseEventDataCache_Private_get_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseEventData>(intPtr3) : null;
			}
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x0002B770 File Offset: 0x00029970
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 530690, RefRangeEnd = 530701, XrefRangeStart = 530686, XrefRangeEnd = 530690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSelectedGameObject(GameObject selected)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selected);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_SetSelectedGameObject_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x0002B7B4 File Offset: 0x000299B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 530701, XrefRangeEnd = 530782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RaycastComparer(RaycastResult lhs, RaycastResult rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(lhs));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(rhs));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_RaycastComparer_Private_Static_Int32_RaycastResult_RaycastResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x0002B814 File Offset: 0x00029A14
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 530815, RefRangeEnd = 530819, XrefRangeStart = 530782, XrefRangeEnd = 530815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RaycastAll(PointerEventData eventData, List<RaycastResult> raycastResults)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(raycastResults);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_RaycastAll_Public_Void_PointerEventData_List_1_RaycastResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x0002B868 File Offset: 0x00029A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 530819, XrefRangeEnd = 530831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPointerOverGameObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_IsPointerOverGameObject_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x0002B8A4 File Offset: 0x00029AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 530831, XrefRangeEnd = 530843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPointerOverGameObject(int pointerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_IsPointerOverGameObject_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x0002B8F0 File Offset: 0x00029AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 530843, XrefRangeEnd = 530851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventSystem.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x0002B92C File Offset: 0x00029B2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 530851, XrefRangeEnd = 530869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventSystem.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x0002B968 File Offset: 0x00029B68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 530886, RefRangeEnd = 530888, XrefRangeStart = 530869, XrefRangeEnd = 530886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TickModules()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_TickModules_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x0002B99C File Offset: 0x00029B9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 530888, XrefRangeEnd = 530889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnApplicationFocus(bool hasFocus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hasFocus;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventSystem.NativeMethodInfoPtr_OnApplicationFocus_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x0002B9E8 File Offset: 0x00029BE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 530936, RefRangeEnd = 530938, XrefRangeStart = 530889, XrefRangeEnd = 530936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventSystem.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x0002BA24 File Offset: 0x00029C24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 530938, XrefRangeEnd = 530981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeEventModule(BaseInputModule module)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(module);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_ChangeEventModule_Private_Void_BaseInputModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x0002BA68 File Offset: 0x00029C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 530981, XrefRangeEnd = 531032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventSystem.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x0000574B File Offset: 0x0000394B
		public EventSystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000988 RID: 2440 RVA: 0x0002BAAC File Offset: 0x00029CAC
		// (set) Token: 0x06000989 RID: 2441 RVA: 0x00005754 File Offset: 0x00003954
		public unsafe List<BaseInputModule> m_SystemInputModules
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_SystemInputModules);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BaseInputModule>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_SystemInputModules), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x0600098A RID: 2442 RVA: 0x0002BADC File Offset: 0x00029CDC
		// (set) Token: 0x0600098B RID: 2443 RVA: 0x00005773 File Offset: 0x00003973
		public unsafe BaseInputModule m_CurrentInputModule
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_CurrentInputModule);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseInputModule>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_CurrentInputModule), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x0600098C RID: 2444 RVA: 0x0002BB0C File Offset: 0x00029D0C
		// (set) Token: 0x0600098D RID: 2445 RVA: 0x00005792 File Offset: 0x00003992
		public unsafe static List<EventSystem> m_EventSystems
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EventSystem.NativeFieldInfoPtr_m_EventSystems, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EventSystem>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventSystem.NativeFieldInfoPtr_m_EventSystems, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x0600098E RID: 2446 RVA: 0x0002BB34 File Offset: 0x00029D34
		// (set) Token: 0x0600098F RID: 2447 RVA: 0x000057A4 File Offset: 0x000039A4
		public unsafe GameObject m_FirstSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_FirstSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_FirstSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000990 RID: 2448 RVA: 0x0002BB64 File Offset: 0x00029D64
		// (set) Token: 0x06000991 RID: 2449 RVA: 0x000057C3 File Offset: 0x000039C3
		public unsafe bool m_sendNavigationEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_sendNavigationEvents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_sendNavigationEvents)) = value;
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000992 RID: 2450 RVA: 0x0002BB8C File Offset: 0x00029D8C
		// (set) Token: 0x06000993 RID: 2451 RVA: 0x000057DE File Offset: 0x000039DE
		public unsafe int m_DragThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_DragThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_DragThreshold)) = value;
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000994 RID: 2452 RVA: 0x0002BBB4 File Offset: 0x00029DB4
		// (set) Token: 0x06000995 RID: 2453 RVA: 0x000057F9 File Offset: 0x000039F9
		public unsafe GameObject m_CurrentSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_CurrentSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_CurrentSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000996 RID: 2454 RVA: 0x0002BBE4 File Offset: 0x00029DE4
		// (set) Token: 0x06000997 RID: 2455 RVA: 0x00005818 File Offset: 0x00003A18
		public unsafe bool m_HasFocus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_HasFocus);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_HasFocus)) = value;
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000998 RID: 2456 RVA: 0x0002BC0C File Offset: 0x00029E0C
		// (set) Token: 0x06000999 RID: 2457 RVA: 0x00005833 File Offset: 0x00003A33
		public unsafe bool m_SelectionGuard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_SelectionGuard);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_SelectionGuard)) = value;
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x0600099A RID: 2458 RVA: 0x0002BC34 File Offset: 0x00029E34
		// (set) Token: 0x0600099B RID: 2459 RVA: 0x0000584E File Offset: 0x00003A4E
		public unsafe BaseEventData m_DummyData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_DummyData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseEventData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_DummyData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x0600099C RID: 2460 RVA: 0x0002BC64 File Offset: 0x00029E64
		// (set) Token: 0x0600099D RID: 2461 RVA: 0x0000586D File Offset: 0x00003A6D
		public unsafe static Comparison<RaycastResult> s_RaycastComparer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EventSystem.NativeFieldInfoPtr_s_RaycastComparer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<RaycastResult>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventSystem.NativeFieldInfoPtr_s_RaycastComparer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000708 RID: 1800
		private static readonly IntPtr NativeFieldInfoPtr_m_SystemInputModules;

		// Token: 0x04000709 RID: 1801
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentInputModule;

		// Token: 0x0400070A RID: 1802
		private static readonly IntPtr NativeFieldInfoPtr_m_EventSystems;

		// Token: 0x0400070B RID: 1803
		private static readonly IntPtr NativeFieldInfoPtr_m_FirstSelected;

		// Token: 0x0400070C RID: 1804
		private static readonly IntPtr NativeFieldInfoPtr_m_sendNavigationEvents;

		// Token: 0x0400070D RID: 1805
		private static readonly IntPtr NativeFieldInfoPtr_m_DragThreshold;

		// Token: 0x0400070E RID: 1806
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentSelected;

		// Token: 0x0400070F RID: 1807
		private static readonly IntPtr NativeFieldInfoPtr_m_HasFocus;

		// Token: 0x04000710 RID: 1808
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectionGuard;

		// Token: 0x04000711 RID: 1809
		private static readonly IntPtr NativeFieldInfoPtr_m_DummyData;

		// Token: 0x04000712 RID: 1810
		private static readonly IntPtr NativeFieldInfoPtr_s_RaycastComparer;

		// Token: 0x04000713 RID: 1811
		private static readonly IntPtr NativeMethodInfoPtr_get_current_Public_Static_get_EventSystem_0;

		// Token: 0x04000714 RID: 1812
		private static readonly IntPtr NativeMethodInfoPtr_set_current_Public_Static_set_Void_EventSystem_0;

		// Token: 0x04000715 RID: 1813
		private static readonly IntPtr NativeMethodInfoPtr_get_sendNavigationEvents_Public_get_Boolean_0;

		// Token: 0x04000716 RID: 1814
		private static readonly IntPtr NativeMethodInfoPtr_set_sendNavigationEvents_Public_set_Void_Boolean_0;

		// Token: 0x04000717 RID: 1815
		private static readonly IntPtr NativeMethodInfoPtr_get_pixelDragThreshold_Public_get_Int32_0;

		// Token: 0x04000718 RID: 1816
		private static readonly IntPtr NativeMethodInfoPtr_set_pixelDragThreshold_Public_set_Void_Int32_0;

		// Token: 0x04000719 RID: 1817
		private static readonly IntPtr NativeMethodInfoPtr_get_currentInputModule_Public_get_BaseInputModule_0;

		// Token: 0x0400071A RID: 1818
		private static readonly IntPtr NativeMethodInfoPtr_get_firstSelectedGameObject_Public_get_GameObject_0;

		// Token: 0x0400071B RID: 1819
		private static readonly IntPtr NativeMethodInfoPtr_set_firstSelectedGameObject_Public_set_Void_GameObject_0;

		// Token: 0x0400071C RID: 1820
		private static readonly IntPtr NativeMethodInfoPtr_get_currentSelectedGameObject_Public_get_GameObject_0;

		// Token: 0x0400071D RID: 1821
		private static readonly IntPtr NativeMethodInfoPtr_get_lastSelectedGameObject_Public_get_GameObject_0;

		// Token: 0x0400071E RID: 1822
		private static readonly IntPtr NativeMethodInfoPtr_get_isFocused_Public_get_Boolean_0;

		// Token: 0x0400071F RID: 1823
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000720 RID: 1824
		private static readonly IntPtr NativeMethodInfoPtr_UpdateModules_Public_Void_0;

		// Token: 0x04000721 RID: 1825
		private static readonly IntPtr NativeMethodInfoPtr_get_alreadySelecting_Public_get_Boolean_0;

		// Token: 0x04000722 RID: 1826
		private static readonly IntPtr NativeMethodInfoPtr_SetSelectedGameObject_Public_Void_GameObject_BaseEventData_0;

		// Token: 0x04000723 RID: 1827
		private static readonly IntPtr NativeMethodInfoPtr_get_baseEventDataCache_Private_get_BaseEventData_0;

		// Token: 0x04000724 RID: 1828
		private static readonly IntPtr NativeMethodInfoPtr_SetSelectedGameObject_Public_Void_GameObject_0;

		// Token: 0x04000725 RID: 1829
		private static readonly IntPtr NativeMethodInfoPtr_RaycastComparer_Private_Static_Int32_RaycastResult_RaycastResult_0;

		// Token: 0x04000726 RID: 1830
		private static readonly IntPtr NativeMethodInfoPtr_RaycastAll_Public_Void_PointerEventData_List_1_RaycastResult_0;

		// Token: 0x04000727 RID: 1831
		private static readonly IntPtr NativeMethodInfoPtr_IsPointerOverGameObject_Public_Boolean_0;

		// Token: 0x04000728 RID: 1832
		private static readonly IntPtr NativeMethodInfoPtr_IsPointerOverGameObject_Public_Boolean_Int32_0;

		// Token: 0x04000729 RID: 1833
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x0400072A RID: 1834
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x0400072B RID: 1835
		private static readonly IntPtr NativeMethodInfoPtr_TickModules_Private_Void_0;

		// Token: 0x0400072C RID: 1836
		private static readonly IntPtr NativeMethodInfoPtr_OnApplicationFocus_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x0400072D RID: 1837
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x0400072E RID: 1838
		private static readonly IntPtr NativeMethodInfoPtr_ChangeEventModule_Private_Void_BaseInputModule_0;

		// Token: 0x0400072F RID: 1839
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
