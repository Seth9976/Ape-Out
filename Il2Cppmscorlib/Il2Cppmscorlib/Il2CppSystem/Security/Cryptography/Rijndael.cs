using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002F8 RID: 760
	public class Rijndael : SymmetricAlgorithm
	{
		// Token: 0x0600328A RID: 12938 RVA: 0x000FC950 File Offset: 0x000FAB50
		// Note: this type is marked as 'beforefieldinit'.
		static Rijndael()
		{
			Il2CppClassPointerStore<Rijndael>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "Rijndael");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Rijndael>.NativeClassPtr);
			Rijndael.NativeFieldInfoPtr_s_legalBlockSizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rijndael>.NativeClassPtr, "s_legalBlockSizes");
			Rijndael.NativeFieldInfoPtr_s_legalKeySizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rijndael>.NativeClassPtr, "s_legalKeySizes");
			Rijndael.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rijndael>.NativeClassPtr, 100671267);
		}

		// Token: 0x0600328B RID: 12939 RVA: 0x000FC9BC File Offset: 0x000FABBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210432, XrefRangeEnd = 210437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rijndael()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Rijndael>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rijndael.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600328C RID: 12940 RVA: 0x00011B14 File Offset: 0x0000FD14
		public Rijndael(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C1E RID: 3102
		// (get) Token: 0x0600328D RID: 12941 RVA: 0x000FC9F8 File Offset: 0x000FABF8
		// (set) Token: 0x0600328E RID: 12942 RVA: 0x00011B1D File Offset: 0x0000FD1D
		public unsafe static Il2CppReferenceArray<KeySizes> s_legalBlockSizes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Rijndael.NativeFieldInfoPtr_s_legalBlockSizes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeySizes>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Rijndael.NativeFieldInfoPtr_s_legalBlockSizes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C1F RID: 3103
		// (get) Token: 0x0600328F RID: 12943 RVA: 0x000FCA20 File Offset: 0x000FAC20
		// (set) Token: 0x06003290 RID: 12944 RVA: 0x00011B2F File Offset: 0x0000FD2F
		public unsafe static Il2CppReferenceArray<KeySizes> s_legalKeySizes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Rijndael.NativeFieldInfoPtr_s_legalKeySizes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeySizes>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Rijndael.NativeFieldInfoPtr_s_legalKeySizes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002B3E RID: 11070
		private static readonly IntPtr NativeFieldInfoPtr_s_legalBlockSizes;

		// Token: 0x04002B3F RID: 11071
		private static readonly IntPtr NativeFieldInfoPtr_s_legalKeySizes;

		// Token: 0x04002B40 RID: 11072
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
