using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppRewired.Interfaces
{
	// Token: 0x020000F1 RID: 241
	public class IAndroidFallbackDS4Helper : Il2CppObjectBase
	{
		// Token: 0x0600189C RID: 6300 RVA: 0x0008C12C File Offset: 0x0008A32C
		// Note: this type is marked as 'beforefieldinit'.
		static IAndroidFallbackDS4Helper()
		{
			Il2CppClassPointerStore<IAndroidFallbackDS4Helper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Interfaces", "IAndroidFallbackDS4Helper");
			IAndroidFallbackDS4Helper.NativeMethodInfoPtr_IsDS4KeyMapped_Public_Abstract_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAndroidFallbackDS4Helper>.NativeClassPtr, 100669275);
			IAndroidFallbackDS4Helper.NativeMethodInfoPtr_IsDS4_Public_Abstract_Virtual_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAndroidFallbackDS4Helper>.NativeClassPtr, 100669276);
		}

		// Token: 0x0600189D RID: 6301 RVA: 0x0008C17C File Offset: 0x0008A37C
		[CallerCount(0)]
		public unsafe virtual bool IsDS4KeyMapped(int unityJoystickArrayIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unityJoystickArrayIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAndroidFallbackDS4Helper.NativeMethodInfoPtr_IsDS4KeyMapped_Public_Abstract_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600189E RID: 6302 RVA: 0x0008C1D0 File Offset: 0x0008A3D0
		[CallerCount(0)]
		public unsafe virtual bool IsDS4(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAndroidFallbackDS4Helper.NativeMethodInfoPtr_IsDS4_Public_Abstract_Virtual_New_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600189F RID: 6303 RVA: 0x0000A240 File Offset: 0x00008440
		public IAndroidFallbackDS4Helper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001571 RID: 5489
		private static readonly IntPtr NativeMethodInfoPtr_IsDS4KeyMapped_Public_Abstract_Virtual_New_Boolean_Int32_0;

		// Token: 0x04001572 RID: 5490
		private static readonly IntPtr NativeMethodInfoPtr_IsDS4_Public_Abstract_Virtual_New_Boolean_String_0;
	}
}
