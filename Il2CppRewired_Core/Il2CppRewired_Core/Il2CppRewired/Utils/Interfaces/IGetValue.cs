using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Il2CppRewired.Utils.Interfaces
{
	// Token: 0x020000FC RID: 252
	public class IGetValue<T> : Il2CppObjectBase
	{
		// Token: 0x0600191B RID: 6427 RVA: 0x0008F3D0 File Offset: 0x0008D5D0
		// Note: this type is marked as 'beforefieldinit'.
		static IGetValue()
		{
			Il2CppClassPointerStore<IGetValue<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Interfaces", "IGetValue`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IGetValue<T>.NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGetValue<T>>.NativeClassPtr, 100669380);
		}

		// Token: 0x0600191C RID: 6428 RVA: 0x0008F448 File Offset: 0x0008D648
		[CallerCount(0)]
		public unsafe virtual T GetValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGetValue<T>.NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600191D RID: 6429 RVA: 0x0000A2D2 File Offset: 0x000084D2
		public IGetValue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040015DA RID: 5594
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_T_0;
	}
}
