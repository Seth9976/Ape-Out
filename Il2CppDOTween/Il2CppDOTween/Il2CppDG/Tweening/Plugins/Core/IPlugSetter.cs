using System;
using Il2CppDG.Tweening.Core;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppDG.Tweening.Plugins.Core
{
	// Token: 0x0200003D RID: 61
	public class IPlugSetter<T1, T2, TPlugin, TPlugOptions> : Il2CppObjectBase
	{
		// Token: 0x060003A7 RID: 935 RVA: 0x00018294 File Offset: 0x00016494
		// Note: this type is marked as 'beforefieldinit'.
		static IPlugSetter()
		{
			Il2CppClassPointerStore<IPlugSetter<T1, T2, TPlugin, TPlugOptions>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Plugins.Core", "IPlugSetter`4"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlugin>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlugOptions>.NativeClassPtr))
			})).TypeHandle.value);
			IPlugSetter<T1, T2, TPlugin, TPlugOptions>.NativeMethodInfoPtr_Getter_Public_Abstract_Virtual_New_DOGetter_1_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlugSetter<T1, T2, TPlugin, TPlugOptions>>.NativeClassPtr, 100664104);
			IPlugSetter<T1, T2, TPlugin, TPlugOptions>.NativeMethodInfoPtr_Setter_Public_Abstract_Virtual_New_DOSetter_1_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlugSetter<T1, T2, TPlugin, TPlugOptions>>.NativeClassPtr, 100664105);
			IPlugSetter<T1, T2, TPlugin, TPlugOptions>.NativeMethodInfoPtr_EndValue_Public_Abstract_Virtual_New_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlugSetter<T1, T2, TPlugin, TPlugOptions>>.NativeClassPtr, 100664106);
			IPlugSetter<T1, T2, TPlugin, TPlugOptions>.NativeMethodInfoPtr_GetOptions_Public_Abstract_Virtual_New_TPlugOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlugSetter<T1, T2, TPlugin, TPlugOptions>>.NativeClassPtr, 100664107);
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x0001837C File Offset: 0x0001657C
		[CallerCount(0)]
		public unsafe virtual DOGetter<T1> Getter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlugSetter<T1, T2, TPlugin, TPlugOptions>.NativeMethodInfoPtr_Getter_Public_Abstract_Virtual_New_DOGetter_1_T1_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DOGetter<T1>>(intPtr3) : null;
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x000183C8 File Offset: 0x000165C8
		[CallerCount(0)]
		public unsafe virtual DOSetter<T1> Setter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlugSetter<T1, T2, TPlugin, TPlugOptions>.NativeMethodInfoPtr_Setter_Public_Abstract_Virtual_New_DOSetter_1_T1_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DOSetter<T1>>(intPtr3) : null;
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00018414 File Offset: 0x00016614
		[CallerCount(0)]
		public unsafe virtual T2 EndValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlugSetter<T1, T2, TPlugin, TPlugOptions>.NativeMethodInfoPtr_EndValue_Public_Abstract_Virtual_New_T2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T2>(intPtr, false, true);
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00018458 File Offset: 0x00016658
		[CallerCount(0)]
		public unsafe virtual TPlugOptions GetOptions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlugSetter<T1, T2, TPlugin, TPlugOptions>.NativeMethodInfoPtr_GetOptions_Public_Abstract_Virtual_New_TPlugOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TPlugOptions>(intPtr, false, true);
		}

		// Token: 0x060003AC RID: 940 RVA: 0x000030EF File Offset: 0x000012EF
		public IPlugSetter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400032F RID: 815
		private static readonly IntPtr NativeMethodInfoPtr_Getter_Public_Abstract_Virtual_New_DOGetter_1_T1_0;

		// Token: 0x04000330 RID: 816
		private static readonly IntPtr NativeMethodInfoPtr_Setter_Public_Abstract_Virtual_New_DOSetter_1_T1_0;

		// Token: 0x04000331 RID: 817
		private static readonly IntPtr NativeMethodInfoPtr_EndValue_Public_Abstract_Virtual_New_T2_0;

		// Token: 0x04000332 RID: 818
		private static readonly IntPtr NativeMethodInfoPtr_GetOptions_Public_Abstract_Virtual_New_TPlugOptions_0;
	}
}
