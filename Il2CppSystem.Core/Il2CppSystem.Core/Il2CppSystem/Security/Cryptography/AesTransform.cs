using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.Cryptography;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000005 RID: 5
	public class AesTransform : SymmetricTransform
	{
		// Token: 0x06000031 RID: 49 RVA: 0x000043A4 File Offset: 0x000025A4
		// Note: this type is marked as 'beforefieldinit'.
		static AesTransform()
		{
			Il2CppClassPointerStore<AesTransform>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Security.Cryptography", "AesTransform");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AesTransform>.NativeClassPtr);
			AesTransform.NativeFieldInfoPtr_expandedKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, "expandedKey");
			AesTransform.NativeFieldInfoPtr_Nk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, "Nk");
			AesTransform.NativeFieldInfoPtr_Nr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, "Nr");
			AesTransform.NativeFieldInfoPtr_Rcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, "Rcon");
			AesTransform.NativeFieldInfoPtr_SBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, "SBox");
			AesTransform.NativeFieldInfoPtr_iSBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, "iSBox");
			AesTransform.NativeFieldInfoPtr_T0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, "T0");
			AesTransform.NativeFieldInfoPtr_T1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, "T1");
			AesTransform.NativeFieldInfoPtr_T2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, "T2");
			AesTransform.NativeFieldInfoPtr_T3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, "T3");
			AesTransform.NativeFieldInfoPtr_iT0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, "iT0");
			AesTransform.NativeFieldInfoPtr_iT1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, "iT1");
			AesTransform.NativeFieldInfoPtr_iT2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, "iT2");
			AesTransform.NativeFieldInfoPtr_iT3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, "iT3");
			AesTransform.NativeMethodInfoPtr__ctor_Public_Void_Aes_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, 100663337);
			AesTransform.NativeMethodInfoPtr_ECB_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, 100663338);
			AesTransform.NativeMethodInfoPtr_SubByte_Private_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, 100663339);
			AesTransform.NativeMethodInfoPtr_Encrypt128_Private_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, 100663340);
			AesTransform.NativeMethodInfoPtr_Decrypt128_Private_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, 100663341);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00004550 File Offset: 0x00002750
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 362828, RefRangeEnd = 362830, XrefRangeStart = 362811, XrefRangeEnd = 362828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AesTransform(Aes algo, bool encryption, Il2CppStructArray<byte> key, Il2CppStructArray<byte> iv)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AesTransform>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(algo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref encryption;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(key);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(iv);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AesTransform.NativeMethodInfoPtr__ctor_Public_Void_Aes_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000045D0 File Offset: 0x000027D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362830, XrefRangeEnd = 362831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ECB(Il2CppStructArray<byte> input, Il2CppStructArray<byte> output)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(output);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AesTransform.NativeMethodInfoPtr_ECB_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00004630 File Offset: 0x00002830
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 362835, RefRangeEnd = 362837, XrefRangeStart = 362831, XrefRangeEnd = 362835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint SubByte(uint a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AesTransform.NativeMethodInfoPtr_SubByte_Private_UInt32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000467C File Offset: 0x0000287C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362837, XrefRangeEnd = 362866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Encrypt128(Il2CppStructArray<byte> indata, Il2CppStructArray<byte> outdata, Il2CppStructArray<uint> ekey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(indata);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outdata);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ekey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AesTransform.NativeMethodInfoPtr_Encrypt128_Private_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000046E4 File Offset: 0x000028E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 362895, RefRangeEnd = 362896, XrefRangeStart = 362866, XrefRangeEnd = 362895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Decrypt128(Il2CppStructArray<byte> indata, Il2CppStructArray<byte> outdata, Il2CppStructArray<uint> ekey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(indata);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outdata);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ekey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AesTransform.NativeMethodInfoPtr_Decrypt128_Private_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0000208A File Offset: 0x0000028A
		public AesTransform(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000038 RID: 56 RVA: 0x0000474C File Offset: 0x0000294C
		// (set) Token: 0x06000039 RID: 57 RVA: 0x00002093 File Offset: 0x00000293
		public unsafe Il2CppStructArray<uint> expandedKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AesTransform.NativeFieldInfoPtr_expandedKey);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AesTransform.NativeFieldInfoPtr_expandedKey), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600003A RID: 58 RVA: 0x0000477C File Offset: 0x0000297C
		// (set) Token: 0x0600003B RID: 59 RVA: 0x000020B2 File Offset: 0x000002B2
		public unsafe int Nk
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AesTransform.NativeFieldInfoPtr_Nk);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AesTransform.NativeFieldInfoPtr_Nk)) = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600003C RID: 60 RVA: 0x000047A4 File Offset: 0x000029A4
		// (set) Token: 0x0600003D RID: 61 RVA: 0x000020CD File Offset: 0x000002CD
		public unsafe int Nr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AesTransform.NativeFieldInfoPtr_Nr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AesTransform.NativeFieldInfoPtr_Nr)) = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600003E RID: 62 RVA: 0x000047CC File Offset: 0x000029CC
		// (set) Token: 0x0600003F RID: 63 RVA: 0x000020E8 File Offset: 0x000002E8
		public unsafe static Il2CppStructArray<uint> Rcon
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AesTransform.NativeFieldInfoPtr_Rcon, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AesTransform.NativeFieldInfoPtr_Rcon, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000040 RID: 64 RVA: 0x000047F4 File Offset: 0x000029F4
		// (set) Token: 0x06000041 RID: 65 RVA: 0x000020FA File Offset: 0x000002FA
		public unsafe static Il2CppStructArray<byte> SBox
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AesTransform.NativeFieldInfoPtr_SBox, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AesTransform.NativeFieldInfoPtr_SBox, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000042 RID: 66 RVA: 0x0000481C File Offset: 0x00002A1C
		// (set) Token: 0x06000043 RID: 67 RVA: 0x0000210C File Offset: 0x0000030C
		public unsafe static Il2CppStructArray<byte> iSBox
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AesTransform.NativeFieldInfoPtr_iSBox, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AesTransform.NativeFieldInfoPtr_iSBox, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00004844 File Offset: 0x00002A44
		// (set) Token: 0x06000045 RID: 69 RVA: 0x0000211E File Offset: 0x0000031E
		public unsafe static Il2CppStructArray<uint> T0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AesTransform.NativeFieldInfoPtr_T0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AesTransform.NativeFieldInfoPtr_T0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000046 RID: 70 RVA: 0x0000486C File Offset: 0x00002A6C
		// (set) Token: 0x06000047 RID: 71 RVA: 0x00002130 File Offset: 0x00000330
		public unsafe static Il2CppStructArray<uint> T1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AesTransform.NativeFieldInfoPtr_T1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AesTransform.NativeFieldInfoPtr_T1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00004894 File Offset: 0x00002A94
		// (set) Token: 0x06000049 RID: 73 RVA: 0x00002142 File Offset: 0x00000342
		public unsafe static Il2CppStructArray<uint> T2
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AesTransform.NativeFieldInfoPtr_T2, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AesTransform.NativeFieldInfoPtr_T2, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600004A RID: 74 RVA: 0x000048BC File Offset: 0x00002ABC
		// (set) Token: 0x0600004B RID: 75 RVA: 0x00002154 File Offset: 0x00000354
		public unsafe static Il2CppStructArray<uint> T3
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AesTransform.NativeFieldInfoPtr_T3, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AesTransform.NativeFieldInfoPtr_T3, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600004C RID: 76 RVA: 0x000048E4 File Offset: 0x00002AE4
		// (set) Token: 0x0600004D RID: 77 RVA: 0x00002166 File Offset: 0x00000366
		public unsafe static Il2CppStructArray<uint> iT0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AesTransform.NativeFieldInfoPtr_iT0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AesTransform.NativeFieldInfoPtr_iT0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600004E RID: 78 RVA: 0x0000490C File Offset: 0x00002B0C
		// (set) Token: 0x0600004F RID: 79 RVA: 0x00002178 File Offset: 0x00000378
		public unsafe static Il2CppStructArray<uint> iT1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AesTransform.NativeFieldInfoPtr_iT1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AesTransform.NativeFieldInfoPtr_iT1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00004934 File Offset: 0x00002B34
		// (set) Token: 0x06000051 RID: 81 RVA: 0x0000218A File Offset: 0x0000038A
		public unsafe static Il2CppStructArray<uint> iT2
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AesTransform.NativeFieldInfoPtr_iT2, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AesTransform.NativeFieldInfoPtr_iT2, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000052 RID: 82 RVA: 0x0000495C File Offset: 0x00002B5C
		// (set) Token: 0x06000053 RID: 83 RVA: 0x0000219C File Offset: 0x0000039C
		public unsafe static Il2CppStructArray<uint> iT3
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AesTransform.NativeFieldInfoPtr_iT3, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AesTransform.NativeFieldInfoPtr_iT3, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeFieldInfoPtr_expandedKey;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeFieldInfoPtr_Nk;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeFieldInfoPtr_Nr;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeFieldInfoPtr_Rcon;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeFieldInfoPtr_SBox;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeFieldInfoPtr_iSBox;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeFieldInfoPtr_T0;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeFieldInfoPtr_T1;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeFieldInfoPtr_T2;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeFieldInfoPtr_T3;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeFieldInfoPtr_iT0;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeFieldInfoPtr_iT1;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeFieldInfoPtr_iT2;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeFieldInfoPtr_iT3;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Aes_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr_ECB_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_SubByte_Private_UInt32_UInt32_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_Encrypt128_Private_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt32_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_Decrypt128_Private_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt32_0;
	}
}
