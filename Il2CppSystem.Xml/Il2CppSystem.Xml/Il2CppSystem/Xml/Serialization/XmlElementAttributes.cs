using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000CF RID: 207
	public class XmlElementAttributes : CollectionBase
	{
		// Token: 0x06001227 RID: 4647 RVA: 0x00061EBC File Offset: 0x000600BC
		// Note: this type is marked as 'beforefieldinit'.
		static XmlElementAttributes()
		{
			Il2CppClassPointerStore<XmlElementAttributes>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlElementAttributes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlElementAttributes>.NativeClassPtr);
			XmlElementAttributes.NativeMethodInfoPtr_get_Item_Public_get_XmlElementAttribute_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElementAttributes>.NativeClassPtr, 100666145);
			XmlElementAttributes.NativeMethodInfoPtr_Add_Public_Int32_XmlElementAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElementAttributes>.NativeClassPtr, 100666146);
			XmlElementAttributes.NativeMethodInfoPtr_get_Order_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElementAttributes>.NativeClassPtr, 100666147);
			XmlElementAttributes.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElementAttributes>.NativeClassPtr, 100666148);
		}

		// Token: 0x1700060C RID: 1548
		public unsafe XmlElementAttribute this[int index]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 405044, XrefRangeEnd = 405049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlElementAttributes.NativeMethodInfoPtr_get_Item_Public_get_XmlElementAttribute_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlElementAttribute>(intPtr3) : null;
				}
			}
		}

		// Token: 0x06001229 RID: 4649 RVA: 0x00061F88 File Offset: 0x00060188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 405049, XrefRangeEnd = 405053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Add(XmlElementAttribute attribute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlElementAttributes.NativeMethodInfoPtr_Add_Public_Int32_XmlElementAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x0600122A RID: 4650 RVA: 0x00061FD8 File Offset: 0x000601D8
		public unsafe int Order
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 405068, RefRangeEnd = 405069, XrefRangeStart = 405053, XrefRangeEnd = 405068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlElementAttributes.NativeMethodInfoPtr_get_Order_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600122B RID: 4651 RVA: 0x00062014 File Offset: 0x00060214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlElementAttributes()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlElementAttributes>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlElementAttributes.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600122C RID: 4652 RVA: 0x00008178 File Offset: 0x00006378
		public XmlElementAttributes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E31 RID: 3633
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_XmlElementAttribute_Int32_0;

		// Token: 0x04000E32 RID: 3634
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Int32_XmlElementAttribute_0;

		// Token: 0x04000E33 RID: 3635
		private static readonly IntPtr NativeMethodInfoPtr_get_Order_Internal_get_Int32_0;

		// Token: 0x04000E34 RID: 3636
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
