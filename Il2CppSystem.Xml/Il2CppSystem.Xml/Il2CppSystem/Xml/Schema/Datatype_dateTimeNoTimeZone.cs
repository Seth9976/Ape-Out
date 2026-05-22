using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200012F RID: 303
	public class Datatype_dateTimeNoTimeZone : Datatype_dateTimeBase
	{
		// Token: 0x060018B0 RID: 6320 RVA: 0x0000AD82 File Offset: 0x00008F82
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_dateTimeNoTimeZone()
		{
			Il2CppClassPointerStore<Datatype_dateTimeNoTimeZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_dateTimeNoTimeZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_dateTimeNoTimeZone>.NativeClassPtr);
			Datatype_dateTimeNoTimeZone.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_dateTimeNoTimeZone>.NativeClassPtr, 100666910);
		}

		// Token: 0x060018B1 RID: 6321 RVA: 0x0007AD1C File Offset: 0x00078F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 411207, XrefRangeEnd = 411211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_dateTimeNoTimeZone()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_dateTimeNoTimeZone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_dateTimeNoTimeZone.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018B2 RID: 6322 RVA: 0x0000ADBB File Offset: 0x00008FBB
		public Datatype_dateTimeNoTimeZone(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400129B RID: 4763
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
