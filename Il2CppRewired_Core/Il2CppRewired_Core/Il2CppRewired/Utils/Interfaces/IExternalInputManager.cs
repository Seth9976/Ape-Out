using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Platforms;
using Il2CppSystem;

namespace Il2CppRewired.Utils.Interfaces
{
	// Token: 0x020000F4 RID: 244
	public class IExternalInputManager : Il2CppObjectBase
	{
		// Token: 0x060018FB RID: 6395 RVA: 0x0008E87C File Offset: 0x0008CA7C
		// Note: this type is marked as 'beforefieldinit'.
		static IExternalInputManager()
		{
			Il2CppClassPointerStore<IExternalInputManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Interfaces", "IExternalInputManager");
			IExternalInputManager.NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Object_Platform_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalInputManager>.NativeClassPtr, 100669364);
			IExternalInputManager.NativeMethodInfoPtr_Deinitialize_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalInputManager>.NativeClassPtr, 100669365);
		}

		// Token: 0x060018FC RID: 6396 RVA: 0x0008E8CC File Offset: 0x0008CACC
		[CallerCount(0)]
		public unsafe virtual Object Initialize(Il2CppRewired.Platforms.Platform platform, Object configVars)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref platform;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(configVars);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalInputManager.NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Object_Platform_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060018FD RID: 6397 RVA: 0x0008E938 File Offset: 0x0008CB38
		[CallerCount(0)]
		public unsafe virtual void Deinitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalInputManager.NativeMethodInfoPtr_Deinitialize_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018FE RID: 6398 RVA: 0x0000A25B File Offset: 0x0000845B
		public IExternalInputManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040015CA RID: 5578
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Object_Platform_Object_0;

		// Token: 0x040015CB RID: 5579
		private static readonly IntPtr NativeMethodInfoPtr_Deinitialize_Public_Abstract_Virtual_New_Void_0;
	}
}
