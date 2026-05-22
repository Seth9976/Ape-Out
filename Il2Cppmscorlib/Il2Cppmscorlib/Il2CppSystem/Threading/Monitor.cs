using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000275 RID: 629
	public static class Monitor : Object
	{
		// Token: 0x06002B9A RID: 11162 RVA: 0x000E26DC File Offset: 0x000E08DC
		// Note: this type is marked as 'beforefieldinit'.
		static Monitor()
		{
			Il2CppClassPointerStore<Monitor>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "Monitor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Monitor>.NativeClassPtr);
			Monitor.NativeMethodInfoPtr_Enter_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100670294);
			Monitor.NativeMethodInfoPtr_Enter_Public_Static_Void_Object_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100670295);
			Monitor.NativeMethodInfoPtr_ThrowLockTakenException_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100670296);
			Monitor.NativeMethodInfoPtr_Exit_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100670297);
			Monitor.NativeMethodInfoPtr_TryEnter_Public_Static_Void_Object_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100670298);
			Monitor.NativeMethodInfoPtr_MillisecondsTimeoutFromTimeSpan_Private_Static_Int32_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100670299);
			Monitor.NativeMethodInfoPtr_Wait_Public_Static_Boolean_Object_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100670300);
			Monitor.NativeMethodInfoPtr_Wait_Public_Static_Boolean_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100670301);
			Monitor.NativeMethodInfoPtr_Wait_Public_Static_Boolean_Object_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100670302);
			Monitor.NativeMethodInfoPtr_Wait_Public_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100670303);
			Monitor.NativeMethodInfoPtr_Pulse_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100670304);
			Monitor.NativeMethodInfoPtr_PulseAll_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100670305);
			Monitor.NativeMethodInfoPtr_Monitor_test_synchronised_Private_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100670306);
			Monitor.NativeMethodInfoPtr_Monitor_pulse_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100670307);
			Monitor.NativeMethodInfoPtr_ObjPulse_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100670308);
			Monitor.NativeMethodInfoPtr_Monitor_pulse_all_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100670309);
			Monitor.NativeMethodInfoPtr_ObjPulseAll_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100670310);
			Monitor.NativeMethodInfoPtr_Monitor_wait_Private_Static_Boolean_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100670311);
			Monitor.NativeMethodInfoPtr_ObjWait_Private_Static_Boolean_Boolean_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100670312);
			Monitor.NativeMethodInfoPtr_try_enter_with_atomic_var_Private_Static_Void_Object_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100670313);
			Monitor.NativeMethodInfoPtr_ReliableEnterTimeout_Private_Static_Void_Object_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100670314);
			Monitor.NativeMethodInfoPtr_ReliableEnter_Private_Static_Void_Object_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100670315);
		}

		// Token: 0x06002B9B RID: 11163 RVA: 0x000E28C4 File Offset: 0x000E0AC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 201339, RefRangeEnd = 201340, XrefRangeStart = 201336, XrefRangeEnd = 201339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Enter(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_Enter_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B9C RID: 11164 RVA: 0x000E28FC File Offset: 0x000E0AFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 201341, RefRangeEnd = 201343, XrefRangeStart = 201340, XrefRangeEnd = 201341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Enter(Object obj, ref bool lockTaken)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lockTaken;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_Enter_Public_Static_Void_Object_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B9D RID: 11165 RVA: 0x000E2940 File Offset: 0x000E0B40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201343, XrefRangeEnd = 201351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowLockTakenException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_ThrowLockTakenException_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B9E RID: 11166 RVA: 0x000E2968 File Offset: 0x000E0B68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 201354, RefRangeEnd = 201356, XrefRangeStart = 201351, XrefRangeEnd = 201354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Exit(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_Exit_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B9F RID: 11167 RVA: 0x000E29A0 File Offset: 0x000E0BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201356, XrefRangeEnd = 201357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TryEnter(Object obj, ref bool lockTaken)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lockTaken;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_TryEnter_Public_Static_Void_Object_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BA0 RID: 11168 RVA: 0x000E29E4 File Offset: 0x000E0BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201357, XrefRangeEnd = 201358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int MillisecondsTimeoutFromTimeSpan(TimeSpan timeout)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timeout;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_MillisecondsTimeoutFromTimeSpan_Private_Static_Int32_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002BA1 RID: 11169 RVA: 0x000E2A24 File Offset: 0x000E0C24
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 201377, RefRangeEnd = 201383, XrefRangeStart = 201358, XrefRangeEnd = 201377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Wait(Object obj, int millisecondsTimeout, bool exitContext)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref millisecondsTimeout;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exitContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_Wait_Public_Static_Boolean_Object_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002BA2 RID: 11170 RVA: 0x000E2A84 File Offset: 0x000E0C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201383, XrefRangeEnd = 201384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Wait(Object obj, int millisecondsTimeout)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref millisecondsTimeout;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_Wait_Public_Static_Boolean_Object_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002BA3 RID: 11171 RVA: 0x000E2AD4 File Offset: 0x000E0CD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 201394, RefRangeEnd = 201395, XrefRangeStart = 201384, XrefRangeEnd = 201394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Wait(Object obj, TimeSpan timeout)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeout;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_Wait_Public_Static_Boolean_Object_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002BA4 RID: 11172 RVA: 0x000E2B24 File Offset: 0x000E0D24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201395, XrefRangeEnd = 201408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Wait(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_Wait_Public_Static_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002BA5 RID: 11173 RVA: 0x000E2B68 File Offset: 0x000E0D68
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 201421, RefRangeEnd = 201428, XrefRangeStart = 201408, XrefRangeEnd = 201421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Pulse(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_Pulse_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BA6 RID: 11174 RVA: 0x000E2BA0 File Offset: 0x000E0DA0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 201430, RefRangeEnd = 201438, XrefRangeStart = 201428, XrefRangeEnd = 201430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PulseAll(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_PulseAll_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BA7 RID: 11175 RVA: 0x000E2BD8 File Offset: 0x000E0DD8
		[CallerCount(0)]
		public unsafe static bool Monitor_test_synchronised(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_Monitor_test_synchronised_Private_Static_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002BA8 RID: 11176 RVA: 0x000E2C1C File Offset: 0x000E0E1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201438, XrefRangeEnd = 201441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Monitor_pulse(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_Monitor_pulse_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BA9 RID: 11177 RVA: 0x000E2C54 File Offset: 0x000E0E54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201441, XrefRangeEnd = 201450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ObjPulse(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_ObjPulse_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BAA RID: 11178 RVA: 0x000E2C8C File Offset: 0x000E0E8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201450, XrefRangeEnd = 201452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Monitor_pulse_all(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_Monitor_pulse_all_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BAB RID: 11179 RVA: 0x000E2CC4 File Offset: 0x000E0EC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201452, XrefRangeEnd = 201454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ObjPulseAll(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_ObjPulseAll_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BAC RID: 11180 RVA: 0x000E2CFC File Offset: 0x000E0EFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201454, XrefRangeEnd = 201457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Monitor_wait(Object obj, int ms)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ms;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_Monitor_wait_Private_Static_Boolean_Object_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002BAD RID: 11181 RVA: 0x000E2D4C File Offset: 0x000E0F4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201457, XrefRangeEnd = 201472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ObjWait(bool exitContext, int millisecondsTimeout, Object obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref exitContext;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref millisecondsTimeout;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_ObjWait_Private_Static_Boolean_Boolean_Int32_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002BAE RID: 11182 RVA: 0x000E2DAC File Offset: 0x000E0FAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201472, XrefRangeEnd = 201473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void try_enter_with_atomic_var(Object obj, int millisecondsTimeout, ref bool lockTaken)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref millisecondsTimeout;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lockTaken;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_try_enter_with_atomic_var_Private_Static_Void_Object_Int32_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BAF RID: 11183 RVA: 0x000E2E00 File Offset: 0x000E1000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201473, XrefRangeEnd = 201474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReliableEnterTimeout(Object obj, int timeout, ref bool lockTaken)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeout;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lockTaken;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_ReliableEnterTimeout_Private_Static_Void_Object_Int32_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BB0 RID: 11184 RVA: 0x000E2E54 File Offset: 0x000E1054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201474, XrefRangeEnd = 201475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReliableEnter(Object obj, ref bool lockTaken)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lockTaken;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_ReliableEnter_Private_Static_Void_Object_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BB1 RID: 11185 RVA: 0x0000F134 File Offset: 0x0000D334
		public Monitor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002620 RID: 9760
		private static readonly IntPtr NativeMethodInfoPtr_Enter_Public_Static_Void_Object_0;

		// Token: 0x04002621 RID: 9761
		private static readonly IntPtr NativeMethodInfoPtr_Enter_Public_Static_Void_Object_byref_Boolean_0;

		// Token: 0x04002622 RID: 9762
		private static readonly IntPtr NativeMethodInfoPtr_ThrowLockTakenException_Private_Static_Void_0;

		// Token: 0x04002623 RID: 9763
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Public_Static_Void_Object_0;

		// Token: 0x04002624 RID: 9764
		private static readonly IntPtr NativeMethodInfoPtr_TryEnter_Public_Static_Void_Object_byref_Boolean_0;

		// Token: 0x04002625 RID: 9765
		private static readonly IntPtr NativeMethodInfoPtr_MillisecondsTimeoutFromTimeSpan_Private_Static_Int32_TimeSpan_0;

		// Token: 0x04002626 RID: 9766
		private static readonly IntPtr NativeMethodInfoPtr_Wait_Public_Static_Boolean_Object_Int32_Boolean_0;

		// Token: 0x04002627 RID: 9767
		private static readonly IntPtr NativeMethodInfoPtr_Wait_Public_Static_Boolean_Object_Int32_0;

		// Token: 0x04002628 RID: 9768
		private static readonly IntPtr NativeMethodInfoPtr_Wait_Public_Static_Boolean_Object_TimeSpan_0;

		// Token: 0x04002629 RID: 9769
		private static readonly IntPtr NativeMethodInfoPtr_Wait_Public_Static_Boolean_Object_0;

		// Token: 0x0400262A RID: 9770
		private static readonly IntPtr NativeMethodInfoPtr_Pulse_Public_Static_Void_Object_0;

		// Token: 0x0400262B RID: 9771
		private static readonly IntPtr NativeMethodInfoPtr_PulseAll_Public_Static_Void_Object_0;

		// Token: 0x0400262C RID: 9772
		private static readonly IntPtr NativeMethodInfoPtr_Monitor_test_synchronised_Private_Static_Boolean_Object_0;

		// Token: 0x0400262D RID: 9773
		private static readonly IntPtr NativeMethodInfoPtr_Monitor_pulse_Private_Static_Void_Object_0;

		// Token: 0x0400262E RID: 9774
		private static readonly IntPtr NativeMethodInfoPtr_ObjPulse_Private_Static_Void_Object_0;

		// Token: 0x0400262F RID: 9775
		private static readonly IntPtr NativeMethodInfoPtr_Monitor_pulse_all_Private_Static_Void_Object_0;

		// Token: 0x04002630 RID: 9776
		private static readonly IntPtr NativeMethodInfoPtr_ObjPulseAll_Private_Static_Void_Object_0;

		// Token: 0x04002631 RID: 9777
		private static readonly IntPtr NativeMethodInfoPtr_Monitor_wait_Private_Static_Boolean_Object_Int32_0;

		// Token: 0x04002632 RID: 9778
		private static readonly IntPtr NativeMethodInfoPtr_ObjWait_Private_Static_Boolean_Boolean_Int32_Object_0;

		// Token: 0x04002633 RID: 9779
		private static readonly IntPtr NativeMethodInfoPtr_try_enter_with_atomic_var_Private_Static_Void_Object_Int32_byref_Boolean_0;

		// Token: 0x04002634 RID: 9780
		private static readonly IntPtr NativeMethodInfoPtr_ReliableEnterTimeout_Private_Static_Void_Object_Int32_byref_Boolean_0;

		// Token: 0x04002635 RID: 9781
		private static readonly IntPtr NativeMethodInfoPtr_ReliableEnter_Private_Static_Void_Object_byref_Boolean_0;
	}
}
