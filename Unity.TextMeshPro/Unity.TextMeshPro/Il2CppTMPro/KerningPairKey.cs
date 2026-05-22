using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppTMPro
{
	// Token: 0x0200001F RID: 31
	[StructLayout(2)]
	public struct KerningPairKey
	{
		// Token: 0x06000307 RID: 775 RVA: 0x00013D2C File Offset: 0x00011F2C
		// Note: this type is marked as 'beforefieldinit'.
		static KerningPairKey()
		{
			Il2CppClassPointerStore<KerningPairKey>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "KerningPairKey");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KerningPairKey>.NativeClassPtr);
			KerningPairKey.NativeFieldInfoPtr_ascii_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningPairKey>.NativeClassPtr, "ascii_Left");
			KerningPairKey.NativeFieldInfoPtr_ascii_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningPairKey>.NativeClassPtr, "ascii_Right");
			KerningPairKey.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningPairKey>.NativeClassPtr, "key");
			KerningPairKey.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningPairKey>.NativeClassPtr, 100663625);
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00013DAC File Offset: 0x00011FAC
		[CallerCount(0)]
		public unsafe KerningPairKey(uint ascii_left, uint ascii_right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ascii_left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ascii_right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningPairKey.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000309 RID: 777 RVA: 0x0000393D File Offset: 0x00001B3D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KerningPairKey>.NativeClassPtr, ref this));
		}

		// Token: 0x0400020F RID: 527
		private static readonly IntPtr NativeFieldInfoPtr_ascii_Left;

		// Token: 0x04000210 RID: 528
		private static readonly IntPtr NativeFieldInfoPtr_ascii_Right;

		// Token: 0x04000211 RID: 529
		private static readonly IntPtr NativeFieldInfoPtr_key;

		// Token: 0x04000212 RID: 530
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_0;

		// Token: 0x04000213 RID: 531
		[FieldOffset(0)]
		public uint ascii_Left;

		// Token: 0x04000214 RID: 532
		[FieldOffset(4)]
		public uint ascii_Right;

		// Token: 0x04000215 RID: 533
		[FieldOffset(8)]
		public uint key;
	}
}
