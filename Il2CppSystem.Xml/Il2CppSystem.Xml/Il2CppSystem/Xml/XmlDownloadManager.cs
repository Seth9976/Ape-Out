using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.IO;
using Il2CppSystem.Net;
using Il2CppSystem.Net.Cache;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000099 RID: 153
	public class XmlDownloadManager : Object
	{
		// Token: 0x06000F9B RID: 3995 RVA: 0x00057788 File Offset: 0x00055988
		// Note: this type is marked as 'beforefieldinit'.
		static XmlDownloadManager()
		{
			Il2CppClassPointerStore<XmlDownloadManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlDownloadManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlDownloadManager>.NativeClassPtr);
			XmlDownloadManager.NativeFieldInfoPtr_connections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDownloadManager>.NativeClassPtr, "connections");
			XmlDownloadManager.NativeMethodInfoPtr_GetStream_Internal_Stream_Uri_ICredentials_IWebProxy_RequestCachePolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDownloadManager>.NativeClassPtr, 100665800);
			XmlDownloadManager.NativeMethodInfoPtr_GetNonFileStream_Private_Stream_Uri_ICredentials_IWebProxy_RequestCachePolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDownloadManager>.NativeClassPtr, 100665801);
			XmlDownloadManager.NativeMethodInfoPtr_Remove_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDownloadManager>.NativeClassPtr, 100665802);
			XmlDownloadManager.NativeMethodInfoPtr_GetStreamAsync_Internal_Task_1_Stream_Uri_ICredentials_IWebProxy_RequestCachePolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDownloadManager>.NativeClassPtr, 100665803);
			XmlDownloadManager.NativeMethodInfoPtr_GetNonFileStreamAsync_Private_Task_1_Stream_Uri_ICredentials_IWebProxy_RequestCachePolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDownloadManager>.NativeClassPtr, 100665804);
			XmlDownloadManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDownloadManager>.NativeClassPtr, 100665805);
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x00057844 File Offset: 0x00055A44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402082, XrefRangeEnd = 402087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Stream GetStream(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(credentials);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(proxy);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cachePolicy);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDownloadManager.NativeMethodInfoPtr_GetStream_Internal_Stream_Uri_ICredentials_IWebProxy_RequestCachePolicy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
		}

		// Token: 0x06000F9D RID: 3997 RVA: 0x000578CC File Offset: 0x00055ACC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 402126, RefRangeEnd = 402128, XrefRangeStart = 402087, XrefRangeEnd = 402126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Stream GetNonFileStream(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(credentials);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(proxy);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cachePolicy);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDownloadManager.NativeMethodInfoPtr_GetNonFileStream_Private_Stream_Uri_ICredentials_IWebProxy_RequestCachePolicy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
		}

		// Token: 0x06000F9E RID: 3998 RVA: 0x00057954 File Offset: 0x00055B54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 402133, RefRangeEnd = 402135, XrefRangeStart = 402128, XrefRangeEnd = 402133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(string host)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(host);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDownloadManager.NativeMethodInfoPtr_Remove_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F9F RID: 3999 RVA: 0x00057998 File Offset: 0x00055B98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 402147, RefRangeEnd = 402148, XrefRangeStart = 402135, XrefRangeEnd = 402147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Stream> GetStreamAsync(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(credentials);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(proxy);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cachePolicy);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDownloadManager.NativeMethodInfoPtr_GetStreamAsync_Internal_Task_1_Stream_Uri_ICredentials_IWebProxy_RequestCachePolicy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Stream>>(intPtr3) : null;
		}

		// Token: 0x06000FA0 RID: 4000 RVA: 0x00057A20 File Offset: 0x00055C20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 402158, RefRangeEnd = 402159, XrefRangeStart = 402148, XrefRangeEnd = 402158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Stream> GetNonFileStreamAsync(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(credentials);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(proxy);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cachePolicy);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDownloadManager.NativeMethodInfoPtr_GetNonFileStreamAsync_Private_Task_1_Stream_Uri_ICredentials_IWebProxy_RequestCachePolicy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Stream>>(intPtr3) : null;
		}

		// Token: 0x06000FA1 RID: 4001 RVA: 0x00057AA8 File Offset: 0x00055CA8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlDownloadManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlDownloadManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDownloadManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FA2 RID: 4002 RVA: 0x000072E6 File Offset: 0x000054E6
		public XmlDownloadManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06000FA3 RID: 4003 RVA: 0x00057AE4 File Offset: 0x00055CE4
		// (set) Token: 0x06000FA4 RID: 4004 RVA: 0x000072EF File Offset: 0x000054EF
		public unsafe Hashtable connections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager.NativeFieldInfoPtr_connections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager.NativeFieldInfoPtr_connections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C41 RID: 3137
		private static readonly IntPtr NativeFieldInfoPtr_connections;

		// Token: 0x04000C42 RID: 3138
		private static readonly IntPtr NativeMethodInfoPtr_GetStream_Internal_Stream_Uri_ICredentials_IWebProxy_RequestCachePolicy_0;

		// Token: 0x04000C43 RID: 3139
		private static readonly IntPtr NativeMethodInfoPtr_GetNonFileStream_Private_Stream_Uri_ICredentials_IWebProxy_RequestCachePolicy_0;

		// Token: 0x04000C44 RID: 3140
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Internal_Void_String_0;

		// Token: 0x04000C45 RID: 3141
		private static readonly IntPtr NativeMethodInfoPtr_GetStreamAsync_Internal_Task_1_Stream_Uri_ICredentials_IWebProxy_RequestCachePolicy_0;

		// Token: 0x04000C46 RID: 3142
		private static readonly IntPtr NativeMethodInfoPtr_GetNonFileStreamAsync_Private_Task_1_Stream_Uri_ICredentials_IWebProxy_RequestCachePolicy_0;

		// Token: 0x04000C47 RID: 3143
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000223 RID: 547
		[ObfuscatedName("System.Xml.XmlDownloadManager+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x06002BBF RID: 11199 RVA: 0x000C4A94 File Offset: 0x000C2C94
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<XmlDownloadManager.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlDownloadManager>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlDownloadManager.__c__DisplayClass4_0>.NativeClassPtr);
				XmlDownloadManager.__c__DisplayClass4_0.NativeFieldInfoPtr_uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDownloadManager.__c__DisplayClass4_0>.NativeClassPtr, "uri");
				XmlDownloadManager.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDownloadManager.__c__DisplayClass4_0>.NativeClassPtr, 100665806);
				XmlDownloadManager.__c__DisplayClass4_0.NativeMethodInfoPtr__GetStreamAsync_b__0_Internal_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDownloadManager.__c__DisplayClass4_0>.NativeClassPtr, 100665807);
			}

			// Token: 0x06002BC0 RID: 11200 RVA: 0x000C4AFC File Offset: 0x000C2CFC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlDownloadManager.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDownloadManager.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002BC1 RID: 11201 RVA: 0x000C4B38 File Offset: 0x000C2D38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401991, XrefRangeEnd = 401996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Stream _GetStreamAsync_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDownloadManager.__c__DisplayClass4_0.NativeMethodInfoPtr__GetStreamAsync_b__0_Internal_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
			}

			// Token: 0x06002BC2 RID: 11202 RVA: 0x00012A82 File Offset: 0x00010C82
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000EED RID: 3821
			// (get) Token: 0x06002BC3 RID: 11203 RVA: 0x000C4B78 File Offset: 0x000C2D78
			// (set) Token: 0x06002BC4 RID: 11204 RVA: 0x00012A8B File Offset: 0x00010C8B
			public unsafe Uri uri
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager.__c__DisplayClass4_0.NativeFieldInfoPtr_uri);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager.__c__DisplayClass4_0.NativeFieldInfoPtr_uri), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400223E RID: 8766
			private static readonly IntPtr NativeFieldInfoPtr_uri;

			// Token: 0x0400223F RID: 8767
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002240 RID: 8768
			private static readonly IntPtr NativeMethodInfoPtr__GetStreamAsync_b__0_Internal_Stream_0;
		}

		// Token: 0x02000224 RID: 548
		[ObfuscatedName("System.Xml.XmlDownloadManager+<GetNonFileStreamAsync>d__5")]
		public sealed class _GetNonFileStreamAsync_d__5 : ValueType
		{
			// Token: 0x06002BC5 RID: 11205 RVA: 0x000C4BA8 File Offset: 0x000C2DA8
			// Note: this type is marked as 'beforefieldinit'.
			static _GetNonFileStreamAsync_d__5()
			{
				Il2CppClassPointerStore<XmlDownloadManager._GetNonFileStreamAsync_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlDownloadManager>.NativeClassPtr, "<GetNonFileStreamAsync>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlDownloadManager._GetNonFileStreamAsync_d__5>.NativeClassPtr);
				XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDownloadManager._GetNonFileStreamAsync_d__5>.NativeClassPtr, "<>1__state");
				XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDownloadManager._GetNonFileStreamAsync_d__5>.NativeClassPtr, "<>t__builder");
				XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr_uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDownloadManager._GetNonFileStreamAsync_d__5>.NativeClassPtr, "uri");
				XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr_credentials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDownloadManager._GetNonFileStreamAsync_d__5>.NativeClassPtr, "credentials");
				XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr_proxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDownloadManager._GetNonFileStreamAsync_d__5>.NativeClassPtr, "proxy");
				XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr_cachePolicy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDownloadManager._GetNonFileStreamAsync_d__5>.NativeClassPtr, "cachePolicy");
				XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr__req_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDownloadManager._GetNonFileStreamAsync_d__5>.NativeClassPtr, "<req>5__1");
				XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDownloadManager._GetNonFileStreamAsync_d__5>.NativeClassPtr, "<>4__this");
				XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDownloadManager._GetNonFileStreamAsync_d__5>.NativeClassPtr, "<>u__1");
				XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDownloadManager._GetNonFileStreamAsync_d__5>.NativeClassPtr, 100665808);
				XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDownloadManager._GetNonFileStreamAsync_d__5>.NativeClassPtr, 100665809);
			}

			// Token: 0x06002BC6 RID: 11206 RVA: 0x000C4CB0 File Offset: 0x000C2EB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401996, XrefRangeEnd = 402067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002BC7 RID: 11207 RVA: 0x000C4CE8 File Offset: 0x000C2EE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402067, XrefRangeEnd = 402082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002BC8 RID: 11208 RVA: 0x00012AAA File Offset: 0x00010CAA
			public _GetNonFileStreamAsync_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002BC9 RID: 11209 RVA: 0x00012AB3 File Offset: 0x00010CB3
			public _GetNonFileStreamAsync_d__5()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlDownloadManager._GetNonFileStreamAsync_d__5>.NativeClassPtr))
			{
			}

			// Token: 0x17000EEE RID: 3822
			// (get) Token: 0x06002BCA RID: 11210 RVA: 0x000C4D30 File Offset: 0x000C2F30
			// (set) Token: 0x06002BCB RID: 11211 RVA: 0x00012AC5 File Offset: 0x00010CC5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000EEF RID: 3823
			// (get) Token: 0x06002BCC RID: 11212 RVA: 0x000C4D58 File Offset: 0x000C2F58
			// (set) Token: 0x06002BCD RID: 11213 RVA: 0x00012AE0 File Offset: 0x00010CE0
			public AsyncTaskMethodBuilder<Stream> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Stream>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Stream>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Stream>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000EF0 RID: 3824
			// (get) Token: 0x06002BCE RID: 11214 RVA: 0x000C4D88 File Offset: 0x000C2F88
			// (set) Token: 0x06002BCF RID: 11215 RVA: 0x00012B0E File Offset: 0x00010D0E
			public unsafe Uri uri
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr_uri);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr_uri), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EF1 RID: 3825
			// (get) Token: 0x06002BD0 RID: 11216 RVA: 0x000C4DB8 File Offset: 0x000C2FB8
			// (set) Token: 0x06002BD1 RID: 11217 RVA: 0x00012B2D File Offset: 0x00010D2D
			public unsafe ICredentials credentials
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr_credentials);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICredentials>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr_credentials), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EF2 RID: 3826
			// (get) Token: 0x06002BD2 RID: 11218 RVA: 0x000C4DE8 File Offset: 0x000C2FE8
			// (set) Token: 0x06002BD3 RID: 11219 RVA: 0x00012B4C File Offset: 0x00010D4C
			public unsafe IWebProxy proxy
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr_proxy);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr_proxy), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EF3 RID: 3827
			// (get) Token: 0x06002BD4 RID: 11220 RVA: 0x000C4E18 File Offset: 0x000C3018
			// (set) Token: 0x06002BD5 RID: 11221 RVA: 0x00012B6B File Offset: 0x00010D6B
			public unsafe RequestCachePolicy cachePolicy
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr_cachePolicy);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RequestCachePolicy>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr_cachePolicy), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EF4 RID: 3828
			// (get) Token: 0x06002BD6 RID: 11222 RVA: 0x000C4E48 File Offset: 0x000C3048
			// (set) Token: 0x06002BD7 RID: 11223 RVA: 0x00012B8A File Offset: 0x00010D8A
			public unsafe WebRequest _req_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr__req_5__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr__req_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EF5 RID: 3829
			// (get) Token: 0x06002BD8 RID: 11224 RVA: 0x000C4E78 File Offset: 0x000C3078
			// (set) Token: 0x06002BD9 RID: 11225 RVA: 0x00012BA9 File Offset: 0x00010DA9
			public unsafe XmlDownloadManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlDownloadManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EF6 RID: 3830
			// (get) Token: 0x06002BDA RID: 11226 RVA: 0x000C4EA8 File Offset: 0x000C30A8
			// (set) Token: 0x06002BDB RID: 11227 RVA: 0x00012BC8 File Offset: 0x00010DC8
			public ConfiguredTaskAwaitable<WebResponse>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<WebResponse>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<WebResponse>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<WebResponse>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002241 RID: 8769
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002242 RID: 8770
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002243 RID: 8771
			private static readonly IntPtr NativeFieldInfoPtr_uri;

			// Token: 0x04002244 RID: 8772
			private static readonly IntPtr NativeFieldInfoPtr_credentials;

			// Token: 0x04002245 RID: 8773
			private static readonly IntPtr NativeFieldInfoPtr_proxy;

			// Token: 0x04002246 RID: 8774
			private static readonly IntPtr NativeFieldInfoPtr_cachePolicy;

			// Token: 0x04002247 RID: 8775
			private static readonly IntPtr NativeFieldInfoPtr__req_5__1;

			// Token: 0x04002248 RID: 8776
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002249 RID: 8777
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400224A RID: 8778
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400224B RID: 8779
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
