using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002EE RID: 750
	public class HMACSHA384 : HMAC
	{
		// Token: 0x06003220 RID: 12832 RVA: 0x000FB0C8 File Offset: 0x000F92C8
		// Note: this type is marked as 'beforefieldinit'.
		static HMACSHA384()
		{
			Il2CppClassPointerStore<HMACSHA384>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "HMACSHA384");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HMACSHA384>.NativeClassPtr);
			HMACSHA384.NativeFieldInfoPtr_m_useLegacyBlockSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HMACSHA384>.NativeClassPtr, "m_useLegacyBlockSize");
			HMACSHA384.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMACSHA384>.NativeClassPtr, 100671213);
			HMACSHA384.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMACSHA384>.NativeClassPtr, 100671214);
			HMACSHA384.NativeMethodInfoPtr_get_BlockSize_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMACSHA384>.NativeClassPtr, 100671215);
		}

		// Token: 0x06003221 RID: 12833 RVA: 0x000FB148 File Offset: 0x000F9348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210182, XrefRangeEnd = 210188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HMACSHA384()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HMACSHA384>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HMACSHA384.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003222 RID: 12834 RVA: 0x000FB184 File Offset: 0x000F9384
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 210198, RefRangeEnd = 210199, XrefRangeStart = 210188, XrefRangeEnd = 210198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HMACSHA384(Il2CppStructArray<byte> key)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HMACSHA384>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HMACSHA384.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000BFF RID: 3071
		// (get) Token: 0x06003223 RID: 12835 RVA: 0x000FB1D0 File Offset: 0x000F93D0
		public unsafe int BlockSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HMACSHA384.NativeMethodInfoPtr_get_BlockSize_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003224 RID: 12836 RVA: 0x000118F2 File Offset: 0x0000FAF2
		public HMACSHA384(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BFE RID: 3070
		// (get) Token: 0x06003225 RID: 12837 RVA: 0x000FB20C File Offset: 0x000F940C
		// (set) Token: 0x06003226 RID: 12838 RVA: 0x000118FB File Offset: 0x0000FAFB
		public unsafe bool m_useLegacyBlockSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HMACSHA384.NativeFieldInfoPtr_m_useLegacyBlockSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HMACSHA384.NativeFieldInfoPtr_m_useLegacyBlockSize)) = value;
			}
		}

		// Token: 0x04002AF9 RID: 11001
		private static readonly IntPtr NativeFieldInfoPtr_m_useLegacyBlockSize;

		// Token: 0x04002AFA RID: 11002
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002AFB RID: 11003
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002AFC RID: 11004
		private static readonly IntPtr NativeMethodInfoPtr_get_BlockSize_Private_get_Int32_0;
	}
}
