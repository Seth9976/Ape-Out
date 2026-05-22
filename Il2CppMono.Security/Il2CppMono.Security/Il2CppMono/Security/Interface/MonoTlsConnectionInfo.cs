using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Security.Interface
{
	// Token: 0x02000021 RID: 33
	public class MonoTlsConnectionInfo : Object
	{
		// Token: 0x060001A5 RID: 421 RVA: 0x00009B10 File Offset: 0x00007D10
		// Note: this type is marked as 'beforefieldinit'.
		static MonoTlsConnectionInfo()
		{
			Il2CppClassPointerStore<MonoTlsConnectionInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Interface", "MonoTlsConnectionInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoTlsConnectionInfo>.NativeClassPtr);
			MonoTlsConnectionInfo.NativeFieldInfoPtr__CipherSuiteCode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsConnectionInfo>.NativeClassPtr, "<CipherSuiteCode>k__BackingField");
			MonoTlsConnectionInfo.NativeFieldInfoPtr__ProtocolVersion_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsConnectionInfo>.NativeClassPtr, "<ProtocolVersion>k__BackingField");
			MonoTlsConnectionInfo.NativeFieldInfoPtr__PeerDomainName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsConnectionInfo>.NativeClassPtr, "<PeerDomainName>k__BackingField");
			MonoTlsConnectionInfo.NativeMethodInfoPtr_get_CipherSuiteCode_Public_get_CipherSuiteCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsConnectionInfo>.NativeClassPtr, 100663522);
			MonoTlsConnectionInfo.NativeMethodInfoPtr_set_CipherSuiteCode_Public_set_Void_CipherSuiteCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsConnectionInfo>.NativeClassPtr, 100663523);
			MonoTlsConnectionInfo.NativeMethodInfoPtr_get_ProtocolVersion_Public_get_TlsProtocols_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsConnectionInfo>.NativeClassPtr, 100663524);
			MonoTlsConnectionInfo.NativeMethodInfoPtr_set_ProtocolVersion_Public_set_Void_TlsProtocols_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsConnectionInfo>.NativeClassPtr, 100663525);
			MonoTlsConnectionInfo.NativeMethodInfoPtr_set_PeerDomainName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsConnectionInfo>.NativeClassPtr, 100663526);
			MonoTlsConnectionInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsConnectionInfo>.NativeClassPtr, 100663527);
			MonoTlsConnectionInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsConnectionInfo>.NativeClassPtr, 100663528);
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x00009C08 File Offset: 0x00007E08
		// (set) Token: 0x060001A7 RID: 423 RVA: 0x00009C44 File Offset: 0x00007E44
		public unsafe CipherSuiteCode CipherSuiteCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsConnectionInfo.NativeMethodInfoPtr_get_CipherSuiteCode_Public_get_CipherSuiteCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsConnectionInfo.NativeMethodInfoPtr_set_CipherSuiteCode_Public_set_Void_CipherSuiteCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x00009C84 File Offset: 0x00007E84
		// (set) Token: 0x060001A9 RID: 425 RVA: 0x00009CC0 File Offset: 0x00007EC0
		public unsafe TlsProtocols ProtocolVersion
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsConnectionInfo.NativeMethodInfoPtr_get_ProtocolVersion_Public_get_TlsProtocols_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsConnectionInfo.NativeMethodInfoPtr_set_ProtocolVersion_Public_set_Void_TlsProtocols_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000099 RID: 153
		// (set) Token: 0x060001AA RID: 426 RVA: 0x00009D00 File Offset: 0x00007F00
		public unsafe string PeerDomainName
		{
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 18562, RefRangeEnd = 18620, XrefRangeStart = 18562, XrefRangeEnd = 18620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsConnectionInfo.NativeMethodInfoPtr_set_PeerDomainName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00009D44 File Offset: 0x00007F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129679, XrefRangeEnd = 129688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoTlsConnectionInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00009D88 File Offset: 0x00007F88
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoTlsConnectionInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoTlsConnectionInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsConnectionInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00002B5F File Offset: 0x00000D5F
		public MonoTlsConnectionInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060001AE RID: 430 RVA: 0x00009DC4 File Offset: 0x00007FC4
		// (set) Token: 0x060001AF RID: 431 RVA: 0x00002B68 File Offset: 0x00000D68
		public unsafe CipherSuiteCode _CipherSuiteCode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsConnectionInfo.NativeFieldInfoPtr__CipherSuiteCode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsConnectionInfo.NativeFieldInfoPtr__CipherSuiteCode_k__BackingField)) = value;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x00009DEC File Offset: 0x00007FEC
		// (set) Token: 0x060001B1 RID: 433 RVA: 0x00002B83 File Offset: 0x00000D83
		public unsafe TlsProtocols _ProtocolVersion_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsConnectionInfo.NativeFieldInfoPtr__ProtocolVersion_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsConnectionInfo.NativeFieldInfoPtr__ProtocolVersion_k__BackingField)) = value;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x00009E14 File Offset: 0x00008014
		// (set) Token: 0x060001B3 RID: 435 RVA: 0x00002B9E File Offset: 0x00000D9E
		public unsafe string _PeerDomainName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsConnectionInfo.NativeFieldInfoPtr__PeerDomainName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsConnectionInfo.NativeFieldInfoPtr__PeerDomainName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400024E RID: 590
		private static readonly IntPtr NativeFieldInfoPtr__CipherSuiteCode_k__BackingField;

		// Token: 0x0400024F RID: 591
		private static readonly IntPtr NativeFieldInfoPtr__ProtocolVersion_k__BackingField;

		// Token: 0x04000250 RID: 592
		private static readonly IntPtr NativeFieldInfoPtr__PeerDomainName_k__BackingField;

		// Token: 0x04000251 RID: 593
		private static readonly IntPtr NativeMethodInfoPtr_get_CipherSuiteCode_Public_get_CipherSuiteCode_0;

		// Token: 0x04000252 RID: 594
		private static readonly IntPtr NativeMethodInfoPtr_set_CipherSuiteCode_Public_set_Void_CipherSuiteCode_0;

		// Token: 0x04000253 RID: 595
		private static readonly IntPtr NativeMethodInfoPtr_get_ProtocolVersion_Public_get_TlsProtocols_0;

		// Token: 0x04000254 RID: 596
		private static readonly IntPtr NativeMethodInfoPtr_set_ProtocolVersion_Public_set_Void_TlsProtocols_0;

		// Token: 0x04000255 RID: 597
		private static readonly IntPtr NativeMethodInfoPtr_set_PeerDomainName_Public_set_Void_String_0;

		// Token: 0x04000256 RID: 598
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000257 RID: 599
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
