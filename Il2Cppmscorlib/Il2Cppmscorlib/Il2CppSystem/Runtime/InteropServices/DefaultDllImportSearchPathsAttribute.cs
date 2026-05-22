using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x0200044D RID: 1101
	public sealed class DefaultDllImportSearchPathsAttribute : Attribute
	{
		// Token: 0x060043D9 RID: 17369 RVA: 0x0013958C File Offset: 0x0013778C
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultDllImportSearchPathsAttribute()
		{
			Il2CppClassPointerStore<DefaultDllImportSearchPathsAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "DefaultDllImportSearchPathsAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultDllImportSearchPathsAttribute>.NativeClassPtr);
			DefaultDllImportSearchPathsAttribute.NativeFieldInfoPtr__paths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultDllImportSearchPathsAttribute>.NativeClassPtr, "_paths");
			DefaultDllImportSearchPathsAttribute.NativeMethodInfoPtr__ctor_Public_Void_DllImportSearchPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultDllImportSearchPathsAttribute>.NativeClassPtr, 100673182);
		}

		// Token: 0x060043DA RID: 17370 RVA: 0x001395E4 File Offset: 0x001377E4
		[CallerCount(0)]
		public unsafe DefaultDllImportSearchPathsAttribute(DllImportSearchPath paths)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultDllImportSearchPathsAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref paths;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultDllImportSearchPathsAttribute.NativeMethodInfoPtr__ctor_Public_Void_DllImportSearchPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060043DB RID: 17371 RVA: 0x00019DA1 File Offset: 0x00017FA1
		public DefaultDllImportSearchPathsAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001154 RID: 4436
		// (get) Token: 0x060043DC RID: 17372 RVA: 0x0013962C File Offset: 0x0013782C
		// (set) Token: 0x060043DD RID: 17373 RVA: 0x00019DAA File Offset: 0x00017FAA
		public unsafe DllImportSearchPath _paths
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultDllImportSearchPathsAttribute.NativeFieldInfoPtr__paths);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultDllImportSearchPathsAttribute.NativeFieldInfoPtr__paths)) = value;
			}
		}

		// Token: 0x0400375E RID: 14174
		private static readonly IntPtr NativeFieldInfoPtr__paths;

		// Token: 0x0400375F RID: 14175
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DllImportSearchPath_0;
	}
}
