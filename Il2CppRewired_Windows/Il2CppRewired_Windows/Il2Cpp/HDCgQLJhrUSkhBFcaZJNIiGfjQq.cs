using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2Cpp
{
	// Token: 0x02000041 RID: 65
	public sealed class HDCgQLJhrUSkhBFcaZJNIiGfjQq : Attribute
	{
		// Token: 0x06000715 RID: 1813 RVA: 0x00024A94 File Offset: 0x00022C94
		// Note: this type is marked as 'beforefieldinit'.
		static HDCgQLJhrUSkhBFcaZJNIiGfjQq()
		{
			Il2CppClassPointerStore<HDCgQLJhrUSkhBFcaZJNIiGfjQq>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Windows.dll", "", "HDCgQLJhrUSkhBFcaZJNIiGfjQq");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HDCgQLJhrUSkhBFcaZJNIiGfjQq>.NativeClassPtr);
			HDCgQLJhrUSkhBFcaZJNIiGfjQq.NativeFieldInfoPtr_qbgjKHFvGPUDrwqgjYtEzKHHBDi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDCgQLJhrUSkhBFcaZJNIiGfjQq>.NativeClassPtr, "qbgjKHFvGPUDrwqgjYtEzKHHBDi");
			HDCgQLJhrUSkhBFcaZJNIiGfjQq.NativeMethodInfoPtr__ctor_Public_Void_PjgTGhAZWmBlKOcMVGzmNgaSARr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDCgQLJhrUSkhBFcaZJNIiGfjQq>.NativeClassPtr, 100664621);
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x00024AEC File Offset: 0x00022CEC
		[CallerCount(0)]
		public unsafe HDCgQLJhrUSkhBFcaZJNIiGfjQq(PjgTGhAZWmBlKOcMVGzmNgaSARr flags)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HDCgQLJhrUSkhBFcaZJNIiGfjQq>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDCgQLJhrUSkhBFcaZJNIiGfjQq.NativeMethodInfoPtr__ctor_Public_Void_PjgTGhAZWmBlKOcMVGzmNgaSARr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x000051A7 File Offset: 0x000033A7
		public HDCgQLJhrUSkhBFcaZJNIiGfjQq(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000718 RID: 1816 RVA: 0x00024B34 File Offset: 0x00022D34
		// (set) Token: 0x06000719 RID: 1817 RVA: 0x000051B0 File Offset: 0x000033B0
		public unsafe PjgTGhAZWmBlKOcMVGzmNgaSARr qbgjKHFvGPUDrwqgjYtEzKHHBDi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HDCgQLJhrUSkhBFcaZJNIiGfjQq.NativeFieldInfoPtr_qbgjKHFvGPUDrwqgjYtEzKHHBDi);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HDCgQLJhrUSkhBFcaZJNIiGfjQq.NativeFieldInfoPtr_qbgjKHFvGPUDrwqgjYtEzKHHBDi)) = value;
			}
		}

		// Token: 0x040005D2 RID: 1490
		private static readonly IntPtr NativeFieldInfoPtr_qbgjKHFvGPUDrwqgjYtEzKHHBDi;

		// Token: 0x040005D3 RID: 1491
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PjgTGhAZWmBlKOcMVGzmNgaSARr_0;
	}
}
