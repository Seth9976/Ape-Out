using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020000E8 RID: 232
	public class IAuthenticationModule : Il2CppObjectBase
	{
		// Token: 0x06000CBB RID: 3259 RVA: 0x00040B10 File Offset: 0x0003ED10
		// Note: this type is marked as 'beforefieldinit'.
		static IAuthenticationModule()
		{
			Il2CppClassPointerStore<IAuthenticationModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "IAuthenticationModule");
			IAuthenticationModule.NativeMethodInfoPtr_Authenticate_Public_Abstract_Virtual_New_Authorization_String_WebRequest_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAuthenticationModule>.NativeClassPtr, 100665158);
			IAuthenticationModule.NativeMethodInfoPtr_PreAuthenticate_Public_Abstract_Virtual_New_Authorization_WebRequest_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAuthenticationModule>.NativeClassPtr, 100665159);
			IAuthenticationModule.NativeMethodInfoPtr_get_AuthenticationType_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAuthenticationModule>.NativeClassPtr, 100665160);
		}

		// Token: 0x06000CBC RID: 3260 RVA: 0x00040B74 File Offset: 0x0003ED74
		[CallerCount(0)]
		public unsafe virtual Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(challenge);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(request);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(credentials);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAuthenticationModule.NativeMethodInfoPtr_Authenticate_Public_Abstract_Virtual_New_Authorization_String_WebRequest_ICredentials_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Authorization>(intPtr3) : null;
		}

		// Token: 0x06000CBD RID: 3261 RVA: 0x00040BF4 File Offset: 0x0003EDF4
		[CallerCount(0)]
		public unsafe virtual Authorization PreAuthenticate(WebRequest request, ICredentials credentials)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(credentials);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAuthenticationModule.NativeMethodInfoPtr_PreAuthenticate_Public_Abstract_Virtual_New_Authorization_WebRequest_ICredentials_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Authorization>(intPtr3) : null;
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06000CBE RID: 3262 RVA: 0x00040C64 File Offset: 0x0003EE64
		public unsafe virtual string AuthenticationType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAuthenticationModule.NativeMethodInfoPtr_get_AuthenticationType_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000CBF RID: 3263 RVA: 0x00006FF4 File Offset: 0x000051F4
		public IAuthenticationModule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040009FD RID: 2557
		private static readonly IntPtr NativeMethodInfoPtr_Authenticate_Public_Abstract_Virtual_New_Authorization_String_WebRequest_ICredentials_0;

		// Token: 0x040009FE RID: 2558
		private static readonly IntPtr NativeMethodInfoPtr_PreAuthenticate_Public_Abstract_Virtual_New_Authorization_WebRequest_ICredentials_0;

		// Token: 0x040009FF RID: 2559
		private static readonly IntPtr NativeMethodInfoPtr_get_AuthenticationType_Public_Abstract_Virtual_New_get_String_0;
	}
}
