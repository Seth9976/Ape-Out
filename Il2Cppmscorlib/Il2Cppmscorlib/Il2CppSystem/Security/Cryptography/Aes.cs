using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002D5 RID: 725
	public class Aes : SymmetricAlgorithm
	{
		// Token: 0x0600312A RID: 12586 RVA: 0x000F78D0 File Offset: 0x000F5AD0
		// Note: this type is marked as 'beforefieldinit'.
		static Aes()
		{
			Il2CppClassPointerStore<Aes>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "Aes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Aes>.NativeClassPtr);
			Aes.NativeFieldInfoPtr_s_legalBlockSizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Aes>.NativeClassPtr, "s_legalBlockSizes");
			Aes.NativeFieldInfoPtr_s_legalKeySizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Aes>.NativeClassPtr, "s_legalKeySizes");
			Aes.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Aes>.NativeClassPtr, 100671094);
		}

		// Token: 0x0600312B RID: 12587 RVA: 0x000F793C File Offset: 0x000F5B3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 209158, RefRangeEnd = 209160, XrefRangeStart = 209153, XrefRangeEnd = 209158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Aes()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Aes>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Aes.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600312C RID: 12588 RVA: 0x00011288 File Offset: 0x0000F488
		public Aes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BBC RID: 3004
		// (get) Token: 0x0600312D RID: 12589 RVA: 0x000F7978 File Offset: 0x000F5B78
		// (set) Token: 0x0600312E RID: 12590 RVA: 0x00011291 File Offset: 0x0000F491
		public unsafe static Il2CppReferenceArray<KeySizes> s_legalBlockSizes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Aes.NativeFieldInfoPtr_s_legalBlockSizes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeySizes>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Aes.NativeFieldInfoPtr_s_legalBlockSizes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BBD RID: 3005
		// (get) Token: 0x0600312F RID: 12591 RVA: 0x000F79A0 File Offset: 0x000F5BA0
		// (set) Token: 0x06003130 RID: 12592 RVA: 0x000112A3 File Offset: 0x0000F4A3
		public unsafe static Il2CppReferenceArray<KeySizes> s_legalKeySizes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Aes.NativeFieldInfoPtr_s_legalKeySizes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeySizes>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Aes.NativeFieldInfoPtr_s_legalKeySizes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002A44 RID: 10820
		private static readonly IntPtr NativeFieldInfoPtr_s_legalBlockSizes;

		// Token: 0x04002A45 RID: 10821
		private static readonly IntPtr NativeFieldInfoPtr_s_legalKeySizes;

		// Token: 0x04002A46 RID: 10822
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
