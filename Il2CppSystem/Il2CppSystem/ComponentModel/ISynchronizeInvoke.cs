using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000089 RID: 137
	public class ISynchronizeInvoke : Il2CppObjectBase
	{
		// Token: 0x060008AA RID: 2218 RVA: 0x000311B8 File Offset: 0x0002F3B8
		// Note: this type is marked as 'beforefieldinit'.
		static ISynchronizeInvoke()
		{
			Il2CppClassPointerStore<ISynchronizeInvoke>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "ISynchronizeInvoke");
			ISynchronizeInvoke.NativeMethodInfoPtr_get_InvokeRequired_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISynchronizeInvoke>.NativeClassPtr, 100664541);
			ISynchronizeInvoke.NativeMethodInfoPtr_BeginInvoke_Public_Abstract_Virtual_New_IAsyncResult_Delegate_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISynchronizeInvoke>.NativeClassPtr, 100664542);
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x060008AB RID: 2219 RVA: 0x00031208 File Offset: 0x0002F408
		public unsafe virtual bool InvokeRequired
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISynchronizeInvoke.NativeMethodInfoPtr_get_InvokeRequired_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x00031250 File Offset: 0x0002F450
		[CallerCount(0)]
		public unsafe virtual IAsyncResult BeginInvoke(Delegate method, Il2CppReferenceArray<Object> args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISynchronizeInvoke.NativeMethodInfoPtr_BeginInvoke_Public_Abstract_Virtual_New_IAsyncResult_Delegate_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x00005701 File Offset: 0x00003901
		public ISynchronizeInvoke(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400065B RID: 1627
		private static readonly IntPtr NativeMethodInfoPtr_get_InvokeRequired_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x0400065C RID: 1628
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Abstract_Virtual_New_IAsyncResult_Delegate_Il2CppReferenceArray_1_Object_0;
	}
}
