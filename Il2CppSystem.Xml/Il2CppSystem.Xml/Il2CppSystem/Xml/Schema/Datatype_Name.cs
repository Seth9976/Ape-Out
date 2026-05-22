using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000145 RID: 325
	public class Datatype_Name : Datatype_token
	{
		// Token: 0x06001939 RID: 6457 RVA: 0x0007CEC8 File Offset: 0x0007B0C8
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_Name()
		{
			Il2CppClassPointerStore<Datatype_Name>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_Name");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_Name>.NativeClassPtr);
			Datatype_Name.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_Name>.NativeClassPtr, 100666991);
			Datatype_Name.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_Name>.NativeClassPtr, 100666992);
		}

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x0600193A RID: 6458 RVA: 0x0007CF20 File Offset: 0x0007B120
		public unsafe override XmlTypeCode TypeCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_Name.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600193B RID: 6459 RVA: 0x0007CF68 File Offset: 0x0007B168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_Name()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_Name>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_Name.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600193C RID: 6460 RVA: 0x0000AFF5 File Offset: 0x000091F5
		public Datatype_Name(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040012F0 RID: 4848
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0;

		// Token: 0x040012F1 RID: 4849
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
