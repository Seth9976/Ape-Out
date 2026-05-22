using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.Cryptography;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000318 RID: 792
	public class RC2Transform : SymmetricTransform
	{
		// Token: 0x06003480 RID: 13440 RVA: 0x00103A50 File Offset: 0x00101C50
		// Note: this type is marked as 'beforefieldinit'.
		static RC2Transform()
		{
			Il2CppClassPointerStore<RC2Transform>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "RC2Transform");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RC2Transform>.NativeClassPtr);
			RC2Transform.NativeFieldInfoPtr_R0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RC2Transform>.NativeClassPtr, "R0");
			RC2Transform.NativeFieldInfoPtr_R1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RC2Transform>.NativeClassPtr, "R1");
			RC2Transform.NativeFieldInfoPtr_R2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RC2Transform>.NativeClassPtr, "R2");
			RC2Transform.NativeFieldInfoPtr_R3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RC2Transform>.NativeClassPtr, "R3");
			RC2Transform.NativeFieldInfoPtr_K = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RC2Transform>.NativeClassPtr, "K");
			RC2Transform.NativeFieldInfoPtr_j = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RC2Transform>.NativeClassPtr, "j");
			RC2Transform.NativeFieldInfoPtr_pitable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RC2Transform>.NativeClassPtr, "pitable");
			RC2Transform.NativeMethodInfoPtr__ctor_Public_Void_RC2_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RC2Transform>.NativeClassPtr, 100671499);
			RC2Transform.NativeMethodInfoPtr_ECB_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RC2Transform>.NativeClassPtr, 100671500);
		}

		// Token: 0x06003481 RID: 13441 RVA: 0x00103B34 File Offset: 0x00101D34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 212727, RefRangeEnd = 212729, XrefRangeStart = 212700, XrefRangeEnd = 212727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RC2Transform(RC2 rc2Algo, bool encryption, Il2CppStructArray<byte> key, Il2CppStructArray<byte> iv)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RC2Transform>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rc2Algo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref encryption;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(key);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(iv);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RC2Transform.NativeMethodInfoPtr__ctor_Public_Void_RC2_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003482 RID: 13442 RVA: 0x00103BB4 File Offset: 0x00101DB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212729, XrefRangeEnd = 212733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RC2Transform.NativeMethodInfoPtr_ECB_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003483 RID: 13443 RVA: 0x0001286E File Offset: 0x00010A6E
		public RC2Transform(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CA0 RID: 3232
		// (get) Token: 0x06003484 RID: 13444 RVA: 0x00103C14 File Offset: 0x00101E14
		// (set) Token: 0x06003485 RID: 13445 RVA: 0x00012877 File Offset: 0x00010A77
		public unsafe ushort R0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RC2Transform.NativeFieldInfoPtr_R0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RC2Transform.NativeFieldInfoPtr_R0)) = value;
			}
		}

		// Token: 0x17000CA1 RID: 3233
		// (get) Token: 0x06003486 RID: 13446 RVA: 0x00103C3C File Offset: 0x00101E3C
		// (set) Token: 0x06003487 RID: 13447 RVA: 0x00012892 File Offset: 0x00010A92
		public unsafe ushort R1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RC2Transform.NativeFieldInfoPtr_R1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RC2Transform.NativeFieldInfoPtr_R1)) = value;
			}
		}

		// Token: 0x17000CA2 RID: 3234
		// (get) Token: 0x06003488 RID: 13448 RVA: 0x00103C64 File Offset: 0x00101E64
		// (set) Token: 0x06003489 RID: 13449 RVA: 0x000128AD File Offset: 0x00010AAD
		public unsafe ushort R2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RC2Transform.NativeFieldInfoPtr_R2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RC2Transform.NativeFieldInfoPtr_R2)) = value;
			}
		}

		// Token: 0x17000CA3 RID: 3235
		// (get) Token: 0x0600348A RID: 13450 RVA: 0x00103C8C File Offset: 0x00101E8C
		// (set) Token: 0x0600348B RID: 13451 RVA: 0x000128C8 File Offset: 0x00010AC8
		public unsafe ushort R3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RC2Transform.NativeFieldInfoPtr_R3);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RC2Transform.NativeFieldInfoPtr_R3)) = value;
			}
		}

		// Token: 0x17000CA4 RID: 3236
		// (get) Token: 0x0600348C RID: 13452 RVA: 0x00103CB4 File Offset: 0x00101EB4
		// (set) Token: 0x0600348D RID: 13453 RVA: 0x000128E3 File Offset: 0x00010AE3
		public unsafe Il2CppStructArray<ushort> K
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RC2Transform.NativeFieldInfoPtr_K);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ushort>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RC2Transform.NativeFieldInfoPtr_K), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CA5 RID: 3237
		// (get) Token: 0x0600348E RID: 13454 RVA: 0x00103CE4 File Offset: 0x00101EE4
		// (set) Token: 0x0600348F RID: 13455 RVA: 0x00012902 File Offset: 0x00010B02
		public unsafe int j
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RC2Transform.NativeFieldInfoPtr_j);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RC2Transform.NativeFieldInfoPtr_j)) = value;
			}
		}

		// Token: 0x17000CA6 RID: 3238
		// (get) Token: 0x06003490 RID: 13456 RVA: 0x00103D0C File Offset: 0x00101F0C
		// (set) Token: 0x06003491 RID: 13457 RVA: 0x0001291D File Offset: 0x00010B1D
		public unsafe static Il2CppStructArray<byte> pitable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RC2Transform.NativeFieldInfoPtr_pitable, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RC2Transform.NativeFieldInfoPtr_pitable, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002C8C RID: 11404
		private static readonly IntPtr NativeFieldInfoPtr_R0;

		// Token: 0x04002C8D RID: 11405
		private static readonly IntPtr NativeFieldInfoPtr_R1;

		// Token: 0x04002C8E RID: 11406
		private static readonly IntPtr NativeFieldInfoPtr_R2;

		// Token: 0x04002C8F RID: 11407
		private static readonly IntPtr NativeFieldInfoPtr_R3;

		// Token: 0x04002C90 RID: 11408
		private static readonly IntPtr NativeFieldInfoPtr_K;

		// Token: 0x04002C91 RID: 11409
		private static readonly IntPtr NativeFieldInfoPtr_j;

		// Token: 0x04002C92 RID: 11410
		private static readonly IntPtr NativeFieldInfoPtr_pitable;

		// Token: 0x04002C93 RID: 11411
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RC2_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002C94 RID: 11412
		private static readonly IntPtr NativeMethodInfoPtr_ECB_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;
	}
}
