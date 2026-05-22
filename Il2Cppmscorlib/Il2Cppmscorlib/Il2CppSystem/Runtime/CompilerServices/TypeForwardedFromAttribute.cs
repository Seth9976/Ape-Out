using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x02000426 RID: 1062
	public sealed class TypeForwardedFromAttribute : Attribute
	{
		// Token: 0x06004324 RID: 17188 RVA: 0x00137618 File Offset: 0x00135818
		// Note: this type is marked as 'beforefieldinit'.
		static TypeForwardedFromAttribute()
		{
			Il2CppClassPointerStore<TypeForwardedFromAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "TypeForwardedFromAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeForwardedFromAttribute>.NativeClassPtr);
			TypeForwardedFromAttribute.NativeFieldInfoPtr_assemblyFullName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeForwardedFromAttribute>.NativeClassPtr, "assemblyFullName");
			TypeForwardedFromAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeForwardedFromAttribute>.NativeClassPtr, 100673122);
			TypeForwardedFromAttribute.NativeMethodInfoPtr_get_AssemblyFullName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeForwardedFromAttribute>.NativeClassPtr, 100673123);
		}

		// Token: 0x06004325 RID: 17189 RVA: 0x00137684 File Offset: 0x00135884
		[CallerCount(0)]
		public unsafe TypeForwardedFromAttribute(string assemblyFullName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeForwardedFromAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyFullName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeForwardedFromAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700112C RID: 4396
		// (get) Token: 0x06004326 RID: 17190 RVA: 0x001376D0 File Offset: 0x001358D0
		public unsafe string AssemblyFullName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeForwardedFromAttribute.NativeMethodInfoPtr_get_AssemblyFullName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06004327 RID: 17191 RVA: 0x000196B9 File Offset: 0x000178B9
		public TypeForwardedFromAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700112B RID: 4395
		// (get) Token: 0x06004328 RID: 17192 RVA: 0x00137708 File Offset: 0x00135908
		// (set) Token: 0x06004329 RID: 17193 RVA: 0x000196C2 File Offset: 0x000178C2
		public unsafe string assemblyFullName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeForwardedFromAttribute.NativeFieldInfoPtr_assemblyFullName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeForwardedFromAttribute.NativeFieldInfoPtr_assemblyFullName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400369D RID: 13981
		private static readonly IntPtr NativeFieldInfoPtr_assemblyFullName;

		// Token: 0x0400369E RID: 13982
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400369F RID: 13983
		private static readonly IntPtr NativeMethodInfoPtr_get_AssemblyFullName_Public_get_String_0;
	}
}
