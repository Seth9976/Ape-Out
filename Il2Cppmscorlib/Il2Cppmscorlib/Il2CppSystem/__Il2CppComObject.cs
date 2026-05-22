using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200052F RID: 1327
	public class __Il2CppComObject : Object
	{
		// Token: 0x06004EE2 RID: 20194 RVA: 0x0001D831 File Offset: 0x0001BA31
		// Note: this type is marked as 'beforefieldinit'.
		static __Il2CppComObject()
		{
			Il2CppClassPointerStore<__Il2CppComObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "__Il2CppComObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__Il2CppComObject>.NativeClassPtr);
			__Il2CppComObject.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__Il2CppComObject>.NativeClassPtr, 100674899);
		}

		// Token: 0x06004EE3 RID: 20195 RVA: 0x001673EC File Offset: 0x001655EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242899, XrefRangeEnd = 242900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), __Il2CppComObject.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004EE4 RID: 20196 RVA: 0x0001D86A File Offset: 0x0001BA6A
		public __Il2CppComObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003F77 RID: 16247
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;
	}
}
