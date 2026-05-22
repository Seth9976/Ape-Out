using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200015B RID: 347
	public class Datatype_ENUMERATION : Datatype_NMTOKEN
	{
		// Token: 0x06001A11 RID: 6673 RVA: 0x0008069C File Offset: 0x0007E89C
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_ENUMERATION()
		{
			Il2CppClassPointerStore<Datatype_ENUMERATION>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_ENUMERATION");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_ENUMERATION>.NativeClassPtr);
			Datatype_ENUMERATION.NativeMethodInfoPtr_get_TokenizedType_Public_Virtual_get_XmlTokenizedType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_ENUMERATION>.NativeClassPtr, 100667113);
			Datatype_ENUMERATION.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_ENUMERATION>.NativeClassPtr, 100667114);
		}

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x06001A12 RID: 6674 RVA: 0x000806F4 File Offset: 0x0007E8F4
		public unsafe override XmlTokenizedType TokenizedType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_ENUMERATION.NativeMethodInfoPtr_get_TokenizedType_Public_Virtual_get_XmlTokenizedType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A13 RID: 6675 RVA: 0x0008073C File Offset: 0x0007E93C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_ENUMERATION()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_ENUMERATION>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_ENUMERATION.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A14 RID: 6676 RVA: 0x0000B2FB File Offset: 0x000094FB
		public Datatype_ENUMERATION(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400137C RID: 4988
		private static readonly IntPtr NativeMethodInfoPtr_get_TokenizedType_Public_Virtual_get_XmlTokenizedType_0;

		// Token: 0x0400137D RID: 4989
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
