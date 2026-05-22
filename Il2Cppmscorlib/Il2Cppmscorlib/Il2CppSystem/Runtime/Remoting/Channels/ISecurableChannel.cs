using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.Remoting.Channels
{
	// Token: 0x020003CE RID: 974
	public class ISecurableChannel : Il2CppObjectBase
	{
		// Token: 0x06003F50 RID: 16208 RVA: 0x00017A72 File Offset: 0x00015C72
		// Note: this type is marked as 'beforefieldinit'.
		static ISecurableChannel()
		{
			Il2CppClassPointerStore<ISecurableChannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Channels", "ISecurableChannel");
			ISecurableChannel.NativeMethodInfoPtr_set_IsSecured_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISecurableChannel>.NativeClassPtr, 100672656);
		}

		// Token: 0x17000FD6 RID: 4054
		// (set) Token: 0x06003F51 RID: 16209 RVA: 0x00129D38 File Offset: 0x00127F38
		public unsafe virtual bool IsSecured
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISecurableChannel.NativeMethodInfoPtr_set_IsSecured_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003F52 RID: 16210 RVA: 0x00017AA1 File Offset: 0x00015CA1
		public ISecurableChannel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003429 RID: 13353
		private static readonly IntPtr NativeMethodInfoPtr_set_IsSecured_Public_Abstract_Virtual_New_set_Void_Boolean_0;
	}
}
