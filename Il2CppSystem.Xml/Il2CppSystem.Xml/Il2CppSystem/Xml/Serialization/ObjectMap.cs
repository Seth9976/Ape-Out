using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000D4 RID: 212
	public class ObjectMap : Object
	{
		// Token: 0x06001253 RID: 4691 RVA: 0x000082D2 File Offset: 0x000064D2
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectMap()
		{
			Il2CppClassPointerStore<ObjectMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "ObjectMap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectMap>.NativeClassPtr);
			ObjectMap.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectMap>.NativeClassPtr, 100666163);
		}

		// Token: 0x06001254 RID: 4692 RVA: 0x00062774 File Offset: 0x00060974
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectMap()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectMap>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectMap.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001255 RID: 4693 RVA: 0x0000830B File Offset: 0x0000650B
		public ObjectMap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E4B RID: 3659
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
