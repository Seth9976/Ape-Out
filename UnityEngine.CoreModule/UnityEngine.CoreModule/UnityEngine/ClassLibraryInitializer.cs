using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000D1 RID: 209
	public static class ClassLibraryInitializer : Object
	{
		// Token: 0x0600127B RID: 4731 RVA: 0x0000AB15 File Offset: 0x00008D15
		// Note: this type is marked as 'beforefieldinit'.
		static ClassLibraryInitializer()
		{
			Il2CppClassPointerStore<ClassLibraryInitializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ClassLibraryInitializer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClassLibraryInitializer>.NativeClassPtr);
			ClassLibraryInitializer.NativeMethodInfoPtr_Init_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassLibraryInitializer>.NativeClassPtr, 100664838);
		}

		// Token: 0x0600127C RID: 4732 RVA: 0x0004B254 File Offset: 0x00049454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 494108, XrefRangeEnd = 494109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Init()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClassLibraryInitializer.NativeMethodInfoPtr_Init_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600127D RID: 4733 RVA: 0x0000AB4E File Offset: 0x00008D4E
		public ClassLibraryInitializer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000ECA RID: 3786
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Static_Void_0;
	}
}
