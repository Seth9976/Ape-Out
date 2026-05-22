using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppRewired.Utils
{
	// Token: 0x020001E3 RID: 483
	public class SafeDelegate<T> : SafeDelegate where T : class
	{
		// Token: 0x0600314E RID: 12622 RVA: 0x000F4C08 File Offset: 0x000F2E08
		// Note: this type is marked as 'beforefieldinit'.
		static SafeDelegate()
		{
			Il2CppClassPointerStore<SafeDelegate<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils", "SafeDelegate`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeDelegate<T>>.NativeClassPtr);
			SafeDelegate<T>.NativeFieldInfoPtr_YQmFurxPQGCzcbiDCAoJoXFxRCn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeDelegate<T>>.NativeClassPtr, "YQmFurxPQGCzcbiDCAoJoXFxRCn");
			SafeDelegate<T>.NativeFieldInfoPtr_oawLRBBaxebqpNQHfAKiHDclmZJf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeDelegate<T>>.NativeClassPtr, "oawLRBBaxebqpNQHfAKiHDclmZJf");
			SafeDelegate<T>.NativeFieldInfoPtr_xrvUXpzFjXHLwyyxZARQvpgcOIZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeDelegate<T>>.NativeClassPtr, "xrvUXpzFjXHLwyyxZARQvpgcOIZ");
			SafeDelegate<T>.NativeMethodInfoPtr_get_Count_Internal_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeDelegate<T>>.NativeClassPtr, 100675806);
			SafeDelegate<T>.NativeMethodInfoPtr_get_ExceptionHandler_Internal_Virtual_get_Action_1_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeDelegate<T>>.NativeClassPtr, 100675807);
			SafeDelegate<T>.NativeMethodInfoPtr_set_ExceptionHandler_Internal_Virtual_set_Void_Action_1_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeDelegate<T>>.NativeClassPtr, 100675808);
			SafeDelegate<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeDelegate<T>>.NativeClassPtr, 100675809);
			SafeDelegate<T>.NativeMethodInfoPtr__ctor_Protected_Void_Action_1_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeDelegate<T>>.NativeClassPtr, 100675810);
			SafeDelegate<T>.NativeMethodInfoPtr__ctor_Protected_Void_SafeDelegate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeDelegate<T>>.NativeClassPtr, 100675811);
			SafeDelegate<T>.NativeMethodInfoPtr_AddDelegate_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeDelegate<T>>.NativeClassPtr, 100675812);
			SafeDelegate<T>.NativeMethodInfoPtr_RemoveDelegate_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeDelegate<T>>.NativeClassPtr, 100675813);
			SafeDelegate<T>.NativeMethodInfoPtr_RemoveDelegateOrAllDelegatesFromAnObject_Internal_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeDelegate<T>>.NativeClassPtr, 100675814);
			SafeDelegate<T>.NativeMethodInfoPtr_Clear_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeDelegate<T>>.NativeClassPtr, 100675815);
			SafeDelegate<T>.NativeMethodInfoPtr_Invoke_Protected_Void_Action_2_Object_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeDelegate<T>>.NativeClassPtr, 100675816);
			SafeDelegate<T>.NativeMethodInfoPtr_GetCombinedDelegate_Protected_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeDelegate<T>>.NativeClassPtr, 100675817);
			SafeDelegate<T>.NativeMethodInfoPtr_pqUmJgCiRbkfcUyrXIMmpKcRSDB_Private_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeDelegate<T>>.NativeClassPtr, 100675818);
			SafeDelegate<T>.NativeMethodInfoPtr_toLEPoWuMDQZlYmjvpYldRbMVym_Private_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeDelegate<T>>.NativeClassPtr, 100675819);
			SafeDelegate<T>.NativeMethodInfoPtr_GZqQQaGDLliavCqmVrEaVRZoPujR_Private_Static_Delegate_Object_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeDelegate<T>>.NativeClassPtr, 100675820);
			SafeDelegate<T>.NativeMethodInfoPtr_GZqQQaGDLliavCqmVrEaVRZoPujR_Private_Static_Delegate_Delegate_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeDelegate<T>>.NativeClassPtr, 100675821);
			SafeDelegate<T>.NativeMethodInfoPtr_MCSkDmNKFEwDJPokiDIzuaFUvgG_Private_Static_Int32_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeDelegate<T>>.NativeClassPtr, 100675822);
			SafeDelegate<T>.NativeMethodInfoPtr_SwmgMMcOPQkkbDavZfmBbYsPaFg_Private_Static_List_1_Delegate_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeDelegate<T>>.NativeClassPtr, 100675823);
		}

		// Token: 0x17000F3F RID: 3903
		// (get) Token: 0x0600314F RID: 12623 RVA: 0x000F4E18 File Offset: 0x000F3018
		public unsafe override int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336953, XrefRangeEnd = 336954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SafeDelegate<T>.NativeMethodInfoPtr_get_Count_Internal_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F40 RID: 3904
		// (get) Token: 0x06003150 RID: 12624 RVA: 0x000F4E60 File Offset: 0x000F3060
		// (set) Token: 0x06003151 RID: 12625 RVA: 0x000F4EAC File Offset: 0x000F30AC
		public unsafe override Action<Exception> ExceptionHandler
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SafeDelegate<T>.NativeMethodInfoPtr_get_ExceptionHandler_Internal_Virtual_get_Action_1_Exception_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<Exception>>(intPtr3) : null;
			}
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SafeDelegate<T>.NativeMethodInfoPtr_set_ExceptionHandler_Internal_Virtual_set_Void_Action_1_Exception_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003152 RID: 12626 RVA: 0x000F4EFC File Offset: 0x000F30FC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 336968, RefRangeEnd = 336977, XrefRangeStart = 336954, XrefRangeEnd = 336968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeDelegate()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeDelegate<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeDelegate<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003153 RID: 12627 RVA: 0x000F4F38 File Offset: 0x000F3138
		[CallerCount(0)]
		public unsafe SafeDelegate(Action<Exception> exceptionHandler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeDelegate<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exceptionHandler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeDelegate<T>.NativeMethodInfoPtr__ctor_Protected_Void_Action_1_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003154 RID: 12628 RVA: 0x000F4F84 File Offset: 0x000F3184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336977, XrefRangeEnd = 336981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeDelegate(SafeDelegate<T> source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeDelegate<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeDelegate<T>.NativeMethodInfoPtr__ctor_Protected_Void_SafeDelegate_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003155 RID: 12629 RVA: 0x000F4FD0 File Offset: 0x000F31D0
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 336992, RefRangeEnd = 337002, XrefRangeStart = 336981, XrefRangeEnd = 336992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddDelegate(T @delegate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = @delegate;
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
					ptr4 = ref @delegate;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeDelegate<T>.NativeMethodInfoPtr_AddDelegate_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003156 RID: 12630 RVA: 0x000F5060 File Offset: 0x000F3260
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 337011, RefRangeEnd = 337020, XrefRangeStart = 337002, XrefRangeEnd = 337011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveDelegate(T @delegate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = @delegate;
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
					ptr4 = ref @delegate;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeDelegate<T>.NativeMethodInfoPtr_RemoveDelegate_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003157 RID: 12631 RVA: 0x000F50F0 File Offset: 0x000F32F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337020, XrefRangeEnd = 337033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RemoveDelegateOrAllDelegatesFromAnObject(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SafeDelegate<T>.NativeMethodInfoPtr_RemoveDelegateOrAllDelegatesFromAnObject_Internal_Virtual_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003158 RID: 12632 RVA: 0x000F5140 File Offset: 0x000F3340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337033, XrefRangeEnd = 337034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SafeDelegate<T>.NativeMethodInfoPtr_Clear_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003159 RID: 12633 RVA: 0x000F517C File Offset: 0x000F337C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 337054, RefRangeEnd = 337055, XrefRangeStart = 337034, XrefRangeEnd = 337054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(Action<Object, T> invokeCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(invokeCallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeDelegate<T>.NativeMethodInfoPtr_Invoke_Protected_Void_Action_2_Object_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600315A RID: 12634 RVA: 0x000F51C0 File Offset: 0x000F33C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 337068, RefRangeEnd = 337069, XrefRangeStart = 337055, XrefRangeEnd = 337068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetCombinedDelegate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeDelegate<T>.NativeMethodInfoPtr_GetCombinedDelegate_Protected_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600315B RID: 12635 RVA: 0x000F51FC File Offset: 0x000F33FC
		[CallerCount(0)]
		public unsafe bool pqUmJgCiRbkfcUyrXIMmpKcRSDB(T A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = A_1;
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
					ptr4 = ref A_1;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeDelegate<T>.NativeMethodInfoPtr_pqUmJgCiRbkfcUyrXIMmpKcRSDB_Private_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600315C RID: 12636 RVA: 0x000F5294 File Offset: 0x000F3494
		[CallerCount(0)]
		public unsafe int toLEPoWuMDQZlYmjvpYldRbMVym(T A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = A_1;
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
					ptr4 = ref A_1;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeDelegate<T>.NativeMethodInfoPtr_toLEPoWuMDQZlYmjvpYldRbMVym_Private_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600315D RID: 12637 RVA: 0x000F532C File Offset: 0x000F352C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337069, XrefRangeEnd = 337081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate GZqQQaGDLliavCqmVrEaVRZoPujR(Object A_0, Delegate A_1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeDelegate<T>.NativeMethodInfoPtr_GZqQQaGDLliavCqmVrEaVRZoPujR_Private_Static_Delegate_Object_Delegate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
		}

		// Token: 0x0600315E RID: 12638 RVA: 0x000F5384 File Offset: 0x000F3584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337081, XrefRangeEnd = 337095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate GZqQQaGDLliavCqmVrEaVRZoPujR(Delegate A_0, Delegate A_1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeDelegate<T>.NativeMethodInfoPtr_GZqQQaGDLliavCqmVrEaVRZoPujR_Private_Static_Delegate_Delegate_Delegate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
		}

		// Token: 0x0600315F RID: 12639 RVA: 0x000F53DC File Offset: 0x000F35DC
		[CallerCount(0)]
		public unsafe static int MCSkDmNKFEwDJPokiDIzuaFUvgG(Delegate A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeDelegate<T>.NativeMethodInfoPtr_MCSkDmNKFEwDJPokiDIzuaFUvgG_Private_Static_Int32_Delegate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003160 RID: 12640 RVA: 0x000F5420 File Offset: 0x000F3620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337095, XrefRangeEnd = 337108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Delegate> SwmgMMcOPQkkbDavZfmBbYsPaFg(Delegate A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeDelegate<T>.NativeMethodInfoPtr_SwmgMMcOPQkkbDavZfmBbYsPaFg_Private_Static_List_1_Delegate_Delegate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Delegate>>(intPtr3) : null;
			}
		}

		// Token: 0x06003161 RID: 12641 RVA: 0x00011B53 File Offset: 0x0000FD53
		public SafeDelegate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F3C RID: 3900
		// (get) Token: 0x06003162 RID: 12642 RVA: 0x000F5464 File Offset: 0x000F3664
		// (set) Token: 0x06003163 RID: 12643 RVA: 0x00011B5C File Offset: 0x0000FD5C
		public unsafe Action<Exception> YQmFurxPQGCzcbiDCAoJoXFxRCn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeDelegate<T>.NativeFieldInfoPtr_YQmFurxPQGCzcbiDCAoJoXFxRCn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Exception>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeDelegate<T>.NativeFieldInfoPtr_YQmFurxPQGCzcbiDCAoJoXFxRCn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F3D RID: 3901
		// (get) Token: 0x06003164 RID: 12644 RVA: 0x000F5494 File Offset: 0x000F3694
		// (set) Token: 0x06003165 RID: 12645 RVA: 0x00011B7B File Offset: 0x0000FD7B
		public unsafe List<SafeDelegate<T>.DbpqkgrOWwxhXrQbffsLlogWHQF> oawLRBBaxebqpNQHfAKiHDclmZJf
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeDelegate<T>.NativeFieldInfoPtr_oawLRBBaxebqpNQHfAKiHDclmZJf);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SafeDelegate<T>.DbpqkgrOWwxhXrQbffsLlogWHQF>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeDelegate<T>.NativeFieldInfoPtr_oawLRBBaxebqpNQHfAKiHDclmZJf), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F3E RID: 3902
		// (get) Token: 0x06003166 RID: 12646 RVA: 0x000F54C4 File Offset: 0x000F36C4
		// (set) Token: 0x06003167 RID: 12647 RVA: 0x00011B9A File Offset: 0x0000FD9A
		public unsafe List<SafeDelegate<T>.DbpqkgrOWwxhXrQbffsLlogWHQF> xrvUXpzFjXHLwyyxZARQvpgcOIZ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeDelegate<T>.NativeFieldInfoPtr_xrvUXpzFjXHLwyyxZARQvpgcOIZ);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SafeDelegate<T>.DbpqkgrOWwxhXrQbffsLlogWHQF>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeDelegate<T>.NativeFieldInfoPtr_xrvUXpzFjXHLwyyxZARQvpgcOIZ), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002A0A RID: 10762
		private static readonly IntPtr NativeFieldInfoPtr_YQmFurxPQGCzcbiDCAoJoXFxRCn;

		// Token: 0x04002A0B RID: 10763
		private static readonly IntPtr NativeFieldInfoPtr_oawLRBBaxebqpNQHfAKiHDclmZJf;

		// Token: 0x04002A0C RID: 10764
		private static readonly IntPtr NativeFieldInfoPtr_xrvUXpzFjXHLwyyxZARQvpgcOIZ;

		// Token: 0x04002A0D RID: 10765
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Internal_Virtual_get_Int32_0;

		// Token: 0x04002A0E RID: 10766
		private static readonly IntPtr NativeMethodInfoPtr_get_ExceptionHandler_Internal_Virtual_get_Action_1_Exception_0;

		// Token: 0x04002A0F RID: 10767
		private static readonly IntPtr NativeMethodInfoPtr_set_ExceptionHandler_Internal_Virtual_set_Void_Action_1_Exception_0;

		// Token: 0x04002A10 RID: 10768
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04002A11 RID: 10769
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Action_1_Exception_0;

		// Token: 0x04002A12 RID: 10770
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SafeDelegate_1_T_0;

		// Token: 0x04002A13 RID: 10771
		private static readonly IntPtr NativeMethodInfoPtr_AddDelegate_Public_Void_T_0;

		// Token: 0x04002A14 RID: 10772
		private static readonly IntPtr NativeMethodInfoPtr_RemoveDelegate_Public_Void_T_0;

		// Token: 0x04002A15 RID: 10773
		private static readonly IntPtr NativeMethodInfoPtr_RemoveDelegateOrAllDelegatesFromAnObject_Internal_Virtual_Void_Object_0;

		// Token: 0x04002A16 RID: 10774
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Internal_Virtual_Void_0;

		// Token: 0x04002A17 RID: 10775
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Protected_Void_Action_2_Object_T_0;

		// Token: 0x04002A18 RID: 10776
		private static readonly IntPtr NativeMethodInfoPtr_GetCombinedDelegate_Protected_T_0;

		// Token: 0x04002A19 RID: 10777
		private static readonly IntPtr NativeMethodInfoPtr_pqUmJgCiRbkfcUyrXIMmpKcRSDB_Private_Boolean_T_0;

		// Token: 0x04002A1A RID: 10778
		private static readonly IntPtr NativeMethodInfoPtr_toLEPoWuMDQZlYmjvpYldRbMVym_Private_Int32_T_0;

		// Token: 0x04002A1B RID: 10779
		private static readonly IntPtr NativeMethodInfoPtr_GZqQQaGDLliavCqmVrEaVRZoPujR_Private_Static_Delegate_Object_Delegate_0;

		// Token: 0x04002A1C RID: 10780
		private static readonly IntPtr NativeMethodInfoPtr_GZqQQaGDLliavCqmVrEaVRZoPujR_Private_Static_Delegate_Delegate_Delegate_0;

		// Token: 0x04002A1D RID: 10781
		private static readonly IntPtr NativeMethodInfoPtr_MCSkDmNKFEwDJPokiDIzuaFUvgG_Private_Static_Int32_Delegate_0;

		// Token: 0x04002A1E RID: 10782
		private static readonly IntPtr NativeMethodInfoPtr_SwmgMMcOPQkkbDavZfmBbYsPaFg_Private_Static_List_1_Delegate_Delegate_0;

		// Token: 0x020003FB RID: 1019
		public class DbpqkgrOWwxhXrQbffsLlogWHQF : Object
		{
			// Token: 0x060050A4 RID: 20644 RVA: 0x0016E818 File Offset: 0x0016CA18
			// Note: this type is marked as 'beforefieldinit'.
			static DbpqkgrOWwxhXrQbffsLlogWHQF()
			{
				Il2CppClassPointerStore<SafeDelegate<T>.DbpqkgrOWwxhXrQbffsLlogWHQF>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SafeDelegate<T>>.NativeClassPtr, "DbpqkgrOWwxhXrQbffsLlogWHQF"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeDelegate<T>.DbpqkgrOWwxhXrQbffsLlogWHQF>.NativeClassPtr);
				SafeDelegate<T>.DbpqkgrOWwxhXrQbffsLlogWHQF.NativeFieldInfoPtr_stwCvNnCIpZXeLIOgxcljidlhMm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeDelegate<T>.DbpqkgrOWwxhXrQbffsLlogWHQF>.NativeClassPtr, "stwCvNnCIpZXeLIOgxcljidlhMm");
				SafeDelegate<T>.DbpqkgrOWwxhXrQbffsLlogWHQF.NativeFieldInfoPtr_QOvYBMumHBTKRswPnUjkbLxwisx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeDelegate<T>.DbpqkgrOWwxhXrQbffsLlogWHQF>.NativeClassPtr, "QOvYBMumHBTKRswPnUjkbLxwisx");
				SafeDelegate<T>.DbpqkgrOWwxhXrQbffsLlogWHQF.NativeFieldInfoPtr_ICyOzcUmdahOdyXiKMSbrBBYSWg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeDelegate<T>.DbpqkgrOWwxhXrQbffsLlogWHQF>.NativeClassPtr, "ICyOzcUmdahOdyXiKMSbrBBYSWg");
				SafeDelegate<T>.DbpqkgrOWwxhXrQbffsLlogWHQF.NativeFieldInfoPtr_VryXnogQAvPjLvGjbEAbjpMGWIZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeDelegate<T>.DbpqkgrOWwxhXrQbffsLlogWHQF>.NativeClassPtr, "VryXnogQAvPjLvGjbEAbjpMGWIZ");
				SafeDelegate<T>.DbpqkgrOWwxhXrQbffsLlogWHQF.NativeMethodInfoPtr__ctor_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeDelegate<T>.DbpqkgrOWwxhXrQbffsLlogWHQF>.NativeClassPtr, 100675824);
				SafeDelegate<T>.DbpqkgrOWwxhXrQbffsLlogWHQF.NativeMethodInfoPtr__ctor_Public_Void_DbpqkgrOWwxhXrQbffsLlogWHQF_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeDelegate<T>.DbpqkgrOWwxhXrQbffsLlogWHQF>.NativeClassPtr, 100675825);
				SafeDelegate<T>.DbpqkgrOWwxhXrQbffsLlogWHQF.NativeMethodInfoPtr_HNjlaOqMZCXPggpTjOTOJakyFHhe_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeDelegate<T>.DbpqkgrOWwxhXrQbffsLlogWHQF>.NativeClassPtr, 100675826);
			}

			// Token: 0x060050A5 RID: 20645 RVA: 0x0016E90C File Offset: 0x0016CB0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336921, XrefRangeEnd = 336933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DbpqkgrOWwxhXrQbffsLlogWHQF(T item)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeDelegate<T>.DbpqkgrOWwxhXrQbffsLlogWHQF>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					IntPtr* ptr2 = ptr;
					ref T ptr4;
					if (!typeof(T).IsValueType)
					{
						T t = item;
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
						ptr4 = ref item;
					}
					*ptr2 = ref ptr4;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeDelegate<T>.DbpqkgrOWwxhXrQbffsLlogWHQF.NativeMethodInfoPtr__ctor_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060050A6 RID: 20646 RVA: 0x0016E9A4 File Offset: 0x0016CBA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336933, XrefRangeEnd = 336952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DbpqkgrOWwxhXrQbffsLlogWHQF(SafeDelegate<T>.DbpqkgrOWwxhXrQbffsLlogWHQF source)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeDelegate<T>.DbpqkgrOWwxhXrQbffsLlogWHQF>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeDelegate<T>.DbpqkgrOWwxhXrQbffsLlogWHQF.NativeMethodInfoPtr__ctor_Public_Void_DbpqkgrOWwxhXrQbffsLlogWHQF_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060050A7 RID: 20647 RVA: 0x0016E9F0 File Offset: 0x0016CBF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336952, XrefRangeEnd = 336953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool HNjlaOqMZCXPggpTjOTOJakyFHhe()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeDelegate<T>.DbpqkgrOWwxhXrQbffsLlogWHQF.NativeMethodInfoPtr_HNjlaOqMZCXPggpTjOTOJakyFHhe_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060050A8 RID: 20648 RVA: 0x0001D57D File Offset: 0x0001B77D
			public DbpqkgrOWwxhXrQbffsLlogWHQF(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170018FA RID: 6394
			// (get) Token: 0x060050A9 RID: 20649 RVA: 0x0016EA2C File Offset: 0x0016CC2C
			// (set) Token: 0x060050AA RID: 20650 RVA: 0x0016EA54 File Offset: 0x0016CC54
			public unsafe T stwCvNnCIpZXeLIOgxcljidlhMm
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeDelegate<T>.DbpqkgrOWwxhXrQbffsLlogWHQF.NativeFieldInfoPtr_stwCvNnCIpZXeLIOgxcljidlhMm);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeDelegate<T>.DbpqkgrOWwxhXrQbffsLlogWHQF.NativeFieldInfoPtr_stwCvNnCIpZXeLIOgxcljidlhMm);
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

			// Token: 0x170018FB RID: 6395
			// (get) Token: 0x060050AB RID: 20651 RVA: 0x0016EAFC File Offset: 0x0016CCFC
			// (set) Token: 0x060050AC RID: 20652 RVA: 0x0001D586 File Offset: 0x0001B786
			public unsafe Object QOvYBMumHBTKRswPnUjkbLxwisx
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeDelegate<T>.DbpqkgrOWwxhXrQbffsLlogWHQF.NativeFieldInfoPtr_QOvYBMumHBTKRswPnUjkbLxwisx);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeDelegate<T>.DbpqkgrOWwxhXrQbffsLlogWHQF.NativeFieldInfoPtr_QOvYBMumHBTKRswPnUjkbLxwisx), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018FC RID: 6396
			// (get) Token: 0x060050AD RID: 20653 RVA: 0x0016EB2C File Offset: 0x0016CD2C
			// (set) Token: 0x060050AE RID: 20654 RVA: 0x0001D5A5 File Offset: 0x0001B7A5
			public unsafe Object ICyOzcUmdahOdyXiKMSbrBBYSWg
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeDelegate<T>.DbpqkgrOWwxhXrQbffsLlogWHQF.NativeFieldInfoPtr_ICyOzcUmdahOdyXiKMSbrBBYSWg);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeDelegate<T>.DbpqkgrOWwxhXrQbffsLlogWHQF.NativeFieldInfoPtr_ICyOzcUmdahOdyXiKMSbrBBYSWg), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018FD RID: 6397
			// (get) Token: 0x060050AF RID: 20655 RVA: 0x0016EB5C File Offset: 0x0016CD5C
			// (set) Token: 0x060050B0 RID: 20656 RVA: 0x0001D5C4 File Offset: 0x0001B7C4
			public unsafe bool VryXnogQAvPjLvGjbEAbjpMGWIZ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeDelegate<T>.DbpqkgrOWwxhXrQbffsLlogWHQF.NativeFieldInfoPtr_VryXnogQAvPjLvGjbEAbjpMGWIZ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeDelegate<T>.DbpqkgrOWwxhXrQbffsLlogWHQF.NativeFieldInfoPtr_VryXnogQAvPjLvGjbEAbjpMGWIZ)) = value;
				}
			}

			// Token: 0x0400432E RID: 17198
			private static readonly IntPtr NativeFieldInfoPtr_stwCvNnCIpZXeLIOgxcljidlhMm;

			// Token: 0x0400432F RID: 17199
			private static readonly IntPtr NativeFieldInfoPtr_QOvYBMumHBTKRswPnUjkbLxwisx;

			// Token: 0x04004330 RID: 17200
			private static readonly IntPtr NativeFieldInfoPtr_ICyOzcUmdahOdyXiKMSbrBBYSWg;

			// Token: 0x04004331 RID: 17201
			private static readonly IntPtr NativeFieldInfoPtr_VryXnogQAvPjLvGjbEAbjpMGWIZ;

			// Token: 0x04004332 RID: 17202
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_T_0;

			// Token: 0x04004333 RID: 17203
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DbpqkgrOWwxhXrQbffsLlogWHQF_T_0;

			// Token: 0x04004334 RID: 17204
			private static readonly IntPtr NativeMethodInfoPtr_HNjlaOqMZCXPggpTjOTOJakyFHhe_Public_Boolean_0;
		}
	}
}
