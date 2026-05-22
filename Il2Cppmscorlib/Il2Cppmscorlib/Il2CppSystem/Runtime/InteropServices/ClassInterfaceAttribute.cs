using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x02000442 RID: 1090
	public sealed class ClassInterfaceAttribute : Attribute
	{
		// Token: 0x060043BA RID: 17338 RVA: 0x001391B8 File Offset: 0x001373B8
		// Note: this type is marked as 'beforefieldinit'.
		static ClassInterfaceAttribute()
		{
			Il2CppClassPointerStore<ClassInterfaceAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "ClassInterfaceAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClassInterfaceAttribute>.NativeClassPtr);
			ClassInterfaceAttribute.NativeFieldInfoPtr__val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClassInterfaceAttribute>.NativeClassPtr, "_val");
			ClassInterfaceAttribute.NativeMethodInfoPtr__ctor_Public_Void_ClassInterfaceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassInterfaceAttribute>.NativeClassPtr, 100673173);
		}

		// Token: 0x060043BB RID: 17339 RVA: 0x00139210 File Offset: 0x00137410
		[CallerCount(0)]
		public unsafe ClassInterfaceAttribute(ClassInterfaceType classInterfaceType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClassInterfaceAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref classInterfaceType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClassInterfaceAttribute.NativeMethodInfoPtr__ctor_Public_Void_ClassInterfaceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060043BC RID: 17340 RVA: 0x00019BE7 File Offset: 0x00017DE7
		public ClassInterfaceAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001150 RID: 4432
		// (get) Token: 0x060043BD RID: 17341 RVA: 0x00139258 File Offset: 0x00137458
		// (set) Token: 0x060043BE RID: 17342 RVA: 0x00019BF0 File Offset: 0x00017DF0
		public unsafe ClassInterfaceType _val
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassInterfaceAttribute.NativeFieldInfoPtr__val);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassInterfaceAttribute.NativeFieldInfoPtr__val)) = value;
			}
		}

		// Token: 0x040036F6 RID: 14070
		private static readonly IntPtr NativeFieldInfoPtr__val;

		// Token: 0x040036F7 RID: 14071
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ClassInterfaceType_0;
	}
}
