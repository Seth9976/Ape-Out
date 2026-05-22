using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x020000F0 RID: 240
	[Serializable]
	public class ThreadStaticAttribute : Attribute
	{
		// Token: 0x060010F9 RID: 4345 RVA: 0x000061B0 File Offset: 0x000043B0
		// Note: this type is marked as 'beforefieldinit'.
		static ThreadStaticAttribute()
		{
			Il2CppClassPointerStore<ThreadStaticAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ThreadStaticAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThreadStaticAttribute>.NativeClassPtr);
			ThreadStaticAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadStaticAttribute>.NativeClassPtr, 100666237);
		}

		// Token: 0x060010FA RID: 4346 RVA: 0x00072814 File Offset: 0x00070A14
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThreadStaticAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreadStaticAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadStaticAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010FB RID: 4347 RVA: 0x000061E9 File Offset: 0x000043E9
		public ThreadStaticAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E70 RID: 3696
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
