using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppSystem.Net
{
	// Token: 0x020000E9 RID: 233
	public class ICertificatePolicy : Il2CppObjectBase
	{
		// Token: 0x06000CC0 RID: 3264 RVA: 0x00006FFD File Offset: 0x000051FD
		// Note: this type is marked as 'beforefieldinit'.
		static ICertificatePolicy()
		{
			Il2CppClassPointerStore<ICertificatePolicy>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "ICertificatePolicy");
			ICertificatePolicy.NativeMethodInfoPtr_CheckValidationResult_Public_Abstract_Virtual_New_Boolean_ServicePoint_X509Certificate_WebRequest_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICertificatePolicy>.NativeClassPtr, 100665161);
		}

		// Token: 0x06000CC1 RID: 3265 RVA: 0x00040CA8 File Offset: 0x0003EEA8
		[CallerCount(0)]
		public unsafe virtual bool CheckValidationResult(ServicePoint srvPoint, X509Certificate certificate, WebRequest request, int certificateProblem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(srvPoint);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(certificate);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(request);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref certificateProblem;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICertificatePolicy.NativeMethodInfoPtr_CheckValidationResult_Public_Abstract_Virtual_New_Boolean_ServicePoint_X509Certificate_WebRequest_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CC2 RID: 3266 RVA: 0x0000702C File Offset: 0x0000522C
		public ICertificatePolicy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A00 RID: 2560
		private static readonly IntPtr NativeMethodInfoPtr_CheckValidationResult_Public_Abstract_Virtual_New_Boolean_ServicePoint_X509Certificate_WebRequest_Int32_0;
	}
}
