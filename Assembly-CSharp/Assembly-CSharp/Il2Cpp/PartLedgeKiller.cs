using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000152 RID: 338
	public class PartLedgeKiller : MonoBehaviour
	{
		// Token: 0x060028B5 RID: 10421 RVA: 0x0001C653 File Offset: 0x0001A853
		// Note: this type is marked as 'beforefieldinit'.
		static PartLedgeKiller()
		{
			Il2CppClassPointerStore<PartLedgeKiller>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "PartLedgeKiller");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartLedgeKiller>.NativeClassPtr);
			PartLedgeKiller.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartLedgeKiller>.NativeClassPtr, 100666514);
		}

		// Token: 0x060028B6 RID: 10422 RVA: 0x000A4B5C File Offset: 0x000A2D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PartLedgeKiller()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartLedgeKiller>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartLedgeKiller.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028B7 RID: 10423 RVA: 0x0001C68C File Offset: 0x0001A88C
		public PartLedgeKiller(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040017ED RID: 6125
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
