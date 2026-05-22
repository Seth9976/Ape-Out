using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000EA RID: 234
	public class XmlTypeMapMemberExpandable : XmlTypeMapMemberElement
	{
		// Token: 0x060013DC RID: 5084 RVA: 0x00068E70 File Offset: 0x00067070
		// Note: this type is marked as 'beforefieldinit'.
		static XmlTypeMapMemberExpandable()
		{
			Il2CppClassPointerStore<XmlTypeMapMemberExpandable>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlTypeMapMemberExpandable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTypeMapMemberExpandable>.NativeClassPtr);
			XmlTypeMapMemberExpandable.NativeFieldInfoPtr__flatArrayIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapMemberExpandable>.NativeClassPtr, "_flatArrayIndex");
			XmlTypeMapMemberExpandable.NativeMethodInfoPtr_set_FlatArrayIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberExpandable>.NativeClassPtr, 100666375);
			XmlTypeMapMemberExpandable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberExpandable>.NativeClassPtr, 100666376);
		}

		// Token: 0x17000696 RID: 1686
		// (set) Token: 0x060013DD RID: 5085 RVA: 0x00068EDC File Offset: 0x000670DC
		public unsafe int FlatArrayIndex
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberExpandable.NativeMethodInfoPtr_set_FlatArrayIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060013DE RID: 5086 RVA: 0x00068F1C File Offset: 0x0006711C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapMemberExpandable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTypeMapMemberExpandable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberExpandable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013DF RID: 5087 RVA: 0x00008D13 File Offset: 0x00006F13
		public XmlTypeMapMemberExpandable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x060013E0 RID: 5088 RVA: 0x00068F58 File Offset: 0x00067158
		// (set) Token: 0x060013E1 RID: 5089 RVA: 0x00008D1C File Offset: 0x00006F1C
		public unsafe int _flatArrayIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMemberExpandable.NativeFieldInfoPtr__flatArrayIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMemberExpandable.NativeFieldInfoPtr__flatArrayIndex)) = value;
			}
		}

		// Token: 0x04000F61 RID: 3937
		private static readonly IntPtr NativeFieldInfoPtr__flatArrayIndex;

		// Token: 0x04000F62 RID: 3938
		private static readonly IntPtr NativeMethodInfoPtr_set_FlatArrayIndex_Public_set_Void_Int32_0;

		// Token: 0x04000F63 RID: 3939
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
