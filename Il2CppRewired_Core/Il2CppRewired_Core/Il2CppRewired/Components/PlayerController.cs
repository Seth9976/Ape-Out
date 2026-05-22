using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine.Events;

namespace Il2CppRewired.Components
{
	// Token: 0x02000054 RID: 84
	[Serializable]
	public class PlayerController : ComponentWrapper<PlayerController>
	{
		// Token: 0x06000A31 RID: 2609 RVA: 0x00054E1C File Offset: 0x0005301C
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerController()
		{
			Il2CppClassPointerStore<PlayerController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Components", "PlayerController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerController>.NativeClassPtr);
			PlayerController.NativeFieldInfoPtr__rewiredInputManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, "_rewiredInputManager");
			PlayerController.NativeFieldInfoPtr__playerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, "_playerId");
			PlayerController.NativeFieldInfoPtr__elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, "_elements");
			PlayerController.NativeFieldInfoPtr__onButtonStateChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, "_onButtonStateChanged");
			PlayerController.NativeFieldInfoPtr__onAxisValueChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, "_onAxisValueChanged");
			PlayerController.NativeFieldInfoPtr__onEnabledStateChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, "_onEnabledStateChanged");
			PlayerController.NativeMethodInfoPtr_get_playerId_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100664974);
			PlayerController.NativeMethodInfoPtr_set_playerId_Public_Virtual_Final_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100664975);
			PlayerController.NativeMethodInfoPtr_get_buttons_Public_Virtual_Final_New_get_IList_1_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100664976);
			PlayerController.NativeMethodInfoPtr_get_axes_Public_Virtual_Final_New_get_IList_1_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100664977);
			PlayerController.NativeMethodInfoPtr_get_elements_Public_Virtual_Final_New_get_IList_1_Element_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100664978);
			PlayerController.NativeMethodInfoPtr_get_buttonCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100664979);
			PlayerController.NativeMethodInfoPtr_get_axisCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100664980);
			PlayerController.NativeMethodInfoPtr_get_elementCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100664981);
			PlayerController.NativeMethodInfoPtr_add_ButtonStateChangedEvent_Public_Virtual_Final_New_add_Void_Action_2_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100664982);
			PlayerController.NativeMethodInfoPtr_remove_ButtonStateChangedEvent_Public_Virtual_Final_New_rem_Void_Action_2_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100664983);
			PlayerController.NativeMethodInfoPtr_add_AxisValueChangedEvent_Public_Virtual_Final_New_add_Void_Action_2_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100664984);
			PlayerController.NativeMethodInfoPtr_remove_AxisValueChangedEvent_Public_Virtual_Final_New_rem_Void_Action_2_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100664985);
			PlayerController.NativeMethodInfoPtr_add_EnabledStateChangedEvent_Public_Virtual_Final_New_add_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100664986);
			PlayerController.NativeMethodInfoPtr_remove_EnabledStateChangedEvent_Public_Virtual_Final_New_rem_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100664987);
			PlayerController.NativeMethodInfoPtr_GetButton_Public_Virtual_Final_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100664988);
			PlayerController.NativeMethodInfoPtr_GetButtonDown_Public_Virtual_Final_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100664989);
			PlayerController.NativeMethodInfoPtr_GetButtonUp_Public_Virtual_Final_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100664990);
			PlayerController.NativeMethodInfoPtr_GetAxis_Public_Virtual_Final_New_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100664991);
			PlayerController.NativeMethodInfoPtr_GetAxisRaw_Public_Virtual_Final_New_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100664992);
			PlayerController.NativeMethodInfoPtr_GetElement_Public_Virtual_Final_New_Element_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100664993);
			PlayerController.NativeMethodInfoPtr_GetElement_Public_Virtual_Final_New_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100664994);
			PlayerController.NativeMethodInfoPtr_OnAwake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100664995);
			PlayerController.NativeMethodInfoPtr_OnAwakeFinished_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100664996);
			PlayerController.NativeMethodInfoPtr_OnEnabled_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100664997);
			PlayerController.NativeMethodInfoPtr_OnDisabled_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100664998);
			PlayerController.NativeMethodInfoPtr_OnValidated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100664999);
			PlayerController.NativeMethodInfoPtr_OnReset_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100665000);
			PlayerController.NativeMethodInfoPtr_Subscribe_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100665001);
			PlayerController.NativeMethodInfoPtr_Unsubscribe_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100665002);
			PlayerController.NativeMethodInfoPtr_GetCreateSourceArgs_Protected_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100665003);
			PlayerController.NativeMethodInfoPtr_CreateSource_Protected_Virtual_PlayerController_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100665004);
			PlayerController.NativeMethodInfoPtr_HpMGqAommMgbVcbRvjhzRHgsqRNd_Internal_Virtual_New_List_1_ElementInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100665005);
			PlayerController.NativeMethodInfoPtr_LtTBBCnowRUjsXbRBilBfQueXyB_Private_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100665006);
			PlayerController.NativeMethodInfoPtr_iKvhyyDmHyilyjqsJZrcpJwxVPj_Private_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100665007);
			PlayerController.NativeMethodInfoPtr_ZNbAaTrnYCvrPWkQHuoWZFAnvCy_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100665008);
			PlayerController.NativeMethodInfoPtr_lYRclzbnVXGcHWXvyPrKIFwmtyK_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100665009);
			PlayerController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100665010);
			PlayerController.NativeMethodInfoPtr_Rewired_IPlayerController_get_enabled_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100665011);
			PlayerController.NativeMethodInfoPtr_Rewired_IPlayerController_set_enabled_Private_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100665012);
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000A32 RID: 2610 RVA: 0x000551D0 File Offset: 0x000533D0
		// (set) Token: 0x06000A33 RID: 2611 RVA: 0x0005520C File Offset: 0x0005340C
		public unsafe virtual int playerId
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250822, XrefRangeEnd = 250825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_get_playerId_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 250846, RefRangeEnd = 250848, XrefRangeStart = 250825, XrefRangeEnd = 250846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_set_playerId_Public_Virtual_Final_New_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000A34 RID: 2612 RVA: 0x0005524C File Offset: 0x0005344C
		public unsafe virtual IList<PlayerController.Button> buttons
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250848, XrefRangeEnd = 250855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_get_buttons_Public_Virtual_Final_New_get_IList_1_Button_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<PlayerController.Button>>(intPtr3) : null;
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000A35 RID: 2613 RVA: 0x0005528C File Offset: 0x0005348C
		public unsafe virtual IList<PlayerController.Axis> axes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250855, XrefRangeEnd = 250862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_get_axes_Public_Virtual_Final_New_get_IList_1_Axis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<PlayerController.Axis>>(intPtr3) : null;
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000A36 RID: 2614 RVA: 0x000552CC File Offset: 0x000534CC
		public unsafe virtual IList<PlayerController.Element> elements
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250862, XrefRangeEnd = 250869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_get_elements_Public_Virtual_Final_New_get_IList_1_Element_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<PlayerController.Element>>(intPtr3) : null;
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000A37 RID: 2615 RVA: 0x0005530C File Offset: 0x0005350C
		public unsafe virtual int buttonCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250869, XrefRangeEnd = 250875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_get_buttonCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000A38 RID: 2616 RVA: 0x00055348 File Offset: 0x00053548
		public unsafe virtual int axisCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250875, XrefRangeEnd = 250881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_get_axisCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000A39 RID: 2617 RVA: 0x00055384 File Offset: 0x00053584
		public unsafe virtual int elementCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250881, XrefRangeEnd = 250884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_get_elementCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x000553C0 File Offset: 0x000535C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250884, XrefRangeEnd = 250887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void add_ButtonStateChangedEvent(Action<int, bool> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_add_ButtonStateChangedEvent_Public_Virtual_Final_New_add_Void_Action_2_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x00055404 File Offset: 0x00053604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250887, XrefRangeEnd = 250890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void remove_ButtonStateChangedEvent(Action<int, bool> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_remove_ButtonStateChangedEvent_Public_Virtual_Final_New_rem_Void_Action_2_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x00055448 File Offset: 0x00053648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250890, XrefRangeEnd = 250893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void add_AxisValueChangedEvent(Action<int, float> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_add_AxisValueChangedEvent_Public_Virtual_Final_New_add_Void_Action_2_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x0005548C File Offset: 0x0005368C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250893, XrefRangeEnd = 250896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void remove_AxisValueChangedEvent(Action<int, float> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_remove_AxisValueChangedEvent_Public_Virtual_Final_New_rem_Void_Action_2_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x000554D0 File Offset: 0x000536D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250896, XrefRangeEnd = 250899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void add_EnabledStateChangedEvent(Action<bool> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_add_EnabledStateChangedEvent_Public_Virtual_Final_New_add_Void_Action_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x00055514 File Offset: 0x00053714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250899, XrefRangeEnd = 250902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void remove_EnabledStateChangedEvent(Action<bool> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_remove_EnabledStateChangedEvent_Public_Virtual_Final_New_rem_Void_Action_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x00055558 File Offset: 0x00053758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250902, XrefRangeEnd = 250905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetButton(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_GetButton_Public_Virtual_Final_New_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x000555A4 File Offset: 0x000537A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250905, XrefRangeEnd = 250908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetButtonDown(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_GetButtonDown_Public_Virtual_Final_New_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x000555F0 File Offset: 0x000537F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250908, XrefRangeEnd = 250911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetButtonUp(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_GetButtonUp_Public_Virtual_Final_New_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x0005563C File Offset: 0x0005383C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250911, XrefRangeEnd = 250922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual float GetAxis(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_GetAxis_Public_Virtual_Final_New_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x00055688 File Offset: 0x00053888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250922, XrefRangeEnd = 250933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual float GetAxisRaw(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_GetAxisRaw_Public_Virtual_Final_New_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x000556D4 File Offset: 0x000538D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250933, XrefRangeEnd = 250936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual PlayerController.Element GetElement(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_GetElement_Public_Virtual_Final_New_Element_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerController.Element>(intPtr3) : null;
			}
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x00055720 File Offset: 0x00053920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250936, XrefRangeEnd = 250938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual T GetElement<T>(int index) where T : PlayerController.Element
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.MethodInfoStoreGeneric_GetElement_Public_Virtual_Final_New_T_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x00055768 File Offset: 0x00053968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250938, XrefRangeEnd = 250951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnAwake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerController.NativeMethodInfoPtr_OnAwake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x000557A4 File Offset: 0x000539A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250951, XrefRangeEnd = 250954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnAwakeFinished()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerController.NativeMethodInfoPtr_OnAwakeFinished_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x000557E0 File Offset: 0x000539E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250954, XrefRangeEnd = 250962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerController.NativeMethodInfoPtr_OnEnabled_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x0005581C File Offset: 0x00053A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250962, XrefRangeEnd = 250970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerController.NativeMethodInfoPtr_OnDisabled_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x00055858 File Offset: 0x00053A58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250970, XrefRangeEnd = 250975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValidated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerController.NativeMethodInfoPtr_OnValidated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x00055894 File Offset: 0x00053A94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 250996, RefRangeEnd = 250997, XrefRangeStart = 250975, XrefRangeEnd = 250996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnReset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerController.NativeMethodInfoPtr_OnReset_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x000558D0 File Offset: 0x00053AD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 251028, RefRangeEnd = 251029, XrefRangeStart = 250997, XrefRangeEnd = 251028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Subscribe()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerController.NativeMethodInfoPtr_Subscribe_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x0005590C File Offset: 0x00053B0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 251060, RefRangeEnd = 251061, XrefRangeStart = 251029, XrefRangeEnd = 251060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unsubscribe()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerController.NativeMethodInfoPtr_Unsubscribe_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x00055948 File Offset: 0x00053B48
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 621, RefRangeEnd = 626, XrefRangeStart = 621, XrefRangeEnd = 626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object GetCreateSourceArgs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerController.NativeMethodInfoPtr_GetCreateSourceArgs_Protected_Virtual_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x00055994 File Offset: 0x00053B94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251061, XrefRangeEnd = 251104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override PlayerController CreateSource(Object args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerController.NativeMethodInfoPtr_CreateSource_Protected_Virtual_PlayerController_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerController>(intPtr3) : null;
			}
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x000559F0 File Offset: 0x00053BF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251104, XrefRangeEnd = 251187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<PlayerController.ElementInfo> HpMGqAommMgbVcbRvjhzRHgsqRNd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerController.NativeMethodInfoPtr_HpMGqAommMgbVcbRvjhzRHgsqRNd_Internal_Virtual_New_List_1_ElementInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<PlayerController.ElementInfo>>(intPtr3) : null;
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x00055A3C File Offset: 0x00053C3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251187, XrefRangeEnd = 251198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LtTBBCnowRUjsXbRBilBfQueXyB(int A_1, bool A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_LtTBBCnowRUjsXbRBilBfQueXyB_Private_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x00055A88 File Offset: 0x00053C88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251198, XrefRangeEnd = 251209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void iKvhyyDmHyilyjqsJZrcpJwxVPj(int A_1, float A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_iKvhyyDmHyilyjqsJZrcpJwxVPj_Private_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x00055AD4 File Offset: 0x00053CD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 251218, RefRangeEnd = 251219, XrefRangeStart = 251209, XrefRangeEnd = 251218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ZNbAaTrnYCvrPWkQHuoWZFAnvCy(bool A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_ZNbAaTrnYCvrPWkQHuoWZFAnvCy_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x00055B14 File Offset: 0x00053D14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 251220, RefRangeEnd = 251222, XrefRangeStart = 251219, XrefRangeEnd = 251220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void lYRclzbnVXGcHWXvyPrKIFwmtyK()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_lYRclzbnVXGcHWXvyPrKIFwmtyK_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x00055B48 File Offset: 0x00053D48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 251245, RefRangeEnd = 251246, XrefRangeStart = 251222, XrefRangeEnd = 251245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerController()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000A57 RID: 2647 RVA: 0x00055B84 File Offset: 0x00053D84
		// (set) Token: 0x06000A58 RID: 2648 RVA: 0x00055BC0 File Offset: 0x00053DC0
		public unsafe virtual bool Rewired.IPlayerController.enabled
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 251250, RefRangeEnd = 251258, XrefRangeStart = 251246, XrefRangeEnd = 251250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_Rewired_IPlayerController_get_enabled_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 251262, RefRangeEnd = 251285, XrefRangeStart = 251258, XrefRangeEnd = 251262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_Rewired_IPlayerController_set_enabled_Private_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x00005635 File Offset: 0x00003835
		public PlayerController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000A5A RID: 2650 RVA: 0x00055C00 File Offset: 0x00053E00
		// (set) Token: 0x06000A5B RID: 2651 RVA: 0x0000563E File Offset: 0x0000383E
		public unsafe InputManager_Base _rewiredInputManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr__rewiredInputManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputManager_Base>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr__rewiredInputManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000A5C RID: 2652 RVA: 0x00055C30 File Offset: 0x00053E30
		// (set) Token: 0x06000A5D RID: 2653 RVA: 0x0000565D File Offset: 0x0000385D
		public unsafe int _playerId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr__playerId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr__playerId)) = value;
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000A5E RID: 2654 RVA: 0x00055C58 File Offset: 0x00053E58
		// (set) Token: 0x06000A5F RID: 2655 RVA: 0x00005678 File Offset: 0x00003878
		public unsafe List<PlayerController.ElementInfo> _elements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr__elements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayerController.ElementInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr__elements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000A60 RID: 2656 RVA: 0x00055C88 File Offset: 0x00053E88
		// (set) Token: 0x06000A61 RID: 2657 RVA: 0x00005697 File Offset: 0x00003897
		public unsafe PlayerController.ButtonStateChangedHandler _onButtonStateChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr__onButtonStateChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerController.ButtonStateChangedHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr__onButtonStateChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000A62 RID: 2658 RVA: 0x00055CB8 File Offset: 0x00053EB8
		// (set) Token: 0x06000A63 RID: 2659 RVA: 0x000056B6 File Offset: 0x000038B6
		public unsafe PlayerController.AxisValueChangedHandler _onAxisValueChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr__onAxisValueChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerController.AxisValueChangedHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr__onAxisValueChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000A64 RID: 2660 RVA: 0x00055CE8 File Offset: 0x00053EE8
		// (set) Token: 0x06000A65 RID: 2661 RVA: 0x000056D5 File Offset: 0x000038D5
		public unsafe PlayerController.EnabledStateChangedHandler _onEnabledStateChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr__onEnabledStateChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerController.EnabledStateChangedHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr__onEnabledStateChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400083D RID: 2109
		private static readonly IntPtr NativeFieldInfoPtr__rewiredInputManager;

		// Token: 0x0400083E RID: 2110
		private static readonly IntPtr NativeFieldInfoPtr__playerId;

		// Token: 0x0400083F RID: 2111
		private static readonly IntPtr NativeFieldInfoPtr__elements;

		// Token: 0x04000840 RID: 2112
		private static readonly IntPtr NativeFieldInfoPtr__onButtonStateChanged;

		// Token: 0x04000841 RID: 2113
		private static readonly IntPtr NativeFieldInfoPtr__onAxisValueChanged;

		// Token: 0x04000842 RID: 2114
		private static readonly IntPtr NativeFieldInfoPtr__onEnabledStateChanged;

		// Token: 0x04000843 RID: 2115
		private static readonly IntPtr NativeMethodInfoPtr_get_playerId_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000844 RID: 2116
		private static readonly IntPtr NativeMethodInfoPtr_set_playerId_Public_Virtual_Final_New_set_Void_Int32_0;

		// Token: 0x04000845 RID: 2117
		private static readonly IntPtr NativeMethodInfoPtr_get_buttons_Public_Virtual_Final_New_get_IList_1_Button_0;

		// Token: 0x04000846 RID: 2118
		private static readonly IntPtr NativeMethodInfoPtr_get_axes_Public_Virtual_Final_New_get_IList_1_Axis_0;

		// Token: 0x04000847 RID: 2119
		private static readonly IntPtr NativeMethodInfoPtr_get_elements_Public_Virtual_Final_New_get_IList_1_Element_0;

		// Token: 0x04000848 RID: 2120
		private static readonly IntPtr NativeMethodInfoPtr_get_buttonCount_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000849 RID: 2121
		private static readonly IntPtr NativeMethodInfoPtr_get_axisCount_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400084A RID: 2122
		private static readonly IntPtr NativeMethodInfoPtr_get_elementCount_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400084B RID: 2123
		private static readonly IntPtr NativeMethodInfoPtr_add_ButtonStateChangedEvent_Public_Virtual_Final_New_add_Void_Action_2_Int32_Boolean_0;

		// Token: 0x0400084C RID: 2124
		private static readonly IntPtr NativeMethodInfoPtr_remove_ButtonStateChangedEvent_Public_Virtual_Final_New_rem_Void_Action_2_Int32_Boolean_0;

		// Token: 0x0400084D RID: 2125
		private static readonly IntPtr NativeMethodInfoPtr_add_AxisValueChangedEvent_Public_Virtual_Final_New_add_Void_Action_2_Int32_Single_0;

		// Token: 0x0400084E RID: 2126
		private static readonly IntPtr NativeMethodInfoPtr_remove_AxisValueChangedEvent_Public_Virtual_Final_New_rem_Void_Action_2_Int32_Single_0;

		// Token: 0x0400084F RID: 2127
		private static readonly IntPtr NativeMethodInfoPtr_add_EnabledStateChangedEvent_Public_Virtual_Final_New_add_Void_Action_1_Boolean_0;

		// Token: 0x04000850 RID: 2128
		private static readonly IntPtr NativeMethodInfoPtr_remove_EnabledStateChangedEvent_Public_Virtual_Final_New_rem_Void_Action_1_Boolean_0;

		// Token: 0x04000851 RID: 2129
		private static readonly IntPtr NativeMethodInfoPtr_GetButton_Public_Virtual_Final_New_Boolean_Int32_0;

		// Token: 0x04000852 RID: 2130
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonDown_Public_Virtual_Final_New_Boolean_Int32_0;

		// Token: 0x04000853 RID: 2131
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonUp_Public_Virtual_Final_New_Boolean_Int32_0;

		// Token: 0x04000854 RID: 2132
		private static readonly IntPtr NativeMethodInfoPtr_GetAxis_Public_Virtual_Final_New_Single_Int32_0;

		// Token: 0x04000855 RID: 2133
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisRaw_Public_Virtual_Final_New_Single_Int32_0;

		// Token: 0x04000856 RID: 2134
		private static readonly IntPtr NativeMethodInfoPtr_GetElement_Public_Virtual_Final_New_Element_Int32_0;

		// Token: 0x04000857 RID: 2135
		private static readonly IntPtr NativeMethodInfoPtr_GetElement_Public_Virtual_Final_New_T_Int32_0;

		// Token: 0x04000858 RID: 2136
		private static readonly IntPtr NativeMethodInfoPtr_OnAwake_Protected_Virtual_Void_0;

		// Token: 0x04000859 RID: 2137
		private static readonly IntPtr NativeMethodInfoPtr_OnAwakeFinished_Protected_Virtual_Void_0;

		// Token: 0x0400085A RID: 2138
		private static readonly IntPtr NativeMethodInfoPtr_OnEnabled_Protected_Virtual_Void_0;

		// Token: 0x0400085B RID: 2139
		private static readonly IntPtr NativeMethodInfoPtr_OnDisabled_Protected_Virtual_Void_0;

		// Token: 0x0400085C RID: 2140
		private static readonly IntPtr NativeMethodInfoPtr_OnValidated_Protected_Virtual_Void_0;

		// Token: 0x0400085D RID: 2141
		private static readonly IntPtr NativeMethodInfoPtr_OnReset_Protected_Virtual_Void_0;

		// Token: 0x0400085E RID: 2142
		private static readonly IntPtr NativeMethodInfoPtr_Subscribe_Protected_Virtual_Void_0;

		// Token: 0x0400085F RID: 2143
		private static readonly IntPtr NativeMethodInfoPtr_Unsubscribe_Protected_Virtual_Void_0;

		// Token: 0x04000860 RID: 2144
		private static readonly IntPtr NativeMethodInfoPtr_GetCreateSourceArgs_Protected_Virtual_Object_0;

		// Token: 0x04000861 RID: 2145
		private static readonly IntPtr NativeMethodInfoPtr_CreateSource_Protected_Virtual_PlayerController_Object_0;

		// Token: 0x04000862 RID: 2146
		private static readonly IntPtr NativeMethodInfoPtr_HpMGqAommMgbVcbRvjhzRHgsqRNd_Internal_Virtual_New_List_1_ElementInfo_0;

		// Token: 0x04000863 RID: 2147
		private static readonly IntPtr NativeMethodInfoPtr_LtTBBCnowRUjsXbRBilBfQueXyB_Private_Void_Int32_Boolean_0;

		// Token: 0x04000864 RID: 2148
		private static readonly IntPtr NativeMethodInfoPtr_iKvhyyDmHyilyjqsJZrcpJwxVPj_Private_Void_Int32_Single_0;

		// Token: 0x04000865 RID: 2149
		private static readonly IntPtr NativeMethodInfoPtr_ZNbAaTrnYCvrPWkQHuoWZFAnvCy_Private_Void_Boolean_0;

		// Token: 0x04000866 RID: 2150
		private static readonly IntPtr NativeMethodInfoPtr_lYRclzbnVXGcHWXvyPrKIFwmtyK_Private_Void_0;

		// Token: 0x04000867 RID: 2151
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000868 RID: 2152
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IPlayerController_get_enabled_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000869 RID: 2153
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IPlayerController_set_enabled_Private_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x0200026F RID: 623
		[Serializable]
		public class ButtonStateChangedHandler : UnityEvent<int, bool>
		{
			// Token: 0x0600396B RID: 14699 RVA: 0x00014406 File Offset: 0x00012606
			// Note: this type is marked as 'beforefieldinit'.
			static ButtonStateChangedHandler()
			{
				Il2CppClassPointerStore<PlayerController.ButtonStateChangedHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, "ButtonStateChangedHandler");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerController.ButtonStateChangedHandler>.NativeClassPtr);
				PlayerController.ButtonStateChangedHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.ButtonStateChangedHandler>.NativeClassPtr, 100665013);
			}

			// Token: 0x0600396C RID: 14700 RVA: 0x001173A8 File Offset: 0x001155A8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 250748, RefRangeEnd = 250750, XrefRangeStart = 250746, XrefRangeEnd = 250748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ButtonStateChangedHandler()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerController.ButtonStateChangedHandler>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.ButtonStateChangedHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600396D RID: 14701 RVA: 0x0001443A File Offset: 0x0001263A
			public ButtonStateChangedHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400306D RID: 12397
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000270 RID: 624
		[Serializable]
		public class AxisValueChangedHandler : UnityEvent<int, float>
		{
			// Token: 0x0600396E RID: 14702 RVA: 0x00014443 File Offset: 0x00012643
			// Note: this type is marked as 'beforefieldinit'.
			static AxisValueChangedHandler()
			{
				Il2CppClassPointerStore<PlayerController.AxisValueChangedHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, "AxisValueChangedHandler");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerController.AxisValueChangedHandler>.NativeClassPtr);
				PlayerController.AxisValueChangedHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.AxisValueChangedHandler>.NativeClassPtr, 100665014);
			}

			// Token: 0x0600396F RID: 14703 RVA: 0x001173E4 File Offset: 0x001155E4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 250752, RefRangeEnd = 250754, XrefRangeStart = 250750, XrefRangeEnd = 250752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AxisValueChangedHandler()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerController.AxisValueChangedHandler>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.AxisValueChangedHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003970 RID: 14704 RVA: 0x00014477 File Offset: 0x00012677
			public AxisValueChangedHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400306E RID: 12398
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000271 RID: 625
		[Serializable]
		public class EnabledStateChangedHandler : UnityEvent<bool>
		{
			// Token: 0x06003971 RID: 14705 RVA: 0x00014480 File Offset: 0x00012680
			// Note: this type is marked as 'beforefieldinit'.
			static EnabledStateChangedHandler()
			{
				Il2CppClassPointerStore<PlayerController.EnabledStateChangedHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, "EnabledStateChangedHandler");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerController.EnabledStateChangedHandler>.NativeClassPtr);
				PlayerController.EnabledStateChangedHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.EnabledStateChangedHandler>.NativeClassPtr, 100665015);
			}

			// Token: 0x06003972 RID: 14706 RVA: 0x00117420 File Offset: 0x00115620
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250754, XrefRangeEnd = 250756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EnabledStateChangedHandler()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerController.EnabledStateChangedHandler>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.EnabledStateChangedHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003973 RID: 14707 RVA: 0x000144B4 File Offset: 0x000126B4
			public EnabledStateChangedHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400306F RID: 12399
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000272 RID: 626
		[Serializable]
		public sealed class ElementWithSourceInfo : Object
		{
			// Token: 0x06003974 RID: 14708 RVA: 0x0011745C File Offset: 0x0011565C
			// Note: this type is marked as 'beforefieldinit'.
			static ElementWithSourceInfo()
			{
				Il2CppClassPointerStore<PlayerController.ElementWithSourceInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, "ElementWithSourceInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerController.ElementWithSourceInfo>.NativeClassPtr);
				PlayerController.ElementWithSourceInfo.NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController.ElementWithSourceInfo>.NativeClassPtr, "_name");
				PlayerController.ElementWithSourceInfo.NativeFieldInfoPtr__elementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController.ElementWithSourceInfo>.NativeClassPtr, "_elementType");
				PlayerController.ElementWithSourceInfo.NativeFieldInfoPtr__enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController.ElementWithSourceInfo>.NativeClassPtr, "_enabled");
				PlayerController.ElementWithSourceInfo.NativeFieldInfoPtr__actionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController.ElementWithSourceInfo>.NativeClassPtr, "_actionId");
				PlayerController.ElementWithSourceInfo.NativeFieldInfoPtr__coordinateMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController.ElementWithSourceInfo>.NativeClassPtr, "_coordinateMode");
				PlayerController.ElementWithSourceInfo.NativeFieldInfoPtr__absoluteToRelativeSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController.ElementWithSourceInfo>.NativeClassPtr, "_absoluteToRelativeSensitivity");
				PlayerController.ElementWithSourceInfo.NativeFieldInfoPtr__repeatRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController.ElementWithSourceInfo>.NativeClassPtr, "_repeatRate");
				PlayerController.ElementWithSourceInfo.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.ElementWithSourceInfo>.NativeClassPtr, 100665016);
				PlayerController.ElementWithSourceInfo.NativeMethodInfoPtr_set_name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.ElementWithSourceInfo>.NativeClassPtr, 100665017);
				PlayerController.ElementWithSourceInfo.NativeMethodInfoPtr_get_elementType_Public_get_TypeWithSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.ElementWithSourceInfo>.NativeClassPtr, 100665018);
				PlayerController.ElementWithSourceInfo.NativeMethodInfoPtr_set_elementType_Public_set_Void_TypeWithSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.ElementWithSourceInfo>.NativeClassPtr, 100665019);
				PlayerController.ElementWithSourceInfo.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.ElementWithSourceInfo>.NativeClassPtr, 100665020);
				PlayerController.ElementWithSourceInfo.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.ElementWithSourceInfo>.NativeClassPtr, 100665021);
				PlayerController.ElementWithSourceInfo.NativeMethodInfoPtr_get_actionId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.ElementWithSourceInfo>.NativeClassPtr, 100665022);
				PlayerController.ElementWithSourceInfo.NativeMethodInfoPtr_set_actionId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.ElementWithSourceInfo>.NativeClassPtr, 100665023);
				PlayerController.ElementWithSourceInfo.NativeMethodInfoPtr_get_coordinateMode_Public_get_AxisCoordinateMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.ElementWithSourceInfo>.NativeClassPtr, 100665024);
				PlayerController.ElementWithSourceInfo.NativeMethodInfoPtr_set_coordinateMode_Public_set_Void_AxisCoordinateMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.ElementWithSourceInfo>.NativeClassPtr, 100665025);
				PlayerController.ElementWithSourceInfo.NativeMethodInfoPtr_get_absoluteSourceSensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.ElementWithSourceInfo>.NativeClassPtr, 100665026);
				PlayerController.ElementWithSourceInfo.NativeMethodInfoPtr_set_absoluteSourceSensitivity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.ElementWithSourceInfo>.NativeClassPtr, 100665027);
				PlayerController.ElementWithSourceInfo.NativeMethodInfoPtr_get_repeatRate_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.ElementWithSourceInfo>.NativeClassPtr, 100665028);
				PlayerController.ElementWithSourceInfo.NativeMethodInfoPtr_set_repeatRate_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.ElementWithSourceInfo>.NativeClassPtr, 100665029);
				PlayerController.ElementWithSourceInfo.NativeMethodInfoPtr_ToDefinition_Public_Definition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.ElementWithSourceInfo>.NativeClassPtr, 100665030);
				PlayerController.ElementWithSourceInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.ElementWithSourceInfo>.NativeClassPtr, 100665031);
			}

			// Token: 0x1700111E RID: 4382
			// (get) Token: 0x06003975 RID: 14709 RVA: 0x00117654 File Offset: 0x00115854
			// (set) Token: 0x06003976 RID: 14710 RVA: 0x0011768C File Offset: 0x0011588C
			public unsafe string name
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.ElementWithSourceInfo.NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				[CallerCount(79)]
				[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.ElementWithSourceInfo.NativeMethodInfoPtr_set_name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700111F RID: 4383
			// (get) Token: 0x06003977 RID: 14711 RVA: 0x001176D0 File Offset: 0x001158D0
			// (set) Token: 0x06003978 RID: 14712 RVA: 0x0011770C File Offset: 0x0011590C
			public unsafe PlayerController.Element.TypeWithSource elementType
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.ElementWithSourceInfo.NativeMethodInfoPtr_get_elementType_Public_get_TypeWithSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.ElementWithSourceInfo.NativeMethodInfoPtr_set_elementType_Public_set_Void_TypeWithSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001120 RID: 4384
			// (get) Token: 0x06003979 RID: 14713 RVA: 0x0011774C File Offset: 0x0011594C
			// (set) Token: 0x0600397A RID: 14714 RVA: 0x00117788 File Offset: 0x00115988
			public unsafe bool enabled
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.ElementWithSourceInfo.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.ElementWithSourceInfo.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001121 RID: 4385
			// (get) Token: 0x0600397B RID: 14715 RVA: 0x001177C8 File Offset: 0x001159C8
			// (set) Token: 0x0600397C RID: 14716 RVA: 0x00117804 File Offset: 0x00115A04
			public unsafe int actionId
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.ElementWithSourceInfo.NativeMethodInfoPtr_get_actionId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.ElementWithSourceInfo.NativeMethodInfoPtr_set_actionId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001122 RID: 4386
			// (get) Token: 0x0600397D RID: 14717 RVA: 0x00117844 File Offset: 0x00115A44
			// (set) Token: 0x0600397E RID: 14718 RVA: 0x00117880 File Offset: 0x00115A80
			public unsafe AxisCoordinateMode coordinateMode
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.ElementWithSourceInfo.NativeMethodInfoPtr_get_coordinateMode_Public_get_AxisCoordinateMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.ElementWithSourceInfo.NativeMethodInfoPtr_set_coordinateMode_Public_set_Void_AxisCoordinateMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001123 RID: 4387
			// (get) Token: 0x0600397F RID: 14719 RVA: 0x001178C0 File Offset: 0x00115AC0
			// (set) Token: 0x06003980 RID: 14720 RVA: 0x001178FC File Offset: 0x00115AFC
			public unsafe float absoluteSourceSensitivity
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.ElementWithSourceInfo.NativeMethodInfoPtr_get_absoluteSourceSensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.ElementWithSourceInfo.NativeMethodInfoPtr_set_absoluteSourceSensitivity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001124 RID: 4388
			// (get) Token: 0x06003981 RID: 14721 RVA: 0x0011793C File Offset: 0x00115B3C
			// (set) Token: 0x06003982 RID: 14722 RVA: 0x00117978 File Offset: 0x00115B78
			public unsafe float repeatRate
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.ElementWithSourceInfo.NativeMethodInfoPtr_get_repeatRate_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.ElementWithSourceInfo.NativeMethodInfoPtr_set_repeatRate_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06003983 RID: 14723 RVA: 0x001179B8 File Offset: 0x00115BB8
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 250763, RefRangeEnd = 250767, XrefRangeStart = 250756, XrefRangeEnd = 250763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PlayerController.Element.Definition ToDefinition()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.ElementWithSourceInfo.NativeMethodInfoPtr_ToDefinition_Public_Definition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerController.Element.Definition>(intPtr3) : null;
			}

			// Token: 0x06003984 RID: 14724 RVA: 0x001179F8 File Offset: 0x00115BF8
			[CallerCount(0)]
			public unsafe ElementWithSourceInfo()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerController.ElementWithSourceInfo>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.ElementWithSourceInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003985 RID: 14725 RVA: 0x000144BD File Offset: 0x000126BD
			public ElementWithSourceInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001117 RID: 4375
			// (get) Token: 0x06003986 RID: 14726 RVA: 0x00117A34 File Offset: 0x00115C34
			// (set) Token: 0x06003987 RID: 14727 RVA: 0x000144C6 File Offset: 0x000126C6
			public unsafe string _name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.ElementWithSourceInfo.NativeFieldInfoPtr__name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.ElementWithSourceInfo.NativeFieldInfoPtr__name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001118 RID: 4376
			// (get) Token: 0x06003988 RID: 14728 RVA: 0x00117A5C File Offset: 0x00115C5C
			// (set) Token: 0x06003989 RID: 14729 RVA: 0x000144E5 File Offset: 0x000126E5
			public unsafe PlayerController.Element.TypeWithSource _elementType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.ElementWithSourceInfo.NativeFieldInfoPtr__elementType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.ElementWithSourceInfo.NativeFieldInfoPtr__elementType)) = value;
				}
			}

			// Token: 0x17001119 RID: 4377
			// (get) Token: 0x0600398A RID: 14730 RVA: 0x00117A84 File Offset: 0x00115C84
			// (set) Token: 0x0600398B RID: 14731 RVA: 0x00014500 File Offset: 0x00012700
			public unsafe bool _enabled
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.ElementWithSourceInfo.NativeFieldInfoPtr__enabled);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.ElementWithSourceInfo.NativeFieldInfoPtr__enabled)) = value;
				}
			}

			// Token: 0x1700111A RID: 4378
			// (get) Token: 0x0600398C RID: 14732 RVA: 0x00117AAC File Offset: 0x00115CAC
			// (set) Token: 0x0600398D RID: 14733 RVA: 0x0001451B File Offset: 0x0001271B
			public unsafe int _actionId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.ElementWithSourceInfo.NativeFieldInfoPtr__actionId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.ElementWithSourceInfo.NativeFieldInfoPtr__actionId)) = value;
				}
			}

			// Token: 0x1700111B RID: 4379
			// (get) Token: 0x0600398E RID: 14734 RVA: 0x00117AD4 File Offset: 0x00115CD4
			// (set) Token: 0x0600398F RID: 14735 RVA: 0x00014536 File Offset: 0x00012736
			public unsafe AxisCoordinateMode _coordinateMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.ElementWithSourceInfo.NativeFieldInfoPtr__coordinateMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.ElementWithSourceInfo.NativeFieldInfoPtr__coordinateMode)) = value;
				}
			}

			// Token: 0x1700111C RID: 4380
			// (get) Token: 0x06003990 RID: 14736 RVA: 0x00117AFC File Offset: 0x00115CFC
			// (set) Token: 0x06003991 RID: 14737 RVA: 0x00014551 File Offset: 0x00012751
			public unsafe float _absoluteToRelativeSensitivity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.ElementWithSourceInfo.NativeFieldInfoPtr__absoluteToRelativeSensitivity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.ElementWithSourceInfo.NativeFieldInfoPtr__absoluteToRelativeSensitivity)) = value;
				}
			}

			// Token: 0x1700111D RID: 4381
			// (get) Token: 0x06003992 RID: 14738 RVA: 0x00117B24 File Offset: 0x00115D24
			// (set) Token: 0x06003993 RID: 14739 RVA: 0x0001456C File Offset: 0x0001276C
			public unsafe float _repeatRate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.ElementWithSourceInfo.NativeFieldInfoPtr__repeatRate);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.ElementWithSourceInfo.NativeFieldInfoPtr__repeatRate)) = value;
				}
			}

			// Token: 0x04003070 RID: 12400
			private static readonly IntPtr NativeFieldInfoPtr__name;

			// Token: 0x04003071 RID: 12401
			private static readonly IntPtr NativeFieldInfoPtr__elementType;

			// Token: 0x04003072 RID: 12402
			private static readonly IntPtr NativeFieldInfoPtr__enabled;

			// Token: 0x04003073 RID: 12403
			private static readonly IntPtr NativeFieldInfoPtr__actionId;

			// Token: 0x04003074 RID: 12404
			private static readonly IntPtr NativeFieldInfoPtr__coordinateMode;

			// Token: 0x04003075 RID: 12405
			private static readonly IntPtr NativeFieldInfoPtr__absoluteToRelativeSensitivity;

			// Token: 0x04003076 RID: 12406
			private static readonly IntPtr NativeFieldInfoPtr__repeatRate;

			// Token: 0x04003077 RID: 12407
			private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

			// Token: 0x04003078 RID: 12408
			private static readonly IntPtr NativeMethodInfoPtr_set_name_Public_set_Void_String_0;

			// Token: 0x04003079 RID: 12409
			private static readonly IntPtr NativeMethodInfoPtr_get_elementType_Public_get_TypeWithSource_0;

			// Token: 0x0400307A RID: 12410
			private static readonly IntPtr NativeMethodInfoPtr_set_elementType_Public_set_Void_TypeWithSource_0;

			// Token: 0x0400307B RID: 12411
			private static readonly IntPtr NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0;

			// Token: 0x0400307C RID: 12412
			private static readonly IntPtr NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0;

			// Token: 0x0400307D RID: 12413
			private static readonly IntPtr NativeMethodInfoPtr_get_actionId_Public_get_Int32_0;

			// Token: 0x0400307E RID: 12414
			private static readonly IntPtr NativeMethodInfoPtr_set_actionId_Public_set_Void_Int32_0;

			// Token: 0x0400307F RID: 12415
			private static readonly IntPtr NativeMethodInfoPtr_get_coordinateMode_Public_get_AxisCoordinateMode_0;

			// Token: 0x04003080 RID: 12416
			private static readonly IntPtr NativeMethodInfoPtr_set_coordinateMode_Public_set_Void_AxisCoordinateMode_0;

			// Token: 0x04003081 RID: 12417
			private static readonly IntPtr NativeMethodInfoPtr_get_absoluteSourceSensitivity_Public_get_Single_0;

			// Token: 0x04003082 RID: 12418
			private static readonly IntPtr NativeMethodInfoPtr_set_absoluteSourceSensitivity_Public_set_Void_Single_0;

			// Token: 0x04003083 RID: 12419
			private static readonly IntPtr NativeMethodInfoPtr_get_repeatRate_Public_get_Single_0;

			// Token: 0x04003084 RID: 12420
			private static readonly IntPtr NativeMethodInfoPtr_set_repeatRate_Public_set_Void_Single_0;

			// Token: 0x04003085 RID: 12421
			private static readonly IntPtr NativeMethodInfoPtr_ToDefinition_Public_Definition_0;

			// Token: 0x04003086 RID: 12422
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000273 RID: 627
		[Serializable]
		public sealed class ElementInfo : Object
		{
			// Token: 0x06003994 RID: 14740 RVA: 0x00117B4C File Offset: 0x00115D4C
			// Note: this type is marked as 'beforefieldinit'.
			static ElementInfo()
			{
				Il2CppClassPointerStore<PlayerController.ElementInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, "ElementInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerController.ElementInfo>.NativeClassPtr);
				PlayerController.ElementInfo.NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController.ElementInfo>.NativeClassPtr, "_name");
				PlayerController.ElementInfo.NativeFieldInfoPtr__elementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController.ElementInfo>.NativeClassPtr, "_elementType");
				PlayerController.ElementInfo.NativeFieldInfoPtr__enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController.ElementInfo>.NativeClassPtr, "_enabled");
				PlayerController.ElementInfo.NativeFieldInfoPtr__elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController.ElementInfo>.NativeClassPtr, "_elements");
				PlayerController.ElementInfo.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.ElementInfo>.NativeClassPtr, 100665032);
				PlayerController.ElementInfo.NativeMethodInfoPtr_set_name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.ElementInfo>.NativeClassPtr, 100665033);
				PlayerController.ElementInfo.NativeMethodInfoPtr_get_elementType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.ElementInfo>.NativeClassPtr, 100665034);
				PlayerController.ElementInfo.NativeMethodInfoPtr_set_elementType_Public_set_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.ElementInfo>.NativeClassPtr, 100665035);
				PlayerController.ElementInfo.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.ElementInfo>.NativeClassPtr, 100665036);
				PlayerController.ElementInfo.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.ElementInfo>.NativeClassPtr, 100665037);
				PlayerController.ElementInfo.NativeMethodInfoPtr_get_elements_Public_get_Il2CppReferenceArray_1_ElementWithSourceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.ElementInfo>.NativeClassPtr, 100665038);
				PlayerController.ElementInfo.NativeMethodInfoPtr_set_elements_Public_set_Void_Il2CppReferenceArray_1_ElementWithSourceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.ElementInfo>.NativeClassPtr, 100665039);
				PlayerController.ElementInfo.NativeMethodInfoPtr_ToDefinition_Public_Definition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.ElementInfo>.NativeClassPtr, 100665040);
				PlayerController.ElementInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.ElementInfo>.NativeClassPtr, 100665041);
			}

			// Token: 0x17001129 RID: 4393
			// (get) Token: 0x06003995 RID: 14741 RVA: 0x00117C90 File Offset: 0x00115E90
			// (set) Token: 0x06003996 RID: 14742 RVA: 0x00117CC8 File Offset: 0x00115EC8
			public unsafe string name
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.ElementInfo.NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				[CallerCount(79)]
				[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.ElementInfo.NativeMethodInfoPtr_set_name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700112A RID: 4394
			// (get) Token: 0x06003997 RID: 14743 RVA: 0x00117D0C File Offset: 0x00115F0C
			// (set) Token: 0x06003998 RID: 14744 RVA: 0x00117D48 File Offset: 0x00115F48
			public unsafe PlayerController.Element.Type elementType
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.ElementInfo.NativeMethodInfoPtr_get_elementType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.ElementInfo.NativeMethodInfoPtr_set_elementType_Public_set_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700112B RID: 4395
			// (get) Token: 0x06003999 RID: 14745 RVA: 0x00117D88 File Offset: 0x00115F88
			// (set) Token: 0x0600399A RID: 14746 RVA: 0x00117DC4 File Offset: 0x00115FC4
			public unsafe bool enabled
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.ElementInfo.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.ElementInfo.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700112C RID: 4396
			// (get) Token: 0x0600399B RID: 14747 RVA: 0x00117E04 File Offset: 0x00116004
			// (set) Token: 0x0600399C RID: 14748 RVA: 0x00117E44 File Offset: 0x00116044
			public unsafe Il2CppReferenceArray<PlayerController.ElementWithSourceInfo> elements
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.ElementInfo.NativeMethodInfoPtr_get_elements_Public_get_Il2CppReferenceArray_1_ElementWithSourceInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PlayerController.ElementWithSourceInfo>>(intPtr3) : null;
				}
				[CallerCount(33)]
				[CachedScanResults(RefRangeStart = 18620, RefRangeEnd = 18653, XrefRangeStart = 18620, XrefRangeEnd = 18653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.ElementInfo.NativeMethodInfoPtr_set_elements_Public_set_Void_Il2CppReferenceArray_1_ElementWithSourceInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x0600399D RID: 14749 RVA: 0x00117E88 File Offset: 0x00116088
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 250807, RefRangeEnd = 250809, XrefRangeStart = 250767, XrefRangeEnd = 250807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PlayerController.Element.Definition ToDefinition()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.ElementInfo.NativeMethodInfoPtr_ToDefinition_Public_Definition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerController.Element.Definition>(intPtr3) : null;
			}

			// Token: 0x0600399E RID: 14750 RVA: 0x00117EC8 File Offset: 0x001160C8
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 250812, RefRangeEnd = 250822, XrefRangeStart = 250809, XrefRangeEnd = 250812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ElementInfo()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerController.ElementInfo>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.ElementInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600399F RID: 14751 RVA: 0x00014587 File Offset: 0x00012787
			public ElementInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001125 RID: 4389
			// (get) Token: 0x060039A0 RID: 14752 RVA: 0x00117F04 File Offset: 0x00116104
			// (set) Token: 0x060039A1 RID: 14753 RVA: 0x00014590 File Offset: 0x00012790
			public unsafe string _name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.ElementInfo.NativeFieldInfoPtr__name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.ElementInfo.NativeFieldInfoPtr__name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001126 RID: 4390
			// (get) Token: 0x060039A2 RID: 14754 RVA: 0x00117F2C File Offset: 0x0011612C
			// (set) Token: 0x060039A3 RID: 14755 RVA: 0x000145AF File Offset: 0x000127AF
			public unsafe PlayerController.Element.Type _elementType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.ElementInfo.NativeFieldInfoPtr__elementType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.ElementInfo.NativeFieldInfoPtr__elementType)) = value;
				}
			}

			// Token: 0x17001127 RID: 4391
			// (get) Token: 0x060039A4 RID: 14756 RVA: 0x00117F54 File Offset: 0x00116154
			// (set) Token: 0x060039A5 RID: 14757 RVA: 0x000145CA File Offset: 0x000127CA
			public unsafe bool _enabled
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.ElementInfo.NativeFieldInfoPtr__enabled);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.ElementInfo.NativeFieldInfoPtr__enabled)) = value;
				}
			}

			// Token: 0x17001128 RID: 4392
			// (get) Token: 0x060039A6 RID: 14758 RVA: 0x00117F7C File Offset: 0x0011617C
			// (set) Token: 0x060039A7 RID: 14759 RVA: 0x000145E5 File Offset: 0x000127E5
			public unsafe Il2CppReferenceArray<PlayerController.ElementWithSourceInfo> _elements
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.ElementInfo.NativeFieldInfoPtr__elements);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PlayerController.ElementWithSourceInfo>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.ElementInfo.NativeFieldInfoPtr__elements), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003087 RID: 12423
			private static readonly IntPtr NativeFieldInfoPtr__name;

			// Token: 0x04003088 RID: 12424
			private static readonly IntPtr NativeFieldInfoPtr__elementType;

			// Token: 0x04003089 RID: 12425
			private static readonly IntPtr NativeFieldInfoPtr__enabled;

			// Token: 0x0400308A RID: 12426
			private static readonly IntPtr NativeFieldInfoPtr__elements;

			// Token: 0x0400308B RID: 12427
			private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

			// Token: 0x0400308C RID: 12428
			private static readonly IntPtr NativeMethodInfoPtr_set_name_Public_set_Void_String_0;

			// Token: 0x0400308D RID: 12429
			private static readonly IntPtr NativeMethodInfoPtr_get_elementType_Public_get_Type_0;

			// Token: 0x0400308E RID: 12430
			private static readonly IntPtr NativeMethodInfoPtr_set_elementType_Public_set_Void_Type_0;

			// Token: 0x0400308F RID: 12431
			private static readonly IntPtr NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0;

			// Token: 0x04003090 RID: 12432
			private static readonly IntPtr NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0;

			// Token: 0x04003091 RID: 12433
			private static readonly IntPtr NativeMethodInfoPtr_get_elements_Public_get_Il2CppReferenceArray_1_ElementWithSourceInfo_0;

			// Token: 0x04003092 RID: 12434
			private static readonly IntPtr NativeMethodInfoPtr_set_elements_Public_set_Void_Il2CppReferenceArray_1_ElementWithSourceInfo_0;

			// Token: 0x04003093 RID: 12435
			private static readonly IntPtr NativeMethodInfoPtr_ToDefinition_Public_Definition_0;

			// Token: 0x04003094 RID: 12436
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000274 RID: 628
		private sealed class MethodInfoStoreGeneric_GetElement_Public_Virtual_Final_New_T_Int32_0<T>
		{
			// Token: 0x04003095 RID: 12437
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayerController.NativeMethodInfoPtr_GetElement_Public_Virtual_Final_New_T_Int32_0, Il2CppClassPointerStore<PlayerController>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
