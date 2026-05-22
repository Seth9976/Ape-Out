using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000137 RID: 311
	public class Datatype_year : Datatype_dateTimeBase
	{
		// Token: 0x060018CB RID: 6347 RVA: 0x0007B0DC File Offset: 0x000792DC
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_year()
		{
			Il2CppClassPointerStore<Datatype_year>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_year");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_year>.NativeClassPtr);
			Datatype_year.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_year>.NativeClassPtr, 100666921);
			Datatype_year.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_year>.NativeClassPtr, 100666922);
		}

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x060018CC RID: 6348 RVA: 0x0007B134 File Offset: 0x00079334
		public unsafe override XmlTypeCode TypeCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_year.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018CD RID: 6349 RVA: 0x0007B17C File Offset: 0x0007937C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 411239, XrefRangeEnd = 411243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_year()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_year>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_year.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018CE RID: 6350 RVA: 0x0000AEE7 File Offset: 0x000090E7
		public Datatype_year(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040012A6 RID: 4774
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0;

		// Token: 0x040012A7 RID: 4775
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
