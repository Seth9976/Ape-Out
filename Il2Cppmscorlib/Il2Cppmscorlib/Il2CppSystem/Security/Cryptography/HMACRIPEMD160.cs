using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002EB RID: 747
	public class HMACRIPEMD160 : HMAC
	{
		// Token: 0x06003213 RID: 12819 RVA: 0x000FADB8 File Offset: 0x000F8FB8
		// Note: this type is marked as 'beforefieldinit'.
		static HMACRIPEMD160()
		{
			Il2CppClassPointerStore<HMACRIPEMD160>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "HMACRIPEMD160");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HMACRIPEMD160>.NativeClassPtr);
			HMACRIPEMD160.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMACRIPEMD160>.NativeClassPtr, 100671206);
			HMACRIPEMD160.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMACRIPEMD160>.NativeClassPtr, 100671207);
		}

		// Token: 0x06003214 RID: 12820 RVA: 0x000FAE10 File Offset: 0x000F9010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210104, XrefRangeEnd = 210119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HMACRIPEMD160()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HMACRIPEMD160>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HMACRIPEMD160.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003215 RID: 12821 RVA: 0x000FAE4C File Offset: 0x000F904C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210119, XrefRangeEnd = 210129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HMACRIPEMD160(Il2CppStructArray<byte> key)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HMACRIPEMD160>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HMACRIPEMD160.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003216 RID: 12822 RVA: 0x000118D7 File Offset: 0x0000FAD7
		public HMACRIPEMD160(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002AF2 RID: 10994
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002AF3 RID: 10995
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;
	}
}
