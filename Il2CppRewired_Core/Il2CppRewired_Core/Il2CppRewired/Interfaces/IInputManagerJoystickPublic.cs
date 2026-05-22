using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.Interfaces
{
	// Token: 0x020000E7 RID: 231
	public class IInputManagerJoystickPublic : Il2CppObjectBase
	{
		// Token: 0x06001843 RID: 6211 RVA: 0x0008A520 File Offset: 0x00088720
		// Note: this type is marked as 'beforefieldinit'.
		static IInputManagerJoystickPublic()
		{
			Il2CppClassPointerStore<IInputManagerJoystickPublic>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Interfaces", "IInputManagerJoystickPublic");
			IInputManagerJoystickPublic.NativeMethodInfoPtr_get_rewiredId_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputManagerJoystickPublic>.NativeClassPtr, 100669206);
			IInputManagerJoystickPublic.NativeMethodInfoPtr_get_inputManagerId_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputManagerJoystickPublic>.NativeClassPtr, 100669207);
			IInputManagerJoystickPublic.NativeMethodInfoPtr_get_name_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputManagerJoystickPublic>.NativeClassPtr, 100669208);
			IInputManagerJoystickPublic.NativeMethodInfoPtr_get_systemId_Public_Abstract_Virtual_New_get_Nullable_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputManagerJoystickPublic>.NativeClassPtr, 100669209);
			IInputManagerJoystickPublic.NativeMethodInfoPtr_get_unityId_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputManagerJoystickPublic>.NativeClassPtr, 100669210);
			IInputManagerJoystickPublic.NativeMethodInfoPtr_get_extension_Public_Abstract_Virtual_New_get_Extension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputManagerJoystickPublic>.NativeClassPtr, 100669211);
			IInputManagerJoystickPublic.NativeMethodInfoPtr_get_instanceGuid_Public_Abstract_Virtual_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputManagerJoystickPublic>.NativeClassPtr, 100669212);
			IInputManagerJoystickPublic.NativeMethodInfoPtr_get_persistentGuid_Public_Abstract_Virtual_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputManagerJoystickPublic>.NativeClassPtr, 100669213);
			IInputManagerJoystickPublic.NativeMethodInfoPtr_SetVibration_Public_Abstract_Virtual_New_Void_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputManagerJoystickPublic>.NativeClassPtr, 100669214);
			IInputManagerJoystickPublic.NativeMethodInfoPtr_StopVibration_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputManagerJoystickPublic>.NativeClassPtr, 100669215);
		}

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x06001844 RID: 6212 RVA: 0x0008A610 File Offset: 0x00088810
		public unsafe virtual int rewiredId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInputManagerJoystickPublic.NativeMethodInfoPtr_get_rewiredId_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x06001845 RID: 6213 RVA: 0x0008A658 File Offset: 0x00088858
		public unsafe virtual int inputManagerId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInputManagerJoystickPublic.NativeMethodInfoPtr_get_inputManagerId_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x06001846 RID: 6214 RVA: 0x0008A6A0 File Offset: 0x000888A0
		public unsafe virtual string name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInputManagerJoystickPublic.NativeMethodInfoPtr_get_name_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x06001847 RID: 6215 RVA: 0x0008A6E4 File Offset: 0x000888E4
		public unsafe virtual Nullable<long> systemId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInputManagerJoystickPublic.NativeMethodInfoPtr_get_systemId_Public_Abstract_Virtual_New_get_Nullable_1_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<long>(intPtr);
			}
		}

		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x06001848 RID: 6216 RVA: 0x0008A728 File Offset: 0x00088928
		public unsafe virtual int unityId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInputManagerJoystickPublic.NativeMethodInfoPtr_get_unityId_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x06001849 RID: 6217 RVA: 0x0008A770 File Offset: 0x00088970
		public unsafe virtual Controller.Extension extension
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInputManagerJoystickPublic.NativeMethodInfoPtr_get_extension_Public_Abstract_Virtual_New_get_Extension_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Controller.Extension>(intPtr3) : null;
			}
		}

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x0600184A RID: 6218 RVA: 0x0008A7BC File Offset: 0x000889BC
		public unsafe virtual Guid instanceGuid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInputManagerJoystickPublic.NativeMethodInfoPtr_get_instanceGuid_Public_Abstract_Virtual_New_get_Guid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x0600184B RID: 6219 RVA: 0x0008A804 File Offset: 0x00088A04
		public unsafe virtual Guid persistentGuid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInputManagerJoystickPublic.NativeMethodInfoPtr_get_persistentGuid_Public_Abstract_Virtual_New_get_Guid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600184C RID: 6220 RVA: 0x0008A84C File Offset: 0x00088A4C
		[CallerCount(0)]
		public unsafe virtual void SetVibration(float amount, int motorIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref motorIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInputManagerJoystickPublic.NativeMethodInfoPtr_SetVibration_Public_Abstract_Virtual_New_Void_Single_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600184D RID: 6221 RVA: 0x0008A8A4 File Offset: 0x00088AA4
		[CallerCount(0)]
		public unsafe virtual void StopVibration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInputManagerJoystickPublic.NativeMethodInfoPtr_StopVibration_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600184E RID: 6222 RVA: 0x0000A1B7 File Offset: 0x000083B7
		public IInputManagerJoystickPublic(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400152C RID: 5420
		private static readonly IntPtr NativeMethodInfoPtr_get_rewiredId_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x0400152D RID: 5421
		private static readonly IntPtr NativeMethodInfoPtr_get_inputManagerId_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x0400152E RID: 5422
		private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x0400152F RID: 5423
		private static readonly IntPtr NativeMethodInfoPtr_get_systemId_Public_Abstract_Virtual_New_get_Nullable_1_Int64_0;

		// Token: 0x04001530 RID: 5424
		private static readonly IntPtr NativeMethodInfoPtr_get_unityId_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04001531 RID: 5425
		private static readonly IntPtr NativeMethodInfoPtr_get_extension_Public_Abstract_Virtual_New_get_Extension_0;

		// Token: 0x04001532 RID: 5426
		private static readonly IntPtr NativeMethodInfoPtr_get_instanceGuid_Public_Abstract_Virtual_New_get_Guid_0;

		// Token: 0x04001533 RID: 5427
		private static readonly IntPtr NativeMethodInfoPtr_get_persistentGuid_Public_Abstract_Virtual_New_get_Guid_0;

		// Token: 0x04001534 RID: 5428
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Abstract_Virtual_New_Void_Single_Int32_0;

		// Token: 0x04001535 RID: 5429
		private static readonly IntPtr NativeMethodInfoPtr_StopVibration_Public_Abstract_Virtual_New_Void_0;
	}
}
