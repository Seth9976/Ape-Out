using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Unity
{
	// Token: 0x02000006 RID: 6
	public static class UnityTls : Object
	{
		// Token: 0x06000014 RID: 20 RVA: 0x00010B30 File Offset: 0x0000ED30
		// Note: this type is marked as 'beforefieldinit'.
		static UnityTls()
		{
			Il2CppClassPointerStore<UnityTls>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Unity", "UnityTls");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityTls>.NativeClassPtr);
			UnityTls.NativeFieldInfoPtr_marshalledInterface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "marshalledInterface");
			UnityTls.NativeMethodInfoPtr_GetUnityTlsInterface_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, 100663306);
			UnityTls.NativeMethodInfoPtr_get_IsSupported_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, 100663307);
			UnityTls.NativeMethodInfoPtr_get_NativeInterface_Public_Static_get_unitytls_interface_struct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, 100663308);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00010BB0 File Offset: 0x0000EDB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364092, XrefRangeEnd = 364093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetUnityTlsInterface()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.NativeMethodInfoPtr_GetUnityTlsInterface_Private_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00010BE0 File Offset: 0x0000EDE0
		public unsafe static bool IsSupported
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364093, XrefRangeEnd = 364094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.NativeMethodInfoPtr_get_IsSupported_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00010C10 File Offset: 0x0000EE10
		public unsafe static UnityTls.unitytls_interface_struct NativeInterface
		{
			[CallerCount(67)]
			[CachedScanResults(RefRangeStart = 364116, RefRangeEnd = 364183, XrefRangeStart = 364094, XrefRangeEnd = 364116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.NativeMethodInfoPtr_get_NativeInterface_Public_Static_get_unitytls_interface_struct_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct>(intPtr3) : null;
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000020CA File Offset: 0x000002CA
		public UnityTls(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00010C44 File Offset: 0x0000EE44
		// (set) Token: 0x0600001A RID: 26 RVA: 0x000020D3 File Offset: 0x000002D3
		public unsafe static UnityTls.unitytls_interface_struct marshalledInterface
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UnityTls.NativeFieldInfoPtr_marshalledInterface, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UnityTls.NativeFieldInfoPtr_marshalledInterface, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeFieldInfoPtr_marshalledInterface;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr_GetUnityTlsInterface_Private_Static_IntPtr_0;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSupported_Public_Static_get_Boolean_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_get_NativeInterface_Public_Static_get_unitytls_interface_struct_0;

		// Token: 0x0200018A RID: 394
		[OriginalName("System.dll", "", "unitytls_error_code")]
		public enum unitytls_error_code : uint
		{
			// Token: 0x04001288 RID: 4744
			UNITYTLS_SUCCESS,
			// Token: 0x04001289 RID: 4745
			UNITYTLS_INVALID_ARGUMENT,
			// Token: 0x0400128A RID: 4746
			UNITYTLS_INVALID_FORMAT,
			// Token: 0x0400128B RID: 4747
			UNITYTLS_INVALID_PASSWORD,
			// Token: 0x0400128C RID: 4748
			UNITYTLS_INVALID_STATE,
			// Token: 0x0400128D RID: 4749
			UNITYTLS_BUFFER_OVERFLOW,
			// Token: 0x0400128E RID: 4750
			UNITYTLS_OUT_OF_MEMORY,
			// Token: 0x0400128F RID: 4751
			UNITYTLS_INTERNAL_ERROR,
			// Token: 0x04001290 RID: 4752
			UNITYTLS_NOT_SUPPORTED,
			// Token: 0x04001291 RID: 4753
			UNITYTLS_ENTROPY_SOURCE_FAILED,
			// Token: 0x04001292 RID: 4754
			UNITYTLS_STREAM_CLOSED,
			// Token: 0x04001293 RID: 4755
			UNITYTLS_USER_CUSTOM_ERROR_START = 1048576U,
			// Token: 0x04001294 RID: 4756
			UNITYTLS_USER_WOULD_BLOCK,
			// Token: 0x04001295 RID: 4757
			UNITYTLS_USER_READ_FAILED,
			// Token: 0x04001296 RID: 4758
			UNITYTLS_USER_WRITE_FAILED,
			// Token: 0x04001297 RID: 4759
			UNITYTLS_USER_UNKNOWN_ERROR,
			// Token: 0x04001298 RID: 4760
			UNITYTLS_USER_CUSTOM_ERROR_END = 2097152U
		}

		// Token: 0x0200018B RID: 395
		[StructLayout(2)]
		public struct unitytls_errorstate
		{
			// Token: 0x0600176F RID: 5999 RVA: 0x00067BA0 File Offset: 0x00065DA0
			// Note: this type is marked as 'beforefieldinit'.
			static unitytls_errorstate()
			{
				Il2CppClassPointerStore<UnityTls.unitytls_errorstate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_errorstate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityTls.unitytls_errorstate>.NativeClassPtr);
				UnityTls.unitytls_errorstate.NativeFieldInfoPtr_magic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_errorstate>.NativeClassPtr, "magic");
				UnityTls.unitytls_errorstate.NativeFieldInfoPtr_code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_errorstate>.NativeClassPtr, "code");
				UnityTls.unitytls_errorstate.NativeFieldInfoPtr_reserved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_errorstate>.NativeClassPtr, "reserved");
			}

			// Token: 0x06001770 RID: 6000 RVA: 0x0000BB0D File Offset: 0x00009D0D
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnityTls.unitytls_errorstate>.NativeClassPtr, ref this));
			}

			// Token: 0x04001299 RID: 4761
			private static readonly IntPtr NativeFieldInfoPtr_magic;

			// Token: 0x0400129A RID: 4762
			private static readonly IntPtr NativeFieldInfoPtr_code;

			// Token: 0x0400129B RID: 4763
			private static readonly IntPtr NativeFieldInfoPtr_reserved;

			// Token: 0x0400129C RID: 4764
			[FieldOffset(0)]
			public uint magic;

			// Token: 0x0400129D RID: 4765
			[FieldOffset(4)]
			public UnityTls.unitytls_error_code code;

			// Token: 0x0400129E RID: 4766
			[FieldOffset(8)]
			public ulong reserved;
		}

		// Token: 0x0200018C RID: 396
		[StructLayout(2)]
		public struct unitytls_key
		{
			// Token: 0x06001771 RID: 6001 RVA: 0x0000BB1F File Offset: 0x00009D1F
			// Note: this type is marked as 'beforefieldinit'.
			static unitytls_key()
			{
				Il2CppClassPointerStore<UnityTls.unitytls_key>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_key");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityTls.unitytls_key>.NativeClassPtr);
			}

			// Token: 0x06001772 RID: 6002 RVA: 0x0000BB3F File Offset: 0x00009D3F
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnityTls.unitytls_key>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x0200018D RID: 397
		[StructLayout(2)]
		public struct unitytls_key_ref
		{
			// Token: 0x06001773 RID: 6003 RVA: 0x0000BB51 File Offset: 0x00009D51
			// Note: this type is marked as 'beforefieldinit'.
			static unitytls_key_ref()
			{
				Il2CppClassPointerStore<UnityTls.unitytls_key_ref>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_key_ref");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityTls.unitytls_key_ref>.NativeClassPtr);
				UnityTls.unitytls_key_ref.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_key_ref>.NativeClassPtr, "handle");
			}

			// Token: 0x06001774 RID: 6004 RVA: 0x0000BB85 File Offset: 0x00009D85
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnityTls.unitytls_key_ref>.NativeClassPtr, ref this));
			}

			// Token: 0x0400129F RID: 4767
			private static readonly IntPtr NativeFieldInfoPtr_handle;

			// Token: 0x040012A0 RID: 4768
			[FieldOffset(0)]
			public ulong handle;
		}

		// Token: 0x0200018E RID: 398
		[StructLayout(2)]
		public struct unitytls_x509_ref
		{
			// Token: 0x06001775 RID: 6005 RVA: 0x0000BB97 File Offset: 0x00009D97
			// Note: this type is marked as 'beforefieldinit'.
			static unitytls_x509_ref()
			{
				Il2CppClassPointerStore<UnityTls.unitytls_x509_ref>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_x509_ref");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityTls.unitytls_x509_ref>.NativeClassPtr);
				UnityTls.unitytls_x509_ref.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_x509_ref>.NativeClassPtr, "handle");
			}

			// Token: 0x06001776 RID: 6006 RVA: 0x0000BBCB File Offset: 0x00009DCB
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnityTls.unitytls_x509_ref>.NativeClassPtr, ref this));
			}

			// Token: 0x040012A1 RID: 4769
			private static readonly IntPtr NativeFieldInfoPtr_handle;

			// Token: 0x040012A2 RID: 4770
			[FieldOffset(0)]
			public ulong handle;
		}

		// Token: 0x0200018F RID: 399
		[StructLayout(2)]
		public struct unitytls_x509list
		{
			// Token: 0x06001777 RID: 6007 RVA: 0x0000BBDD File Offset: 0x00009DDD
			// Note: this type is marked as 'beforefieldinit'.
			static unitytls_x509list()
			{
				Il2CppClassPointerStore<UnityTls.unitytls_x509list>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_x509list");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityTls.unitytls_x509list>.NativeClassPtr);
			}

			// Token: 0x06001778 RID: 6008 RVA: 0x0000BBFD File Offset: 0x00009DFD
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnityTls.unitytls_x509list>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000190 RID: 400
		[StructLayout(2)]
		public struct unitytls_x509list_ref
		{
			// Token: 0x06001779 RID: 6009 RVA: 0x0000BC0F File Offset: 0x00009E0F
			// Note: this type is marked as 'beforefieldinit'.
			static unitytls_x509list_ref()
			{
				Il2CppClassPointerStore<UnityTls.unitytls_x509list_ref>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_x509list_ref");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityTls.unitytls_x509list_ref>.NativeClassPtr);
				UnityTls.unitytls_x509list_ref.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_x509list_ref>.NativeClassPtr, "handle");
			}

			// Token: 0x0600177A RID: 6010 RVA: 0x0000BC43 File Offset: 0x00009E43
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnityTls.unitytls_x509list_ref>.NativeClassPtr, ref this));
			}

			// Token: 0x040012A3 RID: 4771
			private static readonly IntPtr NativeFieldInfoPtr_handle;

			// Token: 0x040012A4 RID: 4772
			[FieldOffset(0)]
			public ulong handle;
		}

		// Token: 0x02000191 RID: 401
		[OriginalName("System.dll", "", "unitytls_x509verify_result")]
		[Flags]
		public enum unitytls_x509verify_result : uint
		{
			// Token: 0x040012A6 RID: 4774
			UNITYTLS_X509VERIFY_SUCCESS = 0U,
			// Token: 0x040012A7 RID: 4775
			UNITYTLS_X509VERIFY_NOT_DONE = 2147483648U,
			// Token: 0x040012A8 RID: 4776
			UNITYTLS_X509VERIFY_FATAL_ERROR = 4294967295U,
			// Token: 0x040012A9 RID: 4777
			UNITYTLS_X509VERIFY_FLAG_EXPIRED = 1U,
			// Token: 0x040012AA RID: 4778
			UNITYTLS_X509VERIFY_FLAG_REVOKED = 2U,
			// Token: 0x040012AB RID: 4779
			UNITYTLS_X509VERIFY_FLAG_CN_MISMATCH = 4U,
			// Token: 0x040012AC RID: 4780
			UNITYTLS_X509VERIFY_FLAG_NOT_TRUSTED = 8U,
			// Token: 0x040012AD RID: 4781
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR1 = 65536U,
			// Token: 0x040012AE RID: 4782
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR2 = 131072U,
			// Token: 0x040012AF RID: 4783
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR3 = 262144U,
			// Token: 0x040012B0 RID: 4784
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR4 = 524288U,
			// Token: 0x040012B1 RID: 4785
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR5 = 1048576U,
			// Token: 0x040012B2 RID: 4786
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR6 = 2097152U,
			// Token: 0x040012B3 RID: 4787
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR7 = 4194304U,
			// Token: 0x040012B4 RID: 4788
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR8 = 8388608U,
			// Token: 0x040012B5 RID: 4789
			UNITYTLS_X509VERIFY_FLAG_UNKNOWN_ERROR = 134217728U
		}

		// Token: 0x02000192 RID: 402
		public sealed class unitytls_x509verify_callback : MulticastDelegate
		{
			// Token: 0x0600177B RID: 6011 RVA: 0x00067C08 File Offset: 0x00065E08
			// Note: this type is marked as 'beforefieldinit'.
			static unitytls_x509verify_callback()
			{
				Il2CppClassPointerStore<UnityTls.unitytls_x509verify_callback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_x509verify_callback");
				UnityTls.unitytls_x509verify_callback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_x509verify_callback>.NativeClassPtr, 100663309);
				UnityTls.unitytls_x509verify_callback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_ptr_Void_unitytls_x509_ref_unitytls_x509verify_result_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_x509verify_callback>.NativeClassPtr, 100663310);
				UnityTls.unitytls_x509verify_callback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_unitytls_x509_ref_unitytls_x509verify_result_ptr_unitytls_errorstate_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_x509verify_callback>.NativeClassPtr, 100663311);
				UnityTls.unitytls_x509verify_callback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_unitytls_x509verify_result_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_x509verify_callback>.NativeClassPtr, 100663312);
			}

			// Token: 0x0600177C RID: 6012 RVA: 0x00067C7C File Offset: 0x00065E7C
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe unitytls_x509verify_callback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_x509verify_callback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_x509verify_callback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600177D RID: 6013 RVA: 0x00067CD8 File Offset: 0x00065ED8
			[CallerCount(0)]
			public unsafe UnityTls.unitytls_x509verify_result Invoke(void* userData, UnityTls.unitytls_x509_ref cert, UnityTls.unitytls_x509verify_result result, UnityTls.unitytls_errorstate* errorState)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = userData;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cert;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref result;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_x509verify_callback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_ptr_Void_unitytls_x509_ref_unitytls_x509verify_result_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600177E RID: 6014 RVA: 0x00067D4C File Offset: 0x00065F4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363867, XrefRangeEnd = 363874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(void* userData, UnityTls.unitytls_x509_ref cert, UnityTls.unitytls_x509verify_result result, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = userData;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cert;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref result;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_x509verify_callback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_unitytls_x509_ref_unitytls_x509verify_result_ptr_unitytls_errorstate_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600177F RID: 6015 RVA: 0x00067DE8 File Offset: 0x00065FE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UnityTls.unitytls_x509verify_result EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_x509verify_callback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_unitytls_x509verify_result_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001780 RID: 6016 RVA: 0x0000BC55 File Offset: 0x00009E55
			public unitytls_x509verify_callback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040012B6 RID: 4790
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040012B7 RID: 4791
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_ptr_Void_unitytls_x509_ref_unitytls_x509verify_result_ptr_unitytls_errorstate_0;

			// Token: 0x040012B8 RID: 4792
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_unitytls_x509_ref_unitytls_x509verify_result_ptr_unitytls_errorstate_AsyncCallback_Object_0;

			// Token: 0x040012B9 RID: 4793
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_unitytls_x509verify_result_IAsyncResult_0;
		}

		// Token: 0x02000193 RID: 403
		[StructLayout(2)]
		public struct unitytls_tlsctx
		{
			// Token: 0x06001781 RID: 6017 RVA: 0x0000BC5E File Offset: 0x00009E5E
			// Note: this type is marked as 'beforefieldinit'.
			static unitytls_tlsctx()
			{
				Il2CppClassPointerStore<UnityTls.unitytls_tlsctx>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_tlsctx");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx>.NativeClassPtr);
			}

			// Token: 0x06001782 RID: 6018 RVA: 0x0000BC7E File Offset: 0x00009E7E
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000194 RID: 404
		[StructLayout(2)]
		public struct unitytls_x509name
		{
			// Token: 0x06001783 RID: 6019 RVA: 0x0000BC90 File Offset: 0x00009E90
			// Note: this type is marked as 'beforefieldinit'.
			static unitytls_x509name()
			{
				Il2CppClassPointerStore<UnityTls.unitytls_x509name>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_x509name");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityTls.unitytls_x509name>.NativeClassPtr);
			}

			// Token: 0x06001784 RID: 6020 RVA: 0x0000BCB0 File Offset: 0x00009EB0
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnityTls.unitytls_x509name>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000195 RID: 405
		[OriginalName("System.dll", "", "unitytls_ciphersuite")]
		public enum unitytls_ciphersuite : uint
		{
			// Token: 0x040012BB RID: 4795
			UNITYTLS_CIPHERSUITE_INVALID = 16777215U
		}

		// Token: 0x02000196 RID: 406
		[OriginalName("System.dll", "", "unitytls_protocol")]
		public enum unitytls_protocol : uint
		{
			// Token: 0x040012BD RID: 4797
			UNITYTLS_PROTOCOL_TLS_1_0,
			// Token: 0x040012BE RID: 4798
			UNITYTLS_PROTOCOL_TLS_1_1,
			// Token: 0x040012BF RID: 4799
			UNITYTLS_PROTOCOL_TLS_1_2,
			// Token: 0x040012C0 RID: 4800
			UNITYTLS_PROTOCOL_INVALID
		}

		// Token: 0x02000197 RID: 407
		[StructLayout(2)]
		public struct unitytls_tlsctx_protocolrange
		{
			// Token: 0x06001785 RID: 6021 RVA: 0x00067E38 File Offset: 0x00066038
			// Note: this type is marked as 'beforefieldinit'.
			static unitytls_tlsctx_protocolrange()
			{
				Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_protocolrange>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_tlsctx_protocolrange");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_protocolrange>.NativeClassPtr);
				UnityTls.unitytls_tlsctx_protocolrange.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_protocolrange>.NativeClassPtr, "min");
				UnityTls.unitytls_tlsctx_protocolrange.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_protocolrange>.NativeClassPtr, "max");
			}

			// Token: 0x06001786 RID: 6022 RVA: 0x0000BCC2 File Offset: 0x00009EC2
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_protocolrange>.NativeClassPtr, ref this));
			}

			// Token: 0x040012C1 RID: 4801
			private static readonly IntPtr NativeFieldInfoPtr_min;

			// Token: 0x040012C2 RID: 4802
			private static readonly IntPtr NativeFieldInfoPtr_max;

			// Token: 0x040012C3 RID: 4803
			[FieldOffset(0)]
			public UnityTls.unitytls_protocol min;

			// Token: 0x040012C4 RID: 4804
			[FieldOffset(4)]
			public UnityTls.unitytls_protocol max;
		}

		// Token: 0x02000198 RID: 408
		public sealed class unitytls_tlsctx_write_callback : MulticastDelegate
		{
			// Token: 0x06001787 RID: 6023 RVA: 0x00067E8C File Offset: 0x0006608C
			// Note: this type is marked as 'beforefieldinit'.
			static unitytls_tlsctx_write_callback()
			{
				Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_write_callback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_tlsctx_write_callback");
				UnityTls.unitytls_tlsctx_write_callback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_write_callback>.NativeClassPtr, 100663313);
				UnityTls.unitytls_tlsctx_write_callback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_ptr_Void_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_write_callback>.NativeClassPtr, 100663314);
				UnityTls.unitytls_tlsctx_write_callback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_ptr_Byte_IntPtr_ptr_unitytls_errorstate_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_write_callback>.NativeClassPtr, 100663315);
				UnityTls.unitytls_tlsctx_write_callback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_write_callback>.NativeClassPtr, 100663316);
			}

			// Token: 0x06001788 RID: 6024 RVA: 0x00067F00 File Offset: 0x00066100
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe unitytls_tlsctx_write_callback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_write_callback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_tlsctx_write_callback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001789 RID: 6025 RVA: 0x00067F5C File Offset: 0x0006615C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 363874, RefRangeEnd = 363876, XrefRangeStart = 363874, XrefRangeEnd = 363874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IntPtr Invoke(void* userData, byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = userData;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = data;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferLen;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_tlsctx_write_callback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_ptr_Void_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600178A RID: 6026 RVA: 0x00067FD0 File Offset: 0x000661D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363876, XrefRangeEnd = 363880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(void* userData, byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = userData;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = data;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferLen;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_tlsctx_write_callback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_ptr_Byte_IntPtr_ptr_unitytls_errorstate_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600178B RID: 6027 RVA: 0x0006806C File Offset: 0x0006626C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IntPtr EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_tlsctx_write_callback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600178C RID: 6028 RVA: 0x0000BCD4 File Offset: 0x00009ED4
			public unitytls_tlsctx_write_callback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040012C5 RID: 4805
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040012C6 RID: 4806
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_ptr_Void_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0;

			// Token: 0x040012C7 RID: 4807
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_ptr_Byte_IntPtr_ptr_unitytls_errorstate_AsyncCallback_Object_0;

			// Token: 0x040012C8 RID: 4808
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0;
		}

		// Token: 0x02000199 RID: 409
		public sealed class unitytls_tlsctx_read_callback : MulticastDelegate
		{
			// Token: 0x0600178D RID: 6029 RVA: 0x000680BC File Offset: 0x000662BC
			// Note: this type is marked as 'beforefieldinit'.
			static unitytls_tlsctx_read_callback()
			{
				Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_read_callback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_tlsctx_read_callback");
				UnityTls.unitytls_tlsctx_read_callback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_read_callback>.NativeClassPtr, 100663317);
				UnityTls.unitytls_tlsctx_read_callback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_ptr_Void_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_read_callback>.NativeClassPtr, 100663318);
				UnityTls.unitytls_tlsctx_read_callback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_ptr_Byte_IntPtr_ptr_unitytls_errorstate_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_read_callback>.NativeClassPtr, 100663319);
				UnityTls.unitytls_tlsctx_read_callback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_read_callback>.NativeClassPtr, 100663320);
			}

			// Token: 0x0600178E RID: 6030 RVA: 0x00068130 File Offset: 0x00066330
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe unitytls_tlsctx_read_callback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_read_callback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_tlsctx_read_callback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600178F RID: 6031 RVA: 0x0006818C File Offset: 0x0006638C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 363874, RefRangeEnd = 363876, XrefRangeStart = 363874, XrefRangeEnd = 363876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IntPtr Invoke(void* userData, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = userData;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = buffer;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferLen;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_tlsctx_read_callback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_ptr_Void_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001790 RID: 6032 RVA: 0x00068200 File Offset: 0x00066400
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363880, XrefRangeEnd = 363884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(void* userData, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = userData;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = buffer;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferLen;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_tlsctx_read_callback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_ptr_Byte_IntPtr_ptr_unitytls_errorstate_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001791 RID: 6033 RVA: 0x0006829C File Offset: 0x0006649C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IntPtr EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_tlsctx_read_callback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001792 RID: 6034 RVA: 0x0000BCDD File Offset: 0x00009EDD
			public unitytls_tlsctx_read_callback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040012C9 RID: 4809
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040012CA RID: 4810
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_ptr_Void_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0;

			// Token: 0x040012CB RID: 4811
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_ptr_Byte_IntPtr_ptr_unitytls_errorstate_AsyncCallback_Object_0;

			// Token: 0x040012CC RID: 4812
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0;
		}

		// Token: 0x0200019A RID: 410
		public sealed class unitytls_tlsctx_trace_callback : MulticastDelegate
		{
			// Token: 0x06001793 RID: 6035 RVA: 0x000682EC File Offset: 0x000664EC
			// Note: this type is marked as 'beforefieldinit'.
			static unitytls_tlsctx_trace_callback()
			{
				Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_trace_callback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_tlsctx_trace_callback");
				UnityTls.unitytls_tlsctx_trace_callback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_trace_callback>.NativeClassPtr, 100663321);
				UnityTls.unitytls_tlsctx_trace_callback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_trace_callback>.NativeClassPtr, 100663322);
				UnityTls.unitytls_tlsctx_trace_callback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_trace_callback>.NativeClassPtr, 100663323);
				UnityTls.unitytls_tlsctx_trace_callback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_trace_callback>.NativeClassPtr, 100663324);
			}

			// Token: 0x06001794 RID: 6036 RVA: 0x00068360 File Offset: 0x00066560
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe unitytls_tlsctx_trace_callback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_trace_callback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_tlsctx_trace_callback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001795 RID: 6037 RVA: 0x000683BC File Offset: 0x000665BC
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 363884, RefRangeEnd = 363888, XrefRangeStart = 363884, XrefRangeEnd = 363884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(void* userData, UnityTls.unitytls_tlsctx* ctx, byte* traceMessage, IntPtr traceMessageLen)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = userData;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ctx;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = traceMessage;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref traceMessageLen;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_tlsctx_trace_callback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001796 RID: 6038 RVA: 0x00068424 File Offset: 0x00066624
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363888, XrefRangeEnd = 363892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(void* userData, UnityTls.unitytls_tlsctx* ctx, byte* traceMessage, IntPtr traceMessageLen, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = userData;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ctx;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = traceMessage;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref traceMessageLen;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_tlsctx_trace_callback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001797 RID: 6039 RVA: 0x000684C0 File Offset: 0x000666C0
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_tlsctx_trace_callback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001798 RID: 6040 RVA: 0x0000BCE6 File Offset: 0x00009EE6
			public unitytls_tlsctx_trace_callback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040012CD RID: 4813
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040012CE RID: 4814
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_0;

			// Token: 0x040012CF RID: 4815
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_AsyncCallback_Object_0;

			// Token: 0x040012D0 RID: 4816
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x0200019B RID: 411
		public sealed class unitytls_tlsctx_certificate_callback : MulticastDelegate
		{
			// Token: 0x06001799 RID: 6041 RVA: 0x00068504 File Offset: 0x00066704
			// Note: this type is marked as 'beforefieldinit'.
			static unitytls_tlsctx_certificate_callback()
			{
				Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_certificate_callback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_tlsctx_certificate_callback");
				UnityTls.unitytls_tlsctx_certificate_callback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_certificate_callback>.NativeClassPtr, 100663325);
				UnityTls.unitytls_tlsctx_certificate_callback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_x509name_IntPtr_ptr_unitytls_x509list_ref_ptr_unitytls_key_ref_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_certificate_callback>.NativeClassPtr, 100663326);
				UnityTls.unitytls_tlsctx_certificate_callback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_x509name_IntPtr_ptr_unitytls_x509list_ref_ptr_unitytls_key_ref_ptr_unitytls_errorstate_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_certificate_callback>.NativeClassPtr, 100663327);
				UnityTls.unitytls_tlsctx_certificate_callback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_certificate_callback>.NativeClassPtr, 100663328);
			}

			// Token: 0x0600179A RID: 6042 RVA: 0x00068578 File Offset: 0x00066778
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe unitytls_tlsctx_certificate_callback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_certificate_callback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_tlsctx_certificate_callback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600179B RID: 6043 RVA: 0x000685D4 File Offset: 0x000667D4
			[CallerCount(0)]
			public unsafe void Invoke(void* userData, UnityTls.unitytls_tlsctx* ctx, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509name* caList, IntPtr caListLen, UnityTls.unitytls_x509list_ref* chain, UnityTls.unitytls_key_ref* key, UnityTls.unitytls_errorstate* errorState)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
					*ptr = userData;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ctx;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = cn;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cnLen;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = caList;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref caListLen;
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = chain;
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = key;
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_tlsctx_certificate_callback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_x509name_IntPtr_ptr_unitytls_x509list_ref_ptr_unitytls_key_ref_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600179C RID: 6044 RVA: 0x00068680 File Offset: 0x00066880
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363892, XrefRangeEnd = 363898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(void* userData, UnityTls.unitytls_tlsctx* ctx, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509name* caList, IntPtr caListLen, UnityTls.unitytls_x509list_ref* chain, UnityTls.unitytls_key_ref* key, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)];
					*ptr = userData;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ctx;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = cn;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cnLen;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = caList;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref caListLen;
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = chain;
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = key;
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
				ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_tlsctx_certificate_callback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_x509name_IntPtr_ptr_unitytls_x509list_ref_ptr_unitytls_key_ref_ptr_unitytls_errorstate_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600179D RID: 6045 RVA: 0x00068764 File Offset: 0x00066964
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_tlsctx_certificate_callback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600179E RID: 6046 RVA: 0x0000BCEF File Offset: 0x00009EEF
			public unitytls_tlsctx_certificate_callback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040012D1 RID: 4817
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040012D2 RID: 4818
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_x509name_IntPtr_ptr_unitytls_x509list_ref_ptr_unitytls_key_ref_ptr_unitytls_errorstate_0;

			// Token: 0x040012D3 RID: 4819
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_x509name_IntPtr_ptr_unitytls_x509list_ref_ptr_unitytls_key_ref_ptr_unitytls_errorstate_AsyncCallback_Object_0;

			// Token: 0x040012D4 RID: 4820
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x0200019C RID: 412
		public sealed class unitytls_tlsctx_x509verify_callback : MulticastDelegate
		{
			// Token: 0x0600179F RID: 6047 RVA: 0x000687A8 File Offset: 0x000669A8
			// Note: this type is marked as 'beforefieldinit'.
			static unitytls_tlsctx_x509verify_callback()
			{
				Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_x509verify_callback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_tlsctx_x509verify_callback");
				UnityTls.unitytls_tlsctx_x509verify_callback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_x509verify_callback>.NativeClassPtr, 100663329);
				UnityTls.unitytls_tlsctx_x509verify_callback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_ptr_Void_unitytls_x509list_ref_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_x509verify_callback>.NativeClassPtr, 100663330);
				UnityTls.unitytls_tlsctx_x509verify_callback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_unitytls_x509list_ref_ptr_unitytls_errorstate_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_x509verify_callback>.NativeClassPtr, 100663331);
				UnityTls.unitytls_tlsctx_x509verify_callback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_unitytls_x509verify_result_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_x509verify_callback>.NativeClassPtr, 100663332);
			}

			// Token: 0x060017A0 RID: 6048 RVA: 0x0006881C File Offset: 0x00066A1C
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe unitytls_tlsctx_x509verify_callback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_x509verify_callback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_tlsctx_x509verify_callback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060017A1 RID: 6049 RVA: 0x00068878 File Offset: 0x00066A78
			[CallerCount(0)]
			public unsafe UnityTls.unitytls_x509verify_result Invoke(void* userData, UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_errorstate* errorState)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = userData;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref chain;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_tlsctx_x509verify_callback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_ptr_Void_unitytls_x509list_ref_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060017A2 RID: 6050 RVA: 0x000688DC File Offset: 0x00066ADC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363898, XrefRangeEnd = 363902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(void* userData, UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = userData;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref chain;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_tlsctx_x509verify_callback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_unitytls_x509list_ref_ptr_unitytls_errorstate_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x060017A3 RID: 6051 RVA: 0x00068968 File Offset: 0x00066B68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UnityTls.unitytls_x509verify_result EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_tlsctx_x509verify_callback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_unitytls_x509verify_result_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060017A4 RID: 6052 RVA: 0x0000BCF8 File Offset: 0x00009EF8
			public unitytls_tlsctx_x509verify_callback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040012D5 RID: 4821
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040012D6 RID: 4822
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_ptr_Void_unitytls_x509list_ref_ptr_unitytls_errorstate_0;

			// Token: 0x040012D7 RID: 4823
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_unitytls_x509list_ref_ptr_unitytls_errorstate_AsyncCallback_Object_0;

			// Token: 0x040012D8 RID: 4824
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_unitytls_x509verify_result_IAsyncResult_0;
		}

		// Token: 0x0200019D RID: 413
		public sealed class unitytls_tlsctx_callbacks : ValueType
		{
			// Token: 0x060017A5 RID: 6053 RVA: 0x000689B8 File Offset: 0x00066BB8
			// Note: this type is marked as 'beforefieldinit'.
			static unitytls_tlsctx_callbacks()
			{
				Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_callbacks>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_tlsctx_callbacks");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_callbacks>.NativeClassPtr);
				UnityTls.unitytls_tlsctx_callbacks.NativeFieldInfoPtr_read = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_callbacks>.NativeClassPtr, "read");
				UnityTls.unitytls_tlsctx_callbacks.NativeFieldInfoPtr_write = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_callbacks>.NativeClassPtr, "write");
				UnityTls.unitytls_tlsctx_callbacks.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_callbacks>.NativeClassPtr, "data");
			}

			// Token: 0x060017A6 RID: 6054 RVA: 0x0000BD01 File Offset: 0x00009F01
			public unitytls_tlsctx_callbacks(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060017A7 RID: 6055 RVA: 0x0000BD0A File Offset: 0x00009F0A
			public unitytls_tlsctx_callbacks()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_callbacks>.NativeClassPtr))
			{
			}

			// Token: 0x17000789 RID: 1929
			// (get) Token: 0x060017A8 RID: 6056 RVA: 0x00068A20 File Offset: 0x00066C20
			// (set) Token: 0x060017A9 RID: 6057 RVA: 0x0000BD1C File Offset: 0x00009F1C
			public unsafe UnityTls.unitytls_tlsctx_read_callback read
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_tlsctx_callbacks.NativeFieldInfoPtr_read);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_tlsctx_read_callback>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_tlsctx_callbacks.NativeFieldInfoPtr_read), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700078A RID: 1930
			// (get) Token: 0x060017AA RID: 6058 RVA: 0x00068A50 File Offset: 0x00066C50
			// (set) Token: 0x060017AB RID: 6059 RVA: 0x0000BD3B File Offset: 0x00009F3B
			public unsafe UnityTls.unitytls_tlsctx_write_callback write
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_tlsctx_callbacks.NativeFieldInfoPtr_write);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_tlsctx_write_callback>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_tlsctx_callbacks.NativeFieldInfoPtr_write), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700078B RID: 1931
			// (get) Token: 0x060017AC RID: 6060 RVA: 0x00068A80 File Offset: 0x00066C80
			// (set) Token: 0x060017AD RID: 6061 RVA: 0x0000BD5A File Offset: 0x00009F5A
			public unsafe void* data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_tlsctx_callbacks.NativeFieldInfoPtr_data);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_tlsctx_callbacks.NativeFieldInfoPtr_data)) = value;
				}
			}

			// Token: 0x040012D9 RID: 4825
			private static readonly IntPtr NativeFieldInfoPtr_read;

			// Token: 0x040012DA RID: 4826
			private static readonly IntPtr NativeFieldInfoPtr_write;

			// Token: 0x040012DB RID: 4827
			private static readonly IntPtr NativeFieldInfoPtr_data;
		}

		// Token: 0x0200019E RID: 414
		public class unitytls_interface_struct : Object
		{
			// Token: 0x060017AE RID: 6062 RVA: 0x00068AA4 File Offset: 0x00066CA4
			// Note: this type is marked as 'beforefieldinit'.
			static unitytls_interface_struct()
			{
				Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_interface_struct");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr);
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_UNITYTLS_INVALID_HANDLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "UNITYTLS_INVALID_HANDLE");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_UNITYTLS_TLSCTX_PROTOCOLRANGE_DEFAULT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "UNITYTLS_TLSCTX_PROTOCOLRANGE_DEFAULT");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_errorstate_create = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_errorstate_create");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_errorstate_raise_error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_errorstate_raise_error");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_key_get_ref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_key_get_ref");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_key_parse_der = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_key_parse_der");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_key_parse_pem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_key_parse_pem");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_key_free = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_key_free");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509_export_der = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509_export_der");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_get_ref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509list_get_ref");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_get_x509 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509list_get_x509");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_create = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509list_create");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_append = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509list_append");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_append_der = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509list_append_der");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_append_pem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509list_append_pem");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_free = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509list_free");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509verify_default_ca = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509verify_default_ca");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509verify_explicit_ca = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509verify_explicit_ca");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_create_server = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_create_server");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_create_client = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_create_client");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_server_require_client_authentication = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_server_require_client_authentication");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_set_certificate_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_set_certificate_callback");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_set_trace_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_set_trace_callback");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_set_x509verify_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_set_x509verify_callback");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_set_supported_ciphersuites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_set_supported_ciphersuites");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_get_ciphersuite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_get_ciphersuite");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_get_protocol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_get_protocol");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_process_handshake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_process_handshake");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_read = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_read");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_write = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_write");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_notify_close = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_notify_close");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_free = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_free");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_random_generate_bytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_random_generate_bytes");
				UnityTls.unitytls_interface_struct.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, 100663333);
			}

			// Token: 0x060017AF RID: 6063 RVA: 0x00068D78 File Offset: 0x00066F78
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe unitytls_interface_struct()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060017B0 RID: 6064 RVA: 0x0000BD75 File Offset: 0x00009F75
			public unitytls_interface_struct(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700078C RID: 1932
			// (get) Token: 0x060017B1 RID: 6065 RVA: 0x00068DB4 File Offset: 0x00066FB4
			// (set) Token: 0x060017B2 RID: 6066 RVA: 0x0000BD7E File Offset: 0x00009F7E
			public unsafe ulong UNITYTLS_INVALID_HANDLE
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_UNITYTLS_INVALID_HANDLE);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_UNITYTLS_INVALID_HANDLE)) = value;
				}
			}

			// Token: 0x1700078D RID: 1933
			// (get) Token: 0x060017B3 RID: 6067 RVA: 0x00068DDC File Offset: 0x00066FDC
			// (set) Token: 0x060017B4 RID: 6068 RVA: 0x0000BD99 File Offset: 0x00009F99
			public unsafe UnityTls.unitytls_tlsctx_protocolrange UNITYTLS_TLSCTX_PROTOCOLRANGE_DEFAULT
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_UNITYTLS_TLSCTX_PROTOCOLRANGE_DEFAULT);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_UNITYTLS_TLSCTX_PROTOCOLRANGE_DEFAULT)) = value;
				}
			}

			// Token: 0x1700078E RID: 1934
			// (get) Token: 0x060017B5 RID: 6069 RVA: 0x00068E04 File Offset: 0x00067004
			// (set) Token: 0x060017B6 RID: 6070 RVA: 0x0000BDB4 File Offset: 0x00009FB4
			public unsafe UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t unitytls_errorstate_create
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_errorstate_create);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_errorstate_create), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700078F RID: 1935
			// (get) Token: 0x060017B7 RID: 6071 RVA: 0x00068E34 File Offset: 0x00067034
			// (set) Token: 0x060017B8 RID: 6072 RVA: 0x0000BDD3 File Offset: 0x00009FD3
			public unsafe UnityTls.unitytls_interface_struct.unitytls_errorstate_raise_error_t unitytls_errorstate_raise_error
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_errorstate_raise_error);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_errorstate_raise_error_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_errorstate_raise_error), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000790 RID: 1936
			// (get) Token: 0x060017B9 RID: 6073 RVA: 0x00068E64 File Offset: 0x00067064
			// (set) Token: 0x060017BA RID: 6074 RVA: 0x0000BDF2 File Offset: 0x00009FF2
			public unsafe UnityTls.unitytls_interface_struct.unitytls_key_get_ref_t unitytls_key_get_ref
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_key_get_ref);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_key_get_ref_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_key_get_ref), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000791 RID: 1937
			// (get) Token: 0x060017BB RID: 6075 RVA: 0x00068E94 File Offset: 0x00067094
			// (set) Token: 0x060017BC RID: 6076 RVA: 0x0000BE11 File Offset: 0x0000A011
			public unsafe UnityTls.unitytls_interface_struct.unitytls_key_parse_der_t unitytls_key_parse_der
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_key_parse_der);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_key_parse_der_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_key_parse_der), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000792 RID: 1938
			// (get) Token: 0x060017BD RID: 6077 RVA: 0x00068EC4 File Offset: 0x000670C4
			// (set) Token: 0x060017BE RID: 6078 RVA: 0x0000BE30 File Offset: 0x0000A030
			public unsafe UnityTls.unitytls_interface_struct.unitytls_key_parse_pem_t unitytls_key_parse_pem
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_key_parse_pem);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_key_parse_pem_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_key_parse_pem), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000793 RID: 1939
			// (get) Token: 0x060017BF RID: 6079 RVA: 0x00068EF4 File Offset: 0x000670F4
			// (set) Token: 0x060017C0 RID: 6080 RVA: 0x0000BE4F File Offset: 0x0000A04F
			public unsafe UnityTls.unitytls_interface_struct.unitytls_key_free_t unitytls_key_free
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_key_free);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_key_free_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_key_free), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000794 RID: 1940
			// (get) Token: 0x060017C1 RID: 6081 RVA: 0x00068F24 File Offset: 0x00067124
			// (set) Token: 0x060017C2 RID: 6082 RVA: 0x0000BE6E File Offset: 0x0000A06E
			public unsafe UnityTls.unitytls_interface_struct.unitytls_x509_export_der_t unitytls_x509_export_der
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509_export_der);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_x509_export_der_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509_export_der), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000795 RID: 1941
			// (get) Token: 0x060017C3 RID: 6083 RVA: 0x00068F54 File Offset: 0x00067154
			// (set) Token: 0x060017C4 RID: 6084 RVA: 0x0000BE8D File Offset: 0x0000A08D
			public unsafe UnityTls.unitytls_interface_struct.unitytls_x509list_get_ref_t unitytls_x509list_get_ref
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_get_ref);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_x509list_get_ref_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_get_ref), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000796 RID: 1942
			// (get) Token: 0x060017C5 RID: 6085 RVA: 0x00068F84 File Offset: 0x00067184
			// (set) Token: 0x060017C6 RID: 6086 RVA: 0x0000BEAC File Offset: 0x0000A0AC
			public unsafe UnityTls.unitytls_interface_struct.unitytls_x509list_get_x509_t unitytls_x509list_get_x509
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_get_x509);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_x509list_get_x509_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_get_x509), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000797 RID: 1943
			// (get) Token: 0x060017C7 RID: 6087 RVA: 0x00068FB4 File Offset: 0x000671B4
			// (set) Token: 0x060017C8 RID: 6088 RVA: 0x0000BECB File Offset: 0x0000A0CB
			public unsafe UnityTls.unitytls_interface_struct.unitytls_x509list_create_t unitytls_x509list_create
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_create);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_x509list_create_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_create), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000798 RID: 1944
			// (get) Token: 0x060017C9 RID: 6089 RVA: 0x00068FE4 File Offset: 0x000671E4
			// (set) Token: 0x060017CA RID: 6090 RVA: 0x0000BEEA File Offset: 0x0000A0EA
			public unsafe UnityTls.unitytls_interface_struct.unitytls_x509list_append_t unitytls_x509list_append
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_append);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_x509list_append_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_append), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000799 RID: 1945
			// (get) Token: 0x060017CB RID: 6091 RVA: 0x00069014 File Offset: 0x00067214
			// (set) Token: 0x060017CC RID: 6092 RVA: 0x0000BF09 File Offset: 0x0000A109
			public unsafe UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t unitytls_x509list_append_der
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_append_der);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_append_der), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700079A RID: 1946
			// (get) Token: 0x060017CD RID: 6093 RVA: 0x00069044 File Offset: 0x00067244
			// (set) Token: 0x060017CE RID: 6094 RVA: 0x0000BF28 File Offset: 0x0000A128
			public unsafe UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t unitytls_x509list_append_pem
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_append_pem);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_append_pem), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700079B RID: 1947
			// (get) Token: 0x060017CF RID: 6095 RVA: 0x00069074 File Offset: 0x00067274
			// (set) Token: 0x060017D0 RID: 6096 RVA: 0x0000BF47 File Offset: 0x0000A147
			public unsafe UnityTls.unitytls_interface_struct.unitytls_x509list_free_t unitytls_x509list_free
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_free);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_x509list_free_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_free), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700079C RID: 1948
			// (get) Token: 0x060017D1 RID: 6097 RVA: 0x000690A4 File Offset: 0x000672A4
			// (set) Token: 0x060017D2 RID: 6098 RVA: 0x0000BF66 File Offset: 0x0000A166
			public unsafe UnityTls.unitytls_interface_struct.unitytls_x509verify_default_ca_t unitytls_x509verify_default_ca
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509verify_default_ca);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_x509verify_default_ca_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509verify_default_ca), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700079D RID: 1949
			// (get) Token: 0x060017D3 RID: 6099 RVA: 0x000690D4 File Offset: 0x000672D4
			// (set) Token: 0x060017D4 RID: 6100 RVA: 0x0000BF85 File Offset: 0x0000A185
			public unsafe UnityTls.unitytls_interface_struct.unitytls_x509verify_explicit_ca_t unitytls_x509verify_explicit_ca
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509verify_explicit_ca);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_x509verify_explicit_ca_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509verify_explicit_ca), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700079E RID: 1950
			// (get) Token: 0x060017D5 RID: 6101 RVA: 0x00069104 File Offset: 0x00067304
			// (set) Token: 0x060017D6 RID: 6102 RVA: 0x0000BFA4 File Offset: 0x0000A1A4
			public unsafe UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_server_t unitytls_tlsctx_create_server
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_create_server);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_server_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_create_server), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700079F RID: 1951
			// (get) Token: 0x060017D7 RID: 6103 RVA: 0x00069134 File Offset: 0x00067334
			// (set) Token: 0x060017D8 RID: 6104 RVA: 0x0000BFC3 File Offset: 0x0000A1C3
			public unsafe UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_client_t unitytls_tlsctx_create_client
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_create_client);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_client_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_create_client), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007A0 RID: 1952
			// (get) Token: 0x060017D9 RID: 6105 RVA: 0x00069164 File Offset: 0x00067364
			// (set) Token: 0x060017DA RID: 6106 RVA: 0x0000BFE2 File Offset: 0x0000A1E2
			public unsafe UnityTls.unitytls_interface_struct.unitytls_tlsctx_server_require_client_authentication_t unitytls_tlsctx_server_require_client_authentication
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_server_require_client_authentication);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_tlsctx_server_require_client_authentication_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_server_require_client_authentication), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007A1 RID: 1953
			// (get) Token: 0x060017DB RID: 6107 RVA: 0x00069194 File Offset: 0x00067394
			// (set) Token: 0x060017DC RID: 6108 RVA: 0x0000C001 File Offset: 0x0000A201
			public unsafe UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_certificate_callback_t unitytls_tlsctx_set_certificate_callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_set_certificate_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_certificate_callback_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_set_certificate_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007A2 RID: 1954
			// (get) Token: 0x060017DD RID: 6109 RVA: 0x000691C4 File Offset: 0x000673C4
			// (set) Token: 0x060017DE RID: 6110 RVA: 0x0000C020 File Offset: 0x0000A220
			public unsafe UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_callback_t unitytls_tlsctx_set_trace_callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_set_trace_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_callback_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_set_trace_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007A3 RID: 1955
			// (get) Token: 0x060017DF RID: 6111 RVA: 0x000691F4 File Offset: 0x000673F4
			// (set) Token: 0x060017E0 RID: 6112 RVA: 0x0000C03F File Offset: 0x0000A23F
			public unsafe UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_x509verify_callback_t unitytls_tlsctx_set_x509verify_callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_set_x509verify_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_x509verify_callback_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_set_x509verify_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007A4 RID: 1956
			// (get) Token: 0x060017E1 RID: 6113 RVA: 0x00069224 File Offset: 0x00067424
			// (set) Token: 0x060017E2 RID: 6114 RVA: 0x0000C05E File Offset: 0x0000A25E
			public unsafe UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_supported_ciphersuites_t unitytls_tlsctx_set_supported_ciphersuites
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_set_supported_ciphersuites);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_supported_ciphersuites_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_set_supported_ciphersuites), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007A5 RID: 1957
			// (get) Token: 0x060017E3 RID: 6115 RVA: 0x00069254 File Offset: 0x00067454
			// (set) Token: 0x060017E4 RID: 6116 RVA: 0x0000C07D File Offset: 0x0000A27D
			public unsafe UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_ciphersuite_t unitytls_tlsctx_get_ciphersuite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_get_ciphersuite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_ciphersuite_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_get_ciphersuite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007A6 RID: 1958
			// (get) Token: 0x060017E5 RID: 6117 RVA: 0x00069284 File Offset: 0x00067484
			// (set) Token: 0x060017E6 RID: 6118 RVA: 0x0000C09C File Offset: 0x0000A29C
			public unsafe UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_protocol_t unitytls_tlsctx_get_protocol
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_get_protocol);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_protocol_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_get_protocol), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007A7 RID: 1959
			// (get) Token: 0x060017E7 RID: 6119 RVA: 0x000692B4 File Offset: 0x000674B4
			// (set) Token: 0x060017E8 RID: 6120 RVA: 0x0000C0BB File Offset: 0x0000A2BB
			public unsafe UnityTls.unitytls_interface_struct.unitytls_tlsctx_process_handshake_t unitytls_tlsctx_process_handshake
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_process_handshake);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_tlsctx_process_handshake_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_process_handshake), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007A8 RID: 1960
			// (get) Token: 0x060017E9 RID: 6121 RVA: 0x000692E4 File Offset: 0x000674E4
			// (set) Token: 0x060017EA RID: 6122 RVA: 0x0000C0DA File Offset: 0x0000A2DA
			public unsafe UnityTls.unitytls_interface_struct.unitytls_tlsctx_read_t unitytls_tlsctx_read
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_read);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_tlsctx_read_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_read), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007A9 RID: 1961
			// (get) Token: 0x060017EB RID: 6123 RVA: 0x00069314 File Offset: 0x00067514
			// (set) Token: 0x060017EC RID: 6124 RVA: 0x0000C0F9 File Offset: 0x0000A2F9
			public unsafe UnityTls.unitytls_interface_struct.unitytls_tlsctx_write_t unitytls_tlsctx_write
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_write);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_tlsctx_write_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_write), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007AA RID: 1962
			// (get) Token: 0x060017ED RID: 6125 RVA: 0x00069344 File Offset: 0x00067544
			// (set) Token: 0x060017EE RID: 6126 RVA: 0x0000C118 File Offset: 0x0000A318
			public unsafe UnityTls.unitytls_interface_struct.unitytls_tlsctx_notify_close_t unitytls_tlsctx_notify_close
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_notify_close);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_tlsctx_notify_close_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_notify_close), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007AB RID: 1963
			// (get) Token: 0x060017EF RID: 6127 RVA: 0x00069374 File Offset: 0x00067574
			// (set) Token: 0x060017F0 RID: 6128 RVA: 0x0000C137 File Offset: 0x0000A337
			public unsafe UnityTls.unitytls_interface_struct.unitytls_tlsctx_free_t unitytls_tlsctx_free
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_free);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_tlsctx_free_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_free), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007AC RID: 1964
			// (get) Token: 0x060017F1 RID: 6129 RVA: 0x000693A4 File Offset: 0x000675A4
			// (set) Token: 0x060017F2 RID: 6130 RVA: 0x0000C156 File Offset: 0x0000A356
			public unsafe UnityTls.unitytls_interface_struct.unitytls_random_generate_bytes_t unitytls_random_generate_bytes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_random_generate_bytes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_random_generate_bytes_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_random_generate_bytes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040012DC RID: 4828
			private static readonly IntPtr NativeFieldInfoPtr_UNITYTLS_INVALID_HANDLE;

			// Token: 0x040012DD RID: 4829
			private static readonly IntPtr NativeFieldInfoPtr_UNITYTLS_TLSCTX_PROTOCOLRANGE_DEFAULT;

			// Token: 0x040012DE RID: 4830
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_errorstate_create;

			// Token: 0x040012DF RID: 4831
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_errorstate_raise_error;

			// Token: 0x040012E0 RID: 4832
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_key_get_ref;

			// Token: 0x040012E1 RID: 4833
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_key_parse_der;

			// Token: 0x040012E2 RID: 4834
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_key_parse_pem;

			// Token: 0x040012E3 RID: 4835
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_key_free;

			// Token: 0x040012E4 RID: 4836
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_x509_export_der;

			// Token: 0x040012E5 RID: 4837
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_x509list_get_ref;

			// Token: 0x040012E6 RID: 4838
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_x509list_get_x509;

			// Token: 0x040012E7 RID: 4839
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_x509list_create;

			// Token: 0x040012E8 RID: 4840
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_x509list_append;

			// Token: 0x040012E9 RID: 4841
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_x509list_append_der;

			// Token: 0x040012EA RID: 4842
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_x509list_append_pem;

			// Token: 0x040012EB RID: 4843
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_x509list_free;

			// Token: 0x040012EC RID: 4844
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_x509verify_default_ca;

			// Token: 0x040012ED RID: 4845
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_x509verify_explicit_ca;

			// Token: 0x040012EE RID: 4846
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_tlsctx_create_server;

			// Token: 0x040012EF RID: 4847
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_tlsctx_create_client;

			// Token: 0x040012F0 RID: 4848
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_tlsctx_server_require_client_authentication;

			// Token: 0x040012F1 RID: 4849
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_tlsctx_set_certificate_callback;

			// Token: 0x040012F2 RID: 4850
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_tlsctx_set_trace_callback;

			// Token: 0x040012F3 RID: 4851
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_tlsctx_set_x509verify_callback;

			// Token: 0x040012F4 RID: 4852
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_tlsctx_set_supported_ciphersuites;

			// Token: 0x040012F5 RID: 4853
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_tlsctx_get_ciphersuite;

			// Token: 0x040012F6 RID: 4854
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_tlsctx_get_protocol;

			// Token: 0x040012F7 RID: 4855
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_tlsctx_process_handshake;

			// Token: 0x040012F8 RID: 4856
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_tlsctx_read;

			// Token: 0x040012F9 RID: 4857
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_tlsctx_write;

			// Token: 0x040012FA RID: 4858
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_tlsctx_notify_close;

			// Token: 0x040012FB RID: 4859
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_tlsctx_free;

			// Token: 0x040012FC RID: 4860
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_random_generate_bytes;

			// Token: 0x040012FD RID: 4861
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0200021E RID: 542
			public sealed class unitytls_errorstate_create_t : MulticastDelegate
			{
				// Token: 0x06001D9F RID: 7583 RVA: 0x000780B4 File Offset: 0x000762B4
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_errorstate_create_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_errorstate_create_t");
					UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t>.NativeClassPtr, 100663334);
					UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t>.NativeClassPtr, 100663335);
					UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t>.NativeClassPtr, 100663336);
					UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_unitytls_errorstate_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t>.NativeClassPtr, 100663337);
				}

				// Token: 0x06001DA0 RID: 7584 RVA: 0x00078128 File Offset: 0x00076328
				[CallerCount(42)]
				[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_errorstate_create_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001DA1 RID: 7585 RVA: 0x00078184 File Offset: 0x00076384
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 363902, RefRangeEnd = 363912, XrefRangeStart = 363902, XrefRangeEnd = 363902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe UnityTls.unitytls_errorstate Invoke()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06001DA2 RID: 7586 RVA: 0x000781C0 File Offset: 0x000763C0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06001DA3 RID: 7587 RVA: 0x00078224 File Offset: 0x00076424
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe UnityTls.unitytls_errorstate EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_unitytls_errorstate_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x06001DA4 RID: 7588 RVA: 0x00010405 File Offset: 0x0000E605
				public unitytls_errorstate_create_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06001DA5 RID: 7589 RVA: 0x0001040E File Offset: 0x0000E60E
				public static implicit operator UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t(Func<UnityTls.unitytls_errorstate> A_0)
				{
					return DelegateSupport.ConvertDelegate<UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t>(A_0);
				}

				// Token: 0x06001DA6 RID: 7590 RVA: 0x00010416 File Offset: 0x0000E616
				public static UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t operator +(UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t A_0, UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t>();
				}

				// Token: 0x06001DA7 RID: 7591 RVA: 0x00010424 File Offset: 0x0000E624
				public static UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t operator -(UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t A_0, UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t>();
					}
					return delegate2;
				}

				// Token: 0x04001666 RID: 5734
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001667 RID: 5735
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_errorstate_0;

				// Token: 0x04001668 RID: 5736
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

				// Token: 0x04001669 RID: 5737
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_unitytls_errorstate_IAsyncResult_0;
			}

			// Token: 0x0200021F RID: 543
			public sealed class unitytls_errorstate_raise_error_t : MulticastDelegate
			{
				// Token: 0x06001DA8 RID: 7592 RVA: 0x00078274 File Offset: 0x00076474
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_errorstate_raise_error_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_errorstate_raise_error_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_errorstate_raise_error_t");
					UnityTls.unitytls_interface_struct.unitytls_errorstate_raise_error_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_errorstate_raise_error_t>.NativeClassPtr, 100663338);
					UnityTls.unitytls_interface_struct.unitytls_errorstate_raise_error_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_errorstate_unitytls_error_code_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_errorstate_raise_error_t>.NativeClassPtr, 100663339);
					UnityTls.unitytls_interface_struct.unitytls_errorstate_raise_error_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_errorstate_unitytls_error_code_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_errorstate_raise_error_t>.NativeClassPtr, 100663340);
					UnityTls.unitytls_interface_struct.unitytls_errorstate_raise_error_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_errorstate_raise_error_t>.NativeClassPtr, 100663341);
				}

				// Token: 0x06001DA9 RID: 7593 RVA: 0x000782E8 File Offset: 0x000764E8
				[CallerCount(42)]
				[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_errorstate_raise_error_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_errorstate_raise_error_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_errorstate_raise_error_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001DAA RID: 7594 RVA: 0x00078344 File Offset: 0x00076544
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 363912, RefRangeEnd = 363919, XrefRangeStart = 363912, XrefRangeEnd = 363912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void Invoke(UnityTls.unitytls_errorstate* errorState, UnityTls.unitytls_error_code errorCode)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = errorState;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref errorCode;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_errorstate_raise_error_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_errorstate_unitytls_error_code_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001DAB RID: 7595 RVA: 0x00078390 File Offset: 0x00076590
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363919, XrefRangeEnd = 363923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(UnityTls.unitytls_errorstate* errorState, UnityTls.unitytls_error_code errorCode, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = errorState;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref errorCode;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_errorstate_raise_error_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_errorstate_unitytls_error_code_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06001DAC RID: 7596 RVA: 0x00078410 File Offset: 0x00076610
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_errorstate_raise_error_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06001DAD RID: 7597 RVA: 0x00010435 File Offset: 0x0000E635
				public unitytls_errorstate_raise_error_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0400166A RID: 5738
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x0400166B RID: 5739
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_errorstate_unitytls_error_code_0;

				// Token: 0x0400166C RID: 5740
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_errorstate_unitytls_error_code_AsyncCallback_Object_0;

				// Token: 0x0400166D RID: 5741
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x02000220 RID: 544
			public sealed class unitytls_key_get_ref_t : MulticastDelegate
			{
				// Token: 0x06001DAE RID: 7598 RVA: 0x00078454 File Offset: 0x00076654
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_key_get_ref_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_key_get_ref_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_key_get_ref_t");
					UnityTls.unitytls_interface_struct.unitytls_key_get_ref_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_key_get_ref_t>.NativeClassPtr, 100663342);
					UnityTls.unitytls_interface_struct.unitytls_key_get_ref_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_key_ref_ptr_unitytls_key_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_key_get_ref_t>.NativeClassPtr, 100663343);
					UnityTls.unitytls_interface_struct.unitytls_key_get_ref_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_key_ptr_unitytls_errorstate_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_key_get_ref_t>.NativeClassPtr, 100663344);
					UnityTls.unitytls_interface_struct.unitytls_key_get_ref_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_unitytls_key_ref_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_key_get_ref_t>.NativeClassPtr, 100663345);
				}

				// Token: 0x06001DAF RID: 7599 RVA: 0x000784C8 File Offset: 0x000766C8
				[CallerCount(42)]
				[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_key_get_ref_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_key_get_ref_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_key_get_ref_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001DB0 RID: 7600 RVA: 0x00078524 File Offset: 0x00076724
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 363923, RefRangeEnd = 363930, XrefRangeStart = 363923, XrefRangeEnd = 363923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe UnityTls.unitytls_key_ref Invoke(UnityTls.unitytls_key* key, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = key;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_key_get_ref_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_key_ref_ptr_unitytls_key_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06001DB1 RID: 7601 RVA: 0x0007857C File Offset: 0x0007677C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(UnityTls.unitytls_key* key, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = key;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_key_get_ref_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_key_ptr_unitytls_errorstate_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06001DB2 RID: 7602 RVA: 0x000785FC File Offset: 0x000767FC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe UnityTls.unitytls_key_ref EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_key_get_ref_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_unitytls_key_ref_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x06001DB3 RID: 7603 RVA: 0x0001043E File Offset: 0x0000E63E
				public unitytls_key_get_ref_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0400166E RID: 5742
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x0400166F RID: 5743
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_key_ref_ptr_unitytls_key_ptr_unitytls_errorstate_0;

				// Token: 0x04001670 RID: 5744
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_key_ptr_unitytls_errorstate_AsyncCallback_Object_0;

				// Token: 0x04001671 RID: 5745
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_unitytls_key_ref_IAsyncResult_0;
			}

			// Token: 0x02000221 RID: 545
			public sealed class unitytls_key_parse_der_t : MulticastDelegate
			{
				// Token: 0x06001DB4 RID: 7604 RVA: 0x0007864C File Offset: 0x0007684C
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_key_parse_der_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_key_parse_der_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_key_parse_der_t");
					UnityTls.unitytls_interface_struct.unitytls_key_parse_der_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_key_parse_der_t>.NativeClassPtr, 100663346);
					UnityTls.unitytls_interface_struct.unitytls_key_parse_der_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_key_ptr_Byte_IntPtr_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_key_parse_der_t>.NativeClassPtr, 100663347);
					UnityTls.unitytls_interface_struct.unitytls_key_parse_der_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Byte_IntPtr_ptr_Byte_IntPtr_ptr_unitytls_errorstate_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_key_parse_der_t>.NativeClassPtr, 100663348);
					UnityTls.unitytls_interface_struct.unitytls_key_parse_der_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_ptr_unitytls_key_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_key_parse_der_t>.NativeClassPtr, 100663349);
				}

				// Token: 0x06001DB5 RID: 7605 RVA: 0x000786C0 File Offset: 0x000768C0
				[CallerCount(42)]
				[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_key_parse_der_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_key_parse_der_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_key_parse_der_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001DB6 RID: 7606 RVA: 0x0007871C File Offset: 0x0007691C
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 363930, RefRangeEnd = 363931, XrefRangeStart = 363930, XrefRangeEnd = 363930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe UnityTls.unitytls_key* Invoke(byte* buffer, IntPtr bufferLen, byte* password, IntPtr passwordLen, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = buffer;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferLen;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = password;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref passwordLen;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_key_parse_der_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_key_ptr_Byte_IntPtr_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}

				// Token: 0x06001DB7 RID: 7607 RVA: 0x00078794 File Offset: 0x00076994
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363931, XrefRangeEnd = 363937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(byte* buffer, IntPtr bufferLen, byte* password, IntPtr passwordLen, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
						*ptr = buffer;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferLen;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = password;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref passwordLen;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_key_parse_der_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Byte_IntPtr_ptr_Byte_IntPtr_ptr_unitytls_errorstate_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06001DB8 RID: 7608 RVA: 0x0007883C File Offset: 0x00076A3C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe UnityTls.unitytls_key* EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_key_parse_der_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_ptr_unitytls_key_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return intPtr;
					}
				}

				// Token: 0x06001DB9 RID: 7609 RVA: 0x00010447 File Offset: 0x0000E647
				public unitytls_key_parse_der_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001672 RID: 5746
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001673 RID: 5747
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_key_ptr_Byte_IntPtr_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0;

				// Token: 0x04001674 RID: 5748
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Byte_IntPtr_ptr_Byte_IntPtr_ptr_unitytls_errorstate_AsyncCallback_Object_0;

				// Token: 0x04001675 RID: 5749
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_ptr_unitytls_key_IAsyncResult_0;
			}

			// Token: 0x02000222 RID: 546
			public sealed class unitytls_key_parse_pem_t : MulticastDelegate
			{
				// Token: 0x06001DBA RID: 7610 RVA: 0x00078880 File Offset: 0x00076A80
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_key_parse_pem_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_key_parse_pem_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_key_parse_pem_t");
					UnityTls.unitytls_interface_struct.unitytls_key_parse_pem_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_key_parse_pem_t>.NativeClassPtr, 100663350);
					UnityTls.unitytls_interface_struct.unitytls_key_parse_pem_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_key_ptr_Byte_IntPtr_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_key_parse_pem_t>.NativeClassPtr, 100663351);
					UnityTls.unitytls_interface_struct.unitytls_key_parse_pem_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Byte_IntPtr_ptr_Byte_IntPtr_ptr_unitytls_errorstate_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_key_parse_pem_t>.NativeClassPtr, 100663352);
					UnityTls.unitytls_interface_struct.unitytls_key_parse_pem_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_ptr_unitytls_key_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_key_parse_pem_t>.NativeClassPtr, 100663353);
				}

				// Token: 0x06001DBB RID: 7611 RVA: 0x000788F4 File Offset: 0x00076AF4
				[CallerCount(42)]
				[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_key_parse_pem_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_key_parse_pem_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_key_parse_pem_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001DBC RID: 7612 RVA: 0x00078950 File Offset: 0x00076B50
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 363930, RefRangeEnd = 363931, XrefRangeStart = 363930, XrefRangeEnd = 363931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe UnityTls.unitytls_key* Invoke(byte* buffer, IntPtr bufferLen, byte* password, IntPtr passwordLen, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = buffer;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferLen;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = password;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref passwordLen;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_key_parse_pem_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_key_ptr_Byte_IntPtr_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}

				// Token: 0x06001DBD RID: 7613 RVA: 0x000789C8 File Offset: 0x00076BC8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363937, XrefRangeEnd = 363943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(byte* buffer, IntPtr bufferLen, byte* password, IntPtr passwordLen, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
						*ptr = buffer;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferLen;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = password;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref passwordLen;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_key_parse_pem_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Byte_IntPtr_ptr_Byte_IntPtr_ptr_unitytls_errorstate_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06001DBE RID: 7614 RVA: 0x00078A70 File Offset: 0x00076C70
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe UnityTls.unitytls_key* EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_key_parse_pem_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_ptr_unitytls_key_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return intPtr;
					}
				}

				// Token: 0x06001DBF RID: 7615 RVA: 0x00010450 File Offset: 0x0000E650
				public unitytls_key_parse_pem_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001676 RID: 5750
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001677 RID: 5751
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_key_ptr_Byte_IntPtr_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0;

				// Token: 0x04001678 RID: 5752
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Byte_IntPtr_ptr_Byte_IntPtr_ptr_unitytls_errorstate_AsyncCallback_Object_0;

				// Token: 0x04001679 RID: 5753
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_ptr_unitytls_key_IAsyncResult_0;
			}

			// Token: 0x02000223 RID: 547
			public sealed class unitytls_key_free_t : MulticastDelegate
			{
				// Token: 0x06001DC0 RID: 7616 RVA: 0x00078AB4 File Offset: 0x00076CB4
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_key_free_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_key_free_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_key_free_t");
					UnityTls.unitytls_interface_struct.unitytls_key_free_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_key_free_t>.NativeClassPtr, 100663354);
					UnityTls.unitytls_interface_struct.unitytls_key_free_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_key_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_key_free_t>.NativeClassPtr, 100663355);
					UnityTls.unitytls_interface_struct.unitytls_key_free_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_key_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_key_free_t>.NativeClassPtr, 100663356);
					UnityTls.unitytls_interface_struct.unitytls_key_free_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_key_free_t>.NativeClassPtr, 100663357);
				}

				// Token: 0x06001DC1 RID: 7617 RVA: 0x00078B28 File Offset: 0x00076D28
				[CallerCount(42)]
				[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_key_free_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_key_free_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_key_free_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001DC2 RID: 7618 RVA: 0x00078B84 File Offset: 0x00076D84
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 363943, RefRangeEnd = 363953, XrefRangeStart = 363943, XrefRangeEnd = 363943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void Invoke(UnityTls.unitytls_key* key)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = key;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_key_free_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_key_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06001DC3 RID: 7619 RVA: 0x00078BC4 File Offset: 0x00076DC4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(UnityTls.unitytls_key* key, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = key;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_key_free_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_key_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06001DC4 RID: 7620 RVA: 0x00078C34 File Offset: 0x00076E34
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_key_free_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06001DC5 RID: 7621 RVA: 0x00010459 File Offset: 0x0000E659
				public unitytls_key_free_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0400167A RID: 5754
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x0400167B RID: 5755
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_key_0;

				// Token: 0x0400167C RID: 5756
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_key_AsyncCallback_Object_0;

				// Token: 0x0400167D RID: 5757
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x02000224 RID: 548
			public sealed class unitytls_x509_export_der_t : MulticastDelegate
			{
				// Token: 0x06001DC6 RID: 7622 RVA: 0x00078C78 File Offset: 0x00076E78
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_x509_export_der_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509_export_der_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509_export_der_t");
					UnityTls.unitytls_interface_struct.unitytls_x509_export_der_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509_export_der_t>.NativeClassPtr, 100663358);
					UnityTls.unitytls_interface_struct.unitytls_x509_export_der_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_unitytls_x509_ref_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509_export_der_t>.NativeClassPtr, 100663359);
					UnityTls.unitytls_interface_struct.unitytls_x509_export_der_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_unitytls_x509_ref_ptr_Byte_IntPtr_ptr_unitytls_errorstate_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509_export_der_t>.NativeClassPtr, 100663360);
					UnityTls.unitytls_interface_struct.unitytls_x509_export_der_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509_export_der_t>.NativeClassPtr, 100663361);
				}

				// Token: 0x06001DC7 RID: 7623 RVA: 0x00078CEC File Offset: 0x00076EEC
				[CallerCount(42)]
				[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_x509_export_der_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509_export_der_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509_export_der_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001DC8 RID: 7624 RVA: 0x00078D48 File Offset: 0x00076F48
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 363953, RefRangeEnd = 363955, XrefRangeStart = 363953, XrefRangeEnd = 363953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IntPtr Invoke(UnityTls.unitytls_x509_ref cert, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref cert;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = buffer;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferLen;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509_export_der_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_unitytls_x509_ref_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06001DC9 RID: 7625 RVA: 0x00078DBC File Offset: 0x00076FBC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363955, XrefRangeEnd = 363962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(UnityTls.unitytls_x509_ref cert, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref cert;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = buffer;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferLen;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509_export_der_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_unitytls_x509_ref_ptr_Byte_IntPtr_ptr_unitytls_errorstate_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06001DCA RID: 7626 RVA: 0x00078E58 File Offset: 0x00077058
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IntPtr EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509_export_der_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x06001DCB RID: 7627 RVA: 0x00010462 File Offset: 0x0000E662
				public unitytls_x509_export_der_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0400167E RID: 5758
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x0400167F RID: 5759
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_unitytls_x509_ref_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0;

				// Token: 0x04001680 RID: 5760
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_unitytls_x509_ref_ptr_Byte_IntPtr_ptr_unitytls_errorstate_AsyncCallback_Object_0;

				// Token: 0x04001681 RID: 5761
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0;
			}

			// Token: 0x02000225 RID: 549
			public sealed class unitytls_x509list_get_ref_t : MulticastDelegate
			{
				// Token: 0x06001DCC RID: 7628 RVA: 0x00078EA8 File Offset: 0x000770A8
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_x509list_get_ref_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_get_ref_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509list_get_ref_t");
					UnityTls.unitytls_interface_struct.unitytls_x509list_get_ref_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_get_ref_t>.NativeClassPtr, 100663362);
					UnityTls.unitytls_interface_struct.unitytls_x509list_get_ref_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509list_ref_ptr_unitytls_x509list_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_get_ref_t>.NativeClassPtr, 100663363);
					UnityTls.unitytls_interface_struct.unitytls_x509list_get_ref_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_x509list_ptr_unitytls_errorstate_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_get_ref_t>.NativeClassPtr, 100663364);
					UnityTls.unitytls_interface_struct.unitytls_x509list_get_ref_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_unitytls_x509list_ref_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_get_ref_t>.NativeClassPtr, 100663365);
				}

				// Token: 0x06001DCD RID: 7629 RVA: 0x00078F1C File Offset: 0x0007711C
				[CallerCount(42)]
				[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_x509list_get_ref_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_get_ref_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509list_get_ref_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001DCE RID: 7630 RVA: 0x00078F78 File Offset: 0x00077178
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 363923, RefRangeEnd = 363930, XrefRangeStart = 363923, XrefRangeEnd = 363930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe UnityTls.unitytls_x509list_ref Invoke(UnityTls.unitytls_x509list* list, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = list;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509list_get_ref_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509list_ref_ptr_unitytls_x509list_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06001DCF RID: 7631 RVA: 0x00078FD0 File Offset: 0x000771D0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(UnityTls.unitytls_x509list* list, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = list;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509list_get_ref_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_x509list_ptr_unitytls_errorstate_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06001DD0 RID: 7632 RVA: 0x00079050 File Offset: 0x00077250
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe UnityTls.unitytls_x509list_ref EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509list_get_ref_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_unitytls_x509list_ref_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x06001DD1 RID: 7633 RVA: 0x0001046B File Offset: 0x0000E66B
				public unitytls_x509list_get_ref_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001682 RID: 5762
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001683 RID: 5763
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509list_ref_ptr_unitytls_x509list_ptr_unitytls_errorstate_0;

				// Token: 0x04001684 RID: 5764
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_x509list_ptr_unitytls_errorstate_AsyncCallback_Object_0;

				// Token: 0x04001685 RID: 5765
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_unitytls_x509list_ref_IAsyncResult_0;
			}

			// Token: 0x02000226 RID: 550
			public sealed class unitytls_x509list_get_x509_t : MulticastDelegate
			{
				// Token: 0x06001DD2 RID: 7634 RVA: 0x000790A0 File Offset: 0x000772A0
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_x509list_get_x509_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_get_x509_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509list_get_x509_t");
					UnityTls.unitytls_interface_struct.unitytls_x509list_get_x509_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_get_x509_t>.NativeClassPtr, 100663366);
					UnityTls.unitytls_interface_struct.unitytls_x509list_get_x509_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509_ref_unitytls_x509list_ref_IntPtr_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_get_x509_t>.NativeClassPtr, 100663367);
					UnityTls.unitytls_interface_struct.unitytls_x509list_get_x509_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_unitytls_x509list_ref_IntPtr_ptr_unitytls_errorstate_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_get_x509_t>.NativeClassPtr, 100663368);
					UnityTls.unitytls_interface_struct.unitytls_x509list_get_x509_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_unitytls_x509_ref_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_get_x509_t>.NativeClassPtr, 100663369);
				}

				// Token: 0x06001DD3 RID: 7635 RVA: 0x00079114 File Offset: 0x00077314
				[CallerCount(42)]
				[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_x509list_get_x509_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_get_x509_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509list_get_x509_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001DD4 RID: 7636 RVA: 0x00079170 File Offset: 0x00077370
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 363962, RefRangeEnd = 363965, XrefRangeStart = 363962, XrefRangeEnd = 363962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe UnityTls.unitytls_x509_ref Invoke(UnityTls.unitytls_x509list_ref list, IntPtr index, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref list;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509list_get_x509_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509_ref_unitytls_x509list_ref_IntPtr_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06001DD5 RID: 7637 RVA: 0x000791D4 File Offset: 0x000773D4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363965, XrefRangeEnd = 363972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(UnityTls.unitytls_x509list_ref list, IntPtr index, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref list;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509list_get_x509_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_unitytls_x509list_ref_IntPtr_ptr_unitytls_errorstate_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06001DD6 RID: 7638 RVA: 0x00079264 File Offset: 0x00077464
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe UnityTls.unitytls_x509_ref EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509list_get_x509_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_unitytls_x509_ref_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x06001DD7 RID: 7639 RVA: 0x00010474 File Offset: 0x0000E674
				public unitytls_x509list_get_x509_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001686 RID: 5766
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001687 RID: 5767
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509_ref_unitytls_x509list_ref_IntPtr_ptr_unitytls_errorstate_0;

				// Token: 0x04001688 RID: 5768
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_unitytls_x509list_ref_IntPtr_ptr_unitytls_errorstate_AsyncCallback_Object_0;

				// Token: 0x04001689 RID: 5769
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_unitytls_x509_ref_IAsyncResult_0;
			}

			// Token: 0x02000227 RID: 551
			public sealed class unitytls_x509list_create_t : MulticastDelegate
			{
				// Token: 0x06001DD8 RID: 7640 RVA: 0x000792B4 File Offset: 0x000774B4
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_x509list_create_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_create_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509list_create_t");
					UnityTls.unitytls_interface_struct.unitytls_x509list_create_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_create_t>.NativeClassPtr, 100663370);
					UnityTls.unitytls_interface_struct.unitytls_x509list_create_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_x509list_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_create_t>.NativeClassPtr, 100663371);
					UnityTls.unitytls_interface_struct.unitytls_x509list_create_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_errorstate_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_create_t>.NativeClassPtr, 100663372);
					UnityTls.unitytls_interface_struct.unitytls_x509list_create_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_ptr_unitytls_x509list_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_create_t>.NativeClassPtr, 100663373);
				}

				// Token: 0x06001DD9 RID: 7641 RVA: 0x00079328 File Offset: 0x00077528
				[CallerCount(42)]
				[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_x509list_create_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_create_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509list_create_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001DDA RID: 7642 RVA: 0x00079384 File Offset: 0x00077584
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 363972, RefRangeEnd = 363976, XrefRangeStart = 363972, XrefRangeEnd = 363972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe UnityTls.unitytls_x509list* Invoke(UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = errorState;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509list_create_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_x509list_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return intPtr;
					}
				}

				// Token: 0x06001DDB RID: 7643 RVA: 0x000793C4 File Offset: 0x000775C4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = errorState;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509list_create_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_errorstate_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06001DDC RID: 7644 RVA: 0x00079434 File Offset: 0x00077634
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe UnityTls.unitytls_x509list* EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509list_create_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_ptr_unitytls_x509list_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return intPtr;
					}
				}

				// Token: 0x06001DDD RID: 7645 RVA: 0x0001047D File Offset: 0x0000E67D
				public unitytls_x509list_create_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0400168A RID: 5770
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x0400168B RID: 5771
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_x509list_ptr_unitytls_errorstate_0;

				// Token: 0x0400168C RID: 5772
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_errorstate_AsyncCallback_Object_0;

				// Token: 0x0400168D RID: 5773
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_ptr_unitytls_x509list_IAsyncResult_0;
			}

			// Token: 0x02000228 RID: 552
			public sealed class unitytls_x509list_append_t : MulticastDelegate
			{
				// Token: 0x06001DDE RID: 7646 RVA: 0x00079478 File Offset: 0x00077678
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_x509list_append_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_append_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509list_append_t");
					UnityTls.unitytls_interface_struct.unitytls_x509list_append_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_append_t>.NativeClassPtr, 100663374);
					UnityTls.unitytls_interface_struct.unitytls_x509list_append_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_x509list_unitytls_x509_ref_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_append_t>.NativeClassPtr, 100663375);
					UnityTls.unitytls_interface_struct.unitytls_x509list_append_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_x509list_unitytls_x509_ref_ptr_unitytls_errorstate_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_append_t>.NativeClassPtr, 100663376);
					UnityTls.unitytls_interface_struct.unitytls_x509list_append_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_append_t>.NativeClassPtr, 100663377);
				}

				// Token: 0x06001DDF RID: 7647 RVA: 0x000794EC File Offset: 0x000776EC
				[CallerCount(42)]
				[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_x509list_append_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_append_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509list_append_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001DE0 RID: 7648 RVA: 0x00079548 File Offset: 0x00077748
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 363976, RefRangeEnd = 363977, XrefRangeStart = 363976, XrefRangeEnd = 363976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void Invoke(UnityTls.unitytls_x509list* list, UnityTls.unitytls_x509_ref cert, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = list;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cert;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509list_append_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_x509list_unitytls_x509_ref_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001DE1 RID: 7649 RVA: 0x000795A0 File Offset: 0x000777A0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363977, XrefRangeEnd = 363981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(UnityTls.unitytls_x509list* list, UnityTls.unitytls_x509_ref cert, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = list;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cert;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509list_append_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_x509list_unitytls_x509_ref_ptr_unitytls_errorstate_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06001DE2 RID: 7650 RVA: 0x0007962C File Offset: 0x0007782C
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509list_append_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06001DE3 RID: 7651 RVA: 0x00010486 File Offset: 0x0000E686
				public unitytls_x509list_append_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0400168E RID: 5774
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x0400168F RID: 5775
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_x509list_unitytls_x509_ref_ptr_unitytls_errorstate_0;

				// Token: 0x04001690 RID: 5776
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_x509list_unitytls_x509_ref_ptr_unitytls_errorstate_AsyncCallback_Object_0;

				// Token: 0x04001691 RID: 5777
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x02000229 RID: 553
			public sealed class unitytls_x509list_append_der_t : MulticastDelegate
			{
				// Token: 0x06001DE4 RID: 7652 RVA: 0x00079670 File Offset: 0x00077870
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_x509list_append_der_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509list_append_der_t");
					UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t>.NativeClassPtr, 100663378);
					UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_x509list_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t>.NativeClassPtr, 100663379);
					UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_x509list_ptr_Byte_IntPtr_ptr_unitytls_errorstate_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t>.NativeClassPtr, 100663380);
					UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t>.NativeClassPtr, 100663381);
				}

				// Token: 0x06001DE5 RID: 7653 RVA: 0x000796E4 File Offset: 0x000778E4
				[CallerCount(42)]
				[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_x509list_append_der_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001DE6 RID: 7654 RVA: 0x00079740 File Offset: 0x00077940
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 363884, RefRangeEnd = 363888, XrefRangeStart = 363884, XrefRangeEnd = 363888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void Invoke(UnityTls.unitytls_x509list* list, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = list;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = buffer;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferLen;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_x509list_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001DE7 RID: 7655 RVA: 0x000797A8 File Offset: 0x000779A8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363981, XrefRangeEnd = 363985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(UnityTls.unitytls_x509list* list, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
						*ptr = list;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = buffer;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferLen;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_x509list_ptr_Byte_IntPtr_ptr_unitytls_errorstate_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06001DE8 RID: 7656 RVA: 0x00079844 File Offset: 0x00077A44
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06001DE9 RID: 7657 RVA: 0x0001048F File Offset: 0x0000E68F
				public unitytls_x509list_append_der_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001692 RID: 5778
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001693 RID: 5779
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_x509list_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0;

				// Token: 0x04001694 RID: 5780
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_x509list_ptr_Byte_IntPtr_ptr_unitytls_errorstate_AsyncCallback_Object_0;

				// Token: 0x04001695 RID: 5781
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x0200022A RID: 554
			public sealed class unitytls_x509list_free_t : MulticastDelegate
			{
				// Token: 0x06001DEA RID: 7658 RVA: 0x00079888 File Offset: 0x00077A88
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_x509list_free_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_free_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509list_free_t");
					UnityTls.unitytls_interface_struct.unitytls_x509list_free_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_free_t>.NativeClassPtr, 100663382);
					UnityTls.unitytls_interface_struct.unitytls_x509list_free_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_x509list_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_free_t>.NativeClassPtr, 100663383);
					UnityTls.unitytls_interface_struct.unitytls_x509list_free_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_x509list_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_free_t>.NativeClassPtr, 100663384);
					UnityTls.unitytls_interface_struct.unitytls_x509list_free_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_free_t>.NativeClassPtr, 100663385);
				}

				// Token: 0x06001DEB RID: 7659 RVA: 0x000798FC File Offset: 0x00077AFC
				[CallerCount(42)]
				[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_x509list_free_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_free_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509list_free_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001DEC RID: 7660 RVA: 0x00079958 File Offset: 0x00077B58
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 363943, RefRangeEnd = 363953, XrefRangeStart = 363943, XrefRangeEnd = 363953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void Invoke(UnityTls.unitytls_x509list* list)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = list;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509list_free_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_x509list_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06001DED RID: 7661 RVA: 0x00079998 File Offset: 0x00077B98
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(UnityTls.unitytls_x509list* list, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = list;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509list_free_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_x509list_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06001DEE RID: 7662 RVA: 0x00079A08 File Offset: 0x00077C08
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509list_free_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06001DEF RID: 7663 RVA: 0x00010498 File Offset: 0x0000E698
				public unitytls_x509list_free_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001696 RID: 5782
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001697 RID: 5783
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_x509list_0;

				// Token: 0x04001698 RID: 5784
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_x509list_AsyncCallback_Object_0;

				// Token: 0x04001699 RID: 5785
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x0200022B RID: 555
			public sealed class unitytls_x509verify_default_ca_t : MulticastDelegate
			{
				// Token: 0x06001DF0 RID: 7664 RVA: 0x00079A4C File Offset: 0x00077C4C
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_x509verify_default_ca_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509verify_default_ca_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509verify_default_ca_t");
					UnityTls.unitytls_interface_struct.unitytls_x509verify_default_ca_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509verify_default_ca_t>.NativeClassPtr, 100663386);
					UnityTls.unitytls_interface_struct.unitytls_x509verify_default_ca_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_unitytls_x509list_ref_ptr_Byte_IntPtr_unitytls_x509verify_callback_ptr_Void_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509verify_default_ca_t>.NativeClassPtr, 100663387);
					UnityTls.unitytls_interface_struct.unitytls_x509verify_default_ca_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_unitytls_x509list_ref_ptr_Byte_IntPtr_unitytls_x509verify_callback_ptr_Void_ptr_unitytls_errorstate_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509verify_default_ca_t>.NativeClassPtr, 100663388);
					UnityTls.unitytls_interface_struct.unitytls_x509verify_default_ca_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_unitytls_x509verify_result_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509verify_default_ca_t>.NativeClassPtr, 100663389);
				}

				// Token: 0x06001DF1 RID: 7665 RVA: 0x00079AC0 File Offset: 0x00077CC0
				[CallerCount(42)]
				[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_x509verify_default_ca_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509verify_default_ca_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509verify_default_ca_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001DF2 RID: 7666 RVA: 0x00079B1C File Offset: 0x00077D1C
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 363999, RefRangeEnd = 364000, XrefRangeStart = 363985, XrefRangeEnd = 363999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe UnityTls.unitytls_x509verify_result Invoke(UnityTls.unitytls_x509list_ref chain, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509verify_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref chain;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = cn;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cnLen;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cb);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = userData;
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509verify_default_ca_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_unitytls_x509list_ref_ptr_Byte_IntPtr_unitytls_x509verify_callback_ptr_Void_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06001DF3 RID: 7667 RVA: 0x00079BB0 File Offset: 0x00077DB0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364000, XrefRangeEnd = 364007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(UnityTls.unitytls_x509list_ref chain, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509verify_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref chain;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = cn;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cnLen;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cb);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = userData;
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509verify_default_ca_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_unitytls_x509list_ref_ptr_Byte_IntPtr_unitytls_x509verify_callback_ptr_Void_ptr_unitytls_errorstate_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06001DF4 RID: 7668 RVA: 0x00079C6C File Offset: 0x00077E6C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe UnityTls.unitytls_x509verify_result EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509verify_default_ca_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_unitytls_x509verify_result_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x06001DF5 RID: 7669 RVA: 0x000104A1 File Offset: 0x0000E6A1
				public unitytls_x509verify_default_ca_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0400169A RID: 5786
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x0400169B RID: 5787
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_unitytls_x509list_ref_ptr_Byte_IntPtr_unitytls_x509verify_callback_ptr_Void_ptr_unitytls_errorstate_0;

				// Token: 0x0400169C RID: 5788
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_unitytls_x509list_ref_ptr_Byte_IntPtr_unitytls_x509verify_callback_ptr_Void_ptr_unitytls_errorstate_AsyncCallback_Object_0;

				// Token: 0x0400169D RID: 5789
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_unitytls_x509verify_result_IAsyncResult_0;
			}

			// Token: 0x0200022C RID: 556
			public sealed class unitytls_x509verify_explicit_ca_t : MulticastDelegate
			{
				// Token: 0x06001DF6 RID: 7670 RVA: 0x00079CBC File Offset: 0x00077EBC
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_x509verify_explicit_ca_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509verify_explicit_ca_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509verify_explicit_ca_t");
					UnityTls.unitytls_interface_struct.unitytls_x509verify_explicit_ca_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509verify_explicit_ca_t>.NativeClassPtr, 100663390);
					UnityTls.unitytls_interface_struct.unitytls_x509verify_explicit_ca_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_unitytls_x509list_ref_unitytls_x509list_ref_ptr_Byte_IntPtr_unitytls_x509verify_callback_ptr_Void_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509verify_explicit_ca_t>.NativeClassPtr, 100663391);
					UnityTls.unitytls_interface_struct.unitytls_x509verify_explicit_ca_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_unitytls_x509list_ref_unitytls_x509list_ref_ptr_Byte_IntPtr_unitytls_x509verify_callback_ptr_Void_ptr_unitytls_errorstate_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509verify_explicit_ca_t>.NativeClassPtr, 100663392);
					UnityTls.unitytls_interface_struct.unitytls_x509verify_explicit_ca_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_unitytls_x509verify_result_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509verify_explicit_ca_t>.NativeClassPtr, 100663393);
				}

				// Token: 0x06001DF7 RID: 7671 RVA: 0x00079D30 File Offset: 0x00077F30
				[CallerCount(42)]
				[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_x509verify_explicit_ca_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509verify_explicit_ca_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509verify_explicit_ca_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001DF8 RID: 7672 RVA: 0x00079D8C File Offset: 0x00077F8C
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 364021, RefRangeEnd = 364022, XrefRangeStart = 364007, XrefRangeEnd = 364021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe UnityTls.unitytls_x509verify_result Invoke(UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_x509list_ref trustCA, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509verify_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref chain;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trustCA;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = cn;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cnLen;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cb);
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = userData;
					ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509verify_explicit_ca_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_unitytls_x509list_ref_unitytls_x509list_ref_ptr_Byte_IntPtr_unitytls_x509verify_callback_ptr_Void_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06001DF9 RID: 7673 RVA: 0x00079E30 File Offset: 0x00078030
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364022, XrefRangeEnd = 364031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_x509list_ref trustCA, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509verify_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref chain;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trustCA;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = cn;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cnLen;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cb);
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = userData;
					ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509verify_explicit_ca_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_unitytls_x509list_ref_unitytls_x509list_ref_ptr_Byte_IntPtr_unitytls_x509verify_callback_ptr_Void_ptr_unitytls_errorstate_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06001DFA RID: 7674 RVA: 0x00079EFC File Offset: 0x000780FC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe UnityTls.unitytls_x509verify_result EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509verify_explicit_ca_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_unitytls_x509verify_result_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x06001DFB RID: 7675 RVA: 0x000104AA File Offset: 0x0000E6AA
				public unitytls_x509verify_explicit_ca_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0400169E RID: 5790
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x0400169F RID: 5791
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_unitytls_x509list_ref_unitytls_x509list_ref_ptr_Byte_IntPtr_unitytls_x509verify_callback_ptr_Void_ptr_unitytls_errorstate_0;

				// Token: 0x040016A0 RID: 5792
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_unitytls_x509list_ref_unitytls_x509list_ref_ptr_Byte_IntPtr_unitytls_x509verify_callback_ptr_Void_ptr_unitytls_errorstate_AsyncCallback_Object_0;

				// Token: 0x040016A1 RID: 5793
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_unitytls_x509verify_result_IAsyncResult_0;
			}

			// Token: 0x0200022D RID: 557
			public sealed class unitytls_tlsctx_create_server_t : MulticastDelegate
			{
				// Token: 0x06001DFC RID: 7676 RVA: 0x00079F4C File Offset: 0x0007814C
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_tlsctx_create_server_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_server_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_create_server_t");
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_server_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_server_t>.NativeClassPtr, 100663394);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_server_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_tlsctx_unitytls_tlsctx_protocolrange_unitytls_tlsctx_callbacks_UInt64_UInt64_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_server_t>.NativeClassPtr, 100663395);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_server_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_unitytls_tlsctx_protocolrange_unitytls_tlsctx_callbacks_UInt64_UInt64_ptr_unitytls_errorstate_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_server_t>.NativeClassPtr, 100663396);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_server_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_ptr_unitytls_tlsctx_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_server_t>.NativeClassPtr, 100663397);
				}

				// Token: 0x06001DFD RID: 7677 RVA: 0x00079FC0 File Offset: 0x000781C0
				[CallerCount(42)]
				[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_tlsctx_create_server_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_server_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_server_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001DFE RID: 7678 RVA: 0x0007A01C File Offset: 0x0007821C
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 364047, RefRangeEnd = 364049, XrefRangeStart = 364031, XrefRangeEnd = 364047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe UnityTls.unitytls_tlsctx* Invoke(UnityTls.unitytls_tlsctx_protocolrange supportedProtocols, UnityTls.unitytls_tlsctx_callbacks callbacks, ulong certChain, ulong leafCertificateKey, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref supportedProtocols;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(callbacks));
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref certChain;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leafCertificateKey;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_server_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_tlsctx_unitytls_tlsctx_protocolrange_unitytls_tlsctx_callbacks_UInt64_UInt64_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}

				// Token: 0x06001DFF RID: 7679 RVA: 0x0007A09C File Offset: 0x0007829C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364049, XrefRangeEnd = 364061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(UnityTls.unitytls_tlsctx_protocolrange supportedProtocols, UnityTls.unitytls_tlsctx_callbacks callbacks, ulong certChain, ulong leafCertificateKey, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref supportedProtocols;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(callbacks));
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref certChain;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leafCertificateKey;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_server_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_unitytls_tlsctx_protocolrange_unitytls_tlsctx_callbacks_UInt64_UInt64_ptr_unitytls_errorstate_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06001E00 RID: 7680 RVA: 0x0007A150 File Offset: 0x00078350
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe UnityTls.unitytls_tlsctx* EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_server_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_ptr_unitytls_tlsctx_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return intPtr;
					}
				}

				// Token: 0x06001E01 RID: 7681 RVA: 0x000104B3 File Offset: 0x0000E6B3
				public unitytls_tlsctx_create_server_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x040016A2 RID: 5794
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x040016A3 RID: 5795
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_tlsctx_unitytls_tlsctx_protocolrange_unitytls_tlsctx_callbacks_UInt64_UInt64_ptr_unitytls_errorstate_0;

				// Token: 0x040016A4 RID: 5796
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_unitytls_tlsctx_protocolrange_unitytls_tlsctx_callbacks_UInt64_UInt64_ptr_unitytls_errorstate_AsyncCallback_Object_0;

				// Token: 0x040016A5 RID: 5797
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_ptr_unitytls_tlsctx_IAsyncResult_0;
			}

			// Token: 0x0200022E RID: 558
			public sealed class unitytls_tlsctx_create_client_t : MulticastDelegate
			{
				// Token: 0x06001E02 RID: 7682 RVA: 0x0007A194 File Offset: 0x00078394
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_tlsctx_create_client_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_client_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_create_client_t");
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_client_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_client_t>.NativeClassPtr, 100663398);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_client_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_tlsctx_unitytls_tlsctx_protocolrange_unitytls_tlsctx_callbacks_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_client_t>.NativeClassPtr, 100663399);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_client_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_unitytls_tlsctx_protocolrange_unitytls_tlsctx_callbacks_ptr_Byte_IntPtr_ptr_unitytls_errorstate_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_client_t>.NativeClassPtr, 100663400);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_client_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_ptr_unitytls_tlsctx_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_client_t>.NativeClassPtr, 100663401);
				}

				// Token: 0x06001E03 RID: 7683 RVA: 0x0007A208 File Offset: 0x00078408
				[CallerCount(42)]
				[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_tlsctx_create_client_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_client_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_client_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001E04 RID: 7684 RVA: 0x0007A264 File Offset: 0x00078464
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 364047, RefRangeEnd = 364049, XrefRangeStart = 364047, XrefRangeEnd = 364049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe UnityTls.unitytls_tlsctx* Invoke(UnityTls.unitytls_tlsctx_protocolrange supportedProtocols, UnityTls.unitytls_tlsctx_callbacks callbacks, byte* cn, IntPtr cnLen, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref supportedProtocols;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(callbacks));
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = cn;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cnLen;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_client_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_tlsctx_unitytls_tlsctx_protocolrange_unitytls_tlsctx_callbacks_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}

				// Token: 0x06001E05 RID: 7685 RVA: 0x0007A2E4 File Offset: 0x000784E4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364061, XrefRangeEnd = 364071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(UnityTls.unitytls_tlsctx_protocolrange supportedProtocols, UnityTls.unitytls_tlsctx_callbacks callbacks, byte* cn, IntPtr cnLen, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref supportedProtocols;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(callbacks));
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = cn;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cnLen;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_client_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_unitytls_tlsctx_protocolrange_unitytls_tlsctx_callbacks_ptr_Byte_IntPtr_ptr_unitytls_errorstate_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06001E06 RID: 7686 RVA: 0x0007A398 File Offset: 0x00078598
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe UnityTls.unitytls_tlsctx* EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_client_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_ptr_unitytls_tlsctx_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return intPtr;
					}
				}

				// Token: 0x06001E07 RID: 7687 RVA: 0x000104BC File Offset: 0x0000E6BC
				public unitytls_tlsctx_create_client_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x040016A6 RID: 5798
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x040016A7 RID: 5799
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_tlsctx_unitytls_tlsctx_protocolrange_unitytls_tlsctx_callbacks_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0;

				// Token: 0x040016A8 RID: 5800
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_unitytls_tlsctx_protocolrange_unitytls_tlsctx_callbacks_ptr_Byte_IntPtr_ptr_unitytls_errorstate_AsyncCallback_Object_0;

				// Token: 0x040016A9 RID: 5801
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_ptr_unitytls_tlsctx_IAsyncResult_0;
			}

			// Token: 0x0200022F RID: 559
			public sealed class unitytls_tlsctx_server_require_client_authentication_t : MulticastDelegate
			{
				// Token: 0x06001E08 RID: 7688 RVA: 0x0007A3DC File Offset: 0x000785DC
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_tlsctx_server_require_client_authentication_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_server_require_client_authentication_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_server_require_client_authentication_t");
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_server_require_client_authentication_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_server_require_client_authentication_t>.NativeClassPtr, 100663402);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_server_require_client_authentication_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_unitytls_x509list_ref_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_server_require_client_authentication_t>.NativeClassPtr, 100663403);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_server_require_client_authentication_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_tlsctx_unitytls_x509list_ref_ptr_unitytls_errorstate_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_server_require_client_authentication_t>.NativeClassPtr, 100663404);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_server_require_client_authentication_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_server_require_client_authentication_t>.NativeClassPtr, 100663405);
				}

				// Token: 0x06001E09 RID: 7689 RVA: 0x0007A450 File Offset: 0x00078650
				[CallerCount(42)]
				[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_tlsctx_server_require_client_authentication_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_server_require_client_authentication_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_server_require_client_authentication_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001E0A RID: 7690 RVA: 0x0007A4AC File Offset: 0x000786AC
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 363976, RefRangeEnd = 363977, XrefRangeStart = 363976, XrefRangeEnd = 363977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_x509list_ref clientAuthCAList, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ctx;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clientAuthCAList;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_server_require_client_authentication_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_unitytls_x509list_ref_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001E0B RID: 7691 RVA: 0x0007A504 File Offset: 0x00078704
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364071, XrefRangeEnd = 364075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_x509list_ref clientAuthCAList, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ctx;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clientAuthCAList;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_server_require_client_authentication_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_tlsctx_unitytls_x509list_ref_ptr_unitytls_errorstate_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06001E0C RID: 7692 RVA: 0x0007A590 File Offset: 0x00078790
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_server_require_client_authentication_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06001E0D RID: 7693 RVA: 0x000104C5 File Offset: 0x0000E6C5
				public unitytls_tlsctx_server_require_client_authentication_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x040016AA RID: 5802
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x040016AB RID: 5803
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_unitytls_x509list_ref_ptr_unitytls_errorstate_0;

				// Token: 0x040016AC RID: 5804
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_tlsctx_unitytls_x509list_ref_ptr_unitytls_errorstate_AsyncCallback_Object_0;

				// Token: 0x040016AD RID: 5805
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x02000230 RID: 560
			public sealed class unitytls_tlsctx_set_certificate_callback_t : MulticastDelegate
			{
				// Token: 0x06001E0E RID: 7694 RVA: 0x0007A5D4 File Offset: 0x000787D4
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_tlsctx_set_certificate_callback_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_certificate_callback_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_set_certificate_callback_t");
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_certificate_callback_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_certificate_callback_t>.NativeClassPtr, 100663406);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_certificate_callback_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_unitytls_tlsctx_certificate_callback_ptr_Void_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_certificate_callback_t>.NativeClassPtr, 100663407);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_certificate_callback_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_tlsctx_unitytls_tlsctx_certificate_callback_ptr_Void_ptr_unitytls_errorstate_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_certificate_callback_t>.NativeClassPtr, 100663408);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_certificate_callback_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_certificate_callback_t>.NativeClassPtr, 100663409);
				}

				// Token: 0x06001E0F RID: 7695 RVA: 0x0007A648 File Offset: 0x00078848
				[CallerCount(42)]
				[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_tlsctx_set_certificate_callback_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_certificate_callback_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_certificate_callback_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001E10 RID: 7696 RVA: 0x0007A6A4 File Offset: 0x000788A4
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 363884, RefRangeEnd = 363888, XrefRangeStart = 363884, XrefRangeEnd = 363888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_tlsctx_certificate_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ctx;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cb);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = userData;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_certificate_callback_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_unitytls_tlsctx_certificate_callback_ptr_Void_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001E11 RID: 7697 RVA: 0x0007A710 File Offset: 0x00078910
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_tlsctx_certificate_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ctx;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cb);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = userData;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_certificate_callback_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_tlsctx_unitytls_tlsctx_certificate_callback_ptr_Void_ptr_unitytls_errorstate_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06001E12 RID: 7698 RVA: 0x0007A7B0 File Offset: 0x000789B0
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_certificate_callback_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06001E13 RID: 7699 RVA: 0x000104CE File Offset: 0x0000E6CE
				public unitytls_tlsctx_set_certificate_callback_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x040016AE RID: 5806
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x040016AF RID: 5807
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_unitytls_tlsctx_certificate_callback_ptr_Void_ptr_unitytls_errorstate_0;

				// Token: 0x040016B0 RID: 5808
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_tlsctx_unitytls_tlsctx_certificate_callback_ptr_Void_ptr_unitytls_errorstate_AsyncCallback_Object_0;

				// Token: 0x040016B1 RID: 5809
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x02000231 RID: 561
			public sealed class unitytls_tlsctx_set_trace_callback_t : MulticastDelegate
			{
				// Token: 0x06001E14 RID: 7700 RVA: 0x0007A7F4 File Offset: 0x000789F4
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_tlsctx_set_trace_callback_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_callback_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_set_trace_callback_t");
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_callback_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_callback_t>.NativeClassPtr, 100663410);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_callback_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_unitytls_tlsctx_trace_callback_ptr_Void_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_callback_t>.NativeClassPtr, 100663411);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_callback_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_tlsctx_unitytls_tlsctx_trace_callback_ptr_Void_ptr_unitytls_errorstate_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_callback_t>.NativeClassPtr, 100663412);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_callback_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_callback_t>.NativeClassPtr, 100663413);
				}

				// Token: 0x06001E15 RID: 7701 RVA: 0x0007A868 File Offset: 0x00078A68
				[CallerCount(42)]
				[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_tlsctx_set_trace_callback_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_callback_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_callback_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001E16 RID: 7702 RVA: 0x0007A8C4 File Offset: 0x00078AC4
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 363884, RefRangeEnd = 363888, XrefRangeStart = 363884, XrefRangeEnd = 363888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_tlsctx_trace_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ctx;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cb);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = userData;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_callback_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_unitytls_tlsctx_trace_callback_ptr_Void_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001E17 RID: 7703 RVA: 0x0007A930 File Offset: 0x00078B30
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_tlsctx_trace_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ctx;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cb);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = userData;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_callback_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_tlsctx_unitytls_tlsctx_trace_callback_ptr_Void_ptr_unitytls_errorstate_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06001E18 RID: 7704 RVA: 0x0007A9D0 File Offset: 0x00078BD0
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_callback_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06001E19 RID: 7705 RVA: 0x000104D7 File Offset: 0x0000E6D7
				public unitytls_tlsctx_set_trace_callback_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x040016B2 RID: 5810
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x040016B3 RID: 5811
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_unitytls_tlsctx_trace_callback_ptr_Void_ptr_unitytls_errorstate_0;

				// Token: 0x040016B4 RID: 5812
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_tlsctx_unitytls_tlsctx_trace_callback_ptr_Void_ptr_unitytls_errorstate_AsyncCallback_Object_0;

				// Token: 0x040016B5 RID: 5813
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x02000232 RID: 562
			public sealed class unitytls_tlsctx_set_x509verify_callback_t : MulticastDelegate
			{
				// Token: 0x06001E1A RID: 7706 RVA: 0x0007AA14 File Offset: 0x00078C14
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_tlsctx_set_x509verify_callback_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_x509verify_callback_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_set_x509verify_callback_t");
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_x509verify_callback_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_x509verify_callback_t>.NativeClassPtr, 100663414);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_x509verify_callback_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_unitytls_tlsctx_x509verify_callback_ptr_Void_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_x509verify_callback_t>.NativeClassPtr, 100663415);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_x509verify_callback_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_tlsctx_unitytls_tlsctx_x509verify_callback_ptr_Void_ptr_unitytls_errorstate_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_x509verify_callback_t>.NativeClassPtr, 100663416);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_x509verify_callback_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_x509verify_callback_t>.NativeClassPtr, 100663417);
				}

				// Token: 0x06001E1B RID: 7707 RVA: 0x0007AA88 File Offset: 0x00078C88
				[CallerCount(42)]
				[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_tlsctx_set_x509verify_callback_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_x509verify_callback_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_x509verify_callback_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001E1C RID: 7708 RVA: 0x0007AAE4 File Offset: 0x00078CE4
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 363884, RefRangeEnd = 363888, XrefRangeStart = 363884, XrefRangeEnd = 363888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_tlsctx_x509verify_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ctx;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cb);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = userData;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_x509verify_callback_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_unitytls_tlsctx_x509verify_callback_ptr_Void_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001E1D RID: 7709 RVA: 0x0007AB50 File Offset: 0x00078D50
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_tlsctx_x509verify_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ctx;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cb);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = userData;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_x509verify_callback_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_tlsctx_unitytls_tlsctx_x509verify_callback_ptr_Void_ptr_unitytls_errorstate_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06001E1E RID: 7710 RVA: 0x0007ABF0 File Offset: 0x00078DF0
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_x509verify_callback_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06001E1F RID: 7711 RVA: 0x000104E0 File Offset: 0x0000E6E0
				public unitytls_tlsctx_set_x509verify_callback_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x040016B6 RID: 5814
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x040016B7 RID: 5815
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_unitytls_tlsctx_x509verify_callback_ptr_Void_ptr_unitytls_errorstate_0;

				// Token: 0x040016B8 RID: 5816
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_tlsctx_unitytls_tlsctx_x509verify_callback_ptr_Void_ptr_unitytls_errorstate_AsyncCallback_Object_0;

				// Token: 0x040016B9 RID: 5817
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x02000233 RID: 563
			public sealed class unitytls_tlsctx_set_supported_ciphersuites_t : MulticastDelegate
			{
				// Token: 0x06001E20 RID: 7712 RVA: 0x0007AC34 File Offset: 0x00078E34
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_tlsctx_set_supported_ciphersuites_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_supported_ciphersuites_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_set_supported_ciphersuites_t");
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_supported_ciphersuites_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_supported_ciphersuites_t>.NativeClassPtr, 100663418);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_supported_ciphersuites_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_ptr_unitytls_ciphersuite_IntPtr_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_supported_ciphersuites_t>.NativeClassPtr, 100663419);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_supported_ciphersuites_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_tlsctx_ptr_unitytls_ciphersuite_IntPtr_ptr_unitytls_errorstate_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_supported_ciphersuites_t>.NativeClassPtr, 100663420);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_supported_ciphersuites_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_supported_ciphersuites_t>.NativeClassPtr, 100663421);
				}

				// Token: 0x06001E21 RID: 7713 RVA: 0x0007ACA8 File Offset: 0x00078EA8
				[CallerCount(42)]
				[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_tlsctx_set_supported_ciphersuites_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_supported_ciphersuites_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_supported_ciphersuites_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001E22 RID: 7714 RVA: 0x0007AD04 File Offset: 0x00078F04
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 363884, RefRangeEnd = 363888, XrefRangeStart = 363884, XrefRangeEnd = 363888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_ciphersuite* supportedCiphersuites, IntPtr supportedCiphersuitesLen, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ctx;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = supportedCiphersuites;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref supportedCiphersuitesLen;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_supported_ciphersuites_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_ptr_unitytls_ciphersuite_IntPtr_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001E23 RID: 7715 RVA: 0x0007AD6C File Offset: 0x00078F6C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364075, XrefRangeEnd = 364079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_ciphersuite* supportedCiphersuites, IntPtr supportedCiphersuitesLen, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ctx;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = supportedCiphersuites;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref supportedCiphersuitesLen;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_supported_ciphersuites_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_tlsctx_ptr_unitytls_ciphersuite_IntPtr_ptr_unitytls_errorstate_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06001E24 RID: 7716 RVA: 0x0007AE08 File Offset: 0x00079008
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_supported_ciphersuites_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06001E25 RID: 7717 RVA: 0x000104E9 File Offset: 0x0000E6E9
				public unitytls_tlsctx_set_supported_ciphersuites_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x040016BA RID: 5818
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x040016BB RID: 5819
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_ptr_unitytls_ciphersuite_IntPtr_ptr_unitytls_errorstate_0;

				// Token: 0x040016BC RID: 5820
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_tlsctx_ptr_unitytls_ciphersuite_IntPtr_ptr_unitytls_errorstate_AsyncCallback_Object_0;

				// Token: 0x040016BD RID: 5821
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x02000234 RID: 564
			public sealed class unitytls_tlsctx_get_ciphersuite_t : MulticastDelegate
			{
				// Token: 0x06001E26 RID: 7718 RVA: 0x0007AE4C File Offset: 0x0007904C
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_tlsctx_get_ciphersuite_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_ciphersuite_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_get_ciphersuite_t");
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_ciphersuite_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_ciphersuite_t>.NativeClassPtr, 100663422);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_ciphersuite_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_ciphersuite_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_ciphersuite_t>.NativeClassPtr, 100663423);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_ciphersuite_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_ciphersuite_t>.NativeClassPtr, 100663424);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_ciphersuite_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_unitytls_ciphersuite_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_ciphersuite_t>.NativeClassPtr, 100663425);
				}

				// Token: 0x06001E27 RID: 7719 RVA: 0x0007AEC0 File Offset: 0x000790C0
				[CallerCount(42)]
				[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_tlsctx_get_ciphersuite_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_ciphersuite_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_ciphersuite_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001E28 RID: 7720 RVA: 0x0007AF1C File Offset: 0x0007911C
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 358650, RefRangeEnd = 358653, XrefRangeStart = 358650, XrefRangeEnd = 358653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe UnityTls.unitytls_ciphersuite Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ctx;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_ciphersuite_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_ciphersuite_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06001E29 RID: 7721 RVA: 0x0007AF74 File Offset: 0x00079174
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ctx;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_ciphersuite_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06001E2A RID: 7722 RVA: 0x0007AFF4 File Offset: 0x000791F4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe UnityTls.unitytls_ciphersuite EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_ciphersuite_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_unitytls_ciphersuite_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x06001E2B RID: 7723 RVA: 0x000104F2 File Offset: 0x0000E6F2
				public unitytls_tlsctx_get_ciphersuite_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x040016BE RID: 5822
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x040016BF RID: 5823
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_ciphersuite_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_0;

				// Token: 0x040016C0 RID: 5824
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_AsyncCallback_Object_0;

				// Token: 0x040016C1 RID: 5825
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_unitytls_ciphersuite_IAsyncResult_0;
			}

			// Token: 0x02000235 RID: 565
			public sealed class unitytls_tlsctx_get_protocol_t : MulticastDelegate
			{
				// Token: 0x06001E2C RID: 7724 RVA: 0x0007B044 File Offset: 0x00079244
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_tlsctx_get_protocol_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_protocol_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_get_protocol_t");
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_protocol_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_protocol_t>.NativeClassPtr, 100663426);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_protocol_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_protocol_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_protocol_t>.NativeClassPtr, 100663427);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_protocol_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_protocol_t>.NativeClassPtr, 100663428);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_protocol_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_unitytls_protocol_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_protocol_t>.NativeClassPtr, 100663429);
				}

				// Token: 0x06001E2D RID: 7725 RVA: 0x0007B0B8 File Offset: 0x000792B8
				[CallerCount(42)]
				[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_tlsctx_get_protocol_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_protocol_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_protocol_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001E2E RID: 7726 RVA: 0x0007B114 File Offset: 0x00079314
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 358650, RefRangeEnd = 358653, XrefRangeStart = 358650, XrefRangeEnd = 358653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe UnityTls.unitytls_protocol Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ctx;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_protocol_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_protocol_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06001E2F RID: 7727 RVA: 0x0007B16C File Offset: 0x0007936C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ctx;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_protocol_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06001E30 RID: 7728 RVA: 0x0007B1EC File Offset: 0x000793EC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe UnityTls.unitytls_protocol EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_protocol_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_unitytls_protocol_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x06001E31 RID: 7729 RVA: 0x000104FB File Offset: 0x0000E6FB
				public unitytls_tlsctx_get_protocol_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x040016C2 RID: 5826
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x040016C3 RID: 5827
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_protocol_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_0;

				// Token: 0x040016C4 RID: 5828
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_AsyncCallback_Object_0;

				// Token: 0x040016C5 RID: 5829
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_unitytls_protocol_IAsyncResult_0;
			}

			// Token: 0x02000236 RID: 566
			public sealed class unitytls_tlsctx_process_handshake_t : MulticastDelegate
			{
				// Token: 0x06001E32 RID: 7730 RVA: 0x0007B23C File Offset: 0x0007943C
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_tlsctx_process_handshake_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_process_handshake_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_process_handshake_t");
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_process_handshake_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_process_handshake_t>.NativeClassPtr, 100663430);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_process_handshake_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_process_handshake_t>.NativeClassPtr, 100663431);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_process_handshake_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_process_handshake_t>.NativeClassPtr, 100663432);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_process_handshake_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_unitytls_x509verify_result_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_process_handshake_t>.NativeClassPtr, 100663433);
				}

				// Token: 0x06001E33 RID: 7731 RVA: 0x0007B2B0 File Offset: 0x000794B0
				[CallerCount(42)]
				[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_tlsctx_process_handshake_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_process_handshake_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_process_handshake_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001E34 RID: 7732 RVA: 0x0007B30C File Offset: 0x0007950C
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 358650, RefRangeEnd = 358653, XrefRangeStart = 358650, XrefRangeEnd = 358653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe UnityTls.unitytls_x509verify_result Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ctx;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_process_handshake_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06001E35 RID: 7733 RVA: 0x0007B364 File Offset: 0x00079564
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ctx;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_process_handshake_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06001E36 RID: 7734 RVA: 0x0007B3E4 File Offset: 0x000795E4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe UnityTls.unitytls_x509verify_result EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_process_handshake_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_unitytls_x509verify_result_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x06001E37 RID: 7735 RVA: 0x00010504 File Offset: 0x0000E704
				public unitytls_tlsctx_process_handshake_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x040016C6 RID: 5830
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x040016C7 RID: 5831
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_0;

				// Token: 0x040016C8 RID: 5832
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_AsyncCallback_Object_0;

				// Token: 0x040016C9 RID: 5833
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_unitytls_x509verify_result_IAsyncResult_0;
			}

			// Token: 0x02000237 RID: 567
			public sealed class unitytls_tlsctx_read_t : MulticastDelegate
			{
				// Token: 0x06001E38 RID: 7736 RVA: 0x0007B434 File Offset: 0x00079634
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_tlsctx_read_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_read_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_read_t");
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_read_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_read_t>.NativeClassPtr, 100663434);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_read_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_read_t>.NativeClassPtr, 100663435);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_read_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_errorstate_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_read_t>.NativeClassPtr, 100663436);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_read_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_read_t>.NativeClassPtr, 100663437);
				}

				// Token: 0x06001E39 RID: 7737 RVA: 0x0007B4A8 File Offset: 0x000796A8
				[CallerCount(42)]
				[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_tlsctx_read_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_read_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_read_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001E3A RID: 7738 RVA: 0x0007B504 File Offset: 0x00079704
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 363874, RefRangeEnd = 363876, XrefRangeStart = 363874, XrefRangeEnd = 363876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IntPtr Invoke(UnityTls.unitytls_tlsctx* ctx, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ctx;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = buffer;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferLen;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_read_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06001E3B RID: 7739 RVA: 0x0007B578 File Offset: 0x00079778
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364079, XrefRangeEnd = 364083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(UnityTls.unitytls_tlsctx* ctx, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ctx;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = buffer;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferLen;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_read_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_errorstate_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06001E3C RID: 7740 RVA: 0x0007B614 File Offset: 0x00079814
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IntPtr EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_read_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x06001E3D RID: 7741 RVA: 0x0001050D File Offset: 0x0000E70D
				public unitytls_tlsctx_read_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x040016CA RID: 5834
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x040016CB RID: 5835
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0;

				// Token: 0x040016CC RID: 5836
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_errorstate_AsyncCallback_Object_0;

				// Token: 0x040016CD RID: 5837
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0;
			}

			// Token: 0x02000238 RID: 568
			public sealed class unitytls_tlsctx_write_t : MulticastDelegate
			{
				// Token: 0x06001E3E RID: 7742 RVA: 0x0007B664 File Offset: 0x00079864
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_tlsctx_write_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_write_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_write_t");
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_write_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_write_t>.NativeClassPtr, 100663438);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_write_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_write_t>.NativeClassPtr, 100663439);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_write_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_errorstate_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_write_t>.NativeClassPtr, 100663440);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_write_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_write_t>.NativeClassPtr, 100663441);
				}

				// Token: 0x06001E3F RID: 7743 RVA: 0x0007B6D8 File Offset: 0x000798D8
				[CallerCount(42)]
				[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_tlsctx_write_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_write_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_write_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001E40 RID: 7744 RVA: 0x0007B734 File Offset: 0x00079934
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 363874, RefRangeEnd = 363876, XrefRangeStart = 363874, XrefRangeEnd = 363876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IntPtr Invoke(UnityTls.unitytls_tlsctx* ctx, byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ctx;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = data;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferLen;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_write_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06001E41 RID: 7745 RVA: 0x0007B7A8 File Offset: 0x000799A8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364083, XrefRangeEnd = 364087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(UnityTls.unitytls_tlsctx* ctx, byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ctx;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = data;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferLen;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_write_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_errorstate_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06001E42 RID: 7746 RVA: 0x0007B844 File Offset: 0x00079A44
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IntPtr EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_write_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x06001E43 RID: 7747 RVA: 0x00010516 File Offset: 0x0000E716
				public unitytls_tlsctx_write_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x040016CE RID: 5838
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x040016CF RID: 5839
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0;

				// Token: 0x040016D0 RID: 5840
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_errorstate_AsyncCallback_Object_0;

				// Token: 0x040016D1 RID: 5841
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0;
			}

			// Token: 0x02000239 RID: 569
			public sealed class unitytls_tlsctx_notify_close_t : MulticastDelegate
			{
				// Token: 0x06001E44 RID: 7748 RVA: 0x0007B894 File Offset: 0x00079A94
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_tlsctx_notify_close_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_notify_close_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_notify_close_t");
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_notify_close_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_notify_close_t>.NativeClassPtr, 100663442);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_notify_close_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_notify_close_t>.NativeClassPtr, 100663443);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_notify_close_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_notify_close_t>.NativeClassPtr, 100663444);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_notify_close_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_notify_close_t>.NativeClassPtr, 100663445);
				}

				// Token: 0x06001E45 RID: 7749 RVA: 0x0007B908 File Offset: 0x00079B08
				[CallerCount(42)]
				[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_tlsctx_notify_close_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_notify_close_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_notify_close_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001E46 RID: 7750 RVA: 0x0007B964 File Offset: 0x00079B64
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 364087, RefRangeEnd = 364088, XrefRangeStart = 364087, XrefRangeEnd = 364087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ctx;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_notify_close_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001E47 RID: 7751 RVA: 0x0007B9B0 File Offset: 0x00079BB0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ctx;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_notify_close_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06001E48 RID: 7752 RVA: 0x0007BA30 File Offset: 0x00079C30
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_notify_close_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06001E49 RID: 7753 RVA: 0x0001051F File Offset: 0x0000E71F
				public unitytls_tlsctx_notify_close_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x040016D2 RID: 5842
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x040016D3 RID: 5843
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_0;

				// Token: 0x040016D4 RID: 5844
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_AsyncCallback_Object_0;

				// Token: 0x040016D5 RID: 5845
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x0200023A RID: 570
			public sealed class unitytls_tlsctx_free_t : MulticastDelegate
			{
				// Token: 0x06001E4A RID: 7754 RVA: 0x0007BA74 File Offset: 0x00079C74
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_tlsctx_free_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_free_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_free_t");
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_free_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_free_t>.NativeClassPtr, 100663446);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_free_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_free_t>.NativeClassPtr, 100663447);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_free_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_tlsctx_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_free_t>.NativeClassPtr, 100663448);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_free_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_free_t>.NativeClassPtr, 100663449);
				}

				// Token: 0x06001E4B RID: 7755 RVA: 0x0007BAE8 File Offset: 0x00079CE8
				[CallerCount(42)]
				[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_tlsctx_free_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_free_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_free_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001E4C RID: 7756 RVA: 0x0007BB44 File Offset: 0x00079D44
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 363943, RefRangeEnd = 363953, XrefRangeStart = 363943, XrefRangeEnd = 363953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void Invoke(UnityTls.unitytls_tlsctx* ctx)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ctx;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_free_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06001E4D RID: 7757 RVA: 0x0007BB84 File Offset: 0x00079D84
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(UnityTls.unitytls_tlsctx* ctx, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ctx;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_free_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_tlsctx_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06001E4E RID: 7758 RVA: 0x0007BBF4 File Offset: 0x00079DF4
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_free_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06001E4F RID: 7759 RVA: 0x00010528 File Offset: 0x0000E728
				public unitytls_tlsctx_free_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x040016D6 RID: 5846
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x040016D7 RID: 5847
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_0;

				// Token: 0x040016D8 RID: 5848
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_unitytls_tlsctx_AsyncCallback_Object_0;

				// Token: 0x040016D9 RID: 5849
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x0200023B RID: 571
			public sealed class unitytls_random_generate_bytes_t : MulticastDelegate
			{
				// Token: 0x06001E50 RID: 7760 RVA: 0x0007BC38 File Offset: 0x00079E38
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_random_generate_bytes_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_random_generate_bytes_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_random_generate_bytes_t");
					UnityTls.unitytls_interface_struct.unitytls_random_generate_bytes_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_random_generate_bytes_t>.NativeClassPtr, 100663450);
					UnityTls.unitytls_interface_struct.unitytls_random_generate_bytes_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_random_generate_bytes_t>.NativeClassPtr, 100663451);
					UnityTls.unitytls_interface_struct.unitytls_random_generate_bytes_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Byte_IntPtr_ptr_unitytls_errorstate_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_random_generate_bytes_t>.NativeClassPtr, 100663452);
					UnityTls.unitytls_interface_struct.unitytls_random_generate_bytes_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_random_generate_bytes_t>.NativeClassPtr, 100663453);
				}

				// Token: 0x06001E51 RID: 7761 RVA: 0x0007BCAC File Offset: 0x00079EAC
				[CallerCount(42)]
				[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_random_generate_bytes_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_random_generate_bytes_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_random_generate_bytes_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001E52 RID: 7762 RVA: 0x0007BD08 File Offset: 0x00079F08
				[CallerCount(0)]
				public unsafe void Invoke(byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = buffer;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferLen;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_random_generate_bytes_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001E53 RID: 7763 RVA: 0x0007BD60 File Offset: 0x00079F60
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364088, XrefRangeEnd = 364092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = buffer;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferLen;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_random_generate_bytes_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Byte_IntPtr_ptr_unitytls_errorstate_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06001E54 RID: 7764 RVA: 0x0007BDEC File Offset: 0x00079FEC
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_random_generate_bytes_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06001E55 RID: 7765 RVA: 0x00010531 File Offset: 0x0000E731
				public unitytls_random_generate_bytes_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x040016DA RID: 5850
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x040016DB RID: 5851
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0;

				// Token: 0x040016DC RID: 5852
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Byte_IntPtr_ptr_unitytls_errorstate_AsyncCallback_Object_0;

				// Token: 0x040016DD RID: 5853
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}
		}
	}
}
