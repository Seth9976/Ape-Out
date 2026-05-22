using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security
{
	// Token: 0x020002C1 RID: 705
	public sealed class SecureString : Object
	{
		// Token: 0x06002FEE RID: 12270 RVA: 0x000F3484 File Offset: 0x000F1684
		// Note: this type is marked as 'beforefieldinit'.
		static SecureString()
		{
			Il2CppClassPointerStore<SecureString>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security", "SecureString");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SecureString>.NativeClassPtr);
			SecureString.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecureString>.NativeClassPtr, "length");
			SecureString.NativeFieldInfoPtr_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecureString>.NativeClassPtr, "disposed");
			SecureString.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecureString>.NativeClassPtr, "data");
			SecureString.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecureString>.NativeClassPtr, 100670938);
			SecureString.NativeMethodInfoPtr__ctor_Public_Void_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecureString>.NativeClassPtr, 100670939);
			SecureString.NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecureString>.NativeClassPtr, 100670940);
			SecureString.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecureString>.NativeClassPtr, 100670941);
			SecureString.NativeMethodInfoPtr_Encrypt_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecureString>.NativeClassPtr, 100670942);
			SecureString.NativeMethodInfoPtr_Decrypt_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecureString>.NativeClassPtr, 100670943);
			SecureString.NativeMethodInfoPtr_Alloc_Private_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecureString>.NativeClassPtr, 100670944);
			SecureString.NativeMethodInfoPtr_GetBuffer_Internal_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecureString>.NativeClassPtr, 100670945);
		}

		// Token: 0x06002FEF RID: 12271 RVA: 0x000F3590 File Offset: 0x000F1790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207708, XrefRangeEnd = 207713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SecureString()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SecureString>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecureString.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FF0 RID: 12272 RVA: 0x000F35CC File Offset: 0x000F17CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207713, XrefRangeEnd = 207714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SecureString(char* value, int length)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SecureString>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecureString.NativeMethodInfoPtr__ctor_Public_Void_ptr_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B5D RID: 2909
		// (get) Token: 0x06002FF1 RID: 12273 RVA: 0x000F3620 File Offset: 0x000F1820
		public unsafe int Length
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 207714, RefRangeEnd = 207716, XrefRangeStart = 207714, XrefRangeEnd = 207714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecureString.NativeMethodInfoPtr_get_Length_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002FF2 RID: 12274 RVA: 0x000F365C File Offset: 0x000F185C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207716, XrefRangeEnd = 207717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecureString.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FF3 RID: 12275 RVA: 0x000F3690 File Offset: 0x000F1890
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 33858, RefRangeEnd = 33864, XrefRangeStart = 33858, XrefRangeEnd = 33864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Encrypt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecureString.NativeMethodInfoPtr_Encrypt_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FF4 RID: 12276 RVA: 0x000F36C4 File Offset: 0x000F18C4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 33858, RefRangeEnd = 33864, XrefRangeStart = 33858, XrefRangeEnd = 33864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Decrypt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecureString.NativeMethodInfoPtr_Decrypt_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FF5 RID: 12277 RVA: 0x000F36F8 File Offset: 0x000F18F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 207722, RefRangeEnd = 207724, XrefRangeStart = 207717, XrefRangeEnd = 207722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Alloc(int length, bool realloc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref length;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref realloc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecureString.NativeMethodInfoPtr_Alloc_Private_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FF6 RID: 12278 RVA: 0x000F3744 File Offset: 0x000F1944
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 207729, RefRangeEnd = 207730, XrefRangeStart = 207724, XrefRangeEnd = 207729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecureString.NativeMethodInfoPtr_GetBuffer_Internal_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06002FF7 RID: 12279 RVA: 0x0001091F File Offset: 0x0000EB1F
		public SecureString(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B5A RID: 2906
		// (get) Token: 0x06002FF8 RID: 12280 RVA: 0x000F3784 File Offset: 0x000F1984
		// (set) Token: 0x06002FF9 RID: 12281 RVA: 0x00010928 File Offset: 0x0000EB28
		public unsafe int length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecureString.NativeFieldInfoPtr_length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecureString.NativeFieldInfoPtr_length)) = value;
			}
		}

		// Token: 0x17000B5B RID: 2907
		// (get) Token: 0x06002FFA RID: 12282 RVA: 0x000F37AC File Offset: 0x000F19AC
		// (set) Token: 0x06002FFB RID: 12283 RVA: 0x00010943 File Offset: 0x0000EB43
		public unsafe bool disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecureString.NativeFieldInfoPtr_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecureString.NativeFieldInfoPtr_disposed)) = value;
			}
		}

		// Token: 0x17000B5C RID: 2908
		// (get) Token: 0x06002FFC RID: 12284 RVA: 0x000F37D4 File Offset: 0x000F19D4
		// (set) Token: 0x06002FFD RID: 12285 RVA: 0x0001095E File Offset: 0x0000EB5E
		public unsafe Il2CppStructArray<byte> data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecureString.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecureString.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002968 RID: 10600
		private static readonly IntPtr NativeFieldInfoPtr_length;

		// Token: 0x04002969 RID: 10601
		private static readonly IntPtr NativeFieldInfoPtr_disposed;

		// Token: 0x0400296A RID: 10602
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x0400296B RID: 10603
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400296C RID: 10604
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ptr_Char_Int32_0;

		// Token: 0x0400296D RID: 10605
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;

		// Token: 0x0400296E RID: 10606
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400296F RID: 10607
		private static readonly IntPtr NativeMethodInfoPtr_Encrypt_Private_Void_0;

		// Token: 0x04002970 RID: 10608
		private static readonly IntPtr NativeMethodInfoPtr_Decrypt_Private_Void_0;

		// Token: 0x04002971 RID: 10609
		private static readonly IntPtr NativeMethodInfoPtr_Alloc_Private_Void_Int32_Boolean_0;

		// Token: 0x04002972 RID: 10610
		private static readonly IntPtr NativeMethodInfoPtr_GetBuffer_Internal_Il2CppStructArray_1_Byte_0;
	}
}
