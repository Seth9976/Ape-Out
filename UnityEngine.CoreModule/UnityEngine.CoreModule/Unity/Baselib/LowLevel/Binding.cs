using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Unity.Baselib.LowLevel
{
	// Token: 0x020001BA RID: 442
	public static class Binding
	{
		// Token: 0x06001FB2 RID: 8114 RVA: 0x000106D0 File Offset: 0x0000E8D0
		public static IntPtr Baselib_Memory_Allocate(UIntPtr size)
		{
			return Binding.Baselib_Memory_AllocateDelegateField(size);
		}

		// Token: 0x06001FB3 RID: 8115 RVA: 0x000106DD File Offset: 0x0000E8DD
		public static IntPtr Baselib_Memory_Reallocate(IntPtr ptr, UIntPtr newSize)
		{
			return Binding.Baselib_Memory_ReallocateDelegateField(ptr, newSize);
		}

		// Token: 0x06001FB4 RID: 8116 RVA: 0x000106EB File Offset: 0x0000E8EB
		public static void Baselib_Memory_Free(IntPtr ptr)
		{
			Binding.Baselib_Memory_FreeDelegateField(ptr);
		}

		// Token: 0x06001FB5 RID: 8117 RVA: 0x000106F8 File Offset: 0x0000E8F8
		public static IntPtr Baselib_Memory_AlignedAllocate(UIntPtr size, UIntPtr alignment)
		{
			return Binding.Baselib_Memory_AlignedAllocateDelegateField(size, alignment);
		}

		// Token: 0x06001FB6 RID: 8118 RVA: 0x00010706 File Offset: 0x0000E906
		public static IntPtr Baselib_Memory_AlignedReallocate(IntPtr ptr, UIntPtr newSize, UIntPtr alignment)
		{
			return Binding.Baselib_Memory_AlignedReallocateDelegateField(ptr, newSize, alignment);
		}

		// Token: 0x06001FB7 RID: 8119 RVA: 0x00010715 File Offset: 0x0000E915
		public static void Baselib_Memory_AlignedFree(IntPtr ptr)
		{
			Binding.Baselib_Memory_AlignedFreeDelegateField(ptr);
		}

		// Token: 0x06001FB8 RID: 8120 RVA: 0x00073CB8 File Offset: 0x00071EB8
		public static Binding.Baselib_RegisteredNetwork_Endpoint Baselib_RegisteredNetwork_Endpoint_Empty()
		{
			Binding.Baselib_RegisteredNetwork_Endpoint baselib_RegisteredNetwork_Endpoint;
			Binding.Baselib_RegisteredNetwork_Endpoint_Empty_Injected(out baselib_RegisteredNetwork_Endpoint);
			return baselib_RegisteredNetwork_Endpoint;
		}

		// Token: 0x06001FB9 RID: 8121 RVA: 0x00010722 File Offset: 0x0000E922
		public static void Baselib_Thread_YieldExecution()
		{
			Binding.Baselib_Thread_YieldExecutionDelegateField();
		}

		// Token: 0x06001FBA RID: 8122 RVA: 0x0001072E File Offset: 0x0000E92E
		public static IntPtr Baselib_Thread_GetCurrentThreadId()
		{
			return Binding.Baselib_Thread_GetCurrentThreadIdDelegateField();
		}

		// Token: 0x06001FBB RID: 8123 RVA: 0x0001073A File Offset: 0x0000E93A
		public static UIntPtr Baselib_TLS_Alloc()
		{
			return Binding.Baselib_TLS_AllocDelegateField();
		}

		// Token: 0x06001FBC RID: 8124 RVA: 0x00010746 File Offset: 0x0000E946
		public static void Baselib_TLS_Free(UIntPtr handle)
		{
			Binding.Baselib_TLS_FreeDelegateField(handle);
		}

		// Token: 0x06001FBD RID: 8125 RVA: 0x00010753 File Offset: 0x0000E953
		public static void Baselib_TLS_Set(UIntPtr handle, UIntPtr value)
		{
			Binding.Baselib_TLS_SetDelegateField(handle, value);
		}

		// Token: 0x06001FBE RID: 8126 RVA: 0x00010761 File Offset: 0x0000E961
		public static UIntPtr Baselib_TLS_Get(UIntPtr handle)
		{
			return Binding.Baselib_TLS_GetDelegateField(handle);
		}

		// Token: 0x06001FBF RID: 8127 RVA: 0x0001076E File Offset: 0x0000E96E
		public static ulong Baselib_Timer_GetHighPrecisionTimerTicks()
		{
			return Binding.Baselib_Timer_GetHighPrecisionTimerTicksDelegateField();
		}

		// Token: 0x06001FC0 RID: 8128 RVA: 0x0001077A File Offset: 0x0000E97A
		public static void Baselib_Timer_WaitForAtLeast(uint timeInMilliseconds)
		{
			Binding.Baselib_Timer_WaitForAtLeastDelegateField(timeInMilliseconds);
		}

		// Token: 0x06001FC1 RID: 8129 RVA: 0x00010787 File Offset: 0x0000E987
		public static double Baselib_Timer_GetTimeSinceStartupInSeconds()
		{
			return Binding.Baselib_Timer_GetTimeSinceStartupInSecondsDelegateField();
		}

		// Token: 0x06001FC2 RID: 8130 RVA: 0x00010793 File Offset: 0x0000E993
		public static void Baselib_RegisteredNetwork_Endpoint_Empty_Injected(out Binding.Baselib_RegisteredNetwork_Endpoint ret)
		{
			Binding.Baselib_RegisteredNetwork_Endpoint_Empty_InjectedDelegateField(out ret);
		}

		// Token: 0x040019A7 RID: 6567
		public const uint Baselib_NetworkAddress_IpMaxStringLength = 46U;

		// Token: 0x040019A8 RID: 6568
		public const uint Baselib_RegisteredNetwork_Endpoint_MaxSize = 28U;

		// Token: 0x040019A9 RID: 6569
		public const uint Baselib_TLS_MinimumGuaranteedSlots = 100U;

		// Token: 0x040019AA RID: 6570
		public const ulong Baselib_SecondsPerMinute = 60UL;

		// Token: 0x040019AB RID: 6571
		public const ulong Baselib_MillisecondsPerSecond = 1000UL;

		// Token: 0x040019AC RID: 6572
		public const ulong Baselib_MillisecondsPerMinute = 60000UL;

		// Token: 0x040019AD RID: 6573
		public const ulong Baselib_MicrosecondsPerMillisecond = 1000UL;

		// Token: 0x040019AE RID: 6574
		public const ulong Baselib_MicrosecondsPerSecond = 1000000UL;

		// Token: 0x040019AF RID: 6575
		public const ulong Baselib_MicrosecondsPerMinute = 60000000UL;

		// Token: 0x040019B0 RID: 6576
		public const ulong Baselib_NanosecondsPerMicrosecond = 1000UL;

		// Token: 0x040019B1 RID: 6577
		public const ulong Baselib_NanosecondsPerMillisecond = 1000000UL;

		// Token: 0x040019B2 RID: 6578
		public const ulong Baselib_NanosecondsPerSecond = 1000000000UL;

		// Token: 0x040019B3 RID: 6579
		public const ulong Baselib_NanosecondsPerMinute = 60000000000UL;

		// Token: 0x040019B4 RID: 6580
		public const ulong Baselib_Timer_MaxNumberOfNanosecondsPerTick = 1000UL;

		// Token: 0x040019B5 RID: 6581
		public const double Baselib_Timer_MinNumberOfNanosecondsPerTick = 0.01;

		// Token: 0x040019B6 RID: 6582
		private static readonly Binding.Baselib_Memory_AllocateDelegate Baselib_Memory_AllocateDelegateField = IL2CPP.ResolveICall<Binding.Baselib_Memory_AllocateDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Memory_Allocate");

		// Token: 0x040019B7 RID: 6583
		private static readonly Binding.Baselib_Memory_ReallocateDelegate Baselib_Memory_ReallocateDelegateField = IL2CPP.ResolveICall<Binding.Baselib_Memory_ReallocateDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Memory_Reallocate");

		// Token: 0x040019B8 RID: 6584
		private static readonly Binding.Baselib_Memory_FreeDelegate Baselib_Memory_FreeDelegateField = IL2CPP.ResolveICall<Binding.Baselib_Memory_FreeDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Memory_Free");

		// Token: 0x040019B9 RID: 6585
		private static readonly Binding.Baselib_Memory_AlignedAllocateDelegate Baselib_Memory_AlignedAllocateDelegateField = IL2CPP.ResolveICall<Binding.Baselib_Memory_AlignedAllocateDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Memory_AlignedAllocate");

		// Token: 0x040019BA RID: 6586
		private static readonly Binding.Baselib_Memory_AlignedReallocateDelegate Baselib_Memory_AlignedReallocateDelegateField = IL2CPP.ResolveICall<Binding.Baselib_Memory_AlignedReallocateDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Memory_AlignedReallocate");

		// Token: 0x040019BB RID: 6587
		private static readonly Binding.Baselib_Memory_AlignedFreeDelegate Baselib_Memory_AlignedFreeDelegateField = IL2CPP.ResolveICall<Binding.Baselib_Memory_AlignedFreeDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Memory_AlignedFree");

		// Token: 0x040019BC RID: 6588
		private static readonly Binding.Baselib_Thread_YieldExecutionDelegate Baselib_Thread_YieldExecutionDelegateField = IL2CPP.ResolveICall<Binding.Baselib_Thread_YieldExecutionDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Thread_YieldExecution");

		// Token: 0x040019BD RID: 6589
		private static readonly Binding.Baselib_Thread_GetCurrentThreadIdDelegate Baselib_Thread_GetCurrentThreadIdDelegateField = IL2CPP.ResolveICall<Binding.Baselib_Thread_GetCurrentThreadIdDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Thread_GetCurrentThreadId");

		// Token: 0x040019BE RID: 6590
		private static readonly Binding.Baselib_TLS_AllocDelegate Baselib_TLS_AllocDelegateField = IL2CPP.ResolveICall<Binding.Baselib_TLS_AllocDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_TLS_Alloc");

		// Token: 0x040019BF RID: 6591
		private static readonly Binding.Baselib_TLS_FreeDelegate Baselib_TLS_FreeDelegateField = IL2CPP.ResolveICall<Binding.Baselib_TLS_FreeDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_TLS_Free");

		// Token: 0x040019C0 RID: 6592
		private static readonly Binding.Baselib_TLS_SetDelegate Baselib_TLS_SetDelegateField = IL2CPP.ResolveICall<Binding.Baselib_TLS_SetDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_TLS_Set");

		// Token: 0x040019C1 RID: 6593
		private static readonly Binding.Baselib_TLS_GetDelegate Baselib_TLS_GetDelegateField = IL2CPP.ResolveICall<Binding.Baselib_TLS_GetDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_TLS_Get");

		// Token: 0x040019C2 RID: 6594
		private static readonly Binding.Baselib_Timer_GetHighPrecisionTimerTicksDelegate Baselib_Timer_GetHighPrecisionTimerTicksDelegateField = IL2CPP.ResolveICall<Binding.Baselib_Timer_GetHighPrecisionTimerTicksDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Timer_GetHighPrecisionTimerTicks");

		// Token: 0x040019C3 RID: 6595
		private static readonly Binding.Baselib_Timer_WaitForAtLeastDelegate Baselib_Timer_WaitForAtLeastDelegateField = IL2CPP.ResolveICall<Binding.Baselib_Timer_WaitForAtLeastDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Timer_WaitForAtLeast");

		// Token: 0x040019C4 RID: 6596
		private static readonly Binding.Baselib_Timer_GetTimeSinceStartupInSecondsDelegate Baselib_Timer_GetTimeSinceStartupInSecondsDelegateField = IL2CPP.ResolveICall<Binding.Baselib_Timer_GetTimeSinceStartupInSecondsDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Timer_GetTimeSinceStartupInSeconds");

		// Token: 0x040019C5 RID: 6597
		private static readonly Binding.Baselib_RegisteredNetwork_Endpoint_Empty_InjectedDelegate Baselib_RegisteredNetwork_Endpoint_Empty_InjectedDelegateField = IL2CPP.ResolveICall<Binding.Baselib_RegisteredNetwork_Endpoint_Empty_InjectedDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_RegisteredNetwork_Endpoint_Empty_Injected");

		// Token: 0x02000A8F RID: 2703
		public enum Baselib_ErrorCode
		{
			// Token: 0x04002008 RID: 8200
			Success,
			// Token: 0x04002009 RID: 8201
			OutOfMemory = 16777216,
			// Token: 0x0400200A RID: 8202
			OutOfSystemResources,
			// Token: 0x0400200B RID: 8203
			InvalidAddressRange,
			// Token: 0x0400200C RID: 8204
			InvalidArgument,
			// Token: 0x0400200D RID: 8205
			InvalidBufferSize,
			// Token: 0x0400200E RID: 8206
			InvalidState,
			// Token: 0x0400200F RID: 8207
			NotSupported,
			// Token: 0x04002010 RID: 8208
			Timeout,
			// Token: 0x04002011 RID: 8209
			UnsupportedAlignment = 33554432,
			// Token: 0x04002012 RID: 8210
			InvalidPageSize,
			// Token: 0x04002013 RID: 8211
			InvalidPageCount,
			// Token: 0x04002014 RID: 8212
			UnsupportedPageState,
			// Token: 0x04002015 RID: 8213
			ThreadCannotJoinSelf = 50331648,
			// Token: 0x04002016 RID: 8214
			NetworkInitializationError = 67108864,
			// Token: 0x04002017 RID: 8215
			AddressInUse,
			// Token: 0x04002018 RID: 8216
			AddressUnreachable,
			// Token: 0x04002019 RID: 8217
			AddressFamilyNotSupported,
			// Token: 0x0400201A RID: 8218
			Disconnected,
			// Token: 0x0400201B RID: 8219
			InvalidPathname = 83886080,
			// Token: 0x0400201C RID: 8220
			RequestedAccessIsNotAllowed,
			// Token: 0x0400201D RID: 8221
			IOError,
			// Token: 0x0400201E RID: 8222
			FailedToOpenDynamicLibrary = 100663296,
			// Token: 0x0400201F RID: 8223
			FunctionNotFound,
			// Token: 0x04002020 RID: 8224
			UnexpectedError = -1
		}

		// Token: 0x02000A90 RID: 2704
		public enum Baselib_ErrorState_NativeErrorCodeType : byte
		{
			// Token: 0x04002022 RID: 8226
			None,
			// Token: 0x04002023 RID: 8227
			PlatformDefined
		}

		// Token: 0x02000A91 RID: 2705
		public enum Baselib_ErrorState_ExtraInformationType : byte
		{
			// Token: 0x04002025 RID: 8229
			None,
			// Token: 0x04002026 RID: 8230
			StaticString,
			// Token: 0x04002027 RID: 8231
			GenerationCounter
		}

		// Token: 0x02000A92 RID: 2706
		public enum Baselib_ErrorState_ExplainVerbosity
		{
			// Token: 0x04002029 RID: 8233
			ErrorType,
			// Token: 0x0400202A RID: 8234
			ErrorType_SourceLocation_Explanation
		}

		// Token: 0x02000A93 RID: 2707
		public enum Baselib_Memory_PageState
		{
			// Token: 0x0400202C RID: 8236
			Reserved,
			// Token: 0x0400202D RID: 8237
			NoAccess,
			// Token: 0x0400202E RID: 8238
			ReadOnly,
			// Token: 0x0400202F RID: 8239
			ReadWrite = 4,
			// Token: 0x04002030 RID: 8240
			ReadOnly_Executable = 18,
			// Token: 0x04002031 RID: 8241
			ReadWrite_Executable = 20
		}

		// Token: 0x02000A94 RID: 2708
		public enum Baselib_NetworkAddress_Family
		{
			// Token: 0x04002033 RID: 8243
			Invalid,
			// Token: 0x04002034 RID: 8244
			IPv4,
			// Token: 0x04002035 RID: 8245
			IPv6
		}

		// Token: 0x02000A95 RID: 2709
		public enum Baselib_NetworkAddress_AddressReuse
		{
			// Token: 0x04002037 RID: 8247
			DoNotAllow,
			// Token: 0x04002038 RID: 8248
			Allow
		}

		// Token: 0x02000A96 RID: 2710
		public struct Baselib_RegisteredNetwork_Endpoint
		{
		}

		// Token: 0x02000A97 RID: 2711
		public enum Baselib_RegisteredNetwork_CompletionStatus
		{
			// Token: 0x0400203A RID: 8250
			Failed,
			// Token: 0x0400203B RID: 8251
			Success
		}

		// Token: 0x02000A98 RID: 2712
		public enum Baselib_RegisteredNetwork_ProcessStatus
		{
			// Token: 0x0400203D RID: 8253
			NonePendingImmediately,
			// Token: 0x0400203E RID: 8254
			Done = 0,
			// Token: 0x0400203F RID: 8255
			Pending
		}

		// Token: 0x02000A99 RID: 2713
		public enum Baselib_RegisteredNetwork_CompletionQueueStatus
		{
			// Token: 0x04002041 RID: 8257
			NoResultsAvailable,
			// Token: 0x04002042 RID: 8258
			ResultsAvailable
		}

		// Token: 0x02000A9A RID: 2714
		public enum Baselib_Socket_Protocol
		{
			// Token: 0x04002044 RID: 8260
			UDP = 1,
			// Token: 0x04002045 RID: 8261
			TCP
		}

		// Token: 0x02000A9B RID: 2715
		public enum Baselib_Socket_PollEvents
		{
			// Token: 0x04002047 RID: 8263
			Readable = 1,
			// Token: 0x04002048 RID: 8264
			Writable,
			// Token: 0x04002049 RID: 8265
			Connected = 4
		}

		// Token: 0x02000A9C RID: 2716
		// (Invoke) Token: 0x0600339E RID: 13214
		private delegate IntPtr Baselib_Memory_AllocateDelegate(UIntPtr size);

		// Token: 0x02000A9D RID: 2717
		// (Invoke) Token: 0x060033A0 RID: 13216
		private delegate IntPtr Baselib_Memory_ReallocateDelegate(IntPtr ptr, UIntPtr newSize);

		// Token: 0x02000A9E RID: 2718
		// (Invoke) Token: 0x060033A2 RID: 13218
		private delegate void Baselib_Memory_FreeDelegate(IntPtr ptr);

		// Token: 0x02000A9F RID: 2719
		// (Invoke) Token: 0x060033A4 RID: 13220
		private delegate IntPtr Baselib_Memory_AlignedAllocateDelegate(UIntPtr size, UIntPtr alignment);

		// Token: 0x02000AA0 RID: 2720
		// (Invoke) Token: 0x060033A6 RID: 13222
		private delegate IntPtr Baselib_Memory_AlignedReallocateDelegate(IntPtr ptr, UIntPtr newSize, UIntPtr alignment);

		// Token: 0x02000AA1 RID: 2721
		// (Invoke) Token: 0x060033A8 RID: 13224
		private delegate void Baselib_Memory_AlignedFreeDelegate(IntPtr ptr);

		// Token: 0x02000AA2 RID: 2722
		// (Invoke) Token: 0x060033AA RID: 13226
		private delegate void Baselib_Thread_YieldExecutionDelegate();

		// Token: 0x02000AA3 RID: 2723
		// (Invoke) Token: 0x060033AC RID: 13228
		private delegate IntPtr Baselib_Thread_GetCurrentThreadIdDelegate();

		// Token: 0x02000AA4 RID: 2724
		// (Invoke) Token: 0x060033AE RID: 13230
		private delegate UIntPtr Baselib_TLS_AllocDelegate();

		// Token: 0x02000AA5 RID: 2725
		// (Invoke) Token: 0x060033B0 RID: 13232
		private delegate void Baselib_TLS_FreeDelegate(UIntPtr handle);

		// Token: 0x02000AA6 RID: 2726
		// (Invoke) Token: 0x060033B2 RID: 13234
		private delegate void Baselib_TLS_SetDelegate(UIntPtr handle, UIntPtr value);

		// Token: 0x02000AA7 RID: 2727
		// (Invoke) Token: 0x060033B4 RID: 13236
		private delegate UIntPtr Baselib_TLS_GetDelegate(UIntPtr handle);

		// Token: 0x02000AA8 RID: 2728
		// (Invoke) Token: 0x060033B6 RID: 13238
		private delegate ulong Baselib_Timer_GetHighPrecisionTimerTicksDelegate();

		// Token: 0x02000AA9 RID: 2729
		// (Invoke) Token: 0x060033B8 RID: 13240
		private delegate void Baselib_Timer_WaitForAtLeastDelegate(uint timeInMilliseconds);

		// Token: 0x02000AAA RID: 2730
		// (Invoke) Token: 0x060033BA RID: 13242
		private delegate double Baselib_Timer_GetTimeSinceStartupInSecondsDelegate();

		// Token: 0x02000AAB RID: 2731
		// (Invoke) Token: 0x060033BC RID: 13244
		private delegate void Baselib_RegisteredNetwork_Endpoint_Empty_InjectedDelegate([Out] IntPtr ret);
	}
}
