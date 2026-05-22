using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000088 RID: 136
	[Serializable]
	public sealed class CLSCompliantAttribute : Attribute
	{
		// Token: 0x06000897 RID: 2199 RVA: 0x0004A1CC File Offset: 0x000483CC
		// Note: this type is marked as 'beforefieldinit'.
		static CLSCompliantAttribute()
		{
			Il2CppClassPointerStore<CLSCompliantAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "CLSCompliantAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CLSCompliantAttribute>.NativeClassPtr);
			CLSCompliantAttribute.NativeFieldInfoPtr_m_compliant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CLSCompliantAttribute>.NativeClassPtr, "m_compliant");
			CLSCompliantAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CLSCompliantAttribute>.NativeClassPtr, 100664688);
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x0004A224 File Offset: 0x00048424
		[CallerCount(0)]
		public unsafe CLSCompliantAttribute(bool isCompliant)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CLSCompliantAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isCompliant;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CLSCompliantAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x0000485F File Offset: 0x00002A5F
		public CLSCompliantAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x0600089A RID: 2202 RVA: 0x0004A26C File Offset: 0x0004846C
		// (set) Token: 0x0600089B RID: 2203 RVA: 0x00004868 File Offset: 0x00002A68
		public unsafe bool m_compliant
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CLSCompliantAttribute.NativeFieldInfoPtr_m_compliant);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CLSCompliantAttribute.NativeFieldInfoPtr_m_compliant)) = value;
			}
		}

		// Token: 0x04000660 RID: 1632
		private static readonly IntPtr NativeFieldInfoPtr_m_compliant;

		// Token: 0x04000661 RID: 1633
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;
	}
}
