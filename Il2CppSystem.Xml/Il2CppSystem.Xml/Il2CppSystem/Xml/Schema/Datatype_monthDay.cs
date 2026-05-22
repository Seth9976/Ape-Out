using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000138 RID: 312
	public class Datatype_monthDay : Datatype_dateTimeBase
	{
		// Token: 0x060018CF RID: 6351 RVA: 0x0007B1B8 File Offset: 0x000793B8
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_monthDay()
		{
			Il2CppClassPointerStore<Datatype_monthDay>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_monthDay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_monthDay>.NativeClassPtr);
			Datatype_monthDay.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_monthDay>.NativeClassPtr, 100666923);
			Datatype_monthDay.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_monthDay>.NativeClassPtr, 100666924);
		}

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x060018D0 RID: 6352 RVA: 0x0007B210 File Offset: 0x00079410
		public unsafe override XmlTypeCode TypeCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_monthDay.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018D1 RID: 6353 RVA: 0x0007B258 File Offset: 0x00079458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 411243, XrefRangeEnd = 411247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_monthDay()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_monthDay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_monthDay.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018D2 RID: 6354 RVA: 0x0000AEF0 File Offset: 0x000090F0
		public Datatype_monthDay(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040012A8 RID: 4776
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0;

		// Token: 0x040012A9 RID: 4777
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
