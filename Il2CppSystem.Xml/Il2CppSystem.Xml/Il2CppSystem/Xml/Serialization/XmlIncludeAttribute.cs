using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000D2 RID: 210
	public class XmlIncludeAttribute : Attribute
	{
		// Token: 0x06001236 RID: 4662 RVA: 0x000621A4 File Offset: 0x000603A4
		// Note: this type is marked as 'beforefieldinit'.
		static XmlIncludeAttribute()
		{
			Il2CppClassPointerStore<XmlIncludeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlIncludeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlIncludeAttribute>.NativeClassPtr);
			XmlIncludeAttribute.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlIncludeAttribute>.NativeClassPtr, "type");
			XmlIncludeAttribute.NativeMethodInfoPtr_get_Type_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlIncludeAttribute>.NativeClassPtr, 100666152);
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06001237 RID: 4663 RVA: 0x000621FC File Offset: 0x000603FC
		public unsafe Type Type
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlIncludeAttribute.NativeMethodInfoPtr_get_Type_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x000081EB File Offset: 0x000063EB
		public XmlIncludeAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06001239 RID: 4665 RVA: 0x0006223C File Offset: 0x0006043C
		// (set) Token: 0x0600123A RID: 4666 RVA: 0x000081F4 File Offset: 0x000063F4
		public unsafe Type type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlIncludeAttribute.NativeFieldInfoPtr_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlIncludeAttribute.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E39 RID: 3641
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04000E3A RID: 3642
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_Type_0;
	}
}
