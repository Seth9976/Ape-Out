using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000C9 RID: 201
	public sealed class ExecuteAlways : Attribute
	{
		// Token: 0x06001254 RID: 4692 RVA: 0x0000A954 File Offset: 0x00008B54
		// Note: this type is marked as 'beforefieldinit'.
		static ExecuteAlways()
		{
			Il2CppClassPointerStore<ExecuteAlways>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ExecuteAlways");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExecuteAlways>.NativeClassPtr);
			ExecuteAlways.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteAlways>.NativeClassPtr, 100664829);
		}

		// Token: 0x06001255 RID: 4693 RVA: 0x0004ACA0 File Offset: 0x00048EA0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExecuteAlways()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExecuteAlways>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteAlways.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001256 RID: 4694 RVA: 0x0000A98D File Offset: 0x00008B8D
		public ExecuteAlways(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000EBB RID: 3771
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
