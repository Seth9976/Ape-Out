using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml.XPath;

namespace Il2CppMS.Internal.Xml.XPath
{
	// Token: 0x02000006 RID: 6
	public class Axis : AstNode
	{
		// Token: 0x06000012 RID: 18 RVA: 0x0001457C File Offset: 0x0001277C
		// Note: this type is marked as 'beforefieldinit'.
		static Axis()
		{
			Il2CppClassPointerStore<Axis>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "MS.Internal.Xml.XPath", "Axis");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Axis>.NativeClassPtr);
			Axis.NativeFieldInfoPtr_axisType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Axis>.NativeClassPtr, "axisType");
			Axis.NativeFieldInfoPtr_input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Axis>.NativeClassPtr, "input");
			Axis.NativeFieldInfoPtr_prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Axis>.NativeClassPtr, "prefix");
			Axis.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Axis>.NativeClassPtr, "name");
			Axis.NativeFieldInfoPtr_nodeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Axis>.NativeClassPtr, "nodeType");
			Axis.NativeFieldInfoPtr_abbrAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Axis>.NativeClassPtr, "abbrAxis");
			Axis.NativeFieldInfoPtr_urn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Axis>.NativeClassPtr, "urn");
			Axis.NativeMethodInfoPtr__ctor_Public_Void_AxisType_AstNode_String_String_XPathNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Axis>.NativeClassPtr, 100663304);
			Axis.NativeMethodInfoPtr__ctor_Public_Void_AxisType_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Axis>.NativeClassPtr, 100663305);
			Axis.NativeMethodInfoPtr_get_Type_Public_Virtual_get_AstType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Axis>.NativeClassPtr, 100663306);
			Axis.NativeMethodInfoPtr_get_ReturnType_Public_Virtual_get_XPathResultType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Axis>.NativeClassPtr, 100663307);
			Axis.NativeMethodInfoPtr_get_Input_Public_get_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Axis>.NativeClassPtr, 100663308);
			Axis.NativeMethodInfoPtr_set_Input_Public_set_Void_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Axis>.NativeClassPtr, 100663309);
			Axis.NativeMethodInfoPtr_get_Prefix_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Axis>.NativeClassPtr, 100663310);
			Axis.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Axis>.NativeClassPtr, 100663311);
			Axis.NativeMethodInfoPtr_get_NodeType_Public_get_XPathNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Axis>.NativeClassPtr, 100663312);
			Axis.NativeMethodInfoPtr_get_TypeOfAxis_Public_get_AxisType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Axis>.NativeClassPtr, 100663313);
			Axis.NativeMethodInfoPtr_get_AbbrAxis_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Axis>.NativeClassPtr, 100663314);
			Axis.NativeMethodInfoPtr_get_Urn_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Axis>.NativeClassPtr, 100663315);
			Axis.NativeMethodInfoPtr_set_Urn_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Axis>.NativeClassPtr, 100663316);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x0001473C File Offset: 0x0001293C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 388778, RefRangeEnd = 388785, XrefRangeStart = 388776, XrefRangeEnd = 388778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Axis(Axis.AxisType axisType, AstNode input, string prefix, string name, XPathNodeType nodetype)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Axis>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axisType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(input);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nodetype;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Axis.NativeMethodInfoPtr__ctor_Public_Void_AxisType_AstNode_String_String_XPathNodeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000147C8 File Offset: 0x000129C8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 388788, RefRangeEnd = 388792, XrefRangeStart = 388785, XrefRangeEnd = 388788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Axis(Axis.AxisType axisType, AstNode input)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Axis>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axisType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(input);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Axis.NativeMethodInfoPtr__ctor_Public_Void_AxisType_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00014824 File Offset: 0x00012A24
		public unsafe override AstNode.AstType Type
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Axis.NativeMethodInfoPtr_get_Type_Public_Virtual_get_AstType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000016 RID: 22 RVA: 0x0001486C File Offset: 0x00012A6C
		public unsafe override XPathResultType ReturnType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Axis.NativeMethodInfoPtr_get_ReturnType_Public_Virtual_get_XPathResultType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000017 RID: 23 RVA: 0x000148B4 File Offset: 0x00012AB4
		// (set) Token: 0x06000018 RID: 24 RVA: 0x000148F4 File Offset: 0x00012AF4
		public unsafe AstNode Input
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Axis.NativeMethodInfoPtr_get_Input_Public_get_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AstNode>(intPtr3) : null;
			}
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 18562, RefRangeEnd = 18620, XrefRangeStart = 18562, XrefRangeEnd = 18620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Axis.NativeMethodInfoPtr_set_Input_Public_set_Void_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00014938 File Offset: 0x00012B38
		public unsafe string Prefix
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Axis.NativeMethodInfoPtr_get_Prefix_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00014970 File Offset: 0x00012B70
		public unsafe string Name
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Axis.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600001B RID: 27 RVA: 0x000149A8 File Offset: 0x00012BA8
		public unsafe XPathNodeType NodeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Axis.NativeMethodInfoPtr_get_NodeType_Public_get_XPathNodeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600001C RID: 28 RVA: 0x000149E4 File Offset: 0x00012BE4
		public unsafe Axis.AxisType TypeOfAxis
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Axis.NativeMethodInfoPtr_get_TypeOfAxis_Public_get_AxisType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00014A20 File Offset: 0x00012C20
		public unsafe bool AbbrAxis
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Axis.NativeMethodInfoPtr_get_AbbrAxis_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00014A5C File Offset: 0x00012C5C
		// (set) Token: 0x0600001F RID: 31 RVA: 0x00014A94 File Offset: 0x00012C94
		public unsafe string Urn
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 621, RefRangeEnd = 626, XrefRangeStart = 621, XrefRangeEnd = 626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Axis.NativeMethodInfoPtr_get_Urn_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 99340, RefRangeEnd = 99363, XrefRangeStart = 99340, XrefRangeEnd = 99363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Axis.NativeMethodInfoPtr_set_Urn_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002103 File Offset: 0x00000303
		public Axis(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00014AD8 File Offset: 0x00012CD8
		// (set) Token: 0x06000022 RID: 34 RVA: 0x0000210C File Offset: 0x0000030C
		public unsafe Axis.AxisType axisType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Axis.NativeFieldInfoPtr_axisType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Axis.NativeFieldInfoPtr_axisType)) = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00014B00 File Offset: 0x00012D00
		// (set) Token: 0x06000024 RID: 36 RVA: 0x00002127 File Offset: 0x00000327
		public unsafe AstNode input
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Axis.NativeFieldInfoPtr_input);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AstNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Axis.NativeFieldInfoPtr_input), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00014B30 File Offset: 0x00012D30
		// (set) Token: 0x06000026 RID: 38 RVA: 0x00002146 File Offset: 0x00000346
		public unsafe string prefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Axis.NativeFieldInfoPtr_prefix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Axis.NativeFieldInfoPtr_prefix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00014B58 File Offset: 0x00012D58
		// (set) Token: 0x06000028 RID: 40 RVA: 0x00002165 File Offset: 0x00000365
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Axis.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Axis.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00014B80 File Offset: 0x00012D80
		// (set) Token: 0x0600002A RID: 42 RVA: 0x00002184 File Offset: 0x00000384
		public unsafe XPathNodeType nodeType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Axis.NativeFieldInfoPtr_nodeType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Axis.NativeFieldInfoPtr_nodeType)) = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00014BA8 File Offset: 0x00012DA8
		// (set) Token: 0x0600002C RID: 44 RVA: 0x0000219F File Offset: 0x0000039F
		public unsafe bool abbrAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Axis.NativeFieldInfoPtr_abbrAxis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Axis.NativeFieldInfoPtr_abbrAxis)) = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00014BD0 File Offset: 0x00012DD0
		// (set) Token: 0x0600002E RID: 46 RVA: 0x000021BA File Offset: 0x000003BA
		public unsafe string urn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Axis.NativeFieldInfoPtr_urn);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Axis.NativeFieldInfoPtr_urn), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeFieldInfoPtr_axisType;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeFieldInfoPtr_input;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeFieldInfoPtr_prefix;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeFieldInfoPtr_nodeType;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeFieldInfoPtr_abbrAxis;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeFieldInfoPtr_urn;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AxisType_AstNode_String_String_XPathNodeType_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AxisType_AstNode_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Virtual_get_AstType_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_get_ReturnType_Public_Virtual_get_XPathResultType_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_get_Input_Public_get_AstNode_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_set_Input_Public_set_Void_AstNode_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_get_Prefix_Public_get_String_0;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_get_XPathNodeType_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeOfAxis_Public_get_AxisType_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_get_AbbrAxis_Public_get_Boolean_0;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_get_Urn_Public_get_String_0;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_set_Urn_Public_set_Void_String_0;

		// Token: 0x020001F2 RID: 498
		[OriginalName("System.Xml.dll", "", "AxisType")]
		public enum AxisType
		{
			// Token: 0x04001FAF RID: 8111
			Ancestor,
			// Token: 0x04001FB0 RID: 8112
			AncestorOrSelf,
			// Token: 0x04001FB1 RID: 8113
			Attribute,
			// Token: 0x04001FB2 RID: 8114
			Child,
			// Token: 0x04001FB3 RID: 8115
			Descendant,
			// Token: 0x04001FB4 RID: 8116
			DescendantOrSelf,
			// Token: 0x04001FB5 RID: 8117
			Following,
			// Token: 0x04001FB6 RID: 8118
			FollowingSibling,
			// Token: 0x04001FB7 RID: 8119
			Namespace,
			// Token: 0x04001FB8 RID: 8120
			Parent,
			// Token: 0x04001FB9 RID: 8121
			Preceding,
			// Token: 0x04001FBA RID: 8122
			PrecedingSibling,
			// Token: 0x04001FBB RID: 8123
			Self,
			// Token: 0x04001FBC RID: 8124
			None
		}
	}
}
