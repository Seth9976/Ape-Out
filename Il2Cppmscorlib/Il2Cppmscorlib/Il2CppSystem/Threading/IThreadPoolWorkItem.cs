using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000282 RID: 642
	public class IThreadPoolWorkItem : Il2CppObjectBase
	{
		// Token: 0x06002C60 RID: 11360 RVA: 0x000E56B4 File Offset: 0x000E38B4
		// Note: this type is marked as 'beforefieldinit'.
		static IThreadPoolWorkItem()
		{
			Il2CppClassPointerStore<IThreadPoolWorkItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "IThreadPoolWorkItem");
			IThreadPoolWorkItem.NativeMethodInfoPtr_ExecuteWorkItem_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IThreadPoolWorkItem>.NativeClassPtr, 100670422);
			IThreadPoolWorkItem.NativeMethodInfoPtr_MarkAborted_Public_Abstract_Virtual_New_Void_ThreadAbortException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IThreadPoolWorkItem>.NativeClassPtr, 100670423);
		}

		// Token: 0x06002C61 RID: 11361 RVA: 0x000E5704 File Offset: 0x000E3904
		[CallerCount(0)]
		public unsafe virtual void ExecuteWorkItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IThreadPoolWorkItem.NativeMethodInfoPtr_ExecuteWorkItem_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C62 RID: 11362 RVA: 0x000E5740 File Offset: 0x000E3940
		[CallerCount(0)]
		public unsafe virtual void MarkAborted(ThreadAbortException tae)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tae);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IThreadPoolWorkItem.NativeMethodInfoPtr_MarkAborted_Public_Abstract_Virtual_New_Void_ThreadAbortException_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C63 RID: 11363 RVA: 0x0000F468 File Offset: 0x0000D668
		public IThreadPoolWorkItem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040026B7 RID: 9911
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteWorkItem_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040026B8 RID: 9912
		private static readonly IntPtr NativeMethodInfoPtr_MarkAborted_Public_Abstract_Virtual_New_Void_ThreadAbortException_0;
	}
}
