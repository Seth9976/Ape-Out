using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Threading
{
	// Token: 0x0200026B RID: 619
	public class IAsyncLocal : Il2CppObjectBase
	{
		// Token: 0x06002B2C RID: 11052 RVA: 0x0000EE6E File Offset: 0x0000D06E
		// Note: this type is marked as 'beforefieldinit'.
		static IAsyncLocal()
		{
			Il2CppClassPointerStore<IAsyncLocal>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "IAsyncLocal");
			IAsyncLocal.NativeMethodInfoPtr_OnValueChanged_Public_Abstract_Virtual_New_Void_Object_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsyncLocal>.NativeClassPtr, 100670226);
		}

		// Token: 0x06002B2D RID: 11053 RVA: 0x000E0AB0 File Offset: 0x000DECB0
		[CallerCount(0)]
		public unsafe virtual void OnValueChanged(Object previousValue, Object currentValue, bool contextChanged)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(previousValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentValue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contextChanged;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAsyncLocal.NativeMethodInfoPtr_OnValueChanged_Public_Abstract_Virtual_New_Void_Object_Object_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B2E RID: 11054 RVA: 0x0000EE9D File Offset: 0x0000D09D
		public IAsyncLocal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040025D5 RID: 9685
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Public_Abstract_Virtual_New_Void_Object_Object_Boolean_0;
	}
}
