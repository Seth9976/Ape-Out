using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x02000435 RID: 1077
	public sealed class TypeDependencyAttribute : Attribute
	{
		// Token: 0x06004366 RID: 17254 RVA: 0x00138108 File Offset: 0x00136308
		// Note: this type is marked as 'beforefieldinit'.
		static TypeDependencyAttribute()
		{
			Il2CppClassPointerStore<TypeDependencyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "TypeDependencyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeDependencyAttribute>.NativeClassPtr);
			TypeDependencyAttribute.NativeFieldInfoPtr_typeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeDependencyAttribute>.NativeClassPtr, "typeName");
			TypeDependencyAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDependencyAttribute>.NativeClassPtr, 100673144);
		}

		// Token: 0x06004367 RID: 17255 RVA: 0x00138160 File Offset: 0x00136360
		[CallerCount(0)]
		public unsafe TypeDependencyAttribute(string typeName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeDependencyAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDependencyAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004368 RID: 17256 RVA: 0x00019936 File Offset: 0x00017B36
		public TypeDependencyAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700113D RID: 4413
		// (get) Token: 0x06004369 RID: 17257 RVA: 0x001381AC File Offset: 0x001363AC
		// (set) Token: 0x0600436A RID: 17258 RVA: 0x0001993F File Offset: 0x00017B3F
		public unsafe string typeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeDependencyAttribute.NativeFieldInfoPtr_typeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeDependencyAttribute.NativeFieldInfoPtr_typeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040036C2 RID: 14018
		private static readonly IntPtr NativeFieldInfoPtr_typeName;

		// Token: 0x040036C3 RID: 14019
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
