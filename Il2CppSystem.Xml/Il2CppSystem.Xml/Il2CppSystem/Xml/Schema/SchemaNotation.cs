using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200017D RID: 381
	public sealed class SchemaNotation : Object
	{
		// Token: 0x06001E5B RID: 7771 RVA: 0x00090B74 File Offset: 0x0008ED74
		// Note: this type is marked as 'beforefieldinit'.
		static SchemaNotation()
		{
			Il2CppClassPointerStore<SchemaNotation>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "SchemaNotation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SchemaNotation>.NativeClassPtr);
			SchemaNotation.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNotation>.NativeClassPtr, "name");
			SchemaNotation.NativeFieldInfoPtr_systemLiteral = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNotation>.NativeClassPtr, "systemLiteral");
			SchemaNotation.NativeFieldInfoPtr_pubid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNotation>.NativeClassPtr, "pubid");
			SchemaNotation.NativeMethodInfoPtr__ctor_Internal_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaNotation>.NativeClassPtr, 100667624);
			SchemaNotation.NativeMethodInfoPtr_get_Name_Internal_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaNotation>.NativeClassPtr, 100667625);
			SchemaNotation.NativeMethodInfoPtr_get_SystemLiteral_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaNotation>.NativeClassPtr, 100667626);
			SchemaNotation.NativeMethodInfoPtr_set_SystemLiteral_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaNotation>.NativeClassPtr, 100667627);
			SchemaNotation.NativeMethodInfoPtr_get_Pubid_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaNotation>.NativeClassPtr, 100667628);
			SchemaNotation.NativeMethodInfoPtr_set_Pubid_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaNotation>.NativeClassPtr, 100667629);
		}

		// Token: 0x06001E5C RID: 7772 RVA: 0x00090C58 File Offset: 0x0008EE58
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaNotation(XmlQualifiedName name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchemaNotation>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaNotation.NativeMethodInfoPtr__ctor_Internal_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x06001E5D RID: 7773 RVA: 0x00090CA4 File Offset: 0x0008EEA4
		public unsafe XmlQualifiedName Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaNotation.NativeMethodInfoPtr_get_Name_Internal_get_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
		}

		// Token: 0x17000A96 RID: 2710
		// (get) Token: 0x06001E5E RID: 7774 RVA: 0x00090CE4 File Offset: 0x0008EEE4
		// (set) Token: 0x06001E5F RID: 7775 RVA: 0x00090D1C File Offset: 0x0008EF1C
		public unsafe string SystemLiteral
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaNotation.NativeMethodInfoPtr_get_SystemLiteral_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 18562, RefRangeEnd = 18620, XrefRangeStart = 18562, XrefRangeEnd = 18620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaNotation.NativeMethodInfoPtr_set_SystemLiteral_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A97 RID: 2711
		// (get) Token: 0x06001E60 RID: 7776 RVA: 0x00090D60 File Offset: 0x0008EF60
		// (set) Token: 0x06001E61 RID: 7777 RVA: 0x00090D98 File Offset: 0x0008EF98
		public unsafe string Pubid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaNotation.NativeMethodInfoPtr_get_Pubid_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(33)]
			[CachedScanResults(RefRangeStart = 18620, RefRangeEnd = 18653, XrefRangeStart = 18620, XrefRangeEnd = 18653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaNotation.NativeMethodInfoPtr_set_Pubid_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001E62 RID: 7778 RVA: 0x0000D4D3 File Offset: 0x0000B6D3
		public SchemaNotation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x06001E63 RID: 7779 RVA: 0x00090DDC File Offset: 0x0008EFDC
		// (set) Token: 0x06001E64 RID: 7780 RVA: 0x0000D4DC File Offset: 0x0000B6DC
		public unsafe XmlQualifiedName name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNotation.NativeFieldInfoPtr_name);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNotation.NativeFieldInfoPtr_name), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x06001E65 RID: 7781 RVA: 0x00090E0C File Offset: 0x0008F00C
		// (set) Token: 0x06001E66 RID: 7782 RVA: 0x0000D4FB File Offset: 0x0000B6FB
		public unsafe string systemLiteral
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNotation.NativeFieldInfoPtr_systemLiteral);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNotation.NativeFieldInfoPtr_systemLiteral), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x06001E67 RID: 7783 RVA: 0x00090E34 File Offset: 0x0008F034
		// (set) Token: 0x06001E68 RID: 7784 RVA: 0x0000D51A File Offset: 0x0000B71A
		public unsafe string pubid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNotation.NativeFieldInfoPtr_pubid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNotation.NativeFieldInfoPtr_pubid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001680 RID: 5760
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04001681 RID: 5761
		private static readonly IntPtr NativeFieldInfoPtr_systemLiteral;

		// Token: 0x04001682 RID: 5762
		private static readonly IntPtr NativeFieldInfoPtr_pubid;

		// Token: 0x04001683 RID: 5763
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlQualifiedName_0;

		// Token: 0x04001684 RID: 5764
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Internal_get_XmlQualifiedName_0;

		// Token: 0x04001685 RID: 5765
		private static readonly IntPtr NativeMethodInfoPtr_get_SystemLiteral_Internal_get_String_0;

		// Token: 0x04001686 RID: 5766
		private static readonly IntPtr NativeMethodInfoPtr_set_SystemLiteral_Internal_set_Void_String_0;

		// Token: 0x04001687 RID: 5767
		private static readonly IntPtr NativeMethodInfoPtr_get_Pubid_Internal_get_String_0;

		// Token: 0x04001688 RID: 5768
		private static readonly IntPtr NativeMethodInfoPtr_set_Pubid_Internal_set_Void_String_0;
	}
}
