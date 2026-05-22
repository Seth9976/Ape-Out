using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Net
{
	// Token: 0x02000106 RID: 262
	public class ICloseEx : Il2CppObjectBase
	{
		// Token: 0x06000E55 RID: 3669 RVA: 0x00007968 File Offset: 0x00005B68
		// Note: this type is marked as 'beforefieldinit'.
		static ICloseEx()
		{
			Il2CppClassPointerStore<ICloseEx>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "ICloseEx");
			ICloseEx.NativeMethodInfoPtr_CloseEx_Public_Abstract_Virtual_New_Void_CloseExState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICloseEx>.NativeClassPtr, 100665362);
		}

		// Token: 0x06000E56 RID: 3670 RVA: 0x00046A38 File Offset: 0x00044C38
		[CallerCount(0)]
		public unsafe virtual void CloseEx(CloseExState closeState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref closeState;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICloseEx.NativeMethodInfoPtr_CloseEx_Public_Abstract_Virtual_New_Void_CloseExState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E57 RID: 3671 RVA: 0x00007997 File Offset: 0x00005B97
		public ICloseEx(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B36 RID: 2870
		private static readonly IntPtr NativeMethodInfoPtr_CloseEx_Public_Abstract_Virtual_New_Void_CloseExState_0;
	}
}
