using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml.XPath;

namespace Il2CppMS.Internal.Xml.XPath
{
	// Token: 0x0200000B RID: 11
	public class Operator : AstNode
	{
		// Token: 0x0600005A RID: 90 RVA: 0x0001550C File Offset: 0x0001370C
		// Note: this type is marked as 'beforefieldinit'.
		static Operator()
		{
			Il2CppClassPointerStore<Operator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "MS.Internal.Xml.XPath", "Operator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Operator>.NativeClassPtr);
			Operator.NativeFieldInfoPtr_invertOp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Operator>.NativeClassPtr, "invertOp");
			Operator.NativeFieldInfoPtr_opType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Operator>.NativeClassPtr, "opType");
			Operator.NativeFieldInfoPtr_opnd1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Operator>.NativeClassPtr, "opnd1");
			Operator.NativeFieldInfoPtr_opnd2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Operator>.NativeClassPtr, "opnd2");
			Operator.NativeMethodInfoPtr__ctor_Public_Void_Op_AstNode_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Operator>.NativeClassPtr, 100663333);
			Operator.NativeMethodInfoPtr_get_Type_Public_Virtual_get_AstType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Operator>.NativeClassPtr, 100663334);
			Operator.NativeMethodInfoPtr_get_ReturnType_Public_Virtual_get_XPathResultType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Operator>.NativeClassPtr, 100663335);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000155C8 File Offset: 0x000137C8
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 369207, RefRangeEnd = 369220, XrefRangeStart = 369207, XrefRangeEnd = 369220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Operator(Operator.Op op, AstNode opnd1, AstNode opnd2)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Operator>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref op;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(opnd1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(opnd2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Operator.NativeMethodInfoPtr__ctor_Public_Void_Op_AstNode_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00015634 File Offset: 0x00013834
		public unsafe override AstNode.AstType Type
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Operator.NativeMethodInfoPtr_get_Type_Public_Virtual_get_AstType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600005D RID: 93 RVA: 0x0001567C File Offset: 0x0001387C
		public unsafe override XPathResultType ReturnType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Operator.NativeMethodInfoPtr_get_ReturnType_Public_Virtual_get_XPathResultType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000231E File Offset: 0x0000051E
		public Operator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600005F RID: 95 RVA: 0x000156C4 File Offset: 0x000138C4
		// (set) Token: 0x06000060 RID: 96 RVA: 0x00002327 File Offset: 0x00000527
		public unsafe static Il2CppStructArray<Operator.Op> invertOp
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Operator.NativeFieldInfoPtr_invertOp, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Operator.Op>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Operator.NativeFieldInfoPtr_invertOp, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000061 RID: 97 RVA: 0x000156EC File Offset: 0x000138EC
		// (set) Token: 0x06000062 RID: 98 RVA: 0x00002339 File Offset: 0x00000539
		public unsafe Operator.Op opType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Operator.NativeFieldInfoPtr_opType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Operator.NativeFieldInfoPtr_opType)) = value;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00015714 File Offset: 0x00013914
		// (set) Token: 0x06000064 RID: 100 RVA: 0x00002354 File Offset: 0x00000554
		public unsafe AstNode opnd1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Operator.NativeFieldInfoPtr_opnd1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AstNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Operator.NativeFieldInfoPtr_opnd1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00015744 File Offset: 0x00013944
		// (set) Token: 0x06000066 RID: 102 RVA: 0x00002373 File Offset: 0x00000573
		public unsafe AstNode opnd2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Operator.NativeFieldInfoPtr_opnd2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AstNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Operator.NativeFieldInfoPtr_opnd2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeFieldInfoPtr_invertOp;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeFieldInfoPtr_opType;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeFieldInfoPtr_opnd1;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeFieldInfoPtr_opnd2;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Op_AstNode_AstNode_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Virtual_get_AstType_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_get_ReturnType_Public_Virtual_get_XPathResultType_0;

		// Token: 0x020001F4 RID: 500
		[OriginalName("System.Xml.dll", "", "Op")]
		public enum Op
		{
			// Token: 0x04001FDB RID: 8155
			INVALID,
			// Token: 0x04001FDC RID: 8156
			OR,
			// Token: 0x04001FDD RID: 8157
			AND,
			// Token: 0x04001FDE RID: 8158
			EQ,
			// Token: 0x04001FDF RID: 8159
			NE,
			// Token: 0x04001FE0 RID: 8160
			LT,
			// Token: 0x04001FE1 RID: 8161
			LE,
			// Token: 0x04001FE2 RID: 8162
			GT,
			// Token: 0x04001FE3 RID: 8163
			GE,
			// Token: 0x04001FE4 RID: 8164
			PLUS,
			// Token: 0x04001FE5 RID: 8165
			MINUS,
			// Token: 0x04001FE6 RID: 8166
			MUL,
			// Token: 0x04001FE7 RID: 8167
			DIV,
			// Token: 0x04001FE8 RID: 8168
			MOD,
			// Token: 0x04001FE9 RID: 8169
			UNION
		}
	}
}
