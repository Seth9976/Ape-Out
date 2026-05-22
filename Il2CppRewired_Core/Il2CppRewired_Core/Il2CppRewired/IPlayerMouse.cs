using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Utils.Classes.Data;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppRewired
{
	// Token: 0x02000055 RID: 85
	public class IPlayerMouse : Il2CppObjectBase
	{
		// Token: 0x06000A66 RID: 2662 RVA: 0x00055D18 File Offset: 0x00053F18
		// Note: this type is marked as 'beforefieldinit'.
		static IPlayerMouse()
		{
			Il2CppClassPointerStore<IPlayerMouse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "IPlayerMouse");
			IPlayerMouse.NativeMethodInfoPtr_get_defaultToCenter_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerMouse>.NativeClassPtr, 100665042);
			IPlayerMouse.NativeMethodInfoPtr_get_movementArea_Public_Abstract_Virtual_New_get_ScreenRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerMouse>.NativeClassPtr, 100665043);
			IPlayerMouse.NativeMethodInfoPtr_set_movementArea_Public_Abstract_Virtual_New_set_Void_ScreenRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerMouse>.NativeClassPtr, 100665044);
			IPlayerMouse.NativeMethodInfoPtr_get_movementAreaUnit_Public_Abstract_Virtual_New_get_MovementAreaUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerMouse>.NativeClassPtr, 100665045);
			IPlayerMouse.NativeMethodInfoPtr_set_movementAreaUnit_Public_Abstract_Virtual_New_set_Void_MovementAreaUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerMouse>.NativeClassPtr, 100665046);
			IPlayerMouse.NativeMethodInfoPtr_get_screenPosition_Public_Abstract_Virtual_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerMouse>.NativeClassPtr, 100665047);
			IPlayerMouse.NativeMethodInfoPtr_get_screenPositionPrev_Public_Abstract_Virtual_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerMouse>.NativeClassPtr, 100665048);
			IPlayerMouse.NativeMethodInfoPtr_get_screenPositionDelta_Public_Abstract_Virtual_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerMouse>.NativeClassPtr, 100665049);
			IPlayerMouse.NativeMethodInfoPtr_get_xAxis_Public_Abstract_Virtual_New_get_MouseAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerMouse>.NativeClassPtr, 100665050);
			IPlayerMouse.NativeMethodInfoPtr_get_yAxis_Public_Abstract_Virtual_New_get_MouseAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerMouse>.NativeClassPtr, 100665051);
			IPlayerMouse.NativeMethodInfoPtr_get_wheel_Public_Abstract_Virtual_New_get_MouseWheel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerMouse>.NativeClassPtr, 100665052);
			IPlayerMouse.NativeMethodInfoPtr_get_leftButton_Public_Abstract_Virtual_New_get_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerMouse>.NativeClassPtr, 100665053);
			IPlayerMouse.NativeMethodInfoPtr_get_rightButton_Public_Abstract_Virtual_New_get_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerMouse>.NativeClassPtr, 100665054);
			IPlayerMouse.NativeMethodInfoPtr_get_middleButton_Public_Abstract_Virtual_New_get_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerMouse>.NativeClassPtr, 100665055);
			IPlayerMouse.NativeMethodInfoPtr_get_pointerSpeed_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerMouse>.NativeClassPtr, 100665056);
			IPlayerMouse.NativeMethodInfoPtr_get_useHardwarePointerPosition_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerMouse>.NativeClassPtr, 100665057);
			IPlayerMouse.NativeMethodInfoPtr_add_ScreenPositionChangedEvent_Public_Abstract_Virtual_New_add_Void_Action_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerMouse>.NativeClassPtr, 100665058);
			IPlayerMouse.NativeMethodInfoPtr_remove_ScreenPositionChangedEvent_Public_Abstract_Virtual_New_rem_Void_Action_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerMouse>.NativeClassPtr, 100665059);
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000A67 RID: 2663 RVA: 0x00055EA8 File Offset: 0x000540A8
		public unsafe virtual bool defaultToCenter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerMouse.NativeMethodInfoPtr_get_defaultToCenter_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000A68 RID: 2664 RVA: 0x00055EF0 File Offset: 0x000540F0
		// (set) Token: 0x06000A69 RID: 2665 RVA: 0x00055F38 File Offset: 0x00054138
		public unsafe virtual ScreenRect movementArea
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerMouse.NativeMethodInfoPtr_get_movementArea_Public_Abstract_Virtual_New_get_ScreenRect_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerMouse.NativeMethodInfoPtr_set_movementArea_Public_Abstract_Virtual_New_set_Void_ScreenRect_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000A6A RID: 2666 RVA: 0x00055F84 File Offset: 0x00054184
		// (set) Token: 0x06000A6B RID: 2667 RVA: 0x00055FCC File Offset: 0x000541CC
		public unsafe virtual PlayerMouse.MovementAreaUnit movementAreaUnit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerMouse.NativeMethodInfoPtr_get_movementAreaUnit_Public_Abstract_Virtual_New_get_MovementAreaUnit_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerMouse.NativeMethodInfoPtr_set_movementAreaUnit_Public_Abstract_Virtual_New_set_Void_MovementAreaUnit_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000A6C RID: 2668 RVA: 0x00056018 File Offset: 0x00054218
		public unsafe virtual Vector2 screenPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerMouse.NativeMethodInfoPtr_get_screenPosition_Public_Abstract_Virtual_New_get_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000A6D RID: 2669 RVA: 0x00056060 File Offset: 0x00054260
		public unsafe virtual Vector2 screenPositionPrev
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerMouse.NativeMethodInfoPtr_get_screenPositionPrev_Public_Abstract_Virtual_New_get_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000A6E RID: 2670 RVA: 0x000560A8 File Offset: 0x000542A8
		public unsafe virtual Vector2 screenPositionDelta
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerMouse.NativeMethodInfoPtr_get_screenPositionDelta_Public_Abstract_Virtual_New_get_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000A6F RID: 2671 RVA: 0x000560F0 File Offset: 0x000542F0
		public unsafe virtual PlayerController.MouseAxis xAxis
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerMouse.NativeMethodInfoPtr_get_xAxis_Public_Abstract_Virtual_New_get_MouseAxis_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerController.MouseAxis>(intPtr3) : null;
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000A70 RID: 2672 RVA: 0x0005613C File Offset: 0x0005433C
		public unsafe virtual PlayerController.MouseAxis yAxis
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerMouse.NativeMethodInfoPtr_get_yAxis_Public_Abstract_Virtual_New_get_MouseAxis_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerController.MouseAxis>(intPtr3) : null;
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000A71 RID: 2673 RVA: 0x00056188 File Offset: 0x00054388
		public unsafe virtual PlayerController.MouseWheel wheel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerMouse.NativeMethodInfoPtr_get_wheel_Public_Abstract_Virtual_New_get_MouseWheel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerController.MouseWheel>(intPtr3) : null;
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000A72 RID: 2674 RVA: 0x000561D4 File Offset: 0x000543D4
		public unsafe virtual PlayerController.Button leftButton
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerMouse.NativeMethodInfoPtr_get_leftButton_Public_Abstract_Virtual_New_get_Button_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerController.Button>(intPtr3) : null;
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000A73 RID: 2675 RVA: 0x00056220 File Offset: 0x00054420
		public unsafe virtual PlayerController.Button rightButton
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerMouse.NativeMethodInfoPtr_get_rightButton_Public_Abstract_Virtual_New_get_Button_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerController.Button>(intPtr3) : null;
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000A74 RID: 2676 RVA: 0x0005626C File Offset: 0x0005446C
		public unsafe virtual PlayerController.Button middleButton
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerMouse.NativeMethodInfoPtr_get_middleButton_Public_Abstract_Virtual_New_get_Button_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerController.Button>(intPtr3) : null;
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000A75 RID: 2677 RVA: 0x000562B8 File Offset: 0x000544B8
		public unsafe virtual float pointerSpeed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerMouse.NativeMethodInfoPtr_get_pointerSpeed_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000A76 RID: 2678 RVA: 0x00056300 File Offset: 0x00054500
		public unsafe virtual bool useHardwarePointerPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerMouse.NativeMethodInfoPtr_get_useHardwarePointerPosition_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x00056348 File Offset: 0x00054548
		[CallerCount(0)]
		public unsafe virtual void add_ScreenPositionChangedEvent(Action<Vector2> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerMouse.NativeMethodInfoPtr_add_ScreenPositionChangedEvent_Public_Abstract_Virtual_New_add_Void_Action_1_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x00056398 File Offset: 0x00054598
		[CallerCount(0)]
		public unsafe virtual void remove_ScreenPositionChangedEvent(Action<Vector2> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerMouse.NativeMethodInfoPtr_remove_ScreenPositionChangedEvent_Public_Abstract_Virtual_New_rem_Void_Action_1_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x000056F4 File Offset: 0x000038F4
		public IPlayerMouse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400086A RID: 2154
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultToCenter_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x0400086B RID: 2155
		private static readonly IntPtr NativeMethodInfoPtr_get_movementArea_Public_Abstract_Virtual_New_get_ScreenRect_0;

		// Token: 0x0400086C RID: 2156
		private static readonly IntPtr NativeMethodInfoPtr_set_movementArea_Public_Abstract_Virtual_New_set_Void_ScreenRect_0;

		// Token: 0x0400086D RID: 2157
		private static readonly IntPtr NativeMethodInfoPtr_get_movementAreaUnit_Public_Abstract_Virtual_New_get_MovementAreaUnit_0;

		// Token: 0x0400086E RID: 2158
		private static readonly IntPtr NativeMethodInfoPtr_set_movementAreaUnit_Public_Abstract_Virtual_New_set_Void_MovementAreaUnit_0;

		// Token: 0x0400086F RID: 2159
		private static readonly IntPtr NativeMethodInfoPtr_get_screenPosition_Public_Abstract_Virtual_New_get_Vector2_0;

		// Token: 0x04000870 RID: 2160
		private static readonly IntPtr NativeMethodInfoPtr_get_screenPositionPrev_Public_Abstract_Virtual_New_get_Vector2_0;

		// Token: 0x04000871 RID: 2161
		private static readonly IntPtr NativeMethodInfoPtr_get_screenPositionDelta_Public_Abstract_Virtual_New_get_Vector2_0;

		// Token: 0x04000872 RID: 2162
		private static readonly IntPtr NativeMethodInfoPtr_get_xAxis_Public_Abstract_Virtual_New_get_MouseAxis_0;

		// Token: 0x04000873 RID: 2163
		private static readonly IntPtr NativeMethodInfoPtr_get_yAxis_Public_Abstract_Virtual_New_get_MouseAxis_0;

		// Token: 0x04000874 RID: 2164
		private static readonly IntPtr NativeMethodInfoPtr_get_wheel_Public_Abstract_Virtual_New_get_MouseWheel_0;

		// Token: 0x04000875 RID: 2165
		private static readonly IntPtr NativeMethodInfoPtr_get_leftButton_Public_Abstract_Virtual_New_get_Button_0;

		// Token: 0x04000876 RID: 2166
		private static readonly IntPtr NativeMethodInfoPtr_get_rightButton_Public_Abstract_Virtual_New_get_Button_0;

		// Token: 0x04000877 RID: 2167
		private static readonly IntPtr NativeMethodInfoPtr_get_middleButton_Public_Abstract_Virtual_New_get_Button_0;

		// Token: 0x04000878 RID: 2168
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerSpeed_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x04000879 RID: 2169
		private static readonly IntPtr NativeMethodInfoPtr_get_useHardwarePointerPosition_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x0400087A RID: 2170
		private static readonly IntPtr NativeMethodInfoPtr_add_ScreenPositionChangedEvent_Public_Abstract_Virtual_New_add_Void_Action_1_Vector2_0;

		// Token: 0x0400087B RID: 2171
		private static readonly IntPtr NativeMethodInfoPtr_remove_ScreenPositionChangedEvent_Public_Abstract_Virtual_New_rem_Void_Action_1_Vector2_0;
	}
}
