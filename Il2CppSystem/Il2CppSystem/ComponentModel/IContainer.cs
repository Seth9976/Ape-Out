using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000087 RID: 135
	public class IContainer : Il2CppObjectBase
	{
		// Token: 0x060008A1 RID: 2209 RVA: 0x00030F8C File Offset: 0x0002F18C
		// Note: this type is marked as 'beforefieldinit'.
		static IContainer()
		{
			Il2CppClassPointerStore<IContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "IContainer");
			IContainer.NativeMethodInfoPtr_Add_Public_Abstract_Virtual_New_Void_IComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IContainer>.NativeClassPtr, 100664536);
			IContainer.NativeMethodInfoPtr_Remove_Public_Abstract_Virtual_New_Void_IComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IContainer>.NativeClassPtr, 100664537);
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x00030FDC File Offset: 0x0002F1DC
		[CallerCount(0)]
		public unsafe virtual void Add(IComponent component)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IContainer.NativeMethodInfoPtr_Add_Public_Abstract_Virtual_New_Void_IComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x0003102C File Offset: 0x0002F22C
		[CallerCount(0)]
		public unsafe virtual void Remove(IComponent component)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IContainer.NativeMethodInfoPtr_Remove_Public_Abstract_Virtual_New_Void_IComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x000056EF File Offset: 0x000038EF
		public IContainer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000656 RID: 1622
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Abstract_Virtual_New_Void_IComponent_0;

		// Token: 0x04000657 RID: 1623
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Abstract_Virtual_New_Void_IComponent_0;
	}
}
