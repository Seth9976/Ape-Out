using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Diagnostics.Tracing;

namespace Il2CppMicrosoft.Win32
{
	// Token: 0x0200003D RID: 61
	public static class UnsafeNativeMethods : Object
	{
		// Token: 0x0600041E RID: 1054 RVA: 0x00003AA7 File Offset: 0x00001CA7
		// Note: this type is marked as 'beforefieldinit'.
		static UnsafeNativeMethods()
		{
			Il2CppClassPointerStore<UnsafeNativeMethods>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Microsoft.Win32", "UnsafeNativeMethods");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsafeNativeMethods>.NativeClassPtr);
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00003ACC File Offset: 0x00001CCC
		public UnsafeNativeMethods(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0200054C RID: 1356
		public static class ManifestEtw : Object
		{
			// Token: 0x06004FC8 RID: 20424 RVA: 0x0016AAA8 File Offset: 0x00168CA8
			// Note: this type is marked as 'beforefieldinit'.
			static ManifestEtw()
			{
				Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnsafeNativeMethods>.NativeClassPtr, "ManifestEtw");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw>.NativeClassPtr);
				UnsafeNativeMethods.ManifestEtw.NativeMethodInfoPtr_EventRegister_Internal_Static_UInt32_byref_Guid_EtwEnableCallback_ptr_Void_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw>.NativeClassPtr, 100663885);
				UnsafeNativeMethods.ManifestEtw.NativeMethodInfoPtr_EventUnregister_Internal_Static_UInt32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw>.NativeClassPtr, 100663886);
				UnsafeNativeMethods.ManifestEtw.NativeMethodInfoPtr_EventWriteTransferWrapper_Internal_Static_Int32_Int64_byref_EventDescriptor_ptr_Guid_ptr_Guid_Int32_ptr_EventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw>.NativeClassPtr, 100663887);
				UnsafeNativeMethods.ManifestEtw.NativeMethodInfoPtr_EventWriteTransfer_Private_Static_Int32_Int64_byref_EventDescriptor_ptr_Guid_ptr_Guid_Int32_ptr_EventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw>.NativeClassPtr, 100663888);
				UnsafeNativeMethods.ManifestEtw.NativeMethodInfoPtr_EventActivityIdControl_Internal_Static_Int32_ActivityControl_byref_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw>.NativeClassPtr, 100663889);
				UnsafeNativeMethods.ManifestEtw.NativeMethodInfoPtr_EventSetInformation_Internal_Static_Int32_Int64_EVENT_INFO_CLASS_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw>.NativeClassPtr, 100663890);
				UnsafeNativeMethods.ManifestEtw.NativeMethodInfoPtr_EnumerateTraceGuidsEx_Internal_Static_Int32_TRACE_QUERY_INFO_CLASS_ptr_Void_Int32_ptr_Void_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw>.NativeClassPtr, 100663891);
			}

			// Token: 0x06004FC9 RID: 20425 RVA: 0x0016AB60 File Offset: 0x00168D60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137306, XrefRangeEnd = 137308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static uint EventRegister([In] ref Guid providerId, [In] UnsafeNativeMethods.ManifestEtw.EtwEnableCallback enableCallback, [In] void* callbackContext, [In] [Out] ref long registrationHandle)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &providerId;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(enableCallback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = callbackContext;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &registrationHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeNativeMethods.ManifestEtw.NativeMethodInfoPtr_EventRegister_Internal_Static_UInt32_byref_Guid_EtwEnableCallback_ptr_Void_byref_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004FCA RID: 20426 RVA: 0x0016ABCC File Offset: 0x00168DCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137308, XrefRangeEnd = 137310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static uint EventUnregister([In] long registrationHandle)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref registrationHandle;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeNativeMethods.ManifestEtw.NativeMethodInfoPtr_EventUnregister_Internal_Static_UInt32_Int64_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004FCB RID: 20427 RVA: 0x0016AC0C File Offset: 0x00168E0C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137317, RefRangeEnd = 137318, XrefRangeStart = 137310, XrefRangeEnd = 137317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static int EventWriteTransferWrapper(long registrationHandle, ref EventDescriptor eventDescriptor, Guid* activityId, Guid* relatedActivityId, int userDataCount, EventProvider.EventData* userData)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref registrationHandle;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &eventDescriptor;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = activityId;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = relatedActivityId;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userDataCount;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = userData;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeNativeMethods.ManifestEtw.NativeMethodInfoPtr_EventWriteTransferWrapper_Internal_Static_Int32_Int64_byref_EventDescriptor_ptr_Guid_ptr_Guid_Int32_ptr_EventData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004FCC RID: 20428 RVA: 0x0016AC90 File Offset: 0x00168E90
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 137320, RefRangeEnd = 137325, XrefRangeStart = 137318, XrefRangeEnd = 137320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static int EventWriteTransfer([In] long registrationHandle, [In] ref EventDescriptor eventDescriptor, [In] Guid* activityId, [In] Guid* relatedActivityId, [In] int userDataCount, [In] EventProvider.EventData* userData)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref registrationHandle;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &eventDescriptor;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = activityId;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = relatedActivityId;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userDataCount;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = userData;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeNativeMethods.ManifestEtw.NativeMethodInfoPtr_EventWriteTransfer_Private_Static_Int32_Int64_byref_EventDescriptor_ptr_Guid_ptr_Guid_Int32_ptr_EventData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004FCD RID: 20429 RVA: 0x0016AD14 File Offset: 0x00168F14
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 137327, RefRangeEnd = 137329, XrefRangeStart = 137325, XrefRangeEnd = 137327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static int EventActivityIdControl([In] UnsafeNativeMethods.ManifestEtw.ActivityControl ControlCode, [In] [Out] ref Guid ActivityId)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref ControlCode;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ActivityId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeNativeMethods.ManifestEtw.NativeMethodInfoPtr_EventActivityIdControl_Internal_Static_Int32_ActivityControl_byref_Guid_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004FCE RID: 20430 RVA: 0x0016AD60 File Offset: 0x00168F60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137329, XrefRangeEnd = 137331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static int EventSetInformation([In] long registrationHandle, [In] UnsafeNativeMethods.ManifestEtw.EVENT_INFO_CLASS informationClass, [In] void* eventInformation, [In] int informationLength)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref registrationHandle;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref informationClass;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = eventInformation;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref informationLength;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeNativeMethods.ManifestEtw.NativeMethodInfoPtr_EventSetInformation_Internal_Static_Int32_Int64_EVENT_INFO_CLASS_ptr_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004FCF RID: 20431 RVA: 0x0016ADC8 File Offset: 0x00168FC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137331, XrefRangeEnd = 137333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static int EnumerateTraceGuidsEx(UnsafeNativeMethods.ManifestEtw.TRACE_QUERY_INFO_CLASS TraceQueryInfoClass, void* InBuffer, int InBufferSize, void* OutBuffer, int OutBufferSize, ref int ReturnLength)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref TraceQueryInfoClass;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = InBuffer;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref InBufferSize;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = OutBuffer;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref OutBufferSize;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ReturnLength;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeNativeMethods.ManifestEtw.NativeMethodInfoPtr_EnumerateTraceGuidsEx_Internal_Static_Int32_TRACE_QUERY_INFO_CLASS_ptr_Void_Int32_ptr_Void_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004FD0 RID: 20432 RVA: 0x0001DE42 File Offset: 0x0001C042
			public ManifestEtw(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04004069 RID: 16489
			private static readonly IntPtr NativeMethodInfoPtr_EventRegister_Internal_Static_UInt32_byref_Guid_EtwEnableCallback_ptr_Void_byref_Int64_0;

			// Token: 0x0400406A RID: 16490
			private static readonly IntPtr NativeMethodInfoPtr_EventUnregister_Internal_Static_UInt32_Int64_0;

			// Token: 0x0400406B RID: 16491
			private static readonly IntPtr NativeMethodInfoPtr_EventWriteTransferWrapper_Internal_Static_Int32_Int64_byref_EventDescriptor_ptr_Guid_ptr_Guid_Int32_ptr_EventData_0;

			// Token: 0x0400406C RID: 16492
			private static readonly IntPtr NativeMethodInfoPtr_EventWriteTransfer_Private_Static_Int32_Int64_byref_EventDescriptor_ptr_Guid_ptr_Guid_Int32_ptr_EventData_0;

			// Token: 0x0400406D RID: 16493
			private static readonly IntPtr NativeMethodInfoPtr_EventActivityIdControl_Internal_Static_Int32_ActivityControl_byref_Guid_0;

			// Token: 0x0400406E RID: 16494
			private static readonly IntPtr NativeMethodInfoPtr_EventSetInformation_Internal_Static_Int32_Int64_EVENT_INFO_CLASS_ptr_Void_Int32_0;

			// Token: 0x0400406F RID: 16495
			private static readonly IntPtr NativeMethodInfoPtr_EnumerateTraceGuidsEx_Internal_Static_Int32_TRACE_QUERY_INFO_CLASS_ptr_Void_Int32_ptr_Void_Int32_byref_Int32_0;

			// Token: 0x020006C4 RID: 1732
			public sealed class EtwEnableCallback : MulticastDelegate
			{
				// Token: 0x060059A7 RID: 22951 RVA: 0x0018C27C File Offset: 0x0018A47C
				// Note: this type is marked as 'beforefieldinit'.
				static EtwEnableCallback()
				{
					Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.EtwEnableCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw>.NativeClassPtr, "EtwEnableCallback");
					UnsafeNativeMethods.ManifestEtw.EtwEnableCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.EtwEnableCallback>.NativeClassPtr, 100663892);
					UnsafeNativeMethods.ManifestEtw.EtwEnableCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_Guid_Int32_Byte_Int64_Int64_ptr_EVENT_FILTER_DESCRIPTOR_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.EtwEnableCallback>.NativeClassPtr, 100663893);
					UnsafeNativeMethods.ManifestEtw.EtwEnableCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_Guid_Int32_Byte_Int64_Int64_ptr_EVENT_FILTER_DESCRIPTOR_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.EtwEnableCallback>.NativeClassPtr, 100663894);
					UnsafeNativeMethods.ManifestEtw.EtwEnableCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Guid_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.EtwEnableCallback>.NativeClassPtr, 100663895);
				}

				// Token: 0x060059A8 RID: 22952 RVA: 0x0018C2F0 File Offset: 0x0018A4F0
				[CallerCount(42)]
				[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe EtwEnableCallback(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.EtwEnableCallback>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeNativeMethods.ManifestEtw.EtwEnableCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060059A9 RID: 22953 RVA: 0x0018C34C File Offset: 0x0018A54C
				[CallerCount(0)]
				public unsafe void Invoke([In] ref Guid sourceId, [In] int isEnabled, [In] byte level, [In] long matchAnyKeywords, [In] long matchAllKeywords, [In] UnsafeNativeMethods.ManifestEtw.EVENT_FILTER_DESCRIPTOR* filterData, [In] void* callbackContext)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
						*ptr = &sourceId;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isEnabled;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matchAnyKeywords;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matchAllKeywords;
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = filterData;
					ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = callbackContext;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeNativeMethods.ManifestEtw.EtwEnableCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_Guid_Int32_Byte_Int64_Int64_ptr_EVENT_FILTER_DESCRIPTOR_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060059AA RID: 22954 RVA: 0x0018C3E0 File Offset: 0x0018A5E0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137290, XrefRangeEnd = 137305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke([In] ref Guid sourceId, [In] int isEnabled, [In] byte level, [In] long matchAnyKeywords, [In] long matchAllKeywords, [In] UnsafeNativeMethods.ManifestEtw.EVENT_FILTER_DESCRIPTOR* filterData, [In] void* callbackContext, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
						*ptr = &sourceId;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isEnabled;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matchAnyKeywords;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matchAllKeywords;
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = filterData;
					ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = callbackContext;
					ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeNativeMethods.ManifestEtw.EtwEnableCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_Guid_Int32_Byte_Int64_Int64_ptr_EVENT_FILTER_DESCRIPTOR_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060059AB RID: 22955 RVA: 0x0018C4A8 File Offset: 0x0018A6A8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137305, XrefRangeEnd = 137306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke([In] ref Guid sourceId, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = &sourceId;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeNativeMethods.ManifestEtw.EtwEnableCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Guid_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060059AC RID: 22956 RVA: 0x00022A77 File Offset: 0x00020C77
				public EtwEnableCallback(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04004771 RID: 18289
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04004772 RID: 18290
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_Guid_Int32_Byte_Int64_Int64_ptr_EVENT_FILTER_DESCRIPTOR_ptr_Void_0;

				// Token: 0x04004773 RID: 18291
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_Guid_Int32_Byte_Int64_Int64_ptr_EVENT_FILTER_DESCRIPTOR_ptr_Void_AsyncCallback_Object_0;

				// Token: 0x04004774 RID: 18292
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Guid_IAsyncResult_0;
			}

			// Token: 0x020006C5 RID: 1733
			[StructLayout(2)]
			public struct EVENT_FILTER_DESCRIPTOR
			{
				// Token: 0x060059AD RID: 22957 RVA: 0x0018C4F8 File Offset: 0x0018A6F8
				// Note: this type is marked as 'beforefieldinit'.
				static EVENT_FILTER_DESCRIPTOR()
				{
					Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.EVENT_FILTER_DESCRIPTOR>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw>.NativeClassPtr, "EVENT_FILTER_DESCRIPTOR");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.EVENT_FILTER_DESCRIPTOR>.NativeClassPtr);
					UnsafeNativeMethods.ManifestEtw.EVENT_FILTER_DESCRIPTOR.NativeFieldInfoPtr_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.EVENT_FILTER_DESCRIPTOR>.NativeClassPtr, "Ptr");
					UnsafeNativeMethods.ManifestEtw.EVENT_FILTER_DESCRIPTOR.NativeFieldInfoPtr_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.EVENT_FILTER_DESCRIPTOR>.NativeClassPtr, "Size");
					UnsafeNativeMethods.ManifestEtw.EVENT_FILTER_DESCRIPTOR.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.EVENT_FILTER_DESCRIPTOR>.NativeClassPtr, "Type");
				}

				// Token: 0x060059AE RID: 22958 RVA: 0x00022A80 File Offset: 0x00020C80
				public Object BoxIl2CppObject()
				{
					return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.EVENT_FILTER_DESCRIPTOR>.NativeClassPtr, ref this));
				}

				// Token: 0x04004775 RID: 18293
				private static readonly IntPtr NativeFieldInfoPtr_Ptr;

				// Token: 0x04004776 RID: 18294
				private static readonly IntPtr NativeFieldInfoPtr_Size;

				// Token: 0x04004777 RID: 18295
				private static readonly IntPtr NativeFieldInfoPtr_Type;

				// Token: 0x04004778 RID: 18296
				[FieldOffset(0)]
				public long Ptr;

				// Token: 0x04004779 RID: 18297
				[FieldOffset(8)]
				public int Size;

				// Token: 0x0400477A RID: 18298
				[FieldOffset(12)]
				public int Type;
			}

			// Token: 0x020006C6 RID: 1734
			[OriginalName("mscorlib.dll", "", "ActivityControl")]
			public enum ActivityControl : uint
			{
				// Token: 0x0400477C RID: 18300
				EVENT_ACTIVITY_CTRL_GET_ID = 1U,
				// Token: 0x0400477D RID: 18301
				EVENT_ACTIVITY_CTRL_SET_ID,
				// Token: 0x0400477E RID: 18302
				EVENT_ACTIVITY_CTRL_CREATE_ID,
				// Token: 0x0400477F RID: 18303
				EVENT_ACTIVITY_CTRL_GET_SET_ID,
				// Token: 0x04004780 RID: 18304
				EVENT_ACTIVITY_CTRL_CREATE_SET_ID
			}

			// Token: 0x020006C7 RID: 1735
			[OriginalName("mscorlib.dll", "", "EVENT_INFO_CLASS")]
			public enum EVENT_INFO_CLASS
			{
				// Token: 0x04004782 RID: 18306
				BinaryTrackInfo,
				// Token: 0x04004783 RID: 18307
				SetEnableAllKeywords,
				// Token: 0x04004784 RID: 18308
				SetTraits
			}

			// Token: 0x020006C8 RID: 1736
			[OriginalName("mscorlib.dll", "", "TRACE_QUERY_INFO_CLASS")]
			public enum TRACE_QUERY_INFO_CLASS
			{
				// Token: 0x04004786 RID: 18310
				TraceGuidQueryList,
				// Token: 0x04004787 RID: 18311
				TraceGuidQueryInfo,
				// Token: 0x04004788 RID: 18312
				TraceGuidQueryProcess,
				// Token: 0x04004789 RID: 18313
				TraceStackTracingInfo,
				// Token: 0x0400478A RID: 18314
				MaxTraceSetInfoClass
			}

			// Token: 0x020006C9 RID: 1737
			[StructLayout(2)]
			public struct TRACE_GUID_INFO
			{
				// Token: 0x060059AF RID: 22959 RVA: 0x0018C560 File Offset: 0x0018A760
				// Note: this type is marked as 'beforefieldinit'.
				static TRACE_GUID_INFO()
				{
					Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.TRACE_GUID_INFO>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw>.NativeClassPtr, "TRACE_GUID_INFO");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.TRACE_GUID_INFO>.NativeClassPtr);
					UnsafeNativeMethods.ManifestEtw.TRACE_GUID_INFO.NativeFieldInfoPtr_InstanceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.TRACE_GUID_INFO>.NativeClassPtr, "InstanceCount");
					UnsafeNativeMethods.ManifestEtw.TRACE_GUID_INFO.NativeFieldInfoPtr_Reserved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.TRACE_GUID_INFO>.NativeClassPtr, "Reserved");
				}

				// Token: 0x060059B0 RID: 22960 RVA: 0x00022A92 File Offset: 0x00020C92
				public Object BoxIl2CppObject()
				{
					return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.TRACE_GUID_INFO>.NativeClassPtr, ref this));
				}

				// Token: 0x0400478B RID: 18315
				private static readonly IntPtr NativeFieldInfoPtr_InstanceCount;

				// Token: 0x0400478C RID: 18316
				private static readonly IntPtr NativeFieldInfoPtr_Reserved;

				// Token: 0x0400478D RID: 18317
				[FieldOffset(0)]
				public int InstanceCount;

				// Token: 0x0400478E RID: 18318
				[FieldOffset(4)]
				public int Reserved;
			}

			// Token: 0x020006CA RID: 1738
			[StructLayout(2)]
			public struct TRACE_PROVIDER_INSTANCE_INFO
			{
				// Token: 0x060059B1 RID: 22961 RVA: 0x0018C5B4 File Offset: 0x0018A7B4
				// Note: this type is marked as 'beforefieldinit'.
				static TRACE_PROVIDER_INSTANCE_INFO()
				{
					Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.TRACE_PROVIDER_INSTANCE_INFO>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw>.NativeClassPtr, "TRACE_PROVIDER_INSTANCE_INFO");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.TRACE_PROVIDER_INSTANCE_INFO>.NativeClassPtr);
					UnsafeNativeMethods.ManifestEtw.TRACE_PROVIDER_INSTANCE_INFO.NativeFieldInfoPtr_NextOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.TRACE_PROVIDER_INSTANCE_INFO>.NativeClassPtr, "NextOffset");
					UnsafeNativeMethods.ManifestEtw.TRACE_PROVIDER_INSTANCE_INFO.NativeFieldInfoPtr_EnableCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.TRACE_PROVIDER_INSTANCE_INFO>.NativeClassPtr, "EnableCount");
					UnsafeNativeMethods.ManifestEtw.TRACE_PROVIDER_INSTANCE_INFO.NativeFieldInfoPtr_Pid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.TRACE_PROVIDER_INSTANCE_INFO>.NativeClassPtr, "Pid");
					UnsafeNativeMethods.ManifestEtw.TRACE_PROVIDER_INSTANCE_INFO.NativeFieldInfoPtr_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.TRACE_PROVIDER_INSTANCE_INFO>.NativeClassPtr, "Flags");
				}

				// Token: 0x060059B2 RID: 22962 RVA: 0x00022AA4 File Offset: 0x00020CA4
				public Object BoxIl2CppObject()
				{
					return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.TRACE_PROVIDER_INSTANCE_INFO>.NativeClassPtr, ref this));
				}

				// Token: 0x0400478F RID: 18319
				private static readonly IntPtr NativeFieldInfoPtr_NextOffset;

				// Token: 0x04004790 RID: 18320
				private static readonly IntPtr NativeFieldInfoPtr_EnableCount;

				// Token: 0x04004791 RID: 18321
				private static readonly IntPtr NativeFieldInfoPtr_Pid;

				// Token: 0x04004792 RID: 18322
				private static readonly IntPtr NativeFieldInfoPtr_Flags;

				// Token: 0x04004793 RID: 18323
				[FieldOffset(0)]
				public int NextOffset;

				// Token: 0x04004794 RID: 18324
				[FieldOffset(4)]
				public int EnableCount;

				// Token: 0x04004795 RID: 18325
				[FieldOffset(8)]
				public int Pid;

				// Token: 0x04004796 RID: 18326
				[FieldOffset(12)]
				public int Flags;
			}

			// Token: 0x020006CB RID: 1739
			[StructLayout(2)]
			public struct TRACE_ENABLE_INFO
			{
				// Token: 0x060059B3 RID: 22963 RVA: 0x0018C630 File Offset: 0x0018A830
				// Note: this type is marked as 'beforefieldinit'.
				static TRACE_ENABLE_INFO()
				{
					Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.TRACE_ENABLE_INFO>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw>.NativeClassPtr, "TRACE_ENABLE_INFO");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.TRACE_ENABLE_INFO>.NativeClassPtr);
					UnsafeNativeMethods.ManifestEtw.TRACE_ENABLE_INFO.NativeFieldInfoPtr_IsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.TRACE_ENABLE_INFO>.NativeClassPtr, "IsEnabled");
					UnsafeNativeMethods.ManifestEtw.TRACE_ENABLE_INFO.NativeFieldInfoPtr_Level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.TRACE_ENABLE_INFO>.NativeClassPtr, "Level");
					UnsafeNativeMethods.ManifestEtw.TRACE_ENABLE_INFO.NativeFieldInfoPtr_Reserved1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.TRACE_ENABLE_INFO>.NativeClassPtr, "Reserved1");
					UnsafeNativeMethods.ManifestEtw.TRACE_ENABLE_INFO.NativeFieldInfoPtr_LoggerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.TRACE_ENABLE_INFO>.NativeClassPtr, "LoggerId");
					UnsafeNativeMethods.ManifestEtw.TRACE_ENABLE_INFO.NativeFieldInfoPtr_EnableProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.TRACE_ENABLE_INFO>.NativeClassPtr, "EnableProperty");
					UnsafeNativeMethods.ManifestEtw.TRACE_ENABLE_INFO.NativeFieldInfoPtr_Reserved2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.TRACE_ENABLE_INFO>.NativeClassPtr, "Reserved2");
					UnsafeNativeMethods.ManifestEtw.TRACE_ENABLE_INFO.NativeFieldInfoPtr_MatchAnyKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.TRACE_ENABLE_INFO>.NativeClassPtr, "MatchAnyKeyword");
					UnsafeNativeMethods.ManifestEtw.TRACE_ENABLE_INFO.NativeFieldInfoPtr_MatchAllKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.TRACE_ENABLE_INFO>.NativeClassPtr, "MatchAllKeyword");
				}

				// Token: 0x060059B4 RID: 22964 RVA: 0x00022AB6 File Offset: 0x00020CB6
				public Object BoxIl2CppObject()
				{
					return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.TRACE_ENABLE_INFO>.NativeClassPtr, ref this));
				}

				// Token: 0x04004797 RID: 18327
				private static readonly IntPtr NativeFieldInfoPtr_IsEnabled;

				// Token: 0x04004798 RID: 18328
				private static readonly IntPtr NativeFieldInfoPtr_Level;

				// Token: 0x04004799 RID: 18329
				private static readonly IntPtr NativeFieldInfoPtr_Reserved1;

				// Token: 0x0400479A RID: 18330
				private static readonly IntPtr NativeFieldInfoPtr_LoggerId;

				// Token: 0x0400479B RID: 18331
				private static readonly IntPtr NativeFieldInfoPtr_EnableProperty;

				// Token: 0x0400479C RID: 18332
				private static readonly IntPtr NativeFieldInfoPtr_Reserved2;

				// Token: 0x0400479D RID: 18333
				private static readonly IntPtr NativeFieldInfoPtr_MatchAnyKeyword;

				// Token: 0x0400479E RID: 18334
				private static readonly IntPtr NativeFieldInfoPtr_MatchAllKeyword;

				// Token: 0x0400479F RID: 18335
				[FieldOffset(0)]
				public int IsEnabled;

				// Token: 0x040047A0 RID: 18336
				[FieldOffset(4)]
				public byte Level;

				// Token: 0x040047A1 RID: 18337
				[FieldOffset(5)]
				public byte Reserved1;

				// Token: 0x040047A2 RID: 18338
				[FieldOffset(6)]
				public ushort LoggerId;

				// Token: 0x040047A3 RID: 18339
				[FieldOffset(8)]
				public int EnableProperty;

				// Token: 0x040047A4 RID: 18340
				[FieldOffset(12)]
				public int Reserved2;

				// Token: 0x040047A5 RID: 18341
				[FieldOffset(16)]
				public long MatchAnyKeyword;

				// Token: 0x040047A6 RID: 18342
				[FieldOffset(24)]
				public long MatchAllKeyword;
			}
		}
	}
}
