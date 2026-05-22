using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

namespace Il2CppRewired.Platforms.PS4
{
	// Token: 0x0200018C RID: 396
	public class IPS4ControllerExtensionSourceTouchPad : Il2CppObjectBase
	{
		// Token: 0x060028E6 RID: 10470 RVA: 0x000CE890 File Offset: 0x000CCA90
		// Note: this type is marked as 'beforefieldinit'.
		static IPS4ControllerExtensionSourceTouchPad()
		{
			Il2CppClassPointerStore<IPS4ControllerExtensionSourceTouchPad>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Platforms.PS4", "IPS4ControllerExtensionSourceTouchPad");
			IPS4ControllerExtensionSourceTouchPad.NativeMethodInfoPtr_get_maxTouches_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPS4ControllerExtensionSourceTouchPad>.NativeClassPtr, 100673220);
			IPS4ControllerExtensionSourceTouchPad.NativeMethodInfoPtr_GetTouchPixelDensity_Public_Abstract_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPS4ControllerExtensionSourceTouchPad>.NativeClassPtr, 100673221);
			IPS4ControllerExtensionSourceTouchPad.NativeMethodInfoPtr_GetTouchpadResolutionX_Public_Abstract_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPS4ControllerExtensionSourceTouchPad>.NativeClassPtr, 100673222);
			IPS4ControllerExtensionSourceTouchPad.NativeMethodInfoPtr_GetTouchpadResolutionY_Public_Abstract_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPS4ControllerExtensionSourceTouchPad>.NativeClassPtr, 100673223);
			IPS4ControllerExtensionSourceTouchPad.NativeMethodInfoPtr_GetTouchCount_Public_Abstract_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPS4ControllerExtensionSourceTouchPad>.NativeClassPtr, 100673224);
			IPS4ControllerExtensionSourceTouchPad.NativeMethodInfoPtr_GetTouchId_Public_Abstract_Virtual_New_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPS4ControllerExtensionSourceTouchPad>.NativeClassPtr, 100673225);
			IPS4ControllerExtensionSourceTouchPad.NativeMethodInfoPtr_GetTouchPositionByIndex_Public_Abstract_Virtual_New_Boolean_Int32_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPS4ControllerExtensionSourceTouchPad>.NativeClassPtr, 100673226);
			IPS4ControllerExtensionSourceTouchPad.NativeMethodInfoPtr_GetTouchPositionAbsByIndex_Public_Abstract_Virtual_New_Boolean_Int32_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPS4ControllerExtensionSourceTouchPad>.NativeClassPtr, 100673227);
			IPS4ControllerExtensionSourceTouchPad.NativeMethodInfoPtr_GetTouchPositionByTouchId_Public_Abstract_Virtual_New_Boolean_Int32_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPS4ControllerExtensionSourceTouchPad>.NativeClassPtr, 100673228);
			IPS4ControllerExtensionSourceTouchPad.NativeMethodInfoPtr_GetTouchPositionAbsByTouchId_Public_Abstract_Virtual_New_Boolean_Int32_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPS4ControllerExtensionSourceTouchPad>.NativeClassPtr, 100673229);
			IPS4ControllerExtensionSourceTouchPad.NativeMethodInfoPtr_IsTouchingByIndex_Public_Abstract_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPS4ControllerExtensionSourceTouchPad>.NativeClassPtr, 100673230);
			IPS4ControllerExtensionSourceTouchPad.NativeMethodInfoPtr_IsTouchingByTouchId_Public_Abstract_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPS4ControllerExtensionSourceTouchPad>.NativeClassPtr, 100673231);
		}

		// Token: 0x17000D23 RID: 3363
		// (get) Token: 0x060028E7 RID: 10471 RVA: 0x000CE9A8 File Offset: 0x000CCBA8
		public unsafe virtual int maxTouches
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPS4ControllerExtensionSourceTouchPad.NativeMethodInfoPtr_get_maxTouches_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060028E8 RID: 10472 RVA: 0x000CE9F0 File Offset: 0x000CCBF0
		[CallerCount(0)]
		public unsafe virtual float GetTouchPixelDensity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPS4ControllerExtensionSourceTouchPad.NativeMethodInfoPtr_GetTouchPixelDensity_Public_Abstract_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028E9 RID: 10473 RVA: 0x000CEA38 File Offset: 0x000CCC38
		[CallerCount(0)]
		public unsafe virtual int GetTouchpadResolutionX()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPS4ControllerExtensionSourceTouchPad.NativeMethodInfoPtr_GetTouchpadResolutionX_Public_Abstract_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028EA RID: 10474 RVA: 0x000CEA80 File Offset: 0x000CCC80
		[CallerCount(0)]
		public unsafe virtual int GetTouchpadResolutionY()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPS4ControllerExtensionSourceTouchPad.NativeMethodInfoPtr_GetTouchpadResolutionY_Public_Abstract_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028EB RID: 10475 RVA: 0x000CEAC8 File Offset: 0x000CCCC8
		[CallerCount(0)]
		public unsafe virtual int GetTouchCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPS4ControllerExtensionSourceTouchPad.NativeMethodInfoPtr_GetTouchCount_Public_Abstract_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028EC RID: 10476 RVA: 0x000CEB10 File Offset: 0x000CCD10
		[CallerCount(0)]
		public unsafe virtual int GetTouchId(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPS4ControllerExtensionSourceTouchPad.NativeMethodInfoPtr_GetTouchId_Public_Abstract_Virtual_New_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060028ED RID: 10477 RVA: 0x000CEB64 File Offset: 0x000CCD64
		[CallerCount(0)]
		public unsafe virtual bool GetTouchPositionByIndex(int index, out Vector2 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPS4ControllerExtensionSourceTouchPad.NativeMethodInfoPtr_GetTouchPositionByIndex_Public_Abstract_Virtual_New_Boolean_Int32_byref_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028EE RID: 10478 RVA: 0x000CEBC8 File Offset: 0x000CCDC8
		[CallerCount(0)]
		public unsafe virtual bool GetTouchPositionAbsByIndex(int index, out Vector2 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPS4ControllerExtensionSourceTouchPad.NativeMethodInfoPtr_GetTouchPositionAbsByIndex_Public_Abstract_Virtual_New_Boolean_Int32_byref_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028EF RID: 10479 RVA: 0x000CEC2C File Offset: 0x000CCE2C
		[CallerCount(0)]
		public unsafe virtual bool GetTouchPositionByTouchId(int touchId, out Vector2 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref touchId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPS4ControllerExtensionSourceTouchPad.NativeMethodInfoPtr_GetTouchPositionByTouchId_Public_Abstract_Virtual_New_Boolean_Int32_byref_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028F0 RID: 10480 RVA: 0x000CEC90 File Offset: 0x000CCE90
		[CallerCount(0)]
		public unsafe virtual bool GetTouchPositionAbsByTouchId(int touchId, out Vector2 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref touchId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPS4ControllerExtensionSourceTouchPad.NativeMethodInfoPtr_GetTouchPositionAbsByTouchId_Public_Abstract_Virtual_New_Boolean_Int32_byref_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028F1 RID: 10481 RVA: 0x000CECF4 File Offset: 0x000CCEF4
		[CallerCount(0)]
		public unsafe virtual bool IsTouchingByIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPS4ControllerExtensionSourceTouchPad.NativeMethodInfoPtr_IsTouchingByIndex_Public_Abstract_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060028F2 RID: 10482 RVA: 0x000CED48 File Offset: 0x000CCF48
		[CallerCount(0)]
		public unsafe virtual bool IsTouchingByTouchId(int touchId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref touchId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPS4ControllerExtensionSourceTouchPad.NativeMethodInfoPtr_IsTouchingByTouchId_Public_Abstract_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060028F3 RID: 10483 RVA: 0x0000FB39 File Offset: 0x0000DD39
		public IPS4ControllerExtensionSourceTouchPad(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040022AE RID: 8878
		private static readonly IntPtr NativeMethodInfoPtr_get_maxTouches_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x040022AF RID: 8879
		private static readonly IntPtr NativeMethodInfoPtr_GetTouchPixelDensity_Public_Abstract_Virtual_New_Single_0;

		// Token: 0x040022B0 RID: 8880
		private static readonly IntPtr NativeMethodInfoPtr_GetTouchpadResolutionX_Public_Abstract_Virtual_New_Int32_0;

		// Token: 0x040022B1 RID: 8881
		private static readonly IntPtr NativeMethodInfoPtr_GetTouchpadResolutionY_Public_Abstract_Virtual_New_Int32_0;

		// Token: 0x040022B2 RID: 8882
		private static readonly IntPtr NativeMethodInfoPtr_GetTouchCount_Public_Abstract_Virtual_New_Int32_0;

		// Token: 0x040022B3 RID: 8883
		private static readonly IntPtr NativeMethodInfoPtr_GetTouchId_Public_Abstract_Virtual_New_Int32_Int32_0;

		// Token: 0x040022B4 RID: 8884
		private static readonly IntPtr NativeMethodInfoPtr_GetTouchPositionByIndex_Public_Abstract_Virtual_New_Boolean_Int32_byref_Vector2_0;

		// Token: 0x040022B5 RID: 8885
		private static readonly IntPtr NativeMethodInfoPtr_GetTouchPositionAbsByIndex_Public_Abstract_Virtual_New_Boolean_Int32_byref_Vector2_0;

		// Token: 0x040022B6 RID: 8886
		private static readonly IntPtr NativeMethodInfoPtr_GetTouchPositionByTouchId_Public_Abstract_Virtual_New_Boolean_Int32_byref_Vector2_0;

		// Token: 0x040022B7 RID: 8887
		private static readonly IntPtr NativeMethodInfoPtr_GetTouchPositionAbsByTouchId_Public_Abstract_Virtual_New_Boolean_Int32_byref_Vector2_0;

		// Token: 0x040022B8 RID: 8888
		private static readonly IntPtr NativeMethodInfoPtr_IsTouchingByIndex_Public_Abstract_Virtual_New_Boolean_Int32_0;

		// Token: 0x040022B9 RID: 8889
		private static readonly IntPtr NativeMethodInfoPtr_IsTouchingByTouchId_Public_Abstract_Virtual_New_Boolean_Int32_0;
	}
}
