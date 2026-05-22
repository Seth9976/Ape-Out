using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000139 RID: 313
	public class Datatype_day : Datatype_dateTimeBase
	{
		// Token: 0x060018D3 RID: 6355 RVA: 0x0007B294 File Offset: 0x00079494
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_day()
		{
			Il2CppClassPointerStore<Datatype_day>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_day");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_day>.NativeClassPtr);
			Datatype_day.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_day>.NativeClassPtr, 100666925);
			Datatype_day.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_day>.NativeClassPtr, 100666926);
		}

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x060018D4 RID: 6356 RVA: 0x0007B2EC File Offset: 0x000794EC
		public unsafe override XmlTypeCode TypeCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_day.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018D5 RID: 6357 RVA: 0x0007B334 File Offset: 0x00079534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 411247, XrefRangeEnd = 411251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_day()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_day>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_day.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018D6 RID: 6358 RVA: 0x0000AEF9 File Offset: 0x000090F9
		public Datatype_day(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040012AA RID: 4778
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0;

		// Token: 0x040012AB RID: 4779
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
