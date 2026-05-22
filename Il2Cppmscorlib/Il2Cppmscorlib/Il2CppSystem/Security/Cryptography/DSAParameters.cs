using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002E4 RID: 740
	[Serializable]
	public sealed class DSAParameters : ValueType
	{
		// Token: 0x060031B4 RID: 12724 RVA: 0x000F992C File Offset: 0x000F7B2C
		// Note: this type is marked as 'beforefieldinit'.
		static DSAParameters()
		{
			Il2CppClassPointerStore<DSAParameters>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "DSAParameters");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DSAParameters>.NativeClassPtr);
			DSAParameters.NativeFieldInfoPtr_P = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSAParameters>.NativeClassPtr, "P");
			DSAParameters.NativeFieldInfoPtr_Q = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSAParameters>.NativeClassPtr, "Q");
			DSAParameters.NativeFieldInfoPtr_G = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSAParameters>.NativeClassPtr, "G");
			DSAParameters.NativeFieldInfoPtr_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSAParameters>.NativeClassPtr, "Y");
			DSAParameters.NativeFieldInfoPtr_J = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSAParameters>.NativeClassPtr, "J");
			DSAParameters.NativeFieldInfoPtr_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSAParameters>.NativeClassPtr, "X");
			DSAParameters.NativeFieldInfoPtr_Seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSAParameters>.NativeClassPtr, "Seed");
			DSAParameters.NativeFieldInfoPtr_Counter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSAParameters>.NativeClassPtr, "Counter");
		}

		// Token: 0x060031B5 RID: 12725 RVA: 0x00011613 File Offset: 0x0000F813
		public DSAParameters(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060031B6 RID: 12726 RVA: 0x0001161C File Offset: 0x0000F81C
		public DSAParameters()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DSAParameters>.NativeClassPtr))
		{
		}

		// Token: 0x17000BE2 RID: 3042
		// (get) Token: 0x060031B7 RID: 12727 RVA: 0x000F99FC File Offset: 0x000F7BFC
		// (set) Token: 0x060031B8 RID: 12728 RVA: 0x0001162E File Offset: 0x0000F82E
		public unsafe Il2CppStructArray<byte> P
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAParameters.NativeFieldInfoPtr_P);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAParameters.NativeFieldInfoPtr_P), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BE3 RID: 3043
		// (get) Token: 0x060031B9 RID: 12729 RVA: 0x000F9A2C File Offset: 0x000F7C2C
		// (set) Token: 0x060031BA RID: 12730 RVA: 0x0001164D File Offset: 0x0000F84D
		public unsafe Il2CppStructArray<byte> Q
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAParameters.NativeFieldInfoPtr_Q);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAParameters.NativeFieldInfoPtr_Q), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BE4 RID: 3044
		// (get) Token: 0x060031BB RID: 12731 RVA: 0x000F9A5C File Offset: 0x000F7C5C
		// (set) Token: 0x060031BC RID: 12732 RVA: 0x0001166C File Offset: 0x0000F86C
		public unsafe Il2CppStructArray<byte> G
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAParameters.NativeFieldInfoPtr_G);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAParameters.NativeFieldInfoPtr_G), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BE5 RID: 3045
		// (get) Token: 0x060031BD RID: 12733 RVA: 0x000F9A8C File Offset: 0x000F7C8C
		// (set) Token: 0x060031BE RID: 12734 RVA: 0x0001168B File Offset: 0x0000F88B
		public unsafe Il2CppStructArray<byte> Y
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAParameters.NativeFieldInfoPtr_Y);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAParameters.NativeFieldInfoPtr_Y), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BE6 RID: 3046
		// (get) Token: 0x060031BF RID: 12735 RVA: 0x000F9ABC File Offset: 0x000F7CBC
		// (set) Token: 0x060031C0 RID: 12736 RVA: 0x000116AA File Offset: 0x0000F8AA
		public unsafe Il2CppStructArray<byte> J
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAParameters.NativeFieldInfoPtr_J);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAParameters.NativeFieldInfoPtr_J), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BE7 RID: 3047
		// (get) Token: 0x060031C1 RID: 12737 RVA: 0x000F9AEC File Offset: 0x000F7CEC
		// (set) Token: 0x060031C2 RID: 12738 RVA: 0x000116C9 File Offset: 0x0000F8C9
		public unsafe Il2CppStructArray<byte> X
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAParameters.NativeFieldInfoPtr_X);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAParameters.NativeFieldInfoPtr_X), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BE8 RID: 3048
		// (get) Token: 0x060031C3 RID: 12739 RVA: 0x000F9B1C File Offset: 0x000F7D1C
		// (set) Token: 0x060031C4 RID: 12740 RVA: 0x000116E8 File Offset: 0x0000F8E8
		public unsafe Il2CppStructArray<byte> Seed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAParameters.NativeFieldInfoPtr_Seed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAParameters.NativeFieldInfoPtr_Seed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BE9 RID: 3049
		// (get) Token: 0x060031C5 RID: 12741 RVA: 0x000F9B4C File Offset: 0x000F7D4C
		// (set) Token: 0x060031C6 RID: 12742 RVA: 0x00011707 File Offset: 0x0000F907
		public unsafe int Counter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAParameters.NativeFieldInfoPtr_Counter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAParameters.NativeFieldInfoPtr_Counter)) = value;
			}
		}

		// Token: 0x04002AB7 RID: 10935
		private static readonly IntPtr NativeFieldInfoPtr_P;

		// Token: 0x04002AB8 RID: 10936
		private static readonly IntPtr NativeFieldInfoPtr_Q;

		// Token: 0x04002AB9 RID: 10937
		private static readonly IntPtr NativeFieldInfoPtr_G;

		// Token: 0x04002ABA RID: 10938
		private static readonly IntPtr NativeFieldInfoPtr_Y;

		// Token: 0x04002ABB RID: 10939
		private static readonly IntPtr NativeFieldInfoPtr_J;

		// Token: 0x04002ABC RID: 10940
		private static readonly IntPtr NativeFieldInfoPtr_X;

		// Token: 0x04002ABD RID: 10941
		private static readonly IntPtr NativeFieldInfoPtr_Seed;

		// Token: 0x04002ABE RID: 10942
		private static readonly IntPtr NativeFieldInfoPtr_Counter;
	}
}
