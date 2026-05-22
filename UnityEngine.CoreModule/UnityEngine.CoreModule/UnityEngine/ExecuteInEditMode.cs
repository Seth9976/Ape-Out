using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000C8 RID: 200
	public sealed class ExecuteInEditMode : Attribute
	{
		// Token: 0x06001251 RID: 4689 RVA: 0x0000A912 File Offset: 0x00008B12
		// Note: this type is marked as 'beforefieldinit'.
		static ExecuteInEditMode()
		{
			Il2CppClassPointerStore<ExecuteInEditMode>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ExecuteInEditMode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExecuteInEditMode>.NativeClassPtr);
			ExecuteInEditMode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteInEditMode>.NativeClassPtr, 100664828);
		}

		// Token: 0x06001252 RID: 4690 RVA: 0x0004AC64 File Offset: 0x00048E64
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExecuteInEditMode()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExecuteInEditMode>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteInEditMode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001253 RID: 4691 RVA: 0x0000A94B File Offset: 0x00008B4B
		public ExecuteInEditMode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000EBA RID: 3770
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
