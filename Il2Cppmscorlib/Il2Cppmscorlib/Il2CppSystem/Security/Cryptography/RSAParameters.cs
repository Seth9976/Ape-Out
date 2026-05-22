using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002FE RID: 766
	[Serializable]
	public sealed class RSAParameters : ValueType
	{
		// Token: 0x060032F9 RID: 13049 RVA: 0x000FE298 File Offset: 0x000FC498
		// Note: this type is marked as 'beforefieldinit'.
		static RSAParameters()
		{
			Il2CppClassPointerStore<RSAParameters>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "RSAParameters");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RSAParameters>.NativeClassPtr);
			RSAParameters.NativeFieldInfoPtr_Exponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSAParameters>.NativeClassPtr, "Exponent");
			RSAParameters.NativeFieldInfoPtr_Modulus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSAParameters>.NativeClassPtr, "Modulus");
			RSAParameters.NativeFieldInfoPtr_P = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSAParameters>.NativeClassPtr, "P");
			RSAParameters.NativeFieldInfoPtr_Q = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSAParameters>.NativeClassPtr, "Q");
			RSAParameters.NativeFieldInfoPtr_DP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSAParameters>.NativeClassPtr, "DP");
			RSAParameters.NativeFieldInfoPtr_DQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSAParameters>.NativeClassPtr, "DQ");
			RSAParameters.NativeFieldInfoPtr_InverseQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSAParameters>.NativeClassPtr, "InverseQ");
			RSAParameters.NativeFieldInfoPtr_D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSAParameters>.NativeClassPtr, "D");
		}

		// Token: 0x060032FA RID: 13050 RVA: 0x00011E4F File Offset: 0x0001004F
		public RSAParameters(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060032FB RID: 13051 RVA: 0x00011E58 File Offset: 0x00010058
		public RSAParameters()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RSAParameters>.NativeClassPtr))
		{
		}

		// Token: 0x17000C3F RID: 3135
		// (get) Token: 0x060032FC RID: 13052 RVA: 0x000FE368 File Offset: 0x000FC568
		// (set) Token: 0x060032FD RID: 13053 RVA: 0x00011E6A File Offset: 0x0001006A
		public unsafe Il2CppStructArray<byte> Exponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAParameters.NativeFieldInfoPtr_Exponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAParameters.NativeFieldInfoPtr_Exponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C40 RID: 3136
		// (get) Token: 0x060032FE RID: 13054 RVA: 0x000FE398 File Offset: 0x000FC598
		// (set) Token: 0x060032FF RID: 13055 RVA: 0x00011E89 File Offset: 0x00010089
		public unsafe Il2CppStructArray<byte> Modulus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAParameters.NativeFieldInfoPtr_Modulus);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAParameters.NativeFieldInfoPtr_Modulus), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C41 RID: 3137
		// (get) Token: 0x06003300 RID: 13056 RVA: 0x000FE3C8 File Offset: 0x000FC5C8
		// (set) Token: 0x06003301 RID: 13057 RVA: 0x00011EA8 File Offset: 0x000100A8
		public unsafe Il2CppStructArray<byte> P
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAParameters.NativeFieldInfoPtr_P);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAParameters.NativeFieldInfoPtr_P), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C42 RID: 3138
		// (get) Token: 0x06003302 RID: 13058 RVA: 0x000FE3F8 File Offset: 0x000FC5F8
		// (set) Token: 0x06003303 RID: 13059 RVA: 0x00011EC7 File Offset: 0x000100C7
		public unsafe Il2CppStructArray<byte> Q
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAParameters.NativeFieldInfoPtr_Q);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAParameters.NativeFieldInfoPtr_Q), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C43 RID: 3139
		// (get) Token: 0x06003304 RID: 13060 RVA: 0x000FE428 File Offset: 0x000FC628
		// (set) Token: 0x06003305 RID: 13061 RVA: 0x00011EE6 File Offset: 0x000100E6
		public unsafe Il2CppStructArray<byte> DP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAParameters.NativeFieldInfoPtr_DP);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAParameters.NativeFieldInfoPtr_DP), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C44 RID: 3140
		// (get) Token: 0x06003306 RID: 13062 RVA: 0x000FE458 File Offset: 0x000FC658
		// (set) Token: 0x06003307 RID: 13063 RVA: 0x00011F05 File Offset: 0x00010105
		public unsafe Il2CppStructArray<byte> DQ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAParameters.NativeFieldInfoPtr_DQ);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAParameters.NativeFieldInfoPtr_DQ), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C45 RID: 3141
		// (get) Token: 0x06003308 RID: 13064 RVA: 0x000FE488 File Offset: 0x000FC688
		// (set) Token: 0x06003309 RID: 13065 RVA: 0x00011F24 File Offset: 0x00010124
		public unsafe Il2CppStructArray<byte> InverseQ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAParameters.NativeFieldInfoPtr_InverseQ);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAParameters.NativeFieldInfoPtr_InverseQ), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C46 RID: 3142
		// (get) Token: 0x0600330A RID: 13066 RVA: 0x000FE4B8 File Offset: 0x000FC6B8
		// (set) Token: 0x0600330B RID: 13067 RVA: 0x00011F43 File Offset: 0x00010143
		public unsafe Il2CppStructArray<byte> D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAParameters.NativeFieldInfoPtr_D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAParameters.NativeFieldInfoPtr_D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002B88 RID: 11144
		private static readonly IntPtr NativeFieldInfoPtr_Exponent;

		// Token: 0x04002B89 RID: 11145
		private static readonly IntPtr NativeFieldInfoPtr_Modulus;

		// Token: 0x04002B8A RID: 11146
		private static readonly IntPtr NativeFieldInfoPtr_P;

		// Token: 0x04002B8B RID: 11147
		private static readonly IntPtr NativeFieldInfoPtr_Q;

		// Token: 0x04002B8C RID: 11148
		private static readonly IntPtr NativeFieldInfoPtr_DP;

		// Token: 0x04002B8D RID: 11149
		private static readonly IntPtr NativeFieldInfoPtr_DQ;

		// Token: 0x04002B8E RID: 11150
		private static readonly IntPtr NativeFieldInfoPtr_InverseQ;

		// Token: 0x04002B8F RID: 11151
		private static readonly IntPtr NativeFieldInfoPtr_D;
	}
}
