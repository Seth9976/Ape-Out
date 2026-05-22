using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem
{
	// Token: 0x0200010E RID: 270
	public class AssemblyLoadEventArgs : EventArgs
	{
		// Token: 0x06001416 RID: 5142 RVA: 0x000808A4 File Offset: 0x0007EAA4
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyLoadEventArgs()
		{
			Il2CppClassPointerStore<AssemblyLoadEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "AssemblyLoadEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyLoadEventArgs>.NativeClassPtr);
			AssemblyLoadEventArgs.NativeFieldInfoPtr_m_loadedAssembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyLoadEventArgs>.NativeClassPtr, "m_loadedAssembly");
			AssemblyLoadEventArgs.NativeMethodInfoPtr__ctor_Public_Void_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyLoadEventArgs>.NativeClassPtr, 100666796);
		}

		// Token: 0x06001417 RID: 5143 RVA: 0x000808FC File Offset: 0x0007EAFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174494, XrefRangeEnd = 174497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssemblyLoadEventArgs(Assembly loadedAssembly)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyLoadEventArgs>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(loadedAssembly);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyLoadEventArgs.NativeMethodInfoPtr__ctor_Public_Void_Assembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001418 RID: 5144 RVA: 0x00006E82 File Offset: 0x00005082
		public AssemblyLoadEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06001419 RID: 5145 RVA: 0x00080948 File Offset: 0x0007EB48
		// (set) Token: 0x0600141A RID: 5146 RVA: 0x00006E8B File Offset: 0x0000508B
		public unsafe Assembly m_loadedAssembly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyLoadEventArgs.NativeFieldInfoPtr_m_loadedAssembly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyLoadEventArgs.NativeFieldInfoPtr_m_loadedAssembly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400114F RID: 4431
		private static readonly IntPtr NativeFieldInfoPtr_m_loadedAssembly;

		// Token: 0x04001150 RID: 4432
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Assembly_0;
	}
}
