using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Net
{
	// Token: 0x0200013D RID: 317
	public class WebConnectionTunnel : Object
	{
		// Token: 0x0600139E RID: 5022 RVA: 0x00059E38 File Offset: 0x00058038
		// Note: this type is marked as 'beforefieldinit'.
		static WebConnectionTunnel()
		{
			Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "WebConnectionTunnel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr);
			WebConnectionTunnel.NativeFieldInfoPtr__Request_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, "<Request>k__BackingField");
			WebConnectionTunnel.NativeFieldInfoPtr__ConnectUri_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, "<ConnectUri>k__BackingField");
			WebConnectionTunnel.NativeFieldInfoPtr_connectRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, "connectRequest");
			WebConnectionTunnel.NativeFieldInfoPtr_ntlmAuthState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, "ntlmAuthState");
			WebConnectionTunnel.NativeFieldInfoPtr__Success_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, "<Success>k__BackingField");
			WebConnectionTunnel.NativeFieldInfoPtr__CloseConnection_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, "<CloseConnection>k__BackingField");
			WebConnectionTunnel.NativeFieldInfoPtr__StatusCode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, "<StatusCode>k__BackingField");
			WebConnectionTunnel.NativeFieldInfoPtr__StatusDescription_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, "<StatusDescription>k__BackingField");
			WebConnectionTunnel.NativeFieldInfoPtr__Challenge_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, "<Challenge>k__BackingField");
			WebConnectionTunnel.NativeFieldInfoPtr__Headers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, "<Headers>k__BackingField");
			WebConnectionTunnel.NativeFieldInfoPtr__ProxyVersion_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, "<ProxyVersion>k__BackingField");
			WebConnectionTunnel.NativeFieldInfoPtr__Data_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, "<Data>k__BackingField");
			WebConnectionTunnel.NativeMethodInfoPtr_get_Request_Public_get_HttpWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100666066);
			WebConnectionTunnel.NativeMethodInfoPtr_get_ConnectUri_Public_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100666067);
			WebConnectionTunnel.NativeMethodInfoPtr__ctor_Public_Void_HttpWebRequest_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100666068);
			WebConnectionTunnel.NativeMethodInfoPtr_get_Success_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100666069);
			WebConnectionTunnel.NativeMethodInfoPtr_set_Success_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100666070);
			WebConnectionTunnel.NativeMethodInfoPtr_get_CloseConnection_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100666071);
			WebConnectionTunnel.NativeMethodInfoPtr_set_CloseConnection_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100666072);
			WebConnectionTunnel.NativeMethodInfoPtr_get_StatusCode_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100666073);
			WebConnectionTunnel.NativeMethodInfoPtr_set_StatusCode_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100666074);
			WebConnectionTunnel.NativeMethodInfoPtr_set_StatusDescription_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100666075);
			WebConnectionTunnel.NativeMethodInfoPtr_get_Challenge_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100666076);
			WebConnectionTunnel.NativeMethodInfoPtr_set_Challenge_Private_set_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100666077);
			WebConnectionTunnel.NativeMethodInfoPtr_get_Headers_Public_get_WebHeaderCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100666078);
			WebConnectionTunnel.NativeMethodInfoPtr_set_Headers_Private_set_Void_WebHeaderCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100666079);
			WebConnectionTunnel.NativeMethodInfoPtr_get_ProxyVersion_Public_get_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100666080);
			WebConnectionTunnel.NativeMethodInfoPtr_set_ProxyVersion_Private_set_Void_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100666081);
			WebConnectionTunnel.NativeMethodInfoPtr_get_Data_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100666082);
			WebConnectionTunnel.NativeMethodInfoPtr_set_Data_Private_set_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100666083);
			WebConnectionTunnel.NativeMethodInfoPtr_Initialize_Internal_Task_Stream_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100666084);
			WebConnectionTunnel.NativeMethodInfoPtr_ReadHeaders_Private_Task_1_ValueTuple_3_WebHeaderCollection_Il2CppStructArray_1_Byte_Int32_Stream_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100666085);
			WebConnectionTunnel.NativeMethodInfoPtr_FlushContents_Private_Void_Stream_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100666086);
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x0600139F RID: 5023 RVA: 0x0005A0FC File Offset: 0x000582FC
		public unsafe HttpWebRequest Request
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_get_Request_Public_get_HttpWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpWebRequest>(intPtr3) : null;
			}
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x060013A0 RID: 5024 RVA: 0x0005A13C File Offset: 0x0005833C
		public unsafe Uri ConnectUri
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_get_ConnectUri_Public_get_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
		}

		// Token: 0x060013A1 RID: 5025 RVA: 0x0005A17C File Offset: 0x0005837C
		[CallerCount(76)]
		[CachedScanResults(RefRangeStart = 19789, RefRangeEnd = 19865, XrefRangeStart = 19789, XrefRangeEnd = 19865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebConnectionTunnel(HttpWebRequest request, Uri connectUri)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(connectUri);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr__ctor_Public_Void_HttpWebRequest_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x060013A2 RID: 5026 RVA: 0x0005A1DC File Offset: 0x000583DC
		// (set) Token: 0x060013A3 RID: 5027 RVA: 0x0005A218 File Offset: 0x00058418
		public unsafe bool Success
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_get_Success_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_set_Success_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x060013A4 RID: 5028 RVA: 0x0005A258 File Offset: 0x00058458
		// (set) Token: 0x060013A5 RID: 5029 RVA: 0x0005A294 File Offset: 0x00058494
		public unsafe bool CloseConnection
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_get_CloseConnection_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_set_CloseConnection_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x060013A6 RID: 5030 RVA: 0x0005A2D4 File Offset: 0x000584D4
		// (set) Token: 0x060013A7 RID: 5031 RVA: 0x0005A310 File Offset: 0x00058510
		public unsafe int StatusCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_get_StatusCode_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_set_StatusCode_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700064B RID: 1611
		// (set) Token: 0x060013A8 RID: 5032 RVA: 0x0005A350 File Offset: 0x00058550
		public unsafe string StatusDescription
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 99340, RefRangeEnd = 99363, XrefRangeStart = 99340, XrefRangeEnd = 99363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_set_StatusDescription_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x060013A9 RID: 5033 RVA: 0x0005A394 File Offset: 0x00058594
		// (set) Token: 0x060013AA RID: 5034 RVA: 0x0005A3D4 File Offset: 0x000585D4
		public unsafe Il2CppStringArray Challenge
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_get_Challenge_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
			[CallerCount(43)]
			[CachedScanResults(RefRangeStart = 13782, RefRangeEnd = 13825, XrefRangeStart = 13782, XrefRangeEnd = 13825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_set_Challenge_Private_set_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x060013AB RID: 5035 RVA: 0x0005A418 File Offset: 0x00058618
		// (set) Token: 0x060013AC RID: 5036 RVA: 0x0005A458 File Offset: 0x00058658
		public unsafe WebHeaderCollection Headers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_get_Headers_Public_get_WebHeaderCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebHeaderCollection>(intPtr3) : null;
			}
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 14747, RefRangeEnd = 14763, XrefRangeStart = 14747, XrefRangeEnd = 14763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_set_Headers_Private_set_Void_WebHeaderCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x060013AD RID: 5037 RVA: 0x0005A49C File Offset: 0x0005869C
		// (set) Token: 0x060013AE RID: 5038 RVA: 0x0005A4DC File Offset: 0x000586DC
		public unsafe Version ProxyVersion
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_get_ProxyVersion_Public_get_Version_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Version>(intPtr3) : null;
			}
			[CallerCount(26)]
			[CachedScanResults(RefRangeStart = 13543, RefRangeEnd = 13569, XrefRangeStart = 13543, XrefRangeEnd = 13569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_set_ProxyVersion_Private_set_Void_Version_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x060013AF RID: 5039 RVA: 0x0005A520 File Offset: 0x00058720
		// (set) Token: 0x060013B0 RID: 5040 RVA: 0x0005A560 File Offset: 0x00058760
		public unsafe Il2CppStructArray<byte> Data
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_get_Data_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 17925, RefRangeEnd = 17937, XrefRangeStart = 17925, XrefRangeEnd = 17937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_set_Data_Private_set_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x0005A5A4 File Offset: 0x000587A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 385079, RefRangeEnd = 385080, XrefRangeStart = 385070, XrefRangeEnd = 385079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task Initialize(Stream stream, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_Initialize_Internal_Task_Stream_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060013B2 RID: 5042 RVA: 0x0005A60C File Offset: 0x0005880C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 385090, RefRangeEnd = 385091, XrefRangeStart = 385080, XrefRangeEnd = 385090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<ValueTuple<WebHeaderCollection, Il2CppStructArray<byte>, int>> ReadHeaders(Stream stream, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_ReadHeaders_Private_Task_1_ValueTuple_3_WebHeaderCollection_Il2CppStructArray_1_Byte_Int32_Stream_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<ValueTuple<WebHeaderCollection, Il2CppStructArray<byte>, int>>>(intPtr3) : null;
		}

		// Token: 0x060013B3 RID: 5043 RVA: 0x0005A674 File Offset: 0x00058874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385091, XrefRangeEnd = 385094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FlushContents(Stream stream, int contentLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contentLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_FlushContents_Private_Void_Stream_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013B4 RID: 5044 RVA: 0x00009F7F File Offset: 0x0000817F
		public WebConnectionTunnel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x060013B5 RID: 5045 RVA: 0x0005A6C4 File Offset: 0x000588C4
		// (set) Token: 0x060013B6 RID: 5046 RVA: 0x00009F88 File Offset: 0x00008188
		public unsafe HttpWebRequest _Request_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__Request_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpWebRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__Request_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x060013B7 RID: 5047 RVA: 0x0005A6F4 File Offset: 0x000588F4
		// (set) Token: 0x060013B8 RID: 5048 RVA: 0x00009FA7 File Offset: 0x000081A7
		public unsafe Uri _ConnectUri_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__ConnectUri_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__ConnectUri_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x060013B9 RID: 5049 RVA: 0x0005A724 File Offset: 0x00058924
		// (set) Token: 0x060013BA RID: 5050 RVA: 0x00009FC6 File Offset: 0x000081C6
		public unsafe HttpWebRequest connectRequest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr_connectRequest);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpWebRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr_connectRequest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x060013BB RID: 5051 RVA: 0x0005A754 File Offset: 0x00058954
		// (set) Token: 0x060013BC RID: 5052 RVA: 0x00009FE5 File Offset: 0x000081E5
		public unsafe WebConnectionTunnel.NtlmAuthState ntlmAuthState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr_ntlmAuthState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr_ntlmAuthState)) = value;
			}
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x060013BD RID: 5053 RVA: 0x0005A77C File Offset: 0x0005897C
		// (set) Token: 0x060013BE RID: 5054 RVA: 0x0000A000 File Offset: 0x00008200
		public unsafe bool _Success_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__Success_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__Success_k__BackingField)) = value;
			}
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x060013BF RID: 5055 RVA: 0x0005A7A4 File Offset: 0x000589A4
		// (set) Token: 0x060013C0 RID: 5056 RVA: 0x0000A01B File Offset: 0x0000821B
		public unsafe bool _CloseConnection_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__CloseConnection_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__CloseConnection_k__BackingField)) = value;
			}
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x060013C1 RID: 5057 RVA: 0x0005A7CC File Offset: 0x000589CC
		// (set) Token: 0x060013C2 RID: 5058 RVA: 0x0000A036 File Offset: 0x00008236
		public unsafe int _StatusCode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__StatusCode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__StatusCode_k__BackingField)) = value;
			}
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x060013C3 RID: 5059 RVA: 0x0005A7F4 File Offset: 0x000589F4
		// (set) Token: 0x060013C4 RID: 5060 RVA: 0x0000A051 File Offset: 0x00008251
		public unsafe string _StatusDescription_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__StatusDescription_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__StatusDescription_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x060013C5 RID: 5061 RVA: 0x0005A81C File Offset: 0x00058A1C
		// (set) Token: 0x060013C6 RID: 5062 RVA: 0x0000A070 File Offset: 0x00008270
		public unsafe Il2CppStringArray _Challenge_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__Challenge_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__Challenge_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x060013C7 RID: 5063 RVA: 0x0005A84C File Offset: 0x00058A4C
		// (set) Token: 0x060013C8 RID: 5064 RVA: 0x0000A08F File Offset: 0x0000828F
		public unsafe WebHeaderCollection _Headers_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__Headers_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebHeaderCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__Headers_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x060013C9 RID: 5065 RVA: 0x0005A87C File Offset: 0x00058A7C
		// (set) Token: 0x060013CA RID: 5066 RVA: 0x0000A0AE File Offset: 0x000082AE
		public unsafe Version _ProxyVersion_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__ProxyVersion_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Version>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__ProxyVersion_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x060013CB RID: 5067 RVA: 0x0005A8AC File Offset: 0x00058AAC
		// (set) Token: 0x060013CC RID: 5068 RVA: 0x0000A0CD File Offset: 0x000082CD
		public unsafe Il2CppStructArray<byte> _Data_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__Data_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__Data_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000EF3 RID: 3827
		private static readonly IntPtr NativeFieldInfoPtr__Request_k__BackingField;

		// Token: 0x04000EF4 RID: 3828
		private static readonly IntPtr NativeFieldInfoPtr__ConnectUri_k__BackingField;

		// Token: 0x04000EF5 RID: 3829
		private static readonly IntPtr NativeFieldInfoPtr_connectRequest;

		// Token: 0x04000EF6 RID: 3830
		private static readonly IntPtr NativeFieldInfoPtr_ntlmAuthState;

		// Token: 0x04000EF7 RID: 3831
		private static readonly IntPtr NativeFieldInfoPtr__Success_k__BackingField;

		// Token: 0x04000EF8 RID: 3832
		private static readonly IntPtr NativeFieldInfoPtr__CloseConnection_k__BackingField;

		// Token: 0x04000EF9 RID: 3833
		private static readonly IntPtr NativeFieldInfoPtr__StatusCode_k__BackingField;

		// Token: 0x04000EFA RID: 3834
		private static readonly IntPtr NativeFieldInfoPtr__StatusDescription_k__BackingField;

		// Token: 0x04000EFB RID: 3835
		private static readonly IntPtr NativeFieldInfoPtr__Challenge_k__BackingField;

		// Token: 0x04000EFC RID: 3836
		private static readonly IntPtr NativeFieldInfoPtr__Headers_k__BackingField;

		// Token: 0x04000EFD RID: 3837
		private static readonly IntPtr NativeFieldInfoPtr__ProxyVersion_k__BackingField;

		// Token: 0x04000EFE RID: 3838
		private static readonly IntPtr NativeFieldInfoPtr__Data_k__BackingField;

		// Token: 0x04000EFF RID: 3839
		private static readonly IntPtr NativeMethodInfoPtr_get_Request_Public_get_HttpWebRequest_0;

		// Token: 0x04000F00 RID: 3840
		private static readonly IntPtr NativeMethodInfoPtr_get_ConnectUri_Public_get_Uri_0;

		// Token: 0x04000F01 RID: 3841
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_HttpWebRequest_Uri_0;

		// Token: 0x04000F02 RID: 3842
		private static readonly IntPtr NativeMethodInfoPtr_get_Success_Public_get_Boolean_0;

		// Token: 0x04000F03 RID: 3843
		private static readonly IntPtr NativeMethodInfoPtr_set_Success_Private_set_Void_Boolean_0;

		// Token: 0x04000F04 RID: 3844
		private static readonly IntPtr NativeMethodInfoPtr_get_CloseConnection_Public_get_Boolean_0;

		// Token: 0x04000F05 RID: 3845
		private static readonly IntPtr NativeMethodInfoPtr_set_CloseConnection_Private_set_Void_Boolean_0;

		// Token: 0x04000F06 RID: 3846
		private static readonly IntPtr NativeMethodInfoPtr_get_StatusCode_Public_get_Int32_0;

		// Token: 0x04000F07 RID: 3847
		private static readonly IntPtr NativeMethodInfoPtr_set_StatusCode_Private_set_Void_Int32_0;

		// Token: 0x04000F08 RID: 3848
		private static readonly IntPtr NativeMethodInfoPtr_set_StatusDescription_Private_set_Void_String_0;

		// Token: 0x04000F09 RID: 3849
		private static readonly IntPtr NativeMethodInfoPtr_get_Challenge_Public_get_Il2CppStringArray_0;

		// Token: 0x04000F0A RID: 3850
		private static readonly IntPtr NativeMethodInfoPtr_set_Challenge_Private_set_Void_Il2CppStringArray_0;

		// Token: 0x04000F0B RID: 3851
		private static readonly IntPtr NativeMethodInfoPtr_get_Headers_Public_get_WebHeaderCollection_0;

		// Token: 0x04000F0C RID: 3852
		private static readonly IntPtr NativeMethodInfoPtr_set_Headers_Private_set_Void_WebHeaderCollection_0;

		// Token: 0x04000F0D RID: 3853
		private static readonly IntPtr NativeMethodInfoPtr_get_ProxyVersion_Public_get_Version_0;

		// Token: 0x04000F0E RID: 3854
		private static readonly IntPtr NativeMethodInfoPtr_set_ProxyVersion_Private_set_Void_Version_0;

		// Token: 0x04000F0F RID: 3855
		private static readonly IntPtr NativeMethodInfoPtr_get_Data_Public_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000F10 RID: 3856
		private static readonly IntPtr NativeMethodInfoPtr_set_Data_Private_set_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000F11 RID: 3857
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Internal_Task_Stream_CancellationToken_0;

		// Token: 0x04000F12 RID: 3858
		private static readonly IntPtr NativeMethodInfoPtr_ReadHeaders_Private_Task_1_ValueTuple_3_WebHeaderCollection_Il2CppStructArray_1_Byte_Int32_Stream_CancellationToken_0;

		// Token: 0x04000F13 RID: 3859
		private static readonly IntPtr NativeMethodInfoPtr_FlushContents_Private_Void_Stream_Int32_0;

		// Token: 0x020001F9 RID: 505
		[OriginalName("System.dll", "", "NtlmAuthState")]
		public enum NtlmAuthState
		{
			// Token: 0x04001564 RID: 5476
			None,
			// Token: 0x04001565 RID: 5477
			Challenge,
			// Token: 0x04001566 RID: 5478
			Response
		}

		// Token: 0x020001FA RID: 506
		[ObfuscatedName("System.Net.WebConnectionTunnel+<Initialize>d__42")]
		public sealed class _Initialize_d__42 : ValueType
		{
			// Token: 0x06001B93 RID: 7059 RVA: 0x00073658 File Offset: 0x00071858
			// Note: this type is marked as 'beforefieldinit'.
			static _Initialize_d__42()
			{
				Il2CppClassPointerStore<WebConnectionTunnel._Initialize_d__42>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, "<Initialize>d__42");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebConnectionTunnel._Initialize_d__42>.NativeClassPtr);
				WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel._Initialize_d__42>.NativeClassPtr, "<>1__state");
				WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel._Initialize_d__42>.NativeClassPtr, "<>t__builder");
				WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel._Initialize_d__42>.NativeClassPtr, "<>4__this");
				WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel._Initialize_d__42>.NativeClassPtr, "stream");
				WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel._Initialize_d__42>.NativeClassPtr, "cancellationToken");
				WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr__have_auth_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel._Initialize_d__42>.NativeClassPtr, "<have_auth>5__1");
				WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel._Initialize_d__42>.NativeClassPtr, "<>u__1");
				WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel._Initialize_d__42>.NativeClassPtr, "<>u__2");
				WebConnectionTunnel._Initialize_d__42.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel._Initialize_d__42>.NativeClassPtr, 100666087);
				WebConnectionTunnel._Initialize_d__42.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel._Initialize_d__42>.NativeClassPtr, 100666088);
			}

			// Token: 0x06001B94 RID: 7060 RVA: 0x0007374C File Offset: 0x0007194C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384819, XrefRangeEnd = 384982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel._Initialize_d__42.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B95 RID: 7061 RVA: 0x00073784 File Offset: 0x00071984
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel._Initialize_d__42.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B96 RID: 7062 RVA: 0x0000E7BF File Offset: 0x0000C9BF
			public _Initialize_d__42(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001B97 RID: 7063 RVA: 0x0000E7C8 File Offset: 0x0000C9C8
			public _Initialize_d__42()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebConnectionTunnel._Initialize_d__42>.NativeClassPtr))
			{
			}

			// Token: 0x170008CE RID: 2254
			// (get) Token: 0x06001B98 RID: 7064 RVA: 0x000737CC File Offset: 0x000719CC
			// (set) Token: 0x06001B99 RID: 7065 RVA: 0x0000E7DA File Offset: 0x0000C9DA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008CF RID: 2255
			// (get) Token: 0x06001B9A RID: 7066 RVA: 0x000737F4 File Offset: 0x000719F4
			// (set) Token: 0x06001B9B RID: 7067 RVA: 0x0000E7F5 File Offset: 0x0000C9F5
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008D0 RID: 2256
			// (get) Token: 0x06001B9C RID: 7068 RVA: 0x00073824 File Offset: 0x00071A24
			// (set) Token: 0x06001B9D RID: 7069 RVA: 0x0000E823 File Offset: 0x0000CA23
			public unsafe WebConnectionTunnel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebConnectionTunnel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008D1 RID: 2257
			// (get) Token: 0x06001B9E RID: 7070 RVA: 0x00073854 File Offset: 0x00071A54
			// (set) Token: 0x06001B9F RID: 7071 RVA: 0x0000E842 File Offset: 0x0000CA42
			public unsafe Stream stream
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr_stream);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008D2 RID: 2258
			// (get) Token: 0x06001BA0 RID: 7072 RVA: 0x00073884 File Offset: 0x00071A84
			// (set) Token: 0x06001BA1 RID: 7073 RVA: 0x0000E861 File Offset: 0x0000CA61
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008D3 RID: 2259
			// (get) Token: 0x06001BA2 RID: 7074 RVA: 0x000738B4 File Offset: 0x00071AB4
			// (set) Token: 0x06001BA3 RID: 7075 RVA: 0x0000E88F File Offset: 0x0000CA8F
			public unsafe bool _have_auth_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr__have_auth_5__1);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr__have_auth_5__1)) = value;
				}
			}

			// Token: 0x170008D4 RID: 2260
			// (get) Token: 0x06001BA4 RID: 7076 RVA: 0x000738DC File Offset: 0x00071ADC
			// (set) Token: 0x06001BA5 RID: 7077 RVA: 0x0000E8AA File Offset: 0x0000CAAA
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008D5 RID: 2261
			// (get) Token: 0x06001BA6 RID: 7078 RVA: 0x0007390C File Offset: 0x00071B0C
			// (set) Token: 0x06001BA7 RID: 7079 RVA: 0x0000E8D8 File Offset: 0x0000CAD8
			public ConfiguredTaskAwaitable<ValueTuple<WebHeaderCollection, Il2CppStructArray<byte>, int>>.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable<ValueTuple<WebHeaderCollection, Il2CppStructArray<byte>, int>>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<ValueTuple<WebHeaderCollection, Il2CppStructArray<byte>, int>>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<ValueTuple<WebHeaderCollection, Il2CppStructArray<byte>, int>>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001567 RID: 5479
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001568 RID: 5480
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001569 RID: 5481
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400156A RID: 5482
			private static readonly IntPtr NativeFieldInfoPtr_stream;

			// Token: 0x0400156B RID: 5483
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x0400156C RID: 5484
			private static readonly IntPtr NativeFieldInfoPtr__have_auth_5__1;

			// Token: 0x0400156D RID: 5485
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400156E RID: 5486
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x0400156F RID: 5487
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001570 RID: 5488
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020001FB RID: 507
		[ObfuscatedName("System.Net.WebConnectionTunnel+<ReadHeaders>d__43")]
		public sealed class _ReadHeaders_d__43 : ValueType
		{
			// Token: 0x06001BA8 RID: 7080 RVA: 0x0007393C File Offset: 0x00071B3C
			// Note: this type is marked as 'beforefieldinit'.
			static _ReadHeaders_d__43()
			{
				Il2CppClassPointerStore<WebConnectionTunnel._ReadHeaders_d__43>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, "<ReadHeaders>d__43");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebConnectionTunnel._ReadHeaders_d__43>.NativeClassPtr);
				WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel._ReadHeaders_d__43>.NativeClassPtr, "<>1__state");
				WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel._ReadHeaders_d__43>.NativeClassPtr, "<>t__builder");
				WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel._ReadHeaders_d__43>.NativeClassPtr, "cancellationToken");
				WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel._ReadHeaders_d__43>.NativeClassPtr, "stream");
				WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr__buffer_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel._ReadHeaders_d__43>.NativeClassPtr, "<buffer>5__1");
				WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr__ms_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel._ReadHeaders_d__43>.NativeClassPtr, "<ms>5__2");
				WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel._ReadHeaders_d__43>.NativeClassPtr, "<>4__this");
				WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr__retBuffer_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel._ReadHeaders_d__43>.NativeClassPtr, "<retBuffer>5__3");
				WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr__status_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel._ReadHeaders_d__43>.NativeClassPtr, "<status>5__4");
				WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel._ReadHeaders_d__43>.NativeClassPtr, "<>u__1");
				WebConnectionTunnel._ReadHeaders_d__43.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel._ReadHeaders_d__43>.NativeClassPtr, 100666089);
				WebConnectionTunnel._ReadHeaders_d__43.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel._ReadHeaders_d__43>.NativeClassPtr, 100666090);
			}

			// Token: 0x06001BA9 RID: 7081 RVA: 0x00073A58 File Offset: 0x00071C58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384982, XrefRangeEnd = 385055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel._ReadHeaders_d__43.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BAA RID: 7082 RVA: 0x00073A90 File Offset: 0x00071C90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385055, XrefRangeEnd = 385070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel._ReadHeaders_d__43.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001BAB RID: 7083 RVA: 0x0000E906 File Offset: 0x0000CB06
			public _ReadHeaders_d__43(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001BAC RID: 7084 RVA: 0x0000E90F File Offset: 0x0000CB0F
			public _ReadHeaders_d__43()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebConnectionTunnel._ReadHeaders_d__43>.NativeClassPtr))
			{
			}

			// Token: 0x170008D6 RID: 2262
			// (get) Token: 0x06001BAD RID: 7085 RVA: 0x00073AD8 File Offset: 0x00071CD8
			// (set) Token: 0x06001BAE RID: 7086 RVA: 0x0000E921 File Offset: 0x0000CB21
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008D7 RID: 2263
			// (get) Token: 0x06001BAF RID: 7087 RVA: 0x00073B00 File Offset: 0x00071D00
			// (set) Token: 0x06001BB0 RID: 7088 RVA: 0x0000E93C File Offset: 0x0000CB3C
			public AsyncTaskMethodBuilder<ValueTuple<WebHeaderCollection, Il2CppStructArray<byte>, int>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<ValueTuple<WebHeaderCollection, Il2CppStructArray<byte>, int>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<ValueTuple<WebHeaderCollection, Il2CppStructArray<byte>, int>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<ValueTuple<WebHeaderCollection, Il2CppStructArray<byte>, int>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008D8 RID: 2264
			// (get) Token: 0x06001BB1 RID: 7089 RVA: 0x00073B30 File Offset: 0x00071D30
			// (set) Token: 0x06001BB2 RID: 7090 RVA: 0x0000E96A File Offset: 0x0000CB6A
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008D9 RID: 2265
			// (get) Token: 0x06001BB3 RID: 7091 RVA: 0x00073B60 File Offset: 0x00071D60
			// (set) Token: 0x06001BB4 RID: 7092 RVA: 0x0000E998 File Offset: 0x0000CB98
			public unsafe Stream stream
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr_stream);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008DA RID: 2266
			// (get) Token: 0x06001BB5 RID: 7093 RVA: 0x00073B90 File Offset: 0x00071D90
			// (set) Token: 0x06001BB6 RID: 7094 RVA: 0x0000E9B7 File Offset: 0x0000CBB7
			public unsafe Il2CppStructArray<byte> _buffer_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr__buffer_5__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr__buffer_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008DB RID: 2267
			// (get) Token: 0x06001BB7 RID: 7095 RVA: 0x00073BC0 File Offset: 0x00071DC0
			// (set) Token: 0x06001BB8 RID: 7096 RVA: 0x0000E9D6 File Offset: 0x0000CBD6
			public unsafe MemoryStream _ms_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr__ms_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemoryStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr__ms_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008DC RID: 2268
			// (get) Token: 0x06001BB9 RID: 7097 RVA: 0x00073BF0 File Offset: 0x00071DF0
			// (set) Token: 0x06001BBA RID: 7098 RVA: 0x0000E9F5 File Offset: 0x0000CBF5
			public unsafe WebConnectionTunnel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebConnectionTunnel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008DD RID: 2269
			// (get) Token: 0x06001BBB RID: 7099 RVA: 0x00073C20 File Offset: 0x00071E20
			// (set) Token: 0x06001BBC RID: 7100 RVA: 0x0000EA14 File Offset: 0x0000CC14
			public unsafe Il2CppStructArray<byte> _retBuffer_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr__retBuffer_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr__retBuffer_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008DE RID: 2270
			// (get) Token: 0x06001BBD RID: 7101 RVA: 0x00073C50 File Offset: 0x00071E50
			// (set) Token: 0x06001BBE RID: 7102 RVA: 0x0000EA33 File Offset: 0x0000CC33
			public unsafe int _status_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr__status_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr__status_5__4)) = value;
				}
			}

			// Token: 0x170008DF RID: 2271
			// (get) Token: 0x06001BBF RID: 7103 RVA: 0x00073C78 File Offset: 0x00071E78
			// (set) Token: 0x06001BC0 RID: 7104 RVA: 0x0000EA4E File Offset: 0x0000CC4E
			public ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001571 RID: 5489
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001572 RID: 5490
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001573 RID: 5491
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04001574 RID: 5492
			private static readonly IntPtr NativeFieldInfoPtr_stream;

			// Token: 0x04001575 RID: 5493
			private static readonly IntPtr NativeFieldInfoPtr__buffer_5__1;

			// Token: 0x04001576 RID: 5494
			private static readonly IntPtr NativeFieldInfoPtr__ms_5__2;

			// Token: 0x04001577 RID: 5495
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001578 RID: 5496
			private static readonly IntPtr NativeFieldInfoPtr__retBuffer_5__3;

			// Token: 0x04001579 RID: 5497
			private static readonly IntPtr NativeFieldInfoPtr__status_5__4;

			// Token: 0x0400157A RID: 5498
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400157B RID: 5499
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400157C RID: 5500
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
