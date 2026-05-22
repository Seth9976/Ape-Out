using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Windows.WebCam
{
	// Token: 0x0200011A RID: 282
	public class PhotoCapture : Object
	{
		// Token: 0x06001754 RID: 5972 RVA: 0x0005A1B8 File Offset: 0x000583B8
		// Note: this type is marked as 'beforefieldinit'.
		static PhotoCapture()
		{
			Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Windows.WebCam", "PhotoCapture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr);
			PhotoCapture.NativeFieldInfoPtr_m_NativePtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, "m_NativePtr");
			PhotoCapture.NativeFieldInfoPtr_HR_SUCCESS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, "HR_SUCCESS");
			PhotoCapture.NativeMethodInfoPtr_MakeCaptureResult_Private_Static_PhotoCaptureResult_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100665386);
			PhotoCapture.NativeMethodInfoPtr_InvokeOnCreatedResourceDelegate_Private_Static_Void_OnCaptureResourceCreatedCallback_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100665387);
			PhotoCapture.NativeMethodInfoPtr_InvokeOnPhotoModeStartedDelegate_Private_Static_Void_OnPhotoModeStartedCallback_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100665389);
			PhotoCapture.NativeMethodInfoPtr_InvokeOnPhotoModeStoppedDelegate_Private_Static_Void_OnPhotoModeStoppedCallback_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100665390);
			PhotoCapture.NativeMethodInfoPtr_InvokeOnCapturedPhotoToDiskDelegate_Private_Static_Void_OnCapturedToDiskCallback_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100665391);
			PhotoCapture.NativeMethodInfoPtr_InvokeOnCapturedPhotoToMemoryDelegate_Private_Static_Void_OnCapturedToMemoryCallback_Int64_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100665392);
			PhotoCapture.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100665393);
			PhotoCapture.NativeMethodInfoPtr_Dispose_Internal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100665394);
			PhotoCapture.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100665395);
			PhotoCapture.NativeMethodInfoPtr_DisposeThreaded_Internal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100665396);
		}

		// Token: 0x06001755 RID: 5973 RVA: 0x0005A2D8 File Offset: 0x000584D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500442, XrefRangeEnd = 500446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PhotoCapture.PhotoCaptureResult MakeCaptureResult(long hResult)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hResult;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.NativeMethodInfoPtr_MakeCaptureResult_Private_Static_PhotoCaptureResult_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001756 RID: 5974 RVA: 0x0005A318 File Offset: 0x00058518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500446, XrefRangeEnd = 500451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnCreatedResourceDelegate(PhotoCapture.OnCaptureResourceCreatedCallback callback, IntPtr nativePtr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nativePtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.NativeMethodInfoPtr_InvokeOnCreatedResourceDelegate_Private_Static_Void_OnCaptureResourceCreatedCallback_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001757 RID: 5975 RVA: 0x0005A35C File Offset: 0x0005855C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500451, XrefRangeEnd = 500460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnPhotoModeStartedDelegate(PhotoCapture.OnPhotoModeStartedCallback callback, long hResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hResult;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.NativeMethodInfoPtr_InvokeOnPhotoModeStartedDelegate_Private_Static_Void_OnPhotoModeStartedCallback_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001758 RID: 5976 RVA: 0x0005A3A0 File Offset: 0x000585A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500460, XrefRangeEnd = 500469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnPhotoModeStoppedDelegate(PhotoCapture.OnPhotoModeStoppedCallback callback, long hResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hResult;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.NativeMethodInfoPtr_InvokeOnPhotoModeStoppedDelegate_Private_Static_Void_OnPhotoModeStoppedCallback_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001759 RID: 5977 RVA: 0x0005A3E4 File Offset: 0x000585E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500469, XrefRangeEnd = 500478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnCapturedPhotoToDiskDelegate(PhotoCapture.OnCapturedToDiskCallback callback, long hResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hResult;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.NativeMethodInfoPtr_InvokeOnCapturedPhotoToDiskDelegate_Private_Static_Void_OnCapturedToDiskCallback_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600175A RID: 5978 RVA: 0x0005A428 File Offset: 0x00058628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500478, XrefRangeEnd = 500492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnCapturedPhotoToMemoryDelegate(PhotoCapture.OnCapturedToMemoryCallback callback, long hResult, IntPtr photoCaptureFramePtr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hResult;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref photoCaptureFramePtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.NativeMethodInfoPtr_InvokeOnCapturedPhotoToMemoryDelegate_Private_Static_Void_OnCapturedToMemoryCallback_Int64_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600175B RID: 5979 RVA: 0x0005A47C File Offset: 0x0005867C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500492, XrefRangeEnd = 500501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600175C RID: 5980 RVA: 0x0005A4B0 File Offset: 0x000586B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500501, XrefRangeEnd = 500505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose_Internal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.NativeMethodInfoPtr_Dispose_Internal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600175D RID: 5981 RVA: 0x0005A4E4 File Offset: 0x000586E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500505, XrefRangeEnd = 500509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PhotoCapture.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600175E RID: 5982 RVA: 0x0005A520 File Offset: 0x00058720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500509, XrefRangeEnd = 500515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisposeThreaded_Internal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.NativeMethodInfoPtr_DisposeThreaded_Internal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600175F RID: 5983 RVA: 0x0000C7DD File Offset: 0x0000A9DD
		public PhotoCapture(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06001760 RID: 5984 RVA: 0x0005A554 File Offset: 0x00058754
		// (set) Token: 0x06001761 RID: 5985 RVA: 0x0000C7E6 File Offset: 0x0000A9E6
		public unsafe IntPtr m_NativePtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhotoCapture.NativeFieldInfoPtr_m_NativePtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhotoCapture.NativeFieldInfoPtr_m_NativePtr)) = value;
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06001762 RID: 5986 RVA: 0x0005A57C File Offset: 0x0005877C
		// (set) Token: 0x06001763 RID: 5987 RVA: 0x0000C801 File Offset: 0x0000AA01
		public unsafe static long HR_SUCCESS
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(PhotoCapture.NativeFieldInfoPtr_HR_SUCCESS, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PhotoCapture.NativeFieldInfoPtr_HR_SUCCESS, (void*)(&value));
			}
		}

		// Token: 0x04001242 RID: 4674
		private static readonly IntPtr NativeFieldInfoPtr_m_NativePtr;

		// Token: 0x04001243 RID: 4675
		private static readonly IntPtr NativeFieldInfoPtr_HR_SUCCESS;

		// Token: 0x04001244 RID: 4676
		private static readonly IntPtr NativeMethodInfoPtr_MakeCaptureResult_Private_Static_PhotoCaptureResult_Int64_0;

		// Token: 0x04001245 RID: 4677
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnCreatedResourceDelegate_Private_Static_Void_OnCaptureResourceCreatedCallback_IntPtr_0;

		// Token: 0x04001246 RID: 4678
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnPhotoModeStartedDelegate_Private_Static_Void_OnPhotoModeStartedCallback_Int64_0;

		// Token: 0x04001247 RID: 4679
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnPhotoModeStoppedDelegate_Private_Static_Void_OnPhotoModeStoppedCallback_Int64_0;

		// Token: 0x04001248 RID: 4680
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnCapturedPhotoToDiskDelegate_Private_Static_Void_OnCapturedToDiskCallback_Int64_0;

		// Token: 0x04001249 RID: 4681
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnCapturedPhotoToMemoryDelegate_Private_Static_Void_OnCapturedToMemoryCallback_Int64_IntPtr_0;

		// Token: 0x0400124A RID: 4682
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400124B RID: 4683
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Internal_Private_Void_0;

		// Token: 0x0400124C RID: 4684
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x0400124D RID: 4685
		private static readonly IntPtr NativeMethodInfoPtr_DisposeThreaded_Internal_Private_Void_0;

		// Token: 0x02000897 RID: 2199
		[OriginalName("UnityEngine.CoreModule.dll", "", "CaptureResultType")]
		public enum CaptureResultType
		{
			// Token: 0x04001F69 RID: 8041
			Success,
			// Token: 0x04001F6A RID: 8042
			UnknownError
		}

		// Token: 0x02000898 RID: 2200
		[StructLayout(2)]
		public struct PhotoCaptureResult
		{
			// Token: 0x06002F67 RID: 12135 RVA: 0x0007D79C File Offset: 0x0007B99C
			// Note: this type is marked as 'beforefieldinit'.
			static PhotoCaptureResult()
			{
				Il2CppClassPointerStore<PhotoCapture.PhotoCaptureResult>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, "PhotoCaptureResult");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhotoCapture.PhotoCaptureResult>.NativeClassPtr);
				PhotoCapture.PhotoCaptureResult.NativeFieldInfoPtr_resultType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoCapture.PhotoCaptureResult>.NativeClassPtr, "resultType");
				PhotoCapture.PhotoCaptureResult.NativeFieldInfoPtr_hResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoCapture.PhotoCaptureResult>.NativeClassPtr, "hResult");
			}

			// Token: 0x06002F68 RID: 12136 RVA: 0x00013A84 File Offset: 0x00011C84
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PhotoCapture.PhotoCaptureResult>.NativeClassPtr, ref this));
			}

			// Token: 0x04001F6B RID: 8043
			private static readonly IntPtr NativeFieldInfoPtr_resultType;

			// Token: 0x04001F6C RID: 8044
			private static readonly IntPtr NativeFieldInfoPtr_hResult;

			// Token: 0x04001F6D RID: 8045
			[FieldOffset(0)]
			public PhotoCapture.CaptureResultType resultType;

			// Token: 0x04001F6E RID: 8046
			[FieldOffset(8)]
			public long hResult;
		}

		// Token: 0x02000899 RID: 2201
		public sealed class OnCaptureResourceCreatedCallback : MulticastDelegate
		{
			// Token: 0x06002F69 RID: 12137 RVA: 0x0007D7F0 File Offset: 0x0007B9F0
			// Note: this type is marked as 'beforefieldinit'.
			static OnCaptureResourceCreatedCallback()
			{
				Il2CppClassPointerStore<PhotoCapture.OnCaptureResourceCreatedCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, "OnCaptureResourceCreatedCallback");
				PhotoCapture.OnCaptureResourceCreatedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnCaptureResourceCreatedCallback>.NativeClassPtr, 100665398);
				PhotoCapture.OnCaptureResourceCreatedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCapture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnCaptureResourceCreatedCallback>.NativeClassPtr, 100665399);
				PhotoCapture.OnCaptureResourceCreatedCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_PhotoCapture_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnCaptureResourceCreatedCallback>.NativeClassPtr, 100665400);
				PhotoCapture.OnCaptureResourceCreatedCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnCaptureResourceCreatedCallback>.NativeClassPtr, 100665401);
			}

			// Token: 0x06002F6A RID: 12138 RVA: 0x0007D864 File Offset: 0x0007BA64
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnCaptureResourceCreatedCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhotoCapture.OnCaptureResourceCreatedCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnCaptureResourceCreatedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F6B RID: 12139 RVA: 0x0007D8C0 File Offset: 0x0007BAC0
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 1006, RefRangeEnd = 1022, XrefRangeStart = 1006, XrefRangeEnd = 1022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(PhotoCapture captureObject)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(captureObject);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnCaptureResourceCreatedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCapture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002F6C RID: 12140 RVA: 0x0007D904 File Offset: 0x0007BB04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(PhotoCapture captureObject, AsyncCallback callback, Object @object)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnCaptureResourceCreatedCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_PhotoCapture_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06002F6D RID: 12141 RVA: 0x0007D978 File Offset: 0x0007BB78
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnCaptureResourceCreatedCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002F6E RID: 12142 RVA: 0x00013A96 File Offset: 0x00011C96
			public OnCaptureResourceCreatedCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002F6F RID: 12143 RVA: 0x00013A9F File Offset: 0x00011C9F
			public static implicit operator PhotoCapture.OnCaptureResourceCreatedCallback(Action<PhotoCapture> A_0)
			{
				return DelegateSupport.ConvertDelegate<PhotoCapture.OnCaptureResourceCreatedCallback>(A_0);
			}

			// Token: 0x06002F70 RID: 12144 RVA: 0x00013AA7 File Offset: 0x00011CA7
			public static PhotoCapture.OnCaptureResourceCreatedCallback operator +(PhotoCapture.OnCaptureResourceCreatedCallback A_0, PhotoCapture.OnCaptureResourceCreatedCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<PhotoCapture.OnCaptureResourceCreatedCallback>();
			}

			// Token: 0x06002F71 RID: 12145 RVA: 0x00013AB5 File Offset: 0x00011CB5
			public static PhotoCapture.OnCaptureResourceCreatedCallback operator -(PhotoCapture.OnCaptureResourceCreatedCallback A_0, PhotoCapture.OnCaptureResourceCreatedCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<PhotoCapture.OnCaptureResourceCreatedCallback>();
				}
				return delegate2;
			}

			// Token: 0x04001F6F RID: 8047
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001F70 RID: 8048
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCapture_0;

			// Token: 0x04001F71 RID: 8049
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_PhotoCapture_AsyncCallback_Object_0;

			// Token: 0x04001F72 RID: 8050
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x0200089A RID: 2202
		public sealed class OnPhotoModeStartedCallback : MulticastDelegate
		{
			// Token: 0x06002F72 RID: 12146 RVA: 0x0007D9BC File Offset: 0x0007BBBC
			// Note: this type is marked as 'beforefieldinit'.
			static OnPhotoModeStartedCallback()
			{
				Il2CppClassPointerStore<PhotoCapture.OnPhotoModeStartedCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, "OnPhotoModeStartedCallback");
				PhotoCapture.OnPhotoModeStartedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnPhotoModeStartedCallback>.NativeClassPtr, 100665402);
				PhotoCapture.OnPhotoModeStartedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnPhotoModeStartedCallback>.NativeClassPtr, 100665403);
				PhotoCapture.OnPhotoModeStartedCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_PhotoCaptureResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnPhotoModeStartedCallback>.NativeClassPtr, 100665404);
				PhotoCapture.OnPhotoModeStartedCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnPhotoModeStartedCallback>.NativeClassPtr, 100665405);
			}

			// Token: 0x06002F73 RID: 12147 RVA: 0x0007DA30 File Offset: 0x0007BC30
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnPhotoModeStartedCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhotoCapture.OnPhotoModeStartedCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnPhotoModeStartedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F74 RID: 12148 RVA: 0x0007DA8C File Offset: 0x0007BC8C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 500418, RefRangeEnd = 500425, XrefRangeStart = 500418, XrefRangeEnd = 500418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(PhotoCapture.PhotoCaptureResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref result;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnPhotoModeStartedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002F75 RID: 12149 RVA: 0x0007DACC File Offset: 0x0007BCCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500425, XrefRangeEnd = 500429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(PhotoCapture.PhotoCaptureResult result, AsyncCallback callback, Object @object)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnPhotoModeStartedCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_PhotoCaptureResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06002F76 RID: 12150 RVA: 0x0007DB3C File Offset: 0x0007BD3C
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnPhotoModeStartedCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002F77 RID: 12151 RVA: 0x00013AC6 File Offset: 0x00011CC6
			public OnPhotoModeStartedCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002F78 RID: 12152 RVA: 0x00013ACF File Offset: 0x00011CCF
			public static implicit operator PhotoCapture.OnPhotoModeStartedCallback(Action<PhotoCapture.PhotoCaptureResult> A_0)
			{
				return DelegateSupport.ConvertDelegate<PhotoCapture.OnPhotoModeStartedCallback>(A_0);
			}

			// Token: 0x06002F79 RID: 12153 RVA: 0x00013AD7 File Offset: 0x00011CD7
			public static PhotoCapture.OnPhotoModeStartedCallback operator +(PhotoCapture.OnPhotoModeStartedCallback A_0, PhotoCapture.OnPhotoModeStartedCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<PhotoCapture.OnPhotoModeStartedCallback>();
			}

			// Token: 0x06002F7A RID: 12154 RVA: 0x00013AE5 File Offset: 0x00011CE5
			public static PhotoCapture.OnPhotoModeStartedCallback operator -(PhotoCapture.OnPhotoModeStartedCallback A_0, PhotoCapture.OnPhotoModeStartedCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<PhotoCapture.OnPhotoModeStartedCallback>();
				}
				return delegate2;
			}

			// Token: 0x04001F73 RID: 8051
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001F74 RID: 8052
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_0;

			// Token: 0x04001F75 RID: 8053
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_PhotoCaptureResult_AsyncCallback_Object_0;

			// Token: 0x04001F76 RID: 8054
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x0200089B RID: 2203
		public sealed class OnPhotoModeStoppedCallback : MulticastDelegate
		{
			// Token: 0x06002F7B RID: 12155 RVA: 0x0007DB80 File Offset: 0x0007BD80
			// Note: this type is marked as 'beforefieldinit'.
			static OnPhotoModeStoppedCallback()
			{
				Il2CppClassPointerStore<PhotoCapture.OnPhotoModeStoppedCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, "OnPhotoModeStoppedCallback");
				PhotoCapture.OnPhotoModeStoppedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnPhotoModeStoppedCallback>.NativeClassPtr, 100665406);
				PhotoCapture.OnPhotoModeStoppedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnPhotoModeStoppedCallback>.NativeClassPtr, 100665407);
				PhotoCapture.OnPhotoModeStoppedCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_PhotoCaptureResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnPhotoModeStoppedCallback>.NativeClassPtr, 100665408);
				PhotoCapture.OnPhotoModeStoppedCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnPhotoModeStoppedCallback>.NativeClassPtr, 100665409);
			}

			// Token: 0x06002F7C RID: 12156 RVA: 0x0007DBF4 File Offset: 0x0007BDF4
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnPhotoModeStoppedCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhotoCapture.OnPhotoModeStoppedCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnPhotoModeStoppedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F7D RID: 12157 RVA: 0x0007DC50 File Offset: 0x0007BE50
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 500418, RefRangeEnd = 500425, XrefRangeStart = 500418, XrefRangeEnd = 500425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(PhotoCapture.PhotoCaptureResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref result;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnPhotoModeStoppedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002F7E RID: 12158 RVA: 0x0007DC90 File Offset: 0x0007BE90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500429, XrefRangeEnd = 500433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(PhotoCapture.PhotoCaptureResult result, AsyncCallback callback, Object @object)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnPhotoModeStoppedCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_PhotoCaptureResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06002F7F RID: 12159 RVA: 0x0007DD00 File Offset: 0x0007BF00
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnPhotoModeStoppedCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002F80 RID: 12160 RVA: 0x00013AF6 File Offset: 0x00011CF6
			public OnPhotoModeStoppedCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002F81 RID: 12161 RVA: 0x00013AFF File Offset: 0x00011CFF
			public static implicit operator PhotoCapture.OnPhotoModeStoppedCallback(Action<PhotoCapture.PhotoCaptureResult> A_0)
			{
				return DelegateSupport.ConvertDelegate<PhotoCapture.OnPhotoModeStoppedCallback>(A_0);
			}

			// Token: 0x06002F82 RID: 12162 RVA: 0x00013B07 File Offset: 0x00011D07
			public static PhotoCapture.OnPhotoModeStoppedCallback operator +(PhotoCapture.OnPhotoModeStoppedCallback A_0, PhotoCapture.OnPhotoModeStoppedCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<PhotoCapture.OnPhotoModeStoppedCallback>();
			}

			// Token: 0x06002F83 RID: 12163 RVA: 0x00013B15 File Offset: 0x00011D15
			public static PhotoCapture.OnPhotoModeStoppedCallback operator -(PhotoCapture.OnPhotoModeStoppedCallback A_0, PhotoCapture.OnPhotoModeStoppedCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<PhotoCapture.OnPhotoModeStoppedCallback>();
				}
				return delegate2;
			}

			// Token: 0x04001F77 RID: 8055
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001F78 RID: 8056
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_0;

			// Token: 0x04001F79 RID: 8057
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_PhotoCaptureResult_AsyncCallback_Object_0;

			// Token: 0x04001F7A RID: 8058
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x0200089C RID: 2204
		public sealed class OnCapturedToDiskCallback : MulticastDelegate
		{
			// Token: 0x06002F84 RID: 12164 RVA: 0x0007DD44 File Offset: 0x0007BF44
			// Note: this type is marked as 'beforefieldinit'.
			static OnCapturedToDiskCallback()
			{
				Il2CppClassPointerStore<PhotoCapture.OnCapturedToDiskCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, "OnCapturedToDiskCallback");
				PhotoCapture.OnCapturedToDiskCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnCapturedToDiskCallback>.NativeClassPtr, 100665410);
				PhotoCapture.OnCapturedToDiskCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnCapturedToDiskCallback>.NativeClassPtr, 100665411);
				PhotoCapture.OnCapturedToDiskCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_PhotoCaptureResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnCapturedToDiskCallback>.NativeClassPtr, 100665412);
				PhotoCapture.OnCapturedToDiskCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnCapturedToDiskCallback>.NativeClassPtr, 100665413);
			}

			// Token: 0x06002F85 RID: 12165 RVA: 0x0007DDB8 File Offset: 0x0007BFB8
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnCapturedToDiskCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhotoCapture.OnCapturedToDiskCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnCapturedToDiskCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F86 RID: 12166 RVA: 0x0007DE14 File Offset: 0x0007C014
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 500418, RefRangeEnd = 500425, XrefRangeStart = 500418, XrefRangeEnd = 500425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(PhotoCapture.PhotoCaptureResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref result;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnCapturedToDiskCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002F87 RID: 12167 RVA: 0x0007DE54 File Offset: 0x0007C054
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500433, XrefRangeEnd = 500437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(PhotoCapture.PhotoCaptureResult result, AsyncCallback callback, Object @object)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnCapturedToDiskCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_PhotoCaptureResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06002F88 RID: 12168 RVA: 0x0007DEC4 File Offset: 0x0007C0C4
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnCapturedToDiskCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002F89 RID: 12169 RVA: 0x00013B26 File Offset: 0x00011D26
			public OnCapturedToDiskCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002F8A RID: 12170 RVA: 0x00013B2F File Offset: 0x00011D2F
			public static implicit operator PhotoCapture.OnCapturedToDiskCallback(Action<PhotoCapture.PhotoCaptureResult> A_0)
			{
				return DelegateSupport.ConvertDelegate<PhotoCapture.OnCapturedToDiskCallback>(A_0);
			}

			// Token: 0x06002F8B RID: 12171 RVA: 0x00013B37 File Offset: 0x00011D37
			public static PhotoCapture.OnCapturedToDiskCallback operator +(PhotoCapture.OnCapturedToDiskCallback A_0, PhotoCapture.OnCapturedToDiskCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<PhotoCapture.OnCapturedToDiskCallback>();
			}

			// Token: 0x06002F8C RID: 12172 RVA: 0x00013B45 File Offset: 0x00011D45
			public static PhotoCapture.OnCapturedToDiskCallback operator -(PhotoCapture.OnCapturedToDiskCallback A_0, PhotoCapture.OnCapturedToDiskCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<PhotoCapture.OnCapturedToDiskCallback>();
				}
				return delegate2;
			}

			// Token: 0x04001F7B RID: 8059
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001F7C RID: 8060
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_0;

			// Token: 0x04001F7D RID: 8061
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_PhotoCaptureResult_AsyncCallback_Object_0;

			// Token: 0x04001F7E RID: 8062
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x0200089D RID: 2205
		public sealed class OnCapturedToMemoryCallback : MulticastDelegate
		{
			// Token: 0x06002F8D RID: 12173 RVA: 0x0007DF08 File Offset: 0x0007C108
			// Note: this type is marked as 'beforefieldinit'.
			static OnCapturedToMemoryCallback()
			{
				Il2CppClassPointerStore<PhotoCapture.OnCapturedToMemoryCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, "OnCapturedToMemoryCallback");
				PhotoCapture.OnCapturedToMemoryCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnCapturedToMemoryCallback>.NativeClassPtr, 100665414);
				PhotoCapture.OnCapturedToMemoryCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_PhotoCaptureFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnCapturedToMemoryCallback>.NativeClassPtr, 100665415);
				PhotoCapture.OnCapturedToMemoryCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_PhotoCaptureResult_PhotoCaptureFrame_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnCapturedToMemoryCallback>.NativeClassPtr, 100665416);
				PhotoCapture.OnCapturedToMemoryCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnCapturedToMemoryCallback>.NativeClassPtr, 100665417);
			}

			// Token: 0x06002F8E RID: 12174 RVA: 0x0007DF7C File Offset: 0x0007C17C
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnCapturedToMemoryCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhotoCapture.OnCapturedToMemoryCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnCapturedToMemoryCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F8F RID: 12175 RVA: 0x0007DFD8 File Offset: 0x0007C1D8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 500437, RefRangeEnd = 500438, XrefRangeStart = 500437, XrefRangeEnd = 500437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(PhotoCapture.PhotoCaptureResult result, PhotoCaptureFrame photoCaptureFrame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref result;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(photoCaptureFrame);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnCapturedToMemoryCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_PhotoCaptureFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F90 RID: 12176 RVA: 0x0007E028 File Offset: 0x0007C228
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500438, XrefRangeEnd = 500442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(PhotoCapture.PhotoCaptureResult result, PhotoCaptureFrame photoCaptureFrame, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref result;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(photoCaptureFrame);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnCapturedToMemoryCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_PhotoCaptureResult_PhotoCaptureFrame_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06002F91 RID: 12177 RVA: 0x0007E0AC File Offset: 0x0007C2AC
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnCapturedToMemoryCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002F92 RID: 12178 RVA: 0x00013B56 File Offset: 0x00011D56
			public OnCapturedToMemoryCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002F93 RID: 12179 RVA: 0x00013B5F File Offset: 0x00011D5F
			public static implicit operator PhotoCapture.OnCapturedToMemoryCallback(Action<PhotoCapture.PhotoCaptureResult, PhotoCaptureFrame> A_0)
			{
				return DelegateSupport.ConvertDelegate<PhotoCapture.OnCapturedToMemoryCallback>(A_0);
			}

			// Token: 0x06002F94 RID: 12180 RVA: 0x00013B67 File Offset: 0x00011D67
			public static PhotoCapture.OnCapturedToMemoryCallback operator +(PhotoCapture.OnCapturedToMemoryCallback A_0, PhotoCapture.OnCapturedToMemoryCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<PhotoCapture.OnCapturedToMemoryCallback>();
			}

			// Token: 0x06002F95 RID: 12181 RVA: 0x00013B75 File Offset: 0x00011D75
			public static PhotoCapture.OnCapturedToMemoryCallback operator -(PhotoCapture.OnCapturedToMemoryCallback A_0, PhotoCapture.OnCapturedToMemoryCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<PhotoCapture.OnCapturedToMemoryCallback>();
				}
				return delegate2;
			}

			// Token: 0x04001F7F RID: 8063
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001F80 RID: 8064
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_PhotoCaptureFrame_0;

			// Token: 0x04001F81 RID: 8065
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_PhotoCaptureResult_PhotoCaptureFrame_AsyncCallback_Object_0;

			// Token: 0x04001F82 RID: 8066
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
