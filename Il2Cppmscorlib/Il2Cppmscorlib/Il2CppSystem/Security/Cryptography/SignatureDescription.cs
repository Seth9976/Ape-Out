using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000309 RID: 777
	public class SignatureDescription : Object
	{
		// Token: 0x060033A9 RID: 13225 RVA: 0x00100B30 File Offset: 0x000FED30
		// Note: this type is marked as 'beforefieldinit'.
		static SignatureDescription()
		{
			Il2CppClassPointerStore<SignatureDescription>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "SignatureDescription");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SignatureDescription>.NativeClassPtr);
			SignatureDescription.NativeFieldInfoPtr__strKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignatureDescription>.NativeClassPtr, "_strKey");
			SignatureDescription.NativeFieldInfoPtr__strDigest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignatureDescription>.NativeClassPtr, "_strDigest");
			SignatureDescription.NativeFieldInfoPtr__strFormatter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignatureDescription>.NativeClassPtr, "_strFormatter");
			SignatureDescription.NativeFieldInfoPtr__strDeformatter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignatureDescription>.NativeClassPtr, "_strDeformatter");
			SignatureDescription.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureDescription>.NativeClassPtr, 100671398);
			SignatureDescription.NativeMethodInfoPtr_set_KeyAlgorithm_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureDescription>.NativeClassPtr, 100671399);
			SignatureDescription.NativeMethodInfoPtr_set_DigestAlgorithm_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureDescription>.NativeClassPtr, 100671400);
			SignatureDescription.NativeMethodInfoPtr_set_FormatterAlgorithm_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureDescription>.NativeClassPtr, 100671401);
			SignatureDescription.NativeMethodInfoPtr_set_DeformatterAlgorithm_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureDescription>.NativeClassPtr, 100671402);
		}

		// Token: 0x060033AA RID: 13226 RVA: 0x00100C14 File Offset: 0x000FEE14
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SignatureDescription()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SignatureDescription>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureDescription.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000C68 RID: 3176
		// (set) Token: 0x060033AB RID: 13227 RVA: 0x00100C50 File Offset: 0x000FEE50
		public unsafe string KeyAlgorithm
		{
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureDescription.NativeMethodInfoPtr_set_KeyAlgorithm_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C69 RID: 3177
		// (set) Token: 0x060033AC RID: 13228 RVA: 0x00100C94 File Offset: 0x000FEE94
		public unsafe string DigestAlgorithm
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureDescription.NativeMethodInfoPtr_set_DigestAlgorithm_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C6A RID: 3178
		// (set) Token: 0x060033AD RID: 13229 RVA: 0x00100CD8 File Offset: 0x000FEED8
		public unsafe string FormatterAlgorithm
		{
			[CallerCount(33)]
			[CachedScanResults(RefRangeStart = 18620, RefRangeEnd = 18653, XrefRangeStart = 18620, XrefRangeEnd = 18653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureDescription.NativeMethodInfoPtr_set_FormatterAlgorithm_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C6B RID: 3179
		// (set) Token: 0x060033AE RID: 13230 RVA: 0x00100D1C File Offset: 0x000FEF1C
		public unsafe string DeformatterAlgorithm
		{
			[CallerCount(38)]
			[CachedScanResults(RefRangeStart = 17089, RefRangeEnd = 17127, XrefRangeStart = 17089, XrefRangeEnd = 17127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureDescription.NativeMethodInfoPtr_set_DeformatterAlgorithm_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060033AF RID: 13231 RVA: 0x0001228A File Offset: 0x0001048A
		public SignatureDescription(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C64 RID: 3172
		// (get) Token: 0x060033B0 RID: 13232 RVA: 0x00100D60 File Offset: 0x000FEF60
		// (set) Token: 0x060033B1 RID: 13233 RVA: 0x00012293 File Offset: 0x00010493
		public unsafe string _strKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignatureDescription.NativeFieldInfoPtr__strKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignatureDescription.NativeFieldInfoPtr__strKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C65 RID: 3173
		// (get) Token: 0x060033B2 RID: 13234 RVA: 0x00100D88 File Offset: 0x000FEF88
		// (set) Token: 0x060033B3 RID: 13235 RVA: 0x000122B2 File Offset: 0x000104B2
		public unsafe string _strDigest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignatureDescription.NativeFieldInfoPtr__strDigest);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignatureDescription.NativeFieldInfoPtr__strDigest), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C66 RID: 3174
		// (get) Token: 0x060033B4 RID: 13236 RVA: 0x00100DB0 File Offset: 0x000FEFB0
		// (set) Token: 0x060033B5 RID: 13237 RVA: 0x000122D1 File Offset: 0x000104D1
		public unsafe string _strFormatter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignatureDescription.NativeFieldInfoPtr__strFormatter);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignatureDescription.NativeFieldInfoPtr__strFormatter), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C67 RID: 3175
		// (get) Token: 0x060033B6 RID: 13238 RVA: 0x00100DD8 File Offset: 0x000FEFD8
		// (set) Token: 0x060033B7 RID: 13239 RVA: 0x000122F0 File Offset: 0x000104F0
		public unsafe string _strDeformatter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignatureDescription.NativeFieldInfoPtr__strDeformatter);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignatureDescription.NativeFieldInfoPtr__strDeformatter), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002BFF RID: 11263
		private static readonly IntPtr NativeFieldInfoPtr__strKey;

		// Token: 0x04002C00 RID: 11264
		private static readonly IntPtr NativeFieldInfoPtr__strDigest;

		// Token: 0x04002C01 RID: 11265
		private static readonly IntPtr NativeFieldInfoPtr__strFormatter;

		// Token: 0x04002C02 RID: 11266
		private static readonly IntPtr NativeFieldInfoPtr__strDeformatter;

		// Token: 0x04002C03 RID: 11267
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002C04 RID: 11268
		private static readonly IntPtr NativeMethodInfoPtr_set_KeyAlgorithm_Public_set_Void_String_0;

		// Token: 0x04002C05 RID: 11269
		private static readonly IntPtr NativeMethodInfoPtr_set_DigestAlgorithm_Public_set_Void_String_0;

		// Token: 0x04002C06 RID: 11270
		private static readonly IntPtr NativeMethodInfoPtr_set_FormatterAlgorithm_Public_set_Void_String_0;

		// Token: 0x04002C07 RID: 11271
		private static readonly IntPtr NativeMethodInfoPtr_set_DeformatterAlgorithm_Public_set_Void_String_0;
	}
}
