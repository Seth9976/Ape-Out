using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000018 RID: 24
	public class Base64Encoder : Object
	{
		// Token: 0x0600015D RID: 349 RVA: 0x00018D68 File Offset: 0x00016F68
		// Note: this type is marked as 'beforefieldinit'.
		static Base64Encoder()
		{
			Il2CppClassPointerStore<Base64Encoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "Base64Encoder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Base64Encoder>.NativeClassPtr);
			Base64Encoder.NativeFieldInfoPtr_leftOverBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Base64Encoder>.NativeClassPtr, "leftOverBytes");
			Base64Encoder.NativeFieldInfoPtr_leftOverBytesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Base64Encoder>.NativeClassPtr, "leftOverBytesCount");
			Base64Encoder.NativeFieldInfoPtr_charsLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Base64Encoder>.NativeClassPtr, "charsLine");
			Base64Encoder.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base64Encoder>.NativeClassPtr, 100663452);
			Base64Encoder.NativeMethodInfoPtr_WriteChars_Internal_Abstract_Virtual_New_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base64Encoder>.NativeClassPtr, 100663453);
			Base64Encoder.NativeMethodInfoPtr_Encode_Internal_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base64Encoder>.NativeClassPtr, 100663454);
			Base64Encoder.NativeMethodInfoPtr_Flush_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base64Encoder>.NativeClassPtr, 100663455);
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00018E24 File Offset: 0x00017024
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 389589, RefRangeEnd = 389593, XrefRangeStart = 389586, XrefRangeEnd = 389589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Base64Encoder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Base64Encoder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Base64Encoder.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00018E60 File Offset: 0x00017060
		[CallerCount(0)]
		public unsafe virtual void WriteChars(Il2CppStructArray<char> chars, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Base64Encoder.NativeMethodInfoPtr_WriteChars_Internal_Abstract_Virtual_New_Void_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00018ECC File Offset: 0x000170CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 389595, RefRangeEnd = 389597, XrefRangeStart = 389593, XrefRangeEnd = 389595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Encode(Il2CppStructArray<byte> buffer, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Base64Encoder.NativeMethodInfoPtr_Encode_Internal_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00018F2C File Offset: 0x0001712C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 389601, RefRangeEnd = 389609, XrefRangeStart = 389597, XrefRangeEnd = 389601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Base64Encoder.NativeMethodInfoPtr_Flush_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000162 RID: 354 RVA: 0x000029CC File Offset: 0x00000BCC
		public Base64Encoder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000163 RID: 355 RVA: 0x00018F60 File Offset: 0x00017160
		// (set) Token: 0x06000164 RID: 356 RVA: 0x000029D5 File Offset: 0x00000BD5
		public unsafe Il2CppStructArray<byte> leftOverBytes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base64Encoder.NativeFieldInfoPtr_leftOverBytes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base64Encoder.NativeFieldInfoPtr_leftOverBytes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000165 RID: 357 RVA: 0x00018F90 File Offset: 0x00017190
		// (set) Token: 0x06000166 RID: 358 RVA: 0x000029F4 File Offset: 0x00000BF4
		public unsafe int leftOverBytesCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base64Encoder.NativeFieldInfoPtr_leftOverBytesCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base64Encoder.NativeFieldInfoPtr_leftOverBytesCount)) = value;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000167 RID: 359 RVA: 0x00018FB8 File Offset: 0x000171B8
		// (set) Token: 0x06000168 RID: 360 RVA: 0x00002A0F File Offset: 0x00000C0F
		public unsafe Il2CppStructArray<char> charsLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base64Encoder.NativeFieldInfoPtr_charsLine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base64Encoder.NativeFieldInfoPtr_charsLine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeFieldInfoPtr_leftOverBytes;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeFieldInfoPtr_leftOverBytesCount;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeFieldInfoPtr_charsLine;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeMethodInfoPtr_WriteChars_Internal_Abstract_Virtual_New_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeMethodInfoPtr_Encode_Internal_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Internal_Void_0;
	}
}
