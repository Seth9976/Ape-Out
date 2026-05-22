using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x0200009B RID: 155
	public sealed class SRCategoryAttribute : CategoryAttribute
	{
		// Token: 0x06000925 RID: 2341 RVA: 0x00005B26 File Offset: 0x00003D26
		// Note: this type is marked as 'beforefieldinit'.
		static SRCategoryAttribute()
		{
			Il2CppClassPointerStore<SRCategoryAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "SRCategoryAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SRCategoryAttribute>.NativeClassPtr);
			SRCategoryAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SRCategoryAttribute>.NativeClassPtr, 100664589);
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x00032760 File Offset: 0x00030960
		[CallerCount(0)]
		public unsafe SRCategoryAttribute(string category)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SRCategoryAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(category);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SRCategoryAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x00005B5F File Offset: 0x00003D5F
		public SRCategoryAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000699 RID: 1689
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
