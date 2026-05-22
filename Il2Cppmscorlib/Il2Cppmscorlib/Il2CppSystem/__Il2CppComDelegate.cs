using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000530 RID: 1328
	public sealed class __Il2CppComDelegate : __Il2CppComObject
	{
		// Token: 0x06004EE5 RID: 20197 RVA: 0x0001D873 File Offset: 0x0001BA73
		// Note: this type is marked as 'beforefieldinit'.
		static __Il2CppComDelegate()
		{
			Il2CppClassPointerStore<__Il2CppComDelegate>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "__Il2CppComDelegate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__Il2CppComDelegate>.NativeClassPtr);
			__Il2CppComDelegate.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__Il2CppComDelegate>.NativeClassPtr, 100674900);
		}

		// Token: 0x06004EE6 RID: 20198 RVA: 0x00167428 File Offset: 0x00165628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__Il2CppComDelegate.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004EE7 RID: 20199 RVA: 0x0001D8AC File Offset: 0x0001BAAC
		public __Il2CppComDelegate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003F78 RID: 16248
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;
	}
}
