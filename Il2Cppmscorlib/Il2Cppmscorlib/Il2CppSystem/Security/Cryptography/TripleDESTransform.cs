using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.Cryptography;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x0200031E RID: 798
	public class TripleDESTransform : SymmetricTransform
	{
		// Token: 0x060034C6 RID: 13510 RVA: 0x00104868 File Offset: 0x00102A68
		// Note: this type is marked as 'beforefieldinit'.
		static TripleDESTransform()
		{
			Il2CppClassPointerStore<TripleDESTransform>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "TripleDESTransform");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TripleDESTransform>.NativeClassPtr);
			TripleDESTransform.NativeFieldInfoPtr_E1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TripleDESTransform>.NativeClassPtr, "E1");
			TripleDESTransform.NativeFieldInfoPtr_D2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TripleDESTransform>.NativeClassPtr, "D2");
			TripleDESTransform.NativeFieldInfoPtr_E3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TripleDESTransform>.NativeClassPtr, "E3");
			TripleDESTransform.NativeFieldInfoPtr_D1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TripleDESTransform>.NativeClassPtr, "D1");
			TripleDESTransform.NativeFieldInfoPtr_E2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TripleDESTransform>.NativeClassPtr, "E2");
			TripleDESTransform.NativeFieldInfoPtr_D3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TripleDESTransform>.NativeClassPtr, "D3");
			TripleDESTransform.NativeMethodInfoPtr__ctor_Public_Void_TripleDES_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TripleDESTransform>.NativeClassPtr, 100671529);
			TripleDESTransform.NativeMethodInfoPtr_ECB_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TripleDESTransform>.NativeClassPtr, 100671530);
			TripleDESTransform.NativeMethodInfoPtr_GetStrongKey_Internal_Static_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TripleDESTransform>.NativeClassPtr, 100671531);
		}

		// Token: 0x060034C7 RID: 13511 RVA: 0x0010494C File Offset: 0x00102B4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 212914, RefRangeEnd = 212916, XrefRangeStart = 212850, XrefRangeEnd = 212914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TripleDESTransform(TripleDES algo, bool encryption, Il2CppStructArray<byte> key, Il2CppStructArray<byte> iv)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TripleDESTransform>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TripleDESTransform.NativeMethodInfoPtr__ctor_Public_Void_TripleDES_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034C8 RID: 13512 RVA: 0x001049CC File Offset: 0x00102BCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212916, XrefRangeEnd = 212931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TripleDESTransform.NativeMethodInfoPtr_ECB_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034C9 RID: 13513 RVA: 0x00104A2C File Offset: 0x00102C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212931, XrefRangeEnd = 212945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> GetStrongKey()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TripleDESTransform.NativeMethodInfoPtr_GetStrongKey_Internal_Static_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060034CA RID: 13514 RVA: 0x00012AAD File Offset: 0x00010CAD
		public TripleDESTransform(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CAF RID: 3247
		// (get) Token: 0x060034CB RID: 13515 RVA: 0x00104A60 File Offset: 0x00102C60
		// (set) Token: 0x060034CC RID: 13516 RVA: 0x00012AB6 File Offset: 0x00010CB6
		public unsafe DESTransform E1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TripleDESTransform.NativeFieldInfoPtr_E1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DESTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TripleDESTransform.NativeFieldInfoPtr_E1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CB0 RID: 3248
		// (get) Token: 0x060034CD RID: 13517 RVA: 0x00104A90 File Offset: 0x00102C90
		// (set) Token: 0x060034CE RID: 13518 RVA: 0x00012AD5 File Offset: 0x00010CD5
		public unsafe DESTransform D2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TripleDESTransform.NativeFieldInfoPtr_D2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DESTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TripleDESTransform.NativeFieldInfoPtr_D2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CB1 RID: 3249
		// (get) Token: 0x060034CF RID: 13519 RVA: 0x00104AC0 File Offset: 0x00102CC0
		// (set) Token: 0x060034D0 RID: 13520 RVA: 0x00012AF4 File Offset: 0x00010CF4
		public unsafe DESTransform E3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TripleDESTransform.NativeFieldInfoPtr_E3);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DESTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TripleDESTransform.NativeFieldInfoPtr_E3), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CB2 RID: 3250
		// (get) Token: 0x060034D1 RID: 13521 RVA: 0x00104AF0 File Offset: 0x00102CF0
		// (set) Token: 0x060034D2 RID: 13522 RVA: 0x00012B13 File Offset: 0x00010D13
		public unsafe DESTransform D1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TripleDESTransform.NativeFieldInfoPtr_D1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DESTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TripleDESTransform.NativeFieldInfoPtr_D1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CB3 RID: 3251
		// (get) Token: 0x060034D3 RID: 13523 RVA: 0x00104B20 File Offset: 0x00102D20
		// (set) Token: 0x060034D4 RID: 13524 RVA: 0x00012B32 File Offset: 0x00010D32
		public unsafe DESTransform E2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TripleDESTransform.NativeFieldInfoPtr_E2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DESTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TripleDESTransform.NativeFieldInfoPtr_E2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CB4 RID: 3252
		// (get) Token: 0x060034D5 RID: 13525 RVA: 0x00104B50 File Offset: 0x00102D50
		// (set) Token: 0x060034D6 RID: 13526 RVA: 0x00012B51 File Offset: 0x00010D51
		public unsafe DESTransform D3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TripleDESTransform.NativeFieldInfoPtr_D3);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DESTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TripleDESTransform.NativeFieldInfoPtr_D3), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002CB7 RID: 11447
		private static readonly IntPtr NativeFieldInfoPtr_E1;

		// Token: 0x04002CB8 RID: 11448
		private static readonly IntPtr NativeFieldInfoPtr_D2;

		// Token: 0x04002CB9 RID: 11449
		private static readonly IntPtr NativeFieldInfoPtr_E3;

		// Token: 0x04002CBA RID: 11450
		private static readonly IntPtr NativeFieldInfoPtr_D1;

		// Token: 0x04002CBB RID: 11451
		private static readonly IntPtr NativeFieldInfoPtr_E2;

		// Token: 0x04002CBC RID: 11452
		private static readonly IntPtr NativeFieldInfoPtr_D3;

		// Token: 0x04002CBD RID: 11453
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TripleDES_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002CBE RID: 11454
		private static readonly IntPtr NativeMethodInfoPtr_ECB_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002CBF RID: 11455
		private static readonly IntPtr NativeMethodInfoPtr_GetStrongKey_Internal_Static_Il2CppStructArray_1_Byte_0;
	}
}
