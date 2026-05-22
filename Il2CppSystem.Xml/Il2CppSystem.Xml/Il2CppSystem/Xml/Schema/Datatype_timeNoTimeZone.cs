using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000132 RID: 306
	public class Datatype_timeNoTimeZone : Datatype_dateTimeBase
	{
		// Token: 0x060018B9 RID: 6329 RVA: 0x0000AE48 File Offset: 0x00009048
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_timeNoTimeZone()
		{
			Il2CppClassPointerStore<Datatype_timeNoTimeZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_timeNoTimeZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_timeNoTimeZone>.NativeClassPtr);
			Datatype_timeNoTimeZone.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_timeNoTimeZone>.NativeClassPtr, 100666913);
		}

		// Token: 0x060018BA RID: 6330 RVA: 0x0007ADD0 File Offset: 0x00078FD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 411219, XrefRangeEnd = 411223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_timeNoTimeZone()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_timeNoTimeZone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_timeNoTimeZone.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018BB RID: 6331 RVA: 0x0000AE81 File Offset: 0x00009081
		public Datatype_timeNoTimeZone(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400129E RID: 4766
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
