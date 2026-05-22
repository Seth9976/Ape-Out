using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000CC RID: 204
	public class XmlChoiceIdentifierAttribute : Attribute
	{
		// Token: 0x06001201 RID: 4609 RVA: 0x00061738 File Offset: 0x0005F938
		// Note: this type is marked as 'beforefieldinit'.
		static XmlChoiceIdentifierAttribute()
		{
			Il2CppClassPointerStore<XmlChoiceIdentifierAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlChoiceIdentifierAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlChoiceIdentifierAttribute>.NativeClassPtr);
			XmlChoiceIdentifierAttribute.NativeFieldInfoPtr_memberName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlChoiceIdentifierAttribute>.NativeClassPtr, "memberName");
			XmlChoiceIdentifierAttribute.NativeMethodInfoPtr_get_MemberName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlChoiceIdentifierAttribute>.NativeClassPtr, 100666130);
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06001202 RID: 4610 RVA: 0x00061790 File Offset: 0x0005F990
		public unsafe string MemberName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 404906, XrefRangeEnd = 404908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlChoiceIdentifierAttribute.NativeMethodInfoPtr_get_MemberName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001203 RID: 4611 RVA: 0x0000805F File Offset: 0x0000625F
		public XmlChoiceIdentifierAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06001204 RID: 4612 RVA: 0x000617C8 File Offset: 0x0005F9C8
		// (set) Token: 0x06001205 RID: 4613 RVA: 0x00008068 File Offset: 0x00006268
		public unsafe string memberName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlChoiceIdentifierAttribute.NativeFieldInfoPtr_memberName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlChoiceIdentifierAttribute.NativeFieldInfoPtr_memberName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000E1A RID: 3610
		private static readonly IntPtr NativeFieldInfoPtr_memberName;

		// Token: 0x04000E1B RID: 3611
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberName_Public_get_String_0;
	}
}
