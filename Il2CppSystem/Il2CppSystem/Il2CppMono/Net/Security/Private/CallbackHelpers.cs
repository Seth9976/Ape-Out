using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.Interface;
using Il2CppSystem;
using Il2CppSystem.Net.Security;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppMono.Net.Security.Private
{
	// Token: 0x0200002A RID: 42
	public static class CallbackHelpers : Object
	{
		// Token: 0x06000247 RID: 583 RVA: 0x0001944C File Offset: 0x0001764C
		// Note: this type is marked as 'beforefieldinit'.
		static CallbackHelpers()
		{
			Il2CppClassPointerStore<CallbackHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net.Security.Private", "CallbackHelpers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallbackHelpers>.NativeClassPtr);
			CallbackHelpers.NativeMethodInfoPtr_MonoToPublic_Internal_Static_RemoteCertificateValidationCallback_MonoRemoteCertificateValidationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackHelpers>.NativeClassPtr, 100663747);
			CallbackHelpers.NativeMethodInfoPtr_MonoToInternal_Internal_Static_LocalCertSelectionCallback_MonoLocalCertificateSelectionCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackHelpers>.NativeClassPtr, 100663748);
		}

		// Token: 0x06000248 RID: 584 RVA: 0x000194A4 File Offset: 0x000176A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366760, XrefRangeEnd = 366768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RemoteCertificateValidationCallback MonoToPublic(MonoRemoteCertificateValidationCallback callback)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackHelpers.NativeMethodInfoPtr_MonoToPublic_Internal_Static_RemoteCertificateValidationCallback_MonoRemoteCertificateValidationCallback_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RemoteCertificateValidationCallback>(intPtr3) : null;
			}
		}

		// Token: 0x06000249 RID: 585 RVA: 0x000194E8 File Offset: 0x000176E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366768, XrefRangeEnd = 366776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static LocalCertSelectionCallback MonoToInternal(MonoLocalCertificateSelectionCallback callback)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackHelpers.NativeMethodInfoPtr_MonoToInternal_Internal_Static_LocalCertSelectionCallback_MonoLocalCertificateSelectionCallback_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalCertSelectionCallback>(intPtr3) : null;
			}
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00002DEC File Offset: 0x00000FEC
		public CallbackHelpers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400019A RID: 410
		private static readonly IntPtr NativeMethodInfoPtr_MonoToPublic_Internal_Static_RemoteCertificateValidationCallback_MonoRemoteCertificateValidationCallback_0;

		// Token: 0x0400019B RID: 411
		private static readonly IntPtr NativeMethodInfoPtr_MonoToInternal_Internal_Static_LocalCertSelectionCallback_MonoLocalCertificateSelectionCallback_0;

		// Token: 0x020001AD RID: 429
		[ObfuscatedName("Mono.Net.Security.Private.CallbackHelpers+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Object
		{
			// Token: 0x060018C4 RID: 6340 RVA: 0x0006B430 File Offset: 0x00069630
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<CallbackHelpers.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CallbackHelpers>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallbackHelpers.__c__DisplayClass5_0>.NativeClassPtr);
				CallbackHelpers.__c__DisplayClass5_0.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackHelpers.__c__DisplayClass5_0>.NativeClassPtr, "callback");
				CallbackHelpers.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackHelpers.__c__DisplayClass5_0>.NativeClassPtr, 100663749);
				CallbackHelpers.__c__DisplayClass5_0.NativeMethodInfoPtr__MonoToPublic_b__0_Internal_Boolean_Object_X509Certificate_X509Chain_SslPolicyErrors_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackHelpers.__c__DisplayClass5_0>.NativeClassPtr, 100663750);
			}

			// Token: 0x060018C5 RID: 6341 RVA: 0x0006B498 File Offset: 0x00069698
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallbackHelpers.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackHelpers.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060018C6 RID: 6342 RVA: 0x0006B4D4 File Offset: 0x000696D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366756, XrefRangeEnd = 366758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MonoToPublic_b__0(Object t, X509Certificate c, X509Chain ch, SslPolicyErrors e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(c);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ch);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref e;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackHelpers.__c__DisplayClass5_0.NativeMethodInfoPtr__MonoToPublic_b__0_Internal_Boolean_Object_X509Certificate_X509Chain_SslPolicyErrors_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060018C7 RID: 6343 RVA: 0x0000CC0F File Offset: 0x0000AE0F
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007F3 RID: 2035
			// (get) Token: 0x060018C8 RID: 6344 RVA: 0x0006B554 File Offset: 0x00069754
			// (set) Token: 0x060018C9 RID: 6345 RVA: 0x0000CC18 File Offset: 0x0000AE18
			public unsafe MonoRemoteCertificateValidationCallback callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallbackHelpers.__c__DisplayClass5_0.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoRemoteCertificateValidationCallback>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallbackHelpers.__c__DisplayClass5_0.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001369 RID: 4969
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x0400136A RID: 4970
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400136B RID: 4971
			private static readonly IntPtr NativeMethodInfoPtr__MonoToPublic_b__0_Internal_Boolean_Object_X509Certificate_X509Chain_SslPolicyErrors_0;
		}

		// Token: 0x020001AE RID: 430
		[ObfuscatedName("Mono.Net.Security.Private.CallbackHelpers+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Object
		{
			// Token: 0x060018CA RID: 6346 RVA: 0x0006B584 File Offset: 0x00069784
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<CallbackHelpers.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CallbackHelpers>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallbackHelpers.__c__DisplayClass8_0>.NativeClassPtr);
				CallbackHelpers.__c__DisplayClass8_0.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackHelpers.__c__DisplayClass8_0>.NativeClassPtr, "callback");
				CallbackHelpers.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackHelpers.__c__DisplayClass8_0>.NativeClassPtr, 100663751);
				CallbackHelpers.__c__DisplayClass8_0.NativeMethodInfoPtr__MonoToInternal_b__0_Internal_X509Certificate_String_X509CertificateCollection_X509Certificate_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackHelpers.__c__DisplayClass8_0>.NativeClassPtr, 100663752);
			}

			// Token: 0x060018CB RID: 6347 RVA: 0x0006B5EC File Offset: 0x000697EC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallbackHelpers.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackHelpers.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060018CC RID: 6348 RVA: 0x0006B628 File Offset: 0x00069828
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366758, XrefRangeEnd = 366760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe X509Certificate _MonoToInternal_b__0(string t, X509CertificateCollection lc, X509Certificate rc, Il2CppStringArray ai)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(t);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lc);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rc);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ai);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackHelpers.__c__DisplayClass8_0.NativeMethodInfoPtr__MonoToInternal_b__0_Internal_X509Certificate_String_X509CertificateCollection_X509Certificate_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr3) : null;
			}

			// Token: 0x060018CD RID: 6349 RVA: 0x0000CC37 File Offset: 0x0000AE37
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007F4 RID: 2036
			// (get) Token: 0x060018CE RID: 6350 RVA: 0x0006B6B0 File Offset: 0x000698B0
			// (set) Token: 0x060018CF RID: 6351 RVA: 0x0000CC40 File Offset: 0x0000AE40
			public unsafe MonoLocalCertificateSelectionCallback callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallbackHelpers.__c__DisplayClass8_0.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoLocalCertificateSelectionCallback>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallbackHelpers.__c__DisplayClass8_0.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400136C RID: 4972
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x0400136D RID: 4973
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400136E RID: 4974
			private static readonly IntPtr NativeMethodInfoPtr__MonoToInternal_b__0_Internal_X509Certificate_String_X509CertificateCollection_X509Certificate_Il2CppStringArray_0;
		}
	}
}
