using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000154 RID: 340
	public class __ComObject : Object
	{
		// Token: 0x0600177B RID: 6011 RVA: 0x0000828B File Offset: 0x0000648B
		// Note: this type is marked as 'beforefieldinit'.
		static __ComObject()
		{
			Il2CppClassPointerStore<__ComObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "__ComObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__ComObject>.NativeClassPtr);
			__ComObject.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__ComObject>.NativeClassPtr, 100667282);
		}

		// Token: 0x0600177C RID: 6012 RVA: 0x0008DE90 File Offset: 0x0008C090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178947, XrefRangeEnd = 178952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __ComObject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__ComObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__ComObject.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600177D RID: 6013 RVA: 0x000082C4 File Offset: 0x000064C4
		public __ComObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040015D3 RID: 5587
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;
	}
}
