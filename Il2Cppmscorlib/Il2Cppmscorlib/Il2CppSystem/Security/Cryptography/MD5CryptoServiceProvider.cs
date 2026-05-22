using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000317 RID: 791
	public sealed class MD5CryptoServiceProvider : MD5
	{
		// Token: 0x06003469 RID: 13417 RVA: 0x00103558 File Offset: 0x00101758
		// Note: this type is marked as 'beforefieldinit'.
		static MD5CryptoServiceProvider()
		{
			Il2CppClassPointerStore<MD5CryptoServiceProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "MD5CryptoServiceProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MD5CryptoServiceProvider>.NativeClassPtr);
			MD5CryptoServiceProvider.NativeFieldInfoPtr__H = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MD5CryptoServiceProvider>.NativeClassPtr, "_H");
			MD5CryptoServiceProvider.NativeFieldInfoPtr_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MD5CryptoServiceProvider>.NativeClassPtr, "buff");
			MD5CryptoServiceProvider.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MD5CryptoServiceProvider>.NativeClassPtr, "count");
			MD5CryptoServiceProvider.NativeFieldInfoPtr__ProcessingBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MD5CryptoServiceProvider>.NativeClassPtr, "_ProcessingBuffer");
			MD5CryptoServiceProvider.NativeFieldInfoPtr__ProcessingBufferCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MD5CryptoServiceProvider>.NativeClassPtr, "_ProcessingBufferCount");
			MD5CryptoServiceProvider.NativeFieldInfoPtr_K = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MD5CryptoServiceProvider>.NativeClassPtr, "K");
			MD5CryptoServiceProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD5CryptoServiceProvider>.NativeClassPtr, 100671489);
			MD5CryptoServiceProvider.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD5CryptoServiceProvider>.NativeClassPtr, 100671490);
			MD5CryptoServiceProvider.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD5CryptoServiceProvider>.NativeClassPtr, 100671491);
			MD5CryptoServiceProvider.NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD5CryptoServiceProvider>.NativeClassPtr, 100671492);
			MD5CryptoServiceProvider.NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD5CryptoServiceProvider>.NativeClassPtr, 100671493);
			MD5CryptoServiceProvider.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD5CryptoServiceProvider>.NativeClassPtr, 100671494);
			MD5CryptoServiceProvider.NativeMethodInfoPtr_ProcessBlock_Private_Void_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD5CryptoServiceProvider>.NativeClassPtr, 100671495);
			MD5CryptoServiceProvider.NativeMethodInfoPtr_ProcessFinalBlock_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD5CryptoServiceProvider>.NativeClassPtr, 100671496);
			MD5CryptoServiceProvider.NativeMethodInfoPtr_AddLength_Internal_Void_UInt64_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD5CryptoServiceProvider>.NativeClassPtr, 100671497);
		}

		// Token: 0x0600346A RID: 13418 RVA: 0x001036B4 File Offset: 0x001018B4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 212667, RefRangeEnd = 212672, XrefRangeStart = 212659, XrefRangeEnd = 212667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MD5CryptoServiceProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MD5CryptoServiceProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD5CryptoServiceProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600346B RID: 13419 RVA: 0x001036F0 File Offset: 0x001018F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212672, XrefRangeEnd = 212673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD5CryptoServiceProvider.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600346C RID: 13420 RVA: 0x00103724 File Offset: 0x00101924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212673, XrefRangeEnd = 212677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD5CryptoServiceProvider.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600346D RID: 13421 RVA: 0x00103764 File Offset: 0x00101964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212677, XrefRangeEnd = 212681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void HashCore(Il2CppStructArray<byte> rgb, int ibStart, int cbSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ibStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD5CryptoServiceProvider.NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600346E RID: 13422 RVA: 0x001037C4 File Offset: 0x001019C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212681, XrefRangeEnd = 212685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> HashFinal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD5CryptoServiceProvider.NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x0600346F RID: 13423 RVA: 0x00103804 File Offset: 0x00101A04
		[CallerCount(0)]
		public unsafe override void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD5CryptoServiceProvider.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003470 RID: 13424 RVA: 0x00103838 File Offset: 0x00101A38
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 212689, RefRangeEnd = 212693, XrefRangeStart = 212685, XrefRangeEnd = 212689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessBlock(Il2CppStructArray<byte> inputBuffer, int inputOffset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputBuffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD5CryptoServiceProvider.NativeMethodInfoPtr_ProcessBlock_Private_Void_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003471 RID: 13425 RVA: 0x00103888 File Offset: 0x00101A88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212699, RefRangeEnd = 212700, XrefRangeStart = 212693, XrefRangeEnd = 212699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessFinalBlock(Il2CppStructArray<byte> inputBuffer, int inputOffset, int inputCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputBuffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD5CryptoServiceProvider.NativeMethodInfoPtr_ProcessFinalBlock_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003472 RID: 13426 RVA: 0x001038E8 File Offset: 0x00101AE8
		[CallerCount(0)]
		public unsafe void AddLength(ulong length, Il2CppStructArray<byte> buffer, int position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref length;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD5CryptoServiceProvider.NativeMethodInfoPtr_AddLength_Internal_Void_UInt64_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003473 RID: 13427 RVA: 0x000127C0 File Offset: 0x000109C0
		public MD5CryptoServiceProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C9A RID: 3226
		// (get) Token: 0x06003474 RID: 13428 RVA: 0x00103948 File Offset: 0x00101B48
		// (set) Token: 0x06003475 RID: 13429 RVA: 0x000127C9 File Offset: 0x000109C9
		public unsafe Il2CppStructArray<uint> _H
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD5CryptoServiceProvider.NativeFieldInfoPtr__H);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD5CryptoServiceProvider.NativeFieldInfoPtr__H), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C9B RID: 3227
		// (get) Token: 0x06003476 RID: 13430 RVA: 0x00103978 File Offset: 0x00101B78
		// (set) Token: 0x06003477 RID: 13431 RVA: 0x000127E8 File Offset: 0x000109E8
		public unsafe Il2CppStructArray<uint> buff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD5CryptoServiceProvider.NativeFieldInfoPtr_buff);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD5CryptoServiceProvider.NativeFieldInfoPtr_buff), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C9C RID: 3228
		// (get) Token: 0x06003478 RID: 13432 RVA: 0x001039A8 File Offset: 0x00101BA8
		// (set) Token: 0x06003479 RID: 13433 RVA: 0x00012807 File Offset: 0x00010A07
		public unsafe ulong count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD5CryptoServiceProvider.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD5CryptoServiceProvider.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x17000C9D RID: 3229
		// (get) Token: 0x0600347A RID: 13434 RVA: 0x001039D0 File Offset: 0x00101BD0
		// (set) Token: 0x0600347B RID: 13435 RVA: 0x00012822 File Offset: 0x00010A22
		public unsafe Il2CppStructArray<byte> _ProcessingBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD5CryptoServiceProvider.NativeFieldInfoPtr__ProcessingBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD5CryptoServiceProvider.NativeFieldInfoPtr__ProcessingBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C9E RID: 3230
		// (get) Token: 0x0600347C RID: 13436 RVA: 0x00103A00 File Offset: 0x00101C00
		// (set) Token: 0x0600347D RID: 13437 RVA: 0x00012841 File Offset: 0x00010A41
		public unsafe int _ProcessingBufferCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD5CryptoServiceProvider.NativeFieldInfoPtr__ProcessingBufferCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD5CryptoServiceProvider.NativeFieldInfoPtr__ProcessingBufferCount)) = value;
			}
		}

		// Token: 0x17000C9F RID: 3231
		// (get) Token: 0x0600347E RID: 13438 RVA: 0x00103A28 File Offset: 0x00101C28
		// (set) Token: 0x0600347F RID: 13439 RVA: 0x0001285C File Offset: 0x00010A5C
		public unsafe static Il2CppStructArray<uint> K
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MD5CryptoServiceProvider.NativeFieldInfoPtr_K, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MD5CryptoServiceProvider.NativeFieldInfoPtr_K, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002C7D RID: 11389
		private static readonly IntPtr NativeFieldInfoPtr__H;

		// Token: 0x04002C7E RID: 11390
		private static readonly IntPtr NativeFieldInfoPtr_buff;

		// Token: 0x04002C7F RID: 11391
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x04002C80 RID: 11392
		private static readonly IntPtr NativeFieldInfoPtr__ProcessingBuffer;

		// Token: 0x04002C81 RID: 11393
		private static readonly IntPtr NativeFieldInfoPtr__ProcessingBufferCount;

		// Token: 0x04002C82 RID: 11394
		private static readonly IntPtr NativeFieldInfoPtr_K;

		// Token: 0x04002C83 RID: 11395
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002C84 RID: 11396
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04002C85 RID: 11397
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04002C86 RID: 11398
		private static readonly IntPtr NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04002C87 RID: 11399
		private static readonly IntPtr NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002C88 RID: 11400
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

		// Token: 0x04002C89 RID: 11401
		private static readonly IntPtr NativeMethodInfoPtr_ProcessBlock_Private_Void_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04002C8A RID: 11402
		private static readonly IntPtr NativeMethodInfoPtr_ProcessFinalBlock_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04002C8B RID: 11403
		private static readonly IntPtr NativeMethodInfoPtr_AddLength_Internal_Void_UInt64_Il2CppStructArray_1_Byte_Int32_0;
	}
}
