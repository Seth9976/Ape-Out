using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.ComponentModel;

namespace Il2CppSanford.Multimedia.Timers
{
	// Token: 0x02000185 RID: 389
	public class ITimer : Il2CppObjectBase
	{
		// Token: 0x06001170 RID: 4464 RVA: 0x00053F78 File Offset: 0x00052178
		// Note: this type is marked as 'beforefieldinit'.
		static ITimer()
		{
			Il2CppClassPointerStore<ITimer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Timers", "ITimer");
			ITimer.NativeMethodInfoPtr_get_IsRunning_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITimer>.NativeClassPtr, 100665808);
			ITimer.NativeMethodInfoPtr_get_Mode_Public_Abstract_Virtual_New_get_TimerMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITimer>.NativeClassPtr, 100665809);
			ITimer.NativeMethodInfoPtr_set_Mode_Public_Abstract_Virtual_New_set_Void_TimerMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITimer>.NativeClassPtr, 100665810);
			ITimer.NativeMethodInfoPtr_get_Period_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITimer>.NativeClassPtr, 100665811);
			ITimer.NativeMethodInfoPtr_set_Period_Public_Abstract_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITimer>.NativeClassPtr, 100665812);
			ITimer.NativeMethodInfoPtr_get_Resolution_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITimer>.NativeClassPtr, 100665813);
			ITimer.NativeMethodInfoPtr_set_Resolution_Public_Abstract_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITimer>.NativeClassPtr, 100665814);
			ITimer.NativeMethodInfoPtr_get_SynchronizingObject_Public_Abstract_Virtual_New_get_ISynchronizeInvoke_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITimer>.NativeClassPtr, 100665815);
			ITimer.NativeMethodInfoPtr_set_SynchronizingObject_Public_Abstract_Virtual_New_set_Void_ISynchronizeInvoke_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITimer>.NativeClassPtr, 100665816);
			ITimer.NativeMethodInfoPtr_add_Started_Public_Abstract_Virtual_New_add_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITimer>.NativeClassPtr, 100665817);
			ITimer.NativeMethodInfoPtr_remove_Started_Public_Abstract_Virtual_New_rem_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITimer>.NativeClassPtr, 100665818);
			ITimer.NativeMethodInfoPtr_add_Stopped_Public_Abstract_Virtual_New_add_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITimer>.NativeClassPtr, 100665819);
			ITimer.NativeMethodInfoPtr_remove_Stopped_Public_Abstract_Virtual_New_rem_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITimer>.NativeClassPtr, 100665820);
			ITimer.NativeMethodInfoPtr_add_Tick_Public_Abstract_Virtual_New_add_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITimer>.NativeClassPtr, 100665821);
			ITimer.NativeMethodInfoPtr_remove_Tick_Public_Abstract_Virtual_New_rem_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITimer>.NativeClassPtr, 100665822);
			ITimer.NativeMethodInfoPtr_Start_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITimer>.NativeClassPtr, 100665823);
			ITimer.NativeMethodInfoPtr_Stop_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITimer>.NativeClassPtr, 100665824);
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06001171 RID: 4465 RVA: 0x000540F4 File Offset: 0x000522F4
		public unsafe virtual bool IsRunning
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITimer.NativeMethodInfoPtr_get_IsRunning_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06001172 RID: 4466 RVA: 0x0005413C File Offset: 0x0005233C
		// (set) Token: 0x06001173 RID: 4467 RVA: 0x00054184 File Offset: 0x00052384
		public unsafe virtual TimerMode Mode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITimer.NativeMethodInfoPtr_get_Mode_Public_Abstract_Virtual_New_get_TimerMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITimer.NativeMethodInfoPtr_set_Mode_Public_Abstract_Virtual_New_set_Void_TimerMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06001174 RID: 4468 RVA: 0x000541D0 File Offset: 0x000523D0
		// (set) Token: 0x06001175 RID: 4469 RVA: 0x00054218 File Offset: 0x00052418
		public unsafe virtual int Period
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITimer.NativeMethodInfoPtr_get_Period_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITimer.NativeMethodInfoPtr_set_Period_Public_Abstract_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06001176 RID: 4470 RVA: 0x00054264 File Offset: 0x00052464
		// (set) Token: 0x06001177 RID: 4471 RVA: 0x000542AC File Offset: 0x000524AC
		public unsafe virtual int Resolution
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITimer.NativeMethodInfoPtr_get_Resolution_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITimer.NativeMethodInfoPtr_set_Resolution_Public_Abstract_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06001178 RID: 4472 RVA: 0x000542F8 File Offset: 0x000524F8
		// (set) Token: 0x06001179 RID: 4473 RVA: 0x00054344 File Offset: 0x00052544
		public unsafe virtual ISynchronizeInvoke SynchronizingObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITimer.NativeMethodInfoPtr_get_SynchronizingObject_Public_Abstract_Virtual_New_get_ISynchronizeInvoke_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISynchronizeInvoke>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITimer.NativeMethodInfoPtr_set_SynchronizingObject_Public_Abstract_Virtual_New_set_Void_ISynchronizeInvoke_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600117A RID: 4474 RVA: 0x00054394 File Offset: 0x00052594
		[CallerCount(0)]
		public unsafe virtual void add_Started(EventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITimer.NativeMethodInfoPtr_add_Started_Public_Abstract_Virtual_New_add_Void_EventHandler_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600117B RID: 4475 RVA: 0x000543E4 File Offset: 0x000525E4
		[CallerCount(0)]
		public unsafe virtual void remove_Started(EventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITimer.NativeMethodInfoPtr_remove_Started_Public_Abstract_Virtual_New_rem_Void_EventHandler_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600117C RID: 4476 RVA: 0x00054434 File Offset: 0x00052634
		[CallerCount(0)]
		public unsafe virtual void add_Stopped(EventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITimer.NativeMethodInfoPtr_add_Stopped_Public_Abstract_Virtual_New_add_Void_EventHandler_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600117D RID: 4477 RVA: 0x00054484 File Offset: 0x00052684
		[CallerCount(0)]
		public unsafe virtual void remove_Stopped(EventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITimer.NativeMethodInfoPtr_remove_Stopped_Public_Abstract_Virtual_New_rem_Void_EventHandler_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600117E RID: 4478 RVA: 0x000544D4 File Offset: 0x000526D4
		[CallerCount(0)]
		public unsafe virtual void add_Tick(EventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITimer.NativeMethodInfoPtr_add_Tick_Public_Abstract_Virtual_New_add_Void_EventHandler_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600117F RID: 4479 RVA: 0x00054524 File Offset: 0x00052724
		[CallerCount(0)]
		public unsafe virtual void remove_Tick(EventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITimer.NativeMethodInfoPtr_remove_Tick_Public_Abstract_Virtual_New_rem_Void_EventHandler_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001180 RID: 4480 RVA: 0x00054574 File Offset: 0x00052774
		[CallerCount(0)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITimer.NativeMethodInfoPtr_Start_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001181 RID: 4481 RVA: 0x000545B0 File Offset: 0x000527B0
		[CallerCount(0)]
		public unsafe virtual void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITimer.NativeMethodInfoPtr_Stop_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001182 RID: 4482 RVA: 0x000072C6 File Offset: 0x000054C6
		public ITimer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001384 RID: 4996
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRunning_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04001385 RID: 4997
		private static readonly IntPtr NativeMethodInfoPtr_get_Mode_Public_Abstract_Virtual_New_get_TimerMode_0;

		// Token: 0x04001386 RID: 4998
		private static readonly IntPtr NativeMethodInfoPtr_set_Mode_Public_Abstract_Virtual_New_set_Void_TimerMode_0;

		// Token: 0x04001387 RID: 4999
		private static readonly IntPtr NativeMethodInfoPtr_get_Period_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04001388 RID: 5000
		private static readonly IntPtr NativeMethodInfoPtr_set_Period_Public_Abstract_Virtual_New_set_Void_Int32_0;

		// Token: 0x04001389 RID: 5001
		private static readonly IntPtr NativeMethodInfoPtr_get_Resolution_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x0400138A RID: 5002
		private static readonly IntPtr NativeMethodInfoPtr_set_Resolution_Public_Abstract_Virtual_New_set_Void_Int32_0;

		// Token: 0x0400138B RID: 5003
		private static readonly IntPtr NativeMethodInfoPtr_get_SynchronizingObject_Public_Abstract_Virtual_New_get_ISynchronizeInvoke_0;

		// Token: 0x0400138C RID: 5004
		private static readonly IntPtr NativeMethodInfoPtr_set_SynchronizingObject_Public_Abstract_Virtual_New_set_Void_ISynchronizeInvoke_0;

		// Token: 0x0400138D RID: 5005
		private static readonly IntPtr NativeMethodInfoPtr_add_Started_Public_Abstract_Virtual_New_add_Void_EventHandler_0;

		// Token: 0x0400138E RID: 5006
		private static readonly IntPtr NativeMethodInfoPtr_remove_Started_Public_Abstract_Virtual_New_rem_Void_EventHandler_0;

		// Token: 0x0400138F RID: 5007
		private static readonly IntPtr NativeMethodInfoPtr_add_Stopped_Public_Abstract_Virtual_New_add_Void_EventHandler_0;

		// Token: 0x04001390 RID: 5008
		private static readonly IntPtr NativeMethodInfoPtr_remove_Stopped_Public_Abstract_Virtual_New_rem_Void_EventHandler_0;

		// Token: 0x04001391 RID: 5009
		private static readonly IntPtr NativeMethodInfoPtr_add_Tick_Public_Abstract_Virtual_New_add_Void_EventHandler_0;

		// Token: 0x04001392 RID: 5010
		private static readonly IntPtr NativeMethodInfoPtr_remove_Tick_Public_Abstract_Virtual_New_rem_Void_EventHandler_0;

		// Token: 0x04001393 RID: 5011
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04001394 RID: 5012
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Abstract_Virtual_New_Void_0;
	}
}
