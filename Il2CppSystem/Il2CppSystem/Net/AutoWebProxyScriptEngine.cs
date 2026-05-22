using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Net
{
	// Token: 0x0200011C RID: 284
	public class AutoWebProxyScriptEngine : Object
	{
		// Token: 0x06001019 RID: 4121 RVA: 0x0004D124 File Offset: 0x0004B324
		// Note: this type is marked as 'beforefieldinit'.
		static AutoWebProxyScriptEngine()
		{
			Il2CppClassPointerStore<AutoWebProxyScriptEngine>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "AutoWebProxyScriptEngine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AutoWebProxyScriptEngine>.NativeClassPtr);
			AutoWebProxyScriptEngine.NativeMethodInfoPtr_GetProxies_Public_Boolean_Uri_byref_IList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoWebProxyScriptEngine>.NativeClassPtr, 100665593);
			AutoWebProxyScriptEngine.NativeMethodInfoPtr_GetProxies_Public_Boolean_Uri_byref_IList_1_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoWebProxyScriptEngine>.NativeClassPtr, 100665594);
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x0004D17C File Offset: 0x0004B37C
		[CallerCount(0)]
		public unsafe bool GetProxies(Uri destination, out IList<string> proxyList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AutoWebProxyScriptEngine.NativeMethodInfoPtr_GetProxies_Public_Boolean_Uri_byref_IList_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			proxyList = ((intPtr4 == 0) ? null : new IList<string>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x0004D1EC File Offset: 0x0004B3EC
		[CallerCount(0)]
		public unsafe bool GetProxies(Uri destination, out IList<string> proxyList, ref int syncStatus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &syncStatus;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AutoWebProxyScriptEngine.NativeMethodInfoPtr_GetProxies_Public_Boolean_Uri_byref_IList_1_String_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			proxyList = ((intPtr4 == 0) ? null : new IList<string>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600101C RID: 4124 RVA: 0x000085A2 File Offset: 0x000067A2
		public AutoWebProxyScriptEngine(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C82 RID: 3202
		private static readonly IntPtr NativeMethodInfoPtr_GetProxies_Public_Boolean_Uri_byref_IList_1_String_0;

		// Token: 0x04000C83 RID: 3203
		private static readonly IntPtr NativeMethodInfoPtr_GetProxies_Public_Boolean_Uri_byref_IList_1_String_byref_Int32_0;
	}
}
