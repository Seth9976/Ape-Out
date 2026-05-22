using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppCodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x020001FF RID: 511
	public class BitconverterExt : Object
	{
		// Token: 0x06001B1F RID: 6943 RVA: 0x0007B15C File Offset: 0x0007935C
		// Note: this type is marked as 'beforefieldinit'.
		static BitconverterExt()
		{
			Il2CppClassPointerStore<BitconverterExt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CodeStage.AntiCheat.ObscuredTypes", "BitconverterExt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BitconverterExt>.NativeClassPtr);
			BitconverterExt.NativeMethodInfoPtr_GetBytes_Public_Static_Il2CppStructArray_1_Byte_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitconverterExt>.NativeClassPtr, 100667650);
			BitconverterExt.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitconverterExt>.NativeClassPtr, 100667651);
			BitconverterExt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitconverterExt>.NativeClassPtr, 100667652);
		}

		// Token: 0x06001B20 RID: 6944 RVA: 0x0007B1C8 File Offset: 0x000793C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25787, XrefRangeEnd = 25808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> GetBytes(Decimal dec)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dec;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitconverterExt.NativeMethodInfoPtr_GetBytes_Public_Static_Il2CppStructArray_1_Byte_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06001B21 RID: 6945 RVA: 0x0007B208 File Offset: 0x00079408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25808, XrefRangeEnd = 25816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal ToDecimal(Il2CppStructArray<byte> bytes)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitconverterExt.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B22 RID: 6946 RVA: 0x0007B24C File Offset: 0x0007944C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BitconverterExt()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BitconverterExt>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitconverterExt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B23 RID: 6947 RVA: 0x0000A1AD File Offset: 0x000083AD
		public BitconverterExt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001C29 RID: 7209
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Static_Il2CppStructArray_1_Byte_Decimal_0;

		// Token: 0x04001C2A RID: 7210
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001C2B RID: 7211
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
