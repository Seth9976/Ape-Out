using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.Utils
{
	// Token: 0x020001E5 RID: 485
	public sealed class SafeAction<T> : SafeDelegate<Action<T>>
	{
		// Token: 0x06003177 RID: 12663 RVA: 0x000F5938 File Offset: 0x000F3B38
		// Note: this type is marked as 'beforefieldinit'.
		static SafeAction()
		{
			Il2CppClassPointerStore<SafeAction<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils", "SafeAction`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeAction<T>>.NativeClassPtr);
			SafeAction<T>.NativeFieldInfoPtr_gWfsLHmVjBrPGPYzUOZDaKhbKHa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeAction<T>>.NativeClassPtr, "gWfsLHmVjBrPGPYzUOZDaKhbKHa");
			SafeAction<T>.NativeFieldInfoPtr_gBHYUjlrgPpCcxohnMBNikgNzss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeAction<T>>.NativeClassPtr, "gBHYUjlrgPpCcxohnMBNikgNzss");
			SafeAction<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeAction<T>>.NativeClassPtr, 100675838);
			SafeAction<T>.NativeMethodInfoPtr__ctor_Public_Void_Action_1_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeAction<T>>.NativeClassPtr, 100675839);
			SafeAction<T>.NativeMethodInfoPtr__ctor_Protected_Void_SafeAction_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeAction<T>>.NativeClassPtr, 100675840);
			SafeAction<T>.NativeMethodInfoPtr_Invoke_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeAction<T>>.NativeClassPtr, 100675841);
			SafeAction<T>.NativeMethodInfoPtr_Clone_Public_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeAction<T>>.NativeClassPtr, 100675842);
			SafeAction<T>.NativeMethodInfoPtr_get_invokeDelegate_Private_Static_get_Action_2_Object_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeAction<T>>.NativeClassPtr, 100675843);
			SafeAction<T>.NativeMethodInfoPtr_IeDiRNoROqgJggMJIWRwJAkyOMlt_Private_Static_Void_Object_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeAction<T>>.NativeClassPtr, 100675844);
			SafeAction<T>.NativeMethodInfoPtr_op_Addition_Public_Static_SafeAction_1_T_SafeAction_1_T_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeAction<T>>.NativeClassPtr, 100675845);
			SafeAction<T>.NativeMethodInfoPtr_op_Subtraction_Public_Static_SafeAction_1_T_SafeAction_1_T_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeAction<T>>.NativeClassPtr, 100675846);
			SafeAction<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_Action_1_T_SafeAction_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeAction<T>>.NativeClassPtr, 100675847);
			SafeAction<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_SafeAction_1_T_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeAction<T>>.NativeClassPtr, 100675848);
		}

		// Token: 0x06003178 RID: 12664 RVA: 0x000F5AA8 File Offset: 0x000F3CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeAction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeAction<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeAction<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003179 RID: 12665 RVA: 0x000F5AE4 File Offset: 0x000F3CE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337186, XrefRangeEnd = 337187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeAction(Action<Exception> exceptionHandler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeAction<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exceptionHandler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeAction<T>.NativeMethodInfoPtr__ctor_Public_Void_Action_1_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600317A RID: 12666 RVA: 0x000F5B30 File Offset: 0x000F3D30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337187, XrefRangeEnd = 337188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeAction(SafeAction<T> source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeAction<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeAction<T>.NativeMethodInfoPtr__ctor_Protected_Void_SafeAction_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600317B RID: 12667 RVA: 0x000F5B7C File Offset: 0x000F3D7C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 337191, RefRangeEnd = 337203, XrefRangeStart = 337188, XrefRangeEnd = 337191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(T arg0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = arg0;
					if (!(t is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref arg0;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeAction<T>.NativeMethodInfoPtr_Invoke_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600317C RID: 12668 RVA: 0x000F5C0C File Offset: 0x000F3E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337203, XrefRangeEnd = 337205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeAction<T>.NativeMethodInfoPtr_Clone_Public_Virtual_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x17000F45 RID: 3909
		// (get) Token: 0x0600317D RID: 12669 RVA: 0x000F5C4C File Offset: 0x000F3E4C
		public unsafe static Action<Object, Action<T>> invokeDelegate
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337205, XrefRangeEnd = 337215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeAction<T>.NativeMethodInfoPtr_get_invokeDelegate_Private_Static_get_Action_2_Object_Action_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<Object, Action<T>>>(intPtr3) : null;
			}
		}

		// Token: 0x0600317E RID: 12670 RVA: 0x000F5C80 File Offset: 0x000F3E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337215, XrefRangeEnd = 337220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IeDiRNoROqgJggMJIWRwJAkyOMlt(Object A_0, Action<T> A_1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeAction<T>.NativeMethodInfoPtr_IeDiRNoROqgJggMJIWRwJAkyOMlt_Private_Static_Void_Object_Action_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600317F RID: 12671 RVA: 0x000F5CC8 File Offset: 0x000F3EC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337220, XrefRangeEnd = 337227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SafeAction<T>operator +(SafeAction<T> eventList, Action<T> listener)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listener);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeAction<T>.NativeMethodInfoPtr_op_Addition_Public_Static_SafeAction_1_T_SafeAction_1_T_Action_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SafeAction<T>>(intPtr3) : null;
		}

		// Token: 0x06003180 RID: 12672 RVA: 0x000F5D20 File Offset: 0x000F3F20
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 337229, RefRangeEnd = 337239, XrefRangeStart = 337227, XrefRangeEnd = 337229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SafeAction<T>operator -(SafeAction<T> eventList, Action<T> listener)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listener);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeAction<T>.NativeMethodInfoPtr_op_Subtraction_Public_Static_SafeAction_1_T_SafeAction_1_T_Action_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SafeAction<T>>(intPtr3) : null;
		}

		// Token: 0x06003181 RID: 12673 RVA: 0x000F5D78 File Offset: 0x000F3F78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337239, XrefRangeEnd = 337241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Action<T>(SafeAction<T> obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeAction<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_Action_1_T_SafeAction_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06003182 RID: 12674 RVA: 0x000F5DBC File Offset: 0x000F3FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337241, XrefRangeEnd = 337248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator SafeAction<T>(Action<T> obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeAction<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_SafeAction_1_T_Action_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SafeAction<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06003183 RID: 12675 RVA: 0x00011BD4 File Offset: 0x0000FDD4
		public SafeAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F43 RID: 3907
		// (get) Token: 0x06003184 RID: 12676 RVA: 0x000F5E00 File Offset: 0x000F4000
		// (set) Token: 0x06003185 RID: 12677 RVA: 0x000F5E28 File Offset: 0x000F4028
		public unsafe T gWfsLHmVjBrPGPYzUOZDaKhbKHa
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeAction<T>.NativeFieldInfoPtr_gWfsLHmVjBrPGPYzUOZDaKhbKHa);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeAction<T>.NativeFieldInfoPtr_gWfsLHmVjBrPGPYzUOZDaKhbKHa);
				Type typeFromHandle = typeof(T);
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

		// Token: 0x17000F44 RID: 3908
		// (get) Token: 0x06003186 RID: 12678 RVA: 0x000F5ED0 File Offset: 0x000F40D0
		// (set) Token: 0x06003187 RID: 12679 RVA: 0x00011BDD File Offset: 0x0000FDDD
		public unsafe static Action<Object, Action<T>> gBHYUjlrgPpCcxohnMBNikgNzss
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SafeAction<T>.NativeFieldInfoPtr_gBHYUjlrgPpCcxohnMBNikgNzss, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object, Action<T>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SafeAction<T>.NativeFieldInfoPtr_gBHYUjlrgPpCcxohnMBNikgNzss, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002A2B RID: 10795
		private static readonly IntPtr NativeFieldInfoPtr_gWfsLHmVjBrPGPYzUOZDaKhbKHa;

		// Token: 0x04002A2C RID: 10796
		private static readonly IntPtr NativeFieldInfoPtr_gBHYUjlrgPpCcxohnMBNikgNzss;

		// Token: 0x04002A2D RID: 10797
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002A2E RID: 10798
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Action_1_Exception_0;

		// Token: 0x04002A2F RID: 10799
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SafeAction_1_T_0;

		// Token: 0x04002A30 RID: 10800
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Void_T_0;

		// Token: 0x04002A31 RID: 10801
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Object_0;

		// Token: 0x04002A32 RID: 10802
		private static readonly IntPtr NativeMethodInfoPtr_get_invokeDelegate_Private_Static_get_Action_2_Object_Action_1_T_0;

		// Token: 0x04002A33 RID: 10803
		private static readonly IntPtr NativeMethodInfoPtr_IeDiRNoROqgJggMJIWRwJAkyOMlt_Private_Static_Void_Object_Action_1_T_0;

		// Token: 0x04002A34 RID: 10804
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_SafeAction_1_T_SafeAction_1_T_Action_1_T_0;

		// Token: 0x04002A35 RID: 10805
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_SafeAction_1_T_SafeAction_1_T_Action_1_T_0;

		// Token: 0x04002A36 RID: 10806
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Action_1_T_SafeAction_1_T_0;

		// Token: 0x04002A37 RID: 10807
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SafeAction_1_T_Action_1_T_0;
	}
}
