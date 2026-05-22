using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Net;
using Il2CppSystem.Net.Cache;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Xml
{
	// Token: 0x020000B0 RID: 176
	public class XmlUrlResolver : XmlResolver
	{
		// Token: 0x06001094 RID: 4244 RVA: 0x0005C3D8 File Offset: 0x0005A5D8
		// Note: this type is marked as 'beforefieldinit'.
		static XmlUrlResolver()
		{
			Il2CppClassPointerStore<XmlUrlResolver>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlUrlResolver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlUrlResolver>.NativeClassPtr);
			XmlUrlResolver.NativeFieldInfoPtr_s_DownloadManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUrlResolver>.NativeClassPtr, "s_DownloadManager");
			XmlUrlResolver.NativeFieldInfoPtr__credentials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUrlResolver>.NativeClassPtr, "_credentials");
			XmlUrlResolver.NativeFieldInfoPtr__proxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUrlResolver>.NativeClassPtr, "_proxy");
			XmlUrlResolver.NativeFieldInfoPtr__cachePolicy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUrlResolver>.NativeClassPtr, "_cachePolicy");
			XmlUrlResolver.NativeMethodInfoPtr_get_DownloadManager_Private_Static_get_XmlDownloadManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUrlResolver>.NativeClassPtr, 100665957);
			XmlUrlResolver.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUrlResolver>.NativeClassPtr, 100665958);
			XmlUrlResolver.NativeMethodInfoPtr_GetEntity_Public_Virtual_Object_Uri_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUrlResolver>.NativeClassPtr, 100665959);
			XmlUrlResolver.NativeMethodInfoPtr_ResolveUri_Public_Virtual_Uri_Uri_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUrlResolver>.NativeClassPtr, 100665960);
			XmlUrlResolver.NativeMethodInfoPtr_GetEntityAsync_Public_Virtual_Task_1_Object_Uri_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUrlResolver>.NativeClassPtr, 100665961);
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06001095 RID: 4245 RVA: 0x0005C4BC File Offset: 0x0005A6BC
		public unsafe static XmlDownloadManager DownloadManager
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 403168, RefRangeEnd = 403170, XrefRangeStart = 403160, XrefRangeEnd = 403168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlUrlResolver.NativeMethodInfoPtr_get_DownloadManager_Private_Static_get_XmlDownloadManager_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlDownloadManager>(intPtr3) : null;
			}
		}

		// Token: 0x06001096 RID: 4246 RVA: 0x0005C4F0 File Offset: 0x0005A6F0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlUrlResolver()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlUrlResolver>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlUrlResolver.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001097 RID: 4247 RVA: 0x0005C52C File Offset: 0x0005A72C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403170, XrefRangeEnd = 403194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(absoluteUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(role);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ofObjectToReturn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUrlResolver.NativeMethodInfoPtr_GetEntity_Public_Virtual_Object_Uri_String_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001098 RID: 4248 RVA: 0x0005C5AC File Offset: 0x0005A7AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403194, XrefRangeEnd = 403195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Uri ResolveUri(Uri baseUri, string relativeUri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(relativeUri);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUrlResolver.NativeMethodInfoPtr_ResolveUri_Public_Virtual_Uri_Uri_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
		}

		// Token: 0x06001099 RID: 4249 RVA: 0x0005C61C File Offset: 0x0005A81C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403195, XrefRangeEnd = 403205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task<Object> GetEntityAsync(Uri absoluteUri, string role, Type ofObjectToReturn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(absoluteUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(role);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ofObjectToReturn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUrlResolver.NativeMethodInfoPtr_GetEntityAsync_Public_Virtual_Task_1_Object_Uri_String_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Object>>(intPtr3) : null;
		}

		// Token: 0x0600109A RID: 4250 RVA: 0x00007703 File Offset: 0x00005903
		public XmlUrlResolver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x0600109B RID: 4251 RVA: 0x0005C69C File Offset: 0x0005A89C
		// (set) Token: 0x0600109C RID: 4252 RVA: 0x0000770C File Offset: 0x0000590C
		public unsafe static Object s_DownloadManager
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlUrlResolver.NativeFieldInfoPtr_s_DownloadManager, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlUrlResolver.NativeFieldInfoPtr_s_DownloadManager, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x0600109D RID: 4253 RVA: 0x0005C6C4 File Offset: 0x0005A8C4
		// (set) Token: 0x0600109E RID: 4254 RVA: 0x0000771E File Offset: 0x0000591E
		public unsafe ICredentials _credentials
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUrlResolver.NativeFieldInfoPtr__credentials);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICredentials>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUrlResolver.NativeFieldInfoPtr__credentials), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x0600109F RID: 4255 RVA: 0x0005C6F4 File Offset: 0x0005A8F4
		// (set) Token: 0x060010A0 RID: 4256 RVA: 0x0000773D File Offset: 0x0000593D
		public unsafe IWebProxy _proxy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUrlResolver.NativeFieldInfoPtr__proxy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUrlResolver.NativeFieldInfoPtr__proxy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x060010A1 RID: 4257 RVA: 0x0005C724 File Offset: 0x0005A924
		// (set) Token: 0x060010A2 RID: 4258 RVA: 0x0000775C File Offset: 0x0000595C
		public unsafe RequestCachePolicy _cachePolicy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUrlResolver.NativeFieldInfoPtr__cachePolicy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RequestCachePolicy>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUrlResolver.NativeFieldInfoPtr__cachePolicy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D09 RID: 3337
		private static readonly IntPtr NativeFieldInfoPtr_s_DownloadManager;

		// Token: 0x04000D0A RID: 3338
		private static readonly IntPtr NativeFieldInfoPtr__credentials;

		// Token: 0x04000D0B RID: 3339
		private static readonly IntPtr NativeFieldInfoPtr__proxy;

		// Token: 0x04000D0C RID: 3340
		private static readonly IntPtr NativeFieldInfoPtr__cachePolicy;

		// Token: 0x04000D0D RID: 3341
		private static readonly IntPtr NativeMethodInfoPtr_get_DownloadManager_Private_Static_get_XmlDownloadManager_0;

		// Token: 0x04000D0E RID: 3342
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000D0F RID: 3343
		private static readonly IntPtr NativeMethodInfoPtr_GetEntity_Public_Virtual_Object_Uri_String_Type_0;

		// Token: 0x04000D10 RID: 3344
		private static readonly IntPtr NativeMethodInfoPtr_ResolveUri_Public_Virtual_Uri_Uri_String_0;

		// Token: 0x04000D11 RID: 3345
		private static readonly IntPtr NativeMethodInfoPtr_GetEntityAsync_Public_Virtual_Task_1_Object_Uri_String_Type_0;

		// Token: 0x02000227 RID: 551
		[ObfuscatedName("System.Xml.XmlUrlResolver+<GetEntityAsync>d__15")]
		public sealed class _GetEntityAsync_d__15 : ValueType
		{
			// Token: 0x06002BF1 RID: 11249 RVA: 0x000C52A0 File Offset: 0x000C34A0
			// Note: this type is marked as 'beforefieldinit'.
			static _GetEntityAsync_d__15()
			{
				Il2CppClassPointerStore<XmlUrlResolver._GetEntityAsync_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlUrlResolver>.NativeClassPtr, "<GetEntityAsync>d__15");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlUrlResolver._GetEntityAsync_d__15>.NativeClassPtr);
				XmlUrlResolver._GetEntityAsync_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUrlResolver._GetEntityAsync_d__15>.NativeClassPtr, "<>1__state");
				XmlUrlResolver._GetEntityAsync_d__15.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUrlResolver._GetEntityAsync_d__15>.NativeClassPtr, "<>t__builder");
				XmlUrlResolver._GetEntityAsync_d__15.NativeFieldInfoPtr_ofObjectToReturn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUrlResolver._GetEntityAsync_d__15>.NativeClassPtr, "ofObjectToReturn");
				XmlUrlResolver._GetEntityAsync_d__15.NativeFieldInfoPtr_absoluteUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUrlResolver._GetEntityAsync_d__15>.NativeClassPtr, "absoluteUri");
				XmlUrlResolver._GetEntityAsync_d__15.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUrlResolver._GetEntityAsync_d__15>.NativeClassPtr, "<>4__this");
				XmlUrlResolver._GetEntityAsync_d__15.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUrlResolver._GetEntityAsync_d__15>.NativeClassPtr, "<>u__1");
				XmlUrlResolver._GetEntityAsync_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUrlResolver._GetEntityAsync_d__15>.NativeClassPtr, 100665962);
				XmlUrlResolver._GetEntityAsync_d__15.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUrlResolver._GetEntityAsync_d__15>.NativeClassPtr, 100665963);
			}

			// Token: 0x06002BF2 RID: 11250 RVA: 0x000C536C File Offset: 0x000C356C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403114, XrefRangeEnd = 403145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlUrlResolver._GetEntityAsync_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002BF3 RID: 11251 RVA: 0x000C53A4 File Offset: 0x000C35A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403145, XrefRangeEnd = 403160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlUrlResolver._GetEntityAsync_d__15.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002BF4 RID: 11252 RVA: 0x00012CB5 File Offset: 0x00010EB5
			public _GetEntityAsync_d__15(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002BF5 RID: 11253 RVA: 0x00012CBE File Offset: 0x00010EBE
			public _GetEntityAsync_d__15()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlUrlResolver._GetEntityAsync_d__15>.NativeClassPtr))
			{
			}

			// Token: 0x17000EFB RID: 3835
			// (get) Token: 0x06002BF6 RID: 11254 RVA: 0x000C53EC File Offset: 0x000C35EC
			// (set) Token: 0x06002BF7 RID: 11255 RVA: 0x00012CD0 File Offset: 0x00010ED0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUrlResolver._GetEntityAsync_d__15.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUrlResolver._GetEntityAsync_d__15.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000EFC RID: 3836
			// (get) Token: 0x06002BF8 RID: 11256 RVA: 0x000C5414 File Offset: 0x000C3614
			// (set) Token: 0x06002BF9 RID: 11257 RVA: 0x00012CEB File Offset: 0x00010EEB
			public AsyncTaskMethodBuilder<Object> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUrlResolver._GetEntityAsync_d__15.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Object>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Object>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUrlResolver._GetEntityAsync_d__15.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Object>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000EFD RID: 3837
			// (get) Token: 0x06002BFA RID: 11258 RVA: 0x000C5444 File Offset: 0x000C3644
			// (set) Token: 0x06002BFB RID: 11259 RVA: 0x00012D19 File Offset: 0x00010F19
			public unsafe Type ofObjectToReturn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUrlResolver._GetEntityAsync_d__15.NativeFieldInfoPtr_ofObjectToReturn);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUrlResolver._GetEntityAsync_d__15.NativeFieldInfoPtr_ofObjectToReturn), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EFE RID: 3838
			// (get) Token: 0x06002BFC RID: 11260 RVA: 0x000C5474 File Offset: 0x000C3674
			// (set) Token: 0x06002BFD RID: 11261 RVA: 0x00012D38 File Offset: 0x00010F38
			public unsafe Uri absoluteUri
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUrlResolver._GetEntityAsync_d__15.NativeFieldInfoPtr_absoluteUri);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUrlResolver._GetEntityAsync_d__15.NativeFieldInfoPtr_absoluteUri), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EFF RID: 3839
			// (get) Token: 0x06002BFE RID: 11262 RVA: 0x000C54A4 File Offset: 0x000C36A4
			// (set) Token: 0x06002BFF RID: 11263 RVA: 0x00012D57 File Offset: 0x00010F57
			public unsafe XmlUrlResolver __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUrlResolver._GetEntityAsync_d__15.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlUrlResolver>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUrlResolver._GetEntityAsync_d__15.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F00 RID: 3840
			// (get) Token: 0x06002C00 RID: 11264 RVA: 0x000C54D4 File Offset: 0x000C36D4
			// (set) Token: 0x06002C01 RID: 11265 RVA: 0x00012D76 File Offset: 0x00010F76
			public ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUrlResolver._GetEntityAsync_d__15.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUrlResolver._GetEntityAsync_d__15.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002255 RID: 8789
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002256 RID: 8790
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002257 RID: 8791
			private static readonly IntPtr NativeFieldInfoPtr_ofObjectToReturn;

			// Token: 0x04002258 RID: 8792
			private static readonly IntPtr NativeFieldInfoPtr_absoluteUri;

			// Token: 0x04002259 RID: 8793
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400225A RID: 8794
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400225B RID: 8795
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400225C RID: 8796
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
