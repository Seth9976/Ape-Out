using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000297 RID: 663
	public sealed class RegisteredWaitHandle : MarshalByRefObject
	{
		// Token: 0x06002D4E RID: 11598 RVA: 0x000E8DE8 File Offset: 0x000E6FE8
		// Note: this type is marked as 'beforefieldinit'.
		static RegisteredWaitHandle()
		{
			Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "RegisteredWaitHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr);
			RegisteredWaitHandle.NativeFieldInfoPtr__waitObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr, "_waitObject");
			RegisteredWaitHandle.NativeFieldInfoPtr__callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr, "_callback");
			RegisteredWaitHandle.NativeFieldInfoPtr__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr, "_state");
			RegisteredWaitHandle.NativeFieldInfoPtr__finalEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr, "_finalEvent");
			RegisteredWaitHandle.NativeFieldInfoPtr__cancelEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr, "_cancelEvent");
			RegisteredWaitHandle.NativeFieldInfoPtr__timeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr, "_timeout");
			RegisteredWaitHandle.NativeFieldInfoPtr__callsInProcess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr, "_callsInProcess");
			RegisteredWaitHandle.NativeFieldInfoPtr__executeOnlyOnce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr, "_executeOnlyOnce");
			RegisteredWaitHandle.NativeFieldInfoPtr__unregistered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr, "_unregistered");
			RegisteredWaitHandle.NativeMethodInfoPtr__ctor_Internal_Void_WaitHandle_WaitOrTimerCallback_Object_TimeSpan_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr, 100670556);
			RegisteredWaitHandle.NativeMethodInfoPtr_Wait_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr, 100670557);
			RegisteredWaitHandle.NativeMethodInfoPtr_DoCallBack_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr, 100670558);
		}

		// Token: 0x06002D4F RID: 11599 RVA: 0x000E8F08 File Offset: 0x000E7108
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 204770, RefRangeEnd = 204771, XrefRangeStart = 204766, XrefRangeEnd = 204770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegisteredWaitHandle(WaitHandle waitObject, WaitOrTimerCallback callback, Object state, TimeSpan timeout, bool executeOnlyOnce)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(waitObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeout;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref executeOnlyOnce;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisteredWaitHandle.NativeMethodInfoPtr__ctor_Internal_Void_WaitHandle_WaitOrTimerCallback_Object_TimeSpan_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D50 RID: 11600 RVA: 0x000E8F94 File Offset: 0x000E7194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204771, XrefRangeEnd = 204810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Wait(Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisteredWaitHandle.NativeMethodInfoPtr_Wait_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D51 RID: 11601 RVA: 0x000E8FD8 File Offset: 0x000E71D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204810, XrefRangeEnd = 204819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoCallBack(Object timedOut)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(timedOut);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisteredWaitHandle.NativeMethodInfoPtr_DoCallBack_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D52 RID: 11602 RVA: 0x0000F989 File Offset: 0x0000DB89
		public RegisteredWaitHandle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x06002D53 RID: 11603 RVA: 0x000E901C File Offset: 0x000E721C
		// (set) Token: 0x06002D54 RID: 11604 RVA: 0x0000F992 File Offset: 0x0000DB92
		public unsafe WaitHandle _waitObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredWaitHandle.NativeFieldInfoPtr__waitObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredWaitHandle.NativeFieldInfoPtr__waitObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A9C RID: 2716
		// (get) Token: 0x06002D55 RID: 11605 RVA: 0x000E904C File Offset: 0x000E724C
		// (set) Token: 0x06002D56 RID: 11606 RVA: 0x0000F9B1 File Offset: 0x0000DBB1
		public unsafe WaitOrTimerCallback _callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredWaitHandle.NativeFieldInfoPtr__callback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitOrTimerCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredWaitHandle.NativeFieldInfoPtr__callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x06002D57 RID: 11607 RVA: 0x000E907C File Offset: 0x000E727C
		// (set) Token: 0x06002D58 RID: 11608 RVA: 0x0000F9D0 File Offset: 0x0000DBD0
		public unsafe Object _state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredWaitHandle.NativeFieldInfoPtr__state);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredWaitHandle.NativeFieldInfoPtr__state), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x06002D59 RID: 11609 RVA: 0x000E90AC File Offset: 0x000E72AC
		// (set) Token: 0x06002D5A RID: 11610 RVA: 0x0000F9EF File Offset: 0x0000DBEF
		public unsafe WaitHandle _finalEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredWaitHandle.NativeFieldInfoPtr__finalEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredWaitHandle.NativeFieldInfoPtr__finalEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x06002D5B RID: 11611 RVA: 0x000E90DC File Offset: 0x000E72DC
		// (set) Token: 0x06002D5C RID: 11612 RVA: 0x0000FA0E File Offset: 0x0000DC0E
		public unsafe ManualResetEvent _cancelEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredWaitHandle.NativeFieldInfoPtr__cancelEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManualResetEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredWaitHandle.NativeFieldInfoPtr__cancelEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x06002D5D RID: 11613 RVA: 0x000E910C File Offset: 0x000E730C
		// (set) Token: 0x06002D5E RID: 11614 RVA: 0x0000FA2D File Offset: 0x0000DC2D
		public unsafe TimeSpan _timeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredWaitHandle.NativeFieldInfoPtr__timeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredWaitHandle.NativeFieldInfoPtr__timeout)) = value;
			}
		}

		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x06002D5F RID: 11615 RVA: 0x000E9134 File Offset: 0x000E7334
		// (set) Token: 0x06002D60 RID: 11616 RVA: 0x0000FA48 File Offset: 0x0000DC48
		public unsafe int _callsInProcess
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredWaitHandle.NativeFieldInfoPtr__callsInProcess);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredWaitHandle.NativeFieldInfoPtr__callsInProcess)) = value;
			}
		}

		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x06002D61 RID: 11617 RVA: 0x000E915C File Offset: 0x000E735C
		// (set) Token: 0x06002D62 RID: 11618 RVA: 0x0000FA63 File Offset: 0x0000DC63
		public unsafe bool _executeOnlyOnce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredWaitHandle.NativeFieldInfoPtr__executeOnlyOnce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredWaitHandle.NativeFieldInfoPtr__executeOnlyOnce)) = value;
			}
		}

		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x06002D63 RID: 11619 RVA: 0x000E9184 File Offset: 0x000E7384
		// (set) Token: 0x06002D64 RID: 11620 RVA: 0x0000FA7E File Offset: 0x0000DC7E
		public unsafe bool _unregistered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredWaitHandle.NativeFieldInfoPtr__unregistered);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredWaitHandle.NativeFieldInfoPtr__unregistered)) = value;
			}
		}

		// Token: 0x04002763 RID: 10083
		private static readonly IntPtr NativeFieldInfoPtr__waitObject;

		// Token: 0x04002764 RID: 10084
		private static readonly IntPtr NativeFieldInfoPtr__callback;

		// Token: 0x04002765 RID: 10085
		private static readonly IntPtr NativeFieldInfoPtr__state;

		// Token: 0x04002766 RID: 10086
		private static readonly IntPtr NativeFieldInfoPtr__finalEvent;

		// Token: 0x04002767 RID: 10087
		private static readonly IntPtr NativeFieldInfoPtr__cancelEvent;

		// Token: 0x04002768 RID: 10088
		private static readonly IntPtr NativeFieldInfoPtr__timeout;

		// Token: 0x04002769 RID: 10089
		private static readonly IntPtr NativeFieldInfoPtr__callsInProcess;

		// Token: 0x0400276A RID: 10090
		private static readonly IntPtr NativeFieldInfoPtr__executeOnlyOnce;

		// Token: 0x0400276B RID: 10091
		private static readonly IntPtr NativeFieldInfoPtr__unregistered;

		// Token: 0x0400276C RID: 10092
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_WaitHandle_WaitOrTimerCallback_Object_TimeSpan_Boolean_0;

		// Token: 0x0400276D RID: 10093
		private static readonly IntPtr NativeMethodInfoPtr_Wait_Internal_Void_Object_0;

		// Token: 0x0400276E RID: 10094
		private static readonly IntPtr NativeMethodInfoPtr_DoCallBack_Private_Void_Object_0;
	}
}
