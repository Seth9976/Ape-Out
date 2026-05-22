using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000068 RID: 104
	public class BaseInputModule : UIBehaviour
	{
		// Token: 0x06000A1E RID: 2590 RVA: 0x0002DED8 File Offset: 0x0002C0D8
		// Note: this type is marked as 'beforefieldinit'.
		static BaseInputModule()
		{
			Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "BaseInputModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr);
			BaseInputModule.NativeFieldInfoPtr_m_RaycastResultCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, "m_RaycastResultCache");
			BaseInputModule.NativeFieldInfoPtr_m_AxisEventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, "m_AxisEventData");
			BaseInputModule.NativeFieldInfoPtr_m_EventSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, "m_EventSystem");
			BaseInputModule.NativeFieldInfoPtr_m_BaseEventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, "m_BaseEventData");
			BaseInputModule.NativeFieldInfoPtr_m_InputOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, "m_InputOverride");
			BaseInputModule.NativeFieldInfoPtr_m_DefaultInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, "m_DefaultInput");
			BaseInputModule.NativeMethodInfoPtr_get_input_Public_get_BaseInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100664910);
			BaseInputModule.NativeMethodInfoPtr_get_inputOverride_Public_get_BaseInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100664911);
			BaseInputModule.NativeMethodInfoPtr_set_inputOverride_Public_set_Void_BaseInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100664912);
			BaseInputModule.NativeMethodInfoPtr_get_eventSystem_Protected_get_EventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100664913);
			BaseInputModule.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100664914);
			BaseInputModule.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100664915);
			BaseInputModule.NativeMethodInfoPtr_Process_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100664916);
			BaseInputModule.NativeMethodInfoPtr_FindFirstRaycast_Protected_Static_RaycastResult_List_1_RaycastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100664917);
			BaseInputModule.NativeMethodInfoPtr_DetermineMoveDirection_Protected_Static_MoveDirection_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100664918);
			BaseInputModule.NativeMethodInfoPtr_DetermineMoveDirection_Protected_Static_MoveDirection_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100664919);
			BaseInputModule.NativeMethodInfoPtr_FindCommonRoot_Protected_Static_GameObject_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100664920);
			BaseInputModule.NativeMethodInfoPtr_HandlePointerExitAndEnter_Protected_Void_PointerEventData_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100664921);
			BaseInputModule.NativeMethodInfoPtr_GetAxisEventData_Protected_Virtual_New_AxisEventData_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100664922);
			BaseInputModule.NativeMethodInfoPtr_GetBaseEventData_Protected_Virtual_New_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100664923);
			BaseInputModule.NativeMethodInfoPtr_IsPointerOverGameObject_Public_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100664924);
			BaseInputModule.NativeMethodInfoPtr_ShouldActivateModule_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100664925);
			BaseInputModule.NativeMethodInfoPtr_DeactivateModule_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100664926);
			BaseInputModule.NativeMethodInfoPtr_ActivateModule_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100664927);
			BaseInputModule.NativeMethodInfoPtr_UpdateModule_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100664928);
			BaseInputModule.NativeMethodInfoPtr_IsModuleSupported_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100664929);
			BaseInputModule.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100664930);
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000A1F RID: 2591 RVA: 0x0002E124 File Offset: 0x0002C324
		public unsafe BaseInput input
		{
			[CallerCount(47)]
			[CachedScanResults(RefRangeStart = 531654, RefRangeEnd = 531701, XrefRangeStart = 531636, XrefRangeEnd = 531654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseInputModule.NativeMethodInfoPtr_get_input_Public_get_BaseInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseInput>(intPtr3) : null;
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000A20 RID: 2592 RVA: 0x0002E164 File Offset: 0x0002C364
		// (set) Token: 0x06000A21 RID: 2593 RVA: 0x0002E1A4 File Offset: 0x0002C3A4
		public unsafe BaseInput inputOverride
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 621, RefRangeEnd = 626, XrefRangeStart = 621, XrefRangeEnd = 626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseInputModule.NativeMethodInfoPtr_get_inputOverride_Public_get_BaseInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseInput>(intPtr3) : null;
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 99340, RefRangeEnd = 99363, XrefRangeStart = 99340, XrefRangeEnd = 99363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseInputModule.NativeMethodInfoPtr_set_inputOverride_Public_set_Void_BaseInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000A22 RID: 2594 RVA: 0x0002E1E8 File Offset: 0x0002C3E8
		public unsafe EventSystem eventSystem
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseInputModule.NativeMethodInfoPtr_get_eventSystem_Protected_get_EventSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventSystem>(intPtr3) : null;
			}
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x0002E228 File Offset: 0x0002C428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531701, XrefRangeEnd = 531706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInputModule.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x0002E264 File Offset: 0x0002C464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531706, XrefRangeEnd = 531708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInputModule.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x0002E2A0 File Offset: 0x0002C4A0
		[CallerCount(0)]
		public unsafe virtual void Process()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInputModule.NativeMethodInfoPtr_Process_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x0002E2DC File Offset: 0x0002C4DC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 531724, RefRangeEnd = 531728, XrefRangeStart = 531708, XrefRangeEnd = 531724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RaycastResult FindFirstRaycast(List<RaycastResult> candidates)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(candidates);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseInputModule.NativeMethodInfoPtr_FindFirstRaycast_Protected_Static_RaycastResult_List_1_RaycastResult_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new RaycastResult(intPtr);
			}
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x0002E318 File Offset: 0x0002C518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531728, XrefRangeEnd = 531729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MoveDirection DetermineMoveDirection(float x, float y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseInputModule.NativeMethodInfoPtr_DetermineMoveDirection_Protected_Static_MoveDirection_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x0002E364 File Offset: 0x0002C564
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 531729, RefRangeEnd = 531731, XrefRangeStart = 531729, XrefRangeEnd = 531729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MoveDirection DetermineMoveDirection(float x, float y, float deadZone)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deadZone;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseInputModule.NativeMethodInfoPtr_DetermineMoveDirection_Protected_Static_MoveDirection_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x0002E3C0 File Offset: 0x0002C5C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 531794, RefRangeEnd = 531795, XrefRangeStart = 531731, XrefRangeEnd = 531794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject FindCommonRoot(GameObject g1, GameObject g2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(g1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(g2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseInputModule.NativeMethodInfoPtr_FindCommonRoot_Protected_Static_GameObject_GameObject_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x0002E418 File Offset: 0x0002C618
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 531980, RefRangeEnd = 531991, XrefRangeStart = 531795, XrefRangeEnd = 531980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandlePointerExitAndEnter(PointerEventData currentPointerData, GameObject newEnterTarget)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentPointerData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newEnterTarget);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseInputModule.NativeMethodInfoPtr_HandlePointerExitAndEnter_Protected_Void_PointerEventData_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x0002E46C File Offset: 0x0002C66C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531991, XrefRangeEnd = 531997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AxisEventData GetAxisEventData(float x, float y, float moveDeadZone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moveDeadZone;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInputModule.NativeMethodInfoPtr_GetAxisEventData_Protected_Virtual_New_AxisEventData_Single_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AxisEventData>(intPtr3) : null;
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x0002E4E0 File Offset: 0x0002C6E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531997, XrefRangeEnd = 532000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual BaseEventData GetBaseEventData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInputModule.NativeMethodInfoPtr_GetBaseEventData_Protected_Virtual_New_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseEventData>(intPtr3) : null;
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x0002E52C File Offset: 0x0002C72C
		[CallerCount(0)]
		public unsafe virtual bool IsPointerOverGameObject(int pointerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInputModule.NativeMethodInfoPtr_IsPointerOverGameObject_Public_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x0002E580 File Offset: 0x0002C780
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 532002, RefRangeEnd = 532005, XrefRangeStart = 532000, XrefRangeEnd = 532002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldActivateModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInputModule.NativeMethodInfoPtr_ShouldActivateModule_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x0002E5C8 File Offset: 0x0002C7C8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DeactivateModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInputModule.NativeMethodInfoPtr_DeactivateModule_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x0002E604 File Offset: 0x0002C804
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ActivateModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInputModule.NativeMethodInfoPtr_ActivateModule_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x0002E640 File Offset: 0x0002C840
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInputModule.NativeMethodInfoPtr_UpdateModule_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x0002E67C File Offset: 0x0002C87C
		[CallerCount(0)]
		public unsafe virtual bool IsModuleSupported()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInputModule.NativeMethodInfoPtr_IsModuleSupported_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x0002E6C4 File Offset: 0x0002C8C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 532018, RefRangeEnd = 532020, XrefRangeStart = 532005, XrefRangeEnd = 532018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseInputModule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseInputModule.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x00005A0F File Offset: 0x00003C0F
		public BaseInputModule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000A35 RID: 2613 RVA: 0x0002E700 File Offset: 0x0002C900
		// (set) Token: 0x06000A36 RID: 2614 RVA: 0x00005A18 File Offset: 0x00003C18
		public unsafe List<RaycastResult> m_RaycastResultCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseInputModule.NativeFieldInfoPtr_m_RaycastResultCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RaycastResult>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseInputModule.NativeFieldInfoPtr_m_RaycastResultCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000A37 RID: 2615 RVA: 0x0002E730 File Offset: 0x0002C930
		// (set) Token: 0x06000A38 RID: 2616 RVA: 0x00005A37 File Offset: 0x00003C37
		public unsafe AxisEventData m_AxisEventData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseInputModule.NativeFieldInfoPtr_m_AxisEventData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AxisEventData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseInputModule.NativeFieldInfoPtr_m_AxisEventData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000A39 RID: 2617 RVA: 0x0002E760 File Offset: 0x0002C960
		// (set) Token: 0x06000A3A RID: 2618 RVA: 0x00005A56 File Offset: 0x00003C56
		public unsafe EventSystem m_EventSystem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseInputModule.NativeFieldInfoPtr_m_EventSystem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseInputModule.NativeFieldInfoPtr_m_EventSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000A3B RID: 2619 RVA: 0x0002E790 File Offset: 0x0002C990
		// (set) Token: 0x06000A3C RID: 2620 RVA: 0x00005A75 File Offset: 0x00003C75
		public unsafe BaseEventData m_BaseEventData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseInputModule.NativeFieldInfoPtr_m_BaseEventData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseEventData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseInputModule.NativeFieldInfoPtr_m_BaseEventData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000A3D RID: 2621 RVA: 0x0002E7C0 File Offset: 0x0002C9C0
		// (set) Token: 0x06000A3E RID: 2622 RVA: 0x00005A94 File Offset: 0x00003C94
		public unsafe BaseInput m_InputOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseInputModule.NativeFieldInfoPtr_m_InputOverride);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseInput>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseInputModule.NativeFieldInfoPtr_m_InputOverride), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000A3F RID: 2623 RVA: 0x0002E7F0 File Offset: 0x0002C9F0
		// (set) Token: 0x06000A40 RID: 2624 RVA: 0x00005AB3 File Offset: 0x00003CB3
		public unsafe BaseInput m_DefaultInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseInputModule.NativeFieldInfoPtr_m_DefaultInput);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseInput>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseInputModule.NativeFieldInfoPtr_m_DefaultInput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007A8 RID: 1960
		private static readonly IntPtr NativeFieldInfoPtr_m_RaycastResultCache;

		// Token: 0x040007A9 RID: 1961
		private static readonly IntPtr NativeFieldInfoPtr_m_AxisEventData;

		// Token: 0x040007AA RID: 1962
		private static readonly IntPtr NativeFieldInfoPtr_m_EventSystem;

		// Token: 0x040007AB RID: 1963
		private static readonly IntPtr NativeFieldInfoPtr_m_BaseEventData;

		// Token: 0x040007AC RID: 1964
		private static readonly IntPtr NativeFieldInfoPtr_m_InputOverride;

		// Token: 0x040007AD RID: 1965
		private static readonly IntPtr NativeFieldInfoPtr_m_DefaultInput;

		// Token: 0x040007AE RID: 1966
		private static readonly IntPtr NativeMethodInfoPtr_get_input_Public_get_BaseInput_0;

		// Token: 0x040007AF RID: 1967
		private static readonly IntPtr NativeMethodInfoPtr_get_inputOverride_Public_get_BaseInput_0;

		// Token: 0x040007B0 RID: 1968
		private static readonly IntPtr NativeMethodInfoPtr_set_inputOverride_Public_set_Void_BaseInput_0;

		// Token: 0x040007B1 RID: 1969
		private static readonly IntPtr NativeMethodInfoPtr_get_eventSystem_Protected_get_EventSystem_0;

		// Token: 0x040007B2 RID: 1970
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x040007B3 RID: 1971
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x040007B4 RID: 1972
		private static readonly IntPtr NativeMethodInfoPtr_Process_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040007B5 RID: 1973
		private static readonly IntPtr NativeMethodInfoPtr_FindFirstRaycast_Protected_Static_RaycastResult_List_1_RaycastResult_0;

		// Token: 0x040007B6 RID: 1974
		private static readonly IntPtr NativeMethodInfoPtr_DetermineMoveDirection_Protected_Static_MoveDirection_Single_Single_0;

		// Token: 0x040007B7 RID: 1975
		private static readonly IntPtr NativeMethodInfoPtr_DetermineMoveDirection_Protected_Static_MoveDirection_Single_Single_Single_0;

		// Token: 0x040007B8 RID: 1976
		private static readonly IntPtr NativeMethodInfoPtr_FindCommonRoot_Protected_Static_GameObject_GameObject_GameObject_0;

		// Token: 0x040007B9 RID: 1977
		private static readonly IntPtr NativeMethodInfoPtr_HandlePointerExitAndEnter_Protected_Void_PointerEventData_GameObject_0;

		// Token: 0x040007BA RID: 1978
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisEventData_Protected_Virtual_New_AxisEventData_Single_Single_Single_0;

		// Token: 0x040007BB RID: 1979
		private static readonly IntPtr NativeMethodInfoPtr_GetBaseEventData_Protected_Virtual_New_BaseEventData_0;

		// Token: 0x040007BC RID: 1980
		private static readonly IntPtr NativeMethodInfoPtr_IsPointerOverGameObject_Public_Virtual_New_Boolean_Int32_0;

		// Token: 0x040007BD RID: 1981
		private static readonly IntPtr NativeMethodInfoPtr_ShouldActivateModule_Public_Virtual_New_Boolean_0;

		// Token: 0x040007BE RID: 1982
		private static readonly IntPtr NativeMethodInfoPtr_DeactivateModule_Public_Virtual_New_Void_0;

		// Token: 0x040007BF RID: 1983
		private static readonly IntPtr NativeMethodInfoPtr_ActivateModule_Public_Virtual_New_Void_0;

		// Token: 0x040007C0 RID: 1984
		private static readonly IntPtr NativeMethodInfoPtr_UpdateModule_Public_Virtual_New_Void_0;

		// Token: 0x040007C1 RID: 1985
		private static readonly IntPtr NativeMethodInfoPtr_IsModuleSupported_Public_Virtual_New_Boolean_0;

		// Token: 0x040007C2 RID: 1986
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
