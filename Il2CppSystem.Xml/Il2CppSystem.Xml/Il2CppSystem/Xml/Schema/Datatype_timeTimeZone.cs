using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000133 RID: 307
	public class Datatype_timeTimeZone : Datatype_dateTimeBase
	{
		// Token: 0x060018BC RID: 6332 RVA: 0x0000AE8A File Offset: 0x0000908A
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_timeTimeZone()
		{
			Il2CppClassPointerStore<Datatype_timeTimeZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_timeTimeZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_timeTimeZone>.NativeClassPtr);
			Datatype_timeTimeZone.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_timeTimeZone>.NativeClassPtr, 100666914);
		}

		// Token: 0x060018BD RID: 6333 RVA: 0x0007AE0C File Offset: 0x0007900C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 411223, XrefRangeEnd = 411227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_timeTimeZone()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_timeTimeZone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_timeTimeZone.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018BE RID: 6334 RVA: 0x0000AEC3 File Offset: 0x000090C3
		public Datatype_timeTimeZone(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400129F RID: 4767
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
