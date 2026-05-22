using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x0200030A RID: 778
	public class RSAPKCS1SignatureDescription : SignatureDescription
	{
		// Token: 0x060033B8 RID: 13240 RVA: 0x00100E00 File Offset: 0x000FF000
		// Note: this type is marked as 'beforefieldinit'.
		static RSAPKCS1SignatureDescription()
		{
			Il2CppClassPointerStore<RSAPKCS1SignatureDescription>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "RSAPKCS1SignatureDescription");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RSAPKCS1SignatureDescription>.NativeClassPtr);
			RSAPKCS1SignatureDescription.NativeFieldInfoPtr__hashAlgorithm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSAPKCS1SignatureDescription>.NativeClassPtr, "_hashAlgorithm");
			RSAPKCS1SignatureDescription.NativeMethodInfoPtr__ctor_Protected_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAPKCS1SignatureDescription>.NativeClassPtr, 100671403);
		}

		// Token: 0x060033B9 RID: 13241 RVA: 0x00100E58 File Offset: 0x000FF058
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 211844, RefRangeEnd = 211848, XrefRangeStart = 211838, XrefRangeEnd = 211844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RSAPKCS1SignatureDescription(string hashAlgorithm, string digestAlgorithm)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RSAPKCS1SignatureDescription>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(hashAlgorithm);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(digestAlgorithm);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSAPKCS1SignatureDescription.NativeMethodInfoPtr__ctor_Protected_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033BA RID: 13242 RVA: 0x0001230F File Offset: 0x0001050F
		public RSAPKCS1SignatureDescription(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C6C RID: 3180
		// (get) Token: 0x060033BB RID: 13243 RVA: 0x00100EB8 File Offset: 0x000FF0B8
		// (set) Token: 0x060033BC RID: 13244 RVA: 0x00012318 File Offset: 0x00010518
		public unsafe string _hashAlgorithm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAPKCS1SignatureDescription.NativeFieldInfoPtr__hashAlgorithm);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAPKCS1SignatureDescription.NativeFieldInfoPtr__hashAlgorithm), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002C08 RID: 11272
		private static readonly IntPtr NativeFieldInfoPtr__hashAlgorithm;

		// Token: 0x04002C09 RID: 11273
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_String_String_0;
	}
}
