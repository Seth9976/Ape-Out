using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001D0 RID: 464
	public class XmlSchemaSubstitutionGroupV1Compat : XmlSchemaSubstitutionGroup
	{
		// Token: 0x060024DA RID: 9434 RVA: 0x000A9E60 File Offset: 0x000A8060
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaSubstitutionGroupV1Compat()
		{
			Il2CppClassPointerStore<XmlSchemaSubstitutionGroupV1Compat>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaSubstitutionGroupV1Compat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaSubstitutionGroupV1Compat>.NativeClassPtr);
			XmlSchemaSubstitutionGroupV1Compat.NativeFieldInfoPtr_choice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSubstitutionGroupV1Compat>.NativeClassPtr, "choice");
			XmlSchemaSubstitutionGroupV1Compat.NativeMethodInfoPtr_get_Choice_Internal_get_XmlSchemaChoice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSubstitutionGroupV1Compat>.NativeClassPtr, 100668540);
			XmlSchemaSubstitutionGroupV1Compat.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSubstitutionGroupV1Compat>.NativeClassPtr, 100668541);
		}

		// Token: 0x17000CEF RID: 3311
		// (get) Token: 0x060024DB RID: 9435 RVA: 0x000A9ECC File Offset: 0x000A80CC
		public unsafe XmlSchemaChoice Choice
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSubstitutionGroupV1Compat.NativeMethodInfoPtr_get_Choice_Internal_get_XmlSchemaChoice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaChoice>(intPtr3) : null;
			}
		}

		// Token: 0x060024DC RID: 9436 RVA: 0x000A9F0C File Offset: 0x000A810C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 429304, RefRangeEnd = 429305, XrefRangeStart = 429299, XrefRangeEnd = 429304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaSubstitutionGroupV1Compat()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaSubstitutionGroupV1Compat>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSubstitutionGroupV1Compat.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024DD RID: 9437 RVA: 0x00010050 File Offset: 0x0000E250
		public XmlSchemaSubstitutionGroupV1Compat(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CEE RID: 3310
		// (get) Token: 0x060024DE RID: 9438 RVA: 0x000A9F48 File Offset: 0x000A8148
		// (set) Token: 0x060024DF RID: 9439 RVA: 0x00010059 File Offset: 0x0000E259
		public unsafe XmlSchemaChoice choice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSubstitutionGroupV1Compat.NativeFieldInfoPtr_choice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaChoice>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSubstitutionGroupV1Compat.NativeFieldInfoPtr_choice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B53 RID: 6995
		private static readonly IntPtr NativeFieldInfoPtr_choice;

		// Token: 0x04001B54 RID: 6996
		private static readonly IntPtr NativeMethodInfoPtr_get_Choice_Internal_get_XmlSchemaChoice_0;

		// Token: 0x04001B55 RID: 6997
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
