using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000134 RID: 308
	public class Datatype_time : Datatype_dateTimeBase
	{
		// Token: 0x060018BF RID: 6335 RVA: 0x0007AE48 File Offset: 0x00079048
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_time()
		{
			Il2CppClassPointerStore<Datatype_time>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_time");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_time>.NativeClassPtr);
			Datatype_time.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_time>.NativeClassPtr, 100666915);
			Datatype_time.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_time>.NativeClassPtr, 100666916);
		}

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x060018C0 RID: 6336 RVA: 0x0007AEA0 File Offset: 0x000790A0
		public unsafe override XmlTypeCode TypeCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_time.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018C1 RID: 6337 RVA: 0x0007AEE8 File Offset: 0x000790E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 411227, XrefRangeEnd = 411231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_time()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_time>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_time.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018C2 RID: 6338 RVA: 0x0000AECC File Offset: 0x000090CC
		public Datatype_time(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040012A0 RID: 4768
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0;

		// Token: 0x040012A1 RID: 4769
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
