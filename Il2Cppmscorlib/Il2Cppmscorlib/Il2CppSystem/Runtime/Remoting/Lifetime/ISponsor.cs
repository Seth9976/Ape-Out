using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.Remoting.Lifetime
{
	// Token: 0x020003AF RID: 943
	public class ISponsor : Il2CppObjectBase
	{
		// Token: 0x06003E2E RID: 15918 RVA: 0x00017313 File Offset: 0x00015513
		// Note: this type is marked as 'beforefieldinit'.
		static ISponsor()
		{
			Il2CppClassPointerStore<ISponsor>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Lifetime", "ISponsor");
			ISponsor.NativeMethodInfoPtr_Renewal_Public_Abstract_Virtual_New_TimeSpan_ILease_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISponsor>.NativeClassPtr, 100672508);
		}

		// Token: 0x06003E2F RID: 15919 RVA: 0x00125E4C File Offset: 0x0012404C
		[CallerCount(0)]
		public unsafe virtual TimeSpan Renewal(ILease lease)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lease);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISponsor.NativeMethodInfoPtr_Renewal_Public_Abstract_Virtual_New_TimeSpan_ILease_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003E30 RID: 15920 RVA: 0x00017342 File Offset: 0x00015542
		public ISponsor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400336E RID: 13166
		private static readonly IntPtr NativeMethodInfoPtr_Renewal_Public_Abstract_Virtual_New_TimeSpan_ILease_0;
	}
}
