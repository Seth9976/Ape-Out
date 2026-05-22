using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x020000AE RID: 174
	public sealed class DTSubString : ValueType
	{
		// Token: 0x06000C9E RID: 3230 RVA: 0x0005D5E0 File Offset: 0x0005B7E0
		// Note: this type is marked as 'beforefieldinit'.
		static DTSubString()
		{
			Il2CppClassPointerStore<DTSubString>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "DTSubString");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DTSubString>.NativeClassPtr);
			DTSubString.NativeFieldInfoPtr_s = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DTSubString>.NativeClassPtr, "s");
			DTSubString.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DTSubString>.NativeClassPtr, "index");
			DTSubString.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DTSubString>.NativeClassPtr, "length");
			DTSubString.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DTSubString>.NativeClassPtr, "type");
			DTSubString.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DTSubString>.NativeClassPtr, "value");
			DTSubString.NativeMethodInfoPtr_get_Item_Internal_get_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DTSubString>.NativeClassPtr, 100665459);
		}

		// Token: 0x17000255 RID: 597
		public unsafe char this[int relativeIndex]
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref relativeIndex;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DTSubString.NativeMethodInfoPtr_get_Item_Internal_get_Char_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x0000528A File Offset: 0x0000348A
		public DTSubString(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x00005293 File Offset: 0x00003493
		public DTSubString()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DTSubString>.NativeClassPtr))
		{
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000CA2 RID: 3234 RVA: 0x0005D6D8 File Offset: 0x0005B8D8
		// (set) Token: 0x06000CA3 RID: 3235 RVA: 0x000052A5 File Offset: 0x000034A5
		public unsafe string s
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DTSubString.NativeFieldInfoPtr_s);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DTSubString.NativeFieldInfoPtr_s), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000CA4 RID: 3236 RVA: 0x0005D700 File Offset: 0x0005B900
		// (set) Token: 0x06000CA5 RID: 3237 RVA: 0x000052C4 File Offset: 0x000034C4
		public unsafe int index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DTSubString.NativeFieldInfoPtr_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DTSubString.NativeFieldInfoPtr_index)) = value;
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000CA6 RID: 3238 RVA: 0x0005D728 File Offset: 0x0005B928
		// (set) Token: 0x06000CA7 RID: 3239 RVA: 0x000052DF File Offset: 0x000034DF
		public unsafe int length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DTSubString.NativeFieldInfoPtr_length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DTSubString.NativeFieldInfoPtr_length)) = value;
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000CA8 RID: 3240 RVA: 0x0005D750 File Offset: 0x0005B950
		// (set) Token: 0x06000CA9 RID: 3241 RVA: 0x000052FA File Offset: 0x000034FA
		public unsafe DTSubStringType type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DTSubString.NativeFieldInfoPtr_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DTSubString.NativeFieldInfoPtr_type)) = value;
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000CAA RID: 3242 RVA: 0x0005D778 File Offset: 0x0005B978
		// (set) Token: 0x06000CAB RID: 3243 RVA: 0x00005315 File Offset: 0x00003515
		public unsafe int value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DTSubString.NativeFieldInfoPtr_value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DTSubString.NativeFieldInfoPtr_value)) = value;
			}
		}

		// Token: 0x04000A88 RID: 2696
		private static readonly IntPtr NativeFieldInfoPtr_s;

		// Token: 0x04000A89 RID: 2697
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x04000A8A RID: 2698
		private static readonly IntPtr NativeFieldInfoPtr_length;

		// Token: 0x04000A8B RID: 2699
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04000A8C RID: 2700
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04000A8D RID: 2701
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Internal_get_Char_Int32_0;
	}
}
