using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020003F5 RID: 1013
	public class IInternalMessage : Il2CppObjectBase
	{
		// Token: 0x0600410D RID: 16653 RVA: 0x0012FBD0 File Offset: 0x0012DDD0
		// Note: this type is marked as 'beforefieldinit'.
		static IInternalMessage()
		{
			Il2CppClassPointerStore<IInternalMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "IInternalMessage");
			IInternalMessage.NativeMethodInfoPtr_get_TargetIdentity_Public_Abstract_Virtual_New_get_Identity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInternalMessage>.NativeClassPtr, 100672844);
			IInternalMessage.NativeMethodInfoPtr_set_TargetIdentity_Public_Abstract_Virtual_New_set_Void_Identity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInternalMessage>.NativeClassPtr, 100672845);
			IInternalMessage.NativeMethodInfoPtr_get_Uri_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInternalMessage>.NativeClassPtr, 100672846);
			IInternalMessage.NativeMethodInfoPtr_set_Uri_Public_Abstract_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInternalMessage>.NativeClassPtr, 100672847);
		}

		// Token: 0x17001073 RID: 4211
		// (get) Token: 0x0600410E RID: 16654 RVA: 0x0012FC48 File Offset: 0x0012DE48
		// (set) Token: 0x0600410F RID: 16655 RVA: 0x0012FC94 File Offset: 0x0012DE94
		public unsafe virtual Identity TargetIdentity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInternalMessage.NativeMethodInfoPtr_get_TargetIdentity_Public_Abstract_Virtual_New_get_Identity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Identity>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInternalMessage.NativeMethodInfoPtr_set_TargetIdentity_Public_Abstract_Virtual_New_set_Void_Identity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001074 RID: 4212
		// (get) Token: 0x06004110 RID: 16656 RVA: 0x0012FCE4 File Offset: 0x0012DEE4
		// (set) Token: 0x06004111 RID: 16657 RVA: 0x0012FD28 File Offset: 0x0012DF28
		public unsafe virtual string Uri
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInternalMessage.NativeMethodInfoPtr_get_Uri_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInternalMessage.NativeMethodInfoPtr_set_Uri_Public_Abstract_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06004112 RID: 16658 RVA: 0x0001876F File Offset: 0x0001696F
		public IInternalMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400353D RID: 13629
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetIdentity_Public_Abstract_Virtual_New_get_Identity_0;

		// Token: 0x0400353E RID: 13630
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetIdentity_Public_Abstract_Virtual_New_set_Void_Identity_0;

		// Token: 0x0400353F RID: 13631
		private static readonly IntPtr NativeMethodInfoPtr_get_Uri_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04003540 RID: 13632
		private static readonly IntPtr NativeMethodInfoPtr_set_Uri_Public_Abstract_Virtual_New_set_Void_String_0;
	}
}
