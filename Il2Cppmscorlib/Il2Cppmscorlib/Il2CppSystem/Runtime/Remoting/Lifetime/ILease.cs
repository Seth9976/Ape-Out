using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.Remoting.Lifetime
{
	// Token: 0x020003AE RID: 942
	public class ILease : Il2CppObjectBase
	{
		// Token: 0x06003E28 RID: 15912 RVA: 0x00125CA8 File Offset: 0x00123EA8
		// Note: this type is marked as 'beforefieldinit'.
		static ILease()
		{
			Il2CppClassPointerStore<ILease>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Lifetime", "ILease");
			ILease.NativeMethodInfoPtr_get_CurrentLeaseTime_Public_Abstract_Virtual_New_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILease>.NativeClassPtr, 100672504);
			ILease.NativeMethodInfoPtr_get_CurrentState_Public_Abstract_Virtual_New_get_LeaseState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILease>.NativeClassPtr, 100672505);
			ILease.NativeMethodInfoPtr_get_RenewOnCallTime_Public_Abstract_Virtual_New_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILease>.NativeClassPtr, 100672506);
			ILease.NativeMethodInfoPtr_Renew_Public_Abstract_Virtual_New_TimeSpan_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILease>.NativeClassPtr, 100672507);
		}

		// Token: 0x17000F87 RID: 3975
		// (get) Token: 0x06003E29 RID: 15913 RVA: 0x00125D20 File Offset: 0x00123F20
		public unsafe virtual TimeSpan CurrentLeaseTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILease.NativeMethodInfoPtr_get_CurrentLeaseTime_Public_Abstract_Virtual_New_get_TimeSpan_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F88 RID: 3976
		// (get) Token: 0x06003E2A RID: 15914 RVA: 0x00125D68 File Offset: 0x00123F68
		public unsafe virtual LeaseState CurrentState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILease.NativeMethodInfoPtr_get_CurrentState_Public_Abstract_Virtual_New_get_LeaseState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F89 RID: 3977
		// (get) Token: 0x06003E2B RID: 15915 RVA: 0x00125DB0 File Offset: 0x00123FB0
		public unsafe virtual TimeSpan RenewOnCallTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILease.NativeMethodInfoPtr_get_RenewOnCallTime_Public_Abstract_Virtual_New_get_TimeSpan_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003E2C RID: 15916 RVA: 0x00125DF8 File Offset: 0x00123FF8
		[CallerCount(0)]
		public unsafe virtual TimeSpan Renew(TimeSpan renewalTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref renewalTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILease.NativeMethodInfoPtr_Renew_Public_Abstract_Virtual_New_TimeSpan_TimeSpan_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003E2D RID: 15917 RVA: 0x0001730A File Offset: 0x0001550A
		public ILease(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400336A RID: 13162
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentLeaseTime_Public_Abstract_Virtual_New_get_TimeSpan_0;

		// Token: 0x0400336B RID: 13163
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentState_Public_Abstract_Virtual_New_get_LeaseState_0;

		// Token: 0x0400336C RID: 13164
		private static readonly IntPtr NativeMethodInfoPtr_get_RenewOnCallTime_Public_Abstract_Virtual_New_get_TimeSpan_0;

		// Token: 0x0400336D RID: 13165
		private static readonly IntPtr NativeMethodInfoPtr_Renew_Public_Abstract_Virtual_New_TimeSpan_TimeSpan_0;
	}
}
