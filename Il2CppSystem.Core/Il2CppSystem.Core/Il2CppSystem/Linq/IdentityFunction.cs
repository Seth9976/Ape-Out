using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq
{
	// Token: 0x02000009 RID: 9
	public class IdentityFunction<TElement> : Object
	{
		// Token: 0x06000086 RID: 134 RVA: 0x00005B58 File Offset: 0x00003D58
		// Note: this type is marked as 'beforefieldinit'.
		static IdentityFunction()
		{
			Il2CppClassPointerStore<IdentityFunction<TElement>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq", "IdentityFunction`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IdentityFunction<TElement>>.NativeClassPtr);
			IdentityFunction<TElement>.NativeMethodInfoPtr_get_Instance_Public_Static_get_Func_2_TElement_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdentityFunction<TElement>>.NativeClassPtr, 100663479);
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00005BD8 File Offset: 0x00003DD8
		public unsafe static Func<TElement, TElement> Instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363443, XrefRangeEnd = 363469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdentityFunction<TElement>.NativeMethodInfoPtr_get_Instance_Public_Static_get_Func_2_TElement_TElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<TElement, TElement>>(intPtr3) : null;
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000021DB File Offset: 0x000003DB
		public IdentityFunction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_Func_2_TElement_TElement_0;

		// Token: 0x02000051 RID: 81
		[ObfuscatedName("System.Linq.IdentityFunction`1+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600028E RID: 654 RVA: 0x0000D580 File Offset: 0x0000B780
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<IdentityFunction<TElement>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IdentityFunction<TElement>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IdentityFunction<TElement>.__c>.NativeClassPtr);
				IdentityFunction<TElement>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdentityFunction<TElement>.__c>.NativeClassPtr, "<>9");
				IdentityFunction<TElement>.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdentityFunction<TElement>.__c>.NativeClassPtr, "<>9__1_0");
				IdentityFunction<TElement>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdentityFunction<TElement>.__c>.NativeClassPtr, 100663481);
				IdentityFunction<TElement>.__c.NativeMethodInfoPtr__get_Instance_b__1_0_Internal_TElement_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdentityFunction<TElement>.__c>.NativeClassPtr, 100663482);
			}

			// Token: 0x0600028F RID: 655 RVA: 0x0000D638 File Offset: 0x0000B838
			[CallerCount(0)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IdentityFunction<TElement>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdentityFunction<TElement>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000290 RID: 656 RVA: 0x0000D674 File Offset: 0x0000B874
			[CallerCount(0)]
			public unsafe TElement _get_Instance_b__1_0(TElement x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					IntPtr* ptr2 = ptr;
					ref TElement ptr4;
					if (!typeof(TElement).IsValueType)
					{
						TElement telement = x;
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
						ptr4 = ref x;
					}
					*ptr2 = ref ptr4;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdentityFunction<TElement>.__c.NativeMethodInfoPtr__get_Instance_b__1_0_Internal_TElement_TElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TElement>(intPtr, false, true);
				}
			}

			// Token: 0x06000291 RID: 657 RVA: 0x000030CA File Offset: 0x000012CA
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000AF RID: 175
			// (get) Token: 0x06000292 RID: 658 RVA: 0x0000D70C File Offset: 0x0000B90C
			// (set) Token: 0x06000293 RID: 659 RVA: 0x000030D3 File Offset: 0x000012D3
			public unsafe static IdentityFunction<TElement>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IdentityFunction<TElement>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IdentityFunction<TElement>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IdentityFunction<TElement>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000B0 RID: 176
			// (get) Token: 0x06000294 RID: 660 RVA: 0x0000D734 File Offset: 0x0000B934
			// (set) Token: 0x06000295 RID: 661 RVA: 0x000030E5 File Offset: 0x000012E5
			public unsafe static Func<TElement, TElement> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IdentityFunction<TElement>.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TElement, TElement>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IdentityFunction<TElement>.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000200 RID: 512
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000201 RID: 513
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x04000202 RID: 514
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000203 RID: 515
			private static readonly IntPtr NativeMethodInfoPtr__get_Instance_b__1_0_Internal_TElement_TElement_0;
		}
	}
}
