using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000135 RID: 309
	public class Datatype_date : Datatype_dateTimeBase
	{
		// Token: 0x060018C3 RID: 6339 RVA: 0x0007AF24 File Offset: 0x00079124
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_date()
		{
			Il2CppClassPointerStore<Datatype_date>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_date");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_date>.NativeClassPtr);
			Datatype_date.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_date>.NativeClassPtr, 100666917);
			Datatype_date.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_date>.NativeClassPtr, 100666918);
		}

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x060018C4 RID: 6340 RVA: 0x0007AF7C File Offset: 0x0007917C
		public unsafe override XmlTypeCode TypeCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_date.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018C5 RID: 6341 RVA: 0x0007AFC4 File Offset: 0x000791C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 411231, XrefRangeEnd = 411235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_date()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_date>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_date.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018C6 RID: 6342 RVA: 0x0000AED5 File Offset: 0x000090D5
		public Datatype_date(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040012A2 RID: 4770
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0;

		// Token: 0x040012A3 RID: 4771
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
