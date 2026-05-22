using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem
{
	// Token: 0x0200012E RID: 302
	public class ResolveEventArgs : EventArgs
	{
		// Token: 0x060015DC RID: 5596 RVA: 0x00087BF8 File Offset: 0x00085DF8
		// Note: this type is marked as 'beforefieldinit'.
		static ResolveEventArgs()
		{
			Il2CppClassPointerStore<ResolveEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ResolveEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResolveEventArgs>.NativeClassPtr);
			ResolveEventArgs.NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveEventArgs>.NativeClassPtr, "m_Name");
			ResolveEventArgs.NativeFieldInfoPtr_m_Requesting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveEventArgs>.NativeClassPtr, "m_Requesting");
			ResolveEventArgs.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveEventArgs>.NativeClassPtr, 100667068);
			ResolveEventArgs.NativeMethodInfoPtr__ctor_Public_Void_String_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveEventArgs>.NativeClassPtr, 100667069);
		}

		// Token: 0x060015DD RID: 5597 RVA: 0x00087C78 File Offset: 0x00085E78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177314, XrefRangeEnd = 177317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResolveEventArgs(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResolveEventArgs>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveEventArgs.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015DE RID: 5598 RVA: 0x00087CC4 File Offset: 0x00085EC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 177320, RefRangeEnd = 177322, XrefRangeStart = 177317, XrefRangeEnd = 177320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResolveEventArgs(string name, Assembly requestingAssembly)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResolveEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(requestingAssembly);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveEventArgs.NativeMethodInfoPtr__ctor_Public_Void_String_Assembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015DF RID: 5599 RVA: 0x00007729 File Offset: 0x00005929
		public ResolveEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x060015E0 RID: 5600 RVA: 0x00087D24 File Offset: 0x00085F24
		// (set) Token: 0x060015E1 RID: 5601 RVA: 0x00007732 File Offset: 0x00005932
		public unsafe string m_Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveEventArgs.NativeFieldInfoPtr_m_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveEventArgs.NativeFieldInfoPtr_m_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x060015E2 RID: 5602 RVA: 0x00087D4C File Offset: 0x00085F4C
		// (set) Token: 0x060015E3 RID: 5603 RVA: 0x00007751 File Offset: 0x00005951
		public unsafe Assembly m_Requesting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveEventArgs.NativeFieldInfoPtr_m_Requesting);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveEventArgs.NativeFieldInfoPtr_m_Requesting), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400129D RID: 4765
		private static readonly IntPtr NativeFieldInfoPtr_m_Name;

		// Token: 0x0400129E RID: 4766
		private static readonly IntPtr NativeFieldInfoPtr_m_Requesting;

		// Token: 0x0400129F RID: 4767
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040012A0 RID: 4768
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Assembly_0;
	}
}
