using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppMicrosoft.Win32.SafeHandles;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000294 RID: 660
	public static class NativeEventCalls : Object
	{
		// Token: 0x06002D2F RID: 11567 RVA: 0x000E8724 File Offset: 0x000E6924
		// Note: this type is marked as 'beforefieldinit'.
		static NativeEventCalls()
		{
			Il2CppClassPointerStore<NativeEventCalls>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "NativeEventCalls");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeEventCalls>.NativeClassPtr);
			NativeEventCalls.NativeMethodInfoPtr_CreateEvent_internal_Public_Static_IntPtr_Boolean_Boolean_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeEventCalls>.NativeClassPtr, 100670543);
			NativeEventCalls.NativeMethodInfoPtr_SetEvent_Public_Static_Boolean_SafeWaitHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeEventCalls>.NativeClassPtr, 100670544);
			NativeEventCalls.NativeMethodInfoPtr_SetEvent_internal_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeEventCalls>.NativeClassPtr, 100670545);
			NativeEventCalls.NativeMethodInfoPtr_ResetEvent_Public_Static_Boolean_SafeWaitHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeEventCalls>.NativeClassPtr, 100670546);
			NativeEventCalls.NativeMethodInfoPtr_ResetEvent_internal_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeEventCalls>.NativeClassPtr, 100670547);
			NativeEventCalls.NativeMethodInfoPtr_CloseEvent_internal_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeEventCalls>.NativeClassPtr, 100670548);
		}

		// Token: 0x06002D30 RID: 11568 RVA: 0x000E87CC File Offset: 0x000E69CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204704, XrefRangeEnd = 204707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CreateEvent_internal(bool manual, bool initial, string name, out int errorCode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref manual;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initial;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &errorCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeEventCalls.NativeMethodInfoPtr_CreateEvent_internal_Public_Static_IntPtr_Boolean_Boolean_String_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002D31 RID: 11569 RVA: 0x000E8838 File Offset: 0x000E6A38
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 204710, RefRangeEnd = 204723, XrefRangeStart = 204707, XrefRangeEnd = 204710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetEvent(SafeWaitHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeEventCalls.NativeMethodInfoPtr_SetEvent_Public_Static_Boolean_SafeWaitHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D32 RID: 11570 RVA: 0x000E887C File Offset: 0x000E6A7C
		[CallerCount(0)]
		public unsafe static bool SetEvent_internal(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeEventCalls.NativeMethodInfoPtr_SetEvent_internal_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D33 RID: 11571 RVA: 0x000E88BC File Offset: 0x000E6ABC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 204726, RefRangeEnd = 204731, XrefRangeStart = 204723, XrefRangeEnd = 204726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ResetEvent(SafeWaitHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeEventCalls.NativeMethodInfoPtr_ResetEvent_Public_Static_Boolean_SafeWaitHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D34 RID: 11572 RVA: 0x000E8900 File Offset: 0x000E6B00
		[CallerCount(0)]
		public unsafe static bool ResetEvent_internal(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeEventCalls.NativeMethodInfoPtr_ResetEvent_internal_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D35 RID: 11573 RVA: 0x000E8940 File Offset: 0x000E6B40
		[CallerCount(0)]
		public unsafe static void CloseEvent_internal(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeEventCalls.NativeMethodInfoPtr_CloseEvent_internal_Public_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D36 RID: 11574 RVA: 0x0000F8BB File Offset: 0x0000DABB
		public NativeEventCalls(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002746 RID: 10054
		private static readonly IntPtr NativeMethodInfoPtr_CreateEvent_internal_Public_Static_IntPtr_Boolean_Boolean_String_byref_Int32_0;

		// Token: 0x04002747 RID: 10055
		private static readonly IntPtr NativeMethodInfoPtr_SetEvent_Public_Static_Boolean_SafeWaitHandle_0;

		// Token: 0x04002748 RID: 10056
		private static readonly IntPtr NativeMethodInfoPtr_SetEvent_internal_Private_Static_Boolean_IntPtr_0;

		// Token: 0x04002749 RID: 10057
		private static readonly IntPtr NativeMethodInfoPtr_ResetEvent_Public_Static_Boolean_SafeWaitHandle_0;

		// Token: 0x0400274A RID: 10058
		private static readonly IntPtr NativeMethodInfoPtr_ResetEvent_internal_Private_Static_Boolean_IntPtr_0;

		// Token: 0x0400274B RID: 10059
		private static readonly IntPtr NativeMethodInfoPtr_CloseEvent_internal_Public_Static_Void_IntPtr_0;
	}
}
