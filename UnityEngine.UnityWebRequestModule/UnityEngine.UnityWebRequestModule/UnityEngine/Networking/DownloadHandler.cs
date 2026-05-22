using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Text;

namespace UnityEngine.Networking
{
	// Token: 0x02000008 RID: 8
	public class DownloadHandler : Object
	{
		// Token: 0x060000F2 RID: 242 RVA: 0x0000597C File Offset: 0x00003B7C
		// Note: this type is marked as 'beforefieldinit'.
		static DownloadHandler()
		{
			Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityWebRequestModule.dll", "UnityEngine.Networking", "DownloadHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr);
			DownloadHandler.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr, "m_Ptr");
			DownloadHandler.NativeMethodInfoPtr_Release_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr, 100663372);
			DownloadHandler.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr, 100663373);
			DownloadHandler.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr, 100663374);
			DownloadHandler.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr, 100663375);
			DownloadHandler.NativeMethodInfoPtr_get_data_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr, 100663376);
			DownloadHandler.NativeMethodInfoPtr_GetData_Protected_Virtual_New_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr, 100663377);
			DownloadHandler.NativeMethodInfoPtr_ReceiveContentLengthHeader_Protected_Virtual_New_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr, 100663378);
			DownloadHandler.NativeMethodInfoPtr_ReceiveContentLength_Protected_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr, 100663379);
			DownloadHandler.NativeMethodInfoPtr_InternalGetByteArray_Internal_Static_Il2CppStructArray_1_Byte_DownloadHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr, 100663380);
			DownloadHandler.IsDoneDelegateField = IL2CPP.ResolveICall<DownloadHandler.IsDoneDelegate>("UnityEngine.Networking.DownloadHandler::IsDone");
			DownloadHandler.GetErrorMsgDelegateField = IL2CPP.ResolveICall<DownloadHandler.GetErrorMsgDelegate>("UnityEngine.Networking.DownloadHandler::GetErrorMsg");
			DownloadHandler.GetContentTypeDelegateField = IL2CPP.ResolveICall<DownloadHandler.GetContentTypeDelegate>("UnityEngine.Networking.DownloadHandler::GetContentType");
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00005AA4 File Offset: 0x00003CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534859, XrefRangeEnd = 534863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandler.NativeMethodInfoPtr_Release_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00005AD8 File Offset: 0x00003CD8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DownloadHandler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandler.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00005B14 File Offset: 0x00003D14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534863, XrefRangeEnd = 534865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DownloadHandler.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00005B50 File Offset: 0x00003D50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 534868, RefRangeEnd = 534870, XrefRangeStart = 534865, XrefRangeEnd = 534868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandler.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00005B84 File Offset: 0x00003D84
		public unsafe Il2CppStructArray<byte> data
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandler.NativeMethodInfoPtr_get_data_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00005BC4 File Offset: 0x00003DC4
		[CallerCount(0)]
		public unsafe virtual Il2CppStructArray<byte> GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DownloadHandler.NativeMethodInfoPtr_GetData_Protected_Virtual_New_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00005C10 File Offset: 0x00003E10
		[CallerCount(0)]
		public unsafe virtual void ReceiveContentLengthHeader(ulong contentLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref contentLength;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DownloadHandler.NativeMethodInfoPtr_ReceiveContentLengthHeader_Protected_Virtual_New_Void_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00005C5C File Offset: 0x00003E5C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ReceiveContentLength(int contentLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref contentLength;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DownloadHandler.NativeMethodInfoPtr_ReceiveContentLength_Protected_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00005CA8 File Offset: 0x00003EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534870, XrefRangeEnd = 534874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> InternalGetByteArray(DownloadHandler dh)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandler.NativeMethodInfoPtr_InternalGetByteArray_Internal_Static_Il2CppStructArray_1_Byte_DownloadHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x060000FC RID: 252 RVA: 0x000024FE File Offset: 0x000006FE
		public DownloadHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00005CEC File Offset: 0x00003EEC
		// (set) Token: 0x060000FE RID: 254 RVA: 0x00002507 File Offset: 0x00000707
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadHandler.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadHandler.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00005D14 File Offset: 0x00003F14
		public bool isDone
		{
			get
			{
				return this.IsDone();
			}
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00002522 File Offset: 0x00000722
		public bool IsDone()
		{
			return DownloadHandler.IsDoneDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000101 RID: 257 RVA: 0x00005D2C File Offset: 0x00003F2C
		public string error
		{
			get
			{
				return this.GetErrorMsg();
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00005D44 File Offset: 0x00003F44
		public string GetErrorMsg()
		{
			IntPtr intPtr = DownloadHandler.GetErrorMsgDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000103 RID: 259 RVA: 0x00005D68 File Offset: 0x00003F68
		public string text
		{
			get
			{
				return this.GetText();
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00005D80 File Offset: 0x00003F80
		public virtual string GetText()
		{
			Il2CppStructArray<byte> data = this.GetData();
			bool flag = data != null && data.Length != 0;
			string text;
			if (flag)
			{
				text = this.GetTextEncoder().GetString(data, 0, data.Length);
			}
			else
			{
				text = "";
			}
			return text;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002534 File Offset: 0x00000734
		public Encoding GetTextEncoder()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00005DCC File Offset: 0x00003FCC
		public string GetContentType()
		{
			IntPtr intPtr = DownloadHandler.GetContentTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00005DF0 File Offset: 0x00003FF0
		public virtual bool ReceiveData(Il2CppStructArray<byte> data, int dataLength)
		{
			return true;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00002541 File Offset: 0x00000741
		public virtual void CompleteContent()
		{
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00005E04 File Offset: 0x00004004
		public virtual float GetProgress()
		{
			return 0f;
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00005E1C File Offset: 0x0000401C
		public static T GetCheckedDownloader<T>(UnityWebRequest www) where T : DownloadHandler
		{
			bool flag = www == null;
			if (flag)
			{
				throw new NullReferenceException("Cannot get content from a null UnityWebRequest object");
			}
			bool flag2 = !www.isDone;
			if (flag2)
			{
				throw new InvalidOperationException("Cannot get content from an unfinished UnityWebRequest object");
			}
			bool flag3 = www.result == UnityWebRequest.Result.ProtocolError;
			if (flag3)
			{
				throw new InvalidOperationException(www.error);
			}
			return www.downloadHandler.Cast<T>();
		}

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_Release_Private_Void_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_get_data_Public_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Protected_Virtual_New_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveContentLengthHeader_Protected_Virtual_New_Void_UInt64_0;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveContentLength_Protected_Virtual_New_Void_Int32_0;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetByteArray_Internal_Static_Il2CppStructArray_1_Byte_DownloadHandler_0;

		// Token: 0x0400008C RID: 140
		private static readonly DownloadHandler.IsDoneDelegate IsDoneDelegateField;

		// Token: 0x0400008D RID: 141
		private static readonly DownloadHandler.GetErrorMsgDelegate GetErrorMsgDelegateField;

		// Token: 0x0400008E RID: 142
		private static readonly DownloadHandler.GetContentTypeDelegate GetContentTypeDelegateField;

		// Token: 0x0200002D RID: 45
		// (Invoke) Token: 0x06000174 RID: 372
		private delegate bool IsDoneDelegate(IntPtr @this);

		// Token: 0x0200002E RID: 46
		// (Invoke) Token: 0x06000176 RID: 374
		private delegate IntPtr GetErrorMsgDelegate(IntPtr @this);

		// Token: 0x0200002F RID: 47
		// (Invoke) Token: 0x06000178 RID: 376
		private delegate IntPtr GetContentTypeDelegate(IntPtr @this);
	}
}
