using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection.Emit
{
	// Token: 0x0200052C RID: 1324
	[Serializable]
	public sealed class UnmanagedMarshal : Object
	{
		// Token: 0x06004ECF RID: 20175 RVA: 0x0001D7AE File Offset: 0x0001B9AE
		// Note: this type is marked as 'beforefieldinit'.
		static UnmanagedMarshal()
		{
			Il2CppClassPointerStore<UnmanagedMarshal>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection.Emit", "UnmanagedMarshal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnmanagedMarshal>.NativeClassPtr);
			UnmanagedMarshal.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMarshal>.NativeClassPtr, 100674886);
		}

		// Token: 0x06004ED0 RID: 20176 RVA: 0x00166F30 File Offset: 0x00165130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242858, XrefRangeEnd = 242861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnmanagedMarshal()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnmanagedMarshal>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnmanagedMarshal.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004ED1 RID: 20177 RVA: 0x0001D7E7 File Offset: 0x0001B9E7
		public UnmanagedMarshal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003F6A RID: 16234
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
