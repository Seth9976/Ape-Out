using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000090 RID: 144
	[Serializable]
	public class ContextBoundObject : MarshalByRefObject
	{
		// Token: 0x060008B6 RID: 2230 RVA: 0x00004904 File Offset: 0x00002B04
		// Note: this type is marked as 'beforefieldinit'.
		static ContextBoundObject()
		{
			Il2CppClassPointerStore<ContextBoundObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ContextBoundObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContextBoundObject>.NativeClassPtr);
			ContextBoundObject.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextBoundObject>.NativeClassPtr, 100664702);
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x0004A890 File Offset: 0x00048A90
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContextBoundObject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContextBoundObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextBoundObject.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x0000493D File Offset: 0x00002B3D
		public ContextBoundObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000720 RID: 1824
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
