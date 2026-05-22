using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020003FB RID: 1019
	public class IMethodReturnMessage : Il2CppObjectBase
	{
		// Token: 0x06004129 RID: 16681 RVA: 0x00130258 File Offset: 0x0012E458
		// Note: this type is marked as 'beforefieldinit'.
		static IMethodReturnMessage()
		{
			Il2CppClassPointerStore<IMethodReturnMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "IMethodReturnMessage");
			IMethodReturnMessage.NativeMethodInfoPtr_get_Exception_Public_Abstract_Virtual_New_get_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMethodReturnMessage>.NativeClassPtr, 100672860);
			IMethodReturnMessage.NativeMethodInfoPtr_get_OutArgs_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMethodReturnMessage>.NativeClassPtr, 100672861);
			IMethodReturnMessage.NativeMethodInfoPtr_get_ReturnValue_Public_Abstract_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMethodReturnMessage>.NativeClassPtr, 100672862);
		}

		// Token: 0x1700107E RID: 4222
		// (get) Token: 0x0600412A RID: 16682 RVA: 0x001302BC File Offset: 0x0012E4BC
		public unsafe virtual Exception Exception
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMethodReturnMessage.NativeMethodInfoPtr_get_Exception_Public_Abstract_Virtual_New_get_Exception_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x1700107F RID: 4223
		// (get) Token: 0x0600412B RID: 16683 RVA: 0x00130308 File Offset: 0x0012E508
		public unsafe virtual Il2CppReferenceArray<Object> OutArgs
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMethodReturnMessage.NativeMethodInfoPtr_get_OutArgs_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x17001080 RID: 4224
		// (get) Token: 0x0600412C RID: 16684 RVA: 0x00130354 File Offset: 0x0012E554
		public unsafe virtual Object ReturnValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMethodReturnMessage.NativeMethodInfoPtr_get_ReturnValue_Public_Abstract_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600412D RID: 16685 RVA: 0x0001880A File Offset: 0x00016A0A
		public IMethodReturnMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400354D RID: 13645
		private static readonly IntPtr NativeMethodInfoPtr_get_Exception_Public_Abstract_Virtual_New_get_Exception_0;

		// Token: 0x0400354E RID: 13646
		private static readonly IntPtr NativeMethodInfoPtr_get_OutArgs_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400354F RID: 13647
		private static readonly IntPtr NativeMethodInfoPtr_get_ReturnValue_Public_Abstract_Virtual_New_get_Object_0;
	}
}
