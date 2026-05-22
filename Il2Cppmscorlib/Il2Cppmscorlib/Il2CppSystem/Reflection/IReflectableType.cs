using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001A9 RID: 425
	public class IReflectableType : Il2CppObjectBase
	{
		// Token: 0x06001C13 RID: 7187 RVA: 0x00009901 File Offset: 0x00007B01
		// Note: this type is marked as 'beforefieldinit'.
		static IReflectableType()
		{
			Il2CppClassPointerStore<IReflectableType>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "IReflectableType");
			IReflectableType.NativeMethodInfoPtr_GetTypeInfo_Public_Abstract_Virtual_New_TypeInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IReflectableType>.NativeClassPtr, 100668049);
		}

		// Token: 0x06001C14 RID: 7188 RVA: 0x000A2D40 File Offset: 0x000A0F40
		[CallerCount(0)]
		public unsafe virtual TypeInfo GetTypeInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IReflectableType.NativeMethodInfoPtr_GetTypeInfo_Public_Abstract_Virtual_New_TypeInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeInfo>(intPtr3) : null;
		}

		// Token: 0x06001C15 RID: 7189 RVA: 0x00009930 File Offset: 0x00007B30
		public IReflectableType(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001996 RID: 6550
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeInfo_Public_Abstract_Virtual_New_TypeInfo_0;
	}
}
