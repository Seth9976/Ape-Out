using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.Cryptography;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000316 RID: 790
	public sealed class DSACryptoServiceProvider : DSA
	{
		// Token: 0x0600344F RID: 13391 RVA: 0x0010301C File Offset: 0x0010121C
		// Note: this type is marked as 'beforefieldinit'.
		static DSACryptoServiceProvider()
		{
			Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "DSACryptoServiceProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr);
			DSACryptoServiceProvider.NativeFieldInfoPtr_store = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr, "store");
			DSACryptoServiceProvider.NativeFieldInfoPtr_persistKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr, "persistKey");
			DSACryptoServiceProvider.NativeFieldInfoPtr_persisted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr, "persisted");
			DSACryptoServiceProvider.NativeFieldInfoPtr_privateKeyExportable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr, "privateKeyExportable");
			DSACryptoServiceProvider.NativeFieldInfoPtr_m_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr, "m_disposed");
			DSACryptoServiceProvider.NativeFieldInfoPtr_dsa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr, "dsa");
			DSACryptoServiceProvider.NativeFieldInfoPtr_useMachineKeyStore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr, "useMachineKeyStore");
			DSACryptoServiceProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr, 100671479);
			DSACryptoServiceProvider.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr, 100671480);
			DSACryptoServiceProvider.NativeMethodInfoPtr_Common_Private_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr, 100671481);
			DSACryptoServiceProvider.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr, 100671482);
			DSACryptoServiceProvider.NativeMethodInfoPtr_get_KeySize_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr, 100671483);
			DSACryptoServiceProvider.NativeMethodInfoPtr_get_PublicOnly_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr, 100671484);
			DSACryptoServiceProvider.NativeMethodInfoPtr_ExportParameters_Public_Virtual_DSAParameters_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr, 100671485);
			DSACryptoServiceProvider.NativeMethodInfoPtr_ImportParameters_Public_Virtual_Void_DSAParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr, 100671486);
			DSACryptoServiceProvider.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr, 100671487);
			DSACryptoServiceProvider.NativeMethodInfoPtr_OnKeyGenerated_Private_Void_Object_EventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr, 100671488);
		}

		// Token: 0x06003450 RID: 13392 RVA: 0x001031A0 File Offset: 0x001013A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212605, XrefRangeEnd = 212606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DSACryptoServiceProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSACryptoServiceProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003451 RID: 13393 RVA: 0x001031DC File Offset: 0x001013DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212606, XrefRangeEnd = 212607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DSACryptoServiceProvider(int dwKeySize)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dwKeySize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSACryptoServiceProvider.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003452 RID: 13394 RVA: 0x00103224 File Offset: 0x00101424
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 212645, RefRangeEnd = 212653, XrefRangeStart = 212607, XrefRangeEnd = 212645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Common(int dwKeySize, bool parameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dwKeySize;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parameters;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSACryptoServiceProvider.NativeMethodInfoPtr_Common_Private_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003453 RID: 13395 RVA: 0x00103270 File Offset: 0x00101470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSACryptoServiceProvider.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000C98 RID: 3224
		// (get) Token: 0x06003454 RID: 13396 RVA: 0x001032A4 File Offset: 0x001014A4
		public unsafe override int KeySize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212653, XrefRangeEnd = 212654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSACryptoServiceProvider.NativeMethodInfoPtr_get_KeySize_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C99 RID: 3225
		// (get) Token: 0x06003455 RID: 13397 RVA: 0x001032E0 File Offset: 0x001014E0
		public unsafe bool PublicOnly
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212654, XrefRangeEnd = 212656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSACryptoServiceProvider.NativeMethodInfoPtr_get_PublicOnly_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003456 RID: 13398 RVA: 0x0010331C File Offset: 0x0010151C
		[CallerCount(0)]
		public unsafe override DSAParameters ExportParameters(bool includePrivateParameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includePrivateParameters;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSACryptoServiceProvider.NativeMethodInfoPtr_ExportParameters_Public_Virtual_DSAParameters_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new DSAParameters(intPtr);
			}
		}

		// Token: 0x06003457 RID: 13399 RVA: 0x00103360 File Offset: 0x00101560
		[CallerCount(0)]
		public unsafe override void ImportParameters(DSAParameters parameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(parameters));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSACryptoServiceProvider.NativeMethodInfoPtr_ImportParameters_Public_Virtual_Void_DSAParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003458 RID: 13400 RVA: 0x001033A8 File Offset: 0x001015A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSACryptoServiceProvider.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003459 RID: 13401 RVA: 0x001033E8 File Offset: 0x001015E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212656, XrefRangeEnd = 212659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnKeyGenerated(Object sender, EventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSACryptoServiceProvider.NativeMethodInfoPtr_OnKeyGenerated_Private_Void_Object_EventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600345A RID: 13402 RVA: 0x000126FF File Offset: 0x000108FF
		public DSACryptoServiceProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C91 RID: 3217
		// (get) Token: 0x0600345B RID: 13403 RVA: 0x0010343C File Offset: 0x0010163C
		// (set) Token: 0x0600345C RID: 13404 RVA: 0x00012708 File Offset: 0x00010908
		public unsafe KeyPairPersistence store
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSACryptoServiceProvider.NativeFieldInfoPtr_store);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<KeyPairPersistence>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSACryptoServiceProvider.NativeFieldInfoPtr_store), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C92 RID: 3218
		// (get) Token: 0x0600345D RID: 13405 RVA: 0x0010346C File Offset: 0x0010166C
		// (set) Token: 0x0600345E RID: 13406 RVA: 0x00012727 File Offset: 0x00010927
		public unsafe bool persistKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSACryptoServiceProvider.NativeFieldInfoPtr_persistKey);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSACryptoServiceProvider.NativeFieldInfoPtr_persistKey)) = value;
			}
		}

		// Token: 0x17000C93 RID: 3219
		// (get) Token: 0x0600345F RID: 13407 RVA: 0x00103494 File Offset: 0x00101694
		// (set) Token: 0x06003460 RID: 13408 RVA: 0x00012742 File Offset: 0x00010942
		public unsafe bool persisted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSACryptoServiceProvider.NativeFieldInfoPtr_persisted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSACryptoServiceProvider.NativeFieldInfoPtr_persisted)) = value;
			}
		}

		// Token: 0x17000C94 RID: 3220
		// (get) Token: 0x06003461 RID: 13409 RVA: 0x001034BC File Offset: 0x001016BC
		// (set) Token: 0x06003462 RID: 13410 RVA: 0x0001275D File Offset: 0x0001095D
		public unsafe bool privateKeyExportable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSACryptoServiceProvider.NativeFieldInfoPtr_privateKeyExportable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSACryptoServiceProvider.NativeFieldInfoPtr_privateKeyExportable)) = value;
			}
		}

		// Token: 0x17000C95 RID: 3221
		// (get) Token: 0x06003463 RID: 13411 RVA: 0x001034E4 File Offset: 0x001016E4
		// (set) Token: 0x06003464 RID: 13412 RVA: 0x00012778 File Offset: 0x00010978
		public unsafe bool m_disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSACryptoServiceProvider.NativeFieldInfoPtr_m_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSACryptoServiceProvider.NativeFieldInfoPtr_m_disposed)) = value;
			}
		}

		// Token: 0x17000C96 RID: 3222
		// (get) Token: 0x06003465 RID: 13413 RVA: 0x0010350C File Offset: 0x0010170C
		// (set) Token: 0x06003466 RID: 13414 RVA: 0x00012793 File Offset: 0x00010993
		public unsafe DSAManaged dsa
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSACryptoServiceProvider.NativeFieldInfoPtr_dsa);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DSAManaged>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSACryptoServiceProvider.NativeFieldInfoPtr_dsa), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C97 RID: 3223
		// (get) Token: 0x06003467 RID: 13415 RVA: 0x0010353C File Offset: 0x0010173C
		// (set) Token: 0x06003468 RID: 13416 RVA: 0x000127B2 File Offset: 0x000109B2
		public unsafe static bool useMachineKeyStore
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(DSACryptoServiceProvider.NativeFieldInfoPtr_useMachineKeyStore, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DSACryptoServiceProvider.NativeFieldInfoPtr_useMachineKeyStore, (void*)(&value));
			}
		}

		// Token: 0x04002C6C RID: 11372
		private static readonly IntPtr NativeFieldInfoPtr_store;

		// Token: 0x04002C6D RID: 11373
		private static readonly IntPtr NativeFieldInfoPtr_persistKey;

		// Token: 0x04002C6E RID: 11374
		private static readonly IntPtr NativeFieldInfoPtr_persisted;

		// Token: 0x04002C6F RID: 11375
		private static readonly IntPtr NativeFieldInfoPtr_privateKeyExportable;

		// Token: 0x04002C70 RID: 11376
		private static readonly IntPtr NativeFieldInfoPtr_m_disposed;

		// Token: 0x04002C71 RID: 11377
		private static readonly IntPtr NativeFieldInfoPtr_dsa;

		// Token: 0x04002C72 RID: 11378
		private static readonly IntPtr NativeFieldInfoPtr_useMachineKeyStore;

		// Token: 0x04002C73 RID: 11379
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002C74 RID: 11380
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04002C75 RID: 11381
		private static readonly IntPtr NativeMethodInfoPtr_Common_Private_Void_Int32_Boolean_0;

		// Token: 0x04002C76 RID: 11382
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04002C77 RID: 11383
		private static readonly IntPtr NativeMethodInfoPtr_get_KeySize_Public_Virtual_get_Int32_0;

		// Token: 0x04002C78 RID: 11384
		private static readonly IntPtr NativeMethodInfoPtr_get_PublicOnly_Public_get_Boolean_0;

		// Token: 0x04002C79 RID: 11385
		private static readonly IntPtr NativeMethodInfoPtr_ExportParameters_Public_Virtual_DSAParameters_Boolean_0;

		// Token: 0x04002C7A RID: 11386
		private static readonly IntPtr NativeMethodInfoPtr_ImportParameters_Public_Virtual_Void_DSAParameters_0;

		// Token: 0x04002C7B RID: 11387
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04002C7C RID: 11388
		private static readonly IntPtr NativeMethodInfoPtr_OnKeyGenerated_Private_Void_Object_EventArgs_0;
	}
}
