using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Timeline
{
	// Token: 0x02000029 RID: 41
	public class CustomSignalEventDrawer : PropertyAttribute
	{
		// Token: 0x060003CD RID: 973 RVA: 0x00003369 File Offset: 0x00001569
		// Note: this type is marked as 'beforefieldinit'.
		static CustomSignalEventDrawer()
		{
			Il2CppClassPointerStore<CustomSignalEventDrawer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "CustomSignalEventDrawer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomSignalEventDrawer>.NativeClassPtr);
			CustomSignalEventDrawer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSignalEventDrawer>.NativeClassPtr, 100663942);
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00013720 File Offset: 0x00011920
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomSignalEventDrawer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomSignalEventDrawer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomSignalEventDrawer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003CF RID: 975 RVA: 0x000033A2 File Offset: 0x000015A2
		public CustomSignalEventDrawer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000305 RID: 773
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
