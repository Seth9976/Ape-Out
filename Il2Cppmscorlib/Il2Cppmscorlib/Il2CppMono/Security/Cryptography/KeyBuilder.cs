using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Security.Cryptography;

namespace Il2CppMono.Security.Cryptography
{
	// Token: 0x0200002A RID: 42
	public sealed class KeyBuilder : Object
	{
		// Token: 0x060002B8 RID: 696 RVA: 0x0002D038 File Offset: 0x0002B238
		// Note: this type is marked as 'beforefieldinit'.
		static KeyBuilder()
		{
			Il2CppClassPointerStore<KeyBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Security.Cryptography", "KeyBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyBuilder>.NativeClassPtr);
			KeyBuilder.NativeFieldInfoPtr_rng = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyBuilder>.NativeClassPtr, "rng");
			KeyBuilder.NativeMethodInfoPtr_get_Rng_Private_Static_get_RandomNumberGenerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyBuilder>.NativeClassPtr, 100663655);
			KeyBuilder.NativeMethodInfoPtr_Key_Public_Static_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyBuilder>.NativeClassPtr, 100663656);
			KeyBuilder.NativeMethodInfoPtr_IV_Public_Static_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyBuilder>.NativeClassPtr, 100663657);
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060002B9 RID: 697 RVA: 0x0002D0B8 File Offset: 0x0002B2B8
		public unsafe static RandomNumberGenerator Rng
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 134992, RefRangeEnd = 134996, XrefRangeStart = 134987, XrefRangeEnd = 134992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyBuilder.NativeMethodInfoPtr_get_Rng_Private_Static_get_RandomNumberGenerator_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RandomNumberGenerator>(intPtr3) : null;
			}
		}

		// Token: 0x060002BA RID: 698 RVA: 0x0002D0EC File Offset: 0x0002B2EC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 135000, RefRangeEnd = 135007, XrefRangeStart = 134996, XrefRangeEnd = 135000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> Key(int size)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyBuilder.NativeMethodInfoPtr_Key_Public_Static_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x060002BB RID: 699 RVA: 0x0002D12C File Offset: 0x0002B32C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 135011, RefRangeEnd = 135013, XrefRangeStart = 135007, XrefRangeEnd = 135011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> IV(int size)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyBuilder.NativeMethodInfoPtr_IV_Public_Static_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00003269 File Offset: 0x00001469
		public KeyBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060002BD RID: 701 RVA: 0x0002D16C File Offset: 0x0002B36C
		// (set) Token: 0x060002BE RID: 702 RVA: 0x00003272 File Offset: 0x00001472
		public unsafe static RandomNumberGenerator rng
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(KeyBuilder.NativeFieldInfoPtr_rng, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RandomNumberGenerator>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KeyBuilder.NativeFieldInfoPtr_rng, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001EA RID: 490
		private static readonly IntPtr NativeFieldInfoPtr_rng;

		// Token: 0x040001EB RID: 491
		private static readonly IntPtr NativeMethodInfoPtr_get_Rng_Private_Static_get_RandomNumberGenerator_0;

		// Token: 0x040001EC RID: 492
		private static readonly IntPtr NativeMethodInfoPtr_Key_Public_Static_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x040001ED RID: 493
		private static readonly IntPtr NativeMethodInfoPtr_IV_Public_Static_Il2CppStructArray_1_Byte_Int32_0;
	}
}
