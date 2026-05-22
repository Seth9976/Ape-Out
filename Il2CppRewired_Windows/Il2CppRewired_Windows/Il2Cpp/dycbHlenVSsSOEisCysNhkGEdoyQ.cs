using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2Cpp
{
	// Token: 0x0200000A RID: 10
	public class dycbHlenVSsSOEisCysNhkGEdoyQ : Il2CppObjectBase
	{
		// Token: 0x0600005F RID: 95 RVA: 0x000022BF File Offset: 0x000004BF
		// Note: this type is marked as 'beforefieldinit'.
		static dycbHlenVSsSOEisCysNhkGEdoyQ()
		{
			Il2CppClassPointerStore<dycbHlenVSsSOEisCysNhkGEdoyQ>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Windows.dll", "", "dycbHlenVSsSOEisCysNhkGEdoyQ");
			dycbHlenVSsSOEisCysNhkGEdoyQ.NativeMethodInfoPtr_set_useXInput_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<dycbHlenVSsSOEisCysNhkGEdoyQ>.NativeClassPtr, 100663364);
		}

		// Token: 0x17000017 RID: 23
		// (set) Token: 0x06000060 RID: 96 RVA: 0x0000BE4C File Offset: 0x0000A04C
		public unsafe virtual bool wfvqYGGPIizvUGgiRDuPHaBxHJUC
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), dycbHlenVSsSOEisCysNhkGEdoyQ.NativeMethodInfoPtr_set_useXInput_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000022EE File Offset: 0x000004EE
		public dycbHlenVSsSOEisCysNhkGEdoyQ(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_set_useXInput_Public_Abstract_Virtual_New_set_Void_Boolean_0;
	}
}
