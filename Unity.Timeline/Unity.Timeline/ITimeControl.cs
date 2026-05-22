using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Timeline
{
	// Token: 0x02000033 RID: 51
	public class ITimeControl : Il2CppObjectBase
	{
		// Token: 0x06000438 RID: 1080 RVA: 0x00015338 File Offset: 0x00013538
		// Note: this type is marked as 'beforefieldinit'.
		static ITimeControl()
		{
			Il2CppClassPointerStore<ITimeControl>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "ITimeControl");
			ITimeControl.NativeMethodInfoPtr_SetTime_Public_Abstract_Virtual_New_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITimeControl>.NativeClassPtr, 100664014);
			ITimeControl.NativeMethodInfoPtr_OnControlTimeStart_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITimeControl>.NativeClassPtr, 100664015);
			ITimeControl.NativeMethodInfoPtr_OnControlTimeStop_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITimeControl>.NativeClassPtr, 100664016);
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x0001539C File Offset: 0x0001359C
		[CallerCount(0)]
		public unsafe virtual void SetTime(double time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITimeControl.NativeMethodInfoPtr_SetTime_Public_Abstract_Virtual_New_Void_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x000153E8 File Offset: 0x000135E8
		[CallerCount(0)]
		public unsafe virtual void OnControlTimeStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITimeControl.NativeMethodInfoPtr_OnControlTimeStart_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00015424 File Offset: 0x00013624
		[CallerCount(0)]
		public unsafe virtual void OnControlTimeStop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITimeControl.NativeMethodInfoPtr_OnControlTimeStop_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x0000355B File Offset: 0x0000175B
		public ITimeControl(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000351 RID: 849
		private static readonly IntPtr NativeMethodInfoPtr_SetTime_Public_Abstract_Virtual_New_Void_Double_0;

		// Token: 0x04000352 RID: 850
		private static readonly IntPtr NativeMethodInfoPtr_OnControlTimeStart_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000353 RID: 851
		private static readonly IntPtr NativeMethodInfoPtr_OnControlTimeStop_Public_Abstract_Virtual_New_Void_0;
	}
}
