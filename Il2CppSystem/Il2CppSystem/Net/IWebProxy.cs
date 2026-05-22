using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x0200011A RID: 282
	public class IWebProxy : Il2CppObjectBase
	{
		// Token: 0x06000FE9 RID: 4073 RVA: 0x0004C46C File Offset: 0x0004A66C
		// Note: this type is marked as 'beforefieldinit'.
		static IWebProxy()
		{
			Il2CppClassPointerStore<IWebProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "IWebProxy");
			IWebProxy.NativeMethodInfoPtr_GetProxy_Public_Abstract_Virtual_New_Uri_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWebProxy>.NativeClassPtr, 100665567);
			IWebProxy.NativeMethodInfoPtr_IsBypassed_Public_Abstract_Virtual_New_Boolean_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWebProxy>.NativeClassPtr, 100665568);
			IWebProxy.NativeMethodInfoPtr_get_Credentials_Public_Abstract_Virtual_New_get_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWebProxy>.NativeClassPtr, 100665569);
		}

		// Token: 0x06000FEA RID: 4074 RVA: 0x0004C4D0 File Offset: 0x0004A6D0
		[CallerCount(0)]
		public unsafe virtual Uri GetProxy(Uri destination)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IWebProxy.NativeMethodInfoPtr_GetProxy_Public_Abstract_Virtual_New_Uri_Uri_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
		}

		// Token: 0x06000FEB RID: 4075 RVA: 0x0004C52C File Offset: 0x0004A72C
		[CallerCount(0)]
		public unsafe virtual bool IsBypassed(Uri host)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(host);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IWebProxy.NativeMethodInfoPtr_IsBypassed_Public_Abstract_Virtual_New_Boolean_Uri_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06000FEC RID: 4076 RVA: 0x0004C584 File Offset: 0x0004A784
		public unsafe virtual ICredentials Credentials
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IWebProxy.NativeMethodInfoPtr_get_Credentials_Public_Abstract_Virtual_New_get_ICredentials_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICredentials>(intPtr3) : null;
			}
		}

		// Token: 0x06000FED RID: 4077 RVA: 0x00008485 File Offset: 0x00006685
		public IWebProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C5F RID: 3167
		private static readonly IntPtr NativeMethodInfoPtr_GetProxy_Public_Abstract_Virtual_New_Uri_Uri_0;

		// Token: 0x04000C60 RID: 3168
		private static readonly IntPtr NativeMethodInfoPtr_IsBypassed_Public_Abstract_Virtual_New_Boolean_Uri_0;

		// Token: 0x04000C61 RID: 3169
		private static readonly IntPtr NativeMethodInfoPtr_get_Credentials_Public_Abstract_Virtual_New_get_ICredentials_0;
	}
}
