using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Bindings
{
	// Token: 0x02000016 RID: 22
	public class ThreadSafeAttribute : NativeMethodAttribute
	{
		// Token: 0x06000097 RID: 151 RVA: 0x00002579 File Offset: 0x00000779
		// Note: this type is marked as 'beforefieldinit'.
		static ThreadSafeAttribute()
		{
			Il2CppClassPointerStore<ThreadSafeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SharedInternalsModule.dll", "UnityEngine.Bindings", "ThreadSafeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThreadSafeAttribute>.NativeClassPtr);
			ThreadSafeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadSafeAttribute>.NativeClassPtr, 100663346);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00004000 File Offset: 0x00002200
		[CallerCount(0)]
		public unsafe ThreadSafeAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreadSafeAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadSafeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000025B2 File Offset: 0x000007B2
		public ThreadSafeAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
