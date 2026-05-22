using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000136 RID: 310
	public class Datatype_yearMonth : Datatype_dateTimeBase
	{
		// Token: 0x060018C7 RID: 6343 RVA: 0x0007B000 File Offset: 0x00079200
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_yearMonth()
		{
			Il2CppClassPointerStore<Datatype_yearMonth>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_yearMonth");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_yearMonth>.NativeClassPtr);
			Datatype_yearMonth.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_yearMonth>.NativeClassPtr, 100666919);
			Datatype_yearMonth.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_yearMonth>.NativeClassPtr, 100666920);
		}

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x060018C8 RID: 6344 RVA: 0x0007B058 File Offset: 0x00079258
		public unsafe override XmlTypeCode TypeCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_yearMonth.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018C9 RID: 6345 RVA: 0x0007B0A0 File Offset: 0x000792A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 411235, XrefRangeEnd = 411239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_yearMonth()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_yearMonth>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_yearMonth.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018CA RID: 6346 RVA: 0x0000AEDE File Offset: 0x000090DE
		public Datatype_yearMonth(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040012A4 RID: 4772
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0;

		// Token: 0x040012A5 RID: 4773
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
