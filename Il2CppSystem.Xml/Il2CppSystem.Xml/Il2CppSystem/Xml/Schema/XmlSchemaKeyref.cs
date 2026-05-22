using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001BB RID: 443
	public class XmlSchemaKeyref : XmlSchemaIdentityConstraint
	{
		// Token: 0x0600234B RID: 9035 RVA: 0x000A3EEC File Offset: 0x000A20EC
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaKeyref()
		{
			Il2CppClassPointerStore<XmlSchemaKeyref>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaKeyref");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaKeyref>.NativeClassPtr);
			XmlSchemaKeyref.NativeFieldInfoPtr_refer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaKeyref>.NativeClassPtr, "refer");
			XmlSchemaKeyref.NativeMethodInfoPtr_get_Refer_Public_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaKeyref>.NativeClassPtr, 100668315);
			XmlSchemaKeyref.NativeMethodInfoPtr_set_Refer_Public_set_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaKeyref>.NativeClassPtr, 100668316);
			XmlSchemaKeyref.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaKeyref>.NativeClassPtr, 100668317);
		}

		// Token: 0x17000C58 RID: 3160
		// (get) Token: 0x0600234C RID: 9036 RVA: 0x000A3F6C File Offset: 0x000A216C
		// (set) Token: 0x0600234D RID: 9037 RVA: 0x000A3FAC File Offset: 0x000A21AC
		public unsafe XmlQualifiedName Refer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaKeyref.NativeMethodInfoPtr_get_Refer_Public_get_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427617, XrefRangeEnd = 427623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaKeyref.NativeMethodInfoPtr_set_Refer_Public_set_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600234E RID: 9038 RVA: 0x000A3FF0 File Offset: 0x000A21F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427623, XrefRangeEnd = 427628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaKeyref()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaKeyref>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaKeyref.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600234F RID: 9039 RVA: 0x0000F682 File Offset: 0x0000D882
		public XmlSchemaKeyref(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C57 RID: 3159
		// (get) Token: 0x06002350 RID: 9040 RVA: 0x000A402C File Offset: 0x000A222C
		// (set) Token: 0x06002351 RID: 9041 RVA: 0x0000F68B File Offset: 0x0000D88B
		public unsafe XmlQualifiedName refer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaKeyref.NativeFieldInfoPtr_refer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaKeyref.NativeFieldInfoPtr_refer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A39 RID: 6713
		private static readonly IntPtr NativeFieldInfoPtr_refer;

		// Token: 0x04001A3A RID: 6714
		private static readonly IntPtr NativeMethodInfoPtr_get_Refer_Public_get_XmlQualifiedName_0;

		// Token: 0x04001A3B RID: 6715
		private static readonly IntPtr NativeMethodInfoPtr_set_Refer_Public_set_Void_XmlQualifiedName_0;

		// Token: 0x04001A3C RID: 6716
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
