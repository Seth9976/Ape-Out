using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.ConstrainedExecution
{
	// Token: 0x0200040F RID: 1039
	public class CriticalFinalizerObject : Object
	{
		// Token: 0x0600427A RID: 17018 RVA: 0x0013508C File Offset: 0x0013328C
		// Note: this type is marked as 'beforefieldinit'.
		static CriticalFinalizerObject()
		{
			Il2CppClassPointerStore<CriticalFinalizerObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.ConstrainedExecution", "CriticalFinalizerObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CriticalFinalizerObject>.NativeClassPtr);
			CriticalFinalizerObject.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CriticalFinalizerObject>.NativeClassPtr, 100673026);
			CriticalFinalizerObject.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CriticalFinalizerObject>.NativeClassPtr, 100673027);
		}

		// Token: 0x0600427B RID: 17019 RVA: 0x001350E4 File Offset: 0x001332E4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CriticalFinalizerObject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CriticalFinalizerObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CriticalFinalizerObject.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600427C RID: 17020 RVA: 0x00135120 File Offset: 0x00133320
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 33858, RefRangeEnd = 33864, XrefRangeStart = 33858, XrefRangeEnd = 33864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CriticalFinalizerObject.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600427D RID: 17021 RVA: 0x00019180 File Offset: 0x00017380
		public CriticalFinalizerObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003635 RID: 13877
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04003636 RID: 13878
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;
	}
}
