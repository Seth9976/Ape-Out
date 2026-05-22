using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000265 RID: 613
	[StructLayout(2)]
	public struct SpinLock
	{
		// Token: 0x06002AFC RID: 11004 RVA: 0x000DFFD4 File Offset: 0x000DE1D4
		// Note: this type is marked as 'beforefieldinit'.
		static SpinLock()
		{
			Il2CppClassPointerStore<SpinLock>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "SpinLock");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpinLock>.NativeClassPtr);
			SpinLock.NativeFieldInfoPtr_m_owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, "m_owner");
			SpinLock.NativeFieldInfoPtr_MAXIMUM_WAITERS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, "MAXIMUM_WAITERS");
			SpinLock.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, 100670201);
			SpinLock.NativeMethodInfoPtr_Enter_Public_Void_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, 100670202);
			SpinLock.NativeMethodInfoPtr_TryEnter_Public_Void_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, 100670203);
			SpinLock.NativeMethodInfoPtr_ContinueTryEnter_Private_Void_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, 100670204);
			SpinLock.NativeMethodInfoPtr_DecrementWaiters_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, 100670205);
			SpinLock.NativeMethodInfoPtr_ContinueTryEnterWithThreadTracking_Private_Void_Int32_UInt32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, 100670206);
			SpinLock.NativeMethodInfoPtr_Exit_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, 100670207);
			SpinLock.NativeMethodInfoPtr_ExitSlowPath_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, 100670208);
			SpinLock.NativeMethodInfoPtr_get_IsHeldByCurrentThread_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, 100670209);
			SpinLock.NativeMethodInfoPtr_get_IsThreadOwnerTrackingEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, 100670210);
		}

		// Token: 0x06002AFD RID: 11005 RVA: 0x000E00F4 File Offset: 0x000DE2F4
		[CallerCount(0)]
		public unsafe SpinLock(bool enableThreadOwnerTracking)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enableThreadOwnerTracking;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpinLock.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002AFE RID: 11006 RVA: 0x000E0128 File Offset: 0x000DE328
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 200875, RefRangeEnd = 200878, XrefRangeStart = 200872, XrefRangeEnd = 200875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Enter(ref bool lockTaken)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &lockTaken;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpinLock.NativeMethodInfoPtr_Enter_Public_Void_byref_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002AFF RID: 11007 RVA: 0x000E015C File Offset: 0x000DE35C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200878, XrefRangeEnd = 200881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryEnter(int millisecondsTimeout, ref bool lockTaken)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lockTaken;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpinLock.NativeMethodInfoPtr_TryEnter_Public_Void_Int32_byref_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B00 RID: 11008 RVA: 0x000E019C File Offset: 0x000DE39C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 200901, RefRangeEnd = 200905, XrefRangeStart = 200881, XrefRangeEnd = 200901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ContinueTryEnter(int millisecondsTimeout, ref bool lockTaken)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lockTaken;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpinLock.NativeMethodInfoPtr_ContinueTryEnter_Private_Void_Int32_byref_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B01 RID: 11009 RVA: 0x000E01DC File Offset: 0x000DE3DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200905, XrefRangeEnd = 200906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DecrementWaiters()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpinLock.NativeMethodInfoPtr_DecrementWaiters_Private_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B02 RID: 11010 RVA: 0x000E0204 File Offset: 0x000DE404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200906, XrefRangeEnd = 200915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ContinueTryEnterWithThreadTracking(int millisecondsTimeout, uint startTime, ref bool lockTaken)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startTime;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lockTaken;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpinLock.NativeMethodInfoPtr_ContinueTryEnterWithThreadTracking_Private_Void_Int32_UInt32_byref_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B03 RID: 11011 RVA: 0x000E0254 File Offset: 0x000DE454
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 200919, RefRangeEnd = 200920, XrefRangeStart = 200915, XrefRangeEnd = 200919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(bool useMemoryBarrier)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref useMemoryBarrier;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpinLock.NativeMethodInfoPtr_Exit_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B04 RID: 11012 RVA: 0x000E0288 File Offset: 0x000DE488
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 200921, RefRangeEnd = 200926, XrefRangeStart = 200920, XrefRangeEnd = 200921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitSlowPath(bool useMemoryBarrier)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref useMemoryBarrier;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpinLock.NativeMethodInfoPtr_ExitSlowPath_Private_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x06002B05 RID: 11013 RVA: 0x000E02BC File Offset: 0x000DE4BC
		public unsafe bool IsHeldByCurrentThread
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 200928, RefRangeEnd = 200929, XrefRangeStart = 200926, XrefRangeEnd = 200928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpinLock.NativeMethodInfoPtr_get_IsHeldByCurrentThread_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x06002B06 RID: 11014 RVA: 0x000E02EC File Offset: 0x000DE4EC
		public unsafe bool IsThreadOwnerTrackingEnabled
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpinLock.NativeMethodInfoPtr_get_IsThreadOwnerTrackingEnabled_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B07 RID: 11015 RVA: 0x0000EDA3 File Offset: 0x0000CFA3
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, ref this));
		}

		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x06002B08 RID: 11016 RVA: 0x000E031C File Offset: 0x000DE51C
		// (set) Token: 0x06002B09 RID: 11017 RVA: 0x0000EDB5 File Offset: 0x0000CFB5
		public unsafe static int MAXIMUM_WAITERS
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SpinLock.NativeFieldInfoPtr_MAXIMUM_WAITERS, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpinLock.NativeFieldInfoPtr_MAXIMUM_WAITERS, (void*)(&value));
			}
		}

		// Token: 0x040025B3 RID: 9651
		private static readonly IntPtr NativeFieldInfoPtr_m_owner;

		// Token: 0x040025B4 RID: 9652
		private static readonly IntPtr NativeFieldInfoPtr_MAXIMUM_WAITERS;

		// Token: 0x040025B5 RID: 9653
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x040025B6 RID: 9654
		private static readonly IntPtr NativeMethodInfoPtr_Enter_Public_Void_byref_Boolean_0;

		// Token: 0x040025B7 RID: 9655
		private static readonly IntPtr NativeMethodInfoPtr_TryEnter_Public_Void_Int32_byref_Boolean_0;

		// Token: 0x040025B8 RID: 9656
		private static readonly IntPtr NativeMethodInfoPtr_ContinueTryEnter_Private_Void_Int32_byref_Boolean_0;

		// Token: 0x040025B9 RID: 9657
		private static readonly IntPtr NativeMethodInfoPtr_DecrementWaiters_Private_Void_0;

		// Token: 0x040025BA RID: 9658
		private static readonly IntPtr NativeMethodInfoPtr_ContinueTryEnterWithThreadTracking_Private_Void_Int32_UInt32_byref_Boolean_0;

		// Token: 0x040025BB RID: 9659
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Public_Void_Boolean_0;

		// Token: 0x040025BC RID: 9660
		private static readonly IntPtr NativeMethodInfoPtr_ExitSlowPath_Private_Void_Boolean_0;

		// Token: 0x040025BD RID: 9661
		private static readonly IntPtr NativeMethodInfoPtr_get_IsHeldByCurrentThread_Public_get_Boolean_0;

		// Token: 0x040025BE RID: 9662
		private static readonly IntPtr NativeMethodInfoPtr_get_IsThreadOwnerTrackingEnabled_Public_get_Boolean_0;

		// Token: 0x040025BF RID: 9663
		[FieldOffset(0)]
		public int m_owner;

		// Token: 0x020005ED RID: 1517
		public class SystemThreading_SpinLockDebugView : Object
		{
			// Token: 0x06005413 RID: 21523 RVA: 0x0001FBAF File Offset: 0x0001DDAF
			// Note: this type is marked as 'beforefieldinit'.
			static SystemThreading_SpinLockDebugView()
			{
				Il2CppClassPointerStore<SpinLock.SystemThreading_SpinLockDebugView>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, "SystemThreading_SpinLockDebugView");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpinLock.SystemThreading_SpinLockDebugView>.NativeClassPtr);
			}

			// Token: 0x06005414 RID: 21524 RVA: 0x0001FBCF File Offset: 0x0001DDCF
			public SystemThreading_SpinLockDebugView(IntPtr pointer)
				: base(pointer)
			{
			}
		}
	}
}
