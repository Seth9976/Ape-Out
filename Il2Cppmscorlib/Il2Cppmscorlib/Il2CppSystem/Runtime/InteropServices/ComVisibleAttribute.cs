using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x02000443 RID: 1091
	public sealed class ComVisibleAttribute : Attribute
	{
		// Token: 0x060043BF RID: 17343 RVA: 0x00139280 File Offset: 0x00137480
		// Note: this type is marked as 'beforefieldinit'.
		static ComVisibleAttribute()
		{
			Il2CppClassPointerStore<ComVisibleAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "ComVisibleAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComVisibleAttribute>.NativeClassPtr);
			ComVisibleAttribute.NativeFieldInfoPtr__val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComVisibleAttribute>.NativeClassPtr, "_val");
			ComVisibleAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComVisibleAttribute>.NativeClassPtr, 100673174);
		}

		// Token: 0x060043C0 RID: 17344 RVA: 0x001392D8 File Offset: 0x001374D8
		[CallerCount(0)]
		public unsafe ComVisibleAttribute(bool visibility)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComVisibleAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref visibility;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComVisibleAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060043C1 RID: 17345 RVA: 0x00019C0B File Offset: 0x00017E0B
		public ComVisibleAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001151 RID: 4433
		// (get) Token: 0x060043C2 RID: 17346 RVA: 0x00139320 File Offset: 0x00137520
		// (set) Token: 0x060043C3 RID: 17347 RVA: 0x00019C14 File Offset: 0x00017E14
		public unsafe bool _val
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComVisibleAttribute.NativeFieldInfoPtr__val);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComVisibleAttribute.NativeFieldInfoPtr__val)) = value;
			}
		}

		// Token: 0x040036F8 RID: 14072
		private static readonly IntPtr NativeFieldInfoPtr__val;

		// Token: 0x040036F9 RID: 14073
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;
	}
}
