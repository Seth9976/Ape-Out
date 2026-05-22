using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000088 RID: 136
	public class ISite : Il2CppObjectBase
	{
		// Token: 0x060008A5 RID: 2213 RVA: 0x0003107C File Offset: 0x0002F27C
		// Note: this type is marked as 'beforefieldinit'.
		static ISite()
		{
			Il2CppClassPointerStore<ISite>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "ISite");
			ISite.NativeMethodInfoPtr_get_Container_Public_Abstract_Virtual_New_get_IContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISite>.NativeClassPtr, 100664538);
			ISite.NativeMethodInfoPtr_get_DesignMode_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISite>.NativeClassPtr, 100664539);
			ISite.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISite>.NativeClassPtr, 100664540);
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x060008A6 RID: 2214 RVA: 0x000310E0 File Offset: 0x0002F2E0
		public unsafe virtual IContainer Container
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISite.NativeMethodInfoPtr_get_Container_Public_Abstract_Virtual_New_get_IContainer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IContainer>(intPtr3) : null;
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x060008A7 RID: 2215 RVA: 0x0003112C File Offset: 0x0002F32C
		public unsafe virtual bool DesignMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISite.NativeMethodInfoPtr_get_DesignMode_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x060008A8 RID: 2216 RVA: 0x00031174 File Offset: 0x0002F374
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISite.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x000056F8 File Offset: 0x000038F8
		public ISite(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000658 RID: 1624
		private static readonly IntPtr NativeMethodInfoPtr_get_Container_Public_Abstract_Virtual_New_get_IContainer_0;

		// Token: 0x04000659 RID: 1625
		private static readonly IntPtr NativeMethodInfoPtr_get_DesignMode_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x0400065A RID: 1626
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0;
	}
}
