using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002EA RID: 746
	public class HMACMD5 : HMAC
	{
		// Token: 0x0600320F RID: 12815 RVA: 0x000FACD8 File Offset: 0x000F8ED8
		// Note: this type is marked as 'beforefieldinit'.
		static HMACMD5()
		{
			Il2CppClassPointerStore<HMACMD5>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "HMACMD5");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HMACMD5>.NativeClassPtr);
			HMACMD5.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMACMD5>.NativeClassPtr, 100671204);
			HMACMD5.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMACMD5>.NativeClassPtr, 100671205);
		}

		// Token: 0x06003210 RID: 12816 RVA: 0x000FAD30 File Offset: 0x000F8F30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210085, XrefRangeEnd = 210091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HMACMD5()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HMACMD5>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HMACMD5.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003211 RID: 12817 RVA: 0x000FAD6C File Offset: 0x000F8F6C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 210101, RefRangeEnd = 210104, XrefRangeStart = 210091, XrefRangeEnd = 210101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HMACMD5(Il2CppStructArray<byte> key)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HMACMD5>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HMACMD5.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003212 RID: 12818 RVA: 0x000118CE File Offset: 0x0000FACE
		public HMACMD5(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002AF0 RID: 10992
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002AF1 RID: 10993
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;
	}
}
