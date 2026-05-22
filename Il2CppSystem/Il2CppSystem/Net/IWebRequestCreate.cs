using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020000EE RID: 238
	public class IWebRequestCreate : Il2CppObjectBase
	{
		// Token: 0x06000D23 RID: 3363 RVA: 0x000072E8 File Offset: 0x000054E8
		// Note: this type is marked as 'beforefieldinit'.
		static IWebRequestCreate()
		{
			Il2CppClassPointerStore<IWebRequestCreate>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "IWebRequestCreate");
			IWebRequestCreate.NativeMethodInfoPtr_Create_Public_Abstract_Virtual_New_WebRequest_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWebRequestCreate>.NativeClassPtr, 100665196);
		}

		// Token: 0x06000D24 RID: 3364 RVA: 0x00041FE8 File Offset: 0x000401E8
		[CallerCount(0)]
		public unsafe virtual WebRequest Create(Uri uri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IWebRequestCreate.NativeMethodInfoPtr_Create_Public_Abstract_Virtual_New_WebRequest_Uri_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebRequest>(intPtr3) : null;
			}
		}

		// Token: 0x06000D25 RID: 3365 RVA: 0x00007317 File Offset: 0x00005517
		public IWebRequestCreate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A3D RID: 2621
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Abstract_Virtual_New_WebRequest_Uri_0;
	}
}
