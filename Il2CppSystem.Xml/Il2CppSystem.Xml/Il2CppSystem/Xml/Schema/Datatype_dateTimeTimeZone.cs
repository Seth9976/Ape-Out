using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000130 RID: 304
	public class Datatype_dateTimeTimeZone : Datatype_dateTimeBase
	{
		// Token: 0x060018B3 RID: 6323 RVA: 0x0000ADC4 File Offset: 0x00008FC4
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_dateTimeTimeZone()
		{
			Il2CppClassPointerStore<Datatype_dateTimeTimeZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_dateTimeTimeZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_dateTimeTimeZone>.NativeClassPtr);
			Datatype_dateTimeTimeZone.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_dateTimeTimeZone>.NativeClassPtr, 100666911);
		}

		// Token: 0x060018B4 RID: 6324 RVA: 0x0007AD58 File Offset: 0x00078F58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 411211, XrefRangeEnd = 411215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_dateTimeTimeZone()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_dateTimeTimeZone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_dateTimeTimeZone.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018B5 RID: 6325 RVA: 0x0000ADFD File Offset: 0x00008FFD
		public Datatype_dateTimeTimeZone(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400129C RID: 4764
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
