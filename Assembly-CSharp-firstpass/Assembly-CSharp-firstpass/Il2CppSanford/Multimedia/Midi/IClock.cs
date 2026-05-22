using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x0200018F RID: 399
	public class IClock : Il2CppObjectBase
	{
		// Token: 0x06001223 RID: 4643 RVA: 0x00056A4C File Offset: 0x00054C4C
		// Note: this type is marked as 'beforefieldinit'.
		static IClock()
		{
			Il2CppClassPointerStore<IClock>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "IClock");
			IClock.NativeMethodInfoPtr_add_Tick_Public_Abstract_Virtual_New_add_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClock>.NativeClassPtr, 100665917);
			IClock.NativeMethodInfoPtr_remove_Tick_Public_Abstract_Virtual_New_rem_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClock>.NativeClassPtr, 100665918);
			IClock.NativeMethodInfoPtr_add_Started_Public_Abstract_Virtual_New_add_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClock>.NativeClassPtr, 100665919);
			IClock.NativeMethodInfoPtr_remove_Started_Public_Abstract_Virtual_New_rem_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClock>.NativeClassPtr, 100665920);
			IClock.NativeMethodInfoPtr_add_Continued_Public_Abstract_Virtual_New_add_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClock>.NativeClassPtr, 100665921);
			IClock.NativeMethodInfoPtr_remove_Continued_Public_Abstract_Virtual_New_rem_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClock>.NativeClassPtr, 100665922);
			IClock.NativeMethodInfoPtr_add_Stopped_Public_Abstract_Virtual_New_add_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClock>.NativeClassPtr, 100665923);
			IClock.NativeMethodInfoPtr_remove_Stopped_Public_Abstract_Virtual_New_rem_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClock>.NativeClassPtr, 100665924);
			IClock.NativeMethodInfoPtr_get_IsRunning_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClock>.NativeClassPtr, 100665925);
			IClock.NativeMethodInfoPtr_get_Ticks_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClock>.NativeClassPtr, 100665926);
		}

		// Token: 0x06001224 RID: 4644 RVA: 0x00056B3C File Offset: 0x00054D3C
		[CallerCount(0)]
		public unsafe virtual void add_Tick(EventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClock.NativeMethodInfoPtr_add_Tick_Public_Abstract_Virtual_New_add_Void_EventHandler_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001225 RID: 4645 RVA: 0x00056B8C File Offset: 0x00054D8C
		[CallerCount(0)]
		public unsafe virtual void remove_Tick(EventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClock.NativeMethodInfoPtr_remove_Tick_Public_Abstract_Virtual_New_rem_Void_EventHandler_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001226 RID: 4646 RVA: 0x00056BDC File Offset: 0x00054DDC
		[CallerCount(0)]
		public unsafe virtual void add_Started(EventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClock.NativeMethodInfoPtr_add_Started_Public_Abstract_Virtual_New_add_Void_EventHandler_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001227 RID: 4647 RVA: 0x00056C2C File Offset: 0x00054E2C
		[CallerCount(0)]
		public unsafe virtual void remove_Started(EventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClock.NativeMethodInfoPtr_remove_Started_Public_Abstract_Virtual_New_rem_Void_EventHandler_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001228 RID: 4648 RVA: 0x00056C7C File Offset: 0x00054E7C
		[CallerCount(0)]
		public unsafe virtual void add_Continued(EventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClock.NativeMethodInfoPtr_add_Continued_Public_Abstract_Virtual_New_add_Void_EventHandler_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001229 RID: 4649 RVA: 0x00056CCC File Offset: 0x00054ECC
		[CallerCount(0)]
		public unsafe virtual void remove_Continued(EventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClock.NativeMethodInfoPtr_remove_Continued_Public_Abstract_Virtual_New_rem_Void_EventHandler_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600122A RID: 4650 RVA: 0x00056D1C File Offset: 0x00054F1C
		[CallerCount(0)]
		public unsafe virtual void add_Stopped(EventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClock.NativeMethodInfoPtr_add_Stopped_Public_Abstract_Virtual_New_add_Void_EventHandler_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600122B RID: 4651 RVA: 0x00056D6C File Offset: 0x00054F6C
		[CallerCount(0)]
		public unsafe virtual void remove_Stopped(EventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClock.NativeMethodInfoPtr_remove_Stopped_Public_Abstract_Virtual_New_rem_Void_EventHandler_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x0600122C RID: 4652 RVA: 0x00056DBC File Offset: 0x00054FBC
		public unsafe virtual bool IsRunning
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClock.NativeMethodInfoPtr_get_IsRunning_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x0600122D RID: 4653 RVA: 0x00056E04 File Offset: 0x00055004
		public unsafe virtual int Ticks
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClock.NativeMethodInfoPtr_get_Ticks_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600122E RID: 4654 RVA: 0x0000772E File Offset: 0x0000592E
		public IClock(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400142E RID: 5166
		private static readonly IntPtr NativeMethodInfoPtr_add_Tick_Public_Abstract_Virtual_New_add_Void_EventHandler_0;

		// Token: 0x0400142F RID: 5167
		private static readonly IntPtr NativeMethodInfoPtr_remove_Tick_Public_Abstract_Virtual_New_rem_Void_EventHandler_0;

		// Token: 0x04001430 RID: 5168
		private static readonly IntPtr NativeMethodInfoPtr_add_Started_Public_Abstract_Virtual_New_add_Void_EventHandler_0;

		// Token: 0x04001431 RID: 5169
		private static readonly IntPtr NativeMethodInfoPtr_remove_Started_Public_Abstract_Virtual_New_rem_Void_EventHandler_0;

		// Token: 0x04001432 RID: 5170
		private static readonly IntPtr NativeMethodInfoPtr_add_Continued_Public_Abstract_Virtual_New_add_Void_EventHandler_0;

		// Token: 0x04001433 RID: 5171
		private static readonly IntPtr NativeMethodInfoPtr_remove_Continued_Public_Abstract_Virtual_New_rem_Void_EventHandler_0;

		// Token: 0x04001434 RID: 5172
		private static readonly IntPtr NativeMethodInfoPtr_add_Stopped_Public_Abstract_Virtual_New_add_Void_EventHandler_0;

		// Token: 0x04001435 RID: 5173
		private static readonly IntPtr NativeMethodInfoPtr_remove_Stopped_Public_Abstract_Virtual_New_rem_Void_EventHandler_0;

		// Token: 0x04001436 RID: 5174
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRunning_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04001437 RID: 5175
		private static readonly IntPtr NativeMethodInfoPtr_get_Ticks_Public_Abstract_Virtual_New_get_Int32_0;
	}
}
