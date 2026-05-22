using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x0200043D RID: 1085
	public sealed class DispIdAttribute : Attribute
	{
		// Token: 0x060043AB RID: 17323 RVA: 0x00138F54 File Offset: 0x00137154
		// Note: this type is marked as 'beforefieldinit'.
		static DispIdAttribute()
		{
			Il2CppClassPointerStore<DispIdAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "DispIdAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DispIdAttribute>.NativeClassPtr);
			DispIdAttribute.NativeFieldInfoPtr__val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DispIdAttribute>.NativeClassPtr, "_val");
			DispIdAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispIdAttribute>.NativeClassPtr, 100673170);
		}

		// Token: 0x060043AC RID: 17324 RVA: 0x00138FAC File Offset: 0x001371AC
		[CallerCount(0)]
		public unsafe DispIdAttribute(int dispId)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DispIdAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dispId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DispIdAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060043AD RID: 17325 RVA: 0x00019B77 File Offset: 0x00017D77
		public DispIdAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700114D RID: 4429
		// (get) Token: 0x060043AE RID: 17326 RVA: 0x00138FF4 File Offset: 0x001371F4
		// (set) Token: 0x060043AF RID: 17327 RVA: 0x00019B80 File Offset: 0x00017D80
		public unsafe int _val
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DispIdAttribute.NativeFieldInfoPtr__val);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DispIdAttribute.NativeFieldInfoPtr__val)) = value;
			}
		}

		// Token: 0x040036E7 RID: 14055
		private static readonly IntPtr NativeFieldInfoPtr__val;

		// Token: 0x040036E8 RID: 14056
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
	}
}
