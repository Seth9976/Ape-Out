using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

namespace Il2CppRewired.UI
{
	// Token: 0x02000107 RID: 263
	public class ITouchInputSource : Il2CppObjectBase
	{
		// Token: 0x0600198B RID: 6539 RVA: 0x000917B8 File Offset: 0x0008F9B8
		// Note: this type is marked as 'beforefieldinit'.
		static ITouchInputSource()
		{
			Il2CppClassPointerStore<ITouchInputSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.UI", "ITouchInputSource");
			ITouchInputSource.NativeMethodInfoPtr_get_playerId_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITouchInputSource>.NativeClassPtr, 100669470);
			ITouchInputSource.NativeMethodInfoPtr_get_touchSupported_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITouchInputSource>.NativeClassPtr, 100669471);
			ITouchInputSource.NativeMethodInfoPtr_get_touchCount_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITouchInputSource>.NativeClassPtr, 100669472);
			ITouchInputSource.NativeMethodInfoPtr_GetTouch_Public_Abstract_Virtual_New_Touch_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITouchInputSource>.NativeClassPtr, 100669473);
		}

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x0600198C RID: 6540 RVA: 0x00091830 File Offset: 0x0008FA30
		public unsafe virtual int playerId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITouchInputSource.NativeMethodInfoPtr_get_playerId_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x0600198D RID: 6541 RVA: 0x00091878 File Offset: 0x0008FA78
		public unsafe virtual bool touchSupported
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITouchInputSource.NativeMethodInfoPtr_get_touchSupported_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x0600198E RID: 6542 RVA: 0x000918C0 File Offset: 0x0008FAC0
		public unsafe virtual int touchCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITouchInputSource.NativeMethodInfoPtr_get_touchCount_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600198F RID: 6543 RVA: 0x00091908 File Offset: 0x0008FB08
		[CallerCount(0)]
		public unsafe virtual Touch GetTouch(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITouchInputSource.NativeMethodInfoPtr_GetTouch_Public_Abstract_Virtual_New_Touch_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001990 RID: 6544 RVA: 0x0000A3B5 File Offset: 0x000085B5
		public ITouchInputSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001634 RID: 5684
		private static readonly IntPtr NativeMethodInfoPtr_get_playerId_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04001635 RID: 5685
		private static readonly IntPtr NativeMethodInfoPtr_get_touchSupported_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04001636 RID: 5686
		private static readonly IntPtr NativeMethodInfoPtr_get_touchCount_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04001637 RID: 5687
		private static readonly IntPtr NativeMethodInfoPtr_GetTouch_Public_Abstract_Virtual_New_Touch_Int32_0;
	}
}
