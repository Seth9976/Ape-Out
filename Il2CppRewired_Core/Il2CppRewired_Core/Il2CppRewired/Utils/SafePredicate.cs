using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.Utils
{
	// Token: 0x020001E8 RID: 488
	public class SafePredicate<T> : SafeDelegate<Predicate<T>>
	{
		// Token: 0x060031AE RID: 12718 RVA: 0x000F6CD8 File Offset: 0x000F4ED8
		// Note: this type is marked as 'beforefieldinit'.
		static SafePredicate()
		{
			Il2CppClassPointerStore<SafePredicate<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils", "SafePredicate`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafePredicate<T>>.NativeClassPtr);
			SafePredicate<T>.NativeFieldInfoPtr_gWfsLHmVjBrPGPYzUOZDaKhbKHa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafePredicate<T>>.NativeClassPtr, "gWfsLHmVjBrPGPYzUOZDaKhbKHa");
			SafePredicate<T>.NativeFieldInfoPtr_pFwvOIvykdgSWfyaPuAseUBSfsR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafePredicate<T>>.NativeClassPtr, "pFwvOIvykdgSWfyaPuAseUBSfsR");
			SafePredicate<T>.NativeFieldInfoPtr_gBHYUjlrgPpCcxohnMBNikgNzss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafePredicate<T>>.NativeClassPtr, "gBHYUjlrgPpCcxohnMBNikgNzss");
			SafePredicate<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafePredicate<T>>.NativeClassPtr, 100675871);
			SafePredicate<T>.NativeMethodInfoPtr__ctor_Public_Void_Action_1_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafePredicate<T>>.NativeClassPtr, 100675872);
			SafePredicate<T>.NativeMethodInfoPtr__ctor_Protected_Void_SafePredicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafePredicate<T>>.NativeClassPtr, 100675873);
			SafePredicate<T>.NativeMethodInfoPtr_Invoke_Public_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafePredicate<T>>.NativeClassPtr, 100675874);
			SafePredicate<T>.NativeMethodInfoPtr_Clone_Public_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafePredicate<T>>.NativeClassPtr, 100675875);
			SafePredicate<T>.NativeMethodInfoPtr_get_invokeDelegate_Private_Static_get_Action_2_Object_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafePredicate<T>>.NativeClassPtr, 100675876);
			SafePredicate<T>.NativeMethodInfoPtr_IeDiRNoROqgJggMJIWRwJAkyOMlt_Private_Static_Void_Object_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafePredicate<T>>.NativeClassPtr, 100675877);
			SafePredicate<T>.NativeMethodInfoPtr_op_Addition_Public_Static_SafePredicate_1_T_SafePredicate_1_T_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafePredicate<T>>.NativeClassPtr, 100675878);
			SafePredicate<T>.NativeMethodInfoPtr_op_Subtraction_Public_Static_SafePredicate_1_T_SafePredicate_1_T_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafePredicate<T>>.NativeClassPtr, 100675879);
			SafePredicate<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_Predicate_1_T_SafePredicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafePredicate<T>>.NativeClassPtr, 100675880);
			SafePredicate<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_SafePredicate_1_T_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafePredicate<T>>.NativeClassPtr, 100675881);
		}

		// Token: 0x060031AF RID: 12719 RVA: 0x000F6E5C File Offset: 0x000F505C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafePredicate()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafePredicate<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafePredicate<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031B0 RID: 12720 RVA: 0x000F6E98 File Offset: 0x000F5098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafePredicate(Action<Exception> exceptionHandler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafePredicate<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exceptionHandler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafePredicate<T>.NativeMethodInfoPtr__ctor_Public_Void_Action_1_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060031B1 RID: 12721 RVA: 0x000F6EE4 File Offset: 0x000F50E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafePredicate(SafePredicate<T> source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafePredicate<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafePredicate<T>.NativeMethodInfoPtr__ctor_Protected_Void_SafePredicate_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060031B2 RID: 12722 RVA: 0x000F6F30 File Offset: 0x000F5130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337265, XrefRangeEnd = 337269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Invoke(T arg0)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafePredicate<T>.NativeMethodInfoPtr_Invoke_Public_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060031B3 RID: 12723 RVA: 0x000F6FC8 File Offset: 0x000F51C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SafePredicate<T>.NativeMethodInfoPtr_Clone_Public_Virtual_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x17000F51 RID: 3921
		// (get) Token: 0x060031B4 RID: 12724 RVA: 0x000F7014 File Offset: 0x000F5214
		public unsafe static Action<Object, Predicate<T>> invokeDelegate
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafePredicate<T>.NativeMethodInfoPtr_get_invokeDelegate_Private_Static_get_Action_2_Object_Predicate_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<Object, Predicate<T>>>(intPtr3) : null;
			}
		}

		// Token: 0x060031B5 RID: 12725 RVA: 0x000F7048 File Offset: 0x000F5248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337269, XrefRangeEnd = 337274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IeDiRNoROqgJggMJIWRwJAkyOMlt(Object A_0, Predicate<T> A_1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafePredicate<T>.NativeMethodInfoPtr_IeDiRNoROqgJggMJIWRwJAkyOMlt_Private_Static_Void_Object_Predicate_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031B6 RID: 12726 RVA: 0x000F7090 File Offset: 0x000F5290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SafePredicate<T>operator +(SafePredicate<T> eventList, Predicate<T> predicate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafePredicate<T>.NativeMethodInfoPtr_op_Addition_Public_Static_SafePredicate_1_T_SafePredicate_1_T_Predicate_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SafePredicate<T>>(intPtr3) : null;
		}

		// Token: 0x060031B7 RID: 12727 RVA: 0x000F70E8 File Offset: 0x000F52E8
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 337229, RefRangeEnd = 337239, XrefRangeStart = 337229, XrefRangeEnd = 337239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SafePredicate<T>operator -(SafePredicate<T> eventList, Predicate<T> predicate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafePredicate<T>.NativeMethodInfoPtr_op_Subtraction_Public_Static_SafePredicate_1_T_SafePredicate_1_T_Predicate_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SafePredicate<T>>(intPtr3) : null;
		}

		// Token: 0x060031B8 RID: 12728 RVA: 0x000F7140 File Offset: 0x000F5340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Predicate<T>(SafePredicate<T> obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafePredicate<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_Predicate_1_T_SafePredicate_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Predicate<T>>(intPtr3) : null;
			}
		}

		// Token: 0x060031B9 RID: 12729 RVA: 0x000F7184 File Offset: 0x000F5384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator SafePredicate<T>(Predicate<T> obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafePredicate<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_SafePredicate_1_T_Predicate_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SafePredicate<T>>(intPtr3) : null;
			}
		}

		// Token: 0x060031BA RID: 12730 RVA: 0x00011C25 File Offset: 0x0000FE25
		public SafePredicate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F4E RID: 3918
		// (get) Token: 0x060031BB RID: 12731 RVA: 0x000F71C8 File Offset: 0x000F53C8
		// (set) Token: 0x060031BC RID: 12732 RVA: 0x000F71F0 File Offset: 0x000F53F0
		public unsafe T gWfsLHmVjBrPGPYzUOZDaKhbKHa
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafePredicate<T>.NativeFieldInfoPtr_gWfsLHmVjBrPGPYzUOZDaKhbKHa);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafePredicate<T>.NativeFieldInfoPtr_gWfsLHmVjBrPGPYzUOZDaKhbKHa);
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

		// Token: 0x17000F4F RID: 3919
		// (get) Token: 0x060031BD RID: 12733 RVA: 0x000F7298 File Offset: 0x000F5498
		// (set) Token: 0x060031BE RID: 12734 RVA: 0x00011C2E File Offset: 0x0000FE2E
		public unsafe bool pFwvOIvykdgSWfyaPuAseUBSfsR
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafePredicate<T>.NativeFieldInfoPtr_pFwvOIvykdgSWfyaPuAseUBSfsR);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafePredicate<T>.NativeFieldInfoPtr_pFwvOIvykdgSWfyaPuAseUBSfsR)) = value;
			}
		}

		// Token: 0x17000F50 RID: 3920
		// (get) Token: 0x060031BF RID: 12735 RVA: 0x000F72C0 File Offset: 0x000F54C0
		// (set) Token: 0x060031C0 RID: 12736 RVA: 0x00011C49 File Offset: 0x0000FE49
		public unsafe static Action<Object, Predicate<T>> gBHYUjlrgPpCcxohnMBNikgNzss
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SafePredicate<T>.NativeFieldInfoPtr_gBHYUjlrgPpCcxohnMBNikgNzss, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object, Predicate<T>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SafePredicate<T>.NativeFieldInfoPtr_gBHYUjlrgPpCcxohnMBNikgNzss, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002A54 RID: 10836
		private static readonly IntPtr NativeFieldInfoPtr_gWfsLHmVjBrPGPYzUOZDaKhbKHa;

		// Token: 0x04002A55 RID: 10837
		private static readonly IntPtr NativeFieldInfoPtr_pFwvOIvykdgSWfyaPuAseUBSfsR;

		// Token: 0x04002A56 RID: 10838
		private static readonly IntPtr NativeFieldInfoPtr_gBHYUjlrgPpCcxohnMBNikgNzss;

		// Token: 0x04002A57 RID: 10839
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002A58 RID: 10840
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Action_1_Exception_0;

		// Token: 0x04002A59 RID: 10841
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SafePredicate_1_T_0;

		// Token: 0x04002A5A RID: 10842
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Boolean_T_0;

		// Token: 0x04002A5B RID: 10843
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Object_0;

		// Token: 0x04002A5C RID: 10844
		private static readonly IntPtr NativeMethodInfoPtr_get_invokeDelegate_Private_Static_get_Action_2_Object_Predicate_1_T_0;

		// Token: 0x04002A5D RID: 10845
		private static readonly IntPtr NativeMethodInfoPtr_IeDiRNoROqgJggMJIWRwJAkyOMlt_Private_Static_Void_Object_Predicate_1_T_0;

		// Token: 0x04002A5E RID: 10846
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_SafePredicate_1_T_SafePredicate_1_T_Predicate_1_T_0;

		// Token: 0x04002A5F RID: 10847
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_SafePredicate_1_T_SafePredicate_1_T_Predicate_1_T_0;

		// Token: 0x04002A60 RID: 10848
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Predicate_1_T_SafePredicate_1_T_0;

		// Token: 0x04002A61 RID: 10849
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SafePredicate_1_T_Predicate_1_T_0;
	}
}
