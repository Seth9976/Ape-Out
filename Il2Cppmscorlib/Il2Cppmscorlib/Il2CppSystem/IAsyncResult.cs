using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading;

namespace Il2CppSystem
{
	// Token: 0x020000B7 RID: 183
	public class IAsyncResult : Il2CppObjectBase
	{
		// Token: 0x06000D1C RID: 3356 RVA: 0x0005F2E4 File Offset: 0x0005D4E4
		// Note: this type is marked as 'beforefieldinit'.
		static IAsyncResult()
		{
			Il2CppClassPointerStore<IAsyncResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "IAsyncResult");
			IAsyncResult.NativeMethodInfoPtr_get_IsCompleted_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsyncResult>.NativeClassPtr, 100665509);
			IAsyncResult.NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Abstract_Virtual_New_get_WaitHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsyncResult>.NativeClassPtr, 100665510);
			IAsyncResult.NativeMethodInfoPtr_get_AsyncState_Public_Abstract_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsyncResult>.NativeClassPtr, 100665511);
			IAsyncResult.NativeMethodInfoPtr_get_CompletedSynchronously_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsyncResult>.NativeClassPtr, 100665512);
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000D1D RID: 3357 RVA: 0x0005F35C File Offset: 0x0005D55C
		public unsafe virtual bool IsCompleted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAsyncResult.NativeMethodInfoPtr_get_IsCompleted_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000D1E RID: 3358 RVA: 0x0005F3A4 File Offset: 0x0005D5A4
		public unsafe virtual WaitHandle AsyncWaitHandle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAsyncResult.NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Abstract_Virtual_New_get_WaitHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WaitHandle>(intPtr3) : null;
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000D1F RID: 3359 RVA: 0x0005F3F0 File Offset: 0x0005D5F0
		public unsafe virtual Object AsyncState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAsyncResult.NativeMethodInfoPtr_get_AsyncState_Public_Abstract_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000D20 RID: 3360 RVA: 0x0005F43C File Offset: 0x0005D63C
		public unsafe virtual bool CompletedSynchronously
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAsyncResult.NativeMethodInfoPtr_get_CompletedSynchronously_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x0000569B File Offset: 0x0000389B
		public IAsyncResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B3C RID: 2876
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000B3D RID: 2877
		private static readonly IntPtr NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Abstract_Virtual_New_get_WaitHandle_0;

		// Token: 0x04000B3E RID: 2878
		private static readonly IntPtr NativeMethodInfoPtr_get_AsyncState_Public_Abstract_Virtual_New_get_Object_0;

		// Token: 0x04000B3F RID: 2879
		private static readonly IntPtr NativeMethodInfoPtr_get_CompletedSynchronously_Public_Abstract_Virtual_New_get_Boolean_0;
	}
}
