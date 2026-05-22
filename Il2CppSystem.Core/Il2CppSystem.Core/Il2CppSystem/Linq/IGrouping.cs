using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Linq
{
	// Token: 0x0200000B RID: 11
	public class IGrouping<TKey, TElement> : Il2CppObjectBase
	{
		// Token: 0x0600008C RID: 140 RVA: 0x00005D00 File Offset: 0x00003F00
		// Note: this type is marked as 'beforefieldinit'.
		static IGrouping()
		{
			Il2CppClassPointerStore<IGrouping<TKey, TElement>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq", "IGrouping`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr))
			})).TypeHandle.value);
			IGrouping<TKey, TElement>.NativeMethodInfoPtr_get_Key_Public_Abstract_Virtual_New_get_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGrouping<TKey, TElement>>.NativeClassPtr, 100663484);
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00005D88 File Offset: 0x00003F88
		public unsafe virtual TKey Key
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGrouping<TKey, TElement>.NativeMethodInfoPtr_get_Key_Public_Abstract_Virtual_New_get_TKey_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TKey>(intPtr, false, true);
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x000021ED File Offset: 0x000003ED
		public IGrouping(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_Abstract_Virtual_New_get_TKey_0;
	}
}
