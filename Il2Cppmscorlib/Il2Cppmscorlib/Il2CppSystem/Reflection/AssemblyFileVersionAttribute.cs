using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000198 RID: 408
	public sealed class AssemblyFileVersionAttribute : Attribute
	{
		// Token: 0x06001BE1 RID: 7137 RVA: 0x000A20E0 File Offset: 0x000A02E0
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyFileVersionAttribute()
		{
			Il2CppClassPointerStore<AssemblyFileVersionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "AssemblyFileVersionAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyFileVersionAttribute>.NativeClassPtr);
			AssemblyFileVersionAttribute.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyFileVersionAttribute>.NativeClassPtr, "_version");
			AssemblyFileVersionAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyFileVersionAttribute>.NativeClassPtr, 100668029);
		}

		// Token: 0x06001BE2 RID: 7138 RVA: 0x000A2138 File Offset: 0x000A0338
		[CallerCount(0)]
		public unsafe AssemblyFileVersionAttribute(string version)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyFileVersionAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(version);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyFileVersionAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BE3 RID: 7139 RVA: 0x000097C1 File Offset: 0x000079C1
		public AssemblyFileVersionAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06001BE4 RID: 7140 RVA: 0x000A2184 File Offset: 0x000A0384
		// (set) Token: 0x06001BE5 RID: 7141 RVA: 0x000097CA File Offset: 0x000079CA
		public unsafe string _version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyFileVersionAttribute.NativeFieldInfoPtr__version);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyFileVersionAttribute.NativeFieldInfoPtr__version), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400192F RID: 6447
		private static readonly IntPtr NativeFieldInfoPtr__version;

		// Token: 0x04001930 RID: 6448
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
