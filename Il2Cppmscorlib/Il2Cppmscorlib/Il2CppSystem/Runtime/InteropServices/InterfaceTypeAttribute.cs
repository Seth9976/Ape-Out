using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x0200043F RID: 1087
	public sealed class InterfaceTypeAttribute : Attribute
	{
		// Token: 0x060043B0 RID: 17328 RVA: 0x0013901C File Offset: 0x0013721C
		// Note: this type is marked as 'beforefieldinit'.
		static InterfaceTypeAttribute()
		{
			Il2CppClassPointerStore<InterfaceTypeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "InterfaceTypeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InterfaceTypeAttribute>.NativeClassPtr);
			InterfaceTypeAttribute.NativeFieldInfoPtr__val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceTypeAttribute>.NativeClassPtr, "_val");
			InterfaceTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_ComInterfaceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterfaceTypeAttribute>.NativeClassPtr, 100673171);
		}

		// Token: 0x060043B1 RID: 17329 RVA: 0x00139074 File Offset: 0x00137274
		[CallerCount(0)]
		public unsafe InterfaceTypeAttribute(ComInterfaceType interfaceType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InterfaceTypeAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref interfaceType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterfaceTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_ComInterfaceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060043B2 RID: 17330 RVA: 0x00019B9B File Offset: 0x00017D9B
		public InterfaceTypeAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700114E RID: 4430
		// (get) Token: 0x060043B3 RID: 17331 RVA: 0x001390BC File Offset: 0x001372BC
		// (set) Token: 0x060043B4 RID: 17332 RVA: 0x00019BA4 File Offset: 0x00017DA4
		public unsafe ComInterfaceType _val
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterfaceTypeAttribute.NativeFieldInfoPtr__val);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterfaceTypeAttribute.NativeFieldInfoPtr__val)) = value;
			}
		}

		// Token: 0x040036EE RID: 14062
		private static readonly IntPtr NativeFieldInfoPtr__val;

		// Token: 0x040036EF RID: 14063
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ComInterfaceType_0;
	}
}
