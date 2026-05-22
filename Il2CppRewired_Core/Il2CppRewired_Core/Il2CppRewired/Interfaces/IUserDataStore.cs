using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppRewired.Interfaces
{
	// Token: 0x020000C0 RID: 192
	public class IUserDataStore : Il2CppObjectBase
	{
		// Token: 0x060017CD RID: 6093 RVA: 0x000885C8 File Offset: 0x000867C8
		// Note: this type is marked as 'beforefieldinit'.
		static IUserDataStore()
		{
			Il2CppClassPointerStore<IUserDataStore>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Interfaces", "IUserDataStore");
			IUserDataStore.NativeMethodInfoPtr_Save_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUserDataStore>.NativeClassPtr, 100669126);
			IUserDataStore.NativeMethodInfoPtr_SaveControllerData_Public_Abstract_Virtual_New_Void_Int32_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUserDataStore>.NativeClassPtr, 100669127);
			IUserDataStore.NativeMethodInfoPtr_SaveControllerData_Public_Abstract_Virtual_New_Void_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUserDataStore>.NativeClassPtr, 100669128);
			IUserDataStore.NativeMethodInfoPtr_SavePlayerData_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUserDataStore>.NativeClassPtr, 100669129);
			IUserDataStore.NativeMethodInfoPtr_SaveInputBehavior_Public_Abstract_Virtual_New_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUserDataStore>.NativeClassPtr, 100669130);
			IUserDataStore.NativeMethodInfoPtr_Load_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUserDataStore>.NativeClassPtr, 100669131);
			IUserDataStore.NativeMethodInfoPtr_LoadControllerData_Public_Abstract_Virtual_New_Void_Int32_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUserDataStore>.NativeClassPtr, 100669132);
			IUserDataStore.NativeMethodInfoPtr_LoadControllerData_Public_Abstract_Virtual_New_Void_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUserDataStore>.NativeClassPtr, 100669133);
			IUserDataStore.NativeMethodInfoPtr_LoadPlayerData_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUserDataStore>.NativeClassPtr, 100669134);
			IUserDataStore.NativeMethodInfoPtr_LoadInputBehavior_Public_Abstract_Virtual_New_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUserDataStore>.NativeClassPtr, 100669135);
		}

		// Token: 0x060017CE RID: 6094 RVA: 0x000886B8 File Offset: 0x000868B8
		[CallerCount(0)]
		public unsafe virtual void Save()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUserDataStore.NativeMethodInfoPtr_Save_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017CF RID: 6095 RVA: 0x000886F4 File Offset: 0x000868F4
		[CallerCount(0)]
		public unsafe virtual void SaveControllerData(int playerId, ControllerType controllerType, int controllerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controllerType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controllerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUserDataStore.NativeMethodInfoPtr_SaveControllerData_Public_Abstract_Virtual_New_Void_Int32_ControllerType_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017D0 RID: 6096 RVA: 0x0008875C File Offset: 0x0008695C
		[CallerCount(0)]
		public unsafe virtual void SaveControllerData(ControllerType controllerType, int controllerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controllerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUserDataStore.NativeMethodInfoPtr_SaveControllerData_Public_Abstract_Virtual_New_Void_ControllerType_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017D1 RID: 6097 RVA: 0x000887B4 File Offset: 0x000869B4
		[CallerCount(0)]
		public unsafe virtual void SavePlayerData(int playerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUserDataStore.NativeMethodInfoPtr_SavePlayerData_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017D2 RID: 6098 RVA: 0x00088800 File Offset: 0x00086A00
		[CallerCount(0)]
		public unsafe virtual void SaveInputBehavior(int playerId, int behaviorId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref behaviorId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUserDataStore.NativeMethodInfoPtr_SaveInputBehavior_Public_Abstract_Virtual_New_Void_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017D3 RID: 6099 RVA: 0x00088858 File Offset: 0x00086A58
		[CallerCount(0)]
		public unsafe virtual void Load()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUserDataStore.NativeMethodInfoPtr_Load_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017D4 RID: 6100 RVA: 0x00088894 File Offset: 0x00086A94
		[CallerCount(0)]
		public unsafe virtual void LoadControllerData(int playerId, ControllerType controllerType, int controllerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controllerType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controllerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUserDataStore.NativeMethodInfoPtr_LoadControllerData_Public_Abstract_Virtual_New_Void_Int32_ControllerType_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017D5 RID: 6101 RVA: 0x000888FC File Offset: 0x00086AFC
		[CallerCount(0)]
		public unsafe virtual void LoadControllerData(ControllerType controllerType, int controllerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controllerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUserDataStore.NativeMethodInfoPtr_LoadControllerData_Public_Abstract_Virtual_New_Void_ControllerType_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017D6 RID: 6102 RVA: 0x00088954 File Offset: 0x00086B54
		[CallerCount(0)]
		public unsafe virtual void LoadPlayerData(int playerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUserDataStore.NativeMethodInfoPtr_LoadPlayerData_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017D7 RID: 6103 RVA: 0x000889A0 File Offset: 0x00086BA0
		[CallerCount(0)]
		public unsafe virtual void LoadInputBehavior(int playerId, int behaviorId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref behaviorId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUserDataStore.NativeMethodInfoPtr_LoadInputBehavior_Public_Abstract_Virtual_New_Void_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017D8 RID: 6104 RVA: 0x0000A066 File Offset: 0x00008266
		public IUserDataStore(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001342 RID: 4930
		private static readonly IntPtr NativeMethodInfoPtr_Save_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04001343 RID: 4931
		private static readonly IntPtr NativeMethodInfoPtr_SaveControllerData_Public_Abstract_Virtual_New_Void_Int32_ControllerType_Int32_0;

		// Token: 0x04001344 RID: 4932
		private static readonly IntPtr NativeMethodInfoPtr_SaveControllerData_Public_Abstract_Virtual_New_Void_ControllerType_Int32_0;

		// Token: 0x04001345 RID: 4933
		private static readonly IntPtr NativeMethodInfoPtr_SavePlayerData_Public_Abstract_Virtual_New_Void_Int32_0;

		// Token: 0x04001346 RID: 4934
		private static readonly IntPtr NativeMethodInfoPtr_SaveInputBehavior_Public_Abstract_Virtual_New_Void_Int32_Int32_0;

		// Token: 0x04001347 RID: 4935
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04001348 RID: 4936
		private static readonly IntPtr NativeMethodInfoPtr_LoadControllerData_Public_Abstract_Virtual_New_Void_Int32_ControllerType_Int32_0;

		// Token: 0x04001349 RID: 4937
		private static readonly IntPtr NativeMethodInfoPtr_LoadControllerData_Public_Abstract_Virtual_New_Void_ControllerType_Int32_0;

		// Token: 0x0400134A RID: 4938
		private static readonly IntPtr NativeMethodInfoPtr_LoadPlayerData_Public_Abstract_Virtual_New_Void_Int32_0;

		// Token: 0x0400134B RID: 4939
		private static readonly IntPtr NativeMethodInfoPtr_LoadInputBehavior_Public_Abstract_Virtual_New_Void_Int32_Int32_0;
	}
}
