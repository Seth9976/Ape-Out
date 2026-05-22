using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000143 RID: 323
	public class Datatype_language : Datatype_token
	{
		// Token: 0x06001930 RID: 6448 RVA: 0x0007CCB4 File Offset: 0x0007AEB4
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_language()
		{
			Il2CppClassPointerStore<Datatype_language>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_language");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_language>.NativeClassPtr);
			Datatype_language.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_language>.NativeClassPtr, 100666986);
			Datatype_language.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_language>.NativeClassPtr, 100666987);
		}

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x06001931 RID: 6449 RVA: 0x0007CD0C File Offset: 0x0007AF0C
		public unsafe override XmlTypeCode TypeCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_language.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001932 RID: 6450 RVA: 0x0007CD54 File Offset: 0x0007AF54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_language()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_language>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_language.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001933 RID: 6451 RVA: 0x0000AFE3 File Offset: 0x000091E3
		public Datatype_language(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040012EB RID: 4843
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0;

		// Token: 0x040012EC RID: 4844
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
