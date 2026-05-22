using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001B6 RID: 438
	public class XmlSchemaGroupRef : XmlSchemaParticle
	{
		// Token: 0x06002318 RID: 8984 RVA: 0x000A3494 File Offset: 0x000A1694
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaGroupRef()
		{
			Il2CppClassPointerStore<XmlSchemaGroupRef>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaGroupRef");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaGroupRef>.NativeClassPtr);
			XmlSchemaGroupRef.NativeFieldInfoPtr_refName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaGroupRef>.NativeClassPtr, "refName");
			XmlSchemaGroupRef.NativeFieldInfoPtr_particle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaGroupRef>.NativeClassPtr, "particle");
			XmlSchemaGroupRef.NativeFieldInfoPtr_refined = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaGroupRef>.NativeClassPtr, "refined");
			XmlSchemaGroupRef.NativeMethodInfoPtr_get_RefName_Public_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaGroupRef>.NativeClassPtr, 100668292);
			XmlSchemaGroupRef.NativeMethodInfoPtr_set_RefName_Public_set_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaGroupRef>.NativeClassPtr, 100668293);
			XmlSchemaGroupRef.NativeMethodInfoPtr_SetParticle_Internal_Void_XmlSchemaGroupBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaGroupRef>.NativeClassPtr, 100668294);
			XmlSchemaGroupRef.NativeMethodInfoPtr_get_Redefined_Internal_get_XmlSchemaGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaGroupRef>.NativeClassPtr, 100668295);
			XmlSchemaGroupRef.NativeMethodInfoPtr_set_Redefined_Internal_set_Void_XmlSchemaGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaGroupRef>.NativeClassPtr, 100668296);
			XmlSchemaGroupRef.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaGroupRef>.NativeClassPtr, 100668297);
		}

		// Token: 0x17000C48 RID: 3144
		// (get) Token: 0x06002319 RID: 8985 RVA: 0x000A3578 File Offset: 0x000A1778
		// (set) Token: 0x0600231A RID: 8986 RVA: 0x000A35B8 File Offset: 0x000A17B8
		public unsafe XmlQualifiedName RefName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaGroupRef.NativeMethodInfoPtr_get_RefName_Public_get_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 427595, RefRangeEnd = 427596, XrefRangeStart = 427589, XrefRangeEnd = 427595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaGroupRef.NativeMethodInfoPtr_set_RefName_Public_set_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600231B RID: 8987 RVA: 0x000A35FC File Offset: 0x000A17FC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 382561, RefRangeEnd = 382571, XrefRangeStart = 382561, XrefRangeEnd = 382571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetParticle(XmlSchemaGroupBase value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaGroupRef.NativeMethodInfoPtr_SetParticle_Internal_Void_XmlSchemaGroupBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C49 RID: 3145
		// (get) Token: 0x0600231C RID: 8988 RVA: 0x000A3640 File Offset: 0x000A1840
		// (set) Token: 0x0600231D RID: 8989 RVA: 0x000A3680 File Offset: 0x000A1880
		public unsafe XmlSchemaGroup Redefined
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaGroupRef.NativeMethodInfoPtr_get_Redefined_Internal_get_XmlSchemaGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaGroup>(intPtr3) : null;
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 161221, RefRangeEnd = 161228, XrefRangeStart = 161221, XrefRangeEnd = 161228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaGroupRef.NativeMethodInfoPtr_set_Redefined_Internal_set_Void_XmlSchemaGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600231E RID: 8990 RVA: 0x000A36C4 File Offset: 0x000A18C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427596, XrefRangeEnd = 427604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaGroupRef()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaGroupRef>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaGroupRef.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600231F RID: 8991 RVA: 0x0000F4CC File Offset: 0x0000D6CC
		public XmlSchemaGroupRef(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C45 RID: 3141
		// (get) Token: 0x06002320 RID: 8992 RVA: 0x000A3700 File Offset: 0x000A1900
		// (set) Token: 0x06002321 RID: 8993 RVA: 0x0000F4D5 File Offset: 0x0000D6D5
		public unsafe XmlQualifiedName refName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaGroupRef.NativeFieldInfoPtr_refName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaGroupRef.NativeFieldInfoPtr_refName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C46 RID: 3142
		// (get) Token: 0x06002322 RID: 8994 RVA: 0x000A3730 File Offset: 0x000A1930
		// (set) Token: 0x06002323 RID: 8995 RVA: 0x0000F4F4 File Offset: 0x0000D6F4
		public unsafe XmlSchemaGroupBase particle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaGroupRef.NativeFieldInfoPtr_particle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaGroupBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaGroupRef.NativeFieldInfoPtr_particle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C47 RID: 3143
		// (get) Token: 0x06002324 RID: 8996 RVA: 0x000A3760 File Offset: 0x000A1960
		// (set) Token: 0x06002325 RID: 8997 RVA: 0x0000F513 File Offset: 0x0000D713
		public unsafe XmlSchemaGroup refined
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaGroupRef.NativeFieldInfoPtr_refined);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaGroupRef.NativeFieldInfoPtr_refined), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A19 RID: 6681
		private static readonly IntPtr NativeFieldInfoPtr_refName;

		// Token: 0x04001A1A RID: 6682
		private static readonly IntPtr NativeFieldInfoPtr_particle;

		// Token: 0x04001A1B RID: 6683
		private static readonly IntPtr NativeFieldInfoPtr_refined;

		// Token: 0x04001A1C RID: 6684
		private static readonly IntPtr NativeMethodInfoPtr_get_RefName_Public_get_XmlQualifiedName_0;

		// Token: 0x04001A1D RID: 6685
		private static readonly IntPtr NativeMethodInfoPtr_set_RefName_Public_set_Void_XmlQualifiedName_0;

		// Token: 0x04001A1E RID: 6686
		private static readonly IntPtr NativeMethodInfoPtr_SetParticle_Internal_Void_XmlSchemaGroupBase_0;

		// Token: 0x04001A1F RID: 6687
		private static readonly IntPtr NativeMethodInfoPtr_get_Redefined_Internal_get_XmlSchemaGroup_0;

		// Token: 0x04001A20 RID: 6688
		private static readonly IntPtr NativeMethodInfoPtr_set_Redefined_Internal_set_Void_XmlSchemaGroup_0;

		// Token: 0x04001A21 RID: 6689
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
