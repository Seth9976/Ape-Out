using System;
using System.Reflection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000D6 RID: 214
	[DefaultMember("Item")]
	public class XmlMembersMapping : XmlMapping
	{
		// Token: 0x06001256 RID: 4694 RVA: 0x000627B0 File Offset: 0x000609B0
		// Note: this type is marked as 'beforefieldinit'.
		static XmlMembersMapping()
		{
			Il2CppClassPointerStore<XmlMembersMapping>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlMembersMapping");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlMembersMapping>.NativeClassPtr);
			XmlMembersMapping.NativeFieldInfoPtr__hasWrapperElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlMembersMapping>.NativeClassPtr, "_hasWrapperElement");
			XmlMembersMapping.NativeMethodInfoPtr_get_HasWrapperElement_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlMembersMapping>.NativeClassPtr, 100666164);
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06001257 RID: 4695 RVA: 0x00062808 File Offset: 0x00060A08
		public unsafe bool HasWrapperElement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlMembersMapping.NativeMethodInfoPtr_get_HasWrapperElement_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001258 RID: 4696 RVA: 0x00008314 File Offset: 0x00006514
		public XmlMembersMapping(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06001259 RID: 4697 RVA: 0x00062844 File Offset: 0x00060A44
		// (set) Token: 0x0600125A RID: 4698 RVA: 0x0000831D File Offset: 0x0000651D
		public unsafe bool _hasWrapperElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlMembersMapping.NativeFieldInfoPtr__hasWrapperElement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlMembersMapping.NativeFieldInfoPtr__hasWrapperElement)) = value;
			}
		}

		// Token: 0x04000E4F RID: 3663
		private static readonly IntPtr NativeFieldInfoPtr__hasWrapperElement;

		// Token: 0x04000E50 RID: 3664
		private static readonly IntPtr NativeMethodInfoPtr_get_HasWrapperElement_Internal_get_Boolean_0;
	}
}
