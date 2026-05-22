using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x0200042E RID: 1070
	[Serializable]
	public sealed class DecimalConstantAttribute : Attribute
	{
		// Token: 0x06004342 RID: 17218 RVA: 0x00137B48 File Offset: 0x00135D48
		// Note: this type is marked as 'beforefieldinit'.
		static DecimalConstantAttribute()
		{
			Il2CppClassPointerStore<DecimalConstantAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "DecimalConstantAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecimalConstantAttribute>.NativeClassPtr);
			DecimalConstantAttribute.NativeFieldInfoPtr_dec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecimalConstantAttribute>.NativeClassPtr, "dec");
			DecimalConstantAttribute.NativeMethodInfoPtr__ctor_Public_Void_Byte_Byte_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecimalConstantAttribute>.NativeClassPtr, 100673132);
			DecimalConstantAttribute.NativeMethodInfoPtr_get_Value_Public_get_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecimalConstantAttribute>.NativeClassPtr, 100673133);
		}

		// Token: 0x06004343 RID: 17219 RVA: 0x00137BB4 File Offset: 0x00135DB4
		[CallerCount(0)]
		public unsafe DecimalConstantAttribute(byte scale, byte sign, uint hi, uint mid, uint low)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecimalConstantAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scale;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sign;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hi;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mid;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref low;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecimalConstantAttribute.NativeMethodInfoPtr__ctor_Public_Void_Byte_Byte_UInt32_UInt32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001134 RID: 4404
		// (get) Token: 0x06004344 RID: 17220 RVA: 0x00137C34 File Offset: 0x00135E34
		public unsafe Decimal Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecimalConstantAttribute.NativeMethodInfoPtr_get_Value_Public_get_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004345 RID: 17221 RVA: 0x00019798 File Offset: 0x00017998
		public DecimalConstantAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001133 RID: 4403
		// (get) Token: 0x06004346 RID: 17222 RVA: 0x00137C70 File Offset: 0x00135E70
		// (set) Token: 0x06004347 RID: 17223 RVA: 0x000197A1 File Offset: 0x000179A1
		public unsafe Decimal dec
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecimalConstantAttribute.NativeFieldInfoPtr_dec);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecimalConstantAttribute.NativeFieldInfoPtr_dec)) = value;
			}
		}

		// Token: 0x040036B1 RID: 14001
		private static readonly IntPtr NativeFieldInfoPtr_dec;

		// Token: 0x040036B2 RID: 14002
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_Byte_UInt32_UInt32_UInt32_0;

		// Token: 0x040036B3 RID: 14003
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Decimal_0;
	}
}
