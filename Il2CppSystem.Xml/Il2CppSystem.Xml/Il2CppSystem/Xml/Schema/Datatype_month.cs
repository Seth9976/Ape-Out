using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200013A RID: 314
	public class Datatype_month : Datatype_dateTimeBase
	{
		// Token: 0x060018D7 RID: 6359 RVA: 0x0007B370 File Offset: 0x00079570
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_month()
		{
			Il2CppClassPointerStore<Datatype_month>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_month");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_month>.NativeClassPtr);
			Datatype_month.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_month>.NativeClassPtr, 100666927);
			Datatype_month.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_month>.NativeClassPtr, 100666928);
		}

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x060018D8 RID: 6360 RVA: 0x0007B3C8 File Offset: 0x000795C8
		public unsafe override XmlTypeCode TypeCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_month.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018D9 RID: 6361 RVA: 0x0007B410 File Offset: 0x00079610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 411251, XrefRangeEnd = 411255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_month()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_month>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_month.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018DA RID: 6362 RVA: 0x0000AF02 File Offset: 0x00009102
		public Datatype_month(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040012AC RID: 4780
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0;

		// Token: 0x040012AD RID: 4781
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
