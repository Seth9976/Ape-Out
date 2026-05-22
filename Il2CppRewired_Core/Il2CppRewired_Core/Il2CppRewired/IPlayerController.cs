using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppRewired
{
	// Token: 0x02000053 RID: 83
	public class IPlayerController : Il2CppObjectBase
	{
		// Token: 0x06000A18 RID: 2584 RVA: 0x00054514 File Offset: 0x00052714
		// Note: this type is marked as 'beforefieldinit'.
		static IPlayerController()
		{
			Il2CppClassPointerStore<IPlayerController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "IPlayerController");
			IPlayerController.NativeMethodInfoPtr_get_enabled_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerController>.NativeClassPtr, 100664951);
			IPlayerController.NativeMethodInfoPtr_set_enabled_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerController>.NativeClassPtr, 100664952);
			IPlayerController.NativeMethodInfoPtr_get_playerId_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerController>.NativeClassPtr, 100664953);
			IPlayerController.NativeMethodInfoPtr_set_playerId_Public_Abstract_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerController>.NativeClassPtr, 100664954);
			IPlayerController.NativeMethodInfoPtr_get_buttons_Public_Abstract_Virtual_New_get_IList_1_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerController>.NativeClassPtr, 100664955);
			IPlayerController.NativeMethodInfoPtr_get_axes_Public_Abstract_Virtual_New_get_IList_1_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerController>.NativeClassPtr, 100664956);
			IPlayerController.NativeMethodInfoPtr_get_elements_Public_Abstract_Virtual_New_get_IList_1_Element_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerController>.NativeClassPtr, 100664957);
			IPlayerController.NativeMethodInfoPtr_get_buttonCount_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerController>.NativeClassPtr, 100664958);
			IPlayerController.NativeMethodInfoPtr_get_axisCount_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerController>.NativeClassPtr, 100664959);
			IPlayerController.NativeMethodInfoPtr_get_elementCount_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerController>.NativeClassPtr, 100664960);
			IPlayerController.NativeMethodInfoPtr_add_ButtonStateChangedEvent_Public_Abstract_Virtual_New_add_Void_Action_2_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerController>.NativeClassPtr, 100664961);
			IPlayerController.NativeMethodInfoPtr_remove_ButtonStateChangedEvent_Public_Abstract_Virtual_New_rem_Void_Action_2_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerController>.NativeClassPtr, 100664962);
			IPlayerController.NativeMethodInfoPtr_add_AxisValueChangedEvent_Public_Abstract_Virtual_New_add_Void_Action_2_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerController>.NativeClassPtr, 100664963);
			IPlayerController.NativeMethodInfoPtr_remove_AxisValueChangedEvent_Public_Abstract_Virtual_New_rem_Void_Action_2_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerController>.NativeClassPtr, 100664964);
			IPlayerController.NativeMethodInfoPtr_add_EnabledStateChangedEvent_Public_Abstract_Virtual_New_add_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerController>.NativeClassPtr, 100664965);
			IPlayerController.NativeMethodInfoPtr_remove_EnabledStateChangedEvent_Public_Abstract_Virtual_New_rem_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerController>.NativeClassPtr, 100664966);
			IPlayerController.NativeMethodInfoPtr_GetButton_Public_Abstract_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerController>.NativeClassPtr, 100664967);
			IPlayerController.NativeMethodInfoPtr_GetButtonDown_Public_Abstract_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerController>.NativeClassPtr, 100664968);
			IPlayerController.NativeMethodInfoPtr_GetButtonUp_Public_Abstract_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerController>.NativeClassPtr, 100664969);
			IPlayerController.NativeMethodInfoPtr_GetAxis_Public_Abstract_Virtual_New_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerController>.NativeClassPtr, 100664970);
			IPlayerController.NativeMethodInfoPtr_GetAxisRaw_Public_Abstract_Virtual_New_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerController>.NativeClassPtr, 100664971);
			IPlayerController.NativeMethodInfoPtr_GetElement_Public_Abstract_Virtual_New_Element_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerController>.NativeClassPtr, 100664972);
			IPlayerController.NativeMethodInfoPtr_GetElement_Public_Abstract_Virtual_New_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerController>.NativeClassPtr, 100664973);
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000A19 RID: 2585 RVA: 0x00054708 File Offset: 0x00052908
		// (set) Token: 0x06000A1A RID: 2586 RVA: 0x00054750 File Offset: 0x00052950
		public unsafe virtual bool enabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerController.NativeMethodInfoPtr_get_enabled_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerController.NativeMethodInfoPtr_set_enabled_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000A1B RID: 2587 RVA: 0x0005479C File Offset: 0x0005299C
		// (set) Token: 0x06000A1C RID: 2588 RVA: 0x000547E4 File Offset: 0x000529E4
		public unsafe virtual int playerId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerController.NativeMethodInfoPtr_get_playerId_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerController.NativeMethodInfoPtr_set_playerId_Public_Abstract_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000A1D RID: 2589 RVA: 0x00054830 File Offset: 0x00052A30
		public unsafe virtual IList<PlayerController.Button> buttons
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerController.NativeMethodInfoPtr_get_buttons_Public_Abstract_Virtual_New_get_IList_1_Button_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<PlayerController.Button>>(intPtr3) : null;
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000A1E RID: 2590 RVA: 0x0005487C File Offset: 0x00052A7C
		public unsafe virtual IList<PlayerController.Axis> axes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerController.NativeMethodInfoPtr_get_axes_Public_Abstract_Virtual_New_get_IList_1_Axis_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<PlayerController.Axis>>(intPtr3) : null;
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000A1F RID: 2591 RVA: 0x000548C8 File Offset: 0x00052AC8
		public unsafe virtual IList<PlayerController.Element> elements
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerController.NativeMethodInfoPtr_get_elements_Public_Abstract_Virtual_New_get_IList_1_Element_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<PlayerController.Element>>(intPtr3) : null;
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000A20 RID: 2592 RVA: 0x00054914 File Offset: 0x00052B14
		public unsafe virtual int buttonCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerController.NativeMethodInfoPtr_get_buttonCount_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000A21 RID: 2593 RVA: 0x0005495C File Offset: 0x00052B5C
		public unsafe virtual int axisCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerController.NativeMethodInfoPtr_get_axisCount_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000A22 RID: 2594 RVA: 0x000549A4 File Offset: 0x00052BA4
		public unsafe virtual int elementCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerController.NativeMethodInfoPtr_get_elementCount_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x000549EC File Offset: 0x00052BEC
		[CallerCount(0)]
		public unsafe virtual void add_ButtonStateChangedEvent(Action<int, bool> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerController.NativeMethodInfoPtr_add_ButtonStateChangedEvent_Public_Abstract_Virtual_New_add_Void_Action_2_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x00054A3C File Offset: 0x00052C3C
		[CallerCount(0)]
		public unsafe virtual void remove_ButtonStateChangedEvent(Action<int, bool> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerController.NativeMethodInfoPtr_remove_ButtonStateChangedEvent_Public_Abstract_Virtual_New_rem_Void_Action_2_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x00054A8C File Offset: 0x00052C8C
		[CallerCount(0)]
		public unsafe virtual void add_AxisValueChangedEvent(Action<int, float> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerController.NativeMethodInfoPtr_add_AxisValueChangedEvent_Public_Abstract_Virtual_New_add_Void_Action_2_Int32_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x00054ADC File Offset: 0x00052CDC
		[CallerCount(0)]
		public unsafe virtual void remove_AxisValueChangedEvent(Action<int, float> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerController.NativeMethodInfoPtr_remove_AxisValueChangedEvent_Public_Abstract_Virtual_New_rem_Void_Action_2_Int32_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x00054B2C File Offset: 0x00052D2C
		[CallerCount(0)]
		public unsafe virtual void add_EnabledStateChangedEvent(Action<bool> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerController.NativeMethodInfoPtr_add_EnabledStateChangedEvent_Public_Abstract_Virtual_New_add_Void_Action_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x00054B7C File Offset: 0x00052D7C
		[CallerCount(0)]
		public unsafe virtual void remove_EnabledStateChangedEvent(Action<bool> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerController.NativeMethodInfoPtr_remove_EnabledStateChangedEvent_Public_Abstract_Virtual_New_rem_Void_Action_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x00054BCC File Offset: 0x00052DCC
		[CallerCount(0)]
		public unsafe virtual bool GetButton(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerController.NativeMethodInfoPtr_GetButton_Public_Abstract_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x00054C20 File Offset: 0x00052E20
		[CallerCount(0)]
		public unsafe virtual bool GetButtonDown(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerController.NativeMethodInfoPtr_GetButtonDown_Public_Abstract_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x00054C74 File Offset: 0x00052E74
		[CallerCount(0)]
		public unsafe virtual bool GetButtonUp(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerController.NativeMethodInfoPtr_GetButtonUp_Public_Abstract_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x00054CC8 File Offset: 0x00052EC8
		[CallerCount(0)]
		public unsafe virtual float GetAxis(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerController.NativeMethodInfoPtr_GetAxis_Public_Abstract_Virtual_New_Single_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x00054D1C File Offset: 0x00052F1C
		[CallerCount(0)]
		public unsafe virtual float GetAxisRaw(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerController.NativeMethodInfoPtr_GetAxisRaw_Public_Abstract_Virtual_New_Single_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x00054D70 File Offset: 0x00052F70
		[CallerCount(0)]
		public unsafe virtual PlayerController.Element GetElement(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerController.NativeMethodInfoPtr_GetElement_Public_Abstract_Virtual_New_Element_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerController.Element>(intPtr3) : null;
			}
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x00054DC8 File Offset: 0x00052FC8
		[CallerCount(0)]
		public unsafe virtual T GetElement<T>(int index) where T : PlayerController.Element
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerController.MethodInfoStoreGeneric_GetElement_Public_Abstract_Virtual_New_T_Int32_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x0000562C File Offset: 0x0000382C
		public IPlayerController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000826 RID: 2086
		private static readonly IntPtr NativeMethodInfoPtr_get_enabled_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000827 RID: 2087
		private static readonly IntPtr NativeMethodInfoPtr_set_enabled_Public_Abstract_Virtual_New_set_Void_Boolean_0;

		// Token: 0x04000828 RID: 2088
		private static readonly IntPtr NativeMethodInfoPtr_get_playerId_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04000829 RID: 2089
		private static readonly IntPtr NativeMethodInfoPtr_set_playerId_Public_Abstract_Virtual_New_set_Void_Int32_0;

		// Token: 0x0400082A RID: 2090
		private static readonly IntPtr NativeMethodInfoPtr_get_buttons_Public_Abstract_Virtual_New_get_IList_1_Button_0;

		// Token: 0x0400082B RID: 2091
		private static readonly IntPtr NativeMethodInfoPtr_get_axes_Public_Abstract_Virtual_New_get_IList_1_Axis_0;

		// Token: 0x0400082C RID: 2092
		private static readonly IntPtr NativeMethodInfoPtr_get_elements_Public_Abstract_Virtual_New_get_IList_1_Element_0;

		// Token: 0x0400082D RID: 2093
		private static readonly IntPtr NativeMethodInfoPtr_get_buttonCount_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x0400082E RID: 2094
		private static readonly IntPtr NativeMethodInfoPtr_get_axisCount_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x0400082F RID: 2095
		private static readonly IntPtr NativeMethodInfoPtr_get_elementCount_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04000830 RID: 2096
		private static readonly IntPtr NativeMethodInfoPtr_add_ButtonStateChangedEvent_Public_Abstract_Virtual_New_add_Void_Action_2_Int32_Boolean_0;

		// Token: 0x04000831 RID: 2097
		private static readonly IntPtr NativeMethodInfoPtr_remove_ButtonStateChangedEvent_Public_Abstract_Virtual_New_rem_Void_Action_2_Int32_Boolean_0;

		// Token: 0x04000832 RID: 2098
		private static readonly IntPtr NativeMethodInfoPtr_add_AxisValueChangedEvent_Public_Abstract_Virtual_New_add_Void_Action_2_Int32_Single_0;

		// Token: 0x04000833 RID: 2099
		private static readonly IntPtr NativeMethodInfoPtr_remove_AxisValueChangedEvent_Public_Abstract_Virtual_New_rem_Void_Action_2_Int32_Single_0;

		// Token: 0x04000834 RID: 2100
		private static readonly IntPtr NativeMethodInfoPtr_add_EnabledStateChangedEvent_Public_Abstract_Virtual_New_add_Void_Action_1_Boolean_0;

		// Token: 0x04000835 RID: 2101
		private static readonly IntPtr NativeMethodInfoPtr_remove_EnabledStateChangedEvent_Public_Abstract_Virtual_New_rem_Void_Action_1_Boolean_0;

		// Token: 0x04000836 RID: 2102
		private static readonly IntPtr NativeMethodInfoPtr_GetButton_Public_Abstract_Virtual_New_Boolean_Int32_0;

		// Token: 0x04000837 RID: 2103
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonDown_Public_Abstract_Virtual_New_Boolean_Int32_0;

		// Token: 0x04000838 RID: 2104
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonUp_Public_Abstract_Virtual_New_Boolean_Int32_0;

		// Token: 0x04000839 RID: 2105
		private static readonly IntPtr NativeMethodInfoPtr_GetAxis_Public_Abstract_Virtual_New_Single_Int32_0;

		// Token: 0x0400083A RID: 2106
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisRaw_Public_Abstract_Virtual_New_Single_Int32_0;

		// Token: 0x0400083B RID: 2107
		private static readonly IntPtr NativeMethodInfoPtr_GetElement_Public_Abstract_Virtual_New_Element_Int32_0;

		// Token: 0x0400083C RID: 2108
		private static readonly IntPtr NativeMethodInfoPtr_GetElement_Public_Abstract_Virtual_New_T_Int32_0;

		// Token: 0x0200026E RID: 622
		private sealed class MethodInfoStoreGeneric_GetElement_Public_Abstract_Virtual_New_T_Int32_0<T>
		{
			// Token: 0x0400306C RID: 12396
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(IPlayerController.NativeMethodInfoPtr_GetElement_Public_Abstract_Virtual_New_T_Int32_0, Il2CppClassPointerStore<IPlayerController>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
