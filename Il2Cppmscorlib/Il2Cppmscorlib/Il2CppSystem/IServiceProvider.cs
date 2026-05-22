using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x020000C9 RID: 201
	public class IServiceProvider : Il2CppObjectBase
	{
		// Token: 0x06000DD7 RID: 3543 RVA: 0x000058C6 File Offset: 0x00003AC6
		// Note: this type is marked as 'beforefieldinit'.
		static IServiceProvider()
		{
			Il2CppClassPointerStore<IServiceProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "IServiceProvider");
			IServiceProvider.NativeMethodInfoPtr_GetService_Public_Abstract_Virtual_New_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IServiceProvider>.NativeClassPtr, 100665648);
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x00062AA8 File Offset: 0x00060CA8
		[CallerCount(0)]
		public unsafe virtual Object GetService(Type serviceType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serviceType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IServiceProvider.NativeMethodInfoPtr_GetService_Public_Abstract_Virtual_New_Object_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x000058F5 File Offset: 0x00003AF5
		public IServiceProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000BD3 RID: 3027
		private static readonly IntPtr NativeMethodInfoPtr_GetService_Public_Abstract_Virtual_New_Object_Type_0;
	}
}
