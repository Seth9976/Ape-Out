using System;
using System.Reflection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Linq
{
	// Token: 0x0200000C RID: 12
	[DefaultMember("Item")]
	public class Lookup<TKey, TElement> : Object
	{
		// Token: 0x0600008F RID: 143 RVA: 0x00005DCC File Offset: 0x00003FCC
		// Note: this type is marked as 'beforefieldinit'.
		static Lookup()
		{
			Il2CppClassPointerStore<Lookup<TKey, TElement>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq", "Lookup`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Lookup<TKey, TElement>>.NativeClassPtr);
			Lookup<TKey, TElement>.NativeFieldInfoPtr_comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lookup<TKey, TElement>>.NativeClassPtr, "comparer");
			Lookup<TKey, TElement>.NativeFieldInfoPtr_groupings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lookup<TKey, TElement>>.NativeClassPtr, "groupings");
			Lookup<TKey, TElement>.NativeFieldInfoPtr_lastGrouping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lookup<TKey, TElement>>.NativeClassPtr, "lastGrouping");
			Lookup<TKey, TElement>.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lookup<TKey, TElement>>.NativeClassPtr, "count");
			Lookup<TKey, TElement>.NativeMethodInfoPtr_Create_Internal_Static_Lookup_2_TKey_TElement_IEnumerable_1_TSource_Func_2_TSource_TKey_Func_2_TSource_TElement_IEqualityComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>>.NativeClassPtr, 100663485);
			Lookup<TKey, TElement>.NativeMethodInfoPtr__ctor_Private_Void_IEqualityComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>>.NativeClassPtr, 100663486);
			Lookup<TKey, TElement>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_IGrouping_2_TKey_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>>.NativeClassPtr, 100663487);
			Lookup<TKey, TElement>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>>.NativeClassPtr, 100663488);
			Lookup<TKey, TElement>.NativeMethodInfoPtr_InternalGetHashCode_Internal_Int32_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>>.NativeClassPtr, 100663489);
			Lookup<TKey, TElement>.NativeMethodInfoPtr_GetGrouping_Internal_Grouping_TKey_TElement_TKey_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>>.NativeClassPtr, 100663490);
			Lookup<TKey, TElement>.NativeMethodInfoPtr_Resize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>>.NativeClassPtr, 100663491);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00005F28 File Offset: 0x00004128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363503, XrefRangeEnd = 363524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public static Lookup<TKey, TElement> Create<TSource>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
		{
			/*
An exception occurred when decompiling this method (06000090)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Il2CppSystem.Linq.Lookup`2<TKey,TElement> Il2CppSystem.Linq.Lookup`2::Create<TSource>(Il2CppSystem.Collections.Generic.IEnumerable`1<TSource>,Il2CppSystem.Func`2<TSource,TKey>,Il2CppSystem.Func`2<TSource,TElement>,Il2CppSystem.Collections.Generic.IEqualityComparer`1<TKey>)

 ---> System.ArgumentOutOfRangeException: Non-negative number required. (Parameter 'count')
   at System.Collections.Generic.List`1.GetRange(Int32 index, Int32 count)
   at ICSharpCode.Decompiler.Ast.AstBuilder.ApplyTypeArgumentsTo(AstType baseType, List`1 typeArguments) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 947
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(TypeSig type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 712
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(ITypeDefOrRef type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 817
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(ITypeDefOrRef type, StringBuilder sb, IHasCustomAttribute typeAttributes, ConvertTypeOptions options) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 666
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 874
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 488
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 488
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformNode(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 268
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformBlock(ILBlock block) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 252
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 150
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1686
*/;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00005FA4 File Offset: 0x000041A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363524, XrefRangeEnd = 363526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Lookup(IEqualityComparer<TKey> comparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Lookup<TKey, TElement>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.NativeMethodInfoPtr__ctor_Private_Void_IEqualityComparer_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00005FF0 File Offset: 0x000041F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363526, XrefRangeEnd = 363528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<IGrouping<TKey, TElement>> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_IGrouping_2_TKey_TElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<IGrouping<TKey, TElement>>>(intPtr3) : null;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00006030 File Offset: 0x00004230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363528, XrefRangeEnd = 363529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00006070 File Offset: 0x00004270
		[CallerCount(0)]
		public unsafe int InternalGetHashCode(TKey key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref TKey ptr4;
				if (!typeof(TKey).IsValueType)
				{
					TKey tkey = key;
					if (!(tkey is string))
					{
						ref TKey ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(tkey as string);
					}
				}
				else
				{
					ptr4 = ref key;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.NativeMethodInfoPtr_InternalGetHashCode_Internal_Int32_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00006108 File Offset: 0x00004308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363529, XrefRangeEnd = 363531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Lookup<TKey, TElement>.Grouping GetGrouping(TKey key, bool create)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref TKey ptr4;
				if (!typeof(TKey).IsValueType)
				{
					TKey tkey = key;
					if (!(tkey is string))
					{
						ref TKey ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(tkey as string);
					}
				}
				else
				{
					ptr4 = ref key;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref create;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.NativeMethodInfoPtr_GetGrouping_Internal_Grouping_TKey_TElement_TKey_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Lookup<TKey, TElement>.Grouping>(intPtr3) : null;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x000061B4 File Offset: 0x000043B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363531, XrefRangeEnd = 363548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Resize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.NativeMethodInfoPtr_Resize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000021F6 File Offset: 0x000003F6
		public Lookup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000098 RID: 152 RVA: 0x000061E8 File Offset: 0x000043E8
		// (set) Token: 0x06000099 RID: 153 RVA: 0x000021FF File Offset: 0x000003FF
		public unsafe IEqualityComparer<TKey> comparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>.NativeFieldInfoPtr_comparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEqualityComparer<TKey>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>.NativeFieldInfoPtr_comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00006218 File Offset: 0x00004418
		// (set) Token: 0x0600009B RID: 155 RVA: 0x0000221E File Offset: 0x0000041E
		public unsafe Il2CppReferenceArray<Lookup<TKey, TElement>.Grouping> groupings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>.NativeFieldInfoPtr_groupings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Lookup<TKey, TElement>.Grouping>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>.NativeFieldInfoPtr_groupings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00006248 File Offset: 0x00004448
		// (set) Token: 0x0600009D RID: 157 RVA: 0x0000223D File Offset: 0x0000043D
		public unsafe Lookup<TKey, TElement>.Grouping lastGrouping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>.NativeFieldInfoPtr_lastGrouping);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Lookup<TKey, TElement>.Grouping>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>.NativeFieldInfoPtr_lastGrouping), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00006278 File Offset: 0x00004478
		// (set) Token: 0x0600009F RID: 159 RVA: 0x0000225C File Offset: 0x0000045C
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeFieldInfoPtr_comparer;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeFieldInfoPtr_groupings;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeFieldInfoPtr_lastGrouping;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr_Create_Internal_Static_Lookup_2_TKey_TElement_IEnumerable_1_TSource_Func_2_TSource_TKey_Func_2_TSource_TElement_IEqualityComparer_1_TKey_0;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_IEqualityComparer_1_TKey_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_IGrouping_2_TKey_TElement_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetHashCode_Internal_Int32_TKey_0;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_GetGrouping_Internal_Grouping_TKey_TElement_TKey_Boolean_0;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_Resize_Private_Void_0;

		// Token: 0x02000053 RID: 83
		public class Grouping : Object
		{
			// Token: 0x06000297 RID: 663 RVA: 0x0000D7B0 File Offset: 0x0000B9B0
			// Note: this type is marked as 'beforefieldinit'.
			static Grouping()
			{
				Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Lookup<TKey, TElement>>.NativeClassPtr, "Grouping"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping>.NativeClassPtr);
				Lookup<TKey, TElement>.Grouping.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping>.NativeClassPtr, "key");
				Lookup<TKey, TElement>.Grouping.NativeFieldInfoPtr_hashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping>.NativeClassPtr, "hashCode");
				Lookup<TKey, TElement>.Grouping.NativeFieldInfoPtr_elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping>.NativeClassPtr, "elements");
				Lookup<TKey, TElement>.Grouping.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping>.NativeClassPtr, "count");
				Lookup<TKey, TElement>.Grouping.NativeFieldInfoPtr_hashNext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping>.NativeClassPtr, "hashNext");
				Lookup<TKey, TElement>.Grouping.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping>.NativeClassPtr, "next");
				Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_Add_Internal_Void_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping>.NativeClassPtr, 100663492);
				Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping>.NativeClassPtr, 100663493);
				Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping>.NativeClassPtr, 100663494);
				Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping>.NativeClassPtr, 100663495);
				Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TElement__get_Count_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping>.NativeClassPtr, 100663496);
				Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TElement__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping>.NativeClassPtr, 100663497);
				Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TElement__Add_Private_Virtual_Final_New_Void_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping>.NativeClassPtr, 100663498);
				Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TElement__Clear_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping>.NativeClassPtr, 100663499);
				Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TElement__Contains_Private_Virtual_Final_New_Boolean_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping>.NativeClassPtr, 100663500);
				Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TElement__CopyTo_Private_Virtual_Final_New_Void_Il2CppArrayBase_1_TElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping>.NativeClassPtr, 100663501);
				Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TElement__Remove_Private_Virtual_Final_New_Boolean_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping>.NativeClassPtr, 100663502);
				Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_System_Collections_Generic_IList_TElement__IndexOf_Private_Virtual_Final_New_Int32_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping>.NativeClassPtr, 100663503);
				Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_System_Collections_Generic_IList_TElement__Insert_Private_Virtual_Final_New_Void_Int32_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping>.NativeClassPtr, 100663504);
				Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_System_Collections_Generic_IList_TElement__RemoveAt_Private_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping>.NativeClassPtr, 100663505);
				Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_System_Collections_Generic_IList_TElement__get_Item_Private_Virtual_Final_New_get_TElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping>.NativeClassPtr, 100663506);
				Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_System_Collections_Generic_IList_TElement__set_Item_Private_Virtual_Final_New_set_Void_Int32_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping>.NativeClassPtr, 100663507);
				Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping>.NativeClassPtr, 100663508);
			}

			// Token: 0x06000298 RID: 664 RVA: 0x0000D9F4 File Offset: 0x0000BBF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363475, XrefRangeEnd = 363477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Add(TElement element)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					IntPtr* ptr2 = ptr;
					ref TElement ptr4;
					if (!typeof(TElement).IsValueType)
					{
						TElement telement = element;
						if (!(telement is string))
						{
							ref TElement ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(telement as Il2CppObjectBase));
							if ((ref ptr3) != null)
							{
								ptr4 = ref ptr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
								{
									ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
								}
							}
						}
						else
						{
							ptr4 = IL2CPP.ManagedStringToIl2Cpp(telement as string);
						}
					}
					else
					{
						ptr4 = ref element;
					}
					*ptr2 = ref ptr4;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_Add_Internal_Void_TElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000299 RID: 665 RVA: 0x0000DA84 File Offset: 0x0000BC84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363477, XrefRangeEnd = 363479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IEnumerator<TElement> GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_TElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TElement>>(intPtr3) : null;
			}

			// Token: 0x0600029A RID: 666 RVA: 0x0000DAC4 File Offset: 0x0000BCC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x170000B7 RID: 183
			// (get) Token: 0x0600029B RID: 667 RVA: 0x0000DB04 File Offset: 0x0000BD04
			public unsafe virtual TKey Key
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TKey>(intPtr, false, true);
				}
			}

			// Token: 0x170000B8 RID: 184
			// (get) Token: 0x0600029C RID: 668 RVA: 0x0000DB40 File Offset: 0x0000BD40
			public unsafe virtual int System.Collections.Generic.ICollection<TElement>.Count
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TElement__get_Count_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170000B9 RID: 185
			// (get) Token: 0x0600029D RID: 669 RVA: 0x0000DB7C File Offset: 0x0000BD7C
			public unsafe virtual bool System.Collections.Generic.ICollection<TElement>.IsReadOnly
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TElement__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600029E RID: 670 RVA: 0x0000DBB8 File Offset: 0x0000BDB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363479, XrefRangeEnd = 363482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void System_Collections_Generic_ICollection_TElement__Add(TElement item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					IntPtr* ptr2 = ptr;
					ref TElement ptr4;
					if (!typeof(TElement).IsValueType)
					{
						TElement telement = item;
						if (!(telement is string))
						{
							ref TElement ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(telement as Il2CppObjectBase));
							if ((ref ptr3) != null)
							{
								ptr4 = ref ptr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
								{
									ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
								}
							}
						}
						else
						{
							ptr4 = IL2CPP.ManagedStringToIl2Cpp(telement as string);
						}
					}
					else
					{
						ptr4 = ref item;
					}
					*ptr2 = ref ptr4;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TElement__Add_Private_Virtual_Final_New_Void_TElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600029F RID: 671 RVA: 0x0000DC48 File Offset: 0x0000BE48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363482, XrefRangeEnd = 363485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void System_Collections_Generic_ICollection_TElement__Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TElement__Clear_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002A0 RID: 672 RVA: 0x0000DC7C File Offset: 0x0000BE7C
			[CallerCount(0)]
			public unsafe virtual bool System_Collections_Generic_ICollection_TElement__Contains(TElement item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					IntPtr* ptr2 = ptr;
					ref TElement ptr4;
					if (!typeof(TElement).IsValueType)
					{
						TElement telement = item;
						if (!(telement is string))
						{
							ref TElement ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(telement as Il2CppObjectBase));
							if ((ref ptr3) != null)
							{
								ptr4 = ref ptr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
								{
									ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
								}
							}
						}
						else
						{
							ptr4 = IL2CPP.ManagedStringToIl2Cpp(telement as string);
						}
					}
					else
					{
						ptr4 = ref item;
					}
					*ptr2 = ref ptr4;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TElement__Contains_Private_Virtual_Final_New_Boolean_TElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060002A1 RID: 673 RVA: 0x0000DD14 File Offset: 0x0000BF14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363485, XrefRangeEnd = 363486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void System_Collections_Generic_ICollection_TElement__CopyTo(Il2CppArrayBase<TElement> array, int arrayIndex)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TElement__CopyTo_Private_Virtual_Final_New_Void_Il2CppArrayBase_1_TElement_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002A2 RID: 674 RVA: 0x0000DD64 File Offset: 0x0000BF64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363486, XrefRangeEnd = 363489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool System_Collections_Generic_ICollection_TElement__Remove(TElement item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					IntPtr* ptr2 = ptr;
					ref TElement ptr4;
					if (!typeof(TElement).IsValueType)
					{
						TElement telement = item;
						if (!(telement is string))
						{
							ref TElement ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(telement as Il2CppObjectBase));
							if ((ref ptr3) != null)
							{
								ptr4 = ref ptr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
								{
									ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
								}
							}
						}
						else
						{
							ptr4 = IL2CPP.ManagedStringToIl2Cpp(telement as string);
						}
					}
					else
					{
						ptr4 = ref item;
					}
					*ptr2 = ref ptr4;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TElement__Remove_Private_Virtual_Final_New_Boolean_TElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060002A3 RID: 675 RVA: 0x0000DDFC File Offset: 0x0000BFFC
			[CallerCount(0)]
			public unsafe virtual int System_Collections_Generic_IList_TElement__IndexOf(TElement item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					IntPtr* ptr2 = ptr;
					ref TElement ptr4;
					if (!typeof(TElement).IsValueType)
					{
						TElement telement = item;
						if (!(telement is string))
						{
							ref TElement ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(telement as Il2CppObjectBase));
							if ((ref ptr3) != null)
							{
								ptr4 = ref ptr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
								{
									ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
								}
							}
						}
						else
						{
							ptr4 = IL2CPP.ManagedStringToIl2Cpp(telement as string);
						}
					}
					else
					{
						ptr4 = ref item;
					}
					*ptr2 = ref ptr4;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_System_Collections_Generic_IList_TElement__IndexOf_Private_Virtual_Final_New_Int32_TElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060002A4 RID: 676 RVA: 0x0000DE94 File Offset: 0x0000C094
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363489, XrefRangeEnd = 363492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void System_Collections_Generic_IList_TElement__Insert(int index, TElement item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
				ref TElement ptr4;
				if (!typeof(TElement).IsValueType)
				{
					TElement telement = item;
					if (!(telement is string))
					{
						ref TElement ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(telement as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(telement as string);
					}
				}
				else
				{
					ptr4 = ref item;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_System_Collections_Generic_IList_TElement__Insert_Private_Virtual_Final_New_Void_Int32_TElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002A5 RID: 677 RVA: 0x0000DF30 File Offset: 0x0000C130
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363492, XrefRangeEnd = 363495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void System_Collections_Generic_IList_TElement__RemoveAt(int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_System_Collections_Generic_IList_TElement__RemoveAt_Private_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x170000BA RID: 186
			// (get) Token: 0x060002A6 RID: 678 RVA: 0x0000DF70 File Offset: 0x0000C170
			// (set) Token: 0x060002A7 RID: 679 RVA: 0x0000DFB8 File Offset: 0x0000C1B8
			public unsafe virtual TElement System.Collections.Generic.IList<TElement>.Item
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref index;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_System_Collections_Generic_IList_TElement__get_Item_Private_Virtual_Final_New_get_TElement_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.PointerToValueGeneric<TElement>(intPtr, false, true);
					}
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363495, XrefRangeEnd = 363498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref index;
					}
					IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
					ref TElement ptr4;
					if (!typeof(TElement).IsValueType)
					{
						TElement telement = value;
						if (!(telement is string))
						{
							ref TElement ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(telement as Il2CppObjectBase));
							if ((ref ptr3) != null)
							{
								ptr4 = ref ptr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
								{
									ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
								}
							}
						}
						else
						{
							ptr4 = IL2CPP.ManagedStringToIl2Cpp(telement as string);
						}
					}
					else
					{
						ptr4 = ref value;
					}
					*ptr2 = ref ptr4;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_System_Collections_Generic_IList_TElement__set_Item_Private_Virtual_Final_New_set_Void_Int32_TElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060002A8 RID: 680 RVA: 0x0000E054 File Offset: 0x0000C254
			[CallerCount(0)]
			public unsafe Grouping()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002A9 RID: 681 RVA: 0x000030F7 File Offset: 0x000012F7
			public Grouping(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000B1 RID: 177
			// (get) Token: 0x060002AA RID: 682 RVA: 0x0000E090 File Offset: 0x0000C290
			// (set) Token: 0x060002AB RID: 683 RVA: 0x0000E0B8 File Offset: 0x0000C2B8
			public unsafe TKey key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>.Grouping.NativeFieldInfoPtr_key);
					return IL2CPP.PointerToValueGeneric<TKey>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>.Grouping.NativeFieldInfoPtr_key);
					Type typeFromHandle = typeof(TKey);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x170000B2 RID: 178
			// (get) Token: 0x060002AC RID: 684 RVA: 0x0000E160 File Offset: 0x0000C360
			// (set) Token: 0x060002AD RID: 685 RVA: 0x00003100 File Offset: 0x00001300
			public unsafe int hashCode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>.Grouping.NativeFieldInfoPtr_hashCode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>.Grouping.NativeFieldInfoPtr_hashCode)) = value;
				}
			}

			// Token: 0x170000B3 RID: 179
			// (get) Token: 0x060002AE RID: 686 RVA: 0x0000E188 File Offset: 0x0000C388
			// (set) Token: 0x060002AF RID: 687 RVA: 0x0000311B File Offset: 0x0000131B
			public unsafe Il2CppArrayBase<TElement> elements
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>.Grouping.NativeFieldInfoPtr_elements);
					return Il2CppArrayBase<TElement>.WrapNativeGenericArrayPointer(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>.Grouping.NativeFieldInfoPtr_elements), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000B4 RID: 180
			// (get) Token: 0x060002B0 RID: 688 RVA: 0x0000E1B0 File Offset: 0x0000C3B0
			// (set) Token: 0x060002B1 RID: 689 RVA: 0x0000313A File Offset: 0x0000133A
			public unsafe int count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>.Grouping.NativeFieldInfoPtr_count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>.Grouping.NativeFieldInfoPtr_count)) = value;
				}
			}

			// Token: 0x170000B5 RID: 181
			// (get) Token: 0x060002B2 RID: 690 RVA: 0x0000E1D8 File Offset: 0x0000C3D8
			// (set) Token: 0x060002B3 RID: 691 RVA: 0x00003155 File Offset: 0x00001355
			public unsafe Lookup<TKey, TElement>.Grouping hashNext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>.Grouping.NativeFieldInfoPtr_hashNext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Lookup<TKey, TElement>.Grouping>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>.Grouping.NativeFieldInfoPtr_hashNext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000B6 RID: 182
			// (get) Token: 0x060002B4 RID: 692 RVA: 0x0000E208 File Offset: 0x0000C408
			// (set) Token: 0x060002B5 RID: 693 RVA: 0x00003174 File Offset: 0x00001374
			public unsafe Lookup<TKey, TElement>.Grouping next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>.Grouping.NativeFieldInfoPtr_next);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Lookup<TKey, TElement>.Grouping>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>.Grouping.NativeFieldInfoPtr_next), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000205 RID: 517
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x04000206 RID: 518
			private static readonly IntPtr NativeFieldInfoPtr_hashCode;

			// Token: 0x04000207 RID: 519
			private static readonly IntPtr NativeFieldInfoPtr_elements;

			// Token: 0x04000208 RID: 520
			private static readonly IntPtr NativeFieldInfoPtr_count;

			// Token: 0x04000209 RID: 521
			private static readonly IntPtr NativeFieldInfoPtr_hashNext;

			// Token: 0x0400020A RID: 522
			private static readonly IntPtr NativeFieldInfoPtr_next;

			// Token: 0x0400020B RID: 523
			private static readonly IntPtr NativeMethodInfoPtr_Add_Internal_Void_TElement_0;

			// Token: 0x0400020C RID: 524
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_TElement_0;

			// Token: 0x0400020D RID: 525
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x0400020E RID: 526
			private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_TKey_0;

			// Token: 0x0400020F RID: 527
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TElement__get_Count_Private_Virtual_Final_New_get_Int32_0;

			// Token: 0x04000210 RID: 528
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TElement__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x04000211 RID: 529
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TElement__Add_Private_Virtual_Final_New_Void_TElement_0;

			// Token: 0x04000212 RID: 530
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TElement__Clear_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000213 RID: 531
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TElement__Contains_Private_Virtual_Final_New_Boolean_TElement_0;

			// Token: 0x04000214 RID: 532
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TElement__CopyTo_Private_Virtual_Final_New_Void_Il2CppArrayBase_1_TElement_Int32_0;

			// Token: 0x04000215 RID: 533
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TElement__Remove_Private_Virtual_Final_New_Boolean_TElement_0;

			// Token: 0x04000216 RID: 534
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IList_TElement__IndexOf_Private_Virtual_Final_New_Int32_TElement_0;

			// Token: 0x04000217 RID: 535
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IList_TElement__Insert_Private_Virtual_Final_New_Void_Int32_TElement_0;

			// Token: 0x04000218 RID: 536
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IList_TElement__RemoveAt_Private_Virtual_Final_New_Void_Int32_0;

			// Token: 0x04000219 RID: 537
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IList_TElement__get_Item_Private_Virtual_Final_New_get_TElement_Int32_0;

			// Token: 0x0400021A RID: 538
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IList_TElement__set_Item_Private_Virtual_Final_New_set_Void_Int32_TElement_0;

			// Token: 0x0400021B RID: 539
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x02000069 RID: 105
			[ObfuscatedName("System.Linq.Lookup`2+Grouping+<GetEnumerator>d__7")]
			public sealed class _GetEnumerator_d__7 : Object
			{
				// Token: 0x06000316 RID: 790 RVA: 0x0000F530 File Offset: 0x0000D730
				// Note: this type is marked as 'beforefieldinit'.
				static _GetEnumerator_d__7()
				{
					Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping>.NativeClassPtr, "<GetEnumerator>d__7"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
					{
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr))
					})).TypeHandle.value);
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7>.NativeClassPtr);
					Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7>.NativeClassPtr, "<>1__state");
					Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7>.NativeClassPtr, "<>2__current");
					Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7>.NativeClassPtr, "<>4__this");
					Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7.NativeFieldInfoPtr__i_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7>.NativeClassPtr, "<i>5__1");
					Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7>.NativeClassPtr, 100663509);
					Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7>.NativeClassPtr, 100663510);
					Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7>.NativeClassPtr, 100663511);
					Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TElement__get_Current_Private_Virtual_Final_New_get_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7>.NativeClassPtr, 100663512);
					Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7>.NativeClassPtr, 100663513);
					Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7>.NativeClassPtr, 100663514);
				}

				// Token: 0x06000317 RID: 791 RVA: 0x0000F670 File Offset: 0x0000D870
				[CallerCount(0)]
				public unsafe _GetEnumerator_d__7(int <>1__state)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref <>1__state;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06000318 RID: 792 RVA: 0x0000F6B8 File Offset: 0x0000D8B8
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06000319 RID: 793 RVA: 0x0000F6EC File Offset: 0x0000D8EC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363469, XrefRangeEnd = 363470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170000DA RID: 218
				// (get) Token: 0x0600031A RID: 794 RVA: 0x0000F728 File Offset: 0x0000D928
				public unsafe TElement System.Collections.Generic.IEnumerator<TElement>.Current
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TElement__get_Current_Private_Virtual_Final_New_get_TElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.PointerToValueGeneric<TElement>(intPtr, false, true);
					}
				}

				// Token: 0x0600031B RID: 795 RVA: 0x0000F764 File Offset: 0x0000D964
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363470, XrefRangeEnd = 363475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170000DB RID: 219
				// (get) Token: 0x0600031C RID: 796 RVA: 0x0000F798 File Offset: 0x0000D998
				public unsafe Object System.Collections.IEnumerator.Current
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600031D RID: 797 RVA: 0x000034FC File Offset: 0x000016FC
				public _GetEnumerator_d__7(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x170000D6 RID: 214
				// (get) Token: 0x0600031E RID: 798 RVA: 0x0000F7D8 File Offset: 0x0000D9D8
				// (set) Token: 0x0600031F RID: 799 RVA: 0x00003505 File Offset: 0x00001705
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170000D7 RID: 215
				// (get) Token: 0x06000320 RID: 800 RVA: 0x0000F800 File Offset: 0x0000DA00
				// (set) Token: 0x06000321 RID: 801 RVA: 0x0000F828 File Offset: 0x0000DA28
				public unsafe TElement __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7.NativeFieldInfoPtr___2__current);
						return IL2CPP.PointerToValueGeneric<TElement>(intPtr, true, false);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7.NativeFieldInfoPtr___2__current);
						Type typeFromHandle = typeof(TElement);
						if (!typeFromHandle.IsValueType)
						{
							if (!string.Equals(typeFromHandle.FullName, "System.String"))
							{
								IntPtr intPtr4;
								IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
								if (intPtr3 != 0)
								{
									intPtr4 = intPtr3;
									if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
									{
										IntPtr intPtr5 = intPtr3;
										cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
										return;
									}
								}
								IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
							}
							else
							{
								IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
							}
						}
						else
						{
							*intPtr2 = value;
						}
					}
				}

				// Token: 0x170000D8 RID: 216
				// (get) Token: 0x06000322 RID: 802 RVA: 0x0000F8D0 File Offset: 0x0000DAD0
				// (set) Token: 0x06000323 RID: 803 RVA: 0x00003520 File Offset: 0x00001720
				public unsafe Lookup<TKey, TElement>.Grouping __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Lookup<TKey, TElement>.Grouping>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170000D9 RID: 217
				// (get) Token: 0x06000324 RID: 804 RVA: 0x0000F900 File Offset: 0x0000DB00
				// (set) Token: 0x06000325 RID: 805 RVA: 0x0000353F File Offset: 0x0000173F
				public unsafe int _i_5__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7.NativeFieldInfoPtr__i_5__1);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7.NativeFieldInfoPtr__i_5__1)) = value;
					}
				}

				// Token: 0x0400024C RID: 588
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400024D RID: 589
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400024E RID: 590
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400024F RID: 591
				private static readonly IntPtr NativeFieldInfoPtr__i_5__1;

				// Token: 0x04000250 RID: 592
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04000251 RID: 593
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04000252 RID: 594
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04000253 RID: 595
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TElement__get_Current_Private_Virtual_Final_New_get_TElement_0;

				// Token: 0x04000254 RID: 596
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04000255 RID: 597
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000054 RID: 84
		[ObfuscatedName("System.Linq.Lookup`2+<GetEnumerator>d__12")]
		public sealed class _GetEnumerator_d__12 : Object
		{
			// Token: 0x060002B6 RID: 694 RVA: 0x0000E238 File Offset: 0x0000C438
			// Note: this type is marked as 'beforefieldinit'.
			static _GetEnumerator_d__12()
			{
				Il2CppClassPointerStore<Lookup<TKey, TElement>._GetEnumerator_d__12>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Lookup<TKey, TElement>>.NativeClassPtr, "<GetEnumerator>d__12"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Lookup<TKey, TElement>._GetEnumerator_d__12>.NativeClassPtr);
				Lookup<TKey, TElement>._GetEnumerator_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lookup<TKey, TElement>._GetEnumerator_d__12>.NativeClassPtr, "<>1__state");
				Lookup<TKey, TElement>._GetEnumerator_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lookup<TKey, TElement>._GetEnumerator_d__12>.NativeClassPtr, "<>2__current");
				Lookup<TKey, TElement>._GetEnumerator_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lookup<TKey, TElement>._GetEnumerator_d__12>.NativeClassPtr, "<>4__this");
				Lookup<TKey, TElement>._GetEnumerator_d__12.NativeFieldInfoPtr__g_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lookup<TKey, TElement>._GetEnumerator_d__12>.NativeClassPtr, "<g>5__1");
				Lookup<TKey, TElement>._GetEnumerator_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>._GetEnumerator_d__12>.NativeClassPtr, 100663515);
				Lookup<TKey, TElement>._GetEnumerator_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>._GetEnumerator_d__12>.NativeClassPtr, 100663516);
				Lookup<TKey, TElement>._GetEnumerator_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>._GetEnumerator_d__12>.NativeClassPtr, 100663517);
				Lookup<TKey, TElement>._GetEnumerator_d__12.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_IGrouping_2_TKey_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>._GetEnumerator_d__12>.NativeClassPtr, 100663518);
				Lookup<TKey, TElement>._GetEnumerator_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>._GetEnumerator_d__12>.NativeClassPtr, 100663519);
				Lookup<TKey, TElement>._GetEnumerator_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>._GetEnumerator_d__12>.NativeClassPtr, 100663520);
			}

			// Token: 0x060002B7 RID: 695 RVA: 0x0000E378 File Offset: 0x0000C578
			[CallerCount(0)]
			public unsafe _GetEnumerator_d__12(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Lookup<TKey, TElement>._GetEnumerator_d__12>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>._GetEnumerator_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060002B8 RID: 696 RVA: 0x0000E3C0 File Offset: 0x0000C5C0
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>._GetEnumerator_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002B9 RID: 697 RVA: 0x0000E3F4 File Offset: 0x0000C5F4
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>._GetEnumerator_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170000BF RID: 191
			// (get) Token: 0x060002BA RID: 698 RVA: 0x0000E430 File Offset: 0x0000C630
			public unsafe IGrouping<TKey, TElement> prop_IGrouping_2_TKey_TElement_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>._GetEnumerator_d__12.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_IGrouping_2_TKey_TElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IGrouping<TKey, TElement>>(intPtr3) : null;
				}
			}

			// Token: 0x060002BB RID: 699 RVA: 0x0000E470 File Offset: 0x0000C670
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363498, XrefRangeEnd = 363503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>._GetEnumerator_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000C0 RID: 192
			// (get) Token: 0x060002BC RID: 700 RVA: 0x0000E4A4 File Offset: 0x0000C6A4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>._GetEnumerator_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060002BD RID: 701 RVA: 0x00003193 File Offset: 0x00001393
			public _GetEnumerator_d__12(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000BB RID: 187
			// (get) Token: 0x060002BE RID: 702 RVA: 0x0000E4E4 File Offset: 0x0000C6E4
			// (set) Token: 0x060002BF RID: 703 RVA: 0x0000319C File Offset: 0x0000139C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>._GetEnumerator_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>._GetEnumerator_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000BC RID: 188
			// (get) Token: 0x060002C0 RID: 704 RVA: 0x0000E50C File Offset: 0x0000C70C
			// (set) Token: 0x060002C1 RID: 705 RVA: 0x000031B7 File Offset: 0x000013B7
			public unsafe IGrouping<TKey, TElement> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>._GetEnumerator_d__12.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGrouping<TKey, TElement>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>._GetEnumerator_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000BD RID: 189
			// (get) Token: 0x060002C2 RID: 706 RVA: 0x0000E53C File Offset: 0x0000C73C
			// (set) Token: 0x060002C3 RID: 707 RVA: 0x000031D6 File Offset: 0x000013D6
			public unsafe Lookup<TKey, TElement> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>._GetEnumerator_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Lookup<TKey, TElement>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>._GetEnumerator_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000BE RID: 190
			// (get) Token: 0x060002C4 RID: 708 RVA: 0x0000E56C File Offset: 0x0000C76C
			// (set) Token: 0x060002C5 RID: 709 RVA: 0x000031F5 File Offset: 0x000013F5
			public unsafe Lookup<TKey, TElement>.Grouping _g_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>._GetEnumerator_d__12.NativeFieldInfoPtr__g_5__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Lookup<TKey, TElement>.Grouping>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>._GetEnumerator_d__12.NativeFieldInfoPtr__g_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400021C RID: 540
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400021D RID: 541
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400021E RID: 542
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400021F RID: 543
			private static readonly IntPtr NativeFieldInfoPtr__g_5__1;

			// Token: 0x04000220 RID: 544
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000221 RID: 545
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000222 RID: 546
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000223 RID: 547
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_IGrouping_2_TKey_TElement_0;

			// Token: 0x04000224 RID: 548
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000225 RID: 549
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000055 RID: 85
		private sealed class MethodInfoStoreGeneric_Create_Internal_Static_Lookup_2_TKey_TElement_IEnumerable_1_TSource_Func_2_TSource_TKey_Func_2_TSource_TElement_IEqualityComparer_1_TKey_0
		{
			// Token: 0x060002C6 RID: 710 RVA: 0x0000E59C File Offset: 0x0000C79C
			// Note: this type is marked as 'beforefieldinit'.
			static MethodInfoStoreGeneric_Create_Internal_Static_Lookup_2_TKey_TElement_IEnumerable_1_TSource_Func_2_TSource_TKey_Func_2_TSource_TElement_IEqualityComparer_1_TKey_0()
			{
				/*
An exception occurred when decompiling this method (060002C6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Il2CppSystem.Linq.Lookup`2/MethodInfoStoreGeneric_Create_Internal_Static_Lookup_2_TKey_TElement_IEnumerable_1_TSource_Func_2_TSource_TKey_Func_2_TSource_TElement_IEqualityComparer_1_TKey_0`1::.cctor()

 ---> System.ArgumentOutOfRangeException: Non-negative number required. (Parameter 'count')
   at System.Collections.Generic.List`1.GetRange(Int32 index, Int32 count)
   at ICSharpCode.Decompiler.Ast.AstBuilder.ApplyTypeArgumentsTo(AstType baseType, List`1 typeArguments) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 947
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(TypeSig type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 712
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(ITypeDefOrRef type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 817
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(ITypeDefOrRef type, StringBuilder sb, IHasCustomAttribute typeAttributes, ConvertTypeOptions options) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 666
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 881
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformNode(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 268
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformBlock(ILBlock block) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 252
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 150
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1686
*/;
			}

			// Token: 0x04000226 RID: 550
			internal static IntPtr Pointer;
		}
	}
}
