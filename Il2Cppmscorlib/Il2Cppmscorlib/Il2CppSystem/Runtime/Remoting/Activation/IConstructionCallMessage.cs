using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Runtime.Remoting.Activation
{
	// Token: 0x020003D6 RID: 982
	public class IConstructionCallMessage : Il2CppObjectBase
	{
		// Token: 0x06003F86 RID: 16262 RVA: 0x0012A8BC File Offset: 0x00128ABC
		// Note: this type is marked as 'beforefieldinit'.
		static IConstructionCallMessage()
		{
			Il2CppClassPointerStore<IConstructionCallMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Activation", "IConstructionCallMessage");
			IConstructionCallMessage.NativeMethodInfoPtr_get_ActivationType_Public_Abstract_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConstructionCallMessage>.NativeClassPtr, 100672680);
			IConstructionCallMessage.NativeMethodInfoPtr_get_ActivationTypeName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConstructionCallMessage>.NativeClassPtr, 100672681);
			IConstructionCallMessage.NativeMethodInfoPtr_get_Activator_Public_Abstract_Virtual_New_get_IActivator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConstructionCallMessage>.NativeClassPtr, 100672682);
			IConstructionCallMessage.NativeMethodInfoPtr_set_Activator_Public_Abstract_Virtual_New_set_Void_IActivator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConstructionCallMessage>.NativeClassPtr, 100672683);
			IConstructionCallMessage.NativeMethodInfoPtr_get_CallSiteActivationAttributes_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConstructionCallMessage>.NativeClassPtr, 100672684);
			IConstructionCallMessage.NativeMethodInfoPtr_get_ContextProperties_Public_Abstract_Virtual_New_get_IList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConstructionCallMessage>.NativeClassPtr, 100672685);
		}

		// Token: 0x17000FE6 RID: 4070
		// (get) Token: 0x06003F87 RID: 16263 RVA: 0x0012A95C File Offset: 0x00128B5C
		public unsafe virtual Type ActivationType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConstructionCallMessage.NativeMethodInfoPtr_get_ActivationType_Public_Abstract_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000FE7 RID: 4071
		// (get) Token: 0x06003F88 RID: 16264 RVA: 0x0012A9A8 File Offset: 0x00128BA8
		public unsafe virtual string ActivationTypeName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConstructionCallMessage.NativeMethodInfoPtr_get_ActivationTypeName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000FE8 RID: 4072
		// (get) Token: 0x06003F89 RID: 16265 RVA: 0x0012A9EC File Offset: 0x00128BEC
		// (set) Token: 0x06003F8A RID: 16266 RVA: 0x0012AA38 File Offset: 0x00128C38
		public unsafe virtual IActivator Activator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConstructionCallMessage.NativeMethodInfoPtr_get_Activator_Public_Abstract_Virtual_New_get_IActivator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IActivator>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConstructionCallMessage.NativeMethodInfoPtr_set_Activator_Public_Abstract_Virtual_New_set_Void_IActivator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000FE9 RID: 4073
		// (get) Token: 0x06003F8B RID: 16267 RVA: 0x0012AA88 File Offset: 0x00128C88
		public unsafe virtual Il2CppReferenceArray<Object> CallSiteActivationAttributes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConstructionCallMessage.NativeMethodInfoPtr_get_CallSiteActivationAttributes_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x17000FEA RID: 4074
		// (get) Token: 0x06003F8C RID: 16268 RVA: 0x0012AAD4 File Offset: 0x00128CD4
		public unsafe virtual IList ContextProperties
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConstructionCallMessage.NativeMethodInfoPtr_get_ContextProperties_Public_Abstract_Virtual_New_get_IList_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList>(intPtr3) : null;
			}
		}

		// Token: 0x06003F8D RID: 16269 RVA: 0x00017BE4 File Offset: 0x00015DE4
		public IConstructionCallMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003448 RID: 13384
		private static readonly IntPtr NativeMethodInfoPtr_get_ActivationType_Public_Abstract_Virtual_New_get_Type_0;

		// Token: 0x04003449 RID: 13385
		private static readonly IntPtr NativeMethodInfoPtr_get_ActivationTypeName_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x0400344A RID: 13386
		private static readonly IntPtr NativeMethodInfoPtr_get_Activator_Public_Abstract_Virtual_New_get_IActivator_0;

		// Token: 0x0400344B RID: 13387
		private static readonly IntPtr NativeMethodInfoPtr_set_Activator_Public_Abstract_Virtual_New_set_Void_IActivator_0;

		// Token: 0x0400344C RID: 13388
		private static readonly IntPtr NativeMethodInfoPtr_get_CallSiteActivationAttributes_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400344D RID: 13389
		private static readonly IntPtr NativeMethodInfoPtr_get_ContextProperties_Public_Abstract_Virtual_New_get_IList_0;
	}
}
