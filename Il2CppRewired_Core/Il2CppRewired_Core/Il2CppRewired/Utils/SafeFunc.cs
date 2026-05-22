using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.Utils
{
	// Token: 0x020001E7 RID: 487
	public class SafeFunc<T, TResult> : SafeDelegate<Func<T, TResult>>
	{
		// Token: 0x0600319B RID: 12699 RVA: 0x000F660C File Offset: 0x000F480C
		// Note: this type is marked as 'beforefieldinit'.
		static SafeFunc()
		{
			Il2CppClassPointerStore<SafeFunc<T, TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils", "SafeFunc`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeFunc<T, TResult>>.NativeClassPtr);
			SafeFunc<T, TResult>.NativeFieldInfoPtr_gWfsLHmVjBrPGPYzUOZDaKhbKHa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeFunc<T, TResult>>.NativeClassPtr, "gWfsLHmVjBrPGPYzUOZDaKhbKHa");
			SafeFunc<T, TResult>.NativeFieldInfoPtr_pFwvOIvykdgSWfyaPuAseUBSfsR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeFunc<T, TResult>>.NativeClassPtr, "pFwvOIvykdgSWfyaPuAseUBSfsR");
			SafeFunc<T, TResult>.NativeFieldInfoPtr_gBHYUjlrgPpCcxohnMBNikgNzss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeFunc<T, TResult>>.NativeClassPtr, "gBHYUjlrgPpCcxohnMBNikgNzss");
			SafeFunc<T, TResult>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeFunc<T, TResult>>.NativeClassPtr, 100675860);
			SafeFunc<T, TResult>.NativeMethodInfoPtr__ctor_Public_Void_Action_1_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeFunc<T, TResult>>.NativeClassPtr, 100675861);
			SafeFunc<T, TResult>.NativeMethodInfoPtr__ctor_Protected_Void_SafeFunc_2_T_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeFunc<T, TResult>>.NativeClassPtr, 100675862);
			SafeFunc<T, TResult>.NativeMethodInfoPtr_Invoke_Public_TResult_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeFunc<T, TResult>>.NativeClassPtr, 100675863);
			SafeFunc<T, TResult>.NativeMethodInfoPtr_Clone_Public_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeFunc<T, TResult>>.NativeClassPtr, 100675864);
			SafeFunc<T, TResult>.NativeMethodInfoPtr_get_invokeDelegate_Private_Static_get_Action_2_Object_Func_2_T_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeFunc<T, TResult>>.NativeClassPtr, 100675865);
			SafeFunc<T, TResult>.NativeMethodInfoPtr_IeDiRNoROqgJggMJIWRwJAkyOMlt_Private_Static_Void_Object_Func_2_T_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeFunc<T, TResult>>.NativeClassPtr, 100675866);
			SafeFunc<T, TResult>.NativeMethodInfoPtr_op_Addition_Public_Static_SafeFunc_2_T_TResult_SafeFunc_2_T_TResult_Func_2_T_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeFunc<T, TResult>>.NativeClassPtr, 100675867);
			SafeFunc<T, TResult>.NativeMethodInfoPtr_op_Subtraction_Public_Static_SafeFunc_2_T_TResult_SafeFunc_2_T_TResult_Func_2_T_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeFunc<T, TResult>>.NativeClassPtr, 100675868);
			SafeFunc<T, TResult>.NativeMethodInfoPtr_op_Implicit_Public_Static_Func_2_T_TResult_SafeFunc_2_T_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeFunc<T, TResult>>.NativeClassPtr, 100675869);
			SafeFunc<T, TResult>.NativeMethodInfoPtr_op_Implicit_Public_Static_SafeFunc_2_T_TResult_Func_2_T_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeFunc<T, TResult>>.NativeClassPtr, 100675870);
		}

		// Token: 0x0600319C RID: 12700 RVA: 0x000F67A4 File Offset: 0x000F49A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeFunc()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeFunc<T, TResult>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeFunc<T, TResult>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600319D RID: 12701 RVA: 0x000F67E0 File Offset: 0x000F49E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeFunc(Action<Exception> exceptionHandler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeFunc<T, TResult>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exceptionHandler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeFunc<T, TResult>.NativeMethodInfoPtr__ctor_Public_Void_Action_1_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600319E RID: 12702 RVA: 0x000F682C File Offset: 0x000F4A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeFunc(SafeFunc<T, TResult> source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeFunc<T, TResult>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeFunc<T, TResult>.NativeMethodInfoPtr__ctor_Protected_Void_SafeFunc_2_T_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600319F RID: 12703 RVA: 0x000F6878 File Offset: 0x000F4A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337256, XrefRangeEnd = 337260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TResult Invoke(T arg0)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeFunc<T, TResult>.NativeMethodInfoPtr_Invoke_Public_TResult_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TResult>(intPtr, false, true);
			}
		}

		// Token: 0x060031A0 RID: 12704 RVA: 0x000F6910 File Offset: 0x000F4B10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SafeFunc<T, TResult>.NativeMethodInfoPtr_Clone_Public_Virtual_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x17000F4D RID: 3917
		// (get) Token: 0x060031A1 RID: 12705 RVA: 0x000F695C File Offset: 0x000F4B5C
		public unsafe static Action<Object, Func<T, TResult>> invokeDelegate
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeFunc<T, TResult>.NativeMethodInfoPtr_get_invokeDelegate_Private_Static_get_Action_2_Object_Func_2_T_TResult_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<Object, Func<T, TResult>>>(intPtr3) : null;
			}
		}

		// Token: 0x060031A2 RID: 12706 RVA: 0x000F6990 File Offset: 0x000F4B90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337260, XrefRangeEnd = 337265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IeDiRNoROqgJggMJIWRwJAkyOMlt(Object A_0, Func<T, TResult> A_1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeFunc<T, TResult>.NativeMethodInfoPtr_IeDiRNoROqgJggMJIWRwJAkyOMlt_Private_Static_Void_Object_Func_2_T_TResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031A3 RID: 12707 RVA: 0x000F69D8 File Offset: 0x000F4BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SafeFunc<T, TResult>operator +(SafeFunc<T, TResult> eventList, Func<T, TResult> func)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(func);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeFunc<T, TResult>.NativeMethodInfoPtr_op_Addition_Public_Static_SafeFunc_2_T_TResult_SafeFunc_2_T_TResult_Func_2_T_TResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SafeFunc<T, TResult>>(intPtr3) : null;
		}

		// Token: 0x060031A4 RID: 12708 RVA: 0x000F6A30 File Offset: 0x000F4C30
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 337229, RefRangeEnd = 337239, XrefRangeStart = 337229, XrefRangeEnd = 337239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SafeFunc<T, TResult>operator -(SafeFunc<T, TResult> eventList, Func<T, TResult> func)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(func);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeFunc<T, TResult>.NativeMethodInfoPtr_op_Subtraction_Public_Static_SafeFunc_2_T_TResult_SafeFunc_2_T_TResult_Func_2_T_TResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SafeFunc<T, TResult>>(intPtr3) : null;
		}

		// Token: 0x060031A5 RID: 12709 RVA: 0x000F6A88 File Offset: 0x000F4C88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Func<T, TResult>(SafeFunc<T, TResult> obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeFunc<T, TResult>.NativeMethodInfoPtr_op_Implicit_Public_Static_Func_2_T_TResult_SafeFunc_2_T_TResult_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<T, TResult>>(intPtr3) : null;
			}
		}

		// Token: 0x060031A6 RID: 12710 RVA: 0x000F6ACC File Offset: 0x000F4CCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator SafeFunc<T, TResult>(Func<T, TResult> obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeFunc<T, TResult>.NativeMethodInfoPtr_op_Implicit_Public_Static_SafeFunc_2_T_TResult_Func_2_T_TResult_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SafeFunc<T, TResult>>(intPtr3) : null;
			}
		}

		// Token: 0x060031A7 RID: 12711 RVA: 0x00011C0A File Offset: 0x0000FE0A
		public SafeFunc(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F4A RID: 3914
		// (get) Token: 0x060031A8 RID: 12712 RVA: 0x000F6B10 File Offset: 0x000F4D10
		// (set) Token: 0x060031A9 RID: 12713 RVA: 0x000F6B38 File Offset: 0x000F4D38
		public unsafe T gWfsLHmVjBrPGPYzUOZDaKhbKHa
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeFunc<T, TResult>.NativeFieldInfoPtr_gWfsLHmVjBrPGPYzUOZDaKhbKHa);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeFunc<T, TResult>.NativeFieldInfoPtr_gWfsLHmVjBrPGPYzUOZDaKhbKHa);
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

		// Token: 0x17000F4B RID: 3915
		// (get) Token: 0x060031AA RID: 12714 RVA: 0x000F6BE0 File Offset: 0x000F4DE0
		// (set) Token: 0x060031AB RID: 12715 RVA: 0x000F6C08 File Offset: 0x000F4E08
		public unsafe TResult pFwvOIvykdgSWfyaPuAseUBSfsR
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeFunc<T, TResult>.NativeFieldInfoPtr_pFwvOIvykdgSWfyaPuAseUBSfsR);
				return IL2CPP.PointerToValueGeneric<TResult>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeFunc<T, TResult>.NativeFieldInfoPtr_pFwvOIvykdgSWfyaPuAseUBSfsR);
				Type typeFromHandle = typeof(TResult);
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

		// Token: 0x17000F4C RID: 3916
		// (get) Token: 0x060031AC RID: 12716 RVA: 0x000F6CB0 File Offset: 0x000F4EB0
		// (set) Token: 0x060031AD RID: 12717 RVA: 0x00011C13 File Offset: 0x0000FE13
		public unsafe static Action<Object, Func<T, TResult>> gBHYUjlrgPpCcxohnMBNikgNzss
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SafeFunc<T, TResult>.NativeFieldInfoPtr_gBHYUjlrgPpCcxohnMBNikgNzss, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object, Func<T, TResult>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SafeFunc<T, TResult>.NativeFieldInfoPtr_gBHYUjlrgPpCcxohnMBNikgNzss, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002A46 RID: 10822
		private static readonly IntPtr NativeFieldInfoPtr_gWfsLHmVjBrPGPYzUOZDaKhbKHa;

		// Token: 0x04002A47 RID: 10823
		private static readonly IntPtr NativeFieldInfoPtr_pFwvOIvykdgSWfyaPuAseUBSfsR;

		// Token: 0x04002A48 RID: 10824
		private static readonly IntPtr NativeFieldInfoPtr_gBHYUjlrgPpCcxohnMBNikgNzss;

		// Token: 0x04002A49 RID: 10825
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002A4A RID: 10826
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Action_1_Exception_0;

		// Token: 0x04002A4B RID: 10827
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SafeFunc_2_T_TResult_0;

		// Token: 0x04002A4C RID: 10828
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_TResult_T_0;

		// Token: 0x04002A4D RID: 10829
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Object_0;

		// Token: 0x04002A4E RID: 10830
		private static readonly IntPtr NativeMethodInfoPtr_get_invokeDelegate_Private_Static_get_Action_2_Object_Func_2_T_TResult_0;

		// Token: 0x04002A4F RID: 10831
		private static readonly IntPtr NativeMethodInfoPtr_IeDiRNoROqgJggMJIWRwJAkyOMlt_Private_Static_Void_Object_Func_2_T_TResult_0;

		// Token: 0x04002A50 RID: 10832
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_SafeFunc_2_T_TResult_SafeFunc_2_T_TResult_Func_2_T_TResult_0;

		// Token: 0x04002A51 RID: 10833
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_SafeFunc_2_T_TResult_SafeFunc_2_T_TResult_Func_2_T_TResult_0;

		// Token: 0x04002A52 RID: 10834
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Func_2_T_TResult_SafeFunc_2_T_TResult_0;

		// Token: 0x04002A53 RID: 10835
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SafeFunc_2_T_TResult_Func_2_T_TResult_0;
	}
}
