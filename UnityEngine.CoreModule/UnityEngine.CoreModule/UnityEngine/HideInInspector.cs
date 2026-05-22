using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000CA RID: 202
	public sealed class HideInInspector : Attribute
	{
		// Token: 0x06001257 RID: 4695 RVA: 0x0000A996 File Offset: 0x00008B96
		// Note: this type is marked as 'beforefieldinit'.
		static HideInInspector()
		{
			Il2CppClassPointerStore<HideInInspector>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "HideInInspector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HideInInspector>.NativeClassPtr);
			HideInInspector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideInInspector>.NativeClassPtr, 100664830);
		}

		// Token: 0x06001258 RID: 4696 RVA: 0x0004ACDC File Offset: 0x00048EDC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HideInInspector()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HideInInspector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HideInInspector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001259 RID: 4697 RVA: 0x0000A9CF File Offset: 0x00008BCF
		public HideInInspector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000EBC RID: 3772
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
