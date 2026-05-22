using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Il2CppRewired.Data.Mapping
{
	// Token: 0x020000AF RID: 175
	public class IControllerTemplateMapSpecialElement_Internal : Il2CppObjectBase
	{
		// Token: 0x06001553 RID: 5459 RVA: 0x00009566 File Offset: 0x00007766
		// Note: this type is marked as 'beforefieldinit'.
		static IControllerTemplateMapSpecialElement_Internal()
		{
			Il2CppClassPointerStore<IControllerTemplateMapSpecialElement_Internal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Data.Mapping", "IControllerTemplateMapSpecialElement_Internal");
			IControllerTemplateMapSpecialElement_Internal.NativeMethodInfoPtr_GetMapping_Public_Abstract_Virtual_New_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateMapSpecialElement_Internal>.NativeClassPtr, 100668361);
		}

		// Token: 0x06001554 RID: 5460 RVA: 0x0007CEE0 File Offset: 0x0007B0E0
		[CallerCount(0)]
		public unsafe virtual T GetMapping<T>() where T : ControllerTemplateSpecialElementMapping
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateMapSpecialElement_Internal.MethodInfoStoreGeneric_GetMapping_Public_Abstract_Virtual_New_T_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06001555 RID: 5461 RVA: 0x00009595 File Offset: 0x00007795
		public IControllerTemplateMapSpecialElement_Internal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400110F RID: 4367
		private static readonly IntPtr NativeMethodInfoPtr_GetMapping_Public_Abstract_Virtual_New_T_0;

		// Token: 0x0200030C RID: 780
		private sealed class MethodInfoStoreGeneric_GetMapping_Public_Abstract_Virtual_New_T_0<T>
		{
			// Token: 0x040036D9 RID: 14041
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(IControllerTemplateMapSpecialElement_Internal.NativeMethodInfoPtr_GetMapping_Public_Abstract_Virtual_New_T_0, Il2CppClassPointerStore<IControllerTemplateMapSpecialElement_Internal>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
