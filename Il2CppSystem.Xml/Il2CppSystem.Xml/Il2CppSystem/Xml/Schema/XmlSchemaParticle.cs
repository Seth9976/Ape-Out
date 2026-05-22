using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001C3 RID: 451
	public class XmlSchemaParticle : XmlSchemaAnnotated
	{
		// Token: 0x060023E3 RID: 9187 RVA: 0x000A6498 File Offset: 0x000A4698
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaParticle()
		{
			Il2CppClassPointerStore<XmlSchemaParticle>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaParticle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaParticle>.NativeClassPtr);
			XmlSchemaParticle.NativeFieldInfoPtr_minOccurs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaParticle>.NativeClassPtr, "minOccurs");
			XmlSchemaParticle.NativeFieldInfoPtr_maxOccurs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaParticle>.NativeClassPtr, "maxOccurs");
			XmlSchemaParticle.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaParticle>.NativeClassPtr, "flags");
			XmlSchemaParticle.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaParticle>.NativeClassPtr, "Empty");
			XmlSchemaParticle.NativeMethodInfoPtr_get_MinOccursString_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaParticle>.NativeClassPtr, 100668416);
			XmlSchemaParticle.NativeMethodInfoPtr_set_MinOccursString_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaParticle>.NativeClassPtr, 100668417);
			XmlSchemaParticle.NativeMethodInfoPtr_get_MaxOccursString_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaParticle>.NativeClassPtr, 100668418);
			XmlSchemaParticle.NativeMethodInfoPtr_set_MaxOccursString_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaParticle>.NativeClassPtr, 100668419);
			XmlSchemaParticle.NativeMethodInfoPtr_get_MinOccurs_Public_get_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaParticle>.NativeClassPtr, 100668420);
			XmlSchemaParticle.NativeMethodInfoPtr_set_MinOccurs_Public_set_Void_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaParticle>.NativeClassPtr, 100668421);
			XmlSchemaParticle.NativeMethodInfoPtr_get_MaxOccurs_Public_get_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaParticle>.NativeClassPtr, 100668422);
			XmlSchemaParticle.NativeMethodInfoPtr_set_MaxOccurs_Public_set_Void_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaParticle>.NativeClassPtr, 100668423);
			XmlSchemaParticle.NativeMethodInfoPtr_get_IsEmpty_Internal_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaParticle>.NativeClassPtr, 100668424);
			XmlSchemaParticle.NativeMethodInfoPtr_get_NameString_Internal_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaParticle>.NativeClassPtr, 100668425);
			XmlSchemaParticle.NativeMethodInfoPtr_GetQualifiedName_Internal_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaParticle>.NativeClassPtr, 100668426);
			XmlSchemaParticle.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaParticle>.NativeClassPtr, 100668427);
		}

		// Token: 0x17000C91 RID: 3217
		// (get) Token: 0x060023E4 RID: 9188 RVA: 0x000A6608 File Offset: 0x000A4808
		// (set) Token: 0x060023E5 RID: 9189 RVA: 0x000A6640 File Offset: 0x000A4840
		public unsafe string MinOccursString
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 428058, RefRangeEnd = 428064, XrefRangeStart = 428057, XrefRangeEnd = 428058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaParticle.NativeMethodInfoPtr_get_MinOccursString_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 428082, RefRangeEnd = 428085, XrefRangeStart = 428064, XrefRangeEnd = 428082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaParticle.NativeMethodInfoPtr_set_MinOccursString_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C92 RID: 3218
		// (get) Token: 0x060023E6 RID: 9190 RVA: 0x000A6684 File Offset: 0x000A4884
		// (set) Token: 0x060023E7 RID: 9191 RVA: 0x000A66BC File Offset: 0x000A48BC
		public unsafe string MaxOccursString
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 428088, RefRangeEnd = 428092, XrefRangeStart = 428085, XrefRangeEnd = 428088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaParticle.NativeMethodInfoPtr_get_MaxOccursString_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 428115, RefRangeEnd = 428116, XrefRangeStart = 428092, XrefRangeEnd = 428115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaParticle.NativeMethodInfoPtr_set_MaxOccursString_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C93 RID: 3219
		// (get) Token: 0x060023E8 RID: 9192 RVA: 0x000A6700 File Offset: 0x000A4900
		// (set) Token: 0x060023E9 RID: 9193 RVA: 0x000A673C File Offset: 0x000A493C
		public unsafe Decimal MinOccurs
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaParticle.NativeMethodInfoPtr_get_MinOccurs_Public_get_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 428137, RefRangeEnd = 428159, XrefRangeStart = 428116, XrefRangeEnd = 428137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaParticle.NativeMethodInfoPtr_set_MinOccurs_Public_set_Void_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C94 RID: 3220
		// (get) Token: 0x060023EA RID: 9194 RVA: 0x000A677C File Offset: 0x000A497C
		// (set) Token: 0x060023EB RID: 9195 RVA: 0x000A67B8 File Offset: 0x000A49B8
		public unsafe Decimal MaxOccurs
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaParticle.NativeMethodInfoPtr_get_MaxOccurs_Public_get_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 428187, RefRangeEnd = 428205, XrefRangeStart = 428159, XrefRangeEnd = 428187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaParticle.NativeMethodInfoPtr_set_MaxOccurs_Public_set_Void_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C95 RID: 3221
		// (get) Token: 0x060023EC RID: 9196 RVA: 0x000A67F8 File Offset: 0x000A49F8
		public unsafe virtual bool IsEmpty
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 428213, RefRangeEnd = 428216, XrefRangeStart = 428205, XrefRangeEnd = 428213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaParticle.NativeMethodInfoPtr_get_IsEmpty_Internal_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C96 RID: 3222
		// (get) Token: 0x060023ED RID: 9197 RVA: 0x000A6840 File Offset: 0x000A4A40
		public unsafe virtual string NameString
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428216, XrefRangeEnd = 428218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaParticle.NativeMethodInfoPtr_get_NameString_Internal_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060023EE RID: 9198 RVA: 0x000A6884 File Offset: 0x000A4A84
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 428225, RefRangeEnd = 428228, XrefRangeStart = 428218, XrefRangeEnd = 428225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlQualifiedName GetQualifiedName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaParticle.NativeMethodInfoPtr_GetQualifiedName_Internal_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
		}

		// Token: 0x060023EF RID: 9199 RVA: 0x000A68C4 File Offset: 0x000A4AC4
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 428233, RefRangeEnd = 428244, XrefRangeStart = 428228, XrefRangeEnd = 428233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaParticle()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaParticle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaParticle.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023F0 RID: 9200 RVA: 0x0000F9B5 File Offset: 0x0000DBB5
		public XmlSchemaParticle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C8D RID: 3213
		// (get) Token: 0x060023F1 RID: 9201 RVA: 0x000A6900 File Offset: 0x000A4B00
		// (set) Token: 0x060023F2 RID: 9202 RVA: 0x0000F9BE File Offset: 0x0000DBBE
		public unsafe Decimal minOccurs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaParticle.NativeFieldInfoPtr_minOccurs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaParticle.NativeFieldInfoPtr_minOccurs)) = value;
			}
		}

		// Token: 0x17000C8E RID: 3214
		// (get) Token: 0x060023F3 RID: 9203 RVA: 0x000A6928 File Offset: 0x000A4B28
		// (set) Token: 0x060023F4 RID: 9204 RVA: 0x0000F9D9 File Offset: 0x0000DBD9
		public unsafe Decimal maxOccurs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaParticle.NativeFieldInfoPtr_maxOccurs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaParticle.NativeFieldInfoPtr_maxOccurs)) = value;
			}
		}

		// Token: 0x17000C8F RID: 3215
		// (get) Token: 0x060023F5 RID: 9205 RVA: 0x000A6950 File Offset: 0x000A4B50
		// (set) Token: 0x060023F6 RID: 9206 RVA: 0x0000F9F4 File Offset: 0x0000DBF4
		public unsafe XmlSchemaParticle.Occurs flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaParticle.NativeFieldInfoPtr_flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaParticle.NativeFieldInfoPtr_flags)) = value;
			}
		}

		// Token: 0x17000C90 RID: 3216
		// (get) Token: 0x060023F7 RID: 9207 RVA: 0x000A6978 File Offset: 0x000A4B78
		// (set) Token: 0x060023F8 RID: 9208 RVA: 0x0000FA0F File Offset: 0x0000DC0F
		public unsafe static XmlSchemaParticle Empty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSchemaParticle.NativeFieldInfoPtr_Empty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaParticle>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSchemaParticle.NativeFieldInfoPtr_Empty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001AA8 RID: 6824
		private static readonly IntPtr NativeFieldInfoPtr_minOccurs;

		// Token: 0x04001AA9 RID: 6825
		private static readonly IntPtr NativeFieldInfoPtr_maxOccurs;

		// Token: 0x04001AAA RID: 6826
		private static readonly IntPtr NativeFieldInfoPtr_flags;

		// Token: 0x04001AAB RID: 6827
		private static readonly IntPtr NativeFieldInfoPtr_Empty;

		// Token: 0x04001AAC RID: 6828
		private static readonly IntPtr NativeMethodInfoPtr_get_MinOccursString_Public_get_String_0;

		// Token: 0x04001AAD RID: 6829
		private static readonly IntPtr NativeMethodInfoPtr_set_MinOccursString_Public_set_Void_String_0;

		// Token: 0x04001AAE RID: 6830
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxOccursString_Public_get_String_0;

		// Token: 0x04001AAF RID: 6831
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxOccursString_Public_set_Void_String_0;

		// Token: 0x04001AB0 RID: 6832
		private static readonly IntPtr NativeMethodInfoPtr_get_MinOccurs_Public_get_Decimal_0;

		// Token: 0x04001AB1 RID: 6833
		private static readonly IntPtr NativeMethodInfoPtr_set_MinOccurs_Public_set_Void_Decimal_0;

		// Token: 0x04001AB2 RID: 6834
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxOccurs_Public_get_Decimal_0;

		// Token: 0x04001AB3 RID: 6835
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxOccurs_Public_set_Void_Decimal_0;

		// Token: 0x04001AB4 RID: 6836
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEmpty_Internal_Virtual_New_get_Boolean_0;

		// Token: 0x04001AB5 RID: 6837
		private static readonly IntPtr NativeMethodInfoPtr_get_NameString_Internal_Virtual_New_get_String_0;

		// Token: 0x04001AB6 RID: 6838
		private static readonly IntPtr NativeMethodInfoPtr_GetQualifiedName_Internal_XmlQualifiedName_0;

		// Token: 0x04001AB7 RID: 6839
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000249 RID: 585
		[OriginalName("System.Xml.dll", "", "Occurs")]
		[Flags]
		public enum Occurs
		{
			// Token: 0x040023C1 RID: 9153
			None = 0,
			// Token: 0x040023C2 RID: 9154
			Min = 1,
			// Token: 0x040023C3 RID: 9155
			Max = 2
		}

		// Token: 0x0200024A RID: 586
		public class EmptyParticle : XmlSchemaParticle
		{
			// Token: 0x06002D6E RID: 11630 RVA: 0x000C9748 File Offset: 0x000C7948
			// Note: this type is marked as 'beforefieldinit'.
			static EmptyParticle()
			{
				Il2CppClassPointerStore<XmlSchemaParticle.EmptyParticle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlSchemaParticle>.NativeClassPtr, "EmptyParticle");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaParticle.EmptyParticle>.NativeClassPtr);
				XmlSchemaParticle.EmptyParticle.NativeMethodInfoPtr_get_IsEmpty_Internal_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaParticle.EmptyParticle>.NativeClassPtr, 100668429);
				XmlSchemaParticle.EmptyParticle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaParticle.EmptyParticle>.NativeClassPtr, 100668430);
			}

			// Token: 0x17000F75 RID: 3957
			// (get) Token: 0x06002D6F RID: 11631 RVA: 0x000C979C File Offset: 0x000C799C
			public unsafe override bool IsEmpty
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaParticle.EmptyParticle.NativeMethodInfoPtr_get_IsEmpty_Internal_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002D70 RID: 11632 RVA: 0x000C97E4 File Offset: 0x000C79E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428053, XrefRangeEnd = 428057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EmptyParticle()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaParticle.EmptyParticle>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaParticle.EmptyParticle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D71 RID: 11633 RVA: 0x00013AEC File Offset: 0x00011CEC
			public EmptyParticle(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040023C4 RID: 9156
			private static readonly IntPtr NativeMethodInfoPtr_get_IsEmpty_Internal_Virtual_get_Boolean_0;

			// Token: 0x040023C5 RID: 9157
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
