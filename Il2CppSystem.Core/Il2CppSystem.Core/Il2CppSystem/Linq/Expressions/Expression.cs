using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Dynamic.Utils;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.CompilerServices;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x02000014 RID: 20
	public class Expression : Object
	{
		// Token: 0x060000F2 RID: 242 RVA: 0x00007678 File Offset: 0x00005878
		// Note: this type is marked as 'beforefieldinit'.
		static Expression()
		{
			Il2CppClassPointerStore<Expression>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "Expression");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Expression>.NativeClassPtr);
			Expression.NativeFieldInfoPtr_s_lambdaDelegateCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Expression>.NativeClassPtr, "s_lambdaDelegateCache");
			Expression.NativeFieldInfoPtr_s_legacyCtorSupportTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Expression>.NativeClassPtr, "s_legacyCtorSupportTable");
			Expression.NativeMethodInfoPtr_get_NodeType_Public_Virtual_New_get_ExpressionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expression>.NativeClassPtr, 100663552);
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x000076E4 File Offset: 0x000058E4
		public unsafe virtual ExpressionType NodeType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363633, XrefRangeEnd = 363642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Expression.NativeMethodInfoPtr_get_NodeType_Public_Virtual_New_get_ExpressionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0000253F File Offset: 0x0000073F
		public Expression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x0000772C File Offset: 0x0000592C
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x00002548 File Offset: 0x00000748
		public unsafe static CacheDict<Type, MethodInfo> s_lambdaDelegateCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Expression.NativeFieldInfoPtr_s_lambdaDelegateCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CacheDict<Type, MethodInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Expression.NativeFieldInfoPtr_s_lambdaDelegateCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00007754 File Offset: 0x00005954
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x0000255A File Offset: 0x0000075A
		public unsafe static ConditionalWeakTable<Expression, Expression.ExtensionInfo> s_legacyCtorSupportTable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Expression.NativeFieldInfoPtr_s_legacyCtorSupportTable, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConditionalWeakTable<Expression, Expression.ExtensionInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Expression.NativeFieldInfoPtr_s_legacyCtorSupportTable, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeFieldInfoPtr_s_lambdaDelegateCache;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeFieldInfoPtr_s_legacyCtorSupportTable;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_New_get_ExpressionType_0;

		// Token: 0x02000059 RID: 89
		public class LambdaExpressionProxy : Object
		{
			// Token: 0x060002E5 RID: 741 RVA: 0x00003310 File Offset: 0x00001510
			// Note: this type is marked as 'beforefieldinit'.
			static LambdaExpressionProxy()
			{
				Il2CppClassPointerStore<Expression.LambdaExpressionProxy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Expression>.NativeClassPtr, "LambdaExpressionProxy");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Expression.LambdaExpressionProxy>.NativeClassPtr);
			}

			// Token: 0x060002E6 RID: 742 RVA: 0x00003330 File Offset: 0x00001530
			public LambdaExpressionProxy(IntPtr pointer)
				: base(pointer)
			{
			}
		}

		// Token: 0x0200005A RID: 90
		public class MemberExpressionProxy : Object
		{
			// Token: 0x060002E7 RID: 743 RVA: 0x00003339 File Offset: 0x00001539
			// Note: this type is marked as 'beforefieldinit'.
			static MemberExpressionProxy()
			{
				Il2CppClassPointerStore<Expression.MemberExpressionProxy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Expression>.NativeClassPtr, "MemberExpressionProxy");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Expression.MemberExpressionProxy>.NativeClassPtr);
			}

			// Token: 0x060002E8 RID: 744 RVA: 0x00003359 File Offset: 0x00001559
			public MemberExpressionProxy(IntPtr pointer)
				: base(pointer)
			{
			}
		}

		// Token: 0x0200005B RID: 91
		public class ExtensionInfo : Object
		{
			// Token: 0x060002E9 RID: 745 RVA: 0x00003362 File Offset: 0x00001562
			// Note: this type is marked as 'beforefieldinit'.
			static ExtensionInfo()
			{
				Il2CppClassPointerStore<Expression.ExtensionInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Expression>.NativeClassPtr, "ExtensionInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Expression.ExtensionInfo>.NativeClassPtr);
				Expression.ExtensionInfo.NativeFieldInfoPtr_NodeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Expression.ExtensionInfo>.NativeClassPtr, "NodeType");
			}

			// Token: 0x060002EA RID: 746 RVA: 0x00003396 File Offset: 0x00001596
			public ExtensionInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000CC RID: 204
			// (get) Token: 0x060002EB RID: 747 RVA: 0x0000EC78 File Offset: 0x0000CE78
			// (set) Token: 0x060002EC RID: 748 RVA: 0x0000339F File Offset: 0x0000159F
			public unsafe ExpressionType NodeType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Expression.ExtensionInfo.NativeFieldInfoPtr_NodeType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Expression.ExtensionInfo.NativeFieldInfoPtr_NodeType)) = value;
				}
			}

			// Token: 0x04000237 RID: 567
			private static readonly IntPtr NativeFieldInfoPtr_NodeType;
		}
	}
}
