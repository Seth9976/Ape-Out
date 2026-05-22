using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Timeline
{
	// Token: 0x0200003C RID: 60
	public class NotKeyableAttribute : Attribute
	{
		// Token: 0x06000493 RID: 1171 RVA: 0x0000373F File Offset: 0x0000193F
		// Note: this type is marked as 'beforefieldinit'.
		static NotKeyableAttribute()
		{
			Il2CppClassPointerStore<NotKeyableAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "NotKeyableAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotKeyableAttribute>.NativeClassPtr);
			NotKeyableAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotKeyableAttribute>.NativeClassPtr, 100664065);
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00016974 File Offset: 0x00014B74
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NotKeyableAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotKeyableAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotKeyableAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00003778 File Offset: 0x00001978
		public NotKeyableAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000391 RID: 913
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
