using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Windows.WebCam
{
	// Token: 0x0200011C RID: 284
	public class VideoCapture : Object
	{
		// Token: 0x06001779 RID: 6009 RVA: 0x0005AA14 File Offset: 0x00058C14
		// Note: this type is marked as 'beforefieldinit'.
		static VideoCapture()
		{
			Il2CppClassPointerStore<VideoCapture>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Windows.WebCam", "VideoCapture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr);
			VideoCapture.NativeFieldInfoPtr_m_NativePtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, "m_NativePtr");
			VideoCapture.NativeFieldInfoPtr_HR_SUCCESS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, "HR_SUCCESS");
			VideoCapture.NativeMethodInfoPtr_MakeCaptureResult_Private_Static_VideoCaptureResult_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100665430);
			VideoCapture.NativeMethodInfoPtr_InvokeOnCreatedVideoCaptureResourceDelegate_Private_Static_Void_OnVideoCaptureResourceCreatedCallback_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100665431);
			VideoCapture.NativeMethodInfoPtr_InvokeOnVideoModeStartedDelegate_Private_Static_Void_OnVideoModeStartedCallback_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100665433);
			VideoCapture.NativeMethodInfoPtr_InvokeOnVideoModeStoppedDelegate_Private_Static_Void_OnVideoModeStoppedCallback_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100665434);
			VideoCapture.NativeMethodInfoPtr_InvokeOnStartedRecordingVideoToDiskDelegate_Private_Static_Void_OnStartedRecordingVideoCallback_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100665435);
			VideoCapture.NativeMethodInfoPtr_InvokeOnStoppedRecordingVideoToDiskDelegate_Private_Static_Void_OnStoppedRecordingVideoCallback_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100665436);
			VideoCapture.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100665437);
			VideoCapture.NativeMethodInfoPtr_Dispose_Internal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100665438);
			VideoCapture.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100665439);
			VideoCapture.NativeMethodInfoPtr_DisposeThreaded_Internal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100665440);
		}

		// Token: 0x0600177A RID: 6010 RVA: 0x0005AB34 File Offset: 0x00058D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500579, XrefRangeEnd = 500583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static VideoCapture.VideoCaptureResult MakeCaptureResult(long hResult)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hResult;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.NativeMethodInfoPtr_MakeCaptureResult_Private_Static_VideoCaptureResult_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600177B RID: 6011 RVA: 0x0005AB74 File Offset: 0x00058D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500583, XrefRangeEnd = 500588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnCreatedVideoCaptureResourceDelegate(VideoCapture.OnVideoCaptureResourceCreatedCallback callback, IntPtr nativePtr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nativePtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.NativeMethodInfoPtr_InvokeOnCreatedVideoCaptureResourceDelegate_Private_Static_Void_OnVideoCaptureResourceCreatedCallback_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600177C RID: 6012 RVA: 0x0005ABB8 File Offset: 0x00058DB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500588, XrefRangeEnd = 500597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnVideoModeStartedDelegate(VideoCapture.OnVideoModeStartedCallback callback, long hResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hResult;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.NativeMethodInfoPtr_InvokeOnVideoModeStartedDelegate_Private_Static_Void_OnVideoModeStartedCallback_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600177D RID: 6013 RVA: 0x0005ABFC File Offset: 0x00058DFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500597, XrefRangeEnd = 500606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnVideoModeStoppedDelegate(VideoCapture.OnVideoModeStoppedCallback callback, long hResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hResult;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.NativeMethodInfoPtr_InvokeOnVideoModeStoppedDelegate_Private_Static_Void_OnVideoModeStoppedCallback_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600177E RID: 6014 RVA: 0x0005AC40 File Offset: 0x00058E40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500606, XrefRangeEnd = 500615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnStartedRecordingVideoToDiskDelegate(VideoCapture.OnStartedRecordingVideoCallback callback, long hResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hResult;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.NativeMethodInfoPtr_InvokeOnStartedRecordingVideoToDiskDelegate_Private_Static_Void_OnStartedRecordingVideoCallback_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600177F RID: 6015 RVA: 0x0005AC84 File Offset: 0x00058E84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500615, XrefRangeEnd = 500624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnStoppedRecordingVideoToDiskDelegate(VideoCapture.OnStoppedRecordingVideoCallback callback, long hResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hResult;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.NativeMethodInfoPtr_InvokeOnStoppedRecordingVideoToDiskDelegate_Private_Static_Void_OnStoppedRecordingVideoCallback_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001780 RID: 6016 RVA: 0x0005ACC8 File Offset: 0x00058EC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500624, XrefRangeEnd = 500633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001781 RID: 6017 RVA: 0x0005ACFC File Offset: 0x00058EFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500633, XrefRangeEnd = 500637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose_Internal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.NativeMethodInfoPtr_Dispose_Internal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001782 RID: 6018 RVA: 0x0005AD30 File Offset: 0x00058F30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500637, XrefRangeEnd = 500641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VideoCapture.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001783 RID: 6019 RVA: 0x0005AD6C File Offset: 0x00058F6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500641, XrefRangeEnd = 500647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisposeThreaded_Internal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.NativeMethodInfoPtr_DisposeThreaded_Internal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001784 RID: 6020 RVA: 0x0000C884 File Offset: 0x0000AA84
		public VideoCapture(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06001785 RID: 6021 RVA: 0x0005ADA0 File Offset: 0x00058FA0
		// (set) Token: 0x06001786 RID: 6022 RVA: 0x0000C88D File Offset: 0x0000AA8D
		public unsafe IntPtr m_NativePtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VideoCapture.NativeFieldInfoPtr_m_NativePtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VideoCapture.NativeFieldInfoPtr_m_NativePtr)) = value;
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06001787 RID: 6023 RVA: 0x0005ADC8 File Offset: 0x00058FC8
		// (set) Token: 0x06001788 RID: 6024 RVA: 0x0000C8A8 File Offset: 0x0000AAA8
		public unsafe static long HR_SUCCESS
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(VideoCapture.NativeFieldInfoPtr_HR_SUCCESS, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VideoCapture.NativeFieldInfoPtr_HR_SUCCESS, (void*)(&value));
			}
		}

		// Token: 0x0400125D RID: 4701
		private static readonly IntPtr NativeFieldInfoPtr_m_NativePtr;

		// Token: 0x0400125E RID: 4702
		private static readonly IntPtr NativeFieldInfoPtr_HR_SUCCESS;

		// Token: 0x0400125F RID: 4703
		private static readonly IntPtr NativeMethodInfoPtr_MakeCaptureResult_Private_Static_VideoCaptureResult_Int64_0;

		// Token: 0x04001260 RID: 4704
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnCreatedVideoCaptureResourceDelegate_Private_Static_Void_OnVideoCaptureResourceCreatedCallback_IntPtr_0;

		// Token: 0x04001261 RID: 4705
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnVideoModeStartedDelegate_Private_Static_Void_OnVideoModeStartedCallback_Int64_0;

		// Token: 0x04001262 RID: 4706
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnVideoModeStoppedDelegate_Private_Static_Void_OnVideoModeStoppedCallback_Int64_0;

		// Token: 0x04001263 RID: 4707
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnStartedRecordingVideoToDiskDelegate_Private_Static_Void_OnStartedRecordingVideoCallback_Int64_0;

		// Token: 0x04001264 RID: 4708
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnStoppedRecordingVideoToDiskDelegate_Private_Static_Void_OnStoppedRecordingVideoCallback_Int64_0;

		// Token: 0x04001265 RID: 4709
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001266 RID: 4710
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Internal_Private_Void_0;

		// Token: 0x04001267 RID: 4711
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04001268 RID: 4712
		private static readonly IntPtr NativeMethodInfoPtr_DisposeThreaded_Internal_Private_Void_0;

		// Token: 0x0200089E RID: 2206
		[OriginalName("UnityEngine.CoreModule.dll", "", "CaptureResultType")]
		public enum CaptureResultType
		{
			// Token: 0x04001F84 RID: 8068
			Success,
			// Token: 0x04001F85 RID: 8069
			UnknownError
		}

		// Token: 0x0200089F RID: 2207
		[StructLayout(2)]
		public struct VideoCaptureResult
		{
			// Token: 0x06002F96 RID: 12182 RVA: 0x0007E0F0 File Offset: 0x0007C2F0
			// Note: this type is marked as 'beforefieldinit'.
			static VideoCaptureResult()
			{
				Il2CppClassPointerStore<VideoCapture.VideoCaptureResult>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, "VideoCaptureResult");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VideoCapture.VideoCaptureResult>.NativeClassPtr);
				VideoCapture.VideoCaptureResult.NativeFieldInfoPtr_resultType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoCapture.VideoCaptureResult>.NativeClassPtr, "resultType");
				VideoCapture.VideoCaptureResult.NativeFieldInfoPtr_hResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoCapture.VideoCaptureResult>.NativeClassPtr, "hResult");
			}

			// Token: 0x06002F97 RID: 12183 RVA: 0x00013B86 File Offset: 0x00011D86
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VideoCapture.VideoCaptureResult>.NativeClassPtr, ref this));
			}

			// Token: 0x04001F86 RID: 8070
			private static readonly IntPtr NativeFieldInfoPtr_resultType;

			// Token: 0x04001F87 RID: 8071
			private static readonly IntPtr NativeFieldInfoPtr_hResult;

			// Token: 0x04001F88 RID: 8072
			[FieldOffset(0)]
			public VideoCapture.CaptureResultType resultType;

			// Token: 0x04001F89 RID: 8073
			[FieldOffset(8)]
			public long hResult;
		}

		// Token: 0x020008A0 RID: 2208
		public sealed class OnVideoCaptureResourceCreatedCallback : MulticastDelegate
		{
			// Token: 0x06002F98 RID: 12184 RVA: 0x0007E144 File Offset: 0x0007C344
			// Note: this type is marked as 'beforefieldinit'.
			static OnVideoCaptureResourceCreatedCallback()
			{
				Il2CppClassPointerStore<VideoCapture.OnVideoCaptureResourceCreatedCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, "OnVideoCaptureResourceCreatedCallback");
				VideoCapture.OnVideoCaptureResourceCreatedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnVideoCaptureResourceCreatedCallback>.NativeClassPtr, 100665442);
				VideoCapture.OnVideoCaptureResourceCreatedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCapture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnVideoCaptureResourceCreatedCallback>.NativeClassPtr, 100665443);
				VideoCapture.OnVideoCaptureResourceCreatedCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_VideoCapture_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnVideoCaptureResourceCreatedCallback>.NativeClassPtr, 100665444);
				VideoCapture.OnVideoCaptureResourceCreatedCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnVideoCaptureResourceCreatedCallback>.NativeClassPtr, 100665445);
			}

			// Token: 0x06002F99 RID: 12185 RVA: 0x0007E1B8 File Offset: 0x0007C3B8
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnVideoCaptureResourceCreatedCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VideoCapture.OnVideoCaptureResourceCreatedCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnVideoCaptureResourceCreatedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F9A RID: 12186 RVA: 0x0007E214 File Offset: 0x0007C414
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 1006, RefRangeEnd = 1022, XrefRangeStart = 1006, XrefRangeEnd = 1022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(VideoCapture captureObject)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(captureObject);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnVideoCaptureResourceCreatedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCapture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002F9B RID: 12187 RVA: 0x0007E258 File Offset: 0x0007C458
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(VideoCapture captureObject, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(captureObject);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnVideoCaptureResourceCreatedCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_VideoCapture_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06002F9C RID: 12188 RVA: 0x0007E2CC File Offset: 0x0007C4CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnVideoCaptureResourceCreatedCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002F9D RID: 12189 RVA: 0x00013B98 File Offset: 0x00011D98
			public OnVideoCaptureResourceCreatedCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002F9E RID: 12190 RVA: 0x00013BA1 File Offset: 0x00011DA1
			public static implicit operator VideoCapture.OnVideoCaptureResourceCreatedCallback(Action<VideoCapture> A_0)
			{
				return DelegateSupport.ConvertDelegate<VideoCapture.OnVideoCaptureResourceCreatedCallback>(A_0);
			}

			// Token: 0x06002F9F RID: 12191 RVA: 0x00013BA9 File Offset: 0x00011DA9
			public static VideoCapture.OnVideoCaptureResourceCreatedCallback operator +(VideoCapture.OnVideoCaptureResourceCreatedCallback A_0, VideoCapture.OnVideoCaptureResourceCreatedCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<VideoCapture.OnVideoCaptureResourceCreatedCallback>();
			}

			// Token: 0x06002FA0 RID: 12192 RVA: 0x00013BB7 File Offset: 0x00011DB7
			public static VideoCapture.OnVideoCaptureResourceCreatedCallback operator -(VideoCapture.OnVideoCaptureResourceCreatedCallback A_0, VideoCapture.OnVideoCaptureResourceCreatedCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<VideoCapture.OnVideoCaptureResourceCreatedCallback>();
				}
				return delegate2;
			}

			// Token: 0x04001F8A RID: 8074
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001F8B RID: 8075
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCapture_0;

			// Token: 0x04001F8C RID: 8076
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_VideoCapture_AsyncCallback_Object_0;

			// Token: 0x04001F8D RID: 8077
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020008A1 RID: 2209
		public sealed class OnVideoModeStartedCallback : MulticastDelegate
		{
			// Token: 0x06002FA1 RID: 12193 RVA: 0x0007E310 File Offset: 0x0007C510
			// Note: this type is marked as 'beforefieldinit'.
			static OnVideoModeStartedCallback()
			{
				Il2CppClassPointerStore<VideoCapture.OnVideoModeStartedCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, "OnVideoModeStartedCallback");
				VideoCapture.OnVideoModeStartedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnVideoModeStartedCallback>.NativeClassPtr, 100665446);
				VideoCapture.OnVideoModeStartedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnVideoModeStartedCallback>.NativeClassPtr, 100665447);
				VideoCapture.OnVideoModeStartedCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_VideoCaptureResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnVideoModeStartedCallback>.NativeClassPtr, 100665448);
				VideoCapture.OnVideoModeStartedCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnVideoModeStartedCallback>.NativeClassPtr, 100665449);
			}

			// Token: 0x06002FA2 RID: 12194 RVA: 0x0007E384 File Offset: 0x0007C584
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnVideoModeStartedCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VideoCapture.OnVideoModeStartedCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnVideoModeStartedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002FA3 RID: 12195 RVA: 0x0007E3E0 File Offset: 0x0007C5E0
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 500418, RefRangeEnd = 500425, XrefRangeStart = 500418, XrefRangeEnd = 500425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(VideoCapture.VideoCaptureResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref result;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnVideoModeStartedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002FA4 RID: 12196 RVA: 0x0007E420 File Offset: 0x0007C620
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500563, XrefRangeEnd = 500567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(VideoCapture.VideoCaptureResult result, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref result;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnVideoModeStartedCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_VideoCaptureResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06002FA5 RID: 12197 RVA: 0x0007E490 File Offset: 0x0007C690
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnVideoModeStartedCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002FA6 RID: 12198 RVA: 0x00013BC8 File Offset: 0x00011DC8
			public OnVideoModeStartedCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002FA7 RID: 12199 RVA: 0x00013BD1 File Offset: 0x00011DD1
			public static implicit operator VideoCapture.OnVideoModeStartedCallback(Action<VideoCapture.VideoCaptureResult> A_0)
			{
				return DelegateSupport.ConvertDelegate<VideoCapture.OnVideoModeStartedCallback>(A_0);
			}

			// Token: 0x06002FA8 RID: 12200 RVA: 0x00013BD9 File Offset: 0x00011DD9
			public static VideoCapture.OnVideoModeStartedCallback operator +(VideoCapture.OnVideoModeStartedCallback A_0, VideoCapture.OnVideoModeStartedCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<VideoCapture.OnVideoModeStartedCallback>();
			}

			// Token: 0x06002FA9 RID: 12201 RVA: 0x00013BE7 File Offset: 0x00011DE7
			public static VideoCapture.OnVideoModeStartedCallback operator -(VideoCapture.OnVideoModeStartedCallback A_0, VideoCapture.OnVideoModeStartedCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<VideoCapture.OnVideoModeStartedCallback>();
				}
				return delegate2;
			}

			// Token: 0x04001F8E RID: 8078
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001F8F RID: 8079
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0;

			// Token: 0x04001F90 RID: 8080
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_VideoCaptureResult_AsyncCallback_Object_0;

			// Token: 0x04001F91 RID: 8081
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020008A2 RID: 2210
		public sealed class OnVideoModeStoppedCallback : MulticastDelegate
		{
			// Token: 0x06002FAA RID: 12202 RVA: 0x0007E4D4 File Offset: 0x0007C6D4
			// Note: this type is marked as 'beforefieldinit'.
			static OnVideoModeStoppedCallback()
			{
				Il2CppClassPointerStore<VideoCapture.OnVideoModeStoppedCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, "OnVideoModeStoppedCallback");
				VideoCapture.OnVideoModeStoppedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnVideoModeStoppedCallback>.NativeClassPtr, 100665450);
				VideoCapture.OnVideoModeStoppedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnVideoModeStoppedCallback>.NativeClassPtr, 100665451);
				VideoCapture.OnVideoModeStoppedCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_VideoCaptureResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnVideoModeStoppedCallback>.NativeClassPtr, 100665452);
				VideoCapture.OnVideoModeStoppedCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnVideoModeStoppedCallback>.NativeClassPtr, 100665453);
			}

			// Token: 0x06002FAB RID: 12203 RVA: 0x0007E548 File Offset: 0x0007C748
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnVideoModeStoppedCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VideoCapture.OnVideoModeStoppedCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnVideoModeStoppedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002FAC RID: 12204 RVA: 0x0007E5A4 File Offset: 0x0007C7A4
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 500418, RefRangeEnd = 500425, XrefRangeStart = 500418, XrefRangeEnd = 500425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(VideoCapture.VideoCaptureResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref result;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnVideoModeStoppedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002FAD RID: 12205 RVA: 0x0007E5E4 File Offset: 0x0007C7E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500567, XrefRangeEnd = 500571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(VideoCapture.VideoCaptureResult result, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref result;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnVideoModeStoppedCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_VideoCaptureResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06002FAE RID: 12206 RVA: 0x0007E654 File Offset: 0x0007C854
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnVideoModeStoppedCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002FAF RID: 12207 RVA: 0x00013BF8 File Offset: 0x00011DF8
			public OnVideoModeStoppedCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002FB0 RID: 12208 RVA: 0x00013C01 File Offset: 0x00011E01
			public static implicit operator VideoCapture.OnVideoModeStoppedCallback(Action<VideoCapture.VideoCaptureResult> A_0)
			{
				return DelegateSupport.ConvertDelegate<VideoCapture.OnVideoModeStoppedCallback>(A_0);
			}

			// Token: 0x06002FB1 RID: 12209 RVA: 0x00013C09 File Offset: 0x00011E09
			public static VideoCapture.OnVideoModeStoppedCallback operator +(VideoCapture.OnVideoModeStoppedCallback A_0, VideoCapture.OnVideoModeStoppedCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<VideoCapture.OnVideoModeStoppedCallback>();
			}

			// Token: 0x06002FB2 RID: 12210 RVA: 0x00013C17 File Offset: 0x00011E17
			public static VideoCapture.OnVideoModeStoppedCallback operator -(VideoCapture.OnVideoModeStoppedCallback A_0, VideoCapture.OnVideoModeStoppedCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<VideoCapture.OnVideoModeStoppedCallback>();
				}
				return delegate2;
			}

			// Token: 0x04001F92 RID: 8082
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001F93 RID: 8083
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0;

			// Token: 0x04001F94 RID: 8084
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_VideoCaptureResult_AsyncCallback_Object_0;

			// Token: 0x04001F95 RID: 8085
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020008A3 RID: 2211
		public sealed class OnStartedRecordingVideoCallback : MulticastDelegate
		{
			// Token: 0x06002FB3 RID: 12211 RVA: 0x0007E698 File Offset: 0x0007C898
			// Note: this type is marked as 'beforefieldinit'.
			static OnStartedRecordingVideoCallback()
			{
				Il2CppClassPointerStore<VideoCapture.OnStartedRecordingVideoCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, "OnStartedRecordingVideoCallback");
				VideoCapture.OnStartedRecordingVideoCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnStartedRecordingVideoCallback>.NativeClassPtr, 100665454);
				VideoCapture.OnStartedRecordingVideoCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnStartedRecordingVideoCallback>.NativeClassPtr, 100665455);
				VideoCapture.OnStartedRecordingVideoCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_VideoCaptureResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnStartedRecordingVideoCallback>.NativeClassPtr, 100665456);
				VideoCapture.OnStartedRecordingVideoCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnStartedRecordingVideoCallback>.NativeClassPtr, 100665457);
			}

			// Token: 0x06002FB4 RID: 12212 RVA: 0x0007E70C File Offset: 0x0007C90C
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnStartedRecordingVideoCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VideoCapture.OnStartedRecordingVideoCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnStartedRecordingVideoCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002FB5 RID: 12213 RVA: 0x0007E768 File Offset: 0x0007C968
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 500418, RefRangeEnd = 500425, XrefRangeStart = 500418, XrefRangeEnd = 500425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(VideoCapture.VideoCaptureResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref result;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnStartedRecordingVideoCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002FB6 RID: 12214 RVA: 0x0007E7A8 File Offset: 0x0007C9A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500571, XrefRangeEnd = 500575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(VideoCapture.VideoCaptureResult result, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref result;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnStartedRecordingVideoCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_VideoCaptureResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06002FB7 RID: 12215 RVA: 0x0007E818 File Offset: 0x0007CA18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnStartedRecordingVideoCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002FB8 RID: 12216 RVA: 0x00013C28 File Offset: 0x00011E28
			public OnStartedRecordingVideoCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002FB9 RID: 12217 RVA: 0x00013C31 File Offset: 0x00011E31
			public static implicit operator VideoCapture.OnStartedRecordingVideoCallback(Action<VideoCapture.VideoCaptureResult> A_0)
			{
				return DelegateSupport.ConvertDelegate<VideoCapture.OnStartedRecordingVideoCallback>(A_0);
			}

			// Token: 0x06002FBA RID: 12218 RVA: 0x00013C39 File Offset: 0x00011E39
			public static VideoCapture.OnStartedRecordingVideoCallback operator +(VideoCapture.OnStartedRecordingVideoCallback A_0, VideoCapture.OnStartedRecordingVideoCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<VideoCapture.OnStartedRecordingVideoCallback>();
			}

			// Token: 0x06002FBB RID: 12219 RVA: 0x00013C47 File Offset: 0x00011E47
			public static VideoCapture.OnStartedRecordingVideoCallback operator -(VideoCapture.OnStartedRecordingVideoCallback A_0, VideoCapture.OnStartedRecordingVideoCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<VideoCapture.OnStartedRecordingVideoCallback>();
				}
				return delegate2;
			}

			// Token: 0x04001F96 RID: 8086
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001F97 RID: 8087
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0;

			// Token: 0x04001F98 RID: 8088
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_VideoCaptureResult_AsyncCallback_Object_0;

			// Token: 0x04001F99 RID: 8089
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020008A4 RID: 2212
		public sealed class OnStoppedRecordingVideoCallback : MulticastDelegate
		{
			// Token: 0x06002FBC RID: 12220 RVA: 0x0007E85C File Offset: 0x0007CA5C
			// Note: this type is marked as 'beforefieldinit'.
			static OnStoppedRecordingVideoCallback()
			{
				Il2CppClassPointerStore<VideoCapture.OnStoppedRecordingVideoCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, "OnStoppedRecordingVideoCallback");
				VideoCapture.OnStoppedRecordingVideoCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnStoppedRecordingVideoCallback>.NativeClassPtr, 100665458);
				VideoCapture.OnStoppedRecordingVideoCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnStoppedRecordingVideoCallback>.NativeClassPtr, 100665459);
				VideoCapture.OnStoppedRecordingVideoCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_VideoCaptureResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnStoppedRecordingVideoCallback>.NativeClassPtr, 100665460);
				VideoCapture.OnStoppedRecordingVideoCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnStoppedRecordingVideoCallback>.NativeClassPtr, 100665461);
			}

			// Token: 0x06002FBD RID: 12221 RVA: 0x0007E8D0 File Offset: 0x0007CAD0
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnStoppedRecordingVideoCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VideoCapture.OnStoppedRecordingVideoCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnStoppedRecordingVideoCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002FBE RID: 12222 RVA: 0x0007E92C File Offset: 0x0007CB2C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 500418, RefRangeEnd = 500425, XrefRangeStart = 500418, XrefRangeEnd = 500425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(VideoCapture.VideoCaptureResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref result;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnStoppedRecordingVideoCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002FBF RID: 12223 RVA: 0x0007E96C File Offset: 0x0007CB6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500575, XrefRangeEnd = 500579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(VideoCapture.VideoCaptureResult result, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref result;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnStoppedRecordingVideoCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_VideoCaptureResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06002FC0 RID: 12224 RVA: 0x0007E9DC File Offset: 0x0007CBDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnStoppedRecordingVideoCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002FC1 RID: 12225 RVA: 0x00013C58 File Offset: 0x00011E58
			public OnStoppedRecordingVideoCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002FC2 RID: 12226 RVA: 0x00013C61 File Offset: 0x00011E61
			public static implicit operator VideoCapture.OnStoppedRecordingVideoCallback(Action<VideoCapture.VideoCaptureResult> A_0)
			{
				return DelegateSupport.ConvertDelegate<VideoCapture.OnStoppedRecordingVideoCallback>(A_0);
			}

			// Token: 0x06002FC3 RID: 12227 RVA: 0x00013C69 File Offset: 0x00011E69
			public static VideoCapture.OnStoppedRecordingVideoCallback operator +(VideoCapture.OnStoppedRecordingVideoCallback A_0, VideoCapture.OnStoppedRecordingVideoCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<VideoCapture.OnStoppedRecordingVideoCallback>();
			}

			// Token: 0x06002FC4 RID: 12228 RVA: 0x00013C77 File Offset: 0x00011E77
			public static VideoCapture.OnStoppedRecordingVideoCallback operator -(VideoCapture.OnStoppedRecordingVideoCallback A_0, VideoCapture.OnStoppedRecordingVideoCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<VideoCapture.OnStoppedRecordingVideoCallback>();
				}
				return delegate2;
			}

			// Token: 0x04001F9A RID: 8090
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001F9B RID: 8091
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0;

			// Token: 0x04001F9C RID: 8092
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_VideoCaptureResult_AsyncCallback_Object_0;

			// Token: 0x04001F9D RID: 8093
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
