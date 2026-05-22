using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.ExceptionServices
{
	// Token: 0x0200040C RID: 1036
	public sealed class HandleProcessCorruptedStateExceptionsAttribute : Attribute
	{
		// Token: 0x0600426A RID: 17002 RVA: 0x000190C9 File Offset: 0x000172C9
		// Note: this type is marked as 'beforefieldinit'.
		static HandleProcessCorruptedStateExceptionsAttribute()
		{
			Il2CppClassPointerStore<HandleProcessCorruptedStateExceptionsAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.ExceptionServices", "HandleProcessCorruptedStateExceptionsAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandleProcessCorruptedStateExceptionsAttribute>.NativeClassPtr);
			HandleProcessCorruptedStateExceptionsAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleProcessCorruptedStateExceptionsAttribute>.NativeClassPtr, 100673020);
		}

		// Token: 0x0600426B RID: 17003 RVA: 0x00134DF0 File Offset: 0x00132FF0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HandleProcessCorruptedStateExceptionsAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HandleProcessCorruptedStateExceptionsAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandleProcessCorruptedStateExceptionsAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600426C RID: 17004 RVA: 0x00019102 File Offset: 0x00017302
		public HandleProcessCorruptedStateExceptionsAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400362D RID: 13869
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
